Public Class BK_LOADING
    Private Sub BK_LOADING_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'loding bk 

        Dim conn_inter As New Internet
        Dim db_conn As New Database


        If conn_inter.Connect_internet() = True Then
            If db_conn.Connect_db = True AndAlso db_conn.Create_table = True Then
                TIMER_LOAD.Start()
            Else
                Me.Hide()
                MessageBox.Show("Oops! Something went wrong.",
                            "Error 400",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
                End

            End If


        Else
            Me.Hide()
            MessageBox.Show("Unable to connect to S.B.S. Please check the internet connection and try again.",
                            "No Internet Connection",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
            End
        End If
    End Sub

    Private Sub TIMER_LOAD_Tick(sender As Object, e As EventArgs) Handles TIMER_LOAD.Tick
        GunaProgressBar1.Increment(1)
        TIMER_LOAD.Interval = 100
        GunaLabel1.Text = GunaProgressBar1.ProgressPercentText
        If GunaProgressBar1.Value = 100 Then

            TIMER_LOAD.Stop()

            GunaProgressBar1.Value = 0
            Body.Show()
            Me.Hide()


        End If
    End Sub
End Class