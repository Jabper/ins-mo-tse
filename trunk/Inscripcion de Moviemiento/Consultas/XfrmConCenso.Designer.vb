<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmConCenso
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
        Me.cbxMunicipio = New System.Windows.Forms.ComboBox
        Me.IMFK1MUNICIPIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSConsultas = New Inscripcion_de_Moviemientos.DSConsultas
        Me.cbxDepartamento = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPNombre = New System.Windows.Forms.TextBox
        Me.dtdHasta = New DevExpress.XtraEditors.DateEdit
        Me.dtdDesde = New DevExpress.XtraEditors.DateEdit
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
        Me.cbxGenero = New System.Windows.Forms.ComboBox
        Me.GenerosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnFiltro = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNUMERO_IDENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIMER_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSEGUNDO_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPRIMER_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSEGUNDO_APELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGENERO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_NACIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GenerosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.GenerosTableAdapter
        Me.DepartamentosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.DepartamentosTableAdapter
        Me.MunicipiosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MunicipiosTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.IMFK1MUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtdHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtdHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtdDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtdDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxMunicipio)
        Me.GroupBox1.Controls.Add(Me.cbxDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPNombre)
        Me.GroupBox1.Controls.Add(Me.dtdHasta)
        Me.GroupBox1.Controls.Add(Me.dtdDesde)
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
        Me.GroupBox1.Controls.Add(Me.cbxGenero)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 176)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'cbxMunicipio
        '
        Me.cbxMunicipio.DataSource = Me.IMFK1MUNICIPIOBindingSource
        Me.cbxMunicipio.DisplayMember = "DESCRIPCION"
        Me.cbxMunicipio.FormattingEnabled = True
        Me.cbxMunicipio.Location = New System.Drawing.Point(596, 141)
        Me.cbxMunicipio.Name = "cbxMunicipio"
        Me.cbxMunicipio.Size = New System.Drawing.Size(397, 21)
        Me.cbxMunicipio.TabIndex = 9
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
        'DSConsultas
        '
        Me.DSConsultas.DataSetName = "DSConsultas"
        Me.DSConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxDepartamento
        '
        Me.cbxDepartamento.DataSource = Me.DepartamentosBindingSource
        Me.cbxDepartamento.DisplayMember = "DESCRIPCION"
        Me.cbxDepartamento.FormattingEnabled = True
        Me.cbxDepartamento.Location = New System.Drawing.Point(596, 114)
        Me.cbxDepartamento.Name = "cbxDepartamento"
        Me.cbxDepartamento.Size = New System.Drawing.Size(397, 21)
        Me.cbxDepartamento.TabIndex = 8
        Me.cbxDepartamento.ValueMember = "CODIGO_DEPARTAMENTO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(787, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Hasta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(499, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Fecha Nacimiento"
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
        Me.txtPNombre.Size = New System.Drawing.Size(361, 21)
        Me.txtPNombre.TabIndex = 1
        '
        'dtdHasta
        '
        Me.dtdHasta.EditValue = Nothing
        Me.dtdHasta.Location = New System.Drawing.Point(828, 88)
        Me.dtdHasta.Name = "dtdHasta"
        Me.dtdHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtdHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtdHasta.Size = New System.Drawing.Size(165, 20)
        Me.dtdHasta.TabIndex = 7
        '
        'dtdDesde
        '
        Me.dtdDesde.EditValue = Nothing
        Me.dtdDesde.Location = New System.Drawing.Point(596, 88)
        Me.dtdDesde.Name = "dtdDesde"
        Me.dtdDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtdDesde.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtdDesde.Size = New System.Drawing.Size(165, 20)
        Me.dtdDesde.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(514, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Departamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(548, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Género"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(111, 20)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(361, 21)
        Me.txtIdentidad.TabIndex = 0
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
        Me.txtSApellido.Size = New System.Drawing.Size(361, 21)
        Me.txtSApellido.TabIndex = 4
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
        Me.txtPApellido.Size = New System.Drawing.Size(361, 21)
        Me.txtPApellido.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(540, 144)
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
        Me.txtSNombre.Size = New System.Drawing.Size(361, 21)
        Me.txtSNombre.TabIndex = 2
        '
        'cbxGenero
        '
        Me.cbxGenero.DataSource = Me.GenerosBindingSource
        Me.cbxGenero.DisplayMember = "DES"
        Me.cbxGenero.FormattingEnabled = True
        Me.cbxGenero.Location = New System.Drawing.Point(596, 60)
        Me.cbxGenero.Name = "cbxGenero"
        Me.cbxGenero.Size = New System.Drawing.Size(165, 21)
        Me.cbxGenero.TabIndex = 5
        Me.cbxGenero.ValueMember = "COD"
        '
        'GenerosBindingSource
        '
        Me.GenerosBindingSource.DataMember = "Generos"
        Me.GenerosBindingSource.DataSource = Me.DSConsultas
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
        'GCBusqueda
        '
        Me.GCBusqueda.Location = New System.Drawing.Point(12, 264)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.Size = New System.Drawing.Size(1038, 490)
        Me.GCBusqueda.TabIndex = 15
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNUMERO_IDENTIDAD, Me.colPRIMER_NOMBRE, Me.colSEGUNDO_NOMBRE, Me.colPRIMER_APELLIDO, Me.colSEGUNDO_APELLIDO, Me.colGENERO, Me.colFECHA_NACIMIENTO, Me.colDEPARTAMENTO, Me.colMUNICIPIO})
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
        'colNUMERO_IDENTIDAD
        '
        Me.colNUMERO_IDENTIDAD.Caption = "No. Identificación"
        Me.colNUMERO_IDENTIDAD.FieldName = "NUMERO_IDENTIDAD"
        Me.colNUMERO_IDENTIDAD.Name = "colNUMERO_IDENTIDAD"
        Me.colNUMERO_IDENTIDAD.OptionsColumn.AllowEdit = False
        Me.colNUMERO_IDENTIDAD.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colNUMERO_IDENTIDAD.Visible = True
        Me.colNUMERO_IDENTIDAD.VisibleIndex = 0
        Me.colNUMERO_IDENTIDAD.Width = 100
        '
        'colPRIMER_NOMBRE
        '
        Me.colPRIMER_NOMBRE.Caption = "Primer Nombre"
        Me.colPRIMER_NOMBRE.FieldName = "PRIMER_NOMBRE"
        Me.colPRIMER_NOMBRE.Name = "colPRIMER_NOMBRE"
        Me.colPRIMER_NOMBRE.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colPRIMER_NOMBRE.Visible = True
        Me.colPRIMER_NOMBRE.VisibleIndex = 1
        Me.colPRIMER_NOMBRE.Width = 100
        '
        'colSEGUNDO_NOMBRE
        '
        Me.colSEGUNDO_NOMBRE.Caption = "Segundo Nombre"
        Me.colSEGUNDO_NOMBRE.FieldName = "SEGUNDO_NOMBRE"
        Me.colSEGUNDO_NOMBRE.Name = "colSEGUNDO_NOMBRE"
        Me.colSEGUNDO_NOMBRE.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colSEGUNDO_NOMBRE.Visible = True
        Me.colSEGUNDO_NOMBRE.VisibleIndex = 2
        Me.colSEGUNDO_NOMBRE.Width = 100
        '
        'colPRIMER_APELLIDO
        '
        Me.colPRIMER_APELLIDO.Caption = "Primer Apellido"
        Me.colPRIMER_APELLIDO.FieldName = "PRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.Name = "colPRIMER_APELLIDO"
        Me.colPRIMER_APELLIDO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colPRIMER_APELLIDO.Visible = True
        Me.colPRIMER_APELLIDO.VisibleIndex = 3
        Me.colPRIMER_APELLIDO.Width = 100
        '
        'colSEGUNDO_APELLIDO
        '
        Me.colSEGUNDO_APELLIDO.Caption = "Segundo Apellido"
        Me.colSEGUNDO_APELLIDO.FieldName = "SEGUNDO_APELLIDO"
        Me.colSEGUNDO_APELLIDO.Name = "colSEGUNDO_APELLIDO"
        Me.colSEGUNDO_APELLIDO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colSEGUNDO_APELLIDO.Visible = True
        Me.colSEGUNDO_APELLIDO.VisibleIndex = 4
        Me.colSEGUNDO_APELLIDO.Width = 100
        '
        'colGENERO
        '
        Me.colGENERO.Caption = "Género"
        Me.colGENERO.FieldName = "GENERO"
        Me.colGENERO.Name = "colGENERO"
        Me.colGENERO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colGENERO.Visible = True
        Me.colGENERO.VisibleIndex = 5
        Me.colGENERO.Width = 100
        '
        'colFECHA_NACIMIENTO
        '
        Me.colFECHA_NACIMIENTO.Caption = "Fecha Nacimiento"
        Me.colFECHA_NACIMIENTO.FieldName = "FECHA_NACIMIENTO"
        Me.colFECHA_NACIMIENTO.Name = "colFECHA_NACIMIENTO"
        Me.colFECHA_NACIMIENTO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colFECHA_NACIMIENTO.Visible = True
        Me.colFECHA_NACIMIENTO.VisibleIndex = 8
        Me.colFECHA_NACIMIENTO.Width = 100
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colDEPARTAMENTO.Visible = True
        Me.colDEPARTAMENTO.VisibleIndex = 6
        Me.colDEPARTAMENTO.Width = 100
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.Caption = "Municipio"
        Me.colMUNICIPIO.FieldName = "MUNICIPIO"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colMUNICIPIO.Visible = True
        Me.colMUNICIPIO.VisibleIndex = 7
        Me.colMUNICIPIO.Width = 100
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'GenerosTableAdapter
        '
        Me.GenerosTableAdapter.ClearBeforeFill = True
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'MunicipiosTableAdapter
        '
        Me.MunicipiosTableAdapter.ClearBeforeFill = True
        '
        'XfrmConCenso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 766)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GCBusqueda)
        Me.Name = "XfrmConCenso"
        Me.Text = "XfrmConCenso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IMFK1MUNICIPIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtdHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtdHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtdDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtdDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSNombre As System.Windows.Forms.TextBox
    Friend WithEvents cbxGenero As System.Windows.Forms.ComboBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnFiltro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNUMERO_IDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIMER_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEGUNDO_APELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGENERO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_NACIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtdHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtdDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPNombre As System.Windows.Forms.TextBox
    Friend WithEvents cbxMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents colMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DSConsultas As Inscripcion_de_Moviemientos.DSConsultas
    Friend WithEvents GenerosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GenerosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.GenerosTableAdapter
    Friend WithEvents DepartamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartamentosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.DepartamentosTableAdapter
    Friend WithEvents IMFK1MUNICIPIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MunicipiosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.MunicipiosTableAdapter
End Class
