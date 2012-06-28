Public Class XfrmConCiudadanosInha 

    Private Sub XfrmConCiudadanosInha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSConsultas.Motivos' table. You can move, or remove it, as needed.
        Me.MotivosTableAdapter.Fill(Me.DSConsultas.Motivos)
        'TODO: This line of code loads data into the 'DSConsultas.IM_CIUDADANOS_INHABILITADOS' table. You can move, or remove it, as needed.
        Me.IM_CIUDADANOS_INHABILITADOSTableAdapter.Fill(Me.DSConsultas.IM_CIUDADANOS_INHABILITADOS)
    End Sub

    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        Dim filtro As String = String.Empty
        If Me.txtIdentidad.Text <> String.Empty Then filtro = filtro & String.Format("NUMERO_IDENTIFICACION LIKE '%{0}%'", Me.txtIdentidad.Text).ToString
        If Me.txtNombres.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("NOMBRES LIKE '%{0}%'", Me.txtNombres.Text).ToString
        If Me.txtPApellido.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("PRIMER_APELLIDO LIKE '%{0}%'", Me.txtPApellido.Text).ToString
        If Me.txtSApellido.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("SEGUNDO_APELLIDO LIKE '%{0}%'", Me.txtSApellido.Text).ToString
        If Me.txtDependencia.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("DEPEDENCIA_GUBERNAMENTAL LIKE '%{0}%'", Me.txtDependencia.Text).ToString
        If Me.txtCargo.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CARGO LIKE '%{0}%'", Me.txtCargo.Text).ToString
        If Me.cbxMotivo.SelectedValue > 0 Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CODIGO_MOTIVO = {0}", Me.cbxMotivo.SelectedValue).ToString
        Me.IMCIUDADANOSINHABILITADOSBindingSource.Filter = filtro
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class