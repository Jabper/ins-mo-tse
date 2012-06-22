Public Class XfrmJerarquico 

    Private Sub XfrmJerarquico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSConsultas.Departamentos' table. You can move, or remove it, as needed.
        Me.DepartamentosTableAdapter.Fill(Me.DSConsultas.Departamentos)
        Me.MunicipiosTableAdapter.Fill(Me.DSConsultas.Municipios)

    End Sub
End Class