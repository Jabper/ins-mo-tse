Public Class Data

    Public Shared Function CapturarDatoGrid(ByVal gridview As Object, ByVal numerodecelda As Integer) As String

        'SE CREA UNA FILA DE TIPO DATAROW QUE ES IGUAL AL LA FILA SELECCIONADA DEL GRID
        Dim nurow As System.Data.DataRow = gridview.GetFocusedDataRow
        Return nurow(numerodecelda)

    End Function
End Class
