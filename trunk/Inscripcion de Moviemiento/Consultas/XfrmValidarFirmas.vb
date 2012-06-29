Public Class XfrmValidarFirmas

    Private _folio As Integer
    Private _pagina As Integer
    Private _maquina As String

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

    End Sub

    Private Sub XfrmValidarFirmas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSConsultas.IM_V_VALIDAR_FIRMAS' table. You can move, or remove it, as needed.
        'Me.IM_V_VALIDAR_FIRMASTableAdapter.Fill(Me.DSConsultas.IM_V_VALIDAR_FIRMAS)
        'TODO: This line of code loads data into the 'DSConsultas.Municipios' table. You can move, or remove it, as needed.
        Me.MunicipiosTableAdapter.Fill(Me.DSConsultas.Municipios)
        'TODO: This line of code loads data into the 'DSConsultas.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.Fill(Me.DSConsultas.Departamentos)
        'TODO: This line of code loads data into the 'DSConsultas.Movimientos' table. You can move, or remove it, as needed.
        Me.MovimientosTableAdapter.Fill(Me.DSConsultas.Movimientos)
        'TODO: This line of code loads data into the 'DSConsultas.Partidos' table. You can move, or remove it, as needed.
        Me.PartidosTableAdapter.Fill(Me.DSConsultas.Partidos)
        _folio = 0
        _pagina = 0
        _maquina = 0
    End Sub

    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        Me.IM_V_VALIDAR_FIRMASTableAdapter.FillBy(Me.DSConsultas.IM_V_VALIDAR_FIRMAS, Me.cbxPartido.SelectedValue.ToString, Me.cbxMovimiento.SelectedValue.ToString, _
                                                  Me.cbxDepartamento.SelectedValue.ToString, Me.cbxMunicipio.SelectedValue.ToString)
        Me.ImagenesFirmaTableAdapter.FillByMaquina(Me.DSConsultas.ImagenesFirma, Me.cbxPartido.SelectedValue.ToString, Me.cbxMovimiento.SelectedValue.ToString, _folio, _pagina, _maquina)
    End Sub

    Private Sub btnFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnFiltro.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub txtPagina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPagina.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub pbxFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxFirma.Click

    End Sub
End Class