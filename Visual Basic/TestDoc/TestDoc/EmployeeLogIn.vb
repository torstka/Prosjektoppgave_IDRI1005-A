Imports MySql.Data.MySqlClient

Public Class EmployeeLogIn

    Private connection As MySqlConnection

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        connection.Close()
        connection.Dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        connection.Open()
    End Sub

    Private Sub btbLogin_Click(sender As Object, e As EventArgs) Handles btbLogin.Click
        Dim ansattNr = txtAnsattnr.Text
        Dim password = txtPassword.Text
        Dim sqlSporring = "select * from Employees where Ansattnr=@ansattnr " &
                      "and Passord=@passord"

        Dim sql As New MySqlCommand(sqlSporring, connection)

        sql.Parameters.AddWithValue("@ansattnr", ansattNr)
        sql.Parameters.AddWithValue("@passord", password)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            MsgBox("Du er logget inn")
        Else
            MsgBox("Innlogging misslykket")
        End If
        leser.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        LogIn.Show()
    End Sub
End Class