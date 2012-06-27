<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmDiscoPartido
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
        Me.IMPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_procesos = New Inscripcion_de_Moviemientos.Ds_procesos
        Me.FbUbicacion = New System.Windows.Forms.FolderBrowserDialog
        Me.DsprocesosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.Ds_procesosTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
        Me.TxtRuta = New DevExpress.XtraEditors.TextEdit
        Me.BtnExplorar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnEjecutar = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.LovPartido = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_procesos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsprocesosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LovPartido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IMPARTIDOSPOLITICOSBindingSource
        '
        Me.IMPARTIDOSPOLITICOSBindingSource.DataMember = "IM_PARTIDOS_POLITICOS"
        Me.IMPARTIDOSPOLITICOSBindingSource.DataSource = Me.Ds_procesos
        '
        'Ds_procesos
        '
        Me.Ds_procesos.DataSetName = "Ds_procesos"
        Me.Ds_procesos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsprocesosBindingSource
        '
        Me.DsprocesosBindingSource.DataSource = Me.Ds_procesos
        Me.DsprocesosBindingSource.Position = 0
        '
        'IM_PARTIDOS_POLITICOSTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'TxtRuta
        '
        Me.TxtRuta.Enabled = False
        Me.TxtRuta.Location = New System.Drawing.Point(13, 145)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Properties.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.TxtRuta.Size = New System.Drawing.Size(219, 20)
        Me.TxtRuta.TabIndex = 12
        '
        'BtnExplorar
        '
        Me.BtnExplorar.Location = New System.Drawing.Point(240, 143)
        Me.BtnExplorar.Name = "BtnExplorar"
        Me.BtnExplorar.Size = New System.Drawing.Size(75, 23)
        Me.BtnExplorar.TabIndex = 13
        Me.BtnExplorar.Text = "Explorar"
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(125, 174)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEjecutar.TabIndex = 14
        Me.BtnEjecutar.Text = "Generar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Seleccione la ubicacion del archivo a exportar:"
        '
        'LovPartido
        '
        Me.LovPartido.Location = New System.Drawing.Point(13, 100)
        Me.LovPartido.Name = "LovPartido"
        Me.LovPartido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LovPartido.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_PARTIDO", "CODIGO_PARTIDO", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LovPartido.Properties.DataSource = Me.IMPARTIDOSPOLITICOSBindingSource
        Me.LovPartido.Properties.DisplayMember = "NOMBRE"
        Me.LovPartido.Properties.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.LovPartido.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.LovPartido.Size = New System.Drawing.Size(302, 20)
        Me.LovPartido.TabIndex = 17
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 80)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(267, 13)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "Seleccione el partido al que se le generará el instalador:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.LovPartido)
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnEjecutar)
        Me.Panel1.Controls.Add(Me.BtnExplorar)
        Me.Panel1.Controls.Add(Me.TxtRuta)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 223)
        Me.Panel1.TabIndex = 11
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(9, 7)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 55)
        Me.BtnSalir.TabIndex = 16
        Me.BtnSalir.Text = "Salir"
        '
        'XfrmDiscoPartido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 248)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "XfrmDiscoPartido"
        Me.Text = "Generar Instalador para Partidos"
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_procesos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsprocesosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LovPartido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FbUbicacion As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DsprocesosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_procesos As Inscripcion_de_Moviemientos.Ds_procesos
    Friend WithEvents IMPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.Ds_procesosTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents TxtRuta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnExplorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEjecutar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LovPartido As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
