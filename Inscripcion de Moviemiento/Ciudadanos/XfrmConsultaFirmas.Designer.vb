﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.IMVMOSTRARFIRMASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSCiudadanos = New Inscripcion_de_Moviemientos.DSCiudadanos
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
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
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colMAQUINA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPAGINA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CODIGO_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFOLIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.lbltodos = New DevExpress.XtraEditors.LabelControl
        Me.lblfirmasnecesarias = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.lblporcentaje = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.lblinconsistentes = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.lblconsistentes = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.CmbMovimiento = New DevExpress.XtraEditors.LookUpEdit
        Me.TAMOVIMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPolitico = New Inscripcion_de_Moviemientos.DSPolitico
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.img = New DevExpress.XtraEditors.PictureEdit
        Me.txtpagina = New DevExpress.XtraEditors.TextEdit
        Me.txtfolio = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.CmbPartido = New DevExpress.XtraEditors.LookUpEdit
        Me.TAPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.BtnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.txtidentidad = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.ChkMuni = New DevExpress.XtraEditors.CheckEdit
        Me.ChkDepto = New DevExpress.XtraEditors.CheckEdit
        Me.BtnReestablecer = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.CmbFiltro = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.CmbMunicipio = New DevExpress.XtraEditors.LookUpEdit
        Me.TAMUNICIPIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDeptoMuni = New Inscripcion_de_Moviemientos.DSDeptoMuni
        Me.CmbDepartamento = New DevExpress.XtraEditors.LookUpEdit
        Me.TADEPARTAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.SplitterItem2 = New DevExpress.XtraLayout.SplitterItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TA_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
        Me.TA_MOVIMIENTOTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_MOVIMIENTOTableAdapter
        Me.TA_DEPARTAMENTOSTableAdapter = New Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_DEPARTAMENTOSTableAdapter
        Me.TA_MUNICIPIOSTableAdapter = New Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_MUNICIPIOSTableAdapter
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.IM_V_MOSTRAR_FIRMASTableAdapter = New Inscripcion_de_Moviemientos.DSCiudadanosTableAdapters.IM_V_MOSTRAR_FIRMASTableAdapter
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMVMOSTRARFIRMASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCiudadanos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIChkFima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIChkCoincide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.CmbMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpagina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfolio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbPartido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtidentidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkMuni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkDepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbFiltro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDeptoMuni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TADEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GCBusqueda)
        Me.LayoutControl1.Controls.Add(Me.PanelControl2)
        Me.LayoutControl1.Controls.Add(Me.PanelControl3)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(452, 447, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(828, 750)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GCBusqueda
        '
        Me.GCBusqueda.DataSource = Me.IMVMOSTRARFIRMASBindingSource
        Me.GCBusqueda.Location = New System.Drawing.Point(12, 250)
        Me.GCBusqueda.MainView = Me.GridView3
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.Size = New System.Drawing.Size(794, 366)
        Me.GCBusqueda.TabIndex = 11
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView4})
        '
        'IMVMOSTRARFIRMASBindingSource
        '
        Me.IMVMOSTRARFIRMASBindingSource.DataMember = "IM_V_MOSTRAR_FIRMAS"
        Me.IMVMOSTRARFIRMASBindingSource.DataSource = Me.DSCiudadanos
        '
        'DSCiudadanos
        '
        Me.DSCiudadanos.DataSetName = "DSCiudadanos"
        Me.DSCiudadanos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_CUIDADANOS_RESPALDAN, Me.colCONSISTENTE, Me.colIDENTIDAD, Me.colPRIMER_NOMBRE_PAPELETA, Me.colSEGUNDO_NOMBRE_PAPELETA, Me.colPRIMER_APELLIDO_PAPELETA, Me.colSEGUNDO_APELLIDO_PAPELETA, Me.colFIRMA, Me.colHUELLA, Me.colDIRECCION, Me.colNOMBRE_IGUAL, Me.colOBSERVACION, Me.colMAQUINA, Me.colPAGINA, Me.CODIGO_PARTIDO, Me.CODIGO_MOVIMIENTO, Me.colCODIGO_DEPARTAMENTO, Me.colCODIGO_MUNICIPIO, Me.colFOLIO, Me.colDEPARTAMENTO, Me.colMUNICIPIO, Me.colNOMBRE, Me.colNOMBRE_MOVIMIENTO})
        Me.GridView3.GridControl = Me.GCBusqueda
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowDetailButtons = False
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.RowHeight = 50
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPAGINA, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCODIGO_CUIDADANOS_RESPALDAN
        '
        Me.colCODIGO_CUIDADANOS_RESPALDAN.FieldName = "CODIGO_CUIDADANOS_RESPALDAN"
        Me.colCODIGO_CUIDADANOS_RESPALDAN.Name = "colCODIGO_CUIDADANOS_RESPALDAN"
        Me.colCODIGO_CUIDADANOS_RESPALDAN.OptionsColumn.AllowEdit = False
        '
        'colCONSISTENTE
        '
        Me.colCONSISTENTE.Caption = "Consistente"
        Me.colCONSISTENTE.ColumnEdit = Me.ChkEstado
        Me.colCONSISTENTE.FieldName = "CONSISTENTE"
        Me.colCONSISTENTE.Name = "colCONSISTENTE"
        Me.colCONSISTENTE.OptionsColumn.AllowEdit = False
        Me.colCONSISTENTE.Visible = True
        Me.colCONSISTENTE.VisibleIndex = 0
        Me.colCONSISTENTE.Width = 64
        '
        'ChkEstado
        '
        Me.ChkEstado.AutoHeight = False
        Me.ChkEstado.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.PictureChecked = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.Ok
        Me.ChkEstado.PictureUnchecked = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.errorIcon
        Me.ChkEstado.ValueChecked = "S"
        Me.ChkEstado.ValueGrayed = "N"
        Me.ChkEstado.ValueUnchecked = "N"
        '
        'colIDENTIDAD
        '
        Me.colIDENTIDAD.Caption = "Identidad"
        Me.colIDENTIDAD.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colIDENTIDAD.FieldName = "IDENTIDAD"
        Me.colIDENTIDAD.Name = "colIDENTIDAD"
        Me.colIDENTIDAD.Visible = True
        Me.colIDENTIDAD.VisibleIndex = 1
        Me.colIDENTIDAD.Width = 87
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.MaxLength = 13
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colPRIMER_NOMBRE_PAPELETA
        '
        Me.colPRIMER_NOMBRE_PAPELETA.Caption = "Primer Nombre"
        Me.colPRIMER_NOMBRE_PAPELETA.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colPRIMER_NOMBRE_PAPELETA.FieldName = "PRIMER_NOMBRE_PAPELETA"
        Me.colPRIMER_NOMBRE_PAPELETA.Name = "colPRIMER_NOMBRE_PAPELETA"
        Me.colPRIMER_NOMBRE_PAPELETA.Visible = True
        Me.colPRIMER_NOMBRE_PAPELETA.VisibleIndex = 2
        Me.colPRIMER_NOMBRE_PAPELETA.Width = 100
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.MaxLength = 50
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colSEGUNDO_NOMBRE_PAPELETA
        '
        Me.colSEGUNDO_NOMBRE_PAPELETA.Caption = "Segundo Nombre"
        Me.colSEGUNDO_NOMBRE_PAPELETA.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colSEGUNDO_NOMBRE_PAPELETA.FieldName = "SEGUNDO_NOMBRE_PAPELETA"
        Me.colSEGUNDO_NOMBRE_PAPELETA.Name = "colSEGUNDO_NOMBRE_PAPELETA"
        Me.colSEGUNDO_NOMBRE_PAPELETA.Visible = True
        Me.colSEGUNDO_NOMBRE_PAPELETA.VisibleIndex = 3
        Me.colSEGUNDO_NOMBRE_PAPELETA.Width = 103
        '
        'colPRIMER_APELLIDO_PAPELETA
        '
        Me.colPRIMER_APELLIDO_PAPELETA.Caption = "Primer Apellido"
        Me.colPRIMER_APELLIDO_PAPELETA.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colPRIMER_APELLIDO_PAPELETA.FieldName = "PRIMER_APELLIDO_PAPELETA"
        Me.colPRIMER_APELLIDO_PAPELETA.Name = "colPRIMER_APELLIDO_PAPELETA"
        Me.colPRIMER_APELLIDO_PAPELETA.Visible = True
        Me.colPRIMER_APELLIDO_PAPELETA.VisibleIndex = 4
        Me.colPRIMER_APELLIDO_PAPELETA.Width = 93
        '
        'colSEGUNDO_APELLIDO_PAPELETA
        '
        Me.colSEGUNDO_APELLIDO_PAPELETA.Caption = "Segundo Apellido"
        Me.colSEGUNDO_APELLIDO_PAPELETA.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colSEGUNDO_APELLIDO_PAPELETA.FieldName = "SEGUNDO_APELLIDO_PAPELETA"
        Me.colSEGUNDO_APELLIDO_PAPELETA.Name = "colSEGUNDO_APELLIDO_PAPELETA"
        Me.colSEGUNDO_APELLIDO_PAPELETA.Visible = True
        Me.colSEGUNDO_APELLIDO_PAPELETA.VisibleIndex = 5
        Me.colSEGUNDO_APELLIDO_PAPELETA.Width = 93
        '
        'colFIRMA
        '
        Me.colFIRMA.Caption = "Firma"
        Me.colFIRMA.ColumnEdit = Me.RIChkFima
        Me.colFIRMA.FieldName = "FIRMA"
        Me.colFIRMA.Name = "colFIRMA"
        Me.colFIRMA.Visible = True
        Me.colFIRMA.VisibleIndex = 6
        Me.colFIRMA.Width = 42
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
        Me.colHUELLA.Caption = "Huella"
        Me.colHUELLA.ColumnEdit = Me.RIChkFima
        Me.colHUELLA.FieldName = "HUELLA"
        Me.colHUELLA.Name = "colHUELLA"
        Me.colHUELLA.Visible = True
        Me.colHUELLA.VisibleIndex = 7
        Me.colHUELLA.Width = 40
        '
        'colDIRECCION
        '
        Me.colDIRECCION.Caption = "Dirección"
        Me.colDIRECCION.ColumnEdit = Me.RIChkFima
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        Me.colDIRECCION.Visible = True
        Me.colDIRECCION.VisibleIndex = 8
        Me.colDIRECCION.Width = 51
        '
        'colNOMBRE_IGUAL
        '
        Me.colNOMBRE_IGUAL.ColumnEdit = Me.RIChkCoincide
        Me.colNOMBRE_IGUAL.FieldName = "NOMBRE_IGUAL"
        Me.colNOMBRE_IGUAL.Name = "colNOMBRE_IGUAL"
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
        Me.colOBSERVACION.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOBSERVACION.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colOBSERVACION.AppearanceCell.Options.UseFont = True
        Me.colOBSERVACION.AppearanceCell.Options.UseForeColor = True
        Me.colOBSERVACION.Caption = "Observación"
        Me.colOBSERVACION.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colOBSERVACION.FieldName = "OBSERVACION"
        Me.colOBSERVACION.Name = "colOBSERVACION"
        Me.colOBSERVACION.OptionsColumn.ReadOnly = True
        Me.colOBSERVACION.Visible = True
        Me.colOBSERVACION.VisibleIndex = 15
        Me.colOBSERVACION.Width = 245
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.MaxLength = 500
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colMAQUINA
        '
        Me.colMAQUINA.FieldName = "MAQUINA"
        Me.colMAQUINA.Name = "colMAQUINA"
        '
        'colPAGINA
        '
        Me.colPAGINA.Caption = "Página"
        Me.colPAGINA.FieldName = "PAGINA"
        Me.colPAGINA.Name = "colPAGINA"
        Me.colPAGINA.OptionsColumn.AllowEdit = False
        Me.colPAGINA.Visible = True
        Me.colPAGINA.VisibleIndex = 10
        Me.colPAGINA.Width = 44
        '
        'CODIGO_PARTIDO
        '
        Me.CODIGO_PARTIDO.Caption = "CODIGO_PARTIDO"
        Me.CODIGO_PARTIDO.FieldName = "CODIGO_PARTIDO"
        Me.CODIGO_PARTIDO.Name = "CODIGO_PARTIDO"
        '
        'CODIGO_MOVIMIENTO
        '
        Me.CODIGO_MOVIMIENTO.Caption = "CODIGO_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTO.FieldName = "CODIGO_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTO.Name = "CODIGO_MOVIMIENTO"
        '
        'colCODIGO_DEPARTAMENTO
        '
        Me.colCODIGO_DEPARTAMENTO.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Name = "colCODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.OptionsColumn.AllowEdit = False
        '
        'colCODIGO_MUNICIPIO
        '
        Me.colCODIGO_MUNICIPIO.FieldName = "CODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Name = "colCODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.OptionsColumn.AllowEdit = False
        '
        'colFOLIO
        '
        Me.colFOLIO.Caption = "Folio"
        Me.colFOLIO.FieldName = "FOLIO"
        Me.colFOLIO.Name = "colFOLIO"
        Me.colFOLIO.Visible = True
        Me.colFOLIO.VisibleIndex = 9
        Me.colFOLIO.Width = 30
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.OptionsColumn.AllowEdit = False
        Me.colDEPARTAMENTO.Visible = True
        Me.colDEPARTAMENTO.VisibleIndex = 11
        Me.colDEPARTAMENTO.Width = 80
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.Caption = "Municipio"
        Me.colMUNICIPIO.FieldName = "MUNICIPIO"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.OptionsColumn.AllowEdit = False
        Me.colMUNICIPIO.Visible = True
        Me.colMUNICIPIO.VisibleIndex = 12
        Me.colMUNICIPIO.Width = 71
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "Partido Político"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.OptionsColumn.AllowEdit = False
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 13
        Me.colNOMBRE.Width = 97
        '
        'colNOMBRE_MOVIMIENTO
        '
        Me.colNOMBRE_MOVIMIENTO.Caption = "Movimiento"
        Me.colNOMBRE_MOVIMIENTO.FieldName = "NOMBRE_MOVIMIENTO"
        Me.colNOMBRE_MOVIMIENTO.Name = "colNOMBRE_MOVIMIENTO"
        Me.colNOMBRE_MOVIMIENTO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_MOVIMIENTO.Visible = True
        Me.colNOMBRE_MOVIMIENTO.VisibleIndex = 14
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GCBusqueda
        Me.GridView4.Name = "GridView4"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.lbltodos)
        Me.PanelControl2.Controls.Add(Me.lblfirmasnecesarias)
        Me.PanelControl2.Controls.Add(Me.LabelControl12)
        Me.PanelControl2.Controls.Add(Me.lblporcentaje)
        Me.PanelControl2.Controls.Add(Me.LabelControl11)
        Me.PanelControl2.Controls.Add(Me.lblinconsistentes)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.lblconsistentes)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.PictureEdit2)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.PictureEdit1)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 626)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(775, 112)
        Me.PanelControl2.TabIndex = 15
        '
        'lbltodos
        '
        Me.lbltodos.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbltodos.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltodos.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbltodos.Location = New System.Drawing.Point(286, 12)
        Me.lbltodos.Name = "lbltodos"
        Me.lbltodos.Size = New System.Drawing.Size(56, 14)
        Me.lbltodos.TabIndex = 38
        Me.lbltodos.Text = "Registro "
        '
        'lblfirmasnecesarias
        '
        Me.lblfirmasnecesarias.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblfirmasnecesarias.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirmasnecesarias.Appearance.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblfirmasnecesarias.Location = New System.Drawing.Point(396, 47)
        Me.lblfirmasnecesarias.Name = "lblfirmasnecesarias"
        Me.lblfirmasnecesarias.Size = New System.Drawing.Size(64, 25)
        Me.lblfirmasnecesarias.TabIndex = 34
        Me.lblfirmasnecesarias.Text = "100%"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.DarkCyan
        Me.LabelControl12.Location = New System.Drawing.Point(359, 12)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(139, 14)
        Me.LabelControl12.TabIndex = 33
        Me.LabelControl12.Text = "Total Firmas Necesarias"
        '
        'lblporcentaje
        '
        Me.lblporcentaje.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblporcentaje.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblporcentaje.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblporcentaje.Location = New System.Drawing.Point(572, 47)
        Me.lblporcentaje.Name = "lblporcentaje"
        Me.lblporcentaje.Size = New System.Drawing.Size(64, 25)
        Me.lblporcentaje.TabIndex = 32
        Me.lblporcentaje.Text = "100%"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl11.Location = New System.Drawing.Point(516, 12)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(189, 14)
        Me.LabelControl11.TabIndex = 31
        Me.LabelControl11.Text = "Porcentaje de Firmas Correctas"
        '
        'lblinconsistentes
        '
        Me.lblinconsistentes.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblinconsistentes.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinconsistentes.Location = New System.Drawing.Point(215, 66)
        Me.lblinconsistentes.Name = "lblinconsistentes"
        Me.lblinconsistentes.Size = New System.Drawing.Size(56, 14)
        Me.lblinconsistentes.TabIndex = 30
        Me.lblinconsistentes.Text = "Registro "
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Orange
        Me.LabelControl10.Location = New System.Drawing.Point(178, 12)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(93, 14)
        Me.LabelControl10.TabIndex = 29
        Me.LabelControl10.Text = "Total Registros"
        '
        'lblconsistentes
        '
        Me.lblconsistentes.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblconsistentes.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconsistentes.Location = New System.Drawing.Point(215, 32)
        Me.lblconsistentes.Name = "lblconsistentes"
        Me.lblconsistentes.Size = New System.Drawing.Size(56, 14)
        Me.lblconsistentes.TabIndex = 28
        Me.lblconsistentes.Text = "Registro "
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(41, 70)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(150, 14)
        Me.LabelControl6.TabIndex = 25
        Me.LabelControl6.Text = "Registros inconsistentes"
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.errorIcon
        Me.PictureEdit2.Location = New System.Drawing.Point(11, 66)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.AllowFocused = False
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.ShowMenu = False
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit2.Size = New System.Drawing.Size(24, 25)
        Me.PictureEdit2.TabIndex = 26
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(41, 36)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(141, 14)
        Me.LabelControl7.TabIndex = 27
        Me.LabelControl7.Text = "Registros Consistentes"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.OrangeRed
        Me.LabelControl8.Location = New System.Drawing.Point(11, 12)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(75, 14)
        Me.LabelControl8.TabIndex = 24
        Me.LabelControl8.Text = "Indicadores:"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.Ok
        Me.PictureEdit1.Location = New System.Drawing.Point(11, 32)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(24, 25)
        Me.PictureEdit1.TabIndex = 23
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.LabelControl16)
        Me.PanelControl3.Controls.Add(Me.CmbMovimiento)
        Me.PanelControl3.Controls.Add(Me.LabelControl15)
        Me.PanelControl3.Controls.Add(Me.SimpleButton5)
        Me.PanelControl3.Controls.Add(Me.SimpleButton4)
        Me.PanelControl3.Controls.Add(Me.img)
        Me.PanelControl3.Controls.Add(Me.txtpagina)
        Me.PanelControl3.Controls.Add(Me.txtfolio)
        Me.PanelControl3.Controls.Add(Me.LabelControl14)
        Me.PanelControl3.Controls.Add(Me.LabelControl13)
        Me.PanelControl3.Controls.Add(Me.CmbPartido)
        Me.PanelControl3.Controls.Add(Me.SimpleButton3)
        Me.PanelControl3.Controls.Add(Me.BtnEliminar)
        Me.PanelControl3.Controls.Add(Me.BtnUpdate)
        Me.PanelControl3.Controls.Add(Me.SimpleButton2)
        Me.PanelControl3.Controls.Add(Me.txtidentidad)
        Me.PanelControl3.Controls.Add(Me.LabelControl9)
        Me.PanelControl3.Controls.Add(Me.ChkMuni)
        Me.PanelControl3.Controls.Add(Me.ChkDepto)
        Me.PanelControl3.Controls.Add(Me.BtnReestablecer)
        Me.PanelControl3.Controls.Add(Me.LabelControl5)
        Me.PanelControl3.Controls.Add(Me.SimpleButton1)
        Me.PanelControl3.Controls.Add(Me.CmbFiltro)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.LabelControl4)
        Me.PanelControl3.Controls.Add(Me.LabelControl3)
        Me.PanelControl3.Controls.Add(Me.LabelControl2)
        Me.PanelControl3.Controls.Add(Me.CmbMunicipio)
        Me.PanelControl3.Controls.Add(Me.CmbDepartamento)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(779, 228)
        Me.PanelControl3.TabIndex = 17
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(14, 208)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(169, 13)
        Me.LabelControl16.TabIndex = 59
        Me.LabelControl16.Text = "Presione Esc para cancelar cambios"
        '
        'CmbMovimiento
        '
        Me.CmbMovimiento.Location = New System.Drawing.Point(366, 30)
        Me.CmbMovimiento.Name = "CmbMovimiento"
        Me.CmbMovimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMovimiento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MOVIMIENTO", "CODIGO_MOVIMIENTO", 50, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE_MOVIMIENTO", "Movimiento", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.CmbMovimiento.Properties.DataSource = Me.TAMOVIMIENTOBindingSource
        Me.CmbMovimiento.Properties.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.CmbMovimiento.Properties.NullText = "Seleccione"
        Me.CmbMovimiento.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        Me.CmbMovimiento.Size = New System.Drawing.Size(152, 20)
        Me.CmbMovimiento.TabIndex = 57
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
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(623, 36)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl15.TabIndex = 56
        Me.LabelControl15.Text = "Imágen de la Página"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(693, 184)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(84, 23)
        Me.SimpleButton5.TabIndex = 55
        Me.SimpleButton5.Text = "Guardar"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(603, 184)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(84, 23)
        Me.SimpleButton4.TabIndex = 54
        Me.SimpleButton4.Text = "Cargar Imágen"
        '
        'img
        '
        Me.img.Location = New System.Drawing.Point(623, 55)
        Me.img.Name = "img"
        Me.img.Properties.ShowMenu = False
        Me.img.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.img.Size = New System.Drawing.Size(139, 123)
        Me.img.TabIndex = 53
        '
        'txtpagina
        '
        Me.txtpagina.Location = New System.Drawing.Point(204, 108)
        Me.txtpagina.Name = "txtpagina"
        Me.txtpagina.Properties.MaxLength = 15
        Me.txtpagina.Size = New System.Drawing.Size(56, 20)
        Me.txtpagina.TabIndex = 52
        '
        'txtfolio
        '
        Me.txtfolio.Location = New System.Drawing.Point(103, 108)
        Me.txtfolio.Name = "txtfolio"
        Me.txtfolio.Properties.MaxLength = 15
        Me.txtfolio.Size = New System.Drawing.Size(53, 20)
        Me.txtfolio.TabIndex = 51
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(162, 111)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl14.TabIndex = 50
        Me.LabelControl14.Text = "Página:"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(28, 108)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl13.TabIndex = 49
        Me.LabelControl13.Text = "Folio:"
        '
        'CmbPartido
        '
        Me.CmbPartido.Location = New System.Drawing.Point(103, 30)
        Me.CmbPartido.Name = "CmbPartido"
        Me.CmbPartido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbPartido.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_PARTIDO", "CODIGO_PARTIDO", 115, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "Partido Político", 52, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.CmbPartido.Properties.DataSource = Me.TAPARTIDOSPOLITICOSBindingSource
        Me.CmbPartido.Properties.DisplayMember = "NOMBRE"
        Me.CmbPartido.Properties.NullText = "Seleccione"
        Me.CmbPartido.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.CmbPartido.Size = New System.Drawing.Size(157, 20)
        Me.CmbPartido.TabIndex = 48
        '
        'TAPARTIDOSPOLITICOSBindingSource
        '
        Me.TAPARTIDOSPOLITICOSBindingSource.DataMember = "TA_PARTIDOS_POLITICOS"
        Me.TAPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSPolitico
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Options.UseTextOptions = True
        Me.SimpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton3.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.SimpleButton3.Location = New System.Drawing.Point(215, 169)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(96, 36)
        Me.SimpleButton3.TabIndex = 47
        Me.SimpleButton3.Text = "Salir"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Appearance.Options.UseTextOptions = True
        Me.BtnEliminar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnEliminar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.eliminar
        Me.BtnEliminar.Location = New System.Drawing.Point(113, 169)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(96, 36)
        Me.BtnEliminar.TabIndex = 46
        Me.BtnEliminar.Text = "Eliminar Registro"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Appearance.Options.UseTextOptions = True
        Me.BtnUpdate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnUpdate.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.guardar1
        Me.BtnUpdate.Location = New System.Drawing.Point(11, 169)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(96, 36)
        Me.BtnUpdate.TabIndex = 45
        Me.BtnUpdate.Text = "Actualizar Registro"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(-270, -291)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(125, 22)
        Me.SimpleButton2.TabIndex = 44
        Me.SimpleButton2.Text = "Realizar Busqueda"
        '
        'txtidentidad
        '
        Me.txtidentidad.Location = New System.Drawing.Point(366, 86)
        Me.txtidentidad.Name = "txtidentidad"
        Me.txtidentidad.Properties.MaxLength = 15
        Me.txtidentidad.Size = New System.Drawing.Size(152, 20)
        Me.txtidentidad.TabIndex = 43
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(288, 85)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl9.TabIndex = 42
        Me.LabelControl9.Text = "Identidad:"
        '
        'ChkMuni
        '
        Me.ChkMuni.Location = New System.Drawing.Point(269, 53)
        Me.ChkMuni.Name = "ChkMuni"
        Me.ChkMuni.Properties.Caption = ""
        Me.ChkMuni.Size = New System.Drawing.Size(16, 19)
        Me.ChkMuni.TabIndex = 41
        '
        'ChkDepto
        '
        Me.ChkDepto.Location = New System.Drawing.Point(6, 57)
        Me.ChkDepto.Name = "ChkDepto"
        Me.ChkDepto.Properties.Caption = ""
        Me.ChkDepto.Size = New System.Drawing.Size(16, 19)
        Me.ChkDepto.TabIndex = 40
        '
        'BtnReestablecer
        '
        Me.BtnReestablecer.Location = New System.Drawing.Point(393, 132)
        Me.BtnReestablecer.Name = "BtnReestablecer"
        Me.BtnReestablecer.Size = New System.Drawing.Size(125, 22)
        Me.BtnReestablecer.TabIndex = 35
        Me.BtnReestablecer.Text = "Cancelar Filtro"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(28, 59)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl5.TabIndex = 39
        Me.LabelControl5.Text = "Departamento"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(262, 132)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(125, 22)
        Me.SimpleButton1.TabIndex = 30
        Me.SimpleButton1.Text = "Realizar Busqueda"
        '
        'CmbFiltro
        '
        Me.CmbFiltro.EditValue = "Ninguno"
        Me.CmbFiltro.Location = New System.Drawing.Point(103, 82)
        Me.CmbFiltro.Name = "CmbFiltro"
        Me.CmbFiltro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbFiltro.Properties.Items.AddRange(New Object() {"Ninguno", "Consistentes", "Inconsistentes"})
        Me.CmbFiltro.Size = New System.Drawing.Size(157, 20)
        Me.CmbFiltro.TabIndex = 31
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(28, 85)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Estado:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(291, 55)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl4.TabIndex = 38
        Me.LabelControl4.Text = "Municipio"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(288, 33)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl3.TabIndex = 37
        Me.LabelControl3.Text = "Movimiento"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(28, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl2.TabIndex = 36
        Me.LabelControl2.Text = "Partido"
        '
        'CmbMunicipio
        '
        Me.CmbMunicipio.Enabled = False
        Me.CmbMunicipio.Location = New System.Drawing.Point(366, 57)
        Me.CmbMunicipio.Name = "CmbMunicipio"
        Me.CmbMunicipio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMunicipio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MUNICIPIO", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Departamento", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CmbMunicipio.Properties.DataSource = Me.TAMUNICIPIOSBindingSource
        Me.CmbMunicipio.Properties.DisplayMember = "DESCRIPCION"
        Me.CmbMunicipio.Properties.NullText = "Seleccione"
        Me.CmbMunicipio.Properties.ValueMember = "CODIGO_MUNICIPIO"
        Me.CmbMunicipio.Size = New System.Drawing.Size(152, 20)
        Me.CmbMunicipio.TabIndex = 29
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
        Me.CmbDepartamento.Enabled = False
        Me.CmbDepartamento.Location = New System.Drawing.Point(103, 56)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_DEPARTAMENTO", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Departamento", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CmbDepartamento.Properties.DataSource = Me.TADEPARTAMENTOSBindingSource
        Me.CmbDepartamento.Properties.DisplayMember = "DESCRIPCION"
        Me.CmbDepartamento.Properties.NullText = "Seleccione"
        Me.CmbDepartamento.Properties.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.CmbDepartamento.Size = New System.Drawing.Size(157, 20)
        Me.CmbDepartamento.TabIndex = 28
        '
        'TADEPARTAMENTOSBindingSource
        '
        Me.TADEPARTAMENTOSBindingSource.DataMember = "TA_DEPARTAMENTOS"
        Me.TADEPARTAMENTOSBindingSource.DataSource = Me.DSDeptoMuni
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem3, Me.LayoutControlItem10, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.SplitterItem2, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.SplitterItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(828, 750)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(779, 614)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(29, 0)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(29, 10)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(29, 116)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.PanelControl3
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(783, 232)
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(783, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(25, 232)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PanelControl2
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 614)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(779, 116)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'SplitterItem2
        '
        Me.SplitterItem2.AllowHotTrack = True
        Me.SplitterItem2.CustomizationFormText = "SplitterItem2"
        Me.SplitterItem2.Location = New System.Drawing.Point(0, 608)
        Me.SplitterItem2.Name = "SplitterItem2"
        Me.SplitterItem2.Size = New System.Drawing.Size(808, 6)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GCBusqueda
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 238)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(798, 370)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(798, 238)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 370)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
        Me.SplitterItem1.Location = New System.Drawing.Point(0, 232)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(808, 6)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'IM_V_MOSTRAR_FIRMASTableAdapter
        '
        Me.IM_V_MOSTRAR_FIRMASTableAdapter.ClearBeforeFill = True
        '
        'XfrmConsultaFirmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 750)
        Me.Controls.Add(Me.LayoutControl1)
        Me.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.Name = "XfrmConsultaFirmas"
        Me.Text = "Correción de Firmas"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMVMOSTRARFIRMASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCiudadanos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIChkFima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIChkCoincide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.CmbMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpagina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfolio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbPartido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtidentidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkMuni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkDepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbFiltro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDeptoMuni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TADEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DSCiudadanos As Inscripcion_de_Moviemientos.DSCiudadanos
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
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblinconsistentes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblconsistentes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblporcentaje As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblfirmasnecesarias As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtidentidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChkMuni As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkDepto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BtnReestablecer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbFiltro As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbMunicipio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CmbDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbPartido As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtpagina As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtfolio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbltodos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents img As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbMovimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SplitterItem2 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IMVMOSTRARFIRMASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_V_MOSTRAR_FIRMASTableAdapter As Inscripcion_de_Moviemientos.DSCiudadanosTableAdapters.IM_V_MOSTRAR_FIRMASTableAdapter
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO_CUIDADANOS_RESPALDAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONSISTENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkEstado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colIDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colPRIMER_NOMBRE_PAPELETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colSEGUNDO_NOMBRE_PAPELETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_APELLIDO_PAPELETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_APELLIDO_PAPELETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RIChkFima As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colHUELLA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_IGUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RIChkCoincide As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colOBSERVACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colMAQUINA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAGINA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFOLIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
End Class
