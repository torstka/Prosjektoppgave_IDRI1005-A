Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class ChangeUserInfo
    Dim connection As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub ChangeUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connString As String = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
        Dim sqlQuery As String = "SELECT e_mail, phone, address, password FROM User WHERE ss_number='" & MyPage.Label3.Text & "'"
        Using sqlConn As New MySqlConnection(connString)
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = sqlConn
                    .CommandText = sqlQuery
                    .CommandType = CommandType.Text
                End With
                Try
                    sqlConn.Open()
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        txtemail.Text = sqlReader("e_mail")
                        txtphone.Text = sqlReader("phone")
                        txtaddress.Text = sqlReader("address")
                        txtpassword.Text = sqlReader("password")
                        txtconfirmpassword.Text = txtpassword.Text
                    End While
                Catch ex As MySqlException
                    ' add your exception here '
                End Try
            End Using
        End Using

    End Sub
    Private Function ValidEmail() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim epost = txtemail.Text
        If epost.Length = 0 Then
            Me.regerror.SetError(txtemail, "Vennligst fyll ut E-Post")
            Return False
        End If
        'Validerer at tekstboksen inneholder riktige tegn ("@" og "." i riktig rekkefølge og riktig antall tegn(Ikke mer enn et "@" og "."))
        Dim errorMessage = "E-Post adresse må være av gyldig format" + ControlChars.Cr +
            "Eksempel 'olanordmann@eksempel.no' "
        Me.regerror.SetError(txtemail, errorMessage)
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
        Me.regerror.SetError(txtemail, "")
        Return True
    End Function

    Private Function ValidTelefon() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim telefonnr = txtphone.Text
        If telefonnr.Length = 0 Then
            Me.regerror.SetError(txtphone, "Vennligst fyll ut telefonnummer")
            Return False
            'Validerer at tekstboksen inneholder ett bestemt antall tegn (8 tegn)
        ElseIf Not telefonnr.Length = 8 Then
            Me.regerror.SetError(txtphone, "Telefonnummer må bestå av 8 Tall")
            Return False
            'Validerer at tekstboksen kun inneholder et bestemt sett av tegn (kun tall)
        ElseIf Not Regex.IsMatch(telefonnr, "^[0-9]+$") Then
            Me.regerror.SetError(txtphone, "Telefonnummer kan bare bestå av tall")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtphone, "")
            Return True
        End If
    End Function
    Private Function ValidAdresse() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Adresse = txtaddress.Text
        If Adresse.Length = 0 Then
            Me.regerror.SetError(txtaddress, "Vennligst fyll ut adresse")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtaddress, "")
            Return True
        End If
    End Function
    Private Function ConfirmPass() As Boolean
        'Validerer at innholdet i "passord" og "bekreft passord" tekstboksene er identiske
        If Not txtpassword.Text.Equals(txtconfirmpassword.Text) Then
            Me.regerror.SetError(txtconfirmpassword, "Passordene må være like")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtconfirmpassword, "")
            Return True
        End If
    End Function
    Private Function ValidPass() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Pass = txtpassword.Text
        If Pass.Length = 0 Then
            Me.regerror.SetError(txtpassword, "Vennligst fyll ut et passord")
            Return False
            'Validerer at tekstboksen inneholder minst 8 tegn
        ElseIf Pass.Length < 8 Then
            Me.regerror.SetError(txtpassword, "Passord må bestå av minst 8 Tegn")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtpassword, "")
            Return True
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'work in progress

        If Not ValidEmail() Then
            MsgBox(Me.regerror.GetError(txtemail))
        ElseIf Not ValidTelefon Then
            MsgBox(Me.regerror.GetError(txtphone))
        ElseIf Not ValidAdresse Then
            MsgBox(Me.regerror.GetError(txtaddress))
        ElseIf Not ValidPass Then
            MsgBox(Me.regerror.GetError(txtpassword))
        ElseIf Not ConfirmPass Then
            MsgBox(Me.regerror.GetError(txtconfirmpassword))
        Else

            connection = New MySqlConnection
            connection.ConnectionString =
           "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
            Dim Reader As MySqlDataReader

            Try
                connection.Open()
                Dim query As String
                query = "Update g_oops_03.User set e_mail='" & txtemail.Text & "',address='" & txtaddress.Text & "',phone='" & txtphone.Text & "',password='" & txtpassword.Text & "' where ss_number='" & MyPage.Label3.Text & "'"
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
        txtphone.Clear()
        txtpassword.Clear()
        txtconfirmpassword.Clear()
        txtaddress.Clear()
        txtemail.Clear()
        regerror.Clear()
        MyPage.Show()
    End Sub

End Class