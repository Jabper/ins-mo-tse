Imports System.Data.OracleClient
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Public Class REPORTE_RAZONADO


    Private Sub REPORTE_RAZONADO_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        'carga de datos de parametros generales 
        Me.presidente.Text = "1"
        Me.parlacenp.Text = "1"
        Me.parlacens.Text = "1"
        Me.congresop.Text = "10"
        Me.congresos.Text = "10"
        Me.corporacionm.Text = "150"

        Dim dataset As New DS_PLANILLA_TOTALES
        Using Adapter As New DS_PLANILLA_TOTALESTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
            Adapter.Fill(dataset.IM_PARTIDOS_POLITICOS)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombrePartido" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_PARTIDOS_POLITICOS
                LookUpEdit.Properties.DisplayMember = "NOMBRE PARTIDO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NOMBRE PARTIDO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE PARTIDO", 0, "NOMBRE PARTIDO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next

        ' ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALOR DE LOS MOVIMIENTOS
        Using Adapter1 As New DS_PLANILLA_TOTALESTableAdapters.IM_MOVIMIENTOSTableAdapter
            Adapter1.Fill(dataset.IM_MOVIMIENTOS)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombreMovimiento" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_MOVIMIENTOS
                LookUpEdit.Properties.DisplayMember = "NOMBRE MOVIMIENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NOMBRE MOVIMIENTO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE MOVIMIENTO", 0, "NOMBRE MOVIMIENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next




    End Sub


    Private Sub REPORTE_RAZONADO_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit

        Me.Nomina_presidencialTableAdapter.Fill(DS_RAZONADO.nomina_presidencial, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.Nomina_parlacen_pTableAdapter.Fill(DS_RAZONADO.nomina_parlacen_p, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.Nomina_parlacen_sTableAdapter.Fill(DS_RAZONADO.nomina_parlacen_s, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.Nomina_congreso_pTableAdapter.Fill(DS_RAZONADO.nomina_congreso_p, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.Nomina_congreso_pinTableAdapter.Fill(DS_RAZONADO.nomina_congreso_pin, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)

        Me.partido.Text = Me.NombrePartido.Value.ToString
        Me.movimiento.Text = Me.NombreMovimiento.Value.ToString


        'If Me.PRECO.Text.ToString <> "4" Then
        '    Me.preco1.Text = "0"
        '    Me.preco2.Text = "1"
        '    Me.preco3.Text = "No"
        'Else
        '    Me.preco1.Text = "1"
        '    Me.preco2.Text = "0"
        '    Me.preco3.Text = "Si"
        'End If

        'If Me.parla.Text.ToString <> "20" Then
        '    Me.parla1.Text = "0"
        '    Me.parla2.Text = "1"
        '    Me.parla3.Text = "No"
        'Else
        '    Me.parla1.Text = "1"
        '    Me.parla2.Text = "0"
        '    Me.parla3.Text = "Si"
        'End If

        'If Me.parlas.Text.ToString <> "20" Then
        '    Me.parlas1.Text = "0"
        '    Me.parlas2.Text = "1"
        '    Me.parlas3.Text = "No"
        'Else
        '    Me.parlas1.Text = "1"
        '    Me.parlas2.Text = "0"
        '    Me.parlas3.Text = "Si"
        'End If

        'MsgBox(Me.congre2.Text)
        'diputadosp = Convert.ToInt16(Me.congre2.Text)

        ''If diputadosp > 10 Then
        ''    Me.congre3.Text = "Si"
        ''Else
        ''    Me.congre3.Text = "No"
        'End If

    End Sub

    Private Sub congre2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles congre2.TextChanged
        Me.congre5.Text = Me.congre2.Text
        MsgBox(Me.congre5.Text)
    End Sub
End Class