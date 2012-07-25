﻿Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Public Class Reporte_de_Planilla_PNEMO

    Private Sub Reporte_de_Planilla_PNEMO_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
        Dim dataset As New DS_REPORTE_DE_PNEM_1
        Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
        Dim nombrep As String = COracle.ObtenerDatos("select nombre from im_partidos_politicos where codigo_partido=" & idp, "nombre")
        Dim idmov As String = COracle.ObtenerDatos("select codigo_movimiento from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_MOVIMIENTO")
        Dim nombrem As String = COracle.ObtenerDatos("select NOMBRE_MOVIMIENTO from im_movimientos where codigo_movimiento =" & idmov & " and codigo_partido=" & idp, "NOMBRE_MOVIMIENTO")

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




        ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALORES DEL NIVEL ELECTIVO
        Using Adapter2 As New DS_REPORTE_DE_PNEM_1TableAdapters.IM_NIVEL_ELECTIVOTableAdapter
            Adapter2.Fill(dataset.IM_NIVEL_ELECTIVO)
        End Using

        For Each info In e.ParametersInformation
            If info.Parameter.Name = "NivelElectivo" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_NIVEL_ELECTIVO
                LookUpEdit.Properties.DisplayMember = "NIVEL ELECTIVO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "NIVEL ELECTIVO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NIVEL ELECTIVO", 0, "NIVEL ELECTIVO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                info.Editor = LookUpEdit
            End If
        Next
    End Sub

    Private Sub Reporte_de_Planilla_PNEMO_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(Me.DS_LOG.IM_PARTIDOS_POLITICOS_imagen, NombrePartido.Value.ToString)
        Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(Me.DS_LOG.IM_MOVIMIENTOS_imagen, NombreMovimiento.Value.ToString)

    End Sub
    
    Private Sub Reporte_de_Planilla_PNEMO_ParametersRequestValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs) Handles Me.ParametersRequestValueChanged
        Dim dataset As New DS_REPORTE_DE_PNEM_1

        If ActivarOpciones.PEstado = "TSE" Then
            'If NombrePartido..ToString <> "" Or NombrePartido.Value.ToString <> Nothing Then

            ''CODIGO NECESARIO PARA AGREGAR LA LISTA DE VALOR DE LOS MOVIMIENTOS
            Using Adapter1 As New DS_REPORTE_DE_PNEM_1TableAdapters.IM_MOVIMIENTOSTableAdapter
                NombreMovimiento.Dispose()

                Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
                'Dim nombrep As String = COracle.ObtenerDatos("select nombre from im_partidos_politicos where codigo_partido=" & idp, "nombre")
                'Dim idmov As String = COracle.ObtenerDatos("select codigo_movimiento from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_MOVIMIENTO")
                'Dim nombrem As String = COracle.ObtenerDatos("select NOMBRE_MOVIMIENTO from im_movimientos where codigo_movimiento =" & idmov & " and codigo_partido=" & idp, "NOMBRE_MOVIMIENTO")

                Adapter1.FillCodPartido(dataset.IM_MOVIMIENTOS, CType(idp, Integer))
                'Else
                '    Adapter1.Fill(dataset.IM_MOVIMIENTOS)
                'End If

            End Using
            'e.ParametersInformation(0).Editor
            '(e.ParametersInformation(0).Editor).Properties.DataSource = dataset.IM_MOVIMIENTOS
            'For Each info In e.ParametersInformation
            '    If info.Parameter.Name = "NombreMovimiento" Then
            '        Dim LookUpEdit As New LookUpEdit()

            '        LookUpEdit.Properties.DataSource = dataset.IM_MOVIMIENTOS
            '        LookUpEdit.Properties.DisplayMember = "NOMBRE MOVIMIENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
            '        LookUpEdit.Properties.ValueMember = "NOMBRE MOVIMIENTO"
            '        LookUpEdit.Properties.Columns.Add(New  _
            '            LookUpColumnInfo("NOMBRE MOVIMIENTO", 0, "NOMBRE MOVIMIENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
            '        If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "MOV" Then
            '            LookUpEdit.Enabled = False
            '        End If
            '        info.Editor = LookUpEdit
            '    End If
            'Next
        End If

       

    End Sub
End Class