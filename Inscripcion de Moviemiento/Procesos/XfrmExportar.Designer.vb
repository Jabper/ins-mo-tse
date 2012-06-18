<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmExportar
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
        Me.FbUbicacion = New System.Windows.Forms.FolderBrowserDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnEjecutar = New DevExpress.XtraEditors.SimpleButton
        Me.ChkFirmas = New DevExpress.XtraEditors.CheckEdit
        Me.BtnExplorar = New DevExpress.XtraEditors.SimpleButton
        Me.ChkPlanillas = New DevExpress.XtraEditors.CheckEdit
        Me.TxtRuta = New DevExpress.XtraEditors.TextEdit
        Me.Panel1.SuspendLayout()
        CType(Me.ChkFirmas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkPlanillas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnEjecutar)
        Me.Panel1.Controls.Add(Me.ChkFirmas)
        Me.Panel1.Controls.Add(Me.BtnExplorar)
        Me.Panel1.Controls.Add(Me.ChkPlanillas)
        Me.Panel1.Controls.Add(Me.TxtRuta)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 155)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Seleccione la ubicacion del archivo a exportar:"
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(137, 107)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEjecutar.TabIndex = 14
        Me.BtnEjecutar.Text = "Exportar"
        '
        'ChkFirmas
        '
        Me.ChkFirmas.EditValue = True
        Me.ChkFirmas.Location = New System.Drawing.Point(220, 21)
        Me.ChkFirmas.Name = "ChkFirmas"
        Me.ChkFirmas.Properties.Caption = "Firmas"
        Me.ChkFirmas.Size = New System.Drawing.Size(75, 19)
        Me.ChkFirmas.TabIndex = 11
        '
        'BtnExplorar
        '
        Me.BtnExplorar.Location = New System.Drawing.Point(243, 68)
        Me.BtnExplorar.Name = "BtnExplorar"
        Me.BtnExplorar.Size = New System.Drawing.Size(75, 23)
        Me.BtnExplorar.TabIndex = 13
        Me.BtnExplorar.Text = "Explorar"
        '
        'ChkPlanillas
        '
        Me.ChkPlanillas.EditValue = True
        Me.ChkPlanillas.Location = New System.Drawing.Point(57, 21)
        Me.ChkPlanillas.Name = "ChkPlanillas"
        Me.ChkPlanillas.Properties.Caption = "Planillas"
        Me.ChkPlanillas.Size = New System.Drawing.Size(75, 19)
        Me.ChkPlanillas.TabIndex = 10
        '
        'TxtRuta
        '
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Location = New System.Drawing.Point(18, 69)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(219, 20)
        Me.TxtRuta.TabIndex = 12
        '
        'XfrmExportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 179)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "XfrmExportar"
        Me.Text = "Exportar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ChkFirmas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkPlanillas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FbUbicacion As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnEjecutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkFirmas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BtnExplorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkPlanillas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TxtRuta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
