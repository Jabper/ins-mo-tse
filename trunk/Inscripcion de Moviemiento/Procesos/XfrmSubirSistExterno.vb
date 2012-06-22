Imports System.Data.OleDb
Imports System.Data.OracleClient
Imports DevExpress.Utils

Public Class XfrmSubirSistExterno

    Private Sub XfrmSubirSistExterno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BtnCandidatos.Height = Me.BtnCandidatos.Height + 15
        Me.BtnCandidatos.Width = Me.BtnCandidatos.Width + 15
        Dim punto As Point = New Point(Me.BtnCandidatos.Location.X - 7.5, Me.BtnCandidatos.Location.Y - 7.5)
        Me.BtnCandidatos.Location = punto
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEjecutar.Click
        Dim retorno As Boolean
        If Me.BtnCandidatos.Enabled = True Then
            retorno = subir_candidatos(Me.TxtRuta.Text)
            If retorno = True Then
                Me.TxtRuta.Text = Nothing

                Me.BtnCandidatos.Height = Me.BtnCandidatos.Height - 15
                Me.BtnCandidatos.Width = Me.BtnCandidatos.Width - 15
                Dim punto As Point = New Point(Me.BtnCandidatos.Location.X + 7.5, Me.BtnCandidatos.Location.Y + 7.5)
                Me.BtnCandidatos.Location = punto
                Me.BtnCandidatos.ForeColor = Color.Black
                Me.BtnCandidatos.Enabled = False

                Me.BtnCandidatosRepetidos.Enabled = True
                Me.BtnCandidatosRepetidos.ForeColor = Color.LimeGreen
                Me.BtnCandidatosRepetidos.Height = Me.BtnCandidatosRepetidos.Height + 15
                Me.BtnCandidatosRepetidos.Width = Me.BtnCandidatosRepetidos.Width + 15
                punto = New Point(Me.BtnCandidatosRepetidos.Location.X - 7.5, Me.BtnCandidatosRepetidos.Location.Y - 7.5)
                Me.BtnCandidatosRepetidos.Location = punto
                Exit Sub
            End If        
        End If
        If Me.BtnCandidatosRepetidos.Enabled = True Then
            retorno = subir_candidatos_repetidos(Me.TxtRuta.Text)
            If retorno = True Then
                Me.TxtRuta.Text = Nothing

                Me.BtnCandidatosRepetidos.Height = Me.BtnCandidatosRepetidos.Height - 15
                Me.BtnCandidatosRepetidos.Width = Me.BtnCandidatosRepetidos.Width - 15
                Dim punto As Point = New Point(Me.BtnCandidatosRepetidos.Location.X + 7.5, Me.BtnCandidatosRepetidos.Location.Y + 7.5)
                Me.BtnCandidatosRepetidos.Location = punto
                Me.BtnCandidatosRepetidos.ForeColor = Color.Black
                Me.BtnCandidatosRepetidos.Enabled = False

                Me.BtnRequisitos.Enabled = True
                Me.BtnRequisitos.ForeColor = Color.LimeGreen
                Me.BtnRequisitos.Height = Me.BtnRequisitos.Height + 15
                Me.BtnRequisitos.Width = Me.BtnRequisitos.Width + 15
                punto = New Point(Me.BtnRequisitos.Location.X - 7.5, Me.BtnRequisitos.Location.Y - 7.5)
                Me.BtnRequisitos.Location = punto
                Exit Sub
            End If
        End If
        If Me.BtnRequisitos.Enabled = True Then
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
                Exit Sub
            End If
        End If
        If Me.BtnFirmas.Enabled = True Then
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
                Exit Sub
            End If
        End If
        If Me.BtnMovimiento.Enabled = True Then
            retorno = subir_movimientos(Me.TxtRuta.Text)
        End If
    End Sub

    Private Function subir_candidatos(ByVal Filename As String) As Boolean
        Dim waitDialog As New WaitDialogForm("Procesando Información", "Por favor espere..")
        Try
            Dim extension As String = IO.Path.GetExtension(Filename)
            Dim connString As String = "Data Source=" & Filename

            If (extension = ".xls") Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0; Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"
            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
            Else
                waitDialog.Caption = "finalizando..."
                waitDialog.Close()
                Mensajes.MensajeError("El tipo de archivo seleccionado no esta permitido")
                Return False
            End If

            Using conexion As New OleDbConnection(connString)
                Dim sql As String = "SELECT * FROM [Candidatos$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)
                Dim dt As New DataTable("Excel")
                adaptador.Fill(dt)

                Dim oradb1 As String = Configuracion.verconfig
                Dim conn1 As New OracleConnection()
                Dim myCMD1 As New OracleCommand()
                conn1.ConnectionString = oradb1
                conn1.Open()
                Try
                    myCMD1.Connection = conn1
                    myCMD1.CommandText = "Delete tmp_im_candidatos"
                    myCMD1.CommandType = CommandType.Text
                    myCMD1.ExecuteOracleScalar()
                Catch ex As Exception
                    conn1.Close()
                    waitDialog.Caption = "finalizando..."
                    waitDialog.Close()
                    Mensajes.MensajeError(ex.Message)
                    Return False
                End Try
                conn1.Close()

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                Dim myCMD As New OracleCommand()               
                conn.ConnectionString = oradb
                conn.Open()
                For Each row As System.Data.DataRow In dt.Rows
                    Try
                        myCMD.Connection = conn
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
                    Catch ex As Exception
                        conn.Close()
                        waitDialog.Caption = "finalizando..."
                        waitDialog.Close()
                        Mensajes.MensajeError(ex.Message)
                        Return False
                    End Try                   
                Next
                conn.Close()
            End Using
            waitDialog.Caption = "finalizando..."
            waitDialog.Close()
            MsgBox("La Importacion de Candidatos ha terminado exitosamente", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            waitDialog.Caption = "finalizando..."
            waitDialog.Close()            
            Mensajes.MensajeError(ex.Message)
            Return False
        End Try
    End Function

    Private Function subir_candidatos_repetidos(ByVal Filename As String) As Boolean
        Dim waitDialog As New WaitDialogForm("Procesando Información", "Por favor espere..")
        Try
            Dim extension As String = IO.Path.GetExtension(Filename)
            Dim connString As String = "Data Source=" & Filename

            If (extension = ".xls") Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0; Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"
            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
            Else
                Mensajes.MensajeError("El tipo de archivo seleccionado no esta permitido")
                waitDialog.Caption = "finalizando..."
                waitDialog.Close()
                Return False
            End If

            Using conexion As New OleDbConnection(connString)
                Dim sql As String = "SELECT * FROM [Candidatos_Repetidos$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)
                Dim dt As New DataTable("Excel")
                adaptador.Fill(dt)

                Dim oradb1 As String = Configuracion.verconfig
                Dim conn1 As New OracleConnection()
                Dim myCMD1 As New OracleCommand()
                conn1.ConnectionString = oradb1
                conn1.Open()
                Try
                    myCMD1.Connection = conn1
                    myCMD1.CommandText = "Delete tmp_im_candidatos_repetidos"
                    myCMD1.CommandType = CommandType.Text
                    myCMD1.ExecuteOracleScalar()
                Catch ex As Exception
                    conn1.Close()
                    waitDialog.Caption = "finalizando..."
                    waitDialog.Close()
                    Mensajes.MensajeError(ex.Message)
                    Return False
                End Try
                conn1.Close()

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                Dim myCMD As New OracleCommand()
                conn.ConnectionString = oradb
                conn.Open()
                For Each row As System.Data.DataRow In dt.Rows
                    Try
                        myCMD.Connection = conn
                        myCMD.CommandText = "Insert into tmp_im_candidatos_repetidos (IDENTIDAD, CODIGO_MOVIMIENTO, CODIGO_PARTIDO," _
                        & " ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, ESTADO) VALUES ('" _
                        & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', 'TSE'" _
                        & ", to_date('" & DateTime.Now & "','dd/mm/yyyy hh:mi:ss p.m.'), null, null, '" & row.Item(3).ToString & "')"
                        myCMD.CommandType = CommandType.Text
                        myCMD.ExecuteOracleScalar()
                    Catch ex As Exception
                        conn.Close()
                        waitDialog.Caption = "finalizando..."
                        waitDialog.Close()
                        Mensajes.MensajeError(ex.Message)
                        Return False
                    End Try
                Next
                conn.Close()
            End Using
            waitDialog.Caption = "finalizando..."
            waitDialog.Close()
            MsgBox("La Importacion de Candidatos Repetidos ha terminado exitosamente", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            waitDialog.Caption = "finalizando..."
            waitDialog.Close()
            Mensajes.MensajeError(ex.Message)
            Return False
        End Try
    End Function

    Private Function subir_requisitos_x_candidato(ByVal Filename As String) As Boolean
        Dim waitDialog As New WaitDialogForm("Procesando Información", "Por favor espere..")
        Try
            Dim extension As String = IO.Path.GetExtension(Filename)
            Dim connString As String = "Data Source=" & Filename

            If (extension = ".xls") Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0; Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"
            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
            Else
                Mensajes.MensajeError("El tipo de archivo seleccionado no esta permitido")
                waitDialog.Caption = "finalizando..."
                waitDialog.Close()
                Return False
            End If

            Using conexion As New OleDbConnection(connString)
                Dim sql As String = "SELECT * FROM [requisitos_x_candidato$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)
                Dim dt As New DataTable("Excel")
                adaptador.Fill(dt)

                Dim oradb1 As String = Configuracion.verconfig
                Dim conn1 As New OracleConnection()
                Dim myCMD1 As New OracleCommand()
                conn1.ConnectionString = oradb1
                conn1.Open()
                Try
                    myCMD1.Connection = conn1
                    myCMD1.CommandText = "Delete tmp_im_requisitos_x_candidato"
                    myCMD1.CommandType = CommandType.Text
                    myCMD1.ExecuteOracleScalar()
                Catch ex As Exception
                    conn1.Close()
                    waitDialog.Caption = "finalizando..."
                    waitDialog.Close()
                    Mensajes.MensajeError(ex.Message)
                    Return False
                End Try
                conn1.Close()

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                Dim myCMD As New OracleCommand()
                conn.ConnectionString = oradb
                conn.Open()
                For Each row As System.Data.DataRow In dt.Rows
                    Try
                        myCMD.Connection = conn
                        myCMD.CommandText = "Insert into tmp_im_requisitos_x_candidato (CODIGO_CANDIDATO, CODIGO_PARTIDO, CODIGO_MOVIMIENTO, " _
                        & "CODIGO_REQUISITO, CANTIDAD, IMAGEN, ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, ESTADO) " _
                        & "VALUES ('" & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', '" & row.Item(3).ToString _
                        & "', '" & row.Item(4).ToString & "', null, 'TSE', to_date('" & DateTime.Now & "','dd/mm/yyyy hh:mi:ss p.m.'), null, null, '" & row.Item(5).ToString & "')"
                        myCMD.CommandType = CommandType.Text                        
                        myCMD.ExecuteOracleScalar()
                    Catch ex As Exception
                        conn.Close()
                        waitDialog.Caption = "finalizando..."
                        waitDialog.Close()
                        Mensajes.MensajeError(ex.Message)
                        Return False
                    End Try
                Next
                conn.Close()
            End Using
            waitDialog.Caption = "finalizando..."
            waitDialog.Close()
            MsgBox("La Importacion de Requisitos por Candidato ha terminado exitosamente", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            waitDialog.Caption = "finalizando..."
            waitDialog.Close()
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

                Dim oradb1 As String = Configuracion.verconfig
                Dim conn1 As New OracleConnection()
                Dim myCMD1 As New OracleCommand()
                conn1.ConnectionString = oradb1
                conn1.Open()
                Try
                    myCMD1.Connection = conn1
                    myCMD1.CommandText = "Delete tmp_im_ciudadanos_respaldan"
                    myCMD1.CommandType = CommandType.Text
                    myCMD1.ExecuteOracleScalar()
                Catch ex As Exception
                    conn1.Close()
                    'waitDialog.Caption = "finalizando..."
                    'waitDialog.Close()
                    Mensajes.MensajeError(ex.Message)
                    Return False
                End Try
                conn1.Close()

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
                        & "FOLIO, IMAGEN_FIRMA, ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, " _
                        & "CONSISTENTE, OBSERVACION, MAQUINA, PAGINA) " _
                        & "VALUES ('" & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', '" & row.Item(3).ToString _
                        & "', '" & row.Item(4).ToString & "', '" & row.Item(5).ToString & "', '" & row.Item(6).ToString _
                        & "', '" & row.Item(7).ToString & "', '" & row.Item(8).ToString & "', '" & row.Item(9).ToString _
                        & "', '" & row.Item(10).ToString & "', '" & row.Item(11).ToString & "', '" & row.Item(12).ToString _
                        & "', '" & row.Item(13).ToString & "', '" & row.Item(14).ToString _
                        & "', null, 'TSE', to_date('" & DateTime.Now & "','dd/mm/yyyy hh:mi:ss p.m.'), null, null, '" _
                        & row.Item(15).ToString & "', '" & row.Item(16).ToString & "', '" & row.Item(17).ToString & "', '" & row.Item(18).ToString & "')"
                        myCMD.CommandType = CommandType.Text
                        myCMD.ExecuteOracleScalar()
                        'CoWaitForMultipleHandles(
                        i = i + 1
                        If i Mod 5000 = 0 Then
                            MsgBox("Se ha procesado " & i & " registros. Procesando por favor espere...")
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
            MsgBox("La Importacion de Firmas ha terminado exitosamente", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            'waitDialog.Caption = "finalizando..."
            'waitDialog.Close()
            Mensajes.MensajeError(ex.Message)
            Return False
        End Try
    End Function

    Private Function subir_movimientos(ByVal Filename As String) As Boolean
        Dim waitDialog As New WaitDialogForm("Procesando Información", "Por favor espere..")
        Try
            Dim extension As String = IO.Path.GetExtension(Filename)
            Dim connString As String = "Data Source=" & Filename

            If (extension = ".xls") Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0; Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"
            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0; Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
            Else
                Mensajes.MensajeError("El tipo de archivo seleccionado no esta permitido")
                waitDialog.Caption = "finalizando..."
                waitDialog.Close()
                Return False
            End If

            Using conexion As New OleDbConnection(connString)
                Dim sql As String = "SELECT * FROM [movimientos$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)
                Dim dt As New DataTable("Excel")
                adaptador.Fill(dt)

                Dim oradb1 As String = Configuracion.verconfig
                Dim conn1 As New OracleConnection()
                Dim myCMD1 As New OracleCommand()
                conn1.ConnectionString = oradb1
                conn1.Open()
                Try
                    myCMD1.Connection = conn1
                    myCMD1.CommandText = "Delete tmp_im_movimientos"
                    myCMD1.CommandType = CommandType.Text
                    myCMD1.ExecuteOracleScalar()
                Catch ex As Exception
                    conn1.Close()
                    waitDialog.Caption = "finalizando..."
                    waitDialog.Close()
                    Mensajes.MensajeError(ex.Message)
                    Return False
                End Try
                conn1.Close()

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                Dim myCMD As New OracleCommand()
                conn.ConnectionString = oradb
                conn.Open()
                For Each row As System.Data.DataRow In dt.Rows
                    Try
                        myCMD.Connection = conn
                        myCMD.CommandText = "Insert into tmp_im_movimientos(CODIGO_PARTIDO, CODIGO_MOVIMIENTO, NOMBRE_MOVIMIENTO, INSIGNIA, EMBLEMA, " _
                        & "ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION) " _
                        & "VALUES ('" & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', null, null," _
                        & "'TSE', to_date('" & DateTime.Now & "','dd/mm/yyyy hh:mi:ss p.m.'), null, null)"
                        myCMD.CommandType = CommandType.Text                        
                        myCMD.ExecuteOracleScalar()
                    Catch ex As Exception
                        conn.Close()
                        waitDialog.Caption = "finalizando..."
                        waitDialog.Close()
                        Mensajes.MensajeError(ex.Message)
                        Return False
                    End Try
                Next
                conn.Close()
            End Using
            waitDialog.Caption = "finalizando..."
            waitDialog.Close()
            MsgBox("La Importacion de Movimientos ha terminado exitosamente", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            waitDialog.Caption = "finalizando..."
            waitDialog.Close()
            Mensajes.MensajeError(ex.Message)
            Return False
        End Try
    End Function

    Private Sub BtnExplorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExplorar.Click
        Me.OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.TxtRuta.Text = OpenFileDialog1.FileName
    End Sub
End Class