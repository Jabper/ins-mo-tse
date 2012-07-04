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
        Me.components = New System.ComponentModel.Container
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.id = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_LOG = New Inscripcion_de_Moviemientos.DS_LOG
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.NombrePartido = New DevExpress.XtraReports.Parameters.Parameter
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.nivelelectivo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.movimientopolitico = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.partidopolitico = New DevExpress.XtraReports.UI.XRLabel
        Me.ndepartamento = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel
        Me.NombreMovimiento = New DevExpress.XtraReports.Parameters.Parameter
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.DS_PLANILLA_TOTALES1 = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALES
        Me.IM_CANDIDATOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_CANDIDATOSTableAdapter
        Me.nivel = New DevExpress.XtraReports.Parameters.Parameter
        Me.NombreDep = New DevExpress.XtraReports.Parameters.Parameter
        Me.NombreMunicipio = New DevExpress.XtraReports.Parameters.Parameter
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_MUNICIPIOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MUNICIPIOSTableAdapter
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter = New Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_PARTIDOS_POLITICOS_imagenTableAdapter
        Me.IM_MOVIMIENTOS_imagenTableAdapter = New Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_MOVIMIENTOS_imagenTableAdapter
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_LOG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PLANILLA_TOTALES1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrPictureBox3, Me.XrPictureBox2, Me.XrLabel1})
        Me.ReportHeader.HeightF = 143.75!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 4
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 102.0833!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1041.0!, 23.0!)
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.BindingSource2, "IMAGEN")})
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(13.12504!, 9.998305!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(120.4167!, 81.0417!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "IM_PARTIDOS_POLITICOS_imagen"
        Me.BindingSource2.DataSource = Me.DS_LOG
        '
        'DS_LOG
        '
        Me.DS_LOG.DataSetName = "DS_LOG"
        Me.DS_LOG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.BindingSource3, "IMAGEN")})
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(930.58!, 10.00001!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(120.42!, 81.04!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "IM_MOVIMIENTOS_imagen"
        Me.BindingSource3.DataSource = Me.DS_LOG
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
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel2})
        Me.PageHeader.HeightF = 58.33333!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportHeader
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_DEPARTAMENTOS.CANTIDAD_MUJERES")})
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(302.0833!, 10.00001!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_DEPARTAMENTOS.CANTIDAD_DIPUTADOS")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(140.625!, 10.00001!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel2.Text = "XrLabel2"
        '
        'NombrePartido
        '
        Me.NombrePartido.Description = "Partido Politico"
        Me.NombrePartido.Name = "NombrePartido"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel27, Me.nivelelectivo, Me.XrLabel24, Me.movimientopolitico, Me.XrLabel8, Me.partidopolitico, Me.ndepartamento})
        Me.GroupHeader1.HeightF = 114.5833!
        Me.GroupHeader1.Level = 2
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(13.12501!, 34.04166!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(243.75!, 23.00002!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "Nombre de Movimiento Politico:"
        '
        'XrLabel27
        '
        Me.XrLabel27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(13.12504!, 80.04169!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(243.75!, 23.00002!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.Text = "Departamento:"
        '
        'nivelelectivo
        '
        Me.nivelelectivo.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.nivelelectivo.LocationFloat = New DevExpress.Utils.PointFloat(256.875!, 57.04168!)
        Me.nivelelectivo.Name = "nivelelectivo"
        Me.nivelelectivo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.nivelelectivo.SizeF = New System.Drawing.SizeF(590.6246!, 22.99999!)
        Me.nivelelectivo.StylePriority.UseFont = False
        Me.nivelelectivo.Text = "nivelelectivo"
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(13.12501!, 57.04168!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(243.75!, 23.00002!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.Text = "Nivel Electivo:"
        '
        'movimientopolitico
        '
        Me.movimientopolitico.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.movimientopolitico.LocationFloat = New DevExpress.Utils.PointFloat(256.875!, 34.04172!)
        Me.movimientopolitico.Name = "movimientopolitico"
        Me.movimientopolitico.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.movimientopolitico.SizeF = New System.Drawing.SizeF(590.6247!, 22.99999!)
        Me.movimientopolitico.StylePriority.UseFont = False
        Me.movimientopolitico.Text = "movimientopolitico"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(13.12501!, 11.04164!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(243.75!, 22.99998!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Nombre de Partido Politico:"
        '
        'partidopolitico
        '
        Me.partidopolitico.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.partidopolitico.LocationFloat = New DevExpress.Utils.PointFloat(256.875!, 11.04164!)
        Me.partidopolitico.Name = "partidopolitico"
        Me.partidopolitico.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.partidopolitico.SizeF = New System.Drawing.SizeF(590.6249!, 22.99998!)
        Me.partidopolitico.StylePriority.UseFont = False
        Me.partidopolitico.Text = "partidopolitico"
        '
        'ndepartamento
        '
        Me.ndepartamento.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndepartamento.LocationFloat = New DevExpress.Utils.PointFloat(256.875!, 80.04169!)
        Me.ndepartamento.Name = "ndepartamento"
        Me.ndepartamento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ndepartamento.SizeF = New System.Drawing.SizeF(590.6246!, 23.00002!)
        Me.ndepartamento.StylePriority.UseFont = False
        Me.ndepartamento.Text = "ndepartamento"
        '
        'XrLabel31
        '
        Me.XrLabel31.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(13.12504!, 9.999974!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(94.79168!, 23.00002!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.Text = "Municipio:"
        '
        'XrLabel32
        '
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_CANDIDATOS.municipio")})
        Me.XrLabel32.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(140.625!, 9.999974!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(590.6246!, 23.00002!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.Text = "XrLabel32"
        '
        'NombreMovimiento
        '
        Me.NombreMovimiento.Description = "Nombre Movimiento"
        Me.NombreMovimiento.Name = "NombreMovimiento"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel23, Me.XrLabel21, Me.XrLabel19, Me.XrLabel17, Me.XrLabel16, Me.XrLine1})
        Me.GroupHeader2.HeightF = 48.70835!
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
        'XrLine1
        '
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 32.99999!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1041.0!, 15.70835!)
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
        'NombreMunicipio
        '
        Me.NombreMunicipio.Description = "Municipio"
        Me.NombreMunicipio.Name = "NombreMunicipio"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "IM_MUNICIPIOS"
        Me.BindingSource1.DataSource = Me.DS_PLANILLA_TOTALES1
        '
        'IM_MUNICIPIOSTableAdapter
        '
        Me.IM_MUNICIPIOSTableAdapter.ClearBeforeFill = True
        '
        'IM_PARTIDOS_POLITICOS_imagenTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.ClearBeforeFill = True
        '
        'IM_MOVIMIENTOS_imagenTableAdapter
        '
        Me.IM_MOVIMIENTOS_imagenTableAdapter.ClearBeforeFill = True
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel31, Me.XrLabel32})
        Me.GroupHeader3.HeightF = 55.20833!
        Me.GroupHeader3.Level = 1
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'REPORTE_PLANILLAS_FINALES
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.GroupHeader1, Me.GroupHeader2, Me.GroupHeader3})
        Me.DataAdapter = Me.IM_CANDIDATOSTableAdapter
        Me.DataMember = "IM_CANDIDATOS"
        Me.DataSource = Me.DS_PLANILLA_TOTALES1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(15, 24, 15, 100)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.NombrePartido, Me.NombreMovimiento, Me.nivel, Me.NombreDep, Me.NombreMunicipio})
        Me.Version = "11.2"
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_LOG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PLANILLA_TOTALES1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NombrePartido As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents movimientopolitico As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents partidopolitico As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NombreMovimiento As DevExpress.XtraReports.Parameters.Parameter
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
    Friend WithEvents NombreDep As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ndepartamento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents NombreMunicipio As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MUNICIPIOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_MUNICIPIOSTableAdapter
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DS_LOG As Inscripcion_de_Moviemientos.DS_LOG
    Friend WithEvents IM_PARTIDOS_POLITICOS_imagenTableAdapter As Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_PARTIDOS_POLITICOS_imagenTableAdapter
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_MOVIMIENTOS_imagenTableAdapter As Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_MOVIMIENTOS_imagenTableAdapter
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    '   Friend WithEvents IM_CANDIDATOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLA_TOTALESTableAdapters.IM_CANDIDATOSTableAdapter
End Class
