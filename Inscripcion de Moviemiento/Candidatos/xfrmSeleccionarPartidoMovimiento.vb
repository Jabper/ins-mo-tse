Public Class xfrmSeleccionarPartidoMovimiento 

    Private Sub xfrmSeleccionarPartidoMovimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSInsCandidatos.IM_PARTIDOS_POLITICOS)

    End Sub

    Private Sub CmbPartido_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPartido.EditValueChanged
        Try
            
            'TODO: This line of code loads data into the 'DSInsCandidatos.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
            Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DSInsCandidatos.IM_MOVIMIENTOS, Me.CmbPartido.EditValue)
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub BtnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrear.Click
        mostrar()
    End Sub

    Sub mostrar()
        If IsDBNull(Me.CmbPartido.EditValue) Or Me.CmbPartido.EditValue Is Nothing Then
            Mensajes.mimensaje("SELECCIONE EL PARTIDO POLÍTICO")
        ElseIf IsDBNull(Me.CmbMovimiento.EditValue) Or Me.CmbMovimiento.EditValue Is Nothing Then
            Mensajes.mimensaje("SELECCIONE EL MOVIMIENTO")
        Else

            If VControles.ComprobarFormAbierto(xfrmRegCandidatos) Then

                xfrmRegCandidatos.Close()

            End If


            xfrmRegCandidatos.Show()
            With xfrmRegCandidatos
                .id_partido = Me.CmbPartido.EditValue
                .id_movimiento = Me.CmbMovimiento.EditValue
                Dim cons As String = String.Format("SELECT NOMBRE FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO = {0}", Me.CmbPartido.EditValue)
                Dim con As String = String.Format("SELECT NOMBRE_MOVIMIENTO FROM IM_MOVIMIENTOS WHERE CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1}", Me.CmbPartido.EditValue, Me.CmbMovimiento.EditValue)

                .lblMovimiento.Text = COracle.ObtenerDatos(con, "NOMBRE_MOVIMIENTO")
                .lblPartido.Text = COracle.ObtenerDatos(cons, "NOMBRE")

            End With
            Me.Close()
        End If

    End Sub
End Class