Imports MySql.Data.MySqlClient
Public Class Db_connection

    Dim server As String = "localhost"
    Dim userid As String = "root"
    Dim password As String = "@123"
    Dim database As String = "spt_book_store"
    Dim Query As String
    Dim credentials As String = "server = " & server & " ; userid =" & userid & " ; password = " & password & " ; database =" & database
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim Database_Connection_credentials As New MySqlConnection(credentials)
    Public Sub Db_credentials(ByVal s As String, ByVal u As String, ByVal p As String, ByVal d As String)
        server = s
        userid = u
        password = p
        database = d
    End Sub
    Public Function checkconnection() As Boolean
        Try
            Database_Connection_credentials.Open()
            Return True
            Database_Connection_credentials.Close()

        Catch ex As Exception
            Return False
        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Function
End Class
