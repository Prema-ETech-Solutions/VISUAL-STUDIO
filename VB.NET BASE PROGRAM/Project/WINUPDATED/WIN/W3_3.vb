Public Class W3_3
    Public Sub Cleara()

        TextBox1.Clear()

        TextBox2.Clear()

        TextBox3.Clear()

        RadioButton1.Checked = False

        RadioButton2.Checked = False

        TextBox5.Clear()

        TextBox6.Clear()

        TextBox7.Clear()

        TextBox8.Clear()

        TextBox10.Clear()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Cleara()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        W3.Show()

        Me.Dispose()

    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Asc(e.KeyChar) = 8 Then


        ElseIf Not (Char.IsDigit(c) Or c = "." Or Char.IsControl(c)) Then

            e.Handled = True

            MsgBox("ONLY NUMERICS....!")

        ElseIf TextBox10.TextLength >= 10 Then

            e.Handled = True

            MsgBox(" 10 NUMERICS ONLY")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

End Class