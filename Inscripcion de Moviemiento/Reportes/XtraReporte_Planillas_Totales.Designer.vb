<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReporte_Planillas_Totales
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.partidopolitico = New DevExpress.XtraReports.UI.XRLabel
        Me.movimientopolitico = New DevExpress.XtraReports.UI.XRLabel
        Me.nivelelectivo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.Partido = New DevExpress.XtraReports.Parameters.Parameter
        Me.Movimiento = New DevExpress.XtraReports.Parameters.Parameter
        Me.Departamento = New DevExpress.XtraReports.Parameters.Parameter
        Me.Municipio = New DevExpress.XtraReports.Parameters.Parameter
        Me.Nivel_Electivo = New DevExpress.XtraReports.Parameters.Parameter
        Me.DT_CANDIDATOS_FINALES1 = New Inscripcion_de_Moviemientos.DT_CANDIDATOS_FINALES
        Me.IM_V_MOSTRAR_CANDIDATOS2TableAdapter = New Inscripcion_de_Moviemientos.DT_CANDIDATOS_FINALESTableAdapters.IM_V_MOSTRAR_CANDIDATOS2TableAdapter
        CType(Me.DT_CANDIDATOS_FINALES1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.Detail.HeightF = 147.9167!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.NOMBRE")})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 24.95832!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 51.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 39.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.partidopolitico, Me.movimientopolitico, Me.nivelelectivo, Me.XrLabel24})
        Me.ReportHeader.HeightF = 123.9583!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(193.9724!, 48.62497!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(179.1667!, 32.37502!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "MOVIMIENTO"
        '
        'partidopolitico
        '
        Me.partidopolitico.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.PARTIDO")})
        Me.partidopolitico.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Italic)
        Me.partidopolitico.LocationFloat = New DevExpress.Utils.PointFloat(150.2219!, 9.999985!)
        Me.partidopolitico.Name = "partidopolitico"
        Me.partidopolitico.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.partidopolitico.SizeF = New System.Drawing.SizeF(634.375!, 38.62498!)
        Me.partidopolitico.StylePriority.UseFont = False
        Me.partidopolitico.StylePriority.UseTextAlignment = False
        Me.partidopolitico.Text = "partidopolitico"
        Me.partidopolitico.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'movimientopolitico
        '
        Me.movimientopolitico.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.NOMBRE_MOVIMIENTO")})
        Me.movimientopolitico.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Italic)
        Me.movimientopolitico.LocationFloat = New DevExpress.Utils.PointFloat(390.8468!, 48.62497!)
        Me.movimientopolitico.Name = "movimientopolitico"
        Me.movimientopolitico.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.movimientopolitico.SizeF = New System.Drawing.SizeF(427.0832!, 33.0417!)
        Me.movimientopolitico.StylePriority.UseFont = False
        Me.movimientopolitico.StylePriority.UseTextAlignment = False
        Me.movimientopolitico.Text = "movimientopolitico"
        Me.movimientopolitico.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'nivelelectivo
        '
        Me.nivelelectivo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.CARGO")})
        Me.nivelelectivo.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Italic)
        Me.nivelelectivo.LocationFloat = New DevExpress.Utils.PointFloat(250.8466!, 81.66666!)
        Me.nivelelectivo.Name = "nivelelectivo"
        Me.nivelelectivo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.nivelelectivo.SizeF = New System.Drawing.SizeF(616.8306!, 33.41665!)
        Me.nivelelectivo.StylePriority.UseFont = False
        Me.nivelelectivo.Text = "nivelelectivo"
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(101.4717!, 81.66666!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(149.3749!, 34.45835!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.Text = "PLANILLA DE"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.HeightF = 56.11703!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3})
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.MUNICIPIO")})
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 37.5!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(616.8306!, 33.41665!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "XrLabel3"
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2})
        Me.GroupHeader3.Level = 2
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.DEPARTAMENTO")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 37.5!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(616.8306!, 33.41665!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "XrLabel2"
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 98.95834!
        Me.PageFooter.Name = "PageFooter"
        '
        'Partido
        '
        Me.Partido.Name = "Partido"
        '
        'Movimiento
        '
        Me.Movimiento.Name = "Movimiento"
        '
        'Departamento
        '
        Me.Departamento.Name = "Departamento"
        '
        'Municipio
        '
        Me.Municipio.Name = "Municipio"
        '
        'Nivel_Electivo
        '
        Me.Nivel_Electivo.Name = "Nivel_Electivo"
        '
        'DT_CANDIDATOS_FINALES1
        '
        Me.DT_CANDIDATOS_FINALES1.DataSetName = "DT_CANDIDATOS_FINALES"
        Me.DT_CANDIDATOS_FINALES1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IM_V_MOSTRAR_CANDIDATOS2TableAdapter
        '
        Me.IM_V_MOSTRAR_CANDIDATOS2TableAdapter.ClearBeforeFill = True
        '
        'XtraReporte_Planillas_Totales
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2, Me.GroupHeader3, Me.PageFooter})
        Me.DataAdapter = Me.IM_V_MOSTRAR_CANDIDATOS2TableAdapter
        Me.DataMember = "IM_V_MOSTRAR_CANDIDATOS2"
        Me.DataSource = Me.DT_CANDIDATOS_FINALES1
        Me.FilterString = "[PARTIDO] = ?Partido And [MOVIMIENTO] = ?Movimiento And [CARGO] = ?Nivel_Electivo" & _
            ""
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(31, 31, 51, 39)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Partido, Me.Movimiento, Me.Departamento, Me.Municipio, Me.Nivel_Electivo})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "11.2"
        CType(Me.DT_CANDIDATOS_FINALES1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents partidopolitico As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents movimientopolitico As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents nivelelectivo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Partido As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Movimiento As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Departamento As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Municipio As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Nivel_Electivo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DT_CANDIDATOS_FINALES1 As Inscripcion_de_Moviemientos.DT_CANDIDATOS_FINALES
    Friend WithEvents IM_V_MOSTRAR_CANDIDATOS2TableAdapter As Inscripcion_de_Moviemientos.DT_CANDIDATOS_FINALESTableAdapters.IM_V_MOSTRAR_CANDIDATOS2TableAdapter
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
