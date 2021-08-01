Imports System.IO
Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filePath As String
        filePath = TextBox1.Text

        If File.Exists(filePath) Then

            MessageBox.Show("File Already Exists")

        Else
            File.Create(filePath)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim folderPath As String
        folderPath = TextBox2.Text

        If Directory.Exists(folderPath) Then

            MessageBox.Show("Folder Already Exists")

        Else

            Directory.CreateDirectory(folderPath)

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filePath As String
        filePath = TextBox3.Text

        If File.Exists(filePath) Then

            File.Delete(filePath)

        Else

            MessageBox.Show("File Not Found")


        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim folderPath As String
        folderPath = TextBox4.Text

        If Directory.Exists(folderPath) Then
            'if the directory contain files
            Directory.Delete(folderPath, True)

        Else

            MessageBox.Show("Folder Not Found")


        End If
    End Sub
End Class