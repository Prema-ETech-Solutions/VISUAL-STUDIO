<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BK_LOADING
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
        Me.GunaProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.TIMER_LOAD = New System.Windows.Forms.Timer(Me.components)
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaProgressBar1
        '
        Me.GunaProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.GunaProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.GunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaProgressBar1.IdleColor = System.Drawing.Color.Transparent
        Me.GunaProgressBar1.Location = New System.Drawing.Point(0, 678)
        Me.GunaProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaProgressBar1.Name = "GunaProgressBar1"
        Me.GunaProgressBar1.ProgressMaxColor = System.Drawing.Color.BlueViolet
        Me.GunaProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.GunaProgressBar1.Radius = 1
        Me.GunaProgressBar1.Size = New System.Drawing.Size(1295, 16)
        Me.GunaProgressBar1.TabIndex = 9
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(1250, 652)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(35, 23)
        Me.GunaLabel1.TabIndex = 10
        Me.GunaLabel1.Text = "0%"
        '
        'TIMER_LOAD
        '
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GunaCirclePictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaCirclePictureBox1.Image = Global.BK_CUSTOMER.My.Resources.Resources.icons8_room_100
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(33, 151)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(130, 120)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox1.TabIndex = 11
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPictureBox1.Image = Global.BK_CUSTOMER.My.Resources.Resources.Untitled_1
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(1295, 694)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(169, 162)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(530, 60)
        Me.GunaLabel2.TabIndex = 12
        Me.GunaLabel2.Text = "SPACETECH BOOK STORE"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(177, 222)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(283, 20)
        Me.GunaLabel3.TabIndex = 13
        Me.GunaLabel3.Text = "POWERED BY __SPACETECH . OFFICIALS__"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(518, 573)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(238, 19)
        Me.GunaLabel4.TabIndex = 14
        Me.GunaLabel4.Text = "COPYRIGHT . ( R ) . SPACETECH 2020"
        '
        'BK_LOADING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1295, 694)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaProgressBar1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "BK_LOADING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BK_LOADING"
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaProgressBar1 As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TIMER_LOAD As Timer
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
End Class
