Public Class Parametros 

    Private Sub Parametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_NIVEL_ELECTIVO)

        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_PARTIDOS_POLITICOS)
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_DEPARTAMENTOS)

    End Sub

    Private Sub cboPartido_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPartido.EditValueChanged
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DS_PLANILLA_TOTALES.IM_MOVIMIENTOS, Me.cboPartido.EditValue)
    End Sub

    Private Sub cboDepto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepto.EditValueChanged
        Me.IM_MUNICIPIOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_MUNICIPIOS, Me.cboDepto.Text)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            'Me.IM_CANDIDATOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_CANDIDATOS, Me.cboPartido.Text, Me.cboMovimiento.Text, Me.cbonivel.Text, Me.cboDepto.Text, Me.cboMuni.Text)

            Dim reporte_planilla As REPORTE_PLANILLAS_FINALES = New REPORTE_PLANILLAS_FINALES
            'Me.IM_CANDIDATOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_CANDIDATOS, Me.cboPartido.Text, Me.cboMovimiento.Text, Me.cbonivel.Text Me.cboDepto.Text, Me.cboMuni.Text)
            'reporte_planilla.IM_CANDIDATOSTableAdapter.FillBy(reporte_planilla.DS_PLANILLA_TOTALES1.IM_CANDIDATOS, Me.cboPartido.Text, Me.cboMovimiento.Text, Me.cbonivel.Text, Me.cboDepto.Text, Me.cboMuni.Text)
            reporte_planilla.FilterString = "[MUNICIPIO] = '" & Me.cboMuni.Text & "' And [PARTIDO] = '" & Me.cboPartido.Text & "' And [DEPARTAMENTO] = '" & Me.cboDepto.Text & "' And [NIVEL] = '" & Me.cbonivel.Text & "' And [NOMBRE_MOVIMIENTO] = '" & Me.cboMovimiento.Text & "'"

            reporte_planilla.ShowPreview()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
     

    End Sub
End Class