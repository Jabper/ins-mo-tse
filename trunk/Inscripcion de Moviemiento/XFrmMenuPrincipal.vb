Imports Oracle.DataAccess.Client
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.InternalItems
Imports System.IO
Imports DevExpress.XtraEditors

Public Class XFrmMenuPrincipal
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.KeyPreview = True

    End Sub

    Public Sub conexion()
        Dim oradb As String = "Data Source=OraDb;User Id=scott;Password=tiger;"
        Dim conn As New OracleConnection()
        conn.ConnectionString = oradb
        conn.Open()
    End Sub

    Private Sub XFrmMenuPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (XtraMessageBox.Show("¿Desea salir del sistema?", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then

            End

        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub XFrmMenuPrincipal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim S As String

        S = UCase(e.KeyChar)

        S = ChrW(Asc(S))

        e.KeyChar = S
    End Sub
    Private Sub XFrmMenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'verificaringreso()
        verificar_permisos()
        Me.BtnCerrarSesion.Visibility = BarItemVisibility.Always
        Me.BtnSalir.Visibility = BarItemVisibility.Always
        'Call conexion()

        'For i = 0 To Me.RibbonControl.Pages.Count - 1
        '    'Previo un for buscando nombre del contro
        '    If Me.RibbonControl.Pages(i).Text = "Seguridad" Then

        '        Me.RibbonControl.Pages(i).Visible = False
        '        MsgBox(Me.RibbonControl.Pages(0).Groups.Count)
        '    End If
        'Next


        'For Each item As BarItem In Me.RibbonControl.Items
        '    If TypeOf item Is BarBaseButtonItem Then

        '        MsgBox(item.Name)
        '    End If
        'Next

        XfrmBack.MdiParent = Me
        XfrmBack.Show()


    End Sub
   

    Sub verificaringreso()
        If File.Exists(Application.StartupPath.ToString & "\Cnf.ini") Then
            Me.Visible = False
            XfrmLogin.ShowDialog(Me)

        Else
            Me.Visible = False
            XfrmConfigurar.ShowDialog(Me)
        End If
    End Sub

    Private Sub verificar_permisos()
        For i = 0 To Me.RibbonControl.Pages.Count - 1
            'deshabilita las pestañas
            Dim insertar As String = COracle.credenciales(Me.Ribbon.Pages(i).Name.ToString, "INSERTAR")
            If insertar = "E" Then
                Me.Ribbon.Pages(i).Visible = False
            Else
                Me.Ribbon.Pages(i).Visible = True
            End If
        Next
        For Each item As BarItem In Me.RibbonControl.Items
            If TypeOf item Is BarButtonItem Or TypeOf item Is BarSubItem Then
                Dim insertar As String = COracle.credenciales(item.Name.ToString, "INSERTAR")
                If insertar = "E" Then
                    item.Visibility = BarItemVisibility.Never
                Else
                    item.Visibility = BarItemVisibility.Always
                End If
            End If
        Next
    End Sub

    Sub Padre(ByVal formulario As DevExpress.XtraEditors.XtraForm) 'HACE HIJOS A LOS FORMULARIOS PARA MOSTRARLOS DENTRO DEL MDI
        If VControles.ComprobarFormAbierto(formulario) Then
            formulario.Focus()
        Else
            formulario.MdiParent = Me
            formulario.Show()
        End If



    End Sub

    Private Sub BtnDepartamento_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDepartamento.ItemClick
        Padre(XfrmDepartamentos)
    End Sub



    Private Sub BtnMunicipio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnMunicipio.ItemClick
        Padre(Municipios)
    End Sub

    Private Sub BtnParametros_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnParametros.ItemClick
        Padre(XfrmParametros)
    End Sub

    Private Sub BtnCargos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCargos.ItemClick
        Padre(XfrmCargoElectivo)
    End Sub

    Private Sub BtnNivelesElectivos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnNivelesElectivos.ItemClick
        Padre(XfrmNivelElectivo)
    End Sub

    Private Sub BtnPartidos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPartidos.ItemClick
        Padre(XfrmPartidos)
    End Sub

    Private Sub BtnMovimeintos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnMovimeintos.ItemClick
        Try
            Padre(XfrmMovimientos)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnUsuarios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnUsuarios.ItemClick
        Padre(XfrmUsuarios)
    End Sub

    Private Sub BtnRoles_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRoles.ItemClick
        Padre(XfrmRoles)
    End Sub

    Private Sub BtnOpciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOpciones.ItemClick
        Padre(fmOpcion)
    End Sub

    Private Sub BtnRequisitos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRequisitos.ItemClick
        Padre(XfrmRequisitos)
    End Sub

    Private Sub BtnCandidatos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCandidatos.ItemClick
        Dim Candidatos As Object = New xfrmSeleccionarPartidoMovimiento
        Candidatos.ShowDialog(Me)
    End Sub

    Private Sub BtnOperaciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOperaciones.ItemClick
        Padre(XfrmOperacionesPorRol)
    End Sub


    Private Sub BtnOperacionesUsuarios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnOperacionesUsuarios.ItemClick
        Padre(XfrmOperacionesPorUsuario)
    End Sub

    Private Sub BtnExportar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnExportar.ItemClick
        Padre(XfrmExportar)
    End Sub

    Private Sub BtnIncompatibilidades_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnInhabilitado.ItemClick
        Padre(xfrmCiudadanosInha)
    End Sub

    Private Sub BtnHacerRespaldo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnHacerRespaldo.ItemClick
        Padre(XfrmCrearRespaldo)
    End Sub

    Private Sub BtnFirmas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnFirmas.ItemClick
        Dim filas As Object = New XfrmFilas
        filas.ShowDialog(Me)
    End Sub

    Private Sub BtnImportar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnImportar.ItemClick
        Padre(XfrmImportar)
    End Sub

    Private Sub BtnSubirRespaldo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSubirRespaldo.ItemClick
        Padre(XfrmSubirRespaldo)
    End Sub

    Private Sub BtnCerrarSesion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCerrarSesion.ItemClick
        ' verificar_permisos()
        If XtraMessageBox.Show("Desea Cerrar la Sesión Actual", "Confirmar Acción", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            Me.Visible = False
            Dim xfrm As XfrmLogin = New XfrmLogin
            xfrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub RibbonControl_ApplicationButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RibbonControl.ApplicationButtonClick

    End Sub


    Private Sub RibbonControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl.Click

    End Sub

    Private Sub BtnMotivo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnMotivo.ItemClick
        Try
            Padre(Xfrmmotivos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnModificarFirmas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnModificarFirmas.ItemClick
        Padre(XfrmConsultaFirmas)
    End Sub

    Private Sub btnCInhabilitados_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCInhabilitados.ItemClick
        Padre(XfrmConCiudadanosInha)
    End Sub

    Private Sub btnConsultarCenso_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultarCenso.ItemClick
        Padre(XfrmConCenso)
    End Sub

    Private Sub BtnSubirOtroSistema_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSubirOtroSistema.ItemClick
        Padre(XfrmSubirSistExterno)
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPlanillanivel.ItemClick
        Dim reporte As Reporte_de_PlanillaNEM = New Reporte_de_PlanillaNEM
        reporte.ShowPreview()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPlanilladivision.ItemClick
        Dim reporte2 As Reporte_de_PlanillaDP = New Reporte_de_PlanillaDP
        reporte2.ShowPreview()
    End Sub

    Private Sub btnConsultarFirmas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultarFirmas.ItemClick
        Padre(XfrmConFirmas)
    End Sub

    Private Sub BtnFDP_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnFDP.ItemClick
        Dim reporte3 As Reporte_de__FirmasDP = New Reporte_de__FirmasDP
        reporte3.ShowPreview()
    End Sub

    Private Sub btnConsultarCandidatos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultarCandidatos.ItemClick
        Padre(XfrmConCandidatos)
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnFirmasinc.ItemClick
        Dim reporte4 As Reporte_de_Firmas_In = New Reporte_de_Firmas_In
        reporte4.ShowPreview()
    End Sub

    Private Sub btnJerarquico_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnJerarquico.ItemClick
        Padre(XfrmJerarquico)
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCrucemov.ItemClick
        Dim reporte5 As Reporte_de_cruce_FMOV = New Reporte_de_cruce_FMOV
        reporte5.ShowPreview()
    End Sub

    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCrucepar.ItemClick
        Dim reporte6 As Reporte_de_cruce_FPA = New Reporte_de_cruce_FPA
        reporte6.ShowPreview()
    End Sub

    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnResumenFir.ItemClick
        Dim reporte7 As Reporte_de_Resumen_Firmas_DP = New Reporte_de_Resumen_Firmas_DP
        reporte7.ShowPreview()
    End Sub

    Private Sub BtnSalir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSalir.ItemClick
        If (XtraMessageBox.Show("¿Desea salir del sistema?", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then

            End

        End If
    End Sub

    Private Sub btnConsultarPlanilla_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultarPlanilla.ItemClick
        Padre(XfrmConPlanilla)
    End Sub

    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEstadisticoFI.ItemClick
        Dim reporte8 As Reporte_Estadistico_general_firmas = New Reporte_Estadistico_general_firmas
        reporte8.ShowPreview()
    End Sub

    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btnlogproce.ItemClick
        Dim reporte9 As REPORTE_DE_LOG = New REPORTE_DE_LOG
        reporte9.ShowPreview()

    End Sub

    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPlanillacandidatos.ItemClick
        Dim reporte10 As REPORTE_DE__PLANILLA_DE_CANDIDATOS = New REPORTE_DE__PLANILLA_DE_CANDIDATOS
        reporte10.ShowPreview()
    End Sub

    Private Sub BtnDiscoPartido_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDiscoPartido.ItemClick
        Padre(XfrmDiscoPartido)
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEstadisticopar.ItemClick
        Dim reporte11 As Reporte_estadistico_general_ge = New Reporte_estadistico_general_ge
        reporte11.ShowPreview()
    End Sub

    Private Sub BtnDiscoMovimiento_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDiscoMovimiento.ItemClick
        Padre(XfrmDiscoMovimiento)
    End Sub
End Class