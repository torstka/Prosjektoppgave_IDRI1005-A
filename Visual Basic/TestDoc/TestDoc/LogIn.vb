Imports MySql.Data.MySqlClient
Public Class LogIn
    Public ssn As String
    Dim connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")

    Private Sub btCancel_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs) Handles btbRegistrer.Click
        Me.Hide()
        NewUser.Show()
    End Sub

    Private Sub btbLogin_Click(sender As Object, e As EventArgs) Handles btbLogin.Click
        ssn = txtPersonnr.Text
        Dim password = txtPassword.Text
        connection.open()
        Dim query = "select * from User where ss_number=@ssNumber " &
                          "and password=@password"

        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@ssNumber", ssn)
        command.Parameters.AddWithValue("@password", password)

        Dim reader = command.ExecuteReader()
        If reader.HasRows Then
            Me.Hide()
            MyPage.ShowDialog()
        Else
            MsgBox("Innlogging misslykket")
        End If
        reader.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        EmployeeLogIn.Show()
    End Sub

    Private Sub LogIn_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        connection.Close()
        connection.Dispose()
    End Sub
End Class