Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Public Class REPORTE_DE_LOG

    Private Sub REPORTE_DE_LOG_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        Dim dataset As New DS_LOG

        Using adapter As New DS_LOGTableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
            adapter.Fill(dataset.IM_PARTIDOS_POLITICOS)
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

        Using adapter1 As New DS_LOGTableAdapters.IM_MOVIMIENTOSTableAdapter
            adapter1.Fill(dataset.IM_MOVIMIENTOS)
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


        'Using adapter As New DS_LOGTableAdapters.IM_OPCIONESTableAdapter
        '    adapter.Fill(dataset.IM_OPCIONES)
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NombreOperacion" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_OPCIONES
        '        LookUpEdit.Properties.DisplayMember = "DESCRIPCION" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "DESCRIPCION"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("DESCRIPCION", 0, "DESCRIPCION")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next

        ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALORES DEL MOVIMIENTO
        'Using adapter1 As New DS_LOGTableAdapters.IM_LOG_PROCESOSTableAdapter
        '    adapter1.Fill(dataset.IM_LOG_PROCESOS)
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NombreProceso" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_LOG_PROCESOS
        '        LookUpEdit.Properties.DisplayMember = "PROCESO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "PROCESO"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("PROCESO", 0, "PROCESO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next
    End Sub
End Class