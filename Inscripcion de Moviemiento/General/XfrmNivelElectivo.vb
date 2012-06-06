Public Class XfrmNivelElectivo 

    Private Sub XfrmNivelElectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DataSet1.IM_NIVEL_ELECTIVO)
        'TODO: This line of code loads data into the 'DataSet1.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DataSet1.IM_NIVEL_ELECTIVO)

    End Sub

    Sub guardar()
        Me.Validate()
        Me.IMNIVELELECTIVOBindingSource.EndEdit()
        Me.IM_NIVEL_ELECTIVOTableAdapter.Update(Me.DataSet1.IM_NIVEL_ELECTIVO)

    End Sub

    Sub nuevo()
        Me.Validate()
        Me.IMNIVELELECTIVOBindingSource.CancelEdit()
        Me.IMNIVELELECTIVOBindingSource.AddNew()

    End Sub
End Class