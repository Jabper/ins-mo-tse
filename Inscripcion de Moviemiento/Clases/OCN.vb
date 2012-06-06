Imports Oracle.DataAccess.Client ''IMPORTANDO LIBRERIAS NECESARIAS
Module OCN
    Dim oradb As String = "DATA SOURCE=TERUEL-PC;DBA PRIVILEGE=SYSDBA;PASSWORD=asi;USER ID=SYS" '

    'ESTABLECIENDO VARIABLE DE CONEXION CON LA CADENA DE CONEXION
    Dim conn As New OracleConnection(oradb)

End Module
