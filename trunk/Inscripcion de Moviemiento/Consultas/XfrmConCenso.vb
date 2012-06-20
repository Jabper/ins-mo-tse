Imports System.Data.OracleClient
Public Class XfrmConCenso

    Private Sub XfrmConCenso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DSConsultas.Generos' table. You can move, or remove it, as needed.
        Me.GenerosTableAdapter.Fill(Me.DSConsultas.Generos)
        Me.cbxDepartamento.SelectedIndex = 0
        Me.cbxMunicipio.SelectedIndex = 0
        Me.cbxGenero.SelectedIndex = 0
        fillGrid()
    End Sub

    Private Sub fillGrid()

        Dim Ds As New DataSet()
        Dim Oraclecon As New OracleConnection(Configuracion.verconfig)
        Oraclecon.Open()

        Dim myCMD As New OracleCommand() With {.Connection = Oraclecon, .CommandText = "im_k_consultas.im_p_buscar_censo", .CommandType = CommandType.StoredProcedure}

        myCMD.Parameters.Add(New OracleParameter("pvi_nidentidad", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtIdentidad.Text
        myCMD.Parameters.Add(New OracleParameter("pvi_pnombre", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtPNombre.Text
        myCMD.Parameters.Add(New OracleParameter("pvi_snombre", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtSNombre.Text
        myCMD.Parameters.Add(New OracleParameter("pvi_papellido", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtPApellido.Text
        myCMD.Parameters.Add(New OracleParameter("pvi_sapellido", OracleType.VarChar, 100, ParameterDirection.Input)).Value = Me.txtSApellido.Text
        myCMD.Parameters.Add(New OracleParameter("pvi_genero", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
            If(Me.cbxGenero.SelectedValue IsNot Nothing, Me.cbxGenero.SelectedValue.ToString, "0")
        myCMD.Parameters.Add(New OracleParameter("pvi_fnacimiento_desde", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
            If(Me.dtdDesde.Text <> String.Empty, Convert.ToDateTime(Me.dtdDesde.Text).ToString("yyyyMMdd"), String.Empty)
        myCMD.Parameters.Add(New OracleParameter("pvi_fnacimiento_hasta", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
            If(Me.dtdHasta.Text <> String.Empty, Convert.ToDateTime(Me.dtdHasta.Text).ToString("yyyyMMdd"), String.Empty)
        myCMD.Parameters.Add(New OracleParameter("pvi_departamento", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
            If(Me.cbxDepartamento.SelectedValue IsNot Nothing, Me.cbxDepartamento.SelectedValue.ToString, "0")
        myCMD.Parameters.Add(New OracleParameter("pvi_municipio", OracleType.VarChar, 100, ParameterDirection.Input)).Value = _
            If(Me.cbxMunicipio.SelectedValue IsNot Nothing, Me.cbxMunicipio.SelectedValue.ToString, "0")
        myCMD.Parameters.Add(New OracleParameter("pro_resultado", OracleType.Cursor)).Direction = ParameterDirection.Output

        Dim MyDA As New OracleDataAdapter(myCMD)

        Try
            MyDA.Fill(Ds)
        Catch Myex As Exception
            MessageBox.Show(Myex.Message.ToString)
        End Try
        Me.GCBusqueda.DataSource = Ds.Tables(0)
        Oraclecon.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        fillGrid()
    End Sub
End Class