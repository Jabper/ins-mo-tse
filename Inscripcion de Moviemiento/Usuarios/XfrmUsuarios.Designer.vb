<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmUsuarios
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.BtnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.BtnNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
        Me.NOMBRETextEdit = New DevExpress.XtraEditors.TextEdit
        Me.IMUSUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTUsers = New Inscripcion_de_Moviemientos.DTUsers
        Me.IDENTIDADTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.CONTRASENATextEdit = New DevExpress.XtraEditors.TextEdit
        Me.RESPUESTA_SEGURIDADTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.ADICIONADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.FECHA_ADICIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.MODIFICADO_PORSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.FECHA_MODIFICACIONDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.CODIGO_ROLSpinEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.TAROLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CODIGO_PARTIDOSpinEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.TAPARTIDOSPOLITICOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPolitico = New Inscripcion_de_Moviemientos.DSPolitico
        Me.PREGUNTA_SEGURIDADTextEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.CODIGO_USUARIOSpinEdit = New DevExpress.XtraEditors.TextEdit
        Me.CODIGO_MOVIMIENTOSpinEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.TAMOVIMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESTADOTextEdit = New DevExpress.XtraEditors.CheckEdit
        Me.NIVELSpinEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.ItemForADICIONADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_ADICION = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForMODIFICADO_POR = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForFECHA_MODIFICACION = New DevExpress.XtraLayout.LayoutControlItem
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.ItemForCODIGO_USUARIO = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_ROL = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForPREGUNTA_SEGURIDAD = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForRESPUESTA_SEGURIDAD = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForNOMBRE = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForIDENTIDAD = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCONTRASENA = New DevExpress.XtraLayout.LayoutControlItem
        Me.ItemForCODIGO_PARTIDO = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.ItemForCODIGO_MOVIMIENTO = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.ItemForESTADO = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.GCBusqueda = New DevExpress.XtraGrid.GridControl
        Me.DTUSUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_USUARIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colNOMBRE_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colROL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIDENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNIVEL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.IM_USUARIOSTableAdapter = New Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_USUARIOSTableAdapter
        Me.TA_ROLESTableAdapter = New Inscripcion_de_Moviemientos.DTUsersTableAdapters.TA_ROLESTableAdapter
        Me.DT_USUARIOSTableAdapter = New Inscripcion_de_Moviemientos.DTUsersTableAdapters.DT_USUARIOSTableAdapter
        Me.TA_PARTIDOS_POLITICOSTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
        Me.TA_MOVIMIENTOTableAdapter = New Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_MOVIMIENTOTableAdapter
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.NOMBRETextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDENTIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRASENATextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RESPUESTA_SEGURIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADICIONADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODIFICADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_ROLSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAROLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_PARTIDOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PREGUNTA_SEGURIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_USUARIOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGO_MOVIMIENTOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTADOTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NIVELSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_USUARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_ROL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPREGUNTA_SEGURIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForRESPUESTA_SEGURIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNOMBRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDENTIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCONTRASENA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCODIGO_MOVIMIENTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForESTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.AllowCustomizationMenu = False
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Controls.Add(Me.DataLayoutControl1)
        Me.LayoutControl1.Controls.Add(Me.GCBusqueda)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(572, 215, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(891, 471)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.BtnSalir)
        Me.PanelControl1.Controls.Add(Me.BtnNuevo)
        Me.PanelControl1.Controls.Add(Me.BtnGuardar)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(479, 61)
        Me.PanelControl1.TabIndex = 7
        '
        'BtnSalir
        '
        Me.BtnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Appearance.Options.UseFont = True
        Me.BtnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.BtnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(123, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 55)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "Salir"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.Appearance.Options.UseFont = True
        Me.BtnNuevo.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources._new
        Me.BtnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(5, 2)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(64, 2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 55)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.NOMBRETextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDENTIDADTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CONTRASENATextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.RESPUESTA_SEGURIDADTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ADICIONADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_ADICIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.MODIFICADO_PORSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FECHA_MODIFICACIONDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_ROLSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_PARTIDOSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PREGUNTA_SEGURIDADTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_USUARIOSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CODIGO_MOVIMIENTOSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ESTADOTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NIVELSpinEdit)
        Me.DataLayoutControl1.DataSource = Me.IMUSUARIOSBindingSource
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForADICIONADO_POR, Me.ItemForFECHA_ADICION, Me.ItemForMODIFICADO_POR, Me.ItemForFECHA_MODIFICACION})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(12, 77)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(747, 211, 250, 350)
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(484, 286)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'NOMBRETextEdit
        '
        Me.NOMBRETextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "NOMBRE", True))
        Me.NOMBRETextEdit.Location = New System.Drawing.Point(133, 36)
        Me.NOMBRETextEdit.Name = "NOMBRETextEdit"
        Me.NOMBRETextEdit.Properties.MaxLength = 100
        Me.NOMBRETextEdit.Size = New System.Drawing.Size(166, 20)
        Me.NOMBRETextEdit.StyleController = Me.DataLayoutControl1
        Me.NOMBRETextEdit.TabIndex = 6
        '
        'IMUSUARIOSBindingSource
        '
        Me.IMUSUARIOSBindingSource.DataMember = "IM_USUARIOS"
        Me.IMUSUARIOSBindingSource.DataSource = Me.DTUsers
        '
        'DTUsers
        '
        Me.DTUsers.DataSetName = "DTUsers"
        Me.DTUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDENTIDADTextEdit
        '
        Me.IDENTIDADTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "IDENTIDAD", True))
        Me.IDENTIDADTextEdit.Location = New System.Drawing.Point(133, 60)
        Me.IDENTIDADTextEdit.Name = "IDENTIDADTextEdit"
        Me.IDENTIDADTextEdit.Properties.Mask.BeepOnError = True
        Me.IDENTIDADTextEdit.Properties.MaxLength = 13
        Me.IDENTIDADTextEdit.Size = New System.Drawing.Size(167, 20)
        Me.IDENTIDADTextEdit.StyleController = Me.DataLayoutControl1
        Me.IDENTIDADTextEdit.TabIndex = 7
        '
        'CONTRASENATextEdit
        '
        Me.CONTRASENATextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "CONTRASENA", True))
        Me.CONTRASENATextEdit.Location = New System.Drawing.Point(133, 84)
        Me.CONTRASENATextEdit.Name = "CONTRASENATextEdit"
        Me.CONTRASENATextEdit.Properties.MaxLength = 15
        Me.CONTRASENATextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CONTRASENATextEdit.Size = New System.Drawing.Size(167, 20)
        Me.CONTRASENATextEdit.StyleController = Me.DataLayoutControl1
        Me.CONTRASENATextEdit.TabIndex = 8
        '
        'RESPUESTA_SEGURIDADTextEdit
        '
        Me.RESPUESTA_SEGURIDADTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "RESPUESTA_SEGURIDAD", True))
        Me.RESPUESTA_SEGURIDADTextEdit.Location = New System.Drawing.Point(133, 204)
        Me.RESPUESTA_SEGURIDADTextEdit.Name = "RESPUESTA_SEGURIDADTextEdit"
        Me.RESPUESTA_SEGURIDADTextEdit.Properties.MaxLength = 100
        Me.RESPUESTA_SEGURIDADTextEdit.Size = New System.Drawing.Size(167, 20)
        Me.RESPUESTA_SEGURIDADTextEdit.StyleController = Me.DataLayoutControl1
        Me.RESPUESTA_SEGURIDADTextEdit.TabIndex = 12
        '
        'ADICIONADO_PORSpinEdit
        '
        Me.ADICIONADO_PORSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "ADICIONADO_POR", True))
        Me.ADICIONADO_PORSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ADICIONADO_PORSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.ADICIONADO_PORSpinEdit.Name = "ADICIONADO_PORSpinEdit"
        Me.ADICIONADO_PORSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ADICIONADO_PORSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.ADICIONADO_PORSpinEdit.StyleController = Me.DataLayoutControl1
        Me.ADICIONADO_PORSpinEdit.TabIndex = 15
        '
        'FECHA_ADICIONDateEdit
        '
        Me.FECHA_ADICIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "FECHA_ADICION", True))
        Me.FECHA_ADICIONDateEdit.EditValue = Nothing
        Me.FECHA_ADICIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_ADICIONDateEdit.Name = "FECHA_ADICIONDateEdit"
        Me.FECHA_ADICIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_ADICIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_ADICIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_ADICIONDateEdit.TabIndex = 16
        '
        'MODIFICADO_PORSpinEdit
        '
        Me.MODIFICADO_PORSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "MODIFICADO_POR", True))
        Me.MODIFICADO_PORSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MODIFICADO_PORSpinEdit.Location = New System.Drawing.Point(0, 0)
        Me.MODIFICADO_PORSpinEdit.Name = "MODIFICADO_PORSpinEdit"
        Me.MODIFICADO_PORSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MODIFICADO_PORSpinEdit.Size = New System.Drawing.Size(0, 20)
        Me.MODIFICADO_PORSpinEdit.StyleController = Me.DataLayoutControl1
        Me.MODIFICADO_PORSpinEdit.TabIndex = 17
        '
        'FECHA_MODIFICACIONDateEdit
        '
        Me.FECHA_MODIFICACIONDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "FECHA_MODIFICACION", True))
        Me.FECHA_MODIFICACIONDateEdit.EditValue = Nothing
        Me.FECHA_MODIFICACIONDateEdit.Location = New System.Drawing.Point(0, 0)
        Me.FECHA_MODIFICACIONDateEdit.Name = "FECHA_MODIFICACIONDateEdit"
        Me.FECHA_MODIFICACIONDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FECHA_MODIFICACIONDateEdit.Size = New System.Drawing.Size(0, 20)
        Me.FECHA_MODIFICACIONDateEdit.StyleController = Me.DataLayoutControl1
        Me.FECHA_MODIFICACIONDateEdit.TabIndex = 18
        '
        'CODIGO_ROLSpinEdit
        '
        Me.CODIGO_ROLSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "CODIGO_ROL", True))
        Me.CODIGO_ROLSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_ROLSpinEdit.Location = New System.Drawing.Point(133, 108)
        Me.CODIGO_ROLSpinEdit.Name = "CODIGO_ROLSpinEdit"
        Me.CODIGO_ROLSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_ROLSpinEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Rol", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_ROLSpinEdit.Properties.DataSource = Me.TAROLESBindingSource
        Me.CODIGO_ROLSpinEdit.Properties.DisplayMember = "DESCRIPCION"
        Me.CODIGO_ROLSpinEdit.Properties.NullText = ""
        Me.CODIGO_ROLSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CODIGO_ROLSpinEdit.Properties.ValueMember = "CODIGO_ROL"
        Me.CODIGO_ROLSpinEdit.Size = New System.Drawing.Size(168, 20)
        Me.CODIGO_ROLSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_ROLSpinEdit.TabIndex = 5
        '
        'TAROLESBindingSource
        '
        Me.TAROLESBindingSource.DataMember = "TA_ROLES"
        Me.TAROLESBindingSource.DataSource = Me.DTUsers
        '
        'CODIGO_PARTIDOSpinEdit
        '
        Me.CODIGO_PARTIDOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "CODIGO_PARTIDO", True))
        Me.CODIGO_PARTIDOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_PARTIDOSpinEdit.Location = New System.Drawing.Point(133, 132)
        Me.CODIGO_PARTIDOSpinEdit.Name = "CODIGO_PARTIDOSpinEdit"
        Me.CODIGO_PARTIDOSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_PARTIDOSpinEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_PARTIDO", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "Partido Político", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_PARTIDOSpinEdit.Properties.DataSource = Me.TAPARTIDOSPOLITICOSBindingSource
        Me.CODIGO_PARTIDOSpinEdit.Properties.DisplayMember = "NOMBRE"
        Me.CODIGO_PARTIDOSpinEdit.Properties.NullText = "Seleccione"
        Me.CODIGO_PARTIDOSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CODIGO_PARTIDOSpinEdit.Properties.ValueMember = "CODIGO_PARTIDO"
        Me.CODIGO_PARTIDOSpinEdit.Size = New System.Drawing.Size(168, 20)
        Me.CODIGO_PARTIDOSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_PARTIDOSpinEdit.TabIndex = 14
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
        'PREGUNTA_SEGURIDADTextEdit
        '
        Me.PREGUNTA_SEGURIDADTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "PREGUNTA_SEGURIDAD", True))
        Me.PREGUNTA_SEGURIDADTextEdit.Location = New System.Drawing.Point(133, 180)
        Me.PREGUNTA_SEGURIDADTextEdit.Name = "PREGUNTA_SEGURIDADTextEdit"
        Me.PREGUNTA_SEGURIDADTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PREGUNTA_SEGURIDADTextEdit.Properties.NullText = "Seleccione"
        Me.PREGUNTA_SEGURIDADTextEdit.Properties.PopupSizeable = False
        Me.PREGUNTA_SEGURIDADTextEdit.Size = New System.Drawing.Size(168, 20)
        Me.PREGUNTA_SEGURIDADTextEdit.StyleController = Me.DataLayoutControl1
        Me.PREGUNTA_SEGURIDADTextEdit.TabIndex = 11
        '
        'CODIGO_USUARIOSpinEdit
        '
        Me.CODIGO_USUARIOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "CODIGO_USUARIO", True))
        Me.CODIGO_USUARIOSpinEdit.Location = New System.Drawing.Point(133, 12)
        Me.CODIGO_USUARIOSpinEdit.Name = "CODIGO_USUARIOSpinEdit"
        Me.CODIGO_USUARIOSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.CODIGO_USUARIOSpinEdit.Properties.MaxLength = 10
        Me.CODIGO_USUARIOSpinEdit.Size = New System.Drawing.Size(107, 20)
        Me.CODIGO_USUARIOSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_USUARIOSpinEdit.TabIndex = 4
        '
        'CODIGO_MOVIMIENTOSpinEdit
        '
        Me.CODIGO_MOVIMIENTOSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "CODIGO_MOVIMIENTO", True))
        Me.CODIGO_MOVIMIENTOSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CODIGO_MOVIMIENTOSpinEdit.Location = New System.Drawing.Point(133, 156)
        Me.CODIGO_MOVIMIENTOSpinEdit.Name = "CODIGO_MOVIMIENTOSpinEdit"
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO_MOVIMIENTO", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE_MOVIMIENTO", "Movimiento", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.DataSource = Me.TAMOVIMIENTOBindingSource
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.DisplayMember = "NOMBRE_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.NullText = "Seleccione"
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CODIGO_MOVIMIENTOSpinEdit.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        Me.CODIGO_MOVIMIENTOSpinEdit.Size = New System.Drawing.Size(168, 20)
        Me.CODIGO_MOVIMIENTOSpinEdit.StyleController = Me.DataLayoutControl1
        Me.CODIGO_MOVIMIENTOSpinEdit.TabIndex = 10
        '
        'TAMOVIMIENTOBindingSource
        '
        Me.TAMOVIMIENTOBindingSource.DataMember = "TA_MOVIMIENTO"
        Me.TAMOVIMIENTOBindingSource.DataSource = Me.DSPolitico
        '
        'ESTADOTextEdit
        '
        Me.ESTADOTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "ESTADO", True))
        Me.ESTADOTextEdit.EditValue = "I"
        Me.ESTADOTextEdit.Location = New System.Drawing.Point(257, 228)
        Me.ESTADOTextEdit.Name = "ESTADOTextEdit"
        Me.ESTADOTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.ESTADOTextEdit.Properties.Caption = "Activar Usuario"
        Me.ESTADOTextEdit.Properties.ValueChecked = "A"
        Me.ESTADOTextEdit.Properties.ValueGrayed = "I"
        Me.ESTADOTextEdit.Properties.ValueUnchecked = "I"
        Me.ESTADOTextEdit.Size = New System.Drawing.Size(215, 19)
        Me.ESTADOTextEdit.StyleController = Me.DataLayoutControl1
        Me.ESTADOTextEdit.TabIndex = 9
        '
        'NIVELSpinEdit
        '
        Me.NIVELSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IMUSUARIOSBindingSource, "NIVEL", True))
        Me.NIVELSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NIVELSpinEdit.Location = New System.Drawing.Point(133, 228)
        Me.NIVELSpinEdit.Name = "NIVELSpinEdit"
        Me.NIVELSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NIVELSpinEdit.Properties.NullText = ""
        Me.NIVELSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.NIVELSpinEdit.Size = New System.Drawing.Size(110, 20)
        Me.NIVELSpinEdit.StyleController = Me.DataLayoutControl1
        Me.NIVELSpinEdit.TabIndex = 13
        '
        'ItemForADICIONADO_POR
        '
        Me.ItemForADICIONADO_POR.Control = Me.ADICIONADO_PORSpinEdit
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
        Me.ItemForMODIFICADO_POR.Control = Me.MODIFICADO_PORSpinEdit
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
        Me.Root.Size = New System.Drawing.Size(484, 286)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCODIGO_USUARIO, Me.ItemForCODIGO_ROL, Me.ItemForPREGUNTA_SEGURIDAD, Me.ItemForRESPUESTA_SEGURIDAD, Me.ItemForNOMBRE, Me.ItemForIDENTIDAD, Me.ItemForCONTRASENA, Me.ItemForCODIGO_PARTIDO, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.EmptySpaceItem6, Me.ItemForCODIGO_MOVIMIENTO, Me.EmptySpaceItem7, Me.EmptySpaceItem8, Me.EmptySpaceItem9, Me.EmptySpaceItem10, Me.ItemForESTADO, Me.EmptySpaceItem11, Me.LayoutControlItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(464, 266)
        Me.LayoutControlGroup2.Text = "autoGeneratedGroup0"
        '
        'ItemForCODIGO_USUARIO
        '
        Me.ItemForCODIGO_USUARIO.Control = Me.CODIGO_USUARIOSpinEdit
        Me.ItemForCODIGO_USUARIO.CustomizationFormText = "CODIGO_USUARIO"
        Me.ItemForCODIGO_USUARIO.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCODIGO_USUARIO.Name = "ItemForCODIGO_USUARIO"
        Me.ItemForCODIGO_USUARIO.Size = New System.Drawing.Size(232, 24)
        Me.ItemForCODIGO_USUARIO.Text = "Usuario"
        Me.ItemForCODIGO_USUARIO.TextSize = New System.Drawing.Size(117, 13)
        '
        'ItemForCODIGO_ROL
        '
        Me.ItemForCODIGO_ROL.Control = Me.CODIGO_ROLSpinEdit
        Me.ItemForCODIGO_ROL.CustomizationFormText = "CODIGO_ROL"
        Me.ItemForCODIGO_ROL.Location = New System.Drawing.Point(0, 96)
        Me.ItemForCODIGO_ROL.Name = "ItemForCODIGO_ROL"
        Me.ItemForCODIGO_ROL.Size = New System.Drawing.Size(293, 24)
        Me.ItemForCODIGO_ROL.Text = "Rol Usuario"
        Me.ItemForCODIGO_ROL.TextSize = New System.Drawing.Size(117, 13)
        '
        'ItemForPREGUNTA_SEGURIDAD
        '
        Me.ItemForPREGUNTA_SEGURIDAD.Control = Me.PREGUNTA_SEGURIDADTextEdit
        Me.ItemForPREGUNTA_SEGURIDAD.CustomizationFormText = "PREGUNTA_SEGURIDAD"
        Me.ItemForPREGUNTA_SEGURIDAD.Location = New System.Drawing.Point(0, 168)
        Me.ItemForPREGUNTA_SEGURIDAD.Name = "ItemForPREGUNTA_SEGURIDAD"
        Me.ItemForPREGUNTA_SEGURIDAD.Size = New System.Drawing.Size(293, 24)
        Me.ItemForPREGUNTA_SEGURIDAD.Text = "Pregunta de Seguridad"
        Me.ItemForPREGUNTA_SEGURIDAD.TextSize = New System.Drawing.Size(117, 13)
        '
        'ItemForRESPUESTA_SEGURIDAD
        '
        Me.ItemForRESPUESTA_SEGURIDAD.Control = Me.RESPUESTA_SEGURIDADTextEdit
        Me.ItemForRESPUESTA_SEGURIDAD.CustomizationFormText = "RESPUESTA_SEGURIDAD"
        Me.ItemForRESPUESTA_SEGURIDAD.Location = New System.Drawing.Point(0, 192)
        Me.ItemForRESPUESTA_SEGURIDAD.Name = "ItemForRESPUESTA_SEGURIDAD"
        Me.ItemForRESPUESTA_SEGURIDAD.Size = New System.Drawing.Size(292, 24)
        Me.ItemForRESPUESTA_SEGURIDAD.Text = "Respuesta de Seguridad"
        Me.ItemForRESPUESTA_SEGURIDAD.TextSize = New System.Drawing.Size(117, 13)
        '
        'ItemForNOMBRE
        '
        Me.ItemForNOMBRE.Control = Me.NOMBRETextEdit
        Me.ItemForNOMBRE.CustomizationFormText = "NOMBRE"
        Me.ItemForNOMBRE.Location = New System.Drawing.Point(0, 24)
        Me.ItemForNOMBRE.Name = "ItemForNOMBRE"
        Me.ItemForNOMBRE.Size = New System.Drawing.Size(291, 24)
        Me.ItemForNOMBRE.Text = "Nombre Completo"
        Me.ItemForNOMBRE.TextSize = New System.Drawing.Size(117, 13)
        '
        'ItemForIDENTIDAD
        '
        Me.ItemForIDENTIDAD.Control = Me.IDENTIDADTextEdit
        Me.ItemForIDENTIDAD.CustomizationFormText = "IDENTIDAD"
        Me.ItemForIDENTIDAD.Location = New System.Drawing.Point(0, 48)
        Me.ItemForIDENTIDAD.Name = "ItemForIDENTIDAD"
        Me.ItemForIDENTIDAD.Size = New System.Drawing.Size(292, 24)
        Me.ItemForIDENTIDAD.Text = "Identidad"
        Me.ItemForIDENTIDAD.TextSize = New System.Drawing.Size(117, 13)
        '
        'ItemForCONTRASENA
        '
        Me.ItemForCONTRASENA.Control = Me.CONTRASENATextEdit
        Me.ItemForCONTRASENA.CustomizationFormText = "CONTRASENA"
        Me.ItemForCONTRASENA.Location = New System.Drawing.Point(0, 72)
        Me.ItemForCONTRASENA.Name = "ItemForCONTRASENA"
        Me.ItemForCONTRASENA.Size = New System.Drawing.Size(292, 24)
        Me.ItemForCONTRASENA.Text = "Contraseña"
        Me.ItemForCONTRASENA.TextSize = New System.Drawing.Size(117, 13)
        '
        'ItemForCODIGO_PARTIDO
        '
        Me.ItemForCODIGO_PARTIDO.Control = Me.CODIGO_PARTIDOSpinEdit
        Me.ItemForCODIGO_PARTIDO.CustomizationFormText = "CODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Location = New System.Drawing.Point(0, 120)
        Me.ItemForCODIGO_PARTIDO.Name = "ItemForCODIGO_PARTIDO"
        Me.ItemForCODIGO_PARTIDO.Size = New System.Drawing.Size(293, 24)
        Me.ItemForCODIGO_PARTIDO.Text = "Partido Político"
        Me.ItemForCODIGO_PARTIDO.TextSize = New System.Drawing.Size(117, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(232, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(232, 24)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(291, 24)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(173, 24)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(292, 48)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(172, 24)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(292, 72)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(172, 24)
        Me.EmptySpaceItem5.Text = "EmptySpaceItem5"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(293, 96)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(171, 24)
        Me.EmptySpaceItem6.Text = "EmptySpaceItem6"
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'ItemForCODIGO_MOVIMIENTO
        '
        Me.ItemForCODIGO_MOVIMIENTO.Control = Me.CODIGO_MOVIMIENTOSpinEdit
        Me.ItemForCODIGO_MOVIMIENTO.CustomizationFormText = "CODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Location = New System.Drawing.Point(0, 144)
        Me.ItemForCODIGO_MOVIMIENTO.Name = "ItemForCODIGO_MOVIMIENTO"
        Me.ItemForCODIGO_MOVIMIENTO.Size = New System.Drawing.Size(293, 24)
        Me.ItemForCODIGO_MOVIMIENTO.Text = "Movimiento"
        Me.ItemForCODIGO_MOVIMIENTO.TextSize = New System.Drawing.Size(117, 13)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(293, 120)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(171, 24)
        Me.EmptySpaceItem7.Text = "EmptySpaceItem7"
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(293, 144)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(171, 24)
        Me.EmptySpaceItem8.Text = "EmptySpaceItem8"
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.CustomizationFormText = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(293, 168)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(171, 24)
        Me.EmptySpaceItem9.Text = "EmptySpaceItem9"
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.CustomizationFormText = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(292, 192)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(172, 24)
        Me.EmptySpaceItem10.Text = "EmptySpaceItem10"
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        '
        'ItemForESTADO
        '
        Me.ItemForESTADO.Control = Me.ESTADOTextEdit
        Me.ItemForESTADO.CustomizationFormText = "ESTADO"
        Me.ItemForESTADO.Location = New System.Drawing.Point(245, 216)
        Me.ItemForESTADO.Name = "ItemForESTADO"
        Me.ItemForESTADO.Size = New System.Drawing.Size(219, 50)
        Me.ItemForESTADO.Text = "Estado"
        Me.ItemForESTADO.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForESTADO.TextToControlDistance = 0
        Me.ItemForESTADO.TextVisible = False
        '
        'EmptySpaceItem11
        '
        Me.EmptySpaceItem11.AllowHotTrack = False
        Me.EmptySpaceItem11.CustomizationFormText = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Location = New System.Drawing.Point(235, 216)
        Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Size = New System.Drawing.Size(10, 50)
        Me.EmptySpaceItem11.Text = "Nivel"
        Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.NIVELSpinEdit
        Me.LayoutControlItem4.CustomizationFormText = "Nivel"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 216)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(235, 50)
        Me.LayoutControlItem4.Text = "Nivel"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(117, 13)
        '
        'GCBusqueda
        '
        Me.GCBusqueda.DataSource = Me.DTUSUARIOSBindingSource
        Me.GCBusqueda.Location = New System.Drawing.Point(12, 367)
        Me.GCBusqueda.MainView = Me.GridView1
        Me.GCBusqueda.Name = "GCBusqueda"
        Me.GCBusqueda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCBusqueda.Size = New System.Drawing.Size(867, 92)
        Me.GCBusqueda.TabIndex = 8
        Me.GCBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'DTUSUARIOSBindingSource
        '
        Me.DTUSUARIOSBindingSource.DataMember = "DT_USUARIOS"
        Me.DTUSUARIOSBindingSource.DataSource = Me.DTUsers
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_USUARIO, Me.colNOMBRE, Me.colESTADO, Me.colNOMBRE_MOVIMIENTO, Me.colPARTIDO, Me.colROL, Me.colIDENTIDAD, Me.colNIVEL})
        Me.GridView1.GridControl = Me.GCBusqueda
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colCODIGO_USUARIO
        '
        Me.colCODIGO_USUARIO.Caption = "Código Usuario"
        Me.colCODIGO_USUARIO.FieldName = "CODIGO_USUARIO"
        Me.colCODIGO_USUARIO.Name = "colCODIGO_USUARIO"
        Me.colCODIGO_USUARIO.Visible = True
        Me.colCODIGO_USUARIO.VisibleIndex = 0
        Me.colCODIGO_USUARIO.Width = 95
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "Nombre"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 2
        Me.colNOMBRE.Width = 223
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "Estado"
        Me.colESTADO.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 7
        Me.colESTADO.Width = 48
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "A"
        Me.RepositoryItemCheckEdit1.ValueGrayed = "I"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "I"
        '
        'colNOMBRE_MOVIMIENTO
        '
        Me.colNOMBRE_MOVIMIENTO.Caption = "Movimiento"
        Me.colNOMBRE_MOVIMIENTO.FieldName = "NOMBRE_MOVIMIENTO"
        Me.colNOMBRE_MOVIMIENTO.Name = "colNOMBRE_MOVIMIENTO"
        Me.colNOMBRE_MOVIMIENTO.Visible = True
        Me.colNOMBRE_MOVIMIENTO.VisibleIndex = 5
        Me.colNOMBRE_MOVIMIENTO.Width = 103
        '
        'colPARTIDO
        '
        Me.colPARTIDO.Caption = "Partido"
        Me.colPARTIDO.FieldName = "PARTIDO"
        Me.colPARTIDO.Name = "colPARTIDO"
        Me.colPARTIDO.Visible = True
        Me.colPARTIDO.VisibleIndex = 4
        Me.colPARTIDO.Width = 128
        '
        'colROL
        '
        Me.colROL.Caption = "Rol"
        Me.colROL.FieldName = "ROL"
        Me.colROL.Name = "colROL"
        Me.colROL.Visible = True
        Me.colROL.VisibleIndex = 3
        Me.colROL.Width = 116
        '
        'colIDENTIDAD
        '
        Me.colIDENTIDAD.Caption = "Identidad"
        Me.colIDENTIDAD.FieldName = "IDENTIDAD"
        Me.colIDENTIDAD.Name = "colIDENTIDAD"
        Me.colIDENTIDAD.Visible = True
        Me.colIDENTIDAD.VisibleIndex = 1
        Me.colIDENTIDAD.Width = 101
        '
        'colNIVEL
        '
        Me.colNIVEL.Caption = "Nivel"
        Me.colNIVEL.FieldName = "NIVEL"
        Me.colNIVEL.Name = "colNIVEL"
        Me.colNIVEL.Visible = True
        Me.colNIVEL.VisibleIndex = 6
        Me.colNIVEL.Width = 33
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
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem2, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(891, 471)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(483, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(388, 65)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(388, 65)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(388, 65)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DataLayoutControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 65)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(488, 290)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(488, 290)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(871, 290)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PanelControl1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(483, 65)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(483, 65)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(483, 65)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GCBusqueda
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 355)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(871, 0)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(871, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(871, 96)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'IM_USUARIOSTableAdapter
        '
        Me.IM_USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'TA_ROLESTableAdapter
        '
        Me.TA_ROLESTableAdapter.ClearBeforeFill = True
        '
        'DT_USUARIOSTableAdapter
        '
        Me.DT_USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'TA_PARTIDOS_POLITICOSTableAdapter
        '
        Me.TA_PARTIDOS_POLITICOSTableAdapter.ClearBeforeFill = True
        '
        'TA_MOVIMIENTOTableAdapter
        '
        Me.TA_MOVIMIENTOTableAdapter.ClearBeforeFill = True
        '
        'XfrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 471)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "XfrmUsuarios"
        Me.Text = "Usuarios"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.NOMBRETextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDENTIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRASENATextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RESPUESTA_SEGURIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADICIONADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_ADICIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODIFICADO_PORSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHA_MODIFICACIONDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_ROLSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAROLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_PARTIDOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAPARTIDOSPOLITICOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPolitico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PREGUNTA_SEGURIDADTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_USUARIOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGO_MOVIMIENTOSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAMOVIMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTADOTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NIVELSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForADICIONADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_ADICION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForMODIFICADO_POR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFECHA_MODIFICACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_USUARIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_ROL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPREGUNTA_SEGURIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForRESPUESTA_SEGURIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNOMBRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDENTIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCONTRASENA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_PARTIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCODIGO_MOVIMIENTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForESTADO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DTUsers As Inscripcion_de_Moviemientos.DTUsers
    Friend WithEvents IMUSUARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IM_USUARIOSTableAdapter As Inscripcion_de_Moviemientos.DTUsersTableAdapters.IM_USUARIOSTableAdapter
    Friend WithEvents NOMBRETextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDENTIDADTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CONTRASENATextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RESPUESTA_SEGURIDADTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ADICIONADO_PORSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FECHA_ADICIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MODIFICADO_PORSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FECHA_MODIFICACIONDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ItemForADICIONADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_ADICION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForMODIFICADO_POR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFECHA_MODIFICACION As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForCODIGO_USUARIO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_ROL As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNOMBRE As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIDENTIDAD As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCONTRASENA As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForESTADO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_MOVIMIENTO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPREGUNTA_SEGURIDAD As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForRESPUESTA_SEGURIDAD As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCODIGO_PARTIDO As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CODIGO_ROLSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TAROLESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_ROLESTableAdapter As Inscripcion_de_Moviemientos.DTUsersTableAdapters.TA_ROLESTableAdapter
    Friend WithEvents CODIGO_MOVIMIENTOSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DSPolitico As Inscripcion_de_Moviemientos.DSPolitico
    Friend WithEvents CODIGO_PARTIDOSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PREGUNTA_SEGURIDADTextEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CODIGO_USUARIOSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ESTADOTextEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GCBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DTUSUARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DT_USUARIOSTableAdapter As Inscripcion_de_Moviemientos.DTUsersTableAdapters.DT_USUARIOSTableAdapter
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TAPARTIDOSPOLITICOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_PARTIDOS_POLITICOSTableAdapter As Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_PARTIDOS_POLITICOSTableAdapter
    Friend WithEvents colCODIGO_USUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colROL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIVEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BtnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NIVELSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TAMOVIMIENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TA_MOVIMIENTOTableAdapter As Inscripcion_de_Moviemientos.DSPoliticoTableAdapters.TA_MOVIMIENTOTableAdapter
End Class
