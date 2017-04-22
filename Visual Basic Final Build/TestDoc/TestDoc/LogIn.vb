Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Net.Mail


Public Class LogIn
    ' Inherits System.Windows.Forms.TextBox
    Public ssn As String
    Dim connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")

    Private Sub btCancel_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    'Funksjon for å validere "Personnummer" tekstboksen
    Private Function validloginput() As Boolean
        Dim loginput = txtPersonnr.Text
        If loginput.Length = 0 Then
            Me.loginerror.SetError(txtPersonnr, "Vennligst fyll ut personnummer")
            Return False

        ElseIf Not Regex.IsMatch(loginput, "^[0-9]+$") Then
            Me.loginerror.SetError(txtPersonnr, "Personnummer kan bare bestå av tall")
            Return False

        ElseIf loginput.Length <> 4 And loginput.Length <> 11 Then
            Me.loginerror.SetError(txtPersonnr, "Ugyldig antall tegn")
            Return False
        Else
            loginerror.Clear()
            Return True

        End If
    End Function
    'Funksjon for å validere "Passord" tekstboksen
    Private Function Validpassinput() As Boolean
        Dim passinput = txtPassword.Text
        If passinput.Length = 0 Then
            Me.loginerror.SetError(txtPassword, "Vennligst fyll ut passord")
            Return False
        Else
            Return True
        End If
    End Function
    'Funksjon for å logge inn som Ansatt/admin/ledelse
    Private Function Adminlogin() As Boolean

        Dim employeeNr = txtPersonnr.Text
        Dim password = txtPassword.Text

        connection.Open()
        Dim sqlSporring = "select * from Employee where e_number=@employeeNr and password=@password"

        Dim sql As New MySqlCommand(sqlSporring, connection)

        sql.Parameters.AddWithValue("@employeeNr", employeeNr)
        sql.Parameters.AddWithValue("@password", password)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            Me.Hide()
            If employeeNr >= 2000 Then
                Statistics.Show()
            ElseIf employeeNr >= 1000 Then
                EPage.Show()
            End If

            'EPage.Show()
            txtPassword.Clear()
            txtPersonnr.Clear()

        Else
            MsgBox("Feil brukernavn eller passord", MsgBoxStyle.Critical, "Innlogging misslykket")
        End If

        leser.Close()
        connection.close
        Return True

    End Function

    'Funksjon for å logge inn som "bruker"
    Private Function Userlogin()

        ssn = txtPersonnr.Text
        Dim password = txtPassword.Text

        connection.open
        Dim query = "select * from User where ss_number=@ssNumber " &
                              "and password=@password"

        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@ssNumber", ssn)
        command.Parameters.AddWithValue("@password", password)

        Dim reader = command.ExecuteReader()
        If reader.HasRows Then
            Me.Hide()
            UserPage.Show()
            MyPage.Label3.Text = ssn
            txtPassword.Clear()
            txtPersonnr.Clear()
        Else
            MsgBox("Feil brukernavn eller passord", MsgBoxStyle.Critical, "Innlogging misslykket")
        End If

        connection.Close()
        reader.Close()
        Return True
    End Function

    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs)
        Me.Hide()
        NewUser.Show()
    End Sub
    'De to følgende subene gjør det mulig for bruker å taste enter etter å ha tastet inn brukernavn for å komme til neste txbox for å skrive inn passord
    'og når begge inndata er tastet inn er det mulig å trykke enter istedet for knappen. Hensynsmessig for bevegelsesnedsatte brukere å flytte pila
    'for å navigere på skjermen
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPersonnr.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()

        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.Focus()
            e.Handled = e.SuppressKeyPress = True
        End If
    End Sub
    ''denne suben fjerner ding-lyden som normalt kommer når man manipulerer entertasten
    Const CARRIAGE_RETURN As Char = Chr(13)

    Private Sub NoReturnTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = CARRIAGE_RETURN Then
            e.Handled = True
            System.Windows.Forms.SendKeys.Send(vbTab)
        End If

    End Sub

    Private Sub btbLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Kjører funksjonene for tekstboks validering og finner ut om enn logger inn som ansatt eller
        'bruker basert på antall tall som er skrivet inn


        If Not validloginput() Then
            MsgBox(Me.loginerror.GetError(txtPersonnr))
        ElseIf Not Validpassinput() Then
            MsgBox(Me.loginerror.GetError(txtPassword))
        ElseIf txtPersonnr.TextLength = 11 Then
            Userlogin()
        ElseIf txtPersonnr.TextLength = 4 Then
            Adminlogin()
        End If

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub


    Private Sub LogIn_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        connection.Close()
        connection.Dispose()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        NewUser.Show()
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = SystemInformation.PrimaryMonitorSize
        GroupBox1.Location = New Point((ClientSize.Width - GroupBox1.Width) \ 2,
                             (ClientSize.Height - GroupBox1.Height) \ 2)

    End Sub

    Private Sub txt_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtPersonnr.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLogin.KeyDown
        If e.KeyData = Keys.Enter Then
            MyPage.Focus()  ' The Next textbox to select
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader
        Dim ssn = InputBox("Skriv inn ditt personnummer (11 siffer)", "Verifisering")




        connection.Open()
        Dim query As String = "select e_mail, password FROM User where ss_number = '" & ssn & "'"
        cmd = New MySqlCommand(query, connection)
        reader = cmd.ExecuteReader

        Dim email As String = ""
        Dim pwd As String = ""

        If reader.HasRows Then
            While reader.Read()
                email &= reader("e_mail") & " "
                pwd &= reader("password") & " "
            End While
            Dim mail As New MailMessage()
            Dim SmtpServer As New SmtpClient
            SmtpServer.Credentials = New Net.NetworkCredential("tappernas@gmail.com", "Pannekake123")
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.EnableSsl = True
            '  SmtpServer.EnableSsl = True
            mail.To.Add(email)
            mail.From = New MailAddress("tappernas@gmail.com")
            mail.Subject = "Glemt passord"
            mail.Body = "Ditt passord er: " & pwd
            SmtpServer.Send(mail)
            mail.Body = ""
            MsgBox("Passordet er nå tilsendt på epost", MsgBoxStyle.Information, "Epost sendt")
        ElseIf Not reader.HasRows And ssn <> "" Then
            MsgBox("Feil personnummer. Prøv på nytt", MsgBoxStyle.Critical, "Feil personnummer")

        End If
        connection.close
    End Sub
End Class