Imports System.Net.Mail

Public Class Form1
    Dim check As New Checkinternet
    Private Function sendemail() As Boolean
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
            e_mail.To.Add(Email_2.Text)
            e_mail.Subject = Subject.Text
            e_mail.Body = "Welcome To SPACETECH BOOK STORE! 
                          Your E - Mail verification code is_ _ _ _.
                          Please use this OTP and reset the password.
                          Don't Share The OTP "
            Smtp_server.Send(e_mail)
            Return True
        Catch ex As Exception
            Return False
            'MsgBox(ex.Message)
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If check.isconnection() = True Then
            If sendemail() = True Then
                MessageBox.Show("Sent")
            Else
                MessageBox.Show("NOT SENT")
            End If
        Else
                MessageBox.Show("PLEASE CHECK INTERENT")

        End If
    End Sub
End Class
