<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmIngresoCandidatos
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
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.CODIGO_CANDIDATOSSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ItemForCODIGO_CANDIDATOS = New DevExpress.XtraLayout.LayoutControlItem
        Me.NOMBRETextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ItemForNOMBRE = New DevExpress.XtraLayout.LayoutControlItem
        Me.POSICIONSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ItemForPOSICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_CARGO_ELECTIVO = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.APELLIDOTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ItemForAPELLIDO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_DEPARTAMENTO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_MUNICIPIO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_MOVIMIENTO = New DevExpress.XtraLayout.LayoutControlItem
        Me.IDENTIDADTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ItemForIDENTIDAD = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_PARTIDO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ADICIONADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ItemForADICIONADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.FECHA_ADICIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.ItemForFECHA_ADICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.MODIFICADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ItemForMODIFICADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.FECHA_MODIFICACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.ItemForFECHA_MODIFICACION = New DevExpress.XtraLayout.LayoutControlItem
        Me.LUE_NIVEL_ELECTIVO = New DevExpress.XtraEditors.LookUpEdit
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.CODIGO_CARGO_ELECTIVOSpinEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.CODIGO_DEPARTAMENTOTextEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.CODIGO_MUNICIPIOTextEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.CODIGO_PARTIDOSpinEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMNIVELELECTIVOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSCandidato = New Inscripcion_de_Moviemientos.DSCandidato
        Me.IMCANDIDATOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMCARGOSELECTIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMDEPARTAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMMUNICIPIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_CANDIDATOSTableAdapter = New Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_CANDIDATOSTableAdapter
        Me.IM_NIVEL_ELECTIVOTableAdapter = New Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
        Me.IM_CARGOS_ELECTIVOSTableAdapter = New Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_CARGOS_ELECTIVOSTableAdapter
        Me.IM_DEPARTAMENTOSTableAdapter = New Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_DEPARTAMENTOSTableAdapter
        Me.IM_MUNICIPIOSTableAdapter = New Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_MUNICIPIOSTableAdapter
        Me.IMPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
        Me.CODIGO_MOVIMIENTOSpinEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMMOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_MOVIMIENTOSTableAdapter = New Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_MOVIMIENTOSTableAdapter
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_CANDIDATOSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_CANDIDATOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOMBRETextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNOMBRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSICIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPOSICION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_CARGO_ELECTIVO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APELLIDOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAPELLIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_DEPARTAMENTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_MUNICIPIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_MOVIMIENTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDENTIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDENTIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADICIONADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODIFICADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUE_NIVEL_ELECTIVO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_CARGO_ELECTIVOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_DEPARTAMENTOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_MUNICIPIOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_PARTIDOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMNIVELELECTIVOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCandidato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMCANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMCARGOSELECTIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMDEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_MOVIMIENTOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.DataLayoutControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(304, 287, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(915, 441)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(915, 441)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 183)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(895, 65)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 248)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(895, 173)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.LUE_NIVEL_ELECTIVO)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_CANDIDATOSSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NOMBRETextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.POSICIONSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.APELLIDOTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDENTIDADTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ADICIONADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_ADICIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MODIFICADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_MODIFICACIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_CARGO_ELECTIVOSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_DEPARTAMENTOTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_MUNICIPIOTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_PARTIDOSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_MOVIMIENTOSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.IMCANDIDATOSBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCODIGO_CANDIDATOS, Me.ItemForNOMBRE, Me.ItemForPOSICION, Me.ItemForAPELLIDO, Me.ItemForIDENTIDAD, Me.ItemForADICIONADO_POR, Me.ItemForFECHA_ADICION, Me.ItemForMODIFICADO_POR, Me.ItemForFECHA_MODIFICACION})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 12)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(639, 280, 250, 350)
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(891, 179)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DataLayoutControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(24, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(895, 183)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'Root
        '
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(891, 179)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'CODIGO_CANDIDATOSSpinEdit
        '
        Me.CODIGO_CANDIDATOSSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_CANDIDATOS", True))
        Me.CODIGO_CANDIDATOSSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_CANDIDATOSSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.CODIGO_CANDIDATOSSpinEdit.Name = "CODIGO_CANDIDATOSSpinEdit"
        Me.CODIGO_CANDIDATOSSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CODIGO_CANDIDATOSSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.CODIGO_CANDIDATOSSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_CANDIDATOSSpinEdit.TabIndex = 4
        '
        'ItemForCODIGO_CANDIDATOS
        '
        Me.ItemForCODIGO_CANDIDATOS.Control = Me.CODIGO_CANDIDATOSSpinEdit
        Me.ItemForCODIGO_CANDIDATOS.CustomizationFormText = "CODIGO_CANDIDATOS"
        Me.ItemForCODIGO_CANDIDATOS.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCODIGO_CANDIDATOS.Name = "ItemForCODIGO_CANDIDATOS"
        Me.ItemForCODIGO_CANDIDATOS.Size = New System.Drawing.Size(0, 0)
        Me.ItemForCODIGO_CANDIDATOS.Text = "CODIGO_CANDIDATOS"
        Me.ItemForCODIGO_CANDIDATOS.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCODIGO_CANDIDATOS.TextToControlDistance = 5
        '
        'NOMBRETextEdit
        '
        Me.NOMBRETextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "NOMBRE", True))
        Me.NOMBRETextEdit.Location = New System.Drawing.Point(0, 0)
        Me.NOMBRETextEdit.Name = "NOMBRETextEdit"
        Me.NOMBRETextEdit.Size = New System.Drawing.Size(0, 20)
        Me.NOMBRETextEdit.StyleController = Me.DataLayoutControl1
        Me.NOMBRETextEdit.TabIndex = 5
        '
        'ItemForNOMBRE
        '
        Me.ItemForNOMBRE.Control = Me.NOMBRETextEdit
        Me.ItemForNOMBRE.CustomizationFormText = "NOMBRE"
        Me.ItemForNOMBRE.Location = New System.Drawing.Point(0, 0)
        Me.ItemForNOMBRE.Name = "ItemForNOMBRE"
        Me.ItemForNOMBRE.Size = New System.Drawing.Size(0, 0)
        Me.ItemForNOMBRE.Text = "NOMBRE"
        Me.ItemForNOMBRE.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForNOMBRE.TextToControlDistance = 5
        '
        'POSICIONSpinEdit
        '
        Me.POSICIONSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "POSICION", True))
        Me.POSICIONSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.POSICIONSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.POSICIONSpinEdit.Name = "POSICIONSpinEdit"
        Me.POSICIONSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.POSICIONSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.POSICIONSpinEdit.StyleController = Me.DataLayoutControl1
        Me.POSICIONSpinEdit.TabIndex = 6
        '
        'ItemForPOSICION
        '
        Me.ItemForPOSICION.Control = Me.POSICIONSpinEdit
        Me.ItemForPOSICION.CustomizationFormText = "POSICION"
        Me.ItemForPOSICION.Location = New System.Drawing.Point(0, 0)
        Me.ItemForPOSICION.Name = "ItemForPOSICION"
        Me.ItemForPOSICION.Size = New System.Drawing.Size(0, 0)
        Me.ItemForPOSICION.Text = "POSICION"
        Me.ItemForPOSICION.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForPOSICION.TextToControlDistance = 5
        '
        'ItemForCODIGO_CARGO_ELECTIVO
        '
        Me.ItemForCODIGO_CARGO_ELECTIVO.Control = Me.CODIGO_CARGO_ELECTIVOSpinEdit
        Me.ItemForCODIGO_CARGO_ELECTIVO.CustomizationFormText = "CODIGO_CARGO_ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.Location = New System.Drawing.Point(0, 87)
        Me.ItemForCODIGO_CARGO_ELECTIVO.Name = "ItemForCODIGO_CARGO_ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.Size = New System.Drawing.Size(871, 24)
        Me.ItemForCODIGO_CARGO_ELECTIVO.Text = "CODIGO_CARGO_ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.TextSize = New System.Drawing.Size(137, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCODIGO_CARGO_ELECTIVO, Me.ItemForCODIGO_DEPARTAMENTO, Me.ItemForCODIGO_MUNICIPIO, Me.LayoutControlItem2, Me.ItemForCODIGO_PARTIDO, Me.ItemForCODIGO_MOVIMIENTO, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(871, 159)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'APELLIDOTextEdit
        '
        Me.APELLIDOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "APELLIDO", True))
        Me.APELLIDOTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.APELLIDOTextEdit.Name = "APELLIDOTextEdit"
        Me.APELLIDOTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.APELLIDOTextEdit.StyleController = Me.DataLayoutControl1
        Me.APELLIDOTextEdit.TabIndex = 8
        '
        'ItemForAPELLIDO
        '
        Me.ItemForAPELLIDO.Control = Me.APELLIDOTextEdit
        Me.ItemForAPELLIDO.CustomizationFormText = "APELLIDO"
        Me.ItemForAPELLIDO.Location = New System.Drawing.Point(0, 0)
        Me.ItemForAPELLIDO.Name = "ItemForAPELLIDO"
        Me.ItemForAPELLIDO.Size = New System.Drawing.Size(0, 0)
        Me.ItemForAPELLIDO.Text = "APELLIDO"
        Me.ItemForAPELLIDO.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForAPELLIDO.TextToControlDistance = 5
        '
        'ItemForCODIGO_DEPARTAMENTO
        '
        Me.ItemForCODIGO_DEPARTAMENTO.Control = Me.CODIGO_DEPARTAMENTOTextEdit
        Me.ItemForCODIGO_DEPARTAMENTO.CustomizationFormText = "CODIGO_DEPARTAMENTO"
        Me.ItemForCODIGO_DEPARTAMENTO.Location = New System.Drawing.Point(0, 111)
        Me.ItemForCODIGO_DEPARTAMENTO.Name = "ItemForCODIGO_DEPARTAMENTO"
        Me.ItemForCODIGO_DEPARTAMENTO.Size = New System.Drawing.Size(871, 24)
        Me.ItemForCODIGO_DEPARTAMENTO.Text = "CODIGO_DEPARTAMENTO"
        Me.ItemForCODIGO_DEPARTAMENTO.TextSize = New System.Drawing.Size(137, 13)
        '
        'ItemForCODIGO_MUNICIPIO
        '
        Me.ItemForCODIGO_MUNICIPIO.Control = Me.CODIGO_MUNICIPIOTextEdit
        Me.ItemForCODIGO_MUNICIPIO.CustomizationFormText = "CODIGO_MUNICIPIO"
        Me.ItemForCODIGO_MUNICIPIO.Location = New System.Drawing.Point(0, 135)
        Me.ItemForCODIGO_MUNICIPIO.Name = "ItemForCODIGO_MUNICIPIO"
        Me.ItemForCODIGO_MUNICIPIO.Size = New System.Drawing.Size(871, 24)
        Me.ItemForCODIGO_MUNICIPIO.Text = "CODIGO_MUNICIPIO"
        Me.ItemForCODIGO_MUNICIPIO.TextSize = New System.Drawing.Size(137, 13)
        '
        'ItemForCODIGO_MOVIMIENTO
        '
        Me.ItemForCODIGO_MOVIMIENTO.Control = Me.CODIGO_MOVIMIENTOSpinEdit
        Me.ItemForCODIGO_MOVIMIENTO.CustomizationFormText = "CODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Location = New System.Drawing.Point(430, 0)
        Me.ItemForCODIGO_MOVIMIENTO.Name = "ItemForCODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Size = New System.Drawing.Size(441, 24)
        Me.ItemForCODIGO_MOVIMIENTO.Text = "CODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.TextSize = New System.Drawing.Size(137, 13)
        '
        'IDENTIDADTextEdit
        '
        Me.IDENTIDADTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "IDENTIDAD", True))
        Me.IDENTIDADTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.IDENTIDADTextEdit.Name = "IDENTIDADTextEdit"
        Me.IDENTIDADTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.IDENTIDADTextEdit.StyleController = Me.DataLayoutControl1
        Me.IDENTIDADTextEdit.TabIndex = 12
        '
        'ItemForIDENTIDAD
        '
        Me.ItemForIDENTIDAD.Control = Me.IDENTIDADTextEdit
        Me.ItemForIDENTIDAD.CustomizationFormText = "IDENTIDAD"
        Me.ItemForIDENTIDAD.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIDENTIDAD.Name = "ItemForIDENTIDAD"
        Me.ItemForIDENTIDAD.Size = New System.Drawing.Size(0, 0)
        Me.ItemForIDENTIDAD.Text = "IDENTIDAD"
        Me.ItemForIDENTIDAD.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForIDENTIDAD.TextToControlDistance = 5
        '
        'ItemForCODIGO_PARTIDO
        '
        Me.ItemForCODIGO_PARTIDO.Control = Me.CODIGO_PARTIDOSpinEdit
        Me.ItemForCODIGO_PARTIDO.CustomizationFormText = "CODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCODIGO_PARTIDO.Name = "ItemForCODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Size = New System.Drawing.Size(430, 24)
        Me.ItemForCODIGO_PARTIDO.Text = "CODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.TextSize = New System.Drawing.Size(137, 13)
        '
        'ADICIONADO_PORSpinEdit
        '
        Me.ADICIONADO_PORSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "ADICIONADO_POR", True))
        Me.ADICIONADO_PORSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ADICIONADO_PORSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.ADICIONADO_PORSpinEdit.Name = "ADICIONADO_PORSpinEdit"
        Me.ADICIONADO_PORSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ADICIONADO_PORSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.ADICIONADO_PORSpinEdit.StyleController = Me.DataLayoutControl1
        Me.ADICIONADO_PORSpinEdit.TabIndex = 14
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
        'FECHA_ADICIONDateEdit
        '
        Me.FECHA_ADICIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "FECHA_ADICION", True))
        Me.FECHA_ADICIONDateEdit.EditValue = Nothing
        Me.FECHA_ADICIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_ADICIONDateEdit.Name = "FECHA_ADICIONDateEdit"
        Me.FECHA_ADICIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_ADICIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_ADICIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_ADICIONDateEdit.TabIndex = 15
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
        'MODIFICADO_PORSpinEdit
        '
        Me.MODIFICADO_PORSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "MODIFICADO_POR", True))
        Me.MODIFICADO_PORSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MODIFICADO_PORSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.MODIFICADO_PORSpinEdit.Name = "MODIFICADO_PORSpinEdit"
        Me.MODIFICADO_PORSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MODIFICADO_PORSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.MODIFICADO_PORSpinEdit.StyleController = Me.DataLayoutControl1
        Me.MODIFICADO_PORSpinEdit.TabIndex = 16
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
        'FECHA_MODIFICACIONDateEdit
        '
        Me.FECHA_MODIFICACIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "FECHA_MODIFICACION", True))
        Me.FECHA_MODIFICACIONDateEdit.EditValue = Nothing
        Me.FECHA_MODIFICACIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_MODIFICACIONDateEdit.Name = "FECHA_MODIFICACIONDateEdit"
        Me.FECHA_MODIFICACIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_MODIFICACIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_MODIFICACIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_MODIFICACIONDateEdit.TabIndex = 17
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
        'LUE_NIVEL_ELECTIVO
        '
        Me.LUE_NIVEL_ELECTIVO.Location = New System.Drawing.Point(153, 75)
        Me.LUE_NIVEL_ELECTIVO.Name = "LUE_NIVEL_ELECTIVO"
        Me.LUE_NIVEL_ELECTIVO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_NIVEL_ELECTIVO.Properties.DataSource = Me.IMNIVELELECTIVOBindingSource
        Me.LUE_NIVEL_ELECTIVO.Properties.DisplayMember = "DESCRIPCION"
        Me.LUE_NIVEL_ELECTIVO.Properties.ValueMember = "CODIGO_NIVEL_ELECTIVO"
        Me.LUE_NIVEL_ELECTIVO.Size = New System.Drawing.Size(726, 20)
        Me.LUE_NIVEL_ELECTIVO.StyleController = Me.DataLayoutControl1
        Me.LUE_NIVEL_ELECTIVO.TabIndex = 18
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.LUE_NIVEL_ELECTIVO
        Me.LayoutControlItem2.CustomizationFormText = "NIVEL_ELECTIVO"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 63)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(871, 24)
        Me.LayoutControlItem2.Text = "NIVEL_ELECTIVO"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(137, 13)
        '
        'CODIGO_CARGO_ELECTIVOSpinEdit
        '
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_CARGO_ELECTIVO", True))
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.Location = New System.Drawing.Point(153, 99)
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.Name = "CODIGO_CARGO_ELECTIVOSpinEdit"
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.Properties.DataSource = Me.IMCARGOSELECTIVOSBindingSource
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.Properties.NullText = ""
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.Properties.ValueMember = "CODIGO_CARGO_ELECTIVO"
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.Size = New System.Drawing.Size(726, 20)
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_CARGO_ELECTIVOSpinEdit.TabIndex = 7
        '
        'CODIGO_DEPARTAMENTOTextEdit
        '
        Me.CODIGO_DEPARTAMENTOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_DEPARTAMENTO", True))
        Me.CODIGO_DEPARTAMENTOTextEdit.Location = New System.Drawing.Point(153, 123)
        Me.CODIGO_DEPARTAMENTOTextEdit.Name = "CODIGO_DEPARTAMENTOTextEdit"
        Me.CODIGO_DEPARTAMENTOTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_DEPARTAMENTOTextEdit.Properties.DataSource = Me.IMDEPARTAMENTOSBindingSource
        Me.CODIGO_DEPARTAMENTOTextEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_DEPARTAMENTOTextEdit.Properties.NullText = ""
        Me.CODIGO_DEPARTAMENTOTextEdit.Properties.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.CODIGO_DEPARTAMENTOTextEdit.Size = New System.Drawing.Size(726, 20)
        Me.CODIGO_DEPARTAMENTOTextEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_DEPARTAMENTOTextEdit.TabIndex = 9
        '
        'CODIGO_MUNICIPIOTextEdit
        '
        Me.CODIGO_MUNICIPIOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_MUNICIPIO", True))
        Me.CODIGO_MUNICIPIOTextEdit.Location = New System.Drawing.Point(153, 147)
        Me.CODIGO_MUNICIPIOTextEdit.Name = "CODIGO_MUNICIPIOTextEdit"
        Me.CODIGO_MUNICIPIOTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_MUNICIPIOTextEdit.Properties.DataSource = Me.IMMUNICIPIOSBindingSource
        Me.CODIGO_MUNICIPIOTextEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_MUNICIPIOTextEdit.Properties.NullText = ""
        Me.CODIGO_MUNICIPIOTextEdit.Properties.ValueMember = "CODIGO_MUNICIPIO"
        Me.CODIGO_MUNICIPIOTextEdit.Size = New System.Drawing.Size(726, 20)
        Me.CODIGO_MUNICIPIOTextEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_MUNICIPIOTextEdit.TabIndex = 10
        '
        'CODIGO_PARTIDOSpinEdit
        '
        Me.CODIGO_PARTIDOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_PARTIDO", True))
        Me.CODIGO_PARTIDOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_PARTIDOSpinEdit.Location = New System.Drawing.Point(153, 12)
        Me.CODIGO_PARTIDOSpinEdit.Name = "CODIGO_PARTIDOSpinEdit"
        Me.CODIGO_PARTIDOSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_PARTIDOSpinEdit.Properties.DataSource = Me.IMPARTIDOSPOLITICOSBindingSource
        Me.CODIGO_PARTIDOSpinEdit.Properties.DisplayMember = "IMAGEN"
        Me.CODIGO_PARTIDOSpinEdit.Properties.NullText = ""
        Me.CODIGO_PARTIDOSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CODIGO_PARTIDOSpinEdit.Properties.ValueMember = "NOMBRE"
        Me.CODIGO_PARTIDOSpinEdit.Size = New System.Drawing.Size(285, 20)
        Me.CODIGO_PARTIDOSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_PARTIDOSpinEdit.TabIndex = 13
        '
        'IMNIVELELECTIVOBindingSource
        '
        Me.IMNIVELELECTIVOBindingSource.DataMember = "IM_NIVEL_ELECTIVO"
        Me.IMNIVELELECTIVOBindingSource.DataSource = Me.DSCandidato
        '
        'DSCandidato
        '
        Me.DSCandidato.DataSetName = "DSCandidato"
        Me.DSCandidato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IMCANDIDATOSBindingSource
        '
        Me.IMCANDIDATOSBindingSource.DataMember = "IM_CANDIDATOS"
        Me.IMCANDIDATOSBindingSource.DataSource = Me.DSCandidato
        '
        'IMCARGOSELECTIVOSBindingSource
        '
        Me.IMCARGOSELECTIVOSBindingSource.DataMember = "IM_CARGOS_ELECTIVOS"
        Me.IMCARGOSELECTIVOSBindingSource.DataSource = Me.DSCandidato
        '
        'IMDEPARTAMENTOSBindingSource
        '
        Me.IMDEPARTAMENTOSBindingSource.DataMember = "IM_DEPARTAMENTOS"
        Me.IMDEPARTAMENTOSBindingSource.DataSource = Me.DSCandidato
        '
        'IMMUNICIPIOSBindingSource
        '
        Me.IMMUNICIPIOSBindingSource.DataMember = "IM_MUNICIPIOS"
        Me.IMMUNICIPIOSBindingSource.DataSource = Me.DSCandidato
        '
        'IM_CANDIDATOSTableAdapter
        '
        Me.IM_CANDIDATOSTableAdapter.ClearBeforeFill = True
        '
        'IM_NIVEL_ELECTIVOTableAdapter
        '
        Me.IM_NIVEL_ELECTIVOTableAdapter.ClearBeforeFill = True
        '
        'IM_CARGOS_ELECTIVOSTableAdapter
        '
        Me.IM_CARGOS_ELECTIVOSTableAdapter.ClearBeforeFill = True
        '
        'IM_DEPARTAMENTOSTableAdapter
        '
        Me.IM_DEPARTAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'IM_MUNICIPIOSTableAdapter
        '
        Me.IM_MUNICIPIOSTableAdapter.ClearBeforeFill = True
        '
        'IMPARTIDOSPOLITICOSBindingSource
        '
        Me.IMPARTIDOSPOLITICOSBindingSource.DataMember = "IM_PARTIDOS_POLITICOS"
        Me.IMPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSCandidato
        '
        'IM_PARTIDOS_POLITICOSTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'CODIGO_MOVIMIENTOSpinEdit
        '
        Me.CODIGO_MOVIMIENTOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_MOVIMIENTO", True))
        Me.CODIGO_MOVIMIENTOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_MOVIMIENTOSpinEdit.Location = New System.Drawing.Point(583, 12)
        Me.CODIGO_MOVIMIENTOSpinEdit.Name = "CODIGO_MOVIMIENTOSpinEdit"
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.DataSource = Me.IMMOVIMIENTOSBindingSource
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.NullText = ""
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTOSpinEdit.Size = New System.Drawing.Size(296, 20)
        Me.CODIGO_MOVIMIENTOSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_MOVIMIENTOSpinEdit.TabIndex = 11
        '
        'IMMOVIMIENTOSBindingSource
        '
        Me.IMMOVIMIENTOSBindingSource.DataMember = "IM_MOVIMIENTOS"
        Me.IMMOVIMIENTOSBindingSource.DataSource = Me.DSCandidato
        '
        'IM_MOVIMIENTOSTableAdapter
        '
        Me.IM_MOVIMIENTOSTableAdapter.ClearBeforeFill = True
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(871, 39)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'XfrmIngresoCandidatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 441)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "XfrmIngresoCandidatos"
        Me.Text = "Registro de Candidatos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_CANDIDATOSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_CANDIDATOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOMBRETextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNOMBRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSICIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPOSICION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_CARGO_ELECTIVO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APELLIDOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAPELLIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_DEPARTAMENTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_MUNICIPIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_MOVIMIENTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDENTIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDENTIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADICIONADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODIFICADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUE_NIVEL_ELECTIVO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_CARGO_ELECTIVOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_DEPARTAMENTOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_MUNICIPIOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_PARTIDOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMNIVELELECTIVOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCandidato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMCANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMCARGOSELECTIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMDEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_MOVIMIENTOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DSCandidato As Inscripcion_de_Moviemientos.DSCandidato
    Friend WithEvents IMCANDIDATOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CANDIDATOSTableAdapter As Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_CANDIDATOSTableAdapter
    Friend WithEvents CODIGO_CANDIDATOSSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NOMBRETextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents POSICIONSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents APELLIDOTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDENTIDADTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ADICIONADO_PORSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FECHA_ADICIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MODIFICADO_PORSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FECHA_MODIFICACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ItemForCODIGO_CANDIDATOS As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNOMBRE As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPOSICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAPELLIDO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIDENTIDAD As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForADICIONADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_ADICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMODIFICADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_MODIFICACION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCODIGO_CARGO_ELECTIVO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_DEPARTAMENTO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_MUNICIPIO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_MOVIMIENTO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_PARTIDO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LUE_NIVEL_ELECTIVO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents IMNIVELELECTIVOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_NIVEL_ELECTIVOTableAdapter As Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
    Friend WithEvents CODIGO_CARGO_ELECTIVOSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMCARGOSELECTIVOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CARGOS_ELECTIVOSTableAdapter As Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_CARGOS_ELECTIVOSTableAdapter
    Friend WithEvents CODIGO_DEPARTAMENTOTextEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMDEPARTAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_DEPARTAMENTOSTableAdapter As Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_DEPARTAMENTOSTableAdapter
    Friend WithEvents CODIGO_MUNICIPIOTextEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMMUNICIPIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MUNICIPIOSTableAdapter As Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_MUNICIPIOSTableAdapter
    Friend WithEvents CODIGO_PARTIDOSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents CODIGO_MOVIMIENTOSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMMOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOVIMIENTOSTableAdapter As Inscripcion_de_Moviemientos.DSCandidatoTableAdapters.IM_MOVIMIENTOSTableAdapter
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
