Imports MySql.Data.MySqlClient
Public Class Dtabase ' : Inherits Form1

    Private ReadOnly server As String = "localhost"
    Public userid As String = "root"
    Dim password As String = "@123"
    Dim database As String = "work"

    Dim credentials As String = "server = " & server & " ; userid =" & userid & " ; password = " & password & " ; database =" & database

    Dim Database_Connection_credentials As New MySqlConnection(credentials)

    Public Function Connect() As BindingSource
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim Bs As New BindingSource

        Dim Query As String = "SELECT * FROM work.picture;"
        Dim command As New MySqlCommand(Query, Database_Connection_credentials)

        Try
            Database_Connection_credentials.Open()
            SDA.SelectCommand = command
            SDA.Fill(dbDataset)
            Bs.DataSource = dbDataset
            Return Bs
            SDA.Update(dbDataset)
            Database_Connection_credentials.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Bs = Nothing
            Return Bs
        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Function
End Class
