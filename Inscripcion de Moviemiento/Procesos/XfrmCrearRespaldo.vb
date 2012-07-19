Imports System.Data.OracleClient
Imports System.IO

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
            If File.Exists("C:\oraclexe\app\oracle\admin\XE\dpdump\Respaldo.dmp") Then
                Try
                    System.IO.File.Delete("C:\oraclexe\app\oracle\admin\XE\dpdump\Respaldo.dmp")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            Try
                Dim startInfo As ProcessStartInfo
                Dim pStart As New Process
                startInfo = New ProcessStartInfo("cmd.exe", "/C expdp TSE/TSEORACLE2012@XE SCHEMAS=TSE version=10 DUMPFILE=Respaldo.dmp LOGFILE=exp_Respaldo.log DIRECTORY=DATA_PUMP_DIR")
                pStart.StartInfo = startInfo
                pStart.Start()
                pStart.WaitForExit()
                If pStart.ExitCode = 0 Then
                    If File.Exists("C:\oraclexe\app\oracle\admin\XE\dpdump\Respaldo.dmp") Then
                        Try
                            System.IO.File.Copy("C:\oraclexe\app\oracle\admin\XE\dpdump\Respaldo.dmp", TxtRuta.Text & "\Respaldo.dmp", True)
                            MsgBox("El Respaldo ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                        Catch ex As Exception
                            MsgBox("El Respaldo No se ha realizado Correctamente", MsgBoxStyle.Exclamation)
                        End Try
                    End If
                Else
                    MsgBox("El Respaldo No se ha realizado Correctamente", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                Mensajes.MensajeError(ex.Message)
                Exit Sub
            End Try            
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub XfrmCrearRespaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class