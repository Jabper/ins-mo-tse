Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports System.Data.OracleClient

Public Class XfrmCiudadanos

    Public img As Image
    Dim imagesave As Boolean = False
    Dim vi As Integer = 0
    Dim errores As Integer = 0
    Public iddepto As Integer
    Public idmuni As Integer
    Public idpartido As Integer
    Public idmovimiento As Integer
    Public folio As String
    Public ArregloDeErrores As Integer = 0
    Public noinconsistentes As Integer = 0
    Public pagina As Integer = 0
    Dim mensajeerror As String
    Dim vinicio As Boolean = False
    Dim guardados As Integer = 0
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.KeyPreview = True

    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Sub guardarimagen()
        Try
            If img Is Nothing Then
            Else
                Dim cnx As New OracleConnection(Configuracion.verconfig)
                '
                'Data.ConvertImageToByteArray(Me.Imgimagen.EditValue)

                Dim sqlstring As String
                sqlstring = "INSERT INTO IM_IMAGENES_FIRMAS ( CODIGO_PARTIDO,CODIGO_MOVIMIENTO,PAGINA,FOLIO,IMAGEN) VALUES(:idp,:idmov,:pag,:folio,:imagen)"
                Dim cmd As New OracleCommand(sqlstring, cnx)
                cmd.Parameters.Add(":idp", OracleType.Number, 2).Value = idpartido
                cmd.Parameters.Add(":idmov", OracleType.Number, 3).Value = idmovimiento
                cmd.Parameters.Add(":pag", OracleType.Number).Value = pagina
                If folio = "" Or folio Is Nothing Then
                    cmd.Parameters.Add(":folio", OracleType.Number).Value = DBNull.Value
                Else
                    cmd.Parameters.Add(":folio", OracleType.Number).Value = folio
                End If
                cmd.Parameters.Add(":imagen", OracleType.Blob).Value = Data.ConvertImageToByteArray(img)
                cnx.Open()
                cmd.ExecuteNonQuery()
                cnx.Close()
                imagesave = True
            End If
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

        
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText

        If (e.Column.FieldName = "Fila") Then

            If e.RowHandle < 0 Then
                e.DisplayText = vi + 1

            Else
                e.DisplayText = e.RowHandle + 1
                vi = e.RowHandle + 1
            End If

        End If



    End Sub

    Private Sub GridView1_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GridView1.InvalidValueException
        e.ExceptionMode = ExceptionMode.DisplayError
        e.WindowCaption = "Error"
        e.ErrorText = mensajeerror
        GridView1.HideEditor()
    End Sub


    Private Sub GridView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        Dim view As GridView = TryCast(sender, GridView)

        If view.FocusedColumn.FieldName = "IDENTIDAD" Then

            If e.Value.ToString.Length <> 13 Then
                mensajeerror = "El número de digitos en el campo Identidad es incorrecto debe de ser igual a 13 digitos"
                e.Valid = False

            End If

            If IsNumeric(e.Value) = False Then
                mensajeerror = "El valor del número de indentidad debe de ser un valor numérico"
                e.Valid = False
            End If

            If (e.Value IsNot Nothing AndAlso Not e.Value.Equals(String.Empty)) = False Then
                mensajeerror = "Valor inválido"
                e.Valid = False

            End If
            Dim a As String = "select IDENTIDAD from IM_CIUDADANOS_RESPALDAN where IDENTIDAD='" & e.Value.ToString & "' and CODIGO_PARTIDO=" & idpartido & " and CODIGO_MOVIMIENTO=" & idmovimiento
            If COracle.ObtenerDatos(a, "IDENTIDAD") <> "N" Then
                mensajeerror = "Este firmante ya existe en su lista"
                e.Valid = False
            End If
        End If
    End Sub

    Sub salir()
        Me.Close()
    End Sub



    Private Sub XfrmCiudadanos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim view As GridView = GridView1
        If view.FocusedColumn.FieldName = "IDENTIDAD" Then
            VControles.solonumeros(e)
        End If
    End Sub
    Sub estadistico()
        CREstadistico.AsignarVariables(idpartido, idmovimiento)
        CREstadistico.calcular()

        Me.lblconsistentes.Text = Math.Round(CREstadistico.Firmasmovimiento, 0)
        Me.lblporcentaje.Text = Math.Round(CREstadistico.porcentaje, 2) & "%"
        Me.lblfirmasnecesarias.Text = Math.Round(CREstadistico.TotalFirmas, 0)
        Me.lblinconsistentes.Text = Math.Round(CREstadistico.FirmasInconsistentes, 0)
        lbltodos.Text = Math.Round((CREstadistico.Firmasmovimiento + CREstadistico.FirmasInconsistentes), 0)
    End Sub
    Private Sub XfrmCiudadanos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = XFrmMenuPrincipal
        Me.TA_DEPARTAMENTOSTableAdapter.Fill(Me.DSDeptoMuni.TA_DEPARTAMENTOS)
        Me.TA_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSPolitico.TA_PARTIDOS_POLITICOS)
        Estado.OptionsColumn.AllowEdit = False

    End Sub

    Sub establecer()
        'Partido
        Dim p As Integer = Me.CmbPartido.Properties.GetDataSourceRowIndex(Me.CmbPartido.Properties.Columns("CODIGO_PARTIDO"), idpartido)
        CmbPartido.EditValue = Me.CmbPartido.Properties.GetDataSourceValue(CmbPartido.Properties.ValueMember, p)
        Try
            Me.TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, idpartido)

        Catch ex As Exception

        End Try
        'Movimiento
        Dim m As Integer = Me.CmbMovimiento.Properties.GetDataSourceRowIndex(Me.CmbMovimiento.Properties.Columns("CODIGO_MOVIMIENTO"), idmovimiento)
        Me.CmbMovimiento.EditValue = Me.CmbMovimiento.Properties.GetDataSourceValue(Me.CmbMovimiento.Properties.ValueMember, m)
        'Departamento
        Dim d As Integer = Me.CmbDepartamento.Properties.GetDataSourceRowIndex(Me.CmbDepartamento.Properties.Columns("CODIGO_DEPARTAMENTO"), iddepto)
        Me.CmbDepartamento.EditValue = Me.CmbDepartamento.Properties.GetDataSourceValue(Me.CmbDepartamento.Properties.ValueMember, d)
        Try
            Me.TA_MUNICIPIOSTableAdapter.FillBy1(Me.DSDeptoMuni.TA_MUNICIPIOS, CmbDepartamento.EditValue)

        Catch ex As Exception

        End Try
        'Municipio
        Dim mn As Integer = Me.CmbMunicipio.Properties.GetDataSourceRowIndex(Me.CmbMunicipio.Properties.Columns("CODIGO_MUNICIPIO"), idmuni)
        Me.CmbMunicipio.EditValue = Me.CmbMunicipio.Properties.GetDataSourceValue(Me.CmbMunicipio.Properties.ValueMember, mn)

        Estado.Visible = False
        lblfolio.Text = folio
        Dim sqlc As String = "select nvl((max(PAGINA) +1 ),1) as PAGINA  from IM_CIUDADANOS_RESPALDAN where CODIGO_PARTIDO=" & idpartido & " and CODIGO_MOVIMIENTO=" & idmovimiento
        pagina = COracle.ObtenerDatos(sqlc, "PAGINA")
        lblpagina.Text = pagina
    End Sub
    Private Sub CmbPartido_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPartido.EditValueChanged
        Try
            Me.TA_MOVIMIENTOTableAdapter.FillBy1(Me.DSPolitico.TA_MOVIMIENTO, CmbPartido.EditValue)

        Catch ex As Exception

        End Try
    End Sub



    Sub AgregarFilasGrid(ByVal NumeroCeldas As Integer)
        For i = 1 To CType(NumeroCeldas, Integer)
            GridView1.AddNewRow()

        Next
        vinicio = True
        GCBusqueda.ForceInitialize()
        Dim view As GridView = GridView1
        view.FocusedRowHandle = 0

        view.FocusedColumn = colIDENTIDAD
        view.ShowEditor()

    End Sub

    Sub eliminarvacios()
        Dim view As GridView = GridView1
        'RECORRER EL GRID
        Estado.Visible = True
        For i = 0 To view.DataRowCount - 1
            'SI CUMLE CON TODAS LAS CONDICIONES
            '****************************************
            If Not IsDBNull(view.GetRowCellValue(i, "IDENTIDAD")) And Not IsDBNull(view.GetRowCellValue(i, "PrimerNombre")) And Not IsDBNull(view.GetRowCellValue(i, "PrimerApellido")) Then
                view.SetRowCellValue(i, "Estado", True)
                guardar(i)



                estadistico()
            Else
                view.SetRowCellValue(i, "Estado", False)


                'view.DeleteRow(i)
            End If

        Next

        'SI GUARDO TODO LOS DATOS

        If guardados = view.DataRowCount Then
            Dim consis As Integer = guardados - noinconsistentes
            Dim mensaje As String = "Registros consistentes: " & consis & vbCrLf & "Registros con inconsistencia:" & noinconsistentes & vbCrLf & "Total de Registros Guardados: " & guardados & vbCrLf & "Presione Aceptar para cerrar la pantalla actual"
            If XtraMessageBox.Show(mensaje, "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then

                Me.Close()
            End If
        ElseIf ArregloDeErrores > 1 Or guardados <> view.DataRowCount Then
            'SI NO GUARDO TODOS LOS DATOS
            Dim consis As Integer = guardados - noinconsistentes
            Dim mensaje As String = "Registros consistentes: " & consis & vbCrLf & "Registros con inconsistencia:" & noinconsistentes & vbCrLf & "Total de Registros Guardados: " & guardados & vbCrLf & "¿Desea terminar de editar los registros vacíos e incompletos ?" & vbCrLf & "Presione No para Salir"
            If XtraMessageBox.Show(mensaje, "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Me.Estado.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("Estado= 'False'")
            Else
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        'Me.GridView1.ExportToXls("E:\test.xls")
        guardados = 0
        ArregloDeErrores = 0
        If ContarNoNulos() = 0 Then
            Mensajes.mimensaje("Los campos estan vacíos o estan ingresados incorrectamente, Debe de guardar almenos un registro que contenga los campos requeridos")
        Else
            eliminarvacios()
        End If


        'Dim view As GridView = GridView1
        ''RECORRER EL GRID
        'If view.DataRowCount = 0 Then
        '    Mensajes.mimensaje("Todos los campos estan vacíos,Debe de guardar almenos un registro")
        'Else
        '    validarFilas()
        'End If

    End Sub
    Function ContarNoNulos() As Integer
        Dim coint As Integer = 0
        Dim view As GridView = GridView1
        'RECORRER EL GRID
        For i = 0 To view.DataRowCount - 1
            If Not IsDBNull(view.GetRowCellValue(i, "IDENTIDAD")) And Not IsDBNull(view.GetRowCellValue(i, "PrimerNombre")) And Not IsDBNull(view.GetRowCellValue(i, "PrimerApellido")) Then
                coint += 1
            End If
        Next
        Return coint
    End Function

    Sub validarFilas()
        errores = 0
        Estado.Visible = True
        Try
            Dim view As GridView = GridView1
            'RECORRER EL GRID
            For i = 0 To view.DataRowCount - 1
                'VERIFICAR QUE EL CAMPO IDENTIDAD NO ESTE VACIO
                If IsDBNull(view.GetRowCellValue(i, "IDENTIDAD")) Or view.GetRowCellValue(i, "IDENTIDAD") Is Nothing Then
                    'CONTAR ERRORES
                    errores += 1
                    'Mostar icono de Error
                    view.SetRowCellValue(i, "Estado", False)
                    'VERIFICAR QUE EL NOMBRE NO ESTE VACIO
                ElseIf IsDBNull(view.GetRowCellValue(i, "PrimerNombre")) Or view.GetRowCellValue(i, "PrimerNombre") Is Nothing Then
                    'CONTAR ERRORES
                    errores += 1
                    'Mostar icono de Error
                    view.SetRowCellValue(i, "Estado", False)
                    'VERIFICAR QUE EL APELLIDO NO ESTE VACIO
                ElseIf IsDBNull(view.GetRowCellValue(i, "PrimerApellido")) Or view.GetRowCellValue(i, "PrimerApellido") Is Nothing Then
                    'CONTAR ERRORES
                    errores += 1
                    'Mostar icono de Error
                    view.SetRowCellValue(i, "Estado", False)

                ElseIf Not IsDBNull(view.GetRowCellValue(i, "IDENTIDAD")) Or Not IsDBNull(view.GetRowCellValue(i, "PrimerNombre")) Or Not IsDBNull(view.GetRowCellValue(i, "PrimeApellido")) Then
                    Dim identidad As String = view.GetRowCellValue(i, "IDENTIDAD")
                    Dim nombre As String = view.GetRowCellValue(i, "PrimerNombre")
                    Dim apellido As String = view.GetRowCellValue(i, "PrimerApellido")
                    If (identidad = Nothing Or identidad = "") Or (nombre = Nothing Or nombre = "") Or (apellido = Nothing Or apellido = "") Then
                        errores += 1
                        view.SetRowCellValue(i, "Estado", False)



                    Else
                        view.SetRowCellValue(i, "Estado", True)
                        guardar(i)

                    End If


                End If



            Next i


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub CmbDepartamento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDepartamento.EditValueChanged
        Try
            Me.TA_MUNICIPIOSTableAdapter.FillBy1(Me.DSDeptoMuni.TA_MUNICIPIOS, CmbDepartamento.EditValue)

        Catch ex As Exception

        End Try
    End Sub

    Sub guardar(ByVal i As Integer)

        'proceso de validacion con la base de datos
        Dim NombreIgual As String = "S"
        Dim NombreP As String = ""
        Dim inconsistente As String = "S"
        Dim Observacion As String = ""
        Try

            Dim view As GridView = GridView1
            'RECORRER EL GRID
            'For i = 0 To view.DataRowCount - 1
            'COMPROBAR  SI LA IDENTIDAD EXISTE
            Dim a As String = view.GetRowCellValue(i, "IDENTIDAD").ToString.Trim
            Dim consulta As String = "select NUMERO_IDENTIDAD, PRIMER_NOMBRE, SEGUNDO_NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO "
            consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & a & "'"
            'VERIFICAR IDENTIDAD
            If COracle.ObtenerDatos(consulta, "NUMERO_IDENTIDAD") <> "N" Then
                'SI LA IDENTIDAD EXISTE SE PREOCEDE A COMPROBAR LOS NOMBRES

                'COMPROBANDO EL PRIMER NOMBRE
                Dim pnombre As String = view.GetRowCellValue(i, "PrimerNombre").ToString.Trim
                Dim papellido As String = view.GetRowCellValue(i, "PrimerApellido").ToString.Trim

                If pnombre <> COracle.ObtenerDatos(consulta, "PRIMER_NOMBRE") Then
                    inconsistente = "N"
                    NombreIgual = "N"
                    Observacion &= " El primer nombre no coincide con el del padrón electoral "
                    'COMPROBANDO EL SEGUNDO NOMBRE

                ElseIf papellido <> COracle.ObtenerDatos(consulta, "PRIMER_APELLIDO") Then
                    inconsistente = "N"
                    NombreIgual = "N"
                    Observacion &= " El primer apellido no coincide con el del padrón electoral "
                    'COMPROBANDO EL SEGUNDO NOMBRE

                End If

                'COMPROBANDO INGRESO NULO DE SEGUNDO NOMBRE Y APELLIDO
                Dim SNOMBRE As String = view.GetRowCellValue(i, "SegundoNombre").ToString.Trim
                Dim SAPELLIDO As String = view.GetRowCellValue(i, "SegundoApellido").ToString.Trim

                If COracle.ObtenerDatos(consulta, "SEGUNDO_NOMBRE") = SNOMBRE Then
                Else
                    inconsistente = "N"
                    NombreIgual = "N"
                    Observacion &= " El segundo nombre no coincide con el del padrón electoral "
                End If

                If COracle.ObtenerDatos(consulta, "SEGUNDO_APELLIDO") = SAPELLIDO Then
                Else
                    inconsistente = "N"
                    NombreIgual = "N"
                    Observacion &= " El segundo apellido no coincide con el del padrón electoral "
                End If

                If view.GetRowCellValue(view.FocusedRowHandle, "FIRMA") Is Nothing Or IsDBNull(view.GetRowCellValue(view.FocusedRowHandle, "FIRMA")) Or view.GetRowCellValue(view.FocusedRowHandle, "FIRMA").ToString = "N" Then
                    inconsistente = "N"

                    Observacion &= " No presenta firma "
                End If

                If view.GetRowCellValue(view.FocusedRowHandle, "HUELLA") Is Nothing Or IsDBNull(view.GetRowCellValue(view.FocusedRowHandle, "HUELLA")) Or view.GetRowCellValue(view.FocusedRowHandle, "HUELLA").ToString = "N" Then
                    inconsistente = "N"

                    Observacion &= " No presenta huella "
                End If

                If view.GetRowCellValue(view.FocusedRowHandle, "DIRECCION") Is Nothing Or IsDBNull(view.GetRowCellValue(view.FocusedRowHandle, "DIRECCION")) Or view.GetRowCellValue(view.FocusedRowHandle, "DIRECCION").ToString = "N" Then
                    inconsistente = "N"

                    Observacion &= " No presenta dirección "
                End If

                GuardarEnBase(i, NombreIgual, inconsistente, Observacion)
            Else
                inconsistente = "N"
                Observacion = " Identidad no encontrada en el padrón electoral "
                NombreIgual = ""
                GuardarEnBase(i, NombreIgual, inconsistente, Observacion)
            End If

            'Next i




        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub

    Sub GuardarEnBase(ByVal i As Integer, ByVal NombreIgual As String, ByVal inconsistente As String, ByVal Observacion As String)
        'Guardar Informacion
        Try


            Dim ciudadanos As DSCiudadanos.IM_CIUDADANOS_RESPALDAN1Row
            ciudadanos = Me.DSCiudadanos.IM_CIUDADANOS_RESPALDAN1.NewIM_CIUDADANOS_RESPALDAN1Row
            With ciudadanos
                Dim cod As Integer = COracle.FUN_EJECUTAR_SEQ("IM_SQ1_CIUDADANOS_RESPALDAN")
                .CODIGO_CUIDADANOS_RESPALDAN = cod
                .CODIGO_PARTIDO = idpartido
                .CODIGO_MOVIMIENTO = idmovimiento
                .CODIGO_DEPARTAMENTO = iddepto
                .CODIGO_MUNICIPIO = idmuni
                .FIRMA = GridView1.GetRowCellValue(i, "FIRMA").ToString
                .HUELLA = GridView1.GetRowCellValue(i, "HUELLA").ToString
                .DIRECCION = GridView1.GetRowCellValue(i, "DIRECCION").ToString
                .IDENTIDAD = GridView1.GetRowCellValue(i, "IDENTIDAD").ToString.Trim
                .PRIMER_NOMBRE_PAPELETA = GridView1.GetRowCellValue(i, "PrimerNombre").ToString.Trim
                .SEGUNDO_NOMBRE_PAPELETA = GridView1.GetRowCellValue(i, "SegundoNombre").ToString.Trim
                .PRIMER_APELLIDO_PAPELETA = GridView1.GetRowCellValue(i, "PrimerApellido").ToString.Trim
                .SEGUNDO_APELLIDO_PAPELETA = GridView1.GetRowCellValue(i, "SegundoApellido").ToString.Trim
                .NOMBRE_IGUAL = NombreIgual

                If folio = "" Then

                Else
                    .FOLIO = CType(folio, Integer)
                End If


                .ADICIONADO_POR = usuario
                .FECHA_ADICION = DateTime.Now
                .CONSISTENTE = inconsistente
                .OBSERVACION = Observacion
                .MAQUINA = SystemInformation.ComputerName
                .PAGINA = pagina
            End With

            Me.DSCiudadanos.IM_CIUDADANOS_RESPALDAN1.Rows.Add(ciudadanos)

            Me.IM_CIUDADANOS_RESPALDAN1TableAdapter.Update(Me.DSCiudadanos.IM_CIUDADANOS_RESPALDAN1)
            GridView1.SetRowCellValue(i, "Estado", True)
            If inconsistente = "N" Then
                noinconsistentes += 1
            End If
            guardados += 1
            If imagesave = False Then
                guardarimagen()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            GridView1.SetRowCellValue(i, "Estado", False)
            ArregloDeErrores += 1
        End Try

    End Sub

    Function capturarerrores() As Integer
        Return ArregloDeErrores
    End Function
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MsgBox(GridView1.GetRowCellValue(2, "FIRMA").ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub mostrarimg()
        Dim consulta As String = "SELECT IMAGEN FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO=" & idpartido
        Me.imgpartido.Image = COracle.ObtenerImagen(consulta, "IMAGEN")
        Dim consulta2 As String = "SELECT * FROM IM_MOVIMIENTOS WHERE CODIGO_MOVIMIENTO=" & idmovimiento
        Me.imgmov.Image = COracle.ObtenerImagen(consulta2, "INSIGNIA")
        lblpartido.Text = COracle.ObtenerDatos("SELECT NOMBRE FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO=" & idpartido, "NOMBRE")
        lblmovimiento.Text = COracle.ObtenerDatos("SELECT NOMBRE_MOVIMIENTO FROM IM_MOVIMIENTOS WHERE CODIGO_MOVIMIENTO=" & idmovimiento, "NOMBRE_MOVIMIENTO")

    End Sub


    Private Sub PanelControl2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelControl2.Paint

    End Sub
End Class