Imports System.Data.OracleClient
Imports System.IO

Public Class XfrmSubirRespaldo
    Dim archivo As String
    Private Sub BtnExplorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExplorar.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TxtRuta.Text = OpenFileDialog1.FileName
        archivo = OpenFileDialog1.SafeFileName
    End Sub

    Private Sub BtnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEjecutar.Click
        ImportarDatos()
    End Sub

    Private Sub ImportarDatos()
        If TxtRuta.Text = Nothing Then
            Mensajes.MensajeError("Debe seleccionar una ruta para la ubicación del archivo a Importar")
        Else
            'Dim oradb As String = Configuracion.verconfig
            'Dim conn As New OracleConnection()
            'Dim myCMD As New OracleCommand()
            Dim mensaje As String
            'conn.ConnectionString = oradb
            'conn.Open()
            'Try
            '    myCMD.Connection = conn
            '    myCMD.CommandText = "IM_K_SUBIR_RESPALDO.IM_P_DESHABILITA_CONSTRAINTS"
            '    myCMD.CommandType = CommandType.StoredProcedure
            '    myCMD.Parameters.Add(New OracleParameter("PVO_Error", OracleType.Char, 200)).Direction = ParameterDirection.Output
            '    myCMD.ExecuteOracleScalar()
            '    mensaje = myCMD.Parameters("PVO_Error").Value
            'Catch ex As Exception
            '    conn.Close()
            '    Mensajes.MensajeError(ex.Message)
            '    Exit Sub
            'End Try
            'conn.Close()

            'Dim oradb1 As String = Configuracion.verconfig
            'Dim conn1 As New OracleConnection()
            'Dim myCMD1 As New OracleCommand()
            'conn1.ConnectionString = oradb1
            'conn1.Open()
            'If Trim(mensaje) = "OK" Then
            '    Try
            '        mensaje = "Error"
            '        myCMD1.Connection = conn1
            '        myCMD1.CommandText = "IM_K_SUBIR_RESPALDO.IM_P_BORRA_TABLAS"
            '        myCMD1.CommandType = CommandType.StoredProcedure
            '        myCMD1.Parameters.Add(New OracleParameter("PVO_Error", OracleType.Char, 200)).Direction = ParameterDirection.Output
            '        myCMD1.ExecuteOracleScalar()
            '        mensaje = myCMD1.Parameters("PVO_Error").Value
            '    Catch ex As Exception
            '        conn1.Close()
            '        Mensajes.MensajeError(ex.Message)
            '        Exit Sub
            '    End Try
            'End If
            'conn1.Close()
            mensaje = "OK"
            If Trim(mensaje) = "OK" Then
                If File.Exists("C:\oraclexe\app\oracle\admin\XE\dpdump\" & archivo) Then
                    Try
                        System.IO.File.Delete("C:\oraclexe\app\oracle\admin\XE\dpdump\" & archivo)
                        System.IO.File.Copy(TxtRuta.Text, "C:\oraclexe\app\oracle\admin\XE\dpdump\" & archivo, True)
                    Catch ex As Exception
                        MsgBox("Error al copiar el archivo DMP")
                    End Try
                Else
                    Try
                        System.IO.File.Copy(TxtRuta.Text, "C:\oraclexe\app\oracle\admin\XE\dpdump\" & archivo, True)
                    Catch ex As Exception
                        MsgBox("Error al copiar el archivo DMP")
                    End Try
                End If

                'Try
                '    mensaje = "Error"
                '    Dim startInfo As ProcessStartInfo
                '    Dim pStart As New Process
                '    IO.File.WriteAllText("c:\Windows\Temp\Borrar_usuario.sql", My.Resources.borrar_usuario)
                '    Dim parametro As String = "/C C:\oraclexe\app\oracle\product\10.2.0\server\BIN\SQLPLUS / AS SYSDBA @c:\Windows\Temp\Borrar_usuario.sql"
                '    'MsgBox(parametro)
                '    startInfo = New ProcessStartInfo("cmd.exe", parametro)
                '    'imp TSE/TSEORACLE2012@XE Buffer=5000000 File=" & TxtRuta.Text & " FROMUSER=TSE TOUSER=TSE ignore=Y")
                '    pStart.StartInfo = startInfo
                '    pStart.Start()
                '    pStart.WaitForExit()
                '    If pStart.ExitCode = 0 Then
                '        mensaje = "OK"
                '    Else
                '        MsgBox("La Importación No se ha realizado Correctamente verifique el archivo de origen de los datos", MsgBoxStyle.Exclamation)
                '        mensaje = "Error"
                '    End If
                'Catch ex As Exception
                '    Mensajes.MensajeError(ex.Message)
                '    Exit Sub
                'End Try                

                If Trim(mensaje) = "OK" Then
                    Try
                        mensaje = "Error"
                        Dim startInfo As ProcessStartInfo
                        Dim pStart As New Process
                        startInfo = New ProcessStartInfo("cmd.exe", "/C impdp TSE/TSEORACLE2012@XE DUMPFILE=" & archivo & " LOGFILE=imp_Respaldo.log DIRECTORY=DATA_PUMP_DIR CONTENT=ALL TABLE_EXISTS_ACTION=REPLACE")
                        'imp TSE/TSEORACLE2012@XE Buffer=5000000 File=" & TxtRuta.Text & " FROMUSER=TSE TOUSER=TSE ignore=Y")
                        pStart.StartInfo = startInfo
                        pStart.Start()
                        pStart.WaitForExit()
                        If pStart.ExitCode = 0 Then
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
            End If

            Dim oradb As String = Configuracion.verconfig
            Dim conn1 As New OracleConnection()
            Dim myCMD As New OracleCommand()
            conn1.ConnectionString = oradb
            conn1.Open()
            Try
                myCMD.Connection = conn1
                myCMD.CommandText = "alter PACKAGE im_k_subir_respaldo compile;"
                myCMD.CommandType = CommandType.Text
                myCMD.ExecuteOracleScalar()               
            Catch ex As Exception
                conn1.Close()
                'waitDialog.Caption = "finalizando..."
                'waitDialog.Close()
                Mensajes.MensajeError(ex.Message)               
            End Try
            conn1.Close()

            Dim oradb5 As String = Configuracion.verconfig
            Dim conn5 As New OracleConnection()
            Dim myCMD5 As New OracleCommand()
            conn5.ConnectionString = oradb5
            conn5.Open()
            Try
                myCMD5.Connection = conn5
                myCMD5.CommandText = "alter package im_k_subir_respaldo compile body;"
                myCMD5.CommandType = CommandType.Text
                myCMD5.ExecuteOracleScalar()
            Catch ex As Exception
                conn5.Close()
                'waitDialog.Caption = "finalizando..."
                'waitDialog.Close()
                Mensajes.MensajeError(ex.Message)
            End Try
            conn5.Close()

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

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class