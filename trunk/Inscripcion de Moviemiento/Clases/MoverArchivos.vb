Public Class MoverArchivos
    Public Shared Sub MoverCarpetas()
        Try
            My.Computer.FileSystem.MoveDirectory("C:\oraclexe\Requisitos Previos", Application.StartupPath.ToString & "\CSIM\Requisitos Previos", True)

        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub MoverArchivos()
        Try
            My.Computer.FileSystem.MoveFile("C:\oraclexe\setup.exe", Application.StartupPath.ToString & "\CSIM\Aplicación\Componentes\setup.exe")
            My.Computer.FileSystem.MoveFile("C:\oraclexe\Inscripción de Movimientos TSE.msi", Application.StartupPath.ToString & "\CSIM\Aplicación\Componentes\Inscripción de Movimientos TSE.msi")

        Catch ex As Exception

        End Try
    End Sub
End Class
