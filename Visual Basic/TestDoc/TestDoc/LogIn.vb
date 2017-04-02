Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class LogIn
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
        Dim sqlSporring = "select * from Employee where e_number=@employeeNr " &
                      "and password=@password"

        Dim sql As New MySqlCommand(sqlSporring, connection)

        sql.Parameters.AddWithValue("@employeeNr", employeeNr)
        sql.Parameters.AddWithValue("@password", password)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            Me.Hide()
            EmployeePage.Show()
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


    Private Sub btbLogin_Click(sender As Object, e As EventArgs) Handles btbLogin.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        EmployeeLogIn.Show()
    End Sub

    Private Sub LogIn_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        connection.Close()
        connection.Dispose()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        NewUser.Show()
    End Sub

End Class