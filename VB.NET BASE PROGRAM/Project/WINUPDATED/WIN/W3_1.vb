Public Class W3_1

    Public Property Value As String
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        W3.Show()

        Me.Dispose()

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Value = "" Then

        Else
            TextBox1.Text = Value
            TextBox1.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" AndAlso TextBox2.Text = "" Then
            MessageBox.Show("ENTER USER ID AND EMAIL ID . ")
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("ENTER USER ID . ")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("ENTER EMAIL ID .")
        Else
            W3_1_1.Show()

            Me.Hide()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        W3.Show()

        Me.Dispose()
    End Sub

End Class