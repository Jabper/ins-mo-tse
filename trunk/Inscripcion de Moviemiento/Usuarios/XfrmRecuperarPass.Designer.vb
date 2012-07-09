<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmRecuperarPass
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
        Me.CmbPregunta = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.txtrespuesta = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtcedula = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        CType(Me.CmbPregunta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrespuesta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcedula.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbPregunta
        '
        Me.CmbPregunta.Location = New System.Drawing.Point(57, 133)
        Me.CmbPregunta.Name = "CmbPregunta"
        Me.CmbPregunta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbPregunta.Properties.NullText = "Seleccione"
        Me.CmbPregunta.Size = New System.Drawing.Size(213, 20)
        Me.CmbPregunta.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(57, 65)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Usuario"
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(178, 233)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(63, 55)
        Me.BtnSalir.TabIndex = 12
        Me.BtnSalir.Text = "Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.Usuarios
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(89, 233)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(63, 55)
        Me.SimpleButton1.TabIndex = 13
        Me.SimpleButton1.Text = "Comprobar"
        '
        'txtrespuesta
        '
        Me.txtrespuesta.Location = New System.Drawing.Point(57, 189)
        Me.txtrespuesta.Name = "txtrespuesta"
        Me.txtrespuesta.Properties.MaxLength = 100
        Me.txtrespuesta.Size = New System.Drawing.Size(213, 20)
        Me.txtrespuesta.TabIndex = 14
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(57, 170)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Respuesta de Seguridad"
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(57, 84)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Properties.MaxLength = 10
        Me.txtcedula.Size = New System.Drawing.Size(213, 20)
        Me.txtcedula.TabIndex = 16
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(57, 114)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(213, 13)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Seleccione la pregunta de seguridad elegida "
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(43, 26)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(276, 26)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "¿No puedes iniciar sesión? Ingrese la información" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " solicitada para recuperar su " & _
            "contraseña"
        '
        'XfrmRecuperarPass
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 304)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtrespuesta)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.CmbPregunta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "XfrmRecuperarPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar Contraseña"
        CType(Me.CmbPregunta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrespuesta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcedula.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbPregunta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtrespuesta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcedula As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
