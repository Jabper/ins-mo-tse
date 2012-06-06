Public Class XfrmCargoElectivo 

    Private Sub XfrmCargoElectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.IM_CARGOS_ELECTIVOS' table. You can move, or remove it, as needed.
        Me.IM_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DataSet1.IM_CARGOS_ELECTIVOS)


    End Sub
End Class