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
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFOTOGRAFIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPictureEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.colCONSTANCIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPOSICION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIDENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIMER_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSEGUNDO_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIMER_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSEGUNDO_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colREC1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colREC2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colREC3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colREC4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colREC5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colREC6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colREC7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colREC8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colREC9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVALIDADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colCODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_NIVEL_ELECTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CARGO_ELECTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CANDIDATOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnFiltro = New DevExpress.XtraEditors.SimpleButton
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnUltimo = New System.Windows.Forms.Button
        Me.btnSiguiente = New System.Windows.Forms.Button
        Me.btnAnterior = New System.Windows.Forms.Button
        Me.btnPrimero = New System.Windows.Forms.Button
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.pbxFirma = New System.Windows.Forms.PictureBox
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbxFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCBusqueda
        '
        Me.GCBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCBusqueda.Location = New System.Drawing.Point(0, 219)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit, Me.RepositoryItemPictureEdit, Me.RepositoryItemCheckEdit1})
        Me.GCBusqueda.Size = New System.Drawing.Size(1227, 498)
        Me.GCBusqueda.TabIndex = 23
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 50
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFOTOGRAFIA, Me.colCONSTANCIA, Me.colPOSICION, Me.colIDENTIDAD, Me.colPRIMER_NOMBRE, Me.colSEGUNDO_NOMBRE, Me.colPRIMER_APELLIDO, Me.colSEGUNDO_APELLIDO, Me.colREC1, Me.colREC2, Me.colREC3, Me.colREC4, Me.colREC5, Me.colREC6, Me.colREC7, Me.colREC8, Me.colREC9, Me.colVALIDADO, Me.colCODIGO_PARTIDO, Me.colCODIGO_MOVIMIENTO, Me.colCODIGO_NIVEL_ELECTIVO, Me.colCODIGO_CARGO_ELECTIVO, Me.colCODIGO_DEPARTAMENTO, Me.colCODIGO_MUNICIPIO, Me.colCODIGO_CANDIDATOS, Me.colESTADO})
        Me.GridView1.GridControl = Me.GCBusqueda
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 50
        '
        'colFOTOGRAFIA
        '
        Me.colFOTOGRAFIA.AppearanceHeader.Options.UseTextOptions = True
        Me.colFOTOGRAFIA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFOTOGRAFIA.Caption = "Fotografía"
        Me.colFOTOGRAFIA.ColumnEdit = Me.RepositoryItemPictureEdit
        Me.colFOTOGRAFIA.FieldName = "FOTOGRAFIA"
        Me.colFOTOGRAFIA.Name = "colFOTOGRAFIA"
        Me.colFOTOGRAFIA.OptionsColumn.AllowEdit = False
        Me.colFOTOGRAFIA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colFOTOGRAFIA.OptionsColumn.ReadOnly = True
        Me.colFOTOGRAFIA.OptionsColumn.TabStop = False
        Me.colFOTOGRAFIA.Visible = True
        Me.colFOTOGRAFIA.VisibleIndex = 0
        Me.colFOTOGRAFIA.Width = 62
        '
        'RepositoryItemPictureEdit
        '
        Me.RepositoryItemPictureEdit.Name = "RepositoryItemPictureEdit"
        Me.RepositoryItemPictureEdit.NullText = "-"
        Me.RepositoryItemPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        '
        'colCONSTANCIA
        '
        Me.colCONSTANCIA.AppearanceHeader.Options.UseTextOptions = True
        Me.colCONSTANCIA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCONSTANCIA.Caption = "Constancia"
        Me.colCONSTANCIA.ColumnEdit = Me.RepositoryItemPictureEdit
        Me.colCONSTANCIA.FieldName = "CONSTANCIA"
        Me.colCONSTANCIA.Name = "colCONSTANCIA"
        Me.colCONSTANCIA.OptionsColumn.AllowEdit = False
        Me.colCONSTANCIA.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCONSTANCIA.OptionsColumn.ReadOnly = True
        Me.colCONSTANCIA.OptionsColumn.TabStop = False
        Me.colCONSTANCIA.Visible = True
        Me.colCONSTANCIA.VisibleIndex = 1
        Me.colCONSTANCIA.Width = 62
        '
        'colPOSICION
        '
        Me.colPOSICION.Caption = "Posición"
        Me.colPOSICION.FieldName = "POSICION"
        Me.colPOSICION.Name = "colPOSICION"
        Me.colPOSICION.OptionsColumn.AllowEdit = False
        Me.colPOSICION.OptionsColumn.AllowFocus = False
        Me.colPOSICION.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPOSICION.OptionsColumn.ReadOnly = True
        Me.colPOSICION.OptionsColumn.TabStop = False
        Me.colPOSICION.Visible = True
        Me.colPOSICION.VisibleIndex = 2
        Me.colPOSICION.Width = 47
        '
        'colIDENTIDAD
        '
        Me.colIDENTIDAD.AppearanceHeader.Options.UseTextOptions = True
        Me.colIDENTIDAD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIDENTIDAD.Caption = "Identidad"
        Me.colIDENTIDAD.FieldName = "IDENTIDAD"
        Me.colIDENTIDAD.Name = "colIDENTIDAD"
        Me.colIDENTIDAD.OptionsColumn.AllowEdit = False
        Me.colIDENTIDAD.OptionsColumn.AllowFocus = False
        Me.colIDENTIDAD.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colIDENTIDAD.OptionsColumn.ReadOnly = True
        Me.colIDENTIDAD.OptionsColumn.TabStop = False
        Me.colIDENTIDAD.Visible = True
        Me.colIDENTIDAD.VisibleIndex = 3
        Me.colIDENTIDAD.Width = 91
        '
        'colPRIMER_NOMBRE
        '
        Me.colPRIMER_NOMBRE.AppearanceCell.Options.UseTextOptions = True
        Me.colPRIMER_NOMBRE.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colPRIMER_NOMBRE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPRIMER_NOMBRE.AppearanceHeader.Options.UseTextOptions = True
        Me.colPRIMER_NOMBRE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPRIMER_NOMBRE.Caption = "Primer Nombre"
        Me.colPRIMER_NOMBRE.FieldName = "PRIMER_NOMBRE"
        Me.colPRIMER_NOMBRE.Name = "colPRIMER_NOMBRE"
        Me.colPRIMER_NOMBRE.OptionsColumn.AllowEdit = False
        Me.colPRIMER_NOMBRE.OptionsColumn.AllowFocus = False
        Me.colPRIMER_NOMBRE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPRIMER_NOMBRE.OptionsColumn.ReadOnly = True
        Me.colPRIMER_NOMBRE.OptionsColumn.TabStop = False
        Me.colPRIMER_NOMBRE.Visible = True
        Me.colPRIMER_NOMBRE.VisibleIndex = 4
        '
        'colSEGUNDO_NOMBRE
        '
        Me.colSEGUNDO_NOMBRE.AppearanceCell.Options.UseTextOptions = True
        Me.colSEGUNDO_NOMBRE.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colSEGUNDO_NOMBRE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSEGUNDO_NOMBRE.AppearanceHeader.Options.UseTextOptions = True
        Me.colSEGUNDO_NOMBRE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSEGUNDO_NOMBRE.Caption = "Segundo Nombre"
        Me.colSEGUNDO_NOMBRE.FieldName = "SEGUNDO_NOMBRE"
        Me.colSEGUNDO_NOMBRE.Name = "colSEGUNDO_NOMBRE"
        Me.colSEGUNDO_NOMBRE.OptionsColumn.AllowEdit = False
        Me.colSEGUNDO_NOMBRE.OptionsColumn.AllowFocus = False
        Me.colSEGUNDO_NOMBRE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colSEGUNDO_NOMBRE.OptionsColumn.ReadOnly = True
        Me.colSEGUNDO_NOMBRE.OptionsColumn.TabStop = False
        Me.colSEGUNDO_NOMBRE.Visible = True
        Me.colSEGUNDO_NOMBRE.VisibleIndex = 5
        '
        'colPRIMER_APELLIDO
        '
        Me.colPRIMER_APELLIDO.AppearanceCell.Options.UseTextOptions = True
        Me.colPRIMER_APELLIDO.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colPRIMER_APELLIDO.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPRIMER_APELLIDO.AppearanceHeader.Options.UseTextOptions = True
        Me.colPRIMER_APELLIDO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPRIMER_APELLIDO.Caption = "Primer Apellido"
        Me.colPRIMER_APELLIDO.FieldName = "PRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.Name = "colPRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.OptionsColumn.AllowEdit = False
        Me.colPRIMER_APELLIDO.OptionsColumn.AllowFocus = False
        Me.colPRIMER_APELLIDO.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPRIMER_APELLIDO.OptionsColumn.ReadOnly = True
        Me.colPRIMER_APELLIDO.OptionsColumn.TabStop = False
        Me.colPRIMER_APELLIDO.Visible = True
        Me.colPRIMER_APELLIDO.VisibleIndex = 6
        '
        'colSEGUNDO_APELLIDO
        '
        Me.colSEGUNDO_APELLIDO.AppearanceCell.Options.UseTextOptions = True
        Me.colSEGUNDO_APELLIDO.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
        Me.colSEGUNDO_APELLIDO.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSEGUNDO_APELLIDO.AppearanceHeader.Options.UseTextOptions = True
        Me.colSEGUNDO_APELLIDO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSEGUNDO_APELLIDO.Caption = "Segundo Apellido"
        Me.colSEGUNDO_APELLIDO.FieldName = "SEGUNDO_APELLIDO"
        Me.colSEGUNDO_APELLIDO.Name = "colSEGUNDO_APELLIDO"
        Me.colSEGUNDO_APELLIDO.OptionsColumn.AllowEdit = False
        Me.colSEGUNDO_APELLIDO.OptionsColumn.AllowFocus = False
        Me.colSEGUNDO_APELLIDO.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colSEGUNDO_APELLIDO.OptionsColumn.ReadOnly = True
        Me.colSEGUNDO_APELLIDO.OptionsColumn.TabStop = False
        Me.colSEGUNDO_APELLIDO.Visible = True
        Me.colSEGUNDO_APELLIDO.VisibleIndex = 7
        '
        'colREC1
        '
        Me.colREC1.AppearanceHeader.Options.UseTextOptions = True
        Me.colREC1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colREC1.Caption = "Hondureño por Nacimiento"
        Me.colREC1.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colREC1.FieldName = "REC1"
        Me.colREC1.Name = "colREC1"
        Me.colREC1.OptionsColumn.AllowEdit = False
        Me.colREC1.OptionsColumn.AllowFocus = False
        Me.colREC1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colREC1.OptionsColumn.ReadOnly = True
        Me.colREC1.OptionsColumn.TabStop = False
        Me.colREC1.Visible = True
        Me.colREC1.VisibleIndex = 8
        Me.colREC1.Width = 60
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
        Me.RepositoryItemCheckEdit.ValueChecked = "1"
        Me.RepositoryItemCheckEdit.ValueGrayed = "0"
        Me.RepositoryItemCheckEdit.ValueUnchecked = "0"
        '
        'colREC2
        '
        Me.colREC2.AppearanceHeader.Options.UseTextOptions = True
        Me.colREC2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colREC2.Caption = "Existencia CNE"
        Me.colREC2.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colREC2.FieldName = "REC2"
        Me.colREC2.Name = "colREC2"
        Me.colREC2.OptionsColumn.AllowEdit = False
        Me.colREC2.OptionsColumn.AllowFocus = False
        Me.colREC2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colREC2.OptionsColumn.ReadOnly = True
        Me.colREC2.OptionsColumn.TabStop = False
        Me.colREC2.Visible = True
        Me.colREC2.VisibleIndex = 9
        Me.colREC2.Width = 60
        '
        'colREC3
        '
        Me.colREC3.AppearanceHeader.Options.UseTextOptions = True
        Me.colREC3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colREC3.Caption = "Nombres Apellidos Iguales CNE"
        Me.colREC3.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colREC3.FieldName = "REC3"
        Me.colREC3.Name = "colREC3"
        Me.colREC3.OptionsColumn.AllowEdit = False
        Me.colREC3.OptionsColumn.AllowFocus = False
        Me.colREC3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colREC3.OptionsColumn.ReadOnly = True
        Me.colREC3.OptionsColumn.TabStop = False
        Me.colREC3.Visible = True
        Me.colREC3.VisibleIndex = 10
        Me.colREC3.Width = 60
        '
        'colREC4
        '
        Me.colREC4.AppearanceHeader.Options.UseTextOptions = True
        Me.colREC4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colREC4.Caption = "Mayor de 18 Años"
        Me.colREC4.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colREC4.FieldName = "REC4"
        Me.colREC4.Name = "colREC4"
        Me.colREC4.OptionsColumn.AllowEdit = False
        Me.colREC4.OptionsColumn.AllowFocus = False
        Me.colREC4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colREC4.OptionsColumn.ReadOnly = True
        Me.colREC4.OptionsColumn.TabStop = False
        Me.colREC4.Visible = True
        Me.colREC4.VisibleIndex = 11
        Me.colREC4.Width = 60
        '
        'colREC5
        '
        Me.colREC5.AppearanceHeader.Options.UseTextOptions = True
        Me.colREC5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colREC5.Caption = "Mayor de 21 Años"
        Me.colREC5.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colREC5.FieldName = "REC5"
        Me.colREC5.Name = "colREC5"
        Me.colREC5.OptionsColumn.AllowEdit = False
        Me.colREC5.OptionsColumn.AllowFocus = False
        Me.colREC5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colREC5.OptionsColumn.ReadOnly = True
        Me.colREC5.OptionsColumn.TabStop = False
        Me.colREC5.Visible = True
        Me.colREC5.VisibleIndex = 12
        Me.colREC5.Width = 60
        '
        'colREC6
        '
        Me.colREC6.AppearanceHeader.Options.UseTextOptions = True
        Me.colREC6.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colREC6.Caption = "Mayor de 30 Años"
        Me.colREC6.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colREC6.FieldName = "REC6"
        Me.colREC6.Name = "colREC6"
        Me.colREC6.OptionsColumn.AllowEdit = False
        Me.colREC6.OptionsColumn.AllowFocus = False
        Me.colREC6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colREC6.OptionsColumn.ReadOnly = True
        Me.colREC6.OptionsColumn.TabStop = False
        Me.colREC6.Visible = True
        Me.colREC6.VisibleIndex = 13
        Me.colREC6.Width = 60
        '
        'colREC7
        '
        Me.colREC7.AppearanceHeader.Options.UseTextOptions = True
        Me.colREC7.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colREC7.Caption = "Fotografia Reciente"
        Me.colREC7.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colREC7.FieldName = "REC7"
        Me.colREC7.Name = "colREC7"
        Me.colREC7.OptionsColumn.AllowEdit = False
        Me.colREC7.OptionsColumn.AllowFocus = False
        Me.colREC7.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colREC7.OptionsColumn.ReadOnly = True
        Me.colREC7.OptionsColumn.TabStop = False
        Me.colREC7.Visible = True
        Me.colREC7.VisibleIndex = 14
        Me.colREC7.Width = 60
        '
        'colREC8
        '
        Me.colREC8.AppearanceHeader.Options.UseTextOptions = True
        Me.colREC8.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colREC8.Caption = "Constancia de Vecindad"
        Me.colREC8.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colREC8.FieldName = "REC8"
        Me.colREC8.Name = "colREC8"
        Me.colREC8.OptionsColumn.AllowEdit = False
        Me.colREC8.OptionsColumn.AllowFocus = False
        Me.colREC8.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colREC8.OptionsColumn.ReadOnly = True
        Me.colREC8.OptionsColumn.TabStop = False
        Me.colREC8.Visible = True
        Me.colREC8.VisibleIndex = 15
        Me.colREC8.Width = 60
        '
        'colREC9
        '
        Me.colREC9.AppearanceHeader.Options.UseTextOptions = True
        Me.colREC9.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colREC9.Caption = "Candidato no Existe en Planilla"
        Me.colREC9.ColumnEdit = Me.RepositoryItemCheckEdit
        Me.colREC9.FieldName = "REC9"
        Me.colREC9.Name = "colREC9"
        Me.colREC9.OptionsColumn.AllowEdit = False
        Me.colREC9.OptionsColumn.AllowFocus = False
        Me.colREC9.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colREC9.OptionsColumn.ReadOnly = True
        Me.colREC9.OptionsColumn.TabStop = False
        Me.colREC9.Visible = True
        Me.colREC9.VisibleIndex = 16
        Me.colREC9.Width = 60
        '
        'colVALIDADO
        '
        Me.colVALIDADO.Caption = "¿Validado?"
        Me.colVALIDADO.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colVALIDADO.FieldName = "VALIDADO"
        Me.colVALIDADO.Name = "colVALIDADO"
        Me.colVALIDADO.Visible = True
        Me.colVALIDADO.VisibleIndex = 17
        Me.colVALIDADO.Width = 58
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit1.ValueChecked = "1"
        Me.RepositoryItemCheckEdit1.ValueGrayed = "0"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "0"
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
        'colCODIGO_NIVEL_ELECTIVO
        '
        Me.colCODIGO_NIVEL_ELECTIVO.FieldName = "CODIGO_NIVEL_ELECTIVO"
        Me.colCODIGO_NIVEL_ELECTIVO.Name = "colCODIGO_NIVEL_ELECTIVO"
        '
        'colCODIGO_CARGO_ELECTIVO
        '
        Me.colCODIGO_CARGO_ELECTIVO.FieldName = "CODIGO_CARGO_ELECTIVO"
        Me.colCODIGO_CARGO_ELECTIVO.Name = "colCODIGO_CARGO_ELECTIVO"
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
        'colCODIGO_CANDIDATOS
        '
        Me.colCODIGO_CANDIDATOS.FieldName = "CODIGO_CANDIDATOS"
        Me.colCODIGO_CANDIDATOS.Name = "colCODIGO_CANDIDATOS"
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1227, 219)
        Me.FlowLayoutPanel2.TabIndex = 24
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFiltro)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1204, 64)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUltimo)
        Me.GroupBox1.Controls.Add(Me.btnSiguiente)
        Me.GroupBox1.Controls.Add(Me.btnAnterior)
        Me.GroupBox1.Controls.Add(Me.btnPrimero)
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
        Me.GroupBox1.Size = New System.Drawing.Size(628, 140)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnUltimo.Location = New System.Drawing.Point(554, 92)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(39, 33)
        Me.btnUltimo.TabIndex = 42
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSiguiente.Location = New System.Drawing.Point(514, 92)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(39, 33)
        Me.btnSiguiente.TabIndex = 41
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAnterior.Location = New System.Drawing.Point(474, 92)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(39, 33)
        Me.btnAnterior.TabIndex = 40
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPrimero.Location = New System.Drawing.Point(434, 92)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(39, 33)
        Me.btnPrimero.TabIndex = 39
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'txtPagina
        '
        Me.txtPagina.Location = New System.Drawing.Point(474, 50)
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.Size = New System.Drawing.Size(119, 21)
        Me.txtPagina.TabIndex = 38
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(474, 23)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(119, 21)
        Me.txtFolio.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(441, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Folio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(431, 53)
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
        Me.cbxMovimiento.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.cbxMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMovimiento.FormattingEnabled = True
        Me.cbxMovimiento.Location = New System.Drawing.Point(109, 50)
        Me.cbxMovimiento.Name = "cbxMovimiento"
        Me.cbxMovimiento.Size = New System.Drawing.Size(302, 21)
        Me.cbxMovimiento.TabIndex = 3
        Me.cbxMovimiento.ValueMember = "CODIGO_MOVIMIENTO"
        '
        'cbxMunicipio
        '
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
        Me.cbxPartido.DisplayMember = "NOMBRE"
        Me.cbxPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPartido.FormattingEnabled = True
        Me.cbxPartido.Location = New System.Drawing.Point(109, 23)
        Me.cbxPartido.Name = "cbxPartido"
        Me.cbxPartido.Size = New System.Drawing.Size(302, 21)
        Me.cbxPartido.TabIndex = 2
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pbxFirma)
        Me.GroupBox2.Location = New System.Drawing.Point(637, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 140)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Firma"
        '
        'pbxFirma
        '
        Me.pbxFirma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxFirma.Location = New System.Drawing.Point(3, 17)
        Me.pbxFirma.Name = "pbxFirma"
        Me.pbxFirma.Size = New System.Drawing.Size(140, 120)
        Me.pbxFirma.TabIndex = 0
        Me.pbxFirma.TabStop = False
        '
        'XfrmValidarFirmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 717)
        Me.Controls.Add(Me.GCBusqueda)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Name = "XfrmValidarFirmas"
        Me.Text = "XfrmValidarFirmas"
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbxFirma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFOTOGRAFIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colCONSTANCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOSICION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREC1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colREC2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREC3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREC4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREC5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREC6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREC7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREC8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREC9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALIDADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_NIVEL_ELECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CARGO_ELECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CANDIDATOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnFiltro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtPagina As System.Windows.Forms.TextBox
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxFirma As System.Windows.Forms.PictureBox
End Class
