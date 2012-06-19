Public Class XfrmSubirRespaldo 

    Private Sub BtnExplorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExplorar.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TxtRuta.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub BtnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEjecutar.Click
        ImportarDatos()
    End Sub

    Private Sub ImportarDatos()
        If TxtRuta.Text = Nothing Then
            Mensajes.MensajeError("Debe seleccionar una ruta para la ubicación del archivo a Importar")
        Else
            Try
                Dim startInfo As ProcessStartInfo
                Dim pStart As New Process
                startInfo = New ProcessStartInfo("cmd.exe", "/C imp TSE/oracle Buffer=5000000 File=" & TxtRuta.Text & " FROMUSER=TSE TOUSER=TSE ignore=Y")
                pStart.StartInfo = startInfo
                pStart.Start()
                pStart.WaitForExit()
                If pStart.ExitCode = 0 Then
                    MsgBox("La Importación ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                    TxtRuta.Text = Nothing
                Else
                    MsgBox("La Importación No se ha realizado Correctamente verifique el archivo de origen de los datos", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
                Exit Sub
            End Try
        End If
    End Sub
End Class