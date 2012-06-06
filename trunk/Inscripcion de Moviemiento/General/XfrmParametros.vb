Public Class XfrmParametros 

    Private Sub XfrmParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       'TODO: This line of code loads data into the 'DataSet1.IM_PARAMETROS_GENERALES' table. You can move, or remove it, as needed.
        Me.IM_PARAMETROS_GENERALESTableAdapter.Fill(Me.DataSet1.IM_PARAMETROS_GENERALES)

    End Sub

    Sub guardar()
        Me.Validate()
        Me.IMPARAMETROSGENERALESBindingSource.EndEdit()
        Me.IM_PARAMETROS_GENERALESTableAdapter.Update(Me.DataSet1.IM_PARAMETROS_GENERALES)

    End Sub

    Sub nuevo()
        Me.IMPARAMETROSGENERALESBindingSource.CancelEdit()
        Me.IMPARAMETROSGENERALESBindingSource.AddNew()
    End Sub
End Class