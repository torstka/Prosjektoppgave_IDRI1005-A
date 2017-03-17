Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class NewUser
    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Oppkobling mot databasen
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        tilkobling.Open()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Knapp som klarerer skjema og går tilbake til "form1"
        txtFirstname.Clear()
        txtLastname.Clear()
        txtPersonnr.Clear()
        txtAdress.Clear()
        txtPostnr.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        RegError.Clear()
        Form1.Show()
        Me.Hide()

    End Sub
    Private Function ValidFornavn() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Fornavn = txtFirstname.Text
        If Fornavn.Length = 0 Then
            Me.RegError.SetError(txtFirstname, "Vennligst fyll ut fornavn")
            Return False
            'Validerer at tekstboksen kun inneholder et bestemt sett av tegn (kun bokstaver)
        ElseIf Not Regex.IsMatch(Fornavn, "^[\p{L} ]+$") Then
            Me.RegError.SetError(txtFirstname, "Fornavn kan bare inneholde bokstaver")
            Return False
        Else
            'Om betingelser er møtt, gå videre
            Me.RegError.SetError(txtFirstname, "")
            Return True
        End If
    End Function
    Private Function ValidEtternavn() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Etternavn = txtLastname.Text
        If Etternavn.Length = 0 Then
            Me.RegError.SetError(txtLastname, "Vennligst fyll ut etternavn")
            Return False
            'Validerer at tekstboksen kun inneholder et bestemt sett av tegn (bokstaver)
        ElseIf Not Regex.IsMatch(Etternavn, "^[\p{L} ]+$") Then
            Me.RegError.SetError(txtLastname, "Etternavn kan bare inneholde bokstaver")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.RegError.SetError(txtLastname, "")
            Return True
        End If
    End Function
    Private Function ValidPersnr() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim persnr = txtPersonnr.Text
        If persnr.Length = 0 Then
            Me.RegError.SetError(txtPersonnr, "Vennligst fyll ut personnummer")
            Return False
            'Validerer at tekstboksen inneholder ett bestemt antall tegn (11 tegn)
        ElseIf Not persnr.Length = 11 Then
            Me.RegError.SetError(txtPersonnr, "Personnummer må bestå av 11 tall")
            Return False
            'Validerer at tekstboksen kun inneholder et bestemt sett av tegn (kun tall)
        ElseIf Not Regex.IsMatch(persnr, "^[0-9]+$") Then
            Me.RegError.SetError(txtPersonnr, "Personnummer kan bare bestå av tall")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.RegError.SetError(txtPersonnr, "")
            Return True
        End If
    End Function
    Private Function ValidAdresse() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Adresse = txtAdress.Text
        If Adresse.Length = 0 Then
            Me.RegError.SetError(txtAdress, "Vennligst fyll ut adresse")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.RegError.SetError(txtAdress, "")
            Return True
        End If
    End Function
    Private Function ValidTelefon() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim telefonnr = txtPhone.Text
        If telefonnr.Length = 0 Then
            Me.RegError.SetError(txtPhone, "Vennligst fyll ut telefonnummer")
            Return False
            'Validerer at tekstboksen inneholder ett bestemt antall tegn (8 tegn)
        ElseIf Not telefonnr.Length = 8 Then
            Me.RegError.SetError(txtPhone, "Telefonnummer må bestå av 8 Tall")
            Return False
            'Validerer at tekstboksen kun inneholder et bestemt sett av tegn (kun tall)
        ElseIf Not Regex.IsMatch(telefonnr, "^[0-9]+$") Then
            Me.RegError.SetError(txtPhone, "Telefonnummer kan bare bestå av tall")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.RegError.SetError(txtPhone, "")
            Return True
        End If
    End Function
    Private Function ValidPostnr() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Postnr = txtPostnr.Text
        If Postnr.Length = 0 Then
            Me.RegError.SetError(txtPostnr, "Vennligst fyll ut postnummer")
            Return False
            'Validerer at tekstboksen inneholder ett bestemt antall tegn (4 tegn)
        ElseIf Not Postnr.Length = 4 Then
            Me.RegError.SetError(txtPostnr, "Postnummer må bestå av 4 tall")
            Return False
            'Validerer at tekstboksen kun inneholder et bestemt sett av tegn (kun tall)
        ElseIf Not Regex.IsMatch(Postnr, "^[0-9]+$") Then
            Me.RegError.SetError(txtPostnr, "Postnummer Kan Bare Bestå Av Tall")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.RegError.SetError(txtPostnr, "")
            Return True
        End If
    End Function

    Private Function ValidEmail() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim epost = txtEmail.Text
        If epost.Length = 0 Then
            Me.RegError.SetError(txtEmail, "Vennligst fyll ut E-Post")
            Return False
        End If
        'Validerer at tekstboksen inneholder riktige tegn ("@" og "." i riktig rekkefølge og riktig antall tegn(Ikke mer enn et "@" og "."))
        Dim errorMessage = "E-Post adresse må være av gyldig format" + ControlChars.Cr +
            "Eksempel 'olanordmann@eksempel.no' "
        Me.RegError.SetError(txtEmail, errorMessage)
        Dim indexAt1 = epost.IndexOf("@")
        Dim indexAt2 = epost.LastIndexOf("@")
        If indexAt1 < 1 Or Not indexAt1 = indexAt2 Then
            Return False
        End If
        Dim indexDot1 = epost.IndexOf(".", indexAt1)
        Dim indexDot2 = epost.LastIndexOf(".")
        If indexDot1 <= indexAt1 + 1 Or Not indexDot2 = indexDot1 Or indexDot1 = epost.Length - 1 Then
            Return False
        End If
        'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
        Me.RegError.SetError(txtEmail, "")
        Return True
    End Function
    Private Function ConfirmPass() As Boolean
        'Validerer at innholdet i "passord" og "bekreft passord" tekstboksene er identiske
        If Not txtPassword.Text.Equals(txtConfirmPassword.Text) Then
            Me.RegError.SetError(txtConfirmPassword, "Passordene må være like")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.RegError.SetError(txtConfirmPassword, "")
            Return True
        End If
    End Function
    Private Function ValidPass() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Pass = txtPassword.Text
        If Pass.Length = 0 Then
            Me.RegError.SetError(txtPassword, "Vennligst Fyll ut et Passord")
            Return False
            'Validerer at tekstboksen inneholder minst 8 tegn
        ElseIf Pass.Length < 8 Then
            Me.RegError.SetError(txtPassword, "Passord Må Bestå Av Minst 8 Tegn")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.RegError.SetError(txtPassword, "")
            Return True
        End If
    End Function

    Private tilkobling As MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Deklarerer tekstboksene
        Dim Fornavn = txtFirstname.Text
        Dim Etternavn = txtLastname.Text
        Dim Personnummer = txtPersonnr.Text
        Dim Adresse = txtAdress.Text
        Dim Postnummer = txtPostnr.Text
        Dim Telefon = txtPhone.Text
        Dim Epost = txtEmail.Text
        Dim Passord = txtPassword.Text

        'Validerer at alle tekstboksene er utfylt riktig
        If Not ValidFornavn() Then
            MsgBox(Me.RegError.GetError(txtFirstname))
        ElseIf Not ValidEtternavn() Then
            MsgBox(Me.RegError.GetError(txtLastname))
        ElseIf Not ValidPersnr() Then
            MsgBox(Me.RegError.GetError(txtPersonnr))
        ElseIf Not ValidAdresse() Then
            MsgBox(Me.RegError.GetError(txtAdress))
        ElseIf Not ValidTelefon() Then
            MsgBox(Me.RegError.GetError(txtPhone))
        ElseIf Not ValidPostnr() Then
            MsgBox(Me.RegError.GetError(txtPostnr))
        ElseIf Not ValidEmail() Then
            MsgBox(Me.RegError.GetError(txtEmail))
        ElseIf Not ValidPass() Then
            MsgBox(Me.RegError.GetError(txtPassword))
        ElseIf Not ConfirmPass() Then
            MsgBox(Me.RegError.GetError(txtConfirmPassword))
        Else
            'Om valideringen er godkjent ("return true" på alle funksjonene), utfør sql spørring mot database
            Dim sqlSporring = "insert into Users (Etternavn, Fornavn, Personnummer, Adresse, Postnummer, Epost, Telefon, Passord) values (@Etternavn, @Fornavn, @Personnummer, @Adresse, @Postnummer, @Epost, @Telefon, @Passord)"
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
            MsgBox("Registrering vellykket!")

            Me.Close()
            Form1.Show()

        End If

    End Sub

End Class