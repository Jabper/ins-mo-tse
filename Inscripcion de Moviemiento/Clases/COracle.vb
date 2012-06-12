Imports Oracle.DataAccess.Client ''IMPORTANDO LIBRERIAS NECESARIAS
Public Class COracle
    Public Shared Sub ejecutarconsulta(ByVal consulta As String)

        Try

            Dim cnx As New OracleConnection("Data Source=192.168.1.154:1521;Persist Security Info=True;User ID=tse;Password=oracle;")

            cnx.Open()

            Dim cmd As New OracleCommand(consulta, cnx)
            cmd.ExecuteNonQuery()
            cnx.Close()

        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub
    'Try

    '    'CREANDO CADENA DE CONEXION



    '    'ESTABLECIENDO VARIABLE DE CONEXION CON LA CADENA DE CONEXION
    '    Dim conn As New OracleConnection(GetOCRL.ConexionActiva)

    '    'ABRIENDO LA CONEXION
    '    conn.Open()


    '    Dim sql As String = "SELECT LOCATION_ID, STREET_ADDRESS, POSTAL_CODE, CITY, STATE_PROVINCE, COUNTRY_ID FROM HR.LOCATIONS" ' Visual Basic
    '    'Dim cmd As New OracleCommand(sql, conn)
    '    'cmd.CommandType = CommandType.Text
    '    Dim oa As OracleDataAdapter = New OracleDataAdapter(sql, conn)
    '    Dim ds As DataSet = New DataSet()
    '    oa.Fill(ds)
    '    Me.DataGridView1.DataSource = ds.Tables(0)
    '    conn.Close()
    'Catch ex As Exception
    '    MsgBox(ex.Message)

    'End Try
End Class
