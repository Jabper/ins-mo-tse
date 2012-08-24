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
            COracle.Im_Estadisticas()
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
            myCMD.CommandText = "IM_K_VALIDA_FIRMAS.IM_P_VALIDA"
            myCMD.CommandType = CommandType.StoredProcedure
            'myCMD.Parameters.Add(New OracleParameter("P_ERROR", OracleType.NVarChar, 32767)).Direction = ParameterDirection.Output
            myCMD.ExecuteOracleScalar()

            'If IsDBNull(myCMD.Parameters("P_ERROR").Value) Then
            Mensajes.mimensaje("Validaciones Corridas Exitosamente")
            'Else
            '    Mensajes.MensajeError(myCMD.Parameters("P_ERROR").Value)
            'End If

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
        Dim REPORTECINC As REPORTE_CANDIDATOS_INCONSISTENTES = New REPORTE_CANDIDATOS_INCONSISTENTES
        REPORTECINC.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim reporteciuinc As REPORTE_CIU_INCONSISTENTE = New REPORTE_CIU_INCONSISTENTE
        reporteciuinc.ShowPreview()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim reporte4 As Reporte_de_Firmas_In = New Reporte_de_Firmas_In
        reporte4.ShowPreview()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim reporte9 As REPORTE_DE_LOG = New REPORTE_DE_LOG
        reporte9.ShowPreview()
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        COracle.Im_Estadisticas()
    End Sub
End Class