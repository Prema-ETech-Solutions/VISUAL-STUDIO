Imports MySql.Data.MySqlClient

Public Class Database
    ReadOnly server As String = "localhost"
    ReadOnly userid As String = "root"
    ReadOnly password As String = "@123"
    ReadOnly database As String = "spacetech_bookstores"
    ReadOnly credentials As String = "server = " & server & " ; userid =" & userid & " ; password = " & password & " ; database =" & database
    ReadOnly Database_Connection_credentials As New MySqlConnection(credentials)

    Public temp_id As Int64
    Public temp_fname As String
    Public temp_mname As String
    Public temp_lname As String
    Public temp_eid As String
    Public temp_pn As Int64
    Public temp_cid As String
    Public temp_cpass As String

    Public Function Connect_db() As Boolean
        Try
            Database_Connection_credentials.Open()
            Return True
            Database_Connection_credentials.Close()
        Catch ex As MySqlException
            '  MessageBox.Show(ex.Message)
            Return False
        Finally
            Database_Connection_credentials.Dispose()
        End Try
    End Function

    Public Function Create_table() As Boolean
        Dim Query As String = "CREATE TABLE IF NOT EXISTS customer_login(ID int NOT NULL AUTO_INCREMENT,First_name varchar(100),Middle_name varchar(100),Last_name varchar(100),Email_id varchar(100),Phone_no int8,Customer_id varchar(100),Customer_password varchar(100),PRIMARY KEY (ID));"
        Dim Command As New MySqlCommand(Query, Database_Connection_credentials)
        Try
            Database_Connection_credentials.Open()
            Command.ExecuteNonQuery()

            Return True
            Database_Connection_credentials.Close()

        Catch ex As MySqlException
            '  MessageBox.Show(ex.Message)
            Return False
        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Function

    Public Function Insert(ByVal First_name As String, ByVal Middel_name As String, ByVal Last_name As String, ByVal Email_id As String, ByVal Phone_no As String, ByVal Customer_id As String, ByVal Customer_pass As String) As Boolean

        Dim Query As String = "Insert INTO `spacetech_bookstores`.`customer_login` (`First_name`, `Middle_name`, `Last_name`, `Email_id`, `Phone_no`, `Customer_id`, `Customer_password`) VALUES (@fname, @mname, @lname, @email, @pno, @uname, @pass);"

        Dim command As New MySqlCommand(Query, Database_Connection_credentials)
        command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = First_name
        command.Parameters.Add("@mname", MySqlDbType.VarChar).Value = Middel_name
        command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = Last_name
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email_id
        command.Parameters.Add("@pno", MySqlDbType.Int64).Value = Phone_no
        command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = Customer_id
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Customer_pass
        Try
            Database_Connection_credentials.Open()
            command.ExecuteNonQuery()
            Return True
            Database_Connection_credentials.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Function

    Public Function Insert_check_email(ByVal email As String) As Integer
        Dim Query As String = "select Email_id from customer_login where Email_id =@email"
        Dim command As New MySqlCommand(Query, Database_Connection_credentials)
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
        Dim Read1 As MySqlDataReader
        Try
            Database_Connection_credentials.Open()
            Read1 = command.ExecuteReader
            Dim count As Integer = 0
            While Read1.Read
                count += 1
            End While
            Database_Connection_credentials.Close()
            Return count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        Finally
            Database_Connection_credentials.Dispose()
        End Try
    End Function

    Public Function Insert_check_cid(ByVal cid As String) As Integer
        Dim Query As String = "select Customer_id from customer_login where Customer_id =@cid"
        Dim command As New MySqlCommand(Query, Database_Connection_credentials)
        command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = cid
        Dim Read1 As MySqlDataReader
        Try
            Database_Connection_credentials.Open()
            Read1 = command.ExecuteReader
            Dim count As Integer = 0
            While Read1.Read
                count += 1
            End While
            Database_Connection_credentials.Close()
            Return count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        Finally
            Database_Connection_credentials.Dispose()
        End Try
    End Function

    Public Function Login(ByVal cid As String, ByVal pass As String) As Integer
        Dim Query As String = "select * from customer_login where Customer_id =@cid and Customer_password = @pass"
        Dim command As New MySqlCommand(Query, Database_Connection_credentials)
        command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = cid
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass
        Dim Read1 As MySqlDataReader

        Try
            Database_Connection_credentials.Open()
            Read1 = command.ExecuteReader
            Dim count As Integer = 0
            While Read1.Read
                temp_cid = Read1.GetInt64("ID")
                temp_fname = Read1.GetString("First_name")
                temp_mname = Read1.GetString("Middle_name")
                temp_lname = Read1.GetString("Last_name")
                temp_eid = Read1.GetString("Email_id")
                temp_pn = Read1.GetInt64("Phone_no")
                temp_cid = Read1.GetString("Customer_id")
                temp_cpass = Read1.GetString("Customer_password")
                count += 1
            End While
            Database_Connection_credentials.Close()
            Return count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Function


    Public Function Forget_password(ByVal cid As String, ByVal email As String) As Integer
        Dim Query As String = "select * from customer_login where Customer_id =@cid and Email_id = @email"
        Dim command As New MySqlCommand(Query, Database_Connection_credentials)
        command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = cid
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
        Dim Read1 As MySqlDataReader

        Try
            Database_Connection_credentials.Open()
            Read1 = command.ExecuteReader
            Dim count As Integer = 0
            While Read1.Read
                temp_cid = Read1.GetInt64("ID")
                temp_fname = Read1.GetString("First_name")
                temp_mname = Read1.GetString("Middle_name")
                temp_lname = Read1.GetString("Last_name")
                temp_eid = Read1.GetString("Email_id")
                temp_pn = Read1.GetInt64("Phone_no")
                temp_cid = Read1.GetString("Customer_id")
                temp_cpass = Read1.GetString("Customer_password")
                count += 1
            End While
            Database_Connection_credentials.Close()
            Return count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Function

    Public Function Password_reset(ByVal id As Integer, ByVal pass As String) As Boolean
        Dim Query As String = "UPDATE `spacetech_bookstores`.`customer_login` SET `Customer_password` = @pass WHERE (`ID` = @id);
"
        Dim Command As New MySqlCommand(Query, Database_Connection_credentials)
        Command.Parameters.Add("@id", MySqlDbType.Int64).Value = id
        Command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass
        Try
            Database_Connection_credentials.Open()
            Command.ExecuteNonQuery()

            Return True
            Database_Connection_credentials.Close()

        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
            Return False
        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Function


    Public Function check_phone_no(ByVal phno As String) As Integer
        Dim Query As String = "select Customer_id from customer_login where Phone_no =@Pn"
        Dim command As New MySqlCommand(Query, Database_Connection_credentials)
        command.Parameters.Add("@Pn", MySqlDbType.Int64).Value = phno
        Dim Read1 As MySqlDataReader
        Try
            Database_Connection_credentials.Open()
            Read1 = command.ExecuteReader
            Dim count As Integer = 0
            While Read1.Read
                count += 1
            End While
            Database_Connection_credentials.Close()
            Return count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        Finally
            Database_Connection_credentials.Dispose()
        End Try
    End Function
End Class
