Imports MySql.Data.MySqlClient

Public Class EmployeeLogIn

    Private tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling.Open()
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btbLogin_Click(sender As Object, e As EventArgs) Handles btbLogin.Click
        Dim ansattNr = txtAnsattnr.Text
        Dim password = txtPassword.Text
        Dim sqlSporring = "select * from Employees where Ansattnr=@ansattnr " &
                      "and Passord=@passord"

        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@personnummer", ansattNr)
        sql.Parameters.AddWithValue("@passord", password)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            Me.Hide()
            Logged_In.Show()
        Else
            MsgBox("Innlogging misslykket")
        End If
        leser.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

End Class