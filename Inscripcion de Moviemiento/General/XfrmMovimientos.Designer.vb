<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmMovimientos
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
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.GCDepartamento = New DevExpress.XtraGrid.GridControl
        Me.TAMOVIMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPolitico = New Inscripcion_de_Moviemientos.DSPolitico
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ButtonEdit1 = New DevExpress.XtraEditors.ButtonEdit
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.NOMBRE_MOVIMIENTOTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.IMMOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.BtnEmblema = New DevExpress.XtraEditors.SimpleButton
        Me.INSIGNIAPictureEdit = New DevExpress.XtraEditors.PictureEdit
        Me.EMBLEMAPictureEdit = New DevExpress.XtraEditors.PictureEdit
        Me.ADICIONADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.FECHA_ADICIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.MODIFICADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.FECHA_MODIFICACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.CODIGO_PARTIDOSpinEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.TAPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODIGO_MOVIMIENTOSpinEdit = New DevExpress.XtraEditors.TextEdit
        Me.ItemForADICIONADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_ADICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForMODIFICADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_MODIFICACION = New DevExpress.XtraLayout.LayoutControlItem
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.ItemForCODIGO_MOVIMIENTO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_PARTIDO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForINSIGNIA = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForEMBLEMA = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EspMenu = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.OFDInsignia = New System.Windows.Forms.OpenFileDialog
        Me.OFDEmblema = New System.Windows.Forms.OpenFileDialog
        Me.TA_MOVIMIENTOTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_MOVIMIENTOTableAdapter
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.TA_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
        Me.IM_MOVIMIENTOSTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.IM_MOVIMIENTOSTableAdapter
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.GCDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.NOMBRE_MOVIMIENTOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.INSIGNIAPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMBLEMAPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADICIONADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODIFICADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_PARTIDOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_MOVIMIENTOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_MOVIMIENTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForINSIGNIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEMBLEMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.AllowCustomizationMenu = False
        Me.LayoutControl1.Controls.Add(Me.PanelControl2)
        Me.LayoutControl1.Controls.Add(Me.GCDepartamento)
        Me.LayoutControl1.Controls.Add(Me.ButtonEdit1)
        Me.LayoutControl1.Controls.Add(Me.DataLayoutControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(468, 175, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(518, 439)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(314, 60)
        Me.PanelControl2.TabIndex = 9
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnNuevo)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnEliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, -1)
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
        'GCDepartamento
        '
        Me.GCDepartamento.DataSource = Me.TAMOVIMIENTOBindingSource
        Me.GCDepartamento.Location = New System.Drawing.Point(12, 335)
        Me.GCDepartamento.MainView = Me.GridView1
        Me.GCDepartamento.Name = "GCDepartamento"
        Me.GCDepartamento.Size = New System.Drawing.Size(494, 92)
        Me.GCDepartamento.TabIndex = 8
        Me.GCDepartamento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'TAMOVIMIENTOBindingSource
        '
        Me.TAMOVIMIENTOBindingSource.DataMember = "TA_MOVIMIENTO"
        Me.TAMOVIMIENTOBindingSource.DataSource = Me.DSPolitico
        '
        'DSPolitico
        '
        Me.DSPolitico.DataSetName = "DSPolitico"
        Me.DSPolitico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_MOVIMIENTO, Me.colNOMBRE_MOVIMIENTO, Me.colCODIGO_PARTIDO, Me.colNOMBRE})
        Me.GridView1.GridControl = Me.GCDepartamento
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCODIGO_MOVIMIENTO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCODIGO_MOVIMIENTO
        '
        Me.colCODIGO_MOVIMIENTO.Caption = "Código Movimiento"
        Me.colCODIGO_MOVIMIENTO.FieldName = "CODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO.Name = "colCODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO.Visible = True
        Me.colCODIGO_MOVIMIENTO.VisibleIndex = 0
        '
        'colNOMBRE_MOVIMIENTO
        '
        Me.colNOMBRE_MOVIMIENTO.Caption = "Movimiento"
        Me.colNOMBRE_MOVIMIENTO.FieldName = "NOMBRE_MOVIMIENTO"
        Me.colNOMBRE_MOVIMIENTO.Name = "colNOMBRE_MOVIMIENTO"
        Me.colNOMBRE_MOVIMIENTO.Visible = True
        Me.colNOMBRE_MOVIMIENTO.VisibleIndex = 1
        '
        'colCODIGO_PARTIDO
        '
        Me.colCODIGO_PARTIDO.Caption = "Código Partido"
        Me.colCODIGO_PARTIDO.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Name = "colCODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Visible = True
        Me.colCODIGO_PARTIDO.VisibleIndex = 2
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "Partido Político"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 3
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCDepartamento
        Me.GridView2.Name = "GridView2"
        '
        'ButtonEdit1
        '
        Me.ButtonEdit1.Location = New System.Drawing.Point(63, 311)
        Me.ButtonEdit1.Name = "ButtonEdit1"
        Me.ButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ButtonEdit1.Size = New System.Drawing.Size(443, 20)
        Me.ButtonEdit1.StyleController = Me.LayoutControl1
        Me.ButtonEdit1.TabIndex = 7
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.AllowCustomizationMenu = False
        Me.DataLayoutControl1.Controls.Add(Me.NOMBRE_MOVIMIENTOTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PanelControl4)
        Me.DataLayoutControl1.Controls.Add(Me.INSIGNIAPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.EMBLEMAPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ADICIONADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_ADICIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MODIFICADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_MODIFICACIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_PARTIDOSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_MOVIMIENTOSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.IMMOVIMIENTOSBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForADICIONADO_POR, Me.ItemForFECHA_ADICION, Me.ItemForMODIFICADO_POR, Me.ItemForFECHA_MODIFICACION})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 76)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(633, 218, 250, 350)
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(494, 231)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'NOMBRE_MOVIMIENTOTextEdit
        '
        Me.NOMBRE_MOVIMIENTOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMMOVIMIENTOSBindingSource, "NOMBRE_MOVIMIENTO", True))
        Me.NOMBRE_MOVIMIENTOTextEdit.Location = New System.Drawing.Point(127, 36)
        Me.NOMBRE_MOVIMIENTOTextEdit.Name = "NOMBRE_MOVIMIENTOTextEdit"
        Me.NOMBRE_MOVIMIENTOTextEdit.Size = New System.Drawing.Size(197, 20)
        Me.NOMBRE_MOVIMIENTOTextEdit.StyleController = Me.DataLayoutControl1
        Me.NOMBRE_MOVIMIENTOTextEdit.TabIndex = 15
        '
        'IMMOVIMIENTOSBindingSource
        '
        Me.IMMOVIMIENTOSBindingSource.DataMember = "IM_MOVIMIENTOS"
        Me.IMMOVIMIENTOSBindingSource.DataSource = Me.DSPolitico
        '
        'PanelControl4
        '
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.BtnEmblema)
        Me.PanelControl4.Location = New System.Drawing.Point(158, 192)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(220, 27)
        Me.PanelControl4.TabIndex = 14
        '
        'BtnEmblema
        '
        Me.BtnEmblema.Location = New System.Drawing.Point(114, 0)
        Me.BtnEmblema.Name = "BtnEmblema"
        Me.BtnEmblema.Size = New System.Drawing.Size(91, 23)
        Me.BtnEmblema.TabIndex = 1
        Me.BtnEmblema.Text = "Cargar Imágen"
        '
        'INSIGNIAPictureEdit
        '
        Me.INSIGNIAPictureEdit.Location = New System.Drawing.Point(12, 100)
        Me.INSIGNIAPictureEdit.Name = "INSIGNIAPictureEdit"
        Me.INSIGNIAPictureEdit.Properties.ShowMenu = False
        Me.INSIGNIAPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.INSIGNIAPictureEdit.Size = New System.Drawing.Size(111, 119)
        Me.INSIGNIAPictureEdit.StyleController = Me.DataLayoutControl1
        Me.INSIGNIAPictureEdit.TabIndex = 7
        '
        'EMBLEMAPictureEdit
        '
        Me.EMBLEMAPictureEdit.Location = New System.Drawing.Point(158, 100)
        Me.EMBLEMAPictureEdit.Name = "EMBLEMAPictureEdit"
        Me.EMBLEMAPictureEdit.Properties.ShowMenu = False
        Me.EMBLEMAPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.EMBLEMAPictureEdit.Size = New System.Drawing.Size(220, 88)
        Me.EMBLEMAPictureEdit.StyleController = Me.DataLayoutControl1
        Me.EMBLEMAPictureEdit.TabIndex = 8
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Ingrese una Imágen"
        Me.DxValidationProvider1.SetValidationRule(Me.EMBLEMAPictureEdit, ConditionValidationRule1)
        '
        'ADICIONADO_PORSpinEdit
        '
        Me.ADICIONADO_PORSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ADICIONADO_PORSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.ADICIONADO_PORSpinEdit.Name = "ADICIONADO_PORSpinEdit"
        Me.ADICIONADO_PORSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ADICIONADO_PORSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.ADICIONADO_PORSpinEdit.StyleController = Me.DataLayoutControl1
        Me.ADICIONADO_PORSpinEdit.TabIndex = 9
        '
        'FECHA_ADICIONDateEdit
        '
        Me.FECHA_ADICIONDateEdit.EditValue = Nothing
        Me.FECHA_ADICIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_ADICIONDateEdit.Name = "FECHA_ADICIONDateEdit"
        Me.FECHA_ADICIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_ADICIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_ADICIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_ADICIONDateEdit.TabIndex = 10
        '
        'MODIFICADO_PORSpinEdit
        '
        Me.MODIFICADO_PORSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MODIFICADO_PORSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.MODIFICADO_PORSpinEdit.Name = "MODIFICADO_PORSpinEdit"
        Me.MODIFICADO_PORSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MODIFICADO_PORSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.MODIFICADO_PORSpinEdit.StyleController = Me.DataLayoutControl1
        Me.MODIFICADO_PORSpinEdit.TabIndex = 11
        '
        'FECHA_MODIFICACIONDateEdit
        '
        Me.FECHA_MODIFICACIONDateEdit.EditValue = Nothing
        Me.FECHA_MODIFICACIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_MODIFICACIONDateEdit.Name = "FECHA_MODIFICACIONDateEdit"
        Me.FECHA_MODIFICACIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_MODIFICACIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_MODIFICACIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_MODIFICACIONDateEdit.TabIndex = 12
        '
        'CODIGO_PARTIDOSpinEdit
        '
        Me.CODIGO_PARTIDOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMMOVIMIENTOSBindingSource, "CODIGO_PARTIDO", True))
        Me.CODIGO_PARTIDOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_PARTIDOSpinEdit.Location = New System.Drawing.Point(127, 60)
        Me.CODIGO_PARTIDOSpinEdit.Name = "CODIGO_PARTIDOSpinEdit"
        Me.CODIGO_PARTIDOSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_PARTIDOSpinEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_PARTIDO", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "Partido Político", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.CODIGO_PARTIDOSpinEdit.Properties.DataSource = Me.TAPARTIDOSPOLITICOSBindingSource
        Me.CODIGO_PARTIDOSpinEdit.Properties.DisplayMember = "NOMBRE"
        Me.CODIGO_PARTIDOSpinEdit.Properties.NullText = ""
        Me.CODIGO_PARTIDOSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CODIGO_PARTIDOSpinEdit.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.CODIGO_PARTIDOSpinEdit.Size = New System.Drawing.Size(196, 20)
        Me.CODIGO_PARTIDOSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_PARTIDOSpinEdit.TabIndex = 6
        '
        'TAPARTIDOSPOLITICOSBindingSource
        '
        Me.TAPARTIDOSPOLITICOSBindingSource.DataMember = "TA_PARTIDOS_POLITICOS"
        Me.TAPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSPolitico
        '
        'CODIGO_MOVIMIENTOSpinEdit
        '
        Me.CODIGO_MOVIMIENTOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMMOVIMIENTOSBindingSource, "CODIGO_MOVIMIENTO", True))
        Me.CODIGO_MOVIMIENTOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_MOVIMIENTOSpinEdit.Location = New System.Drawing.Point(127, 12)
        Me.CODIGO_MOVIMIENTOSpinEdit.Name = "CODIGO_MOVIMIENTOSpinEdit"
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.MaxLength = 3
        Me.CODIGO_MOVIMIENTOSpinEdit.Size = New System.Drawing.Size(50, 20)
        Me.CODIGO_MOVIMIENTOSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_MOVIMIENTOSpinEdit.TabIndex = 4
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
        Me.Root.Size = New System.Drawing.Size(494, 231)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCODIGO_MOVIMIENTO, Me.ItemForCODIGO_PARTIDO, Me.ItemForINSIGNIA, Me.ItemForEMBLEMA, Me.LayoutControlItem8, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.LayoutControlItem9, Me.EmptySpaceItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(474, 211)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCODIGO_MOVIMIENTO
        '
        Me.ItemForCODIGO_MOVIMIENTO.Control = Me.CODIGO_MOVIMIENTOSpinEdit
        Me.ItemForCODIGO_MOVIMIENTO.CustomizationFormText = "CODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCODIGO_MOVIMIENTO.Name = "ItemForCODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Size = New System.Drawing.Size(169, 24)
        Me.ItemForCODIGO_MOVIMIENTO.Text = "Código Movimiento"
        Me.ItemForCODIGO_MOVIMIENTO.TextSize = New System.Drawing.Size(111, 13)
        '
        'ItemForCODIGO_PARTIDO
        '
        Me.ItemForCODIGO_PARTIDO.Control = Me.CODIGO_PARTIDOSpinEdit
        Me.ItemForCODIGO_PARTIDO.CustomizationFormText = "CODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Location = New System.Drawing.Point(0, 48)
        Me.ItemForCODIGO_PARTIDO.Name = "ItemForCODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Size = New System.Drawing.Size(315, 24)
        Me.ItemForCODIGO_PARTIDO.Text = "Partido Pólitico"
        Me.ItemForCODIGO_PARTIDO.TextSize = New System.Drawing.Size(111, 13)
        '
        'ItemForINSIGNIA
        '
        Me.ItemForINSIGNIA.Control = Me.INSIGNIAPictureEdit
        Me.ItemForINSIGNIA.CustomizationFormText = "INSIGNIA"
        Me.ItemForINSIGNIA.Location = New System.Drawing.Point(0, 72)
        Me.ItemForINSIGNIA.Name = "ItemForINSIGNIA"
        Me.ItemForINSIGNIA.Size = New System.Drawing.Size(115, 139)
        Me.ItemForINSIGNIA.Text = "Insignia"
        Me.ItemForINSIGNIA.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForINSIGNIA.TextSize = New System.Drawing.Size(111, 13)
        Me.ItemForINSIGNIA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'ItemForEMBLEMA
        '
        Me.ItemForEMBLEMA.Control = Me.EMBLEMAPictureEdit
        Me.ItemForEMBLEMA.CustomizationFormText = "EMBLEMA"
        Me.ItemForEMBLEMA.Location = New System.Drawing.Point(146, 72)
        Me.ItemForEMBLEMA.Name = "ItemForEMBLEMA"
        Me.ItemForEMBLEMA.Size = New System.Drawing.Size(224, 108)
        Me.ItemForEMBLEMA.Text = "Insignia"
        Me.ItemForEMBLEMA.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForEMBLEMA.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.PanelControl4
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(146, 180)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(224, 31)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(169, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(305, 24)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(316, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(158, 24)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(315, 48)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(159, 24)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(115, 72)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(31, 139)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.EmptySpaceItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.NOMBRE_MOVIMIENTOTextEdit
        Me.LayoutControlItem9.CustomizationFormText = "Nombre del Movimiento"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(316, 24)
        Me.LayoutControlItem9.Text = "Nombre del Movimiento"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(111, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(370, 72)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(104, 139)
        Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EspMenu, Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(518, 439)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EspMenu
        '
        Me.EspMenu.AllowHotTrack = False
        Me.EspMenu.CustomizationFormText = "EspMenu"
        Me.EspMenu.Location = New System.Drawing.Point(318, 0)
        Me.EspMenu.MaxSize = New System.Drawing.Size(180, 64)
        Me.EspMenu.MinSize = New System.Drawing.Size(180, 64)
        Me.EspMenu.Name = "EspMenu"
        Me.EspMenu.Size = New System.Drawing.Size(180, 64)
        Me.EspMenu.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EspMenu.Text = "EspMenu"
        Me.EspMenu.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DataLayoutControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 64)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(498, 235)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(498, 235)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(498, 235)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.ButtonEdit1
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 299)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(498, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(498, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(498, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Búsqueda"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(47, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.GCDepartamento
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 323)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(498, 0)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(498, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(498, 96)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PanelControl2
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(318, 64)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(200, 100)
        Me.PanelControl1.TabIndex = 0
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 103)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(526, 24)
        Me.LayoutControlItem4.Text = "Búsqueda"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(47, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 103)
        Me.LayoutControlItem3.Name = "LayoutControlItem4"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(526, 24)
        Me.LayoutControlItem3.Text = "Búsqueda"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(47, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'OFDInsignia
        '
        Me.OFDInsignia.FileName = "OpenFileDialog1"
        Me.OFDInsignia.Filter = "Archivos de Imagen (*.jpg)|*.jpg"
        '
        'OFDEmblema
        '
        Me.OFDEmblema.FileName = "OpenFileDialog2"
        Me.OFDEmblema.Filter = "Archivos de Imagen (*.jpg)|*.jpg"
        '
        'TA_MOVIMIENTOTableAdapter
        '
        Me.TA_MOVIMIENTOTableAdapter.ClearBeforeFill = True
        '
        'TA_PARTIDOS_POLITICOSTableAdapter
        '
        Me.TA_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'IM_MOVIMIENTOSTableAdapter
        '
        Me.IM_MOVIMIENTOSTableAdapter.ClearBeforeFill = True
        '
        'XfrmMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 439)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "XfrmMovimientos"
        Me.Text = "Movimientos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.GCDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.NOMBRE_MOVIMIENTOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.INSIGNIAPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMBLEMAPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADICIONADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODIFICADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_PARTIDOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_MOVIMIENTOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_MOVIMIENTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForINSIGNIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEMBLEMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents INSIGNIAPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents EMBLEMAPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ADICIONADO_PORSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FECHA_ADICIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MODIFICADO_PORSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FECHA_MODIFICACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ItemForADICIONADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_ADICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMODIFICADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_MODIFICACION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCODIGO_MOVIMIENTO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_PARTIDO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForINSIGNIA As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEMBLEMA As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EspMenu As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl

    Friend WithEvents ButtonEdit1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GCDepartamento As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CODIGO_PARTIDOSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CODIGO_MOVIMIENTOSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BtnEmblema As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DSPolitico As Inscripcion_de_Moviemientos.DSPolitico
    Friend WithEvents OFDInsignia As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OFDEmblema As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TAMOVIMIENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_MOVIMIENTOTableAdapter As Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_MOVIMIENTOTableAdapter
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colCODIGO_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents NOMBRE_MOVIMIENTOTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TAPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents IMMOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOVIMIENTOSTableAdapter As Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.IM_MOVIMIENTOSTableAdapter
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
End Class
