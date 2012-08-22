<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parametros4
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
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Me.CmbMovimiento = New DevExpress.XtraEditors.LookUpEdit
        Me.IMMOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPLANILLATOTALESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PLANILLA_TOTALES = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALES
        Me.cbopartido = New DevExpress.XtraEditors.LookUpEdit
        Me.IMPARTIDOSPOLITICOS1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.btnsalir = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cbonivel = New DevExpress.XtraEditors.LookUpEdit
        Me.IMNIVELELECTIVOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cboMuni = New DevExpress.XtraEditors.LookUpEdit
        Me.IMMUNICIPIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMMOVIMIENTOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDepto = New DevExpress.XtraEditors.LookUpEdit
        Me.IMDEPARTAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
        Me.IM_MOVIMIENTOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MOVIMIENTOSTableAdapter
        Me.IM_NIVEL_ELECTIVOTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
        Me.IM_DEPARTAMENTOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_DEPARTAMENTOSTableAdapter
        Me.IM_MUNICIPIOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MUNICIPIOSTableAdapter
        Me.IM_PARTIDOS_POLITICOS1TableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOS1TableAdapter
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.CmbMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPLANILLATOTALESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PLANILLA_TOTALES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbopartido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMPARTIDOSPOLITICOS1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbonivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMNIVELELECTIVOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMuni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMOVIMIENTOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMDEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbMovimiento
        '
        Me.CmbMovimiento.Location = New System.Drawing.Point(156, 38)
        Me.CmbMovimiento.Name = "CmbMovimiento"
        Me.CmbMovimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMovimiento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MOVIMIENTO", "CODIGO_MOVIMIENTO", 10, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE_MOVIMIENTO", "NOMBRE_MOVIMIENTO", 123, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CmbMovimiento.Properties.DataSource = Me.IMMOVIMIENTOSBindingSource
        Me.CmbMovimiento.Properties.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.CmbMovimiento.Properties.NullText = "Seleccione"
        Me.CmbMovimiento.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        Me.CmbMovimiento.Size = New System.Drawing.Size(200, 20)
        Me.CmbMovimiento.TabIndex = 29
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "El valor no puede estar en blanco"
        Me.DxValidationProvider1.SetValidationRule(Me.CmbMovimiento, ConditionValidationRule1)
        '
        'IMMOVIMIENTOSBindingSource
        '
        Me.IMMOVIMIENTOSBindingSource.DataMember = "IM_MOVIMIENTOS"
        Me.IMMOVIMIENTOSBindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
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
        'cbopartido
        '
        Me.cbopartido.Location = New System.Drawing.Point(156, 11)
        Me.cbopartido.Name = "cbopartido"
        Me.cbopartido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbopartido.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_PARTIDO", "CODIGO_PARTIDO", 115, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE PARTIDO", "NOMBRE PARTIDO", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IMAGEN", "IMAGEN", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.cbopartido.Properties.DataSource = Me.IMPARTIDOSPOLITICOS1BindingSource
        Me.cbopartido.Properties.DisplayMember = "NOMBRE PARTIDO"
        Me.cbopartido.Properties.NullText = "Seleccione..."
        Me.cbopartido.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.cbopartido.Size = New System.Drawing.Size(200, 20)
        Me.cbopartido.TabIndex = 26
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "El valor no puede estar en blanco"
        Me.DxValidationProvider1.SetValidationRule(Me.cbopartido, ConditionValidationRule2)
        '
        'IMPARTIDOSPOLITICOS1BindingSource
        '
        Me.IMPARTIDOSPOLITICOS1BindingSource.DataMember = "IM_PARTIDOS_POLITICOS1"
        Me.IMPARTIDOSPOLITICOS1BindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'IMPARTIDOSPOLITICOSBindingSource
        '
        Me.IMPARTIDOSPOLITICOSBindingSource.DataMember = "IM_PARTIDOS_POLITICOS"
        Me.IMPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(385, 41)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl5.TabIndex = 25
        Me.LabelControl5.Text = "Municipio"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(385, 14)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl4.TabIndex = 24
        Me.LabelControl4.Text = "Departamento"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(597, 98)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(126, 23)
        Me.btnsalir.TabIndex = 23
        Me.btnsalir.Text = "SALIR"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(14, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Nivel Electivo"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(14, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Movimiento Político"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Partido Político"
        '
        'cbonivel
        '
        Me.cbonivel.Location = New System.Drawing.Point(156, 64)
        Me.cbonivel.Name = "cbonivel"
        Me.cbonivel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbonivel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_NIVEL_ELECTIVO", "CODIGO_NIVEL_ELECTIVO", 152, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NIVEL ELECTIVO", "NIVEL ELECTIVO", 89, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cbonivel.Properties.DataSource = Me.IMNIVELELECTIVOBindingSource
        Me.cbonivel.Properties.DisplayMember = "NIVEL ELECTIVO"
        Me.cbonivel.Properties.NullText = "Seleccione..."
        Me.cbonivel.Properties.ValueMember = "CODIGO_NIVEL_ELECTIVO"
        Me.cbonivel.Size = New System.Drawing.Size(200, 20)
        Me.cbonivel.TabIndex = 19
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "El valor no puede estar en blanco"
        Me.DxValidationProvider1.SetValidationRule(Me.cbonivel, ConditionValidationRule3)
        '
        'IMNIVELELECTIVOBindingSource
        '
        Me.IMNIVELELECTIVOBindingSource.DataMember = "IM_NIVEL_ELECTIVO"
        Me.IMNIVELELECTIVOBindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(597, 67)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(126, 23)
        Me.SimpleButton1.TabIndex = 18
        Me.SimpleButton1.Text = "IMPRIMIR REPORTE"
        '
        'cboMuni
        '
        Me.cboMuni.Enabled = False
        Me.cboMuni.Location = New System.Drawing.Point(508, 38)
        Me.cboMuni.Name = "cboMuni"
        Me.cboMuni.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMuni.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MUNICIPIO", "CODIGO_MUNICIPIO", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboMuni.Properties.DataSource = Me.IMMUNICIPIOSBindingSource
        Me.cboMuni.Properties.DisplayMember = "DESCRIPCION"
        Me.cboMuni.Properties.NullText = "Seleccione..."
        Me.cboMuni.Properties.ValueMember = "CODIGO_MUNICIPIO"
        Me.cboMuni.Size = New System.Drawing.Size(215, 20)
        Me.cboMuni.TabIndex = 17
        '
        'IMMUNICIPIOSBindingSource
        '
        Me.IMMUNICIPIOSBindingSource.DataMember = "IM_MUNICIPIOS"
        Me.IMMUNICIPIOSBindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'IMMOVIMIENTOSBindingSource1
        '
        Me.IMMOVIMIENTOSBindingSource1.DataMember = "IM_MOVIMIENTOS"
        Me.IMMOVIMIENTOSBindingSource1.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'cboDepto
        '
        Me.cboDepto.Enabled = False
        Me.cboDepto.Location = New System.Drawing.Point(508, 11)
        Me.cboDepto.Name = "cboDepto"
        Me.cboDepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDepto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_DEPARTAMENTO", "CODIGO_DEPARTAMENTO", 151, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboDepto.Properties.DataSource = Me.IMDEPARTAMENTOSBindingSource
        Me.cboDepto.Properties.DisplayMember = "DESCRIPCION"
        Me.cboDepto.Properties.NullText = "Seleccione..."
        Me.cboDepto.Properties.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.cboDepto.Size = New System.Drawing.Size(215, 20)
        Me.cboDepto.TabIndex = 16
        '
        'IMDEPARTAMENTOSBindingSource
        '
        Me.IMDEPARTAMENTOSBindingSource.DataMember = "IM_DEPARTAMENTOS"
        Me.IMDEPARTAMENTOSBindingSource.DataSource = Me.DSPLANILLATOTALESBindingSource
        '
        'IM_PARTIDOS_POLITICOSTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'IM_MOVIMIENTOSTableAdapter
        '
        Me.IM_MOVIMIENTOSTableAdapter.ClearBeforeFill = True
        '
        'IM_NIVEL_ELECTIVOTableAdapter
        '
        Me.IM_NIVEL_ELECTIVOTableAdapter.ClearBeforeFill = True
        '
        'IM_DEPARTAMENTOSTableAdapter
        '
        Me.IM_DEPARTAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'IM_MUNICIPIOSTableAdapter
        '
        Me.IM_MUNICIPIOSTableAdapter.ClearBeforeFill = True
        '
        'IM_PARTIDOS_POLITICOS1TableAdapter
        '
        Me.IM_PARTIDOS_POLITICOS1TableAdapter.ClearBeforeFill = True
        '
        'Parametros4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 134)
        Me.Controls.Add(Me.CmbMovimiento)
        Me.Controls.Add(Me.cbopartido)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbonivel)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cboMuni)
        Me.Controls.Add(Me.cboDepto)
        Me.Name = "Parametros4"
        Me.Text = "Parametros del Reporte de Planillas completas (con imágen)"
        CType(Me.CmbMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPLANILLATOTALESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PLANILLA_TOTALES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbopartido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMPARTIDOSPOLITICOS1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbonivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMNIVELELECTIVOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMuni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMOVIMIENTOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMDEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbMovimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbopartido As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbonivel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboMuni As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDepto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DSPLANILLATOTALESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_PLANILLA_TOTALES As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALES
    Friend WithEvents IMPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents IMMOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOVIMIENTOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MOVIMIENTOSTableAdapter
    Friend WithEvents IMNIVELELECTIVOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_NIVEL_ELECTIVOTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
    Friend WithEvents IMDEPARTAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_DEPARTAMENTOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_DEPARTAMENTOSTableAdapter
    Friend WithEvents IMMOVIMIENTOSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IMMUNICIPIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MUNICIPIOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MUNICIPIOSTableAdapter
    Friend WithEvents IMPARTIDOSPOLITICOS1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOS1TableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOS1TableAdapter
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
