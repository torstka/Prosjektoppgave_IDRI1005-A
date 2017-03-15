Imports MySql.Data.MySqlClient

Public Class EmployeeLogIn
    Public ansattNr As Integer
    Private tilkobling As MySqlConnection

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        tilkobling.Open()
    End Sub

    Private Sub btbLogin_Click(sender As Object, e As EventArgs) Handles btbLogin.Click
        ansattNr = txtAnsattnr.Text
        Dim password = txtPassword.Text
        Dim sqlSporring = "select * from Employees where Ansattnr=@ansattnr " &
                      "and Passord=@passord"

        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@ansattnr", ansattNr)
        sql.Parameters.AddWithValue("@passord", password)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            Me.Hide()
            EmployeePage.Show()
        Else
            MsgBox("Innlogging feilet! Prøv igjen.", MsgBoxStyle.Critical, "ERROR")
        End If
        leser.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class