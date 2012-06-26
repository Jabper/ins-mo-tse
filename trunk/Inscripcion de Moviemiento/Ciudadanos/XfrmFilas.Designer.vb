<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmFilas
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
        Dim ConditionValidationRule5 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim ConditionValidationRule6 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Me.TxtFilas = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.CmbDepartamento = New DevExpress.XtraEditors.LookUpEdit
        Me.TADEPARTAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDeptoMuni = New Inscripcion_de_Moviemientos.DSDeptoMuni
        Me.CmbMunicipio = New DevExpress.XtraEditors.LookUpEdit
        Me.TAMUNICIPIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbMovimiento = New DevExpress.XtraEditors.LookUpEdit
        Me.TAMOVIMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPolitico = New Inscripcion_de_Moviemientos.DSPolitico
        Me.CmbPartido = New DevExpress.XtraEditors.LookUpEdit
        Me.TAPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtFolio = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit
        Me.TA_MOVIMIENTOTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_MOVIMIENTOTableAdapter
        Me.TA_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TA_DEPARTAMENTOSTableAdapter = New Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_DEPARTAMENTOSTableAdapter
        Me.TA_MUNICIPIOSTableAdapter = New Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_MUNICIPIOSTableAdapter
        Me.BtnCrear = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.TxtFilas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TADEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDeptoMuni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbPartido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFolio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtFilas
        '
        Me.TxtFilas.Location = New System.Drawing.Point(203, 39)
        Me.TxtFilas.Name = "TxtFilas"
        Me.TxtFilas.Properties.MaxLength = 3
        Me.TxtFilas.Size = New System.Drawing.Size(37, 20)
        Me.TxtFilas.TabIndex = 0
        ConditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule5.ErrorText = "Valor Inválido"
        Me.DxValidationProvider1.SetValidationRule(Me.TxtFilas, ConditionValidationRule5)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad de firmas en la pagina:"
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TADEPARTAMENTOSBindingSource, "CODIGO_DEPARTAMENTO", True))
        Me.CmbDepartamento.Location = New System.Drawing.Point(88, 59)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_DEPARTAMENTO", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Departamento", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CmbDepartamento.Properties.DataSource = Me.TADEPARTAMENTOSBindingSource
        Me.CmbDepartamento.Properties.DisplayMember = "DESCRIPCION"
        Me.CmbDepartamento.Properties.NullText = "Seleccione"
        Me.CmbDepartamento.Properties.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.CmbDepartamento.Size = New System.Drawing.Size(135, 20)
        Me.CmbDepartamento.TabIndex = 5
        ConditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule6.ErrorText = "Valor Inválido"
        Me.DxValidationProvider1.SetValidationRule(Me.CmbDepartamento, ConditionValidationRule6)
        '
        'TADEPARTAMENTOSBindingSource
        '
        Me.TADEPARTAMENTOSBindingSource.DataMember = "TA_DEPARTAMENTOS"
        Me.TADEPARTAMENTOSBindingSource.DataSource = Me.DSDeptoMuni
        '
        'DSDeptoMuni
        '
        Me.DSDeptoMuni.DataSetName = "DSDeptoMuni"
        Me.DSDeptoMuni.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbMunicipio
        '
        Me.CmbMunicipio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TAMUNICIPIOSBindingSource, "CODIGO_MUNICIPIO", True))
        Me.CmbMunicipio.Location = New System.Drawing.Point(309, 59)
        Me.CmbMunicipio.Name = "CmbMunicipio"
        Me.CmbMunicipio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMunicipio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MUNICIPIO", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Departamento", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CmbMunicipio.Properties.DataSource = Me.TAMUNICIPIOSBindingSource
        Me.CmbMunicipio.Properties.DisplayMember = "DESCRIPCION"
        Me.CmbMunicipio.Properties.NullText = "Seleccione"
        Me.CmbMunicipio.Properties.ValueMember = "CODIGO_MUNICIPIO"
        Me.CmbMunicipio.Size = New System.Drawing.Size(144, 20)
        Me.CmbMunicipio.TabIndex = 6
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Valor Inválido"
        Me.DxValidationProvider1.SetValidationRule(Me.CmbMunicipio, ConditionValidationRule1)
        '
        'TAMUNICIPIOSBindingSource
        '
        Me.TAMUNICIPIOSBindingSource.DataMember = "TA_MUNICIPIOS"
        Me.TAMUNICIPIOSBindingSource.DataSource = Me.DSDeptoMuni
        '
        'CmbMovimiento
        '
        Me.CmbMovimiento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TAMOVIMIENTOBindingSource, "CODIGO_MOVIMIENTO", True))
        Me.CmbMovimiento.Location = New System.Drawing.Point(309, 29)
        Me.CmbMovimiento.Name = "CmbMovimiento"
        Me.CmbMovimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMovimiento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MOVIMIENTO", "CODIGO_MOVIMIENTO", 30, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE_MOVIMIENTO", "Movimiento", 123, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CmbMovimiento.Properties.DataSource = Me.TAMOVIMIENTOBindingSource
        Me.CmbMovimiento.Properties.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.CmbMovimiento.Properties.NullText = "Seleccione"
        Me.CmbMovimiento.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        Me.CmbMovimiento.Size = New System.Drawing.Size(144, 20)
        Me.CmbMovimiento.TabIndex = 4
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Valor Inválido"
        Me.DxValidationProvider1.SetValidationRule(Me.CmbMovimiento, ConditionValidationRule2)
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
        'CmbPartido
        '
        Me.CmbPartido.Location = New System.Drawing.Point(88, 29)
        Me.CmbPartido.Name = "CmbPartido"
        Me.CmbPartido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbPartido.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_PARTIDO", "Código", 40, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "Partido", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CmbPartido.Properties.DataSource = Me.TAPARTIDOSPOLITICOSBindingSource
        Me.CmbPartido.Properties.DisplayMember = "NOMBRE"
        Me.CmbPartido.Properties.NullText = "Seleccione"
        Me.CmbPartido.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.CmbPartido.Size = New System.Drawing.Size(135, 20)
        Me.CmbPartido.TabIndex = 20
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Valor Inválido"
        Me.DxValidationProvider1.SetValidationRule(Me.CmbPartido, ConditionValidationRule3)
        '
        'TAPARTIDOSPOLITICOSBindingSource
        '
        Me.TAPARTIDOSPOLITICOSBindingSource.DataMember = "TA_PARTIDOS_POLITICOS"
        Me.TAPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSPolitico
        '
        'TxtFolio
        '
        Me.TxtFolio.Location = New System.Drawing.Point(203, 79)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Properties.MaxLength = 3
        Me.TxtFolio.Size = New System.Drawing.Size(37, 20)
        Me.TxtFolio.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Número de folio (opcional) :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Partido Político"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Movimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(242, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Municipio"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CmbPartido)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.CmbDepartamento)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.CmbMunicipio)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.CmbMovimiento)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 211)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(481, 117)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Información General"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Controls.Add(Me.PictureEdit2)
        Me.GroupControl2.Controls.Add(Me.TxtFolio)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.TxtFilas)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(481, 163)
        Me.GroupControl2.TabIndex = 21
        Me.GroupControl2.Text = "Información de la Pagina de Firmas"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(331, 135)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(90, 23)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Cargar Imágen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Imágen de la Pagina (opcional)"
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Location = New System.Drawing.Point(324, 40)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.ShowMenu = False
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit2.Size = New System.Drawing.Size(100, 89)
        Me.PictureEdit2.TabIndex = 4
        '
        'TA_MOVIMIENTOTableAdapter
        '
        Me.TA_MOVIMIENTOTableAdapter.ClearBeforeFill = True
        '
        'TA_PARTIDOS_POLITICOSTableAdapter
        '
        Me.TA_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TA_DEPARTAMENTOSTableAdapter
        '
        Me.TA_DEPARTAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'TA_MUNICIPIOSTableAdapter
        '
        Me.TA_MUNICIPIOSTableAdapter.ClearBeforeFill = True
        '
        'BtnCrear
        '
        Me.BtnCrear.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCrear.Appearance.Options.UseFont = True
        Me.BtnCrear.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.agregar
        Me.BtnCrear.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCrear.Location = New System.Drawing.Point(180, 334)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(55, 55)
        Me.BtnCrear.TabIndex = 26
        Me.BtnCrear.Text = "Crear"
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(290, 334)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 55)
        Me.BtnSalir.TabIndex = 25
        Me.BtnSalir.Text = "Salir"
        '
        'XfrmFilas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "XfrmFilas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inscripción de Firmas"
        CType(Me.TxtFilas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TADEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDeptoMuni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbPartido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFolio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtFilas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtFolio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CmbDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DSDeptoMuni As Inscripcion_de_Moviemientos.DSDeptoMuni
    Friend WithEvents TADEPARTAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_DEPARTAMENTOSTableAdapter As Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_DEPARTAMENTOSTableAdapter
    Friend WithEvents CmbMunicipio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CmbMovimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TAMUNICIPIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_MUNICIPIOSTableAdapter As Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_MUNICIPIOSTableAdapter
    Friend WithEvents DSPolitico As Inscripcion_de_Moviemientos.DSPolitico
    Friend WithEvents TAMOVIMIENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_MOVIMIENTOTableAdapter As Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_MOVIMIENTOTableAdapter
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCrear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbPartido As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TAPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
