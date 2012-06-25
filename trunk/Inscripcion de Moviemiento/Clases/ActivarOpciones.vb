Public Class ActivarOpciones


    'ACTIVAR FUNCIONES DE FILTRO
    Public Shared Function PEstado() As String
        Dim idp As String = COracle.ObtenerDatos("SELECT CODIGO_PARTIDO FROM IM_PARAMETROS_GENERALES", "CODIGO_PARTIDO")
        Dim idmov As String = COracle.ObtenerDatos("SELECT CODIGO_MOVIMIENTO FROM IM_PARAMETROS_GENERALES", "CODIGO_MOVIMIENTO")

        If idp = "N" And idmov = "N" Then
            Return "TSE"
        ElseIf idp <> "N" And idmov = "N" Then
            Return "PDO"

        ElseIf idp <> "N" And idmov <> "N" Then
            Return "MOV"
        End If

    End Function





End Class
