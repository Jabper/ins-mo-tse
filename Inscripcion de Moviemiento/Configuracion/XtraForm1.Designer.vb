<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XtraForm1
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
        Me.WizardControl1 = New DevExpress.XtraWizard.WizardControl
        Me.WelcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage
        Me.WizardPage1 = New DevExpress.XtraWizard.WizardPage
        Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WizardControl1
        '
        Me.WizardControl1.Controls.Add(Me.WelcomeWizardPage1)
        Me.WizardControl1.Controls.Add(Me.WizardPage1)
        Me.WizardControl1.Controls.Add(Me.CompletionWizardPage1)
        Me.WizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizardControl1.Location = New System.Drawing.Point(0, 0)
        Me.WizardControl1.Name = "WizardControl1"
        Me.WizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage1, Me.WizardPage1, Me.CompletionWizardPage1})
        Me.WizardControl1.Size = New System.Drawing.Size(537, 358)
        '
        'WelcomeWizardPage1
        '
        Me.WelcomeWizardPage1.Name = "WelcomeWizardPage1"
        Me.WelcomeWizardPage1.Size = New System.Drawing.Size(320, 225)
        '
        'WizardPage1
        '
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Size = New System.Drawing.Size(505, 213)
        '
        'CompletionWizardPage1
        '
        Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
        Me.CompletionWizardPage1.Size = New System.Drawing.Size(320, 225)
        '
        'XtraForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 358)
        Me.Controls.Add(Me.WizardControl1)
        Me.Name = "XtraForm1"
        Me.Text = "XtraForm1"
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WizardControl1 As DevExpress.XtraWizard.WizardControl
    Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
    Friend WithEvents WizardPage1 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
End Class
