Imports Network ' Internet dll file
Imports Index   ' Database dll file 
Public Class W1
    Dim connect_net As New Internet  ' Object of Internet class, dll file network 
    Dim check_net As Boolean ' check 0 or 1 of internet 
    Dim connect_Db As New Db_connection ' Object of Db_connection class , dll file index
    Dim check_db As Boolean ' check 0 or 1 of database is connected 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor ' form cursors set on wating
        Me.Button1.Cursor = System.Windows.Forms.Cursors.WaitCursor ' button cursors set on wating

        check_net = connect_net.Check() ' check internet 
        If check_net = True Then ' internet is on
            check_db = connect_Db.checkconnection() ' check database connection
            If check_db = True Then 'database connected 
                Me.Cursor = System.Windows.Forms.Cursors.Arrow ' form cursor set to default
                Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand 'button cursor set to hand 
                W2.Show() ' second form show
                Me.Hide() ' first form hide
            Else 'database connection failed
                Me.Cursor = System.Windows.Forms.Cursors.Arrow ' form cursor set to default
                Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand 'button cursor set to hand 
                MessageBox.Show("Try again.", "404 Server Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation) ' database connection failed error 
            End If
        Else 'internet is off
            Me.Cursor = System.Windows.Forms.Cursors.Arrow ' form cursor set to default
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand 'button cursor set to hand 
            MessageBox.Show("Please check your internet connection and try again.",
                            "Connection Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation) 'internet connection failed error
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("DO YOU WANT TO EXIT ?",
                                     "CONFIRM DIALOG",
                                     MessageBoxButtons.YesNo) ' Dialog box appear yess or no

        If result = DialogResult.Yes Then ' yess 
            Me.Close()
            End
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized ' minimize window
    End Sub

    Private Sub W1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' keyboard shortcut enable  
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting ' form cursor set to AppStarting
        check_net = connect_net.Check() ' check internet 
        If check_net = True Then 'internet is on
            check_db = connect_Db.checkconnection() ' check database connection
            If check_db = True Then 'database connected 
                Me.Cursor = System.Windows.Forms.Cursors.Arrow 'form cursor set to Arrow
            Else ' database connection failed
                Me.Cursor = System.Windows.Forms.Cursors.Arrow 'form cursor set to Arrow
                MessageBox.Show("Try again.", "404 Server Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation) ' database connection failed error
            End If
        Else 'internet is off
            Me.Cursor = System.Windows.Forms.Cursors.Arrow 'form cursor set to Arrow
            MessageBox.Show("Please check your internet connection and try again.",
                            "Connection Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation) 'database connection failed error
        End If
    End Sub

    Private Sub W1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.S Then ' "S" key for start button
            Button1_Click(sender, e)
        ElseIf e.KeyCode = Keys.Escape Then ' "Escape" key for close 
            Button2_Click(sender, e)
        Else ' null 

        End If
    End Sub

End Class
