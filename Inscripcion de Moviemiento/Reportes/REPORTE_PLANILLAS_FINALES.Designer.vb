<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class REPORTE_PLANILLAS_FINALES
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
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.id = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.total = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.totalpp = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.totalpre = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.totalde = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.totalsp = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.total_presidencial = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.total_general = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.total_designado = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.totalparp = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.totalpars = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.totaldipup = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.totaldipus = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.NombrePartido = New DevExpress.XtraReports.Parameters.Parameter
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.ndepartamento = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.nivelelectivo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.movimientopolitico = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.partidopolitico = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.NombreMovimiento = New DevExpress.XtraReports.Parameters.Parameter
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.DS_PLANILLA_TOTALES1 = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALES
        Me.IM_CANDIDATOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_CANDIDATOSTableAdapter
        Me.nivel = New DevExpress.XtraReports.Parameters.Parameter
        Me.NombreDep = New DevExpress.XtraReports.Parameters.Parameter
        CType(Me.DS_PLANILLA_TOTALES1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1, Me.XrLabel22, Me.XrLabel20, Me.XrLabel18, Me.id})
        Me.Detail.HeightF = 118.75!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "IM_CANDIDATOS.IMAGEN")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(911.4583!, 9.999974!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(139.5419!, 84.16665!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_CANDIDATOS.CARGO")})
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(632.2917!, 8.666675!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(261.4583!, 23.0!)
        Me.XrLabel22.Text = "XrLabel22"
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_CANDIDATOS.APELLIDO")})
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(348.9583!, 9.999974!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(260.4167!, 23.00002!)
        Me.XrLabel20.Text = "XrLabel20"
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_CANDIDATOS.NOMBRE")})
        Me.XrLabel18.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(140.625!, 8.666675!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(208.3333!, 23.00002!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "XrLabel18"
        '
        'id
        '
        Me.id.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_CANDIDATOS.IDENTIDAD")})
        Me.id.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 8.666675!)
        Me.id.Name = "id"
        Me.id.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.id.SizeF = New System.Drawing.SizeF(113.5417!, 23.00002!)
        Me.id.Text = "id"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 15.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox3, Me.XrPictureBox2, Me.XrLabel1, Me.XrLabel6, Me.total, Me.XrLabel3, Me.totalpp, Me.XrLabel4, Me.XrLabel5, Me.totalpre, Me.XrLabel2, Me.totalde, Me.XrLabel7, Me.totalsp, Me.XrLabel9, Me.total_presidencial, Me.XrLabel11, Me.total_general, Me.XrLabel12, Me.XrLabel13, Me.total_designado, Me.XrLabel14, Me.totalparp, Me.XrLabel15, Me.totalpars, Me.XrLabel25, Me.XrLabel26, Me.totaldipup, Me.XrLabel28, Me.totaldipus})
        Me.ReportHeader.HeightF = 421.875!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "IM_CANDIDATOS.PAR")})
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(27.08333!, 10.00001!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(96.45837!, 81.0417!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "IM_CANDIDATOS.MOV")})
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(944.0001!, 10.00001!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(100.0!, 81.0417!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 20.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(222.8749!, 10.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(602.75!, 56.66664!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Reporte General de Planillas "
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 232.2502!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(390.625!, 22.99998!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "Designados(a) Presidenciales Requeridos:"
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.total.LocationFloat = New DevExpress.Utils.PointFloat(443.3334!, 137.0833!)
        Me.total.Name = "total"
        Me.total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.total.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.total.StylePriority.UseFont = False
        Me.total.Text = "total"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 255.25!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(390.625!, 22.99998!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "Diputados(a) Propietarios Requeridos al Parlacen :"
        '
        'totalpp
        '
        Me.totalpp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.totalpp.LocationFloat = New DevExpress.Utils.PointFloat(443.3334!, 255.2499!)
        Me.totalpp.Name = "totalpp"
        Me.totalpp.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalpp.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.totalpp.StylePriority.UseFont = False
        Me.totalpp.Text = "totalpp"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(56.87501!, 177.7918!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(239.5833!, 30.54165!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Detalle de Planilla Presidencial"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 208.3335!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(390.625!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "Candidato(a) a la Presidencia Requerido:"
        '
        'totalpre
        '
        Me.totalpre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.totalpre.LocationFloat = New DevExpress.Utils.PointFloat(443.3334!, 208.3333!)
        Me.totalpre.Name = "totalpre"
        Me.totalpre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalpre.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.totalpre.StylePriority.UseFont = False
        Me.totalpre.Text = "totalpre"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 137.0834!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(390.625!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Candidatos(a) Requeridos en Planilla Presidencial: "
        '
        'totalde
        '
        Me.totalde.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.totalde.LocationFloat = New DevExpress.Utils.PointFloat(443.3334!, 232.25!)
        Me.totalde.Name = "totalde"
        Me.totalde.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalde.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.totalde.StylePriority.UseFont = False
        Me.totalde.Text = "totalde"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 278.2501!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(390.625!, 22.99998!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "Diputados(a) Suplentes Requeridos al Parlacen:"
        '
        'totalsp
        '
        Me.totalsp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.totalsp.LocationFloat = New DevExpress.Utils.PointFloat(443.3334!, 278.2499!)
        Me.totalsp.Name = "totalsp"
        Me.totalsp.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalsp.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.totalsp.StylePriority.UseFont = False
        Me.totalsp.Text = "totalsp"
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(657.9166!, 177.7918!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(258.3333!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Detalle Actual de la Planilla"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'total_presidencial
        '
        Me.total_presidencial.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.total_presidencial.LocationFloat = New DevExpress.Utils.PointFloat(926.9167!, 208.3333!)
        Me.total_presidencial.Name = "total_presidencial"
        Me.total_presidencial.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.total_presidencial.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.total_presidencial.StylePriority.UseFont = False
        Me.total_presidencial.Text = "total_presidencial"
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(615.2083!, 137.0833!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(247.9166!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.Text = "Candidato(a) en Planilla Actual:"
        '
        'total_general
        '
        Me.total_general.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.total_general.LocationFloat = New DevExpress.Utils.PointFloat(926.9167!, 137.0833!)
        Me.total_general.Name = "total_general"
        Me.total_general.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.total_general.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.total_general.StylePriority.UseFont = False
        Me.total_general.Text = "total_general"
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(586.0416!, 208.3333!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(278.125!, 23.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.Text = "Candidato(a) a la Presidencia:"
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(586.0416!, 232.25!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(278.125!, 22.99998!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "Designados(a) Presidenciales:"
        '
        'total_designado
        '
        Me.total_designado.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.total_designado.LocationFloat = New DevExpress.Utils.PointFloat(926.9167!, 232.25!)
        Me.total_designado.Name = "total_designado"
        Me.total_designado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.total_designado.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.total_designado.StylePriority.UseFont = False
        Me.total_designado.Text = "total_designado"
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(586.0416!, 255.25!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(296.8749!, 22.99998!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.Text = "Diputados(a) Propietarios al Parlacen:"
        '
        'totalparp
        '
        Me.totalparp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.totalparp.LocationFloat = New DevExpress.Utils.PointFloat(926.9167!, 255.2499!)
        Me.totalparp.Name = "totalparp"
        Me.totalparp.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalparp.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.totalparp.StylePriority.UseFont = False
        Me.totalparp.Text = "totalparp"
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(586.0416!, 278.2501!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(296.875!, 23.00003!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "Diputados(a)Suplentes al Parlacen:"
        '
        'totalpars
        '
        Me.totalpars.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.totalpars.LocationFloat = New DevExpress.Utils.PointFloat(926.9167!, 278.2501!)
        Me.totalpars.Name = "totalpars"
        Me.totalpars.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalpars.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.totalpars.StylePriority.UseFont = False
        Me.totalpars.Text = "totalpars"
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(53.75002!, 323.9167!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(302.0833!, 23.00002!)
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Detalle de Planilla Congreso Nacional "
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel26
        '
        Me.XrLabel26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 362.4583!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(433.3333!, 23.0!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.Text = "Diputados(a)Propietarios al Congreso Nacional Requeridos:"
        '
        'totaldipup
        '
        Me.totaldipup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.totaldipup.LocationFloat = New DevExpress.Utils.PointFloat(443.3334!, 362.4583!)
        Me.totaldipup.Name = "totaldipup"
        Me.totaldipup.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totaldipup.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.totaldipup.StylePriority.UseFont = False
        Me.totaldipup.Text = "totaldipup"
        '
        'XrLabel28
        '
        Me.XrLabel28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 385.4584!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(433.3333!, 23.00003!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.Text = "Diputados(a)Suplentes al Congreso Nacional Requeridos:"
        '
        'totaldipus
        '
        Me.totaldipus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.totaldipus.LocationFloat = New DevExpress.Utils.PointFloat(443.3333!, 385.4584!)
        Me.totaldipus.Name = "totaldipus"
        Me.totaldipus.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totaldipus.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.totaldipus.StylePriority.UseFont = False
        Me.totaldipus.Text = "totaldipus"
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 59.375!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportHeader
        '
        'NombrePartido
        '
        Me.NombrePartido.Description = "Partido Politico"
        Me.NombrePartido.Name = "NombrePartido"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ndepartamento, Me.XrLabel27, Me.nivelelectivo, Me.XrLabel24, Me.movimientopolitico, Me.XrLabel10, Me.partidopolitico, Me.XrLabel8})
        Me.GroupHeader1.HeightF = 153.125!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'ndepartamento
        '
        Me.ndepartamento.LocationFloat = New DevExpress.Utils.PointFloat(253.75!, 79.00003!)
        Me.ndepartamento.Name = "ndepartamento"
        Me.ndepartamento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ndepartamento.SizeF = New System.Drawing.SizeF(442.7083!, 23.0!)
        Me.ndepartamento.Text = "ndepartamento"
        '
        'XrLabel27
        '
        Me.XrLabel27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 79.00003!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(243.75!, 23.00002!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.Text = "Departamento:"
        '
        'nivelelectivo
        '
        Me.nivelelectivo.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.nivelelectivo.LocationFloat = New DevExpress.Utils.PointFloat(253.75!, 56.00004!)
        Me.nivelelectivo.Name = "nivelelectivo"
        Me.nivelelectivo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.nivelelectivo.SizeF = New System.Drawing.SizeF(590.6246!, 22.99999!)
        Me.nivelelectivo.StylePriority.UseFont = False
        Me.nivelelectivo.Text = "nivelelectivo"
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 56.00001!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(243.75!, 23.00002!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.Text = "Nivel Electivo:"
        '
        'movimientopolitico
        '
        Me.movimientopolitico.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.movimientopolitico.LocationFloat = New DevExpress.Utils.PointFloat(253.75!, 33.00002!)
        Me.movimientopolitico.Name = "movimientopolitico"
        Me.movimientopolitico.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.movimientopolitico.SizeF = New System.Drawing.SizeF(590.6247!, 22.99999!)
        Me.movimientopolitico.StylePriority.UseFont = False
        Me.movimientopolitico.Text = "movimientopolitico"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 32.99999!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(243.75!, 23.00002!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "Nombre de Movimiento Politico:"
        '
        'partidopolitico
        '
        Me.partidopolitico.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.partidopolitico.LocationFloat = New DevExpress.Utils.PointFloat(253.75!, 10.00001!)
        Me.partidopolitico.Name = "partidopolitico"
        Me.partidopolitico.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.partidopolitico.SizeF = New System.Drawing.SizeF(590.6249!, 22.99998!)
        Me.partidopolitico.StylePriority.UseFont = False
        Me.partidopolitico.Text = "partidopolitico"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(243.75!, 22.99998!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Nombre de Partido Politico:"
        '
        'NombreMovimiento
        '
        Me.NombreMovimiento.Description = "Nombre Movimiento"
        Me.NombreMovimiento.Name = "NombreMovimiento"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel23, Me.XrLabel21, Me.XrLabel19, Me.XrLabel17, Me.XrLabel16})
        Me.GroupHeader2.HeightF = 36.45835!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'XrLabel23
        '
        Me.XrLabel23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(911.4583!, 9.999974!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Imagen"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel21
        '
        Me.XrLabel21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(618.75!, 9.999974!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(195.8333!, 23.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "Cargo Nivel Electivo"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(369.375!, 9.999974!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Apellidos"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(170.4167!, 9.999974!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Nombres"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 6.541634!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(113.5417!, 26.45836!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.Text = "Identidad"
        '
        'DS_PLANILLA_TOTALES1
        '
        Me.DS_PLANILLA_TOTALES1.DataSetName = "DS_PLANILLA_TOTALES"
        Me.DS_PLANILLA_TOTALES1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IM_CANDIDATOSTableAdapter
        '
        Me.IM_CANDIDATOSTableAdapter.ClearBeforeFill = True
        '
        'nivel
        '
        Me.nivel.Description = "Nivel Electivo"
        Me.nivel.Name = "nivel"
        '
        'NombreDep
        '
        Me.NombreDep.Description = "Departamento"
        Me.NombreDep.Name = "NombreDep"
        '
        'REPORTE_PLANILLAS_FINALES
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.GroupHeader1, Me.GroupHeader2})
        Me.DataAdapter = Me.IM_CANDIDATOSTableAdapter
        Me.DataMember = "IM_CANDIDATOS"
        Me.DataSource = Me.DS_PLANILLA_TOTALES1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(15, 24, 15, 100)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.NombrePartido, Me.NombreMovimiento, Me.nivel, Me.NombreDep})
        Me.Version = "11.2"
        CType(Me.DS_PLANILLA_TOTALES1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents total As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NombrePartido As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents totalpp As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents totalpre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents totalde As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents totalsp As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents movimientopolitico As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents partidopolitico As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NombreMovimiento As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents total_presidencial As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents total_general As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents total_designado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents totalpars As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents totalparp As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents id As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DS_PLANILLA_TOTALES1 As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALES
    Friend WithEvents IM_CANDIDATOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_CANDIDATOSTableAdapter
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents nivelelectivo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents nivel As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents totaldipus As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents totaldipup As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NombreDep As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ndepartamento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    '   Friend WithEvents IM_CANDIDATOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_CANDIDATOSTableAdapter
End Class
