Public Class xrptPlanilla
    Sub filtrar(ByVal movimiento As String, ByVal partido As String, ByVal muncipio As String, ByVal departamento As String, ByVal cargo As String)
        Me.IM_V_MOSTRAR_CANDIDATOS2TableAdapter.FillBY(Me.DsInsCandidatos1.IM_V_MOSTRAR_CANDIDATOS2, CInt(movimiento), CInt(partido), CInt(muncipio), CInt(departamento), CInt(cargo))
    End Sub
    'Private Sub xrptPlanilla_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
    '    Me.IM_V_MOSTRAR_CANDIDATOS2TableAdapter.FillBY(Me.DsInsCandidatos1.IM_V_MOSTRAR_CANDIDATOS2, CInt(Movimiento.Value), CInt(Partido.Value), CInt(Municipio.Value), CInt(Departamento.Value), CInt(Cargo.Value))
    'End Sub
End Class