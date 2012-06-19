Imports Oracle.DataAccess.Client
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.InternalItems

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

    Private Sub XFrmMenuPrincipal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim S As String

        S = UCase(e.KeyChar)

        S = ChrW(Asc(S))

        e.KeyChar = S
    End Sub
    Private Sub XFrmMenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        'XfrmLogin.ShowDialog(Me)
        'Me.Hide()
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
            If TypeOf item Is BarButtonItem Then
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
        Padre(XfrmPartidosPoliticos)
    End Sub

    Private Sub BtnMovimeintos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnMovimeintos.ItemClick
        Padre(XfrmMovimientos)
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
        Padre(xfrmInscripcionCandidato)
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
        verificar_permisos()
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
End Class