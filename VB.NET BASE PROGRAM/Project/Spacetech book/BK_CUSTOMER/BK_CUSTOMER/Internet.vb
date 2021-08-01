Imports System.Net.Mail
Public Class Internet


    Public Function Connect_internet() As Boolean
        Dim urlobj As New System.Uri("https://www.google.co.in/")
        Dim Webobj As Net.WebRequest
        Webobj = System.Net.WebRequest.Create(urlobj)
        Dim Risobj As System.Net.WebResponse
        Try
            Risobj = Webobj.GetResponse
            Risobj.Close()
            Risobj = Nothing
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function

    Public Function Sendemail(ByVal otp As Integer, ByVal email As String) As Boolean
        Try
            Dim Smtp_server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_server.UseDefaultCredentials = False
            Smtp_server.Credentials = New Net.NetworkCredential("noreplayspacetech@gmail.com", "spacetech@123")
            Smtp_server.Port = 587
            Smtp_server.EnableSsl = True
            Smtp_server.Host = "smtp.gmail.com"
            e_mail = New MailMessage
            e_mail.From = New MailAddress("noreplayspacetech@gmail.com")
            e_mail.To.Add(email)
            e_mail.Subject = "Your verification code is" & otp & "."
            e_mail.Body = "Welcome To SPACETECH BOOK STORE! 
                          Your verification code is" & otp & ".
                          Please use this OTP and reset the password.
                          Don't Share The OTP "
            Smtp_server.Send(e_mail)
            Return True
        Catch ex As Exception
            Return False
            'MsgBox(ex.Message)
        End Try
    End Function


End Class
