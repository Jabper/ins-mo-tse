<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmValidarFirmas
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
        Me.IMVVALIDARFIRMASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSConsultas = New Inscripcion_de_Moviemientos.DSConsultas
        Me.IMFK1MOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMFK1MUNICIPIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImagenesFirmaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartidosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.PartidosTableAdapter
        Me.MovimientosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MovimientosTableAdapter
        Me.DepartamentosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.DepartamentosTableAdapter
        Me.MunicipiosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MunicipiosTableAdapter
        Me.IM_V_VALIDAR_FIRMASTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.IM_V_VALIDAR_FIRMASTableAdapter
        Me.ImagenesFirmaTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.ImagenesFirmaTableAdapter
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.pbxFirma = New System.Windows.Forms.PictureBox
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIDENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIMER_NOMBRE_PAPELETA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colHUELLA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDIRECCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIGUAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFOLIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPAGINA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOBSERVACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colVALIDADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colMAQUINA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CUIDADANOS_RESPALDAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.navFiltro = New DevExpress.XtraEditors.DataNavigator
        Me.NavegacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPagina = New System.Windows.Forms.TextBox
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbxMovimiento = New System.Windows.Forms.ComboBox
        Me.cbxMunicipio = New System.Windows.Forms.ComboBox
        Me.cbxDepartamento = New System.Windows.Forms.ComboBox
        Me.cbxPartido = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnFiltro = New DevExpress.XtraEditors.SimpleButton
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.NavegacionTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.NavegacionTableAdapter
        CType(Me.IMVVALIDARFIRMASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMFK1MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMFK1MUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenesFirmaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbxFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NavegacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IMVVALIDARFIRMASBindingSource
        '
        Me.IMVVALIDARFIRMASBindingSource.DataMember = "IM_V_VALIDAR_FIRMAS"
        Me.IMVVALIDARFIRMASBindingSource.DataSource = Me.DSConsultas
        '
        'DSConsultas
        '
        Me.DSConsultas.DataSetName = "DSConsultas"
        Me.DSConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ImagenesFirmaBindingSource
        '
        Me.ImagenesFirmaBindingSource.DataMember = "ImagenesFirma"
        Me.ImagenesFirmaBindingSource.DataSource = Me.DSConsultas
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
        'IM_V_VALIDAR_FIRMASTableAdapter
        '
        Me.IM_V_VALIDAR_FIRMASTableAdapter.ClearBeforeFill = True
        '
        'ImagenesFirmaTableAdapter
        '
        Me.ImagenesFirmaTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 240)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(294, 477)
        Me.FlowLayoutPanel3.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pbxFirma)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 416)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Firmas"
        '
        'pbxFirma
        '
        Me.pbxFirma.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ImagenesFirmaBindingSource, "IMAGEN", True))
        Me.pbxFirma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxFirma.Location = New System.Drawing.Point(3, 17)
        Me.pbxFirma.Name = "pbxFirma"
        Me.pbxFirma.Size = New System.Drawing.Size(283, 396)
        Me.pbxFirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFirma.TabIndex = 0
        Me.pbxFirma.TabStop = False
        '
        'GCBusqueda
        '
        Me.GCBusqueda.DataSource = Me.IMVVALIDARFIRMASBindingSource
        Me.GCBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCBusqueda.Location = New System.Drawing.Point(294, 240)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit, Me.RepositoryItemCheckEdit1, Me.RepositoryItemMemoEdit1})
        Me.GCBusqueda.Size = New System.Drawing.Size(990, 477)
        Me.GCBusqueda.TabIndex = 26
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 50
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDENTIDAD, Me.colPRIMER_NOMBRE_PAPELETA, Me.colFIRMA, Me.colHUELLA, Me.colDIRECCION, Me.colIGUAL, Me.colFOLIO, Me.colPAGINA, Me.colOBSERVACION, Me.colVALIDADO, Me.colMAQUINA, Me.colCODIGO_CUIDADANOS_RESPALDAN, Me.colCODIGO_PARTIDO, Me.colCODIGO_MOVIMIENTO, Me.colCODIGO_DEPARTAMENTO, Me.colCODIGO_MUNICIPIO})
        Me.GridView1.GridControl = Me.GCBusqueda
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIDENTIDAD
        '
        Me.colIDENTIDAD.Caption = "Identidad"
        Me.colIDENTIDAD.FieldName = "IDENTIDAD"
        Me.colIDENTIDAD.Name = "colIDENTIDAD"
        Me.colIDENTIDAD.OptionsColumn.AllowEdit = False
        Me.colIDENTIDAD.OptionsColumn.AllowFocus = False
        Me.colIDENTIDAD.OptionsColumn.ReadOnly = True
        Me.colIDENTIDAD.OptionsColumn.TabStop = False
        Me.colIDENTIDAD.Visible = True
        Me.colIDENTIDAD.VisibleIndex = 0
        Me.colIDENTIDAD.Width = 96
        '
        'colPRIMER_NOMBRE_PAPELETA
        '
        Me.colPRIMER_NOMBRE_PAPELETA.Caption = "Nombre Completo"
        Me.colPRIMER_NOMBRE_PAPELETA.FieldName = "PRIMER_NOMBRE_PAPELETA"
        Me.colPRIMER_NOMBRE_PAPELETA.Name = "colPRIMER_NOMBRE_PAPELETA"
        Me.colPRIMER_NOMBRE_PAPELETA.OptionsColumn.AllowEdit = False
        Me.colPRIMER_NOMBRE_PAPELETA.OptionsColumn.AllowFocus = False
        Me.colPRIMER_NOMBRE_PAPELETA.OptionsColumn.ReadOnly = True
        Me.colPRIMER_NOMBRE_PAPELETA.OptionsColumn.TabStop = False
        Me.colPRIMER_NOMBRE_PAPELETA.Visible = True
        Me.colPRIMER_NOMBRE_PAPELETA.VisibleIndex = 1
        Me.colPRIMER_NOMBRE_PAPELETA.Width = 195
        '
        'colFIRMA
        '
        Me.colFIRMA.AppearanceHeader.Options.UseTextOptions = True
        Me.colFIRMA.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colFIRMA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFIRMA.Caption = "¿Con Firma?"
        Me.colFIRMA.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colFIRMA.FieldName = "FIRMA"
        Me.colFIRMA.Name = "colFIRMA"
        Me.colFIRMA.OptionsColumn.AllowEdit = False
        Me.colFIRMA.OptionsColumn.AllowFocus = False
        Me.colFIRMA.OptionsColumn.ReadOnly = True
        Me.colFIRMA.OptionsColumn.TabStop = False
        Me.colFIRMA.Visible = True
        Me.colFIRMA.VisibleIndex = 2
        Me.colFIRMA.Width = 65
        '
        'RepositoryItemCheckEdit
        '
        Me.RepositoryItemCheckEdit.AutoHeight = False
        Me.RepositoryItemCheckEdit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit.Name = "RepositoryItemCheckEdit"
        Me.RepositoryItemCheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit.PictureChecked = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.Ok
        Me.RepositoryItemCheckEdit.PictureGrayed = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.errorIcon
        Me.RepositoryItemCheckEdit.PictureUnchecked = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.errorIcon
        Me.RepositoryItemCheckEdit.ValueChecked = "S"
        Me.RepositoryItemCheckEdit.ValueGrayed = "N"
        Me.RepositoryItemCheckEdit.ValueUnchecked = "N"
        '
        'colHUELLA
        '
        Me.colHUELLA.AppearanceHeader.Options.UseTextOptions = True
        Me.colHUELLA.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colHUELLA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colHUELLA.Caption = "¿Con Huella?"
        Me.colHUELLA.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colHUELLA.FieldName = "HUELLA"
        Me.colHUELLA.Name = "colHUELLA"
        Me.colHUELLA.OptionsColumn.AllowEdit = False
        Me.colHUELLA.OptionsColumn.AllowFocus = False
        Me.colHUELLA.OptionsColumn.ReadOnly = True
        Me.colHUELLA.OptionsColumn.TabStop = False
        Me.colHUELLA.Visible = True
        Me.colHUELLA.VisibleIndex = 3
        Me.colHUELLA.Width = 65
        '
        'colDIRECCION
        '
        Me.colDIRECCION.AppearanceHeader.Options.UseTextOptions = True
        Me.colDIRECCION.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colDIRECCION.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDIRECCION.Caption = "¿Con Dirección?"
        Me.colDIRECCION.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        Me.colDIRECCION.OptionsColumn.AllowEdit = False
        Me.colDIRECCION.OptionsColumn.AllowFocus = False
        Me.colDIRECCION.OptionsColumn.ReadOnly = True
        Me.colDIRECCION.OptionsColumn.TabStop = False
        Me.colDIRECCION.Visible = True
        Me.colDIRECCION.VisibleIndex = 4
        Me.colDIRECCION.Width = 65
        '
        'colIGUAL
        '
        Me.colIGUAL.AppearanceHeader.Options.UseTextOptions = True
        Me.colIGUAL.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colIGUAL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIGUAL.Caption = "¿Nombre Igual al Censo?"
        Me.colIGUAL.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colIGUAL.FieldName = "IGUAL"
        Me.colIGUAL.Name = "colIGUAL"
        Me.colIGUAL.OptionsColumn.AllowEdit = False
        Me.colIGUAL.OptionsColumn.AllowFocus = False
        Me.colIGUAL.OptionsColumn.ReadOnly = True
        Me.colIGUAL.OptionsColumn.TabStop = False
        Me.colIGUAL.Visible = True
        Me.colIGUAL.VisibleIndex = 5
        Me.colIGUAL.Width = 65
        '
        'colFOLIO
        '
        Me.colFOLIO.Caption = "Folio"
        Me.colFOLIO.FieldName = "FOLIO"
        Me.colFOLIO.Name = "colFOLIO"
        Me.colFOLIO.OptionsColumn.AllowEdit = False
        Me.colFOLIO.OptionsColumn.AllowFocus = False
        Me.colFOLIO.OptionsColumn.ReadOnly = True
        Me.colFOLIO.OptionsColumn.TabStop = False
        Me.colFOLIO.Visible = True
        Me.colFOLIO.VisibleIndex = 6
        Me.colFOLIO.Width = 50
        '
        'colPAGINA
        '
        Me.colPAGINA.Caption = "Página"
        Me.colPAGINA.FieldName = "PAGINA"
        Me.colPAGINA.Name = "colPAGINA"
        Me.colPAGINA.OptionsColumn.AllowEdit = False
        Me.colPAGINA.OptionsColumn.AllowFocus = False
        Me.colPAGINA.OptionsColumn.ReadOnly = True
        Me.colPAGINA.OptionsColumn.TabStop = False
        Me.colPAGINA.Visible = True
        Me.colPAGINA.VisibleIndex = 7
        Me.colPAGINA.Width = 50
        '
        'colOBSERVACION
        '
        Me.colOBSERVACION.AppearanceCell.Options.UseTextOptions = True
        Me.colOBSERVACION.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.colOBSERVACION.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOBSERVACION.Caption = "Observación"
        Me.colOBSERVACION.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colOBSERVACION.FieldName = "OBSERVACION"
        Me.colOBSERVACION.Name = "colOBSERVACION"
        Me.colOBSERVACION.OptionsColumn.AllowEdit = False
        Me.colOBSERVACION.OptionsColumn.AllowFocus = False
        Me.colOBSERVACION.OptionsColumn.ReadOnly = True
        Me.colOBSERVACION.OptionsColumn.TabStop = False
        Me.colOBSERVACION.Visible = True
        Me.colOBSERVACION.VisibleIndex = 8
        Me.colOBSERVACION.Width = 360
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colVALIDADO
        '
        Me.colVALIDADO.Caption = "¿Validado?"
        Me.colVALIDADO.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colVALIDADO.FieldName = "VALIDADO"
        Me.colVALIDADO.Name = "colVALIDADO"
        Me.colVALIDADO.Visible = True
        Me.colVALIDADO.VisibleIndex = 9
        Me.colVALIDADO.Width = 60
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueChecked = "S"
        Me.RepositoryItemCheckEdit1.ValueGrayed = "N"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'colMAQUINA
        '
        Me.colMAQUINA.FieldName = "MAQUINA"
        Me.colMAQUINA.Name = "colMAQUINA"
        '
        'colCODIGO_CUIDADANOS_RESPALDAN
        '
        Me.colCODIGO_CUIDADANOS_RESPALDAN.FieldName = "CODIGO_CUIDADANOS_RESPALDAN"
        Me.colCODIGO_CUIDADANOS_RESPALDAN.Name = "colCODIGO_CUIDADANOS_RESPALDAN"
        '
        'colCODIGO_PARTIDO
        '
        Me.colCODIGO_PARTIDO.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Name = "colCODIGO_PARTIDO"
        '
        'colCODIGO_MOVIMIENTO
        '
        Me.colCODIGO_MOVIMIENTO.FieldName = "CODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO.Name = "colCODIGO_MOVIMIENTO"
        '
        'colCODIGO_DEPARTAMENTO
        '
        Me.colCODIGO_DEPARTAMENTO.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Name = "colCODIGO_DEPARTAMENTO"
        '
        'colCODIGO_MUNICIPIO
        '
        Me.colCODIGO_MUNICIPIO.FieldName = "CODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Name = "colCODIGO_MUNICIPIO"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.navFiltro)
        Me.GroupBox1.Controls.Add(Me.txtPagina)
        Me.GroupBox1.Controls.Add(Me.txtFolio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbxMovimiento)
        Me.GroupBox1.Controls.Add(Me.cbxMunicipio)
        Me.GroupBox1.Controls.Add(Me.cbxDepartamento)
        Me.GroupBox1.Controls.Add(Me.cbxPartido)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 162)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'navFiltro
        '
        Me.navFiltro.Buttons.Append.Visible = False
        Me.navFiltro.Buttons.CancelEdit.Visible = False
        Me.navFiltro.Buttons.EndEdit.Visible = False
        Me.navFiltro.Buttons.NextPage.Visible = False
        Me.navFiltro.Buttons.PrevPage.Visible = False
        Me.navFiltro.Buttons.Remove.Visible = False
        Me.navFiltro.DataSource = Me.NavegacionBindingSource
        Me.navFiltro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.navFiltro.Location = New System.Drawing.Point(3, 137)
        Me.navFiltro.Name = "navFiltro"
        Me.navFiltro.Size = New System.Drawing.Size(622, 22)
        Me.navFiltro.TabIndex = 37
        Me.navFiltro.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.navFiltro.TextStringFormat = "{0} de {1}"
        '
        'NavegacionBindingSource
        '
        Me.NavegacionBindingSource.DataMember = "Navegacion"
        Me.NavegacionBindingSource.DataSource = Me.DSConsultas
        '
        'txtPagina
        '
        Me.txtPagina.Location = New System.Drawing.Point(483, 104)
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPagina.Size = New System.Drawing.Size(119, 21)
        Me.txtPagina.TabIndex = 8
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(483, 77)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFolio.Size = New System.Drawing.Size(119, 21)
        Me.txtFolio.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(450, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Folio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(440, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Página"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Partido"
        '
        'cbxMovimiento
        '
        Me.cbxMovimiento.DataSource = Me.IMFK1MOVIMIENTOSBindingSource
        Me.cbxMovimiento.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.cbxMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMovimiento.FormattingEnabled = True
        Me.cbxMovimiento.Location = New System.Drawing.Point(109, 50)
        Me.cbxMovimiento.Name = "cbxMovimiento"
        Me.cbxMovimiento.Size = New System.Drawing.Size(302, 21)
        Me.cbxMovimiento.TabIndex = 4
        Me.cbxMovimiento.ValueMember = "CODIGO_MOVIMIENTO"
        '
        'cbxMunicipio
        '
        Me.cbxMunicipio.DataSource = Me.IMFK1MUNICIPIOBindingSource
        Me.cbxMunicipio.DisplayMember = "DESCRIPCION"
        Me.cbxMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMunicipio.FormattingEnabled = True
        Me.cbxMunicipio.Location = New System.Drawing.Point(109, 104)
        Me.cbxMunicipio.Name = "cbxMunicipio"
        Me.cbxMunicipio.Size = New System.Drawing.Size(302, 21)
        Me.cbxMunicipio.TabIndex = 6
        Me.cbxMunicipio.ValueMember = "CODIGO_MUNICIPIO"
        '
        'cbxDepartamento
        '
        Me.cbxDepartamento.DataSource = Me.DepartamentosBindingSource
        Me.cbxDepartamento.DisplayMember = "DESCRIPCION"
        Me.cbxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDepartamento.FormattingEnabled = True
        Me.cbxDepartamento.Location = New System.Drawing.Point(109, 77)
        Me.cbxDepartamento.Name = "cbxDepartamento"
        Me.cbxDepartamento.Size = New System.Drawing.Size(302, 21)
        Me.cbxDepartamento.TabIndex = 5
        Me.cbxDepartamento.ValueMember = "CODIGO_DEPARTAMENTO"
        '
        'cbxPartido
        '
        Me.cbxPartido.DataSource = Me.PartidosBindingSource
        Me.cbxPartido.DisplayMember = "NOMBRE"
        Me.cbxPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPartido.FormattingEnabled = True
        Me.cbxPartido.Location = New System.Drawing.Point(109, 23)
        Me.cbxPartido.Name = "cbxPartido"
        Me.cbxPartido.Size = New System.Drawing.Size(302, 21)
        Me.cbxPartido.TabIndex = 3
        Me.cbxPartido.ValueMember = "CODIGO_PARTIDO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Movimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Municipio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Departamento"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFiltro)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1600, 64)
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
        Me.btnFiltro.TabIndex = 0
        Me.btnFiltro.TabStop = False
        Me.btnFiltro.Text = "Filtrar"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.guardar1
        Me.BtnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(64, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 55)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.btnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(125, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(55, 55)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.TabStop = False
        Me.btnSalir.Text = "Salir"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1284, 240)
        Me.FlowLayoutPanel2.TabIndex = 24
        '
        'NavegacionTableAdapter
        '
        Me.NavegacionTableAdapter.ClearBeforeFill = True
        '
        'XfrmValidarFirmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 717)
        Me.Controls.Add(Me.GCBusqueda)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Name = "XfrmValidarFirmas"
        Me.Text = "Validar Firmas"
        CType(Me.IMVVALIDARFIRMASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMFK1MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMFK1MUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenesFirmaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbxFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NavegacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSConsultas As Inscripcion_de_Moviemientos.DSConsultas
    Friend WithEvents PartidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartidosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.PartidosTableAdapter
    Friend WithEvents IMFK1MOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MovimientosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MovimientosTableAdapter
    Friend WithEvents DepartamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartamentosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.DepartamentosTableAdapter
    Friend WithEvents IMFK1MUNICIPIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MunicipiosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MunicipiosTableAdapter
    Friend WithEvents IMVVALIDARFIRMASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_V_VALIDAR_FIRMASTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.IM_V_VALIDAR_FIRMASTableAdapter
    Friend WithEvents ImagenesFirmaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImagenesFirmaTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.ImagenesFirmaTableAdapter
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_NOMBRE_PAPELETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colHUELLA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIGUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFOLIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAGINA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBSERVACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALIDADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMAQUINA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CUIDADANOS_RESPALDAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPagina As System.Windows.Forms.TextBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents cbxMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPartido As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnFiltro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxFirma As System.Windows.Forms.PictureBox
    Friend WithEvents navFiltro As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents NavegacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NavegacionTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.NavegacionTableAdapter
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
