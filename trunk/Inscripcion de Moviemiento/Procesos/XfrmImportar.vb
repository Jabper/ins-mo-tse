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
                    conn.Close()

                    Dim startInfo As ProcessStartInfo
                    Dim pStart As New Process
                    startInfo = New ProcessStartInfo("cmd.exe", "/C imp TSE/oracle@TSEDB2 Buffer=5000000 File=" & TxtRuta.Text & " FROMUSER=TSE TOUSER=TSE ignore=Y TABLES=tmp_im_candidatos, TMP_IM_MOVIMIENTOS, TMP_IM_REQUISITOS_X_CANDIDATO, tmp_im_ciudadanos_respaldan")
                    pStart.StartInfo = startInfo
                    pStart.Start()
                    pStart.WaitForExit()
                    If pStart.ExitCode = 0 Then
                        MsgBox("La Importación ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                        TxtRuta.Text = Nothing
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
                    conn.Close()
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
End Class