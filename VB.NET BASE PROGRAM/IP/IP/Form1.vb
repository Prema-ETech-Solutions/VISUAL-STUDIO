Imports System.Net

Public Class Form1
    Private Sub Ip_finder_Click(sender As Object, e As EventArgs) Handles Ip_finder.Click
        Dim strHostName As String

        Dim strIPAddress As String



        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()


        MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hostname As IPHostEntry = Dns.GetHostByName(TextBox1.Text)
        Dim ip As IPAddress() = hostname.AddressList
        TextBox2.Text = ip(0).ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As String
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)
        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                result = ipheal.ToString()
            End If

        Next
        Dim wc As New Net.WebClient


        MsgBox(wc.DownloadString("http://icanhazip.com"))
    End Sub
End Class
