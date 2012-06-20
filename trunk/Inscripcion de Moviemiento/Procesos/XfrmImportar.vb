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
            Dim myCMD As New OracleCommand()
            Dim mensaje As String
            conn.ConnectionString = oradb
            conn.Open()
            Try
                myCMD.Connection = conn
                myCMD.CommandText = "IM_P_IMPORTAR_SIM"
                myCMD.CommandType = CommandType.StoredProcedure
                myCMD.Parameters.Add(New OracleParameter("pvo_mensaje", OracleType.Char, 100)).Direction = ParameterDirection.Output
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
                    startInfo = New ProcessStartInfo("cmd.exe", "/C imp TSE/oracle@TSEDB2 Buffer=5000000 File=" & TxtRuta.Text & " FROMUSER=TSE TOUSER=TSE ignore=Y TABLES=tmp_im_candidatos, tmp_im_candidatos_repetidos, TMP_IM_MOVIMIENTOS, TMP_IM_REQUISITOS_X_CANDIDATO, tmp_im_ciudadanos_respaldan")
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
            Else                
                Mensajes.MensajeError(mensaje)
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
End Class