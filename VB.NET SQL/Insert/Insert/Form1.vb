Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim con As New MySqlConnection("server=localhost;userid=root;password = @123;database=work")
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Try
            Dim Query As String = "CREATE TABLE IF NOT EXISTS login_customer(ID INT NOT NULL AUTO_INCREMENT,First_Name VARCHAR(50) NULL,Middle_Name VARCHAR(50) NULL,Last_Name VARCHAR(50) NULL, Gender VARCHAR(5) NULL ,Email_Id VARCHAR(45) NULL,Mobile_No INT NULL,Username VARCHAR(45) NULL,Password VARCHAR(45) NULL,PRIMARY KEY (ID));"
            con.Open()

            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader

            MessageBox.Show("Table Created")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()

        End Try

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim con As New MySqlConnection("server=localhost;userid=root;password = @123;database=work")
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Try
            Dim Query As String = "Insert INTO work.login (COMPANY_NAME, COMPANY_ID, COMPANY_PASSWORD) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "');"

            con.Open()

            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader

            MessageBox.Show("Value Is inserted")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()

        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
