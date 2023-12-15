Imports System.Data.SqlClient
Imports System.Configuration

Module Globales

    Public configLocal As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("localdbSqlite") 'cn varible declada en app.config 
    Public configCtGeneral As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("dbControlTotalSqlServer") 'cn varible declada en app.config 
    Public conexionLocal As New SqlConnection(configLocal.ConnectionString)
    Public conexionControlTotal As New SqlConnection(configCtGeneral.ConnectionString)
End Module
