'CONTIENE PROCEDIMIENTOS Y FUNCIONES QUE MANEJAN LA OBTENCION DE INFORMACION Y CONVERSION DE DATOS LOS DATOS DEL SISTEMA
Imports System.Drawing.Imaging
Imports System.IO
Public Class Data

    Public Shared Function CapturarDatoGrid(ByVal gridview As Object, ByVal numerodecelda As Integer) As String

        'SE CREA UNA FILA DE TIPO DATAROW QUE ES IGUAL AL LA FILA SELECCIONADA DEL GRID
        Dim nurow As System.Data.DataRow = gridview.GetFocusedDataRow
        Return nurow(numerodecelda)

    End Function

    Public Shared Function ConvertByteArrayToImage(ByVal byteArrayIn As Byte()) As Image

        Dim ms As New IO.MemoryStream(byteArrayIn)

        Dim returnImage As Image = Image.FromStream(ms)

        Return returnImage

    End Function

    Public Shared Function ConvertImageToByteArray(ByVal imageIn As System.Drawing.Image) As Byte()

        Dim ms As New IO.MemoryStream()

        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

        Return ms.ToArray()

    End Function

    Public Shared Sub CopiarArchivo(ByVal Origen As String, ByVal Destino As String)
        System.IO.File.Copy(Origen, Destino, True)

    End Sub
End Class
