Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "PDF Files  | *.PDF"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PDF1.src = OpenFileDialog1.FileName
        End If
    End Sub
End Class
