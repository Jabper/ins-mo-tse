Imports System
Imports System.Data.OracleClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Public Class Reporte_estadistico_general_ge

    Private Sub Reporte_estadistico_general_ge_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
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
    End Sub

    Private Sub Reporte_estadistico_general_ge_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit

        Dim oradb As String = Configuracion.verconfig
        Dim conn As New OracleConnection()
        Dim myCMD As New OracleCommand()
        Dim tnivel_presidente As String = 0
        Dim tnivel_diputadosPARP As String = 0
        Dim tnivel_diputadoscongr As String = 0
        Dim tnivel_corporacionmunic As String = 0
        Dim total As String = 0

        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(DS_LOG.IM_PARTIDOS_POLITICOS_imagen, NombrePartido.Value.ToString)
        Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(DS_LOG.IM_MOVIMIENTOS_imagen, NombreMovimiento.Value.ToString)
        Me.DT_TOTALTableAdapter.Fill(DS_ESTADISTICO_GENERAL_GE1.DT_TOTAL, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.DT_PRESIDENCIALTableAdapter.Fill(DS_ESTADISTICO_GENERAL_GE1.DT_PRESIDENCIAL, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.DT_PARLACENTableAdapter.Fill(DS_ESTADISTICO_GENERAL_GE1.DT_PARLACEN, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.DT_CONGRESOTableAdapter.Fill(DS_ESTADISTICO_GENERAL_GE1.DT_CONGRESO, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.DT_CORPORACIONTableAdapter.Fill(DS_ESTADISTICO_GENERAL_GE1.DT_CORPORACION, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)

        conn.ConnectionString = oradb
        conn.Open()

        ' total = COracle.ObtenerDatos("SELECT COUNT(ic.identidad)TOTAL, PA.NOMBRE , MOV.NOMBRE_MOVIMIENTO FROM IM_CANDIDATOS ic,IM_PADRON_ELECTORAL IP,im_partidos_politicos pa,IM_MOVIMIENTOS mov WHERE IC.IDENTIDAD = IP.NUMERO_IDENTIDAD)AND (IP.SEXO = 2 AND IC.CODIGO_PARTIDO = PA.CODIGO_PARTIDO)AND PA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND IC.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO AND PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' AND MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "' GROUP BY PA.NOMBRE , MOV.NOMBRE_MOVIMIENTO '", "TOTAL")



        conn.Close()

        ' Me.NPRE.Text = total.ToString

    End Sub
End Class