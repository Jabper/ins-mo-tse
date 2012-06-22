﻿Imports DevExpress.XtraEditors

Public Class XfrmLogin
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.KeyPreview = True

    End Sub
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

    Private Sub XfrmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            If (XtraMessageBox.Show("¿Desea salir del sistema?", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then

                End

            End If
        End If
    End Sub



    Private Sub XfrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
End Class