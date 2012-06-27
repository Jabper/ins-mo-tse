Imports System.Data.OracleClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class XfrmConFirmas

    Private Sub XfrmConFirmas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DSConsultas.ImagenesCiudadanosRespaldan' table. You can move, or remove it, as needed.
        'Me.ImagenesCiudadanosRespaldanTableAdapter.Fill(Me.DSConsultas.ImagenesCiudadanosRespaldan)
        'TODO: This line of code loads data into the 'DSConsultas.Movimientos' table. You can move, or remove it, as needed.
        Me.MovimientosTableAdapter.Fill(Me.DSConsultas.Movimientos)
        'TODO: This line of code loads data into the 'DSConsultas.Partidos' table. You can move, or remove it, as needed.
        Me.PartidosTableAdapter.Fill(Me.DSConsultas.Partidos)
        'TODO: This line of code loads data into the 'DSConsultas.Municipios' table. You can move, or remove it, as needed.
        Me.MunicipiosTableAdapter.Fill(Me.DSConsultas.Municipios)
        'TODO: This line of code loads data into the 'DSConsultas.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.Fill(Me.DSConsultas.Departamentos)
        Dim fTodos1 As Integer = Me.cbxDepartamento.FindStringExact("TODOS")
        If fTodos1 > 0 Then Me.cbxDepartamento.SelectedIndex = fTodos1
        Dim fTodos2 As Integer = Me.cbxPartido.FindStringExact("TODOS")
        If fTodos2 > 0 Then Me.cbxPartido.SelectedIndex = fTodos2

        fillGrid()
    End Sub

    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        fillGrid()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub fillGrid()
        Try

            Dim Ds As New DataSet()
            Dim Oraclecon As New OracleConnection(Configuracion.verconfig)
            Oraclecon.Open()

            Dim myCMD As New OracleCommand() With {.Connection = Oraclecon, .CommandText = "im_k_consultas.im_p_buscar_crespaldan", .CommandType = CommandType.StoredProcedure}

            myCMD.Parameters.Add(New OracleParameter("pvi_partido", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
                If(Me.cbxPartido.SelectedValue IsNot Nothing, Me.cbxPartido.SelectedValue.ToString, "0")
            myCMD.Parameters.Add(New OracleParameter("pvi_movimiento", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
                If(Me.cbxMovimiento.SelectedValue IsNot Nothing, Me.cbxMovimiento.SelectedValue.ToString, "0")
            myCMD.Parameters.Add(New OracleParameter("pvi_departamento", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
                If(Me.cbxDepartamento.SelectedValue IsNot Nothing, Me.cbxDepartamento.SelectedValue.ToString, "0")
            myCMD.Parameters.Add(New OracleParameter("pvi_municipio", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
                If(Me.cbxMunicipio.SelectedValue IsNot Nothing, Me.cbxMunicipio.SelectedValue.ToString, "0")

            myCMD.Parameters.Add(New OracleParameter("pvi_nidentidad", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtIdentidad.Text
            myCMD.Parameters.Add(New OracleParameter("pvi_pnombre", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtPNombre.Text
            myCMD.Parameters.Add(New OracleParameter("pvi_snombre", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtSNombre.Text
            myCMD.Parameters.Add(New OracleParameter("pvi_papellido", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtPApellido.Text
            myCMD.Parameters.Add(New OracleParameter("pvi_sapellido", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtSApellido.Text
            myCMD.Parameters.Add(New OracleParameter("pvi_folio", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtFolio.Text
            myCMD.Parameters.Add(New OracleParameter("pvi_pagina", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtPagina.Text

            myCMD.Parameters.Add(New OracleParameter("pvi_firma", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
                If(Me.chkFirma.CheckState = CheckState.Checked, "S", If(Me.chkFirma.CheckState = CheckState.Indeterminate, "-", "N"))
            myCMD.Parameters.Add(New OracleParameter("pvi_huella", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
                If(Me.chkHuella.CheckState = CheckState.Checked, "S", If(Me.chkHuella.CheckState = CheckState.Indeterminate, "-", "N"))
            myCMD.Parameters.Add(New OracleParameter("pvi_direccion", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
                If(Me.chkDireccion.CheckState = CheckState.Checked, "S", If(Me.chkDireccion.CheckState = CheckState.Indeterminate, "-", "N"))
            myCMD.Parameters.Add(New OracleParameter("pvi_igual", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
                If(Me.chkIgual.CheckState = CheckState.Checked, "S", If(Me.chkIgual.CheckState = CheckState.Indeterminate, "-", "N"))

            myCMD.Parameters.Add(New OracleParameter("pro_resultado", OracleType.Cursor)).Direction = ParameterDirection.Output

            Dim MyDA As New OracleDataAdapter(myCMD)

            MyDA.Fill(Ds)

            Me.GCBusqueda.DataSource = Ds.Tables(0)
            Oraclecon.Close()
        Catch Myex As Exception
            MessageBox.Show(Myex.Message.ToString)
        End Try
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim rw As DataRowView = GridView1.GetRow(e.FocusedRowHandle)
        If rw IsNot Nothing Then
            Me.ImagenesFirmaTableAdapter.FillBy(Me.DSConsultas.ImagenesFirma, rw.Row.Item(1), rw.Row.Item(2), rw.Row.Item(13))
        End If
    End Sub

    Private Sub txtFolio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolio.KeyPress
        VControles.solonumeros(e)
    End Sub

    Private Sub txtPagina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPagina.KeyPress
        VControles.solonumeros(e)
    End Sub
End Class