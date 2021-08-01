Public Class BK_SELLER_LOADING
    Dim Data_all As New Database

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

    Private Sub BK_SELLER_LOADING_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Internet.connection() = True Then
            If Data_all.Connect() = True AndAlso Data_all.Create_table() = True Then
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
End Class