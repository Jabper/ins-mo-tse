Imports System.Data.OracleClient
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Public Class Reporte_candidatos_inhabilitados

    Private Sub Reporte_candidatos_inhabilitados_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
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

        Using Adapter1 As New DS_REPORTE_CANDIDATOSTableAdapters.IM_CARGO_ELECTIVOTableAdapter
            Adapter1.Fill(dataset.IM_CARGO_ELECTIVO)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombreNivel" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_CARGO_ELECTIVO
                LookUpEdit.Properties.DisplayMember = "DESCRIPCION" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "DESCRIPCION"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("DESCRIPCION", 0, "DESCRIPCION")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
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

    End Sub
End Class