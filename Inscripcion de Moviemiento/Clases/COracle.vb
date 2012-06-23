Imports System.Data.OracleClient ''IMPORTANDO LIBRERIAS NECESARIAS
Public Class COracle
    Public Shared Sub ejecutarconsulta(ByVal consulta As String)

        Try

            Dim cnx As New OracleConnection(Configuracion.verconfig)

            cnx.Open()

            Dim cmd As New OracleCommand(consulta, cnx)
            cmd.ExecuteNonQuery()
            cnx.Close()

        Catch ex As Exception
            Mensajes.mimensaje(ex.Message)
        End Try

    End Sub

    Public Shared Function credenciales(ByVal control As String, ByVal operacion As String) As String
        Try
            Dim oradb As String = Configuracion.verconfig
            Dim opcion As Integer
            Dim conn As New OracleConnection()
            conn.ConnectionString = oradb
            conn.Open()

            Dim CMD As New OracleCommand()
            CMD.Connection = conn
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "select codigo_opcion from im_opciones where nombre_control ='" & control & "'"            

            Dim chek As OracleDataReader = CMD.ExecuteReader()
            If chek.Read Then
                opcion = chek.Item("CODIGO_OPCION")            
            End If

            Dim myCMD As New OracleCommand()
            myCMD.Connection = conn
            myCMD.CommandText = "IM_P_CREDENCIALES"
            myCMD.CommandType = CommandType.StoredProcedure
            myCMD.Parameters.Add(New OracleParameter("pvi_codigo_usuario", OracleType.Char, 10, ParameterDirection.Input)).Value = usuario
            myCMD.Parameters.Add(New OracleParameter("pni_codigo_opcion", OracleType.Number, ParameterDirection.Input)).Value = opcion
            myCMD.Parameters.Add(New OracleParameter("pvi_operacion", OracleType.Char, 10, ParameterDirection.Input)).Value = operacion
            myCMD.Parameters.Add(New OracleParameter("pvi_acceso", OracleType.Char, 1)).Direction = ParameterDirection.Output
            myCMD.ExecuteOracleScalar()

            conn.Close()
            Return myCMD.Parameters("pvi_acceso").Value
        Catch ex As Exception            
            Mensajes.MensajeError(ex.Message)
        End Try
    End Function

    Public Shared Function Login(ByVal txtusuario As Object, ByVal txtpass As Object) As Boolean
        Dim pass As String

        'Metodo para evitar sql Injection
        Try
            Dim cnx As New OracleConnection(Configuracion.verconfig)

            cnx.Open()


            'Compruebo si existe el Usuario
            Dim Ssql As String = "SELECT * FROM IM_USUARIOS WHERE CODIGO_USUARIO='" & txtusuario.Text & "' AND ESTADO='A'"
            Dim sqdel As New OracleCommand(Ssql, cnx)
            Dim dataread As OracleDataReader = sqdel.ExecuteReader()

            'Si existe Extraigo el password
            If dataread.Read = True Then
                With dataread
                    pass = (.Item("CONTRASENA"))
                    NombreUsuario = (.Item("NOMBRE"))
                    usuario = (.Item("CODIGO_USUARIO"))
                    NivelUsuario = (.Item("NIVEL"))
                End With

                'compruebo la contraseña
                If pass = txtpass.Text Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
            dataread.Close()
            cnx.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Shared Function FUN_EJECUTAR_SEQ(ByVal nombre_sequencia As String) As Integer
        Try
            Dim cnx As New OracleConnection(Configuracion.verconfig)

            cnx.Open()
            Dim valor As Integer

            'Compruebo si existe el Usuario
            Dim Ssql As String = "SELECT " & nombre_sequencia & ".nextval NUMERO FROM dual"
            Dim sqdel As New OracleCommand(Ssql, cnx)
            Dim dataread As OracleDataReader = sqdel.ExecuteReader()

            'Si existe Extraigo el password
            If dataread.Read = True Then
                With dataread
                    valor = (.Item("NUMERO"))

                End With
            End If
            dataread.Close()
            cnx.Close()
            Return valor
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Function

    Public Shared Function ObtenerDatos(ByVal consulta As String, ByVal campo As String) As String
        Try
            Dim cnx As New OracleConnection(Configuracion.verconfig)
            cnx.Close()
            cnx.Open()



            Dim sqdel As New OracleCommand(consulta, cnx)
            Dim dataread As OracleDataReader = sqdel.ExecuteReader()


            If dataread.Read = True Then
                With dataread
                    Dim A As String = (.Item(campo)).ToString.Trim
                    cnx.Close()
                    Return A

                End With
            Else
                cnx.Close()
                Return "N"
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return "N"
        End Try
    End Function
    Public Shared Function ObtenerImagen(ByVal consulta As String, ByVal campo As String) As Image
        Try
            Dim cnx As New OracleConnection(Configuracion.verconfig)

            cnx.Open()



            Dim sqdel As New OracleCommand(consulta, cnx)
            Dim dataread As OracleDataReader = sqdel.ExecuteReader()


            If dataread.Read = True Then
                With dataread
                    Dim ba As Byte() = ((.Item(campo)))
                    Return Data.ConvertByteArrayToImage(ba)
                End With
            Else
                Return Nothing
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function


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
