Imports System
Imports System.Data.OracleClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Public Class REPORTE_ESTADISTICO_FIRMAS_MOVIMIENTO

    Private Sub REPORTE_ESTADISTICO_FIRMAS_MOVIMIENTO_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
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

    Private Sub REPORTE_ESTADISTICO_FIRMAS_MOVIMIENTO_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
        Dim oradb As String = Configuracion.verconfig
        Dim conn As New OracleConnection()
        Dim myCMD As New OracleCommand()

        Dim total_firmas_pre As String = 0
        Dim total_firmas_con As String = 0
        Dim total_firmas_inc As String = 0
        Dim porcentaje_consis As String = 0
        Dim porcentaje_incons As String = 0

        ''abrir conexion de la base de datos 
        conn.ConnectionString = oradb
        conn.Open()

        'total firmas Presentadas
        total_firmas_pre = COracle.ObtenerDatos("SELECT COUNT (1) TOTAL_FP FROM im_ciudadanos_respaldan ca,im_partidos_politicos pa,im_movimientos mov WHERE CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_FP")
        Total_firmas.Text = total_firmas_pre.ToString
        'total firmas consistentes 
        total_firmas_con = COracle.ObtenerDatos("SELECT COUNT (1) TOTAL_FP FROM im_ciudadanos_respaldan ca,im_partidos_politicos pa,im_movimientos mov WHERE CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.CONSISTENTE ='S' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_FP")
        firmas_consis.Text = total_firmas_con.ToString
        'total firmas inconsistentes
        total_firmas_inc = COracle.ObtenerDatos("SELECT COUNT (1) TOTAL_FP FROM im_ciudadanos_respaldan ca,im_partidos_politicos pa,im_movimientos mov WHERE CA.CODIGO_PARTIDO = PA.CODIGO_PARTIDO AND CA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND CA.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO and CA.CONSISTENTE ='N' and PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' and MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'", "TOTAL_FP")
        firmas_incon.Text = total_firmas_inc.ToString

        'calculo de porcentaje
        If total_firmas_pre > 0 And total_firmas_con > 0 Then
            porcentaje_consis = Math.Round((CInt(total_firmas_con) / CInt(total_firmas_pre) * 100), 2).ToString
            porcentaje_cons.Text = porcentaje_consis.ToString

        Else
            porcentaje_consis = 0
            porcentaje_cons.Text = "0"
        End If

        If total_firmas_pre > 0 And total_firmas_inc > 0 Then
            porcentaje_incons = Math.Round((CInt(total_firmas_inc) / CInt(total_firmas_pre) * 100), 2).ToString
            Porcentaje_inc.Text = porcentaje_incons.ToString
        Else
            porcentaje_incons = 0
            Porcentaje_inc.Text = "0"
        End If


        Me.GRAFICOTableAdapter.Fill(Me.GraficO_FIRMAS_ESTADISTICO1.GRAFICO, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(DS_LOG.IM_PARTIDOS_POLITICOS_imagen, NombrePartido.Value.ToString)
        Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(DS_LOG.IM_MOVIMIENTOS_imagen, NombreMovimiento.Value.ToString)
        usuario_1.Text = usuario
        PARTIDO.Text = NombrePartido.Value.ToString
        MOVIMIENTO.Text = NombreMovimiento.Value.ToString
    End Sub

    Private Sub REPORTE_ESTADISTICO_FIRMAS_MOVIMIENTO_ParametersRequestValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs) Handles Me.ParametersRequestValueChanged
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