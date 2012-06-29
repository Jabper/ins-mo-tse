Imports System.Data.OleDb
Imports System.Data.OracleClient
Imports DevExpress.Utils
Imports System.IO

Public Class XfrmSubirSistExterno

    Private Sub XfrmSubirSistExterno_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim oradb3 As String = Configuracion.verconfig
        Dim conn3 As New OracleConnection()
        'Dim myCMD As New OracleCommand()
        'Dim mensaje As String
        conn3.ConnectionString = oradb3
        conn3.Open()

        Dim sql3 As String = "Update im_parametros_generales set proceso_en_ejecucion = 'N'"
        Dim cmd3 As New OracleCommand(sql3, conn3)
        cmd3.CommandType = CommandType.Text
        cmd3.ExecuteScalar()
        conn3.Close()
        'Me.Close()
    End Sub

    Private Sub XfrmSubirSistExterno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BtnCandidatos.Height = Me.BtnCandidatos.Height + 15
        Me.BtnCandidatos.Width = Me.BtnCandidatos.Width + 15
        Dim punto As Point = New Point(Me.BtnCandidatos.Location.X - 7.5, Me.BtnCandidatos.Location.Y - 7.5)
        Me.BtnCandidatos.Location = punto
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Dim oradb3 As String = Configuracion.verconfig
        Dim conn3 As New OracleConnection()
        'Dim myCMD As New OracleCommand()
        'Dim mensaje As String
        conn3.ConnectionString = oradb3
        conn3.Open()

        Dim sql3 As String = "Update im_parametros_generales set proceso_en_ejecucion = 'N'"
        Dim cmd3 As New OracleCommand(sql3, conn3)
        cmd3.CommandType = CommandType.Text
        cmd3.ExecuteScalar()
        conn3.Close()
        Me.Close()
    End Sub

    Dim proceso_iniciado As Boolean = False
    Dim proceso_corriendo As String
    Private Sub BtnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEjecutar.Click
        Dim retorno As Boolean

        If Not (TxtRuta.Text = Nothing) Then
            If proceso_iniciado = False Then
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

                If chek.Read Then
                    proceso_corriendo = chek.Item("proceso_en_ejecucion")
                End If
                conn.Close()
            End If

            If proceso_corriendo = "N" Then
                If Me.BtnCandidatos.Enabled = True Then
                    Dim oradb2 As String = Configuracion.verconfig
                    Dim conn2 As New OracleConnection()
                    'Dim myCMD As New OracleCommand()
                    'Dim mensaje As String
                    conn2.ConnectionString = oradb2
                    conn2.Open()

                    Dim sql2 As String = "Update im_parametros_generales set proceso_en_ejecucion = 'S'"
                    Dim cmd2 As New OracleCommand(sql2, conn2)
                    cmd2.CommandType = CommandType.Text
                    cmd2.ExecuteNonQuery()
                    conn2.Close()

                    proceso_iniciado = True

                    retorno = subir_candidatos(Me.TxtRuta.Text)
                    If retorno = True Then
                        Me.TxtRuta.Text = Nothing

                        Me.BtnCandidatos.Height = Me.BtnCandidatos.Height - 15
                        Me.BtnCandidatos.Width = Me.BtnCandidatos.Width - 15
                        Dim punto As Point = New Point(Me.BtnCandidatos.Location.X + 7.5, Me.BtnCandidatos.Location.Y + 7.5)
                        Me.BtnCandidatos.Location = punto
                        Me.BtnCandidatos.ForeColor = Color.Black
                        Me.BtnCandidatos.Enabled = False

                        Me.BtnRequisitos.Enabled = True
                        Me.BtnRequisitos.ForeColor = Color.LimeGreen
                        Me.BtnRequisitos.Height = Me.BtnRequisitos.Height + 15
                        Me.BtnRequisitos.Width = Me.BtnRequisitos.Width + 15
                        punto = New Point(Me.BtnRequisitos.Location.X - 7.5, Me.BtnRequisitos.Location.Y - 7.5)
                        Me.BtnRequisitos.Location = punto
                    End If
                ElseIf Me.BtnRequisitos.Enabled = True Then
                    retorno = subir_requisitos_x_candidato(Me.TxtRuta.Text)
                    If retorno = True Then
                        Me.TxtRuta.Text = Nothing

                        Me.BtnRequisitos.Height = Me.BtnRequisitos.Height - 15
                        Me.BtnRequisitos.Width = Me.BtnRequisitos.Width - 15
                        Dim punto As Point = New Point(Me.BtnRequisitos.Location.X + 7.5, Me.BtnRequisitos.Location.Y + 7.5)
                        Me.BtnRequisitos.Location = punto
                        Me.BtnRequisitos.ForeColor = Color.Black
                        Me.BtnRequisitos.Enabled = False

                        Me.BtnFirmas.Enabled = True
                        Me.BtnFirmas.ForeColor = Color.LimeGreen
                        Me.BtnFirmas.Height = Me.BtnFirmas.Height + 15
                        Me.BtnFirmas.Width = Me.BtnFirmas.Width + 15
                        punto = New Point(Me.BtnFirmas.Location.X - 7.5, Me.BtnFirmas.Location.Y - 7.5)
                        Me.BtnFirmas.Location = punto
                    End If
                ElseIf Me.BtnFirmas.Enabled = True Then
                    retorno = subir_firmas(Me.TxtRuta.Text)
                    If retorno = True Then
                        Me.TxtRuta.Text = Nothing

                        Me.BtnFirmas.Height = Me.BtnFirmas.Height - 15
                        Me.BtnFirmas.Width = Me.BtnFirmas.Width - 15
                        Dim punto As Point = New Point(Me.BtnFirmas.Location.X + 7.5, Me.BtnFirmas.Location.Y + 7.5)
                        Me.BtnFirmas.Location = punto
                        Me.BtnFirmas.ForeColor = Color.Black
                        Me.BtnFirmas.Enabled = False

                        Me.BtnMovimiento.Enabled = True
                        Me.BtnMovimiento.ForeColor = Color.LimeGreen
                        Me.BtnMovimiento.Height = Me.BtnMovimiento.Height + 15
                        Me.BtnMovimiento.Width = Me.BtnMovimiento.Width + 15
                        punto = New Point(Me.BtnMovimiento.Location.X - 7.5, Me.BtnMovimiento.Location.Y - 7.5)
                        Me.BtnMovimiento.Location = punto
                    End If
                ElseIf Me.BtnMovimiento.Enabled = True Then
                    retorno = subir_movimientos(Me.TxtRuta.Text)
                    If retorno = True Then
                        Me.TxtRuta.Text = Nothing

                        Me.BtnMovimiento.Height = Me.BtnMovimiento.Height - 15
                        Me.BtnMovimiento.Width = Me.BtnMovimiento.Width - 15
                        Dim punto As Point = New Point(Me.BtnMovimiento.Location.X + 7.5, Me.BtnMovimiento.Location.Y + 7.5)
                        Me.BtnMovimiento.Location = punto
                        Me.BtnMovimiento.ForeColor = Color.Black
                        Me.BtnMovimiento.Enabled = False

                        Me.BtnImagenes.Enabled = True
                        Me.BtnImagenes.ForeColor = Color.LimeGreen
                        Me.BtnImagenes.Height = Me.BtnImagenes.Height + 15
                        Me.BtnImagenes.Width = Me.BtnImagenes.Width + 15
                        punto = New Point(Me.BtnImagenes.Location.X - 7.5, Me.BtnImagenes.Location.Y - 7.5)
                        Me.BtnImagenes.Location = punto
                        Label2.Text = "Seleccione la carpeta donde se encuentran las imágenes a importar:"
                    End If
                ElseIf Me.BtnImagenes.Enabled = True Then
                    retorno = subir_imagenes(Me.TxtRuta.Text)
                    If retorno = True Then
                        Me.TxtRuta.Text = Nothing

                        Me.BtnImagenes.Height = Me.BtnImagenes.Height - 15
                        Me.BtnImagenes.Width = Me.BtnImagenes.Width - 15
                        Dim punto As Point = New Point(Me.BtnImagenes.Location.X + 7.5, Me.BtnImagenes.Location.Y + 7.5)
                        Me.BtnImagenes.Location = punto
                        Me.BtnImagenes.ForeColor = Color.Black
                        Me.BtnImagenes.Enabled = False

                        Me.BtnImagenesFirmas.Enabled = True
                        Me.BtnImagenesFirmas.ForeColor = Color.LimeGreen
                        Me.BtnImagenesFirmas.Height = Me.BtnImagenesFirmas.Height + 15
                        Me.BtnImagenesFirmas.Width = Me.BtnImagenesFirmas.Width + 15
                        punto = New Point(Me.BtnImagenesFirmas.Location.X - 7.5, Me.BtnImagenesFirmas.Location.Y - 7.5)
                        Me.BtnImagenesFirmas.Location = punto
                    End If
                ElseIf Me.BtnImagenesFirmas.Enabled = True Then
                    retorno = subir_imagenes_firmas(Me.TxtRuta.Text)
                    If retorno = True Then
                        Dim oradb3 As String = Configuracion.verconfig
                        Dim conn3 As New OracleConnection()
                        'Dim myCMD As New OracleCommand()
                        'Dim mensaje As String
                        conn3.ConnectionString = oradb3
                        conn3.Open()

                        Dim sql3 As String = "Update im_parametros_generales set proceso_en_ejecucion = 'N'"
                        Dim cmd3 As New OracleCommand(sql3, conn3)
                        cmd3.CommandType = CommandType.Text
                        cmd3.ExecuteScalar()
                        conn3.Close()

                        Me.TxtRuta.Text = Nothing

                        Me.BtnImagenesFirmas.Height = Me.BtnImagenesFirmas.Height - 15
                        Me.BtnImagenesFirmas.Width = Me.BtnImagenesFirmas.Width - 15
                        Dim punto As Point = New Point(Me.BtnImagenesFirmas.Location.X + 7.5, Me.BtnImagenesFirmas.Location.Y + 7.5)
                        Me.BtnImagenesFirmas.Location = punto
                        Me.BtnImagenesFirmas.ForeColor = Color.Black
                        Me.BtnImagenesFirmas.Enabled = False

                        Me.BtnCandidatos.Enabled = True
                        Me.BtnCandidatos.ForeColor = Color.LimeGreen
                        Me.BtnCandidatos.Height = Me.BtnCandidatos.Height + 15
                        Me.BtnCandidatos.Width = Me.BtnCandidatos.Width + 15
                        punto = New Point(Me.BtnCandidatos.Location.X - 7.5, Me.BtnCandidatos.Location.Y - 7.5)
                        Me.BtnCandidatos.Location = punto
                        Label2.Text = "Seleccione el Archivo a Importar:"

                        proceso_iniciado = False
                        proceso_corriendo = Nothing
                        MsgBox("La Importación ha terminado correctamente...", MsgBoxStyle.Information)
                    End If
                End If
            End If        
        End If
    End Sub

    Private Function subir_candidatos(ByVal Filename As String) As Boolean
        'Dim waitDialog As New WaitDialogForm("Procesando Información", "Por favor espere..")
        Try
            Dim extension As String = IO.Path.GetExtension(Filename)
            Dim connString As String = "Data Source=" & Filename

            If (extension = ".xls") Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0; Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"
            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
            Else
                'waitDialog.Caption = "finalizando..."
                'waitDialog.Close()
                Mensajes.MensajeError("El tipo de archivo seleccionado no esta permitido")
                Return False
            End If

            Using conexion As New OleDbConnection(connString)
                Dim sql1 As String = "SELECT * FROM [Candidatos$]"
                Dim adaptador As New OleDbDataAdapter(sql1, conexion)
                Dim dt As New DataTable("Excel")
                adaptador.Fill(dt)

                Dim oradb1 As String = Configuracion.verconfig
                Dim conn1 As New OracleConnection()
                Dim myCMD As New OracleCommand()
                conn1.ConnectionString = oradb1
                conn1.Open()
                Dim i As Integer = 0
                For Each row As System.Data.DataRow In dt.Rows
                    Try
                        myCMD.Connection = conn1
                        myCMD.CommandText = "Insert into tmp_im_candidatos (CODIGO_CANDIDATOS, IDENTIDAD, NOMBRE, APELLIDO, POSICION, " _
                        & "CODIGO_CARGO_ELECTIVO,  CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, CODIGO_PARTIDO, CODIGO_MOVIMIENTO, " _
                        & "ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, " _
                        & "ESTADO) VALUES ('" _
                        & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', '" & row.Item(3).ToString _
                        & "', '" & row.Item(4).ToString & "', '" & row.Item(5).ToString & "', '" & row.Item(6).ToString & "', '" & row.Item(7).ToString _
                        & "', '" & row.Item(8).ToString & "', '" & row.Item(9).ToString & "', 'TSE', to_date('" & DateTime.Now & "','dd/mm/yyyy hh:mi:ss p.m.')" _
                        & ", null, null, '" & row.Item(10).ToString & "')"
                        myCMD.CommandType = CommandType.Text
                        myCMD.ExecuteOracleScalar()
                        i = i + 1
                        If i Mod 1000 = 0 Then
                            Dialog1.LabelControl1.Text = "Se han procesado " & i & " registros. Procesando por favor espere..."
                            If Dialog1.Visible = False Then
                                Dialog1.ShowDialog()
                            End If
                        End If
                    Catch ex As Exception
                        conn1.Close()
                        'waitDialog.Caption = "finalizando..."
                        'waitDialog.Close()
                        Mensajes.MensajeError(ex.Message)
                        Return False
                    End Try
                Next
                conn1.Close()
            End Using
            'waitDialog.Caption = "finalizando..."
            'waitDialog.Close()
            MsgBox("La Importación de Candidatos ha terminado exitosamente", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            'waitDialog.Caption = "finalizando..."
            'waitDialog.Close()
            Mensajes.MensajeError(ex.Message)
            Return False
        End Try
    End Function

    'Private Function subir_candidatos_repetidos(ByVal Filename As String) As Boolean
    '    Dim waitDialog As New WaitDialogForm("Procesando Información", "Por favor espere..")
    '    Try
    '        Dim extension As String = IO.Path.GetExtension(Filename)
    '        Dim connString As String = "Data Source=" & Filename

    '        If (extension = ".xls") Then
    '            connString &= ";Provider=Microsoft.Jet.OLEDB.4.0; Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"
    '        ElseIf (extension = ".xlsx") Then
    '            connString &= ";Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
    '        Else
    '            Mensajes.MensajeError("El tipo de archivo seleccionado no esta permitido")
    '            waitDialog.Caption = "finalizando..."
    '            waitDialog.Close()
    '            Return False
    '        End If

    '        Using conexion As New OleDbConnection(connString)
    '            Dim sql As String = "SELECT * FROM [Candidatos_Repetidos$]"
    '            Dim adaptador As New OleDbDataAdapter(sql, conexion)
    '            Dim dt As New DataTable("Excel")
    '            adaptador.Fill(dt)

    '            'Dim oradb1 As String = Configuracion.verconfig
    '            'Dim conn1 As New OracleConnection()
    '            'Dim myCMD1 As New OracleCommand()
    '            'conn1.ConnectionString = oradb1
    '            'conn1.Open()
    '            'Try
    '            '    myCMD1.Connection = conn1
    '            '    myCMD1.CommandText = "Delete tmp_im_candidatos_repetidos"
    '            '    myCMD1.CommandType = CommandType.Text
    '            '    myCMD1.ExecuteOracleScalar()
    '            'Catch ex As Exception
    '            '    conn1.Close()
    '            '    waitDialog.Caption = "finalizando..."
    '            '    waitDialog.Close()
    '            '    Mensajes.MensajeError(ex.Message)
    '            '    Return False
    '            'End Try
    '            'conn1.Close()

    '            Dim oradb As String = Configuracion.verconfig
    '            Dim conn As New OracleConnection()
    '            Dim myCMD As New OracleCommand()
    '            conn.ConnectionString = oradb
    '            conn.Open()
    '            For Each row As System.Data.DataRow In dt.Rows
    '                Try
    '                    myCMD.Connection = conn
    '                    myCMD.CommandText = "Insert into tmp_im_candidatos_repetidos (IDENTIDAD, CODIGO_MOVIMIENTO, CODIGO_PARTIDO," _
    '                    & " ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, ESTADO) VALUES ('" _
    '                    & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', 'TSE'" _
    '                    & ", to_date('" & DateTime.Now & "','dd/mm/yyyy hh:mi:ss p.m.'), null, null, '" & row.Item(3).ToString & "')"
    '                    myCMD.CommandType = CommandType.Text
    '                    myCMD.ExecuteOracleScalar()
    '                Catch ex As Exception
    '                    conn.Close()
    '                    waitDialog.Caption = "finalizando..."
    '                    waitDialog.Close()
    '                    Mensajes.MensajeError(ex.Message)
    '                    Return False
    '                End Try
    '            Next
    '            conn.Close()
    '        End Using
    '        waitDialog.Caption = "finalizando..."
    '        waitDialog.Close()
    '        MsgBox("La Importación de Candidatos Repetidos ha terminado exitosamente", MsgBoxStyle.Information)
    '        Return True
    '    Catch ex As Exception
    '        waitDialog.Caption = "finalizando..."
    '        waitDialog.Close()
    '        Mensajes.MensajeError(ex.Message)
    '        Return False
    '    End Try
    'End Function

    Private Function subir_requisitos_x_candidato(ByVal Filename As String) As Boolean
        ' Dim waitDialog As New WaitDialogForm("Procesando Información", "Por favor espere..")
        Try
            Dim extension As String = IO.Path.GetExtension(Filename)
            Dim connString As String = "Data Source=" & Filename

            If (extension = ".xls") Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0; Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"
            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
            Else
                Mensajes.MensajeError("El tipo de archivo seleccionado no esta permitido")
                'waitDialog.Caption = "finalizando..."
                'waitDialog.Close()
                Return False
            End If

            Using conexion As New OleDbConnection(connString)
                Dim sql As String = "SELECT * FROM [requisitos_x_candidato$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)
                Dim dt As New DataTable("Excel")
                adaptador.Fill(dt)

                'Dim oradb1 As String = Configuracion.verconfig
                'Dim conn1 As New OracleConnection()
                'Dim myCMD1 As New OracleCommand()
                'conn1.ConnectionString = oradb1
                'conn1.Open()
                'Try
                '    myCMD1.Connection = conn1
                '    myCMD1.CommandText = "Delete tmp_im_requisitos_x_candidato"
                '    myCMD1.CommandType = CommandType.Text
                '    myCMD1.ExecuteOracleScalar()
                'Catch ex As Exception
                '    conn1.Close()
                '    waitDialog.Caption = "finalizando..."
                '    waitDialog.Close()
                '    Mensajes.MensajeError(ex.Message)
                '    Return False
                'End Try
                'conn1.Close()

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                Dim myCMD As New OracleCommand()
                conn.ConnectionString = oradb
                conn.Open()
                Dim i As Integer = 0
                For Each row As System.Data.DataRow In dt.Rows
                    Try
                        myCMD.Connection = conn
                        myCMD.CommandText = "Insert into tmp_im_requisitos_x_candidato (CODIGO_CANDIDATO, CODIGO_PARTIDO, CODIGO_MOVIMIENTO, " _
                        & "CODIGO_REQUISITO, CANTIDAD, IMAGEN, ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, ESTADO, tipo_sistema) " _
                        & "VALUES ('" & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', '" & row.Item(3).ToString _
                        & "', '" & row.Item(4).ToString & "', null, 'TSE', to_date('" & DateTime.Now & "','dd/mm/yyyy hh:mi:ss p.m.'), null, null, '" & row.Item(5).ToString & "','E')"
                        myCMD.CommandType = CommandType.Text
                        myCMD.ExecuteOracleScalar()

                        i = i + 1
                        If i Mod 1000 = 0 Then
                            Dialog1.LabelControl1.Text = "Se han procesado " & i & " registros. Procesando por favor espere..."
                            If Dialog1.Visible = False Then
                                Dialog1.ShowDialog()
                            End If
                        End If
                    Catch ex As Exception
                        conn.Close()
                        'waitDialog.Caption = "finalizando..."
                        'waitDialog.Close()
                        Mensajes.MensajeError(ex.Message)
                        Return False
                    End Try
                Next
                conn.Close()
            End Using
            'waitDialog.Caption = "finalizando..."
            'waitDialog.Close()
            MsgBox("La Importación de Requisitos por Candidato ha terminado exitosamente", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            'waitDialog.Caption = "finalizando..."
            'waitDialog.Close()
            Mensajes.MensajeError(ex.Message)
            Return False
        End Try
    End Function

    Private Function subir_firmas(ByVal Filename As String) As Boolean
        'Dim waitDialog As New WaitDialogForm("Procesando Información", "Por favor espere..")
        Try
            Dim extension As String = IO.Path.GetExtension(Filename)
            Dim connString As String = "Data Source=" & Filename

            If (extension = ".xls") Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0; Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"
            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
            Else
                Mensajes.MensajeError("El tipo de archivo seleccionado no esta permitido")
                'waitDialog.Caption = "finalizando..."
                'waitDialog.Close()
                Return False
            End If

            Using conexion As New OleDbConnection(connString)
                Dim sql As String = "SELECT * FROM [firmas$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)
                Dim dt As New DataTable("Excel")
                adaptador.Fill(dt)

                'Dim oradb1 As String = Configuracion.verconfig
                'Dim conn1 As New OracleConnection()
                'Dim myCMD1 As New OracleCommand()
                'conn1.ConnectionString = oradb1
                'conn1.Open()
                'Try
                '    myCMD1.Connection = conn1
                '    myCMD1.CommandText = "Delete tmp_im_ciudadanos_respaldan"
                '    myCMD1.CommandType = CommandType.Text
                '    myCMD1.ExecuteOracleScalar()
                'Catch ex As Exception
                '    conn1.Close()
                '    'waitDialog.Caption = "finalizando..."
                '    'waitDialog.Close()
                '    Mensajes.MensajeError(ex.Message)
                '    Return False
                'End Try
                'conn1.Close()

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                Dim myCMD As New OracleCommand()
                Dim i As Integer = 0
                conn.ConnectionString = oradb
                conn.Open()
                Try
                    myCMD.Connection = conn
                    For Each row As System.Data.DataRow In dt.Rows
                        myCMD.CommandText = "Insert into TMP_IM_CIUDADANOS_RESPALDAN(CODIGO_CUIDADANOS_RESPALDAN, IDENTIDAD, " _
                        & "PRIMER_NOMBRE_PAPELETA, SEGUNDO_NOMBRE_PAPELETA, PRIMER_APELLIDO_PAPELETA, SEGUNDO_APELLIDO_PAPELETA, CODIGO_PARTIDO, " _
                        & "CODIGO_MOVIMIENTO, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, FIRMA, HUELLA, DIRECCION,  NOMBRE_IGUAL, " _
                        & "FOLIO, ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, " _
                        & "CONSISTENTE, OBSERVACION, MAQUINA, PAGINA) " _
                        & "VALUES ('" & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', '" & row.Item(3).ToString _
                        & "', '" & row.Item(4).ToString & "', '" & row.Item(5).ToString & "', '" & row.Item(6).ToString _
                        & "', '" & row.Item(7).ToString & "', '" & row.Item(8).ToString & "', '" & row.Item(9).ToString _
                        & "', '" & row.Item(10).ToString & "', '" & row.Item(11).ToString & "', '" & row.Item(12).ToString _
                        & "', '" & row.Item(13).ToString & "', '" & row.Item(14).ToString _
                        & "', 'TSE', to_date('" & DateTime.Now & "','dd/mm/yyyy hh:mi:ss p.m.'), null, null, '" _
                        & row.Item(15).ToString & "', '" & row.Item(16).ToString & "', '" & row.Item(17).ToString & "', '" & row.Item(18).ToString & "')"
                        myCMD.CommandType = CommandType.Text
                        myCMD.ExecuteOracleScalar()
                        'CoWaitForMultipleHandles(
                        i = i + 1
                        If i Mod 1000 = 0 Then
                            Dialog1.LabelControl1.Text = "Se han procesado " & i & " registros. Procesando por favor espere..."
                            If Dialog1.Visible = False Then
                                Dialog1.ShowDialog()
                            End If
                        End If
                    Next
                Catch ex As Exception
                    conn.Close()
                    ' waitDialog.Caption = "finalizando..."
                    'waitDialog.Close()
                    Mensajes.MensajeError(ex.Message)
                    Return False
                End Try
                conn.Close()
            End Using
            'waitDialog.Caption = "finalizando..."
            'waitDialog.Close()
            Dialog1.Hide()
            MsgBox("La Importación de Firmas ha terminado exitosamente", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            'waitDialog.Caption = "finalizando..."
            'waitDialog.Close()
            Mensajes.MensajeError(ex.Message)
            Return False
        End Try
    End Function

    Private Function subir_movimientos(ByVal Filename As String) As Boolean
        'Dim waitDialog As New WaitDialogForm("Procesando Información", "Por favor espere..")
        Try
            Dim extension As String = IO.Path.GetExtension(Filename)
            Dim connString As String = "Data Source=" & Filename

            If (extension = ".xls") Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0; Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"
            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
            Else
                Mensajes.MensajeError("El tipo de archivo seleccionado no esta permitido")
                'waitDialog.Caption = "finalizando..."
                'waitDialog.Close()
                Return False
            End If

            Using conexion As New OleDbConnection(connString)
                Dim sql As String = "SELECT * FROM [movimientos$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)
                Dim dt As New DataTable("Excel")
                adaptador.Fill(dt)

                'Dim oradb1 As String = Configuracion.verconfig
                'Dim conn1 As New OracleConnection()
                'Dim myCMD1 As New OracleCommand()
                'conn1.ConnectionString = oradb1
                'conn1.Open()
                'Try
                '    myCMD1.Connection = conn1
                '    myCMD1.CommandText = "Delete tmp_im_movimientos"
                '    myCMD1.CommandType = CommandType.Text
                '    myCMD1.ExecuteOracleScalar()
                'Catch ex As Exception
                '    conn1.Close()
                '    waitDialog.Caption = "finalizando..."
                '    waitDialog.Close()
                '    Mensajes.MensajeError(ex.Message)
                '    Return False
                'End Try
                'conn1.Close()

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                Dim myCMD As New OracleCommand()
                conn.ConnectionString = oradb
                conn.Open()
                Dim i As Integer = 0
                For Each row As System.Data.DataRow In dt.Rows
                    Try
                        myCMD.Connection = conn
                        myCMD.CommandText = "Insert into tmp_im_movimientos(CODIGO_PARTIDO, CODIGO_MOVIMIENTO, NOMBRE_MOVIMIENTO, INSIGNIA, EMBLEMA, " _
                        & "ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION) " _
                        & "VALUES ('" & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', null, null," _
                        & "'TSE', to_date('" & DateTime.Now & "','dd/mm/yyyy hh:mi:ss p.m.'), null, null)"
                        myCMD.CommandType = CommandType.Text
                        myCMD.ExecuteOracleScalar()

                        i = i + 1
                        If i Mod 1000 = 0 Then
                            Dialog1.LabelControl1.Text = "Se han procesado " & i & " registros. Procesando por favor espere..."
                            If Dialog1.Visible = False Then
                                Dialog1.ShowDialog()
                            End If
                        End If
                    Catch ex As Exception
                        conn.Close()
                        'waitDialog.Caption = "finalizando..."
                        'waitDialog.Close()
                        Mensajes.MensajeError(ex.Message)
                        Return False
                    End Try
                Next
                conn.Close()
            End Using
            'waitDialog.Caption = "finalizando..."
            'waitDialog.Close()
            MsgBox("La Importación de Movimientos ha terminado exitosamente", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            'waitDialog.Caption = "finalizando..."
            'waitDialog.Close()
            Mensajes.MensajeError(ex.Message)
            Return False
        End Try
    End Function

    Private Function subir_imagenes(ByVal FolderPath As String) As Boolean
        Dim Archivo As FileInfo
        Dim campos() As String
        Dim identidad As String
        Dim requisito As String

        Try
            For Each sFichero As String In Directory.GetFiles(FolderPath, "*.jpg", SearchOption.TopDirectoryOnly)
                Archivo = New FileInfo(sFichero)

                campos = Split(Archivo.Name, ".")
                If campos(0) <> "EMBLEMA" Then
                    campos = Nothing
                    campos = Split(Archivo.Name, "_")
                    For i = LBound(campos) To UBound(campos)
                        If i = 0 Then
                            identidad = campos(i)
                        ElseIf i = 1 Then
                            requisito = campos(i)
                        End If
                    Next
                    If Not IsDBNull(requisito) Then
                        campos = Split(requisito, ".")
                        requisito = campos(0)
                    End If

                    Dim oradb As String = Configuracion.verconfig
                    Dim conn As New OracleConnection()
                    conn.ConnectionString = oradb
                    conn.Open()

                    Dim sql As String = "select codigo_candidatos, codigo_partido, codigo_movimiento from tmp_im_candidatos where identidad = '" & identidad & "'"
                    Dim cmd As New OracleCommand(sql, conn)
                    cmd.CommandType = CommandType.Text
                    Dim chek As OracleDataReader = cmd.ExecuteReader()
                    If chek.Read And (requisito = "7" Or requisito = "8") Then
                        Dim oa As OracleDataAdapter = New OracleDataAdapter(sql, conn)
                        Dim ds As DataSet = New DataSet()
                        oa.Fill(ds)
                        Dim i As Integer = 0
                        For Each row As System.Data.DataRow In ds.Tables(0).Rows
                            Try
                                Dim oradb1 As String = Configuracion.verconfig
                                Dim conn1 As New OracleConnection()
                                conn1.ConnectionString = oradb1
                                conn1.Open()

                                Dim sql1 As String = "update tmp_im_requisitos_x_candidato set imagen = :pbi_imagen " _
                                & "where codigo_candidato = '" & row.Item("codigo_candidatos") & "' " _
                                & "And codigo_partido = '" & row.Item("codigo_partido") & "' " _
                                & "And codigo_movimiento = '" & row.Item("codigo_movimiento") & "' " _
                                & "and codigo_requisito = '" & requisito & "'"
                                Dim cmd1 As OracleCommand = New OracleCommand(sql1, conn1)
                                cmd1.Parameters.Add(":pbi_imagen", OracleType.Blob).Value = Data.ConvertImageToByteArray(Image.FromFile(Archivo.FullName))
                                cmd1.ExecuteOracleScalar()

                                i = i + 1
                                If i Mod 1000 = 0 Then
                                    Dialog1.LabelControl1.Text = "Se han procesado " & i & " registros. Procesando por favor espere..."
                                    If Dialog1.Visible = False Then
                                        Dialog1.ShowDialog()
                                    End If
                                End If
                            Catch ex As Exception
                                conn.Close()
                                Mensajes.MensajeError(ex.Message)
                                Return False
                            End Try
                        Next
                    End If
                    conn.Close()
                Else
                    Dim oradb1 As String = Configuracion.verconfig
                    Dim conn1 As New OracleConnection()
                    conn1.ConnectionString = oradb1
                    conn1.Open()

                    Dim sql1 As String = "update tmp_im_movimientos set insignia = :pbi_imagen "
                    Dim cmd1 As OracleCommand = New OracleCommand(sql1, conn1)
                    cmd1.Parameters.Add(":pbi_imagen", OracleType.Blob).Value = Data.ConvertImageToByteArray(Image.FromFile(Archivo.FullName))
                    cmd1.ExecuteOracleScalar()
                End If

            Next
        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
            Return False
        End Try
        MsgBox("La Importación de Imágenes ha terminado exitosamente", MsgBoxStyle.Information)
        Return True
    End Function

    Private Function subir_imagenes_firmas(ByVal FolderPath As String) As Boolean
        Dim Archivo As FileInfo
        Dim campos() As String
        'Dim identidad As String
        'Dim requisito As String

        Try
            For Each sFichero As String In Directory.GetFiles(FolderPath, "*.jpg", SearchOption.TopDirectoryOnly)
                Archivo = New FileInfo(sFichero)

                campos = Split(Archivo.Name, ".")
                'If campos(0) <> "EMBLEMA" Then
                'campos = Nothing
                'campos = Split(Archivo.Name, "_")
                'For i = LBound(campos) To UBound(campos)
                '    If i = 0 Then
                '        identidad = campos(i)
                '    ElseIf i = 1 Then
                '        requisito = campos(i)
                '    End If
                'Next
                'If Not IsDBNull(requisito) Then
                '    campos = Split(requisito, ".")
                '    requisito = campos(0)
                'End If

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                conn.ConnectionString = oradb
                conn.Open()

                Dim sql As String = "select codigo_partido, codigo_movimiento from tmp_im_movimientos where rownum = 1"
                Dim cmd As New OracleCommand(sql, conn)
                cmd.CommandType = CommandType.Text
                Dim chek As OracleDataReader = cmd.ExecuteReader()
                If chek.Read Then
                    Dim oa As OracleDataAdapter = New OracleDataAdapter(sql, conn)
                    Dim ds As DataSet = New DataSet()
                    oa.Fill(ds)
                    Dim i As Integer = 0
                    For Each row As System.Data.DataRow In ds.Tables(0).Rows
                        Try
                            Dim oradb1 As String = Configuracion.verconfig
                            Dim conn1 As New OracleConnection()
                            conn1.ConnectionString = oradb1
                            conn1.Open()

                            Dim sql1 As String = "insert into tmp_im_imagenes_firmas (codigo_partido, codigo_movimiento, pagina, folio, imagen, maquina) " _
                            & "values ('" & row.Item("codigo_partido") & "', '" & row.Item("codigo_movimiento") & "', '" & campos(0) & "', '" & campos(0) & "', :pbi_imagen, 'externo')"
                            Dim cmd1 As OracleCommand = New OracleCommand(sql1, conn1)
                            cmd1.Parameters.Add(":pbi_imagen", OracleType.Blob).Value = Data.ConvertImageToByteArray(Image.FromFile(Archivo.FullName))
                            cmd1.ExecuteOracleScalar()

                            i = i + 1
                            If i Mod 1000 = 0 Then
                                Dialog1.LabelControl1.Text = "Se han procesado " & i & " registros. Procesando por favor espere..."
                                If Dialog1.Visible = False Then
                                    Dialog1.ShowDialog()
                                End If
                            End If
                        Catch ex As Exception
                            conn.Close()
                            Mensajes.MensajeError(ex.Message)
                            Return False
                        End Try
                    Next
                End If
                conn.Close()
                'Else
                'Dim oradb1 As String = Configuracion.verconfig
                'Dim conn1 As New OracleConnection()
                'conn1.ConnectionString = oradb1
                'conn1.Open()

                'Dim sql1 As String = "update tmp_im_movimientos set insignia = :pbi_imagen "
                'Dim cmd1 As OracleCommand = New OracleCommand(sql1, conn1)
                'cmd1.Parameters.Add(":pbi_imagen", OracleType.Blob).Value = Data.ConvertImageToByteArray(Image.FromFile(Archivo.FullName))
                'cmd1.ExecuteOracleScalar()
                'End If

            Next
        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
            Return False
        End Try
        MsgBox("La Importación de Imágenes de Firmas ha terminado exitosamente", MsgBoxStyle.Information)
        Return True
    End Function

    Private Sub BtnExplorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExplorar.Click
        If Me.BtnImagenes.Enabled = True Or Me.BtnImagenesFirmas.Enabled = True Then
            Me.FbUbicacion.ShowDialog()
            Me.TxtRuta.EditValue = FbUbicacion.SelectedPath
        Else
            Me.OpenFileDialog1.ShowDialog()
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.TxtRuta.Text = OpenFileDialog1.FileName
    End Sub
End Class