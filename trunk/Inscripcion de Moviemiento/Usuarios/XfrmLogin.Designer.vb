﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmLogin
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.TxtUsuario = New DevExpress.XtraEditors.TextEdit
        Me.TxtPassword = New DevExpress.XtraEditors.TextEdit
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.textback1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(232, 117)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(178, 41)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.textback1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(232, 164)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 41)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(161, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(127, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Constraseña:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.logme
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(327, 236)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 39)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(249, 128)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtUsuario.Size = New System.Drawing.Size(146, 18)
        Me.TxtUsuario.TabIndex = 8
        ConditionValidationRule1.CaseSensitive = True
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Valor Inválido"
        Me.DxValidationProvider1.SetValidationRule(Me.TxtUsuario, ConditionValidationRule1)
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(249, 174)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(146, 18)
        Me.TxtPassword.TabIndex = 9
        ConditionValidationRule2.CaseSensitive = True
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Valor Inválido"
        Me.DxValidationProvider1.SetValidationRule(Me.TxtPassword, ConditionValidationRule2)
        '
        'XfrmLogin
        '
        Me.Appearance.BackColor = System.Drawing.Color.Fuchsia
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.backlogin
        Me.ClientSize = New System.Drawing.Size(506, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "XfrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso al Sistema"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents TxtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPassword As DevExpress.XtraEditors.TextEdit
End Class
