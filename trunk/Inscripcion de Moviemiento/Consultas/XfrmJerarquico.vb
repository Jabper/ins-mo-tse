Public Class XfrmJerarquico 

    Private Sub XfrmJerarquico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.JrPartidosPoliticosTableAdapter.Fill(Me.DSConsultas.jrPartidosPoliticos)
        Me.JrMovimientosTableAdapter.Fill(Me.DSConsultas.jrMovimientos)
        Me.JrNivelesElectivosTableAdapter.Fill(Me.DSConsultas.jrNivelesElectivos)
        Me.JrCargosElectivosTableAdapter.Fill(Me.DSConsultas.jrCargosElectivos)
        Me.JrDepartamentosTableAdapter .Fill(Me.DSConsultas.jrDepartamentos)
        Me.JrMunicipiosTableAdapter.Fill(Me.DSConsultas.jrMunicipios)
        Me.JrCandidatosTableAdapter.Fill(Me.DSConsultas.jrCandidatos)
    End Sub

End Class