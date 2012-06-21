<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfrmInscripcionCandidato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xfrmInscripcionCandidato))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.IMREQUISITOS1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSInscripcionCandidatos = New Inscripcion_de_Moviemientos.DSInscripcionCandidatos
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CODIGO_REQUISITO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CODIGO_CARGO_ELECTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ESTADO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.IMAGEN1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.CODIGO_CANDIDATO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CODIGO_MOVIMIENTO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CODIGO_PARTIDO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemPictureEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemCheckEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit
        Me.IMNIVELELECTIVOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODIGO_CANDIDATOSSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.IMCANDIDATOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NOMBRETextEdit = New DevExpress.XtraEditors.TextEdit
        Me.APELLIDOTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.CODIGO_DEPARTAMENTOLookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMDEPARTAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDENTIDADTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.CODIGO_PARTIDOLookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADICIONADO_PORTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.FECHA_ADICIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.CODIGO_MUNICIPIOLookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMMUNICIPIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MODIFICADO_PORTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMCARGOSELECTIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FECHA_MODIFICACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.CODIGO_MOVIMIENTOLookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.IMMOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.POSICIONSpinEdit = New DevExpress.XtraEditors.TextEdit
        Me.ItemForCODIGO_CANDIDATOS = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForADICIONADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_ADICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForMODIFICADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_MODIFICACION = New DevExpress.XtraLayout.LayoutControlItem
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.ItemForCODIGO_DEPARTAMENTO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_PARTIDO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForNIVEL_ELECTIVO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_MOVIMIENTO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_CARGO_ELECTIVO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_MUNICIPIO = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.ItemForIDENTIDAD = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForAPELLIDO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForPOSICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForNOMBRE = New DevExpress.XtraLayout.LayoutControlItem
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.IMREQUISITOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_REQUISITO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CARGO_ELECTIVO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.IMAGEN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.CODIGO_CANDIDATO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CODIGO_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Cumplido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkCumplido = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RIChkCoincide = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RIChkFima = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RPIImgfirma = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.ChkEstado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.TACANDIDATOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_CANDIDATOSTableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_CANDIDATOSTableAdapter
        Me.IM_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
        Me.IM_MUNICIPIOSTableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_MUNICIPIOSTableAdapter
        Me.IM_NIVEL_ELECTIVOTableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
        Me.IM_CARGOS_ELECTIVOSTableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_CARGOS_ELECTIVOSTableAdapter
        Me.IM_DEPARTAMENTOSTableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_DEPARTAMENTOSTableAdapter
        Me.IM_MOVIMIENTOSTableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_MOVIMIENTOSTableAdapter
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.TA_CANDIDATOSTableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.TA_CANDIDATOSTableAdapter
        Me.IM_REQUISITOSTableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_REQUISITOSTableAdapter
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.IM_REQUISITOS1TableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_REQUISITOS1TableAdapter
        Me.IMREQUISITOSXCANDIDATOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_REQUISITOS_X_CANDIDATOTableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_REQUISITOS_X_CANDIDATOTableAdapter
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMREQUISITOS1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSInscripcionCandidatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMNIVELELECTIVOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_CANDIDATOSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMCANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOMBRETextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APELLIDOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMDEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDENTIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_PARTIDOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADICIONADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_MUNICIPIOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODIFICADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMCARGOSELECTIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_MOVIMIENTOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSICIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_CANDIDATOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_DEPARTAMENTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNIVEL_ELECTIVO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_MOVIMIENTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_CARGO_ELECTIVO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_MUNICIPIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDENTIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAPELLIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPOSICION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNOMBRE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMREQUISITOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCumplido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIChkCoincide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIChkFima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RPIImgfirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TACANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMREQUISITOSXCANDIDATOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Controls.Add(Me.DataLayoutControl1)
        Me.LayoutControl1.Controls.Add(Me.FlowLayoutPanel1)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(242, 225, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(891, 481)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.IMREQUISITOS1BindingSource
        Me.GridControl2.Location = New System.Drawing.Point(12, 309)
        Me.GridControl2.MainView = Me.GridView5
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3, Me.RepositoryItemCheckEdit4, Me.RepositoryItemPictureEdit3, Me.RepositoryItemComboBox2, Me.RepositoryItemCheckEdit5, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemCheckEdit2, Me.RepositoryItemPictureEdit2})
        Me.GridControl2.Size = New System.Drawing.Size(428, 146)
        Me.GridControl2.TabIndex = 11
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5, Me.GridView6})
        '
        'IMREQUISITOS1BindingSource
        '
        Me.IMREQUISITOS1BindingSource.DataMember = "IM_REQUISITOS1"
        Me.IMREQUISITOS1BindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'DSInscripcionCandidatos
        '
        Me.DSInscripcionCandidatos.DataSetName = "DSInscripcionCandidatos"
        Me.DSInscripcionCandidatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DESCRIPCION, Me.CODIGO_REQUISITO, Me.CODIGO_CARGO_ELECTIVO, Me.ESTADO1, Me.IMAGEN1, Me.CODIGO_CANDIDATO1, Me.CODIGO_MOVIMIENTO1, Me.CODIGO_PARTIDO1})
        Me.GridView5.GridControl = Me.GridControl2
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView5.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView5.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.ShowDetailButtons = False
        Me.GridView5.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Caption = "Descripcion"
        Me.DESCRIPCION.FieldName = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.OptionsColumn.AllowEdit = False
        Me.DESCRIPCION.Visible = True
        Me.DESCRIPCION.VisibleIndex = 1
        Me.DESCRIPCION.Width = 300
        '
        'CODIGO_REQUISITO
        '
        Me.CODIGO_REQUISITO.FieldName = "CODIGO_REQUISITO"
        Me.CODIGO_REQUISITO.Name = "CODIGO_REQUISITO"
        '
        'CODIGO_CARGO_ELECTIVO
        '
        Me.CODIGO_CARGO_ELECTIVO.FieldName = "CODIGO_CARGO_ELECTIVO"
        Me.CODIGO_CARGO_ELECTIVO.Name = "CODIGO_CARGO_ELECTIVO"
        '
        'ESTADO1
        '
        Me.ESTADO1.Caption = "Valido"
        Me.ESTADO1.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.ESTADO1.FieldName = "ESTADO"
        Me.ESTADO1.Name = "ESTADO1"
        Me.ESTADO1.Visible = True
        Me.ESTADO1.VisibleIndex = 0
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit2.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit2.PictureUnchecked = CType(resources.GetObject("RepositoryItemCheckEdit2.PictureUnchecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit2.ValueChecked = "C"
        Me.RepositoryItemCheckEdit2.ValueGrayed = "I"
        Me.RepositoryItemCheckEdit2.ValueUnchecked = "I"
        '
        'IMAGEN1
        '
        Me.IMAGEN1.Caption = "Imagen"
        Me.IMAGEN1.ColumnEdit = Me.RepositoryItemPictureEdit2
        Me.IMAGEN1.FieldName = "IMAGEN"
        Me.IMAGEN1.Name = "IMAGEN1"
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'CODIGO_CANDIDATO1
        '
        Me.CODIGO_CANDIDATO1.Caption = "GridColumn1"
        Me.CODIGO_CANDIDATO1.FieldName = "CODIGO_CANDIDATO"
        Me.CODIGO_CANDIDATO1.Name = "CODIGO_CANDIDATO1"
        '
        'CODIGO_MOVIMIENTO1
        '
        Me.CODIGO_MOVIMIENTO1.Caption = "GridColumn1"
        Me.CODIGO_MOVIMIENTO1.FieldName = "CODIGO_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTO1.Name = "CODIGO_MOVIMIENTO1"
        '
        'CODIGO_PARTIDO1
        '
        Me.CODIGO_PARTIDO1.Caption = "GridColumn1"
        Me.CODIGO_PARTIDO1.FieldName = "CODIGO_PARTIDO"
        Me.CODIGO_PARTIDO1.Name = "CODIGO_PARTIDO1"
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit3.ValueChecked = "S"
        Me.RepositoryItemCheckEdit3.ValueUnchecked = "N"
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        Me.RepositoryItemCheckEdit4.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEdit4.ValueChecked = "S"
        Me.RepositoryItemCheckEdit4.ValueGrayed = "N"
        Me.RepositoryItemCheckEdit4.ValueUnchecked = "N"
        '
        'RepositoryItemPictureEdit3
        '
        Me.RepositoryItemPictureEdit3.Name = "RepositoryItemPictureEdit3"
        Me.RepositoryItemPictureEdit3.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"Si", "No"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        Me.RepositoryItemComboBox2.NullText = "Seleccione"
        '
        'RepositoryItemCheckEdit5
        '
        Me.RepositoryItemCheckEdit5.AutoHeight = False
        Me.RepositoryItemCheckEdit5.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit5.Name = "RepositoryItemCheckEdit5"
        Me.RepositoryItemCheckEdit5.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit5.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit5.PictureUnchecked = CType(resources.GetObject("RepositoryItemCheckEdit5.PictureUnchecked"), System.Drawing.Image)
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.MaxLength = 15
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.MaxLength = 50
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.MaxLength = 300
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.GridControl2
        Me.GridView6.Name = "GridView6"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.LookUpEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_CANDIDATOSSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NOMBRETextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.APELLIDOTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_DEPARTAMENTOLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDENTIDADTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_PARTIDOLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ADICIONADO_PORTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_ADICIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_MUNICIPIOLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MODIFICADO_PORTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_CARGO_ELECTIVOLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_MODIFICACIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_MOVIMIENTOLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.POSICIONSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.IMCANDIDATOSBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCODIGO_CANDIDATOS, Me.ItemForADICIONADO_POR, Me.ItemForFECHA_ADICION, Me.ItemForMODIFICADO_POR, Me.ItemForFECHA_MODIFICACION})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 101)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(776, 141, 250, 350)
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(609, 188)
        Me.DataLayoutControl1.TabIndex = 8
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMNIVELELECTIVOBindingSource, "CODIGO_NIVEL_ELECTIVO", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(112, 36)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_NIVEL_ELECTIVO", "CODIGO", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit1.Properties.DataSource = Me.IMNIVELELECTIVOBindingSource
        Me.LookUpEdit1.Properties.DisplayMember = "DESCRIPCION"
        Me.LookUpEdit1.Properties.NullText = "Seleccione"
        Me.LookUpEdit1.Properties.NullValuePromptShowForEmptyValue = True
        Me.LookUpEdit1.Properties.ValueMember = "CODIGO_NIVEL_ELECTIVO"
        Me.LookUpEdit1.Size = New System.Drawing.Size(150, 20)
        Me.LookUpEdit1.StyleController = Me.DataLayoutControl1
        Me.LookUpEdit1.TabIndex = 18
        '
        'IMNIVELELECTIVOBindingSource
        '
        Me.IMNIVELELECTIVOBindingSource.DataMember = "IM_NIVEL_ELECTIVO"
        Me.IMNIVELELECTIVOBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'CODIGO_CANDIDATOSSpinEdit
        '
        Me.CODIGO_CANDIDATOSSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_CANDIDATOS", True))
        Me.CODIGO_CANDIDATOSSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_CANDIDATOSSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.CODIGO_CANDIDATOSSpinEdit.Name = "CODIGO_CANDIDATOSSpinEdit"
        Me.CODIGO_CANDIDATOSSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CODIGO_CANDIDATOSSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.CODIGO_CANDIDATOSSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_CANDIDATOSSpinEdit.TabIndex = 4
        '
        'IMCANDIDATOSBindingSource
        '
        Me.IMCANDIDATOSBindingSource.DataMember = "IM_CANDIDATOS"
        Me.IMCANDIDATOSBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'NOMBRETextEdit
        '
        Me.NOMBRETextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "NOMBRE", True))
        Me.NOMBRETextEdit.Enabled = False
        Me.NOMBRETextEdit.Location = New System.Drawing.Point(393, 132)
        Me.NOMBRETextEdit.Name = "NOMBRETextEdit"
        Me.NOMBRETextEdit.Properties.MaxLength = 100
        Me.NOMBRETextEdit.Size = New System.Drawing.Size(204, 20)
        Me.NOMBRETextEdit.StyleController = Me.DataLayoutControl1
        Me.NOMBRETextEdit.TabIndex = 5
        '
        'APELLIDOTextEdit
        '
        Me.APELLIDOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "APELLIDO", True))
        Me.APELLIDOTextEdit.Enabled = False
        Me.APELLIDOTextEdit.Location = New System.Drawing.Point(393, 156)
        Me.APELLIDOTextEdit.Name = "APELLIDOTextEdit"
        Me.APELLIDOTextEdit.Size = New System.Drawing.Size(204, 20)
        Me.APELLIDOTextEdit.StyleController = Me.DataLayoutControl1
        Me.APELLIDOTextEdit.TabIndex = 8
        '
        'CODIGO_DEPARTAMENTOLookUpEdit
        '
        Me.CODIGO_DEPARTAMENTOLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_DEPARTAMENTO", True))
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Location = New System.Drawing.Point(112, 60)
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Name = "CODIGO_DEPARTAMENTOLookUpEdit"
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_DEPARTAMENTO", "CODIGO", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.DataSource = Me.IMDEPARTAMENTOSBindingSource
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.NullText = "Seleccione"
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Size = New System.Drawing.Size(150, 20)
        Me.CODIGO_DEPARTAMENTOLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_DEPARTAMENTOLookUpEdit.TabIndex = 9
        '
        'IMDEPARTAMENTOSBindingSource
        '
        Me.IMDEPARTAMENTOSBindingSource.DataMember = "IM_DEPARTAMENTOS"
        Me.IMDEPARTAMENTOSBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'IDENTIDADTextEdit
        '
        Me.IDENTIDADTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "IDENTIDAD", True))
        Me.IDENTIDADTextEdit.Location = New System.Drawing.Point(112, 132)
        Me.IDENTIDADTextEdit.Name = "IDENTIDADTextEdit"
        Me.IDENTIDADTextEdit.Properties.MaxLength = 13
        Me.IDENTIDADTextEdit.Size = New System.Drawing.Size(150, 20)
        Me.IDENTIDADTextEdit.StyleController = Me.DataLayoutControl1
        Me.IDENTIDADTextEdit.TabIndex = 12
        '
        'CODIGO_PARTIDOLookUpEdit
        '
        Me.CODIGO_PARTIDOLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_PARTIDO", True))
        Me.CODIGO_PARTIDOLookUpEdit.Location = New System.Drawing.Point(112, 12)
        Me.CODIGO_PARTIDOLookUpEdit.Name = "CODIGO_PARTIDOLookUpEdit"
        Me.CODIGO_PARTIDOLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_PARTIDOLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_PARTIDO", "CODIGO", 25, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_PARTIDOLookUpEdit.Properties.DataSource = Me.IMPARTIDOSPOLITICOSBindingSource
        Me.CODIGO_PARTIDOLookUpEdit.Properties.DisplayMember = "NOMBRE"
        Me.CODIGO_PARTIDOLookUpEdit.Properties.NullText = "Seleccione"
        Me.CODIGO_PARTIDOLookUpEdit.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.CODIGO_PARTIDOLookUpEdit.Size = New System.Drawing.Size(150, 20)
        Me.CODIGO_PARTIDOLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_PARTIDOLookUpEdit.TabIndex = 13
        '
        'IMPARTIDOSPOLITICOSBindingSource
        '
        Me.IMPARTIDOSPOLITICOSBindingSource.DataMember = "IM_PARTIDOS_POLITICOS"
        Me.IMPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'ADICIONADO_PORTextEdit
        '
        Me.ADICIONADO_PORTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "ADICIONADO_POR", True))
        Me.ADICIONADO_PORTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.ADICIONADO_PORTextEdit.Name = "ADICIONADO_PORTextEdit"
        Me.ADICIONADO_PORTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.ADICIONADO_PORTextEdit.StyleController = Me.DataLayoutControl1
        Me.ADICIONADO_PORTextEdit.TabIndex = 14
        '
        'FECHA_ADICIONDateEdit
        '
        Me.FECHA_ADICIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "FECHA_ADICION", True))
        Me.FECHA_ADICIONDateEdit.EditValue = Nothing
        Me.FECHA_ADICIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_ADICIONDateEdit.Name = "FECHA_ADICIONDateEdit"
        Me.FECHA_ADICIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_ADICIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_ADICIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_ADICIONDateEdit.TabIndex = 15
        '
        'CODIGO_MUNICIPIOLookUpEdit
        '
        Me.CODIGO_MUNICIPIOLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_MUNICIPIO", True))
        Me.CODIGO_MUNICIPIOLookUpEdit.Location = New System.Drawing.Point(393, 60)
        Me.CODIGO_MUNICIPIOLookUpEdit.Name = "CODIGO_MUNICIPIOLookUpEdit"
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MUNICIPIO", "CODIGO", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.DataSource = Me.IMMUNICIPIOSBindingSource
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.NullText = "Seleccione"
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.ValueMember = "CODIGO_MUNICIPIO"
        Me.CODIGO_MUNICIPIOLookUpEdit.Size = New System.Drawing.Size(204, 20)
        Me.CODIGO_MUNICIPIOLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_MUNICIPIOLookUpEdit.TabIndex = 10
        '
        'IMMUNICIPIOSBindingSource
        '
        Me.IMMUNICIPIOSBindingSource.DataMember = "IM_MUNICIPIOS"
        Me.IMMUNICIPIOSBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'MODIFICADO_PORTextEdit
        '
        Me.MODIFICADO_PORTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "MODIFICADO_POR", True))
        Me.MODIFICADO_PORTextEdit.Location = New System.Drawing.Point(0, 0)
        Me.MODIFICADO_PORTextEdit.Name = "MODIFICADO_PORTextEdit"
        Me.MODIFICADO_PORTextEdit.Size = New System.Drawing.Size(0, 20)
        Me.MODIFICADO_PORTextEdit.StyleController = Me.DataLayoutControl1
        Me.MODIFICADO_PORTextEdit.TabIndex = 16
        '
        'CODIGO_CARGO_ELECTIVOLookUpEdit
        '
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_CARGO_ELECTIVO", True))
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Location = New System.Drawing.Point(393, 36)
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Name = "CODIGO_CARGO_ELECTIVOLookUpEdit"
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_CARGO_ELECTIVO", "CODIGO", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.DataSource = Me.IMCARGOSELECTIVOSBindingSource
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.NullText = "Seleccione"
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.ValueMember = "CODIGO_CARGO_ELECTIVO"
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Size = New System.Drawing.Size(204, 20)
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.TabIndex = 7
        '
        'IMCARGOSELECTIVOSBindingSource
        '
        Me.IMCARGOSELECTIVOSBindingSource.DataMember = "IM_CARGOS_ELECTIVOS"
        Me.IMCARGOSELECTIVOSBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'FECHA_MODIFICACIONDateEdit
        '
        Me.FECHA_MODIFICACIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "FECHA_MODIFICACION", True))
        Me.FECHA_MODIFICACIONDateEdit.EditValue = Nothing
        Me.FECHA_MODIFICACIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_MODIFICACIONDateEdit.Name = "FECHA_MODIFICACIONDateEdit"
        Me.FECHA_MODIFICACIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_MODIFICACIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_MODIFICACIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_MODIFICACIONDateEdit.TabIndex = 17
        '
        'CODIGO_MOVIMIENTOLookUpEdit
        '
        Me.CODIGO_MOVIMIENTOLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "CODIGO_MOVIMIENTO", True))
        Me.CODIGO_MOVIMIENTOLookUpEdit.Location = New System.Drawing.Point(393, 12)
        Me.CODIGO_MOVIMIENTOLookUpEdit.Name = "CODIGO_MOVIMIENTOLookUpEdit"
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MOVIMIENTO", "CODIGO", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE_MOVIMIENTO", "NOMBRE MOVIMIENTO", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.DataSource = Me.IMMOVIMIENTOSBindingSource
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.NullText = "Seleccione"
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTOLookUpEdit.Size = New System.Drawing.Size(204, 20)
        Me.CODIGO_MOVIMIENTOLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_MOVIMIENTOLookUpEdit.TabIndex = 11
        '
        'IMMOVIMIENTOSBindingSource
        '
        Me.IMMOVIMIENTOSBindingSource.DataMember = "IM_MOVIMIENTOS"
        Me.IMMOVIMIENTOSBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'POSICIONSpinEdit
        '
        Me.POSICIONSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "POSICION", True))
        Me.POSICIONSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.POSICIONSpinEdit.Location = New System.Drawing.Point(112, 156)
        Me.POSICIONSpinEdit.Name = "POSICIONSpinEdit"
        Me.POSICIONSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.POSICIONSpinEdit.Properties.Mask.EditMask = "00"
        Me.POSICIONSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.POSICIONSpinEdit.Size = New System.Drawing.Size(150, 20)
        Me.POSICIONSpinEdit.StyleController = Me.DataLayoutControl1
        Me.POSICIONSpinEdit.TabIndex = 6
        '
        'ItemForCODIGO_CANDIDATOS
        '
        Me.ItemForCODIGO_CANDIDATOS.Control = Me.CODIGO_CANDIDATOSSpinEdit
        Me.ItemForCODIGO_CANDIDATOS.CustomizationFormText = "CODIGO_CANDIDATOS"
        Me.ItemForCODIGO_CANDIDATOS.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCODIGO_CANDIDATOS.Name = "ItemForCODIGO_CANDIDATOS"
        Me.ItemForCODIGO_CANDIDATOS.Size = New System.Drawing.Size(0, 0)
        Me.ItemForCODIGO_CANDIDATOS.Text = "CODIGO_CANDIDATOS"
        Me.ItemForCODIGO_CANDIDATOS.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForCODIGO_CANDIDATOS.TextToControlDistance = 5
        '
        'ItemForADICIONADO_POR
        '
        Me.ItemForADICIONADO_POR.Control = Me.ADICIONADO_PORTextEdit
        Me.ItemForADICIONADO_POR.CustomizationFormText = "ADICIONADO_POR"
        Me.ItemForADICIONADO_POR.Location = New System.Drawing.Point(0, 0)
        Me.ItemForADICIONADO_POR.Name = "ItemForADICIONADO_POR"
        Me.ItemForADICIONADO_POR.Size = New System.Drawing.Size(0, 0)
        Me.ItemForADICIONADO_POR.Text = "ADICIONADO_POR"
        Me.ItemForADICIONADO_POR.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForADICIONADO_POR.TextToControlDistance = 5
        '
        'ItemForFECHA_ADICION
        '
        Me.ItemForFECHA_ADICION.Control = Me.FECHA_ADICIONDateEdit
        Me.ItemForFECHA_ADICION.CustomizationFormText = "FECHA_ADICION"
        Me.ItemForFECHA_ADICION.Location = New System.Drawing.Point(0, 0)
        Me.ItemForFECHA_ADICION.Name = "ItemForFECHA_ADICION"
        Me.ItemForFECHA_ADICION.Size = New System.Drawing.Size(0, 0)
        Me.ItemForFECHA_ADICION.Text = "FECHA_ADICION"
        Me.ItemForFECHA_ADICION.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForFECHA_ADICION.TextToControlDistance = 5
        '
        'ItemForMODIFICADO_POR
        '
        Me.ItemForMODIFICADO_POR.Control = Me.MODIFICADO_PORTextEdit
        Me.ItemForMODIFICADO_POR.CustomizationFormText = "MODIFICADO_POR"
        Me.ItemForMODIFICADO_POR.Location = New System.Drawing.Point(0, 0)
        Me.ItemForMODIFICADO_POR.Name = "ItemForMODIFICADO_POR"
        Me.ItemForMODIFICADO_POR.Size = New System.Drawing.Size(0, 0)
        Me.ItemForMODIFICADO_POR.Text = "MODIFICADO_POR"
        Me.ItemForMODIFICADO_POR.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForMODIFICADO_POR.TextToControlDistance = 5
        '
        'ItemForFECHA_MODIFICACION
        '
        Me.ItemForFECHA_MODIFICACION.Control = Me.FECHA_MODIFICACIONDateEdit
        Me.ItemForFECHA_MODIFICACION.CustomizationFormText = "FECHA_MODIFICACION"
        Me.ItemForFECHA_MODIFICACION.Location = New System.Drawing.Point(0, 0)
        Me.ItemForFECHA_MODIFICACION.Name = "ItemForFECHA_MODIFICACION"
        Me.ItemForFECHA_MODIFICACION.Size = New System.Drawing.Size(0, 0)
        Me.ItemForFECHA_MODIFICACION.Text = "FECHA_MODIFICACION"
        Me.ItemForFECHA_MODIFICACION.TextSize = New System.Drawing.Size(50, 20)
        Me.ItemForFECHA_MODIFICACION.TextToControlDistance = 5
        '
        'Root
        '
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(609, 188)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCODIGO_DEPARTAMENTO, Me.ItemForCODIGO_PARTIDO, Me.ItemForNIVEL_ELECTIVO, Me.ItemForCODIGO_MOVIMIENTO, Me.ItemForCODIGO_CARGO_ELECTIVO, Me.ItemForCODIGO_MUNICIPIO, Me.EmptySpaceItem2, Me.EmptySpaceItem8, Me.EmptySpaceItem11, Me.ItemForIDENTIDAD, Me.ItemForAPELLIDO, Me.ItemForPOSICION, Me.ItemForNOMBRE})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(589, 168)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCODIGO_DEPARTAMENTO
        '
        Me.ItemForCODIGO_DEPARTAMENTO.BestFitWeight = 50
        Me.ItemForCODIGO_DEPARTAMENTO.Control = Me.CODIGO_DEPARTAMENTOLookUpEdit
        Me.ItemForCODIGO_DEPARTAMENTO.CustomizationFormText = "DEPARTAMENTO"
        Me.ItemForCODIGO_DEPARTAMENTO.Location = New System.Drawing.Point(0, 48)
        Me.ItemForCODIGO_DEPARTAMENTO.Name = "ItemForCODIGO_DEPARTAMENTO"
        Me.ItemForCODIGO_DEPARTAMENTO.Size = New System.Drawing.Size(254, 24)
        Me.ItemForCODIGO_DEPARTAMENTO.Text = "DEPARTAMENTO"
        Me.ItemForCODIGO_DEPARTAMENTO.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForCODIGO_PARTIDO
        '
        Me.ItemForCODIGO_PARTIDO.Control = Me.CODIGO_PARTIDOLookUpEdit
        Me.ItemForCODIGO_PARTIDO.CustomizationFormText = "PARTIDO POLITICO"
        Me.ItemForCODIGO_PARTIDO.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCODIGO_PARTIDO.Name = "ItemForCODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Size = New System.Drawing.Size(254, 24)
        Me.ItemForCODIGO_PARTIDO.Text = "PARTIDO POLITICO"
        Me.ItemForCODIGO_PARTIDO.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForNIVEL_ELECTIVO
        '
        Me.ItemForNIVEL_ELECTIVO.Control = Me.LookUpEdit1
        Me.ItemForNIVEL_ELECTIVO.CustomizationFormText = "LayoutControlItem3"
        Me.ItemForNIVEL_ELECTIVO.Location = New System.Drawing.Point(0, 24)
        Me.ItemForNIVEL_ELECTIVO.Name = "ItemForNIVEL_ELECTIVO"
        Me.ItemForNIVEL_ELECTIVO.Size = New System.Drawing.Size(254, 24)
        Me.ItemForNIVEL_ELECTIVO.Text = "NIVEL ELECTIVO"
        Me.ItemForNIVEL_ELECTIVO.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForCODIGO_MOVIMIENTO
        '
        Me.ItemForCODIGO_MOVIMIENTO.Control = Me.CODIGO_MOVIMIENTOLookUpEdit
        Me.ItemForCODIGO_MOVIMIENTO.CustomizationFormText = "MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Location = New System.Drawing.Point(281, 0)
        Me.ItemForCODIGO_MOVIMIENTO.Name = "ItemForCODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Size = New System.Drawing.Size(308, 24)
        Me.ItemForCODIGO_MOVIMIENTO.Text = "MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForCODIGO_CARGO_ELECTIVO
        '
        Me.ItemForCODIGO_CARGO_ELECTIVO.Control = Me.CODIGO_CARGO_ELECTIVOLookUpEdit
        Me.ItemForCODIGO_CARGO_ELECTIVO.CustomizationFormText = "CARGO ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.Location = New System.Drawing.Point(281, 24)
        Me.ItemForCODIGO_CARGO_ELECTIVO.Name = "ItemForCODIGO_CARGO_ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.Size = New System.Drawing.Size(308, 24)
        Me.ItemForCODIGO_CARGO_ELECTIVO.Text = "CARGO ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForCODIGO_MUNICIPIO
        '
        Me.ItemForCODIGO_MUNICIPIO.BestFitWeight = 50
        Me.ItemForCODIGO_MUNICIPIO.Control = Me.CODIGO_MUNICIPIOLookUpEdit
        Me.ItemForCODIGO_MUNICIPIO.CustomizationFormText = "MUNICIPIO"
        Me.ItemForCODIGO_MUNICIPIO.Location = New System.Drawing.Point(281, 48)
        Me.ItemForCODIGO_MUNICIPIO.Name = "ItemForCODIGO_MUNICIPIO"
        Me.ItemForCODIGO_MUNICIPIO.Size = New System.Drawing.Size(308, 24)
        Me.ItemForCODIGO_MUNICIPIO.Text = "MUNICIPIO"
        Me.ItemForCODIGO_MUNICIPIO.TextSize = New System.Drawing.Size(96, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(254, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(27, 144)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(27, 144)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(27, 168)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(254, 48)
        Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem8.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem11
        '
        Me.EmptySpaceItem11.AllowHotTrack = False
        Me.EmptySpaceItem11.CustomizationFormText = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Location = New System.Drawing.Point(281, 72)
        Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Size = New System.Drawing.Size(308, 48)
        Me.EmptySpaceItem11.Text = "EmptySpaceItem11"
        Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
        '
        'ItemForIDENTIDAD
        '
        Me.ItemForIDENTIDAD.Control = Me.IDENTIDADTextEdit
        Me.ItemForIDENTIDAD.CustomizationFormText = "IDENTIDAD"
        Me.ItemForIDENTIDAD.Location = New System.Drawing.Point(0, 120)
        Me.ItemForIDENTIDAD.Name = "ItemForIDENTIDAD"
        Me.ItemForIDENTIDAD.Size = New System.Drawing.Size(254, 24)
        Me.ItemForIDENTIDAD.Text = "IDENTIDAD"
        Me.ItemForIDENTIDAD.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForAPELLIDO
        '
        Me.ItemForAPELLIDO.Control = Me.APELLIDOTextEdit
        Me.ItemForAPELLIDO.CustomizationFormText = "APELLIDO"
        Me.ItemForAPELLIDO.Location = New System.Drawing.Point(281, 144)
        Me.ItemForAPELLIDO.Name = "ItemForAPELLIDO"
        Me.ItemForAPELLIDO.Size = New System.Drawing.Size(308, 24)
        Me.ItemForAPELLIDO.Text = "APELLIDO"
        Me.ItemForAPELLIDO.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForPOSICION
        '
        Me.ItemForPOSICION.Control = Me.POSICIONSpinEdit
        Me.ItemForPOSICION.CustomizationFormText = "POSICION"
        Me.ItemForPOSICION.Location = New System.Drawing.Point(0, 144)
        Me.ItemForPOSICION.Name = "ItemForPOSICION"
        Me.ItemForPOSICION.Size = New System.Drawing.Size(254, 24)
        Me.ItemForPOSICION.Text = "POSICION"
        Me.ItemForPOSICION.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForNOMBRE
        '
        Me.ItemForNOMBRE.Control = Me.NOMBRETextEdit
        Me.ItemForNOMBRE.CustomizationFormText = "NOMBRE"
        Me.ItemForNOMBRE.Location = New System.Drawing.Point(281, 120)
        Me.ItemForNOMBRE.Name = "ItemForNOMBRE"
        Me.ItemForNOMBRE.Size = New System.Drawing.Size(308, 24)
        Me.ItemForNOMBRE.Text = "NOMBRE"
        Me.ItemForNOMBRE.TextSize = New System.Drawing.Size(96, 13)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnNuevo)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnEliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSalir)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupControl2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(609, 85)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.Appearance.Options.UseFont = True
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(3, 3)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 55)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(64, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 55)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminar.Appearance.Options.UseFont = True
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(125, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(55, 55)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(186, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 55)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Location = New System.Drawing.Point(247, 3)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(354, 77)
        Me.GroupControl2.TabIndex = 12
        Me.GroupControl2.Text = "Estado de Planilla"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(84, 62)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "LabelControl1"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Corp. Municipal:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(84, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "LabelControl1"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(84, 24)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "LabelControl1"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(5, 43)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Diputados:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(5, 24)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Presidente:"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.IMREQUISITOSBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(444, 309)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RIChkCoincide, Me.RIChkFima, Me.RPIImgfirma, Me.RepositoryItemComboBox1, Me.ChkEstado, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemCheckEdit1, Me.RepositoryItemPictureEdit1, Me.chkCumplido})
        Me.GridControl1.Size = New System.Drawing.Size(425, 146)
        Me.GridControl1.TabIndex = 10
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView4})
        '
        'IMREQUISITOSBindingSource
        '
        Me.IMREQUISITOSBindingSource.DataMember = "IM_REQUISITOS"
        Me.IMREQUISITOSBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDESCRIPCION, Me.colCODIGO_REQUISITO, Me.colCODIGO_CARGO_ELECTIVO1, Me.colESTADO, Me.IMAGEN, Me.CODIGO_CANDIDATO, Me.CODIGO_MOVIMIENTO, Me.CODIGO_PARTIDO, Me.Cumplido})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowDetailButtons = False
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripcion"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.OptionsColumn.AllowEdit = False
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 1
        Me.colDESCRIPCION.Width = 300
        '
        'colCODIGO_REQUISITO
        '
        Me.colCODIGO_REQUISITO.FieldName = "CODIGO_REQUISITO"
        Me.colCODIGO_REQUISITO.Name = "colCODIGO_REQUISITO"
        '
        'colCODIGO_CARGO_ELECTIVO1
        '
        Me.colCODIGO_CARGO_ELECTIVO1.FieldName = "CODIGO_CARGO_ELECTIVO"
        Me.colCODIGO_CARGO_ELECTIVO1.Name = "colCODIGO_CARGO_ELECTIVO1"
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "Valido"
        Me.colESTADO.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 0
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit1.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit1.PictureUnchecked = CType(resources.GetObject("RepositoryItemCheckEdit1.PictureUnchecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit1.ValueChecked = "C"
        Me.RepositoryItemCheckEdit1.ValueGrayed = "I"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "I"
        '
        'IMAGEN
        '
        Me.IMAGEN.Caption = "Imagen"
        Me.IMAGEN.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.IMAGEN.FieldName = "IMAGEN"
        Me.IMAGEN.Name = "IMAGEN"
        Me.IMAGEN.Visible = True
        Me.IMAGEN.VisibleIndex = 2
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'CODIGO_CANDIDATO
        '
        Me.CODIGO_CANDIDATO.Caption = "GridColumn1"
        Me.CODIGO_CANDIDATO.FieldName = "CODIGO_CANDIDATO"
        Me.CODIGO_CANDIDATO.Name = "CODIGO_CANDIDATO"
        '
        'CODIGO_MOVIMIENTO
        '
        Me.CODIGO_MOVIMIENTO.Caption = "GridColumn1"
        Me.CODIGO_MOVIMIENTO.FieldName = "CODIGO_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTO.Name = "CODIGO_MOVIMIENTO"
        '
        'CODIGO_PARTIDO
        '
        Me.CODIGO_PARTIDO.Caption = "GridColumn1"
        Me.CODIGO_PARTIDO.FieldName = "CODIGO_PARTIDO"
        Me.CODIGO_PARTIDO.Name = "CODIGO_PARTIDO"
        '
        'Cumplido
        '
        Me.Cumplido.Caption = "Cumplido"
        Me.Cumplido.ColumnEdit = Me.chkCumplido
        Me.Cumplido.FieldName = "Cumplido"
        Me.Cumplido.Name = "Cumplido"
        Me.Cumplido.Visible = True
        Me.Cumplido.VisibleIndex = 3
        '
        'chkCumplido
        '
        Me.chkCumplido.AutoHeight = False
        Me.chkCumplido.Name = "chkCumplido"
        Me.chkCumplido.ValueGrayed = "False"
        '
        'RIChkCoincide
        '
        Me.RIChkCoincide.AutoHeight = False
        Me.RIChkCoincide.Name = "RIChkCoincide"
        Me.RIChkCoincide.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RIChkCoincide.ValueChecked = "S"
        Me.RIChkCoincide.ValueUnchecked = "N"
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
        'ChkEstado
        '
        Me.ChkEstado.AutoHeight = False
        Me.ChkEstado.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.PictureChecked = CType(resources.GetObject("ChkEstado.PictureChecked"), System.Drawing.Image)
        Me.ChkEstado.PictureUnchecked = CType(resources.GetObject("ChkEstado.PictureUnchecked"), System.Drawing.Image)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.MaxLength = 15
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.MaxLength = 50
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.MaxLength = 300
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GridControl1
        Me.GridView4.Name = "GridView4"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(613, 81)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(134, 120)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(50, 20)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.SimpleSeparator1, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.EmptySpaceItem9, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(891, 481)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.FlowLayoutPanel1
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(613, 89)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(613, 89)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(871, 89)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 459)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(871, 2)
        Me.SimpleSeparator1.Text = "SimpleSeparator1"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.DataLayoutControl1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 89)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(613, 192)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(613, 192)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(871, 192)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridControl2
        Me.LayoutControlItem5.CustomizationFormText = "Requisitos Automaticos"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 281)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(115, 40)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(432, 166)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Requisitos Automaticos"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(111, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 447)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(871, 12)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.CustomizationFormText = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(861, 281)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(10, 166)
        Me.EmptySpaceItem9.Text = "EmptySpaceItem9"
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(432, 281)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(115, 40)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(429, 166)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Requisitos Manuales"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(111, 13)
        '
        'TACANDIDATOSBindingSource
        '
        Me.TACANDIDATOSBindingSource.DataMember = "TA_CANDIDATOS"
        Me.TACANDIDATOSBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'IM_CANDIDATOSTableAdapter
        '
        Me.IM_CANDIDATOSTableAdapter.ClearBeforeFill = True
        '
        'IM_PARTIDOS_POLITICOSTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'IM_MUNICIPIOSTableAdapter
        '
        Me.IM_MUNICIPIOSTableAdapter.ClearBeforeFill = True
        '
        'IM_NIVEL_ELECTIVOTableAdapter
        '
        Me.IM_NIVEL_ELECTIVOTableAdapter.ClearBeforeFill = True
        '
        'IM_CARGOS_ELECTIVOSTableAdapter
        '
        Me.IM_CARGOS_ELECTIVOSTableAdapter.ClearBeforeFill = True
        '
        'IM_DEPARTAMENTOSTableAdapter
        '
        Me.IM_DEPARTAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'IM_MOVIMIENTOSTableAdapter
        '
        Me.IM_MOVIMIENTOSTableAdapter.ClearBeforeFill = True
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(570, 96)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(186, 213)
        Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(385, 72)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(371, 40)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(385, 112)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(371, 197)
        Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(358, 28)
        Me.EmptySpaceItem7.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'TA_CANDIDATOSTableAdapter
        '
        Me.TA_CANDIDATOSTableAdapter.ClearBeforeFill = True
        '
        'IM_REQUISITOSTableAdapter
        '
        Me.IM_REQUISITOSTableAdapter.ClearBeforeFill = True
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(613, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(358, 281)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'IM_REQUISITOS1TableAdapter
        '
        Me.IM_REQUISITOS1TableAdapter.ClearBeforeFill = True
        '
        'IMREQUISITOSXCANDIDATOBindingSource
        '
        Me.IMREQUISITOSXCANDIDATOBindingSource.DataMember = "IM_REQUISITOS_X_CANDIDATO"
        Me.IMREQUISITOSXCANDIDATOBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'IM_REQUISITOS_X_CANDIDATOTableAdapter
        '
        Me.IM_REQUISITOS_X_CANDIDATOTableAdapter.ClearBeforeFill = True
        '
        'xfrmInscripcionCandidato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 481)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xfrmInscripcionCandidato"
        Me.Text = "Inscripción de Candidatos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMREQUISITOS1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSInscripcionCandidatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMNIVELELECTIVOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_CANDIDATOSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMCANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOMBRETextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APELLIDOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMDEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDENTIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_PARTIDOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADICIONADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_MUNICIPIOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODIFICADO_PORTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMCARGOSELECTIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_MOVIMIENTOLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSICIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_CANDIDATOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_DEPARTAMENTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNIVEL_ELECTIVO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_MOVIMIENTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_CARGO_ELECTIVO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_MUNICIPIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDENTIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAPELLIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPOSICION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNOMBRE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMREQUISITOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCumplido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIChkCoincide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIChkFima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RPIImgfirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TACANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMREQUISITOSXCANDIDATOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DSInscripcionCandidatos As Inscripcion_de_Moviemientos.DSInscripcionCandidatos
    Friend WithEvents IMCANDIDATOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CANDIDATOSTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_CANDIDATOSTableAdapter
    Friend WithEvents IMPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents IMMUNICIPIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MUNICIPIOSTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_MUNICIPIOSTableAdapter
    Friend WithEvents IMNIVELELECTIVOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_NIVEL_ELECTIVOTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
    Friend WithEvents IMCARGOSELECTIVOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CARGOS_ELECTIVOSTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_CARGOS_ELECTIVOSTableAdapter
    Friend WithEvents IMDEPARTAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_DEPARTAMENTOSTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_DEPARTAMENTOSTableAdapter
    Friend WithEvents IMMOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOVIMIENTOSTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_MOVIMIENTOSTableAdapter
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TACANDIDATOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_CANDIDATOSTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.TA_CANDIDATOSTableAdapter
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CODIGO_CANDIDATOSSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NOMBRETextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents APELLIDOTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CODIGO_DEPARTAMENTOLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IDENTIDADTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CODIGO_PARTIDOLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ADICIONADO_PORTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_ADICIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CODIGO_MUNICIPIOLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MODIFICADO_PORTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CODIGO_CARGO_ELECTIVOLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FECHA_MODIFICACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CODIGO_MOVIMIENTOLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents POSICIONSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForCODIGO_CANDIDATOS As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForADICIONADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_ADICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMODIFICADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_MODIFICACION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCODIGO_DEPARTAMENTO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_PARTIDO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNIVEL_ELECTIVO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_MOVIMIENTO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_CARGO_ELECTIVO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_MUNICIPIO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ItemForNOMBRE As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAPELLIDO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ItemForIDENTIDAD As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPOSICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IMREQUISITOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_REQUISITOSTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_REQUISITOSTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_REQUISITO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CARGO_ELECTIVO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents IMAGEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents CODIGO_CANDIDATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RIChkCoincide As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RIChkFima As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RPIImgfirma As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ChkEstado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_REQUISITO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_CARGO_ELECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ESTADO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents IMAGEN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents CODIGO_CANDIDATO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_MOVIMIENTO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_PARTIDO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemPictureEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemCheckEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents IMREQUISITOS1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_REQUISITOS1TableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_REQUISITOS1TableAdapter
    Friend WithEvents IMREQUISITOSXCANDIDATOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_REQUISITOS_X_CANDIDATOTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_REQUISITOS_X_CANDIDATOTableAdapter
    Friend WithEvents Cumplido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkCumplido As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
