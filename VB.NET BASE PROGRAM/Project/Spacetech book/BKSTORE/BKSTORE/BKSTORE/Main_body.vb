
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Drawing
Imports System.Globalization
Public Class Body
    Dim Data_all As New Database
    Dim Inter_value As Boolean
    Dim Ran As New Random
    Dim otp As Integer
    Dim Data_value As Boolean
    Dim Temp_sid_forget As Integer = 0
    Dim Temp_forget As Integer = 0
    'Sign up pannel btn 
    Private Sub GunaTileButton9_Click(sender As Object, e As EventArgs) Handles GunaTileButton9.Click
        Dim filesize As UInt32
        Dim mstream As New System.IO.MemoryStream
        PF_SIGN.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrimage() As Byte = mstream.GetBuffer
        filesize = mstream.Length
        mstream.Close()

        Dim par As String
        If SIG_Txt_f_name.Text = Nothing Or SIG_Txt_m_name.Text = Nothing Or SIG_Txt_l_name.Text = Nothing Or SIG_Txt_Email.Text = Nothing Or SIG_Txt_sell.Text = Nothing Or SIG_Txt_pass.Text = Nothing Or SIG_Txt_cpass.Text = Nothing Then
            MessageBox.Show("Fill all details.",
                           "Error code 406",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Exclamation,
                           MessageBoxDefaultButton.Button1)
        Else
            par = "^([0-9a-zA-Z]([-\.\W]*[0-9a-zA-Z]*@[0-9a-zA-Z]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
            If Regex.IsMatch(SIG_Txt_Email.Text, par) Then
                If SIG_Txt_cpass.Text.Equals(SIG_Txt_pass.Text) Then
                    If Internet.connection() = True Then
                        'Dim Tempdt_email As Integer = Data_all.Insert_check_email(SIG_Txt_Email.Text)
                        If Data_all.Insert_check_email(SIG_Txt_Email.Text) >= 1 Then
                            sing_e4.Text = "That Email Id is taken.Try another"
                            SIG_Txt_Email.Clear()
                        ElseIf Data_all.Insert_check_email(SIG_Txt_Email.Text) = -1 Then
                            MessageBox.Show("Oops! Something went wrong.",
                                 "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation,
                                  MessageBoxDefaultButton.Button1)
                        Else
                            'Dim Tempdt_sid As Integer = Data_all.Insert_check_sid(SIG_Txt_sell.Text)
                            If Data_all.Insert_check_sid(SIG_Txt_sell.Text) >= 1 Then
                                sing_e5.Text = "That Customer Id is taken.Try another"
                                SIG_Txt_sell.Clear()
                            ElseIf Data_all.Insert_check_sid(SIG_Txt_sell.Text) = -1 Then
                                MessageBox.Show("Oops! Something went wrong.",
                                 "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation,
                                  MessageBoxDefaultButton.Button1)
                            Else
                                'Data_value = Data_all.Insert(SIG_Txt_f_name.Text, SIG_Txt_m_name.Text, SIG_Txt_l_name.Text, SIG_Txt_Email.Text, SIG_Txt_sell.Text, SIG_Txt_pass.Text, arrimage)
                                If Data_all.Insert(SIG_Txt_f_name.Text, SIG_Txt_m_name.Text, SIG_Txt_l_name.Text, SIG_Txt_Email.Text, SIG_Txt_sell.Text, SIG_Txt_pass.Text, arrimage) = True Then
                                    MessageBox.Show("ACCOUNT HAS BEEN CREATED.",
                                            "Important Message")
                                    LGN_Btn_1_Click(sender, e)
                                Else
                                    MessageBox.Show("Oops! Something went wrong.",
                                       "Error Code 400",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1)
                                End If
                            End If
                        End If
                    Else
                        Error_panel_mp_base1.BringToFront()
                        err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."
                    End If

                Else
                    sing_e6.Text = "Password do not match"
                    SIG_Txt_cpass.Clear()
                End If
            Else
                sing_e4.Text = "Email is Not-valid"
                SIG_Txt_Email.Clear()
            End If
        End If

    End Sub
    ' Forget  base p3 submit btn
    Private Sub GunaTileButton5_Click(sender As Object, e As EventArgs) Handles GunaTileButton5.Click ' Forget_base3 _ send otp btn
        otp = Ran.Next(1000, 9999)
        ' Dim Tempotp As Integer = otp
        If Internet.connection() = True Then
            If Internet.Sendemail(otp, Data_all.temp_eid) = True Then
                FORGET_MP_BASE_4.BringToFront()
                FORGET_Txt_OTP.Clear()
            Else
                'MessageBox.Show("Oops! Something went wrong.",
                '			"Error",
                '			 MessageBoxButtons.OK,
                '			 MessageBoxIcon.Exclamation,
                '			 MessageBoxDefaultButton.Button1)

                Error_panel_mp_base1.BringToFront()
                err_all.Text = "Oops! Something went wrong."
            End If
        Else
            'MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
            '					"No Internet Connection",
            '					 MessageBoxButtons.OK,
            '					 MessageBoxIcon.Exclamation,
            '					 MessageBoxDefaultButton.Button1)
            Error_panel_mp_base1.BringToFront()
            err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."
        End If

    End Sub

    'Body_load mainpanel1 login  front
    Private Sub Body_Load(sender As Object, e As EventArgs) Handles Me.Load

        MainPanel_1.BringToFront()
        LGN_Btn_1_Click(sender, e)
        Dim date_ As String = Nothing
        Dim Date_info As DateTimeFormatInfo
        Dim Date_style As String = "ddd, dd MMM yyyy"
        Date_info = DateTimeFormatInfo.InvariantInfo
        date_ = DateTime.Now.ToString(Date_style, Date_info)
        GunaLabel43.Text = date_
        Time.Start()


        'MainPanel_2.BringToFront()
        'Bookshelf_panel_2.BringToFront()
    End Sub
    ' Show time  function
    Private Function mytime(ByVal value As Integer) As String
        Return value.ToString().PadLeft(2, "0")
    End Function
    ' SHOW TIME
    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles Time.Tick
        Dim time As String = ""
        time &= mytime(DateTime.Now.Hour)
        time &= ":" & mytime(DateTime.Now.Minute)
        time &= ":" & mytime(DateTime.Now.Second)
        GunaLabel42.Text = time
    End Sub
    'close_btn_titlepanel
    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Temp_clear()
        End
    End Sub

    ' login _ btn _sidepanel
    Private Sub LGN_Btn_1_Click(sender As Object, e As EventArgs) Handles LGN_Btn_1.Click
        LOGIN_Txt_Id.Clear()
        LOGIN_Txt_pass.Clear()
        LOGIN_MP_Base_1.BringToFront()
        LGN_Btn_1.Enabled = False
        SIP_btn_1.Enabled = True
        ABOUTUS_Btn_1.Enabled = True
        HELP_Btn_1.Enabled = True
        LOGIN_ERR_U.Text = Nothing
        LOGIN_ERR_P.Text = Nothing
        Me.Guna2CirclePictureBox2.Image = Global.BKSTORE.My.Resources.Resources.icons8_male_user_100__1_
        If Internet.connection = False Then
            Error_panel_mp_base1.BringToFront()
            err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."
        End If

    End Sub
    ' singup panel and err and textbox clear
    Private Sub Clear_singup()
        SIG_Txt_f_name.Clear()
        SIG_Txt_m_name.Clear()
        SIG_Txt_l_name.Clear()
        SIG_Txt_Email.Clear()
        SIG_Txt_sell.Clear()
        SIG_Txt_pass.Clear()
        SIG_Txt_cpass.Clear()
        Me.PF_SIGN.Image = Global.BKSTORE.My.Resources.Resources.icons8_male_user_100__1_
        sing_e1.Text = Nothing
        sing_e2.Text = Nothing
        sing_e3.Text = Nothing
        sing_e4.Text = Nothing
        sing_e5.Text = Nothing
        sing_e6.Text = Nothing

    End Sub
    ' Singup_btn_sidepane
    Private Sub SIP_btn_1_Click(sender As Object, e As EventArgs) Handles SIP_btn_1.Click
        Clear_singup()
        SIGNUP_MP_Base_1.BringToFront()
        LGN_Btn_1.Enabled = True
        SIP_btn_1.Enabled = False
        ABOUTUS_Btn_1.Enabled = True
        HELP_Btn_1.Enabled = True
        If Internet.connection = False Then
            Error_panel_mp_base1.BringToFront()
            err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."
        End If
    End Sub
    ' aboutus_sidepanel
    Private Sub ABOUTUS_Btn_1_Click(sender As Object, e As EventArgs) Handles ABOUTUS_Btn_1.Click
        ABOUTUS_MP_BASE_1.BringToFront()
        LGN_Btn_1.Enabled = True
        SIP_btn_1.Enabled = True
        ABOUTUS_Btn_1.Enabled = False
        HELP_Btn_1.Enabled = True
        If Internet.connection = False Then
            Error_panel_mp_base1.BringToFront()
            err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."
        End If
    End Sub

    'Help_btn_sidepanel
    Private Sub HELP_Btn_1_Click(sender As Object, e As EventArgs) Handles HELP_Btn_1.Click 'Help_btn_sidepanel
        HELP_MP_BASE_1.BringToFront()
        LGN_Btn_1.Enabled = True
        SIP_btn_1.Enabled = True
        ABOUTUS_Btn_1.Enabled = True
        HELP_Btn_1.Enabled = False
        If Internet.connection = False Then
            Error_panel_mp_base1.BringToFront()
            err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."
        End If
    End Sub
    'Forget_click_on LoginMpbase1
    Private Sub LOGIN_LNKLbl_1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LOGIN_LNKLbl_1.LinkClicked


        FORGET_MP_BASE_1.BringToFront()
        f1_eid_err.Text = Nothing
        f1_uid_err.Text = Nothing
        SELLER_Txt_ID.Clear()
        SELLER_Txt_EMAIL.Clear()
        LGN_Btn_1.Enabled = True
    End Sub
    ' Cancel_forget_b1
    Private Sub GunaTileButton2_Click(sender As Object, e As EventArgs) Handles GunaTileButton2.Click
        LGN_Btn_1_Click(sender, e)
    End Sub
    ' submit_forget_b1
    Private Sub GunaTileButton1_Click(sender As Object, e As EventArgs) Handles GunaTileButton1.Click
        f1_uid_err.Text = Nothing
        f1_eid_err.Text = Nothing
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\W]*[0-9a-zA-Z]*@[0-9a-zA-Z]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Internet.connection = True Then

            If Regex.IsMatch(SELLER_Txt_EMAIL.Text, par) Then

                LGN_Btn_1.Enabled = False
                SIP_btn_1.Enabled = False
                ABOUTUS_Btn_1.Enabled = False
                HELP_Btn_1.Enabled = False
                GunaProgressBar1.Value = 0
                FORGET_MP_BASE_2.BringToFront()
                F_P_pro.Start()
            Else
                f1_eid_err.Text = "Email is Not-valid"
                SELLER_Txt_EMAIL.Clear()
            End If
        Else
            Error_panel_mp_base1.BringToFront()
            err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."
        End If

    End Sub
    'Progress bar timer
    Private Sub F_W_pro_Tick(sender As Object, e As EventArgs) Handles F_P_pro.Tick ' Timer for the progress bar 
        GunaProgressBar1.Increment(1)
        FORGET_Lbl_NUM.Text = GunaProgressBar1.Value & "%"
        F_P_pro.Interval = 200



        If GunaProgressBar1.Value = 25 Then
            If Internet.connection = False Then
                F_P_pro.Stop()
                FORGET_Lbl_NUM.Text = 0
                GunaProgressBar1.Value = 0
                FORGET_MP_BASE_1.BringToFront()
                Error_panel_mp_base1.BringToFront()
                err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."

            End If
        End If
        If GunaProgressBar1.Value = 50 Then
            Temp_sid_forget = Data_all.Insert_check_sid(SELLER_Txt_ID.Text)
        End If
        If GunaProgressBar1.Value = 75 Then
            Temp_forget = Data_all.Forget_password(SELLER_Txt_ID.Text, SELLER_Txt_EMAIL.Text)
        End If
        If GunaProgressBar1.Value = 100 Then
            F_P_pro.Stop()
            FORGET_Lbl_NUM.Text = 0
            GunaProgressBar1.Value = 0

            If Temp_sid_forget = 1 Then
                If Temp_forget = 1 Then
                    FORGET_Txt_NAME.Enabled = True
                    FORGET_Txt_EMAILID.Enabled = True
                    FORGET_Txt_USERID.Enabled = True

                    FORGET_Txt_NAME.Text = Data_all.temp_fname + " " + Data_all.temp_mname + " " + Data_all.temp_lname
                    FORGET_Txt_EMAILID.Text = Data_all.temp_eid
                    FORGET_Txt_USERID.Text = Data_all.temp_sid
                    Dim mstream As New System.IO.MemoryStream(Data_all.temp_pp)
                    PTB_FORGET_CHECK_1.Image = System.Drawing.Image.FromStream(mstream)

                    FORGET_Txt_NAME.Enabled = False
                    FORGET_Txt_EMAILID.Enabled = False
                    FORGET_Txt_USERID.Enabled = False
                    F_P_pro.Stop()
                    FORGET_Lbl_NUM.Text = 0
                    GunaProgressBar1.Value = 0
                    FORGET_MP_BASE_3.BringToFront()
                    LGN_Btn_1.Enabled = True
                    SIP_btn_1.Enabled = True
                    ABOUTUS_Btn_1.Enabled = True
                    HELP_Btn_1.Enabled = True
                ElseIf Temp_forget = -1 Then
                    MessageBox.Show("Oops! Something went wrong.",
                            "Error",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
                    F_P_pro.Stop()
                    FORGET_Lbl_NUM.Text = 0
                    GunaProgressBar1.Value = 0
                    FORGET_MP_BASE_1.BringToFront()
                ElseIf Temp_forget > 1 Then
                    MessageBox.Show("Something fishy with your account ! Please contact spacetech_suport24X7@gmail.com.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                    F_P_pro.Stop()
                    FORGET_Lbl_NUM.Text = 0
                    GunaProgressBar1.Value = 0
                    FORGET_MP_BASE_1.BringToFront()
                Else
                    F_P_pro.Stop()
                    FORGET_Lbl_NUM.Text = 0
                    GunaProgressBar1.Value = 0
                    f1_eid_err.Text = "The Email Id you have entered is invalid !"
                    FORGET_MP_BASE_1.BringToFront()
                    SELLER_Txt_EMAIL.Clear()


                End If


            ElseIf Temp_sid_forget > 1 Then
                MessageBox.Show("Something fishy with your account ! Please contact spacetech_suport24X7@gmail.com.",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button1)
                F_P_pro.Stop()
                FORGET_Lbl_NUM.Text = 0
                GunaProgressBar1.Value = 0
                FORGET_MP_BASE_1.BringToFront()
            ElseIf Temp_sid_forget = -1 Then
                MessageBox.Show("Oops! Something went wrong.",
                           "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
                F_P_pro.Stop()
                FORGET_Lbl_NUM.Text = 0
                GunaProgressBar1.Value = 0
                FORGET_MP_BASE_1.BringToFront()
            Else
                MessageBox.Show("The Seller ID you have entered is invalid !",
                              "Important Note",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Exclamation,
                              MessageBoxDefaultButton.Button1)
                F_P_pro.Stop()
                FORGET_Lbl_NUM.Text = 0
                GunaProgressBar1.Value = 0
                FORGET_MP_BASE_1.BringToFront()
                SELLER_Txt_ID.Clear()

            End If
        End If

    End Sub
    ' forget base 3 cancel 
    Private Sub GunaTileButton6_Click(sender As Object, e As EventArgs) Handles GunaTileButton6.Click ' forget _base3 _ cancel 
        LGN_Btn_1_Click(sender, e)
    End Sub
    ' forget base 4 cancel
    Private Sub GunaTileButton3_Click(sender As Object, e As EventArgs) Handles GunaTileButton3.Click ' forget _base4 _ cancel 
        LGN_Btn_1_Click(sender, e)
    End Sub
    ' Resend otp  Forget 4
    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked ' forget _base4 _ resend
        Dim Totp As Integer = otp
        otp = Ran.Next(1000, 9999)
        If Internet.connection = True Then
            If Internet.Sendemail(otp, Data_all.temp_eid) = True Then
                MessageBox.Show("Otp has been send.",
                           "Important Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show("Oops! Something went wrong.",
                           "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
                Error_panel_mp_base1.BringToFront()
                err_all.Text = "Oops! Something went wrong."
                otp = Totp
                FORGET_Txt_OTP.Clear()
            End If
        Else
            'MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
            '                  "No Internet Connection",
            'MessageBoxButtons.OK,
            ' MessageBoxIcon.Exclamation,
            'MessageBoxDefaultButton.Button1)
            Error_panel_mp_base1.BringToFront()
            err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."
        End If

    End Sub
    ' Forget 5 submit
    Private Sub GunaTileButton4_Click(sender As Object, e As EventArgs) Handles GunaTileButton4.Click ' forget _base4 _ submit
        If Internet.connection = True Then
            If otp.ToString.Equals(FORGET_Txt_OTP.Text) Then

                FORGET_MP_BASE_5.BringToFront()
                GunaTextBox2.Clear()
                GunaTextBox1.Clear()
            Else
                'MessageBox.Show("The OTP you entered is invalid, Please enter the correct OTP.",
                '          "Error",
                '           MessageBoxButtons.OK,
                '           MessageBoxIcon.Exclamation,
                '           MessageBoxDefaultButton.Button1)
                Error_panel_mp_base1.BringToFront()
                err_all.Text = "The OTP you entered is invalid, Please enter the correct OTP."
                FORGET_Txt_OTP.Clear()
            End If
        Else
            'MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
            '               "No Internet Connection",
            '                MessageBoxButtons.OK,
            '                MessageBoxIcon.Exclamation,
            '                MessageBoxDefaultButton.Button1)
            Error_panel_mp_base1.BringToFront()
            err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."
        End If

        '  FORGET_MP_BASE_5.BringToFront()
    End Sub
    'Forget Base 5 cancel 
    Private Sub GunaTileButton8_Click(sender As Object, e As EventArgs) Handles GunaTileButton8.Click ' forget _base5 _ cancel
        LGN_Btn_1_Click(sender, e)
    End Sub
    'Forget Base 5 Submit
    Private Sub GunaTileButton7_Click(sender As Object, e As EventArgs) Handles GunaTileButton7.Click ' forget _base5 _ submit

        If Internet.connection() = True Then
            If GunaTextBox2.Text.Equals(GunaTextBox1.Text) Then
                If Data_all.Password_reset(Data_all.temp_id, GunaTextBox1.Text) = True Then
                    MessageBox.Show("PASSWORD HAS BEEN CHANGED.")
                    LGN_Btn_1_Click(sender, e)
                    Temp_clear()
                Else
                    'MessageBox.Show("Oops! Something went wrong. ",
                    '     "Error",
                    '      MessageBoxButtons.OK,
                    '      MessageBoxIcon.Exclamation,
                    '      MessageBoxDefaultButton.Button1)
                    Error_panel_mp_base1.BringToFront()
                    err_all.Text = "Oops! Something went wrong."
                End If
            Else
                'MessageBox.Show("Password Didn't Match. ",
                '                  "Error",
                '                   MessageBoxButtons.OK,
                '                   MessageBoxIcon.Exclamation,
                '                   MessageBoxDefaultButton.Button1)
                Error_panel_mp_base1.BringToFront()
                err_all.Text = "Password Didn't Match."
                GunaTextBox1.Clear()

            End If
        Else

            'MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
            '               "No Internet Connection",
            '                MessageBoxButtons.OK,
            '                MessageBoxIcon.Exclamation,
            '                MessageBoxDefaultButton.Button1)
            Error_panel_mp_base1.BringToFront()
            err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."
        End If




    End Sub
    'clear btn singup panel
    Private Sub GunaTileButton10_Click(sender As Object, e As EventArgs) Handles GunaTileButton10.Click ' Singup_clear_btn
        Clear_singup()
    End Sub
    ' Select pic Signup pannel mp1
    Private Sub PF_SIGN_btn_Click(sender As Object, e As EventArgs) Handles PF_SIGN_btn.Click ' Singup_pic_select
        Singup_pic.ShowDialog()

    End Sub
    ' Select pic Signup pannel mp1
    Private Sub Singup_pic_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Singup_pic.FileOk ' show pic in piture box 
        PF_SIGN.Image = Image.FromFile(Singup_pic.FileName)
    End Sub
    ' Hide Show The Password
    Private Sub LOGIN_SHOW_HID_Btn_Click(sender As Object, e As EventArgs) Handles LOGIN_SHOW_HID_Btn.Click
        If LOGIN_Txt_pass.UseSystemPasswordChar = True Then
            Me.LOGIN_Txt_pass.UseSystemPasswordChar = False
            Me.LOGIN_Txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(Nothing)
            Me.LOGIN_SHOW_HID_Btn.Image = Global.BKSTORE.My.Resources.Resources.icons8_hide_96
        ElseIf LOGIN_Txt_pass.UseSystemPasswordChar = False Then
            Me.LOGIN_Txt_pass.UseSystemPasswordChar = True
            Me.LOGIN_SHOW_HID_Btn.Image = Global.BKSTORE.My.Resources.Resources.icons8_eye_96
        End If
    End Sub
    'LOGIN BTN 
    Private Sub LOGIN_Btn_1_Click(sender As Object, e As EventArgs) Handles LOGIN_Btn_1.Click
        Error_panel_mp_base1.SendToBack()
        LOGIN_ERR_U.Text = Nothing
        LOGIN_ERR_P.Text = Nothing
        If Internet.connection = True Then
            If Data_all.Insert_check_sid(LOGIN_Txt_Id.Text) = 1 Then
                Dim mstream As New System.IO.MemoryStream(Data_all.temp_pp)
                Guna2CirclePictureBox2.Image = System.Drawing.Image.FromStream(mstream)
                If Data_all.Login(LOGIN_Txt_Id.Text, LOGIN_Txt_pass.Text) = 1 Then
                    MessageBox.Show("Login Done Successfully. ",
                                        "Important Note")

                    MainPanel_2.BringToFront()
                    Home_lab_mp2_Click(sender, e)


                ElseIf Data_all.Login(LOGIN_Txt_Id.Text, LOGIN_Txt_pass.Text) > 1 Then
                    Error_panel_mp_base1.BringToFront()
                    err_all.Text = "Something is fishy with your account ! Please contact spacetech_suport24X7@gmail.com."

                ElseIf Data_all.Login(LOGIN_Txt_Id.Text, LOGIN_Txt_pass.Text) = -1 Then
                    Error_panel_mp_base1.BringToFront()
                    err_all.Text = "Oops! Something went wrong."
                Else
                    LOGIN_ERR_P.Text = "The password you have entered is invalid !"
                    LOGIN_Txt_pass.Clear()
                End If
            ElseIf Data_all.Insert_check_sid(LOGIN_Txt_Id.Text) > 1 Then
                Error_panel_mp_base1.BringToFront()
                err_all.Text = "Something is fishy with your account ! Please contact spacetech_suport24X7@gmail.com."

            ElseIf Data_all.Insert_check_sid(LOGIN_Txt_Id.Text) = -1 Then
                Error_panel_mp_base1.BringToFront()
                err_all.Text = "Oops! Something went wrong."
            Else
                LOGIN_ERR_U.Text = "The Username you have entered is invalid !"
                LOGIN_Txt_Id.Clear()
            End If
        Else
            Error_panel_mp_base1.BringToFront()
            err_all.Text = "Unable to connect to S.B.S Please check the internet connection and try again."
        End If
    End Sub
    ' temp value clear
    Private Sub Temp_clear()
        Data_all.temp_id = 0
        Data_all.temp_fname = ""
        Data_all.temp_mname = ""
        Data_all.temp_lname = ""
        Data_all.temp_eid = ""
        Data_all.temp_pp = Nothing
        Data_all.temp_sid = ""
        Data_all.temp_spass = ""
    End Sub
    ' singup validitation fname
    Private Sub SIG_Txt_f_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SIG_Txt_f_name.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Then
            sing_e1.Text = Nothing
        ElseIf Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
            sing_e1.Text = Nothing
        ElseIf Asc(e.KeyChar) = 8 Then
            sing_e1.Text = Nothing
        Else
            e.Handled = True
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            sing_e1.Text = "Character Only"
        End If
    End Sub
    ' singup validitation mname
    Private Sub SIG_Txt_m_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SIG_Txt_m_name.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Then
            sing_e2.Text = Nothing
        ElseIf Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
            sing_e2.Text = Nothing
        ElseIf Asc(e.KeyChar) = 8 Then
            sing_e2.Text = Nothing
        Else
            e.Handled = True
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            sing_e2.Text = "Character Only"
        End If
    End Sub
    ' singup validitation lname
    Private Sub SIG_Txt_l_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SIG_Txt_l_name.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Then
            sing_e3.Text = Nothing
        ElseIf Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
            sing_e3.Text = Nothing
        ElseIf Asc(e.KeyChar) = 8 Then
            sing_e3.Text = Nothing
        Else
            e.Handled = True
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            sing_e3.Text = "Character Only"
        End If
    End Sub
    'MP2 HOMEPANNEL pannel
    Private Sub Home_lab_mp2_Click(sender As Object, e As EventArgs) Handles Home_lab_mp2.Click, Home_btn_mp2.Click
        If Internet.connection = True Then
            Home_pannel_2.BringToFront()
        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                           "No Internet Connection",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
        End If
    End Sub
    'MP2 Bookshelf pannel
    Private Sub BookShelf_btn_mP2_Click(sender As Object, e As EventArgs) Handles BookShelf_lbl_mP2.Click, BookShelf_btn_mP2.Click
        If Internet.connection = True Then
            Bookshelf_panel_2.BringToFront()
        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                           "No Internet Connection",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
        End If
    End Sub
    'MP2 ODER pannel
    Private Sub Oder_btn_Mp2_Click(sender As Object, e As EventArgs) Handles Oder_lbl_Mp2.Click, Oder_btn_Mp2.Click
        If Internet.connection = True Then
            Orders_panel_2.BringToFront()
        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                           "No Internet Connection",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
        End If
    End Sub
    'MP2 Requests pannel
    Private Sub Requests_btn_mP2_Click(sender As Object, e As EventArgs) Handles Requests_lbl_mP2.Click, Requests_btn_mP2.Click
        If Internet.connection = True Then
            Request_panel_2.BringToFront()
        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                           "No Internet Connection",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
        End If
    End Sub
    'MP2 Settings pannel
    Private Sub Settings_lbl_mp2_Click(sender As Object, e As EventArgs) Handles Settings_lbl_mp2.Click, Settings_btn_mP2.Click
        If Internet.connection = True Then
            AccSetting_panel_2.BringToFront()
        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                           "No Internet Connection",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
        End If
    End Sub
    'Mp2 Logout button 
    Private Sub Lougout_btn_mP2_Click(sender As Object, e As EventArgs) Handles Lougout_btn_mP2.Click, Logout_lbl_mP2.Click
        MainPanel_1.BringToFront()
        LGN_Btn_1_Click(sender, e)
    End Sub
End Class
