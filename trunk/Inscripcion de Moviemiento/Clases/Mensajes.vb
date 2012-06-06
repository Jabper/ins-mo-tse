Imports DevExpress.XtraEditors
Public Class Mensajes
    Public Shared Sub mimensaje(ByVal mensaje As String)
        XtraMessageBox.Show(mensaje, "Inscripción de Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Public Shared Sub MensajeError(ByVal mensaje As String)
        XtraMessageBox.Show(mensaje, "Inscripción de Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
