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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.gvwPartidos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DSConsultas = New Inscripcion_de_Moviemientos.DSConsultas
        Me.JrPartidosPoliticosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JrPartidosPoliticosTableAdapter = New Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrPartidosPoliticosTableAdapter
        Me.colCODIGO_PARTIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCANTIDAD_FIRMAS = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwPartidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JrPartidosPoliticosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.JrPartidosPoliticosBindingSource
        GridLevelNode6.RelationName = "jrCandidatosMunicipio"
        GridLevelNode5.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode6})
        GridLevelNode5.RelationName = "jrMunicipiosDepartamento"
        GridLevelNode4.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode5})
        GridLevelNode4.RelationName = "jrDepartamentosCargoElectivo"
        GridLevelNode3.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode4})
        GridLevelNode3.RelationName = "jrCargosElectivosNivelElectivo"
        GridLevelNode2.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3})
        GridLevelNode2.RelationName = "jrNivelesElectivosMovimiento"
        GridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        GridLevelNode1.RelationName = "jrMovimientosPartidoPolitico"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.gvwPartidos
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1345, 654)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwPartidos, Me.GridView2})
        '
        'gvwPartidos
        '
        Me.gvwPartidos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODIGO_PARTIDO, Me.colNOMBRE, Me.colCANTIDAD_FIRMAS})
        Me.gvwPartidos.GridControl = Me.GridControl1
        Me.gvwPartidos.Name = "gvwPartidos"
        Me.gvwPartidos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvwPartidos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvwPartidos.OptionsBehavior.Editable = False
        Me.gvwPartidos.OptionsBehavior.ReadOnly = True
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'DSConsultas
        '
        Me.DSConsultas.DataSetName = "DSConsultas"
        Me.DSConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JrPartidosPoliticosBindingSource
        '
        Me.JrPartidosPoliticosBindingSource.DataMember = "jrPartidosPoliticos"
        Me.JrPartidosPoliticosBindingSource.DataSource = Me.DSConsultas
        '
        'JrPartidosPoliticosTableAdapter
        '
        Me.JrPartidosPoliticosTableAdapter.ClearBeforeFill = True
        '
        'colCODIGO_PARTIDO
        '
        Me.colCODIGO_PARTIDO.FieldName = "CODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Name = "colCODIGO_PARTIDO"
        Me.colCODIGO_PARTIDO.Visible = True
        Me.colCODIGO_PARTIDO.VisibleIndex = 0
        '
        'colNOMBRE
        '
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 1
        '
        'colCANTIDAD_FIRMAS
        '
        Me.colCANTIDAD_FIRMAS.FieldName = "CANTIDAD_FIRMAS"
        Me.colCANTIDAD_FIRMAS.Name = "colCANTIDAD_FIRMAS"
        Me.colCANTIDAD_FIRMAS.Visible = True
        Me.colCANTIDAD_FIRMAS.VisibleIndex = 2
        '
        'XfrmJerarquico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 678)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "XfrmJerarquico"
        Me.Text = "XfrmJerarquico"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwPartidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JrPartidosPoliticosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwPartidos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DSConsultas As Inscripcion_de_Moviemientos.DSConsultas
    Friend WithEvents JrPartidosPoliticosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JrPartidosPoliticosTableAdapter As Inscripcion_de_Moviemientos.DSConsultasTableAdapters.jrPartidosPoliticosTableAdapter
    Friend WithEvents colCODIGO_PARTIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD_FIRMAS As DevExpress.XtraGrid.Columns.GridColumn
End Class
