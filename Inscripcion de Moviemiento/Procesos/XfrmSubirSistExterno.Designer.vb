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
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.BtnCandidatosRepetidos = New DevExpress.XtraEditors.SimpleButton
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel1.SuspendLayout()
        CType(Me.TxtRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.BtnCandidatosRepetidos)
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
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 238)
        Me.Panel1.TabIndex = 24
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Appearance.Options.UseForeColor = True
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(467, 157)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(67, 66)
        Me.BtnSalir.TabIndex = 33
        Me.BtnSalir.Text = "Salir"
        '
        'BtnCandidatosRepetidos
        '
        Me.BtnCandidatosRepetidos.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCandidatosRepetidos.Appearance.ForeColor = System.Drawing.Color.Black
        Me.BtnCandidatosRepetidos.Appearance.Options.UseFont = True
        Me.BtnCandidatosRepetidos.Appearance.Options.UseForeColor = True
        Me.BtnCandidatosRepetidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCandidatosRepetidos.Enabled = False
        Me.BtnCandidatosRepetidos.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.candidatos_repetidos
        Me.BtnCandidatosRepetidos.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCandidatosRepetidos.Location = New System.Drawing.Point(120, 15)
        Me.BtnCandidatosRepetidos.Name = "BtnCandidatosRepetidos"
        Me.BtnCandidatosRepetidos.Size = New System.Drawing.Size(72, 66)
        Me.BtnCandidatosRepetidos.TabIndex = 20
        Me.BtnCandidatosRepetidos.Text = "Candidatos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Repetidos"
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
        Me.BtnFirmas.Location = New System.Drawing.Point(353, 15)
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
        Me.BtnRequisitos.Location = New System.Drawing.Point(231, 15)
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
        Me.BtnMovimiento.Location = New System.Drawing.Point(460, 15)
        Me.BtnMovimiento.Name = "BtnMovimiento"
        Me.BtnMovimiento.Size = New System.Drawing.Size(74, 66)
        Me.BtnMovimiento.TabIndex = 21
        Me.BtnMovimiento.Text = "Movimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Seleccione el Archivo a Importar:"
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(181, 179)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(98, 23)
        Me.BtnEjecutar.TabIndex = 31
        Me.BtnEjecutar.Text = "Subir Respaldo"
        '
        'BtnExplorar
        '
        Me.BtnExplorar.Location = New System.Drawing.Point(308, 135)
        Me.BtnExplorar.Name = "BtnExplorar"
        Me.BtnExplorar.Size = New System.Drawing.Size(75, 23)
        Me.BtnExplorar.TabIndex = 30
        Me.BtnExplorar.Text = "Explorar"
        '
        'TxtRuta
        '
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Location = New System.Drawing.Point(83, 136)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(219, 20)
        Me.TxtRuta.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.flecha
        Me.Label1.Location = New System.Drawing.Point(93, 141)
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
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.flecha
        Me.PictureBox2.Location = New System.Drawing.Point(195, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.flecha
        Me.PictureBox3.Location = New System.Drawing.Point(316, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.flecha
        Me.PictureBox4.Location = New System.Drawing.Point(423, 33)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'XfrmSubirSistExterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 262)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "XfrmSubirSistExterno"
        Me.Text = "Importar de Otros Sistemas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TxtRuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCandidatos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCandidatosRepetidos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnMovimiento As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnRequisitos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnFirmas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnEjecutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnExplorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtRuta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
