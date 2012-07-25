Public Class ActivarOpciones


    'ACTIVAR FUNCIONES DE FILTRO
    Public Shared Function PEstado() As String
        Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
        Dim idmov As String = COracle.ObtenerDatos("select codigo_movimiento from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_MOVIMIENTO")

        If (idp = "99") And (idmov = "N" Or idmov = "" Or idmov = "99") Then
            Return "TSE"
        ElseIf (idp <> "99") And (idmov = "N" Or idmov = "" Or idmov = "0") Then
            Return "PDO"

        ElseIf (idp <> "99") And (idmov <> "N" Or idmov <> "" Or idmov <> "99") Then
            Return "MOV"
        End If

    End Function


    'PROCEDIMIENTO PARA REESTRINGIR LA VISUALIZACION DE LA DATA A LOS USUARIOS 
    'DEPENDIENDO DEL PARTIDO Y MOVIMIENTO AL QUE ESTE RELACIONADO
    Public Shared Sub ReestriccionUsuarios(ByVal cmbp As ComboBox, ByVal cmbm As ComboBox)
        Dim modo As String = PEstado()
        Dim idp As String = COracle.ObtenerDatos("select codigo_partido from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_PARTIDO")
        Dim idmov As String = COracle.ObtenerDatos("select codigo_movimiento from im_usuarios where codigo_usuario ='" & usuario & "'", "CODIGO_MOVIMIENTO")

        If modo = "TSE" Then

        ElseIf modo = "PDO" Then
            With cmbp
                .SelectedValue = CInt(idp)
                .Enabled = False
            End With

        Else
            With cmbp
                .SelectedValue = CInt(idp)
                .Enabled = False
            End With

            With cmbm
                .SelectedValue = CInt(idmov)
                .Enabled = False
            End With


        End If
        
    End Sub

End Class
