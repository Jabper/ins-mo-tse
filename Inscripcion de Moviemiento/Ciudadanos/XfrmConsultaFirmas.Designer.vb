<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmConsultaFirmas
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.CmbMunicipio = New DevExpress.XtraEditors.LookUpEdit
        Me.TAMUNICIPIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDeptoMuni = New Inscripcion_de_Moviemientos.DSDeptoMuni
        Me.CmbDepartamento = New DevExpress.XtraEditors.LookUpEdit
        Me.TADEPARTAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbMovimiento = New DevExpress.XtraEditors.LookUpEdit
        Me.TAMOVIMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPolitico = New Inscripcion_de_Moviemientos.DSPolitico
        Me.CmbPartido = New DevExpress.XtraEditors.LookUpEdit
        Me.TAPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.IM_CIUDADANOS_RESPALDAN1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSCiudadanos = New Inscripcion_de_Moviemientos.DSCiudadanos
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_CUIDADANOS_RESPALDAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCONSISTENTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChkEstado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colIDENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colPRIMER_NOMBRE_PAPELETA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colSEGUNDO_NOMBRE_PAPELETA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIMER_APELLIDO_PAPELETA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSEGUNDO_APELLIDO_PAPELETA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RIChkFima = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colHUELLA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDIRECCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_IGUAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RIChkCoincide = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colOBSERVACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.colMAQUINA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPAGINA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIMAGEN_FIRMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RPIImgfirma = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.IMCIUDADANOSRESPALDANBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_CIUDADANOS_RESPALDANTableAdapter = New Inscripcion_de_Moviemientos.DSCiudadanosTableAdapters.IM_CIUDADANOS_RESPALDANTableAdapter
        Me.TA_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
        Me.TA_MOVIMIENTOTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_MOVIMIENTOTableAdapter
        Me.TA_DEPARTAMENTOSTableAdapter = New Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_DEPARTAMENTOSTableAdapter
        Me.TA_MUNICIPIOSTableAdapter = New Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_MUNICIPIOSTableAdapter
        Me.IM_CIUDADANOS_RESPALDAN1TableAdapter = New Inscripcion_de_Moviemientos.DSCiudadanosTableAdapters.IM_CIUDADANOS_RESPALDAN1TableAdapter
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDeptoMuni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TADEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbPartido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IM_CIUDADANOS_RESPALDAN1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCiudadanos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIChkFima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIChkCoincide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RPIImgfirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMCIUDADANOSRESPALDANBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.CmbMunicipio)
        Me.LayoutControl1.Controls.Add(Me.CmbDepartamento)
        Me.LayoutControl1.Controls.Add(Me.CmbMovimiento)
        Me.LayoutControl1.Controls.Add(Me.CmbPartido)
        Me.LayoutControl1.Controls.Add(Me.GCBusqueda)
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(647, 406, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(628, 439)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(448, 110)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Mostrar Solo Inconsistentes"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CheckEdit1.Size = New System.Drawing.Size(156, 19)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 14
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(448, 84)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(86, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 13
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'CmbMunicipio
        '
        Me.CmbMunicipio.Location = New System.Drawing.Point(299, 110)
        Me.CmbMunicipio.Name = "CmbMunicipio"
        Me.CmbMunicipio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMunicipio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MUNICIPIO", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Departamento", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CmbMunicipio.Properties.DataSource = Me.TAMUNICIPIOSBindingSource
        Me.CmbMunicipio.Properties.DisplayMember = "DESCRIPCION"
        Me.CmbMunicipio.Properties.NullText = "Seleccione"
        Me.CmbMunicipio.Properties.ValueMember = "CODIGO_MUNICIPIO"
        Me.CmbMunicipio.Size = New System.Drawing.Size(145, 20)
        Me.CmbMunicipio.StyleController = Me.LayoutControl1
        Me.CmbMunicipio.TabIndex = 12
        '
        'TAMUNICIPIOSBindingSource
        '
        Me.TAMUNICIPIOSBindingSource.DataMember = "TA_MUNICIPIOS"
        Me.TAMUNICIPIOSBindingSource.DataSource = Me.DSDeptoMuni
        '
        'DSDeptoMuni
        '
        Me.DSDeptoMuni.DataSetName = "DSDeptoMuni"
        Me.DSDeptoMuni.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.Location = New System.Drawing.Point(85, 110)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_DEPARTAMENTO", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Departamento", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CmbDepartamento.Properties.DataSource = Me.TADEPARTAMENTOSBindingSource
        Me.CmbDepartamento.Properties.DisplayMember = "DESCRIPCION"
        Me.CmbDepartamento.Properties.NullText = "Seleccione"
        Me.CmbDepartamento.Properties.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.CmbDepartamento.Size = New System.Drawing.Size(137, 20)
        Me.CmbDepartamento.StyleController = Me.LayoutControl1
        Me.CmbDepartamento.TabIndex = 11
        '
        'TADEPARTAMENTOSBindingSource
        '
        Me.TADEPARTAMENTOSBindingSource.DataMember = "TA_DEPARTAMENTOS"
        Me.TADEPARTAMENTOSBindingSource.DataSource = Me.DSDeptoMuni
        '
        'CmbMovimiento
        '
        Me.CmbMovimiento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TAMOVIMIENTOBindingSource, "CODIGO_MOVIMIENTO", True))
        Me.CmbMovimiento.Location = New System.Drawing.Point(299, 84)
        Me.CmbMovimiento.Name = "CmbMovimiento"
        Me.CmbMovimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMovimiento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MOVIMIENTO", "CODIGO_MOVIMIENTO", 135, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE_MOVIMIENTO", "Movimiento", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.CmbMovimiento.Properties.DataSource = Me.TAMOVIMIENTOBindingSource
        Me.CmbMovimiento.Properties.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.CmbMovimiento.Properties.NullText = "Seleccione"
        Me.CmbMovimiento.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        Me.CmbMovimiento.Size = New System.Drawing.Size(145, 20)
        Me.CmbMovimiento.StyleController = Me.LayoutControl1
        Me.CmbMovimiento.TabIndex = 10
        '
        'TAMOVIMIENTOBindingSource
        '
        Me.TAMOVIMIENTOBindingSource.DataMember = "TA_MOVIMIENTO"
        Me.TAMOVIMIENTOBindingSource.DataSource = Me.DSPolitico
        '
        'DSPolitico
        '
        Me.DSPolitico.DataSetName = "DSPolitico"
        Me.DSPolitico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbPartido
        '
        Me.CmbPartido.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TAPARTIDOSPOLITICOSBindingSource, "CODIGO_PARTIDO", True))
        Me.CmbPartido.Location = New System.Drawing.Point(85, 84)
        Me.CmbPartido.Name = "CmbPartido"
        Me.CmbPartido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbPartido.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_PARTIDO", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "Partido", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.CmbPartido.Properties.DataSource = Me.TAPARTIDOSPOLITICOSBindingSource
        Me.CmbPartido.Properties.DisplayMember = "NOMBRE"
        Me.CmbPartido.Properties.NullText = "Seleccione"
        Me.CmbPartido.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.CmbPartido.Size = New System.Drawing.Size(137, 20)
        Me.CmbPartido.StyleController = Me.LayoutControl1
        Me.CmbPartido.TabIndex = 9
        '
        'TAPARTIDOSPOLITICOSBindingSource
        '
        Me.TAPARTIDOSPOLITICOSBindingSource.DataMember = "TA_PARTIDOS_POLITICOS"
        Me.TAPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSPolitico
        '
        'GCBusqueda
        '
        Me.GCBusqueda.DataSource = Me.IM_CIUDADANOS_RESPALDAN1BindingSource
        Me.GCBusqueda.Location = New System.Drawing.Point(12, 134)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RIChkCoincide, Me.RIChkFima, Me.RPIImgfirma, Me.RepositoryItemComboBox1, Me.ChkEstado, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemMemoEdit1})
        Me.GCBusqueda.Size = New System.Drawing.Size(604, 251)
        Me.GCBusqueda.TabIndex = 8
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'IM_CIUDADANOS_RESPALDAN1BindingSource
        '
        Me.IM_CIUDADANOS_RESPALDAN1BindingSource.DataMember = "IM_CIUDADANOS_RESPALDAN1"
        Me.IM_CIUDADANOS_RESPALDAN1BindingSource.DataSource = Me.DSCiudadanos
        '
        'DSCiudadanos
        '
        Me.DSCiudadanos.DataSetName = "DSCiudadanos"
        Me.DSCiudadanos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_CUIDADANOS_RESPALDAN, Me.colCONSISTENTE, Me.colIDENTIDAD, Me.colPRIMER_NOMBRE_PAPELETA, Me.colSEGUNDO_NOMBRE_PAPELETA, Me.colPRIMER_APELLIDO_PAPELETA, Me.colSEGUNDO_APELLIDO_PAPELETA, Me.colFIRMA, Me.colHUELLA, Me.colDIRECCION, Me.colNOMBRE_IGUAL, Me.colOBSERVACION, Me.colMAQUINA, Me.colPAGINA, Me.colIMAGEN_FIRMA})
        Me.GridView1.GridControl = Me.GCBusqueda
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_IGUAL, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCODIGO_CUIDADANOS_RESPALDAN
        '
        Me.colCODIGO_CUIDADANOS_RESPALDAN.FieldName = "CODIGO_CUIDADANOS_RESPALDAN"
        Me.colCODIGO_CUIDADANOS_RESPALDAN.Name = "colCODIGO_CUIDADANOS_RESPALDAN"
        Me.colCODIGO_CUIDADANOS_RESPALDAN.OptionsColumn.AllowEdit = False
        '
        'colCONSISTENTE
        '
        Me.colCONSISTENTE.ColumnEdit = Me.ChkEstado
        Me.colCONSISTENTE.FieldName = "CONSISTENTE"
        Me.colCONSISTENTE.Name = "colCONSISTENTE"
        Me.colCONSISTENTE.OptionsColumn.AllowEdit = False
        Me.colCONSISTENTE.Visible = True
        Me.colCONSISTENTE.VisibleIndex = 0
        Me.colCONSISTENTE.Width = 94
        '
        'ChkEstado
        '
        Me.ChkEstado.AutoHeight = False
        Me.ChkEstado.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.PictureChecked = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.Ok
        Me.ChkEstado.PictureUnchecked = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.errorIcon
        Me.ChkEstado.ValueChecked = "N"
        Me.ChkEstado.ValueGrayed = "S"
        Me.ChkEstado.ValueUnchecked = "S"
        '
        'colIDENTIDAD
        '
        Me.colIDENTIDAD.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colIDENTIDAD.FieldName = "IDENTIDAD"
        Me.colIDENTIDAD.Name = "colIDENTIDAD"
        Me.colIDENTIDAD.Visible = True
        Me.colIDENTIDAD.VisibleIndex = 9
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.MaxLength = 15
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colPRIMER_NOMBRE_PAPELETA
        '
        Me.colPRIMER_NOMBRE_PAPELETA.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colPRIMER_NOMBRE_PAPELETA.FieldName = "PRIMER_NOMBRE_PAPELETA"
        Me.colPRIMER_NOMBRE_PAPELETA.Name = "colPRIMER_NOMBRE_PAPELETA"
        Me.colPRIMER_NOMBRE_PAPELETA.Visible = True
        Me.colPRIMER_NOMBRE_PAPELETA.VisibleIndex = 1
        Me.colPRIMER_NOMBRE_PAPELETA.Width = 159
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.MaxLength = 50
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colSEGUNDO_NOMBRE_PAPELETA
        '
        Me.colSEGUNDO_NOMBRE_PAPELETA.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colSEGUNDO_NOMBRE_PAPELETA.FieldName = "SEGUNDO_NOMBRE_PAPELETA"
        Me.colSEGUNDO_NOMBRE_PAPELETA.Name = "colSEGUNDO_NOMBRE_PAPELETA"
        Me.colSEGUNDO_NOMBRE_PAPELETA.Visible = True
        Me.colSEGUNDO_NOMBRE_PAPELETA.VisibleIndex = 2
        Me.colSEGUNDO_NOMBRE_PAPELETA.Width = 112
        '
        'colPRIMER_APELLIDO_PAPELETA
        '
        Me.colPRIMER_APELLIDO_PAPELETA.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colPRIMER_APELLIDO_PAPELETA.FieldName = "PRIMER_APELLIDO_PAPELETA"
        Me.colPRIMER_APELLIDO_PAPELETA.Name = "colPRIMER_APELLIDO_PAPELETA"
        Me.colPRIMER_APELLIDO_PAPELETA.Visible = True
        Me.colPRIMER_APELLIDO_PAPELETA.VisibleIndex = 3
        Me.colPRIMER_APELLIDO_PAPELETA.Width = 138
        '
        'colSEGUNDO_APELLIDO_PAPELETA
        '
        Me.colSEGUNDO_APELLIDO_PAPELETA.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colSEGUNDO_APELLIDO_PAPELETA.FieldName = "SEGUNDO_APELLIDO_PAPELETA"
        Me.colSEGUNDO_APELLIDO_PAPELETA.Name = "colSEGUNDO_APELLIDO_PAPELETA"
        Me.colSEGUNDO_APELLIDO_PAPELETA.Visible = True
        Me.colSEGUNDO_APELLIDO_PAPELETA.VisibleIndex = 4
        '
        'colFIRMA
        '
        Me.colFIRMA.ColumnEdit = Me.RIChkFima
        Me.colFIRMA.FieldName = "FIRMA"
        Me.colFIRMA.Name = "colFIRMA"
        Me.colFIRMA.Visible = True
        Me.colFIRMA.VisibleIndex = 6
        Me.colFIRMA.Width = 88
        '
        'RIChkFima
        '
        Me.RIChkFima.AutoHeight = False
        Me.RIChkFima.Name = "RIChkFima"
        Me.RIChkFima.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RIChkFima.ValueChecked = "S"
        Me.RIChkFima.ValueGrayed = "N"
        Me.RIChkFima.ValueUnchecked = "N"
        '
        'colHUELLA
        '
        Me.colHUELLA.ColumnEdit = Me.RIChkFima
        Me.colHUELLA.FieldName = "HUELLA"
        Me.colHUELLA.Name = "colHUELLA"
        Me.colHUELLA.Visible = True
        Me.colHUELLA.VisibleIndex = 7
        '
        'colDIRECCION
        '
        Me.colDIRECCION.ColumnEdit = Me.RIChkFima
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        Me.colDIRECCION.Visible = True
        Me.colDIRECCION.VisibleIndex = 8
        '
        'colNOMBRE_IGUAL
        '
        Me.colNOMBRE_IGUAL.ColumnEdit = Me.RIChkCoincide
        Me.colNOMBRE_IGUAL.FieldName = "NOMBRE_IGUAL"
        Me.colNOMBRE_IGUAL.Name = "colNOMBRE_IGUAL"
        Me.colNOMBRE_IGUAL.Visible = True
        Me.colNOMBRE_IGUAL.VisibleIndex = 5
        Me.colNOMBRE_IGUAL.Width = 112
        '
        'RIChkCoincide
        '
        Me.RIChkCoincide.AutoHeight = False
        Me.RIChkCoincide.Name = "RIChkCoincide"
        Me.RIChkCoincide.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RIChkCoincide.ValueChecked = "S"
        Me.RIChkCoincide.ValueGrayed = "N"
        Me.RIChkCoincide.ValueUnchecked = "N"
        '
        'colOBSERVACION
        '
        Me.colOBSERVACION.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.colOBSERVACION.FieldName = "OBSERVACION"
        Me.colOBSERVACION.Name = "colOBSERVACION"
        Me.colOBSERVACION.OptionsColumn.ReadOnly = True
        Me.colOBSERVACION.Visible = True
        Me.colOBSERVACION.VisibleIndex = 11
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'colMAQUINA
        '
        Me.colMAQUINA.FieldName = "MAQUINA"
        Me.colMAQUINA.Name = "colMAQUINA"
        '
        'colPAGINA
        '
        Me.colPAGINA.FieldName = "PAGINA"
        Me.colPAGINA.Name = "colPAGINA"
        Me.colPAGINA.Visible = True
        Me.colPAGINA.VisibleIndex = 12
        '
        'colIMAGEN_FIRMA
        '
        Me.colIMAGEN_FIRMA.ColumnEdit = Me.RPIImgfirma
        Me.colIMAGEN_FIRMA.FieldName = "IMAGEN_FIRMA"
        Me.colIMAGEN_FIRMA.Name = "colIMAGEN_FIRMA"
        Me.colIMAGEN_FIRMA.Visible = True
        Me.colIMAGEN_FIRMA.VisibleIndex = 10
        Me.colIMAGEN_FIRMA.Width = 83
        '
        'RPIImgfirma
        '
        Me.RPIImgfirma.Name = "RPIImgfirma"
        Me.RPIImgfirma.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Si", "No"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.NullText = "Seleccione"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(522, 68)
        Me.PanelControl1.TabIndex = 4
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(248, 64)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.guardar1
        Me.BtnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(3, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 55)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(64, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 55)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem4, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(628, 439)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(526, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(82, 72)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(82, 72)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(82, 72)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 377)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(608, 42)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PanelControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(526, 72)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GCBusqueda
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(608, 255)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(526, 72)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(82, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CmbPartido
        Me.LayoutControlItem3.CustomizationFormText = "Partido"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(214, 26)
        Me.LayoutControlItem3.Text = "Partido"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.CmbMovimiento
        Me.LayoutControlItem4.CustomizationFormText = "Movimiento"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(214, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(222, 26)
        Me.LayoutControlItem4.Text = "Movimiento"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CmbDepartamento
        Me.LayoutControlItem5.CustomizationFormText = "Departamento"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(214, 24)
        Me.LayoutControlItem5.Text = "Departamento"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.CmbMunicipio
        Me.LayoutControlItem6.CustomizationFormText = "Municipio"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(214, 98)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem6.Text = "Municipio"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(69, 13)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(596, 98)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(12, 24)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton1
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(436, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(90, 26)
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CheckEdit1
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(436, 98)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(160, 24)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'IMCIUDADANOSRESPALDANBindingSource
        '
        Me.IMCIUDADANOSRESPALDANBindingSource.DataMember = "IM_CIUDADANOS_RESPALDAN"
        Me.IMCIUDADANOSRESPALDANBindingSource.DataSource = Me.DSCiudadanos
        '
        'IM_CIUDADANOS_RESPALDANTableAdapter
        '
        Me.IM_CIUDADANOS_RESPALDANTableAdapter.ClearBeforeFill = True
        '
        'TA_PARTIDOS_POLITICOSTableAdapter
        '
        Me.TA_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'TA_MOVIMIENTOTableAdapter
        '
        Me.TA_MOVIMIENTOTableAdapter.ClearBeforeFill = True
        '
        'TA_DEPARTAMENTOSTableAdapter
        '
        Me.TA_DEPARTAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'TA_MUNICIPIOSTableAdapter
        '
        Me.TA_MUNICIPIOSTableAdapter.ClearBeforeFill = True
        '
        'IM_CIUDADANOS_RESPALDAN1TableAdapter
        '
        Me.IM_CIUDADANOS_RESPALDAN1TableAdapter.ClearBeforeFill = True
        '
        'XfrmConsultaFirmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 439)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "XfrmConsultaFirmas"
        Me.Text = "Ciudadanos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDeptoMuni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TADEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbPartido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IM_CIUDADANOS_RESPALDAN1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCiudadanos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIChkFima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIChkCoincide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RPIImgfirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMCIUDADANOSRESPALDANBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RIChkCoincide As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RIChkFima As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RPIImgfirma As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents DSCiudadanos As Inscripcion_de_Moviemientos.DSCiudadanos
    Friend WithEvents IMCIUDADANOSRESPALDANBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CIUDADANOS_RESPALDANTableAdapter As Inscripcion_de_Moviemientos.DSCiudadanosTableAdapters.IM_CIUDADANOS_RESPALDANTableAdapter
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CmbMunicipio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CmbDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CmbMovimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CmbPartido As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DSPolitico As Inscripcion_de_Moviemientos.DSPolitico
    Friend WithEvents TAPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents TAMOVIMIENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_MOVIMIENTOTableAdapter As Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_MOVIMIENTOTableAdapter
    Friend WithEvents DSDeptoMuni As Inscripcion_de_Moviemientos.DSDeptoMuni
    Friend WithEvents TADEPARTAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_DEPARTAMENTOSTableAdapter As Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_DEPARTAMENTOSTableAdapter
    Friend WithEvents TAMUNICIPIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_MUNICIPIOSTableAdapter As Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_MUNICIPIOSTableAdapter
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkEstado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents IM_CIUDADANOS_RESPALDAN1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CIUDADANOS_RESPALDAN1TableAdapter As Inscripcion_de_Moviemientos.DSCiudadanosTableAdapters.IM_CIUDADANOS_RESPALDAN1TableAdapter
    Friend WithEvents colCODIGO_CUIDADANOS_RESPALDAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHUELLA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_NOMBRE_PAPELETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_IGUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_NOMBRE_PAPELETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIMAGEN_FIRMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONSISTENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOBSERVACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAQUINA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAGINA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_APELLIDO_PAPELETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_APELLIDO_PAPELETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
