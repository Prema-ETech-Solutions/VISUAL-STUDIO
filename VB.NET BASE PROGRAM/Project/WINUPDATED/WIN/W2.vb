Imports Network
Imports Index
Public Class W2
    Dim connect_net As New Internet  ' Object of Internet class, dll file network 
    Dim check_net As Boolean ' check 0 or 1 of internet 
    Dim connect_Db As New Db_connection ' Object of Db_connection class , dll file index
    Dim check_db As Boolean ' check 0 or 1 of database is connected 

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim result As DialogResult = MessageBox.Show("DO YOU WANT TO EXIT ?",
                                    "CONFIRM DIALOG",
                                    MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Close()
            End
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        W3.Show()

        Me.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        W4.Show()

        Me.Dispose()

    End Sub

    Private Sub W2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

    End Sub

    Private Sub W2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Button5_Click(sender, e)
        ElseIf e.KeyCode = Keys.C Then
            Button1_Click(sender, e)
        ElseIf e.KeyCode = Keys.S Then
            Button2_Click(sender, e)
        Else

        End If
    End Sub
End Class