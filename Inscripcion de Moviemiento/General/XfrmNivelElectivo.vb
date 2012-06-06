Public Class XfrmNivelElectivo 

    Private Sub XfrmNivelElectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         'TODO: This line of code loads data into the 'DataSet1.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DataSet1.IM_NIVEL_ELECTIVO)

    End Sub

    Sub guardar()

        Me.IMNIVELELECTIVOBindingSource.EndEdit()
        Me.IM_NIVEL_ELECTIVOTableAdapter.Update(Me.DataSet1.IM_NIVEL_ELECTIVO)

    End Sub

    Sub nuevo()

        Me.IMNIVELELECTIVOBindingSource.CancelEdit()
        Me.IMNIVELELECTIVOBindingSource.AddNew()
        Me.GCNivelElectivo.Enabled = False

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nuevo()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.IMNIVELELECTIVOBindingSource.CancelEdit()

        Me.GCNivelElectivo.Enabled = True
    End Sub
End Class