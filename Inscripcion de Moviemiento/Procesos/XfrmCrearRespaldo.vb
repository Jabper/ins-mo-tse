Imports System.Data.OracleClient

Public Class XfrmCrearRespaldo

    Private Sub BtnExplorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExplorar.Click
        FbUbicacion.ShowDialog()
        TxtRuta.Text = FbUbicacion.SelectedPath
    End Sub

    Private Sub BtnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEjecutar.Click
        CrearRespaldo()
    End Sub

    Private Sub CrearRespaldo()
        If TxtRuta.Text = Nothing Then
            Mensajes.MensajeError("Debe seleccionar una ruta para la ubicación del archivo de exportación")
        Else                      

            Try
                Dim startInfo As ProcessStartInfo
                Dim pStart As New Process
                startInfo = New ProcessStartInfo("cmd.exe", "/C exp TSE/oracle@TSEDB2 Buffer=5000000 File=" & TxtRuta.Text & "\Respaldo.dmp direct=Y Consistent=Y Rows=Y compress=N")
                pStart.StartInfo = startInfo
                pStart.Start()
                pStart.WaitForExit()
                If pStart.ExitCode = 3 Then
                    MsgBox("El Respaldo ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MsgBox("El Respaldo No se ha realizado Correctamente", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
                Exit Sub
            End Try                        
        End If
    End Sub
End Class