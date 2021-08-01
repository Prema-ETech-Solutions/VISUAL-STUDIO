Imports MySql.Data.MySqlClient
Public Class Form1
    Dim Mycon As New MySqlConnection("server = localhost ; user = root ; password = @123 ; database = work")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "select * from work.login where COMPANY_ID = '" & TextBox1.Text & "' and COMPANY_PASSWORD = '" & TextBox2.Text & "'"
        Dim cmd As New MySqlCommand(query, Mycon)
        Dim read As MySqlDataReader
        Try
            Mycon.Open()
            read = cmd.ExecuteReader
            Dim count As Integer = 0
            While read.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("LOGIN SUCCESSFULL")
                Form2.Show()

                Me.Hide()





            ElseIf count > 1 Then
                MessageBox.Show("SOMETHING WENT WRONG !")
            Else
                MessageBox.Show("CHECK USERID AND PASSWORD")

            End If
            Mycon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mycon.Dispose()

        End Try
    End Sub
End Class
