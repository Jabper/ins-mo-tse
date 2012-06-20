﻿Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Public Class Reporte_PlanillaNEM

    Private Sub Reporte_PlanillaNEM_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        Dim dataset As New DS_PLANILLANEM
        Using Adapter As New DS_PLANILLANEMTableAdapters.DT_Partidos_PlanillaTableAdapter
            Adapter.Fill(dataset.DT_Partidos_Planilla)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombrePartido" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.DT_Partidos_Planilla
                LookUpEdit.Properties.DisplayMember = "NOMBRE PARTIDO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NOMBRE PARTIDO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE PARTIDO", 0, "NOMBRE PARTIDO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next

        ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALOR DE LOS MOVIMIENTOS
        Using Adapter1 As New DS_PLANILLANEMTableAdapters.DT_Movimientos_PlanillaTableAdapter
            Adapter1.Fill(dataset.DT_Movimientos_Planilla)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombreMovimiento" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.DT_Movimientos_Planilla
                LookUpEdit.Properties.DisplayMember = "NOMBRE MOVIMIENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NOMBRE MOVIMIENTO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE MOVIMIENTO", 0, "NOMBRE MOVIMIENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next

        ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALORES DEL NIVEL ELECTIVO
        Using Adapter2 As New DS_PLANILLANEMTableAdapters.IM_NIVEL_ELECTIVOTableAdapter
            Adapter2.Fill(dataset.IM_NIVEL_ELECTIVO)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NivelElectivo" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_NIVEL_ELECTIVO
                LookUpEdit.Properties.DisplayMember = "NIVEL ELECTIVO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NIVEL ELECTIVO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NIVEL ELECTIVO", 0, "NIVEL ELECTIVO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next

    End Sub
End Class