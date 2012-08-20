Imports System.Data.OracleClient
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Public Class xrptReporte_Produccion2

    Private Sub xrptReporte_Produccion2_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        Dim dataset As New DS_REPORTE_DE_PNEM_1


        Using Adapter As New DS_REPORTE_DE_PNEM_1TableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
            Adapter.Fill(dataset.IM_PARTIDOS_POLITICOS)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "Partido" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_PARTIDOS_POLITICOS
                LookUpEdit.Properties.DisplayMember = "NOMBRE PARTIDO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "CODIGO_PARTIDO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE PARTIDO", 0, "NOMBRE PARTIDO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit

            End If
        Next

        Me.txtusuario.Text = NombreUsuario
        'Using Adapter1 As New DS_REPORTE_DE_PNEM_1TableAdapters.IM_MOVIMIENTOSTableAdapter
        '    '-------------------------------------------------------------
        '    'ESTABLECIENDO VALORES PARA EL COMBO MOVIMIENTO

        '    'Adapter1.FillCodPartido(dataset.IM_MOVIMIENTOS, CType(Partido.Value, Integer))


        '    '-------------------------------------------------------------
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "Movimiento" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_MOVIMIENTOS
        '        LookUpEdit.Properties.DisplayMember = "NOMBRE MOVIMIENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "CODIGO_MOVIMIENTO"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("NOMBRE MOVIMIENTO", 0, "NOMBRE MOVIMIENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 


        '        info.Editor = LookUpEdit


        '    End If
        'Next

    End Sub

    Private Sub xrptReporte_Produccion2_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
        Me.IM_V_REPORTE_PRODUCCION2TableAdapter.FillBy(Me.DT_Produccion21.IM_V_REPORTE_PRODUCCION2, Partido.Value)
        'Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(Me.DS_LOG.IM_PARTIDOS_POLITICOS_imagen, e.ParametersInformation(0).Editor.Text)
        'Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(Me.DS_LOG.IM_MOVIMIENTOS_imagen, e.ParametersInformation(1).Editor.Text)

    End Sub

    Private Sub xrptReporte_Produccion2_ParametersRequestValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs) Handles Me.ParametersRequestValueChanged
        'Dim dataset As New DS_REPORTE_DE_PNEM_1


        ' ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALOR DE LOS MOVIMIENTOS
        'Using Adapter1 As New DS_REPORTE_DE_PNEM_1TableAdapters.IM_MOVIMIENTOSTableAdapter


        '    Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_partidos_politicos where Nombre='" & e.ParametersInformation(0).Editor.Text & "'", "CODIGO_PARTIDO")
        '    If idp <> "N" Then
        '        Adapter1.FillCodPartido(dataset.IM_MOVIMIENTOS, CType(idp, Integer))
        '        DirectCast(e.ParametersInformation(1).Editor, DevExpress.XtraEditors.LookUpEdit).Properties.DataSource = Nothing
        '        DirectCast(e.ParametersInformation(1).Editor, DevExpress.XtraEditors.LookUpEdit).Properties.DataSource = dataset.IM_MOVIMIENTOS
        '        'Adapter1.FillCodPartido(dataset.IM_MOVIMIENTOS, CType(idp, Integer))

        '        e.ParametersInformation(1).Editor.Update()
        '        e.ParametersInformation(1).Editor.Refresh()
        '    End If

        'End Using


    End Sub
End Class