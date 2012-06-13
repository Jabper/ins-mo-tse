Public Class XfrmLogin 

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If Me.DxValidationProvider1.Validate = True Then
            
            If COracle.Login(Me.TxtUsuario, Me.TxtPassword) = True Then



                'DESDE ACA PUEDO MANDAR A DESHABILITAR LAS OPCIONES DE VISUALIZACION DEL FORMULARIO PRINCIPAL
               
                'CREAR EN EL MENU PRINCIPAL UN PROCEDIMIENTO QUE ME MUESTRE EL USUARIO CONECTADO
                'XFrmMenuPrincipal.showuser(NombreUsuario)
                Me.TxtUsuario.Text = Nothing
                Me.TxtUsuario.Text = Nothing
                XFrmMenuPrincipal.Show()
                Me.Close()
            Else
                Mensajes.MensajeError("Usuario o Contraseña Inválidos")

            End If
        End If
    End Sub

  

    Private Sub XfrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtUsuario.Focus()
    End Sub
End Class