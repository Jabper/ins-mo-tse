<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmPartidosPoliticos
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
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.ButtonEdit1 = New DevExpress.XtraEditors.ButtonEdit
        Me.GCPartidos_Politicos = New DevExpress.XtraGrid.GridControl
        Me.TAPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPolitico = New Inscripcion_de_Moviemientos.DSPolitico
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCANTIDAD_FIRMAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.NOMBRETextEdit = New DevExpress.XtraEditors.TextEdit
        Me.IMPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADICIONADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.FECHA_ADICIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.MODIFICADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.FECHA_MODIFICACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.IMAGENPictureEdit = New DevExpress.XtraEditors.PictureEdit
        Me.CODIGO_PARTIDOSpinEdit = New DevExpress.XtraEditors.TextEdit
        Me.CANTIDAD_FIRMASSpinEdit = New DevExpress.XtraEditors.TextEdit
        Me.ItemForADICIONADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_ADICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForMODIFICADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_MODIFICACION = New DevExpress.XtraLayout.LayoutControlItem
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.ItemForCANTIDAD_FIRMAS = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForNOMBRE = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_PARTIDO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForIMAGEN = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.IM_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TA_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCPartidos_Politicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.NOMBRETextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADICIONADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODIFICADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMAGENPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_PARTIDOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANTIDAD_FIRMASSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCANTIDAD_FIRMAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNOMBRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIMAGEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.AllowCustomizationMenu = False
        Me.LayoutControl1.Controls.Add(Me.ButtonEdit1)
        Me.LayoutControl1.Controls.Add(Me.GCPartidos_Politicos)
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Controls.Add(Me.DataLayoutControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(537, 201, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(533, 471)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ButtonEdit1
        '
        Me.ButtonEdit1.Location = New System.Drawing.Point(63, 273)
        Me.ButtonEdit1.Name = "ButtonEdit1"
        Me.ButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ButtonEdit1.Size = New System.Drawing.Size(458, 20)
        Me.ButtonEdit1.StyleController = Me.LayoutControl1
        Me.ButtonEdit1.TabIndex = 9
        '
        'GCPartidos_Politicos
        '
        Me.GCPartidos_Politicos.DataSource = Me.TAPARTIDOSPOLITICOSBindingSource
        Me.GCPartidos_Politicos.Location = New System.Drawing.Point(12, 297)
        Me.GCPartidos_Politicos.MainView = Me.GridView1
        Me.GCPartidos_Politicos.Name = "GCPartidos_Politicos"
        Me.GCPartidos_Politicos.Size = New System.Drawing.Size(509, 162)
        Me.GCPartidos_Politicos.TabIndex = 8
        Me.GCPartidos_Politicos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'TAPARTIDOSPOLITICOSBindingSource
        '
        Me.TAPARTIDOSPOLITICOSBindingSource.DataMember = "TA_PARTIDOS_POLITICOS"
        Me.TAPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSPolitico
        '
        'DSPolitico
        '
        Me.DSPolitico.DataSetName = "DSPolitico"
        Me.DSPolitico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_PARTIDO, Me.colNOMBRE, Me.colCANTIDAD_FIRMAS})
        Me.GridView1.GridControl = Me.GCPartidos_Politicos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO_PARTIDO
        '
        Me.colCODIGO_PARTIDO.Caption = "Código del Partido"
        Me.colCODIGO_PARTIDO.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Name = "colCODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Visible = True
        Me.colCODIGO_PARTIDO.VisibleIndex = 0
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "Nombre"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 1
        '
        'colCANTIDAD_FIRMAS
        '
        Me.colCANTIDAD_FIRMAS.Caption = "Cantidad de Firmas"
        Me.colCANTIDAD_FIRMAS.FieldName = "CANTIDAD_FIRMAS"
        Me.colCANTIDAD_FIRMAS.Name = "colCANTIDAD_FIRMAS"
        Me.colCANTIDAD_FIRMAS.Visible = True
        Me.colCANTIDAD_FIRMAS.VisibleIndex = 2
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCPartidos_Politicos
        Me.GridView2.Name = "GridView2"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(509, 62)
        Me.PanelControl1.TabIndex = 6
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnNuevo)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnEliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 1)
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
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.AllowCustomizationMenu = False
        Me.DataLayoutControl1.Controls.Add(Me.PanelControl2)
        Me.DataLayoutControl1.Controls.Add(Me.NOMBRETextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ADICIONADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_ADICIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MODIFICADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_MODIFICACIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IMAGENPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_PARTIDOSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CANTIDAD_FIRMASSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.IMPARTIDOSPOLITICOSBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForADICIONADO_POR, Me.ItemForFECHA_ADICION, Me.ItemForMODIFICADO_POR, Me.ItemForFECHA_MODIFICACION})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 78)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(509, 191)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 149)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(200, 30)
        Me.PanelControl2.TabIndex = 12
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(97, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(91, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Cargar Imágen"
        '
        'NOMBRETextEdit
        '
        Me.NOMBRETextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMPARTIDOSPOLITICOSBindingSource, "NOMBRE", True))
        Me.NOMBRETextEdit.Location = New System.Drawing.Point(312, 36)
        Me.NOMBRETextEdit.Name = "NOMBRETextEdit"
        Me.NOMBRETextEdit.Size = New System.Drawing.Size(185, 20)
        Me.NOMBRETextEdit.StyleController = Me.DataLayoutControl1
        Me.NOMBRETextEdit.TabIndex = 6
        '
        'IMPARTIDOSPOLITICOSBindingSource
        '
        Me.IMPARTIDOSPOLITICOSBindingSource.DataMember = "IM_PARTIDOS_POLITICOS"
        Me.IMPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSPolitico
        '
        'ADICIONADO_PORSpinEdit
        '
        Me.ADICIONADO_PORSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ADICIONADO_PORSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.ADICIONADO_PORSpinEdit.Name = "ADICIONADO_PORSpinEdit"
        Me.ADICIONADO_PORSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ADICIONADO_PORSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.ADICIONADO_PORSpinEdit.StyleController = Me.DataLayoutControl1
        Me.ADICIONADO_PORSpinEdit.TabIndex = 8
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
        Me.FECHA_ADICIONDateEdit.TabIndex = 9
        '
        'MODIFICADO_PORSpinEdit
        '
        Me.MODIFICADO_PORSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MODIFICADO_PORSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.MODIFICADO_PORSpinEdit.Name = "MODIFICADO_PORSpinEdit"
        Me.MODIFICADO_PORSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MODIFICADO_PORSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.MODIFICADO_PORSpinEdit.StyleController = Me.DataLayoutControl1
        Me.MODIFICADO_PORSpinEdit.TabIndex = 10
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
        Me.FECHA_MODIFICACIONDateEdit.TabIndex = 11
        '
        'IMAGENPictureEdit
        '
        Me.IMAGENPictureEdit.Location = New System.Drawing.Point(12, 12)
        Me.IMAGENPictureEdit.Name = "IMAGENPictureEdit"
        Me.IMAGENPictureEdit.Properties.ShowMenu = False
        Me.IMAGENPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.IMAGENPictureEdit.Size = New System.Drawing.Size(200, 133)
        Me.IMAGENPictureEdit.StyleController = Me.DataLayoutControl1
        Me.IMAGENPictureEdit.TabIndex = 5
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Ingrese una Imágen"
        Me.DxValidationProvider1.SetValidationRule(Me.IMAGENPictureEdit, ConditionValidationRule2)
        '
        'CODIGO_PARTIDOSpinEdit
        '
        Me.CODIGO_PARTIDOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMPARTIDOSPOLITICOSBindingSource, "CODIGO_PARTIDO", True))
        Me.CODIGO_PARTIDOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_PARTIDOSpinEdit.Location = New System.Drawing.Point(312, 12)
        Me.CODIGO_PARTIDOSpinEdit.Name = "CODIGO_PARTIDOSpinEdit"
        Me.CODIGO_PARTIDOSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.CODIGO_PARTIDOSpinEdit.Properties.Mask.EditMask = "00"
        Me.CODIGO_PARTIDOSpinEdit.Properties.MaxLength = 2
        Me.CODIGO_PARTIDOSpinEdit.Size = New System.Drawing.Size(185, 20)
        Me.CODIGO_PARTIDOSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_PARTIDOSpinEdit.TabIndex = 4
        '
        'CANTIDAD_FIRMASSpinEdit
        '
        Me.CANTIDAD_FIRMASSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMPARTIDOSPOLITICOSBindingSource, "CANTIDAD_FIRMAS", True))
        Me.CANTIDAD_FIRMASSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CANTIDAD_FIRMASSpinEdit.Location = New System.Drawing.Point(312, 60)
        Me.CANTIDAD_FIRMASSpinEdit.Name = "CANTIDAD_FIRMASSpinEdit"
        Me.CANTIDAD_FIRMASSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.CANTIDAD_FIRMASSpinEdit.Properties.MaxLength = 6
        Me.CANTIDAD_FIRMASSpinEdit.Size = New System.Drawing.Size(185, 20)
        Me.CANTIDAD_FIRMASSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CANTIDAD_FIRMASSpinEdit.TabIndex = 7
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
        Me.Root.AllowCustomizeChildren = False
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(509, 191)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCANTIDAD_FIRMAS, Me.ItemForNOMBRE, Me.ItemForCODIGO_PARTIDO, Me.ItemForIMAGEN, Me.LayoutControlItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(489, 171)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCANTIDAD_FIRMAS
        '
        Me.ItemForCANTIDAD_FIRMAS.Control = Me.CANTIDAD_FIRMASSpinEdit
        Me.ItemForCANTIDAD_FIRMAS.CustomizationFormText = "CANTIDAD_FIRMAS"
        Me.ItemForCANTIDAD_FIRMAS.Location = New System.Drawing.Point(204, 48)
        Me.ItemForCANTIDAD_FIRMAS.Name = "ItemForCANTIDAD_FIRMAS"
        Me.ItemForCANTIDAD_FIRMAS.Size = New System.Drawing.Size(285, 123)
        Me.ItemForCANTIDAD_FIRMAS.Text = "Cantidad de Firmas"
        Me.ItemForCANTIDAD_FIRMAS.TextSize = New System.Drawing.Size(92, 13)
        '
        'ItemForNOMBRE
        '
        Me.ItemForNOMBRE.Control = Me.NOMBRETextEdit
        Me.ItemForNOMBRE.CustomizationFormText = "NOMBRE"
        Me.ItemForNOMBRE.Location = New System.Drawing.Point(204, 24)
        Me.ItemForNOMBRE.Name = "ItemForNOMBRE"
        Me.ItemForNOMBRE.Size = New System.Drawing.Size(285, 24)
        Me.ItemForNOMBRE.Text = "Nombre"
        Me.ItemForNOMBRE.TextSize = New System.Drawing.Size(92, 13)
        '
        'ItemForCODIGO_PARTIDO
        '
        Me.ItemForCODIGO_PARTIDO.Control = Me.CODIGO_PARTIDOSpinEdit
        Me.ItemForCODIGO_PARTIDO.CustomizationFormText = "CODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Location = New System.Drawing.Point(204, 0)
        Me.ItemForCODIGO_PARTIDO.Name = "ItemForCODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Size = New System.Drawing.Size(285, 24)
        Me.ItemForCODIGO_PARTIDO.Text = "Código del Partido"
        Me.ItemForCODIGO_PARTIDO.TextSize = New System.Drawing.Size(92, 13)
        '
        'ItemForIMAGEN
        '
        Me.ItemForIMAGEN.Control = Me.IMAGENPictureEdit
        Me.ItemForIMAGEN.CustomizationFormText = "IMAGEN"
        Me.ItemForIMAGEN.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIMAGEN.Name = "ItemForIMAGEN"
        Me.ItemForIMAGEN.Size = New System.Drawing.Size(204, 137)
        Me.ItemForIMAGEN.Text = "Imágen"
        Me.ItemForIMAGEN.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForIMAGEN.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForIMAGEN.TextToControlDistance = 0
        Me.ItemForIMAGEN.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.PanelControl2
        Me.LayoutControlItem4.CustomizationFormText = "Seleccionar Archivo"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 137)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(204, 34)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(533, 471)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DataLayoutControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 66)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(513, 195)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(513, 195)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(513, 195)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PanelControl1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(513, 66)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(513, 66)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(513, 66)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GCPartidos_Politicos
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 285)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(513, 0)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(513, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(513, 166)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.ButtonEdit1
        Me.LayoutControlItem5.CustomizationFormText = "Búsqueda"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 261)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(513, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(513, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(513, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Búsqueda"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(47, 13)
        '
        'IM_PARTIDOS_POLITICOSTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Archivos de Imagen (*.jpg)|*.jpg"
        '
        'TA_PARTIDOS_POLITICOSTableAdapter
        '
        Me.TA_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'XfrmPartidosPoliticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 471)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "XfrmPartidosPoliticos"
        Me.Text = "Partidos Políticos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCPartidos_Politicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.NOMBRETextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADICIONADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODIFICADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMAGENPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_PARTIDOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANTIDAD_FIRMASSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCANTIDAD_FIRMAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNOMBRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIMAGEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents NOMBRETextEdit As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents ItemForCODIGO_PARTIDO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIMAGEN As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNOMBRE As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCANTIDAD_FIRMAS As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GCPartidos_Politicos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IMAGENPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents DSPolitico As Inscripcion_de_Moviemientos.DSPolitico
    Friend WithEvents IMPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TAPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents colCODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD_FIRMAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_PARTIDOSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CANTIDAD_FIRMASSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents ButtonEdit1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
