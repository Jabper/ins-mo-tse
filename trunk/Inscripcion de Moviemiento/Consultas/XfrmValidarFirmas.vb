Public Class XfrmValidarFirmas 

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Me.Close()
    End Sub

    Private Sub XfrmValidarFirmas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSConsultas.Municipios' table. You can move, or remove it, as needed.
        Me.MunicipiosTableAdapter.Fill(Me.DSConsultas.Municipios)
        'TODO: This line of code loads data into the 'DSConsultas.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.Fill(Me.DSConsultas.Departamentos)
        'TODO: This line of code loads data into the 'DSConsultas.Movimientos' table. You can move, or remove it, as needed.
        Me.MovimientosTableAdapter.Fill(Me.DSConsultas.Movimientos)
        'TODO: This line of code loads data into the 'DSConsultas.Partidos' table. You can move, or remove it, as needed.
        Me.PartidosTableAdapter.Fill(Me.DSConsultas.Partidos)

    End Sub
End Class