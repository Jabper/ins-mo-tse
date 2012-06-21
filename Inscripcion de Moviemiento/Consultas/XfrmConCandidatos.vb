Public Class XfrmConCandidatos 

    Private Sub XfrmConCandidatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSConsultas.Cargos' table. You can move, or remove it, as needed.
        Me.CargosTableAdapter.Fill(Me.DSConsultas.Cargos)
        'TODO: This line of code loads data into the 'DSConsultas.Niveles' table. You can move, or remove it, as needed.
        Me.NivelesTableAdapter.Fill(Me.DSConsultas.Niveles)
        'TODO: This line of code loads data into the 'DSConsultas.Municipios' table. You can move, or remove it, as needed.
        Me.MunicipiosTableAdapter.Fill(Me.DSConsultas.Municipios)
        'TODO: This line of code loads data into the 'DSConsultas.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.Fill(Me.DSConsultas.Departamentos)
        'TODO: This line of code loads data into the 'DSConsultas.Movimientos' table. You can move, or remove it, as needed.
        Me.MovimientosTableAdapter.Fill(Me.DSConsultas.Movimientos)
        'TODO: This line of code loads data into the 'DSConsultas.Partidos' table. You can move, or remove it, as needed.
        Me.PartidosTableAdapter.Fill(Me.DSConsultas.Partidos)
        'TODO: This line of code loads data into the 'DSConsultas.IM_V_CANDIDATOS' table. You can move, or remove it, as needed.
        Me.IM_V_CANDIDATOSTableAdapter.Fill(Me.DSConsultas.IM_V_CANDIDATOS)

    End Sub

    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        Dim filtro As String = String.Empty
        If Me.txtIdentidad.Text <> String.Empty Then filtro = filtro & String.Format("IDENTIDAD LIKE '%{0}%'", Me.txtIdentidad.Text).ToString
        If Me.txtNombre.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("NOMBRE LIKE '%{0}%'", Me.txtNombre.Text).ToString
        If Me.txtApellido.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("APELLIDO LIKE '%{0}%'", Me.txtApellido.Text).ToString
        'If Me.txtSApellido.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("SEGUNDO_APELLIDO LIKE '%{0}%'", Me.txtSApellido.Text).ToString
        'If Me.txtDependencia.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("DEPENDENCIA_GUBERNAMENTAL LIKE '%{0}%'", Me.txtDependencia.Text).ToString
        'If Me.txtCargo.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CARGO LIKE '%{0}%'", Me.txtCargo.Text).ToString
        'If Me.cbxMotivo.SelectedValue <> 0 Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CODIGO_MOTIVO = {0}", Me.cbxMotivo.SelectedValue).ToString
        'If filtro = String.Empty Then filtro = "1=1"
        Me.IMVCANDIDATOSBindingSource.Filter = filtro
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class