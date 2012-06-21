Public Class CREstadistico
    Public Shared TotalFirmas As Double
    Public Shared Firmasmovimiento As Double
    Public Shared porcentaje As Double
    Public Shared FirmasInconsistentes As Double
    'obtencion de estadisticas de los movimientos
    Public Shared Sub obtenerfirmas()
        Dim consulta As String
        consulta = "SELECT CANTIDAD_FIRMAS  FROM IM_PARTIDOS_POLITICOS "
        consulta &= " WHERE CODIGO_PARTIDO = " & IdPartidoPolitico
        TotalFirmas = COracle.ObtenerDatos(consulta, "CANTIDAD_FIRMAS")
    End Sub

    Public Shared Sub FirmasdelMovimiento()
        Dim consulta As String
        consulta = "select count(CONSISTENTE) as CONSISTENTE from IM_CIUDADANOS_RESPALDAN where CONSISTENTE ='S' and "
        consulta &= "CODIGO_PARTIDO=" & IdPartidoPolitico & " AND CODIGO_MOVIMIENTO=" & IdMovimientoPolitico

        Firmasmovimiento = COracle.ObtenerDatos(consulta, "CONSISTENTE")
    End Sub

    Public Shared Sub Calculo()
        porcentaje = (Firmasmovimiento / TotalFirmas) * 100
    End Sub

    Public Shared Sub calcular()
        obtenerfirmas()
        FirmasdelMovimiento()
        FInconsistentes()
        Calculo()
    End Sub

    Public Shared Sub FInconsistentes()
        Dim consulta As String
        consulta = "select count(CONSISTENTE) as CONSISTENTE from IM_CIUDADANOS_RESPALDAN where CONSISTENTE ='N' and "
        consulta &= "CODIGO_PARTIDO=" & IdPartidoPolitico & " AND CODIGO_MOVIMIENTO=" & IdMovimientoPolitico

        FirmasInconsistentes = COracle.ObtenerDatos(consulta, "CONSISTENTE")
    End Sub
End Class
