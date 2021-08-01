<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.RightSide = New System.Windows.Forms.Timer(Me.components)
        Me.LeftSide = New System.Windows.Forms.Timer(Me.components)
        Me.Racer3 = New System.Windows.Forms.PictureBox()
        Me.Racer2 = New System.Windows.Forms.PictureBox()
        Me.Racer1 = New System.Windows.Forms.PictureBox()
        Me.car = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Racer1Move = New System.Windows.Forms.Timer(Me.components)
        Me.Racer2Move = New System.Windows.Forms.Timer(Me.components)
        Me.Racer3Move = New System.Windows.Forms.Timer(Me.components)
        Me.GameOver = New System.Windows.Forms.Label()
        Me.Scoretext = New System.Windows.Forms.Label()
        Me.ReplayButton = New System.Windows.Forms.Button()
        Me.speedtext = New System.Windows.Forms.Label()
        CType(Me.Racer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Racer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Racer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'RightSide
        '
        Me.RightSide.Interval = 10
        '
        'LeftSide
        '
        Me.LeftSide.Interval = 10
        '
        'Racer3
        '
        Me.Racer3.Image = Global.ReadFighter.My.Resources.Resources._4
        Me.Racer3.Location = New System.Drawing.Point(198, 82)
        Me.Racer3.Name = "Racer3"
        Me.Racer3.Size = New System.Drawing.Size(44, 97)
        Me.Racer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Racer3.TabIndex = 11
        Me.Racer3.TabStop = False
        '
        'Racer2
        '
        Me.Racer2.Image = Global.ReadFighter.My.Resources.Resources._3
        Me.Racer2.Location = New System.Drawing.Point(98, 0)
        Me.Racer2.Name = "Racer2"
        Me.Racer2.Size = New System.Drawing.Size(41, 84)
        Me.Racer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Racer2.TabIndex = 10
        Me.Racer2.TabStop = False
        '
        'Racer1
        '
        Me.Racer1.Image = Global.ReadFighter.My.Resources.Resources._2
        Me.Racer1.Location = New System.Drawing.Point(-1, 144)
        Me.Racer1.Name = "Racer1"
        Me.Racer1.Size = New System.Drawing.Size(48, 106)
        Me.Racer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Racer1.TabIndex = 9
        Me.Racer1.TabStop = False
        '
        'car
        '
        Me.car.Image = Global.ReadFighter.My.Resources.Resources._1
        Me.car.Location = New System.Drawing.Point(175, 320)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(41, 73)
        Me.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car.TabIndex = 8
        Me.car.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox7.Location = New System.Drawing.Point(158, 364)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 55)
        Me.PictureBox7.TabIndex = 7
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox8.Location = New System.Drawing.Point(65, 365)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 54)
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox5.Location = New System.Drawing.Point(158, 252)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 57)
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox6.Location = New System.Drawing.Point(65, 252)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 59)
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox3.Location = New System.Drawing.Point(158, 139)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 58)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox4.Location = New System.Drawing.Point(65, 139)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 58)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Location = New System.Drawing.Point(158, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 49)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(65, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 49)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Racer1Move
        '
        Me.Racer1Move.Enabled = True
        Me.Racer1Move.Interval = 10
        '
        'Racer2Move
        '
        Me.Racer2Move.Enabled = True
        Me.Racer2Move.Interval = 10
        '
        'Racer3Move
        '
        Me.Racer3Move.Enabled = True
        Me.Racer3Move.Interval = 10
        '
        'GameOver
        '
        Me.GameOver.AutoSize = True
        Me.GameOver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOver.ForeColor = System.Drawing.Color.Red
        Me.GameOver.Location = New System.Drawing.Point(36, 103)
        Me.GameOver.Name = "GameOver"
        Me.GameOver.Size = New System.Drawing.Size(159, 33)
        Me.GameOver.TabIndex = 12
        Me.GameOver.Text = "GameOver"
        Me.GameOver.Visible = False
        '
        'Scoretext
        '
        Me.Scoretext.AutoSize = True
        Me.Scoretext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scoretext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Scoretext.Location = New System.Drawing.Point(0, 0)
        Me.Scoretext.Name = "Scoretext"
        Me.Scoretext.Size = New System.Drawing.Size(64, 20)
        Me.Scoretext.TabIndex = 13
        Me.Scoretext.Text = "Score 0"
        '
        'ReplayButton
        '
        Me.ReplayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ReplayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReplayButton.Location = New System.Drawing.Point(77, 203)
        Me.ReplayButton.Name = "ReplayButton"
        Me.ReplayButton.Size = New System.Drawing.Size(91, 32)
        Me.ReplayButton.TabIndex = 14
        Me.ReplayButton.Text = "Replay"
        Me.ReplayButton.UseVisualStyleBackColor = False
        Me.ReplayButton.Visible = False
        '
        'speedtext
        '
        Me.speedtext.AutoSize = True
        Me.speedtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speedtext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.speedtext.Location = New System.Drawing.Point(171, 0)
        Me.speedtext.Name = "speedtext"
        Me.speedtext.Size = New System.Drawing.Size(65, 20)
        Me.speedtext.TabIndex = 15
        Me.speedtext.Text = "Speed0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(244, 440)
        Me.Controls.Add(Me.speedtext)
        Me.Controls.Add(Me.ReplayButton)
        Me.Controls.Add(Me.Scoretext)
        Me.Controls.Add(Me.GameOver)
        Me.Controls.Add(Me.Racer3)
        Me.Controls.Add(Me.Racer2)
        Me.Controls.Add(Me.Racer1)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(260, 500)
        Me.Name = "Form1"
        Me.Text = "Road Fighter Game"
        CType(Me.Racer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Racer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Racer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents car As PictureBox
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents Racer1 As PictureBox
    Friend WithEvents Racer2 As PictureBox
    Friend WithEvents Racer3 As PictureBox
    Friend WithEvents Racer1Move As Timer
    Friend WithEvents Racer2Move As Timer
    Friend WithEvents Racer3Move As Timer
    Friend WithEvents GameOver As Label
    Friend WithEvents Scoretext As Label
    Friend WithEvents ReplayButton As Button
    Friend WithEvents speedtext As Label
End Class
