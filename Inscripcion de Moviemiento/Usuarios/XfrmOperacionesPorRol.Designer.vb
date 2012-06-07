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
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.DTUsers = New Inscripcion_de_Moviemientos.DTUsers
        Me.IMOPERACIONESPORROLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_OPERACIONES_POR_ROLTableAdapter = New Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_OPERACIONES_POR_ROLTableAdapter
        Me.CODIGO_OPCIONSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ItemForCODIGO_OPCION = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.CODIGO_ROLSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ItemForCODIGO_ROL = New DevExpress.XtraLayout.LayoutControlItem
        Me.ADICIONADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ItemForADICIONADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.FECHA_ADICIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.ItemForFECHA_ADICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.MODIFICADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ItemForMODIFICADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.FECHA_MODIFICACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.ItemForFECHA_MODIFICACION = New DevExpress.XtraLayout.LayoutControlItem
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMOPERACIONESPORROLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_OPCIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_OPCION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_ROLSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_ROL, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.DataLayoutControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(725, 137, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(487, 291)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(487, 291)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(467, 67)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 212)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(467, 59)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_OPCIONSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_ROLSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ADICIONADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_ADICIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MODIFICADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_MODIFICACIONDateEdit)
        Me.DataLayoutControl1.DataSource = Me.IMOPERACIONESPORROLBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForADICIONADO_POR, Me.ItemForFECHA_ADICION, Me.ItemForMODIFICADO_POR, Me.ItemForFECHA_MODIFICACION})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 79)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(463, 141)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DataLayoutControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 67)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(467, 145)
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
        Me.Root.Size = New System.Drawing.Size(463, 141)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'DTUsers
        '
        Me.DTUsers.DataSetName = "DTUsers"
        Me.DTUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IMOPERACIONESPORROLBindingSource
        '
        Me.IMOPERACIONESPORROLBindingSource.DataMember = "IM_OPERACIONES_POR_ROL"
        Me.IMOPERACIONESPORROLBindingSource.DataSource = Me.DTUsers
        '
        'IM_OPERACIONES_POR_ROLTableAdapter
        '
        Me.IM_OPERACIONES_POR_ROLTableAdapter.ClearBeforeFill = True
        '
        'CODIGO_OPCIONSpinEdit
        '
        Me.CODIGO_OPCIONSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "CODIGO_OPCION", True))
        Me.CODIGO_OPCIONSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_OPCIONSpinEdit.Location = New System.Drawing.Point(103, 12)
        Me.CODIGO_OPCIONSpinEdit.Name = "CODIGO_OPCIONSpinEdit"
        Me.CODIGO_OPCIONSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CODIGO_OPCIONSpinEdit.Size = New System.Drawing.Size(348, 20)
        Me.CODIGO_OPCIONSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_OPCIONSpinEdit.TabIndex = 4
        '
        'ItemForCODIGO_OPCION
        '
        Me.ItemForCODIGO_OPCION.Control = Me.CODIGO_OPCIONSpinEdit
        Me.ItemForCODIGO_OPCION.CustomizationFormText = "CODIGO_OPCION"
        Me.ItemForCODIGO_OPCION.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCODIGO_OPCION.Name = "ItemForCODIGO_OPCION"
        Me.ItemForCODIGO_OPCION.Size = New System.Drawing.Size(443, 24)
        Me.ItemForCODIGO_OPCION.Text = "CODIGO_OPCION"
        Me.ItemForCODIGO_OPCION.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCODIGO_OPCION, Me.ItemForCODIGO_ROL})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(443, 121)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'CODIGO_ROLSpinEdit
        '
        Me.CODIGO_ROLSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "CODIGO_ROL", True))
        Me.CODIGO_ROLSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_ROLSpinEdit.Location = New System.Drawing.Point(103, 36)
        Me.CODIGO_ROLSpinEdit.Name = "CODIGO_ROLSpinEdit"
        Me.CODIGO_ROLSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CODIGO_ROLSpinEdit.Size = New System.Drawing.Size(348, 20)
        Me.CODIGO_ROLSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_ROLSpinEdit.TabIndex = 5
        '
        'ItemForCODIGO_ROL
        '
        Me.ItemForCODIGO_ROL.Control = Me.CODIGO_ROLSpinEdit
        Me.ItemForCODIGO_ROL.CustomizationFormText = "CODIGO_ROL"
        Me.ItemForCODIGO_ROL.Location = New System.Drawing.Point(0, 24)
        Me.ItemForCODIGO_ROL.Name = "ItemForCODIGO_ROL"
        Me.ItemForCODIGO_ROL.Size = New System.Drawing.Size(443, 97)
        Me.ItemForCODIGO_ROL.Text = "CODIGO_ROL"
        Me.ItemForCODIGO_ROL.TextSize = New System.Drawing.Size(87, 13)
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
        Me.MODIFICADO_PORSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMOPERACIONESPORROLBindingSource, "MODIFICADO_POR", True))
        Me.MODIFICADO_PORSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MODIFICADO_PORSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.MODIFICADO_PORSpinEdit.Name = "MODIFICADO_PORSpinEdit"
        Me.MODIFICADO_PORSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MODIFICADO_PORSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.MODIFICADO_PORSpinEdit.StyleController = Me.DataLayoutControl1
        Me.MODIFICADO_PORSpinEdit.TabIndex = 8
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
        'XfrmOperacionesPorRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 291)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "XfrmOperacionesPorRol"
        Me.Text = "Operaciones Por Rol"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMOPERACIONESPORROLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_OPCIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_OPCION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_ROLSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_ROL, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DTUsers As Inscripcion_de_Moviemientos.DTUsers
    Friend WithEvents IMOPERACIONESPORROLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_OPERACIONES_POR_ROLTableAdapter As Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_OPERACIONES_POR_ROLTableAdapter
    Friend WithEvents CODIGO_OPCIONSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CODIGO_ROLSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ADICIONADO_PORSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FECHA_ADICIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MODIFICADO_PORSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FECHA_MODIFICACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ItemForADICIONADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_ADICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMODIFICADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_MODIFICACION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCODIGO_OPCION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_ROL As DevExpress.XtraLayout.LayoutControlItem
End Class
