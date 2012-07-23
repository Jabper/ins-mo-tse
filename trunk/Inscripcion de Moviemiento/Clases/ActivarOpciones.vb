Public Class ActivarOpciones


    'ACTIVAR FUNCIONES DE FILTRO
    Public Shared Function PEstado() As String
        Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
        Dim idmov As String = COracle.ObtenerDatos("select codigo_movimiento from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_MOVIMIENTO")

        If (idp = "99") And (idmov = "N" Or idmov = "" Or idmov = "99") Then
            Return "TSE"
        ElseIf (idp <> "99") And (idmov = "N" Or idmov = "") Then
            Return "PDO"

        ElseIf (idp <> "99") And (idmov <> "N" Or idmov <> "" Or idmov <> "99") Then
            Return "MOV"
        End If

    End Function





End Class
