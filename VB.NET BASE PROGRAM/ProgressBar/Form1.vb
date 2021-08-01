Public Class Form1
    Dim v1 As Integer = 1
    Dim v2 As Integer = 100
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox1.Text = Nothing AndAlso TextBox2.Text = Nothing Then

        Else
            v1 = TextBox1.Text
            v2 = TextBox2.Text
        End If

        ProgressBar1.Increment(v1)
        Timer1.Interval = (v2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        ProgressBar1.Value = 0
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
    End Sub
End Class
