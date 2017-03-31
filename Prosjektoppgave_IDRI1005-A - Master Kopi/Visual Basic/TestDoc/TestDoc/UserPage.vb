Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class UserPage
    Public tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
    Public connection As MySqlConnection
    Public COMMAND As MySqlCommand

    Private Sub UserPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MyPage.Text = "Min side "
        Me.BookTime.Text = "Bestill time"
        Me.ChangeData.Text = "Endre personopplysninger"
        Me.InfoPage.Text = "Informasjon Blodgiving"

        Dim da As New MySqlDataAdapter
        Dim interntabel As New DataTable
        Dim da2 As New MySqlDataAdapter      'de 3 neste her er for å få med seg blodtypen, statisk verdi og skal linkes opp mot txtpersonnr fra form1
        Dim intern2 As New DataTable
        Dim rad As DataRow   'det vil være mange forskjellige variabler i hver rad i den interne tabellen
        Dim da3 As New MySqlDataAdapter
        Dim intern3 As New DataTable
        Dim da4 As New MySqlDataAdapter
        Dim intern4 As New DataTable

        Try
            tilkobling.Open()
            Dim sqlBloodInfo As New MySqlCommand("SELECT last_Drain, hb, iron_Value FROM Blood_Data WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)   'kommando med variabel til å ta imot fra DB, og tilkoblingen
            da.SelectCommand = sqlBloodInfo   'da(data_adapter) velger hvilken kommando som skal kjøres og "Kommanderer" de over til interntabellen med en sqlspørring hvor alt legges i variabelen fra linja over
            da.Fill(interntabel)          'når kommandolinje er valgt og utføres, legges data inn i den internetabellen, som igjen laster rad for rad inn i textboxene
            Dim sqltype As New MySqlCommand("SELECT blood_type FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)
            Dim sqlname As New MySqlCommand("SELECT firstname, lastname FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)
            da2.SelectCommand = sqlname
            da2.Fill(intern2)
            da3.SelectCommand = sqltype
            da3.Fill(intern3)
            Dim sqlEditInfo As New MySqlCommand("SELECT e_mail, phone, address, password, firstname, lastname FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)
            da4.SelectCommand = sqlEditInfo
            da4.Fill(intern4)

            For Each rad In interntabel.Rows
                txtDrain.Text = (rad("last_Drain"))
                txtHb.Text = (rad("hb"))
                txtIronValue.Text = (rad("iron_Value"))
            Next

            For Each rad In intern2.Rows
                Label1.Text = (rad("firstname") & " " & rad("lastname"))
            Next

            For Each rad In intern3.Rows
                txtBtype.Text = (rad("blood_type"))
            Next

            For Each rad In intern4.Rows
                txtFirstName.Text = (rad("firstname"))
                txtLastName.Text = (rad("lastname"))
                txtMail.Text = (rad("e_mail"))
                txtPhone.Text = (rad("phone"))
                txtAddress.Text = (rad("address"))
                txtPwd.Text = (rad("password"))
                txtConPwd.Text = txtPwd.Text
            Next

        Catch ex As MySqlException
            MsgBox(ex.Message)        'tilfelle det oppstår en feil
        Finally
            tilkobling.Dispose()      'lukke tilkoblingen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        End Try



    End Sub

    Private Sub btnChangeData_Click(sender As Object, e As EventArgs) Handles btnChangeData.Click
        'Dim sqlQuery As String = "SELECT e_mail, phone, address, password FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'"
        'Using sqlConn As New MySqlConnection(tilkobling)
        '    Using sqlComm As New MySqlCommand()
        '        With sqlComm
        '            .Connection = sqlConn
        '            .CommandText = sqlQuery
        '            .CommandType = CommandType.Text
        '        End With
        '        Try
        '            sqlConn.Open()
        '            Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
        '            While sqlReader.Read()
        '                txtMail.Text = sqlReader("e_mail")
        '                txtPhone.Text = sqlReader("phone")
        '                txtAddress.Text = sqlReader("address")
        '                txtPwd.Text = sqlReader("password")
        '                txtConPwd.Text = txtPwd.Text
        '            End While
        '        Catch ex As MySqlException
        '            ' add your exception here '
        '        End Try
        '    End Using
        ' End Using
        If Not ValidEmail() Then
            MsgBox(Me.regerror.GetError(txtMail))
        ElseIf Not ValidTelefon() Then
            MsgBox(Me.regerror.GetError(txtPhone))
        ElseIf Not ValidAdresse() Then
            MsgBox(Me.regerror.GetError(txtAddress))
        ElseIf Not ValidPass() Then
            MsgBox(Me.regerror.GetError(txtPwd))
        ElseIf Not ConfirmPass() Then
            MsgBox(Me.regerror.GetError(txtConPwd))
        Else

            connection = New MySqlConnection
            connection.ConnectionString =
       "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
            Dim Reader As MySqlDataReader

            Try
                connection.Open()
                Dim query As String
                query = "Update g_oops_03.User set e_mail='" & txtMail.Text & "',address='" & txtAddress.Text & "',phone='" & txtPhone.Text & "',password='" & txtPwd.Text & "' where ss_number='" & LogIn.Text & "'"
                COMMAND = New MySqlCommand(query, connection)
                Reader = COMMAND.ExecuteReader()

                MsgBox("Personopplysninger er oppdatert!", MsgBoxStyle.Information, "Vellykket")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                connection.Close()
            End Try
        End If

    End Sub
    Private Function ValidEmail() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim epost = txtMail.Text
        If epost.Length = 0 Then
            Me.regerror.SetError(txtMail, "Vennligst fyll ut E-Post")
            Return False
        End If
        'Validerer at tekstboksen inneholder riktige tegn ("@" og "." i riktig rekkefølge og riktig antall tegn(Ikke mer enn et "@" og "."))
        Dim errorMessage = "E-Post adresse må være av gyldig format" + ControlChars.Cr +
        "Eksempel 'olanordmann@eksempel.no' "
        Me.regerror.SetError(txtMail, errorMessage)
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
        Me.regerror.SetError(txtMail, "")
        Return True
    End Function

    Private Function ValidTelefon() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim telefonnr = txtPhone.Text
        If telefonnr.Length = 0 Then
            Me.regerror.SetError(txtPhone, "Vennligst fyll ut telefonnummer")
            Return False
            'Validerer at tekstboksen inneholder ett bestemt antall tegn (8 tegn)
        ElseIf Not telefonnr.Length = 8 Then
            Me.regerror.SetError(txtPhone, "Telefonnummer må bestå av 8 Tall")
            Return False
            'Validerer at tekstboksen kun inneholder et bestemt sett av tegn (kun tall)
        ElseIf Not Regex.IsMatch(telefonnr, "^[0-9]+$") Then
            Me.regerror.SetError(txtPhone, "Telefonnummer kan bare bestå av tall")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtPhone, "")
            Return True
        End If
    End Function
    Private Function ValidAdresse() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Adresse = txtAddress.Text
        If Adresse.Length = 0 Then
            Me.regerror.SetError(txtAddress, "Vennligst fyll ut adresse")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtAddress, "")
            Return True
        End If
    End Function
    Private Function ConfirmPass() As Boolean
        'Validerer at innholdet i "passord" og "bekreft passord" tekstboksene er identiske
        If Not txtPwd.Text.Equals(txtConPwd.Text) Then
            Me.regerror.SetError(txtConPwd, "Passordene må være like")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtConPwd, "")
            Return True
        End If
    End Function
    Private Function ValidPass() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Pass = txtPwd.Text
        If Pass.Length = 0 Then
            Me.regerror.SetError(txtPwd, "Vennligst fyll ut et passord")
            Return False
            'Validerer at tekstboksen inneholder minst 8 tegn
        ElseIf Pass.Length < 8 Then
            Me.regerror.SetError(txtPwd, "Passord må bestå av minst 8 Tegn")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtPwd, "")
            Return True
        End If
    End Function

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

    End Sub

    Private Sub logedOut_Click(sender As Object, e As EventArgs) Handles logedOut.Click
        Me.Close()
        LogIn.Show()
    End Sub
    '    Private Sub btnChangeData_Click(sender As Object, e As EventArgs) Handles btnChangeData.Click
    'work in progress

    ' If Not ValidEmail() Then
    '     MsgBox(Me.regerror.GetError(txtMail))
    ' ElseIf Not ValidTelefon() Then
    '     MsgBox(Me.regerror.GetError(txtPhone))
    ' ElseIf Not ValidAdresse() Then
    '     MsgBox(Me.regerror.GetError(txtAddress))
    ' ElseIf Not ValidPass() Then
    '     MsgBox(Me.regerror.GetError(txtPwd))
    ' ElseIf Not ConfirmPass() Then
    '     MsgBox(Me.regerror.GetError(txtConPwd))
    ' Else

    '     connection = New MySqlConnection
    '     connection.ConnectionString =
    '"Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
    '     Dim Reader As MySqlDataReader

    '     Try
    '         connection.Open()
    '         Dim query As String
    '         query = "Update g_oops_03.User set e_mail='" & txtMail.Text & "',address='" & txtAddress.Text & "',phone='" & txtPhone.Text & "',password='" & txtpassword.Text & "' where ss_number='" & MyPage.Label3.Text & "'"
    '         COMMAND = New MySqlCommand(query, connection)
    '         Reader = COMMAND.ExecuteReader()

    '         MsgBox("Personopplysninger er oppdatert!", MsgBoxStyle.Information, "Vellykket")
    '     Catch ex As Exception
    '         MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
    '         connection.Close()
    '     End Try
    ' End If
    '  End Sub




End Class