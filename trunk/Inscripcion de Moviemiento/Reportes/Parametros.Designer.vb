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
        Me.cboMovimiento = New DevExpress.XtraEditors.LookUpEdit
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PLANILLA_TOTALES = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALES
        Me.cboDepto = New DevExpress.XtraEditors.LookUpEdit
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboMuni = New DevExpress.XtraEditors.LookUpEdit
        Me.BindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.cbonivel = New DevExpress.XtraEditors.LookUpEdit
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.btnsalir = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.IMFK1MOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbopartido = New DevExpress.XtraEditors.LookUpEdit
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbocargo = New DevExpress.XtraEditors.LookUpEdit
        Me.BindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_MOVIMIENTOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MOVIMIENTOSTableAdapter
        Me.IM_NIVEL_ELECTIVOTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
        Me.IM_DEPARTAMENTOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_DEPARTAMENTOSTableAdapter
        Me.IM_MUNICIPIOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MUNICIPIOSTableAdapter
        Me.IM_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
        Me.BindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_PARTIDOS_POLITICOS1TableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOS1TableAdapter
        Me.BindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_MOVIMIENTOS1TableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MOVIMIENTOS1TableAdapter
        Me.IM_CARGOS_ELECTIVOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_CARGOS_ELECTIVOSTableAdapter
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        CType(Me.cboMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PLANILLA_TOTALES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMuni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbonivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMFK1MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbopartido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbocargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboMovimiento
        '
        Me.cboMovimiento.Location = New System.Drawing.Point(155, 51)
        Me.cboMovimiento.Name = "cboMovimiento"
        Me.cboMovimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMovimiento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MOVIMIENTO", "CODIGO_MOVIMIENTO", 135, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE MOVIMIENTO", "NOMBRE MOVIMIENTO", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboMovimiento.Properties.DataSource = Me.BindingSource2
        Me.cboMovimiento.Properties.DisplayMember = "NOMBRE MOVIMIENTO"
        Me.cboMovimiento.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        Me.cboMovimiento.Size = New System.Drawing.Size(200, 20)
        Me.cboMovimiento.TabIndex = 1
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "IM_MOVIMIENTOS"
        Me.BindingSource2.DataSource = Me.DS_PLANILLA_TOTALES
        '
        'DS_PLANILLA_TOTALES
        '
        Me.DS_PLANILLA_TOTALES.DataSetName = "DS_PLANILLA_TOTALES"
        Me.DS_PLANILLA_TOTALES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboDepto
        '
        Me.cboDepto.Location = New System.Drawing.Point(507, 25)
        Me.cboDepto.Name = "cboDepto"
        Me.cboDepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDepto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_DEPARTAMENTO", "CODIGO_DEPARTAMENTO", 151, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboDepto.Properties.DataSource = Me.BindingSource4
        Me.cboDepto.Properties.DisplayMember = "DESCRIPCION"
        Me.cboDepto.Properties.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.cboDepto.Size = New System.Drawing.Size(215, 20)
        Me.cboDepto.TabIndex = 2
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "IM_DEPARTAMENTOS"
        Me.BindingSource4.DataSource = Me.DS_PLANILLA_TOTALES
        '
        'cboMuni
        '
        Me.cboMuni.Location = New System.Drawing.Point(507, 51)
        Me.cboMuni.Name = "cboMuni"
        Me.cboMuni.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMuni.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MUNICIPIO", "CODIGO_MUNICIPIO", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboMuni.Properties.DataSource = Me.BindingSource5
        Me.cboMuni.Properties.DisplayMember = "DESCRIPCION"
        Me.cboMuni.Properties.ValueMember = "CODIGO_MUNICIPIO"
        Me.cboMuni.Size = New System.Drawing.Size(215, 20)
        Me.cboMuni.TabIndex = 3
        '
        'BindingSource5
        '
        Me.BindingSource5.DataMember = "IM_MUNICIPIOS"
        Me.BindingSource5.DataSource = Me.DS_PLANILLA_TOTALES
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(596, 80)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(126, 23)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "IMPRIMIR REPORTE"
        '
        'cbonivel
        '
        Me.cbonivel.Location = New System.Drawing.Point(155, 103)
        Me.cbonivel.Name = "cbonivel"
        Me.cbonivel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbonivel.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_NIVEL_ELECTIVO", "CODIGO_NIVEL_ELECTIVO", 152, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NIVEL ELECTIVO", "NIVEL ELECTIVO", 89, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cbonivel.Properties.DataSource = Me.BindingSource3
        Me.cbonivel.Properties.DisplayMember = "NIVEL ELECTIVO"
        Me.cbonivel.Properties.ValueMember = "CODIGO_NIVEL_ELECTIVO"
        Me.cbonivel.Size = New System.Drawing.Size(200, 20)
        Me.cbonivel.TabIndex = 5
        Me.cbonivel.Visible = False
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "IM_NIVEL_ELECTIVO"
        Me.BindingSource3.DataSource = Me.DS_PLANILLA_TOTALES
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(13, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Partido Político"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(13, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Movimiento Político"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 106)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Nivel Electivo"
        Me.LabelControl3.Visible = False
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(596, 111)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(126, 23)
        Me.btnsalir.TabIndex = 9
        Me.btnsalir.Text = "SALIR"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(384, 28)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Departamento"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(384, 54)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Municipio"
        '
        'cbopartido
        '
        Me.cbopartido.Location = New System.Drawing.Point(155, 19)
        Me.cbopartido.Name = "cbopartido"
        Me.cbopartido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbopartido.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_PARTIDO", "CODIGO_PARTIDO", 115, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE PARTIDO", "NOMBRE PARTIDO", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IMAGEN", "IMAGEN", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.cbopartido.Properties.DataSource = Me.BindingSource1
        Me.cbopartido.Properties.DisplayMember = "NOMBRE PARTIDO"
        Me.cbopartido.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.cbopartido.Size = New System.Drawing.Size(200, 20)
        Me.cbopartido.TabIndex = 12
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "IM_PARTIDOS_POLITICOS"
        Me.BindingSource1.DataSource = Me.DS_PLANILLA_TOTALES
        '
        'cbocargo
        '
        Me.cbocargo.Location = New System.Drawing.Point(155, 77)
        Me.cbocargo.Name = "cbocargo"
        Me.cbocargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbocargo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_CARGO_ELECTIVO", "CODIGO_CARGO_ELECTIVO", 160, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cbocargo.Properties.DataSource = Me.BindingSource8
        Me.cbocargo.Properties.DisplayMember = "DESCRIPCION"
        Me.cbocargo.Properties.ValueMember = "CODIGO_CARGO_ELECTIVO"
        Me.cbocargo.Size = New System.Drawing.Size(200, 20)
        Me.cbocargo.TabIndex = 13
        '
        'BindingSource8
        '
        Me.BindingSource8.DataMember = "IM_CARGOS_ELECTIVOS"
        Me.BindingSource8.DataSource = Me.DS_PLANILLA_TOTALES
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
        'IM_PARTIDOS_POLITICOSTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'BindingSource6
        '
        Me.BindingSource6.DataMember = "IM_PARTIDOS_POLITICOS1"
        Me.BindingSource6.DataSource = Me.DS_PLANILLA_TOTALES
        '
        'IM_PARTIDOS_POLITICOS1TableAdapter
        '
        Me.IM_PARTIDOS_POLITICOS1TableAdapter.ClearBeforeFill = True
        '
        'BindingSource7
        '
        Me.BindingSource7.DataMember = "IM_MOVIMIENTOS1"
        Me.BindingSource7.DataSource = Me.DS_PLANILLA_TOTALES
        '
        'IM_MOVIMIENTOS1TableAdapter
        '
        Me.IM_MOVIMIENTOS1TableAdapter.ClearBeforeFill = True
        '
        'IM_CARGOS_ELECTIVOSTableAdapter
        '
        Me.IM_CARGOS_ELECTIVOSTableAdapter.ClearBeforeFill = True
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(12, 80)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Cargo Electivo"
        '
        'Parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 146)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.cbocargo)
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
        Me.Controls.Add(Me.cboMovimiento)
        Me.Name = "Parametros"
        Me.Text = "Parametros del Reporte de Planillas Completas"
        CType(Me.cboMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PLANILLA_TOTALES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMuni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbonivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMFK1MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbopartido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbocargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DSPLANILLATOTALESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cboMovimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMMOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cboDepto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMDEPARTAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cboMuni As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMMUNICIPIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IMCANDIDATOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cbonivel As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMNIVELELECTIVOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DS_PLANILLA_TOTALES As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALES
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOVIMIENTOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MOVIMIENTOSTableAdapter
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_NIVEL_ELECTIVOTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
    Friend WithEvents BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_DEPARTAMENTOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_DEPARTAMENTOSTableAdapter
    Friend WithEvents BindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MUNICIPIOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MUNICIPIOSTableAdapter
    Friend WithEvents IMFK1MOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cbopartido As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents BindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOS1TableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOS1TableAdapter
    Friend WithEvents BindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOVIMIENTOS1TableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MOVIMIENTOS1TableAdapter
    Friend WithEvents cbocargo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BindingSource8 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CARGOS_ELECTIVOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_CARGOS_ELECTIVOSTableAdapter
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
