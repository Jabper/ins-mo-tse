﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit
        Me.IMNIVELELECTIVOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSInscripcionCandidatos = New Inscripcion_de_Moviemientos.DSInscripcionCandidatos
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
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.ItemForNOMBRE = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForAPELLIDO = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.ItemForIDENTIDAD = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForPOSICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lblCopMuni = New DevExpress.XtraEditors.LabelControl
        Me.lblMuni = New DevExpress.XtraEditors.LabelControl
        Me.lbldepto_select = New DevExpress.XtraEditors.LabelControl
        Me.lblPresidente_estado = New DevExpress.XtraEditors.LabelControl
        Me.lbldepto = New DevExpress.XtraEditors.LabelControl
        Me.lblPresidente = New DevExpress.XtraEditors.LabelControl
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem
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
        Me.TACANDIDATOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_CANDIDATOSTableAdapter = New Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.TA_CANDIDATOSTableAdapter
        Me.colCODIGO_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CANDIDATOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPOSICION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CARGO_ELECTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAPELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIDENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colADICIONADO_POR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_ADICION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMODIFICADO_POR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_MODIFICACION = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMNIVELELECTIVOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSInscripcionCandidatos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNOMBRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAPELLIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDENTIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPOSICION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TACANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.FlowLayoutPanel1)
        Me.LayoutControl1.Controls.Add(Me.DataLayoutControl1)
        Me.LayoutControl1.Controls.Add(Me.GroupControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(400, 265, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(966, 403)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnNuevo)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnEliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(293, 62)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.Appearance.Options.UseFont = True
        Me.BtnNuevo.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources._new
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
        Me.BtnGuardar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.guardar1
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
        Me.BtnEliminar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.eliminar
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
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(186, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 55)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.GCBusqueda)
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
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 78)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(589, 88, 250, 350)
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(745, 313)
        Me.DataLayoutControl1.TabIndex = 7
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'GCBusqueda
        '
        Me.GCBusqueda.DataSource = Me.TACANDIDATOSBindingSource
        Me.GCBusqueda.Location = New System.Drawing.Point(12, 180)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.Size = New System.Drawing.Size(721, 121)
        Me.GCBusqueda.TabIndex = 8
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_MOVIMIENTO, Me.colCODIGO_PARTIDO, Me.colCODIGO_CANDIDATOS, Me.colNOMBRE, Me.colPOSICION, Me.colCODIGO_CARGO_ELECTIVO, Me.colAPELLIDO, Me.colCODIGO_DEPARTAMENTO, Me.colCODIGO_MUNICIPIO, Me.colIDENTIDAD, Me.colADICIONADO_POR, Me.colFECHA_ADICION, Me.colMODIFICADO_POR, Me.colFECHA_MODIFICACION})
        Me.GridView1.GridControl = Me.GCBusqueda
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(112, 36)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_NIVEL_ELECTIVO", "CODIGO", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit1.Properties.DataSource = Me.IMNIVELELECTIVOBindingSource
        Me.LookUpEdit1.Properties.DisplayMember = "DESCRIPCION"
        Me.LookUpEdit1.Properties.NullValuePrompt = "Seleccione"
        Me.LookUpEdit1.Properties.ValueMember = "CODIGO_NIVEL_ELECTIVO"
        Me.LookUpEdit1.Size = New System.Drawing.Size(239, 20)
        Me.LookUpEdit1.StyleController = Me.DataLayoutControl1
        Me.LookUpEdit1.TabIndex = 18
        '
        'IMNIVELELECTIVOBindingSource
        '
        Me.IMNIVELELECTIVOBindingSource.DataMember = "IM_NIVEL_ELECTIVO"
        Me.IMNIVELELECTIVOBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'DSInscripcionCandidatos
        '
        Me.DSInscripcionCandidatos.DataSetName = "DSInscripcionCandidatos"
        Me.DSInscripcionCandidatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.NOMBRETextEdit.Location = New System.Drawing.Point(112, 108)
        Me.NOMBRETextEdit.Name = "NOMBRETextEdit"
        Me.NOMBRETextEdit.Properties.MaxLength = 100
        Me.NOMBRETextEdit.Size = New System.Drawing.Size(239, 20)
        Me.NOMBRETextEdit.StyleController = Me.DataLayoutControl1
        Me.NOMBRETextEdit.TabIndex = 5
        '
        'APELLIDOTextEdit
        '
        Me.APELLIDOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMCANDIDATOSBindingSource, "APELLIDO", True))
        Me.APELLIDOTextEdit.Location = New System.Drawing.Point(112, 132)
        Me.APELLIDOTextEdit.Name = "APELLIDOTextEdit"
        Me.APELLIDOTextEdit.Size = New System.Drawing.Size(239, 20)
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
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.NullValuePrompt = "Seleccione"
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Properties.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.CODIGO_DEPARTAMENTOLookUpEdit.Size = New System.Drawing.Size(239, 20)
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
        Me.IDENTIDADTextEdit.Location = New System.Drawing.Point(482, 108)
        Me.IDENTIDADTextEdit.Name = "IDENTIDADTextEdit"
        Me.IDENTIDADTextEdit.Properties.MaxLength = 13
        Me.IDENTIDADTextEdit.Size = New System.Drawing.Size(251, 20)
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
        Me.CODIGO_PARTIDOLookUpEdit.Properties.NullValuePrompt = "Seleccione"
        Me.CODIGO_PARTIDOLookUpEdit.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.CODIGO_PARTIDOLookUpEdit.Size = New System.Drawing.Size(239, 20)
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
        Me.CODIGO_MUNICIPIOLookUpEdit.Location = New System.Drawing.Point(482, 60)
        Me.CODIGO_MUNICIPIOLookUpEdit.Name = "CODIGO_MUNICIPIOLookUpEdit"
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MUNICIPIO", "CODIGO", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.DataSource = Me.IMMUNICIPIOSBindingSource
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.NullValuePrompt = "Seleccione"
        Me.CODIGO_MUNICIPIOLookUpEdit.Properties.ValueMember = "CODIGO_MUNICIPIO"
        Me.CODIGO_MUNICIPIOLookUpEdit.Size = New System.Drawing.Size(251, 20)
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
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Location = New System.Drawing.Point(482, 36)
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Name = "CODIGO_CARGO_ELECTIVOLookUpEdit"
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_CARGO_ELECTIVO", "CODIGO", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.DataSource = Me.IMCARGOSELECTIVOSBindingSource
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.NullValuePrompt = "Seleccione"
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Properties.ValueMember = "CODIGO_CARGO_ELECTIVO"
        Me.CODIGO_CARGO_ELECTIVOLookUpEdit.Size = New System.Drawing.Size(251, 20)
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
        Me.CODIGO_MOVIMIENTOLookUpEdit.Location = New System.Drawing.Point(482, 12)
        Me.CODIGO_MOVIMIENTOLookUpEdit.Name = "CODIGO_MOVIMIENTOLookUpEdit"
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MOVIMIENTO", "CODIGO", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE_MOVIMIENTO", "NOMBRE MOVIMIENTO", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.DataSource = Me.IMMOVIMIENTOSBindingSource
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.NullValuePrompt = "Seleccione"
        Me.CODIGO_MOVIMIENTOLookUpEdit.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTOLookUpEdit.Size = New System.Drawing.Size(251, 20)
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
        Me.POSICIONSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.POSICIONSpinEdit.Location = New System.Drawing.Point(482, 132)
        Me.POSICIONSpinEdit.Name = "POSICIONSpinEdit"
        Me.POSICIONSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.POSICIONSpinEdit.Properties.Mask.EditMask = "00"
        Me.POSICIONSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.POSICIONSpinEdit.Size = New System.Drawing.Size(251, 20)
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
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem3, Me.EmptySpaceItem4})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(745, 313)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCODIGO_DEPARTAMENTO, Me.ItemForCODIGO_PARTIDO, Me.ItemForNIVEL_ELECTIVO, Me.ItemForCODIGO_MOVIMIENTO, Me.ItemForCODIGO_CARGO_ELECTIVO, Me.ItemForCODIGO_MUNICIPIO, Me.EmptySpaceItem1, Me.ItemForNOMBRE, Me.ItemForAPELLIDO, Me.EmptySpaceItem2, Me.EmptySpaceItem8, Me.ItemForIDENTIDAD, Me.ItemForPOSICION})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(725, 144)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCODIGO_DEPARTAMENTO
        '
        Me.ItemForCODIGO_DEPARTAMENTO.BestFitWeight = 50
        Me.ItemForCODIGO_DEPARTAMENTO.Control = Me.CODIGO_DEPARTAMENTOLookUpEdit
        Me.ItemForCODIGO_DEPARTAMENTO.CustomizationFormText = "DEPARTAMENTO"
        Me.ItemForCODIGO_DEPARTAMENTO.Location = New System.Drawing.Point(0, 48)
        Me.ItemForCODIGO_DEPARTAMENTO.Name = "ItemForCODIGO_DEPARTAMENTO"
        Me.ItemForCODIGO_DEPARTAMENTO.Size = New System.Drawing.Size(343, 24)
        Me.ItemForCODIGO_DEPARTAMENTO.Text = "DEPARTAMENTO"
        Me.ItemForCODIGO_DEPARTAMENTO.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForCODIGO_PARTIDO
        '
        Me.ItemForCODIGO_PARTIDO.Control = Me.CODIGO_PARTIDOLookUpEdit
        Me.ItemForCODIGO_PARTIDO.CustomizationFormText = "PARTIDO POLITICO"
        Me.ItemForCODIGO_PARTIDO.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCODIGO_PARTIDO.Name = "ItemForCODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Size = New System.Drawing.Size(343, 24)
        Me.ItemForCODIGO_PARTIDO.Text = "PARTIDO POLITICO"
        Me.ItemForCODIGO_PARTIDO.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForNIVEL_ELECTIVO
        '
        Me.ItemForNIVEL_ELECTIVO.Control = Me.LookUpEdit1
        Me.ItemForNIVEL_ELECTIVO.CustomizationFormText = "LayoutControlItem3"
        Me.ItemForNIVEL_ELECTIVO.Location = New System.Drawing.Point(0, 24)
        Me.ItemForNIVEL_ELECTIVO.Name = "ItemForNIVEL_ELECTIVO"
        Me.ItemForNIVEL_ELECTIVO.Size = New System.Drawing.Size(343, 24)
        Me.ItemForNIVEL_ELECTIVO.Text = "NIVEL ELECTIVO"
        Me.ItemForNIVEL_ELECTIVO.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForCODIGO_MOVIMIENTO
        '
        Me.ItemForCODIGO_MOVIMIENTO.Control = Me.CODIGO_MOVIMIENTOLookUpEdit
        Me.ItemForCODIGO_MOVIMIENTO.CustomizationFormText = "MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Location = New System.Drawing.Point(370, 0)
        Me.ItemForCODIGO_MOVIMIENTO.Name = "ItemForCODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Size = New System.Drawing.Size(355, 24)
        Me.ItemForCODIGO_MOVIMIENTO.Text = "MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForCODIGO_CARGO_ELECTIVO
        '
        Me.ItemForCODIGO_CARGO_ELECTIVO.Control = Me.CODIGO_CARGO_ELECTIVOLookUpEdit
        Me.ItemForCODIGO_CARGO_ELECTIVO.CustomizationFormText = "CARGO ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.Location = New System.Drawing.Point(370, 24)
        Me.ItemForCODIGO_CARGO_ELECTIVO.Name = "ItemForCODIGO_CARGO_ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.Size = New System.Drawing.Size(355, 24)
        Me.ItemForCODIGO_CARGO_ELECTIVO.Text = "CARGO ELECTIVO"
        Me.ItemForCODIGO_CARGO_ELECTIVO.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForCODIGO_MUNICIPIO
        '
        Me.ItemForCODIGO_MUNICIPIO.BestFitWeight = 50
        Me.ItemForCODIGO_MUNICIPIO.Control = Me.CODIGO_MUNICIPIOLookUpEdit
        Me.ItemForCODIGO_MUNICIPIO.CustomizationFormText = "MUNICIPIO"
        Me.ItemForCODIGO_MUNICIPIO.Location = New System.Drawing.Point(370, 48)
        Me.ItemForCODIGO_MUNICIPIO.Name = "ItemForCODIGO_MUNICIPIO"
        Me.ItemForCODIGO_MUNICIPIO.Size = New System.Drawing.Size(355, 24)
        Me.ItemForCODIGO_MUNICIPIO.Text = "MUNICIPIO"
        Me.ItemForCODIGO_MUNICIPIO.TextSize = New System.Drawing.Size(96, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(343, 0)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(27, 144)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(27, 144)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(27, 144)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'ItemForNOMBRE
        '
        Me.ItemForNOMBRE.Control = Me.NOMBRETextEdit
        Me.ItemForNOMBRE.CustomizationFormText = "NOMBRE"
        Me.ItemForNOMBRE.Location = New System.Drawing.Point(0, 96)
        Me.ItemForNOMBRE.Name = "ItemForNOMBRE"
        Me.ItemForNOMBRE.Size = New System.Drawing.Size(343, 24)
        Me.ItemForNOMBRE.Text = "NOMBRE"
        Me.ItemForNOMBRE.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForAPELLIDO
        '
        Me.ItemForAPELLIDO.Control = Me.APELLIDOTextEdit
        Me.ItemForAPELLIDO.CustomizationFormText = "APELLIDO"
        Me.ItemForAPELLIDO.Location = New System.Drawing.Point(0, 120)
        Me.ItemForAPELLIDO.Name = "ItemForAPELLIDO"
        Me.ItemForAPELLIDO.Size = New System.Drawing.Size(343, 24)
        Me.ItemForAPELLIDO.Text = "APELLIDO"
        Me.ItemForAPELLIDO.TextSize = New System.Drawing.Size(96, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(343, 24)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(370, 72)
        Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(355, 24)
        Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem8.Text = "EmptySpaceItem8"
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'ItemForIDENTIDAD
        '
        Me.ItemForIDENTIDAD.Control = Me.IDENTIDADTextEdit
        Me.ItemForIDENTIDAD.CustomizationFormText = "IDENTIDAD"
        Me.ItemForIDENTIDAD.Location = New System.Drawing.Point(370, 96)
        Me.ItemForIDENTIDAD.Name = "ItemForIDENTIDAD"
        Me.ItemForIDENTIDAD.Size = New System.Drawing.Size(355, 24)
        Me.ItemForIDENTIDAD.Text = "IDENTIDAD"
        Me.ItemForIDENTIDAD.TextSize = New System.Drawing.Size(96, 13)
        '
        'ItemForPOSICION
        '
        Me.ItemForPOSICION.Control = Me.POSICIONSpinEdit
        Me.ItemForPOSICION.CustomizationFormText = "POSICION"
        Me.ItemForPOSICION.Location = New System.Drawing.Point(370, 120)
        Me.ItemForPOSICION.Name = "ItemForPOSICION"
        Me.ItemForPOSICION.Size = New System.Drawing.Size(355, 24)
        Me.ItemForPOSICION.Text = "POSICION"
        Me.ItemForPOSICION.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GCBusqueda
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(725, 125)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 144)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(725, 24)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(725, 24)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(725, 24)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblCopMuni)
        Me.GroupControl1.Controls.Add(Me.lblMuni)
        Me.GroupControl1.Controls.Add(Me.lbldepto_select)
        Me.GroupControl1.Controls.Add(Me.lblPresidente_estado)
        Me.GroupControl1.Controls.Add(Me.lbldepto)
        Me.GroupControl1.Controls.Add(Me.lblPresidente)
        Me.GroupControl1.Location = New System.Drawing.Point(413, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(404, 62)
        Me.GroupControl1.TabIndex = 11
        Me.GroupControl1.Text = "Estado de Planilla"
        '
        'lblCopMuni
        '
        Me.lblCopMuni.Location = New System.Drawing.Point(278, 43)
        Me.lblCopMuni.Name = "lblCopMuni"
        Me.lblCopMuni.Size = New System.Drawing.Size(66, 13)
        Me.lblCopMuni.TabIndex = 5
        Me.lblCopMuni.Text = "LabelControl1"
        '
        'lblMuni
        '
        Me.lblMuni.Location = New System.Drawing.Point(201, 43)
        Me.lblMuni.Name = "lblMuni"
        Me.lblMuni.Size = New System.Drawing.Size(77, 13)
        Me.lblMuni.TabIndex = 4
        Me.lblMuni.Text = "Corp. Municipal:"
        '
        'lbldepto_select
        '
        Me.lbldepto_select.Location = New System.Drawing.Point(84, 43)
        Me.lbldepto_select.Name = "lbldepto_select"
        Me.lbldepto_select.Size = New System.Drawing.Size(66, 13)
        Me.lbldepto_select.TabIndex = 3
        Me.lbldepto_select.Text = "LabelControl1"
        '
        'lblPresidente_estado
        '
        Me.lblPresidente_estado.Location = New System.Drawing.Point(84, 24)
        Me.lblPresidente_estado.Name = "lblPresidente_estado"
        Me.lblPresidente_estado.Size = New System.Drawing.Size(66, 13)
        Me.lblPresidente_estado.TabIndex = 2
        Me.lblPresidente_estado.Text = "LabelControl1"
        '
        'lbldepto
        '
        Me.lbldepto.Location = New System.Drawing.Point(5, 43)
        Me.lbldepto.Name = "lbldepto"
        Me.lbldepto.Size = New System.Drawing.Size(73, 13)
        Me.lbldepto.TabIndex = 1
        Me.lbldepto.Text = "Departamento:"
        '
        'lblPresidente
        '
        Me.lblPresidente.Location = New System.Drawing.Point(5, 24)
        Me.lblPresidente.Name = "lblPresidente"
        Me.lblPresidente.Size = New System.Drawing.Size(55, 13)
        Me.lblPresidente.TabIndex = 0
        Me.lblPresidente.Text = "Presidente:"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem9, Me.LayoutControlItem1, Me.EmptySpaceItem10})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(966, 403)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.DataLayoutControl1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 66)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(749, 317)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(749, 317)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(946, 317)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.FlowLayoutPanel1
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(297, 66)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(297, 66)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(297, 66)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.CustomizationFormText = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(297, 0)
        Me.EmptySpaceItem9.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(104, 66)
        Me.EmptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem9.Text = "EmptySpaceItem9"
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GroupControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(401, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(408, 66)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.CustomizationFormText = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(809, 0)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(137, 66)
        Me.EmptySpaceItem10.Text = "EmptySpaceItem10"
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
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
        'TACANDIDATOSBindingSource
        '
        Me.TACANDIDATOSBindingSource.DataMember = "TA_CANDIDATOS"
        Me.TACANDIDATOSBindingSource.DataSource = Me.DSInscripcionCandidatos
        '
        'TA_CANDIDATOSTableAdapter
        '
        Me.TA_CANDIDATOSTableAdapter.ClearBeforeFill = True
        '
        'colCODIGO_MOVIMIENTO
        '
        Me.colCODIGO_MOVIMIENTO.FieldName = "CODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO.Name = "colCODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO.Visible = True
        Me.colCODIGO_MOVIMIENTO.VisibleIndex = 0
        '
        'colCODIGO_PARTIDO
        '
        Me.colCODIGO_PARTIDO.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Name = "colCODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Visible = True
        Me.colCODIGO_PARTIDO.VisibleIndex = 1
        '
        'colCODIGO_CANDIDATOS
        '
        Me.colCODIGO_CANDIDATOS.FieldName = "CODIGO_CANDIDATOS"
        Me.colCODIGO_CANDIDATOS.Name = "colCODIGO_CANDIDATOS"
        Me.colCODIGO_CANDIDATOS.Visible = True
        Me.colCODIGO_CANDIDATOS.VisibleIndex = 2
        '
        'colNOMBRE
        '
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 3
        '
        'colPOSICION
        '
        Me.colPOSICION.FieldName = "POSICION"
        Me.colPOSICION.Name = "colPOSICION"
        Me.colPOSICION.Visible = True
        Me.colPOSICION.VisibleIndex = 4
        '
        'colCODIGO_CARGO_ELECTIVO
        '
        Me.colCODIGO_CARGO_ELECTIVO.FieldName = "CODIGO_CARGO_ELECTIVO"
        Me.colCODIGO_CARGO_ELECTIVO.Name = "colCODIGO_CARGO_ELECTIVO"
        Me.colCODIGO_CARGO_ELECTIVO.Visible = True
        Me.colCODIGO_CARGO_ELECTIVO.VisibleIndex = 5
        '
        'colAPELLIDO
        '
        Me.colAPELLIDO.FieldName = "APELLIDO"
        Me.colAPELLIDO.Name = "colAPELLIDO"
        Me.colAPELLIDO.Visible = True
        Me.colAPELLIDO.VisibleIndex = 6
        '
        'colCODIGO_DEPARTAMENTO
        '
        Me.colCODIGO_DEPARTAMENTO.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Name = "colCODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Visible = True
        Me.colCODIGO_DEPARTAMENTO.VisibleIndex = 7
        '
        'colCODIGO_MUNICIPIO
        '
        Me.colCODIGO_MUNICIPIO.FieldName = "CODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Name = "colCODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Visible = True
        Me.colCODIGO_MUNICIPIO.VisibleIndex = 8
        '
        'colIDENTIDAD
        '
        Me.colIDENTIDAD.FieldName = "IDENTIDAD"
        Me.colIDENTIDAD.Name = "colIDENTIDAD"
        Me.colIDENTIDAD.Visible = True
        Me.colIDENTIDAD.VisibleIndex = 9
        '
        'colADICIONADO_POR
        '
        Me.colADICIONADO_POR.FieldName = "ADICIONADO_POR"
        Me.colADICIONADO_POR.Name = "colADICIONADO_POR"
        Me.colADICIONADO_POR.Visible = True
        Me.colADICIONADO_POR.VisibleIndex = 10
        '
        'colFECHA_ADICION
        '
        Me.colFECHA_ADICION.FieldName = "FECHA_ADICION"
        Me.colFECHA_ADICION.Name = "colFECHA_ADICION"
        Me.colFECHA_ADICION.Visible = True
        Me.colFECHA_ADICION.VisibleIndex = 11
        '
        'colMODIFICADO_POR
        '
        Me.colMODIFICADO_POR.FieldName = "MODIFICADO_POR"
        Me.colMODIFICADO_POR.Name = "colMODIFICADO_POR"
        Me.colMODIFICADO_POR.Visible = True
        Me.colMODIFICADO_POR.VisibleIndex = 12
        '
        'colFECHA_MODIFICACION
        '
        Me.colFECHA_MODIFICACION.FieldName = "FECHA_MODIFICACION"
        Me.colFECHA_MODIFICACION.Name = "colFECHA_MODIFICACION"
        Me.colFECHA_MODIFICACION.Visible = True
        Me.colFECHA_MODIFICACION.VisibleIndex = 13
        '
        'xfrmInscripcionCandidato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 403)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xfrmInscripcionCandidato"
        Me.Text = "Inscripción de Candidatos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMNIVELELECTIVOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSInscripcionCandidatos, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNOMBRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAPELLIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDENTIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPOSICION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TACANDIDATOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DSInscripcionCandidatos As Inscripcion_de_Moviemientos.DSInscripcionCandidatos
    Friend WithEvents IMCANDIDATOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CANDIDATOSTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.IM_CANDIDATOSTableAdapter
    Friend WithEvents CODIGO_CANDIDATOSSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NOMBRETextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CODIGO_CARGO_ELECTIVOLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents APELLIDOTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CODIGO_DEPARTAMENTOLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CODIGO_MUNICIPIOLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CODIGO_MOVIMIENTOLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IDENTIDADTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CODIGO_PARTIDOLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ADICIONADO_PORTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_ADICIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MODIFICADO_PORTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FECHA_MODIFICACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ItemForCODIGO_CANDIDATOS As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNOMBRE As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAPELLIDO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIDENTIDAD As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForADICIONADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_ADICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMODIFICADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_MODIFICACION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCODIGO_CARGO_ELECTIVO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_DEPARTAMENTO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_MUNICIPIO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_PARTIDO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ItemForNIVEL_ELECTIVO As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents ItemForCODIGO_MOVIMIENTO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ItemForPOSICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents POSICIONSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lbldepto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPresidente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblCopMuni As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMuni As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbldepto_select As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPresidente_estado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TACANDIDATOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCODIGO_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CANDIDATOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOSICION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CARGO_ELECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADICIONADO_POR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_ADICION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMODIFICADO_POR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_MODIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TA_CANDIDATOSTableAdapter As Inscripcion_de_Moviemientos.DSInscripcionCandidatosTableAdapters.TA_CANDIDATOSTableAdapter
End Class
