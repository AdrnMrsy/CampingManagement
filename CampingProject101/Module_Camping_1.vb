Imports System.Transactions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Org.BouncyCastle.Crypto.Generators

Module Module_Camping_1
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim mysqlcmd2, mysqlcmd3, mysqlcmd4 As New MySqlCommand
    Dim dtTable As New DataTable
    Dim adapter As New MySqlDataAdapter
    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String
    Dim sqlquery2 As String
    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "camping"
        uname = "root"
        pwd = "password"
        ' check if connection if open
        If Not con Is Nothing Then
            con.Close() 'close dbconnection
            con.ConnectionString = "server =" & host & "; user id = " & uname & "; password = " & pwd & "; database =" & dbname & ""
            Try
                ' open connection
                con.Open()
                MessageBox.Show("Connected")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Public Sub login()
        Dim username, password As String
        username = Camping_Login.txtuser.Text
        password = Camping_Login.txtpass.Text
        sqlquery = "SELECT * FROM accounts WHERE Username = @username and Password = @password"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd.Parameters.AddWithValue("@username", username)
        mysqlcmd.Parameters.AddWithValue("@password", password)
        Dim role As String = GetUserRole(username)
        reader = mysqlcmd.ExecuteReader
        If reader.Read Then
            If role = "Camper" Then
                CamperInterface.Show()
                Camping_Login.Hide()
            ElseIf role = "Admin" Then
                AdminInterface.Show()
                Camping_Login.Hide()
            ElseIf role = "Admin" Then
                StaffInterface.Show()
                Camping_Login.Hide()
            End If

        End If

    End Sub
    Public Function GetUserRole(username As String) As String
        Dim query As String = "SELECT Account_Type FROM Accounts WHERE Username=@Username;"
        Using command As New MySqlCommand(query, con)
            command.Parameters.AddWithValue("@Username", username)
            Dim role As Object = command.ExecuteScalar()
            If role IsNot Nothing Then
                Return role.ToString()
            Else
                Return "Unknown"
            End If
        End Using
    End Function
    Public Sub Camper_Registry()
        Dim username, password, confirmpassword, fullname, age, birthday, phonenumber, address As String

        ' SET TO STRING FOR TEXTBOXES
        username = Camper_Registration.txtUsername.Text
        password = Camper_Registration.txtPassword.Text
        confirmpassword = Camper_Registration.txtconfirmPassword.Text
        fullname = Camper_Registration.txtFullName.Text
        age = Camper_Registration.txtAge.Text
        birthday = Camper_Registration.txtBirthday.Text
        phonenumber = Camper_Registration.txtPhoneNum.Text
        address = Camper_Registration.txtAddress.Text
        sqlquery = "INSERT INTO camping.campers(Name, Age, Birthday, Phone_Num, Address) 
                    VALUES (@fullname, @age, @birthday, @phonenumber, @address)"
        sqlquery2 = "INSERT INTO camping.accounts(Username, Password, Account_Type) 
                    VALUES (@username, @password, 'Camper')"
        ' MYSQL COMMAND
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd2 = New MySqlCommand(sqlquery2, con)
        ' PARAMETER VALUES
        ' FOR CAMPERS
        mysqlcmd.Parameters.AddWithValue("@fullname", fullname)
        mysqlcmd.Parameters.AddWithValue("@age", age)
        mysqlcmd.Parameters.AddWithValue("@birthday", birthday)
        mysqlcmd.Parameters.AddWithValue("@phonenumber", phonenumber)
        mysqlcmd.Parameters.AddWithValue("@address", address)
        ' FOR ACCOUNTS
        mysqlcmd2.Parameters.AddWithValue("@username", username)
        mysqlcmd2.Parameters.AddWithValue("@password", password)
        If password = confirmpassword Then
            Try
                ' execute query commadn
                mysqlcmd.ExecuteNonQuery()
                mysqlcmd2.ExecuteNonQuery()
                MsgBox("Registered Successfully")
                Camper_Registration.Hide()
                Camping_Login.Show()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                TextClear()
            End Try
        Else
            MessageBox.Show("Confirm Password does not match!")
        End If
    End Sub
    Public Sub Staff_Registry()
        Dim username, password, confirmpassword, fullname, age, birthday, phonenumber, address As String

        ' SET TO STRING FOR TEXTBOXES
        username = Staff_Registration.txtusername.Text
        password = Staff_Registration.txtpassword.Text
        confirmpassword = Staff_Registration.txtconfirmpassword.Text
        fullname = Staff_Registration.txtfullname.Text
        age = Staff_Registration.txtage.Text
        birthday = Staff_Registration.txtbirthday.Text
        phonenumber = Staff_Registration.txtpassword.Text
        address = Staff_Registration.txtaddress.Text
        sqlquery = "INSERT INTO camping.staff(Name, Age, Birthday, Phone_Num, Address) 
                    VALUES (@fullname, @age, @birthday, @phonenumber, @address)"
        sqlquery2 = "INSERT INTO camping.accounts(Username, Password, Account_Type) 
                    VALUES (@username, @password, 'Staff')"
        ' MYSQL COMMAND
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd2 = New MySqlCommand(sqlquery2, con)
        ' PARAMETER VALUES
        ' FOR CAMPERS
        mysqlcmd.Parameters.AddWithValue("@fullname", fullname)
        mysqlcmd.Parameters.AddWithValue("@age", age)
        mysqlcmd.Parameters.AddWithValue("@birthday", birthday)
        mysqlcmd.Parameters.AddWithValue("@phonenumber", phonenumber)
        mysqlcmd.Parameters.AddWithValue("@address", address)
        ' FOR ACCOUNTS
        mysqlcmd2.Parameters.AddWithValue("@username", username)
        mysqlcmd2.Parameters.AddWithValue("@password", password)
        If password = confirmpassword Then
            Try
                ' execute query commadn
                mysqlcmd.ExecuteNonQuery()
                mysqlcmd2.ExecuteNonQuery()
                MsgBox("Registered Successfully")
                Staff_Registration.Hide()
                Camping_Login.Show()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                TextClear()
            End Try
        Else
            MessageBox.Show("Confirm Password does not match!")
        End If
    End Sub
    Public Sub Admin_Registry()
        Dim username, password, confirmpassword, fullname, age, birthday, phonenumber, address As String

        ' SET TO STRING FOR TEXTBOXES
        username = Admin_Registration.txtUSERNAME.Text
        password = Admin_Registration.txtPASS.Text
        confirmpassword = Admin_Registration.txtCONFIRMPASS.Text
        fullname = Admin_Registration.txtFULLNAME.Text
        age = Admin_Registration.txtAGE.Text
        birthday = Admin_Registration.txtBIRTHDAY.Text
        phonenumber = Admin_Registration.txtPHONENUM.Text
        address = Admin_Registration.txtADDRESS.Text
        sqlquery = "INSERT INTO camping.admin(Name, Age, Birthday, Phone_Num, Address) 
                    VALUES (@fullname, @age, @birthday, @phonenumber, @address)"
        sqlquery2 = "INSERT INTO camping.accounts(Username, Password, Account_Type) 
                    VALUES (@username, @password, 'Admin')"
        ' MYSQL COMMAND
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd2 = New MySqlCommand(sqlquery2, con)
        ' PARAMETER VALUES
        ' FOR CAMPERS
        mysqlcmd.Parameters.AddWithValue("@fullname", fullname)
        mysqlcmd.Parameters.AddWithValue("@age", age)
        mysqlcmd.Parameters.AddWithValue("@birthday", birthday)
        mysqlcmd.Parameters.AddWithValue("@phonenumber", phonenumber)
        mysqlcmd.Parameters.AddWithValue("@address", address)
        ' FOR ACCOUNTS
        mysqlcmd2.Parameters.AddWithValue("@username", username)
        mysqlcmd2.Parameters.AddWithValue("@password", password)
        If password = confirmpassword Then
            Try
                ' execute query commadn
                mysqlcmd.ExecuteNonQuery()
                mysqlcmd2.ExecuteNonQuery()
                MsgBox("Registered Successfully")
                Admin_Registration.Hide()
                Camping_Login.Show()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                TextClear()
            End Try
        Else
            MessageBox.Show("Confirm Password does not match!")
        End If
    End Sub
    Sub TextClear()
        ' For Campers
        Camper_Registration.txtUsername.Clear()
        Camper_Registration.txtPassword.Clear()
        Camper_Registration.txtconfirmPassword.Clear()
        Camper_Registration.txtFullName.Clear()
        Camper_Registration.txtAge.Clear()
        Camper_Registration.txtBirthday.Clear()
        Camper_Registration.txtPhoneNum.Clear()
        Camper_Registration.txtAddress.Clear()
        ' For Staff
        Staff_Registration.txtusername.Clear()
        Staff_Registration.txtpassword.Clear()
        Staff_Registration.txtconfirmpassword.Clear()
        Staff_Registration.txtfullname.Clear()
        Staff_Registration.txtage.Clear()
        Staff_Registration.txtbirthday.Clear()
        Staff_Registration.txtpassword.Clear()
        Staff_Registration.txtaddress.Clear()
        ' For Admin
        Admin_Registration.txtUSERNAME.Clear()
        Admin_Registration.txtPASS.Clear()
        Admin_Registration.txtCONFIRMPASS.Clear()
        Admin_Registration.txtFULLNAME.Clear()
        Admin_Registration.txtAGE.Clear()
        Admin_Registration.txtBIRTHDAY.Clear()
        Admin_Registration.txtPHONENUM.Clear()
        Admin_Registration.txtADDRESS.Clear()

    End Sub

End Module
