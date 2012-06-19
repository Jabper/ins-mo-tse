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
            If RbFirmas.Checked = True Then

                Try
                    Dim startInfo As ProcessStartInfo
                    Dim pStart As New Process
                    startInfo = New ProcessStartInfo("cmd.exe", "/C imp TSE/oracle@TSEDB2 Buffer=5000000 File=" & TxtRuta.Text & " FROMUSER=TSE TOUSER=TSE ignore=Y TABLES=tmp_im_ciudadanos_respaldan")
                    pStart.StartInfo = startInfo
                    pStart.Start()
                    pStart.WaitForExit()
                    If pStart.ExitCode = 0 Then
                        MsgBox("La Importación de Firmas ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                        TxtRuta.Text = Nothing
                    Else
                        MsgBox("La Importación de Firmas No se ha realizado Correctamente verifique el archivo de origen de los datos", MsgBoxStyle.Exclamation)
                    End If
                Catch ex As Exception
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try

            End If
            If RbPlanillas.Checked = True Then                
                Try
                    Dim startInfo As ProcessStartInfo
                    Dim pStart As New Process
                    startInfo = New ProcessStartInfo("cmd.exe", "/C imp TSE/oracle@TSEDB2 Buffer=5000000 File=" & TxtRuta.Text & " FROMUSER=TSE TOUSER=TSE ignore=Y TABLES=tmp_im_candidatos,tmp_im_candidatos_repetidos,tmp_im_imagenes_candidato")
                    pStart.StartInfo = startInfo
                    pStart.Start()
                    pStart.WaitForExit()
                    If pStart.ExitCode = 0 Then
                        MsgBox("La Importación de Planillas ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                        TxtRuta.Text = Nothing
                    Else
                        MsgBox("La Importación de Planillas No se ha realizado Correctamente verifique el archivo de origen de los datos", MsgBoxStyle.Exclamation)
                    End If
                Catch ex As Exception
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try
            End If
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TxtRuta.Text = OpenFileDialog1.FileName
    End Sub
End Class