Public Class xfrmRegCandidatos
    Dim vi As Integer = 0


    Sub AgregarFilasGrid(ByVal NumeroCeldas As Integer)
        For i = 1 To CType(NumeroCeldas, Integer)
            GridView1.AddNewRow()

        Next
        Me.GCBusqueda.Focus()
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText

        If (e.Column.FieldName = "Fila") Then

            If e.RowHandle < 0 Then
                e.DisplayText = vi + 1

            Else
                e.DisplayText = e.RowHandle + 1
                vi = e.RowHandle + 1
            End If

        End If



    End Sub
    Private Sub xfrmRegCandidatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSInsCandidatos.DUAL' table. You can move, or remove it, as needed.
        'Me.DUALTableAdapter.Fill(Me.DSInsCandidatos.DUAL)
        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_CANDIDATOS' table. You can move, or remove it, as needed.
        ' Me.IM_CANDIDATOSTableAdapter.Fill(Me.DSInsCandidatos.IM_CANDIDATOS)
        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_CARGOS_ELECTIVOS' table. You can move, or remove it, as needed.
        Me.IM_CARGOS_ELECTIVOSTableAdapter.Fill(Me.DSInsCandidatos.IM_CARGOS_ELECTIVOS)

        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSInsCandidatos.IM_PARTIDOS_POLITICOS)

        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DSInsCandidatos.IM_DEPARTAMENTOS)
        AgregarFilasGrid(5)

    End Sub



    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ' AgregarFilasGrid(Me.TextEdit1.EditValue)

    End Sub

    Private Sub cboDepartamento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.EditValueChanged
        Try
            If Me.cboCargo.EditValue = 4 Or Me.cboCargo.EditValue = 5 Then

                Me.DSInsCandidatos.DUAL.Rows.Clear()

                Dim numFila As Integer
                Dim consulta As String = "select cantidad_diputados from im_departamentos where codigo_departamento = " & Me.cboDepartamento.EditValue
                numFila = COracle.ObtenerDatos(consulta, "cantidad_diputados")
                AgregarFilasGrid(numFila)
            End If

            Me.IM_MUNICIPIOSTableAdapter.Fill(Me.DSInsCandidatos.IM_MUNICIPIOS, Me.cboDepartamento.EditValue)
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub

    Private Sub cboMunicipio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMunicipio.EditValueChanged
        Try
            If Me.cboCargo.EditValue = 8 Then

                Me.DSInsCandidatos.DUAL.Rows.Clear()

                Dim numFila As Integer
                Dim consulta As String = "SELECT CANTIDAD_REGIDORES   FROM IM_MUNICIPIOS WHERE CODIGO_DEPARTAMENTO = " & Me.cboDepartamento.EditValue & " AND CODIGO_MUNICIPIO  = " & Me.cboMunicipio.EditValue
                numFila = COracle.ObtenerDatos(consulta, "CANTIDAD_REGIDORES")
                AgregarFilasGrid(numFila)
            End If

            'Me.IM_MUNICIPIOSTableAdapter.FillBy(Me.DSInsCandidatos.IM_MUNICIPIOS, Me.cboDepartamento.EditValue)
        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try
    End Sub
End Class