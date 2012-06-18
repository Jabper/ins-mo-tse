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
            For i = 0 To view.DataRowCount
                'VERIFICAR QUE EL CAMPO IDENTIDAD NO ESTE VACIO
                If IsDBNull(view.GetRowCellValue(i, "IDENTIDAD")) Or view.GetRowCellValue(i, "IDENTIDAD") Is Nothing Or IsDBNull(view.GetRowCellValue(i, "NOMBRE")) Or view.GetRowCellValue(i, "NOMBRE") Is Nothing Then
                    'CONTAR ERRORES
                    errores += 1
                    'Mostar icono de Error
                    view.SetRowCellValue(i, "Estado", False)
                ElseIf Not IsDBNull(view.GetRowCellValue(i, "IDENTIDAD")) Or Not IsDBNull(view.GetRowCellValue(i, "NOMBRE")) Then
                    Dim identidad As String = view.GetRowCellValue(i, "IDENTIDAD")
                    Dim nombre As String = view.GetRowCellValue(i, "NOMBRE")
                    If (identidad = Nothing Or identidad = "") Or (nombre = Nothing Or nombre = "") Then
                        errores += 1
                        view.SetRowCellValue(i, "Estado", False)
                    Else
                        view.SetRowCellValue(i, "Estado", True)
                    End If
                    '    Dim a As String = view.GetRowCellValue(i, "IDENTIDAD")
                    '    Dim consulta As String = "select NUMERO_IDENTIDAD, PRIMER_NOMBRE || ' ' || SEGUNDO_NOMBRE || ' ' || PRIMER_APELLIDO || ' ' || SEGUNDO_APELLIDO AS NOMBRE "
                    '    consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & a & "'"
                    'verificar si esta correcto en la base de datos
                    'If COracle.ObtenerDatos(consulta, "NOMBRE") <> "N" Then

                    'Else
                    '    view.SetRowCellValue(i, "NOMBRE", "")
                    '    Estado.OptionsColumn.AllowEdit = True
                    '    view.SetRowCellValue(view.FocusedRowHandle, "Estado", False)
                    '    Estado.OptionsColumn.AllowEdit = False
                    '    errores += 1

                End If
                
                

            Next i
            'MsgBox(errores)
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

    Sub guardar(ByVal errores As Integer)
        Dim NombreIgual As String = ""
        Dim NombrePapeleta As String = ""
        Dim inconsistente As String = ""
        Dim Observacion As String = ""

        If errores = 0 Then
            Dim view As GridView = GridView1
            'RECORRER EL GRID
            For i = 0 To view.DataRowCount
                'COMPROBAR  SI LA IDENTIDAD EXISTE
                Dim a As String = view.GetRowCellValue(i, "IDENTIDAD")
                Dim consulta As String = "select NUMERO_IDENTIDAD, PRIMER_NOMBRE || ' ' || SEGUNDO_NOMBRE || ' ' || PRIMER_APELLIDO || ' ' || SEGUNDO_APELLIDO AS NOMBRE "
                consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & a & "'"
                'VERIFICAR IDENTIDAD
                If COracle.ObtenerDatos(consulta, "NOMBRE") <> "N" Then
                    'SI EL NOMBRE ES IGUAL
                    Dim nombre As String = COracle.ObtenerDatos(consulta, "NOMBRE")
                    If GridView1.GetRowCellValue(i, "NOMBRE") = nombre Then
                        inconsistente = "N"
                        NombreIgual = "S"


                    Else
                        'SI EL NOMBRE NO ES IGUAL
                        inconsistente = "S"
                        NombreIgual = "N"
                        Observacion = "El nombre ingresado es diferente al del padrón electoral"
                    End If
                Else
                    inconsistente = "S"
                    Observacion = "Identidad no encontrada en el padrón electoral"
                    NombreIgual = "I"
                End If
                GuardarEnBase(i, NombreIgual, NombrePapeleta, inconsistente, Observacion)
            Next i
        Else

        End If
        'Else
        'GridView1.GetRowCellValue(i, "NOMBRE")
        'GridView1.GetRowCellValue(i, "NOMBRE_IGUAL")
        'GridView1.GetRowCellValue(i, "NOMBRE_PALELETA")
        'GridView1.GetRowCellValue(i, "FIRMA")
        'GridView1.GetRowCellValue(i, "HUELLA")
        'GridView1.GetRowCellValue(i, "DIRECCION")
        'GridView1.GetRowCellValue(i, "IMAGEN_FIRMA")
        'MsgBox(GridView1.GetRowCellValue(i, "IDENTIDAD"))
        'End If
    End Sub

    Sub GuardarEnBase(ByVal i As Integer, ByVal NombreIgual As String, ByVal NombrePapeleta As String, ByVal inconsistente As String, ByVal Observacion As String)
        'Guardar Informacion
        Dim ciudadanos As DSCiudadanos.IM_CIUDADANOS_RESPALDAN1Row
        ciudadanos = Me.DSCiudadanos.IM_CIUDADANOS_RESPALDAN1.NewIM_CIUDADANOS_RESPALDAN1Row
        With ciudadanos
            .CODIGO_CUIDADANOS_RESPALDAN = 1
            .CODIGO_PARTIDO = Me.CmbPartido.EditValue
            .CODIGO_MOVIMIENTO = Me.CmbMunicipio.EditValue
            .CODIGO_DEPARTAMENTO = Me.CmbDepartamento.EditValue
            .CODIGO_MUNICIPIO = Me.CmbMunicipio.EditValue
            .FIRMA = GridView1.GetRowCellValue(i, "FIRMA").ToString
            .HUELLA = GridView1.GetRowCellValue(i, "HUELLA").ToString
            .DIRECCION = GridView1.GetRowCellValue(i, "DIRECCION")
            .IDENTIDAD = GridView1.GetRowCellValue(i, "IDENTIDAD")
            .NOMBRE = GridView1.GetRowCellValue(i, "NOMBRE") 'Revisar
            .NOMBRE_IGUAL = NombreIgual
            .NOMBRE_PAPELETA = "aca el nombre de la papeleta"
            .FOLIO = folio
            .IMAGEN_FIRMA = Data.ConvertImageToByteArray(GridView1.GetRowCellValue(i, "IMAGEN_FIRMA"))
            .ADICIONADO_POR = usuario
            .FECHA_ADICION = DateTime.Now
            .CONSISTENTE = inconsistente
            .OBSERVACION = Observacion
            .MAQUINA = SystemInformation.ComputerName
            .PAGINA = "inserte aca la secuencia"
        End With
        Me.DSCiudadanos.IM_CIUDADANOS_RESPALDAN1.Rows.Add(ciudadanos)
        Me.IM_CIUDADANOS_RESPALDAN1TableAdapter.Update(Me.DSCiudadanos.IM_CIUDADANOS_RESPALDAN1)

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Try
            MsgBox(GridView1.GetRowCellValue(2, "FIRMA").ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class