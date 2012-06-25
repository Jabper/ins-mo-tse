<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmSubirSistExterno
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnImagenes = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.BtnFirmas = New DevExpress.XtraEditors.SimpleButton
        Me.BtnCandidatos = New DevExpress.XtraEditors.SimpleButton
        Me.BtnRequisitos = New DevExpress.XtraEditors.SimpleButton
        Me.BtnMovimiento = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnEjecutar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnExplorar = New DevExpress.XtraEditors.SimpleButton
        Me.TxtRuta = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FbUbicacion = New System.Windows.Forms.FolderBrowserDialog
        Me.Panel1.SuspendLayout()
        CType(Me.TxtRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnImagenes)
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.BtnFirmas)
        Me.Panel1.Controls.Add(Me.BtnCandidatos)
        Me.Panel1.Controls.Add(Me.BtnRequisitos)
        Me.Panel1.Controls.Add(Me.BtnMovimiento)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnEjecutar)
        Me.Panel1.Controls.Add(Me.BtnExplorar)
        Me.Panel1.Controls.Add(Me.TxtRuta)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 238)
        Me.Panel1.TabIndex = 24
        '
        'BtnImagenes
        '
        Me.BtnImagenes.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnImagenes.Appearance.ForeColor = System.Drawing.Color.Black
        Me.BtnImagenes.Appearance.Options.UseFont = True
        Me.BtnImagenes.Appearance.Options.UseForeColor = True
        Me.BtnImagenes.Enabled = False
        Me.BtnImagenes.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.imagenes
        Me.BtnImagenes.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnImagenes.Location = New System.Drawing.Point(464, 15)
        Me.BtnImagenes.Name = "BtnImagenes"
        Me.BtnImagenes.Size = New System.Drawing.Size(74, 66)
        Me.BtnImagenes.TabIndex = 35
        Me.BtnImagenes.Text = "Imágenes"
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Appearance.Options.UseForeColor = True
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(471, 136)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(67, 66)
        Me.BtnSalir.TabIndex = 33
        Me.BtnSalir.Text = "Salir"
        '
        'BtnFirmas
        '
        Me.BtnFirmas.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFirmas.Appearance.ForeColor = System.Drawing.Color.Black
        Me.BtnFirmas.Appearance.Options.UseFont = True
        Me.BtnFirmas.Appearance.Options.UseForeColor = True
        Me.BtnFirmas.Enabled = False
        Me.BtnFirmas.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.firmas
        Me.BtnFirmas.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnFirmas.Location = New System.Drawing.Point(243, 15)
        Me.BtnFirmas.Name = "BtnFirmas"
        Me.BtnFirmas.Size = New System.Drawing.Size(67, 66)
        Me.BtnFirmas.TabIndex = 23
        Me.BtnFirmas.Text = "Firmas"
        '
        'BtnCandidatos
        '
        Me.BtnCandidatos.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCandidatos.Appearance.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnCandidatos.Appearance.Options.UseFont = True
        Me.BtnCandidatos.Appearance.Options.UseForeColor = True
        Me.BtnCandidatos.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.subir_candidatos
        Me.BtnCandidatos.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCandidatos.Location = New System.Drawing.Point(16, 15)
        Me.BtnCandidatos.Name = "BtnCandidatos"
        Me.BtnCandidatos.Size = New System.Drawing.Size(64, 66)
        Me.BtnCandidatos.TabIndex = 19
        Me.BtnCandidatos.Text = "Candidatos"
        '
        'BtnRequisitos
        '
        Me.BtnRequisitos.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRequisitos.Appearance.ForeColor = System.Drawing.Color.Black
        Me.BtnRequisitos.Appearance.Options.UseFont = True
        Me.BtnRequisitos.Appearance.Options.UseForeColor = True
        Me.BtnRequisitos.Enabled = False
        Me.BtnRequisitos.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.subir_requisitos
        Me.BtnRequisitos.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnRequisitos.Location = New System.Drawing.Point(121, 15)
        Me.BtnRequisitos.Name = "BtnRequisitos"
        Me.BtnRequisitos.Size = New System.Drawing.Size(81, 66)
        Me.BtnRequisitos.TabIndex = 22
        Me.BtnRequisitos.Text = "Requisitos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por Candidato"
        '
        'BtnMovimiento
        '
        Me.BtnMovimiento.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnMovimiento.Appearance.ForeColor = System.Drawing.Color.Black
        Me.BtnMovimiento.Appearance.Options.UseFont = True
        Me.BtnMovimiento.Appearance.Options.UseForeColor = True
        Me.BtnMovimiento.Enabled = False
        Me.BtnMovimiento.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.subir_movimientos
        Me.BtnMovimiento.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnMovimiento.Location = New System.Drawing.Point(350, 15)
        Me.BtnMovimiento.Name = "BtnMovimiento"
        Me.BtnMovimiento.Size = New System.Drawing.Size(74, 66)
        Me.BtnMovimiento.TabIndex = 21
        Me.BtnMovimiento.Text = "Movimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Seleccione el Archivo a Importar:"
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(180, 179)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(98, 23)
        Me.BtnEjecutar.TabIndex = 31
        Me.BtnEjecutar.Text = "Subir Datos"
        '
        'BtnExplorar
        '
        Me.BtnExplorar.Location = New System.Drawing.Point(307, 135)
        Me.BtnExplorar.Name = "BtnExplorar"
        Me.BtnExplorar.Size = New System.Drawing.Size(75, 23)
        Me.BtnExplorar.TabIndex = 30
        Me.BtnExplorar.Text = "Explorar"
        '
        'TxtRuta
        '
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Location = New System.Drawing.Point(82, 136)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(219, 20)
        Me.TxtRuta.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.flecha
        Me.Label1.Location = New System.Drawing.Point(92, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.flecha
        Me.PictureBox1.Location = New System.Drawing.Point(84, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.flecha
        Me.PictureBox3.Location = New System.Drawing.Point(206, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.flecha
        Me.PictureBox4.Location = New System.Drawing.Point(313, 33)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.flecha
        Me.PictureBox5.Location = New System.Drawing.Point(427, 33)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox5.TabIndex = 34
        Me.PictureBox5.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'XfrmSubirSistExterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 262)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "XfrmSubirSistExterno"
        Me.Text = "Importar de Otros Sistemas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TxtRuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCandidatos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnMovimiento As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnRequisitos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnFirmas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnEjecutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnExplorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtRuta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnImagenes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FbUbicacion As System.Windows.Forms.FolderBrowserDialog
End Class
