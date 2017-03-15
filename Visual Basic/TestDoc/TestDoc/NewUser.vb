Imports MySql.Data.MySqlClient
Public Class NewUser
    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        tilkobling.Open()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub
    Private Function ValidEmailAddress(ByVal epost As String, ByRef errorMessage As String) As Boolean
        ' Bekrefter at det er en "@" og en "." i e-post adressesn, og i riktig rekkefølge
        If epost.IndexOf("@") > -1 Then
            If (epost.IndexOf(".", epost.IndexOf("@")) > epost.IndexOf("@")) Then
                errorMessage = ""
                Return True
            End If
        End If

        errorMessage = "E-mail address must be valid e-mail address format." + ControlChars.Cr +
        "For example 'someone@example.com' "
        Return False
    End Function

    Private Sub textBox1_Validating(ByVal sender As Object,
   ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating

        Dim errorMsg As String
        If Not ValidEmailAddress(txtEmail.Text, errorMsg) Then
            e.Cancel = True
            txtEmail.Select(0, txtEmail.Text.Length)
            Me.ErrorProvider1.SetError(txtEmail, errorMsg)
        End If
    End Sub


    Private Sub txtEmail_Validated(ByVal sender As Object,
   ByVal e As System.EventArgs) Handles txtEmail.Validated
        ' Om betingelser er møtt, fjern error beskjed
        ErrorProvider1.SetError(txtEmail, "")
    End Sub

    Private tilkobling As MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Fornavn = txtFirstname.Text
        Dim Etternavn = txtLastname.Text
        Dim Personnummer = txtPersonnr.Text
        Dim Adresse = txtAdress.Text
        Dim Postnummer = txtPostnr.Text
        Dim Telefon = txtPhone.Text
        Dim Epost = txtEmail.Text
        Dim Passord = txtPassword.Text

        ' Bekrefter at text er utfylt i felt. 
        If txtEmail.Text.Length = 0 Then
            MsgBox("vennligst fyll ut epost")
        Else

            Dim sqlSporring = "insert into Users (Etternavn, Fornavn, Personnummer, Adresse, Postnummer, Telefon, Epost, Passord) values (@Etternavn, @Fornavn, @Personnummer, @Adresse, @Postnummer, @Epost, @Telefon, @Passord)"
            Dim sql As New MySqlCommand(sqlSporring, tilkobling)


            sql.Parameters.AddWithValue("@Fornavn", Fornavn)
            sql.Parameters.AddWithValue("@Etternavn", Etternavn)
            sql.Parameters.AddWithValue("@Personnummer", Personnummer)
            sql.Parameters.AddWithValue("@Adresse", Adresse)
            sql.Parameters.AddWithValue("@Postnummer", Postnummer)
            sql.Parameters.AddWithValue("@Telefon", Telefon)
            sql.Parameters.AddWithValue("@Epost", Epost)
            sql.Parameters.AddWithValue("@Passord", Passord)

            sql.ExecuteNonQuery()
            MsgBox("Registrering vellykket")

            Me.Close()
            Form1.Show()

        End If

    End Sub

End Class