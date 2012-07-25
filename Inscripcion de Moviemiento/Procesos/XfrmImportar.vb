Imports System.Data.OracleClient
Imports System.IO

Public Class XfrmImportar
    Dim archivo As String
    Dim path As String
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
            Dim fi As New FileInfo(path)

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
                Dim oradb8 As String = Configuracion.verconfig
                Dim conn8 As New OracleConnection()
                conn8.ConnectionString = oradb8
                conn8.Open()
                Dim dpdump As String

                Dim sql8 As String = "select directory_path from dba_directories where directory_name = 'DATA_PUMP_DIR'"
                Dim cmd8 As New OracleCommand(sql8, conn8)
                cmd8.CommandType = CommandType.Text
                Dim chek8 As OracleDataReader = cmd8.ExecuteReader()
                If chek8.Read Then
                    dpdump = chek8.Item("directory_path")
                End If
                conn8.Close()

                If File.Exists(dpdump & archivo) Then
                    System.IO.File.Delete(dpdump & archivo)
                    System.IO.File.Copy(TxtRuta.Text, dpdump & archivo, True)
                Else
                    System.IO.File.Copy(TxtRuta.Text, dpdump & archivo, True)
                End If
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
                    startInfo = New ProcessStartInfo("cmd.exe", "/C impdp TSE/ORACLE@TSEDB2 directory=data_pump_dir dumpfile=" & archivo & " LOGFILE=imp_firmas_y_planilla.log TABLE_EXISTS_ACTION=REPLACE")
                    'imp TSE/TSEORACLE2012@XE Buffer=5000000 File=" & TxtRuta.Text & " FROMUSER=TSE TOUSER=TSE ignore=Y TABLES=tmp_im_candidatos, TMP_IM_MOVIMIENTOS, TMP_IM_REQUISITOS_X_CANDIDATO, tmp_im_ciudadanos_respaldan, tmp_im_imagenes_firmas, tmp_im_parametros_generales")
                    pStart.StartInfo = startInfo
                    pStart.Start()
                    pStart.WaitForExit()
                    If pStart.ExitCode = 0 Then
                        'MsgBox("La Importación ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                        TxtRuta.Text = Nothing

                        'validar datos
                        Dim conn7 As New OracleConnection()
                        Try
                            MsgBox("A continuación se ejecutarán los procesos de validación sobre los datos importados")

                            Dim mensaje As String
                            Dim oradb6 As String = Configuracion.verconfig
                            Dim conn6 As New OracleConnection()
                            Dim myCMD6 As New OracleCommand()
                            conn6.ConnectionString = oradb6
                            conn6.Open()
                            Try
                                myCMD6.Connection = conn6
                                myCMD6.CommandText = "alter PACKAGE im_k_subir_respaldo compile"
                                myCMD6.CommandType = CommandType.Text
                                myCMD6.ExecuteOracleScalar()
                                mensaje = "OK"
                                conn6.Close()
                            Catch ex As Exception
                                conn6.Close()
                                mensaje = "ERROR"
                                'waitDialog.Caption = "finalizando..."
                                'waitDialog.Close()
                                Mensajes.MensajeError(ex.Message)
                            End Try

                            If Trim(mensaje) = "OK" Then
                                Dim oradb5 As String = Configuracion.verconfig
                                Dim conn5 As New OracleConnection()
                                Dim myCMD5 As New OracleCommand()
                                conn5.ConnectionString = oradb5
                                conn5.Open()
                                Try
                                    myCMD5.Connection = conn5
                                    myCMD5.CommandText = "alter package im_k_subir_respaldo compile body"
                                    myCMD5.CommandType = CommandType.Text
                                    myCMD5.ExecuteOracleScalar()
                                    mensaje = "OK"
                                Catch ex As Exception
                                    conn5.Close()
                                    mensaje = "ERROR"
                                    'waitDialog.Caption = "finalizando..."
                                    'waitDialog.Close()
                                    Mensajes.MensajeError(ex.Message)
                                End Try
                                conn5.Close()
                            Else
                                MsgBox("Error al compilar la especificacion del paquete de compilacion")
                            End If

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
                                    conn3.Close()
                                Catch ex As Exception
                                    conn3.Close()
                                    mensaje = "ERROR"
                                    Mensajes.MensajeError(ex.Message)
                                    Exit Sub
                                End Try
                            Else
                                MsgBox("Error al compilar el cuerpo del paquete de compilacion")
                            End If


                            Dim partido As String
                            Dim movimiento As String
                            Dim cantidad_candidatos As Integer
                            Dim cantidad_firmas As Integer
                            Dim cantidad_fotos As Integer
                            Dim cantidad_constancias As Integer
                            Dim cantidad_imagenes_firmas As Integer
                            Dim desc_partido As String
                            Dim desc_movimiento As String

                            Dim oradb9 As String = Configuracion.verconfig
                            Dim conn9 As New OracleConnection()
                            Dim myCMD9 As New OracleCommand()
                            conn9.ConnectionString = oradb9
                            conn9.Open()
                            Try                                
                                myCMD9.Connection = conn9
                                myCMD9.CommandText = "im_p_cantidades_en_temporales"
                                myCMD9.CommandType = CommandType.StoredProcedure   
                                myCMD9.Parameters.Add(New OracleParameter("partido", OracleType.Char, 2)).Direction = ParameterDirection.Output
                                myCMD9.Parameters.Add(New OracleParameter("movimiento", OracleType.Char, 3)).Direction = ParameterDirection.Output
                                myCMD9.Parameters.Add(New OracleParameter("desc_partido", OracleType.Char, 100)).Direction = ParameterDirection.Output
                                myCMD9.Parameters.Add(New OracleParameter("desc_movimiento", OracleType.Char, 200)).Direction = ParameterDirection.Output
                                myCMD9.Parameters.Add(New OracleParameter("cantidad_candidatos", OracleType.Number)).Direction = ParameterDirection.Output
                                myCMD9.Parameters.Add(New OracleParameter("cantidad_firmas", OracleType.Number)).Direction = ParameterDirection.Output
                                myCMD9.Parameters.Add(New OracleParameter("cantidad_fotos", OracleType.Number)).Direction = ParameterDirection.Output
                                myCMD9.Parameters.Add(New OracleParameter("cantidad_constancias", OracleType.Number)).Direction = ParameterDirection.Output
                                myCMD9.Parameters.Add(New OracleParameter("cantidad_imagenes_firmas", OracleType.Number)).Direction = ParameterDirection.Output
                                myCMD9.ExecuteOracleScalar()
                                If IsDBNull(myCMD9.Parameters("partido").Value) Then
                                    partido = "NULL"
                                Else
                                    partido = "'" & myCMD9.Parameters("partido").Value & "'"
                                End If
                                movimiento = Trim(myCMD9.Parameters("movimiento").Value)
                                desc_partido = Trim(myCMD9.Parameters("desc_partido").Value)
                                desc_movimiento = Trim(myCMD9.Parameters("desc_movimiento").Value)
                                cantidad_candidatos = Trim(myCMD9.Parameters("cantidad_candidatos").Value)
                                cantidad_firmas = Trim(myCMD9.Parameters("cantidad_firmas").Value)
                                cantidad_fotos = Trim(myCMD9.Parameters("cantidad_fotos").Value)
                                cantidad_constancias = Trim(myCMD9.Parameters("cantidad_constancias").Value)
                                cantidad_imagenes_firmas = Trim(myCMD9.Parameters("cantidad_imagenes_firmas").Value)
                                conn9.Close()
                            Catch ex As Exception
                                conn9.Close()
                                mensaje = "ERROR"
                                Mensajes.MensajeError(ex.Message)
                                Exit Sub
                            End Try
                            

                            Dim oradb10 As String = Configuracion.verconfig
                            Dim conn10 As New OracleConnection()
                            Dim myCMD10 As New OracleCommand()
                            conn10.ConnectionString = oradb10
                            conn10.Open()
                            Dim reporte As String
                            Try
                                myCMD10.Connection = conn10                                
                                myCMD10.CommandText = "Insert into im_registro_importaciones (FECHA_ADICION, HORA_ADICION, " _
                                & "NOMBRE_ARCHIVO, TAMAÑO_ARCHIVO, CODIGO_PARTIDO, CODIGO_MOVIMIENTO, CANTIDAD_CANDIDATOS, " _
                                & "CANTIDAD_FIRMAS, CANTIDAD_FOTOS, CANTIDAD_CONSTANCIAS, CANTIDAD_IMAGENES_FIRMAS, adicionado_por, desc_partido, desc_movimiento ) VALUES (" _
                                & "to_date('" & DateTime.Now.Date & "','dd/mm/yyyy'),'" & DateTime.Now.ToLongTimeString & "', '" & archivo _
                                & "'," & fi.Length & "," & partido & ",'" & movimiento & "'," & cantidad_candidatos _
                                & "," & cantidad_firmas & "," & cantidad_fotos & "," & cantidad_constancias & "," & cantidad_imagenes_firmas _
                                & ",'" & usuario & "','" & desc_partido & "','" & desc_movimiento & "')"
                                myCMD10.CommandType = CommandType.Text
                                myCMD10.ExecuteOracleScalar()
                                reporte = "OK"
                            Catch ex As Exception
                                reporte = "ERROR"
                                conn10.Close()
                                'waitDialog.Caption = "finalizando..."
                                'waitDialog.Close()
                                Mensajes.MensajeError(ex.Message)
                            End Try
                            conn10.Close()

                            If Trim(mensaje) = "OK" Then
                                System.Threading.Thread.Sleep(2000)
                                Dim oradb7 As String = Configuracion.verconfig
                                'Dim conn7 As New OracleConnection()
                                conn7.ConnectionString = oradb7
                                conn7.Open()
                                Dim myCMD7 As New OracleCommand()
                                myCMD7.Connection = conn7
                                myCMD7.CommandText = "im_k_carga_datos.IM_P_CARGA_DATOS"
                                myCMD7.CommandType = CommandType.StoredProcedure
                                myCMD7.Parameters.Add(New OracleParameter("P_Error", OracleType.NVarChar, 500)).Direction = ParameterDirection.InputOutput
                                myCMD7.ExecuteOracleScalar()
                                If IsDBNull(myCMD7.Parameters("P_Error").Value) Then
                                    Mensajes.mimensaje("Proceso de validación de Datos terminado Exitosamente")
                                Else
                                    Mensajes.MensajeError(myCMD7.Parameters("P_Error").Value)
                                End If
                                conn7.Close()
                            Else
                                MsgBox("Error: " & mensaje, MsgBoxStyle.Information)
                            End If
                            conn3.Close()

                            If reporte = "OK" Then
                                'llamar reporte
                                Dim reporte_import As REPORTE_REGISTRO_IMPORTACIONES_1 = New REPORTE_REGISTRO_IMPORTACIONES_1
                                reporte_import.ShowPreview()
                            Else
                                MsgBox("New se pudo generar el recibo de importacion de datos")
                            End If
                        Catch ex As Exception
                            conn7.Close()
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
        Path = OpenFileDialog1.FileName
        archivo = OpenFileDialog1.SafeFileName
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