Imports System.Data.OracleClient
Imports System.IO

Public Class XfrmExportar
    Private Sub BtnExplorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExplorar.Click
        FbUbicacion.ShowDialog()
        TxtRuta.Text = FbUbicacion.SelectedPath
    End Sub

    Private Sub BtnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEjecutar.Click
        ExportarDatos()
    End Sub

    Private Sub ExportarDatos()
        If TxtRuta.Text = Nothing Then
            Mensajes.MensajeError("Debe seleccionar una ruta para la ubicación del archivo de exportación")
        Else
            Dim oradb As String = Configuracion.verconfig
            Dim conn As New OracleConnection()
            Dim myCMD As New OracleCommand()
            Dim mensaje As String
            conn.ConnectionString = oradb
            conn.Open()
            Try
                myCMD.Connection = conn
                myCMD.CommandText = "IM_P_EXPORTAR_SIM"
                myCMD.CommandType = CommandType.StoredProcedure
                myCMD.Parameters.Add(New OracleParameter("pvo_mensaje", OracleType.Char, 1000)).Direction = ParameterDirection.Output
                myCMD.ExecuteOracleScalar()
                mensaje = myCMD.Parameters("pvo_mensaje").Value
            Catch ex As Exception
                conn.Close()
                Mensajes.MensajeError(ex.Message)
                Exit Sub
            End Try
            conn.Close()

            If Trim(mensaje) = "OK" Then

                Dim oradb8 As String = Configuracion.verconfig
                Dim conn8 As New OracleConnection()
                conn8.ConnectionString = oradb8
                conn8.Open()
                Dim dpdump As String

                Dim sql8 As String = "select directory_path from dba_directories where directory_name = 'DATA_PUMP_DIR'"
                Dim cmd8 As New OracleCommand(sql8, conn8)
                cmd8.CommandType = CommandType.Text
                Dim chek8 As OracleDataReader = cmd8.ExecuteReader()
                If chek8.Read Then
                    dpdump = chek8.Item("directory_path")
                End If
                conn8.Close()

                If File.Exists(dpdump & "Firmas_y_Planilla.dmp") Then
                    Try
                        System.IO.File.Delete(dpdump & "Firmas_y_Planilla.dmp")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If

                Try
                    Dim startInfo As ProcessStartInfo
                    Dim pStart As New Process
                    startInfo = New ProcessStartInfo("cmd.exe", "/C expdp TSE/TSEORACLE2012@XE directory=data_pump_dir dumpfile=Firmas_y_Planilla.dmp LOGFILE=firmas_y_planilla.log TABLES=('TMP_IM_CANDIDATOS', 'TMP_IM_CIUDADANOS_RESPALDAN', 'TMP_IM_IMAGENES_FIRMAS', 'TMP_IM_MOVIMIENTOS', 'TMP_IM_PARAMETROS_GENERALES', 'TMP_IM_REQUISITOS_X_CANDIDATO')")
                    'exp TSE/oracle@tsedb2 Buffer=5000000 File=" & TxtRuta.Text & "\Firmas_y_Planilla.dmp log=" & TxtRuta.Text & "\errores.log direct=Y Consistent=Y Rows=Y compress=N TABLES=tmp_im_candidatos, TMP_IM_MOVIMIENTOS, TMP_IM_REQUISITOS_X_CANDIDATO, tmp_im_ciudadanos_respaldan, tmp_im_parametros_generales, tmp_im_imagenes_firmas")
                    'Me.TextEdit1.Text = "/C exp TSE/oracle@tsedb2 Buffer=5000000 File=" & TxtRuta.Text & "\Firmas_y_Planilla.dmp log=" & TxtRuta.Text & "\errores.log direct=Y Consistent=Y Rows=Y compress=N TABLES=tmp_im_candidatos, TMP_IM_MOVIMIENTOS, TMP_IM_REQUISITOS_X_CANDIDATO, tmp_im_ciudadanos_respaldan, tmp_im_parametros_generales, tmp_im_imagenes_firmas"
                    pStart.StartInfo = startInfo
                    pStart.Start()
                    pStart.WaitForExit()
                    If pStart.ExitCode = 0 Then
                        MsgBox("La Exportación ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                    Else
                        MsgBox("La Exportación No se ha realizado Correctamente", MsgBoxStyle.Exclamation)
                    End If
                Catch ex As Exception
                    conn.Close()
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try

                If File.Exists(dpdump & "Firmas_y_Planilla.dmp") Then
                    System.IO.File.Copy(dpdump & "Firmas_y_Planilla.dmp", TxtRuta.Text & "\Firmas_y_Planilla.dmp", True)
                End If

                Dim oradb1 As String = Configuracion.verconfig
                Dim conn1 As New OracleConnection()
                Dim myCMD1 As New OracleCommand()
                Dim mensaje1 As String
                conn1.ConnectionString = oradb1
                conn1.Open()
                Try
                    myCMD1.Connection = conn1
                    myCMD1.CommandText = "IM_P_BORRAR_TABLAS_EXPORTADAS"
                    myCMD1.CommandType = CommandType.StoredProcedure
                    myCMD1.Parameters.Add(New OracleParameter("pvo_mensaje", OracleType.Char, 100)).Direction = ParameterDirection.Output
                    myCMD1.ExecuteOracleScalar()
                    mensaje1 = myCMD1.Parameters("pvo_mensaje").Value
                Catch ex As Exception
                    conn.Close()
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try
                conn.Close()
            Else
                Mensajes.MensajeError(mensaje)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class