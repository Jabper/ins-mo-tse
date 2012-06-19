<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmImportar
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnEjecutar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnExplorar = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RbFirmas = New System.Windows.Forms.RadioButton
        Me.RbPlanillas = New System.Windows.Forms.RadioButton
        Me.TxtRuta = New DevExpress.XtraEditors.TextEdit
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel1.SuspendLayout()
        CType(Me.TxtRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Seleccione la ubicacion del archivo a Importar:"
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(113, 107)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEjecutar.TabIndex = 14
        Me.BtnEjecutar.Text = "Importar"
        '
        'BtnExplorar
        '
        Me.BtnExplorar.Location = New System.Drawing.Point(243, 68)
        Me.BtnExplorar.Name = "BtnExplorar"
        Me.BtnExplorar.Size = New System.Drawing.Size(75, 23)
        Me.BtnExplorar.TabIndex = 13
        Me.BtnExplorar.Text = "Explorar"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RbFirmas)
        Me.Panel1.Controls.Add(Me.RbPlanillas)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnEjecutar)
        Me.Panel1.Controls.Add(Me.BtnExplorar)
        Me.Panel1.Controls.Add(Me.TxtRuta)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 155)
        Me.Panel1.TabIndex = 11
        '
        'RbFirmas
        '
        Me.RbFirmas.AutoSize = True
        Me.RbFirmas.Location = New System.Drawing.Point(181, 21)
        Me.RbFirmas.Name = "RbFirmas"
        Me.RbFirmas.Size = New System.Drawing.Size(56, 17)
        Me.RbFirmas.TabIndex = 17
        Me.RbFirmas.Text = "Firmas"
        Me.RbFirmas.UseVisualStyleBackColor = True
        '
        'RbPlanillas
        '
        Me.RbPlanillas.AutoSize = True
        Me.RbPlanillas.Checked = True
        Me.RbPlanillas.Location = New System.Drawing.Point(68, 21)
        Me.RbPlanillas.Name = "RbPlanillas"
        Me.RbPlanillas.Size = New System.Drawing.Size(62, 17)
        Me.RbPlanillas.TabIndex = 16
        Me.RbPlanillas.TabStop = True
        Me.RbPlanillas.Text = "Planillas"
        Me.RbPlanillas.UseVisualStyleBackColor = True
        '
        'TxtRuta
        '
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Location = New System.Drawing.Point(18, 69)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(219, 20)
        Me.TxtRuta.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'XfrmImportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 179)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "XfrmImportar"
        Me.Text = "Importar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TxtRuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnEjecutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnExplorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtRuta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RbFirmas As System.Windows.Forms.RadioButton
    Friend WithEvents RbPlanillas As System.Windows.Forms.RadioButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
