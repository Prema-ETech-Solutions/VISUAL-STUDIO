Imports MySql.Data.MySqlClient
Public Class Form1
    Dim server As String = "localhost"
    Dim userid As String = "root"
    Dim password As String = "@123"
    Dim database As String = "indian_book_stores"

    Dim credentials As String = "server = " & server & " ; userid =" & userid & " ; password = " & password & " ; database =" & database

    Dim Database_Connection_credentials As New MySqlConnection(credentials)

    ' Dim myconnection As New MySqlConnection("server=localhost;userid=root;password=@123;database=spt_book_store")
    'myconnection = New MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' myconnection = New MySqlConnection
        'myconnection.ConnectionString = "server=localhost;userid=root;password=@123;database=spacetech_bill_system"
        Try
            Database_Connection_credentials.Open()
            MessageBox.Show("Connected")
            Database_Connection_credentials.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            Database_Connection_credentials.Dispose()
        End Try



    End Sub
End Class
