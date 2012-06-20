<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmCiudadanosInhabilitados
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNUMERO_IDENTIFICACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIMER_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSEGUNDO_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPEDENCIA_GUBERNAMENTAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCARGO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHABILITADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_HABILITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colADICIONADO_POR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_ADICION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMODIFICADO_POR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_MODIFICACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCargo = New System.Windows.Forms.TextBox
        Me.cbxMotivo = New System.Windows.Forms.ComboBox
        Me.txtDependenciaGubernamental = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox
        Me.txtNumeroIdentidad = New System.Windows.Forms.TextBox
        Me.txtNombres = New System.Windows.Forms.TextBox
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnFiltrar = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.DSConsultas = New Inscripcion_de_Moviemientos.DSConsultas
        Me.IMMOTIVOSINHABILITACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_MOTIVOS_INHABILITACIONTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.IM_MOTIVOS_INHABILITACIONTableAdapter
        Me.IMCIUDADANOSINHABILITADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_CIUDADANOS_INHABILITADOSTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.IM_CIUDADANOS_INHABILITADOSTableAdapter
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMOTIVOSINHABILITACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMCIUDADANOSINHABILITADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCBusqueda
        '
        Me.GCBusqueda.DataSource = Me.IMCIUDADANOSINHABILITADOSBindingSource
        Me.GCBusqueda.Location = New System.Drawing.Point(13, 224)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.Size = New System.Drawing.Size(996, 329)
        Me.GCBusqueda.TabIndex = 8
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNUMERO_IDENTIFICACION, Me.colNOMBRES, Me.colPRIMER_APELLIDO, Me.colSEGUNDO_APELLIDO, Me.colDEPEDENCIA_GUBERNAMENTAL, Me.colCARGO, Me.colCODIGO_MOTIVO, Me.colHABILITADO, Me.colFECHA_HABILITACION, Me.colADICIONADO_POR, Me.colFECHA_ADICION, Me.colMODIFICADO_POR, Me.colFECHA_MODIFICACION})
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
        Me.colNUMERO_IDENTIFICACION.FieldName = "NUMERO_IDENTIFICACION"
        Me.colNUMERO_IDENTIFICACION.Name = "colNUMERO_IDENTIFICACION"
        Me.colNUMERO_IDENTIFICACION.Visible = True
        Me.colNUMERO_IDENTIFICACION.VisibleIndex = 0
        '
        'colNOMBRES
        '
        Me.colNOMBRES.FieldName = "NOMBRES"
        Me.colNOMBRES.Name = "colNOMBRES"
        Me.colNOMBRES.Visible = True
        Me.colNOMBRES.VisibleIndex = 1
        '
        'colPRIMER_APELLIDO
        '
        Me.colPRIMER_APELLIDO.FieldName = "PRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.Name = "colPRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.Visible = True
        Me.colPRIMER_APELLIDO.VisibleIndex = 2
        '
        'colSEGUNDO_APELLIDO
        '
        Me.colSEGUNDO_APELLIDO.FieldName = "SEGUNDO_APELLIDO"
        Me.colSEGUNDO_APELLIDO.Name = "colSEGUNDO_APELLIDO"
        Me.colSEGUNDO_APELLIDO.Visible = True
        Me.colSEGUNDO_APELLIDO.VisibleIndex = 3
        '
        'colDEPEDENCIA_GUBERNAMENTAL
        '
        Me.colDEPEDENCIA_GUBERNAMENTAL.FieldName = "DEPEDENCIA_GUBERNAMENTAL"
        Me.colDEPEDENCIA_GUBERNAMENTAL.Name = "colDEPEDENCIA_GUBERNAMENTAL"
        Me.colDEPEDENCIA_GUBERNAMENTAL.Visible = True
        Me.colDEPEDENCIA_GUBERNAMENTAL.VisibleIndex = 4
        '
        'colCARGO
        '
        Me.colCARGO.FieldName = "CARGO"
        Me.colCARGO.Name = "colCARGO"
        Me.colCARGO.Visible = True
        Me.colCARGO.VisibleIndex = 5
        '
        'colCODIGO_MOTIVO
        '
        Me.colCODIGO_MOTIVO.FieldName = "CODIGO_MOTIVO"
        Me.colCODIGO_MOTIVO.Name = "colCODIGO_MOTIVO"
        Me.colCODIGO_MOTIVO.Visible = True
        Me.colCODIGO_MOTIVO.VisibleIndex = 6
        '
        'colHABILITADO
        '
        Me.colHABILITADO.FieldName = "HABILITADO"
        Me.colHABILITADO.Name = "colHABILITADO"
        Me.colHABILITADO.Visible = True
        Me.colHABILITADO.VisibleIndex = 7
        '
        'colFECHA_HABILITACION
        '
        Me.colFECHA_HABILITACION.FieldName = "FECHA_HABILITACION"
        Me.colFECHA_HABILITACION.Name = "colFECHA_HABILITACION"
        Me.colFECHA_HABILITACION.Visible = True
        Me.colFECHA_HABILITACION.VisibleIndex = 8
        '
        'colADICIONADO_POR
        '
        Me.colADICIONADO_POR.FieldName = "ADICIONADO_POR"
        Me.colADICIONADO_POR.Name = "colADICIONADO_POR"
        Me.colADICIONADO_POR.Visible = True
        Me.colADICIONADO_POR.VisibleIndex = 9
        '
        'colFECHA_ADICION
        '
        Me.colFECHA_ADICION.FieldName = "FECHA_ADICION"
        Me.colFECHA_ADICION.Name = "colFECHA_ADICION"
        Me.colFECHA_ADICION.Visible = True
        Me.colFECHA_ADICION.VisibleIndex = 10
        '
        'colMODIFICADO_POR
        '
        Me.colMODIFICADO_POR.FieldName = "MODIFICADO_POR"
        Me.colMODIFICADO_POR.Name = "colMODIFICADO_POR"
        Me.colMODIFICADO_POR.Visible = True
        Me.colMODIFICADO_POR.VisibleIndex = 11
        '
        'colFECHA_MODIFICACION
        '
        Me.colFECHA_MODIFICACION.FieldName = "FECHA_MODIFICACION"
        Me.colFECHA_MODIFICACION.Name = "colFECHA_MODIFICACION"
        Me.colFECHA_MODIFICACION.Visible = True
        Me.colFECHA_MODIFICACION.VisibleIndex = 12
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(546, 99)
        Me.LayoutControlGroup2.Text = "Root"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(546, 99)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AllowCustomizeChildren = False
        Me.LayoutControlGroup3.CustomizationFormText = "Root"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(570, 372)
        Me.LayoutControlGroup3.Text = "Root"
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AllowCustomizeChildren = False
        Me.LayoutControlGroup4.CustomizationFormText = "Root"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "Root"
        Me.LayoutControlGroup4.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(570, 372)
        Me.LayoutControlGroup4.Text = "Root"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCargo)
        Me.GroupBox1.Controls.Add(Me.cbxMotivo)
        Me.GroupBox1.Controls.Add(Me.txtDependenciaGubernamental)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPrimerApellido)
        Me.GroupBox1.Controls.Add(Me.txtNumeroIdentidad)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.txtSegundoApellido)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(996, 134)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(495, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Motivo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(498, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Cargo"
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(540, 47)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(278, 21)
        Me.txtCargo.TabIndex = 33
        '
        'cbxMotivo
        '
        Me.cbxMotivo.DataSource = Me.IMMOTIVOSINHABILITACIONBindingSource
        Me.cbxMotivo.DisplayMember = "DESCRIPCION"
        Me.cbxMotivo.FormattingEnabled = True
        Me.cbxMotivo.Location = New System.Drawing.Point(540, 73)
        Me.cbxMotivo.Name = "cbxMotivo"
        Me.cbxMotivo.Size = New System.Drawing.Size(279, 21)
        Me.cbxMotivo.TabIndex = 31
        Me.cbxMotivo.ValueMember = "CODIGO_MOTIVO"
        '
        'txtDependenciaGubernamental
        '
        Me.txtDependenciaGubernamental.Location = New System.Drawing.Point(540, 20)
        Me.txtDependenciaGubernamental.Name = "txtDependenciaGubernamental"
        Me.txtDependenciaGubernamental.Size = New System.Drawing.Size(278, 21)
        Me.txtDependenciaGubernamental.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Dependencia Gubernamental"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Segundo Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Primer Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Número Identidad"
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(105, 74)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(278, 21)
        Me.txtPrimerApellido.TabIndex = 24
        '
        'txtNumeroIdentidad
        '
        Me.txtNumeroIdentidad.Location = New System.Drawing.Point(105, 20)
        Me.txtNumeroIdentidad.Name = "txtNumeroIdentidad"
        Me.txtNumeroIdentidad.Size = New System.Drawing.Size(278, 21)
        Me.txtNumeroIdentidad.TabIndex = 23
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(105, 47)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(278, 21)
        Me.txtNombres.TabIndex = 22
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(105, 101)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(278, 21)
        Me.txtSegundoApellido.TabIndex = 21
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelControl1.Location = New System.Drawing.Point(13, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(996, 64)
        Me.PanelControl1.TabIndex = 35
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFiltrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(248, 64)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnFiltrar.Appearance.Options.UseFont = True
        Me.btnFiltrar.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources._new
        Me.btnFiltrar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnFiltrar.Location = New System.Drawing.Point(3, 3)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(55, 55)
        Me.btnFiltrar.TabIndex = 0
        Me.btnFiltrar.Text = "Filtrar"
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
        Me.btnSalir.Text = "Salir"
        '
        'DSConsultas
        '
        Me.DSConsultas.DataSetName = "DSConsultas"
        Me.DSConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IMMOTIVOSINHABILITACIONBindingSource
        '
        Me.IMMOTIVOSINHABILITACIONBindingSource.DataMember = "IM_MOTIVOS_INHABILITACION"
        Me.IMMOTIVOSINHABILITACIONBindingSource.DataSource = Me.DSConsultas
        '
        'IM_MOTIVOS_INHABILITACIONTableAdapter
        '
        Me.IM_MOTIVOS_INHABILITACIONTableAdapter.ClearBeforeFill = True
        '
        'IMCIUDADANOSINHABILITADOSBindingSource
        '
        Me.IMCIUDADANOSINHABILITADOSBindingSource.DataMember = "IM_CIUDADANOS_INHABILITADOS"
        Me.IMCIUDADANOSINHABILITADOSBindingSource.DataSource = Me.DSConsultas
        '
        'IM_CIUDADANOS_INHABILITADOSTableAdapter
        '
        Me.IM_CIUDADANOS_INHABILITADOSTableAdapter.ClearBeforeFill = True
        '
        'XfrmCiudadanosInhabilitados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 565)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GCBusqueda)
        Me.Name = "XfrmCiudadanosInhabilitados"
        Me.Text = "XfrmCiudadanosInhabilitados"
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMOTIVOSINHABILITACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMCIUDADANOSINHABILITADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNUMERO_IDENTIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPEDENCIA_GUBERNAMENTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHABILITADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_HABILITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADICIONADO_POR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_ADICION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMODIFICADO_POR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_MODIFICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDependenciaGubernamental As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroIdentidad As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnFiltrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DSConsultas As Inscripcion_de_Moviemientos.DSConsultas
    Friend WithEvents IMMOTIVOSINHABILITACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOTIVOS_INHABILITACIONTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.IM_MOTIVOS_INHABILITACIONTableAdapter
    Friend WithEvents IMCIUDADANOSINHABILITADOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_CIUDADANOS_INHABILITADOSTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.IM_CIUDADANOS_INHABILITADOSTableAdapter
End Class
