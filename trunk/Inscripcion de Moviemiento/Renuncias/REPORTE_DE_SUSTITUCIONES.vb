Imports System.Data.OracleClient
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Public Class REPORTE_DE_SUSTITUCIONES

    Private Sub REPORTE_DE_SUSTITUCIONES_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestBeforeShow
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
            If info.Parameter.Name = "Partido" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_PARTIDOS_POLITICOS
                LookUpEdit.Properties.DisplayMember = "NOMBRE PARTIDO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "CODIGO_PARTIDO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE PARTIDO", 0, "NOMBRE PARTIDO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 

                '-------------------------------------------------------------
                'BLOQUEAR SELECCION DEL COMBO PARA USUARIOS DE PARTIDO Y MOVIMIENTO
                'If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "MOV" Then
                '    LookUpEdit.Enabled = False
                'End If
                '-------------------------------------------------------------
                info.Editor = LookUpEdit
            End If
        Next

        '-------------------------------------------------------------
        '       ESTABLECER EL PARTIDO DE ACUERDO AL USUARIO
        'If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "MOV" Then

        '    Partido.Value = nombrep
        'End If
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
            If info.Parameter.Name = "Movimiento" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = dataset.IM_MOVIMIENTOS
                LookUpEdit.Properties.DisplayMember = "NOMBRE MOVIMIENTO" 'COLOCA EL CAMPO SELECCIONADO EN EL TEXTBOX
                LookUpEdit.Properties.ValueMember = "CODIGO_MOVIMIENTO"
                LookUpEdit.Properties.Columns.Add(New  _
                    LookUpColumnInfo("NOMBRE MOVIMIENTO", 0, "NOMBRE MOVIMIENTO")) 'AGREGA EL NOMBRE DEL PARTIDO A LA LISTA 
                'BLOQUEAR COMBO DE ACUERDO AL USUARIO
                'If ActivarOpciones.PEstado = "MOV" Then
                '    LookUpEdit.Enabled = False
                'End If
                info.Editor = LookUpEdit
            End If

        Next

        ' ESTABLECER MOVIMIENTO DE ACUERDO AL USUARIO
        'If ActivarOpciones.PEstado = "PDO" Or ActivarOpciones.PEstado = "MOV" Then

        '    Movimiento.Value = nombrem
        'End If
    End Sub

    Private Sub REPORTE_DE_SUSTITUCIONES_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles Me.ParametersRequestSubmit
        Me.IM_PARTIDOS_POLITICOS_imagenTableAdapter.Fill(Me.DS_LOG.IM_PARTIDOS_POLITICOS_imagen, e.ParametersInformation(0).Editor.Text)
        Me.IM_MOVIMIENTOS_imagenTableAdapter.Fill(Me.DS_LOG.IM_MOVIMIENTOS_imagen, e.ParametersInformation(1).Editor.Text)
        Me.txtmovimiento.Text = e.ParametersInformation(1).Editor.Text
        Me.txtpartido.Text = e.ParametersInformation(0).Editor.Text
        Me.txtusuario.Text = NombreUsuario
    End Sub

    Private Sub REPORTE_DE_SUSTITUCIONES_ParametersRequestValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs) Handles Me.ParametersRequestValueChanged
        Dim dataset As New DS_REPORTE_DE_PNEM_1

        'If ActivarOpciones.PEstado = "TSE" Then
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

        'End If
    End Sub
End Class