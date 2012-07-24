Public Class xfrmSeleccionarPartidoMovimiento 

    Sub ActivarFiltros()
        If activaropciones.PEstado = "PDO" Then
            Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
            Me.CmbPartido.Enabled = False


            'Partido
            Dim p As Integer = Me.CmbPartido.Properties.GetDataSourceRowIndex(Me.CmbPartido.Properties.Columns("CODIGO_PARTIDO"), idp)
            CmbPartido.EditValue = Me.CmbPartido.Properties.GetDataSourceValue(CmbPartido.Properties.ValueMember, p)

            Try
                'TODO: This line of code loads data into the 'DSInsCandidatos.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
                Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DSInsCandidatos.IM_MOVIMIENTOS, Me.CmbPartido.EditValue)

            Catch ex As Exception

            End Try
            Me.CmbMovimiento.Enabled = True

        ElseIf activaropciones.PEstado = "MOV" Then
            Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
            Dim idmov As String = COracle.ObtenerDatos("select codigo_movimiento from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_MOVIMIENTO")

            Me.CmbPartido.Enabled = False
            Me.CmbMovimiento.Enabled = False

            'Partido
            Dim p As Integer = Me.CmbPartido.Properties.GetDataSourceRowIndex(Me.CmbPartido.Properties.Columns("CODIGO_PARTIDO"), idp)
            CmbPartido.EditValue = Me.CmbPartido.Properties.GetDataSourceValue(CmbPartido.Properties.ValueMember, p)
            Try
                'TODO: This line of code loads data into the 'DSInsCandidatos.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
                Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DSInsCandidatos.IM_MOVIMIENTOS, idp)

            Catch ex As Exception

            End Try
            'Movimiento
            Dim m As Integer = Me.CmbMovimiento.Properties.GetDataSourceRowIndex(Me.CmbMovimiento.Properties.Columns("CODIGO_MOVIMIENTO"), idmov)
            Me.CmbMovimiento.EditValue = Me.CmbMovimiento.Properties.GetDataSourceValue(Me.CmbMovimiento.Properties.ValueMember, m)


        End If
    End Sub

    Private Sub xfrmSeleccionarPartidoMovimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'TODO: This line of code loads data into the 'DSInsCandidatos.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DSInsCandidatos.IM_PARTIDOS_POLITICOS)

        ActivarFiltros()

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

                Dim cons As String = String.Format("SELECT NOMBRE FROM IM_PARTIDOS_POLITICOS WHERE CODIGO_PARTIDO = {0}", Me.CmbPartido.EditValue)
                Dim con As String = String.Format("SELECT NOMBRE_MOVIMIENTO FROM IM_MOVIMIENTOS WHERE CODIGO_PARTIDO = {0} AND CODIGO_MOVIMIENTO = {1}", Me.CmbPartido.EditValue, Me.CmbMovimiento.EditValue)

                .lblMovimiento.Text = COracle.ObtenerDatos(con, "NOMBRE_MOVIMIENTO")
                .lblPartido.Text = COracle.ObtenerDatos(cons, "NOMBRE")
                .lblidpartido.Text = Me.CmbPartido.EditValue
                .lblidmovimiento.Text = Me.CmbMovimiento.EditValue
                .mostrarimg()
            End With
            Me.Close()
        End If

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class