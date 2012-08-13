<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmCambiarPass
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
        Me.txtpass2 = New DevExpress.XtraEditors.TextEdit
        Me.txtpass1 = New DevExpress.XtraEditors.TextEdit
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.Cancelar = New DevExpress.XtraEditors.SimpleButton
        Me.DxValidationProvider2 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.txtpass2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpass1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpass2
        '
        Me.txtpass2.Location = New System.Drawing.Point(147, 132)
        Me.txtpass2.Name = "txtpass2"
        Me.txtpass2.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass2.Size = New System.Drawing.Size(170, 20)
        Me.txtpass2.TabIndex = 1
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "El valor no puede estar en blanco"
        Me.DxValidationProvider1.SetValidationRule(Me.txtpass2, ConditionValidationRule1)
        '
        'txtpass1
        '
        Me.txtpass1.Location = New System.Drawing.Point(147, 106)
        Me.txtpass1.Name = "txtpass1"
        Me.txtpass1.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass1.Size = New System.Drawing.Size(170, 20)
        Me.txtpass1.TabIndex = 0
        CompareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals
        CompareAgainstControlValidationRule1.Control = Me.txtpass2
        CompareAgainstControlValidationRule1.ErrorText = "Las Contraseñas no concuerdan"
        Me.DxValidationProvider2.SetValidationRule(Me.txtpass1, CompareAgainstControlValidationRule1)
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "El valor no puede estar en blanco"
        Me.DxValidationProvider1.SetValidationRule(Me.txtpass1, ConditionValidationRule2)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(38, 105)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Contraseña"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(35, 135)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Confirmar Contraseña"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(70, 173)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(131, 23)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Cambiar mi Contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.lockusr
        Me.PictureBox1.Location = New System.Drawing.Point(26, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl3.Location = New System.Drawing.Point(100, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(238, 42)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Para poder utilizar el sistema usted necesita cambiar su contraseña" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a continuaci" & _
            "ón ingrese su contraseña" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(207, 173)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(131, 23)
        Me.Cancelar.TabIndex = 7
        Me.Cancelar.Text = "Cancelar"
        '
        'XfrmCambiarPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 218)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtpass2)
        Me.Controls.Add(Me.txtpass1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "XfrmCambiarPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Contraseña"
        CType(Me.txtpass2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpass1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpass1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txtpass2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxValidationProvider2 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
