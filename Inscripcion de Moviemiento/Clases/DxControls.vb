'MANEJA METODOS DE LOS CONTROLES EN LOS FORMULARIOS
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

    'Public Shared Sub LimpiarChekedListBox(ByVal CLB As CheckedListBox)
    '    Dim i As Integer = 0
    '    Do While Not CLB.getiteGetItem(i) Is Nothing

    '        If CLB.GetItemCheckState(i) = CheckState.Unchecked Then
    '            MsgBox(Me.CheckedListBoxControl1.GetItemValue(i).ToString)
    '        End If
    '    Loop
    'End Sub

    Public Shared Sub ObtenerCredencial(ByVal NombreBoton As String, ByVal Opcion As String, ByVal btn As Object)
        Dim credencial As String = COracle.credenciales(NombreBoton, Opcion)
        If credencial = "N" Then
            btn.Visible = False
        ElseIf credencial = "S" Then
            btn.Visible = True
        End If
    End Sub
End Class
