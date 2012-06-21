﻿Public Class XfrmConCandidatos 

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

        Dim fTodos1 As Integer = Me.cbxDepartamento.FindStringExact("TODOS")
        If fTodos1 > 0 Then Me.cbxDepartamento.SelectedIndex = fTodos1
        Dim fTodos2 As Integer = Me.cbxPartido.FindStringExact("TODOS")
        If fTodos2 > 0 Then Me.cbxPartido.SelectedIndex = fTodos2
        Me.cbxEstado.SelectedIndex = 0
    End Sub

    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        Dim filtro As String = String.Empty
        If Me.txtIdentidad.Text <> String.Empty Then filtro = filtro & String.Format("IDENTIDAD LIKE '%{0}%'", Me.txtIdentidad.Text).ToString
        If Me.txtNombre.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("NOMBRE LIKE '%{0}%'", Me.txtNombre.Text).ToString
        If Me.txtApellido.Text <> String.Empty Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("APELLIDO LIKE '%{0}%'", Me.txtApellido.Text).ToString
        If Me.cbxPartido.SelectedText <> "TODOS" Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CODIGO_PARTIDO = {0}", Me.cbxPartido.SelectedValue).ToString
        If Me.cbxMovimiento.SelectedText <> "TODOS" Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CODIGO_MOVIMIENTO = {0}", Me.cbxMovimiento.SelectedValue).ToString
        If Me.cbxDepartamento.SelectedText <> "TODOS" Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CODIGO_DEPARTAMENTO = {0}", Me.cbxDepartamento.SelectedValue).ToString
        If Me.cbxMunicipio.SelectedText <> "TODOS" Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CODIGO_MUNICIPIO = {0}", Me.cbxMunicipio.SelectedValue).ToString
        If Me.cbxNivel.SelectedText <> "NINGUNO" Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CODIGO_NIVEL_ELECTIVO = {0}", Me.cbxNivel.SelectedValue).ToString
        If Me.cbxCargo.SelectedText <> "NINGUNO" Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("CODIGO_CARGO_ELECTIVO = {0}", Me.cbxCargo.SelectedValue).ToString
        If Me.cbxEstado.SelectedIndex <> 0 Then filtro = filtro & If(filtro <> String.Empty, " AND ", String.Empty) & String.Format("ESTADO = {0}", Me.cbxEstado.SelectedText).ToString
        'If filtro = String.Empty Then filtro = "1=1"
        Me.IMVCANDIDATOSBindingSource.Filter = filtro
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class