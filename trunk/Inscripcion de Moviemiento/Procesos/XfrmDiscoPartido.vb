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
End Class