
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Public Class REPORTE_DE__PLANILLA_DE_CANDIDATOS

    Private Sub REPORTE_DE__PLANILLA_DE_CANDIDATOS_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        Dim dataset As New DS_REPORTE_CANDIDATOS
        Using Adapter As New DS_REPORTE_CANDIDATOSTableAdapters.IM_PP_CANDIDATOSTableAdapter
            Adapter.Fill(dataset.IM_PP_CANDIDATOS)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombrePartido" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_PP_CANDIDATOS
                LookUpEdit.Properties.DisplayMember = "NOMBRE PARTIDO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NOMBRE PARTIDO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE PARTIDO", 0, "NOMBRE PARTIDO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next

        Using Adapter1 As New DS_REPORTE_CANDIDATOSTableAdapters.IM_NE_CANDIDATOSTableAdapter
            Adapter1.Fill(dataset.IM_NE_CANDIDATOS)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombreNivel" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_NE_CANDIDATOS
                LookUpEdit.Properties.DisplayMember = "NIVEL ELECTIVO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NIVEL ELECTIVO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NIVEL ELECTIVO", 0, "NIVEL ELECTIVO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next

        Using Adapter2 As New DS_REPORTE_CANDIDATOSTableAdapters.IM_DEP_CANDIDATOSTableAdapter
            Adapter2.Fill(dataset.IM_DEP_CANDIDATOS)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombreDepartamento" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_DEP_CANDIDATOS
                LookUpEdit.Properties.DisplayMember = "DEPARTAMENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "DEPARTAMENTO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("DEPARTAMENTO", 0, "DEPARTAMENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next

        Using Adapter2 As New DS_REPORTE_CANDIDATOSTableAdapters.IM_MOVIMIENTOSTableAdapter
            Adapter2.Fill(dataset.IM_MOVIMIENTOS)
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

    Private Sub REPORTE_DE__PLANILLA_DE_CANDIDATOS_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(Me.DS_LOG.IM_PARTIDOS_POLITICOS_imagen, NombrePartido.Value.ToString)
        Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(Me.DS_LOG.IM_MOVIMIENTOS_imagen, NombreMovimiento.Value.ToString)
    End Sub
End Class