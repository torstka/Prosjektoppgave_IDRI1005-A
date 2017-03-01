Imports MySql.Data.MySqlClient
Public Class NewUser
    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        tilkobling.Open()

    End Sub

    Private tilkobling As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Navn = TextBox1.Text
        Dim Passord = TextBox2.Text
        Dim Epost = TextBox3.Text
        Dim Telefon = TextBox4.Text
        Dim Personnummer = textbox5.text
        Dim sqlSporring = "insert into Users (Personnummer, Navn, Passord, Epost, Telefon) values (@Personnummer, @Navn, @Passord, @Epost, @Telefon)"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@Navn", Navn)
        sql.Parameters.AddWithValue("@Passord", Passord)
        sql.Parameters.AddWithValue("@Epost", Epost)
        sql.Parameters.AddWithValue("@Telefon", Telefon)
        sql.Parameters.AddWithValue("@Personnummer", Personnummer)

        sql.ExecuteNonQuery()

        MsgBox("Bruker er opprettet! " & sql.LastInsertedId)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class