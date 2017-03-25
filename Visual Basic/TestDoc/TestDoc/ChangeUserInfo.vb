Imports MySql.Data.MySqlClient
Public Class ChangeUserInfo
    Dim connection As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'work in progress
        connection = New MySqlConnection
        connection.ConnectionString =
       "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
        Dim Reader As MySqlDataReader

        Try
            connection.Open()
            Dim query As String
            query = "Update g_oops_03.User set e_mail='" & txtemail.Text & "',address='" & txtaddress.Text & "',phone='" & txtphone.Text & "',password='" & txtpassword.Text & "' where ss_number='" & TextBox1.Text & "'"
            COMMAND = New MySqlCommand(query, connection)
            Reader = COMMAND.ExecuteReader()

            MsgBox("Personopplysninger er oppdatert!", MsgBoxStyle.Information, "Vellykket")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

End Class