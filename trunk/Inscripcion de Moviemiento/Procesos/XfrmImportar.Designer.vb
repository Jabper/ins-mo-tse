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
        Me.TxtRuta = New DevExpress.XtraEditors.TextEdit
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1.SuspendLayout()
        CType(Me.TxtRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Seleccione la ubicacion del archivo a Importar:"
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(113, 138)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEjecutar.TabIndex = 14
        Me.BtnEjecutar.Text = "Importar"
        '
        'BtnExplorar
        '
        Me.BtnExplorar.Location = New System.Drawing.Point(243, 99)
        Me.BtnExplorar.Name = "BtnExplorar"
        Me.BtnExplorar.Size = New System.Drawing.Size(75, 23)
        Me.BtnExplorar.TabIndex = 13
        Me.BtnExplorar.Text = "Explorar"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnEjecutar)
        Me.Panel1.Controls.Add(Me.BtnExplorar)
        Me.Panel1.Controls.Add(Me.TxtRuta)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 183)
        Me.Panel1.TabIndex = 11
        '
        'TxtRuta
        '
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Location = New System.Drawing.Point(18, 100)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(219, 20)
        Me.TxtRuta.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(15, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 55)
        Me.BtnSalir.TabIndex = 17
        Me.BtnSalir.Text = "Salir"
        '
        'XfrmImportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 207)
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
End Class
