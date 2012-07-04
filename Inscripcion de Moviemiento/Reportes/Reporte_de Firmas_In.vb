Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Public Class Reporte_de_Firmas_In

    Private Sub Reporte_de_Firmas_In_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        Dim dataset As New DS_REPORTE_DE_FI_1
        Using Adapter As New DS_REPORTE_DE_FI_1TableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
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

        ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALOR DE LOS MOVIMIENTOS
        Using Adapter1 As New DS_REPORTE_DE_FI_1TableAdapters.IM_MOVIMIENTOSTableAdapter
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

        Using adapter2 As New DS_REPORTE_DE_FI_1TableAdapters.IM_DEPARTAMENTOSTableAdapter
            adapter2.Fill(dataset.IM_DEPARTAMENTOS)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombreDepartamento" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_DEPARTAMENTOS
                LookUpEdit.Properties.DisplayMember = "NOMBRE DEPARTAMENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NOMBRE DEPARTAMENTO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE DEPARTAMENTO", 0, "NOMBRE DEPARTAMENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next



        ' ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALORES DEL NIVEL ELECTIVO
        'Using Adapter2 As New DS_REPORTE_DE_PNEMTableAdapters.DT_NIVEL_ELECTIVOTableAdapter
        '    Adapter2.Fill(dataset.DT_NIVEL_ELECTIVO)
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NivelElectivo" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.DT_NIVEL_ELECTIVO
        '        LookUpEdit.Properties.DisplayMember = "NIVEL ELECTIVO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "NIVEL ELECTIVO"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("NIVEL ELECTIVO", 0, "NIVEL ELECTIVO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next



    End Sub

    Private Sub Reporte_de_Firmas_In_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
        Me.IM_V_FIRMAS_INCONSISTENTESTableAdapter.Fill(Me.DS_REPORTE_DE_FI_11.IM_V_FIRMAS_INCONSISTENTES, NombreDepartamento.Value.ToString)
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(DS_LOG.IM_PARTIDOS_POLITICOS_imagen, NombrePartido.Value.ToString)
        Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(DS_LOG.IM_MOVIMIENTOS_imagen, NombreMovimiento.Value.ToString)
    End Sub
End Class