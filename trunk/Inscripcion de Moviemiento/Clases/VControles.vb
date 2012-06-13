'MANEJA METODOS Y PROCEDIMIENTOS DE LOS CONTROLES NORMALES DEL SISTEMA
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

    Public Shared Function ComprobarFormAbierto(ByVal formulario As Object) As Boolean
        For Each OpenForm As Form In Application.OpenForms
            If OpenForm.Name = formulario.name Then
                Return True
            End If
        Next

        Return False
    End Function

    Public Shared Sub Mayuscula(ByVal texto As Object)
        Dim tl As Integer
        texto.text = UCase(texto.Text)
        tl = Len(texto.Text)
        texto.SelStart = tl

    End Sub
End Class
