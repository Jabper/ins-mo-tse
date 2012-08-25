Imports DevExpress.XtraEditors

Public Class XfrmLogin
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.KeyPreview = True

    End Sub

    Sub ingresar()
        'config()
        If Me.DxValidationProvider1.Validate = True Then

            If COracle.Login(Me.TxtUsuario, Me.TxtPassword) = True Then

                If COracle.ObtenerDatos("select modificado_por from im_usuarios where codigo_usuario='" & usuario & "'", "modificado_por") = "" Or COracle.ObtenerDatos("select modificado_por from im_usuarios where codigo_usuario='" & usuario & "'", "modificado_por") = " " Then

                    Me.Visible = False
                    XfrmCambiarPass.BringToFront()

                    XfrmCambiarPass.Show()


                Else
                    'config()
                    'DESDE ACA PUEDO MANDAR A DESHABILITAR LAS OPCIONES DE VISUALIZACION DEL FORMULARIO PRINCIPAL

                    'CREAR EN EL MENU PRINCIPAL UN PROCEDIMIENTO QUE ME MUESTRE EL USUARIO CONECTADO
                    'XFrmMenuPrincipal.showuser(NombreUsuario)

                    If COracle.ObtenerDatos("select conectado from im_usuarios where codigo_usuario='" & usuario & "'", "CONECTADO") = "S" Then
                        Mensajes.mimensaje("El usuario ya ha iniciado sesión en otro equipo")
                    Else

                        Me.TxtUsuario.Text = Nothing
                        Me.TxtUsuario.Text = Nothing
                        XFrmMenuPrincipal.TxtUser.Caption = NombreUsuario
                        XFrmMenuPrincipal.verificar_permisos()

                        XFrmMenuPrincipal.Visible = True
                        COracle.ejecutarconsulta("update im_usuarios set conectado='S' where codigo_usuario='" & usuario & "'")
                        XFrmMenuPrincipal.Focus()
                        Me.Close()
                    End If

                    End If
            Else
                    Mensajes.MensajeError("Usuario o Contraseña Inválidos")

            End If
        End If
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ingresar()
    End Sub

    Private Sub XfrmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            If (XtraMessageBox.Show("¿Desea salir del sistema?", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then

                End

            End If
        End If
    End Sub
    Sub config()
        ORCL.DSoruce = SystemInformation.ComputerName
        ORCL.pass = "TSEORACLE2012"
        ORCL.userid = "TSE"

        If ORCL.ComprobarConexion1 = True Then
            Configuracion.cambiarconfiguracion()
            
        Else

            If ORCL.ComprobarConexion2 = True Then

                Configuracion.cambiarconfiguracion()
                
            Else
                'Dim mensaje As String
                'mensaje = "Error al accesar a la base de datos" & vbCrLf & "1. Asegurese de que todos los componentes necesarios esten instalados"

                'MsgBox(mensaje, MsgBoxStyle.Critical, "Error de Conexión")

            End If
        End If
    End Sub


    Private Sub XfrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If VControles.ComprobarFormAbierto(XfrmConfigurar) Then

            XfrmConfigurar.Close()
        End If
        Me.Focus()
        Me.TxtUsuario.Focus()

    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Height += 3
        PictureBox3.Width += 3
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Height -= 3
        PictureBox3.Width -= 3
    End Sub

    Private Sub TxtPassword_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPassword.EditValueChanged

    End Sub

    Private Sub TxtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            ingresar()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (XtraMessageBox.Show("¿Desea salir del sistema?", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then

            End

        End If

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        XfrmRecuperarPass.Show()
    End Sub

    Private Sub Label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        Me.Label3.ForeColor = Color.Blue
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Me.Label3.ForeColor = Color.White
    End Sub
End Class