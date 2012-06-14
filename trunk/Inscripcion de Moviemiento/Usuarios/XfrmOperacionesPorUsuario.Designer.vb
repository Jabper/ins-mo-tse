<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmOperacionesPorUsuario
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
        Me.DTOPERACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTUsuario = New Inscripcion_de_Moviemientos.DTUsuario
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_OPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_USUARIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINSERTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colMODIFICAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colELIMINAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.ChkEliminar = New DevExpress.XtraEditors.CheckEdit
        Me.IMOPERACIONESXUSUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChkModificar = New DevExpress.XtraEditors.CheckEdit
        Me.ChkInsertar = New DevExpress.XtraEditors.CheckEdit
        Me.INSERTARTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.MODIFICARTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ELIMINARTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ADICIONADO_PORTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FECHA_ADICIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.MODIFICADO_PORTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FECHA_MODIFICACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.CODIGO_USUARIOTextEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMUSUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTUsers = New Inscripcion_de_Moviemientos.DTUsers
        Me.CODIGO_OPCIONSpinEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMOPCIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemForINSERTAR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForMODIFICAR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForELIMINAR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForADICIONADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_ADICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForMODIFICADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_MODIFICACION = New DevExpress.XtraLayout.LayoutControlItem
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.ItemForCODIGO_OPCION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_USUARIO = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.IM_OPERACIONES_X_USUARIOTableAdapter = New Inscripcion_de_Moviemientos.DTUsuarioTableAdapters.IM_OPERACIONES_X_USUARIOTableAdapter
        Me.IM_USUARIOSTableAdapter = New Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_USUARIOSTableAdapter
        Me.IM_OPCIONESTableAdapter = New Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_OPCIONESTableAdapter
        Me.DT_OPERACIONESTableAdapter = New Inscripcion_de_Moviemientos.DTUsuarioTableAdapters.DT_OPERACIONESTableAdapter
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTOPERACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.ChkEliminar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMOPERACIONESXUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkModificar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkInsertar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INSERTARTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODIFICARTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELIMINARTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADICIONADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODIFICADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_USUARIOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_OPCIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMOPCIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForINSERTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMODIFICAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForELIMINAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_OPCION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_USUARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(659, 186, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(540, 344)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GCBusqueda
        '
        Me.GCBusqueda.DataSource = Me.DTOPERACIONESBindingSource
        Me.GCBusqueda.Location = New System.Drawing.Point(12, 196)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemCheckEdit3})
        Me.GCBusqueda.Size = New System.Drawing.Size(516, 136)
        Me.GCBusqueda.TabIndex = 8
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'DTOPERACIONESBindingSource
        '
        Me.DTOPERACIONESBindingSource.DataMember = "DT_OPERACIONES"
        Me.DTOPERACIONESBindingSource.DataSource = Me.DTUsuario
        '
        'DTUsuario
        '
        Me.DTUsuario.DataSetName = "DTUsuario"
        Me.DTUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_OPCION, Me.colCODIGO_USUARIO, Me.colDESCRIPCION, Me.colINSERTAR, Me.colMODIFICAR, Me.colELIMINAR})
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
        Me.colCODIGO_OPCION.Width = 84
        '
        'colCODIGO_USUARIO
        '
        Me.colCODIGO_USUARIO.FieldName = "CODIGO_USUARIO"
        Me.colCODIGO_USUARIO.Name = "colCODIGO_USUARIO"
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Opcion"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 1
        Me.colDESCRIPCION.Width = 187
        '
        'colINSERTAR
        '
        Me.colINSERTAR.Caption = "Insertar"
        Me.colINSERTAR.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colINSERTAR.FieldName = "INSERTAR"
        Me.colINSERTAR.Name = "colINSERTAR"
        Me.colINSERTAR.Visible = True
        Me.colINSERTAR.VisibleIndex = 2
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "S"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'colMODIFICAR
        '
        Me.colMODIFICAR.Caption = "Modificar"
        Me.colMODIFICAR.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colMODIFICAR.FieldName = "MODIFICAR"
        Me.colMODIFICAR.Name = "colMODIFICAR"
        Me.colMODIFICAR.Visible = True
        Me.colMODIFICAR.VisibleIndex = 3
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.ValueChecked = "S"
        Me.RepositoryItemCheckEdit2.ValueUnchecked = "N"
        '
        'colELIMINAR
        '
        Me.colELIMINAR.Caption = "Eliminar"
        Me.colELIMINAR.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.colELIMINAR.FieldName = "ELIMINAR"
        Me.colELIMINAR.Name = "colELIMINAR"
        Me.colELIMINAR.Visible = True
        Me.colELIMINAR.VisibleIndex = 4
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.ValueChecked = "S"
        Me.RepositoryItemCheckEdit3.ValueUnchecked = "N"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.PanelControl2)
        Me.DataLayoutControl1.Controls.Add(Me.INSERTARTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MODIFICARTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ELIMINARTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ADICIONADO_PORTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_ADICIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MODIFICADO_PORTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_MODIFICACIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_USUARIOTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_OPCIONSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.IMOPERACIONESXUSUARIOBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForINSERTAR, Me.ItemForMODIFICAR, Me.ItemForELIMINAR, Me.ItemForADICIONADO_POR, Me.ItemForFECHA_ADICION, Me.ItemForMODIFICADO_POR, Me.ItemForFECHA_MODIFICACION})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 80)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(647, 34, 250, 350)
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(399, 112)
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
        Me.PanelControl2.Size = New System.Drawing.Size(375, 40)
        Me.PanelControl2.TabIndex = 11
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
        Me.ChkEliminar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "ELIMINAR", True))
        Me.ChkEliminar.Location = New System.Drawing.Point(255, 9)
        Me.ChkEliminar.Name = "ChkEliminar"
        Me.ChkEliminar.Properties.Caption = "Eliminar"
        Me.ChkEliminar.Properties.ValueChecked = "S"
        Me.ChkEliminar.Properties.ValueUnchecked = "N"
        Me.ChkEliminar.Size = New System.Drawing.Size(75, 19)
        Me.ChkEliminar.TabIndex = 2
        '
        'IMOPERACIONESXUSUARIOBindingSource
        '
        Me.IMOPERACIONESXUSUARIOBindingSource.DataMember = "IM_OPERACIONES_X_USUARIO"
        Me.IMOPERACIONESXUSUARIOBindingSource.DataSource = Me.DTUsuario
        '
        'ChkModificar
        '
        Me.ChkModificar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "MODIFICAR", True))
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
        Me.ChkInsertar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "INSERTAR", True))
        Me.ChkInsertar.Location = New System.Drawing.Point(91, 9)
        Me.ChkInsertar.Name = "ChkInsertar"
        Me.ChkInsertar.Properties.Caption = "Insertar"
        Me.ChkInsertar.Properties.ValueChecked = "S"
        Me.ChkInsertar.Properties.ValueUnchecked = "N"
        Me.ChkInsertar.Size = New System.Drawing.Size(75, 19)
        Me.ChkInsertar.TabIndex = 0
        '
        'INSERTARTextEdit
        '
        Me.INSERTARTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "INSERTAR", True))
        Me.INSERTARTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.INSERTARTextEdit.Name = "INSERTARTextEdit"
        Me.INSERTARTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.INSERTARTextEdit.StyleController = Me.DataLayoutControl1
        Me.INSERTARTextEdit.TabIndex = 6
        '
        'MODIFICARTextEdit
        '
        Me.MODIFICARTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "MODIFICAR", True))
        Me.MODIFICARTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.MODIFICARTextEdit.Name = "MODIFICARTextEdit"
        Me.MODIFICARTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.MODIFICARTextEdit.StyleController = Me.DataLayoutControl1
        Me.MODIFICARTextEdit.TabIndex = 7
        '
        'ELIMINARTextEdit
        '
        Me.ELIMINARTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "ELIMINAR", True))
        Me.ELIMINARTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ELIMINARTextEdit.Name = "ELIMINARTextEdit"
        Me.ELIMINARTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ELIMINARTextEdit.StyleController = Me.DataLayoutControl1
        Me.ELIMINARTextEdit.TabIndex = 8
        '
        'ADICIONADO_PORTextEdit
        '
        Me.ADICIONADO_PORTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "ADICIONADO_POR", True))
        Me.ADICIONADO_PORTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ADICIONADO_PORTextEdit.Name = "ADICIONADO_PORTextEdit"
        Me.ADICIONADO_PORTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ADICIONADO_PORTextEdit.StyleController = Me.DataLayoutControl1
        Me.ADICIONADO_PORTextEdit.TabIndex = 9
        '
        'FECHA_ADICIONDateEdit
        '
        Me.FECHA_ADICIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "FECHA_ADICION", True))
        Me.FECHA_ADICIONDateEdit.EditValue = Nothing
        Me.FECHA_ADICIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_ADICIONDateEdit.Name = "FECHA_ADICIONDateEdit"
        Me.FECHA_ADICIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_ADICIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_ADICIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_ADICIONDateEdit.TabIndex = 10
        '
        'MODIFICADO_PORTextEdit
        '
        Me.MODIFICADO_PORTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "MODIFICADO_POR", True))
        Me.MODIFICADO_PORTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.MODIFICADO_PORTextEdit.Name = "MODIFICADO_PORTextEdit"
        Me.MODIFICADO_PORTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.MODIFICADO_PORTextEdit.StyleController = Me.DataLayoutControl1
        Me.MODIFICADO_PORTextEdit.TabIndex = 11
        '
        'FECHA_MODIFICACIONDateEdit
        '
        Me.FECHA_MODIFICACIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "FECHA_MODIFICACION", True))
        Me.FECHA_MODIFICACIONDateEdit.EditValue = Nothing
        Me.FECHA_MODIFICACIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_MODIFICACIONDateEdit.Name = "FECHA_MODIFICACIONDateEdit"
        Me.FECHA_MODIFICACIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_MODIFICACIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_MODIFICACIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_MODIFICACIONDateEdit.TabIndex = 12
        '
        'CODIGO_USUARIOTextEdit
        '
        Me.CODIGO_USUARIOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "CODIGO_USUARIO", True))
        Me.CODIGO_USUARIOTextEdit.Location = New System.Drawing.Point(52, 12)
        Me.CODIGO_USUARIOTextEdit.Name = "CODIGO_USUARIOTextEdit"
        Me.CODIGO_USUARIOTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_USUARIOTextEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_USUARIO", "Usuario", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "Nombre Usuario", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_USUARIOTextEdit.Properties.DataSource = Me.IMUSUARIOSBindingSource
        Me.CODIGO_USUARIOTextEdit.Properties.DisplayMember = "NOMBRE"
        Me.CODIGO_USUARIOTextEdit.Properties.NullText = ""
        Me.CODIGO_USUARIOTextEdit.Properties.ValueMember = "CODIGO_USUARIO"
        Me.CODIGO_USUARIOTextEdit.Size = New System.Drawing.Size(195, 20)
        Me.CODIGO_USUARIOTextEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_USUARIOTextEdit.TabIndex = 5
        '
        'IMUSUARIOSBindingSource
        '
        Me.IMUSUARIOSBindingSource.DataMember = "IM_USUARIOS"
        Me.IMUSUARIOSBindingSource.DataSource = Me.DTUsers
        '
        'DTUsers
        '
        Me.DTUsers.DataSetName = "DTUsers"
        Me.DTUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CODIGO_OPCIONSpinEdit
        '
        Me.CODIGO_OPCIONSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESXUSUARIOBindingSource, "CODIGO_OPCION", True))
        Me.CODIGO_OPCIONSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_OPCIONSpinEdit.Location = New System.Drawing.Point(52, 36)
        Me.CODIGO_OPCIONSpinEdit.Name = "CODIGO_OPCIONSpinEdit"
        Me.CODIGO_OPCIONSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_OPCIONSpinEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Opción", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_OPCIONSpinEdit.Properties.DataSource = Me.IMOPCIONESBindingSource
        Me.CODIGO_OPCIONSpinEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_OPCIONSpinEdit.Properties.NullText = ""
        Me.CODIGO_OPCIONSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CODIGO_OPCIONSpinEdit.Properties.ValueMember = "CODIGO_OPCION"
        Me.CODIGO_OPCIONSpinEdit.Size = New System.Drawing.Size(195, 20)
        Me.CODIGO_OPCIONSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_OPCIONSpinEdit.TabIndex = 4
        '
        'IMOPCIONESBindingSource
        '
        Me.IMOPCIONESBindingSource.DataMember = "IM_OPCIONES"
        Me.IMOPCIONESBindingSource.DataSource = Me.DTUsers
        '
        'ItemForINSERTAR
        '
        Me.ItemForINSERTAR.Control = Me.INSERTARTextEdit
        Me.ItemForINSERTAR.CustomizationFormText = "INSERTAR"
        Me.ItemForINSERTAR.Location = New System.Drawing.Point(0, 0)
        Me.ItemForINSERTAR.Name = "ItemForINSERTAR"
        Me.ItemForINSERTAR.Size = New System.Drawing.Size(0, 0)
        Me.ItemForINSERTAR.Text = "INSERTAR"
        Me.ItemForINSERTAR.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForINSERTAR.TextToControlDistance = 5
        '
        'ItemForMODIFICAR
        '
        Me.ItemForMODIFICAR.Control = Me.MODIFICARTextEdit
        Me.ItemForMODIFICAR.CustomizationFormText = "MODIFICAR"
        Me.ItemForMODIFICAR.Location = New System.Drawing.Point(0, 0)
        Me.ItemForMODIFICAR.Name = "ItemForMODIFICAR"
        Me.ItemForMODIFICAR.Size = New System.Drawing.Size(0, 0)
        Me.ItemForMODIFICAR.Text = "MODIFICAR"
        Me.ItemForMODIFICAR.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForMODIFICAR.TextToControlDistance = 5
        '
        'ItemForELIMINAR
        '
        Me.ItemForELIMINAR.Control = Me.ELIMINARTextEdit
        Me.ItemForELIMINAR.CustomizationFormText = "ELIMINAR"
        Me.ItemForELIMINAR.Location = New System.Drawing.Point(0, 0)
        Me.ItemForELIMINAR.Name = "ItemForELIMINAR"
        Me.ItemForELIMINAR.Size = New System.Drawing.Size(0, 0)
        Me.ItemForELIMINAR.Text = "ELIMINAR"
        Me.ItemForELIMINAR.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForELIMINAR.TextToControlDistance = 5
        '
        'ItemForADICIONADO_POR
        '
        Me.ItemForADICIONADO_POR.Control = Me.ADICIONADO_PORTextEdit
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
        Me.ItemForMODIFICADO_POR.Control = Me.MODIFICADO_PORTextEdit
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
        Me.Root.Size = New System.Drawing.Size(399, 112)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCODIGO_OPCION, Me.ItemForCODIGO_USUARIO, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.EmptySpaceItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(379, 92)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCODIGO_OPCION
        '
        Me.ItemForCODIGO_OPCION.Control = Me.CODIGO_OPCIONSpinEdit
        Me.ItemForCODIGO_OPCION.CustomizationFormText = "Opción"
        Me.ItemForCODIGO_OPCION.Location = New System.Drawing.Point(0, 24)
        Me.ItemForCODIGO_OPCION.Name = "ItemForCODIGO_OPCION"
        Me.ItemForCODIGO_OPCION.Size = New System.Drawing.Size(239, 24)
        Me.ItemForCODIGO_OPCION.Text = "Opción"
        Me.ItemForCODIGO_OPCION.TextSize = New System.Drawing.Size(36, 13)
        '
        'ItemForCODIGO_USUARIO
        '
        Me.ItemForCODIGO_USUARIO.Control = Me.CODIGO_USUARIOTextEdit
        Me.ItemForCODIGO_USUARIO.CustomizationFormText = "Usuario"
        Me.ItemForCODIGO_USUARIO.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCODIGO_USUARIO.Name = "ItemForCODIGO_USUARIO"
        Me.ItemForCODIGO_USUARIO.Size = New System.Drawing.Size(239, 24)
        Me.ItemForCODIGO_USUARIO.Text = "Usuario"
        Me.ItemForCODIGO_USUARIO.TextSize = New System.Drawing.Size(36, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PanelControl2
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(379, 44)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(239, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(140, 24)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(239, 24)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(140, 24)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(410, 64)
        Me.PanelControl1.TabIndex = 4
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnNuevo)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnEliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(248, 64)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.Appearance.Options.UseFont = True
        Me.BtnNuevo.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources._new
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(3, 3)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(64, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 55)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminar.Appearance.Options.UseFont = True
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(125, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(55, 55)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(186, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 55)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem2, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(540, 344)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(414, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(106, 68)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(106, 68)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(106, 68)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PanelControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(414, 68)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.DataLayoutControl1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 68)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(403, 116)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(403, 116)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(520, 116)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.GCBusqueda
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 184)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(520, 0)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(520, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(520, 140)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'IM_OPERACIONES_X_USUARIOTableAdapter
        '
        Me.IM_OPERACIONES_X_USUARIOTableAdapter.ClearBeforeFill = True
        '
        'IM_USUARIOSTableAdapter
        '
        Me.IM_USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'IM_OPCIONESTableAdapter
        '
        Me.IM_OPCIONESTableAdapter.ClearBeforeFill = True
        '
        'DT_OPERACIONESTableAdapter
        '
        Me.DT_OPERACIONESTableAdapter.ClearBeforeFill = True
        '
        'XfrmOperacionesPorUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 344)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "XfrmOperacionesPorUsuario"
        Me.Text = "Operaciones Por Usuario"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTOPERACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.ChkEliminar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMOPERACIONESXUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkModificar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkInsertar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INSERTARTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODIFICARTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELIMINARTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADICIONADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODIFICADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_USUARIOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_OPCIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMOPCIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForINSERTAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMODIFICAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForELIMINAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_OPCION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_USUARIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DTUsuario As Inscripcion_de_Moviemientos.DTUsuario
    Friend WithEvents IMOPERACIONESXUSUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_OPERACIONES_X_USUARIOTableAdapter As Inscripcion_de_Moviemientos.DTUsuarioTableAdapters.IM_OPERACIONES_X_USUARIOTableAdapter
    Friend WithEvents INSERTARTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MODIFICARTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ELIMINARTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ADICIONADO_PORTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_ADICIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MODIFICADO_PORTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_MODIFICACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CODIGO_USUARIOTextEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ItemForINSERTAR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMODIFICAR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForELIMINAR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForADICIONADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_ADICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMODIFICADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_MODIFICACION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCODIGO_OPCION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_USUARIO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DTUsers As Inscripcion_de_Moviemientos.DTUsers
    Friend WithEvents IMUSUARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_USUARIOSTableAdapter As Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_USUARIOSTableAdapter
    Friend WithEvents CODIGO_OPCIONSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMOPCIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_OPCIONESTableAdapter As Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_OPCIONESTableAdapter
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChkEliminar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkModificar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkInsertar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DTOPERACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DT_OPERACIONESTableAdapter As Inscripcion_de_Moviemientos.DTUsuarioTableAdapters.DT_OPERACIONESTableAdapter
    Friend WithEvents colCODIGO_OPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_USUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINSERTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMODIFICAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colELIMINAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
