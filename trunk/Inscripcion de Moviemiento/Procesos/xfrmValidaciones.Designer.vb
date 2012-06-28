<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfrmValidaciones
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
        Me.BtnFirmas = New DevExpress.XtraEditors.SimpleButton
        Me.btnplanilla = New DevExpress.XtraEditors.SimpleButton
        Me.btnreportes = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFirmas
        '
        Me.BtnFirmas.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFirmas.Appearance.ForeColor = System.Drawing.Color.Black
        Me.BtnFirmas.Appearance.Options.UseFont = True
        Me.BtnFirmas.Appearance.Options.UseForeColor = True
        Me.BtnFirmas.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.firmas
        Me.BtnFirmas.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnFirmas.Location = New System.Drawing.Point(136, 16)
        Me.BtnFirmas.Name = "BtnFirmas"
        Me.BtnFirmas.Size = New System.Drawing.Size(81, 66)
        Me.BtnFirmas.TabIndex = 31
        Me.BtnFirmas.Text = "Validar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Firmas"
        '
        'btnplanilla
        '
        Me.btnplanilla.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnplanilla.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnplanilla.Appearance.Options.UseFont = True
        Me.btnplanilla.Appearance.Options.UseForeColor = True
        Me.btnplanilla.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.validar_planilla
        Me.btnplanilla.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnplanilla.Location = New System.Drawing.Point(14, 16)
        Me.btnplanilla.Name = "btnplanilla"
        Me.btnplanilla.Size = New System.Drawing.Size(81, 66)
        Me.btnplanilla.TabIndex = 30
        Me.btnplanilla.Text = "Validar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Planilla"
        '
        'btnreportes
        '
        Me.btnreportes.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnreportes.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnreportes.Appearance.Options.UseFont = True
        Me.btnreportes.Appearance.Options.UseForeColor = True
        Me.btnreportes.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.modificarfirmas
        Me.btnreportes.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnreportes.Location = New System.Drawing.Point(260, 16)
        Me.btnreportes.Name = "btnreportes"
        Me.btnreportes.Size = New System.Drawing.Size(83, 66)
        Me.btnreportes.TabIndex = 29
        Me.btnreportes.Text = "Reporte"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.flecha
        Me.PictureBox3.Location = New System.Drawing.Point(98, 34)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.flecha
        Me.PictureBox4.Location = New System.Drawing.Point(221, 34)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnSalir)
        Me.PanelControl1.Controls.Add(Me.btnplanilla)
        Me.PanelControl1.Controls.Add(Me.BtnFirmas)
        Me.PanelControl1.Controls.Add(Me.PictureBox4)
        Me.PanelControl1.Controls.Add(Me.PictureBox3)
        Me.PanelControl1.Controls.Add(Me.btnreportes)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(359, 189)
        Me.PanelControl1.TabIndex = 34
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Appearance.Options.UseForeColor = True
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(141, 102)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(67, 66)
        Me.BtnSalir.TabIndex = 34
        Me.BtnSalir.Text = "Salir"
        '
        'xfrmValidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 211)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "xfrmValidaciones"
        Me.Text = "Validaciones"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnFirmas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnplanilla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnreportes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
End Class
