<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class REPORTE_PLANILLA_INCOMPLETA
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
        Me.id = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.nivelelectivo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.movimientopolitico = New DevExpress.XtraReports.UI.XRLabel
        Me.partidopolitico = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.munivalor = New DevExpress.XtraReports.UI.XRLabel
        Me.muniname = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.ndepartamento = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.DS_PLANILLAS_COMPLETAS_INC1 = New Inscripcion_de_Moviemientos.DS_PLANILLAS_COMPLETAS_INC
        Me.CANDIDATOS_INCOMPLETOSTableAdapter = New Inscripcion_de_Moviemientos.DS_PLANILLAS_COMPLETAS_INCTableAdapters.CANDIDATOS_INCOMPLETOSTableAdapter
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_LOG = New Inscripcion_de_Moviemientos.DS_LOG
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter = New Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_PARTIDOS_POLITICOS_imagenTableAdapter
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IM_MOVIMIENTOS_imagenTableAdapter = New Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_MOVIMIENTOS_imagenTableAdapter
        CType(Me.DS_PLANILLAS_COMPLETAS_INC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_LOG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.id, Me.XrLabel22, Me.XrLabel18, Me.XrPictureBox1, Me.XrLabel20})
        Me.Detail.HeightF = 92.70834!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'id
        '
        Me.id.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CANDIDATOS_INCOMPLETOS.IDENTIDAD")})
        Me.id.LocationFloat = New DevExpress.Utils.PointFloat(293.5833!, 0.00003178914!)
        Me.id.Name = "id"
        Me.id.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.id.SizeF = New System.Drawing.SizeF(113.5417!, 23.00002!)
        Me.id.Text = "id"
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CANDIDATOS_INCOMPLETOS.CARGO")})
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(18.58333!, 0.0!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(261.4583!, 23.0!)
        Me.XrLabel22.Text = "XrLabel22"
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CANDIDATOS_INCOMPLETOS.NOMBRE")})
        Me.XrLabel18.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(424.2083!, 0.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(208.3333!, 23.00002!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "XrLabel18"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "CANDIDATOS_INCOMPLETOS.IMAGEN")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(920.0417!, 0.0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(139.5419!, 84.16665!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CANDIDATOS_INCOMPLETOS.APELLIDO")})
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(639.4163!, 0.0!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(260.4167!, 23.00002!)
        Me.XrLabel20.Text = "XrLabel20"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 9.0!
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox3, Me.XrPictureBox2, Me.XrLine2, Me.nivelelectivo, Me.XrLabel24, Me.movimientopolitico, Me.partidopolitico, Me.XrLabel10})
        Me.ReportHeader.HeightF = 129.125!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(18.58333!, 106.125!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1041.0!, 23.0!)
        '
        'nivelelectivo
        '
        Me.nivelelectivo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CANDIDATOS_INCOMPLETOS.NIVEL")})
        Me.nivelelectivo.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Italic)
        Me.nivelelectivo.LocationFloat = New DevExpress.Utils.PointFloat(381.062!, 71.66669!)
        Me.nivelelectivo.Name = "nivelelectivo"
        Me.nivelelectivo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.nivelelectivo.SizeF = New System.Drawing.SizeF(616.8306!, 32.74993!)
        Me.nivelelectivo.StylePriority.UseFont = False
        Me.nivelelectivo.Text = "nivelelectivo"
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(161.8954!, 71.66669!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(208.7499!, 34.45835!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.Text = "PLANILLA DE NIVEL"
        '
        'movimientopolitico
        '
        Me.movimientopolitico.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CANDIDATOS_INCOMPLETOS.NOMBRE_MOVIMIENTO")})
        Me.movimientopolitico.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Italic)
        Me.movimientopolitico.LocationFloat = New DevExpress.Utils.PointFloat(451.2705!, 38.62495!)
        Me.movimientopolitico.Name = "movimientopolitico"
        Me.movimientopolitico.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.movimientopolitico.SizeF = New System.Drawing.SizeF(427.0832!, 33.0417!)
        Me.movimientopolitico.StylePriority.UseFont = False
        Me.movimientopolitico.StylePriority.UseTextAlignment = False
        Me.movimientopolitico.Text = "movimientopolitico"
        Me.movimientopolitico.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'partidopolitico
        '
        Me.partidopolitico.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CANDIDATOS_INCOMPLETOS.PARTIDO")})
        Me.partidopolitico.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Italic)
        Me.partidopolitico.LocationFloat = New DevExpress.Utils.PointFloat(210.6456!, 0.0!)
        Me.partidopolitico.Name = "partidopolitico"
        Me.partidopolitico.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.partidopolitico.SizeF = New System.Drawing.SizeF(634.375!, 38.62498!)
        Me.partidopolitico.StylePriority.UseFont = False
        Me.partidopolitico.StylePriority.UseTextAlignment = False
        Me.partidopolitico.Text = "partidopolitico"
        Me.partidopolitico.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(254.3961!, 38.62495!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(178.1251!, 32.37502!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "MOVIMIENTO"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19, Me.XrLabel23, Me.XrLabel21, Me.XrLabel17, Me.XrLine1, Me.XrLine3, Me.XrLabel1})
        Me.GroupHeader1.HeightF = 75.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(639.4163!, 30.52079!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Apellidos"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel23
        '
        Me.XrLabel23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(935.6216!, 30.52079!)
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
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(18.58333!, 30.52079!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(195.8333!, 23.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "Cargo Nivel Electivo"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(424.2083!, 30.52079!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Nombres"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine1
        '
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(18.58333!, 56.56249!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1041.0!, 15.70835!)
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(18.58333!, 0.0!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(1041.0!, 15.70835!)
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(293.5833!, 30.52079!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Identidad"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.munivalor, Me.muniname})
        Me.GroupHeader2.HeightF = 33.33333!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'munivalor
        '
        Me.munivalor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CANDIDATOS_INCOMPLETOS.MUNICIPIO")})
        Me.munivalor.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.munivalor.LocationFloat = New DevExpress.Utils.PointFloat(148.7917!, 0.0!)
        Me.munivalor.Name = "munivalor"
        Me.munivalor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.munivalor.SizeF = New System.Drawing.SizeF(590.6246!, 23.00002!)
        Me.munivalor.StylePriority.UseFont = False
        Me.munivalor.Text = "munivalor"
        '
        'muniname
        '
        Me.muniname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.muniname.LocationFloat = New DevExpress.Utils.PointFloat(18.58333!, 0.0!)
        Me.muniname.Name = "muniname"
        Me.muniname.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.muniname.SizeF = New System.Drawing.SizeF(94.79168!, 23.00002!)
        Me.muniname.StylePriority.UseFont = False
        Me.muniname.Text = "Municipio:"
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ndepartamento, Me.XrLabel27})
        Me.GroupHeader3.HeightF = 31.25!
        Me.GroupHeader3.Level = 2
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'ndepartamento
        '
        Me.ndepartamento.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CANDIDATOS_INCOMPLETOS.DEPARTAMENTO")})
        Me.ndepartamento.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndepartamento.LocationFloat = New DevExpress.Utils.PointFloat(148.7918!, 0.0!)
        Me.ndepartamento.Name = "ndepartamento"
        Me.ndepartamento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ndepartamento.SizeF = New System.Drawing.SizeF(590.6246!, 23.00002!)
        Me.ndepartamento.StylePriority.UseFont = False
        Me.ndepartamento.Text = "ndepartamento"
        '
        'XrLabel27
        '
        Me.XrLabel27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(18.58333!, 0.0!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(123.9583!, 23.00002!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.Text = "Departamento:"
        '
        'DS_PLANILLAS_COMPLETAS_INC1
        '
        Me.DS_PLANILLAS_COMPLETAS_INC1.DataSetName = "DS_PLANILLAS_COMPLETAS_INC"
        Me.DS_PLANILLAS_COMPLETAS_INC1.EnforceConstraints = False
        Me.DS_PLANILLAS_COMPLETAS_INC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CANDIDATOS_INCOMPLETOSTableAdapter
        '
        Me.CANDIDATOS_INCOMPLETOSTableAdapter.ClearBeforeFill = True
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.BindingSource1, "IMAGEN")})
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(13.375!, 0.0!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(110.4167!, 59.45834!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.BindingSource2, "IMAGEN")})
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(959.58!, 0.0!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(110.42!, 59.46!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
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
        'IM_PARTIDOS_POLITICOS_imagenTableAdapter
        '
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.ClearBeforeFill = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "IM_MOVIMIENTOS_imagen"
        Me.BindingSource2.DataSource = Me.DS_LOG
        '
        'IM_MOVIMIENTOS_imagenTableAdapter
        '
        Me.IM_MOVIMIENTOS_imagenTableAdapter.ClearBeforeFill = True
        '
        'REPORTE_PLANILLA_INCOMPLETA
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.GroupHeader2, Me.GroupHeader3})
        Me.DataAdapter = Me.CANDIDATOS_INCOMPLETOSTableAdapter
        Me.DataMember = "CANDIDATOS_INCOMPLETOS"
        Me.DataSource = Me.DS_PLANILLAS_COMPLETAS_INC1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(5, 15, 9, 100)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "11.2"
        CType(Me.DS_PLANILLAS_COMPLETAS_INC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_LOG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents muniname As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents id As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents nivelelectivo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents movimientopolitico As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents partidopolitico As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents munivalor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ndepartamento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DS_PLANILLAS_COMPLETAS_INC1 As Inscripcion_de_Moviemientos.DS_PLANILLAS_COMPLETAS_INC
    Friend WithEvents CANDIDATOS_INCOMPLETOSTableAdapter As Inscripcion_de_Moviemientos.DS_PLANILLAS_COMPLETAS_INCTableAdapters.CANDIDATOS_INCOMPLETOSTableAdapter
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DS_LOG As Inscripcion_de_Moviemientos.DS_LOG
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IM_PARTIDOS_POLITICOS_imagenTableAdapter As Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_PARTIDOS_POLITICOS_imagenTableAdapter
    Friend WithEvents IM_MOVIMIENTOS_imagenTableAdapter As Inscripcion_de_Moviemientos.DS_LOGTableAdapters.IM_MOVIMIENTOS_imagenTableAdapter
End Class
