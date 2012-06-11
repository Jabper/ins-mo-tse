Public Class XfrmIngresoCandidatos 

    Private Sub XfrmIngresoCandidatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSCandidato.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.DSCandidato.IM_MOVIMIENTOS)
        'TODO: This line of code loads data into the 'DSCandidato.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSCandidato.IM_PARTIDOS_POLITICOS)
        'TODO: This line of code loads data into the 'DSCandidato.IM_MUNICIPIOS' table. You can move, or remove it, as needed.
        Me.IM_MUNICIPIOSTableAdapter.Fill(Me.DSCandidato.IM_MUNICIPIOS)
        'TODO: This line of code loads data into the 'DSCandidato.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DSCandidato.IM_DEPARTAMENTOS)
        'TODO: This line of code loads data into the 'DSCandidato.IM_CARGOS_ELECTIVOS' table. You can move, or remove it, as needed.
        Me.IM_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DSCandidato.IM_CARGOS_ELECTIVOS)
        'TODO: This line of code loads data into the 'DSCandidato.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DSCandidato.IM_NIVEL_ELECTIVO)
        'TODO: This line of code loads data into the 'DSCandidato.IM_CANDIDATOS' table. You can move, or remove it, as needed.
        Me.IM_CANDIDATOSTableAdapter.Fill(Me.DSCandidato.IM_CANDIDATOS)
        'TODO: This line of code loads data into the 'DSPolitico.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
   
        'TODO: This line of code loads data into the 'DSCandidato.IM_CANDIDATOS' table. You can move, or remove it, as needed.
        Me.IM_CANDIDATOSTableAdapter.Fill(Me.DSCandidato.IM_CANDIDATOS)
        'TODO: This line of code loads data into the 'DSCandidato.IM_CANDIDATOS' table. You can move, or remove it, as needed.
        Me.IM_CANDIDATOSTableAdapter.Fill(Me.DSCandidato.IM_CANDIDATOS)

    End Sub
End Class