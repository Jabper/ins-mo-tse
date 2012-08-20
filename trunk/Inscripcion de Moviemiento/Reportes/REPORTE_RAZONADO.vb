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

        'Dim dataset As New DS_PLANILLA_TOTALES
        Dim dataset As New DS_REPORTE_DE_PNEM_1

        Dim nombrem As String
        Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
        Dim nombrep As String = COracle.ObtenerDatos("select nombre from im_partidos_politicos where codigo_partido=" & idp, "nombre")
        Dim idmov As String = COracle.ObtenerDatos("select codigo_movimiento from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_MOVIMIENTO")
        If idmov = "" Then
        Else
            nombrem = COracle.ObtenerDatos("select NOMBRE_MOVIMIENTO from im_movimientos where codigo_movimiento =" & idmov & " and codigo_partido=" & idp, "NOMBRE_MOVIMIENTO")
        End If


        Using Adapter As New DS_REPORTE_DE_PNEM_1TableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
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

                '-------------------------------------------------------------
                'BLOQUEAR SELECCION DEL COMBO PARA USUARIOS DE PARTIDO Y MOVIMIENTO
                If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "MOV" Then
                    LookUpEdit.Enabled = False
                End If
                '-------------------------------------------------------------
                info.Editor = LookUpEdit
            End If
        Next

        '-------------------------------------------------------------
        '       ESTABLECER EL PARTIDO DE ACUERDO AL USUARIO
        If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "MOV" Then

            NombrePartido.Value = nombrep
        End If
        '-------------------------------------------------------------

        ' ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALOR DE LOS MOVIMIENTOS
        Using Adapter1 As New DS_REPORTE_DE_PNEM_1TableAdapters.IM_MOVIMIENTOSTableAdapter
            '-------------------------------------------------------------
            'ESTABLECIENDO VALORES PARA EL COMBO MOVIMIENTO
            If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "MOV" Or ActivarOpciones.PEstado = "TSE" Then

                Adapter1.FillCodPartido(dataset.IM_MOVIMIENTOS, CType(idp, Integer))
                'Else
                '    Adapter1.Fill(dataset.IM_MOVIMIENTOS)
            End If
            '-------------------------------------------------------------
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombreMovimiento" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_MOVIMIENTOS
                LookUpEdit.Properties.DisplayMember = "NOMBRE MOVIMIENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NOMBRE MOVIMIENTO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE MOVIMIENTO", 0, "NOMBRE MOVIMIENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 

                'BLOQUEAR COMBO DE ACUERDO AL USUARIO
                If ActivarOpciones.PEstado = "MOV" Then
                    LookUpEdit.Enabled = False
                End If
                info.Editor = LookUpEdit


            End If
        Next

        'ESTABLECER MOVIMIENTO DE ACUERDO AL USUARIO
        If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "MOV" Then
            NombreMovimiento.Value = nombrem
        End If

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
        Dim tnivel_presidente_in As String = 0
        Dim tnivel_diputadosPARP As String = 0
        Dim tnivel_diputadosPARP_in As String = 0
        'NOMINAS INCOMPLETAS
        Dim NOMINA_INC_PRESIDENTE As String = 0
        Dim NOMINA_INC_PARLACENPR As String = 0
        Dim NOMINA_INC_PARLACENSU As String = 0
        Dim NOMINA_INC_CONGRESOPR As String = 0
        Dim nomina_vac_congresopr As String = 0
        Dim NOMINA_INC_CONGRESOSU As String = 0
        Dim NOMINA_VAC_CONGRESOSU As String = 0

        Dim tnivel_diputadosPARS As String = 0
        Dim tnivel_diputadosPARS_in As String = 0

        Dim tnivel_corporacionmunic As String = 0
        Dim tnivel_corporacionmunin As String = 0
        Dim tnivel_corporacionmunininconsis As String = 0
        '****************************************
        Dim Nomina_vacias_presidente As String = 0
        Dim Nomina_vacias_parlacenp As String = 0
        Dim Nomina_vacias_parlacens As String = 0
        Dim Nomina_vacias_CNP As String = 0
        Dim Nomina_vacias_CNPS As String = 0
        Dim Nomina_vacias_CMUNI As String = 0

        Dim NOMINA_PRESIDENTE_COMPLETA As String = 0


        Dim contadorpre As String = 0

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
        
       '***********************************************************************************
        'tnivel_corporacionmunic = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM IM_V_NOMINA_CM_C A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        'tnivel_corporacionmunin = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM IM_V_NOMINA_CM A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")


        '***********************************************************************************
        'DATOS PARA NOMINA PRESIDENCIAL
        tnivel_presidente = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where  CA.CODIGO_CARGO_ELECTIVO in (1,9) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO  and CA.VALIDADO = 'S' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        tnivel_presidente_in = COracle.ObtenerDatos("select count(1)CARGOS from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (1,9) and C.ESTADO = 'I' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOS")
        Nomina_vacias_presidente = COracle.ObtenerDatos("select count(1)CARGOS from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (1,9)  and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOS")
        'DATOS PARA NOMINA PARLACEN PROPIETARIOS
        tnivel_diputadosPARP = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.CODIGO_CARGO_ELECTIVO in (2) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO  and CA.VALIDADO = 'S' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        tnivel_diputadosPARP_in = COracle.ObtenerDatos("select count(1)CARGOS from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (2) and C.ESTADO = 'I' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOS")
        Nomina_vacias_parlacenp = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (2)  and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        'DATOS PARA NOMINA PARLACEN SUPLENTES
        tnivel_diputadosPARS = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.CODIGO_CARGO_ELECTIVO in (3) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO  and CA.VALIDADO = 'S' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        tnivel_diputadosPARS_in = COracle.ObtenerDatos("select count(1)CARGOS from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (3) and C.ESTADO = 'I' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOS")
        Nomina_vacias_parlacens = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (3) and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        'DATOS PARA NOMINA CONGRESO PROPIETARIOS
        tnivel_diputadoscnpc = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPP_F A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        NOMINA_INC_CONGRESOPR = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_INCONS_DPP A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' AND DECODE(A.conteo,0,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        tnivel_diputadoscnp = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPP_F A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        'DATOS PARA NOMINA DE CONGRESO SUPLENTES
        tnivel_diputadoscnsc = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPS_F A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' and A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        tnivel_diputadoscnsi = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_INCONS_DPS A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' AND DECODE(A.conteo,0,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        NOMINA_INC_CONGRESOSU = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPS_F A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        'DATOS PARA NOMINA DE CORPORACION MUNICIPAL 
        tnivel_corporacionmunic = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM im_cd_completas_dpco_f A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        tnivel_corporacionmunin = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM im_cd_completa_dpco_INC A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        tnivel_corporacionmunininconsis = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_INCONS_MUNI A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.TOTALR,'S','N') ='S' AND DECODE(A.conteo,0,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        'NOMINAS INCOMPLETAS
        'NOMINA_INC_PRESIDENTE = COracle.ObtenerDatos("select count(1)CARGOS from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (1,9)  and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOS")
        'NOMINA_INC_PARLACENPR = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (2)  and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        'NOMINA_INC_PARLACENSU = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (3) and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")

        'NOMINA_INC_CONGRESOPR = COracle.ObtenerDatos("select count (1)CARGOSPP from im_v_faltantes f where F.CARGO_ELECTIVO=  'Diputado (a) al congreso nacional propietarios' and F.CANTIDAD_FALTANTES <> F.REQUERIDOS  and f.Partido ='" & Me.NombrePartido.Value.ToString & "' and f.MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        'nomina_vac_congresopr = COracle.ObtenerDatos("select count (1)CARGOSPP from im_v_faltantes f where F.CARGO_ELECTIVO=  'Diputado (a) al congreso nacional propietarios' and F.INGRESADOS  = 0 and f.Partido ='" & Me.NombrePartido.Value.ToString & "' and f.MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        'NOMINA_INC_CONGRESOSU = COracle.ObtenerDatos("select count (1)CARGOSPP from im_v_faltantes f where F.CARGO_ELECTIVO=  'Diputado (a) al congreso nacional suplentes' and F.CANTIDAD_FALTANTES <> F.REQUERIDOS  and f.Partido ='" & Me.NombrePartido.Value.ToString & "' and f.MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        'NOMINA_VAC_CONGRESOSU = COracle.ObtenerDatos("select count (1)CARGOSPP from im_v_faltantes f where F.CARGO_ELECTIVO=  'Diputado (a) al congreso nacional suplentes' and F.INGRESADOS  = 0 and f.Partido ='" & Me.NombrePartido.Value.ToString & "' and f.MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        '***********************************************************************************
        conn.Close()
        '***********************************************************************************

        'codigo para validacion de las planillas a nivel presidencial

        If tnivel_presidente = 4 Then
            Me.preco1.Text = "1" 'COMPLETA
            Me.preco3.Text = "SI" 'CUMPLE
            Me.preco4.Text = "0" 'INCOMPLETA
        Else
            Me.preco1.Text = "0" 'nivel incompleta
            Me.preco4.Text = "1"
            Me.preco3.Text = "NO"
        End If

        If tnivel_presidente = 4 And tnivel_presidente_in > 0 Then
            Me.preco2.Text = "1" 'INCONSISTENTE
        Else
            Me.preco2.Text = "0"
        End If

        If tnivel_presidente = 0 Then 'nominas vacias
            Me.Nominavacia_1.Text = "1"
            Me.preco4.Text = "0"
        Else
            Me.Nominavacia_1.Text = "0"
        End If
        'revisado y valido
        'fin del codigo de validacion de las planillas a nivel presidencial
        'PARLACEN PROPIETARIOS
        If tnivel_diputadosPARP = 20 Then
            Me.parla1.Text = "1" 'COMPLETA
            Me.parla3.Text = "SI" 'CUMPLE
            Me.NominaParlacen.Text = "0" 'INCOMPLETA
        Else
            Me.parla1.Text = "0" 'nivel incompleta
            Me.NominaParlacen.Text = "1"
            Me.parla3.Text = "NO"
        End If

        If tnivel_diputadosPARP = 20 And tnivel_diputadosPARP_in > 0 Then
            Me.parla2.Text = "1" 'INCONSISTENTE
        Else
            Me.parla2.Text = "0"
        End If

        If tnivel_diputadosPARP = 0 Then 'nominas vacias
            Me.Nominavacia_2.Text = "1"
            Me.NominaParlacen.Text = "0"
        Else
            Me.Nominavacia_2.Text = "0"
        End If
        'FIN PARLACEN PROPIETARIOS


        'PARLACEN SUPLENTES

        If tnivel_diputadosPARS = 20 Then
            Me.parlas1.Text = "1" 'COMPLETA
            Me.parlas3.Text = "SI" 'CUMPLE
            Me.NominaParlacens.Text = "0" 'INCOMPLETA
        Else
            Me.parlas1.Text = "0" 'nivel incompleta
            Me.NominaParlacens.Text = "1"
            Me.parlas3.Text = "NO"
        End If

        If tnivel_diputadosPARS = 20 And tnivel_diputadosPARP_in > 0 Then
            Me.parlas2.Text = "1" 'INCONSISTENTE
        Else
            Me.parlas2.Text = "0"
        End If

        If tnivel_diputadosPARS = 0 Then 'nominas vacias
            Me.Nominavacia_3.Text = "1"
            Me.NominaParlacens.Text = "0"
        Else
            Me.Nominavacia_3.Text = "0"
        End If

        'VERIFICADO Y VALIDADO
        'FIN PARLACEN SUPLENTES

        'CONGRESO PROPIETARIOS

        Me.congre4.Text = tnivel_diputadoscnpc.ToString  'COMPLETA
        If tnivel_diputadoscnpc >= 10 Then
            Me.congre3.Text = "SI" 'CUMPLE
            'Me.NominaParlacens.Text = "0" 'INCOMPLETA
        Else
            Me.congre3.Text = "NO"
        End If
        'INCONSISTENTES

        Me.congre5.Text = NOMINA_INC_CONGRESOPR.ToString  'INCONSISTENTE
       
        'INCOMPLETAS
        Me.NominaCNDP.Text = tnivel_diputadoscnp.ToString

        'VACIAS 
        Nominavacia_4.Text = (18 - tnivel_diputadoscnpc - tnivel_diputadoscnp).ToString


        'FIN CONGRESO PROPIETARIOS
        'VERIFICADO Y VALIDADO 

        'CONGRESO SUPLENTES

        Me.congres1.Text = tnivel_diputadoscnsc.ToString  'COMPLETA
        If tnivel_diputadoscnsc >= 10 Then
            Me.congres3.Text = "SI" 'CUMPLE
            'Me.NominaParlacens.Text = "0" 'INCOMPLETA
        Else
            Me.congres3.Text = "NO"
        End If
        'INCONSISTENTES

        Me.congres2.Text = tnivel_diputadoscnsi.ToString   'INCONSISTENTE

        'INCOMPLETAS
        Me.NominaCNDS.Text = NOMINA_INC_CONGRESOSU.ToString

        'VACIAS 
        Nominavacia_5.Text = (18 - tnivel_diputadoscnsc - NOMINA_INC_CONGRESOSU).ToString

        'FIN SUPLENTES
        'VERIFICADO 

        'CORPORACION MUNICIPAL 

        Me.congres1.Text = tnivel_corporacionmunic.ToString  'COMPLETA
        If tnivel_diputadoscnsc >= 150 Then
            Me.corporacion1.Text = "SI" 'CUMPLE
            'Me.NominaParlacens.Text = "0" 'INCOMPLETA
        Else
            Me.corporacion1.Text = "NO"
        End If
        'INCONSISTENTES

        Me.corporacion2.Text = tnivel_corporacionmunininconsis.ToString   'INCONSISTENTE

        'INCOMPLETAS
        Me.NominaCM.Text = tnivel_corporacionmunin.ToString

        'VACIAS 
        Nominavacia_6.Text = (18 - tnivel_corporacionmunic - tnivel_corporacionmunin).ToString




        ''CORPORACION MUNICIPAL

        'se envian los filtros por nombre de partido y nombre de movimiento para recuperar las respectivas imagenes
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(DS_LOG.IM_PARTIDOS_POLITICOS_imagen, NombrePartido.Value.ToString)
        Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(DS_LOG.IM_MOVIMIENTOS_imagen, NombreMovimiento.Value.ToString)

    End Sub

  
    Private Sub REPORTE_RAZONADO_ParametersRequestValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs) Handles Me.ParametersRequestValueChanged
        Dim dataset As New DS_REPORTE_DE_PNEM_1

        If ActivarOpciones.PEstado = "TSE" Then
            'If NombrePartido..ToString <> "" Or NombrePartido.Value.ToString <> Nothing Then

            ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALOR DE LOS MOVIMIENTOS
            Using Adapter1 As New DS_REPORTE_DE_PNEM_1TableAdapters.IM_MOVIMIENTOSTableAdapter


                Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_partidos_politicos where Nombre='" & e.ParametersInformation(0).Editor.Text & "'", "CODIGO_PARTIDO")
                If idp <> "N" Then
                    Adapter1.FillCodPartido(dataset.IM_MOVIMIENTOS, CType(idp, Integer))
                    DirectCast(e.ParametersInformation(1).Editor, DevExpress.XtraEditors.LookUpEdit).Properties.DataSource = Nothing
                    DirectCast(e.ParametersInformation(1).Editor, DevExpress.XtraEditors.LookUpEdit).Properties.DataSource = dataset.IM_MOVIMIENTOS
                    'Adapter1.FillCodPartido(dataset.IM_MOVIMIENTOS, CType(idp, Integer))

                    e.ParametersInformation(1).Editor.Update()
                    e.ParametersInformation(1).Editor.Refresh()
                End If

            End Using

        End If
    End Sub

End Class