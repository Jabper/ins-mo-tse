Imports Oracle.DataAccess.Client ''IMPORTANDO LIBRERIAS NECESARIAS
Module OCN


    'ESTABLECIENDO VARIABLE DE CONEXION CON LA CADENA DE CONEXION
    Public cnn As OracleConnection = New OracleConnection(Configuracion.verconfig())

    Public Function LlenarDataSet(ByVal DT As DataSet, ByVal sql As String) As DataSet
        Try
            CerrarConexion()
            'ABRIENDO LA CONEXION
            cnn.Open()

            Dim oa As OracleDataAdapter = New OracleDataAdapter(sql, cnn)

            oa.Fill(DT)

            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return DT

    End Function

    Sub CerrarConexion()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
    End Sub
    Public Sub ejecutarconsulta(ByVal consulta As String)

        Try
            cnn.Close()
            cnn.Open()

            Dim cmd As New OracleCommand(consulta, cnn)
            cmd.ExecuteNonQuery()
            cnn.Close()

        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub
End Module
