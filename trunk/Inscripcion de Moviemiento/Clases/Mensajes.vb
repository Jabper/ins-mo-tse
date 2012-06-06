Imports DevExpress.XtraEditors
Public Class Mensajes
    Public Shared Sub mimensaje(ByVal mensaje As String)
        XtraMessageBox.Show(mensaje, "Inscripción de Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Public Shared Sub MensajeError(ByVal mensaje As String)
        XtraMessageBox.Show(mensaje, "Inscripción de Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Shared Sub MensajeGuardar(ByVal mensaje As String)
        XtraMessageBox.Show("La Información ha sido Guardada Correctamente", "Inscripción de Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub MensajeEliminar(ByVal mensaje As String)
        XtraMessageBox.Show("Registro Eliminado Correctamente", "Inscripción de Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub MensajeActualizar(ByVal mensaje As String)
        XtraMessageBox.Show("Datos Actualizados Correctamente", "Inscripción de Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
