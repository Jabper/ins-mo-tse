Imports System.Data.OracleClient

Public Class xfrmValidaciones

    Private Sub btnplanilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplanilla.Click
        Try


            Dim oradb As String = Configuracion.verconfig

            Dim conn As New OracleConnection()
            conn.ConnectionString = oradb
            conn.Open()

            Dim myCMD As New OracleCommand()
            myCMD.Connection = conn
            myCMD.CommandText = "IM_K_CARGA_DATOS.IM_P_VALIDA_FIRMA "
            myCMD.CommandType = CommandType.StoredProcedure
            myCMD.Parameters.Add(New OracleParameter("P_ERROR", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
            myCMD.ExecuteOracleScalar()

            If IsDBNull(myCMD.Parameters("PVO_MENSAJE").Value) Then
            Else
                Mensajes.MensajeError(myCMD.Parameters("PVO_MENSAJE").Value)
            End If

        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub
End Class