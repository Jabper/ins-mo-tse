Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Public Class Reporte_de__FirmasDP

    Private Sub Reporte_de__FirmasDP_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        Dim dataset As New DS_REPORTE_DE_FDP_1
        Dim nombrem As String
        Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
        Dim nombrep As String = COracle.ObtenerDatos("select nombre from im_partidos_politicos where codigo_partido=" & idp, "nombre")
        Dim idmov As String = COracle.ObtenerDatos("select codigo_movimiento from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_MOVIMIENTO")

        If idmov = "" Then
        Else
            nombrem = COracle.ObtenerDatos("select NOMBRE_MOVIMIENTO from im_movimientos where codigo_movimiento =" & idmov & " and codigo_partido=" & idp, "NOMBRE_MOVIMIENTO")
        End If

        Using adapter As New DS_REPORTE_DE_FDP_1TableAdapters.IM_PARTIDOS_POLITICOSTableAdapter
            adapter.Fill(dataset.IM_PARTIDOS_POLITICOS)
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

        'CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALORES DEL MOVIMIENTO
        Using adapter1 As New DS_REPORTE_DE_FDP_1TableAdapters.IM_MOVIMIENTOSTableAdapter
            'adapter.Fill(dataset.IM_MOVIMIENTO)
            '-------------------------------------------------------------
            'ESTABLECIENDO VALORES PARA EL COMBO MOVIMIENTO
            If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "MOV" Or ActivarOpciones.PEstado = "TSE" Then

                adapter1.FillCod_partido(dataset.IM_MOVIMIENTOS, CType(idp, Integer))
                'Else
                '    Adapter1.Fill(dataset.IM_MOVIMIENTOS)
            End If
            '-------------------------------------------------------------
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NombreMovimiento" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_MOVIMIENTOS
                LookUpEdit.Properties.DisplayMember = "NOMBRE_MOVIMIENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NOMBRE_MOVIMIENTO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE_MOVIMIENTO", 0, "NOMBRE_MOVIMIENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
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


        'Using adapter As New DS_REPORTE_DE_FDPTableAdapters.IM_DEPARTAMENTOS_FDPTableAdapter
        '    adapter.Fill(dataset.IM_DEPARTAMENTOS_FDP)

        'End Using

        'For Each info In e.ParametersInformation
        '    If info.Parameter.Name = "NombreDepartamento" Then
        '        Dim LookUpEdit As New LookUpEdit()
        '        LookUpEdit.Properties.DataSource = dataset.IM_DEPARTAMENTOS_FDP
        '        LookUpEdit.Properties.DisplayMember = "NOMBRE DEPARTAMENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
        '        LookUpEdit.Properties.ValueMember = "NOMBRE DEPARTAMENTO"
        '        LookUpEdit.Properties.Columns.Add(New  _
        '            LookUpColumnInfo("NOMBRE DEPARTAMENTO", 0, "DEPARTAMENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
        '        info.Editor = LookUpEdit
        '    End If
        'Next

    End Sub

    Private Sub Reporte_de__FirmasDP_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
        'If Me.NombrePartido.Value = "TODOS" Then
        '    Me.IM_V_FIRMAS_DIVISION_POLITICAAdapter1.FillBy(Me.DS_REPORTE_DE_FDP1.IM_V_FIRMAS_DIVISION_POLITICA)
        'Else
        '    Me.IM_V_FIRMAS_DIVISION_POLITICAAdapter1.Fill(Me.DS_REPORTE_DE_FDP1.IM_V_FIRMAS_DIVISION_POLITICA, Me.NombrePartido.Value.ToString)
        'End If
        Me.IM_V_FIRMAS_DIVISION_POLITICATableAdapter.Fill(Me.DS_REPORTE_DE_FDP_11.IM_V_FIRMAS_DIVISION_POLITICA, Me.NombrePartido.Value.ToString)
    End Sub
End Class