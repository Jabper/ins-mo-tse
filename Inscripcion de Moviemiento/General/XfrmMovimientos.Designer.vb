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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.CODIGO_MOVIMIENTOSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.NOMBRE_MOVIMIENTOTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.CODIGO_PARTIDOSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.INSIGNIAPictureEdit = New DevExpress.XtraEditors.PictureEdit
        Me.EMBLEMAPictureEdit = New DevExpress.XtraEditors.PictureEdit
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.ItemForCODIGO_MOVIMIENTO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForNOMBRE_MOVIMIENTO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_PARTIDO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForINSIGNIA = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForEMBLEMA = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.IMMOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Inscripcion_de_Moviemientos.DataSet1
        Me.IM_MOVIMIENTOSTableAdapter = New Inscripcion_de_Moviemientos.DataSet1TableAdapters.IM_MOVIMIENTOSTableAdapter
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.CODIGO_MOVIMIENTOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOMBRE_MOVIMIENTOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_PARTIDOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INSIGNIAPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMBLEMAPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_MOVIMIENTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNOMBRE_MOVIMIENTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForINSIGNIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForEMBLEMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.DataLayoutControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(481, 175, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(501, 329)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_MOVIMIENTOSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NOMBRE_MOVIMIENTOTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_PARTIDOSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.INSIGNIAPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.EMBLEMAPictureEdit)
        Me.DataLayoutControl1.DataSource = Me.IMMOVIMIENTOSBindingSource
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 12)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(477, 150)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'CODIGO_MOVIMIENTOSpinEdit
        '
        Me.CODIGO_MOVIMIENTOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_MOVIMIENTOSpinEdit.Location = New System.Drawing.Point(129, 12)
        Me.CODIGO_MOVIMIENTOSpinEdit.Name = "CODIGO_MOVIMIENTOSpinEdit"
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CODIGO_MOVIMIENTOSpinEdit.Size = New System.Drawing.Size(336, 20)
        Me.CODIGO_MOVIMIENTOSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_MOVIMIENTOSpinEdit.TabIndex = 4
        '
        'NOMBRE_MOVIMIENTOTextEdit
        '
        Me.NOMBRE_MOVIMIENTOTextEdit.Location = New System.Drawing.Point(129, 36)
        Me.NOMBRE_MOVIMIENTOTextEdit.Name = "NOMBRE_MOVIMIENTOTextEdit"
        Me.NOMBRE_MOVIMIENTOTextEdit.Size = New System.Drawing.Size(336, 20)
        Me.NOMBRE_MOVIMIENTOTextEdit.StyleController = Me.DataLayoutControl1
        Me.NOMBRE_MOVIMIENTOTextEdit.TabIndex = 5
        '
        'CODIGO_PARTIDOSpinEdit
        '
        Me.CODIGO_PARTIDOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_PARTIDOSpinEdit.Location = New System.Drawing.Point(129, 60)
        Me.CODIGO_PARTIDOSpinEdit.Name = "CODIGO_PARTIDOSpinEdit"
        Me.CODIGO_PARTIDOSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CODIGO_PARTIDOSpinEdit.Size = New System.Drawing.Size(336, 20)
        Me.CODIGO_PARTIDOSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_PARTIDOSpinEdit.TabIndex = 6
        '
        'INSIGNIAPictureEdit
        '
        Me.INSIGNIAPictureEdit.Location = New System.Drawing.Point(129, 84)
        Me.INSIGNIAPictureEdit.Name = "INSIGNIAPictureEdit"
        Me.INSIGNIAPictureEdit.Size = New System.Drawing.Size(336, 25)
        Me.INSIGNIAPictureEdit.StyleController = Me.DataLayoutControl1
        Me.INSIGNIAPictureEdit.TabIndex = 7
        '
        'EMBLEMAPictureEdit
        '
        Me.EMBLEMAPictureEdit.Location = New System.Drawing.Point(129, 113)
        Me.EMBLEMAPictureEdit.Name = "EMBLEMAPictureEdit"
        Me.EMBLEMAPictureEdit.Size = New System.Drawing.Size(336, 25)
        Me.EMBLEMAPictureEdit.StyleController = Me.DataLayoutControl1
        Me.EMBLEMAPictureEdit.TabIndex = 8
        '
        'Root
        '
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(477, 150)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCODIGO_MOVIMIENTO, Me.ItemForNOMBRE_MOVIMIENTO, Me.ItemForCODIGO_PARTIDO, Me.ItemForINSIGNIA, Me.ItemForEMBLEMA})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(457, 130)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCODIGO_MOVIMIENTO
        '
        Me.ItemForCODIGO_MOVIMIENTO.Control = Me.CODIGO_MOVIMIENTOSpinEdit
        Me.ItemForCODIGO_MOVIMIENTO.CustomizationFormText = "CODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCODIGO_MOVIMIENTO.Name = "ItemForCODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Size = New System.Drawing.Size(457, 24)
        Me.ItemForCODIGO_MOVIMIENTO.Text = "CODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.TextSize = New System.Drawing.Size(113, 13)
        '
        'ItemForNOMBRE_MOVIMIENTO
        '
        Me.ItemForNOMBRE_MOVIMIENTO.Control = Me.NOMBRE_MOVIMIENTOTextEdit
        Me.ItemForNOMBRE_MOVIMIENTO.CustomizationFormText = "NOMBRE_MOVIMIENTO"
        Me.ItemForNOMBRE_MOVIMIENTO.Location = New System.Drawing.Point(0, 24)
        Me.ItemForNOMBRE_MOVIMIENTO.Name = "ItemForNOMBRE_MOVIMIENTO"
        Me.ItemForNOMBRE_MOVIMIENTO.Size = New System.Drawing.Size(457, 24)
        Me.ItemForNOMBRE_MOVIMIENTO.Text = "NOMBRE_MOVIMIENTO"
        Me.ItemForNOMBRE_MOVIMIENTO.TextSize = New System.Drawing.Size(113, 13)
        '
        'ItemForCODIGO_PARTIDO
        '
        Me.ItemForCODIGO_PARTIDO.Control = Me.CODIGO_PARTIDOSpinEdit
        Me.ItemForCODIGO_PARTIDO.CustomizationFormText = "CODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Location = New System.Drawing.Point(0, 48)
        Me.ItemForCODIGO_PARTIDO.Name = "ItemForCODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Size = New System.Drawing.Size(457, 24)
        Me.ItemForCODIGO_PARTIDO.Text = "CODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.TextSize = New System.Drawing.Size(113, 13)
        '
        'ItemForINSIGNIA
        '
        Me.ItemForINSIGNIA.Control = Me.INSIGNIAPictureEdit
        Me.ItemForINSIGNIA.CustomizationFormText = "INSIGNIA"
        Me.ItemForINSIGNIA.Location = New System.Drawing.Point(0, 72)
        Me.ItemForINSIGNIA.Name = "ItemForINSIGNIA"
        Me.ItemForINSIGNIA.Size = New System.Drawing.Size(457, 29)
        Me.ItemForINSIGNIA.Text = "INSIGNIA"
        Me.ItemForINSIGNIA.TextSize = New System.Drawing.Size(113, 13)
        '
        'ItemForEMBLEMA
        '
        Me.ItemForEMBLEMA.Control = Me.EMBLEMAPictureEdit
        Me.ItemForEMBLEMA.CustomizationFormText = "EMBLEMA"
        Me.ItemForEMBLEMA.Location = New System.Drawing.Point(0, 101)
        Me.ItemForEMBLEMA.Name = "ItemForEMBLEMA"
        Me.ItemForEMBLEMA.Size = New System.Drawing.Size(457, 29)
        Me.ItemForEMBLEMA.Text = "EMBLEMA"
        Me.ItemForEMBLEMA.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(501, 329)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 154)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(481, 155)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DataLayoutControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(481, 154)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'IMMOVIMIENTOSBindingSource
        '
        Me.IMMOVIMIENTOSBindingSource.DataMember = "IM_MOVIMIENTOS"
        Me.IMMOVIMIENTOSBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IM_MOVIMIENTOSTableAdapter
        '
        Me.IM_MOVIMIENTOSTableAdapter.ClearBeforeFill = True
        '
        'XfrmMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 329)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "XfrmMovimientos"
        Me.Text = "XfrmMovimientos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.CODIGO_MOVIMIENTOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOMBRE_MOVIMIENTOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_PARTIDOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INSIGNIAPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMBLEMAPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_MOVIMIENTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNOMBRE_MOVIMIENTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForINSIGNIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForEMBLEMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CODIGO_MOVIMIENTOSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NOMBRE_MOVIMIENTOTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CODIGO_PARTIDOSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents INSIGNIAPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents EMBLEMAPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCODIGO_MOVIMIENTO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNOMBRE_MOVIMIENTO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_PARTIDO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForINSIGNIA As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForEMBLEMA As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DataSet1 As Inscripcion_de_Moviemientos.DataSet1
    Friend WithEvents IMMOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOVIMIENTOSTableAdapter As Inscripcion_de_Moviemientos.DataSet1TableAdapters.IM_MOVIMIENTOSTableAdapter
End Class
