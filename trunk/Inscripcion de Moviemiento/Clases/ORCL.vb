'CONTIENE METODOS DEL STRING DE CONEXION A LA BASE DE DATOS
Imports System.Data.OracleClient 'IMPORTANDO LIBRERIAS DE ORACLE
Public Class ORCL
    Public Shared DSoruce As String
    Public Shared pass As String
    Public Shared userid As String
    Public Shared ConexionActiva As String
    Public Shared mensaje As String


    '//////////////////////////////////////////////////
    'METODO 1 DE CONEXION A ORACLE USUARIO POR DEFAULT
    '///////////////////////////////////////////////////
    Public Shared Function Conexion1() As String
        Dim oradb As String = "DATA SOURCE=" & DSoruce
        oradb &= ";DBA PRIVILEGE=SYSDBA;PASSWORD=" & pass & ";USER ID=" & userid
        Return oradb
    End Function

    '///////////////////////////////////////////////////
    'METODO 2 DE CONEXION CON UN USUARIO CREADO
    '///////////////////////////////////////////////////
    Public Shared Function Conexion2() As String

        Dim oradb As String = "DATA SOURCE=" & DSoruce
        oradb &= ";PASSWORD=" & pass & ";USER ID=" & userid
        Return oradb
    End Function

    Public Shared Function ComprobarConexion1() As Boolean
        Dim oradb As String

        Try
            oradb = ORCL.Conexion1
            Dim conn As New OracleConnection(oradb)
            conn.Open()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            ConexionActiva = oradb
            Return True
        Catch ex As Exception
            mensaje = ex.Message.ToString
            Return False

        End Try

    End Function

    Public Shared Function ComprobarConexion2() As Boolean
        Dim oradb As String
        Try
            oradb = ORCL.Conexion2
            Dim conn As New OracleConnection(oradb)
            conn.Open()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            ConexionActiva = oradb
            Return True
        Catch ex As Exception
            mensaje = ex.Message.ToString
            Return False

        End Try

    End Function


    
End Class
