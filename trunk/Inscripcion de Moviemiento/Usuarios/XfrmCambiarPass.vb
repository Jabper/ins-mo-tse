Public Class XfrmCambiarPass 
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.KeyPreview = True

    End Sub
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        If MessageBox.Show("Desea Cancelar la operación", "Mensaje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
    Sub Pcambiopass()
        If Me.DxValidationProvider1.Validate = True Then
            If Me.DxValidationProvider2.Validate = True Then
                Try
                    CambiarContraseña()
                    MsgBox("Contraseña modificada correctamente" & vbCrLf & "A continuación ingresará nuevamente al sistema con su nueva contraseña", MsgBoxStyle.OkOnly, "Mensaje")
                    XfrmLogin.TxtPassword.Text = ""
                    XfrmLogin.TxtUsuario.Text = ""
                    XfrmLogin.Visible = True
                    XfrmLogin.TxtUsuario.Focus()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Pcambiopass()
    End Sub
    Sub CambiarContraseña()
        'If COracle.ObtenerDatos("select modificado_por from im_usuarios where codigo_usuario='" & usuario & "'", "modificado_por") = "N" Then
        COracle.ejecutarconsulta("update im_usuarios set contrasena='" & Me.txtpass1.Text & "', fecha_modificacion=TO_DATE('" & DateTime.Now.ToString("dd/MM/yyyy") & "','DD/MM/YYYY'), modificado_por='" & usuario & "' where codigo_usuario='" & usuario & "'")
        'End If
    End Sub

    Private Sub txtpass2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass2.EditValueChanged

    End Sub

   
    Private Sub txtpass2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass2.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Pcambiopass()
        End If
    End Sub

    Private Sub XfrmCambiarPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim S As String

        S = UCase(e.KeyChar)

        S = ChrW(Asc(S))

        e.KeyChar = S
    End Sub


    Private Sub XfrmCambiarPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class