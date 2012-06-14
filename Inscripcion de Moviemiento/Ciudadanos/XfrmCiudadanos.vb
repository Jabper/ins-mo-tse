Imports DevExpress.XtraGrid.Views.Grid

Public Class XfrmCiudadanos
    Dim ActivarMayusculas As Boolean



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

    Private Sub XfrmCiudadanos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim S As String

        S = UCase(e.KeyChar)

        S = ChrW(Asc(S))

        e.KeyChar = S

    End Sub

    Private Sub XfrmCiudadanos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSCiudadanos.IM_CIUDADANOS_RESPALDAN' table. You can move, or remove it, as needed.
        'Me.IM_CIUDADANOS_RESPALDANTableAdapter.Fill(Me.DSCiudadanos.IM_CIUDADANOS_RESPALDAN)

    End Sub



    Private Sub GridView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        Dim view As GridView = TryCast(sender, GridView)
        If view.FocusedColumn.FieldName <> "Nombre" Then
            Return
        End If
        e.Valid = e.Value IsNot Nothing AndAlso Not e.Value.Equals(String.Empty)
    End Sub
End Class