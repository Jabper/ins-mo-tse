<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfrmRequisitos_Cargos
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
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.GCDepartamento = New DevExpress.XtraGrid.GridControl
        Me.TAREQUISITOSXCARGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRequisitos = New Inscripcion_de_Moviemientos.DSRequisitos
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.CODIGO_REQUISITO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CARGO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CODIGO_CARGO_ELECTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.CANTIDADTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.IMREQUISITOSXCARGOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADICIONADO_PORTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FECHA_ADICIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.MODIFICADO_PORTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FECHA_MODIFICACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.REQUERIDOCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.SUBSABABLETextEdit = New DevExpress.XtraEditors.CheckEdit
        Me.AUTOMATICOCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.CODIGO_REQUISITOTextEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMREQUISITOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMCARGOSELECTIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DESCRIPCIONTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ItemForADICIONADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_ADICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForMODIFICADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_MODIFICACION = New DevExpress.XtraLayout.LayoutControlItem
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.ItemForDESCRIPCION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCANTIDAD = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_CARGO_ELECTIVO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForREQUERIDO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForAUTOMATICO = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.ItemForSUBSABABLE = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.ItemForCODIGO_REQUISITO = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.IM_REQUISITOS_X_CARGOSTableAdapter = New Inscripcion_de_Moviemientos.DSRequisitosTableAdapters.IM_REQUISITOS_X_CARGOSTableAdapter
        Me.IM_CARGOS_ELECTIVOSTableAdapter = New Inscripcion_de_Moviemientos.DSRequisitosTableAdapters.IM_CARGOS_ELECTIVOSTableAdapter
        Me.DSRequisitosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_REQUISITOS_X_CARGOTableAdapter = New Inscripcion_de_Moviemientos.DSRequisitosTableAdapters.TA_REQUISITOS_X_CARGOTableAdapter
        Me.IM_REQUISITOSTableAdapter = New Inscripcion_de_Moviemientos.DSRequisitosTableAdapters.IM_REQUISITOSTableAdapter
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.GCDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAREQUISITOSXCARGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRequisitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.CANTIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMREQUISITOSXCARGOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADICIONADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODIFICADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQUERIDOCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUBSABABLETextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUTOMATICOCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_REQUISITOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMREQUISITOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMCARGOSELECTIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DESCRIPCIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDESCRIPCION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCANTIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_CARGO_ELECTIVO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForREQUERIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAUTOMATICO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSUBSABABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_REQUISITO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRequisitosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.DataLayoutControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(697, 429)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.GCDepartamento)
        Me.DataLayoutControl1.Controls.Add(Me.FlowLayoutPanel1)
        Me.DataLayoutControl1.Controls.Add(Me.CANTIDADTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ADICIONADO_PORTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_ADICIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MODIFICADO_PORTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_MODIFICACIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.REQUERIDOCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.SUBSABABLETextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AUTOMATICOCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_REQUISITOTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_CARGO_ELECTIVOLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DESCRIPCIONTextEdit)
        Me.DataLayoutControl1.DataSource = Me.IMREQUISITOSXCARGOSBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForADICIONADO_POR, Me.ItemForFECHA_ADICION, Me.ItemForMODIFICADO_POR, Me.ItemForFECHA_MODIFICACION})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 12)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(768, 130, 250, 350)
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(598, 405)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'GCDepartamento
        '
        Me.GCDepartamento.DataSource = Me.TAREQUISITOSXCARGOBindingSource
        Me.GCDepartamento.Location = New System.Drawing.Point(12, 247)
        Me.GCDepartamento.MainView = Me.GridView1
        Me.GCDepartamento.Name = "GCDepartamento"
        Me.GCDepartamento.Size = New System.Drawing.Size(526, 146)
        Me.GCDepartamento.TabIndex = 9
        Me.GCDepartamento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'TAREQUISITOSXCARGOBindingSource
        '
        Me.TAREQUISITOSXCARGOBindingSource.DataMember = "TA_REQUISITOS_X_CARGO"
        Me.TAREQUISITOSXCARGOBindingSource.DataSource = Me.DSRequisitos
        '
        'DSRequisitos
        '
        Me.DSRequisitos.DataSetName = "DSRequisitos"
        Me.DSRequisitos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CODIGO_REQUISITO, Me.DESCRIPCION, Me.CARGO, Me.CODIGO_CARGO_ELECTIVO})
        Me.GridView1.GridControl = Me.GCDepartamento
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'CODIGO_REQUISITO
        '
        Me.CODIGO_REQUISITO.Caption = "Código"
        Me.CODIGO_REQUISITO.FieldName = "CODIGO_REQUISITO"
        Me.CODIGO_REQUISITO.Name = "CODIGO_REQUISITO"
        Me.CODIGO_REQUISITO.Visible = True
        Me.CODIGO_REQUISITO.VisibleIndex = 0
        Me.CODIGO_REQUISITO.Width = 47
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.FieldName = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Visible = True
        Me.DESCRIPCION.VisibleIndex = 1
        Me.DESCRIPCION.Width = 269
        '
        'CARGO
        '
        Me.CARGO.Caption = "Cargo Electivo"
        Me.CARGO.FieldName = "CARGO"
        Me.CARGO.Name = "CARGO"
        Me.CARGO.Visible = True
        Me.CARGO.VisibleIndex = 2
        Me.CARGO.Width = 192
        '
        'CODIGO_CARGO_ELECTIVO
        '
        Me.CODIGO_CARGO_ELECTIVO.FieldName = "CODIGO_CARGO_ELECTIVO"
        Me.CODIGO_CARGO_ELECTIVO.Name = "CODIGO_CARGO_ELECTIVO"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCDepartamento
        Me.GridView2.Name = "GridView2"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnNuevo)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnEliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(554, 63)
        Me.FlowLayoutPanel1.TabIndex = 11
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
        'CANTIDADTextEdit
        '
        Me.CANTIDADTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMREQUISITOSXCARGOSBindingSource, "CANTIDAD", True))
        Me.CANTIDADTextEdit.Location = New System.Drawing.Point(116, 129)
        Me.CANTIDADTextEdit.Name = "CANTIDADTextEdit"
        Me.CANTIDADTextEdit.Size = New System.Drawing.Size(50, 20)
        Me.CANTIDADTextEdit.StyleController = Me.DataLayoutControl1
        Me.CANTIDADTextEdit.TabIndex = 6
        '
        'IMREQUISITOSXCARGOSBindingSource
        '
        Me.IMREQUISITOSXCARGOSBindingSource.DataMember = "IM_REQUISITOS_X_CARGOS"
        Me.IMREQUISITOSXCARGOSBindingSource.DataSource = Me.DSRequisitos
        '
        'ADICIONADO_PORTextEdit
        '
        Me.ADICIONADO_PORTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMREQUISITOSXCARGOSBindingSource, "ADICIONADO_POR", True))
        Me.ADICIONADO_PORTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ADICIONADO_PORTextEdit.Name = "ADICIONADO_PORTextEdit"
        Me.ADICIONADO_PORTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ADICIONADO_PORTextEdit.StyleController = Me.DataLayoutControl1
        Me.ADICIONADO_PORTextEdit.TabIndex = 10
        '
        'FECHA_ADICIONDateEdit
        '
        Me.FECHA_ADICIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMREQUISITOSXCARGOSBindingSource, "FECHA_ADICION", True))
        Me.FECHA_ADICIONDateEdit.EditValue = Nothing
        Me.FECHA_ADICIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_ADICIONDateEdit.Name = "FECHA_ADICIONDateEdit"
        Me.FECHA_ADICIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_ADICIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_ADICIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_ADICIONDateEdit.TabIndex = 11
        '
        'MODIFICADO_PORTextEdit
        '
        Me.MODIFICADO_PORTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMREQUISITOSXCARGOSBindingSource, "MODIFICADO_POR", True))
        Me.MODIFICADO_PORTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.MODIFICADO_PORTextEdit.Name = "MODIFICADO_PORTextEdit"
        Me.MODIFICADO_PORTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.MODIFICADO_PORTextEdit.StyleController = Me.DataLayoutControl1
        Me.MODIFICADO_PORTextEdit.TabIndex = 12
        '
        'FECHA_MODIFICACIONDateEdit
        '
        Me.FECHA_MODIFICACIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMREQUISITOSXCARGOSBindingSource, "FECHA_MODIFICACION", True))
        Me.FECHA_MODIFICACIONDateEdit.EditValue = Nothing
        Me.FECHA_MODIFICACIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_MODIFICACIONDateEdit.Name = "FECHA_MODIFICACIONDateEdit"
        Me.FECHA_MODIFICACIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_MODIFICACIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_MODIFICACIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_MODIFICACIONDateEdit.TabIndex = 13
        '
        'REQUERIDOCheckEdit
        '
        Me.REQUERIDOCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMREQUISITOSXCARGOSBindingSource, "REQUERIDO", True))
        Me.REQUERIDOCheckEdit.Location = New System.Drawing.Point(12, 178)
        Me.REQUERIDOCheckEdit.Name = "REQUERIDOCheckEdit"
        Me.REQUERIDOCheckEdit.Properties.Caption = "REQUERIDO"
        Me.REQUERIDOCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.REQUERIDOCheckEdit.Properties.ValueChecked = "S"
        Me.REQUERIDOCheckEdit.Properties.ValueGrayed = "N"
        Me.REQUERIDOCheckEdit.Properties.ValueUnchecked = "N"
        Me.REQUERIDOCheckEdit.Size = New System.Drawing.Size(497, 19)
        Me.REQUERIDOCheckEdit.StyleController = Me.DataLayoutControl1
        Me.REQUERIDOCheckEdit.TabIndex = 9
        '
        'SUBSABABLETextEdit
        '
        Me.SUBSABABLETextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMREQUISITOSXCARGOSBindingSource, "SUBSABABLE", True))
        Me.SUBSABABLETextEdit.EditValue = Nothing
        Me.SUBSABABLETextEdit.Location = New System.Drawing.Point(12, 201)
        Me.SUBSABABLETextEdit.Name = "SUBSABABLETextEdit"
        Me.SUBSABABLETextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.SUBSABABLETextEdit.Properties.Caption = "SUBSANABLE"
        Me.SUBSABABLETextEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.SUBSABABLETextEdit.Properties.ValueChecked = "S"
        Me.SUBSABABLETextEdit.Properties.ValueGrayed = "N"
        Me.SUBSABABLETextEdit.Properties.ValueUnchecked = "N"
        Me.SUBSABABLETextEdit.Size = New System.Drawing.Size(497, 19)
        Me.SUBSABABLETextEdit.StyleController = Me.DataLayoutControl1
        Me.SUBSABABLETextEdit.TabIndex = 7
        '
        'AUTOMATICOCheckEdit
        '
        Me.AUTOMATICOCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMREQUISITOSXCARGOSBindingSource, "AUTOMATICO", True))
        Me.AUTOMATICOCheckEdit.Location = New System.Drawing.Point(12, 224)
        Me.AUTOMATICOCheckEdit.Name = "AUTOMATICOCheckEdit"
        Me.AUTOMATICOCheckEdit.Properties.Caption = "AUTOMATICO"
        Me.AUTOMATICOCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.AUTOMATICOCheckEdit.Properties.ValueChecked = "S"
        Me.AUTOMATICOCheckEdit.Properties.ValueGrayed = "N"
        Me.AUTOMATICOCheckEdit.Properties.ValueUnchecked = "N"
        Me.AUTOMATICOCheckEdit.Size = New System.Drawing.Size(497, 19)
        Me.AUTOMATICOCheckEdit.StyleController = Me.DataLayoutControl1
        Me.AUTOMATICOCheckEdit.TabIndex = 14
        '
        'CODIGO_REQUISITOTextEdit
        '
        Me.CODIGO_REQUISITOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMREQUISITOSXCARGOSBindingSource, "CODIGO_REQUISITO", True))
        Me.CODIGO_REQUISITOTextEdit.Location = New System.Drawing.Point(116, 79)
        Me.CODIGO_REQUISITOTextEdit.Name = "CODIGO_REQUISITOTextEdit"
        Me.CODIGO_REQUISITOTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_REQUISITOTextEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO", "CODIGO", 10, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_REQUISITOTextEdit.Properties.DataSource = Me.IMREQUISITOSBindingSource
        Me.CODIGO_REQUISITOTextEdit.Properties.DisplayMember = "CODIGO"
        Me.CODIGO_REQUISITOTextEdit.Properties.NullText = ""
        Me.CODIGO_REQUISITOTextEdit.Properties.ValueMember = "CODIGO"
        Me.CODIGO_REQUISITOTextEdit.Size = New System.Drawing.Size(117, 20)
        Me.CODIGO_REQUISITOTextEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_REQUISITOTextEdit.TabIndex = 4
        '
        'IMREQUISITOSBindingSource
        '
        Me.IMREQUISITOSBindingSource.DataMember = "IM_REQUISITOS"
        Me.IMREQUISITOSBindingSource.DataSource = Me.DSRequisitos
        '
        'CODIGO_CARGO_ELECTIVOLookUpEdit
        '
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMREQUISITOSXCARGOSBindingSource, "CODIGO_CARGO_ELECTIVO", True))
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.EditValue = ""
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Location = New System.Drawing.Point(116, 153)
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Name = "CODIGO_CARGO_ELECTIVOLookUpEdit"
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.DataSource = Me.IMCARGOSELECTIVOSBindingSource
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.ValueMember = "CODIGO_CARGO_ELECTIVO"
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Size = New System.Drawing.Size(393, 20)
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.TabIndex = 8
        '
        'IMCARGOSELECTIVOSBindingSource
        '
        Me.IMCARGOSELECTIVOSBindingSource.DataMember = "IM_CARGOS_ELECTIVOS"
        Me.IMCARGOSELECTIVOSBindingSource.DataSource = Me.DSRequisitos
        '
        'DESCRIPCIONTextEdit
        '
        Me.DESCRIPCIONTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMREQUISITOSXCARGOSBindingSource, "DESCRIPCION", True))
        Me.DESCRIPCIONTextEdit.Enabled = False
        Me.DESCRIPCIONTextEdit.Location = New System.Drawing.Point(116, 104)
        Me.DESCRIPCIONTextEdit.Name = "DESCRIPCIONTextEdit"
        Me.DESCRIPCIONTextEdit.Size = New System.Drawing.Size(393, 20)
        Me.DESCRIPCIONTextEdit.StyleController = Me.DataLayoutControl1
        Me.DESCRIPCIONTextEdit.TabIndex = 5
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
        Me.Root.Size = New System.Drawing.Size(598, 405)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForDESCRIPCION, Me.ItemForCANTIDAD, Me.ItemForCODIGO_CARGO_ELECTIVO, Me.ItemForREQUERIDO, Me.ItemForAUTOMATICO, Me.EmptySpaceItem2, Me.EmptySpaceItem4, Me.ItemForSUBSABABLE, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem5, Me.ItemForCODIGO_REQUISITO, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(578, 385)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForDESCRIPCION
        '
        Me.ItemForDESCRIPCION.Control = Me.DESCRIPCIONTextEdit
        Me.ItemForDESCRIPCION.CustomizationFormText = "DESCRIPCION"
        Me.ItemForDESCRIPCION.Location = New System.Drawing.Point(0, 92)
        Me.ItemForDESCRIPCION.MinSize = New System.Drawing.Size(50, 25)
        Me.ItemForDESCRIPCION.Name = "ItemForDESCRIPCION"
        Me.ItemForDESCRIPCION.Size = New System.Drawing.Size(501, 25)
        Me.ItemForDESCRIPCION.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.ItemForDESCRIPCION.Text = "DESCRIPCION"
        Me.ItemForDESCRIPCION.TextSize = New System.Drawing.Size(100, 13)
        '
        'ItemForCANTIDAD
        '
        Me.ItemForCANTIDAD.Control = Me.CANTIDADTextEdit
        Me.ItemForCANTIDAD.CustomizationFormText = "CANTIDAD"
        Me.ItemForCANTIDAD.Location = New System.Drawing.Point(0, 117)
        Me.ItemForCANTIDAD.MaxSize = New System.Drawing.Size(158, 24)
        Me.ItemForCANTIDAD.MinSize = New System.Drawing.Size(158, 24)
        Me.ItemForCANTIDAD.Name = "ItemForCANTIDAD"
        Me.ItemForCANTIDAD.Size = New System.Drawing.Size(158, 24)
        Me.ItemForCANTIDAD.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.ItemForCANTIDAD.Text = "CANTIDAD"
        Me.ItemForCANTIDAD.TextSize = New System.Drawing.Size(100, 13)
        '
        'ItemForCODIGO_CARGO_ELECTIVO
        '
        Me.ItemForCODIGO_CARGO_ELECTIVO.Control = Me.CODIGO_CARGO_ELECTIVOLookUpEdit
        Me.ItemForCODIGO_CARGO_ELECTIVO.CustomizationFormText = "CODIGO_CARGO_ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.Location = New System.Drawing.Point(0, 141)
        Me.ItemForCODIGO_CARGO_ELECTIVO.MinSize = New System.Drawing.Size(50, 25)
        Me.ItemForCODIGO_CARGO_ELECTIVO.Name = "ItemForCODIGO_CARGO_ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.Size = New System.Drawing.Size(501, 25)
        Me.ItemForCODIGO_CARGO_ELECTIVO.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.ItemForCODIGO_CARGO_ELECTIVO.Text = "CARGO ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.TextSize = New System.Drawing.Size(100, 13)
        '
        'ItemForREQUERIDO
        '
        Me.ItemForREQUERIDO.Control = Me.REQUERIDOCheckEdit
        Me.ItemForREQUERIDO.CustomizationFormText = "REQUERIDO"
        Me.ItemForREQUERIDO.Location = New System.Drawing.Point(0, 166)
        Me.ItemForREQUERIDO.Name = "ItemForREQUERIDO"
        Me.ItemForREQUERIDO.Size = New System.Drawing.Size(501, 23)
        Me.ItemForREQUERIDO.Text = "REQUERIDO"
        Me.ItemForREQUERIDO.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForREQUERIDO.TextToControlDistance = 0
        Me.ItemForREQUERIDO.TextVisible = False
        '
        'ItemForAUTOMATICO
        '
        Me.ItemForAUTOMATICO.Control = Me.AUTOMATICOCheckEdit
        Me.ItemForAUTOMATICO.CustomizationFormText = "AUTOMATICO"
        Me.ItemForAUTOMATICO.Location = New System.Drawing.Point(0, 212)
        Me.ItemForAUTOMATICO.Name = "ItemForAUTOMATICO"
        Me.ItemForAUTOMATICO.Size = New System.Drawing.Size(501, 23)
        Me.ItemForAUTOMATICO.Text = "AUTOMATICO"
        Me.ItemForAUTOMATICO.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForAUTOMATICO.TextToControlDistance = 0
        Me.ItemForAUTOMATICO.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(501, 67)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(77, 168)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(77, 168)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(77, 168)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(158, 117)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(343, 24)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'ItemForSUBSABABLE
        '
        Me.ItemForSUBSABABLE.Control = Me.SUBSABABLETextEdit
        Me.ItemForSUBSABABLE.CustomizationFormText = "SUBSABABLE"
        Me.ItemForSUBSABABLE.Location = New System.Drawing.Point(0, 189)
        Me.ItemForSUBSABABLE.Name = "ItemForSUBSABABLE"
        Me.ItemForSUBSABABLE.Size = New System.Drawing.Size(501, 23)
        Me.ItemForSUBSABABLE.Text = "SUBSABABLE"
        Me.ItemForSUBSABABLE.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForSUBSABABLE.TextToControlDistance = 0
        Me.ItemForSUBSABABLE.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.FlowLayoutPanel1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(558, 67)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(558, 67)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(578, 67)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GCDepartamento
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 235)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(530, 150)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(530, 235)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(48, 150)
        Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'ItemForCODIGO_REQUISITO
        '
        Me.ItemForCODIGO_REQUISITO.Control = Me.CODIGO_REQUISITOTextEdit
        Me.ItemForCODIGO_REQUISITO.CustomizationFormText = "CODIGO_REQUISITO"
        Me.ItemForCODIGO_REQUISITO.Location = New System.Drawing.Point(0, 67)
        Me.ItemForCODIGO_REQUISITO.MinSize = New System.Drawing.Size(50, 25)
        Me.ItemForCODIGO_REQUISITO.Name = "ItemForCODIGO_REQUISITO"
        Me.ItemForCODIGO_REQUISITO.Size = New System.Drawing.Size(225, 25)
        Me.ItemForCODIGO_REQUISITO.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.ItemForCODIGO_REQUISITO.Text = "CODIGO REQUISITO"
        Me.ItemForCODIGO_REQUISITO.TextSize = New System.Drawing.Size(100, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(225, 67)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(276, 25)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(276, 25)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(276, 25)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(697, 429)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DataLayoutControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(677, 409)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'IM_REQUISITOS_X_CARGOSTableAdapter
        '
        Me.IM_REQUISITOS_X_CARGOSTableAdapter.ClearBeforeFill = True
        '
        'IM_CARGOS_ELECTIVOSTableAdapter
        '
        Me.IM_CARGOS_ELECTIVOSTableAdapter.ClearBeforeFill = True
        '
        'DSRequisitosBindingSource
        '
        Me.DSRequisitosBindingSource.DataSource = Me.DSRequisitos
        Me.DSRequisitosBindingSource.Position = 0
        '
        'TA_REQUISITOS_X_CARGOTableAdapter
        '
        Me.TA_REQUISITOS_X_CARGOTableAdapter.ClearBeforeFill = True
        '
        'IM_REQUISITOSTableAdapter
        '
        Me.IM_REQUISITOSTableAdapter.ClearBeforeFill = True
        '
        'xfrmRequisitos_Cargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 429)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xfrmRequisitos_Cargos"
        Me.Text = "Requisitos por Cargo Electivos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.GCDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAREQUISITOSXCARGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRequisitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.CANTIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMREQUISITOSXCARGOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADICIONADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODIFICADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQUERIDOCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUBSABABLETextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUTOMATICOCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_REQUISITOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMREQUISITOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMCARGOSELECTIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DESCRIPCIONTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDESCRIPCION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCANTIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_CARGO_ELECTIVO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForREQUERIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAUTOMATICO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSUBSABABLE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_REQUISITO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRequisitosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DSRequisitos As Inscripcion_de_Moviemientos.DSRequisitos
    Friend WithEvents IMREQUISITOSXCARGOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_REQUISITOS_X_CARGOSTableAdapter As Inscripcion_de_Moviemientos.DSRequisitosTableAdapters.IM_REQUISITOS_X_CARGOSTableAdapter
    Friend WithEvents CANTIDADTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ADICIONADO_PORTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_ADICIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MODIFICADO_PORTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_MODIFICACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AUTOMATICOCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents REQUERIDOCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForADICIONADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_ADICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMODIFICADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_MODIFICACION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCODIGO_REQUISITO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDESCRIPCION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCANTIDAD As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForSUBSABABLE As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_CARGO_ELECTIVO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForREQUERIDO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAUTOMATICO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SUBSABABLETextEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents IMCARGOSELECTIVOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CARGOS_ELECTIVOSTableAdapter As Inscripcion_de_Moviemientos.DSRequisitosTableAdapters.IM_CARGOS_ELECTIVOSTableAdapter
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GCDepartamento As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CODIGO_REQUISITO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CARGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_CARGO_ELECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DSRequisitosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TAREQUISITOSXCARGOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_REQUISITOS_X_CARGOTableAdapter As Inscripcion_de_Moviemientos.DSRequisitosTableAdapters.TA_REQUISITOS_X_CARGOTableAdapter
    Friend WithEvents IMREQUISITOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_REQUISITOSTableAdapter As Inscripcion_de_Moviemientos.DSRequisitosTableAdapters.IM_REQUISITOSTableAdapter
    Friend WithEvents CODIGO_REQUISITOTextEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CODIGO_CARGO_ELECTIVOLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DESCRIPCIONTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
