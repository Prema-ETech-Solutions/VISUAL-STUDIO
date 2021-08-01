Public Class W4_1

    Public Property Value2 As String

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        W4.Show()

        Me.Dispose()

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Value2 = "" Then

        Else

            TextBox1.Text = Value2

            TextBox1.Enabled = False

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        W4.Show()

        Me.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" AndAlso TextBox2.Text = "" Then

            MessageBox.Show("ENTER USER ID AND EMAIL ID .")

        ElseIf TextBox1.Text = "" Then

            MessageBox.Show("ENTER USER ID .")

        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("ENTER EMAIL ID .")
        Else

            W4_1_1.Show()

            Me.Show()

        End If


    End Sub
End Class