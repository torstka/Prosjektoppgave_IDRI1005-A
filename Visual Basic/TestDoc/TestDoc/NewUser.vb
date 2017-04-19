Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class NewUser
    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Oppkobling mot databasen
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        tilkobling.Open()
        Me.Size = SystemInformation.PrimaryMonitorSize
        Regbox.Location = New Point((ClientSize.Width - Regbox.Width) \ 2,
                             (ClientSize.Height - Regbox.Height) \ 2)
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPersonnr.KeyPress, txtPhone.KeyPress, txtPostnr.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
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
        rbMale.Checked = False
        rbFemale.Checked = False
        LogIn.Show()
        Me.Hide()

    End Sub
    Private Sub Totalyear(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim year As String
        Dim month As String
        Dim day As String
        year = txtyob.Text
        month = Txtmob.Text
        day = TxtDoB.Text


        If Not Regex.IsMatch(year, "^[0-9]+$") Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
        ElseIf Not Regex.IsMatch(month, "^[0-9]+$") Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
        ElseIf Not Regex.IsMatch(day, "^[0-9]+$") Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
        ElseIf Txtmob.Text = 0 Then
            Me.RegError.SetError(txtyob, "Vennligst fyll inn et tal fra 1-12 (Måned)")
        ElseIf Txtmob.Text > 12 Then
            Me.RegError.SetError(txtyob, "Vennligst fyll inn et tal fra 1-12(Måned)")
        ElseIf TxtDoB.Text > 31 Then
            Me.RegError.SetError(txtyob, "Vennligst fyll inn et tal fra 1-31(Dag)")
        ElseIf TxtDoB.Text = 0 Then
            Me.RegError.SetError(txtyob, "Vennligst fyll inn et tal fra 1-31(Dag)")



        Else
            Dim DOB As New DateTime(year, month, day)
            Dim Years As Integer = DateDiff(DateInterval.Year, DOB, Now) - 1
            Dim Months As Integer = DateDiff(DateInterval.Month, DOB, Now) Mod 12
            Dim days As Integer = DateDiff(DateInterval.Day, DOB, Now) Mod 30 - 10

            Label12.Text = Years


        End If

    End Sub
    Public Function ValidFornavn() As Boolean
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
            Me.RegError.SetError(txtPostnr, "Postnummer kan bare bestå av tall")
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
            Me.RegError.SetError(txtPassword, "Vennligst fyll ut et passord")
            Return False
            'Validerer at tekstboksen inneholder minst 8 tegn
        ElseIf Pass.Length < 8 Then
            Me.RegError.SetError(txtPassword, "Passord må bestå av minst 8 Tegn")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.RegError.SetError(txtPassword, "")
            Return True
        End If
    End Function
    Public Function ValidDOB() As Boolean
        Dim DoB = TxtDoB.Text
        Dim MoB = Txtmob.Text
        Dim YoB = txtyob.Text

        'DAG VERIFISERING

        If Not Regex.IsMatch(DoB, "^[0-9]+$") Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
            Return False

        ElseIf TxtDoB.Text > 31 Then
            Me.RegError.SetError(txtyob, "Vennligst fyll inn et tal fra 1-31")
            Return False
        ElseIf TxtDoB.Text = 0 Then
            Me.RegError.SetError(txtyob, "Vennligst fyll inn et tal fra 1-31")
            Return False
        Else
            Me.RegError.SetError(txtyob, "")
        End If

        'MÅNED VERIFISERING

        If Not Regex.IsMatch(MoB, "^[0-9]+$") Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
            Return False
        ElseIf Txtmob.Text = 0 Then
            Me.RegError.SetError(txtyob, "Vennligst fyll inn et tal fra 1-12")
            Return False

        ElseIf Txtmob.Text > 12 Then
            Me.RegError.SetError(txtyob, "Vennligst fyll inn et tal fra 1-12")
            Return False

        Else
            Me.RegError.SetError(txtyob, "")
        End If

        'ÅR VERIFISERING

        If Not YoB.Length = 4 Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
            Return False
        ElseIf Not Regex.IsMatch(YoB, "^[0-9]+$") Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
            Return False
        ElseIf txtyob.Text < 1900 Then
            Me.RegError.SetError(txtyob, "Minste tillatte årstal er 1900")
            Return False
        ElseIf Label12.Text < 18 Then
            Me.RegError.SetError(txtyob, "Du er for ung til å donere blod")
            Return False
        ElseIf Label12.Text > 64 Then
            Me.RegError.SetError(txtyob, "Du er for gammel til å donere blod")
            Return False
        Else
            Me.RegError.SetError(txtyob, "")
            Return True
        End If

    End Function
    'Private Function ValidKjønn() As Boolean
    'Validerer at du ikke har krysset av for begge kjønn
    'If Mbox.Checked And Fbox.Checked Then
    'Me.RegError.SetError(Fbox, "Du kan bare velge et kjønn")
    'Return False
    'Validerer at minst en av checkboksene er krysset av
    'ElseIf Mbox.Checked = False And Fbox.Checked = False Then
    'Me.RegError.SetError(Fbox, "Vennligst velg et kjønn")
    'Return False
    'Else
    'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
    'Me.RegError.SetError(Fbox, "")
    'Return True
    'End If
    'End Function

    Private tilkobling As MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Deklarerer tekstboksene
        Dim firstname = txtFirstname.Text
        Dim lastname = txtLastname.Text
        Dim ssNumber = txtPersonnr.Text
        Dim address = txtAdress.Text
        Dim zipCode = txtPostnr.Text
        Dim phone = txtPhone.Text
        Dim email = txtEmail.Text
        Dim password = txtPassword.Text
        Dim male = rbMale.Checked
        Dim female = rbFemale.Checked
        Dim DOB = TxtDoB.Text & "/" & Txtmob.Text & "/" & txtyob.Text


        If Not ValidFornavn() Then
            MsgBox(Me.RegError.GetError(txtFirstname))
        ElseIf Not ValidEtternavn() Then
            MsgBox(Me.RegError.GetError(txtLastname))
        ElseIf Not ValidPersnr() Then
            MsgBox(Me.RegError.GetError(txtPersonnr))
        ElseIf Not ValidDOB() Then
            MsgBox(Me.RegError.GetError(txtyob))
        ElseIf Not ValidPostnr() Then
            MsgBox(Me.RegError.GetError(txtPostnr))
        ElseIf Not ValidAdresse() Then
            MsgBox(Me.RegError.GetError(txtAdress))
        ElseIf Not ValidEmail() Then
            MsgBox(Me.RegError.GetError(txtEmail))
        ElseIf Not ValidPass() Then
            MsgBox(Me.RegError.GetError(txtPassword))
        ElseIf Not ConfirmPass() Then
            MsgBox(Me.RegError.GetError(txtConfirmPassword))
        ElseIf Not ValidTelefon() Then
            MsgBox(Me.RegError.GetError(txtPhone))
        Else

            Dim newUser As New User
            newUser.add(ssNumber, firstname, lastname, address, zipCode, phone, email, password, male, female, DOB)

            Dim addBlood As New User
            addBlood.addBloodData(ssNumber)

            Me.Close()
            LogIn.Show()

        End If

    End Sub

    Private Sub Regbox_Enter(sender As Object, e As EventArgs) Handles Regbox.Enter

    End Sub
End Class