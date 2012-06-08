Imports System.IO
Imports DevExpress.XtraEditors

Public Class DxControls
    Public Shared Sub CargarImagen(ByVal PEdit As PictureEdit, ByVal dir As String)
        PEdit.Image = Image.FromFile(dir)
    End Sub


    Public Shared Sub EnumerateControls(ByVal ctrl As System.Windows.Forms.Control)

        If ctrl.Controls.Count > 0 Then
            For Each control As System.Windows.Forms.Control In ctrl.Controls
                EnumerateControls(control)
            Next
        End If
    End Sub

End Class
