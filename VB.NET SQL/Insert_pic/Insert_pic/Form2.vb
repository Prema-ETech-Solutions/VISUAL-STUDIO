Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Form2
    Dim FullFileName() As String
    Dim fname As String
    Dim filecontant() As Byte
    Dim a As Byte()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        OpenFileDialog1.ShowDialog()
        GunaLabel1.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) ' Temp check
        FullFileName = OpenFileDialog1.FileName.Split("\")
        fname = FullFileName.Last.ToString
        Dim Fs As New FileStream(OpenFileDialog1.FileName, FileMode.Open)
        Dim Br As New BinaryReader(Fs)
        filecontant = Br.ReadBytes(Fs.Length)
        Fs.Close()
        Br.Close()


        Dim server As String = "localhost"
        Dim userid As String = "root"
        Dim password As String = "@123"
        Dim database As String = "work"
        Dim credentials As String = "server = " & server & " ; userid =" & userid & " ; password = " & password & " ; database =" & database
        Dim Database_Connection_credentials As New MySqlConnection(credentials)
        Dim Query As String = " INSERT INTO `work`.`file`  (`File`) VALUES (@data);"
        Dim command As MySqlCommand

        command = New MySqlCommand(Query, Database_Connection_credentials)

        command.Parameters.AddWithValue("@data", filecontant)

        Try
            Database_Connection_credentials.Open()

            command.ExecuteNonQuery()
            MessageBox.Show("ok")
            Database_Connection_credentials.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Sub

    Private Sub GunaAdvenceButton1_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim fInfo As New FileInfo(OpenFileDialog1.FileName)
        Dim numBytes As Long = fInfo.Length

        Dim fStream As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
        Dim br As New BinaryReader(fStream)
        a = br.ReadBytes(CInt(numBytes))

        ' Show the number of bytes in the array.
        Guna2TextBox1.Text = Convert.ToString(a.ToString)
        br.Close()
        fStream.Close()

        Dim server As String = "localhost"
        Dim userid As String = "root"
        Dim password As String = "@123"
        Dim database As String = "work"
        Dim credentials As String = "server = " & server & " ; userid =" & userid & " ; password = " & password & " ; database =" & database
        Dim Database_Connection_credentials As New MySqlConnection(credentials)
        Dim Query As String = " INSERT INTO `work`.`file`  (`File`) VALUES (@data);"
        Dim command As MySqlCommand

        command = New MySqlCommand(Query, Database_Connection_credentials)

        command.Parameters.AddWithValue("@data", a)

        Try
            Database_Connection_credentials.Open()

            command.ExecuteNonQuery()
            MessageBox.Show("ok")
            Database_Connection_credentials.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            Database_Connection_credentials.Dispose()
        End Try
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click

        Dim server As String = "localhost"
        Dim userid As String = "root"
        Dim password As String = "@123"
        Dim database As String = "work"
        Dim credentials As String = "server = " & server & " ; userid =" & userid & " ; password = " & password & " ; database =" & database
        Dim Database_Connection_credentials As New MySqlConnection(credentials)
        Dim Query As String = "select * from file where ID =8 "
        Dim command As MySqlCommand
        Dim Read1 As MySqlDataReader
        command = New MySqlCommand(Query, Database_Connection_credentials)

        Try
            Database_Connection_credentials.Open()

            Read1 = command.ExecuteReader
            While Read1.Read
                a = Read1.Item("File")

            End While
            Database_Connection_credentials.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            Database_Connection_credentials.Dispose()
        End Try

















        Dim obj As FileStream = File.Create("C:\FilePDF\test.pdf")
        obj.Write(a, 0, a.Length)

        obj.Flush()
        obj.Close()
        If MsgBox("Open file PDF ?", MsgBoxStyle.OkCancel, "Info") = MsgBoxResult.Ok Then
            System.Diagnostics.Process.Start("C:\FilePDF\test.pdf")
        End If
    End Sub


End Class