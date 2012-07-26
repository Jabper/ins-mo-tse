Imports System
Imports System.Data.OracleClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Public Class Reporte_estadistico_general_ge

    Private Sub Reporte_estadistico_general_ge_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow

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


        'Dim dataset As New DS_REPORTE_DE_FI_1
        'Using Adapter As New DS_REPORTE_DE_FI_1TableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
        '    Adapter.Fill(dataset.IM_PARTIDOS_POLITICOS)
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NombrePartido" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_PARTIDOS_POLITICOS
        '        LookUpEdit.Properties.DisplayMember = "NOMBRE PARTIDO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "NOMBRE PARTIDO"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("NOMBRE PARTIDO", 0, "NOMBRE PARTIDO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next

        ' ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALOR DE LOS MOVIMIENTOS
        'Using Adapter1 As New DS_REPORTE_DE_FI_1TableAdapters.IM_MOVIMIENTOSTableAdapter
        '    Adapter1.Fill(dataset.IM_MOVIMIENTOS)
        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NombreMovimiento" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_MOVIMIENTOS
        '        LookUpEdit.Properties.DisplayMember = "NOMBRE MOVIMIENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "NOMBRE MOVIMIENTO"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("NOMBRE MOVIMIENTO", 0, "NOMBRE MOVIMIENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next
    End Sub

    Private Sub Reporte_estadistico_general_ge_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit

        'Dim oradb As String = Configuracion.verconfig
        'Dim conn As New OracleConnection()
        'Dim myCMD As New OracleCommand()
        'Dim tnivel_presidente As String = 0
        'Dim tnivel_diputadosPARP As String = 0
        'Dim tnivel_diputadoscongr As String = 0
        'Dim tnivel_corporacionmunic As String = 0
        'Dim total As String = 0

        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(DS_LOG.IM_PARTIDOS_POLITICOS_imagen, NombrePartido.Value.ToString)
        Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(DS_LOG.IM_MOVIMIENTOS_imagen, NombreMovimiento.Value.ToString)
        Me.DT_TOTALTableAdapter.Fill(DS_ESTADISTICO_GENERAL_GE1.DT_TOTAL, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.DT_PRESIDENCIALTableAdapter.Fill(DS_ESTADISTICO_GENERAL_GE1.DT_PRESIDENCIAL, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.DT_PARLACENTableAdapter.Fill(DS_ESTADISTICO_GENERAL_GE1.DT_PARLACEN, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.DT_CONGRESOTableAdapter.Fill(DS_ESTADISTICO_GENERAL_GE1.DT_CONGRESO, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)
        Me.DT_CORPORACIONTableAdapter.Fill(DS_ESTADISTICO_GENERAL_GE1.DT_CORPORACION, Me.NombrePartido.Value.ToString, Me.NombreMovimiento.Value.ToString)

        'conn.ConnectionString = oradb
        'conn.Open()

        'total = COracle.ObtenerDatos("SELECT COUNT(ic.identidad)TOTAL FROM IM_CANDIDATOS ic,IM_PADRON_ELECTORAL IP,im_partidos_politicos pa,IM_MOVIMIENTOS mov WHERE IC.IDENTIDAD = IP.NUMERO_IDENTIDAD)AND (IP.SEXO = 2 AND IC.CODIGO_PARTIDO = PA.CODIGO_PARTIDO)AND PA.CODIGO_PARTIDO = MOV.CODIGO_PARTIDO AND IC.CODIGO_MOVIMIENTO = MOV.CODIGO_MOVIMIENTO AND PA.NOMBRE ='" & Me.NombrePartido.Value.ToString & "' AND MOV.NOMBRE_MOVIMIENTO ='" & Me.NombreMovimiento.Value.ToString & "'GROUP BY PA.NOMBRE , MOV.NOMBRE_MOVIMIENTO '", "TOTAL")



        'conn.Close()

        'Me.NPRE.Text = total.ToString

    End Sub
End Class