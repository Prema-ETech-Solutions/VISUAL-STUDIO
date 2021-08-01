Imports System.IO
Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim mysql As String
    Dim mysqlcnx As MySqlConnection
    Dim mysqlcmd As MySqlCommand
    Dim mysqlred As MySqlDataReader
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysqlcnx = New MySqlConnection("server=localhost;user id=root;password = @123;database=work")
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        cpb.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Dim filesize As UInt32
        Dim mstream As New System.IO.MemoryStream
        cpb.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrimage() As Byte = mstream.GetBuffer
        filesize = mstream.Length
        mstream.Close()
        Try
            mysqlcnx.Open()

            mysql = "insert into picture(img) values (@image)"
            mysqlcmd = New MySqlCommand(mysql, mysqlcnx)
            mysqlcmd.Parameters.AddWithValue("@image", arrimage)
            mysqlcmd.ExecuteReader()
            mysqlcnx.Close()
            MessageBox.Show("SAVED")
        Catch ex As Exception
            MessageBox.Show("IMG NOT SAVED")
        Finally
            mysqlcnx.Dispose()
        End Try
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Dim arrimage As Byte()
        Try
            mysqlcnx.Open()

            mysql = "Select img from picture where ID = 14 "
            mysqlcmd = New MySqlCommand(mysql, mysqlcnx)
            mysqlred = mysqlcmd.ExecuteReader
            mysqlred.Read()
            arrimage = mysqlred.Item("Img")
            Dim mstream As New System.IO.MemoryStream(arrimage)
            cpb.Image = System.Drawing.Image.FromStream(mstream)

            mysqlred.Close()
            mysqlcnx.Close()



        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            mysqlcnx.Dispose()
        End Try
    End Sub
End Class
