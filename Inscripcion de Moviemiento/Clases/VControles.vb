Public Class VControles

    Public Shared Sub solonumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            Beep()
            e.Handled = True
        End If
    End Sub
End Class
