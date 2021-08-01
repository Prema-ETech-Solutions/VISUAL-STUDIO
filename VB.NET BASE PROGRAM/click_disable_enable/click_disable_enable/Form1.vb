Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MessageBox.Show("OK")
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        RemoveHandler Label1.Click, AddressOf Label1_Click
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        AddHandler Label1.Click, AddressOf Label1_Click
    End Sub
End Class
