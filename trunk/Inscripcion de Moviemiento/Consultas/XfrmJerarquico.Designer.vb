<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XfrmJerarquico
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode5 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode6 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_PARTIDO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_MOVIMIENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.JrPartidosPoliticosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSConsultas = New Inscripcion_de_Moviemientos.DSConsultas
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCANTIDAD_FIRMAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_PARTIDO2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOVIMIENTO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_NIVEL_ELECTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_PARTIDO3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOVIMIENTO2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_NIVEL_ELECTIVO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CARGO_ELECTIVO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCANTIDAD_CARGO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCANTIDAD_MUJERES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_PARTIDO4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOVIMIENTO3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_NIVEL_ELECTIVO2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CARGO_ELECTIVO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_PARTIDO5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOVIMIENTO4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_NIVEL_ELECTIVO3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CARGO_ELECTIVO2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDESCRIPCION3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCODIGO_PARTIDO6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MOVIMIENTO5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_NIVEL_ELECTIVO4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CARGO_ELECTIVO3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPOSICION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CANDIDATOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIDENTIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAPELLIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.JrPartidosPoliticosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrPartidosPoliticosTableAdapter
        Me.JrMovimientosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrMovimientosTableAdapter
        Me.JrNivelesElectivosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrNivelesElectivosTableAdapter
        Me.JrCargosElectivosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrCargosElectivosTableAdapter
        Me.JrDepartamentosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrDepartamentosTableAdapter
        Me.JrMunicipiosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrMunicipiosTableAdapter
        Me.JrCandidatosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrCandidatosTableAdapter
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JrPartidosPoliticosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_PARTIDO1, Me.colCODIGO_MOVIMIENTO, Me.colNOMBRE_MOVIMIENTO})
        Me.GridView2.DetailHeight = 100000
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowColumnHeaders = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO_PARTIDO1
        '
        Me.colCODIGO_PARTIDO1.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO1.Name = "colCODIGO_PARTIDO1"
        '
        'colCODIGO_MOVIMIENTO
        '
        Me.colCODIGO_MOVIMIENTO.FieldName = "CODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO.Name = "colCODIGO_MOVIMIENTO"
        '
        'colNOMBRE_MOVIMIENTO
        '
        Me.colNOMBRE_MOVIMIENTO.FieldName = "NOMBRE_MOVIMIENTO"
        Me.colNOMBRE_MOVIMIENTO.Name = "colNOMBRE_MOVIMIENTO"
        Me.colNOMBRE_MOVIMIENTO.Visible = True
        Me.colNOMBRE_MOVIMIENTO.VisibleIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.JrPartidosPoliticosBindingSource
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode2.LevelTemplate = Me.GridView3
        GridLevelNode3.LevelTemplate = Me.GridView4
        GridLevelNode4.LevelTemplate = Me.GridView5
        GridLevelNode5.LevelTemplate = Me.GridView6
        GridLevelNode6.LevelTemplate = Me.GridView7
        GridLevelNode6.RelationName = "Candidatos"
        GridLevelNode5.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode6})
        GridLevelNode5.RelationName = "Municipios"
        GridLevelNode4.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode5})
        GridLevelNode4.RelationName = "Departamentos"
        GridLevelNode3.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode4})
        GridLevelNode3.RelationName = "Cargos Electivos"
        GridLevelNode2.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3})
        GridLevelNode2.RelationName = "Niveles Electivos"
        GridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        GridLevelNode1.RelationName = "Movimientos"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(12, 82)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1345, 760)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView3, Me.GridView4, Me.GridView5, Me.GridView6, Me.GridView7, Me.GridView2})
        '
        'JrPartidosPoliticosBindingSource
        '
        Me.JrPartidosPoliticosBindingSource.DataMember = "jrPartidosPoliticos"
        Me.JrPartidosPoliticosBindingSource.DataSource = Me.DSConsultas
        '
        'DSConsultas
        '
        Me.DSConsultas.DataSetName = "DSConsultas"
        Me.DSConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_PARTIDO, Me.colNOMBRE, Me.colCANTIDAD_FIRMAS})
        Me.GridView1.DetailHeight = 100000
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO_PARTIDO
        '
        Me.colCODIGO_PARTIDO.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Name = "colCODIGO_PARTIDO"
        '
        'colNOMBRE
        '
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 0
        '
        'colCANTIDAD_FIRMAS
        '
        Me.colCANTIDAD_FIRMAS.FieldName = "CANTIDAD_FIRMAS"
        Me.colCANTIDAD_FIRMAS.Name = "colCANTIDAD_FIRMAS"
        Me.colCANTIDAD_FIRMAS.Visible = True
        Me.colCANTIDAD_FIRMAS.VisibleIndex = 1
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_PARTIDO2, Me.colCODIGO_MOVIMIENTO1, Me.colCODIGO_NIVEL_ELECTIVO, Me.colDESCRIPCION})
        Me.GridView3.DetailHeight = 100000
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowColumnHeaders = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO_PARTIDO2
        '
        Me.colCODIGO_PARTIDO2.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO2.Name = "colCODIGO_PARTIDO2"
        '
        'colCODIGO_MOVIMIENTO1
        '
        Me.colCODIGO_MOVIMIENTO1.FieldName = "CODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO1.Name = "colCODIGO_MOVIMIENTO1"
        '
        'colCODIGO_NIVEL_ELECTIVO
        '
        Me.colCODIGO_NIVEL_ELECTIVO.FieldName = "CODIGO_NIVEL_ELECTIVO"
        Me.colCODIGO_NIVEL_ELECTIVO.Name = "colCODIGO_NIVEL_ELECTIVO"
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 0
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_PARTIDO3, Me.colCODIGO_MOVIMIENTO2, Me.colCODIGO_NIVEL_ELECTIVO1, Me.colCODIGO_CARGO_ELECTIVO, Me.colDESCRIPCION1, Me.colCANTIDAD_CARGO, Me.colCANTIDAD_MUJERES})
        Me.GridView4.DetailHeight = 100000
        Me.GridView4.GridControl = Me.GridControl1
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO_PARTIDO3
        '
        Me.colCODIGO_PARTIDO3.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO3.Name = "colCODIGO_PARTIDO3"
        '
        'colCODIGO_MOVIMIENTO2
        '
        Me.colCODIGO_MOVIMIENTO2.FieldName = "CODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO2.Name = "colCODIGO_MOVIMIENTO2"
        '
        'colCODIGO_NIVEL_ELECTIVO1
        '
        Me.colCODIGO_NIVEL_ELECTIVO1.FieldName = "CODIGO_NIVEL_ELECTIVO"
        Me.colCODIGO_NIVEL_ELECTIVO1.Name = "colCODIGO_NIVEL_ELECTIVO1"
        '
        'colCODIGO_CARGO_ELECTIVO
        '
        Me.colCODIGO_CARGO_ELECTIVO.FieldName = "CODIGO_CARGO_ELECTIVO"
        Me.colCODIGO_CARGO_ELECTIVO.Name = "colCODIGO_CARGO_ELECTIVO"
        '
        'colDESCRIPCION1
        '
        Me.colDESCRIPCION1.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION1.Name = "colDESCRIPCION1"
        Me.colDESCRIPCION1.Visible = True
        Me.colDESCRIPCION1.VisibleIndex = 0
        '
        'colCANTIDAD_CARGO
        '
        Me.colCANTIDAD_CARGO.FieldName = "CANTIDAD_CARGO"
        Me.colCANTIDAD_CARGO.Name = "colCANTIDAD_CARGO"
        Me.colCANTIDAD_CARGO.Visible = True
        Me.colCANTIDAD_CARGO.VisibleIndex = 1
        '
        'colCANTIDAD_MUJERES
        '
        Me.colCANTIDAD_MUJERES.FieldName = "CANTIDAD_MUJERES"
        Me.colCANTIDAD_MUJERES.Name = "colCANTIDAD_MUJERES"
        Me.colCANTIDAD_MUJERES.Visible = True
        Me.colCANTIDAD_MUJERES.VisibleIndex = 2
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_PARTIDO4, Me.colCODIGO_MOVIMIENTO3, Me.colCODIGO_NIVEL_ELECTIVO2, Me.colCODIGO_CARGO_ELECTIVO1, Me.colCODIGO_DEPARTAMENTO, Me.colDESCRIPCION2})
        Me.GridView5.DetailHeight = 100000
        Me.GridView5.GridControl = Me.GridControl1
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsView.ShowColumnHeaders = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO_PARTIDO4
        '
        Me.colCODIGO_PARTIDO4.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO4.Name = "colCODIGO_PARTIDO4"
        '
        'colCODIGO_MOVIMIENTO3
        '
        Me.colCODIGO_MOVIMIENTO3.FieldName = "CODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO3.Name = "colCODIGO_MOVIMIENTO3"
        '
        'colCODIGO_NIVEL_ELECTIVO2
        '
        Me.colCODIGO_NIVEL_ELECTIVO2.FieldName = "CODIGO_NIVEL_ELECTIVO"
        Me.colCODIGO_NIVEL_ELECTIVO2.Name = "colCODIGO_NIVEL_ELECTIVO2"
        '
        'colCODIGO_CARGO_ELECTIVO1
        '
        Me.colCODIGO_CARGO_ELECTIVO1.FieldName = "CODIGO_CARGO_ELECTIVO"
        Me.colCODIGO_CARGO_ELECTIVO1.Name = "colCODIGO_CARGO_ELECTIVO1"
        '
        'colCODIGO_DEPARTAMENTO
        '
        Me.colCODIGO_DEPARTAMENTO.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Name = "colCODIGO_DEPARTAMENTO"
        '
        'colDESCRIPCION2
        '
        Me.colDESCRIPCION2.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION2.Name = "colDESCRIPCION2"
        Me.colDESCRIPCION2.Visible = True
        Me.colDESCRIPCION2.VisibleIndex = 0
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_PARTIDO5, Me.colCODIGO_MOVIMIENTO4, Me.colCODIGO_NIVEL_ELECTIVO3, Me.colCODIGO_CARGO_ELECTIVO2, Me.colCODIGO_DEPARTAMENTO1, Me.colCODIGO_MUNICIPIO, Me.colDESCRIPCION3})
        Me.GridView6.DetailHeight = 100000
        Me.GridView6.GridControl = Me.GridControl1
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsView.ShowColumnHeaders = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colCODIGO_PARTIDO5
        '
        Me.colCODIGO_PARTIDO5.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO5.Name = "colCODIGO_PARTIDO5"
        '
        'colCODIGO_MOVIMIENTO4
        '
        Me.colCODIGO_MOVIMIENTO4.FieldName = "CODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO4.Name = "colCODIGO_MOVIMIENTO4"
        '
        'colCODIGO_NIVEL_ELECTIVO3
        '
        Me.colCODIGO_NIVEL_ELECTIVO3.FieldName = "CODIGO_NIVEL_ELECTIVO"
        Me.colCODIGO_NIVEL_ELECTIVO3.Name = "colCODIGO_NIVEL_ELECTIVO3"
        '
        'colCODIGO_CARGO_ELECTIVO2
        '
        Me.colCODIGO_CARGO_ELECTIVO2.FieldName = "CODIGO_CARGO_ELECTIVO"
        Me.colCODIGO_CARGO_ELECTIVO2.Name = "colCODIGO_CARGO_ELECTIVO2"
        '
        'colCODIGO_DEPARTAMENTO1
        '
        Me.colCODIGO_DEPARTAMENTO1.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO1.Name = "colCODIGO_DEPARTAMENTO1"
        '
        'colCODIGO_MUNICIPIO
        '
        Me.colCODIGO_MUNICIPIO.FieldName = "CODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Name = "colCODIGO_MUNICIPIO"
        '
        'colDESCRIPCION3
        '
        Me.colDESCRIPCION3.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION3.Name = "colDESCRIPCION3"
        Me.colDESCRIPCION3.Visible = True
        Me.colDESCRIPCION3.VisibleIndex = 0
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_PARTIDO6, Me.colCODIGO_MOVIMIENTO5, Me.colCODIGO_NIVEL_ELECTIVO4, Me.colCODIGO_CARGO_ELECTIVO3, Me.colCODIGO_DEPARTAMENTO2, Me.colCODIGO_MUNICIPIO1, Me.colPOSICION, Me.colCODIGO_CANDIDATOS, Me.colIDENTIDAD, Me.colNOMBRE1, Me.colAPELLIDO, Me.colESTADO})
        Me.GridView7.DetailHeight = 100000
        Me.GridView7.GridControl = Me.GridControl1
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCODIGO_PARTIDO6, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colCODIGO_PARTIDO6
        '
        Me.colCODIGO_PARTIDO6.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO6.Name = "colCODIGO_PARTIDO6"
        '
        'colCODIGO_MOVIMIENTO5
        '
        Me.colCODIGO_MOVIMIENTO5.FieldName = "CODIGO_MOVIMIENTO"
        Me.colCODIGO_MOVIMIENTO5.Name = "colCODIGO_MOVIMIENTO5"
        '
        'colCODIGO_NIVEL_ELECTIVO4
        '
        Me.colCODIGO_NIVEL_ELECTIVO4.FieldName = "CODIGO_NIVEL_ELECTIVO"
        Me.colCODIGO_NIVEL_ELECTIVO4.Name = "colCODIGO_NIVEL_ELECTIVO4"
        '
        'colCODIGO_CARGO_ELECTIVO3
        '
        Me.colCODIGO_CARGO_ELECTIVO3.FieldName = "CODIGO_CARGO_ELECTIVO"
        Me.colCODIGO_CARGO_ELECTIVO3.Name = "colCODIGO_CARGO_ELECTIVO3"
        '
        'colCODIGO_DEPARTAMENTO2
        '
        Me.colCODIGO_DEPARTAMENTO2.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO2.Name = "colCODIGO_DEPARTAMENTO2"
        '
        'colCODIGO_MUNICIPIO1
        '
        Me.colCODIGO_MUNICIPIO1.FieldName = "CODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO1.Name = "colCODIGO_MUNICIPIO1"
        '
        'colPOSICION
        '
        Me.colPOSICION.FieldName = "POSICION"
        Me.colPOSICION.Name = "colPOSICION"
        Me.colPOSICION.Visible = True
        Me.colPOSICION.VisibleIndex = 0
        '
        'colCODIGO_CANDIDATOS
        '
        Me.colCODIGO_CANDIDATOS.FieldName = "CODIGO_CANDIDATOS"
        Me.colCODIGO_CANDIDATOS.Name = "colCODIGO_CANDIDATOS"
        Me.colCODIGO_CANDIDATOS.Visible = True
        Me.colCODIGO_CANDIDATOS.VisibleIndex = 1
        '
        'colIDENTIDAD
        '
        Me.colIDENTIDAD.FieldName = "IDENTIDAD"
        Me.colIDENTIDAD.Name = "colIDENTIDAD"
        Me.colIDENTIDAD.Visible = True
        Me.colIDENTIDAD.VisibleIndex = 2
        '
        'colNOMBRE1
        '
        Me.colNOMBRE1.FieldName = "NOMBRE"
        Me.colNOMBRE1.Name = "colNOMBRE1"
        Me.colNOMBRE1.Visible = True
        Me.colNOMBRE1.VisibleIndex = 3
        '
        'colAPELLIDO
        '
        Me.colAPELLIDO.FieldName = "APELLIDO"
        Me.colAPELLIDO.Name = "colAPELLIDO"
        Me.colAPELLIDO.Visible = True
        Me.colAPELLIDO.VisibleIndex = 4
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 5
        '
        'JrPartidosPoliticosTableAdapter
        '
        Me.JrPartidosPoliticosTableAdapter.ClearBeforeFill = True
        '
        'JrMovimientosTableAdapter
        '
        Me.JrMovimientosTableAdapter.ClearBeforeFill = True
        '
        'JrNivelesElectivosTableAdapter
        '
        Me.JrNivelesElectivosTableAdapter.ClearBeforeFill = True
        '
        'JrCargosElectivosTableAdapter
        '
        Me.JrCargosElectivosTableAdapter.ClearBeforeFill = True
        '
        'JrDepartamentosTableAdapter
        '
        Me.JrDepartamentosTableAdapter.ClearBeforeFill = True
        '
        'JrMunicipiosTableAdapter
        '
        Me.JrMunicipiosTableAdapter.ClearBeforeFill = True
        '
        'JrCandidatosTableAdapter
        '
        Me.JrCandidatosTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSalir)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(248, 64)
        Me.FlowLayoutPanel1.TabIndex = 17
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Image = Global.Inscripcion_de_Moviemientos.My.Resources.Resources.im_aim
        Me.btnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(3, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(55, 55)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.TabStop = False
        Me.btnSalir.Text = "Salir"
        '
        'XfrmJerarquico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 854)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "XfrmJerarquico"
        Me.Text = "Consulta Jerárquica de Candidatos"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JrPartidosPoliticosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DSConsultas As Inscripcion_de_Moviemientos.DSConsultas
    Friend WithEvents JrPartidosPoliticosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JrPartidosPoliticosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrPartidosPoliticosTableAdapter
    Friend WithEvents JrMovimientosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrMovimientosTableAdapter
    Friend WithEvents JrNivelesElectivosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrNivelesElectivosTableAdapter
    Friend WithEvents JrCargosElectivosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrCargosElectivosTableAdapter
    Friend WithEvents JrDepartamentosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrDepartamentosTableAdapter
    Friend WithEvents JrMunicipiosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrMunicipiosTableAdapter
    Friend WithEvents JrCandidatosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrCandidatosTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO_PARTIDO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_MOVIMIENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO_PARTIDO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOVIMIENTO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_NIVEL_ELECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO_PARTIDO3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOVIMIENTO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_NIVEL_ELECTIVO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CARGO_ELECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD_CARGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD_MUJERES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO_PARTIDO4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOVIMIENTO3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_NIVEL_ELECTIVO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CARGO_ELECTIVO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO_PARTIDO5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOVIMIENTO4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_NIVEL_ELECTIVO3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CARGO_ELECTIVO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO_PARTIDO6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MOVIMIENTO5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_NIVEL_ELECTIVO4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CARGO_ELECTIVO3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOSICION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CANDIDATOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDENTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPELLIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD_FIRMAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
End Class
