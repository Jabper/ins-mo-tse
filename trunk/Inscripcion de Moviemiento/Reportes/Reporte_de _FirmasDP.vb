Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Public Class Reporte_de__FirmasDP

    Private Sub Reporte_de__FirmasDP_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        Dim dataset As New DS_REPORTE_DE_FDP
        Using adapter As New DS_REPORTE_DE_FDPTableAdapters.DT_PARTIDO_FDPTableAdapter
            adapter.Fill(dataset.DT_PARTIDO_FDP)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombrePartido" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.DT_PARTIDO_FDP
                LookUpEdit.Properties.DisplayMember = "NOMBRE PARTIDO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NOMBRE PARTIDO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE PARTIDO", 0, "NOMBRE PARTIDO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next

        'CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALORES DEL MOVIMIENTO
        Using adapter As New DS_REPORTE_DE_FDPTableAdapters.DT_MOVIMIENTO_FDPTableAdapter
            adapter.Fill(dataset.DT_MOVIMIENTO_FDP)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombreMovimiento" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.DT_MOVIMIENTO_FDP
                LookUpEdit.Properties.DisplayMember = "NOMBRE MOVIMIENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NOMBRE MOVIMIENTO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE MOVIMIENTO", 0, "NOMBRE MOVIMIENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next

        'Using adapter As New DS_REPORTE_DE_FDPTableAdapters.IM_DEPARTAMENTOS_FDPTableAdapter
        '    adapter.Fill(dataset.IM_DEPARTAMENTOS_FDP)

        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NombreDepartamento" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_DEPARTAMENTOS_FDP
        '        LookUpEdit.Properties.DisplayMember = "NOMBRE DEPARTAMENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "NOMBRE DEPARTAMENTO"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("NOMBRE DEPARTAMENTO", 0, "DEPARTAMENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next


    End Sub
End Class