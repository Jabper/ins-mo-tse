<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XFrmMenuPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.BtnMovimeintos = New DevExpress.XtraBars.BarButtonItem
        Me.BtnPartidos = New DevExpress.XtraBars.BarButtonItem
        Me.BtnMunicipio = New DevExpress.XtraBars.BarButtonItem
        Me.BtnDepartamento = New DevExpress.XtraBars.BarButtonItem
        Me.BtnCargos = New DevExpress.XtraBars.BarButtonItem
        Me.BtnNivelesElectivos = New DevExpress.XtraBars.BarButtonItem
        Me.BtnIncompatibilidades = New DevExpress.XtraBars.BarButtonItem
        Me.BtnCenso = New DevExpress.XtraBars.BarButtonItem
        Me.BtnParametros = New DevExpress.XtraBars.BarButtonItem
        Me.BtnUsuarios = New DevExpress.XtraBars.BarButtonItem
        Me.BtnRoles = New DevExpress.XtraBars.BarButtonItem
        Me.BtnOpciones = New DevExpress.XtraBars.BarButtonItem
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPage6 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.ExpandCollapseItem.Name = ""
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BtnMovimeintos, Me.BtnPartidos, Me.BtnMunicipio, Me.BtnDepartamento, Me.BtnCargos, Me.BtnNivelesElectivos, Me.BtnIncompatibilidades, Me.BtnCenso, Me.BtnParametros, Me.BtnUsuarios, Me.BtnRoles, Me.BtnOpciones})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 15
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4, Me.RibbonPage5, Me.RibbonPage6})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibbonControl.Size = New System.Drawing.Size(815, 145)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BtnMovimeintos
        '
        Me.BtnMovimeintos.Caption = "Movimientos"
        Me.BtnMovimeintos.Glyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.movimientos
        Me.BtnMovimeintos.Id = 1
        Me.BtnMovimeintos.LargeGlyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.movimientos
        Me.BtnMovimeintos.Name = "BtnMovimeintos"
        '
        'BtnPartidos
        '
        Me.BtnPartidos.Caption = "Partidos Políticos"
        Me.BtnPartidos.Glyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.partidos
        Me.BtnPartidos.Id = 2
        Me.BtnPartidos.LargeGlyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.partidos
        Me.BtnPartidos.Name = "BtnPartidos"
        '
        'BtnMunicipio
        '
        Me.BtnMunicipio.Caption = "Municipio"
        Me.BtnMunicipio.Id = 3
        Me.BtnMunicipio.LargeGlyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.municipios
        Me.BtnMunicipio.Name = "BtnMunicipio"
        '
        'BtnDepartamento
        '
        Me.BtnDepartamento.Caption = "Departamento"
        Me.BtnDepartamento.Id = 4
        Me.BtnDepartamento.LargeGlyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.departamento
        Me.BtnDepartamento.Name = "BtnDepartamento"
        '
        'BtnCargos
        '
        Me.BtnCargos.Caption = "Cargos Electivos"
        Me.BtnCargos.Id = 5
        Me.BtnCargos.LargeGlyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.cargos
        Me.BtnCargos.Name = "BtnCargos"
        '
        'BtnNivelesElectivos
        '
        Me.BtnNivelesElectivos.Caption = "Niveles Electivos"
        Me.BtnNivelesElectivos.Id = 6
        Me.BtnNivelesElectivos.LargeGlyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.nivelesElectivos
        Me.BtnNivelesElectivos.Name = "BtnNivelesElectivos"
        '
        'BtnIncompatibilidades
        '
        Me.BtnIncompatibilidades.Caption = "Incompatibilidades"
        Me.BtnIncompatibilidades.Id = 7
        Me.BtnIncompatibilidades.LargeGlyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.incompatibilidades
        Me.BtnIncompatibilidades.Name = "BtnIncompatibilidades"
        '
        'BtnCenso
        '
        Me.BtnCenso.Caption = "Censo"
        Me.BtnCenso.Id = 8
        Me.BtnCenso.Name = "BtnCenso"
        '
        'BtnParametros
        '
        Me.BtnParametros.Caption = "Parámetros"
        Me.BtnParametros.Id = 9
        Me.BtnParametros.LargeGlyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.parametros
        Me.BtnParametros.Name = "BtnParametros"
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.Caption = "Usuarios"
        Me.BtnUsuarios.Id = 12
        Me.BtnUsuarios.LargeGlyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.Usuarios
        Me.BtnUsuarios.Name = "BtnUsuarios"
        '
        'BtnRoles
        '
        Me.BtnRoles.Caption = "Roles"
        Me.BtnRoles.Id = 13
        Me.BtnRoles.LargeGlyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.Roles
        Me.BtnRoles.Name = "BtnRoles"
        '
        'BtnOpciones
        '
        Me.BtnOpciones.Caption = "Opciones"
        Me.BtnOpciones.Id = 14
        Me.BtnOpciones.LargeGlyph = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.OpcionesdeAcceso
        Me.BtnOpciones.Name = "BtnOpciones"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Módulo General"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnParametros)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnIncompatibilidades)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnNivelesElectivos)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnCargos)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnPartidos)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnMovimeintos)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnMunicipio)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnDepartamento)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Acciones"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Operaciones"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Procesos"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Consultas"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Text = "Reportes"
        '
        'RibbonPage6
        '
        Me.RibbonPage6.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage6.Name = "RibbonPage6"
        Me.RibbonPage6.Text = "Seguridad"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnUsuarios)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnRoles)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnOpciones)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Seguridad del Sistema"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 417)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(815, 32)
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Silver"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'XFrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 449)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "XFrmMenuPrincipal"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Inscripción de Movimientos"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage6 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BtnMovimeintos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnPartidos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnMunicipio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnDepartamento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents BtnCargos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnNivelesElectivos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnIncompatibilidades As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCenso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnParametros As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnUsuarios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnRoles As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnOpciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup


End Class
