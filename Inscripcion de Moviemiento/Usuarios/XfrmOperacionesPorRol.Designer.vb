<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmOperacionesPorRol
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.DTOPCIONESXROLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTUsers = New Inscripcion_de_Moviemientos.DTUsers
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_OPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_ROL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colROLES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINSERTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colMODIFICAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colELIMINAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.ChkEliminar = New DevExpress.XtraEditors.CheckEdit
        Me.IMOPERACIONESPORROLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChkModificar = New DevExpress.XtraEditors.CheckEdit
        Me.ChkInsertar = New DevExpress.XtraEditors.CheckEdit
        Me.ADICIONADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.FECHA_ADICIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.MODIFICADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.FECHA_MODIFICACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.CODIGO_OPCIONSpinEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMOPCIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODIGO_ROLSpinEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMROLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemForADICIONADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_ADICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForMODIFICADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_MODIFICACION = New DevExpress.XtraLayout.LayoutControlItem
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.ItemForCODIGO_OPCION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_ROL = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.BtnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.IM_OPERACIONES_POR_ROLTableAdapter = New Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_OPERACIONES_POR_ROLTableAdapter
        Me.IM_OPCIONESTableAdapter = New Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_OPCIONESTableAdapter
        Me.IM_ROLESTableAdapter = New Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_ROLESTableAdapter
        Me.DT_OPCIONES_X_ROLTableAdapter = New Inscripcion_de_Moviemientos.DTUsersTableAdapters.DT_OPCIONES_X_ROLTableAdapter
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTOPCIONESXROLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.ChkEliminar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMOPERACIONESPORROLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkModificar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkInsertar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADICIONADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODIFICADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_OPCIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMOPCIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_ROLSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMROLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_OPCION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_ROL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GCBusqueda)
        Me.LayoutControl1.Controls.Add(Me.DataLayoutControl1)
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(583, 137, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(501, 386)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GCBusqueda
        '
        Me.GCBusqueda.DataSource = Me.DTOPCIONESXROLBindingSource
        Me.GCBusqueda.Location = New System.Drawing.Point(12, 187)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemCheckEdit3})
        Me.GCBusqueda.Size = New System.Drawing.Size(475, 187)
        Me.GCBusqueda.TabIndex = 8
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'DTOPCIONESXROLBindingSource
        '
        Me.DTOPCIONESXROLBindingSource.DataMember = "DT_OPCIONES_X_ROL"
        Me.DTOPCIONESXROLBindingSource.DataSource = Me.DTUsers
        '
        'DTUsers
        '
        Me.DTUsers.DataSetName = "DTUsers"
        Me.DTUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_OPCION, Me.colCODIGO_ROL, Me.colROLES, Me.colOPCION, Me.colINSERTAR, Me.colMODIFICAR, Me.colELIMINAR})
        Me.GridView1.GridControl = Me.GCBusqueda
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO_OPCION
        '
        Me.colCODIGO_OPCION.Caption = "Código Opción"
        Me.colCODIGO_OPCION.FieldName = "CODIGO_OPCION"
        Me.colCODIGO_OPCION.Name = "colCODIGO_OPCION"
        Me.colCODIGO_OPCION.Visible = True
        Me.colCODIGO_OPCION.VisibleIndex = 0
        '
        'colCODIGO_ROL
        '
        Me.colCODIGO_ROL.Caption = "Código Rol"
        Me.colCODIGO_ROL.FieldName = "CODIGO_ROL"
        Me.colCODIGO_ROL.Name = "colCODIGO_ROL"
        Me.colCODIGO_ROL.Visible = True
        Me.colCODIGO_ROL.VisibleIndex = 1
        '
        'colROLES
        '
        Me.colROLES.Caption = "Rol"
        Me.colROLES.FieldName = "ROLES"
        Me.colROLES.Name = "colROLES"
        Me.colROLES.Visible = True
        Me.colROLES.VisibleIndex = 2
        '
        'colOPCION
        '
        Me.colOPCION.Caption = "Opción"
        Me.colOPCION.FieldName = "OPCION"
        Me.colOPCION.Name = "colOPCION"
        Me.colOPCION.Visible = True
        Me.colOPCION.VisibleIndex = 3
        '
        'colINSERTAR
        '
        Me.colINSERTAR.Caption = "Insertar"
        Me.colINSERTAR.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colINSERTAR.FieldName = "INSERTAR"
        Me.colINSERTAR.Name = "colINSERTAR"
        Me.colINSERTAR.Visible = True
        Me.colINSERTAR.VisibleIndex = 4
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.ValueChecked = "S"
        Me.RepositoryItemCheckEdit2.ValueUnchecked = "N"
        '
        'colMODIFICAR
        '
        Me.colMODIFICAR.Caption = "Modificar"
        Me.colMODIFICAR.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.colMODIFICAR.FieldName = "MODIFICAR"
        Me.colMODIFICAR.Name = "colMODIFICAR"
        Me.colMODIFICAR.Visible = True
        Me.colMODIFICAR.VisibleIndex = 5
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.ValueChecked = "S"
        Me.RepositoryItemCheckEdit3.ValueUnchecked = "N"
        '
        'colELIMINAR
        '
        Me.colELIMINAR.Caption = "Eliminar"
        Me.colELIMINAR.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colELIMINAR.FieldName = "ELIMINAR"
        Me.colELIMINAR.Name = "colELIMINAR"
        Me.colELIMINAR.Visible = True
        Me.colELIMINAR.VisibleIndex = 6
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "S"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.PanelControl2)
        Me.DataLayoutControl1.Controls.Add(Me.ADICIONADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_ADICIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MODIFICADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_MODIFICACIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_OPCIONSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_ROLSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.IMOPERACIONESPORROLBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForADICIONADO_POR, Me.ItemForFECHA_ADICION, Me.ItemForMODIFICADO_POR, Me.ItemForFECHA_MODIFICACION})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 76)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(526, 9, 250, 350)
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(475, 107)
        Me.DataLayoutControl1.TabIndex = 5
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.ChkEliminar)
        Me.PanelControl2.Controls.Add(Me.ChkModificar)
        Me.PanelControl2.Controls.Add(Me.ChkInsertar)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 60)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(451, 35)
        Me.PanelControl2.TabIndex = 10
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Operaciones:"
        '
        'ChkEliminar
        '
        Me.ChkEliminar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "ELIMINAR", True))
        Me.ChkEliminar.Location = New System.Drawing.Point(255, 9)
        Me.ChkEliminar.Name = "ChkEliminar"
        Me.ChkEliminar.Properties.Caption = "Eliminar"
        Me.ChkEliminar.Properties.ValueChecked = "S"
        Me.ChkEliminar.Properties.ValueUnchecked = "N"
        Me.ChkEliminar.Size = New System.Drawing.Size(75, 19)
        Me.ChkEliminar.TabIndex = 2
        '
        'IMOPERACIONESPORROLBindingSource
        '
        Me.IMOPERACIONESPORROLBindingSource.DataMember = "IM_OPERACIONES_POR_ROL"
        Me.IMOPERACIONESPORROLBindingSource.DataSource = Me.DTUsers
        '
        'ChkModificar
        '
        Me.ChkModificar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "MODIFICAR", True))
        Me.ChkModificar.Location = New System.Drawing.Point(172, 9)
        Me.ChkModificar.Name = "ChkModificar"
        Me.ChkModificar.Properties.Caption = "Modificar"
        Me.ChkModificar.Properties.ValueChecked = "S"
        Me.ChkModificar.Properties.ValueUnchecked = "N"
        Me.ChkModificar.Size = New System.Drawing.Size(75, 19)
        Me.ChkModificar.TabIndex = 1
        '
        'ChkInsertar
        '
        Me.ChkInsertar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "INSERTAR", True))
        Me.ChkInsertar.Location = New System.Drawing.Point(91, 9)
        Me.ChkInsertar.Name = "ChkInsertar"
        Me.ChkInsertar.Properties.Caption = "Insertar"
        Me.ChkInsertar.Properties.ValueChecked = "S"
        Me.ChkInsertar.Properties.ValueUnchecked = "N"
        Me.ChkInsertar.Size = New System.Drawing.Size(75, 19)
        Me.ChkInsertar.TabIndex = 0
        '
        'ADICIONADO_PORSpinEdit
        '
        Me.ADICIONADO_PORSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "ADICIONADO_POR", True))
        Me.ADICIONADO_PORSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ADICIONADO_PORSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.ADICIONADO_PORSpinEdit.Name = "ADICIONADO_PORSpinEdit"
        Me.ADICIONADO_PORSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ADICIONADO_PORSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.ADICIONADO_PORSpinEdit.StyleController = Me.DataLayoutControl1
        Me.ADICIONADO_PORSpinEdit.TabIndex = 6
        '
        'FECHA_ADICIONDateEdit
        '
        Me.FECHA_ADICIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "FECHA_ADICION", True))
        Me.FECHA_ADICIONDateEdit.EditValue = Nothing
        Me.FECHA_ADICIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_ADICIONDateEdit.Name = "FECHA_ADICIONDateEdit"
        Me.FECHA_ADICIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_ADICIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_ADICIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_ADICIONDateEdit.TabIndex = 7
        '
        'MODIFICADO_PORSpinEdit
        '
        Me.MODIFICADO_PORSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "MODIFICADO_POR", True))
        Me.MODIFICADO_PORSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MODIFICADO_PORSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.MODIFICADO_PORSpinEdit.Name = "MODIFICADO_PORSpinEdit"
        Me.MODIFICADO_PORSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MODIFICADO_PORSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.MODIFICADO_PORSpinEdit.StyleController = Me.DataLayoutControl1
        Me.MODIFICADO_PORSpinEdit.TabIndex = 8
        '
        'FECHA_MODIFICACIONDateEdit
        '
        Me.FECHA_MODIFICACIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "FECHA_MODIFICACION", True))
        Me.FECHA_MODIFICACIONDateEdit.EditValue = Nothing
        Me.FECHA_MODIFICACIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_MODIFICACIONDateEdit.Name = "FECHA_MODIFICACIONDateEdit"
        Me.FECHA_MODIFICACIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_MODIFICACIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_MODIFICACIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_MODIFICACIONDateEdit.TabIndex = 9
        '
        'CODIGO_OPCIONSpinEdit
        '
        Me.CODIGO_OPCIONSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "CODIGO_OPCION", True))
        Me.CODIGO_OPCIONSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_OPCIONSpinEdit.Location = New System.Drawing.Point(49, 36)
        Me.CODIGO_OPCIONSpinEdit.Name = "CODIGO_OPCIONSpinEdit"
        Me.CODIGO_OPCIONSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_OPCIONSpinEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Opción", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_OPCIONSpinEdit.Properties.DataSource = Me.IMOPCIONESBindingSource
        Me.CODIGO_OPCIONSpinEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_OPCIONSpinEdit.Properties.NullText = "Seleccione"
        Me.CODIGO_OPCIONSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CODIGO_OPCIONSpinEdit.Properties.ValueMember = "CODIGO_OPCION"
        Me.CODIGO_OPCIONSpinEdit.Size = New System.Drawing.Size(213, 20)
        Me.CODIGO_OPCIONSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_OPCIONSpinEdit.TabIndex = 4
        '
        'IMOPCIONESBindingSource
        '
        Me.IMOPCIONESBindingSource.DataMember = "IM_OPCIONES"
        Me.IMOPCIONESBindingSource.DataSource = Me.DTUsers
        '
        'CODIGO_ROLSpinEdit
        '
        Me.CODIGO_ROLSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "CODIGO_ROL", True))
        Me.CODIGO_ROLSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_ROLSpinEdit.Location = New System.Drawing.Point(49, 12)
        Me.CODIGO_ROLSpinEdit.Name = "CODIGO_ROLSpinEdit"
        Me.CODIGO_ROLSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_ROLSpinEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Rol", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_ROLSpinEdit.Properties.DataSource = Me.IMROLESBindingSource
        Me.CODIGO_ROLSpinEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_ROLSpinEdit.Properties.NullText = "Seleccione"
        Me.CODIGO_ROLSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CODIGO_ROLSpinEdit.Properties.ValueMember = "CODIGO_ROL"
        Me.CODIGO_ROLSpinEdit.Size = New System.Drawing.Size(213, 20)
        Me.CODIGO_ROLSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_ROLSpinEdit.TabIndex = 5
        '
        'IMROLESBindingSource
        '
        Me.IMROLESBindingSource.DataMember = "IM_ROLES"
        Me.IMROLESBindingSource.DataSource = Me.DTUsers
        '
        'ItemForADICIONADO_POR
        '
        Me.ItemForADICIONADO_POR.Control = Me.ADICIONADO_PORSpinEdit
        Me.ItemForADICIONADO_POR.CustomizationFormText = "ADICIONADO_POR"
        Me.ItemForADICIONADO_POR.Location = New System.Drawing.Point(0, 0)
        Me.ItemForADICIONADO_POR.Name = "ItemForADICIONADO_POR"
        Me.ItemForADICIONADO_POR.Size = New System.Drawing.Size(0, 0)
        Me.ItemForADICIONADO_POR.Text = "ADICIONADO_POR"
        Me.ItemForADICIONADO_POR.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForADICIONADO_POR.TextToControlDistance = 5
        '
        'ItemForFECHA_ADICION
        '
        Me.ItemForFECHA_ADICION.Control = Me.FECHA_ADICIONDateEdit
        Me.ItemForFECHA_ADICION.CustomizationFormText = "FECHA_ADICION"
        Me.ItemForFECHA_ADICION.Location = New System.Drawing.Point(0, 0)
        Me.ItemForFECHA_ADICION.Name = "ItemForFECHA_ADICION"
        Me.ItemForFECHA_ADICION.Size = New System.Drawing.Size(0, 0)
        Me.ItemForFECHA_ADICION.Text = "FECHA_ADICION"
        Me.ItemForFECHA_ADICION.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForFECHA_ADICION.TextToControlDistance = 5
        '
        'ItemForMODIFICADO_POR
        '
        Me.ItemForMODIFICADO_POR.Control = Me.MODIFICADO_PORSpinEdit
        Me.ItemForMODIFICADO_POR.CustomizationFormText = "MODIFICADO_POR"
        Me.ItemForMODIFICADO_POR.Location = New System.Drawing.Point(0, 0)
        Me.ItemForMODIFICADO_POR.Name = "ItemForMODIFICADO_POR"
        Me.ItemForMODIFICADO_POR.Size = New System.Drawing.Size(0, 0)
        Me.ItemForMODIFICADO_POR.Text = "MODIFICADO_POR"
        Me.ItemForMODIFICADO_POR.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForMODIFICADO_POR.TextToControlDistance = 5
        '
        'ItemForFECHA_MODIFICACION
        '
        Me.ItemForFECHA_MODIFICACION.Control = Me.FECHA_MODIFICACIONDateEdit
        Me.ItemForFECHA_MODIFICACION.CustomizationFormText = "FECHA_MODIFICACION"
        Me.ItemForFECHA_MODIFICACION.Location = New System.Drawing.Point(0, 0)
        Me.ItemForFECHA_MODIFICACION.Name = "ItemForFECHA_MODIFICACION"
        Me.ItemForFECHA_MODIFICACION.Size = New System.Drawing.Size(0, 0)
        Me.ItemForFECHA_MODIFICACION.Text = "FECHA_MODIFICACION"
        Me.ItemForFECHA_MODIFICACION.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForFECHA_MODIFICACION.TextToControlDistance = 5
        '
        'Root
        '
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(475, 107)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCODIGO_OPCION, Me.ItemForCODIGO_ROL, Me.EmptySpaceItem5, Me.EmptySpaceItem6, Me.LayoutControlItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(455, 87)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCODIGO_OPCION
        '
        Me.ItemForCODIGO_OPCION.Control = Me.CODIGO_OPCIONSpinEdit
        Me.ItemForCODIGO_OPCION.CustomizationFormText = "CODIGO_OPCION"
        Me.ItemForCODIGO_OPCION.Location = New System.Drawing.Point(0, 24)
        Me.ItemForCODIGO_OPCION.Name = "ItemForCODIGO_OPCION"
        Me.ItemForCODIGO_OPCION.Size = New System.Drawing.Size(254, 24)
        Me.ItemForCODIGO_OPCION.Text = "Opción"
        Me.ItemForCODIGO_OPCION.TextSize = New System.Drawing.Size(33, 13)
        '
        'ItemForCODIGO_ROL
        '
        Me.ItemForCODIGO_ROL.Control = Me.CODIGO_ROLSpinEdit
        Me.ItemForCODIGO_ROL.CustomizationFormText = "CODIGO_ROL"
        Me.ItemForCODIGO_ROL.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCODIGO_ROL.Name = "ItemForCODIGO_ROL"
        Me.ItemForCODIGO_ROL.Size = New System.Drawing.Size(254, 24)
        Me.ItemForCODIGO_ROL.Text = "Rol"
        Me.ItemForCODIGO_ROL.TextSize = New System.Drawing.Size(33, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(254, 24)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(201, 24)
        Me.EmptySpaceItem5.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(254, 0)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(201, 24)
        Me.EmptySpaceItem6.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.PanelControl2
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(455, 39)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.BtnEliminar)
        Me.PanelControl1.Controls.Add(Me.BtnNuevo)
        Me.PanelControl1.Controls.Add(Me.BtnGuardar)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(268, 60)
        Me.PanelControl1.TabIndex = 7
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminar.Appearance.Options.UseFont = True
        Me.BtnEliminar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(123, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(55, 55)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.Appearance.Options.UseFont = True
        Me.BtnNuevo.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources._new
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(5, 2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 55)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.guardar1
        Me.BtnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(64, 2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 55)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem2, Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(501, 386)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(272, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(209, 64)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(209, 64)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(209, 64)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PanelControl1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(272, 64)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DataLayoutControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 64)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(479, 111)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(479, 111)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(481, 111)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GCBusqueda
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 175)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(479, 0)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(479, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(481, 191)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'IM_OPERACIONES_POR_ROLTableAdapter
        '
        Me.IM_OPERACIONES_POR_ROLTableAdapter.ClearBeforeFill = True
        '
        'IM_OPCIONESTableAdapter
        '
        Me.IM_OPCIONESTableAdapter.ClearBeforeFill = True
        '
        'IM_ROLESTableAdapter
        '
        Me.IM_ROLESTableAdapter.ClearBeforeFill = True
        '
        'DT_OPCIONES_X_ROLTableAdapter
        '
        Me.DT_OPCIONES_X_ROLTableAdapter.ClearBeforeFill = True
        '
        'XfrmOperacionesPorRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 386)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "XfrmOperacionesPorRol"
        Me.Text = "Operaciones Por Rol"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTOPCIONESXROLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.ChkEliminar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMOPERACIONESPORROLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkModificar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkInsertar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADICIONADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODIFICADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_OPCIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMOPCIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_ROLSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMROLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_OPCION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_ROL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DTUsers As Inscripcion_de_Moviemientos.DTUsers
    Friend WithEvents IMOPERACIONESPORROLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_OPERACIONES_POR_ROLTableAdapter As Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_OPERACIONES_POR_ROLTableAdapter
    Friend WithEvents IMOPCIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_OPCIONESTableAdapter As Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_OPCIONESTableAdapter
    Friend WithEvents IMROLESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_ROLESTableAdapter As Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_ROLESTableAdapter
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ChkEliminar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkModificar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkInsertar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ADICIONADO_PORSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FECHA_ADICIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MODIFICADO_PORSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FECHA_MODIFICACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CODIGO_OPCIONSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CODIGO_ROLSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ItemForADICIONADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_ADICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMODIFICADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_MODIFICACION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCODIGO_OPCION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_ROL As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DTOPCIONESXROLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DT_OPCIONES_X_ROLTableAdapter As Inscripcion_de_Moviemientos.DTUsersTableAdapters.DT_OPCIONES_X_ROLTableAdapter
    Friend WithEvents colCODIGO_OPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_ROL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colROLES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINSERTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMODIFICAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colELIMINAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
