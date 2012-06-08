Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Reflection




Public Class DxControls
    Public Shared Function ObtenerDireccion(ByVal PEdit As PictureEdit) As String
        Return PEdit.EditValue.ToString()
    End Function
End Class
