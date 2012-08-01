﻿Public Class xfrmParametros3 
    Public partido As String
    Public movimiento As String
    Public nivel As String

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
        Try

            COracle.Im_Estadisticas()




            'Dim cargo As String

            'If Me.cbonivel.Text = "CORPORACION MUNICIPAL" Then
            '    cargo = " 'REGIDORES' or [CARGO] = 'VICEALCALDE' or [CARGO] = 'ALCALDES CORPORACION MUNICIPAL'"
            'ElseIf Me.cbonivel.Text = "DIPUTADOS AL CONGRESO NACIONAL" Then
            '    cargo = " 'DIPUTADO (A) AL CONGRESO NACIONAL PROPIETARIOS' or [CARGO] = 'DIPUTADOS (A) AL CONGRESO NACIONAL SUPLENTES'"
            'ElseIf Me.cbonivel.Text = "PRESIDENCIAL" Then
            '    cargo = "'PRESIDENTE (A)' or [CARGO] ='DESIGNADOS' or [CARGO] ='DIPUTADOS (A) AL PARLACEN PROPIETARIOS' or [CARGO] ='DIPUTADOS (A) AL PARLACEN SUPLENTES' "

            'End If



            Dim reporte_planilla As REPORTE_DETALLADO_ESTADISTICO_FILLBY = New REPORTE_DETALLADO_ESTADISTICO_FILLBY
            reporte_planilla.IM_ESTADISTICASTableAdapter.Fill(reporte_planilla.DS_REPORTE_ESTADISTICO_DP1.IM_ESTADISTICAS, Me.cbopartido.EditValue, Me.CmbMovimiento.EditValue, Me.cbonivel.EditValue, Me.cboDepto.EditValue, Me.cboMuni.EditValue)
            reporte_planilla.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(reporte_planilla.DS_LOG.IM_PARTIDOS_POLITICOS_imagen, cbopartido.Text)
            reporte_planilla.IM_MOVIMIENTOS_imagenTableAdapter.Fill(reporte_planilla.DS_LOG.IM_MOVIMIENTOS_imagen, CmbMovimiento.Text)
            reporte_planilla.ShowPreview()

            Me.Close()

            'Me.partido = Me.cbopartido.Text
            'Me.nivel = Me.cbonivel.Text
            'movimiento = (Me.CmbMovimiento.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


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

    Private Sub xfrmParametros3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_DEPARTAMENTOS)
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_NIVEL_ELECTIVO)
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_MOVIMIENTOS)
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_PARTIDOS_POLITICOS)
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_DEPARTAMENTOS' table. You can move, or remove it, as needed.
        Me.IM_DEPARTAMENTOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_DEPARTAMENTOS)
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_NIVEL_ELECTIVO' table. You can move, or remove it, as needed.
        Me.IM_NIVEL_ELECTIVOTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_NIVEL_ELECTIVO)
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_MOVIMIENTOS' table. You can move, or remove it, as needed.
        ' Me.IM_MOVIMIENTOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_MOVIMIENTOS)
        'TODO: This line of code loads data into the 'DS_PLANILLA_TOTALES.IM_PARTIDOS_POLITICOS' table. You can move, or remove it, as needed.
        Me.IM_PARTIDOS_POLITICOSTableAdapter.Fill(Me.DS_PLANILLA_TOTALES.IM_PARTIDOS_POLITICOS)
        ActivarFiltros()
    End Sub
End Class