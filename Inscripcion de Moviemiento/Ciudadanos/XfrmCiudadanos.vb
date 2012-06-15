Imports DevExpress.XtraGrid.Views.Grid

Public Class XfrmCiudadanos
    Dim ActivarMayusculas As Boolean
    Dim vi As Integer = 1
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.KeyPreview = True

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click

        For i = 1 To CType(Me.TextEdit1.Text, Integer)
            GridView1.AddNewRow()

        Next


    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click

    End Sub

    Sub PreguntasDeSeguridad() 'SE CREA UN DATA TABLE PARA ENLAZARLO AL CONTROL Y MOSTRAR LAS PREGUNTAS DE SEGURIDAD
        Dim tbl As New DataTable()
        'SE CREAN LAS COLUMNAS DEL DATA TABLE
        tbl.Columns.Add("Id", GetType(Integer))
        tbl.Columns.Add("Pregunta", GetType(String))
        'SE AGREGAN LAS FILAS CON LA INFORMACION
        tbl.Rows.Add(1, "¿Nombre de mi mascosta?")
        tbl.Rows.Add(2, "¿Lugar de Nacimiento?")

        'SE ENLAZA EL DATATABLE CREADO PARA MOSTRARLO EN EL CONTROL
        'With PREGUNTA_SEGURIDADTextEdit
        '    .Properties.DataSource = tbl
        '    .Properties.ValueMember = "Id"
        '    .Properties.DisplayMember = "Pregunta"
        '    'SE PREPARA EL CONTROL PARA OCULTAR COLUMNAS
        '    .Properties.ForceInitialize()
        '    .Properties.PopulateColumns()
        '    'SE OCULTA INFORMACION 
        '    .Properties.Columns(0).Visible = False
        '    .Properties.Columns(1).Visible = True
        'End With


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

    Private Sub GridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridView1.KeyPress

    End Sub

    
   



    Private Sub GridView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        '
        Dim view As GridView = TryCast(sender, GridView)
        If view.FocusedColumn.FieldName = "IDENTIDAD" Then
            Dim a As String = e.Value
            Dim consulta As String = "select NUMERO_IDENTIDAD, PRIMER_NOMBRE || ' ' || SEGUNDO_NOMBRE || ' ' || PRIMER_APELLIDO || ' ' || SEGUNDO_APELLIDO AS NOMBRE "
            consulta &= "from Im_padron_electoral where NUMERO_IDENTIDAD='" & a & "'"
            If COracle.ObtenerDatos(consulta, "NOMBRE") <> "N" Then


                view.SetRowCellValue(view.FocusedRowHandle, "NOMBRE", COracle.ObtenerDatos(consulta, "NOMBRE"))
                'view.SetRowCellValue(view.FocusedRowHandle, "NOMBRE_IGUAL", "S")
            Else
                view.SetRowCellValue(view.FocusedRowHandle, "NOMBRE", "")
                'view.SetRowCellValue(view.FocusedRowHandle, "NOMBRE_IGUAL", "N")

                'view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
                'gv.OptionsBehavior.Editable = False
                'gv.OptionsSelection.EnableAppearanceFocusedCell = False
                'e.Valid = e.Value IsNot Nothing AndAlso Not e.Value.Equals(String.Empty)
            End If

        ElseIf view.FocusedColumn.FieldName = "NOMBRE_IGUAL" Then
            If e.Value = "N" Then

                colNOMBRE_PAPELETA.OptionsColumn.AllowEdit = True
            Else
                colNOMBRE_PAPELETA.OptionsColumn.AllowEdit = False
            End If
        End If
        '
    End Sub


    Private Sub GCBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GCBusqueda.Click

    End Sub

    Private Sub GCBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GCBusqueda.KeyPress

    End Sub

    Private Sub XfrmCiudadanos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim view As GridView = Me.GridView1
        If view.FocusedColumn.FieldName = "IDENTIDAD" Then
            VControles.solonumeros(e)
        End If
    End Sub

    Private Sub XfrmCiudadanos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class