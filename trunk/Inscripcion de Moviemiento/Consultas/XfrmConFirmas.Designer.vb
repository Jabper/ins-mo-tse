<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmConFirmas
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
        Me.IMFK1MOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSConsultas = New Inscripcion_de_Moviemientos.DSConsultas
        Me.IMFK1MUNICIPIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.DepartamentosTableAdapter
        Me.MunicipiosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MunicipiosTableAdapter
        Me.PartidosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.PartidosTableAdapter
        Me.MovimientosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MovimientosTableAdapter
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnFiltro = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkIgual = New System.Windows.Forms.CheckBox
        Me.chkDireccion = New System.Windows.Forms.CheckBox
        Me.chkHuella = New System.Windows.Forms.CheckBox
        Me.chkFirma = New System.Windows.Forms.CheckBox
        Me.txtPagina = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.cbxMovimiento = New System.Windows.Forms.ComboBox
        Me.cbxMunicipio = New System.Windows.Forms.ComboBox
        Me.cbxDepartamento = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPNombre = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtIdentidad = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSApellido = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPApellido = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSNombre = New System.Windows.Forms.TextBox
        Me.cbxPartido = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.pbxFirma = New System.Windows.Forms.PictureBox
        Me.ImagenesFirmaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_CUIDADANOS_RESPALDAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIDENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIMER_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSEGUNDO_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIMER_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSEGUNDO_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFOLIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPAGINA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHUELLA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDIRECCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIGUAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOBSERVACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ImagenesFirmaTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.ImagenesFirmaTableAdapter
        CType(Me.IMFK1MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMFK1MUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbxFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenesFirmaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMFK1MOVIMIENTOSBindingSource
        '
        Me.IMFK1MOVIMIENTOSBindingSource.DataMember = "IM_FK1_MOVIMIENTOS"
        Me.IMFK1MOVIMIENTOSBindingSource.DataSource = Me.PartidosBindingSource
        '
        'PartidosBindingSource
        '
        Me.PartidosBindingSource.DataMember = "Partidos"
        Me.PartidosBindingSource.DataSource = Me.DSConsultas
        '
        'DSConsultas
        '
        Me.DSConsultas.DataSetName = "DSConsultas"
        Me.DSConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IMFK1MUNICIPIOBindingSource
        '
        Me.IMFK1MUNICIPIOBindingSource.DataMember = "IM_FK1_MUNICIPIO"
        Me.IMFK1MUNICIPIOBindingSource.DataSource = Me.DepartamentosBindingSource
        '
        'DepartamentosBindingSource
        '
        Me.DepartamentosBindingSource.DataMember = "Departamentos"
        Me.DepartamentosBindingSource.DataSource = Me.DSConsultas
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'MunicipiosTableAdapter
        '
        Me.MunicipiosTableAdapter.ClearBeforeFill = True
        '
        'PartidosTableAdapter
        '
        Me.PartidosTableAdapter.ClearBeforeFill = True
        '
        'MovimientosTableAdapter
        '
        Me.MovimientosTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1177, 279)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFiltro)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1162, 64)
        Me.FlowLayoutPanel1.TabIndex = 20
        '
        'btnFiltro
        '
        Me.btnFiltro.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnFiltro.Appearance.Options.UseFont = True
        Me.btnFiltro.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.Filtro
        Me.btnFiltro.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnFiltro.Location = New System.Drawing.Point(3, 3)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(55, 55)
        Me.btnFiltro.TabIndex = 1
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
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.TabStop = False
        Me.btnSalir.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkIgual)
        Me.GroupBox1.Controls.Add(Me.chkDireccion)
        Me.GroupBox1.Controls.Add(Me.chkHuella)
        Me.GroupBox1.Controls.Add(Me.chkFirma)
        Me.GroupBox1.Controls.Add(Me.txtPagina)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtFolio)
        Me.GroupBox1.Controls.Add(Me.cbxMovimiento)
        Me.GroupBox1.Controls.Add(Me.cbxMunicipio)
        Me.GroupBox1.Controls.Add(Me.cbxDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPNombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSApellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSNombre)
        Me.GroupBox1.Controls.Add(Me.cbxPartido)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 197)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'chkIgual
        '
        Me.chkIgual.AutoSize = True
        Me.chkIgual.Checked = True
        Me.chkIgual.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkIgual.Location = New System.Drawing.Point(484, 168)
        Me.chkIgual.Name = "chkIgual"
        Me.chkIgual.Size = New System.Drawing.Size(176, 17)
        Me.chkIgual.TabIndex = 17
        Me.chkIgual.Text = "¿Nombre coincide con el censo?"
        Me.chkIgual.UseVisualStyleBackColor = True
        '
        'chkDireccion
        '
        Me.chkDireccion.AutoSize = True
        Me.chkDireccion.Checked = True
        Me.chkDireccion.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkDireccion.Location = New System.Drawing.Point(294, 168)
        Me.chkDireccion.Name = "chkDireccion"
        Me.chkDireccion.Size = New System.Drawing.Size(101, 17)
        Me.chkDireccion.TabIndex = 10
        Me.chkDireccion.Text = "¿Con Dirección?"
        Me.chkDireccion.UseVisualStyleBackColor = True
        '
        'chkHuella
        '
        Me.chkHuella.AutoSize = True
        Me.chkHuella.Checked = True
        Me.chkHuella.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkHuella.Location = New System.Drawing.Point(201, 168)
        Me.chkHuella.Name = "chkHuella"
        Me.chkHuella.Size = New System.Drawing.Size(87, 17)
        Me.chkHuella.TabIndex = 9
        Me.chkHuella.Text = "¿Con Huella?"
        Me.chkHuella.UseVisualStyleBackColor = True
        '
        'chkFirma
        '
        Me.chkFirma.AutoSize = True
        Me.chkFirma.Checked = True
        Me.chkFirma.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkFirma.Location = New System.Drawing.Point(111, 168)
        Me.chkFirma.Name = "chkFirma"
        Me.chkFirma.Size = New System.Drawing.Size(84, 17)
        Me.chkFirma.TabIndex = 8
        Me.chkFirma.Text = "¿Con Firma?"
        Me.chkFirma.UseVisualStyleBackColor = True
        '
        'txtPagina
        '
        Me.txtPagina.Location = New System.Drawing.Point(721, 20)
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPagina.Size = New System.Drawing.Size(160, 21)
        Me.txtPagina.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(676, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Página"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(484, 20)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFolio.Size = New System.Drawing.Size(160, 21)
        Me.txtFolio.TabIndex = 11
        '
        'cbxMovimiento
        '
        Me.cbxMovimiento.DataSource = Me.IMFK1MOVIMIENTOSBindingSource
        Me.cbxMovimiento.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.cbxMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMovimiento.FormattingEnabled = True
        Me.cbxMovimiento.Location = New System.Drawing.Point(484, 87)
        Me.cbxMovimiento.Name = "cbxMovimiento"
        Me.cbxMovimiento.Size = New System.Drawing.Size(397, 21)
        Me.cbxMovimiento.TabIndex = 14
        Me.cbxMovimiento.ValueMember = "CODIGO_MOVIMIENTO"
        '
        'cbxMunicipio
        '
        Me.cbxMunicipio.DataSource = Me.IMFK1MUNICIPIOBindingSource
        Me.cbxMunicipio.DisplayMember = "DESCRIPCION"
        Me.cbxMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMunicipio.FormattingEnabled = True
        Me.cbxMunicipio.Location = New System.Drawing.Point(484, 141)
        Me.cbxMunicipio.Name = "cbxMunicipio"
        Me.cbxMunicipio.Size = New System.Drawing.Size(397, 21)
        Me.cbxMunicipio.TabIndex = 16
        Me.cbxMunicipio.ValueMember = "CODIGO_MUNICIPIO"
        '
        'cbxDepartamento
        '
        Me.cbxDepartamento.DataSource = Me.DepartamentosBindingSource
        Me.cbxDepartamento.DisplayMember = "DESCRIPCION"
        Me.cbxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDepartamento.FormattingEnabled = True
        Me.cbxDepartamento.Location = New System.Drawing.Point(484, 114)
        Me.cbxDepartamento.Name = "cbxDepartamento"
        Me.cbxDepartamento.Size = New System.Drawing.Size(397, 21)
        Me.cbxDepartamento.TabIndex = 15
        Me.cbxDepartamento.ValueMember = "CODIGO_DEPARTAMENTO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(449, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Folio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(417, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Movimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Segundo Nombre"
        '
        'txtPNombre
        '
        Me.txtPNombre.Location = New System.Drawing.Point(111, 60)
        Me.txtPNombre.Name = "txtPNombre"
        Me.txtPNombre.Size = New System.Drawing.Size(277, 21)
        Me.txtPNombre.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(402, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Departamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(436, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Partido"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(111, 20)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(277, 21)
        Me.txtIdentidad.TabIndex = 3
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
        Me.Label4.Location = New System.Drawing.Point(16, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Segundo Apellido"
        '
        'txtSApellido
        '
        Me.txtSApellido.Location = New System.Drawing.Point(111, 141)
        Me.txtSApellido.Name = "txtSApellido"
        Me.txtSApellido.Size = New System.Drawing.Size(277, 21)
        Me.txtSApellido.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Primer Apellido"
        '
        'txtPApellido
        '
        Me.txtPApellido.Location = New System.Drawing.Point(111, 114)
        Me.txtPApellido.Name = "txtPApellido"
        Me.txtPApellido.Size = New System.Drawing.Size(277, 21)
        Me.txtPApellido.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Municipio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Primer Nombre"
        '
        'txtSNombre
        '
        Me.txtSNombre.Location = New System.Drawing.Point(111, 87)
        Me.txtSNombre.Name = "txtSNombre"
        Me.txtSNombre.Size = New System.Drawing.Size(277, 21)
        Me.txtSNombre.TabIndex = 5
        '
        'cbxPartido
        '
        Me.cbxPartido.DataSource = Me.PartidosBindingSource
        Me.cbxPartido.DisplayMember = "NOMBRE"
        Me.cbxPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPartido.FormattingEnabled = True
        Me.cbxPartido.Location = New System.Drawing.Point(484, 60)
        Me.cbxPartido.Name = "cbxPartido"
        Me.cbxPartido.Size = New System.Drawing.Size(397, 21)
        Me.cbxPartido.TabIndex = 13
        Me.cbxPartido.ValueMember = "CODIGO_PARTIDO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pbxFirma)
        Me.GroupBox2.Location = New System.Drawing.Point(905, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(193, 197)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Firma"
        '
        'pbxFirma
        '
        Me.pbxFirma.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ImagenesFirmaBindingSource, "IMAGEN", True))
        Me.pbxFirma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxFirma.Location = New System.Drawing.Point(3, 17)
        Me.pbxFirma.Name = "pbxFirma"
        Me.pbxFirma.Size = New System.Drawing.Size(187, 177)
        Me.pbxFirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFirma.TabIndex = 0
        Me.pbxFirma.TabStop = False
        '
        'ImagenesFirmaBindingSource
        '
        Me.ImagenesFirmaBindingSource.DataMember = "ImagenesFirma"
        Me.ImagenesFirmaBindingSource.DataSource = Me.DSConsultas
        '
        'GCBusqueda
        '
        Me.GCBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCBusqueda.Location = New System.Drawing.Point(0, 279)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.Size = New System.Drawing.Size(1177, 426)
        Me.GCBusqueda.TabIndex = 18
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_CUIDADANOS_RESPALDAN, Me.colCODIGO_PARTIDO, Me.colCODIGO_MOVIMIENTO, Me.colPARTIDO, Me.colMOVIMIENTO, Me.colDEPARTAMENTO, Me.colMUNICIPIO, Me.colIDENTIDAD, Me.colPRIMER_NOMBRE, Me.colSEGUNDO_NOMBRE, Me.colPRIMER_APELLIDO, Me.colSEGUNDO_APELLIDO, Me.colFOLIO, Me.colPAGINA, Me.colFIRMA, Me.colHUELLA, Me.colDIRECCION, Me.colIGUAL, Me.colOBSERVACION})
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
        'colCODIGO_CUIDADANOS_RESPALDAN
        '
        Me.colCODIGO_CUIDADANOS_RESPALDAN.FieldName = "CODIGO_CUIDADANOS_RESPALDAN"
        Me.colCODIGO_CUIDADANOS_RESPALDAN.Name = "colCODIGO_CUIDADANOS_RESPALDAN"
        Me.colCODIGO_CUIDADANOS_RESPALDAN.OptionsColumn.AllowEdit = False
        Me.colCODIGO_CUIDADANOS_RESPALDAN.OptionsColumn.AllowFocus = False
        Me.colCODIGO_CUIDADANOS_RESPALDAN.OptionsColumn.TabStop = False
        Me.colCODIGO_CUIDADANOS_RESPALDAN.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'colCODIGO_PARTIDO
        '
        Me.colCODIGO_PARTIDO.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Name = "colCODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.OptionsColumn.AllowEdit = False
        Me.colCODIGO_PARTIDO.OptionsColumn.AllowFocus = False
        Me.colCODIGO_PARTIDO.OptionsColumn.TabStop = False
        Me.colCODIGO_PARTIDO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'colCODIGO_MOVIMIENTO
        '
        Me.colCODIGO_MOVIMIENTO.FieldName = "CODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO.Name = "colCODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO.OptionsColumn.AllowEdit = False
        Me.colCODIGO_MOVIMIENTO.OptionsColumn.AllowFocus = False
        Me.colCODIGO_MOVIMIENTO.OptionsColumn.TabStop = False
        Me.colCODIGO_MOVIMIENTO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'colPARTIDO
        '
        Me.colPARTIDO.Caption = "Partido"
        Me.colPARTIDO.FieldName = "PARTIDO"
        Me.colPARTIDO.Name = "colPARTIDO"
        Me.colPARTIDO.OptionsColumn.AllowEdit = False
        Me.colPARTIDO.OptionsColumn.AllowFocus = False
        Me.colPARTIDO.OptionsColumn.TabStop = False
        Me.colPARTIDO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colPARTIDO.Visible = True
        Me.colPARTIDO.VisibleIndex = 0
        Me.colPARTIDO.Width = 139
        '
        'colMOVIMIENTO
        '
        Me.colMOVIMIENTO.Caption = "Movimiento"
        Me.colMOVIMIENTO.FieldName = "MOVIMIENTO"
        Me.colMOVIMIENTO.Name = "colMOVIMIENTO"
        Me.colMOVIMIENTO.OptionsColumn.AllowEdit = False
        Me.colMOVIMIENTO.OptionsColumn.AllowFocus = False
        Me.colMOVIMIENTO.OptionsColumn.TabStop = False
        Me.colMOVIMIENTO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colMOVIMIENTO.Visible = True
        Me.colMOVIMIENTO.VisibleIndex = 1
        Me.colMOVIMIENTO.Width = 136
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.OptionsColumn.AllowEdit = False
        Me.colDEPARTAMENTO.OptionsColumn.AllowFocus = False
        Me.colDEPARTAMENTO.OptionsColumn.TabStop = False
        Me.colDEPARTAMENTO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colDEPARTAMENTO.Visible = True
        Me.colDEPARTAMENTO.VisibleIndex = 2
        Me.colDEPARTAMENTO.Width = 148
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.Caption = "Municipio"
        Me.colMUNICIPIO.FieldName = "MUNICIPIO"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.OptionsColumn.AllowEdit = False
        Me.colMUNICIPIO.OptionsColumn.AllowFocus = False
        Me.colMUNICIPIO.OptionsColumn.TabStop = False
        Me.colMUNICIPIO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colMUNICIPIO.Visible = True
        Me.colMUNICIPIO.VisibleIndex = 3
        Me.colMUNICIPIO.Width = 151
        '
        'colIDENTIDAD
        '
        Me.colIDENTIDAD.Caption = "No. Identificación"
        Me.colIDENTIDAD.FieldName = "IDENTIDAD"
        Me.colIDENTIDAD.Name = "colIDENTIDAD"
        Me.colIDENTIDAD.OptionsColumn.AllowEdit = False
        Me.colIDENTIDAD.OptionsColumn.AllowFocus = False
        Me.colIDENTIDAD.OptionsColumn.TabStop = False
        Me.colIDENTIDAD.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colIDENTIDAD.Visible = True
        Me.colIDENTIDAD.VisibleIndex = 4
        Me.colIDENTIDAD.Width = 100
        '
        'colPRIMER_NOMBRE
        '
        Me.colPRIMER_NOMBRE.Caption = "Primer Nombre"
        Me.colPRIMER_NOMBRE.FieldName = "PRIMER_NOMBRE_PAPELETA"
        Me.colPRIMER_NOMBRE.Name = "colPRIMER_NOMBRE"
        Me.colPRIMER_NOMBRE.OptionsColumn.AllowEdit = False
        Me.colPRIMER_NOMBRE.OptionsColumn.AllowFocus = False
        Me.colPRIMER_NOMBRE.OptionsColumn.TabStop = False
        Me.colPRIMER_NOMBRE.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colPRIMER_NOMBRE.Visible = True
        Me.colPRIMER_NOMBRE.VisibleIndex = 5
        Me.colPRIMER_NOMBRE.Width = 100
        '
        'colSEGUNDO_NOMBRE
        '
        Me.colSEGUNDO_NOMBRE.Caption = "Segundo Nombre"
        Me.colSEGUNDO_NOMBRE.FieldName = "SEGUNDO_NOMBRE_PAPELETA"
        Me.colSEGUNDO_NOMBRE.Name = "colSEGUNDO_NOMBRE"
        Me.colSEGUNDO_NOMBRE.OptionsColumn.AllowEdit = False
        Me.colSEGUNDO_NOMBRE.OptionsColumn.AllowFocus = False
        Me.colSEGUNDO_NOMBRE.OptionsColumn.TabStop = False
        Me.colSEGUNDO_NOMBRE.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colSEGUNDO_NOMBRE.Visible = True
        Me.colSEGUNDO_NOMBRE.VisibleIndex = 6
        Me.colSEGUNDO_NOMBRE.Width = 100
        '
        'colPRIMER_APELLIDO
        '
        Me.colPRIMER_APELLIDO.Caption = "Primer Apellido"
        Me.colPRIMER_APELLIDO.FieldName = "PRIMER_APELLIDO_PAPELETA"
        Me.colPRIMER_APELLIDO.Name = "colPRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.OptionsColumn.AllowEdit = False
        Me.colPRIMER_APELLIDO.OptionsColumn.AllowFocus = False
        Me.colPRIMER_APELLIDO.OptionsColumn.TabStop = False
        Me.colPRIMER_APELLIDO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colPRIMER_APELLIDO.Visible = True
        Me.colPRIMER_APELLIDO.VisibleIndex = 7
        Me.colPRIMER_APELLIDO.Width = 100
        '
        'colSEGUNDO_APELLIDO
        '
        Me.colSEGUNDO_APELLIDO.Caption = "Segundo Apellido"
        Me.colSEGUNDO_APELLIDO.FieldName = "SEGUNDO_APELLIDO_PAPELETA"
        Me.colSEGUNDO_APELLIDO.Name = "colSEGUNDO_APELLIDO"
        Me.colSEGUNDO_APELLIDO.OptionsColumn.AllowEdit = False
        Me.colSEGUNDO_APELLIDO.OptionsColumn.AllowFocus = False
        Me.colSEGUNDO_APELLIDO.OptionsColumn.TabStop = False
        Me.colSEGUNDO_APELLIDO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colSEGUNDO_APELLIDO.Visible = True
        Me.colSEGUNDO_APELLIDO.VisibleIndex = 8
        Me.colSEGUNDO_APELLIDO.Width = 100
        '
        'colFOLIO
        '
        Me.colFOLIO.Caption = "Folio"
        Me.colFOLIO.FieldName = "FOLIO"
        Me.colFOLIO.Name = "colFOLIO"
        Me.colFOLIO.OptionsColumn.AllowEdit = False
        Me.colFOLIO.OptionsColumn.AllowFocus = False
        Me.colFOLIO.OptionsColumn.TabStop = False
        Me.colFOLIO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colFOLIO.Visible = True
        Me.colFOLIO.VisibleIndex = 10
        Me.colFOLIO.Width = 73
        '
        'colPAGINA
        '
        Me.colPAGINA.Caption = "Página"
        Me.colPAGINA.FieldName = "PAGINA"
        Me.colPAGINA.Name = "colPAGINA"
        Me.colPAGINA.OptionsColumn.AllowEdit = False
        Me.colPAGINA.OptionsColumn.AllowFocus = False
        Me.colPAGINA.OptionsColumn.TabStop = False
        Me.colPAGINA.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colPAGINA.Visible = True
        Me.colPAGINA.VisibleIndex = 9
        '
        'colFIRMA
        '
        Me.colFIRMA.Caption = "¿Con Firma?"
        Me.colFIRMA.FieldName = "FIRMA"
        Me.colFIRMA.Name = "colFIRMA"
        Me.colFIRMA.OptionsColumn.AllowEdit = False
        Me.colFIRMA.OptionsColumn.AllowFocus = False
        Me.colFIRMA.OptionsColumn.TabStop = False
        Me.colFIRMA.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colFIRMA.Visible = True
        Me.colFIRMA.VisibleIndex = 11
        Me.colFIRMA.Width = 65
        '
        'colHUELLA
        '
        Me.colHUELLA.Caption = "¿Con Huella?"
        Me.colHUELLA.FieldName = "HUELLA"
        Me.colHUELLA.Name = "colHUELLA"
        Me.colHUELLA.OptionsColumn.AllowEdit = False
        Me.colHUELLA.OptionsColumn.AllowFocus = False
        Me.colHUELLA.OptionsColumn.TabStop = False
        Me.colHUELLA.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colHUELLA.Visible = True
        Me.colHUELLA.VisibleIndex = 12
        Me.colHUELLA.Width = 68
        '
        'colDIRECCION
        '
        Me.colDIRECCION.Caption = "¿Con Dirección?"
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        Me.colDIRECCION.OptionsColumn.AllowEdit = False
        Me.colDIRECCION.OptionsColumn.AllowFocus = False
        Me.colDIRECCION.OptionsColumn.TabStop = False
        Me.colDIRECCION.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colDIRECCION.Visible = True
        Me.colDIRECCION.VisibleIndex = 13
        Me.colDIRECCION.Width = 84
        '
        'colIGUAL
        '
        Me.colIGUAL.Caption = "¿Nombre Coincide?"
        Me.colIGUAL.FieldName = "IGUAL"
        Me.colIGUAL.Name = "colIGUAL"
        Me.colIGUAL.OptionsColumn.AllowEdit = False
        Me.colIGUAL.OptionsColumn.AllowFocus = False
        Me.colIGUAL.OptionsColumn.TabStop = False
        Me.colIGUAL.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colIGUAL.Visible = True
        Me.colIGUAL.VisibleIndex = 14
        Me.colIGUAL.Width = 99
        '
        'colOBSERVACION
        '
        Me.colOBSERVACION.Caption = "Observación"
        Me.colOBSERVACION.FieldName = "OBSERVACION"
        Me.colOBSERVACION.Name = "colOBSERVACION"
        Me.colOBSERVACION.OptionsColumn.AllowEdit = False
        Me.colOBSERVACION.OptionsColumn.AllowFocus = False
        Me.colOBSERVACION.OptionsColumn.TabStop = False
        Me.colOBSERVACION.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colOBSERVACION.Visible = True
        Me.colOBSERVACION.VisibleIndex = 15
        Me.colOBSERVACION.Width = 152
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'ImagenesFirmaTableAdapter
        '
        Me.ImagenesFirmaTableAdapter.ClearBeforeFill = True
        '
        'XfrmConFirmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 705)
        Me.Controls.Add(Me.GCBusqueda)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Name = "XfrmConFirmas"
        Me.Text = "Consultar Fimas"
        CType(Me.IMFK1MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMFK1MUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbxFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenesFirmaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSConsultas As Inscripcion_de_Moviemientos.DSConsultas
    Friend WithEvents DepartamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartamentosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.DepartamentosTableAdapter
    Friend WithEvents IMFK1MUNICIPIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MunicipiosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MunicipiosTableAdapter
    Friend WithEvents PartidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartidosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.PartidosTableAdapter
    Friend WithEvents IMFK1MOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MovimientosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MovimientosTableAdapter
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnFiltro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkIgual As System.Windows.Forms.CheckBox
    Friend WithEvents chkDireccion As System.Windows.Forms.CheckBox
    Friend WithEvents chkHuella As System.Windows.Forms.CheckBox
    Friend WithEvents chkFirma As System.Windows.Forms.CheckBox
    Friend WithEvents txtPagina As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents cbxMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents cbxMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdentidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSNombre As System.Windows.Forms.TextBox
    Friend WithEvents cbxPartido As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxFirma As System.Windows.Forms.PictureBox
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO_CUIDADANOS_RESPALDAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFOLIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAGINA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHUELLA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIGUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBSERVACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ImagenesFirmaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImagenesFirmaTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.ImagenesFirmaTableAdapter
End Class
