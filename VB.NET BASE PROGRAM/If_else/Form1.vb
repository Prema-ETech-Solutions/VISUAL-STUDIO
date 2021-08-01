Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.Length >= 1 Then


            If TextBox1.Text >= 18 Then
                Label2.Text = "YOU CAN VOTE"
            Else
                Label2.Text = "YOU CANNOT VOTE"
            End If
        Else
            Label2.Text = "INVALID INPUT"
        End If



    End Sub
End Class
