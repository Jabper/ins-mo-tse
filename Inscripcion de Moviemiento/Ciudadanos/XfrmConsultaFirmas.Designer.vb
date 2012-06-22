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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
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
        Me.ChkMovimientos = New DevExpress.XtraEditors.CheckEdit
        Me.CmbPartido = New DevExpress.XtraEditors.LookUpEdit
        Me.TAPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPolitico = New Inscripcion_de_Moviemientos.DSPolitico
        Me.CmbMovimiento = New DevExpress.XtraEditors.LookUpEdit
        Me.TAMOVIMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbMunicipio = New DevExpress.XtraEditors.LookUpEdit
        Me.TAMUNICIPIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDeptoMuni = New Inscripcion_de_Moviemientos.DSDeptoMuni
        Me.CmbDepartamento = New DevExpress.XtraEditors.LookUpEdit
        Me.TADEPARTAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MOSTRARFIRMASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colMAQUINA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPAGINA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIMAGEN_FIRMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RPIImgfirma = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.CODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CODIGO_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFOLIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.TA_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
        Me.TA_MOVIMIENTOTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_MOVIMIENTOTableAdapter
        Me.TA_DEPARTAMENTOSTableAdapter = New Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_DEPARTAMENTOSTableAdapter
        Me.TA_MUNICIPIOSTableAdapter = New Inscripcion_de_Moviemientos.DSDeptoMuniTableAdapters.TA_MUNICIPIOSTableAdapter
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MOSTRAR_FIRMASTableAdapter = New Inscripcion_de_Moviemientos.DSCiudadanosTableAdapters.MOSTRAR_FIRMASTableAdapter
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtidentidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkMuni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkDepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbFiltro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkMovimientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbPartido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDeptoMuni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TADEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOSTRARFIRMASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCiudadanos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIChkFima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIChkCoincide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RPIImgfirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.PanelControl2)
        Me.LayoutControl1.Controls.Add(Me.PanelControl3)
        Me.LayoutControl1.Controls.Add(Me.GCBusqueda)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(451, 406, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(828, 786)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
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
        Me.PanelControl2.Location = New System.Drawing.Point(12, 676)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(775, 98)
        Me.PanelControl2.TabIndex = 15
        '
        'lblfirmasnecesarias
        '
        Me.lblfirmasnecesarias.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblfirmasnecesarias.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirmasnecesarias.Appearance.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblfirmasnecesarias.Location = New System.Drawing.Point(384, 47)
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
        Me.LabelControl12.Location = New System.Drawing.Point(348, 12)
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
        Me.lblinconsistentes.Location = New System.Drawing.Point(240, 70)
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
        Me.LabelControl10.Location = New System.Drawing.Point(222, 12)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(93, 14)
        Me.LabelControl10.TabIndex = 29
        Me.LabelControl10.Text = "Total Registros"
        '
        'lblconsistentes
        '
        Me.lblconsistentes.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblconsistentes.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconsistentes.Location = New System.Drawing.Point(240, 32)
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
        Me.LabelControl8.Size = New System.Drawing.Size(167, 14)
        Me.LabelControl8.TabIndex = 24
        Me.LabelControl8.Text = "Indicadores de Verificación:"
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
        Me.PanelControl3.Controls.Add(Me.ChkMovimientos)
        Me.PanelControl3.Controls.Add(Me.CmbPartido)
        Me.PanelControl3.Controls.Add(Me.CmbMovimiento)
        Me.PanelControl3.Controls.Add(Me.CmbMunicipio)
        Me.PanelControl3.Controls.Add(Me.CmbDepartamento)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(759, 241)
        Me.PanelControl3.TabIndex = 17
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Options.UseTextOptions = True
        Me.SimpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton3.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.SimpleButton3.Location = New System.Drawing.Point(214, 196)
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
        Me.BtnEliminar.Location = New System.Drawing.Point(112, 196)
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
        Me.BtnUpdate.Location = New System.Drawing.Point(10, 196)
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
        Me.txtidentidad.Location = New System.Drawing.Point(396, 118)
        Me.txtidentidad.Name = "txtidentidad"
        Me.txtidentidad.Properties.MaxLength = 15
        Me.txtidentidad.Size = New System.Drawing.Size(152, 20)
        Me.txtidentidad.TabIndex = 43
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(322, 118)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl9.TabIndex = 42
        Me.LabelControl9.Text = "Identidad:"
        '
        'ChkMuni
        '
        Me.ChkMuni.Location = New System.Drawing.Point(299, 81)
        Me.ChkMuni.Name = "ChkMuni"
        Me.ChkMuni.Properties.Caption = ""
        Me.ChkMuni.Size = New System.Drawing.Size(16, 19)
        Me.ChkMuni.TabIndex = 41
        '
        'ChkDepto
        '
        Me.ChkDepto.Location = New System.Drawing.Point(19, 81)
        Me.ChkDepto.Name = "ChkDepto"
        Me.ChkDepto.Properties.Caption = ""
        Me.ChkDepto.Size = New System.Drawing.Size(16, 19)
        Me.ChkDepto.TabIndex = 40
        '
        'BtnReestablecer
        '
        Me.BtnReestablecer.Location = New System.Drawing.Point(423, 161)
        Me.BtnReestablecer.Name = "BtnReestablecer"
        Me.BtnReestablecer.Size = New System.Drawing.Size(125, 22)
        Me.BtnReestablecer.TabIndex = 35
        Me.BtnReestablecer.Text = "Cancelar Filtro"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(41, 83)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl5.TabIndex = 39
        Me.LabelControl5.Text = "Departamento"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(286, 161)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(125, 22)
        Me.SimpleButton1.TabIndex = 30
        Me.SimpleButton1.Text = "Realizar Busqueda"
        '
        'CmbFiltro
        '
        Me.CmbFiltro.EditValue = "Ninguno"
        Me.CmbFiltro.Location = New System.Drawing.Point(133, 115)
        Me.CmbFiltro.Name = "CmbFiltro"
        Me.CmbFiltro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbFiltro.Properties.Items.AddRange(New Object() {"Ninguno", "Consistentes", "Inconsistentes"})
        Me.CmbFiltro.Size = New System.Drawing.Size(157, 20)
        Me.CmbFiltro.TabIndex = 31
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(41, 118)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Estado:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(322, 83)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl4.TabIndex = 38
        Me.LabelControl4.Text = "Municipio"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(322, 47)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl3.TabIndex = 37
        Me.LabelControl3.Text = "Movimiento"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(41, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl2.TabIndex = 36
        Me.LabelControl2.Text = "Partido"
        '
        'ChkMovimientos
        '
        Me.ChkMovimientos.Location = New System.Drawing.Point(19, 22)
        Me.ChkMovimientos.Name = "ChkMovimientos"
        Me.ChkMovimientos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMovimientos.Properties.Appearance.Options.UseFont = True
        Me.ChkMovimientos.Properties.Caption = "Filtrar por Movimiento"
        Me.ChkMovimientos.Size = New System.Drawing.Size(380, 19)
        Me.ChkMovimientos.TabIndex = 33
        '
        'CmbPartido
        '
        Me.CmbPartido.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TAPARTIDOSPOLITICOSBindingSource, "CODIGO_PARTIDO", True))
        Me.CmbPartido.Enabled = False
        Me.CmbPartido.Location = New System.Drawing.Point(133, 44)
        Me.CmbPartido.Name = "CmbPartido"
        Me.CmbPartido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbPartido.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_PARTIDO", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "Partido", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.CmbPartido.Properties.DataSource = Me.TAPARTIDOSPOLITICOSBindingSource
        Me.CmbPartido.Properties.DisplayMember = "NOMBRE"
        Me.CmbPartido.Properties.NullText = "Seleccione"
        Me.CmbPartido.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.CmbPartido.Size = New System.Drawing.Size(157, 20)
        Me.CmbPartido.TabIndex = 26
        '
        'TAPARTIDOSPOLITICOSBindingSource
        '
        Me.TAPARTIDOSPOLITICOSBindingSource.DataMember = "TA_PARTIDOS_POLITICOS"
        Me.TAPARTIDOSPOLITICOSBindingSource.DataSource = Me.DSPolitico
        '
        'DSPolitico
        '
        Me.DSPolitico.DataSetName = "DSPolitico"
        Me.DSPolitico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbMovimiento
        '
        Me.CmbMovimiento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TAMOVIMIENTOBindingSource, "CODIGO_MOVIMIENTO", True))
        Me.CmbMovimiento.Enabled = False
        Me.CmbMovimiento.Location = New System.Drawing.Point(396, 47)
        Me.CmbMovimiento.Name = "CmbMovimiento"
        Me.CmbMovimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMovimiento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MOVIMIENTO", "CODIGO_MOVIMIENTO", 135, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE_MOVIMIENTO", "Movimiento", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.CmbMovimiento.Properties.DataSource = Me.TAMOVIMIENTOBindingSource
        Me.CmbMovimiento.Properties.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.CmbMovimiento.Properties.NullText = "Seleccione"
        Me.CmbMovimiento.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        Me.CmbMovimiento.Size = New System.Drawing.Size(152, 20)
        Me.CmbMovimiento.TabIndex = 27
        '
        'TAMOVIMIENTOBindingSource
        '
        Me.TAMOVIMIENTOBindingSource.DataMember = "TA_MOVIMIENTO"
        Me.TAMOVIMIENTOBindingSource.DataSource = Me.DSPolitico
        '
        'CmbMunicipio
        '
        Me.CmbMunicipio.Enabled = False
        Me.CmbMunicipio.Location = New System.Drawing.Point(396, 84)
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
        Me.CmbDepartamento.Location = New System.Drawing.Point(133, 80)
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
        'GCBusqueda
        '
        Me.GCBusqueda.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GCBusqueda.DataSource = Me.MOSTRARFIRMASBindingSource
        Me.GCBusqueda.Location = New System.Drawing.Point(12, 257)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RIChkCoincide, Me.RIChkFima, Me.RPIImgfirma, Me.RepositoryItemComboBox1, Me.ChkEstado, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemMemoEdit1, Me.RepositoryItemTextEdit3, Me.RepositoryItemPictureEdit1})
        Me.GCBusqueda.Size = New System.Drawing.Size(804, 415)
        Me.GCBusqueda.TabIndex = 8
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MOSTRARFIRMASBindingSource
        '
        Me.MOSTRARFIRMASBindingSource.DataMember = "MOSTRAR_FIRMAS"
        Me.MOSTRARFIRMASBindingSource.DataSource = Me.DSCiudadanos
        '
        'DSCiudadanos
        '
        Me.DSCiudadanos.DataSetName = "DSCiudadanos"
        Me.DSCiudadanos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_CUIDADANOS_RESPALDAN, Me.colCONSISTENTE, Me.colIDENTIDAD, Me.colPRIMER_NOMBRE_PAPELETA, Me.colSEGUNDO_NOMBRE_PAPELETA, Me.colPRIMER_APELLIDO_PAPELETA, Me.colSEGUNDO_APELLIDO_PAPELETA, Me.colFIRMA, Me.colHUELLA, Me.colDIRECCION, Me.colNOMBRE_IGUAL, Me.colOBSERVACION, Me.colMAQUINA, Me.colPAGINA, Me.colIMAGEN_FIRMA, Me.CODIGO_PARTIDO, Me.CODIGO_MOVIMIENTO, Me.colCODIGO_DEPARTAMENTO, Me.colCODIGO_MUNICIPIO, Me.colFOLIO, Me.colDEPARTAMENTO, Me.colMUNICIPIO, Me.colNOMBRE, Me.colNOMBRE_MOVIMIENTO})
        Me.GridView1.GridControl = Me.GCBusqueda
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
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
        Me.colIDENTIDAD.Width = 88
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RepositoryItemTextEdit1.MaxLength = 15
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
        Me.colPRIMER_NOMBRE_PAPELETA.Width = 124
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
        Me.colHUELLA.Width = 48
        '
        'colDIRECCION
        '
        Me.colDIRECCION.Caption = "Dirección"
        Me.colDIRECCION.ColumnEdit = Me.RIChkFima
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        Me.colDIRECCION.Visible = True
        Me.colDIRECCION.VisibleIndex = 8
        Me.colDIRECCION.Width = 92
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
        Me.colOBSERVACION.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colOBSERVACION.FieldName = "OBSERVACION"
        Me.colOBSERVACION.Name = "colOBSERVACION"
        Me.colOBSERVACION.OptionsColumn.ReadOnly = True
        Me.colOBSERVACION.Visible = True
        Me.colOBSERVACION.VisibleIndex = 16
        Me.colOBSERVACION.Width = 93
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
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
        Me.colPAGINA.VisibleIndex = 11
        '
        'colIMAGEN_FIRMA
        '
        Me.colIMAGEN_FIRMA.Caption = "Imágen Firma"
        Me.colIMAGEN_FIRMA.ColumnEdit = Me.RPIImgfirma
        Me.colIMAGEN_FIRMA.FieldName = "IMAGEN_FIRMA"
        Me.colIMAGEN_FIRMA.Name = "colIMAGEN_FIRMA"
        Me.colIMAGEN_FIRMA.Visible = True
        Me.colIMAGEN_FIRMA.VisibleIndex = 9
        Me.colIMAGEN_FIRMA.Width = 83
        '
        'RPIImgfirma
        '
        Me.RPIImgfirma.Name = "RPIImgfirma"
        Me.RPIImgfirma.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.RPIImgfirma.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
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
        Me.colFOLIO.VisibleIndex = 10
        Me.colFOLIO.Width = 53
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.OptionsColumn.AllowEdit = False
        Me.colDEPARTAMENTO.Visible = True
        Me.colDEPARTAMENTO.VisibleIndex = 12
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.Caption = "Municipio"
        Me.colMUNICIPIO.FieldName = "MUNICIPIO"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.OptionsColumn.AllowEdit = False
        Me.colMUNICIPIO.Visible = True
        Me.colMUNICIPIO.VisibleIndex = 13
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "Partido Político"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.OptionsColumn.AllowEdit = False
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 14
        Me.colNOMBRE.Width = 97
        '
        'colNOMBRE_MOVIMIENTO
        '
        Me.colNOMBRE_MOVIMIENTO.Caption = "Movimiento"
        Me.colNOMBRE_MOVIMIENTO.FieldName = "NOMBRE_MOVIMIENTO"
        Me.colNOMBRE_MOVIMIENTO.Name = "colNOMBRE_MOVIMIENTO"
        Me.colNOMBRE_MOVIMIENTO.OptionsColumn.AllowEdit = False
        Me.colNOMBRE_MOVIMIENTO.Visible = True
        Me.colNOMBRE_MOVIMIENTO.VisibleIndex = 15
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Si", "No"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.NullText = "Seleccione"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.InitialImage = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.guardar1
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.ShowMenu = False
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCBusqueda
        Me.GridView2.Name = "GridView2"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem3, Me.LayoutControlItem2, Me.LayoutControlItem10, Me.EmptySpaceItem1, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(828, 786)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(779, 664)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(29, 102)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(29, 102)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(29, 102)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GCBusqueda
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 245)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(808, 419)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.PanelControl3
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(763, 245)
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(763, 0)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(45, 245)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(45, 245)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(45, 245)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PanelControl2
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 664)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(779, 102)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
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
        'MOSTRAR_FIRMASTableAdapter
        '
        Me.MOSTRAR_FIRMASTableAdapter.ClearBeforeFill = True
        '
        'XfrmConsultaFirmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 786)
        Me.Controls.Add(Me.LayoutControl1)
        Me.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.Name = "XfrmConsultaFirmas"
        Me.Text = "Modificación de firmas"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtidentidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkMuni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkDepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbFiltro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkMovimientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbPartido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAMUNICIPIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDeptoMuni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TADEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOSTRARFIRMASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCiudadanos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIChkFima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIChkCoincide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RPIImgfirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RIChkCoincide As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RIChkFima As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RPIImgfirma As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
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
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ChkEstado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
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
    Friend WithEvents CODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CODIGO_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colFOLIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MOSTRARFIRMASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MOSTRAR_FIRMASTableAdapter As Inscripcion_de_Moviemientos.DSCiudadanosTableAdapters.MOSTRAR_FIRMASTableAdapter
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
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
    Friend WithEvents ChkMovimientos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CmbPartido As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CmbMovimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CmbMunicipio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CmbDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
