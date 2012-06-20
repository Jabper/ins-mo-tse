Imports System.Data.OracleClient

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
            Dim oradb As String = Configuracion.verconfig
            Dim conn As New OracleConnection()
            Dim myCMD As New OracleCommand()
            Dim mensaje As String
            conn.ConnectionString = oradb
            conn.Open()
            Try
                myCMD.Connection = conn
                myCMD.CommandText = "IM_K_SUBIR_RESPALDO.IM_P_DESHABILITA_CONSTRAINTS"
                myCMD.CommandType = CommandType.StoredProcedure
                myCMD.Parameters.Add(New OracleParameter("PVO_Error", OracleType.Char, 200)).Direction = ParameterDirection.Output
                myCMD.ExecuteOracleScalar()
                mensaje = myCMD.Parameters("PVO_Error").Value
            Catch ex As Exception
                conn.Close()
                Mensajes.MensajeError(ex.Message)
                Exit Sub
            End Try
            conn.Close()

            Dim oradb1 As String = Configuracion.verconfig
            Dim conn1 As New OracleConnection()
            Dim myCMD1 As New OracleCommand()
            conn1.ConnectionString = oradb1
            conn1.Open()
            If Trim(mensaje) = "OK" Then
                Try
                    mensaje = "Error"
                    myCMD1.Connection = conn1
                    myCMD1.CommandText = "IM_K_SUBIR_RESPALDO.IM_P_BORRA_TABLAS"
                    myCMD1.CommandType = CommandType.StoredProcedure
                    myCMD1.Parameters.Add(New OracleParameter("PVO_Error", OracleType.Char, 200)).Direction = ParameterDirection.Output
                    myCMD1.ExecuteOracleScalar()
                    mensaje = myCMD1.Parameters("PVO_Error").Value
                Catch ex As Exception
                    conn1.Close()
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try
            End If
            conn1.Close()

            If Trim(mensaje) = "OK" Then
                Try
                    mensaje = "Error"
                    Dim startInfo As ProcessStartInfo
                    Dim pStart As New Process
                    startInfo = New ProcessStartInfo("cmd.exe", "/C imp TSE/oracle@TSEDB2 Buffer=5000000 File=" & TxtRuta.Text & " FROMUSER=TSE TOUSER=TSE ignore=Y")
                    pStart.StartInfo = startInfo
                    pStart.Start()
                    pStart.WaitForExit()
                    If pStart.ExitCode = 3 Then
                        mensaje = "OK"
                    Else
                        MsgBox("La Importación No se ha realizado Correctamente verifique el archivo de origen de los datos", MsgBoxStyle.Exclamation)
                        mensaje = "Error"
                    End If
                Catch ex As Exception
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try
            End If

            Dim oradb2 As String = Configuracion.verconfig
            Dim conn2 As New OracleConnection()
            Dim myCMD2 As New OracleCommand()
            conn2.ConnectionString = oradb2
            conn2.Open()
            If Trim(mensaje) = "OK" Then
                Try
                    mensaje = "Error"
                    myCMD2.Connection = conn2
                    myCMD2.CommandText = "IM_K_SUBIR_RESPALDO.IM_P_HABILITA_CONSTRAINTS"
                    myCMD2.CommandType = CommandType.StoredProcedure
                    myCMD2.Parameters.Add(New OracleParameter("PVO_Error", OracleType.Char, 200)).Direction = ParameterDirection.Output
                    myCMD2.ExecuteOracleScalar()
                    mensaje = myCMD2.Parameters("PVO_Error").Value
                Catch ex As Exception
                    conn2.Close()
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try
            End If
            conn2.Close()

            Dim oradb3 As String = Configuracion.verconfig
            Dim conn3 As New OracleConnection()
            Dim myCMD3 As New OracleCommand()
            conn3.ConnectionString = oradb3
            conn3.Open()            
            If Trim(mensaje) = "OK" Then
                Try
                    mensaje = "Error"
                    myCMD3.Connection = conn3
                    myCMD3.CommandText = "IM_K_SUBIR_RESPALDO.IM_P_COMPILA_OBJETOS"
                    myCMD3.CommandType = CommandType.StoredProcedure
                    myCMD3.Parameters.Add(New OracleParameter("PVO_Error", OracleType.Char, 200)).Direction = ParameterDirection.Output
                    myCMD3.ExecuteOracleScalar()
                    mensaje = myCMD3.Parameters("PVO_Error").Value
                Catch ex As Exception
                    conn3.Close()
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try
            End If
            If Trim(mensaje) = "OK" Then
                MsgBox("La Importación ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                TxtRuta.Text = Nothing
            Else
                MsgBox("Error: " & mensaje, MsgBoxStyle.Information)
            End If
            conn3.Close()
            End If
    End Sub
End Class