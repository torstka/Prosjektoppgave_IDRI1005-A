Imports MySql.Data.MySqlClient
Public Class UserInformation

    Private connection As MySqlConnection

    Private Sub UserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query = "SELECT * from Users"
            Dim command As New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim SSN = reader.GetString("Personnummer")
                ListBox1.Items.Add(SSN)
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        Dim reader As MySqlDataReader

        Try
            connection.Open()
            Dim query As String = "select Fornavn, Etternavn, Personnummer from Users where personnummer = '" & ListBox1.Text & "'"
            Dim command As New MySqlCommand(query, connection)
            reader = command.ExecuteReader

            While reader.Read
                txtFirstname.Text = reader.GetString("Fornavn")
                txtLastname.Text = reader.GetString("Etternavn")
                txtSSN.Text = reader.GetString("Personnummer")
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

End Class