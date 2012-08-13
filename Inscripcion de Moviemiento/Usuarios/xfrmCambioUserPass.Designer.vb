<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfrmCambioUserPass
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
        Dim CompareAgainstControlValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule = New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Me.txtpass2 = New DevExpress.XtraEditors.TextEdit
        Me.Cancelar = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtpass1 = New DevExpress.XtraEditors.TextEdit
        Me.TxtPassAnterior = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.DxValidationProvider2 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.txtpass2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpass1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPassAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpass2
        '
        Me.txtpass2.Location = New System.Drawing.Point(151, 74)
        Me.txtpass2.Name = "txtpass2"
        Me.txtpass2.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass2.Size = New System.Drawing.Size(170, 20)
        Me.txtpass2.TabIndex = 2
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "El valor no puede estar en blanco"
        Me.DxValidationProvider1.SetValidationRule(Me.txtpass2, ConditionValidationRule1)
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(211, 115)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(131, 23)
        Me.Cancelar.TabIndex = 4
        Me.Cancelar.Text = "Cancelar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(74, 115)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(131, 23)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Cambiar mi Contraseña"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 81)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Confirmar Contraseña"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Nueva Contraseña"
        '
        'txtpass1
        '
        Me.txtpass1.Location = New System.Drawing.Point(151, 48)
        Me.txtpass1.Name = "txtpass1"
        Me.txtpass1.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass1.Size = New System.Drawing.Size(170, 20)
        Me.txtpass1.TabIndex = 0
        CompareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals
        CompareAgainstControlValidationRule1.Control = Me.txtpass2
        CompareAgainstControlValidationRule1.ErrorText = "Las contraseñas no concuerda"
        Me.DxValidationProvider2.SetValidationRule(Me.txtpass1, CompareAgainstControlValidationRule1)
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "El valor no puede estar en blanco"
        Me.DxValidationProvider1.SetValidationRule(Me.txtpass1, ConditionValidationRule2)
        '
        'TxtPassAnterior
        '
        Me.TxtPassAnterior.Location = New System.Drawing.Point(151, 22)
        Me.TxtPassAnterior.Name = "TxtPassAnterior"
        Me.TxtPassAnterior.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassAnterior.Size = New System.Drawing.Size(170, 20)
        Me.TxtPassAnterior.TabIndex = 0
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "El valor no puede estar en blanco"
        Me.DxValidationProvider1.SetValidationRule(Me.TxtPassAnterior, ConditionValidationRule3)
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(24, 25)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Contraseña"
        '
        'xfrmCambioUserPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 163)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.TxtPassAnterior)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtpass2)
        Me.Controls.Add(Me.txtpass1)
        Me.Name = "xfrmCambioUserPass"
        Me.Text = "Cambio de Contraseña"
        CType(Me.txtpass2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpass1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPassAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtpass1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPassAnterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtpass2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents DxValidationProvider2 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
