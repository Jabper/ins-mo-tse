Imports System.Data.OracleClient
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Public Class REPORTE_DE_CUMPLIMIENTO_1

    Private Sub REPORTE_DE_CUMPLIMIENTO_1_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        Dim dataset As New DS_REPORTE_DE_DP_1
        Dim nombrem As String
        Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
        Dim nombrep As String = COracle.ObtenerDatos("select nombre from im_partidos_politicos where codigo_partido=" & idp, "nombre")
        Dim idmov As String = COracle.ObtenerDatos("select codigo_movimiento from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_MOVIMIENTO")
        If idmov = "" Then
        Else
            nombrem = COracle.ObtenerDatos("select NOMBRE_MOVIMIENTO from im_movimientos where codigo_movimiento =" & idmov & " and codigo_partido=" & idp, "NOMBRE_MOVIMIENTO")
        End If


        Using Adapter As New DS_REPORTE_DE_DP_1TableAdapters.IM_PARTIDOS_POLITICOSTableAdapter

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

        ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALOR DE LOS MOVIMIENTOS
        Using Adapter1 As New DS_REPORTE_DE_DP_1TableAdapters.IM_MOVIMIENTOSTableAdapter
            '-------------------------------------------------------------
            'ESTABLECIENDO VALORES PARA EL COMBO MOVIMIENTO
            If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "MOV" Or ActivarOpciones.PEstado = "TSE" Then

                Adapter1.FillCod_Partido(dataset.IM_MOVIMIENTOS, CType(idp, Integer))
                'Else
                '    Adapter1.Fill(dataset.IM_MOVIMIENTOS)
            End If

            'Adapter1.Fill(dataset.IM_MOVIMIENTOS)
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

        ' ESTABLECER MOVIMIENTO DE ACUERDO AL USUARIO
        If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "MOV" Then

            NombreMovimiento.Value = nombrem
        End If
    End Sub

    Private Sub REPORTE_DE_CUMPLIMIENTO_1_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
        Dim oradb As String = Configuracion.verconfig
        Dim conn As New OracleConnection()
        Dim myCMD As New OracleCommand()

        Dim cd_presidencial As String = 0
        Dim fisico_presidencial As String = 0
        Dim incon_presidencial As String = 0

        Dim incon_parlacenp As String = 0
        Dim cd_parlacenp As String = 0
        Dim fisico_parlacenp As String = 0

        Dim incon_parlacens As String = 0
        Dim cd_parlacens As String = 0
        Dim fisico_parlacens As String = 0

        Dim incon_congrep As String = 0
        Dim cd_congrep As String = 0
        Dim fisico_congrep As String = 0
        Dim congresop_completo As String = 0
        Dim congresop_incompleto As String = 0


        Dim incon_congres As String = 0
        Dim cd_congres As String = 0
        Dim fisico_congres As String = 0
        Dim congresos_completo As String = 0
        Dim congresos_incompleto As String = 0

        Dim incon_muni As String = 0
        Dim cd_muni As String = 0
        Dim fisico_muni As String = 0
        Dim muni_completo As String = 0
        Dim muni_incompleto As String = 0

        ''abrir conexion de la base de datos 
        conn.ConnectionString = oradb
        conn.Open()


        'ANALISIS PRESIDENCIAL

        cd_presidencial = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (1,9) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        'CD_1.Text = cd_presidencial.ToString
        If cd_presidencial > 0 Then
            CD_1.Text = "1" ' "SI" '"1"
        Else
            CD_1.Text = "0" '"NO" '"0"
        End If

        incon_presidencial = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (1,9) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO  and CA.VALIDADO = 'S' and CA.ESTADO = 'I' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")

        fisico_presidencial = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (1,9) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO  and CA.VALIDADO = 'S' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        If fisico_presidencial > 0 Then
            Fisico_1.Text = "SI" '"1"
        Else
            Fisico_1.Text = "NO" '"0"
        End If

        'COINCIDE
        If cd_presidencial = fisico_presidencial Then
            Coin_1.Text = "SI"
        Else
            Coin_1.Text = "NO"
        End If
        'COMPLETA
        If fisico_presidencial = 4 Then
            comp_1.Text = "SI"
        Else
            comp_1.Text = "NO"
        End If

        'INCONSISTENTE 
        'If fisico_presidencial < 4 Then
        '    incons_1.Text = "NO"
        'ElseIf cd_presidencial < 4 Then
        '    incons_1.Text = "NO"

        'End If

        If fisico_presidencial = 4 And (fisico_presidencial - incon_presidencial) < 4 Then
            incons_1.Text = "SI" '"SI"
        Else
            incons_1.Text = "NO"
        End If
        'INCOMPLETA 
        If fisico_presidencial < 4 Then
            incom_1.Text = "SI" 'fisico_presidencial.ToString  '"SI"
        ElseIf cd_presidencial < 4 Then
            incom_1.Text = "SI" 'cd_presidencial.ToString '"SI"
        Else
            incom_1.Text = "NO"
        End If
        'PRESENTO
        If fisico_presidencial > 0 Then
            Prese_1.Text = "SI"
        ElseIf cd_presidencial > 0 Then
            Prese_1.Text = "SI"
        End If

        '*******************************************************************************************
        'ANALISIS DPCP 
        cd_parlacenp = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (2) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        If cd_parlacenp > 0 Then
            CD_2.Text = "SI" '"1"
        Else
            CD_2.Text = "NO" '"0"
        End If
        incon_parlacenp = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (2) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO = 'S' and CA.ESTADO = 'I' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")

        fisico_parlacenp = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (2) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO = 'S' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        If fisico_parlacenp > 0 Then
            Fisico_2.Text = "SI" '"1"
        Else
            Fisico_2.Text = "NO" ' "0"
        End If

        'COINCIDE
        If cd_parlacenp = fisico_parlacenp Then
            Coin_2.Text = "SI"
        Else
            Coin_2.Text = "NO"
        End If

        'COMPLETA
        If fisico_parlacenp = 20 Then
            comp_2.Text = "SI"
        Else
            comp_2.Text = "NO"
        End If

        'INCONSISTENTE 
        'If fisico_parlacenp < 20 Then
        '    incons_2.Text = "NO"
        'ElseIf cd_parlacenp < 20 Then
        '    incons_2.Text = "NO"
        'End If

        If fisico_parlacenp = 20 And (fisico_parlacenp - incon_parlacenp) < 20 Then
            incons_2.Text = "SI"
        Else
            incons_2.Text = "NO"
        End If

        'INCOMPLETA 
        If fisico_parlacenp < 20 Then
            incom_2.Text = "SI"
        ElseIf cd_parlacenp < 20 Then
            incom_2.Text = "SI"
        Else
            incom_2.Text = "NO"
        End If
        'PRESENTO
        If fisico_parlacenp > 0 Then
            Prese_2.Text = "SI"
        ElseIf cd_parlacenp > 0 Then
            Prese_2.Text = "SI"
        End If
        '**************************************************************************************
        'ANALISIS DPCS 
        cd_parlacens = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (3) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        If cd_parlacens > 0 Then
            CD_3.Text = "SI" '"1"
        Else
            CD_3.Text = "NO" '"0"
        End If
        incon_parlacens = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (3) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO = 'S' and CA.ESTADO = 'I' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")

        fisico_parlacens = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (3) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO = 'S' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        If fisico_parlacens > 0 Then
            Fisico_3.Text = "SI" '"1"
        Else
            Fisico_3.Text = "NO" '"0"
        End If

        'COINCIDE
        If cd_parlacens = fisico_parlacens Then
            Coin_3.Text = "SI"
        Else
            Coin_3.Text = "NO"
        End If

        'COMPLETA
        If fisico_parlacens = 20 Then
            comp_3.Text = "SI"
        Else
            comp_3.Text = "NO"
        End If

        'INCONSISTENTE 

        'If fisico_parlacens < 20 Then
        '    incons_3.Text = "NO"
        'ElseIf cd_parlacens < 20 Then
        '    incons_3.Text = "NO"
        'End If

        If fisico_parlacens = 20 And (fisico_parlacens - incon_parlacens) < 20 Then
            incons_3.Text = "SI"
        Else
            incons_3.Text = "NO"
        End If

        'INCOMPLETA 
        If fisico_parlacens < 20 Then
            incom_3.Text = "SI"
        ElseIf cd_parlacens < 20 Then
            incom_3.Text = "SI"
        Else
            incom_3.Text = "NO"
        End If
        'PRESENTO
        If fisico_parlacens > 0 Then
            Prese_3.Text = "SI"
        ElseIf cd_parlacens > 0 Then
            Prese_3.Text = "SI"
        End If

        '************************************************************************************
        'ANALISIS CNP 
        cd_congrep = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPP A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' and A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        'COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        If cd_congrep > 0 Then
            CD_4.Text = "SI" '"1"
        Else
            CD_4.Text = "NO"
        End If
        incon_congrep = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO = 'S' and CA.ESTADO = 'I' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")

        fisico_congrep = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPP_F A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' and A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        'COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO = 'S' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        If fisico_congrep > 0 Then
            Fisico_4.Text = "SI"  '"1"
        Else
            Fisico_4.Text = "NO"
        End If

        'COINCIDE
        If cd_congrep = fisico_congrep Then
            Coin_4.Text = "SI"
        Else
            Coin_4.Text = "NO"
        End If

        'COMPLETA
        congresop_completo = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPP_F A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")

        If congresop_completo >= 10 Then
            comp_4.Text = "SI"
        Else
            comp_4.Text = "NO"
        End If

        'INCONSISTENTE 
        congresop_incompleto = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPP_C A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")

        'If fisico_congrep < 10 Then
        '    incons_4.Text = "NO"
        'ElseIf cd_congrep > 10 Then
        '    incons_4.Text = "NO"
        'End If

        If congresop_completo >= 10 And (congresop_completo - congresop_incompleto) <= 10 Then 'And incon_congrep > 0 Then
            incons_4.Text = "SI"
        Else
            incons_4.Text = "NO"
        End If

        'INCOMPLETA 
        congresop_completo = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPP_F A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")

        If fisico_congrep <= 10 Then
            incom_4.Text = "SI"
        ElseIf cd_congrep <= 10 Then
            incom_4.Text = "SI"
        Else
            incom_4.Text = "NO"
        End If
        'PRESENTO
        If fisico_congrep > 0 Then
            Prese_4.Text = "SI"
        ElseIf cd_parlacens > 0 Then
            Prese_4.Text = "SI"
        End If

        '********************************************************************************************************
        'ANALISIS CNS 
        cd_congres = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPS A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' and A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        'COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        If cd_congres > 0 Then
            CD_5.Text = "SI" '"1"
        Else
            CD_5.Text = "NO"
        End If
        'incon_congres = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO = 'S' and CA.ESTADO = 'I' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")

        fisico_congres = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPS_F A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' and A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")
        'COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO = 'S' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        If fisico_congres > 0 Then
            Fisico_5.Text = "SI"  '"1"
        Else
            Fisico_5.Text = "NO"
        End If

        'COINCIDE
        If cd_congres = fisico_congres Then
            Coin_5.Text = "SI"
        Else
            Coin_5.Text = "NO"
        End If

        'COMPLETA
        congresos_completo = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPS_F A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' and A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")

        If congresos_completo >= 10 Then
            comp_5.Text = "SI"
        Else
            comp_5.Text = "NO"
        End If

        'INCONSISTENTE 
        congresop_incompleto = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPS_C A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")

        'If fisico_congrep < 10 Then
        '    incons_4.Text = "NO"
        'ElseIf cd_congrep > 10 Then
        '    incons_4.Text = "NO"
        'End If

        If congresos_completo >= 10 And (congresos_completo - congresos_incompleto) <= 10 Then 'And incon_congrep > 0 Then
            incons_5.Text = "SI"
        Else
            incons_5.Text = "NO"
        End If

        'INCOMPLETA 
        congresos_completo = COracle.ObtenerDatos("SELECT  COUNT (1)TOTAL_DPN FROM IM_CD_COMPLETAS_DPS_F A ,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.cargo_actual,A.CANTIDAD_DIPUTADOS,'S','N') ='N' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_DPN")

        If fisico_congres <= 10 Then
            incom_5.Text = "SI"
        ElseIf cd_congres <= 10 Then
            incom_5.Text = "SI"
        Else
            incom_5.Text = "NO"
        End If
        'PRESENTO
        If fisico_congres > 0 Then
            Prese_5.Text = "SI"
        ElseIf cd_parlacens > 0 Then
            Prese_5.Text = "SI"
        End If
        '***************************************************************************************************
        'corporacion muni

        cd_muni = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM im_cd_completas_dpco A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        'COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        If cd_muni > 0 Then
            CD_6.Text = "SI" '"1"
        Else
            CD_6.Text = "NO"
        End If

        'incon_congrep = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO = 'S' and CA.ESTADO = 'I' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")

        fisico_muni = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM im_cd_completas_dpco_f A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        'COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO = 'S' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        If fisico_muni > 0 Then
            Fisico_6.Text = "SI"  '"1"
        Else
            Fisico_6.Text = "NO"
        End If

        'COINCIDE
        If cd_muni = fisico_muni Then
            Coin_6.Text = "SI"
        Else
            Coin_6.Text = "NO"
        End If

        'COMPLETA
        muni_completo = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM im_cd_completas_dpco_f A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")

        If muni_completo >= 150 Then
            comp_6.Text = "SI"
        Else
            comp_6.Text = "NO"
        End If

        'INCONSISTENTE 
        muni_incompleto = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM im_cd_completa_dpco_INC A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")

        'If fisico_congrep < 10 Then
        '    incons_4.Text = "NO"
        'ElseIf cd_congrep > 10 Then
        '    incons_4.Text = "NO"
        'End If

        If muni_completo >= 150 And (muni_completo - muni_incompleto) <= 150 Then 'And incon_congrep > 0 Then
            incons_6.Text = "SI"
        Else
            incons_6.Text = "NO"
        End If

        'INCOMPLETA 
        muni_completo = COracle.ObtenerDatos("SELECT COUNT(1)TOTAL_CM FROM im_cd_completas_dpco_f A,  im_partidos_politicos pa, im_movimientos mov WHERE DECODE(A.CARGO_ACTUAL,A.TOTALR,'S','N') ='S' AND A.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND  A.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND  A.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")

        If muni_completo <= 150 Then
            incom_6.Text = "SI"
        ElseIf muni_completo <= 150 Then
            incom_6.Text = "SI"
        Else
            incom_6.Text = "NO"
        End If
        'PRESENTO
        If fisico_muni > 0 Then
            Prese_6.Text = "SI"
        ElseIf fisico_muni > 0 Then
            Prese_6.Text = "SI"
        End If



        '********************************************************************************************************
        Me.partido.Text = Me.NombrePartido.Value.ToString
        Me.movimiento.Text = Me.NombreMovimiento.Value.ToString

        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(DS_LOG.IM_PARTIDOS_POLITICOS_imagen, NombrePartido.Value.ToString)
        Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(DS_LOG.IM_MOVIMIENTOS_imagen, NombreMovimiento.Value.ToString)

        nombre.Text = NombreUsuario.ToString

    End Sub

    Private Sub REPORTE_DE_CUMPLIMIENTO_1_ParametersRequestValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs) Handles Me.ParametersRequestValueChanged
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