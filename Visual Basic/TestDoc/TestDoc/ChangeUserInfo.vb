Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class ChangeUserInfo
    Dim connection As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub ChangeUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim connString As String = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
        'Dim sqlQuery As String = "SELECT e_mail, phone, address, password FROM User WHERE ss_number='" & MyPage.Label3.Text & "'"
        'Using sqlConn As New MySqlConnection(connString)
        'Using sqlComm As New MySqlCommand()
        'With sqlComm
        '.Connection = sqlConn
        '.CommandText = sqlQuery
        '.CommandType = CommandType.Text
        'End With
        'Try
        'sqlConn.Open()
        'Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
        'While sqlReader.Read()
        'txtFornavn.Text = sqlReader("e_mail")
        'txtEtternavn.Text = sqlReader("phone")
        'txtPhone.Text = sqlReader("address")
        'txtEmail.Text = sqlReader("password")
        'txtAddress.Text = txtEmail.Text
        'End While
        'Catch ex As MySqlException
        '' add your exception here '
        'End Try
        'End Using
        'End Using

        Dim selectUser As New User
        selectUser.showData(txtFornavn.Text, txtEtternavn.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text, txtZipCode.Text, txtPassword.Text)

    End Sub
    Private Function ValidEmail() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim epost = txtFornavn.Text
        If epost.Length = 0 Then
            Me.regerror.SetError(txtFornavn, "Vennligst fyll ut E-Post")
            Return False
        End If
        'Validerer at tekstboksen inneholder riktige tegn ("@" og "." i riktig rekkefølge og riktig antall tegn(Ikke mer enn et "@" og "."))
        Dim errorMessage = "E-Post adresse må være av gyldig format" + ControlChars.Cr +
            "Eksempel 'olanordmann@eksempel.no' "
        Me.regerror.SetError(txtFornavn, errorMessage)
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
        Me.regerror.SetError(txtFornavn, "")
        Return True
    End Function

    Private Function ValidTelefon() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim telefonnr = txtEtternavn.Text
        If telefonnr.Length = 0 Then
            Me.regerror.SetError(txtEtternavn, "Vennligst fyll ut telefonnummer")
            Return False
            'Validerer at tekstboksen inneholder ett bestemt antall tegn (8 tegn)
        ElseIf Not telefonnr.Length = 8 Then
            Me.regerror.SetError(txtEtternavn, "Telefonnummer må bestå av 8 Tall")
            Return False
            'Validerer at tekstboksen kun inneholder et bestemt sett av tegn (kun tall)
        ElseIf Not Regex.IsMatch(telefonnr, "^[0-9]+$") Then
            Me.regerror.SetError(txtEtternavn, "Telefonnummer kan bare bestå av tall")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtEtternavn, "")
            Return True
        End If
    End Function
    Private Function ValidAdresse() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Adresse = txtPhone.Text
        If Adresse.Length = 0 Then
            Me.regerror.SetError(txtPhone, "Vennligst fyll ut adresse")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtPhone, "")
            Return True
        End If
    End Function
    Private Function ConfirmPass() As Boolean
        'Validerer at innholdet i "passord" og "bekreft passord" tekstboksene er identiske
        If Not txtEmail.Text.Equals(txtAddress.Text) Then
            Me.regerror.SetError(txtAddress, "Passordene må være like")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtAddress, "")
            Return True
        End If
    End Function
    Private Function ValidPass() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Pass = txtEmail.Text
        If Pass.Length = 0 Then
            Me.regerror.SetError(txtEmail, "Vennligst fyll ut et passord")
            Return False
            'Validerer at tekstboksen inneholder minst 8 tegn
        ElseIf Pass.Length < 8 Then
            Me.regerror.SetError(txtEmail, "Passord må bestå av minst 8 Tegn")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtEmail, "")
            Return True
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'work in progress

        If Not ValidEmail() Then
            MsgBox(Me.regerror.GetError(txtFornavn))
        ElseIf Not ValidTelefon() Then
            MsgBox(Me.regerror.GetError(txtEtternavn))
        ElseIf Not ValidAdresse() Then
            MsgBox(Me.regerror.GetError(txtPhone))
        ElseIf Not ValidPass() Then
            MsgBox(Me.regerror.GetError(txtEmail))
        ElseIf Not ConfirmPass() Then
            MsgBox(Me.regerror.GetError(txtAddress))
        Else

            connection = New MySqlConnection
            connection.ConnectionString =
           "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
            Dim Reader As MySqlDataReader

            Try
                connection.Open()
                Dim query As String
                query = "Update g_oops_03.User set e_mail='" & txtFornavn.Text & "',address='" & txtPhone.Text & "',phone='" & txtEtternavn.Text & "',password='" & txtEmail.Text & "' where ss_number='" & MyPage.Label3.Text & "'"
                COMMAND = New MySqlCommand(query, connection)
                Reader = COMMAND.ExecuteReader()

                MsgBox("Personopplysninger er oppdatert!", MsgBoxStyle.Information, "Vellykket")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        txtEtternavn.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtFornavn.Clear()
        regerror.Clear()
        MyPage.Show()
    End Sub

End Class