Imports System.Data.OracleClient

Public Class xfrmCambioUserPass

    Private Sub xfrmCambioUserPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub Pcambiopass()
        If Me.DxValidationProvider1.Validate = True Then
            If Me.DxValidationProvider2.Validate = True Then
                Try
                    comprobar()
                    
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            End If
        End If
    End Sub
    Sub CambiarContraseña()
        'If COracle.ObtenerDatos("select modificado_por from im_usuarios where codigo_usuario='" & usuario & "'", "modificado_por") = "N" Then
        COracle.ejecutarconsulta("update im_usuarios set contrasena='" & Me.txtpass1.Text & "', fecha_modificacion=TO_DATE('" & DateTime.Now.ToString("dd/MM/yyyy") & "','DD/MM/YYYY'), modificado_por='" & usuario & "' where codigo_usuario='" & usuario & "'")
        'End If
    End Sub

    Sub comprobar()

        Dim cnx As New OracleConnection(Configuracion.verconfig)
        Dim pass As String
        cnx.Open()
        'Compruebo si existe el Usuario
        Dim Ssql As String = "SELECT * FROM IM_USUARIOS WHERE CODIGO_USUARIO='" & VControles.SafeSqlLikeClauseLiteral(usuario) & "'"
        Dim sqdel As New OracleCommand(Ssql, cnx)
        Dim dataread As OracleDataReader = sqdel.ExecuteReader()

        'Si existe Extraigo el password
        If dataread.Read = True Then
            With dataread
                pass = (.Item("CONTRASENA"))

            End With

            'compruebo la contraseña
            If pass = TxtPassAnterior.Text Then
                CambiarContraseña()
                MessageBox.Show("Contraseña modificada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Else
                Mensajes.mimensaje("La contraseña anterior no concuerda")
            End If
        Else

        End If
        dataread.Close()
        cnx.Close()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Pcambiopass()
    End Sub
End Class