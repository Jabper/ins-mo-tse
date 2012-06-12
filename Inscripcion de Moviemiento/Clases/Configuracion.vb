'CONTIENE PROCEDIMIENTOS Y FUNCIONES RELACIONADOS CON LA CONFIGURACION DE LA APLICACION
'REFERENTE A LA CONEXION CON LA BASE DE DATOS
Imports System.Configuration
Public Class Configuracion
    Public Shared Function verconfig() As String

        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        'Leer el archivo de configuracion app.config
        Dim xml = XElement.Load(config.FilePath)

        'obtener la primera configuracion de la lista(la cadena de conexion)
        Dim connStrXML = xml.Descendants("connectionStrings").Elements().First()

        'Get the connection string value
        Dim connStr = connStrXML.Attribute("connectionString").Value

        Return connStr
    End Function

    Public Shared Sub cambiarconfiguracion()
        Try

            Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

            'Leer el archivo de configuracion app.config
            Dim xml = XElement.Load(config.FilePath)

            'obtener la primera configuracion de la lista(la cadena de conexion)
            Dim connStrXML = xml.Descendants("connectionStrings").Elements().First()

            'Get the connection string value
            Dim connStr = connStrXML.Attribute("connectionString").Value


            'Modify the existing connection string information
            connStrXML.SetAttributeValue("connectionString", ORCL.ConexionActiva)

            'Saving config at the same place
            xml.Save(config.FilePath)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
