﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfrmRegCandidatos
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.btnguardarold = New DevExpress.XtraEditors.SimpleButton
        Me.BtnEliminariold = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSalirold = New DevExpress.XtraEditors.SimpleButton
        Me.DUALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSInsCandidatos = New Inscripcion_de_Moviemientos.DSInsCandidatos
        Me.IMDEPARTAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_DEPARTAMENTOSTableAdapter = New Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_DEPARTAMENTOSTableAdapter
        Me.cboDepartamento = New DevExpress.XtraEditors.LookUpEdit
        Me.cboMunicipio = New DevExpress.XtraEditors.LookUpEdit
        Me.IMMUNICIPIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.IMMOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_MUNICIPIOSTableAdapter = New Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_MUNICIPIOSTableAdapter
        Me.IM_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
        Me.IM_MOVIMIENTOSTableAdapter = New Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_MOVIMIENTOSTableAdapter
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.cboCargo = New DevExpress.XtraEditors.LookUpEdit
        Me.IMCARGOSELECTIVOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_CARGOS_ELECTIVOSTableAdapter = New Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_CARGOS_ELECTIVOSTableAdapter
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.lblregidores = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
        Me.lblvice = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.lblalcalde = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
        Me.lblcnr2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.lblcnr1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.lblparlacen2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.lblparlacen1 = New DevExpress.XtraEditors.LabelControl
        Me.labler23455 = New DevExpress.XtraEditors.LabelControl
        Me.lbldesignados = New DevExpress.XtraEditors.LabelControl
        Me.label234 = New DevExpress.XtraEditors.LabelControl
        Me.lblpresidnete = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.lblporcentaje = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.DUALTableAdapter = New Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.DUALTableAdapter
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Estado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ChkEstado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Fila = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIDENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colIMAGEN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RPIImgen = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.colPrimerNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colSegundoNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSegundoApellido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrimerApellido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Posicion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.CONS_VECINDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkConstancia = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.CONS_VECINDAD_IMG = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PICImagenConstancia = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.RIChkCoincide = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RIChkFima = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.lblPartido = New DevExpress.XtraEditors.LabelControl
        Me.lblMovimiento = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.IMREQUISITOSXCANDIDATOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_REQUISITOS_X_CANDIDATOTableAdapter = New Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_REQUISITOS_X_CANDIDATOTableAdapter
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.pctPartido = New DevExpress.XtraEditors.PictureEdit
        Me.PicMovimiento = New DevExpress.XtraEditors.PictureEdit
        Me.colPRIMER_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIMER_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPOSICION = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DUALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSInsCandidatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMDEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMCARGOSELECTIVOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RPIImgen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkConstancia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICImagenConstancia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIChkCoincide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIChkFima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMREQUISITOSXCANDIDATOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPartido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelControl1.Location = New System.Drawing.Point(1, 1)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(271, 58)
        Me.PanelControl1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnNuevo)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnGuardar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnEliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(11, 5)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(248, 48)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.Appearance.Options.UseFont = True
        Me.BtnNuevo.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources._new
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(3, 3)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 39)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardar.Appearance.Options.UseFont = True
        Me.BtnGuardar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.guardar1
        Me.BtnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(64, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 39)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Nuevo"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminar.Appearance.Options.UseFont = True
        Me.BtnEliminar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(125, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(55, 39)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Nuevo"
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter
        Me.BtnSalir.Location = New System.Drawing.Point(186, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 39)
        Me.BtnSalir.TabIndex = 35
        Me.BtnSalir.Text = "Nuevo"
        '
        'btnguardarold
        '
        Me.btnguardarold.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnguardarold.Appearance.Options.UseFont = True
        Me.btnguardarold.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.guardar1
        Me.btnguardarold.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter
        Me.btnguardarold.Location = New System.Drawing.Point(883, 9)
        Me.btnguardarold.Name = "btnguardarold"
        Me.btnguardarold.Size = New System.Drawing.Size(55, 39)
        Me.btnguardarold.TabIndex = 1
        Me.btnguardarold.Text = "Guardar"
        '
        'BtnEliminariold
        '
        Me.BtnEliminariold.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminariold.Appearance.Options.UseFont = True
        Me.BtnEliminariold.Enabled = False
        Me.BtnEliminariold.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.eliminar
        Me.BtnEliminariold.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEliminariold.Location = New System.Drawing.Point(887, 54)
        Me.BtnEliminariold.Name = "BtnEliminariold"
        Me.BtnEliminariold.Size = New System.Drawing.Size(51, 39)
        Me.BtnEliminariold.TabIndex = 2
        Me.BtnEliminariold.Text = "Eliminar"
        '
        'BtnSalirold
        '
        Me.BtnSalirold.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalirold.Appearance.Options.UseFont = True
        Me.BtnSalirold.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalirold.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalirold.Location = New System.Drawing.Point(801, 9)
        Me.BtnSalirold.Name = "BtnSalirold"
        Me.BtnSalirold.Size = New System.Drawing.Size(55, 55)
        Me.BtnSalirold.TabIndex = 10
        Me.BtnSalirold.Text = "Salir"
        '
        'DUALBindingSource
        '
        Me.DUALBindingSource.DataMember = "DUAL"
        Me.DUALBindingSource.DataSource = Me.DSInsCandidatos
        '
        'DSInsCandidatos
        '
        Me.DSInsCandidatos.DataSetName = "DSInsCandidatos"
        Me.DSInsCandidatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IMDEPARTAMENTOSBindingSource
        '
        Me.IMDEPARTAMENTOSBindingSource.DataMember = "IM_DEPARTAMENTOS"
        Me.IMDEPARTAMENTOSBindingSource.DataSource = Me.DSInsCandidatos
        '
        'IM_DEPARTAMENTOSTableAdapter
        '
        Me.IM_DEPARTAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'cboDepartamento
        '
        Me.cboDepartamento.Location = New System.Drawing.Point(106, 115)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_DEPARTAMENTO", "CODIGO", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboDepartamento.Properties.DataSource = Me.IMDEPARTAMENTOSBindingSource
        Me.cboDepartamento.Properties.DisplayMember = "DESCRIPCION"
        Me.cboDepartamento.Properties.NullText = "Seleccione"
        Me.cboDepartamento.Properties.ValueMember = "CODIGO_DEPARTAMENTO"
        Me.cboDepartamento.Size = New System.Drawing.Size(215, 20)
        Me.cboDepartamento.TabIndex = 17
        '
        'cboMunicipio
        '
        Me.cboMunicipio.Location = New System.Drawing.Point(400, 115)
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMunicipio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MUNICIPIO", "MUNICIPIO", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "DESCRIPCION", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboMunicipio.Properties.DataSource = Me.IMMUNICIPIOSBindingSource
        Me.cboMunicipio.Properties.DisplayMember = "DESCRIPCION"
        Me.cboMunicipio.Properties.NullText = "Seleccione"
        Me.cboMunicipio.Properties.ValueMember = "CODIGO_MUNICIPIO"
        Me.cboMunicipio.Size = New System.Drawing.Size(215, 20)
        Me.cboMunicipio.TabIndex = 18
        '
        'IMMUNICIPIOSBindingSource
        '
        Me.IMMUNICIPIOSBindingSource.DataMember = "IM_MUNICIPIOS"
        Me.IMMUNICIPIOSBindingSource.DataSource = Me.DSInsCandidatos
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 118)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl1.TabIndex = 19
        Me.LabelControl1.Text = "DEPARTAMENTO"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(329, 118)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl2.TabIndex = 20
        Me.LabelControl2.Text = "MUNICIPIO"
        '
        'IMMOVIMIENTOSBindingSource
        '
        Me.IMMOVIMIENTOSBindingSource.DataMember = "IM_MOVIMIENTOS"
        Me.IMMOVIMIENTOSBindingSource.DataSource = Me.DSInsCandidatos
        '
        'IMPARTIDOSPOLITICOSBindingSource
        '
        Me.IMPARTIDOSPOLITICOSBindingSource.DataMember = "IM_PARTIDOS_POLITICOS"
        Me.IMPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSInsCandidatos
        '
        'IM_MUNICIPIOSTableAdapter
        '
        Me.IM_MUNICIPIOSTableAdapter.ClearBeforeFill = True
        '
        'IM_PARTIDOS_POLITICOSTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'IM_MOVIMIENTOSTableAdapter
        '
        Me.IM_MOVIMIENTOSTableAdapter.ClearBeforeFill = True
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(15, 92)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl5.TabIndex = 26
        Me.LabelControl5.Text = "CARGO ELECTIVO"
        '
        'cboCargo
        '
        Me.cboCargo.Location = New System.Drawing.Point(106, 89)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCargo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_CARGO_ELECTIVO", "CODIGO", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "CARGO ELECTIVO", 250, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboCargo.Properties.DataSource = Me.IMCARGOSELECTIVOSBindingSource
        Me.cboCargo.Properties.DisplayMember = "DESCRIPCION"
        Me.cboCargo.Properties.NullText = "Seleccione"
        Me.cboCargo.Properties.ValueMember = "CODIGO_CARGO_ELECTIVO"
        Me.cboCargo.Size = New System.Drawing.Size(509, 20)
        Me.cboCargo.TabIndex = 25
        '
        'IMCARGOSELECTIVOSBindingSource
        '
        Me.IMCARGOSELECTIVOSBindingSource.DataMember = "IM_CARGOS_ELECTIVOS"
        Me.IMCARGOSELECTIVOSBindingSource.DataSource = Me.DSInsCandidatos
        '
        'IM_CARGOS_ELECTIVOSTableAdapter
        '
        Me.IM_CARGOS_ELECTIVOSTableAdapter.ClearBeforeFill = True
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PanelControl3)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 379)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(924, 110)
        Me.PanelControl2.TabIndex = 27
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Controls.Add(Me.LabelControl12)
        Me.PanelControl3.Controls.Add(Me.LabelControl13)
        Me.PanelControl3.Controls.Add(Me.LabelControl9)
        Me.PanelControl3.Controls.Add(Me.LabelControl10)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Controls.Add(Me.LabelControl7)
        Me.PanelControl3.Controls.Add(Me.lblporcentaje)
        Me.PanelControl3.Controls.Add(Me.LabelControl11)
        Me.PanelControl3.Controls.Add(Me.PictureEdit2)
        Me.PanelControl3.Controls.Add(Me.LabelControl8)
        Me.PanelControl3.Controls.Add(Me.PictureEdit1)
        Me.PanelControl3.Location = New System.Drawing.Point(5, 7)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(914, 98)
        Me.PanelControl3.TabIndex = 17
        '
        'PanelControl4
        '
        Me.PanelControl4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl4.Appearance.Options.UseBackColor = True
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.lblregidores)
        Me.PanelControl4.Controls.Add(Me.LabelControl35)
        Me.PanelControl4.Controls.Add(Me.lblvice)
        Me.PanelControl4.Controls.Add(Me.LabelControl32)
        Me.PanelControl4.Controls.Add(Me.lblalcalde)
        Me.PanelControl4.Controls.Add(Me.LabelControl34)
        Me.PanelControl4.Controls.Add(Me.lblcnr2)
        Me.PanelControl4.Controls.Add(Me.LabelControl24)
        Me.PanelControl4.Controls.Add(Me.lblcnr1)
        Me.PanelControl4.Controls.Add(Me.LabelControl26)
        Me.PanelControl4.Controls.Add(Me.lblparlacen2)
        Me.PanelControl4.Controls.Add(Me.LabelControl15)
        Me.PanelControl4.Controls.Add(Me.lblparlacen1)
        Me.PanelControl4.Controls.Add(Me.labler23455)
        Me.PanelControl4.Controls.Add(Me.lbldesignados)
        Me.PanelControl4.Controls.Add(Me.label234)
        Me.PanelControl4.Controls.Add(Me.lblpresidnete)
        Me.PanelControl4.Controls.Add(Me.LabelControl21)
        Me.PanelControl4.Location = New System.Drawing.Point(0, -1)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(914, 98)
        Me.PanelControl4.TabIndex = 39
        '
        'lblregidores
        '
        Me.lblregidores.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblregidores.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblregidores.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblregidores.Location = New System.Drawing.Point(665, 33)
        Me.lblregidores.Name = "lblregidores"
        Me.lblregidores.Size = New System.Drawing.Size(38, 14)
        Me.lblregidores.TabIndex = 52
        Me.lblregidores.Text = "100%"
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl35.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl35.Location = New System.Drawing.Point(665, 14)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(61, 14)
        Me.LabelControl35.TabIndex = 51
        Me.LabelControl35.Text = "Regidores"
        '
        'lblvice
        '
        Me.lblvice.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblvice.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblvice.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblvice.Location = New System.Drawing.Point(554, 74)
        Me.lblvice.Name = "lblvice"
        Me.lblvice.Size = New System.Drawing.Size(38, 14)
        Me.lblvice.TabIndex = 50
        Me.lblvice.Text = "100%"
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl32.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl32.Location = New System.Drawing.Point(554, 54)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(65, 14)
        Me.LabelControl32.TabIndex = 49
        Me.LabelControl32.Text = "Vicealcalde"
        '
        'lblalcalde
        '
        Me.lblalcalde.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblalcalde.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblalcalde.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblalcalde.Location = New System.Drawing.Point(554, 34)
        Me.lblalcalde.Name = "lblalcalde"
        Me.lblalcalde.Size = New System.Drawing.Size(38, 14)
        Me.lblalcalde.TabIndex = 48
        Me.lblalcalde.Text = "100%"
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl34.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl34.Location = New System.Drawing.Point(554, 14)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(43, 14)
        Me.LabelControl34.TabIndex = 47
        Me.LabelControl34.Text = "Alcalde"
        '
        'lblcnr2
        '
        Me.lblcnr2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblcnr2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblcnr2.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblcnr2.Location = New System.Drawing.Point(397, 74)
        Me.lblcnr2.Name = "lblcnr2"
        Me.lblcnr2.Size = New System.Drawing.Size(38, 14)
        Me.lblcnr2.TabIndex = 42
        Me.lblcnr2.Text = "100%"
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl24.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl24.Location = New System.Drawing.Point(397, 54)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(109, 14)
        Me.LabelControl24.TabIndex = 41
        Me.LabelControl24.Text = "Dip. al CNR Suple."
        '
        'lblcnr1
        '
        Me.lblcnr1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblcnr1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblcnr1.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblcnr1.Location = New System.Drawing.Point(397, 34)
        Me.lblcnr1.Name = "lblcnr1"
        Me.lblcnr1.Size = New System.Drawing.Size(38, 14)
        Me.lblcnr1.TabIndex = 40
        Me.lblcnr1.Text = "100%"
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl26.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl26.Location = New System.Drawing.Point(397, 14)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(104, 14)
        Me.LabelControl26.TabIndex = 39
        Me.LabelControl26.Text = "Dip. al CNR Prop."
        '
        'lblparlacen2
        '
        Me.lblparlacen2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblparlacen2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblparlacen2.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblparlacen2.Location = New System.Drawing.Point(236, 74)
        Me.lblparlacen2.Name = "lblparlacen2"
        Me.lblparlacen2.Size = New System.Drawing.Size(38, 14)
        Me.lblparlacen2.TabIndex = 38
        Me.lblparlacen2.Text = "100%"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl15.Location = New System.Drawing.Point(236, 54)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(135, 14)
        Me.LabelControl15.TabIndex = 37
        Me.LabelControl15.Text = "Dip. al Parlacen Suple."
        '
        'lblparlacen1
        '
        Me.lblparlacen1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblparlacen1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblparlacen1.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblparlacen1.Location = New System.Drawing.Point(236, 34)
        Me.lblparlacen1.Name = "lblparlacen1"
        Me.lblparlacen1.Size = New System.Drawing.Size(38, 14)
        Me.lblparlacen1.TabIndex = 36
        Me.lblparlacen1.Text = "100%"
        '
        'labler23455
        '
        Me.labler23455.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.labler23455.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.labler23455.Appearance.ForeColor = System.Drawing.Color.Green
        Me.labler23455.Location = New System.Drawing.Point(236, 14)
        Me.labler23455.Name = "labler23455"
        Me.labler23455.Size = New System.Drawing.Size(130, 14)
        Me.labler23455.TabIndex = 35
        Me.labler23455.Text = "Dip. al Parlacen Prop."
        '
        'lbldesignados
        '
        Me.lbldesignados.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbldesignados.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbldesignados.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lbldesignados.Location = New System.Drawing.Point(130, 74)
        Me.lbldesignados.Name = "lbldesignados"
        Me.lbldesignados.Size = New System.Drawing.Size(38, 14)
        Me.lbldesignados.TabIndex = 34
        Me.lbldesignados.Text = "100%"
        '
        'label234
        '
        Me.label234.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.label234.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label234.Appearance.ForeColor = System.Drawing.Color.Green
        Me.label234.Location = New System.Drawing.Point(129, 54)
        Me.label234.Name = "label234"
        Me.label234.Size = New System.Drawing.Size(70, 14)
        Me.label234.TabIndex = 33
        Me.label234.Text = "Designados"
        '
        'lblpresidnete
        '
        Me.lblpresidnete.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblpresidnete.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblpresidnete.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblpresidnete.Location = New System.Drawing.Point(129, 34)
        Me.lblpresidnete.Name = "lblpresidnete"
        Me.lblpresidnete.Size = New System.Drawing.Size(38, 14)
        Me.lblpresidnete.TabIndex = 32
        Me.lblpresidnete.Text = "100%"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl21.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl21.Location = New System.Drawing.Point(129, 14)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(65, 14)
        Me.LabelControl21.TabIndex = 31
        Me.LabelControl21.Text = "Presidente"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl12.Location = New System.Drawing.Point(299, 72)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(38, 14)
        Me.LabelControl12.TabIndex = 38
        Me.LabelControl12.Text = "100%"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl13.Location = New System.Drawing.Point(299, 52)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(135, 14)
        Me.LabelControl13.TabIndex = 37
        Me.LabelControl13.Text = "Dip. al Parlacen Suple."
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl9.Location = New System.Drawing.Point(299, 32)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(38, 14)
        Me.LabelControl9.TabIndex = 36
        Me.LabelControl9.Text = "100%"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl10.Location = New System.Drawing.Point(299, 12)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(130, 14)
        Me.LabelControl10.TabIndex = 35
        Me.LabelControl10.Text = "Dip. al Parlacen Prop."
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl6.Location = New System.Drawing.Point(185, 72)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(38, 14)
        Me.LabelControl6.TabIndex = 34
        Me.LabelControl6.Text = "100%"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl7.Location = New System.Drawing.Point(184, 52)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(70, 14)
        Me.LabelControl7.TabIndex = 33
        Me.LabelControl7.Text = "Designados"
        '
        'lblporcentaje
        '
        Me.lblporcentaje.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblporcentaje.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblporcentaje.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblporcentaje.Location = New System.Drawing.Point(202, 32)
        Me.lblporcentaje.Name = "lblporcentaje"
        Me.lblporcentaje.Size = New System.Drawing.Size(38, 14)
        Me.lblporcentaje.TabIndex = 32
        Me.lblporcentaje.Text = "100%"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Green
        Me.LabelControl11.Location = New System.Drawing.Point(184, 12)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(65, 14)
        Me.LabelControl11.TabIndex = 31
        Me.LabelControl11.Text = "Presidente"
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.errorIcon
        Me.PictureEdit2.Location = New System.Drawing.Point(106, 32)
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
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.OrangeRed
        Me.LabelControl8.Location = New System.Drawing.Point(11, 12)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(167, 14)
        Me.LabelControl8.TabIndex = 24
        Me.LabelControl8.Text = "Indicadores de Verificación:"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.Ok
        Me.PictureEdit1.Location = New System.Drawing.Point(56, 32)
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
        'DUALTableAdapter
        '
        Me.DUALTableAdapter.ClearBeforeFill = True
        '
        'GCBusqueda
        '
        Me.GCBusqueda.DataSource = Me.DUALBindingSource
        Me.GCBusqueda.Location = New System.Drawing.Point(15, 146)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RIChkCoincide, Me.RIChkFima, Me.RPIImgen, Me.RepositoryItemComboBox1, Me.ChkEstado, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.chkConstancia, Me.PICImagenConstancia, Me.RepositoryItemTextEdit4})
        Me.GCBusqueda.Size = New System.Drawing.Size(924, 227)
        Me.GCBusqueda.TabIndex = 30
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Estado, Me.Fila, Me.colIDENTIDAD, Me.colIMAGEN, Me.colPrimerNombre, Me.colSegundoNombre, Me.colSegundoApellido, Me.colPrimerApellido, Me.Posicion, Me.CONS_VECINDAD, Me.CONS_VECINDAD_IMG, Me.colPRIMER_NOMBRE, Me.colPRIMER_APELLIDO, Me.colPOSICION})
        Me.GridView1.GridControl = Me.GCBusqueda
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Estado
        '
        Me.Estado.Caption = "Verificación"
        Me.Estado.ColumnEdit = Me.ChkEstado
        Me.Estado.FieldName = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.OptionsColumn.AllowEdit = False
        Me.Estado.ToolTip = "Verificar si la Información está correcta"
        Me.Estado.Visible = True
        Me.Estado.VisibleIndex = 0
        '
        'ChkEstado
        '
        Me.ChkEstado.AutoHeight = False
        Me.ChkEstado.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.PictureChecked = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.Ok
        Me.ChkEstado.PictureUnchecked = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.errorIcon
        '
        'Fila
        '
        Me.Fila.Caption = "Fila"
        Me.Fila.FieldName = "Fila"
        Me.Fila.Name = "Fila"
        Me.Fila.OptionsColumn.AllowEdit = False
        Me.Fila.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.Fila.Visible = True
        Me.Fila.VisibleIndex = 1
        Me.Fila.Width = 49
        '
        'colIDENTIDAD
        '
        Me.colIDENTIDAD.Caption = "Identidad"
        Me.colIDENTIDAD.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colIDENTIDAD.FieldName = "IDENTIDAD"
        Me.colIDENTIDAD.Name = "colIDENTIDAD"
        Me.colIDENTIDAD.Visible = True
        Me.colIDENTIDAD.VisibleIndex = 2
        Me.colIDENTIDAD.Width = 94
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.MaxLength = 15
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colIMAGEN
        '
        Me.colIMAGEN.Caption = "Imagen"
        Me.colIMAGEN.ColumnEdit = Me.RPIImgen
        Me.colIMAGEN.FieldName = "IMAGEN"
        Me.colIMAGEN.Name = "colIMAGEN"
        Me.colIMAGEN.Visible = True
        Me.colIMAGEN.VisibleIndex = 8
        Me.colIMAGEN.Width = 104
        '
        'RPIImgen
        '
        Me.RPIImgen.Name = "RPIImgen"
        Me.RPIImgen.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        '
        'colPrimerNombre
        '
        Me.colPrimerNombre.Caption = "Primer Nombre"
        Me.colPrimerNombre.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colPrimerNombre.FieldName = "PRIMER_NOMBRE"
        Me.colPrimerNombre.Name = "colPrimerNombre"
        Me.colPrimerNombre.Visible = True
        Me.colPrimerNombre.VisibleIndex = 3
        Me.colPrimerNombre.Width = 113
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.MaxLength = 50
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colSegundoNombre
        '
        Me.colSegundoNombre.Caption = "Segundo Nombre"
        Me.colSegundoNombre.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colSegundoNombre.FieldName = "SEGUNDO_NOMBRE"
        Me.colSegundoNombre.Name = "colSegundoNombre"
        Me.colSegundoNombre.Visible = True
        Me.colSegundoNombre.VisibleIndex = 4
        Me.colSegundoNombre.Width = 118
        '
        'colSegundoApellido
        '
        Me.colSegundoApellido.Caption = "Segundo Apellido"
        Me.colSegundoApellido.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colSegundoApellido.FieldName = "SEGUNDO_APELLIDO"
        Me.colSegundoApellido.Name = "colSegundoApellido"
        Me.colSegundoApellido.Visible = True
        Me.colSegundoApellido.VisibleIndex = 6
        Me.colSegundoApellido.Width = 116
        '
        'colPrimerApellido
        '
        Me.colPrimerApellido.Caption = "Primer Apellido"
        Me.colPrimerApellido.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colPrimerApellido.FieldName = "PRIMER_APELLIDO"
        Me.colPrimerApellido.Name = "colPrimerApellido"
        Me.colPrimerApellido.Visible = True
        Me.colPrimerApellido.VisibleIndex = 5
        Me.colPrimerApellido.Width = 102
        '
        'Posicion
        '
        Me.Posicion.Caption = "Posicion"
        Me.Posicion.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.Posicion.FieldName = "POSICION"
        Me.Posicion.Name = "Posicion"
        Me.Posicion.Visible = True
        Me.Posicion.VisibleIndex = 7
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'CONS_VECINDAD
        '
        Me.CONS_VECINDAD.Caption = "Constancia de Vecindad"
        Me.CONS_VECINDAD.ColumnEdit = Me.chkConstancia
        Me.CONS_VECINDAD.FieldName = "CONS_VECINDAD"
        Me.CONS_VECINDAD.Name = "CONS_VECINDAD"
        Me.CONS_VECINDAD.Visible = True
        Me.CONS_VECINDAD.VisibleIndex = 9
        Me.CONS_VECINDAD.Width = 150
        '
        'chkConstancia
        '
        Me.chkConstancia.AutoHeight = False
        Me.chkConstancia.Name = "chkConstancia"
        Me.chkConstancia.ValueGrayed = False
        '
        'CONS_VECINDAD_IMG
        '
        Me.CONS_VECINDAD_IMG.Caption = "Imagen Constancia"
        Me.CONS_VECINDAD_IMG.ColumnEdit = Me.PICImagenConstancia
        Me.CONS_VECINDAD_IMG.FieldName = "CONS_VECINDAD_IMG"
        Me.CONS_VECINDAD_IMG.Name = "CONS_VECINDAD_IMG"
        Me.CONS_VECINDAD_IMG.Visible = True
        Me.CONS_VECINDAD_IMG.VisibleIndex = 10
        Me.CONS_VECINDAD_IMG.Width = 150
        '
        'PICImagenConstancia
        '
        Me.PICImagenConstancia.Name = "PICImagenConstancia"
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
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Si", "No"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.NullText = "Seleccione"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.MaxLength = 300
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'lblPartido
        '
        Me.lblPartido.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblPartido.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartido.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblPartido.Location = New System.Drawing.Point(337, 11)
        Me.lblPartido.Name = "lblPartido"
        Me.lblPartido.Size = New System.Drawing.Size(126, 19)
        Me.lblPartido.TabIndex = 33
        Me.lblPartido.Text = "Partido Politico"
        '
        'lblMovimiento
        '
        Me.lblMovimiento.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblMovimiento.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovimiento.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblMovimiento.Location = New System.Drawing.Point(337, 56)
        Me.lblMovimiento.Name = "lblMovimiento"
        Me.lblMovimiento.Size = New System.Drawing.Size(209, 19)
        Me.lblMovimiento.TabIndex = 34
        Me.lblMovimiento.Text = "Inscripcion de Candidatos"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Location = New System.Drawing.Point(337, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(161, 25)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Partido Politico"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl4.Location = New System.Drawing.Point(337, 47)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(123, 25)
        Me.LabelControl4.TabIndex = 34
        Me.LabelControl4.Text = "Movimiento"
        '
        'IMREQUISITOSXCANDIDATOBindingSource
        '
        Me.IMREQUISITOSXCANDIDATOBindingSource.DataMember = "IM_REQUISITOS_X_CANDIDATO"
        Me.IMREQUISITOSXCANDIDATOBindingSource.DataSource = Me.DSInsCandidatos
        '
        'IM_REQUISITOS_X_CANDIDATOTableAdapter
        '
        Me.IM_REQUISITOS_X_CANDIDATOTableAdapter.ClearBeforeFill = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.gridview34
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(801, 80)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(55, 55)
        Me.SimpleButton1.TabIndex = 11
        Me.SimpleButton1.Text = "Filas"
        '
        'pctPartido
        '
        Me.pctPartido.Location = New System.Drawing.Point(278, 3)
        Me.pctPartido.Name = "pctPartido"
        Me.pctPartido.Properties.ShowMenu = False
        Me.pctPartido.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pctPartido.Size = New System.Drawing.Size(53, 42)
        Me.pctPartido.TabIndex = 35
        '
        'PicMovimiento
        '
        Me.PicMovimiento.Location = New System.Drawing.Point(278, 46)
        Me.PicMovimiento.Name = "PicMovimiento"
        Me.PicMovimiento.Properties.ShowMenu = False
        Me.PicMovimiento.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PicMovimiento.Size = New System.Drawing.Size(53, 42)
        Me.PicMovimiento.TabIndex = 36
        '
        'colPRIMER_NOMBRE
        '
        Me.colPRIMER_NOMBRE.FieldName = "PRIMER_NOMBRE"
        Me.colPRIMER_NOMBRE.Name = "colPRIMER_NOMBRE"
        Me.colPRIMER_NOMBRE.Visible = True
        Me.colPRIMER_NOMBRE.VisibleIndex = 11
        '
        'colPRIMER_APELLIDO
        '
        Me.colPRIMER_APELLIDO.FieldName = "PRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.Name = "colPRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.Visible = True
        Me.colPRIMER_APELLIDO.VisibleIndex = 12
        '
        'colPOSICION
        '
        Me.colPOSICION.FieldName = "POSICION"
        Me.colPOSICION.Name = "colPOSICION"
        Me.colPOSICION.Visible = True
        Me.colPOSICION.VisibleIndex = 13
        '
        'xfrmRegCandidatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 501)
        Me.Controls.Add(Me.PicMovimiento)
        Me.Controls.Add(Me.pctPartido)
        Me.Controls.Add(Me.lblMovimiento)
        Me.Controls.Add(Me.BtnSalirold)
        Me.Controls.Add(Me.BtnEliminariold)
        Me.Controls.Add(Me.btnguardarold)
        Me.Controls.Add(Me.lblPartido)
        Me.Controls.Add(Me.GCBusqueda)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cboCargo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cboMunicipio)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "xfrmRegCandidatos"
        Me.Text = "Inscripción de Candidatos "
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.DUALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSInsCandidatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMDEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMCARGOSELECTIVOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RPIImgen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkConstancia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICImagenConstancia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIChkCoincide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIChkFima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMREQUISITOSXCANDIDATOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPartido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnguardarold As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminariold As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSalirold As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DSInsCandidatos As Inscripcion_de_Moviemientos.DSInsCandidatos
    Friend WithEvents IMDEPARTAMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_DEPARTAMENTOSTableAdapter As Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_DEPARTAMENTOSTableAdapter
    Friend WithEvents cboDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboMunicipio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IMMUNICIPIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MUNICIPIOSTableAdapter As Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_MUNICIPIOSTableAdapter
    Friend WithEvents IMPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents IMMOVIMIENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOVIMIENTOSTableAdapter As Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_MOVIMIENTOSTableAdapter
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCargo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IMCARGOSELECTIVOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CARGOS_ELECTIVOSTableAdapter As Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_CARGOS_ELECTIVOSTableAdapter
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblporcentaje As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents DUALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DUALTableAdapter As Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.DUALTableAdapter
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Estado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkEstado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Fila As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colIMAGEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RPIImgen As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colPrimerNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colSegundoNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSegundoApellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimerApellido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Posicion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RIChkCoincide As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RIChkFima As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblPartido As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMovimiento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IMREQUISITOSXCANDIDATOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_REQUISITOS_X_CANDIDATOTableAdapter As Inscripcion_de_Moviemientos.DSInsCandidatosTableAdapters.IM_REQUISITOS_X_CANDIDATOTableAdapter
    Friend WithEvents CONS_VECINDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkConstancia As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents CONS_VECINDAD_IMG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PICImagenConstancia As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblcnr2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblcnr1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblparlacen2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblparlacen1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labler23455 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbldesignados As DevExpress.XtraEditors.LabelControl
    Friend WithEvents label234 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblpresidnete As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblvice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblalcalde As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblregidores As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pctPartido As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PicMovimiento As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents colPRIMER_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOSICION As DevExpress.XtraGrid.Columns.GridColumn
End Class
