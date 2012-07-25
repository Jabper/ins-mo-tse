Imports System.Data.OracleClient
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Public Class REPORTE_REGISTRO_IMPORTACIONES_2
    Private Sub REPORTE_REGISTRO_IMPORTACIONES_2_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        Dim dataset As New DS_REGISTRO_IMPORTACIONES_2

        Using adapter As New DS_REGISTRO_IMPORTACIONES_2TableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
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


        Using adapter1 As New DS_REGISTRO_IMPORTACIONES_2TableAdapters.IM_MOVIMIENTOSTableAdapter
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

        Using adapter2 As New DS_REGISTRO_IMPORTACIONES_2TableAdapters.IM_REGISTRO_IMPORTACIONESTableAdapter
            adapter2.Fill(dataset.IM_REGISTRO_IMPORTACIONES)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "FechaA" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_REGISTRO_IMPORTACIONES
                LookUpEdit.Properties.DisplayMember = "FECHA_ADICION" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "FECHA_ADICION"
                LookUpEdit.Properties.Columns.Add(New  _
            LookUpColumnInfo("FECHA_ADICION", 0, "FECHA_ADICION")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next

        Using adapter3 As New DS_REGISTRO_IMPORTACIONES_2TableAdapters.IM_REGISTRO_IMPORTACIONES1TableAdapter
            adapter3.Fill(dataset.IM_REGISTRO_IMPORTACIONES1)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "HoraA" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_REGISTRO_IMPORTACIONES1
                LookUpEdit.Properties.DisplayMember = "HORA_ADICION" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "HORA_ADICION"
                LookUpEdit.Properties.Columns.Add(New  _
            LookUpColumnInfo("HORA_ADICION", 0, "HORA_ADICION")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next

    End Sub

    Private Sub REPORTE_REGISTRO_IMPORTACIONES_2_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
        Me.IM_V_REGISTRO_IMPOR_2TableAdapter.Fill(Me.DS_REGISTRO_IMPORTACIONES_22.IM_V_REGISTRO_IMPOR_2, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString, Me.FechaA.Value.ToString, Me.HoraA.Value.ToString)

    End Sub
End Class