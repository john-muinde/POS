Imports System.Data.OleDb
Public Class Log_in

    Public pro As String
    Public conString As String
    Public command As String
    Public myconn As OleDbConnection = New OleDbConnection
    Public cmd As OleDbCommand
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.PasswordChar = "*"
        txtPassword.MaxLength = 14
    End Sub

    Private Sub Login()
        If txtUserName.Text = "" Or txtPassword.Text = "" Then
            MsgBox("All the Fields are required")
            If txtPassword.Text = "" Then
                txtPassword.Focus()
            Else
                txtUserName.Focus()
            End If
        Else
            pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\_atrocious\OneDrive\Documents\VB\POS.mdb"
            conString = pro
            myconn.ConnectionString = conString
            myconn.Open()

            command = "Select * from Users where userName = '" & txtUserName.Text & "'
            and password = '" & txtPassword.Text & "' "
            cmd = New OleDbCommand(command, myconn)

            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                Home.lblEmployee.Text += $" {sdr("nameUser")} {sdr("userName")}"
                Form1.Show()
                Me.Close()
            Else
                MsgBox("Incorrect Username or Password")
            End If
        End If
        myconn.Close()
    End Sub
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Login()
    End Sub
End Class