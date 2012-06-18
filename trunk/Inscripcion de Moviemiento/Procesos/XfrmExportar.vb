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
            If ChkFirmas.Checked = True Then
                Dim oradb As String = Configuracion.verconfig                
                Dim conn As New OracleConnection()
                Dim myCMD As New OracleCommand()
                Dim mensaje As String
                conn.ConnectionString = oradb
                conn.Open()
                Try
                    myCMD.Connection = conn
                    myCMD.CommandText = "IM_P_EXPORTAR_FIRMAS_SIM"
                    myCMD.CommandType = CommandType.StoredProcedure
                    myCMD.Parameters.Add(New OracleParameter("pvo_mensaje", OracleType.Char, 100)).Direction = ParameterDirection.Output
                    myCMD.ExecuteOracleScalar()
                    mensaje = myCMD.Parameters("pvo_mensaje").Value
                Catch ex As Exception
                    conn.Close()
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try

                If Trim(mensaje) = "OK" Then
                    Try
                        Dim startInfo As ProcessStartInfo
                        Dim pStart As New Process
                        startInfo = New ProcessStartInfo("cmd.exe", "/C exp TSE/oracle@XE Buffer=5000000 File=" & TxtRuta.Text & "\Firmas.dmp direct=Y Consistent=Y Rows=Y compress=N TABLES=tmp_im_ciudadanos_respaldan")
                        pStart.StartInfo = startInfo
                        pStart.Start()
                        pStart.WaitForExit()                        
                        If pStart.ExitCode = 0 Then
                            MsgBox("La Exportación de Firmas ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                        Else
                            MsgBox("La Exportación de Firmas No se ha realizado Correctamente", MsgBoxStyle.Exclamation)
                        End If
                    Catch ex As Exception
                        conn.Close()
                        Mensajes.MensajeError(ex.Message)
                        Exit Sub
                    End Try
                Else
                    conn.Close()
                    Mensajes.MensajeError(mensaje)
                    Exit Sub
                End If
                conn.Close()
            End If
            If ChkPlanillas.Checked = True Then
                Dim oradb As String = Configuracion.verconfig                
                Dim conn As New OracleConnection()
                Dim myCMD As New OracleCommand()
                Dim mensaje As String
                conn.ConnectionString = oradb
                conn.Open()
                Try
                    myCMD.Connection = conn
                    myCMD.CommandText = "IM_P_EXPORTAR_PLANILLA_SIM"
                    myCMD.CommandType = CommandType.StoredProcedure
                    myCMD.Parameters.Add(New OracleParameter("pvo_mensaje", OracleType.Char, 100)).Direction = ParameterDirection.Output
                    myCMD.ExecuteOracleScalar()

                    mensaje = myCMD.Parameters("pvo_mensaje").Value
                Catch ex As Exception
                    conn.Close()
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try

                If Trim(mensaje) = "OK" Then
                    Try
                        Dim startInfo As ProcessStartInfo
                        Dim pStart As New Process
                        startInfo = New ProcessStartInfo("cmd.exe", "/C exp TSE/oracle@XE Buffer=5000000 File=" & TxtRuta.Text & "\Planilla.dmp direct=Y Consistent=Y Rows=Y compress=N TABLES=tmp_im_candidatos,tmp_im_candidatos_repetidos,tmp_im_imagenes_candidato")
                        pStart.StartInfo = startInfo
                        pStart.Start()
                        pStart.WaitForExit()                                            
                        If pStart.ExitCode = 0 Then
                            MsgBox("La Exportación de Planillas ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                        Else
                            MsgBox("La Exportación de Planillas No se ha realizado Correctamente", MsgBoxStyle.Exclamation)
                        End If
                    Catch ex As Exception
                        conn.Close()
                        Mensajes.MensajeError(ex.Message)
                        Exit Sub
                    End Try
                Else
                    Mensajes.MensajeError(mensaje)
                    conn.Close()
                    Exit Sub
                End If
                conn.Close()
            End If
        End If
    End Sub
End Class