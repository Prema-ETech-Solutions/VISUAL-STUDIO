Public Class Checkinternet
    Public Function isconnection() As Boolean
        Dim urlobj As New System.Uri("https://www.google.co.in/")
        Dim webobj As Net.WebRequest
        webobj = System.Net.WebRequest.Create(urlobj)
        Dim risobj As System.Net.WebResponse
        Try
            risobj = webobj.GetResponse
            risobj.Close()
            risobj = Nothing
            Return True
        Catch ex As Exception
            risobj = Nothing
            webobj = Nothing
            Return False
        End Try
    End Function
End Class
