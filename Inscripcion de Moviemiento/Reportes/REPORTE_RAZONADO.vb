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
        '****************************************
        Dim Nomina_vacias_presidente As String = 0
        Dim Nomina_vacias_parlacenp As String = 0
        Dim Nomina_vacias_parlacens As String = 0
        Dim Nomina_vacias_CNP As String = 0
        Dim Nomina_vacias_CNPS As String = 0
        Dim Nomina_vacias_CMUNI As String = 0

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
        tnivel_corporacionmunic = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM IM_V_NOMINA_CM_C A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        tnivel_corporacionmunin = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM IM_V_NOMINA_CM A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        '***********************************************************************************
        'DATOS PARA NOMINA PRESIDENCIAL
        tnivel_presidente = COracle.ObtenerDatos("select count(1)CARGOS from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (1,9) and C.ESTADO = 'H' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOS")
        tnivel_presidente_in = COracle.ObtenerDatos("select count(1)CARGOS from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (1,9) and C.ESTADO = 'I' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOS")
        Nomina_vacias_presidente = COracle.ObtenerDatos("select count(1)CARGOS from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (1,9)  and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOS")
        'DATOS PARA NOMINA PARLACEN PROPIETARIOS
        tnivel_diputadosPARP = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (2) and C.ESTADO ='H' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        tnivel_diputadosPARP_in = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (2) and C.ESTADO ='I' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        Nomina_vacias_parlacenp = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (2)  and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        'DATOS PARA NOMINA PARLACEN SUPLENTES
        tnivel_diputadosPARS = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (3) and C.ESTADO ='H' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        tnivel_diputadosPARS_in = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (3) and C.ESTADO ='I' and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        Nomina_vacias_parlacens = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (3) and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        'DATOS PARA NOMINA CONGRESO PROPIETARIOS
        'COMPLETAS
        tnivel_diputadoscnpc = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_V_NOMINA_DP A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        'INCORRECTAS
        tnivel_diputadoscnp = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_V_NOMINA_DP A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        'DATOS PARA NOMINA DE CONGRESO SUPLENTES
        tnivel_diputadoscnsc = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_V_NOMINA_DS A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        tnivel_diputadoscnsi = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_V_NOMINA_DS_INC A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        'DATOS PARA NOMINA DE CORPORACION MUNICIPAL 

        'NOMINAS INCOMPLETAS
        NOMINA_INC_PRESIDENTE = COracle.ObtenerDatos("select count(1)CARGOS from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (1,9)  and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOS")
        NOMINA_INC_PARLACENPR = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (2)  and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        NOMINA_INC_PARLACENSU = COracle.ObtenerDatos(" select count(1)CARGOSPP from im_candidatos c, im_partidos_politicos pa, im_movimientos mov where C.CODIGO_CARGO_ELECTIVO in (3) and C.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and C.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and C.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")

        NOMINA_INC_CONGRESOPR = COracle.ObtenerDatos("select count (1)CARGOSPP from im_v_faltantes f where F.CARGO_ELECTIVO=  'Diputado (a) al congreso nacional propietarios' and F.CANTIDAD_FALTANTES <> F.REQUERIDOS  and f.Partido ='" & Me.NombrePartido.Value.ToString & "' and f.MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        nomina_vac_congresopr = COracle.ObtenerDatos("select count (1)CARGOSPP from im_v_faltantes f where F.CARGO_ELECTIVO=  'Diputado (a) al congreso nacional propietarios' and F.INGRESADOS  = 0 and f.Partido ='" & Me.NombrePartido.Value.ToString & "' and f.MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        NOMINA_INC_CONGRESOSU = COracle.ObtenerDatos("select count (1)CARGOSPP from im_v_faltantes f where F.CARGO_ELECTIVO=  'Diputado (a) al congreso nacional suplentes' and F.CANTIDAD_FALTANTES <> F.REQUERIDOS  and f.Partido ='" & Me.NombrePartido.Value.ToString & "' and f.MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        NOMINA_VAC_CONGRESOSU = COracle.ObtenerDatos("select count (1)CARGOSPP from im_v_faltantes f where F.CARGO_ELECTIVO=  'Diputado (a) al congreso nacional suplentes' and F.INGRESADOS  = 0 and f.Partido ='" & Me.NombrePartido.Value.ToString & "' and f.MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "CARGOSPP")
        '***********************************************************************************
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

        'codigo anterior
        'If tnivel_presidente = 4 Then
        '    Me.preco1.Text = "1"
        '    Me.preco2.Text = "0"
        '    Me.preco3.Text = "Si"

        'Else
        '    Me.preco1.Text = "0"
        '    Me.preco2.Text = "1"
        '    Me.preco3.Text = "No"

        'End If
        'codigo para validacion de las planillas a nivel presidencial
        If tnivel_presidente = 4 Then
            Me.preco1.Text = "1"
            Me.preco2.Text = "0"
            Me.preco3.Text = "Si"
            Me.Nominavpre.Text = "0"
        Else
            '    Me.Nominavpre.Text = "1"
            Me.preco1.Text = "0"
            Me.preco3.Text = "No"

        End If
        If tnivel_presidente_in > 0 Then
            Me.preco1.Text = "0"
            Me.preco2.Text = "1"
            Me.preco3.Text = "No"
            Me.Nominavpre.Text = "0"
        Else
            Me.Nominavpre.Text = "1"
            '    Me.preco2.Text = "0"
            '    Me.preco3.Text = "No"
        End If
        'manejo de nomina vacia presidente 
        If Nomina_vacias_presidente < 4 Then
            Me.Nominavpre.Text = "1"
            Me.preco1.Text = "0"
            Me.preco2.Text = "0"
        Else
            Me.Nominavpre.Text = "0"
        End If
        'fin del codigo de validacion de las planillas a nivel presidencial


        'If tnivel_diputadosPARP = 20 Then
        '    Me.parla1.Text = "1"
        '    Me.parla2.Text = "0"
        '    Me.parla3.Text = "Si"
        'Else
        '    Me.parla1.Text = "0"
        '    Me.parla2.Text = "1"
        '    Me.parla3.Text = "No"
        'End If
        'CODIGO PARA LA VALIDACION DE NOMINAS A NIVEL PARLACEN PROPIETARIOS
        If tnivel_diputadosPARP = 20 Then
            Me.parla1.Text = "1"
            Me.parla2.Text = "0"
            Me.parla3.Text = "Si"
            Me.NominaParlacen.Text = "0"
        Else
            Me.parla1.Text = "0"
            Me.parla3.Text = "No"
        End If
        If tnivel_diputadosPARP_in > 0 Then
            Me.parla1.Text = "0"
            Me.parla2.Text = "1"
            Me.parla3.Text = "No"
            Me.NominaParlacen.Text = "0"
        Else
            Me.NominaParlacen.Text = "1"
        End If
        If Nomina_vacias_parlacenp < 20 Then
            Me.NominaParlacen.Text = "1"
            Me.parla1.Text = "0"
            Me.parla2.Text = "0"
        Else
            Me.NominaParlacen.Text = "0"
        End If

        'FIN DEL CODIGO DE VALIDACION DE NOMINA PARLACEN PROPIETARIOS

        'If tnivel_diputadosPARS = 20 Then
        '    Me.parlas1.Text = "1"
        '    Me.parlas2.Text = "0"
        '    Me.parlas3.Text = "Si"
        'Else
        '    Me.parlas1.Text = "0"
        '    Me.parlas2.Text = "1"
        '    Me.parlas3.Text = "No"
        'End If
        'CODIGO PARA LA VALIDACION DE NOMINAS A NIVEL PARLACEN SUPLENTES
        If tnivel_diputadosPARS = 20 Then
            Me.parlas1.Text = "1"
            Me.parlas2.Text = "0"
            Me.parlas3.Text = "Si"
            Me.NominaParlacens.Text = "0"
        Else
            Me.parlas1.Text = "0"
            Me.parlas3.Text = "No"
        End If
        If tnivel_diputadosPARS_in > 0 Then
            Me.parlas1.Text = "0"
            Me.parlas2.Text = "1"
            Me.parlas3.Text = "No"
            Me.NominaParlacens.Text = "0"
        Else
            Me.NominaParlacens.Text = "1"
        End If
        If Nomina_vacias_parlacens < 20 Then
            Me.NominaParlacens.Text = "1"
            Me.parlas1.Text = "0"
            Me.parlas2.Text = "0"
        Else
            Me.NominaParlacens.Text = "0"
        End If

        'FIN DEL CODIGO DE VALIDACION DE NOMINA PARLACEN SUPLENTES

        'diputados congreso propietarios
        If tnivel_diputadoscnpc >= 10 Then
            Me.congre3.Text = "Si"
        Else
            Me.congre3.Text = "No"
        End If
        Nomina_vacias_CNP = 18 - tnivel_diputadoscnpc - tnivel_diputadoscnp.ToString
        Me.NominaCNDP.Text = Nomina_vacias_CNP.ToString


        'diputados congreso suplentes
        If tnivel_diputadoscnsc >= 10 Then
            Me.congres3.Text = "Si"
        Else
            Me.congres3.Text = "No"
        End If

        Nomina_vacias_CNPS = 18 - tnivel_diputadoscnsc.ToString - tnivel_diputadoscnsi.ToString
        Me.NominaCNDS.Text = Nomina_vacias_CNPS.ToString
        'corporacion municipal
        If tnivel_corporacionmunic >= 150 Then
            corpo3.Text = "Si"
        Else
            corpo3.Text = "No"
        End If

        Nomina_vacias_CMUNI = 298 - tnivel_corporacionmunic.ToString - tnivel_corporacionmunin.ToString
        Me.NominaCM.Text = Nomina_vacias_CMUNI.ToString
        'NOMINAS INCOMPLETAS
        'PRESIDENTE
        If NOMINA_INC_PRESIDENTE > 0 And NOMINA_INC_PRESIDENTE < 4 Then
            Nominavpre.Text = 1
            Nominavacia_1.Text = 0
        Else
            Nominavpre.Text = 0
        End If
        If NOMINA_INC_PRESIDENTE = 0 Then
            Nominavacia_1.Text = 1
        Else
            Nominavacia_1.Text = 0
        End If
        'PARLACEN PROPIETARIOS
        If NOMINA_INC_PARLACENPR > 0 And NOMINA_INC_PARLACENPR < 20 Then
            NominaParlacen.Text = 1
            Nominavacia_2.Text = 0
        Else
            NominaParlacen.Text = 0
        End If
        If NOMINA_INC_PARLACENPR = 0 Then
            Nominavacia_2.Text = 1
        Else
            Nominavacia_2.Text = 0
        End If
        'PARLACEN SUPLENTES
        If NOMINA_INC_PARLACENSU > 0 And NOMINA_INC_PARLACENSU < 20 Then
            NominaParlacens.Text = 1
            Nominavacia_3.Text = 0
        Else
            NominaParlacens.Text = 0
        End If
        If NOMINA_INC_PARLACENSU = 0 Then
            Nominavacia_3.Text = 1
        Else
            Nominavacia_3.Text = 0
        End If
        'CONGRESO NACIONAL PROPIETARIOS
        NominaCNDP.Text = NOMINA_INC_CONGRESOPR.ToString
        Nominavacia_4.Text = nomina_vac_congresopr.ToString
        'CONGRESO NACIONAL SUPLENTES
        NominaCNDS.Text = NOMINA_INC_CONGRESOSU.ToString
        Nominavacia_5.Text = NOMINA_VAC_CONGRESOSU.ToString
        'CORPORACION MUNICIPAL

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