﻿Public Class Parametros4
    Public partido As String
    Public movimiento As String
    Public nivel As String

    Private Sub Parametros4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_DEPARTAMENTOS)
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_NIVEL_ELECTIVO)
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        ' Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_MOVIMIENTOS)
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOS1TableAdapter.FillBy(Me.DS_PLANILLA_TOTALES.IM_PARTIDOS_POLITICOS1)
        'ActivarFiltros()
    End Sub
    Sub ActivarFiltros()

        If ActivarOpciones.PEstado = "PDO" Then
            Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
            Me.cbopartido.Enabled = False

            'Partido
            Dim p As Integer = Me.cbopartido.Properties.GetDataSourceRowIndex(Me.cbopartido.Properties.Columns("CODIGO_PARTIDO"), idp)
            cbopartido.EditValue = Me.cbopartido.Properties.GetDataSourceValue(cbopartido.Properties.ValueMember, p)

            Try
                'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
                Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DS_PLANILLA_TOTALES.IM_MOVIMIENTOS, Me.cbopartido.EditValue)

            Catch ex As Exception

            End Try

            Me.CmbMovimiento.Enabled = True
            Me.cbopartido.Enabled = False

        ElseIf ActivarOpciones.PEstado = "MOV" Then

            Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
            Dim idmov As String = COracle.ObtenerDatos("select codigo_movimiento from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_MOVIMIENTO")



            Me.cbopartido.Enabled = False
            Me.CmbMovimiento.Enabled = False

            'Partido
            Dim p As Integer = Me.cbopartido.Properties.GetDataSourceRowIndex(Me.cbopartido.Properties.Columns("CODIGO_PARTIDO"), idp)
            cbopartido.EditValue = Me.cbopartido.Properties.GetDataSourceValue(cbopartido.Properties.ValueMember, p)
            Try
                'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
                Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DS_PLANILLA_TOTALES.IM_MOVIMIENTOS, idp)

            Catch ex As Exception

            End Try
            'Movimiento
            Dim m As Integer = Me.CmbMovimiento.Properties.GetDataSourceRowIndex(Me.CmbMovimiento.Properties.Columns("CODIGO_MOVIMIENTO"), idmov)
            Me.CmbMovimiento.EditValue = Me.CmbMovimiento.Properties.GetDataSourceValue(Me.CmbMovimiento.Properties.ValueMember, m)


        End If
    End Sub

    Private Sub cboDepto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepto.EditValueChanged
        Me.IM_MUNICIPIOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_MUNICIPIOS, Me.cboDepto.Text)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'Try
        '    'Me.IM_CANDIDATOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_CANDIDATOS, Me.cboPartido.Text, Me.cboMovimiento.Text, Me.cbonivel.Text, Me.cboDepto.Text, Me.cboMuni.Text)

        '    Dim reporte_planilla As REPORTE_PLANILLA_INCOMPLETA = New REPORTE_PLANILLA_INCOMPLETA
        '    'Me.IM_CANDIDATOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_CANDIDATOS, Me.cboPartido.Text, Me.cboMovimiento.Text, Me.cbonivel.Text Me.cboDepto.Text, Me.cboMuni.Text)
        '    'reporte_planilla.IM_CANDIDATOSTableAdapter.FillBy(reporte_planilla.DS_PLANILLA_TOTALES1.IM_CANDIDATOS, Me.cboPartido.Text, Me.cboMovimiento.Text, Me.cbonivel.Text, Me.cboDepto.Text, Me.cboMuni.Text)
        '    reporte_planilla.FilterString = "[MUNICIPIO] = '" & Me.cboMuni.Text & "' And [PARTIDO] = '" & Me.cbopartido.Text & "' And [DEPARTAMENTO] = '" & Me.cboDepto.Text & "' And [NIVEL] = '" & Me.cbonivel.Text & "' And [NOMBRE_MOVIMIENTO] = '" & Me.CmbMovimiento.Text & "'"
        '    '  reporte_planilla.partido = Me.cboPartido.Text
        '    'reporte_planilla.NombrePartido = cbopartido.Text
        '    ' reporte_planilla.NombreMovimiento = cboMovimiento.Text
        '    reporte_planilla.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(reporte_planilla.DS_LOG.IM_PARTIDOS_POLITICOS_imagen, cbopartido.Text)
        '    reporte_planilla.IM_MOVIMIENTOS_imagenTableAdapter.Fill(reporte_planilla.DS_LOG.IM_MOVIMIENTOS_imagen, CmbMovimiento.Text)
        '    reporte_planilla.ShowPreview()
        '    Me.Close()
        '    Me.partido = Me.cbopartido.Text
        '    Me.nivel = Me.cbonivel.Text
        '    movimiento = (Me.CmbMovimiento.Text)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        If Me.DxValidationProvider1.Validate = True Then



            Try


                Dim reporte As xrptPlanillaNivel3 = New xrptPlanillaNivel3
                reporte.txtmovimiento.Text = Me.CmbMovimiento.Text
                reporte.txtpartido.Text = Me.cbopartido.Text
                reporte.txtnivel.Text = Me.cbonivel.Text
                reporte.txtusuario.Text = NombreUsuario
                reporte.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(reporte.DS_LOG.IM_PARTIDOS_POLITICOS_imagen, cbopartido.Text)
                reporte.IM_MOVIMIENTOS_imagenTableAdapter.Fill(reporte.DS_LOG.IM_MOVIMIENTOS_imagen, CmbMovimiento.Text)
                ' 
                Select Case Me.cbonivel.EditValue
                    Case 1
                        reporte.NivelPresidencial(Me.cbopartido.EditValue, Me.CmbMovimiento.EditValue)
                        reporte.GroupHeader2.Visible = False
                    Case 2
                        reporte.NivelDiputados(Me.cbopartido.EditValue, Me.CmbMovimiento.EditValue, Me.cboDepto.EditValue)
                        reporte.txtdepartamento.Text = Me.cboDepto.Text & " " & Me.cboDepto.EditValue
                        reporte.XrLabel15.Visible = False
                        reporte.txtmunicipio.Visible = False
                    Case 3
                        reporte.NivelCorporacion(Me.cbopartido.EditValue, Me.CmbMovimiento.EditValue, cboDepto.EditValue, Me.cboMuni.EditValue)
                        reporte.txtdepartamento.Text = Me.cboDepto.EditValue & " " & Me.cboDepto.Text
                        reporte.txtmunicipio.Text = Me.cboMuni.EditValue & " " & Me.cboMuni.Text

                End Select
                reporte.ShowPreview()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub

    Private Sub cbopartido_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopartido.EditValueChanged
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        Try
            Me.IM_MOVIMIENTOSTableAdapter.FillBy(Me.DS_PLANILLA_TOTALES.IM_MOVIMIENTOS, Me.cbopartido.EditValue)
            'Me.IM_PARTIDOS_POLITICOS1TableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_PARTIDOS_POLITICOS1, Me.cbopartido.EditValue)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbonivel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbonivel.EditValueChanged

    End Sub

    Private Sub cbonivel_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbonivel.TextChanged
        Select Case Me.cbonivel.EditValue
            Case 0
                With Me.cboDepto
                    .Enabled = False
                    .EditValue = Nothing
                End With

                With Me.cboMuni
                    .Enabled = False
                    .EditValue = Nothing
                End With

            Case 1
                With Me.cboDepto
                    .Enabled = False
                    .EditValue = Nothing
                End With

                With Me.cboMuni
                    .Enabled = False
                    .EditValue = Nothing
                End With

            Case 2
                With Me.cboDepto
                    .Enabled = True
                    .EditValue = Nothing
                End With

                With Me.cboMuni
                    .Enabled = False
                    .EditValue = Nothing
                End With

            Case 3
                With Me.cboDepto
                    .Enabled = True
                    .EditValue = Nothing
                End With

                With Me.cboMuni
                    .Enabled = True
                    .EditValue = Nothing
                End With

        End Select
    End Sub
End Class