Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Public Class NewUser
    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sentrering av groupbox og setter størrelsen på form til brukerens skjerm
        Me.Size = SystemInformation.PrimaryMonitorSize
        Regbox.Location = New Point((ClientSize.Width - Regbox.Width) \ 2,
                             (ClientSize.Height - Regbox.Height) \ 2)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BckBtn.Click
        'Knapp som klarerer skjema og går tilbake til "form1"
        LogIn.Show()
        Me.Close()
    End Sub
    Private Sub txtyob_TextChanged(sender As Object, e As EventArgs) Handles txtyob.Click
        txtyob.Clear()
    End Sub
#Region "Alder validering"
    Private Sub Calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegBtn.Click
        'Denne subben kalkulerer alder basert på hva som blir fylt inn i d relevante combo-/tekstboksene

        Dim year As String
        Dim month As String
        Dim day As String

        year = txtyob.Text 'Fødselsåret  
        month = txtmob.Text 'Fødselsmåneden 
        day = txtdob.Text 'Fødselsdagen

        'validering av tekstbokser

        If Not Regex.IsMatch(year, "^[0-9]+$") Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
        ElseIf txtyob.Text = "" Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
        ElseIf txtyob.Text = "0" Or txtyob.Text = "00" Or txtyob.Text = "000" Or txtyob.Text = "0000" Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
        ElseIf txtmob.Text = "" Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
        ElseIf txtdob.Text = "" Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")

        Else

            Dim DOB As New DateTime(year, month, day)
            Dim BDAY As New DateTime(Now.Year, month, day)

            Dim Years As Integer
            If (BDAY > Now) Then
                Years = DateDiff(DateInterval.Year, DOB, Now) - 1
            Else
                Years = DateDiff(DateInterval.Year, DOB, Now)
            End If

            Dim Months As Integer = DateDiff(DateInterval.Month, DOB, Now) Mod 12
            Dim days As Integer = DateDiff(DateInterval.Day, DOB, Now) Mod 30 - 10
            Age.Text = Years
            Me.RegError.Clear()
        End If
    End Sub
    Private Function Totalage() As Boolean
        'Denne subben validerer at alder er innenfor 18-65 år
        If Age.Text = "" Then
            Me.RegError.SetError(txtyob, "Fødselsdato må være av format: DD/MM/ÅÅÅÅ")
            Return False
        ElseIf Age.Text < 18 Then
            Me.RegError.SetError(txtyob, "Du er for ung til å donere blod")
            Return False
        ElseIf Age.Text > 65 Then
            Me.RegError.SetError(txtyob, "Du er for gammel til å donere blod")
            Return False
        Else
            Me.RegError.Clear()
            Return True
        End If

    End Function
#End Region
#Region "Tekstbox Validering"
    Private Sub txt_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPersonnr.KeyPress, txtPhone.KeyPress, txtPostnr.KeyPress, txtyob.KeyPress
        'Hindrer at bruker taster inn annet enn tal i relevante tekstbokser
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtFirstname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstname.TextChanged, txtLastname.TextChanged, txtAdress.TextChanged
        'Gjør om første bokstav i relevante tekstbokser til Upper-Case
        If txtFirstname.Text <> "" Then
            Dim a As String = txtFirstname.Text
            txtFirstname.Text = (StrConv(a, VbStrConv.ProperCase))
            txtFirstname.Select(txtFirstname.Text.Length, 0)
        End If
        If txtLastname.Text <> "" Then
            Dim a As String = txtLastname.Text
            txtLastname.Text = (StrConv(a, VbStrConv.ProperCase))
            txtLastname.Select(txtLastname.Text.Length, 0)
        End If
        If txtAdress.Text <> "" Then
            Dim a As String = txtAdress.Text
            txtAdress.Text = (StrConv(a, VbStrConv.ProperCase))
            txtAdress.Select(txtAdress.Text.Length, 0)
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

    Private Function ValidKjønn() As Boolean
        ' Validerer at minst en av checkboksene er krysset av
        If rbMale.Checked = False And rbFemale.Checked = False Then
            Me.RegError.SetError(rbFemale, "Vennligst velg et kjønn")
            Return False
        Else
            ' Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.RegError.SetError(rbFemale, "")
            Return True
        End If
    End Function
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RegBtn.Click

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
        Dim DOB = txtdob.Text & "/" & Txtmob.Text & "/" & txtyob.Text


        'Kjører funksjonene for validering
        If Not ValidFornavn() Then
            MsgBox(Me.RegError.GetError(txtFirstname), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidEtternavn() Then
            MsgBox(Me.RegError.GetError(txtLastname), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidPersnr() Then
            MsgBox(Me.RegError.GetError(txtPersonnr), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not Totalage() Then
            MsgBox(Me.RegError.GetError(txtyob), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidAdresse() Then
            MsgBox(Me.RegError.GetError(txtAdress), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidPostnr() Then
            MsgBox(Me.RegError.GetError(txtPostnr), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidEmail() Then
            MsgBox(Me.RegError.GetError(txtEmail), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidTelefon() Then
            MsgBox(Me.RegError.GetError(txtPhone), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidPass() Then
            MsgBox(Me.RegError.GetError(txtPassword), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ConfirmPass() Then
            MsgBox(Me.RegError.GetError(txtConfirmPassword), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidKjønn() Then
            MsgBox(Me.RegError.GetError(rbFemale), MsgBoxStyle.Critical, "Oops!")
        Else
            ' om validering er godkjent kaller knappetrykket på "NewUser" klassen og registrerer data i databasen

            NewUsermail()
            Dim newUser As New User
            newUser.add(ssNumber, firstname, lastname, address, zipCode, phone, email, password, male, female, DOB)

            Dim addBlood As New User
            addBlood.addBloodData(ssNumber)

            Me.Close()
            LogIn.Show()

        End If

    End Sub

    Private Sub NewUsermail()
        'Sender e-post til relevante e-postadresse som bekrefter at bruker er opprettet
        Try
            Dim mail As New MailMessage()
            Dim SmtpServer As New SmtpClient
            SmtpServer.Credentials = New Net.NetworkCredential("tappernas@gmail.com", "Pannekake123")
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.EnableSsl = True
            mail.To.Add(txtEmail.Text)
            mail.From = New MailAddress("tappernas@gmail.com")
            mail.Subject = "Registrering godkjent"
            mail.Body = "Hei!" & vbCrLf & "Takk for at du registrerte deg som blodgiver. Vi ønsker deg velkommen til å komme å fylle ut skjemaet, og gi blod 🙂" & vbCrLf & vbCrLf & "Med vennlig hilsen" & vbCrLf & "Blodbanken ved St.Olavs Hospital"
            SmtpServer.Send(mail)
            mail.Body = ""
        Catch error_mail As Exception
            MsgBox("Det skjedde dessverre en teknisk feil. Dobbelsjekk at du har fyllt inn riktig informasjon, og prøv på nytt." & error_mail.Message)
        End Try
    End Sub

End Class