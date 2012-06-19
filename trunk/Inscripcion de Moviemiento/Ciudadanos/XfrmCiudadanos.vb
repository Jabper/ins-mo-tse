Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors

Public Class XfrmCiudadanos
    

    Dim vi As Integer = 1
    Dim errores As Integer = 0
    Public iddepto As Integer
    Public idmuni As Integer
    Public idpartido As Integer
    Public idmovimiento As Integer
    Public folio As String
    Public ArregloDeErrores As Integer
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.KeyPreview = True

    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
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
        'e.ExceptionMode = ExceptionMode.DisplayError
        'e.WindowCaption = "Valor Inválido"
        'e.ErrorText = "Error"
        'GridView1.HideEditor()
    End Sub

    Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress
      
    End Sub






    Private Sub GridView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor

        'Dim view As GridView = TryCast(sender, GridView)
        'If view.FocusedColumn.FieldName = "IDENTIDAD" Then


        '    Dim a As String = e.Value
        '    'If IsDBNull(a) Or a = Nothing Then
        '    '    e.Valid = IsDBNull(e.Value) AndAlso e.Value IsNot Nothing AndAlso Not e.Value.Equals(String.Empty)
        '    '    Return
        '    'End If
        '    Dim consulta As String = "select NUMERO_IDENTIDAD, PRIMER_NOMBRE || ' ' || SEGUNDO_NOMBRE || ' ' || PRIMER_APELLIDO || ' ' || SEGUNDO_APELLIDO AS NOMBRE "
        '    consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & a & "'"
        '    If COracle.ObtenerDatos(consulta, "NOMBRE") <> "N" Then

        '        view.SetRowCellValue(view.FocusedRowHandle, "NOMBRE", COracle.ObtenerDatos(consulta, "NOMBRE"))
        '        view.SetRowCellValue(view.FocusedRowHandle, "Estado", True)
        '    Else
        '        view.SetRowCellValue(view.FocusedRowHandle, "NOMBRE", "")

        '        view.SetRowCellValue(view.FocusedRowHandle, "Estado", False)

        '        'view.SetRowCellValue(view.FocusedRowHandle, "NOMBRE_IGUAL", "N")

        '        'view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        '        'gv.OptionsBehavior.Editable = False
        '        'gv.OptionsSelection.EnableAppearanceFocusedCell = False
        '        'e.Valid = e.Value IsNot Nothing AndAlso Not e.Value.Equals(String.Empty)
        '    End If

        'ElseIf view.FocusedColumn.FieldName = "NOMBRE_IGUAL" Then
        '    If e.Value = "S" Then

        '        'colNOMBRE_PAPELETA.OptionsColumn.AllowEdit = False
        '    Else
        '        'colNOMBRE_PAPELETA.OptionsColumn.AllowEdit = True
        '    End If

        'End If

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

    Private Sub XfrmCiudadanos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DSCiudadanos.IM_CIUDADANOS_RESPALDAN1' table. You can move, or remove it, as needed.
        Me.IM_CIUDADANOS_RESPALDAN1TableAdapter.Fill(Me.DSCiudadanos.IM_CIUDADANOS_RESPALDAN1)
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
        Me.GCBusqueda.Focus()
    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        'Me.GridView1.ExportToXls("E:\test.xls")
        validarFilas()
    End Sub


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
                    End If


                End If



            Next i
            If errores = 0 Then
                errores = 0
                guardar()
                'vbCrLf
            Else
                Dim mensaje As String = "Errores encontrados: " & errores
                mensaje &= vbCrLf & "Para poder guardar los registros verifique:" & vbCrLf & "1.Que el número de identidad no se encuentre en blanco"
                mensaje &= vbCrLf & "2. El primer nombre y primer apellido no estén en blanco"
                Mensajes.mimensaje(mensaje)
            End If

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

    Sub guardar()

        'proceso de validacion con la base de datos
        Dim NombreIgual As String = "S"
        Dim NombreP As String = ""
        Dim inconsistente As String = "N"
        Dim Observacion As String = ""
        Try

            Dim view As GridView = GridView1
            'RECORRER EL GRID
            For i = 0 To view.DataRowCount - 1
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
                        inconsistente = "S"
                        NombreIgual = "N"
                        Observacion &= "El primer nombre no coincide con el del padrón electoral "
                        'COMPROBANDO EL SEGUNDO NOMBRE

                    ElseIf papellido <> COracle.ObtenerDatos(consulta, "PRIMER_APELLIDO") Then
                        inconsistente = "S"
                        NombreIgual = "N"
                        Observacion &= "El primer apellido no coincide con el del padrón electoral "
                        'COMPROBANDO EL SEGUNDO NOMBRE

                    End If

                    'COMPROBANDO INGRESO NULO DE SEGUNDO NOMBRE Y APELLIDO
                    Dim SNOMBRE As String = view.GetRowCellValue(i, "SegundoNombre").ToString.Trim
                    Dim SAPELLIDO As String = view.GetRowCellValue(i, "SegundoApellido").ToString.Trim

                    If COracle.ObtenerDatos(consulta, "SEGUNDO_NOMBRE") = SNOMBRE Then
                    Else
                        inconsistente = "S"
                        NombreIgual = "N"
                        Observacion &= "El segundo nombre no coincide con el del padrón electoral "
                    End If

                    If COracle.ObtenerDatos(consulta, "SEGUNDO_APELLIDO") = SAPELLIDO Then
                    Else
                        inconsistente = "S"
                        NombreIgual = "N"
                        Observacion &= "El segundo apellido no coincide con el del padrón electoral "
                    End If
                Else
                    inconsistente = "S"
                    Observacion = "Identidad no encontrada en el padrón electoral"
                    NombreIgual = ""

                End If
                GuardarEnBase(i, NombreIgual, inconsistente, Observacion)
            Next i

            If capturarerrores() = 0 Then
                Mensajes.MensajeGuardar()
            Else
                If XtraMessageBox.Show(capturarerrores.ToString & " registros no se pudieron guardar ¿Desea que el sistema intente guardarlos?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Me.Estado.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("Estado= 'False'")
                    errores = 0
                    guardar()
                    Estado.FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("Estado= 'False' or Estado= 'True'")
                End If
            End If


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
                .CODIGO_CUIDADANOS_RESPALDAN = COracle.FUN_EJECUTAR_SEQ("IM_SQ1_CIUDADANOS_RESPALDAN")
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
                If IsDBNull(GridView1.GetRowCellValue(i, "IMAGEN_FIRMA")) Then
                Else
                    .IMAGEN_FIRMA = GridView1.GetRowCellValue(i, "IMAGEN_FIRMA")
                End If

                .ADICIONADO_POR = usuario
                .FECHA_ADICION = DateTime.Now
                .CONSISTENTE = inconsistente
                .OBSERVACION = Observacion
                .MAQUINA = SystemInformation.ComputerName
                .PAGINA = COracle.FUN_EJECUTAR_SEQ("IM_SQ2_CIUDADANOS_RESPALDAN")
            End With

            Me.DSCiudadanos.IM_CIUDADANOS_RESPALDAN1.Rows.Add(ciudadanos)

            Me.IM_CIUDADANOS_RESPALDAN1TableAdapter.Update(Me.DSCiudadanos.IM_CIUDADANOS_RESPALDAN1)
            'GridView1.SetRowCellValue(i, "Estado", False)
            If inconsistente = "S" Then
                inconsistente += 1
            End If
        Catch ex As Exception
            errores += 1
            GridView1.SetRowCellValue(i, "Estado", False)
            'ArregloDeErrores.Add(i.ToString)
        End Try

    End Sub

    Function capturarerrores() As Integer
        Return errores
    End Function
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            MsgBox(GridView1.GetRowCellValue(2, "FIRMA").ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class