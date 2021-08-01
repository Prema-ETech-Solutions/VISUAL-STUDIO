Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Form1.TextBox1.Text = Nothing
        Form1.TextBox2.Text = Nothing
        Form1.Show()

        Me.Dispose()

    End Sub
End Class