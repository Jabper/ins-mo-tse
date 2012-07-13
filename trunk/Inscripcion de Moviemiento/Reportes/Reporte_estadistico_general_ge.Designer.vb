<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Reporte_estadistico_general_ge
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim SideBySideBarSeriesLabel4 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim SideBySideBarSeriesLabel5 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
        Me.DSESTADISTICOGENERALGE1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_ESTADISTICO_GENERAL_GE1 = New Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GE
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart
        Me.IM_V_PARTICIPACION_FETableAdapter = New Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.IM_V_PARTICIPACION_FETableAdapter
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.PC = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.TCM = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.TCN = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.NP = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.TOTAL = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.NPRE = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_LOG = New Inscripcion_de_Moviemientos.DS_LOG
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.NombrePartido = New DevExpress.XtraReports.Parameters.Parameter
        Me.NombreMovimiento = New DevExpress.XtraReports.Parameters.Parameter
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter = New Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_PARTIDOS_POLITICOS_imagenTableAdapter
        Me.IM_MOVIMIENTOS_imagenTableAdapter = New Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_MOVIMIENTOS_imagenTableAdapter
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_TOTALTableAdapter = New Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.DT_TOTALTableAdapter
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_PRESIDENCIALTableAdapter = New Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.DT_PRESIDENCIALTableAdapter
        Me.BindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_PARLACENTableAdapter = New Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.DT_PARLACENTableAdapter
        Me.BindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_CONGRESOTableAdapter = New Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.DT_CONGRESOTableAdapter
        Me.BindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_CORPORACIONTableAdapter = New Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.DT_CORPORACIONTableAdapter
        CType(Me.DSESTADISTICOGENERALGE1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ESTADISTICO_GENERAL_GE1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_LOG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DSESTADISTICOGENERALGE1BindingSource
        '
        Me.DSESTADISTICOGENERALGE1BindingSource.DataSource = Me.DS_ESTADISTICO_GENERAL_GE1
        Me.DSESTADISTICOGENERALGE1BindingSource.Position = 0
        '
        'DS_ESTADISTICO_GENERAL_GE1
        '
        Me.DS_ESTADISTICO_GENERAL_GE1.DataSetName = "DS_ESTADISTICO_GENERAL_GE"
        Me.DS_ESTADISTICO_GENERAL_GE1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart1, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel12, Me.PC, Me.XrLabel10, Me.TCM, Me.XrLabel8, Me.TCN, Me.XrLabel6, Me.NP, Me.XrLabel4, Me.TOTAL, Me.XrLabel2, Me.NPRE, Me.XrPageInfo1, Me.XrPageInfo2})
        Me.Detail.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Detail.HeightF = 682.7084!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.StylePriority.UseForeColor = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.Color.Black
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart1.DataAdapter = Me.IM_V_PARTICIPACION_FETableAdapter
        Me.XrChart1.DataMember = "IM_V_PARTICIPACION_FE"
        Me.XrChart1.DataSource = Me.DS_ESTADISTICO_GENERAL_GE1
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart1.Diagram = XyDiagram1
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 282.2917!)
        Me.XrChart1.Name = "XrChart1"
        Series1.ArgumentDataMember = "TOTAL1"
        Series1.DataSource = Me.BindingSource4
        SideBySideBarSeriesLabel1.LineVisible = True
        SideBySideBarSeriesLabel1.Visible = False
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.Name = "Nivel Presidencial"
        Series1.ValueDataMembersSerializable = "TOTAL1"
        Series2.ArgumentDataMember = "TOTAL4"
        Series2.DataSource = Me.BindingSource5
        SideBySideBarSeriesLabel2.LineVisible = True
        SideBySideBarSeriesLabel2.Visible = False
        Series2.Label = SideBySideBarSeriesLabel2
        Series2.Name = "PARLACEN"
        Series2.ValueDataMembersSerializable = "TOTAL4"
        Series3.ArgumentDataMember = "TOTAL2"
        Series3.DataSource = Me.BindingSource6
        SideBySideBarSeriesLabel3.LineVisible = True
        SideBySideBarSeriesLabel3.Visible = False
        Series3.Label = SideBySideBarSeriesLabel3
        Series3.Name = "Congreso Nacional"
        Series3.ValueDataMembersSerializable = "TOTAL2"
        Series4.ArgumentDataMember = "TOTAL3"
        Series4.DataSource = Me.BindingSource7
        SideBySideBarSeriesLabel4.LineVisible = True
        SideBySideBarSeriesLabel4.Visible = False
        Series4.Label = SideBySideBarSeriesLabel4
        Series4.Name = "Corporación Municipal"
        Series4.ValueDataMembersSerializable = "TOTAL3"
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3, Series4}
        SideBySideBarSeriesLabel5.LineVisible = True
        Me.XrChart1.SeriesTemplate.Label = SideBySideBarSeriesLabel5
        Me.XrChart1.SizeF = New System.Drawing.SizeF(764.5833!, 336.2501!)
        ChartTitle1.Text = "Grafico Estadistico de Participación Efectiva"
        Me.XrChart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'IM_V_PARTICIPACION_FETableAdapter
        '
        Me.IM_V_PARTICIPACION_FETableAdapter.ClearBeforeFill = True
        '
        'XrLabel16
        '
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PARTICIPACION_FE.NIVELCM")})
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.ForeColor = System.Drawing.Color.Green
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(940.4584!, 187.8333!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.Text = "XrLabel16"
        Me.XrLabel16.Visible = False
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PARTICIPACION_FE.NIVELCN")})
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.ForeColor = System.Drawing.Color.Green
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(940.4584!, 148.25!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.Visible = False
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PARTICIPACION_FE.NIVELPAR")})
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.ForeColor = System.Drawing.Color.Green
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(940.4584!, 109.3333!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.Visible = False
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(515.6249!, 23.91666!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(205.2084!, 23.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = " Participación"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PC
        '
        Me.PC.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DT_PARLACEN.TOTAL4")})
        Me.PC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PC.ForeColor = System.Drawing.Color.Green
        Me.PC.LocationFloat = New DevExpress.Utils.PointFloat(620.8333!, 109.3333!)
        Me.PC.Name = "PC"
        Me.PC.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PC.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.PC.StylePriority.UseFont = False
        Me.PC.StylePriority.UseForeColor = False
        Me.PC.Text = "PC"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(48.95833!, 109.3333!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(372.9166!, 22.99998!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "Participación Total Parlamento Centroamericano:"
        '
        'TCM
        '
        Me.TCM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TCM.ForeColor = System.Drawing.Color.Green
        Me.TCM.LocationFloat = New DevExpress.Utils.PointFloat(620.8333!, 187.8333!)
        Me.TCM.Name = "TCM"
        Me.TCM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TCM.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.TCM.StylePriority.UseFont = False
        Me.TCM.StylePriority.UseForeColor = False
        Me.TCM.Text = "[DT_CORPORACION.TOTAL3]"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(48.95833!, 187.8333!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(326.0416!, 22.99998!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Participación Total Corporación Municipal:"
        '
        'TCN
        '
        Me.TCN.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DT_CONGRESO.TOTAL2")})
        Me.TCN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TCN.ForeColor = System.Drawing.Color.Green
        Me.TCN.LocationFloat = New DevExpress.Utils.PointFloat(620.8333!, 148.25!)
        Me.TCN.Name = "TCN"
        Me.TCN.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TCN.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.TCN.StylePriority.UseFont = False
        Me.TCN.StylePriority.UseForeColor = False
        Me.TCN.Text = "TCN"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(48.95833!, 148.25!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(289.5833!, 22.99998!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "Participación Total Congreso Nacional:"
        '
        'NP
        '
        Me.NP.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DT_PRESIDENCIAL.TOTAL1")})
        Me.NP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NP.ForeColor = System.Drawing.Color.Green
        Me.NP.LocationFloat = New DevExpress.Utils.PointFloat(620.8333!, 74.95833!)
        Me.NP.Name = "NP"
        Me.NP.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NP.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.NP.StylePriority.UseFont = False
        Me.NP.StylePriority.UseForeColor = False
        Me.NP.Text = "NP"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(48.95833!, 74.95833!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(289.5833!, 22.99998!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Participación Total Nivel Presidencial:"
        '
        'TOTAL
        '
        Me.TOTAL.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DT_TOTAL.TOTAL")})
        Me.TOTAL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TOTAL.ForeColor = System.Drawing.Color.Green
        Me.TOTAL.LocationFloat = New DevExpress.Utils.PointFloat(620.8333!, 241.625!)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TOTAL.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.TOTAL.StylePriority.UseFont = False
        Me.TOTAL.StylePriority.UseForeColor = False
        Me.TOTAL.Text = "TOTAL"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(48.95833!, 241.625!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(220.8333!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Participación Total: "
        '
        'NPRE
        '
        Me.NPRE.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NPRE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NPRE.ForeColor = System.Drawing.Color.Green
        Me.NPRE.LocationFloat = New DevExpress.Utils.PointFloat(940.4584!, 74.95833!)
        Me.NPRE.Name = "NPRE"
        Me.NPRE.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NPRE.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.NPRE.StylePriority.UseBorders = False
        Me.NPRE.StylePriority.UseFont = False
        Me.NPRE.StylePriority.UseForeColor = False
        Me.NPRE.Text = "NPRE"
        Me.NPRE.Visible = False
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(25.54165!, 634.1667!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "Page {0} of {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(657.2917!, 634.1667!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 22.91667!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 72.49998!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox2, Me.XrPictureBox1, Me.XrLabel1})
        Me.ReportHeader.HeightF = 102.7917!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.BindingSource1, "IMAGEN")})
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.00168!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(113.54!, 82.79!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "IM_PARTIDOS_POLITICOS_imagen"
        Me.BindingSource1.DataSource = Me.DS_LOG
        '
        'DS_LOG
        '
        Me.DS_LOG.DataSetName = "DS_LOG"
        Me.DS_LOG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.BindingSource2, "IMAGEN")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(940.4584!, 10.00001!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(113.5416!, 82.79168!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "IM_MOVIMIENTOS_imagen"
        Me.BindingSource2.DataSource = Me.DS_LOG
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 20.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(126.6667!, 10.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(801.2916!, 92.79166!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Reporte Estadistico General de Participación Efectiva de la Mujer"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 48.33334!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'NombrePartido
        '
        Me.NombrePartido.Description = "Nombre de Partido"
        Me.NombrePartido.Name = "NombrePartido"
        '
        'NombreMovimiento
        '
        Me.NombreMovimiento.Description = "Nombre  de Movimiento"
        Me.NombreMovimiento.Name = "NombreMovimiento"
        '
        'IM_PARTIDOS_POLITICOS_imagenTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.ClearBeforeFill = True
        '
        'IM_MOVIMIENTOS_imagenTableAdapter
        '
        Me.IM_MOVIMIENTOS_imagenTableAdapter.ClearBeforeFill = True
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "DT_TOTAL"
        Me.BindingSource3.DataSource = Me.DS_ESTADISTICO_GENERAL_GE1
        '
        'DT_TOTALTableAdapter
        '
        Me.DT_TOTALTableAdapter.ClearBeforeFill = True
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "DT_PRESIDENCIAL"
        Me.BindingSource4.DataSource = Me.DS_ESTADISTICO_GENERAL_GE1
        '
        'DT_PRESIDENCIALTableAdapter
        '
        Me.DT_PRESIDENCIALTableAdapter.ClearBeforeFill = True
        '
        'BindingSource5
        '
        Me.BindingSource5.DataMember = "DT_PARLACEN"
        Me.BindingSource5.DataSource = Me.DS_ESTADISTICO_GENERAL_GE1
        '
        'DT_PARLACENTableAdapter
        '
        Me.DT_PARLACENTableAdapter.ClearBeforeFill = True
        '
        'BindingSource6
        '
        Me.BindingSource6.DataMember = "DT_CONGRESO"
        Me.BindingSource6.DataSource = Me.DS_ESTADISTICO_GENERAL_GE1
        '
        'DT_CONGRESOTableAdapter
        '
        Me.DT_CONGRESOTableAdapter.ClearBeforeFill = True
        '
        'BindingSource7
        '
        Me.BindingSource7.DataMember = "DT_CORPORACION"
        Me.BindingSource7.DataSource = Me.DS_ESTADISTICO_GENERAL_GE1
        '
        'DT_CORPORACIONTableAdapter
        '
        Me.DT_CORPORACIONTableAdapter.ClearBeforeFill = True
        '
        'Reporte_estadistico_general_ge
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.DataAdapter = Me.IM_V_PARTICIPACION_FETableAdapter
        Me.DataMember = "IM_V_PARTICIPACION_FE"
        Me.DataSource = Me.DS_ESTADISTICO_GENERAL_GE1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(16, 20, 23, 72)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.NombrePartido, Me.NombreMovimiento})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "11.2"
        CType(Me.DSESTADISTICOGENERALGE1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ESTADISTICO_GENERAL_GE1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_LOG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NP As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TOTAL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TCM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TCN As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PC As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NPRE As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents DS_ESTADISTICO_GENERAL_GE1 As Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GE
    Friend WithEvents IM_V_PARTICIPACION_FETableAdapter As Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.IM_V_PARTICIPACION_FETableAdapter
    Friend WithEvents DSESTADISTICOGENERALGE1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents NombrePartido As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents NombreMovimiento As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DS_LOG As Inscripcion_de_Moviemientos.DS_LOG
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOS_imagenTableAdapter As Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_PARTIDOS_POLITICOS_imagenTableAdapter
    Friend WithEvents IM_MOVIMIENTOS_imagenTableAdapter As Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_MOVIMIENTOS_imagenTableAdapter
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents DT_TOTALTableAdapter As Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.DT_TOTALTableAdapter
    Friend WithEvents BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents DT_PRESIDENCIALTableAdapter As Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.DT_PRESIDENCIALTableAdapter
    Friend WithEvents BindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents DT_PARLACENTableAdapter As Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.DT_PARLACENTableAdapter
    Friend WithEvents BindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents DT_CONGRESOTableAdapter As Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.DT_CONGRESOTableAdapter
    Friend WithEvents BindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents DT_CORPORACIONTableAdapter As Inscripcion_de_Moviemientos.DS_ESTADISTICO_GENERAL_GETableAdapters.DT_CORPORACIONTableAdapter
End Class
