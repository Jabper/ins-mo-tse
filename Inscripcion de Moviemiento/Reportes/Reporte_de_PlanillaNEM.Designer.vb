<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Reporte_de_PlanillaNEM
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
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.IM_V_PLANILLAS_X_NIVELAdapter1 = New Inscripcion_de_Moviemientos.DS_REPORTE_DE_PNEMTableAdapters.IM_V_PLANILLAS_X_NIVELAdapter
        Me.DS_REPORTE_DE_PNEM1 = New Inscripcion_de_Moviemientos.DS_REPORTE_DE_PNEM
        Me.GroupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.NombrePartido = New DevExpress.XtraReports.Parameters.Parameter
        Me.NombreMovimiento = New DevExpress.XtraReports.Parameters.Parameter
        Me.NivelElectivo = New DevExpress.XtraReports.Parameters.Parameter
        CType(Me.DS_REPORTE_DE_PNEM1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel13, Me.XrLabel14, Me.XrLabel15, Me.XrLabel16, Me.XrLabel17, Me.XrLabel18})
        Me.Detail.HeightF = 46.95829!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PLANILLAS_X_NIVEL.CODIGO CANDIDATO", "{0}")})
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 0.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(145.3062!, 15.0!)
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PLANILLAS_X_NIVEL.IDENTIDAD")})
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(172.1395!, 0.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(80.83258!, 15.0!)
        Me.XrLabel14.Text = "XrLabel14"
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PLANILLAS_X_NIVEL.NOMBRE CANDIDATO")})
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(284.2787!, 0.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(150.1176!, 15.0!)
        Me.XrLabel15.Text = "XrLabel15"
        '
        'XrLabel16
        '
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PLANILLAS_X_NIVEL.APELLIDO")})
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(434.3963!, 0.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(195.8267!, 14.99999!)
        Me.XrLabel16.Text = "XrLabel16"
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PLANILLAS_X_NIVEL.CARGO ELECTIVO")})
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(637.6595!, 0.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(293.7616!, 14.99999!)
        Me.XrLabel17.Text = "XrLabel17"
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PLANILLAS_X_NIVEL.ESTADO")})
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(931.4211!, 0.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(107.5789!, 15.0!)
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "XrLabel18"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'IM_V_PLANILLAS_X_NIVELAdapter1
        '
        Me.IM_V_PLANILLAS_X_NIVELAdapter1.ClearBeforeFill = True
        '
        'DS_REPORTE_DE_PNEM1
        '
        Me.DS_REPORTE_DE_PNEM1.DataSetName = "DS_REPORTE_DE_PNEM"
        Me.DS_REPORTE_DE_PNEM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupHeaderBand1
        '
        Me.GroupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLabel1, Me.XrLabel2, Me.XrLabel3})
        Me.GroupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("NOMBRE PARTIDO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("NOMBRE MOVIMIENTO ", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("NIVEL ELECTIVO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderBand1.HeightF = 109.9583!
        Me.GroupHeaderBand1.Level = 1
        Me.GroupHeaderBand1.Name = "GroupHeaderBand1"
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PLANILLAS_X_NIVEL.NOMBRE PARTIDO")})
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(215.9897!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(412.2195!, 18.29166!)
        Me.XrLabel4.StyleName = "DataField"
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PLANILLAS_X_NIVEL.NOMBRE MOVIMIENTO ")})
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(215.9897!, 36.45833!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(412.2195!, 18.29166!)
        Me.XrLabel5.StyleName = "DataField"
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IM_V_PLANILLAS_X_NIVEL.NIVEL ELECTIVO")})
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(215.9897!, 70.83334!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(412.2195!, 17.24999!)
        Me.XrLabel6.StyleName = "DataField"
        Me.XrLabel6.Text = "XrLabel6"
        '
        'XrLabel1
        '
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(4.37986!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(146.9263!, 18.29166!)
        Me.XrLabel1.StyleName = "FieldCaption"
        Me.XrLabel1.Text = "NOMBRE PARTIDO:"
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(4.37986!, 36.45833!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(195.4737!, 18.29166!)
        Me.XrLabel2.StyleName = "FieldCaption"
        Me.XrLabel2.Text = "NOMBRE MOVIMIENTO :"
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(8.379872!, 70.83334!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(191.4737!, 17.25!)
        Me.XrLabel3.StyleName = "FieldCaption"
        Me.XrLabel3.Text = "NIVEL ELECTIVO:"
        '
        'GroupHeaderBand2
        '
        Me.GroupHeaderBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11, Me.XrLabel12, Me.XrLine1, Me.XrLine2})
        Me.GroupHeaderBand2.HeightF = 40.54168!
        Me.GroupHeaderBand2.Name = "GroupHeaderBand2"
        Me.GroupHeaderBand2.StyleName = "FieldCaption"
        '
        'XrLabel7
        '
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(6.000002!, 7.000001!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(159.7229!, 18.0!)
        Me.XrLabel7.Text = "CODIGO CANDIDATO"
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(172.1395!, 7.000001!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(92.29088!, 18.0!)
        Me.XrLabel8.Text = "IDENTIDAD"
        '
        'XrLabel9
        '
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(264.4304!, 7.000001!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(169.9659!, 18.0!)
        Me.XrLabel9.Text = "NOMBRE CANDIDATO"
        '
        'XrLabel10
        '
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(434.3963!, 7.000001!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(98.05487!, 18.0!)
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "APELLIDO"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(637.6595!, 7.000001!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(177.9849!, 18.0!)
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "CARGO ELECTIVO"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(942.8795!, 7.000001!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(96.12048!, 18.0!)
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "ESTADO"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 5.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1030.0!, 2.0!)
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 25.0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1030.0!, 2.0!)
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2})
        Me.PageFooterBand1.HeightF = 76.91663!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(4.37986!, 43.91664!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.XrPageInfo1.StyleName = "PageInfo"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "Page {0} of {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(725.9999!, 43.91664!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.XrPageInfo2.StyleName = "PageInfo"
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19})
        Me.ReportHeaderBand1.HeightF = 106.375!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(6.000002!, 6.00001!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(1033.0!, 40.45833!)
        Me.XrLabel19.StyleName = "Title"
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Reporte De Planilla Por Nivel Electivo y Movimiento"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.BorderColor = System.Drawing.SystemColors.ControlText
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 24.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.White
        Me.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1
        Me.FieldCaption.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.White
        Me.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.White
        Me.DataField.BorderColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.DataField.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 43.75!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'NombrePartido
        '
        Me.NombrePartido.Description = "Nombre de Partido Politico"
        Me.NombrePartido.Name = "NombrePartido"
        '
        'NombreMovimiento
        '
        Me.NombreMovimiento.Description = "Nombre de Movimiento"
        Me.NombreMovimiento.Name = "NombreMovimiento"
        '
        'NivelElectivo
        '
        Me.NivelElectivo.Description = "Nivel Electivo"
        Me.NivelElectivo.Name = "NivelElectivo"
        '
        'Reporte_de_PlanillaNEM
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.GroupHeaderBand1, Me.GroupHeaderBand2, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataAdapter = Me.IM_V_PLANILLAS_X_NIVELAdapter1
        Me.DataMember = "IM_V_PLANILLAS_X_NIVEL"
        Me.DataSource = Me.DS_REPORTE_DE_PNEM1
        Me.FilterString = "[NOMBRE PARTIDO] = ?NombrePartido Or [NOMBRE MOVIMIENTO ] = ?NombreMovimiento Or " & _
            "[NIVEL ELECTIVO] = ?NivelElectivo"
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(25, 26, 44, 100)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.NombrePartido, Me.NombreMovimiento, Me.NivelElectivo})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "11.2"
        CType(Me.DS_REPORTE_DE_PNEM1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents IM_V_PLANILLAS_X_NIVELAdapter1 As Inscripcion_de_Moviemientos.DS_REPORTE_DE_PNEMTableAdapters.IM_V_PLANILLAS_X_NIVELAdapter
    Friend WithEvents DS_REPORTE_DE_PNEM1 As Inscripcion_de_Moviemientos.DS_REPORTE_DE_PNEM
    Friend WithEvents GroupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents NombrePartido As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents NombreMovimiento As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents NivelElectivo As DevExpress.XtraReports.Parameters.Parameter
End Class
