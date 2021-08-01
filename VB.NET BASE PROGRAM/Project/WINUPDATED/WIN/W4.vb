Public Class W4
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        W2.Show()

        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.UseSystemPasswordChar = True Then

            Me.Button1.BackgroundImage = Global.book_store_spt.My.Resources.Resources.icons8_eye_96
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True

            Me.Button1.BackgroundImage = Global.book_store_spt.My.Resources.Resources.hide

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        W4_3.Show()

        Me.Dispose()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        If TextBox1.Text = "" Then

            TextBox2.Text = ""

            W4_1.Show()

            Me.Hide()

        Else

            W4_1.Value2 = TextBox1.Text

            TextBox2.Text = ""

            Me.Hide()

            W4_1.Show()

        End If
    End Sub
End Class