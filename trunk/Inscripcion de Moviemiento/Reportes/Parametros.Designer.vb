<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parametros
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
        Me.IMPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboPartido = New DevExpress.XtraEditors.LookUpEdit
        Me.cboMovimiento = New DevExpress.XtraEditors.LookUpEdit
        Me.IMMOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDepto = New DevExpress.XtraEditors.LookUpEdit
        Me.IMDEPARTAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboMuni = New DevExpress.XtraEditors.LookUpEdit
        Me.IMMUNICIPIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.IMCANDIDATOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbonivel = New DevExpress.XtraEditors.LookUpEdit
        Me.IMNIVELELECTIVOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPLANILLATOTALESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PLANILLA_TOTALES = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALES
        Me.IM_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
        Me.IM_MOVIMIENTOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MOVIMIENTOSTableAdapter
        Me.IM_DEPARTAMENTOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_DEPARTAMENTOSTableAdapter
        Me.IM_MUNICIPIOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MUNICIPIOSTableAdapter
        Me.IM_CANDIDATOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_CANDIDATOSTableAdapter
        Me.IM_NIVEL_ELECTIVOTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPartido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMDEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMuni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMCANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbonivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMNIVELELECTIVOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPLANILLATOTALESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PLANILLA_TOTALES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMPARTIDOSPOLITICOSBindingSource
        '
        Me.IMPARTIDOSPOLITICOSBindingSource.DataMember = "IM_PARTIDOS_POLITICOS"
        Me.IMPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'cboPartido
        '
        Me.cboPartido.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMPARTIDOSPOLITICOSBindingSource, "CODIGO_PARTIDO", True))
        Me.cboPartido.Location = New System.Drawing.Point(43, 24)
        Me.cboPartido.Name = "cboPartido"
        Me.cboPartido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPartido.Properties.DataSource = Me.IMPARTIDOSPOLITICOSBindingSource
        Me.cboPartido.Properties.DisplayMember = "NOMBRE PARTIDO"
        Me.cboPartido.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.cboPartido.Size = New System.Drawing.Size(200, 20)
        Me.cboPartido.TabIndex = 0
        '
        'cboMovimiento
        '
        Me.cboMovimiento.Location = New System.Drawing.Point(43, 51)
        Me.cboMovimiento.Name = "cboMovimiento"
        Me.cboMovimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMovimiento.Properties.DataSource = Me.IMMOVIMIENTOSBindingSource
        Me.cboMovimiento.Properties.DisplayMember = "NOMBRE MOVIMIENTO"
        Me.cboMovimiento.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        Me.cboMovimiento.Size = New System.Drawing.Size(200, 20)
        Me.cboMovimiento.TabIndex = 1
        '
        'IMMOVIMIENTOSBindingSource
        '
        Me.IMMOVIMIENTOSBindingSource.DataMember = "IM_MOVIMIENTOS"
        Me.IMMOVIMIENTOSBindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'cboDepto
        '
        Me.cboDepto.Location = New System.Drawing.Point(361, 24)
        Me.cboDepto.Name = "cboDepto"
        Me.cboDepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDepto.Properties.DataSource = Me.IMDEPARTAMENTOSBindingSource
        Me.cboDepto.Properties.DisplayMember = "DESCRIPCION"
        Me.cboDepto.Properties.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.cboDepto.Size = New System.Drawing.Size(215, 20)
        Me.cboDepto.TabIndex = 2
        '
        'IMDEPARTAMENTOSBindingSource
        '
        Me.IMDEPARTAMENTOSBindingSource.DataMember = "IM_DEPARTAMENTOS"
        Me.IMDEPARTAMENTOSBindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'cboMuni
        '
        Me.cboMuni.Location = New System.Drawing.Point(361, 50)
        Me.cboMuni.Name = "cboMuni"
        Me.cboMuni.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMuni.Properties.DataSource = Me.IMMUNICIPIOSBindingSource
        Me.cboMuni.Properties.DisplayMember = "DESCRIPCION"
        Me.cboMuni.Properties.ValueMember = "CODIGO_MUNICIPIO"
        Me.cboMuni.Size = New System.Drawing.Size(215, 20)
        Me.cboMuni.TabIndex = 3
        '
        'IMMUNICIPIOSBindingSource
        '
        Me.IMMUNICIPIOSBindingSource.DataMember = "IM_MUNICIPIOS"
        Me.IMMUNICIPIOSBindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(43, 114)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'IMCANDIDATOSBindingSource
        '
        Me.IMCANDIDATOSBindingSource.DataMember = "IM_CANDIDATOS"
        Me.IMCANDIDATOSBindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'cbonivel
        '
        Me.cbonivel.Location = New System.Drawing.Point(43, 77)
        Me.cbonivel.Name = "cbonivel"
        Me.cbonivel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbonivel.Properties.DataSource = Me.IMNIVELELECTIVOBindingSource
        Me.cbonivel.Properties.DisplayMember = "NIVEL ELECTIVO"
        Me.cbonivel.Properties.ValueMember = "CODIGO_NIVEL_ELECTIVO"
        Me.cbonivel.Size = New System.Drawing.Size(200, 20)
        Me.cbonivel.TabIndex = 5
        '
        'IMNIVELELECTIVOBindingSource
        '
        Me.IMNIVELELECTIVOBindingSource.DataMember = "IM_NIVEL_ELECTIVO"
        Me.IMNIVELELECTIVOBindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'DSPLANILLATOTALESBindingSource
        '
        Me.DSPLANILLATOTALESBindingSource.DataSource = Me.DS_PLANILLA_TOTALES
        Me.DSPLANILLATOTALESBindingSource.Position = 0
        '
        'DS_PLANILLA_TOTALES
        '
        Me.DS_PLANILLA_TOTALES.DataSetName = "DS_PLANILLA_TOTALES"
        Me.DS_PLANILLA_TOTALES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IM_PARTIDOS_POLITICOSTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'IM_MOVIMIENTOSTableAdapter
        '
        Me.IM_MOVIMIENTOSTableAdapter.ClearBeforeFill = True
        '
        'IM_DEPARTAMENTOSTableAdapter
        '
        Me.IM_DEPARTAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'IM_MUNICIPIOSTableAdapter
        '
        Me.IM_MUNICIPIOSTableAdapter.ClearBeforeFill = True
        '
        'IM_CANDIDATOSTableAdapter
        '
        Me.IM_CANDIDATOSTableAdapter.ClearBeforeFill = True
        '
        'IM_NIVEL_ELECTIVOTableAdapter
        '
        Me.IM_NIVEL_ELECTIVOTableAdapter.ClearBeforeFill = True
        '
        'Parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 146)
        Me.Controls.Add(Me.cbonivel)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cboMuni)
        Me.Controls.Add(Me.cboDepto)
        Me.Controls.Add(Me.cboMovimiento)
        Me.Controls.Add(Me.cboPartido)
        Me.Name = "Parametros"
        Me.Text = "Parametros"
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPartido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMDEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMuni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMCANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbonivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMNIVELELECTIVOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPLANILLATOTALESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PLANILLA_TOTALES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSPLANILLATOTALESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_PLANILLA_TOTALES As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALES
    Friend WithEvents IMPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents cboPartido As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboMovimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMMOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOVIMIENTOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MOVIMIENTOSTableAdapter
    Friend WithEvents cboDepto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMDEPARTAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_DEPARTAMENTOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_DEPARTAMENTOSTableAdapter
    Friend WithEvents cboMuni As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMMUNICIPIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MUNICIPIOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MUNICIPIOSTableAdapter
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IMCANDIDATOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CANDIDATOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_CANDIDATOSTableAdapter
    Friend WithEvents cbonivel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMNIVELELECTIVOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_NIVEL_ELECTIVOTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
End Class
