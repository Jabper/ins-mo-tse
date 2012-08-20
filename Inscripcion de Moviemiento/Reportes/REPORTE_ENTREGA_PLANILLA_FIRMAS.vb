Imports System.Data.OracleClient
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Public Class REPORTE_ENTREGA_PLANILLA_FIRMAS

    Private Sub REPORTE_ENTREGA_PLANILLA_FIRMAS_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
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

    Private Sub REPORTE_ENTREGA_PLANILLA_FIRMAS_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
        Dim oradb As String = Configuracion.verconfig
        Dim conn As New OracleConnection()
        Dim myCMD As New OracleCommand()
        ''variables de muestra de datos
        Dim cantidad_candidatos As String = 0
        Dim cantidad_firmas As String = 0
        Dim firmas_agregadas As String = 0
        Dim firmas_actualizadas As String = 0
        Dim firmas_digital As String = 0

        ''nivel presidencial
        Dim presidente_presentado As String = 0
        Dim presidente_modificado As String = 0
        Dim presidente_digital As String = 0
        Dim presidente_agregado As String = 0
        ''nivel designados 
        Dim designado_presentado As String = 0
        Dim designado_modificado As String = 0
        Dim designado_digital As String = 0
        Dim designado_agregado As String = 0
        ''nivel parlacenp
        Dim parlacenp_presentado As String = 0
        Dim parlacenp_modificado As String = 0
        Dim parlacenp_digital As String = 0
        Dim parlacenp_agregado As String = 0
        ''nivel parlacen suplente
        Dim parlacens_presentado As String = 0
        Dim parlacens_modificado As String = 0
        Dim parlacens_digital As String = 0
        Dim parlacens_agregado As String = 0
        ''nivel congreso propietario
        Dim congresop_presentado As String = 0
        Dim congresop_modificado As String = 0
        Dim congresop_digital As String = 0
        Dim congresop_agregado As String = 0
        ''nivel congreso suplente
        Dim congresos_presentado As String = 0
        Dim congresos_modificado As String = 0
        Dim congresos_digital As String = 0
        Dim congresos_agregado As String = 0
        ''nivel alcalde
        Dim alcalde_presentado As String = 0
        Dim alcalde_modificado As String = 0
        Dim alcalde_digital As String = 0
        Dim alcalde_agregado As String = 0
        ''nivel vice alcalde
        Dim vicealcalde_presentado As String = 0
        Dim vicealcalde_modificado As String = 0
        Dim vicealcalde_digital As String = 0
        Dim vicealcalde_agregado As String = 0
        ''nivel regidores
        Dim regidor_presentado As String = 0
        Dim regidor_modificado As String = 0
        Dim regidor_digital As String = 0
        Dim regidor_agregado As String = 0
        ''asignacion de valores de partido y movimiento
        Me.partido.Text = Me.NombrePartido.Value.ToString
        Me.movimiento.Text = Me.NombreMovimiento.Value.ToString

        ''abrir conexion de la base de datos 
        conn.ConnectionString = oradb
        conn.Open()

        ''consultas nivel general
        Me.XrLabel20.Text = "1"
        Me.XrLabel21.Text = "3"
        Me.XrLabel22.Text = "20"
        Me.XrLabel23.Text = "20"
        Me.XrLabel24.Text = "128"
        Me.XrLabel25.Text = "128"
        Me.XrLabel26.Text = "298"
        Me.XrLabel27.Text = "298"
        Me.XrLabel28.Text = "2092"

        cantidad_candidatos = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA') and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.candidatospre.Text = cantidad_candidatos.ToString
        cantidad_firmas = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_ciudadanos_respaldan ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA') and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.firmaspre.Text = cantidad_firmas.ToString
        ''firmas agregadas 
        firmas_agregadas = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_ciudadanos_respaldan ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR not in ('TSE','RPADILLA') and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.firmasagre.Text = firmas_agregadas.ToString
        ''firmas actualizadas 
        firmas_actualizadas = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_ciudadanos_respaldan ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA') and CA.MODIFICADO_POR is not null and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.firmasact.Text = firmas_actualizadas.ToString
        ''firmas digital
        firmas_digital = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_ciudadanos_respaldan ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA') and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and ca.validado is null and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.firmasdigital.Text = firmas_digital.ToString
        '*************************************************************************
        ''consultas nivel presidencial
        ''candidatos presentados
        presidente_presentado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (1) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PRESIDENTE.Text = presidente_presentado.ToString
        ''candidatos modificados
        presidente_modificado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (1) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.MODIFICADO_POR is not null and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PRESIDENTE1.Text = presidente_modificado.ToString
        ''candidatos presentados en digital
        presidente_digital = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (1) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PRESIDENTE2.Text = presidente_digital.ToString
        '' candidato agregado
        presidente_agregado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR not in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (1) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PRESIDENTE3.Text = presidente_agregado



        ''************************************************
        ''consultas nivel designados
        ''candidatos presentados 
        designado_presentado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (9) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.DESIGNADO.Text = designado_presentado.ToString
        ''candidatos modificados
        designado_modificado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (9) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.MODIFICADO_POR is not null and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.DESIGNADO1.Text = designado_modificado.ToString
        ''candidatos presentados en digital
        designado_digital = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (9) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.DESIGNADO2.Text = designado_digital.ToString
        'candidato agregado
        designado_agregado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR not in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (9) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO  and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.DESIGNADO3.Text = designado_agregado.ToString

        '**************************************************

        ''consultas nivel parlacen propietarios
        ''candidatos presentados 
        parlacenp_presentado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (2) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PARLACENP.Text = parlacenp_presentado.ToString
        ''candidatos modificados
        parlacenp_modificado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (2) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.MODIFICADO_POR is not null and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PARLACENP1.Text = parlacenp_modificado.ToString
        ''candidatos presentados en digital
        parlacenp_digital = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (2) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PARLACENP2.Text = parlacenp_digital.ToString
        'candidato agregado
        parlacenp_agregado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR not in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (2) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PARLACENP3.Text = parlacenp_agregado.ToString
        '***************************************************

        ''consultas nivel parlacen suplentes
        ''candidatos presentados
        parlacens_presentado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (3) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PARLACENS.Text = parlacens_presentado.ToString
        ''candidatos modificados
        parlacens_modificado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (3) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.MODIFICADO_POR is not null and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PARLACENS1.Text = parlacens_modificado.ToString
        ''candidatos presentados en digital
        parlacens_digital = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (3) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PARLACENS2.Text = parlacens_digital.ToString
        'candidato agregado
        parlacens_agregado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR not in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (3) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.PARLACENS3.Text = parlacens_agregado.ToString
        '***************************************************

        ''consultas nivel congreso propietarios
        ''candidatos presentados
        congresop_presentado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.CONGRESOP.Text = congresop_presentado.ToString
        ''candidatos modificados
        congresop_modificado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.MODIFICADO_POR is not null and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.CONGRESOP1.Text = congresop_modificado.ToString
        ''candidatos presentados en digital
        congresop_digital = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.CONGRESOP2.Text = congresop_digital.ToString
        'cadidato agregado
        congresop_agregado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR not in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (4) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.CONGRESOP3.Text = congresop_agregado.ToString
        '****************************************************

        ''consultas nivel congreso suplentes
        ''candidatos presentados 
        congresos_presentado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (5) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.CONGRESOS.Text = congresos_presentado.ToString
        ''candidatos modificados
        congresos_modificado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (5) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.MODIFICADO_POR is not null and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.CONGRESOS1.Text = congresos_modificado.ToString
        ''candidatos presentados en digital
        congresos_digital = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (5) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.CONGRESOS2.Text = congresos_digital.ToString
        ''candidato agregado
        congresos_agregado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR not in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (5) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.CONGRESOS3.Text = congresos_agregado.ToString
        '****************************************************

        ''consultas nivel alcaldes
        ''candidatos presentados
        alcalde_presentado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (6) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.ALCALDE.Text = alcalde_presentado.ToString
        ''candidatos modificados
        alcalde_modificado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (6) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.MODIFICADO_POR is not null and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.ALCALDE1.Text = alcalde_modificado.ToString
        ''candidatos presentados en digital
        alcalde_digital = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (6) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.ALCALDE2.Text = alcalde_digital.ToString
        ''candidato agregado
        alcalde_agregado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR not in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (6) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.ALCALDE3.Text = alcalde_agregado.ToString
        '*****************************************************

        ''consultas nivel vicealcaldes
        ''candidatos presentados 
        vicealcalde_presentado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (7) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.VICE.Text = vicealcalde_presentado.ToString
        ''candidatos modificados
        vicealcalde_modificado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (7) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.MODIFICADO_POR is not null and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.VICE2.Text = vicealcalde_modificado.ToString
        ''candidatos presentados en digital
        vicealcalde_digital = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (7) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.VICE3.Text = vicealcalde_digital.ToString
        ''candidato agregado
        vicealcalde_agregado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR not in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (7) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.VICE3ADD.Text = vicealcalde_agregado.ToString
        '*****************************************************

        ''consultas nivel regidores
        ''candidatos presentados 
        regidor_presentado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (8) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.REGIDOR.Text = regidor_presentado.ToString
        ''candidatos modificados
        regidor_modificado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (8) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.MODIFICADO_POR is not null and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.REGIDOR1.Text = regidor_modificado.ToString
        ''candidatos presentados en digital
        regidor_digital = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (8) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.REGIDOR2.Text = regidor_digital.ToString
        ''candidato agregado
        regidor_agregado = COracle.ObtenerDatos("select count(1)TOTAL_CM from im_candidatos ca, im_partidos_politicos pa, im_movimientos mov where CA.ADICIONADO_POR not in ('TSE','RPADILLA')and CA.CODIGO_CARGO_ELECTIVO in (8) and CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO and CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO and CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.VALIDADO IS NULL and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_CM")
        Me.REGIDOR3.Text = regidor_agregado.ToString

        '*****************************************************
        conn.Close()

        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(DS_LOG.IM_PARTIDOS_POLITICOS_imagen, NombrePartido.Value.ToString)
        Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(DS_LOG.IM_MOVIMIENTOS_imagen, NombreMovimiento.Value.ToString)





    End Sub

    Private Sub REPORTE_ENTREGA_PLANILLA_FIRMAS_ParametersRequestValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs) Handles Me.ParametersRequestValueChanged
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

    Private Sub DESIGNADO_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles DESIGNADO.BeforePrint

    End Sub
End Class