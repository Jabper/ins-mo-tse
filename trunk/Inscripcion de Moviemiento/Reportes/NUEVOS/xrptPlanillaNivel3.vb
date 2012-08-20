Public Class xrptPlanillaNivel3
    Sub NivelPresidencial(ByVal partido As Integer, ByVal movimiento As Integer)
        Me.IM_V_CANDIDATOS_NIVELTableAdapter.NivelPresidencial(Me.DT_Planillas_Por_Nivel1.IM_V_CANDIDATOS_NIVEL, partido, movimiento)

    End Sub
    Sub NivelDiputados(ByVal partido As Integer, ByVal movimiento As Integer, ByVal departamento As Integer)
        Me.IM_V_CANDIDATOS_NIVELTableAdapter.NivelDiputados(Me.DT_Planillas_Por_Nivel1.IM_V_CANDIDATOS_NIVEL, partido, movimiento, departamento)

    End Sub

    Sub NivelCorporacion(ByVal partido As Integer, ByVal movimiento As Integer, ByVal departamento As Integer, ByVal municipio As Integer)
        Me.IM_V_CANDIDATOS_NIVELTableAdapter.NivelCorporacion(Me.DT_Planillas_Por_Nivel1.IM_V_CANDIDATOS_NIVEL, partido, movimiento, departamento, municipio)

    End Sub
End Class