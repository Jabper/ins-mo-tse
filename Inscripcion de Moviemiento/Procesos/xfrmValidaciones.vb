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
            myCMD.CommandText = "IM_P_EJECUTAR_VALIDACIONES"
            myCMD.CommandType = CommandType.StoredProcedure
            myCMD.Parameters.Add(New OracleParameter("PVO_ERRORES", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
            myCMD.ExecuteOracleScalar()

            If IsDBNull(myCMD.Parameters("PVO_ERRORES").Value) Then
                Mensajes.mimensaje("Validaciones Corridas Exitosamente")
            Else
                Mensajes.MensajeError(myCMD.Parameters("PVO_ERRORES").Value)
            End If
            conn.Close()
        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
        End Try

    End Sub

    Private Sub BtnFirmas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirmas.Click
        Try


            Dim oradb As String = Configuracion.verconfig

            Dim conn As New OracleConnection()
            conn.ConnectionString = oradb
            conn.Open()

            Dim myCMD As New OracleCommand()
            myCMD.Connection = conn
            myCMD.CommandText = "IM_K_CARGA_DATOS.IM_P_VALIDA_FIRMA"
            myCMD.CommandType = CommandType.StoredProcedure
            myCMD.Parameters.Add(New OracleParameter("P_ERROR", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
            myCMD.ExecuteOracleScalar()

            If IsDBNull(myCMD.Parameters("P_ERROR").Value) Then
                Mensajes.mimensaje("Validaciones Corridas Exitosamente")
            Else
                Mensajes.MensajeError(myCMD.Parameters("P_ERROR").Value)
            End If
            conn.Close()
        Catch ex As Exception
            Mensajes.MensajeError(ex.Message)
        End Try
    End Sub

    Private Sub xfrmValidaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnreportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportes.Click
        Dim reporte3 As REPORTE_PLANILLAS_FINALES = New REPORTE_PLANILLAS_FINALES
        reporte3.ShowPreview()
    End Sub
End Class