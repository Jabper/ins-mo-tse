Imports System.Data.OracleClient
Imports System.IO

Public Class XfrmDiscoPartido

    Private Sub XfrmDiscoPartido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_procesos.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.Ds_procesos.IM_PARTIDOS_POLITICOS)

    End Sub

    Private Sub BtnExplorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExplorar.Click
        FbUbicacion.ShowDialog()
        TxtRuta.Text = FbUbicacion.SelectedPath
    End Sub

    Private Sub BtnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEjecutar.Click
        'MsgBox("expdp tse/oracle@TSEDB2 directory=data_pump_dir dumpfile=exp_tse.dmp logfile=exp_movimiento.log schemas=tse include=table:\""like 'IM_%'\"",VIEW,PROCEDURE,TRIGGER,PACKAGE, SEQUENCE,FUNCTION version=10 query=im_partidos_politicos:\""WHERE codigo_partido = (SELECT codigo_partido FROM im_parametros_generales)\"" query=im_usuarios:\""where codigo_usuario = 'TSE'\"" query=im_roles:\""where codigo_rol <> 1\"" query=IM_OPERACIONES_POR_ROL:\""where  1 = 2\"" query=im_log_procesos:\""where 1 =2\"" query=im_candidatos:\""where codigo_candidatos = 0\"" query=im_requisitos_x_candidato:\""where codigo_candidato = 0\"" query=im_ciudadanos_respaldan:\""where 1 > 2\"" query=im_ciudadanos_inhabilitados:\""where 1 = 2\"" query=im_movimientos:\""where 1 = 2\"" query=im_candidatos_repetidos:\""where 1 = 2\"" query=im_imagenes_candidato:\""where 1 = 2 \"" query=im_imagenes_firmas:\""where 1 = 2\""")
        If Not (TxtRuta.Text = Nothing) Then
            If Not (LovPartido.EditValue Is Nothing) Then
                Dim oradb2 As String = Configuracion.verconfig
                Dim conn2 As New OracleConnection()
                'Dim myCMD As New OracleCommand()
                'Dim mensaje As String
                conn2.ConnectionString = oradb2
                conn2.Open()

                Dim sql As String = "select codigo_partido from im_parametros_generales"
                Dim cmd As New OracleCommand(sql, conn2)
                cmd.CommandType = CommandType.Text
                Dim chek As OracleDataReader = cmd.ExecuteReader()
                Dim partido As String
                If chek.Read Then
                    If Not IsDBNull(chek.Item("codigo_partido")) Then
                        partido = chek.Item("codigo_partido")
                    Else
                        partido = "Null"
                    End If
                End If
                conn2.Close()

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                Dim myCMD As New OracleCommand()
                conn.ConnectionString = oradb
                conn.Open()
                Try
                    myCMD.Connection = conn
                    myCMD.CommandText = "Update im_parametros_generales set codigo_partido = " & LovPartido.EditValue
                    myCMD.CommandType = CommandType.Text
                    myCMD.ExecuteOracleScalar()
                Catch ex As Exception
                    Dim oradb3 As String = Configuracion.verconfig
                    Dim conn3 As New OracleConnection()
                    Dim myCMD3 As New OracleCommand()
                    conn3.ConnectionString = oradb3
                    conn3.Open()
                    myCMD3.Connection = conn3
                    myCMD3.CommandText = "Update im_parametros_generales set codigo_partido = " & partido
                    myCMD3.CommandType = CommandType.Text
                    myCMD3.ExecuteOracleScalar()
                    conn3.Close()
                    conn.Close()
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try
                conn.Close()

                If My.Computer.FileSystem.DirectoryExists(Application.StartupPath.ToString & "\CSIM") Then
                    My.Computer.FileSystem.CopyDirectory(Application.StartupPath.ToString & "\CSIM", TxtRuta.Text & "\CSIM\", True)
                    If comprobararchivos() Then
                        'ejecutar(datapump)
                        Try
                            Dim startInfo As ProcessStartInfo
                            Dim pStart As New Process
                            startInfo = New ProcessStartInfo("cmd.exe", "/C expdp TSE/TSEORACLE2012@XE directory=data_pump_dir dumpfile=exp_tse.dmp logfile=exp_movimiento.log schemas=tse version=10 query=im_partidos_politicos:\""WHERE codigo_partido = (SELECT codigo_partido FROM im_parametros_generales)\"" query=im_usuarios:\""where codigo_usuario = 'TSE'\"" query=im_roles:\""where codigo_rol in (2,3)\"" query=IM_OPERACIONES_POR_ROL:\""where  codigo_rol in (2,3)\"" query=im_log_procesos:\""where 1 =2\"" query=im_candidatos:\""where codigo_candidatos = 0\"" query=im_requisitos_x_candidato:\""where codigo_candidato = 0\"" query=im_ciudadanos_respaldan:\""where 1 > 2\"" query=im_ciudadanos_inhabilitados:\""where 1 = 2\"" query=im_movimientos:\""where 1 = 2\"" query=im_candidatos_repetidos:\""where 1 = 2\"" query=im_imagenes_candidato:\""where 1 = 2 \"" query=im_imagenes_firmas:\""where 1 = 2\""")
                            pStart.StartInfo = startInfo
                            pStart.Start()
                            pStart.WaitForExit()
                            If pStart.ExitCode = 3 Then
                                MsgBox("La Exportación de Tablas ha Terminado Satisfactoriamente... Continuando con el proceso por favor espere", MsgBoxStyle.Information)
                            Else
                                Dim oradb5 As String = Configuracion.verconfig
                                Dim conn5 As New OracleConnection()
                                Dim myCMD5 As New OracleCommand()
                                conn5.ConnectionString = oradb5
                                conn5.Open()
                                myCMD5.Connection = conn5
                                myCMD5.CommandText = "Update im_parametros_generales set codigo_partido = " & partido
                                myCMD5.CommandType = CommandType.Text
                                myCMD5.ExecuteOracleScalar()
                                conn5.Close()
                                MsgBox("La Generación de Tablas No se ha realizado Correctamente", MsgBoxStyle.Exclamation)
                                Exit Sub
                            End If
                        Catch ex As Exception
                            Dim oradb4 As String = Configuracion.verconfig
                            Dim conn4 As New OracleConnection()
                            Dim myCMD4 As New OracleCommand()
                            conn4.ConnectionString = oradb4
                            conn4.Open()
                            myCMD4.Connection = conn4
                            myCMD4.CommandText = "Update im_parametros_generales set codigo_partido = " & partido
                            myCMD4.CommandType = CommandType.Text
                            myCMD4.ExecuteOracleScalar()
                            conn4.Close()
                            Mensajes.MensajeError(ex.Message)
                            Exit Sub
                        End Try

                        Try
                            Dim startInfo As ProcessStartInfo
                            Dim pStart As New Process
                            startInfo = New ProcessStartInfo("cmd.exe", "/C expdp TSE/TSEORACLE2012@XE directory=data_pump_dir dumpfile=exp_tse_md.dmp logfile=exp_tse_md.log schemas=tse version=10 content=metadata_only")
                            pStart.StartInfo = startInfo
                            pStart.Start()
                            pStart.WaitForExit()
                            If pStart.ExitCode = 3 Then
                                MsgBox("La Exportación de metadata ha Terminado Satisfactoriamente... Continuando con el proceso por favor espere", MsgBoxStyle.Information)
                            Else
                                MsgBox("La Generación de Metadata No se ha realizado Correctamente", MsgBoxStyle.Exclamation)
                                Dim oradb6 As String = Configuracion.verconfig
                                Dim conn6 As New OracleConnection()
                                Dim myCMD6 As New OracleCommand()
                                conn6.ConnectionString = oradb6
                                conn6.Open()
                                myCMD6.Connection = conn6
                                myCMD6.CommandText = "Update im_parametros_generales set codigo_partido = " & partido
                                myCMD6.CommandType = CommandType.Text
                                myCMD6.ExecuteOracleScalar()
                                conn6.Close()
                                Exit Sub
                            End If
                        Catch ex As Exception
                            Dim oradb6 As String = Configuracion.verconfig
                            Dim conn6 As New OracleConnection()
                            Dim myCMD6 As New OracleCommand()
                            conn6.ConnectionString = oradb6
                            conn6.Open()
                            myCMD6.Connection = conn6
                            myCMD6.CommandText = "Update im_parametros_generales set codigo_partido = " & partido
                            myCMD6.CommandType = CommandType.Text
                            myCMD6.ExecuteOracleScalar()
                            conn6.Close()
                            Mensajes.MensajeError(ex.Message)
                            Exit Sub
                        End Try

                        If File.Exists("C:\oraclexe\app\oracle\admin\XE\dpdump\exp_tse.dmp") Then
                            System.IO.File.Copy("C:\oraclexe\app\oracle\admin\XE\dpdump\exp_tse.dmp", TxtRuta.Text & "\CSIM\Componentes\exp_tse.dmp", True)
                        Else
                            MsgBox("No se ha encontrado el archivo de la Base de Datos")
                            Dim oradb5 As String = Configuracion.verconfig
                            Dim conn5 As New OracleConnection()
                            Dim myCMD5 As New OracleCommand()
                            conn5.ConnectionString = oradb5
                            conn5.Open()
                            myCMD5.Connection = conn5
                            myCMD5.CommandText = "Update im_parametros_generales set codigo_partido = " & partido
                            myCMD5.CommandType = CommandType.Text
                            myCMD5.ExecuteOracleScalar()
                            conn5.Close()
                            Exit Sub
                        End If

                        Dim oradb1 As String = Configuracion.verconfig
                        Dim conn1 As New OracleConnection()
                        Dim myCMD1 As New OracleCommand()
                        conn1.ConnectionString = oradb1
                        conn1.Open()
                        Try
                            myCMD1.Connection = conn1
                            myCMD1.CommandText = "Update im_parametros_generales set codigo_partido = " & partido
                            myCMD1.CommandType = CommandType.Text
                            myCMD1.ExecuteOracleScalar()
                        Catch ex As Exception
                            conn.Close()
                            Mensajes.MensajeError(ex.Message)
                            Exit Sub
                        End Try
                        conn.Close()

                        MsgBox(" Los archivos de instalacion se han generado correctamente")
                    Else
                        MsgBox("Error al copiar los archivos alguno de los archivos necesarios no se genero correctamente")
                        Dim oradb5 As String = Configuracion.verconfig
                        Dim conn5 As New OracleConnection()
                        Dim myCMD5 As New OracleCommand()
                        conn5.ConnectionString = oradb5
                        conn5.Open()
                        myCMD5.Connection = conn5
                        myCMD5.CommandText = "Update im_parametros_generales set codigo_partido = " & partido
                        myCMD5.CommandType = CommandType.Text
                        myCMD5.ExecuteOracleScalar()
                        conn5.Close()
                        Exit Sub
                    End If
                Else
                    MsgBox("Error no se encontro la carpeta que contiene los archivos de instalacion...")
                    Dim oradb5 As String = Configuracion.verconfig
                    Dim conn5 As New OracleConnection()
                    Dim myCMD5 As New OracleCommand()
                    conn5.ConnectionString = oradb5
                    conn5.Open()
                    myCMD5.Connection = conn5
                    myCMD5.CommandText = "Update im_parametros_generales set codigo_partido = " & partido
                    myCMD5.CommandType = CommandType.Text
                    myCMD5.ExecuteOracleScalar()
                    conn5.Close()
                    Exit Sub
                End If
            Else
                MsgBox("Debe seleccionar un partido.")
            End If
        Else
            MsgBox("Debe seleccionar una ruta para los archivos.")
        End If
    End Sub

    Function comprobararchivos() As Boolean
        Dim poracle As String = TxtRuta.Text & "\CSIM\Componentes\OracleXEUniv.exe"
        Dim psetup As String = TxtRuta.Text & "\CSIM\Componentes\setup.exe"
        Dim psetup2 As String = TxtRuta.Text & "\CSIM\Componentes\Inscripción de Movimientos.msi"
        'Dim backupo As String = TxtRuta.Text & "\CSIM\Componentes\exp_tse.dmp"
        Dim conxion As String = TxtRuta.Text & "\CSIM\Componentes\CNX.TAR"
        Dim conexionsql As String = TxtRuta.Text & "\CSIM\Componentes\CSQ.TAR"
        Dim archivopar As String = TxtRuta.Text & "\CSIM\Componentes\IMPAR.TAR"
        Dim importar As String = TxtRuta.Text & "\CSIM\Componentes\IMP.TAR"

        If File.Exists(poracle) Then            
            If File.Exists(psetup) Then
                If File.Exists(psetup2) Then
                    If File.Exists(conxion) Then
                        If File.Exists(conexionsql) Then
                            If File.Exists(archivopar) Then
                                If File.Exists(importar) Then
                                    Return True
                                Else
                                    Return False
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Function

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class