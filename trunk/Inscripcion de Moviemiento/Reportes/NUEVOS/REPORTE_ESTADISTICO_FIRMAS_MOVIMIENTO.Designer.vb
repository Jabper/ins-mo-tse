<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class REPORTE_ESTADISTICO_FIRMAS_MOVIMIENTO
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
        Dim XyDiagram3D1 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim Bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel
        Dim SideBySideBar3DSeriesView1 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim Bar3DSeriesLabel2 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel
        Dim SideBySideBar3DSeriesView2 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
        Dim Bar3DSeriesLabel3 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel
        Dim SideBySideBar3DSeriesView3 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView
        Dim Bar3DSeriesLabel4 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel
        Dim SideBySideBar3DSeriesView4 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView
        Me.GraficO_FIRMAS_ESTADISTICO1 = New Inscripcion_de_Moviemientos.GRAFICO_FIRMAS_ESTADISTICO
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.requeridas = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart
        Me.GRAFICOTableAdapter = New Inscripcion_de_Moviemientos.GRAFICO_FIRMAS_ESTADISTICOTableAdapters.GRAFICOTableAdapter
        Me.firmas_consis = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.Porcentaje_inc = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.porcentaje_cons = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.firmas_incon = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Total_firmas = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_LOG = New Inscripcion_de_Moviemientos.DS_LOG
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter = New Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_PARTIDOS_POLITICOS_imagenTableAdapter
        Me.IM_MOVIMIENTOS_imagenTableAdapter = New Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_MOVIMIENTOS_imagenTableAdapter
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.usuario_1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.NombrePartido = New DevExpress.XtraReports.Parameters.Parameter
        Me.NombreMovimiento = New DevExpress.XtraReports.Parameters.Parameter
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.MOVIMIENTO = New DevExpress.XtraReports.UI.XRLabel
        Me.PARTIDO = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.GraficO_FIRMAS_ESTADISTICO1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_LOG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'GraficO_FIRMAS_ESTADISTICO1
        '
        Me.GraficO_FIRMAS_ESTADISTICO1.DataSetName = "GRAFICO_FIRMAS_ESTADISTICO"
        Me.GraficO_FIRMAS_ESTADISTICO1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.requeridas, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrChart1, Me.firmas_consis, Me.XrLine1, Me.Porcentaje_inc, Me.XrLabel8, Me.porcentaje_cons, Me.XrLabel7, Me.firmas_incon, Me.XrLabel6, Me.XrLabel4, Me.Total_firmas, Me.XrLabel3})
        Me.Detail.HeightF = 595.8333!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'requeridas
        '
        Me.requeridas.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.requeridas.LocationFloat = New DevExpress.Utils.PointFloat(613.5417!, 41.25001!)
        Me.requeridas.Name = "requeridas"
        Me.requeridas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.requeridas.SizeF = New System.Drawing.SizeF(100.0!, 19.79166!)
        Me.requeridas.StylePriority.UseFont = False
        Me.requeridas.Text = "requeridas"
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(400.0!, 41.25001!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(192.7084!, 19.79167!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "Total de Firmas Requeridas:"
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(658.3333!, 119.75!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(22.5!, 22.99998!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "%"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(327.7083!, 119.75!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(21.875!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "%"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.Color.Black
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart1.DataAdapter = Me.GRAFICOTableAdapter
        Me.XrChart1.DataMember = "GRAFICO"
        Me.XrChart1.DataSource = Me.GraficO_FIRMAS_ESTADISTICO1
        XyDiagram3D1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram3D1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & _
            "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & _
            "1"
        Me.XrChart1.Diagram = XyDiagram3D1
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 169.7917!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.PaletteName = "Mixed"
        Series1.ArgumentDataMember = "GRAFICO.TOTAL_PRESENTADO"
        Series1.DataSource = Me.GraficO_FIRMAS_ESTADISTICO1
        Bar3DSeriesLabel1.LineVisible = True
        Bar3DSeriesLabel1.Visible = False
        Series1.Label = Bar3DSeriesLabel1
        Series1.LegendText = "Firmas Ingresadas"
        Series1.Name = "Series 1"
        Series1.Tag = "Firmas Ingresadas"
        Series1.ValueDataMembersSerializable = "GRAFICO.TOTAL_PRESENTADO"
        Series1.View = SideBySideBar3DSeriesView1
        Series2.ArgumentDataMember = "GRAFICO.CONSISTENTE"
        Series2.DataSource = Me.GraficO_FIRMAS_ESTADISTICO1
        Bar3DSeriesLabel2.LineVisible = True
        Bar3DSeriesLabel2.Visible = False
        Series2.Label = Bar3DSeriesLabel2
        Series2.LegendText = "Firmas Consistentes"
        Series2.Name = "Series 2"
        Series2.Tag = "Firmas Consistentes"
        Series2.ValueDataMembersSerializable = "GRAFICO.INCONSISTENTE"
        Series2.View = SideBySideBar3DSeriesView2
        Series3.ArgumentDataMember = "GRAFICO.INCONSISTENTE"
        Series3.DataSource = Me.GraficO_FIRMAS_ESTADISTICO1
        Bar3DSeriesLabel3.LineVisible = True
        Bar3DSeriesLabel3.Visible = False
        Series3.Label = Bar3DSeriesLabel3
        Series3.LegendText = "Firmas Inconsistentes"
        Series3.Name = "Series 3"
        Series3.Tag = "Firmas Inconsistentes"
        Series3.ValueDataMembersSerializable = "GRAFICO.INCONSISTENTE"
        Series3.View = SideBySideBar3DSeriesView3
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3}
        Bar3DSeriesLabel4.LineVisible = True
        Bar3DSeriesLabel4.Visible = True
        Me.XrChart1.SeriesTemplate.Label = Bar3DSeriesLabel4
        Me.XrChart1.SeriesTemplate.View = SideBySideBar3DSeriesView4
        Me.XrChart1.SizeF = New System.Drawing.SizeF(744.1666!, 392.0833!)
        '
        'GRAFICOTableAdapter
        '
        Me.GRAFICOTableAdapter.ClearBeforeFill = True
        '
        'firmas_consis
        '
        Me.firmas_consis.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.firmas_consis.LocationFloat = New DevExpress.Utils.PointFloat(269.3751!, 81.20833!)
        Me.firmas_consis.Name = "firmas_consis"
        Me.firmas_consis.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.firmas_consis.SizeF = New System.Drawing.SizeF(113.5416!, 23.0!)
        Me.firmas_consis.StylePriority.UseFont = False
        Me.firmas_consis.Text = "firmas_consis"
        '
        'XrLine1
        '
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(779.9999!, 23.0!)
        '
        'Porcentaje_inc
        '
        Me.Porcentaje_inc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Porcentaje_inc.LocationFloat = New DevExpress.Utils.PointFloat(613.5417!, 119.75!)
        Me.Porcentaje_inc.Name = "Porcentaje_inc"
        Me.Porcentaje_inc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Porcentaje_inc.SizeF = New System.Drawing.SizeF(44.79163!, 22.99998!)
        Me.Porcentaje_inc.StylePriority.UseFont = False
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(400.0!, 119.75!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(207.2917!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Porcentaje Firmas Inconsistentes:"
        '
        'porcentaje_cons
        '
        Me.porcentaje_cons.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.porcentaje_cons.LocationFloat = New DevExpress.Utils.PointFloat(269.3751!, 119.75!)
        Me.porcentaje_cons.Name = "porcentaje_cons"
        Me.porcentaje_cons.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.porcentaje_cons.SizeF = New System.Drawing.SizeF(58.33313!, 22.99998!)
        Me.porcentaje_cons.StylePriority.UseFont = False
        Me.porcentaje_cons.Text = "porcentaje_cons"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 119.75!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(203.1251!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "Porcentaje Firmas Consistentes:"
        '
        'firmas_incon
        '
        Me.firmas_incon.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.firmas_incon.LocationFloat = New DevExpress.Utils.PointFloat(613.5417!, 81.20833!)
        Me.firmas_incon.Name = "firmas_incon"
        Me.firmas_incon.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.firmas_incon.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.firmas_incon.StylePriority.UseFont = False
        Me.firmas_incon.Text = "firmas_incon"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(400.0!, 81.20833!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(194.7917!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "Total de Firmas Inconsistentes:"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 81.20833!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(189.5834!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Total de Firmas Consistentes:"
        '
        'Total_firmas
        '
        Me.Total_firmas.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Total_firmas.LocationFloat = New DevExpress.Utils.PointFloat(269.375!, 41.25001!)
        Me.Total_firmas.Name = "Total_firmas"
        Me.Total_firmas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Total_firmas.SizeF = New System.Drawing.SizeF(113.5417!, 23.0!)
        Me.Total_firmas.StylePriority.UseFont = False
        Me.Total_firmas.Text = "Total_firmas"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 41.25001!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(238.5416!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "Total de Firmas Ingresadas al Sistema:"
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrPictureBox2, Me.XrPictureBox1, Me.XrLabel1})
        Me.TopMargin.HeightF = 121.875!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 68.12499!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(600.0!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Reporte Estadistico de Firmas de Respaldo de Movimientos"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.BindingSource2, "IMAGEN")})
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(700.0!, 10.00001!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(100.0!, 58.12498!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "IM_MOVIMIENTOS_imagen"
        Me.BindingSource2.DataSource = Me.DS_LOG
        '
        'DS_LOG
        '
        Me.DS_LOG.DataSetName = "DS_LOG"
        Me.DS_LOG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "IMAGEN")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.00001!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(100.0!, 58.125!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 10.00001!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(600.0!, 58.125!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "TRIBUNAL SUPREMO ELECTORAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SISTEMA DE INSCRIPCION DE MOVIMIENTOS Y CANDIDATOS "
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "IM_PARTIDOS_POLITICOS_imagen"
        Me.BindingSource1.DataSource = Me.DS_LOG
        '
        'IM_PARTIDOS_POLITICOS_imagenTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.ClearBeforeFill = True
        '
        'IM_MOVIMIENTOS_imagenTableAdapter
        '
        Me.IM_MOVIMIENTOS_imagenTableAdapter.ClearBeforeFill = True
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.usuario_1, Me.XrLabel5, Me.XrPageInfo2, Me.XrPageInfo1})
        Me.ReportFooter.HeightF = 59.375!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'usuario_1
        '
        Me.usuario_1.LocationFloat = New DevExpress.Utils.PointFloat(400.0!, 12.08331!)
        Me.usuario_1.Name = "usuario_1"
        Me.usuario_1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.usuario_1.SizeF = New System.Drawing.SizeF(300.0!, 23.00002!)
        Me.usuario_1.Text = "usuario_1"
        '
        'XrLabel5
        '
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(320.8333!, 12.08331!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(79.16667!, 23.0!)
        Me.XrLabel5.Text = "Impreso por:"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "Pagina {0} de {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(700.0!, 12.08334!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(90.0!, 22.99998!)
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Format = "{0:dddd, dd' de 'MMMM' de 'yyyy hh:mm tt}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(5.208333!, 12.08331!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(288.125!, 22.99998!)
        '
        'NombrePartido
        '
        Me.NombrePartido.Description = "Partido Político"
        Me.NombrePartido.Name = "NombrePartido"
        '
        'NombreMovimiento
        '
        Me.NombreMovimiento.Description = "Movimiento Político"
        Me.NombreMovimiento.Name = "NombreMovimiento"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.MOVIMIENTO, Me.PARTIDO, Me.XrLabel10, Me.XrLabel9})
        Me.PageHeader.HeightF = 83.74996!
        Me.PageHeader.Name = "PageHeader"
        '
        'MOVIMIENTO
        '
        Me.MOVIMIENTO.LocationFloat = New DevExpress.Utils.PointFloat(203.125!, 47.87499!)
        Me.MOVIMIENTO.Name = "MOVIMIENTO"
        Me.MOVIMIENTO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.MOVIMIENTO.SizeF = New System.Drawing.SizeF(344.7917!, 23.0!)
        Me.MOVIMIENTO.Text = "MOVIMIENTO"
        '
        'PARTIDO
        '
        Me.PARTIDO.LocationFloat = New DevExpress.Utils.PointFloat(203.125!, 10.00001!)
        Me.PARTIDO.Name = "PARTIDO"
        Me.PARTIDO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.PARTIDO.SizeF = New System.Drawing.SizeF(344.7917!, 23.0!)
        Me.PARTIDO.Text = "PARTIDO"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 47.87499!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(177.0834!, 23.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "MOVIMIENTO POLITICO:"
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(157.2917!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "PARTIDO POLITICO:"
        '
        'REPORTE_ESTADISTICO_FIRMAS_MOVIMIENTO
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter, Me.PageHeader})
        Me.DataSource = Me.BindingSource1
        Me.Margins = New System.Drawing.Printing.Margins(24, 26, 122, 100)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.NombrePartido, Me.NombreMovimiento})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "11.2"
        CType(Me.GraficO_FIRMAS_ESTADISTICO1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_LOG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DS_LOG As Inscripcion_de_Moviemientos.DS_LOG
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOS_imagenTableAdapter As Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_PARTIDOS_POLITICOS_imagenTableAdapter
    Friend WithEvents IM_MOVIMIENTOS_imagenTableAdapter As Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_MOVIMIENTOS_imagenTableAdapter
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Total_firmas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents firmas_incon As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NombrePartido As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents NombreMovimiento As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents usuario_1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Porcentaje_inc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents porcentaje_cons As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents MOVIMIENTO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PARTIDO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GRAFICOTableAdapter As Inscripcion_de_Moviemientos.GRAFICO_FIRMAS_ESTADISTICOTableAdapters.GRAFICOTableAdapter
    Friend WithEvents GraficO_FIRMAS_ESTADISTICO1 As Inscripcion_de_Moviemientos.GRAFICO_FIRMAS_ESTADISTICO
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents firmas_consis As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents requeridas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
End Class
