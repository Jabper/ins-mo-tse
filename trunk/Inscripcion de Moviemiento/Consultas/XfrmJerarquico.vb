Public Class XfrmJerarquico 

    Private Sub XfrmJerarquico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSConsultas.jrPartidosPoliticos' table. You can move, or remove it, as needed.
        Me.JrPartidosPoliticosTableAdapter.Fill(Me.DSConsultas.jrPartidosPoliticos)

    End Sub
End Class