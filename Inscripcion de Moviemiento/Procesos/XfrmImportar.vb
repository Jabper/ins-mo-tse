Imports System.Data.OracleClient

Public Class XfrmImportar

    Private Sub BtnExplorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExplorar.Click
        OpenFileDialog1.ShowDialog()        
    End Sub

    Private Sub BtnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEjecutar.Click
        ImportarDatos()
    End Sub

    Private Sub ImportarDatos()
        If TxtRuta.Text = Nothing Then
            Mensajes.MensajeError("Debe seleccionar una ruta para la ubicación del archivo a Importar")
        Else
            Dim oradb As String = Configuracion.verconfig
            Dim conn As New OracleConnection()
            'Dim myCMD As New OracleCommand()
            'Dim mensaje As String
            conn.ConnectionString = oradb
            conn.Open()

            Dim sql As String = "select proceso_en_ejecucion from im_parametros_generales"
            Dim cmd As New OracleCommand(sql, conn)
            cmd.CommandType = CommandType.Text
            Dim chek As OracleDataReader = cmd.ExecuteReader()
            Dim proceso_corriendo As String
            If chek.Read Then
                proceso_corriendo = chek.Item("proceso_en_ejecucion")
            End If           
            conn.Close()

            If proceso_corriendo = "N" Then
                Try
                    Dim oradb1 As String = Configuracion.verconfig
                    Dim conn1 As New OracleConnection()
                    'Dim myCMD As New OracleCommand()
                    'Dim mensaje As String
                    conn1.ConnectionString = oradb1
                    conn1.Open()

                    Dim sql1 As String = "Update im_parametros_generales set proceso_en_ejecucion = 'S'"
                    Dim cmd1 As New OracleCommand(sql1, conn1)
                    cmd1.CommandType = CommandType.Text
                    cmd1.ExecuteScalar()
                    conn1.Close()

                    Dim startInfo As ProcessStartInfo
                    Dim pStart As New Process
                    startInfo = New ProcessStartInfo("cmd.exe", "/C imp TSE/oracle@TSEDB2 Buffer=5000000 File=" & TxtRuta.Text & " FROMUSER=TSE TOUSER=TSE ignore=Y TABLES=tmp_im_candidatos, TMP_IM_MOVIMIENTOS, TMP_IM_REQUISITOS_X_CANDIDATO, tmp_im_ciudadanos_respaldan, tmp_im_imagenes_firmas, tmp_im_parametros_generales")
                    pStart.StartInfo = startInfo
                    pStart.Start()
                    pStart.WaitForExit()
                    If pStart.ExitCode = 0 Then
                        MsgBox("La Importación ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                        TxtRuta.Text = Nothing

                        'validar datos
                        Dim conn7 As New OracleConnection()
                        Try
                            MsgBox("A continuación se ejecutarán los procesos de validación sobre los datos importados")
                            Dim oradb7 As String = Configuracion.verconfig
                            'Dim conn7 As New OracleConnection()
                            conn7.ConnectionString = oradb7
                            conn7.Open()
                            Dim myCMD7 As New OracleCommand()
                            myCMD7.Connection = conn7
                            myCMD7.CommandText = "IM_P_EJECUTAR_VALIDACIONES"
                            myCMD7.CommandType = CommandType.StoredProcedure
                            myCMD7.Parameters.Add(New OracleParameter("PVO_ERRORES", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
                            myCMD7.ExecuteOracleScalar()
                            If IsDBNull(myCMD7.Parameters("PVO_ERRORES").Value) Then
                                Mensajes.mimensaje("Proceso de validación de Planilla terminado Exitosamente")
                            Else
                                Mensajes.MensajeError(myCMD7.Parameters("PVO_ERRORES").Value)
                            End If
                            conn7.Close()
                        Catch ex As Exception
                            conn7.close()
                            Mensajes.MensajeError(ex.Message)
                        End Try

                        Dim conn8 As New OracleConnection()
                        Try
                            Dim oradb7 As String = Configuracion.verconfig

                            conn8.ConnectionString = oradb7
                            conn8.Open()
                            Dim myCMD7 As New OracleCommand()
                            myCMD7.Connection = conn8
                            myCMD7.CommandText = "IM_K_CARGA_DATOS.IM_P_VALIDA_FIRMA"
                            myCMD7.CommandType = CommandType.StoredProcedure
                            myCMD7.Parameters.Add(New OracleParameter("P_ERROR", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
                            myCMD7.ExecuteOracleScalar()

                            If IsDBNull(myCMD7.Parameters("P_ERROR").Value) Then
                                Mensajes.mimensaje("Proceso de validación de Firmas terminado Exitosamente")
                            Else
                                Mensajes.MensajeError(myCMD7.Parameters("P_ERROR").Value)
                            End If
                            conn8.Close()
                        Catch ex As Exception                            
                            conn8.Close()
                            Mensajes.MensajeError(ex.Message)
                        End Try
                    Else
                        MsgBox("La Importación No se ha realizado Correctamente verifique el archivo de origen de los datos", MsgBoxStyle.Exclamation)
                    End If

                    Dim oradb2 As String = Configuracion.verconfig
                    Dim conn2 As New OracleConnection()                    
                    conn2.ConnectionString = oradb2
                    conn2.Open()

                    Dim sql2 As String = "Update im_parametros_generales set proceso_en_ejecucion = 'N'"
                    Dim cmd2 As New OracleCommand(sql2, conn2)
                    cmd2.CommandType = CommandType.Text
                    cmd2.ExecuteScalar()
                    conn2.Close()
                Catch ex As Exception
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try
            Else
                Mensajes.MensajeError("Actualmente se encuentra corriendo un proceso... Favor esperar a que el proceso actual Termine")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TxtRuta.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub XfrmImportar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim oradb2 As String = Configuracion.verconfig
        Dim conn2 As New OracleConnection()
        conn2.ConnectionString = oradb2
        conn2.Open()

        Dim sql2 As String = "Update im_parametros_generales set proceso_en_ejecucion = 'N'"
        Dim cmd2 As New OracleCommand(sql2, conn2)
        cmd2.CommandType = CommandType.Text
        cmd2.ExecuteScalar()
        conn2.Close()
    End Sub

    Private Sub XfrmImportar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
    End Sub
End Class