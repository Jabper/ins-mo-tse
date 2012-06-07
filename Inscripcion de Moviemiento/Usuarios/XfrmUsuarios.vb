Public Class XfrmUsuarios 

    Private Sub XfrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTUsers.IM_USUARIOS' table. You can move, or remove it, as needed.
        Me.IM_USUARIOSTableAdapter.Fill(Me.DTUsers.IM_USUARIOS)

    End Sub
End Class