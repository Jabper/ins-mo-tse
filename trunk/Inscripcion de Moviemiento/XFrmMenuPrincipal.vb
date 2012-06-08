Imports Oracle.DataAccess.Client


Public Class XFrmMenuPrincipal
    Public Sub conexion()
        Dim oradb As String = "Data Source=OraDb;User Id=scott;Password=tiger;"
        Dim conn As New OracleConnection()
        conn.ConnectionString = oradb
        conn.Open()
    End Sub
    Private Sub XFrmMenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call conexion()

        'For i = 0 To Me.RibbonControl.Pages.Count - 1
        '    'Previo un for buscando nombre del contro
        '    If Me.RibbonControl.Pages(i).Text = "Seguridad" Then
        '        Me.RibbonControl.Pages(i).Visible = False
        '        MsgBox(Me.RibbonControl.Pages(0).Groups.Count)
        '    End If
        'Next

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

    Private Sub BtnIncompatibilidades_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnIncompatibilidades.ItemClick

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
        Padre(XfrmCandidato)
    End Sub
End Class