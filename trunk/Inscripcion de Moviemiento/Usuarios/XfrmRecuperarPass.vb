Public Class XfrmRecuperarPass 
    Sub PreguntasDeSeguridad() 'SE CREA UN DATA TABLE PARA ENLAZARLO AL CONTROL Y MOSTRAR LAS PREGUNTAS DE SEGURIDAD
        Dim tbl As New DataTable()
        'SE CREAN LAS COLUMNAS DEL DATA TABLE
        tbl.Columns.Add("Id", GetType(Integer))
        tbl.Columns.Add("Pregunta", GetType(String))
        'SE AGREGAN LAS FILAS CON LA INFORMACION
        tbl.Rows.Add(1, "¿Nombre de mi mascosta?")
        tbl.Rows.Add(2, "¿Lugar de nacimiento?")
        tbl.Rows.Add(3, "¿Color favorito?")
        tbl.Rows.Add(4, "¿Nombre de mi abuela materna?")
        tbl.Rows.Add(5, "¿Nombre de mi amigo de la infancia?")
        'SE ENLAZA EL DATATABLE CREADO PARA MOSTRARLO EN EL CONTROL
        With CmbPregunta
            .Properties.DataSource = tbl
            .Properties.ValueMember = "Id"
            .Properties.DisplayMember = "Pregunta"
            'SE PREPARA EL CONTROL PARA OCULTAR COLUMNAS
            .Properties.ForceInitialize()
            .Properties.PopulateColumns()
            'SE OCULTA INFORMACION 
            .Properties.Columns(0).Visible = False
            .Properties.Columns(1).Visible = True
        End With


    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        comprobar()

    End Sub

    Private Sub XfrmRecuperarPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreguntasDeSeguridad()
    End Sub


    Sub comprobar()
        If COracle.ObtenerDatos("select codigo_usuario  from im_usuarios where codigo_usuario='" & SafeSqlLikeClauseLiteral(Me.txtcedula.Text) & "'", "codigo_usuario") <> "N" Then
            If COracle.ObtenerDatos("select * from im_usuarios where pregunta_seguridad='" & Me.CmbPregunta.EditValue & "' and codigo_usuario='" & Me.txtcedula.Text & "' and respuesta_seguridad='" & SafeSqlLikeClauseLiteral(Me.txtrespuesta.Text) & "'", "codigo_usuario") <> "N" Then
                Mensajes.mimensaje("Su contraseña es: " & COracle.ObtenerDatos("select * from im_usuarios where pregunta_seguridad='" & Me.CmbPregunta.EditValue & "' and codigo_usuario='" & Me.txtcedula.Text & "' and respuesta_seguridad='" & SafeSqlLikeClauseLiteral(Me.txtrespuesta.Text) & "'", "contrasena"))
            Else
                MsgBox("La pregunta o la respuesta de seguridad son incorrectas", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("El usuario ingresado no existe", MsgBoxStyle.Critical)

        End If
    End Sub


    'Private Function SafeSqlLiteral(ByVal inputSQL As String) As String
    '    Return inputSQL.Replace("'", "''")
    'End Function


    Private Function SafeSqlLikeClauseLiteral(ByVal inputSQL As String) As String
        Dim s As String = inputSQL
        s = inputSQL.Replace("'", " ")
        s = s.Replace("[", " ")
        s = s.Replace("%", " ")
       
        Return s
    End Function

    Private Sub txtcedula_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcedula.EditValueChanged

    End Sub

    
End Class