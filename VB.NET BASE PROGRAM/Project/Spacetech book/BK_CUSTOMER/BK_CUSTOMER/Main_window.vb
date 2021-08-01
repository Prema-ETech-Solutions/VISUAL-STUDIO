Imports System.Text.RegularExpressions
Public Class Body
    Dim Otp As Integer
    ReadOnly Ran As New Random
    ReadOnly Inter_connect As New Internet
    Dim Inter_value As Boolean
    ReadOnly Data_all As New Database
    Public Data_value As Boolean


    ' forget panel
    Dim Temp_cid_forget As Integer = 0
    Dim Temp_forget As Integer = 0


    ' temp value clear
    Private Sub Temp_clear()
        Data_all.temp_id = 0
        Data_all.temp_fname = ""
        Data_all.temp_mname = ""
        Data_all.temp_lname = ""
        Data_all.temp_eid = ""
        Data_all.temp_pn = 0
        Data_all.temp_cid = ""
        Data_all.temp_cpass = ""
    End Sub
    ' hide show password Login Panel
    Private Sub LG_Btn_SHOW_HID_Click(sender As Object, e As EventArgs) Handles LG_Btn_SHOW_HID.Click
        If LG_Txt_PASS.UseSystemPasswordChar = True Then
            Me.LG_Txt_PASS.UseSystemPasswordChar = False
            Me.LG_Txt_PASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(Nothing)
            Me.LG_Btn_SHOW_HID.Image = Global.BK_CUSTOMER.My.Resources.Resources.icons8_hide_96


        ElseIf LG_Txt_PASS.UseSystemPasswordChar = False Then
            Me.LG_Txt_PASS.UseSystemPasswordChar = True
            Me.LG_Btn_SHOW_HID.Image = Global.BK_CUSTOMER.My.Resources.Resources.icons8_eye_96
        End If
    End Sub
    ' Timer For Progress Bar of Forget
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GunaProgressBar1.Increment(2)
        Timer1.Interval = 200
        FORGET_PERCENT_1.Text = GunaProgressBar1.ProgressPercentText

        If GunaProgressBar1.Value = 100 Then
            Timer1.Stop()
            GunaProgressBar1.Value = 0

            If Temp_cid_forget = 1 Then
                If Temp_forget = 1 Then

                    FORGET_NAME_Txt.Enabled = True
                    FORGET_EMAIL_Txt.Enabled = True
                    FORGET_USERID_Txt.Enabled = True
                    FORGET_PHNO_Txt.Enabled = True


                    FORGET_NAME_Txt.Text = Data_all.temp_fname + " " + Data_all.temp_mname + " " + Data_all.temp_lname
                    FORGET_EMAIL_Txt.Text = Data_all.temp_eid
                    FORGET_USERID_Txt.Text = Data_all.temp_cid
                    FORGET_PHNO_Txt.Text = Data_all.temp_pn


                    FORGET_NAME_Txt.Enabled = False
                    FORGET_EMAIL_Txt.Enabled = False
                    FORGET_USERID_Txt.Enabled = False
                    FORGET_PHNO_Txt.Enabled = False

                    FORGET_MP_BASE_3.BringToFront()

                ElseIf Temp_forget = -1 Then
                    MessageBox.Show("Oops! Something went wrong.",
                            "Error",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
                    FORGET_MP_Base_1.BringToFront()
                ElseIf Temp_forget > 1 Then
                    ' MessageBox.Show("Something fishy with your account ! Please contact spacetech_suport24X7@gmail.com.",
                    '           "Error",
                    'MessageBoxButtons.OK,
                    'MessageBoxIcon.Exclamation,
                    'MessageBoxDefaultButton.Button1)
                    err_eid_forget_1.Text = "Something fishy with your EmailId ! Please contact spacetech_suport24X7@gmail.com."
                    FORGET_MP_Base_1.BringToFront()
                Else
                    err_eid_forget_1.Text = "The Email Id you have entered is invalid !"
                    FORGET_MP_Base_1.BringToFront()
                    FORGET_EMAILID_Txt.Clear()
                End If
            ElseIf Temp_cid_forget > 1 Then
                'MessageBox.Show("Something fishy with your account ! Please contact spacetech_suport24X7@gmail.com.",
                '              "Error",
                'MessageBoxButtons.OK,
                'MessageBoxIcon.Exclamation,
                'MessageBoxDefaultButton.Button1)
                err_cid_forget_1.Text = "Something fishy with your UserId ! Please contact spacetech_suport24X7@gmail.com."
                FORGET_MP_Base_1.BringToFront()
            ElseIf Temp_cid_forget = -1 Then
                MessageBox.Show("Oops! Something went wrong.",
                            "Error",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
                FORGET_MP_Base_1.BringToFront()

            Else
                err_cid_forget_1.Text = "The Customer ID you have entered is invalid !"
                FORGET_MP_Base_1.BringToFront()
                FORGET_USERNAME_Txt.Clear()
            End If
        End If
    End Sub
    ' Title Panel Close Btn
    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Temp_clear()
        End
    End Sub
    ' Login forget password 
    Private Sub Login_Forget_panel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Login_Forget_panel.LinkClicked
        If Inter_connect.Connect_internet = True Then
            FORGET_MP_Base_1.BringToFront()
            FORGET_USERNAME_Txt.Clear()
            FORGET_EMAILID_Txt.Clear()
            err_cid_forget_1.Text = Nothing
            err_eid_forget_1.Text = Nothing
        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                            "No Internet Connection",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
        End If



    End Sub
    ' Forget Base1 cancel
    Private Sub FORGET_PASSCANCEL_Btn_1_Click(sender As Object, e As EventArgs) Handles FORGET_PASSCANCEL_Btn_1.Click
        LOGIN_MP_Base_1.BringToFront()
        LG_Txt_Cid.Clear()
        LG_Txt_PASS.Clear()
        err_uid_login.Text = Nothing
        err_pass_login.Text = Nothing
    End Sub
    ' Forget Base1 Submit
    Private Sub FORGET_PASSSUBMIT_Btn_1_Click(sender As Object, e As EventArgs) Handles FORGET_PASSSUBMIT_Btn_1.Click

        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\W]*[0-9a-zA-Z]*@[0-9a-zA-Z]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(FORGET_EMAILID_Txt.Text, par) Then
            If Inter_connect.Connect_internet = True Then
                Temp_cid_forget = Data_all.Insert_check_cid(FORGET_USERNAME_Txt.Text)
                Temp_forget = Data_all.Forget_password(FORGET_USERNAME_Txt.Text, FORGET_EMAILID_Txt.Text)
                FORGET_MP_BASE_2.BringToFront()
                Timer1.Start()
            Else
                MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                               "No Internet Connection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
            End If
        Else
            '  MsgBox("", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Not-Validate")
            err_eid_forget_1.Text = "Email is Not-valid"

        End If


    End Sub
    ' FORM BODY LOAD
    Private Sub Body_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Main_Panel_2.BringToFront()
        Main_Panel_1.BringToFront()
        FORGET_PASSCANCEL_Btn_1_Click(sender, e)

    End Sub
    ' Forget Base3 _ cancel
    Private Sub FORGET_CANCEL_Btn_1_Click(sender As Object, e As EventArgs) Handles FORGET_CANCEL_Btn_1.Click
        FORGET_PASSCANCEL_Btn_1_Click(sender, e)
    End Sub
    ' Forget Base3 _ SEND OTP
    Private Sub FORGET_SENDOTP_Btn_1_Click(sender As Object, e As EventArgs) Handles FORGET_SENDOTP_Btn_1.Click
        Otp = Ran.Next(1000, 9999)


        If Inter_connect.Connect_internet = True Then
            If Inter_connect.Sendemail(Otp, Data_all.temp_eid) = True Then
                GunaLabel98.Text = Nothing
                FORGET_MP_BASE_4.BringToFront()
                GunaTextBox5.Clear()
            Else
                MessageBox.Show("Oops! Something went wrong.",
                            "Error",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
            End If
        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                            "No Internet Connection",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
        End If
    End Sub
    ' Forget Base4  Cancel
    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        FORGET_PASSCANCEL_Btn_1_Click(sender, e)
    End Sub
    'Forget Base 4 resend
    Private Sub GunaLinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel5.LinkClicked
        Otp = Ran.Next(1000, 9999)

        If Inter_connect.Connect_internet = True Then

            If Inter_connect.Sendemail(Otp, Data_all.temp_eid) = True Then
                MessageBox.Show("Otp has been send.",
                            "Important Message",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
                GunaLabel98.Text = Nothing
                GunaTextBox5.Clear()
            Else
                MessageBox.Show("Oops! Something went wrong.",
                            "Error",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
                GunaLabel98.Text = Nothing
            End If
        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                            "No Internet Connection",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
        End If
    End Sub
    'Forget Base 4 submit
    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        If Inter_connect.Connect_internet = True Then
            If Otp.ToString.Equals(GunaTextBox5.Text) Then
                FORGET_MP_BASE_5.BringToFront()
                FORGET_CHANGEPAS_Txt_1.Clear()
                FORGET_CONFIRMPAS_Txt_2.Clear()
                GunaLabel99.Text = Nothing
            Else
                GunaLabel98.Text = "The OTP you entered is invalid, Please enter the correct OTP."
                GunaTextBox5.Clear()
            End If

        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                            "No Internet Connection",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
        End If
    End Sub
    ' Forget Base 5 Cancel
    Private Sub FORGET_CANCELPAS_Btn_1_Click(sender As Object, e As EventArgs) Handles FORGET_CANCELPAS_Btn_1.Click
        FORGET_PASSCANCEL_Btn_1_Click(sender, e)
    End Sub
    ' Forget Base 5 Submit
    Private Sub FORGET_SUBMITPAS_Btn_2_Click(sender As Object, e As EventArgs) Handles FORGET_SUBMITPAS_Btn_2.Click

        If Inter_connect.Connect_internet = True Then
            If FORGET_CHANGEPAS_Txt_1.Text.ToString.Equals(FORGET_CONFIRMPAS_Txt_2.Text) Then
                If Data_all.Password_reset(Data_all.temp_id, FORGET_CHANGEPAS_Txt_1.Text) = True Then
                    MessageBox.Show("PASSWORD HAS BEEN CHANGED.")
                    FORGET_PASSCANCEL_Btn_1_Click(sender, e)
                    Temp_clear()
                Else
                    MessageBox.Show("Oops! Something went wrong. ",
                           "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
                End If

            Else
                GunaLabel99.Text = "Password Didn't Match."
                FORGET_CONFIRMPAS_Txt_2.Clear()
            End If
        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                            "No Internet Connection",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
        End If


    End Sub
    ' Login_ Singup btn
    Private Sub Singup_Btn_login_Click(sender As Object, e As EventArgs) Handles Singup_Btn_login.Click
        If Inter_connect.Connect_internet() = True Then
            SIGNUP_MP_BASE_1.BringToFront()
            Clear_btn_singup()
        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                            "Error code 137",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
        End If
    End Sub
    ' Singup Panel Back Btn
    Private Sub Login_back_Btn_Click(sender As Object, e As EventArgs) Handles Login_back_Btn.Click
        FORGET_PASSCANCEL_Btn_1_Click(sender, e)
    End Sub
    ' Singup Panel clear btn
    Private Sub GunaGradientButton5_Click(sender As Object, e As EventArgs) Handles GunaGradientButton5.Click
        Clear_btn_singup()
    End Sub
    ' Singup base1 clear btn sub 
    Private Sub Clear_btn_singup()
        Singup_fn_text.Clear()
        Singup_mn_txt.Clear()
        Singup_ln_txt.Clear()
        Singup_email_txt.Clear()
        Singup_pn_txt.Clear()
        Singup_cid_txt.Clear()
        Singup_pass_txt.Clear()
        Singup_passcon_txt.Clear()
        err_cid_singup.Text = Nothing
        err_email_singup.Text = Nothing
        err_pass_singup.Text = Nothing
        err_phone_no_singup.Text = Nothing

    End Sub
    ' Singup mp base1 submit
    Private Sub GunaGradientButton4_Click(sender As Object, e As EventArgs) Handles GunaGradientButton4.Click

        If Singup_fn_text.Text = Nothing Or Singup_mn_txt.Text = Nothing Or Singup_ln_txt.Text = Nothing Or Singup_email_txt.Text = Nothing Or Singup_pn_txt.Text = Nothing Or Singup_cid_txt.Text = Nothing Or Singup_pass_txt.Text = Nothing Or Singup_passcon_txt.Text = Nothing Then
            MessageBox.Show("Fill all details.",
                            "Error code 406",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
        Else
            err_cid_singup.Text = Nothing
            err_email_singup.Text = Nothing
            err_pass_singup.Text = Nothing
            err_phone_no_singup.Text = Nothing
            Dim par As String
            par = "^([0-9a-zA-Z]([-\.\W]*[0-9a-zA-Z]*@[0-9a-zA-Z]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
            If Regex.IsMatch(Singup_email_txt.Text, par) Then
                If Singup_pass_txt.Text.Equals(Singup_passcon_txt.Text) Then
                    If Inter_connect.Connect_internet = True Then
                        If Data_all.Insert_check_email(Singup_email_txt.Text) >= 1 Then
                            err_email_singup.Text = "That Email Id is taken.Try another"
                            Singup_email_txt.Clear()
                        ElseIf Data_all.Insert_check_email(Singup_email_txt.Text) = -1 Then
                            MessageBox.Show("Oops! Something went wrong.",
                                 "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation,
                                  MessageBoxDefaultButton.Button1)
                        Else
                            If Data_all.Insert_check_cid(Singup_cid_txt.Text) >= 1 Then
                                err_cid_singup.Text = "That Customer Id is taken.Try another"
                            ElseIf Data_all.Insert_check_cid(Singup_cid_txt.Text) = -1 Then
                                MessageBox.Show("Oops! Something went wrong.",
                                 "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation,
                                  MessageBoxDefaultButton.Button1)
                            Else
                                If Singup_pn_txt.Text.Length = 10 Then
                                    If Data_all.check_phone_no(Singup_pn_txt.Text) >= 1 Then
                                        err_phone_no_singup.Text = "That Phone Number is taken.Try another"
                                    ElseIf Data_all.check_phone_no(Singup_pn_txt.Text) = -1 Then

                                        MessageBox.Show("Oops! Something went wrong.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1)

                                    Else
                                        If Data_all.Insert(Singup_fn_text.Text, Singup_mn_txt.Text, Singup_ln_txt.Text, Singup_email_txt.Text, Convert.ToInt64(Singup_pn_txt.Text), Singup_cid_txt.Text, Singup_passcon_txt.Text) = True Then
                                            MessageBox.Show("ACCOUNT HAS BEEN CREATED.",
                                                "Important Message")
                                            FORGET_PASSCANCEL_Btn_1_Click(sender, e)

                                        Else
                                            MessageBox.Show("Oops! Something went wrong.",
                                               "Error Code 400",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation,
                                                MessageBoxDefaultButton.Button1)

                                        End If
                                    End If
                                Else
                                    err_phone_no_singup.Text = "Enter Valid Phone Number"
                                End If
                            End If
                        End If
                    Else
                        MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                                "Error code 137",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation,
                                 MessageBoxDefaultButton.Button1)
                    End If
                Else
                    err_pass_singup.Text = "Password Didn't Match. "
                    Singup_passcon_txt.Clear()
                End If
            Else
                err_email_singup.Text = "Email is Not-valide"
            End If
        End If
    End Sub
    ' Login About us 
    Private Sub GunaLinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel3.LinkClicked

        ABOUTUS_MP_BASE_1.BringToFront()
    End Sub
    'Login help 
    Private Sub GunaLinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel4.LinkClicked
        HELP_MP_BASE_1.BringToFront()
    End Sub
    'about us back btn
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        FORGET_PASSCANCEL_Btn_1_Click(sender, e)
    End Sub
    ' help back btn
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        FORGET_PASSCANCEL_Btn_1_Click(sender, e)
    End Sub
    ' Singup Phone no Text Box only number 
    Private Sub Singup_pn_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Singup_pn_txt.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Asc(e.KeyChar) = 8 Then

        ElseIf Not (Char.IsDigit(c) Or c = "." Or Char.IsControl(c)) Then

            e.Handled = True


            err_phone_no_singup.Text = "ONLY NUMERICS....!"

        ElseIf Singup_pn_txt.TextLength >= 10 Then

            e.Handled = True

            err_phone_no_singup.Text = "10 NUMERICS ONLY"
        End If
    End Sub
    ' Login _ panel _ login_button
    Private Sub Login_btn_login_panel_Click(sender As Object, e As EventArgs) Handles Login_btn_login_panel.Click


        Inter_value = Inter_connect.Connect_internet
        If Inter_connect.Connect_internet = True Then
            If Data_all.Insert_check_cid(LG_Txt_Cid.Text) = 1 Then
                If Data_all.Login(LG_Txt_Cid.Text, LG_Txt_PASS.Text) = 1 Then
                    MessageBox.Show("Login Done Successfully. ",
                                    "Important Note")
                ElseIf Data_all.Login(LG_Txt_Cid.Text, LG_Txt_PASS.Text) > 1 Then
                    MessageBox.Show("Something is fishy with your account ! Please contact spacetech_suport24X7@gmail.com.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)
                ElseIf Data_all.Login(LG_Txt_Cid.Text, LG_Txt_PASS.Text) = -1 Then
                    MessageBox.Show("Oops! Something went wrong.",
                                "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation,
                                 MessageBoxDefaultButton.Button1)

                Else
                    MessageBox.Show("The password you have entered is invalid !",
                                    "Important Note",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)

                    LG_Txt_PASS.Clear()
                End If
            ElseIf Data_all.Insert_check_cid(LG_Txt_Cid.Text) > 1 Then
                MessageBox.Show("Something is fishy with your account ! Please contact spacetech_suport24X7@gmail.com.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)

            ElseIf Data_all.Insert_check_cid(LG_Txt_Cid.Text) = -1 Then
                MessageBox.Show("Oops! Something went wrong.",
                                "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation,
                                 MessageBoxDefaultButton.Button1)

            Else
                MessageBox.Show("The Customer ID you have entered is invalid !",
                                   "Important Note",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation,
                                   MessageBoxDefaultButton.Button1)
                LG_Txt_Cid.Clear()

            End If
        Else
            MessageBox.Show("Unable to connect to S.B.S Please check the internet connection and try again.",
                            "Error code 137",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        categories_main_panel2.BringToFront()
    End Sub
    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        home_main_panel2.BringToFront()
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        contact_main_panel2.BringToFront()
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        request_main_panel2.BringToFront()
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        account_main_panel2.BringToFront()
    End Sub

    Private Sub account_main_panel2_Paint(sender As Object, e As PaintEventArgs)
        account_main_panel2.BringToFront()
    End Sub
    'Singup email_txtbox
    Private Sub Singup_email_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Singup_email_txt.KeyPress
        ' err_email_singup.Text = Nothing
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\W]*[0-9a-zA-Z]*@[0-9a-zA-Z]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(Singup_email_txt.Text, par) Then
            err_email_singup.Text = Nothing
        Else
            err_email_singup.Text = "Email is Not-valide"
        End If
    End Sub
    'singup email_textbox_forget_1
    Private Sub FORGET_EMAILID_Txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FORGET_EMAILID_Txt.KeyPress
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\W]*[0-9a-zA-Z]*@[0-9a-zA-Z]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(FORGET_EMAILID_Txt.Text, par) Then
            err_eid_forget_1.Text = Nothing
        Else
            err_eid_forget_1.Text = "Email is Not-valide"
        End If
    End Sub


End Class
