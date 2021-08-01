Public Class Form1
    Dim value1 As Double = 0
    Dim value2 As Double = 0
    Dim op As String = Nothing
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        value1 = TextBox1.Text
        value2 = TextBox2.Text
        If op = "+" Then
            Label2.Text = value1 + value2
        ElseIf op = "-" Then
            Label2.Text = value1 - value2
        ElseIf op = "*" Then
            Label2.Text = value1 * value2
        ElseIf op = "/" Then
            Label2.Text = value1 / value2
        Else
            Label2.Text = "INVALID"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "+"
        op = "+"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "-"
        op = "-"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "*"
        op = "*"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "/"
        op = "/"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        value1 = 0
        value2 = 0
        TextBox1.Clear()
        TextBox2.Clear()
        op = Nothing
        Label1.Text = Nothing
        Label2.Text = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        value1 = 0
        value2 = 0
        TextBox1.Clear()
        TextBox2.Clear()
        op = Nothing
        Label1.Text = Nothing
        Label2.Text = Nothing
    End Sub
End Class
