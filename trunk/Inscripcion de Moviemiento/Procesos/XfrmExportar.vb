Imports System.Data.OracleClient
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
                Try
                    Dim startInfo As ProcessStartInfo
                    Dim pStart As New Process
                    startInfo = New ProcessStartInfo("cmd.exe", "/C exp TSE/TSEORACLE2012@XE Buffer=5000000 File=" & TxtRuta.Text & "\Firmas_y_Planilla.dmp log=" & TxtRuta.Text & "\errores.log direct=Y Consistent=Y Rows=Y compress=N TABLES=tmp_im_candidatos, TMP_IM_MOVIMIENTOS, TMP_IM_REQUISITOS_X_CANDIDATO, tmp_im_ciudadanos_respaldan, tmp_im_parametros_generales, tmp_im_imagenes_firmas")
                    pStart.StartInfo = startInfo
                    pStart.Start()
                    pStart.WaitForExit()
                    If pStart.ExitCode = 3 Then
                        MsgBox("La Exportación ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                    Else
                        MsgBox("La Exportación No se ha realizado Correctamente", MsgBoxStyle.Exclamation)
                    End If
                Catch ex As Exception
                    conn.Close()
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try

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