<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmConCandidatos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbxEstado = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbxCargo = New System.Windows.Forms.ComboBox
        Me.IMFK1CARGOSELECTIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NivelesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSConsultas = New Inscripcion_de_Moviemientos.DSConsultas
        Me.cbxNivel = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbxMovimiento = New System.Windows.Forms.ComboBox
        Me.IMFK1MOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxMunicipio = New System.Windows.Forms.ComboBox
        Me.IMFK1MUNICIPIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxDepartamento = New System.Windows.Forms.ComboBox
        Me.cbxPartido = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtIdentidad = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnFiltro = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.IMVCANDIDATOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_V_CANDIDATOSTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.IM_V_CANDIDATOSTableAdapter
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIDENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAPELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_NIVEL_ELECTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNIVEL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CARGO_ELECTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCARGO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PartidosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.PartidosTableAdapter
        Me.MovimientosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MovimientosTableAdapter
        Me.DepartamentosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.DepartamentosTableAdapter
        Me.MunicipiosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MunicipiosTableAdapter
        Me.NivelesTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.NivelesTableAdapter
        Me.CargosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.CargosTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.IMFK1CARGOSELECTIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NivelesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMFK1MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMFK1MUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.IMVCANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbxEstado)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbxCargo)
        Me.GroupBox1.Controls.Add(Me.cbxNivel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbxMovimiento)
        Me.GroupBox1.Controls.Add(Me.cbxMunicipio)
        Me.GroupBox1.Controls.Add(Me.cbxDepartamento)
        Me.GroupBox1.Controls.Add(Me.cbxPartido)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 162)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(539, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Estado"
        '
        'cbxEstado
        '
        Me.cbxEstado.DisplayMember = "DESCRIPCION"
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Items.AddRange(New Object() {"{SELECCIONE UN ESTADO}", "HABILITADO", "INHABILITADO"})
        Me.cbxEstado.Location = New System.Drawing.Point(581, 128)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(275, 21)
        Me.cbxEstado.TabIndex = 36
        Me.cbxEstado.ValueMember = "CODIGO_DEPARTAMENTO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(539, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Cargo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(545, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Nivel"
        '
        'cbxCargo
        '
        Me.cbxCargo.DataSource = Me.IMFK1CARGOSELECTIVOSBindingSource
        Me.cbxCargo.DisplayMember = "DESCRIPCION"
        Me.cbxCargo.FormattingEnabled = True
        Me.cbxCargo.Location = New System.Drawing.Point(581, 101)
        Me.cbxCargo.Name = "cbxCargo"
        Me.cbxCargo.Size = New System.Drawing.Size(275, 21)
        Me.cbxCargo.TabIndex = 33
        Me.cbxCargo.ValueMember = "CODIGO_CARGO_ELECTIVO"
        '
        'IMFK1CARGOSELECTIVOSBindingSource
        '
        Me.IMFK1CARGOSELECTIVOSBindingSource.DataMember = "IM_FK1_CARGOS_ELECTIVOS"
        Me.IMFK1CARGOSELECTIVOSBindingSource.DataSource = Me.NivelesBindingSource
        '
        'NivelesBindingSource
        '
        Me.NivelesBindingSource.DataMember = "Niveles"
        Me.NivelesBindingSource.DataSource = Me.DSConsultas
        '
        'DSConsultas
        '
        Me.DSConsultas.DataSetName = "DSConsultas"
        Me.DSConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxNivel
        '
        Me.cbxNivel.DataSource = Me.NivelesBindingSource
        Me.cbxNivel.DisplayMember = "DESCRIPCION"
        Me.cbxNivel.FormattingEnabled = True
        Me.cbxNivel.Location = New System.Drawing.Point(581, 74)
        Me.cbxNivel.Name = "cbxNivel"
        Me.cbxNivel.Size = New System.Drawing.Size(275, 21)
        Me.cbxNivel.TabIndex = 32
        Me.cbxNivel.ValueMember = "CODIGO_NIVEL_ELECTIVO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Partido"
        '
        'cbxMovimiento
        '
        Me.cbxMovimiento.DataSource = Me.IMFK1MOVIMIENTOSBindingSource
        Me.cbxMovimiento.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.cbxMovimiento.FormattingEnabled = True
        Me.cbxMovimiento.Location = New System.Drawing.Point(106, 128)
        Me.cbxMovimiento.Name = "cbxMovimiento"
        Me.cbxMovimiento.Size = New System.Drawing.Size(361, 21)
        Me.cbxMovimiento.TabIndex = 28
        Me.cbxMovimiento.ValueMember = "CODIGO_MOVIMIENTO"
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
        'cbxMunicipio
        '
        Me.cbxMunicipio.DataSource = Me.IMFK1MUNICIPIOBindingSource
        Me.cbxMunicipio.DisplayMember = "DESCRIPCION"
        Me.cbxMunicipio.FormattingEnabled = True
        Me.cbxMunicipio.Location = New System.Drawing.Point(581, 47)
        Me.cbxMunicipio.Name = "cbxMunicipio"
        Me.cbxMunicipio.Size = New System.Drawing.Size(275, 21)
        Me.cbxMunicipio.TabIndex = 30
        Me.cbxMunicipio.ValueMember = "CODIGO_MUNICIPIO"
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
        'cbxDepartamento
        '
        Me.cbxDepartamento.DataSource = Me.DepartamentosBindingSource
        Me.cbxDepartamento.DisplayMember = "DESCRIPCION"
        Me.cbxDepartamento.FormattingEnabled = True
        Me.cbxDepartamento.Location = New System.Drawing.Point(581, 20)
        Me.cbxDepartamento.Name = "cbxDepartamento"
        Me.cbxDepartamento.Size = New System.Drawing.Size(275, 21)
        Me.cbxDepartamento.TabIndex = 29
        Me.cbxDepartamento.ValueMember = "CODIGO_DEPARTAMENTO"
        '
        'cbxPartido
        '
        Me.cbxPartido.DataSource = Me.PartidosBindingSource
        Me.cbxPartido.DisplayMember = "NOMBRE"
        Me.cbxPartido.FormattingEnabled = True
        Me.cbxPartido.Location = New System.Drawing.Point(106, 101)
        Me.cbxPartido.Name = "cbxPartido"
        Me.cbxPartido.Size = New System.Drawing.Size(361, 21)
        Me.cbxPartido.TabIndex = 27
        Me.cbxPartido.ValueMember = "CODIGO_PARTIDO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Movimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(525, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Municipio"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(106, 20)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(361, 21)
        Me.txtIdentidad.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "No. Identidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(106, 74)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(361, 21)
        Me.txtApellido.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(499, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Departamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombres"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(106, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(361, 21)
        Me.txtNombre.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFiltro)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(248, 64)
        Me.FlowLayoutPanel1.TabIndex = 16
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
        'IMVCANDIDATOSBindingSource
        '
        Me.IMVCANDIDATOSBindingSource.DataMember = "IM_V_CANDIDATOS"
        Me.IMVCANDIDATOSBindingSource.DataSource = Me.DSConsultas
        '
        'IM_V_CANDIDATOSTableAdapter
        '
        Me.IM_V_CANDIDATOSTableAdapter.ClearBeforeFill = True
        '
        'GCBusqueda
        '
        Me.GCBusqueda.DataSource = Me.IMVCANDIDATOSBindingSource
        Me.GCBusqueda.Location = New System.Drawing.Point(12, 250)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.Size = New System.Drawing.Size(1038, 462)
        Me.GCBusqueda.TabIndex = 18
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_PARTIDO, Me.colPARTIDO, Me.colCODIGO_MOVIMIENTO, Me.colMOVIMIENTO, Me.colCODIGO, Me.colIDENTIDAD, Me.colNOMBRE, Me.colAPELLIDO, Me.colCODIGO_DEPARTAMENTO, Me.colDEPARTAMENTO, Me.colCODIGO_MUNICIPIO, Me.colMUNICIPIO, Me.colCODIGO_NIVEL_ELECTIVO, Me.colNIVEL, Me.colCODIGO_CARGO_ELECTIVO, Me.colCARGO, Me.colESTADO})
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
        'colCODIGO_PARTIDO
        '
        Me.colCODIGO_PARTIDO.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Name = "colCODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.OptionsColumn.AllowEdit = False
        Me.colCODIGO_PARTIDO.OptionsColumn.AllowFocus = False
        Me.colCODIGO_PARTIDO.OptionsColumn.TabStop = False
        '
        'colPARTIDO
        '
        Me.colPARTIDO.FieldName = "PARTIDO"
        Me.colPARTIDO.Name = "colPARTIDO"
        Me.colPARTIDO.OptionsColumn.AllowEdit = False
        Me.colPARTIDO.OptionsColumn.AllowFocus = False
        Me.colPARTIDO.OptionsColumn.TabStop = False
        Me.colPARTIDO.Visible = True
        Me.colPARTIDO.VisibleIndex = 0
        '
        'colCODIGO_MOVIMIENTO
        '
        Me.colCODIGO_MOVIMIENTO.FieldName = "CODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO.Name = "colCODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO.OptionsColumn.AllowEdit = False
        Me.colCODIGO_MOVIMIENTO.OptionsColumn.AllowFocus = False
        Me.colCODIGO_MOVIMIENTO.OptionsColumn.TabStop = False
        '
        'colMOVIMIENTO
        '
        Me.colMOVIMIENTO.FieldName = "MOVIMIENTO"
        Me.colMOVIMIENTO.Name = "colMOVIMIENTO"
        Me.colMOVIMIENTO.OptionsColumn.AllowEdit = False
        Me.colMOVIMIENTO.OptionsColumn.AllowFocus = False
        Me.colMOVIMIENTO.OptionsColumn.TabStop = False
        Me.colMOVIMIENTO.Visible = True
        Me.colMOVIMIENTO.VisibleIndex = 1
        '
        'colCODIGO
        '
        Me.colCODIGO.FieldName = "CODIGO"
        Me.colCODIGO.Name = "colCODIGO"
        Me.colCODIGO.OptionsColumn.AllowEdit = False
        Me.colCODIGO.OptionsColumn.AllowFocus = False
        Me.colCODIGO.OptionsColumn.TabStop = False
        Me.colCODIGO.Visible = True
        Me.colCODIGO.VisibleIndex = 2
        '
        'colIDENTIDAD
        '
        Me.colIDENTIDAD.FieldName = "IDENTIDAD"
        Me.colIDENTIDAD.Name = "colIDENTIDAD"
        Me.colIDENTIDAD.OptionsColumn.AllowEdit = False
        Me.colIDENTIDAD.OptionsColumn.AllowFocus = False
        Me.colIDENTIDAD.OptionsColumn.TabStop = False
        Me.colIDENTIDAD.Visible = True
        Me.colIDENTIDAD.VisibleIndex = 3
        '
        'colNOMBRE
        '
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.OptionsColumn.AllowEdit = False
        Me.colNOMBRE.OptionsColumn.AllowFocus = False
        Me.colNOMBRE.OptionsColumn.TabStop = False
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 4
        '
        'colAPELLIDO
        '
        Me.colAPELLIDO.FieldName = "APELLIDO"
        Me.colAPELLIDO.Name = "colAPELLIDO"
        Me.colAPELLIDO.OptionsColumn.AllowEdit = False
        Me.colAPELLIDO.OptionsColumn.AllowFocus = False
        Me.colAPELLIDO.OptionsColumn.TabStop = False
        Me.colAPELLIDO.Visible = True
        Me.colAPELLIDO.VisibleIndex = 5
        '
        'colCODIGO_DEPARTAMENTO
        '
        Me.colCODIGO_DEPARTAMENTO.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Name = "colCODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.OptionsColumn.AllowEdit = False
        Me.colCODIGO_DEPARTAMENTO.OptionsColumn.AllowFocus = False
        Me.colCODIGO_DEPARTAMENTO.OptionsColumn.TabStop = False
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.OptionsColumn.AllowEdit = False
        Me.colDEPARTAMENTO.OptionsColumn.AllowFocus = False
        Me.colDEPARTAMENTO.OptionsColumn.TabStop = False
        Me.colDEPARTAMENTO.Visible = True
        Me.colDEPARTAMENTO.VisibleIndex = 6
        '
        'colCODIGO_MUNICIPIO
        '
        Me.colCODIGO_MUNICIPIO.FieldName = "CODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Name = "colCODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.OptionsColumn.AllowEdit = False
        Me.colCODIGO_MUNICIPIO.OptionsColumn.AllowFocus = False
        Me.colCODIGO_MUNICIPIO.OptionsColumn.TabStop = False
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.FieldName = "MUNICIPIO"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.OptionsColumn.AllowEdit = False
        Me.colMUNICIPIO.OptionsColumn.AllowFocus = False
        Me.colMUNICIPIO.OptionsColumn.TabStop = False
        Me.colMUNICIPIO.Visible = True
        Me.colMUNICIPIO.VisibleIndex = 7
        '
        'colCODIGO_NIVEL_ELECTIVO
        '
        Me.colCODIGO_NIVEL_ELECTIVO.FieldName = "CODIGO_NIVEL_ELECTIVO"
        Me.colCODIGO_NIVEL_ELECTIVO.Name = "colCODIGO_NIVEL_ELECTIVO"
        Me.colCODIGO_NIVEL_ELECTIVO.OptionsColumn.AllowEdit = False
        Me.colCODIGO_NIVEL_ELECTIVO.OptionsColumn.AllowFocus = False
        Me.colCODIGO_NIVEL_ELECTIVO.OptionsColumn.TabStop = False
        '
        'colNIVEL
        '
        Me.colNIVEL.FieldName = "NIVEL"
        Me.colNIVEL.Name = "colNIVEL"
        Me.colNIVEL.OptionsColumn.AllowEdit = False
        Me.colNIVEL.OptionsColumn.AllowFocus = False
        Me.colNIVEL.OptionsColumn.TabStop = False
        Me.colNIVEL.Visible = True
        Me.colNIVEL.VisibleIndex = 8
        '
        'colCODIGO_CARGO_ELECTIVO
        '
        Me.colCODIGO_CARGO_ELECTIVO.FieldName = "CODIGO_CARGO_ELECTIVO"
        Me.colCODIGO_CARGO_ELECTIVO.Name = "colCODIGO_CARGO_ELECTIVO"
        Me.colCODIGO_CARGO_ELECTIVO.OptionsColumn.AllowEdit = False
        Me.colCODIGO_CARGO_ELECTIVO.OptionsColumn.AllowFocus = False
        Me.colCODIGO_CARGO_ELECTIVO.OptionsColumn.TabStop = False
        '
        'colCARGO
        '
        Me.colCARGO.FieldName = "CARGO"
        Me.colCARGO.Name = "colCARGO"
        Me.colCARGO.OptionsColumn.AllowEdit = False
        Me.colCARGO.OptionsColumn.AllowFocus = False
        Me.colCARGO.OptionsColumn.TabStop = False
        Me.colCARGO.Visible = True
        Me.colCARGO.VisibleIndex = 9
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.OptionsColumn.AllowEdit = False
        Me.colESTADO.OptionsColumn.AllowFocus = False
        Me.colESTADO.OptionsColumn.TabStop = False
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 10
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'PartidosTableAdapter
        '
        Me.PartidosTableAdapter.ClearBeforeFill = True
        '
        'MovimientosTableAdapter
        '
        Me.MovimientosTableAdapter.ClearBeforeFill = True
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'MunicipiosTableAdapter
        '
        Me.MunicipiosTableAdapter.ClearBeforeFill = True
        '
        'NivelesTableAdapter
        '
        Me.NivelesTableAdapter.ClearBeforeFill = True
        '
        'CargosTableAdapter
        '
        Me.CargosTableAdapter.ClearBeforeFill = True
        '
        'XfrmConCandidatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 724)
        Me.Controls.Add(Me.GCBusqueda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "XfrmConCandidatos"
        Me.Text = "XfrmConCandidatos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IMFK1CARGOSELECTIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NivelesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMFK1MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMFK1MUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.IMVCANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdentidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnFiltro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DSConsultas As Inscripcion_de_Moviemientos.DSConsultas
    Friend WithEvents IMVCANDIDATOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_V_CANDIDATOSTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.IM_V_CANDIDATOSTableAdapter
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_NIVEL_ELECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIVEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CARGO_ELECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbxMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents cbxMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPartido As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxCargo As System.Windows.Forms.ComboBox
    Friend WithEvents cbxNivel As System.Windows.Forms.ComboBox
    Friend WithEvents PartidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartidosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.PartidosTableAdapter
    Friend WithEvents IMFK1MOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MovimientosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MovimientosTableAdapter
    Friend WithEvents DepartamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartamentosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.DepartamentosTableAdapter
    Friend WithEvents IMFK1MUNICIPIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MunicipiosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MunicipiosTableAdapter
    Friend WithEvents NivelesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NivelesTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.NivelesTableAdapter
    Friend WithEvents IMFK1CARGOSELECTIVOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CargosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.CargosTableAdapter
End Class
