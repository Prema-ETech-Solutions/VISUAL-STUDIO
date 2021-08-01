Public Class Form1
    Dim Speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8


    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            road(x).Top += Speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

        speedtext.Text = "Speed" & Speed

        If score > 10 And score < 30 Then
            Speed = 5
        End If
        If score > 30 And score < 50 Then
            Speed = 6
        End If
        If score > 50 Then
            Speed = 7
        End If

        If ((car.Bounds).IntersectsWith(Racer1.Bounds)) Then
            endgame()
        End If

        If ((car.Bounds).IntersectsWith(Racer2.Bounds)) Then
            endgame()
        End If

        If ((car.Bounds).IntersectsWith(Racer3.Bounds)) Then
            endgame()
        End If

    End Sub
    Private Sub endgame()
        ReplayButton.Visible = True
        GameOver.Visible = True
        RoadMover.Stop()
        Racer1Move.Stop()
        Racer2Move.Stop()
        Racer3Move.Stop()


    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            RightSide.Start()
        End If
        If e.KeyCode = Keys.Left Then
            LeftSide.Start()
        End If
    End Sub

    Private Sub RightSide_Tick(sender As Object, e As EventArgs) Handles RightSide.Tick
        If (car.Location.X < 185) Then
            car.Left += 5
        End If

    End Sub

    Private Sub LeftSide_Tick(sender As Object, e As EventArgs) Handles LeftSide.Tick
        If (car.Location.X > 0) Then
            car.Left -= 5
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightSide.Stop()
        LeftSide.Stop()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles Racer2.Click

    End Sub

    Private Sub Racer1Move_Tick(sender As Object, e As EventArgs) Handles Racer1Move.Tick
        Racer1.Top += Speed / 2
        If Racer1.Top >= Me.Height Then
            score += 1
            Scoretext.Text = "Score" & score

            Racer1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Racer1.Height)
            Racer1.Left = CInt(Math.Ceiling(Rnd() * 60)) + 0
        End If
    End Sub

    Private Sub Racer2Move_Tick(sender As Object, e As EventArgs) Handles Racer2Move.Tick
        Racer2.Top += Speed / 3
        If Racer2.Top >= Me.Height Then
            score += 1
            Scoretext.Text = "Score" & score

            Racer2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Racer2.Height)
            Racer2.Left = CInt(Math.Ceiling(Rnd() * 60)) + 100
        End If
    End Sub

    Private Sub Racer3Move_Tick(sender As Object, e As EventArgs) Handles Racer3Move.Tick
        Racer3.Top += Speed * 1 / 2

        If Racer3.Top >= Me.Height Then
            score += 1
            Scoretext.Text = "Score" & score

            Racer3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Racer3.Height)
            Racer3.Left = CInt(Math.Ceiling(Rnd() * 70)) + 140
        End If
    End Sub

    Private Sub Scoretext_Click(sender As Object, e As EventArgs) Handles Scoretext.Click

    End Sub

    Private Sub RplayButton_Click(sender As Object, e As EventArgs) Handles ReplayButton.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)

    End Sub
End Class
