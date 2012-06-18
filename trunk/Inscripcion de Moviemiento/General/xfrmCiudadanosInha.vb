Public Class xfrmCiudadanosInha 

    Private Sub xfrmCiudadanosInha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_CIUDADANOS_INH.IM_CIUDADANOS_INHABILITADOS' table. You can move, or remove it, as needed.
        Me.IM_CIUDADANOS_INHABILITADOSTableAdapter.Fill(Me.DS_CIUDADANOS_INH.IM_CIUDADANOS_INHABILITADOS)

    End Sub
End Class