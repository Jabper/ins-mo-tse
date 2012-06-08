Public Class XfrmOperacionesPorRol 

    Private Sub XfrmOperacionesPorRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTUsers.IM_ROLES' table. You can move, or remove it, as needed.
        Me.IM_ROLESTableAdapter.Fill(Me.DTUsers.IM_ROLES)
        'TODO: This line of code loads data into the 'DTUsers.TA_ROLES' table. You can move, or remove it, as needed.
        'Me.TA_ROLESTableAdapter.Fill(Me.DTUsers.TA_ROLES)
        'TODO: This line of code loads data into the 'DTUsers.IM_OPCIONES' table. You can move, or remove it, as needed.
        Me.IM_OPCIONESTableAdapter.Fill(Me.DTUsers.IM_OPCIONES)
        'TODO: This line of code loads data into the 'DTUsers.IM_OPERACIONES_POR_ROL' table. You can move, or remove it, as needed.
        Me.IM_OPERACIONES_POR_ROLTableAdapter.Fill(Me.DTUsers.IM_OPERACIONES_POR_ROL)

    End Sub
End Class