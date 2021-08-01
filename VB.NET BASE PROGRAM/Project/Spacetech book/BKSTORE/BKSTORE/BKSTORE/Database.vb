Imports MySql.Data.MySqlClient

Public Class Database
    Dim server As String = "localhost"
    Dim userid As String = "root"
    Dim password As String = "@123"
    Dim database As String = "spacetech_bookstores"

    Dim credentials As String = "server = " & server & " ; userid =" & userid & " ; password = " & password & " ; database =" & database

    Dim Database_Connection_credentials As New MySqlConnection(credentials)
    Public temp_id As Int64
    Public temp_fname As String
    Public temp_mname As String
    Public temp_lname As String
    Public temp_eid As String
    Public temp_pp As Byte()
    Public temp_sid As String
    Public temp_spass As String
    Public count As Integer = 0


    Public Function Connect() As Boolean
        Try
            Database_Connection_credentials.Open()
            Return True
            Database_Connection_credentials.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Function


    Public Function Create_table() As Boolean
        Dim Query As String = "CREATE TABLE IF NOT EXISTS `spacetech_bookstores`.`seller_login` (ID int NOT NULL AUTO_INCREMENT, `First_name` VARCHAR(50) NULL,`Middle_name` VARCHAR(50) NULL,`Last_name` VARCHAR(50) NULL,`Email_id` VARCHAR(50) NULL,`Seller_id` VARCHAR(50) NULL,`Seller_password` VARCHAR(50) NULL,`Profile_Pic` MEDIUMBLOB NULL,PRIMARY KEY (ID));"
        Dim Command As New MySqlCommand(Query, Database_Connection_credentials)
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
    Public Function Insert(ByVal First_name As String, ByVal Middel_name As String, ByVal Last_name As String, ByVal Email_id As String, ByVal Seller_id As String, ByVal Seller_pass As String, ByVal Seller_pic() As Byte) As Boolean
        Dim Query As String = "Insert INTO `spacetech_bookstores`.`seller_login` (`First_name`, `Middle_name`, `Last_name`, `Email_id`, `Seller_id`, `Seller_password`, `Profile_Pic`) VALUES ( @fname , @mname, @lname , @email, @uname, @pass,@seller_pic);"
        Dim command As New MySqlCommand(Query, Database_Connection_credentials)
        command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = First_name
        command.Parameters.Add("@mname", MySqlDbType.VarChar).Value = Middel_name
        command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = Last_name
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email_id
        command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = Seller_id
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Seller_pass
        command.Parameters.AddWithValue("@seller_pic", Seller_pic)
        Try
            Database_Connection_credentials.Open()
            command.ExecuteNonQuery()
            Return True
            Database_Connection_credentials.Close()

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return False
        Finally
            Database_Connection_credentials.Dispose()
        End Try
    End Function

    Public Function Insert_check_email(ByVal email As String) As Integer
        Dim Query As String = "select Email_id from seller_login where Email_id =@email"
        Dim command As New MySqlCommand(Query, Database_Connection_credentials)
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
        Dim Read1 As MySqlDataReader
        Try
            Database_Connection_credentials.Open()
            Read1 = command.ExecuteReader
            count = 0
            While Read1.Read
                count += 1
            End While
            Database_Connection_credentials.Close()
            Return count
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return -1
        Finally
            Database_Connection_credentials.Dispose()
        End Try
    End Function


    Public Function Insert_check_sid(ByVal sid As String) As Integer

        Dim Query As String = "select Seller_id, Profile_Pic from seller_login where Seller_id = @sid"
        Dim command As New MySqlCommand(Query, Database_Connection_credentials)
        command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = sid

        Dim Read11 As MySqlDataReader
        Try
            Database_Connection_credentials.Open()
            Read11 = command.ExecuteReader
            count = 0
            While Read11.Read
                temp_pp = Read11.Item("Profile_Pic")
                count += 1
            End While
            Database_Connection_credentials.Close()
            Return count
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            Return -1
        Finally
            Database_Connection_credentials.Dispose()
        End Try
    End Function

    Public Function Login(ByVal sid As String, ByVal pass As String) As Integer
        Dim Query As String = "select * from seller_login where Seller_id =@sid and Seller_password = @pass"
        Dim command As New MySqlCommand(Query, Database_Connection_credentials)
        command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = sid
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass
        Dim Read1 As MySqlDataReader

        Try
            Database_Connection_credentials.Open()
            Read1 = command.ExecuteReader
            count = 0
            While Read1.Read
                temp_id = Read1.GetInt64("ID")
                temp_fname = Read1.GetString("First_name")
                temp_mname = Read1.GetString("Middle_name")
                temp_lname = Read1.GetString("Last_name")
                temp_eid = Read1.GetString("Email_id")
                temp_sid = Read1.GetString("Seller_id")
                temp_spass = Read1.GetString("Seller_password")
                temp_pp = Read1.Item("Profile_Pic")
                count += 1
            End While
            Database_Connection_credentials.Close()
            Return count
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return -1
        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Function

    Public Function Forget_password(ByVal sid As String, ByVal email As String) As Integer
        Dim Query As String = "select * from seller_login where Seller_id =@cid and Email_id = @email"
        Dim command As New MySqlCommand(Query, Database_Connection_credentials)
        command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = sid
        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
        Dim Read1 As MySqlDataReader

        Try
            Database_Connection_credentials.Open()
            Read1 = command.ExecuteReader
            count = 0
            While Read1.Read
                temp_id = Read1.GetInt64("ID")
                temp_fname = Read1.GetString("First_name")
                temp_mname = Read1.GetString("Middle_name")
                temp_lname = Read1.GetString("Last_name")
                temp_eid = Read1.GetString("Email_id")
                temp_sid = Read1.GetString("Seller_id")
                temp_spass = Read1.GetString("Seller_password")
                temp_pp = Read1.Item("Profile_Pic")
                count += 1
            End While
            Database_Connection_credentials.Close()
            Return count
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Return -1
        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Function

    Public Function Password_reset(ByVal id As Integer, ByVal pass As String) As Boolean
        Dim Query As String = "UPDATE `spacetech_bookstores`.`seller_login` SET `Seller_password` = @pass WHERE (`ID` = @id);"
        Dim Command As New MySqlCommand(Query, Database_Connection_credentials)
        Command.Parameters.Add("@id", MySqlDbType.Int64).Value = id
        Command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass
        Try
            Database_Connection_credentials.Open()
            Command.ExecuteNonQuery()
            Database_Connection_credentials.Close()

            Return True


        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
            Return False
        Finally
            Database_Connection_credentials.Dispose()
        End Try

    End Function

End Class
