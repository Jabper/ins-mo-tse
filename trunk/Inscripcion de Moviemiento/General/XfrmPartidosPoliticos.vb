Public Class XfrmPartidosPoliticos 

    Private Sub XfrmPartidosPoliticos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DataSet1.IM_PARTIDOS_POLITICOS)
        'TODO: This line of code loads data into the 'DataSet1.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DataSet1.IM_PARTIDOS_POLITICOS)

    End Sub
End Class