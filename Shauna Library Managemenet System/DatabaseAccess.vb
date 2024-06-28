Imports System.Configuration
Imports System.Data.OleDb

Public Class DatabaseAccess
    Private connectionString As String

    Public Sub New()
        ' Retrieve the connection string from App.config
        connectionString = ConfigurationManager.ConnectionStrings("DatabaseConnectionString").ConnectionString
    End Sub

    Public Sub ConnectToDatabase()
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                ' Perform your database operations here
                Console.WriteLine("Database connection opened successfully.")
            Catch ex As Exception
                ' Handle exceptions
                Console.WriteLine("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class

