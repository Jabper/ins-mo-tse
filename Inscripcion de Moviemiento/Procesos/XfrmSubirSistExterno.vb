Imports System.Data.OleDb
Imports System.Data.OracleClient
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

        Try
            Dim oradb7 As String = Configuracion.verconfig
            Dim conn7 As New OracleConnection()
            conn7.ConnectionString = oradb7
            conn7.Open()
            Dim myCMD7 As New OracleCommand()
            myCMD7.Connection = conn7
            myCMD7.CommandText = "IM_P_BORRAR_TABLAS_EXPORTADAS"
            myCMD7.CommandType = CommandType.StoredProcedure
            myCMD7.Parameters.Add(New OracleParameter("pvo_mensaje", OracleType.NVarChar, 500)).Direction = ParameterDirection.Output
            myCMD7.ExecuteOracleScalar()
            If Trim(myCMD7.Parameters("pvo_mensaje").Value) <> "OK" Then
                Mensajes.MensajeError(myCMD7.Parameters("pvo_mensaje").Value)
            End If
            conn7.Close()
        Catch ex As Exception
            'conn7.Close()
            Mensajes.MensajeError(ex.Message)
        End Try
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
                            'mensaje = "ERROR"
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
                            & "to_date('" & DateTime.Now.Date & "','dd/mm/yyyy'),'" & DateTime.Now.ToLongTimeString & "', 'SISTEMA EXTERNO'" _
                            & "," & 0 & "," & partido & ",'" & movimiento & "'," & cantidad_candidatos _
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

                        Dim conn7 As New OracleConnection()
                        Try
                            MsgBox("A continuación se ejecutarán los procesos de validación sobre los datos importados")
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
                        Catch ex As Exception
                            conn7.Close()
                            Mensajes.MensajeError(ex.Message)
                        End Try

                        If reporte = "OK" Then
                            'llamar reporte
                            Dim reporte_import As REPORTE_REGISTRO_IMPORTACIONES_1 = New REPORTE_REGISTRO_IMPORTACIONES_1
                            reporte_import.ShowPreview()
                        Else
                            MsgBox("New se pudo generar el recibo de importacion de datos")
                        End If

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
                        myCMD.CommandText = "Insert into tmp_im_candidatos (CODIGO_CANDIDATOS, IDENTIDAD, PRIMER_NOMBRE,SEGUNDO_NOMBRE,PRIMER_APELLIDO,SEGUNDO_APELLIDO, POSICION, " _
                        & "CODIGO_CARGO_ELECTIVO,  CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, CODIGO_PARTIDO, CODIGO_MOVIMIENTO, " _
                        & "ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, " _
                        & "ESTADO, VALIDADO) VALUES ('" _
                        & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', '" & row.Item(3).ToString & "', '" & row.Item(4).ToString & "', '" & row.Item(5).ToString _
                        & "', '" & row.Item(6).ToString & "', '" & row.Item(7).ToString & "', '" & row.Item(8).ToString & "', '" & row.Item(9).ToString _
                        & "', '" & row.Item(10).ToString & "', '" & row.Item(11).ToString & "', '" & usuario & "', to_date('" & DateTime.Now.Date & "','dd/mm/yyyy')" _
                        & ", null, null, 'H',null)"
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
                Dim sql As String = "SELECT * FROM [requisitos$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)
                Dim dt As New DataTable("Excel")
                adaptador.Fill(dt)

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
                        & "', '1', null, '" & usuario & "', to_date('" & DateTime.Now.Date & "','dd/mm/yyyy'), null, null, 'C','E')"
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
                        & "CONSISTENTE, OBSERVACION, MAQUINA, PAGINA, VALIDADO) " _
                        & "VALUES ('" & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', '" & row.Item(3).ToString _
                        & "', '" & row.Item(4).ToString & "', '" & row.Item(5).ToString & "', '" & row.Item(6).ToString _
                        & "', '" & row.Item(7).ToString & "', '" & row.Item(8).ToString & "', '" & row.Item(9).ToString _
                        & "', '" & row.Item(10).ToString & "', '" & row.Item(11).ToString & "', '" & row.Item(12).ToString _
                        & "', 'S', '" & row.Item(13).ToString _
                        & "', '" & usuario & "', to_date('" & DateTime.Now.Date & "','dd/mm/yyyy'), null, null, 'S',null, 'EXTERNO','" _
                        & row.Item(14).ToString & "',null)"
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
                Dim sql As String = "SELECT * FROM [movimiento$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)
                Dim dt As New DataTable("Excel")
                adaptador.Fill(dt)

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
                        & "ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, TIPO_SISTEMA) " _
                        & "VALUES ('" & row.Item(0).ToString & "', '" & row.Item(1).ToString & "', '" & row.Item(2).ToString & "', null, null,'" _
                        & usuario & "', to_date('" & DateTime.Now.Date & "','dd/mm/yyyy'), null, null,'E')"
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
                If campos(0) <> "INSIGNIA" Then
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
                                If i Mod 100 = 0 Then
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

        Try            
            For Each sFichero As String In Directory.GetFiles(FolderPath, "*.jpg", SearchOption.TopDirectoryOnly)
                Archivo = New FileInfo(sFichero)

                campos = Split(Archivo.Name, ".")

                Dim oradb As String = Configuracion.verconfig
                Dim conn As New OracleConnection()
                conn.ConnectionString = oradb
                conn.Open()

                Dim sql As String = "select codigo_partido, codigo_movimiento from tmp_im_movimientos where rownum = 1"
                Dim cmd As New OracleCommand(sql, conn)
                cmd.CommandType = CommandType.Text
                Dim chek As OracleDataReader = cmd.ExecuteReader()
                If chek.Read Then
                    If IsNumeric(campos(0)) Then
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
                                If i Mod 100 = 0 Then
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
                End If
                conn.Close()
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

    Private Sub BtnCandidatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCandidatos.Click

    End Sub
End Class