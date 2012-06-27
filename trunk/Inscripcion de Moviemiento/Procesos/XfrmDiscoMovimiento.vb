Imports System.Data.OracleClient
Imports System.IO

Public Class XfrmDiscoMovimiento
    Private Sub BtnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEjecutar.Click
        If Not (TxtRuta.Text = Nothing) Then
            If Not (LovPartido.EditValue Is Nothing) Then
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
                    conn.Close()
                    Mensajes.MensajeError(ex.Message)
                    Exit Sub
                End Try
                conn.Close()

                My.Computer.FileSystem.CopyDirectory(Application.StartupPath.ToString & "\CSIM", TxtRuta.Text, True)
                If comprobararchivos() Then
                    'ejecutar(datapump)
                    Try
                        Dim startInfo As ProcessStartInfo
                        Dim pStart As New Process
                        startInfo = New ProcessStartInfo("cmd.exe", "expdp TSE/TSEORACLE2012@XE directory=data_pump_dir dumpfile=exp_tse.dmp logfile=exp_movimiento.log schemas=tse include=table:\""like 'IM_%'\"",VIEW,PROCEDURE,TRIGGER,PACKAGE, SEQUENCE,FUNCTION version=10 query=im_partidos_politicos:\""WHERE codigo_partido = (SELECT codigo_partido FROM im_parametros_generales)\"" query=im_usuarios:\""where codigo_usuario = 'TSE'\"" query=im_roles:\""where codigo_rol <> 1\"" query=IM_OPERACIONES_POR_ROL:\""where  1 = 2\"" query=im_log_procesos:\""where 1 =2\"" query=im_candidatos:\""where codigo_candidatos = 0\"" query=im_requisitos_x_candidato:\""where codigo_candidato = 0\"" query=im_ciudadanos_respaldan:\""where 1 > 2\"" query=im_ciudadanos_inhabilitados:\""where 1 = 2\"" query=im_movimientos:\""where 1 = 2\"" query=im_candidatos_repetidos:\""where 1 = 2\"" query=im_imagenes_candidato:\""where 1 = 2 \"" query=im_imagenes_firmas:\""where 1 = 2\""")
                        pStart.StartInfo = startInfo
                        pStart.Start()
                        pStart.WaitForExit()
                        If pStart.ExitCode = 3 Then
                            MsgBox("La Exportación ha Terminado Satisfactoriamente", MsgBoxStyle.Information)
                        Else
                            MsgBox("La Exportación No se ha realizado Correctamente", MsgBoxStyle.Exclamation)
                        End If
                    Catch ex As Exception
                        conn.Close()
                        Mensajes.MensajeError(ex.Message)
                        Exit Sub
                    End Try


                    If File.Exists("C:\oraclexe\app\oracle\admin\XE\dpdump\exp_tse.dmp") Then
                        System.IO.File.Copy("C:\oraclexe\app\oracle\admin\XE\dpdump\exp_tse.dmp", TxtRuta.Text & "\CSIM\Componentes\exp_tse.dmp", True)                                           
                    End If

                    Dim oradb1 As String = Configuracion.verconfig
                    Dim conn1 As New OracleConnection()
                    Dim myCMD1 As New OracleCommand()
                    conn1.ConnectionString = oradb1
                    conn1.Open()
                    Try
                        myCMD1.Connection = conn1
                        myCMD1.CommandText = "Update im_parametros_generales set codigo_partido = null"
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
                    MsgBox("Error al copiar los archivos verifique espacio en disco")
                End If
            Else
                MsgBox("Debe seleccionar un partido.")
            End If
        Else
            MsgBox("Debe seleccionar una ruta para los archivos.")
        End If
    End Sub

    Private Sub BtnExplorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExplorar.Click
        FbUbicacion.ShowDialog()
        TxtRuta.Text = FbUbicacion.SelectedPath
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

        If File.Exists(poracle) And File.Exists(psetup) And File.Exists(psetup2) _
            And File.Exists(conxion) And File.Exists(conexionsql) _
         And File.Exists(archivopar) And File.Exists(importar) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub XfrmDiscoMovimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_procesos.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.Ds_procesos.IM_PARTIDOS_POLITICOS)

    End Sub

    Private Sub LovPartido_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LovPartido.TextChanged
        Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.Ds_procesos.IM_MOVIMIENTOS, LovPartido.EditValue)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class