Imports MySql.Data.MySqlClient

Public Class EmployeeLogIn
    Dim connection As New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        connection.Close()
        connection.Dispose()
    End Sub

    Private Sub btbLogin_Click(sender As Object, e As EventArgs) Handles btbLogin.Click
        Dim employeeNr = txtAnsattnr.Text
        Dim password = txtPassword.Text

        connection.Open()
        Dim sqlSporring = "select * from Employee where employee_number=@employeeNr " &
                      "and password=@password"

        Dim sql As New MySqlCommand(sqlSporring, connection)

        sql.Parameters.AddWithValue("@employeeNr", employeeNr)
        sql.Parameters.AddWithValue("@password", password)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            Me.Hide()
            EmployeePage.Show()
        Else
            MsgBox("Feil brukernavn eller passord", MsgBoxStyle.Critical, "Innlogging misslykket")
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