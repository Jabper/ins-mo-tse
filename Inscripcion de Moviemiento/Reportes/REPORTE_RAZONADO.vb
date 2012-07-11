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
        Dim oradb As String = Configuracion.verconfig
        Dim conn As New OracleConnection()
        Dim myCMD As New OracleCommand()
        Dim tnivel_diputadoscnp As String = 0
        Dim tnivel_diputadoscnpc As String = 0
        Dim tnivel_diputadoscnsc As String = 0
        Dim tnivel_diputadoscnsi As String = 0
        Dim tnivel_presidente As String = 0
        Dim tnivel_diputadosPARP As String = 0
        Dim tnivel_diputadosPARS As String = 0
        Dim tnivel_corporacionmunic As String = 0
        Dim tnivel_corporacionmunin As String = 0

        Me.Nomina_presidencialTableAdapter.Fill(DS_RAZONADO.nomina_presidencial, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        'Me.Nomina_parlacen_pTableAdapter.Fill(DS_RAZONADO.nomina_parlacen_p, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        'Me.Nomina_parlacen_sTableAdapter.Fill(DS_RAZONADO.nomina_parlacen_s, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        'Me.Nomina_congreso_pTableAdapter.Fill(DS_RAZONADO.nomina_congreso_p, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        'Me.Nomina_congreso_pinTableAdapter.Fill(DS_RAZONADO.nomina_congreso_pin, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)

        Me.partido.Text = Me.NombrePartido.Value.ToString
        Me.movimiento.Text = Me.NombreMovimiento.Value.ToString

        '**********************************************************************************
        conn.ConnectionString = oradb
        conn.Open()
        tnivel_diputadoscnp = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_V_NOMINA_DP A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        tnivel_diputadoscnpc = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_V_NOMINA_DP A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        tnivel_diputadoscnsc = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_V_NOMINA_DS A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        tnivel_diputadoscnsi = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_V_NOMINA_DS A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        tnivel_presidente = COracle.ObtenerDatos("select count(1)CARGOS from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (1,9) and C.ESTADO = 'H' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOS")
        tnivel_diputadosPARP = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (2) and C.ESTADO ='H' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        tnivel_diputadosPARS = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (3) and C.ESTADO ='H' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        '***********************************************************************************
        tnivel_corporacionmunic = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM IM_V_NOMINA_CM A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        tnivel_corporacionmunin = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM IM_V_NOMINA_CM A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")

        conn.Close()
        '***********************************************************************************
        'MsgBox(tnivel_diputadoscnp.ToString)
        'MsgBox(tnivel_diputadoscnpc.ToString)
        'MsgBox(tnivel_diputadoscnsc.ToString)
        'MsgBox(tnivel_diputadoscnsi.ToString)
        'MsgBox(tnivel_presidente.ToString)
        'MsgBox(tnivel_diputadosPARP.ToString)
        'MsgBox(tnivel_diputadosPARS.ToString)
        'MsgBox(tnivel_corporacionmunic.ToString)
        'MsgBox(tnivel_corporacionmunin.ToString)

        'ASIGNACIONES
        Me.congre4.Text = tnivel_diputadoscnpc.ToString
        Me.congre5.Text = tnivel_diputadoscnp.ToString
        Me.congres1.Text = tnivel_diputadoscnsc.ToString
        Me.congres2.Text = tnivel_diputadoscnsi.ToString
        Me.corporacion1.Text = tnivel_corporacionmunic.ToString
        Me.corporacion2.Text = tnivel_corporacionmunin.ToString

        If tnivel_presidente = 4 Then
            Me.preco1.Text = "1"
            Me.preco2.Text = "0"
            Me.preco3.Text = "Si"
        Else
            Me.preco1.Text = "0"
            Me.preco2.Text = "1"
            Me.preco3.Text = "No"
        End If

        If tnivel_diputadosPARP = 20 Then
            Me.parla1.Text = "1"
            Me.parla2.Text = "0"
            Me.parla3.Text = "Si"
        Else
            Me.parla1.Text = "0"
            Me.parla2.Text = "1"
            Me.parla3.Text = "No"
        End If

        If tnivel_diputadosPARS = 20 Then
            Me.parlas1.Text = "1"
            Me.parlas2.Text = "0"
            Me.parlas3.Text = "Si"
        Else
            Me.parlas1.Text = "0"
            Me.parlas2.Text = "1"
            Me.parlas3.Text = "No"
        End If

        'diputados congreso propietarios
        If tnivel_diputadoscnpc >= 10 Then
            Me.congre3.Text = "Si"
        Else
            Me.congre3.Text = "No"
        End If
        'diputados congreso suplentes
        If tnivel_diputadoscnsc >= 10 Then
            Me.congres3.Text = "Si"
        Else
            Me.congres3.Text = "No"
        End If
        'corporacion municipal
        If tnivel_corporacionmunic >= 10 Then
            corpo3.Text = "Si"
        Else
            corpo3.Text = "No"
        End If

        'se envian los filtros por nombre de partido y nombre de movimiento para recuperar las respectivas imagenes
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(DS_LOG.IM_PARTIDOS_POLITICOS_imagen, NombrePartido.Value.ToString)
        Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(DS_LOG.IM_MOVIMIENTOS_imagen, NombreMovimiento.Value.ToString)

    End Sub
End Class