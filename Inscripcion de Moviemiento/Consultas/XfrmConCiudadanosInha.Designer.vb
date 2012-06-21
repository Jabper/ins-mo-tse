<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmConCiudadanosInha
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
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.IMCIUDADANOSINHABILITADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSConsultas = New Inscripcion_de_Moviemientos.DSConsultas
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNUMERO_IDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIMER_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSEGUNDO_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPEDENCIA_GUBERNAMENTAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCARGO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.IM_CIUDADANOS_INHABILITADOSTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.IM_CIUDADANOS_INHABILITADOSTableAdapter
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnFiltro = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cbxMotivo = New System.Windows.Forms.ComboBox
        Me.MotivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCargo = New System.Windows.Forms.TextBox
        Me.txtDependencia = New System.Windows.Forms.TextBox
        Me.txtIdentidad = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSApellido = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPApellido = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNombres = New System.Windows.Forms.TextBox
        Me.MotivosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MotivosTableAdapter
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMCIUDADANOSINHABILITADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.MotivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCBusqueda
        '
        Me.GCBusqueda.DataSource = Me.IMCIUDADANOSINHABILITADOSBindingSource
        Me.GCBusqueda.Location = New System.Drawing.Point(12, 226)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.Size = New System.Drawing.Size(1038, 408)
        Me.GCBusqueda.TabIndex = 7
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'IMCIUDADANOSINHABILITADOSBindingSource
        '
        Me.IMCIUDADANOSINHABILITADOSBindingSource.DataMember = "IM_CIUDADANOS_INHABILITADOS"
        Me.IMCIUDADANOSINHABILITADOSBindingSource.DataSource = Me.DSConsultas
        '
        'DSConsultas
        '
        Me.DSConsultas.DataSetName = "DSConsultas"
        Me.DSConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNUMERO_IDENTIFICACION, Me.colNOMBRES, Me.colPRIMER_APELLIDO, Me.colSEGUNDO_APELLIDO, Me.colDEPEDENCIA_GUBERNAMENTAL, Me.colCARGO, Me.colCODIGO_MOTIVO, Me.colDESCRIPCION})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(653, 515, 216, 185)
        Me.GridView1.GridControl = Me.GCBusqueda
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colNUMERO_IDENTIFICACION
        '
        Me.colNUMERO_IDENTIFICACION.Caption = "No. Identificación"
        Me.colNUMERO_IDENTIFICACION.FieldName = "NUMERO_IDENTIFICACION"
        Me.colNUMERO_IDENTIFICACION.Name = "colNUMERO_IDENTIFICACION"
        Me.colNUMERO_IDENTIFICACION.OptionsColumn.AllowEdit = False
        Me.colNUMERO_IDENTIFICACION.OptionsColumn.AllowFocus = False
        Me.colNUMERO_IDENTIFICACION.OptionsColumn.TabStop = False
        Me.colNUMERO_IDENTIFICACION.Visible = True
        Me.colNUMERO_IDENTIFICACION.VisibleIndex = 0
        Me.colNUMERO_IDENTIFICACION.Width = 152
        '
        'colNOMBRES
        '
        Me.colNOMBRES.Caption = "Nombres"
        Me.colNOMBRES.FieldName = "NOMBRES"
        Me.colNOMBRES.Name = "colNOMBRES"
        Me.colNOMBRES.OptionsColumn.AllowEdit = False
        Me.colNOMBRES.OptionsColumn.AllowFocus = False
        Me.colNOMBRES.OptionsColumn.TabStop = False
        Me.colNOMBRES.Visible = True
        Me.colNOMBRES.VisibleIndex = 1
        '
        'colPRIMER_APELLIDO
        '
        Me.colPRIMER_APELLIDO.Caption = "Primer Apellido"
        Me.colPRIMER_APELLIDO.FieldName = "PRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.Name = "colPRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.OptionsColumn.AllowEdit = False
        Me.colPRIMER_APELLIDO.OptionsColumn.AllowFocus = False
        Me.colPRIMER_APELLIDO.OptionsColumn.TabStop = False
        Me.colPRIMER_APELLIDO.Visible = True
        Me.colPRIMER_APELLIDO.VisibleIndex = 2
        Me.colPRIMER_APELLIDO.Width = 111
        '
        'colSEGUNDO_APELLIDO
        '
        Me.colSEGUNDO_APELLIDO.Caption = "Segundo Apellido"
        Me.colSEGUNDO_APELLIDO.FieldName = "SEGUNDO_APELLIDO"
        Me.colSEGUNDO_APELLIDO.Name = "colSEGUNDO_APELLIDO"
        Me.colSEGUNDO_APELLIDO.OptionsColumn.AllowEdit = False
        Me.colSEGUNDO_APELLIDO.OptionsColumn.AllowFocus = False
        Me.colSEGUNDO_APELLIDO.OptionsColumn.TabStop = False
        Me.colSEGUNDO_APELLIDO.Visible = True
        Me.colSEGUNDO_APELLIDO.VisibleIndex = 3
        Me.colSEGUNDO_APELLIDO.Width = 121
        '
        'colDEPEDENCIA_GUBERNAMENTAL
        '
        Me.colDEPEDENCIA_GUBERNAMENTAL.Caption = "Dependencia Gubernamental"
        Me.colDEPEDENCIA_GUBERNAMENTAL.FieldName = "DEPEDENCIA_GUBERNAMENTAL"
        Me.colDEPEDENCIA_GUBERNAMENTAL.Name = "colDEPEDENCIA_GUBERNAMENTAL"
        Me.colDEPEDENCIA_GUBERNAMENTAL.OptionsColumn.AllowEdit = False
        Me.colDEPEDENCIA_GUBERNAMENTAL.OptionsColumn.AllowFocus = False
        Me.colDEPEDENCIA_GUBERNAMENTAL.OptionsColumn.TabStop = False
        Me.colDEPEDENCIA_GUBERNAMENTAL.Visible = True
        Me.colDEPEDENCIA_GUBERNAMENTAL.VisibleIndex = 4
        Me.colDEPEDENCIA_GUBERNAMENTAL.Width = 174
        '
        'colCARGO
        '
        Me.colCARGO.Caption = "Cargo"
        Me.colCARGO.FieldName = "CARGO"
        Me.colCARGO.Name = "colCARGO"
        Me.colCARGO.OptionsColumn.AllowEdit = False
        Me.colCARGO.OptionsColumn.AllowFocus = False
        Me.colCARGO.OptionsColumn.TabStop = False
        Me.colCARGO.Visible = True
        Me.colCARGO.VisibleIndex = 5
        '
        'colCODIGO_MOTIVO
        '
        Me.colCODIGO_MOTIVO.FieldName = "CODIGO_MOTIVO"
        Me.colCODIGO_MOTIVO.Name = "colCODIGO_MOTIVO"
        Me.colCODIGO_MOTIVO.OptionsColumn.AllowEdit = False
        Me.colCODIGO_MOTIVO.OptionsColumn.AllowFocus = False
        Me.colCODIGO_MOTIVO.OptionsColumn.TabStop = False
        Me.colCODIGO_MOTIVO.Width = 96
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Motivo"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.OptionsColumn.AllowEdit = False
        Me.colDESCRIPCION.OptionsColumn.AllowFocus = False
        Me.colDESCRIPCION.OptionsColumn.TabStop = False
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 6
        Me.colDESCRIPCION.Width = 88
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'IM_CIUDADANOS_INHABILITADOSTableAdapter
        '
        Me.IM_CIUDADANOS_INHABILITADOSTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFiltro)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(248, 64)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'btnFiltro
        '
        Me.btnFiltro.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnFiltro.Appearance.Options.UseFont = True
        Me.btnFiltro.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources._new
        Me.btnFiltro.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnFiltro.Location = New System.Drawing.Point(3, 3)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(55, 55)
        Me.btnFiltro.TabIndex = 0
        Me.btnFiltro.TabStop = False
        Me.btnFiltro.Text = "Filtrar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.btnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(64, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(55, 55)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.TabStop = False
        Me.btnSalir.Text = "Salir"
        '
        'cbxMotivo
        '
        Me.cbxMotivo.DataSource = Me.MotivosBindingSource
        Me.cbxMotivo.DisplayMember = "DESCRIPCION"
        Me.cbxMotivo.FormattingEnabled = True
        Me.cbxMotivo.Location = New System.Drawing.Point(566, 111)
        Me.cbxMotivo.Name = "cbxMotivo"
        Me.cbxMotivo.Size = New System.Drawing.Size(361, 21)
        Me.cbxMotivo.TabIndex = 6
        Me.cbxMotivo.ValueMember = "CODIGO_MOTIVO"
        '
        'MotivosBindingSource
        '
        Me.MotivosBindingSource.DataMember = "Motivos"
        Me.MotivosBindingSource.DataSource = Me.DSConsultas
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCargo)
        Me.GroupBox1.Controls.Add(Me.txtDependencia)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSApellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.cbxMotivo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 138)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(491, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Dependencia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(521, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Motivo"
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(566, 84)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(361, 21)
        Me.txtCargo.TabIndex = 5
        '
        'txtDependencia
        '
        Me.txtDependencia.Location = New System.Drawing.Point(566, 58)
        Me.txtDependencia.Name = "txtDependencia"
        Me.txtDependencia.Size = New System.Drawing.Size(361, 21)
        Me.txtDependencia.TabIndex = 4
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(111, 20)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(361, 21)
        Me.txtIdentidad.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "No. Identidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Segundo Apellido"
        '
        'txtSApellido
        '
        Me.txtSApellido.Location = New System.Drawing.Point(111, 111)
        Me.txtSApellido.Name = "txtSApellido"
        Me.txtSApellido.Size = New System.Drawing.Size(361, 21)
        Me.txtSApellido.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Primer Apellido"
        '
        'txtPApellido
        '
        Me.txtPApellido.Location = New System.Drawing.Point(111, 84)
        Me.txtPApellido.Name = "txtPApellido"
        Me.txtPApellido.Size = New System.Drawing.Size(361, 21)
        Me.txtPApellido.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(524, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Cargo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombres"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(111, 57)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(361, 21)
        Me.txtNombres.TabIndex = 1
        '
        'MotivosTableAdapter
        '
        Me.MotivosTableAdapter.ClearBeforeFill = True
        '
        'XfrmConCiudadanosInha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 628)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GCBusqueda)
        Me.Name = "XfrmConCiudadanosInha"
        Me.Text = "Ciudadanos Inhabilitados"
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMCIUDADANOSINHABILITADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.MotivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DSConsultas As Inscripcion_de_Moviemientos.DSConsultas
    Friend WithEvents IMCIUDADANOSINHABILITADOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CIUDADANOS_INHABILITADOSTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.IM_CIUDADANOS_INHABILITADOSTableAdapter
    Friend WithEvents colNUMERO_IDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPEDENCIA_GUBERNAMENTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnFiltro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbxMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtDependencia As System.Windows.Forms.TextBox
    Friend WithEvents txtIdentidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MotivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MotivosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MotivosTableAdapter
End Class
