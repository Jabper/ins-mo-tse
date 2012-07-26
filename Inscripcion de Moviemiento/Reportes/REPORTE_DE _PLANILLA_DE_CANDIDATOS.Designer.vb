<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class REPORTE_DE__PLANILLA_DE_CANDIDATOS
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.imagen = New DevExpress.XtraReports.UI.XRPictureBox
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.DS_REPORTE_CANDIDATOS1 = New Inscripcion_de_Moviemientos.DS_REPORTE_CANDIDATOS
        Me.IM_V_MOSTRAR_CANDIDATOS2TableAdapter = New Inscripcion_de_Moviemientos.DS_REPORTE_CANDIDATOSTableAdapters.IM_V_MOSTRAR_CANDIDATOS2TableAdapter
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_LOG = New Inscripcion_de_Moviemientos.DS_LOG
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.NombrePartido = New DevExpress.XtraReports.Parameters.Parameter
        Me.NombreNivel = New DevExpress.XtraReports.Parameters.Parameter
        Me.NombreDepartamento = New DevExpress.XtraReports.Parameters.Parameter
        Me.NombreMovimiento = New DevExpress.XtraReports.Parameters.Parameter
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter = New Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_PARTIDOS_POLITICOS_imagenTableAdapter
        Me.IM_MOVIMIENTOS_imagenTableAdapter = New Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_MOVIMIENTOS_imagenTableAdapter
        CType(Me.DS_REPORTE_CANDIDATOS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_LOG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel20, Me.XrLabel14, Me.XrLabel13, Me.XrLabel11, Me.XrLabel9, Me.imagen})
        Me.Detail.HeightF = 107.2917!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.CARGO")})
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(775.0!, 9.998322!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(276.0!, 22.99998!)
        Me.XrLabel20.Text = "XrLabel20"
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.APELLIDO")})
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(571.9166!, 9.999974!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(181.1666!, 22.99999!)
        Me.XrLabel14.Text = "XrLabel14"
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.NOMBRE")})
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(414.5832!, 9.998322!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(151.0417!, 23.0!)
        Me.XrLabel13.Text = "XrLabel13"
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.IDENTIDAD")})
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(284.3749!, 9.998322!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel11.Text = "XrLabel11"
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.POSICION")})
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(172.9166!, 9.998322!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "XrLabel9"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'imagen
        '
        Me.imagen.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.IMAGEN")})
        Me.imagen.LocationFloat = New DevExpress.Utils.PointFloat(7.29154!, 9.998322!)
        Me.imagen.Name = "imagen"
        Me.imagen.SizeF = New System.Drawing.SizeF(117.71!, 90.04!)
        Me.imagen.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 24.0!
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
        'DS_REPORTE_CANDIDATOS1
        '
        Me.DS_REPORTE_CANDIDATOS1.DataSetName = "DS_REPORTE_CANDIDATOS"
        Me.DS_REPORTE_CANDIDATOS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IM_V_MOSTRAR_CANDIDATOS2TableAdapter
        '
        Me.IM_V_MOSTRAR_CANDIDATOS2TableAdapter.ClearBeforeFill = True
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox3, Me.XrPictureBox2, Me.XrLabel1})
        Me.ReportHeader.Font = New System.Drawing.Font("Times New Roman", 20.0!)
        Me.ReportHeader.HeightF = 133.3333!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.StylePriority.UseFont = False
        Me.ReportHeader.StylePriority.UseTextAlignment = False
        Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.BindingSource2, "IMAGEN")})
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(950.9995!, 10.00001!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(105.21!, 59.46!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
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
        'XrPictureBox2
        '
        Me.XrPictureBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.BindingSource1, "IMAGEN")})
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(7.29154!, 10.00001!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(105.2083!, 59.45834!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "IM_PARTIDOS_POLITICOS_imagen"
        Me.BindingSource1.DataSource = Me.DS_LOG
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(219.375!, 10.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(686.8334!, 47.91666!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Reporte de Candidatos Habilitados "
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2})
        Me.GroupHeader1.HeightF = 167.7083!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.NOMBRE MOVIMIENTO")})
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(172.9166!, 47.87499!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(547.9166!, 22.99998!)
        Me.XrLabel19.Text = "XrLabel19"
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 47.87499!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(156.2501!, 22.99998!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "Movimiento Político:"
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.PARTIDO")})
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(172.9166!, 3.666687!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(645.8334!, 23.0!)
        Me.XrLabel17.Text = "XrLabel17"
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 3.666687!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(130.2084!, 23.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.Text = "Partido Político:"
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.DEPARTAMENTO")})
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(172.9166!, 134.7083!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(444.7917!, 23.0!)
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 134.7083!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(119.1667!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Departamento:"
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_MOSTRAR_CANDIDATOS2.NIVEL")})
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(172.9166!, 96.45834!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(547.9167!, 23.0!)
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 96.45834!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(119.1667!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Nivel Electivo:"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLabel7, Me.XrLine1, Me.XrLabel15, Me.XrLabel12, Me.XrLabel10, Me.XrLabel8, Me.XrLabel6})
        Me.GroupHeader2.HeightF = 51.04167!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'XrLine2
        '
        Me.XrLine2.BorderWidth = 4
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 44.37497!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1043.708!, 6.666691!)
        Me.XrLine2.StylePriority.UseBorderWidth = False
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(802.0413!, 9.999974!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(198.9583!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "CARGO ELECTIVO"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.BorderWidth = 4
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(7.29154!, 3.333282!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1043.708!, 6.666691!)
        Me.XrLine1.StylePriority.UseBorderWidth = False
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(571.9167!, 11.37498!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "APELLIDOS"
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(414.5832!, 9.999974!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.Text = "NOMBRES"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(284.3749!, 11.37498!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(115.625!, 23.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "IDENTIDAD"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(172.9166!, 9.999974!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "POSICION"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 9.999974!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(159.375!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "IMAGEN CANDIDATO"
        '
        'NombrePartido
        '
        Me.NombrePartido.Description = "Partido Político"
        Me.NombrePartido.Name = "NombrePartido"
        '
        'NombreNivel
        '
        Me.NombreNivel.Description = "Nivel Electivo"
        Me.NombreNivel.Name = "NombreNivel"
        '
        'NombreDepartamento
        '
        Me.NombreDepartamento.Description = "Departamento"
        Me.NombreDepartamento.Name = "NombreDepartamento"
        '
        'NombreMovimiento
        '
        Me.NombreMovimiento.Description = "Movimiento Político"
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
        'REPORTE_DE__PLANILLA_DE_CANDIDATOS
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2})
        Me.DataAdapter = Me.IM_V_MOSTRAR_CANDIDATOS2TableAdapter
        Me.DataMember = "IM_V_MOSTRAR_CANDIDATOS2"
        Me.DataSource = Me.DS_REPORTE_CANDIDATOS1
        Me.FilterString = "[PARTIDO] = ?NombrePartido And [NIVEL] = ?NombreNivel And [DEPARTAMENTO] = ?Nombr" & _
            "eDepartamento And [NOMBRE MOVIMIENTO] = ?NombreMovimiento"
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(19, 20, 24, 100)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.NombrePartido, Me.NombreNivel, Me.NombreDepartamento, Me.NombreMovimiento})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "11.2"
        CType(Me.DS_REPORTE_CANDIDATOS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_LOG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DS_REPORTE_CANDIDATOS1 As Inscripcion_de_Moviemientos.DS_REPORTE_CANDIDATOS
    Friend WithEvents IM_V_MOSTRAR_CANDIDATOS2TableAdapter As Inscripcion_de_Moviemientos.DS_REPORTE_CANDIDATOSTableAdapters.IM_V_MOSTRAR_CANDIDATOS2TableAdapter
    Friend WithEvents imagen As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents NombrePartido As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents NombreNivel As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents NombreDepartamento As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NombreMovimiento As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DS_LOG As Inscripcion_de_Moviemientos.DS_LOG
    Friend WithEvents IM_PARTIDOS_POLITICOS_imagenTableAdapter As Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_PARTIDOS_POLITICOS_imagenTableAdapter
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOVIMIENTOS_imagenTableAdapter As Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_MOVIMIENTOS_imagenTableAdapter
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
End Class
