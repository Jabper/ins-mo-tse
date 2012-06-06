Public Class XfrmMovimientos 

    Private Sub XfrmMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.DataSet1.IM_MOVIMIENTOS)
        'TODO: This line of code loads data into the 'DataSet1.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.DataSet1.IM_MOVIMIENTOS)

    End Sub

    Sub guardar()
        Me.Validate()
        Me.IMMOVIMIENTOSBindingSource.EndEdit()
        Me.IM_MOVIMIENTOSTableAdapter.Update(Me.DataSet1.IM_MOVIMIENTOS)


    End Sub

    Sub nuevo()
        Me.IMMOVIMIENTOSBindingSource.CancelEdit()
        Me.IMMOVIMIENTOSBindingSource.AddNew()

    End Sub
End Class