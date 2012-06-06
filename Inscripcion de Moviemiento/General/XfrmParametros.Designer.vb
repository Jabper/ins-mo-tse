<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmParametros
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
        Me.PARTICIPACION_MUJER_PORCENSpinEdit = New DevExpress.XtraEditors.TextEdit
        Me.IMPARAMETROSGENERALESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Inscripcion_de_Moviemientos.DataSet1
        Me.FORMULAS_DEPART_MINSpinEdit = New DevExpress.XtraEditors.TextEdit
        Me.FORMULAS_MUNICIPIO_MINSpinEdit = New DevExpress.XtraEditors.TextEdit
        Me.FIRMAS_REPETIDAS_PORCENSpinEdit = New DevExpress.XtraEditors.TextEdit
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.ItemForPARTICIPACION_MUJER_PORCEN = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFORMULAS_DEPART_MIN = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFORMULAS_MUNICIPIO_MIN = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFIRMAS_REPETIDAS_PORCEN = New DevExpress.XtraLayout.LayoutControlItem
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.IM_PARAMETROS_GENERALESTableAdapter = New Inscripcion_de_Moviemientos.DataSet1TableAdapters.IM_PARAMETROS_GENERALESTableAdapter
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.PARTICIPACION_MUJER_PORCENSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMPARAMETROSGENERALESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMULAS_DEPART_MINSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMULAS_MUNICIPIO_MINSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIRMAS_REPETIDAS_PORCENSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPARTICIPACION_MUJER_PORCEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFORMULAS_DEPART_MIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFORMULAS_MUNICIPIO_MIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFIRMAS_REPETIDAS_PORCEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.DataLayoutControl1)
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(740, 203, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(657, 327)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.PARTICIPACION_MUJER_PORCENSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FORMULAS_DEPART_MINSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FORMULAS_MUNICIPIO_MINSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FIRMAS_REPETIDAS_PORCENSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.IMPARAMETROSGENERALESBindingSource
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 77)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(633, 117)
        Me.DataLayoutControl1.TabIndex = 7
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'PARTICIPACION_MUJER_PORCENSpinEdit
        '
        Me.PARTICIPACION_MUJER_PORCENSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMPARAMETROSGENERALESBindingSource, "PARTICIPACION_MUJER_PORCEN", True))
        Me.PARTICIPACION_MUJER_PORCENSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PARTICIPACION_MUJER_PORCENSpinEdit.Location = New System.Drawing.Point(195, 12)
        Me.PARTICIPACION_MUJER_PORCENSpinEdit.Name = "PARTICIPACION_MUJER_PORCENSpinEdit"
        Me.PARTICIPACION_MUJER_PORCENSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.PARTICIPACION_MUJER_PORCENSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.PARTICIPACION_MUJER_PORCENSpinEdit.Size = New System.Drawing.Size(426, 20)
        Me.PARTICIPACION_MUJER_PORCENSpinEdit.StyleController = Me.DataLayoutControl1
        Me.PARTICIPACION_MUJER_PORCENSpinEdit.TabIndex = 4
        '
        'IMPARAMETROSGENERALESBindingSource
        '
        Me.IMPARAMETROSGENERALESBindingSource.DataMember = "IM_PARAMETROS_GENERALES"
        Me.IMPARAMETROSGENERALESBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FORMULAS_DEPART_MINSpinEdit
        '
        Me.FORMULAS_DEPART_MINSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMPARAMETROSGENERALESBindingSource, "FORMULAS_DEPART_MIN", True))
        Me.FORMULAS_DEPART_MINSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FORMULAS_DEPART_MINSpinEdit.Location = New System.Drawing.Point(195, 36)
        Me.FORMULAS_DEPART_MINSpinEdit.Name = "FORMULAS_DEPART_MINSpinEdit"
        Me.FORMULAS_DEPART_MINSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.FORMULAS_DEPART_MINSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.FORMULAS_DEPART_MINSpinEdit.Size = New System.Drawing.Size(426, 20)
        Me.FORMULAS_DEPART_MINSpinEdit.StyleController = Me.DataLayoutControl1
        Me.FORMULAS_DEPART_MINSpinEdit.TabIndex = 5
        '
        'FORMULAS_MUNICIPIO_MINSpinEdit
        '
        Me.FORMULAS_MUNICIPIO_MINSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMPARAMETROSGENERALESBindingSource, "FORMULAS_MUNICIPIO_MIN", True))
        Me.FORMULAS_MUNICIPIO_MINSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FORMULAS_MUNICIPIO_MINSpinEdit.Location = New System.Drawing.Point(195, 60)
        Me.FORMULAS_MUNICIPIO_MINSpinEdit.Name = "FORMULAS_MUNICIPIO_MINSpinEdit"
        Me.FORMULAS_MUNICIPIO_MINSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.FORMULAS_MUNICIPIO_MINSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.FORMULAS_MUNICIPIO_MINSpinEdit.Size = New System.Drawing.Size(426, 20)
        Me.FORMULAS_MUNICIPIO_MINSpinEdit.StyleController = Me.DataLayoutControl1
        Me.FORMULAS_MUNICIPIO_MINSpinEdit.TabIndex = 6
        '
        'FIRMAS_REPETIDAS_PORCENSpinEdit
        '
        Me.FIRMAS_REPETIDAS_PORCENSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMPARAMETROSGENERALESBindingSource, "FIRMAS_REPETIDAS_PORCEN", True))
        Me.FIRMAS_REPETIDAS_PORCENSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FIRMAS_REPETIDAS_PORCENSpinEdit.Location = New System.Drawing.Point(195, 84)
        Me.FIRMAS_REPETIDAS_PORCENSpinEdit.Name = "FIRMAS_REPETIDAS_PORCENSpinEdit"
        Me.FIRMAS_REPETIDAS_PORCENSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.FIRMAS_REPETIDAS_PORCENSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.FIRMAS_REPETIDAS_PORCENSpinEdit.Size = New System.Drawing.Size(426, 20)
        Me.FIRMAS_REPETIDAS_PORCENSpinEdit.StyleController = Me.DataLayoutControl1
        Me.FIRMAS_REPETIDAS_PORCENSpinEdit.TabIndex = 7
        '
        'Root
        '
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(633, 117)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForPARTICIPACION_MUJER_PORCEN, Me.ItemForFORMULAS_DEPART_MIN, Me.ItemForFORMULAS_MUNICIPIO_MIN, Me.ItemForFIRMAS_REPETIDAS_PORCEN})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(613, 97)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForPARTICIPACION_MUJER_PORCEN
        '
        Me.ItemForPARTICIPACION_MUJER_PORCEN.Control = Me.PARTICIPACION_MUJER_PORCENSpinEdit
        Me.ItemForPARTICIPACION_MUJER_PORCEN.CustomizationFormText = "Porcentaje de Participación Femenina"
        Me.ItemForPARTICIPACION_MUJER_PORCEN.Location = New System.Drawing.Point(0, 0)
        Me.ItemForPARTICIPACION_MUJER_PORCEN.Name = "ItemForPARTICIPACION_MUJER_PORCEN"
        Me.ItemForPARTICIPACION_MUJER_PORCEN.Size = New System.Drawing.Size(613, 24)
        Me.ItemForPARTICIPACION_MUJER_PORCEN.Text = "Porcentaje de Participación Femenina"
        Me.ItemForPARTICIPACION_MUJER_PORCEN.TextSize = New System.Drawing.Size(179, 13)
        '
        'ItemForFORMULAS_DEPART_MIN
        '
        Me.ItemForFORMULAS_DEPART_MIN.Control = Me.FORMULAS_DEPART_MINSpinEdit
        Me.ItemForFORMULAS_DEPART_MIN.CustomizationFormText = "FORMULAS_DEPART_MIN"
        Me.ItemForFORMULAS_DEPART_MIN.Location = New System.Drawing.Point(0, 24)
        Me.ItemForFORMULAS_DEPART_MIN.Name = "ItemForFORMULAS_DEPART_MIN"
        Me.ItemForFORMULAS_DEPART_MIN.Size = New System.Drawing.Size(613, 24)
        Me.ItemForFORMULAS_DEPART_MIN.Text = "FORMULAS_DEPART_MIN"
        Me.ItemForFORMULAS_DEPART_MIN.TextSize = New System.Drawing.Size(179, 13)
        '
        'ItemForFORMULAS_MUNICIPIO_MIN
        '
        Me.ItemForFORMULAS_MUNICIPIO_MIN.Control = Me.FORMULAS_MUNICIPIO_MINSpinEdit
        Me.ItemForFORMULAS_MUNICIPIO_MIN.CustomizationFormText = "FORMULAS_MUNICIPIO_MIN"
        Me.ItemForFORMULAS_MUNICIPIO_MIN.Location = New System.Drawing.Point(0, 48)
        Me.ItemForFORMULAS_MUNICIPIO_MIN.Name = "ItemForFORMULAS_MUNICIPIO_MIN"
        Me.ItemForFORMULAS_MUNICIPIO_MIN.Size = New System.Drawing.Size(613, 24)
        Me.ItemForFORMULAS_MUNICIPIO_MIN.Text = "FORMULAS_MUNICIPIO_MIN"
        Me.ItemForFORMULAS_MUNICIPIO_MIN.TextSize = New System.Drawing.Size(179, 13)
        '
        'ItemForFIRMAS_REPETIDAS_PORCEN
        '
        Me.ItemForFIRMAS_REPETIDAS_PORCEN.Control = Me.FIRMAS_REPETIDAS_PORCENSpinEdit
        Me.ItemForFIRMAS_REPETIDAS_PORCEN.CustomizationFormText = "Porcentaje de Firmas Repetidas"
        Me.ItemForFIRMAS_REPETIDAS_PORCEN.Location = New System.Drawing.Point(0, 72)
        Me.ItemForFIRMAS_REPETIDAS_PORCEN.Name = "ItemForFIRMAS_REPETIDAS_PORCEN"
        Me.ItemForFIRMAS_REPETIDAS_PORCEN.Size = New System.Drawing.Size(613, 25)
        Me.ItemForFIRMAS_REPETIDAS_PORCEN.Text = "Porcentaje de Firmas Repetidas"
        Me.ItemForFIRMAS_REPETIDAS_PORCEN.TextSize = New System.Drawing.Size(179, 13)
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.BtnGuardar)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(632, 61)
        Me.PanelControl1.TabIndex = 6
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.guardar1
        Me.BtnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(3, 1)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 55)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(657, 327)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 186)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(637, 121)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PanelControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(636, 65)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(636, 65)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(637, 65)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.DataLayoutControl1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 65)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(637, 121)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(637, 121)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(637, 121)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'IM_PARAMETROS_GENERALESTableAdapter
        '
        Me.IM_PARAMETROS_GENERALESTableAdapter.ClearBeforeFill = True
        '
        'XfrmParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 327)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "XfrmParametros"
        Me.Text = "Parámetros"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.PARTICIPACION_MUJER_PORCENSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMPARAMETROSGENERALESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMULAS_DEPART_MINSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMULAS_MUNICIPIO_MINSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIRMAS_REPETIDAS_PORCENSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPARTICIPACION_MUJER_PORCEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFORMULAS_DEPART_MIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFORMULAS_MUNICIPIO_MIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFIRMAS_REPETIDAS_PORCEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DataSet1 As Inscripcion_de_Moviemientos.DataSet1
    Friend WithEvents IMPARAMETROSGENERALESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARAMETROS_GENERALESTableAdapter As Inscripcion_de_Moviemientos.DataSet1TableAdapters.IM_PARAMETROS_GENERALESTableAdapter
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForPARTICIPACION_MUJER_PORCEN As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFORMULAS_DEPART_MIN As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFORMULAS_MUNICIPIO_MIN As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFIRMAS_REPETIDAS_PORCEN As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PARTICIPACION_MUJER_PORCENSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FORMULAS_DEPART_MINSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FORMULAS_MUNICIPIO_MINSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FIRMAS_REPETIDAS_PORCENSpinEdit As DevExpress.XtraEditors.TextEdit
End Class
