Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class UserPage

    'Public tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
    'Public connection As MySqlConnection
    'Public COMMAND As MySqlCommand

    Dim constring As String = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
    Dim connection As New MySqlConnection(constring)
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim reader As MySqlDataReader
    Dim rad As DataRow
    Public ssNumber = LogIn.txtPersonnr.Text


    Public Sub showData()
        Try
            connection.Open()
            Dim query As String = "SELECT firstname, lastname, phone, e_mail, address, zip_code, password FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'"
            cmd = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(dtable)

            For Each rad In dtable.Rows
                txtFirstName.Text = (rad("firstname"))
                txtLastName.Text = (rad("lastname"))
                txtPhone.Text = (rad("phone"))
                txtMail.Text = (rad("e_mail"))
                txtAddress.Text = (rad("address"))
                txtZipcode.Text = (rad("zip_code"))
                txtPwd.Text = (rad("password"))
            Next

        Catch ex As MySqlException
            MsgBox(ex.Message)         'tilfelle det oppstår en feil
            connection.Close()

        Finally
            connection.Dispose()  'lukke tilkoblingen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        End Try
    End Sub

    Public Function ConfirmPass() As Boolean
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

    Public Sub updateData()




        If Not ConfirmPass() Then
            MsgBox(Me.regerror.GetError(txtConPwd))
        ElseIf Not ValidPass() Then
            MsgBox(Me.regerror.GetError(txtPwd))
        Else

            Try
                connection.Open()
                Dim query As String = "UPDATE User SET firstname = @firstname,lastname = @lastname,phone = @phone, e_mail = @email, address = @address, zip_code = @zipcode, password = @password where ss_number = '" & ssNumber & "'"
                cmd = New MySqlCommand(query, connection)

                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text)
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@email", txtMail.Text)
                cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@zipcode", txtZipcode.Text)
                cmd.Parameters.AddWithValue("@password", txtPwd.Text)

                reader = cmd.ExecuteReader

                MessageBox.Show("Data oppdatert")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                connection.Close()
            Finally
                connection.Dispose()
            End Try
        End If

    End Sub


    Public Sub showBloodData()
        Try
            '  connection.Open()
            Dim query As String = "SELECT blood_type, hb, iron_value, last_drain FROM Blood_Data WHERE ss_number='" & LogIn.txtPersonnr.Text & "'"
            cmd = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(dtable)

            For Each rad In dtable.Rows
                txtBtype.Text = (rad("blood_type")).ToString()
                txtHb.Text = (rad("hb")).ToString()
                txtIronValue.Text = (rad("iron_value")).ToString()
                txtDrain.Text = (rad("last_drain")).ToString()
            Next

        Catch ex As MySqlException
            MsgBox(ex.Message)         'tilfelle det oppstår en feil
            connection.Close()

        Finally
            connection.Dispose()  'lukke tilkoblingen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        End Try

    End Sub

    Public Sub getUser()

        connection.Open()
        Dim query As String = "SELECT ss_number, firstname, lastname FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'"
        cmd = New MySqlCommand(query, connection)
        adapter = New MySqlDataAdapter
        adapter.SelectCommand = cmd
        adapter.Fill(dtable)

        For Each rad In dtable.Rows
            lblFullName.Text = (rad("firstname") & " " & rad("lastname"))
            lblSSnumber.Text = (rad("ss_number")).ToString()
        Next



    End Sub


    Private Sub UserPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'DonorPage.Size = (Me.Height / 2) - (buttonMain.Height / 2)

        DonorPage.Location = New Point((Me.Width - DonorPage.Width) \ 2, (Me.Height - DonorPage.Height) \ 2)

        Me.MyPage.Text = "Min side "
        Me.BookTime.Text = "Bestill time"
        Me.ChangeData.Text = "Endre personopplysninger"
        Me.InfoPage.Text = "Informasjon Blodgiving"


        'Label18.Text = ssNumber

        showData()
        getUser()
        showBloodData()



        'Dim showUser As New User
        'showUser.showData(txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtMail.Text, txtAddress.Text, txtZipcode.Text, txtPwd.Text)


        'Dim da As New MySqlDataAdapter
        'Dim interntabel As New DataTable
        'Dim da2 As New MySqlDataAdapter      'de 3 neste her er for å få med seg blodtypen, statisk verdi og skal linkes opp mot txtpersonnr fra form1


        'Dim intern2 As New DataTable


        '        Dim rad As DataRow   'det vil være mange forskjellige variabler i hver rad i den interne tabellen


        'Dim da3 As New MySqlDataAdapter


        'Dim intern3 As New DataTable

        'Dim da4 As New MySqlDataAdapter

        'Dim intern4 As New DataTable

        'Try
        'tilkobling.Open()
        'Dim sqlBloodInfo As New MySqlCommand("SELECT last_Drain, hb, iron_Value FROM Blood_Data WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)   'kommando med variabel til å ta imot fra DB, og tilkoblingen
        'da.SelectCommand = sqlBloodInfo   'da(data_adapter) velger hvilken kommando som skal kjøres og "Kommanderer" de over til interntabellen med en sqlspørring hvor alt legges i variabelen fra linja over
        'da.Fill(interntabel)          'når kommandolinje er valgt og utføres, legges data inn i den internetabellen, som igjen laster rad for rad inn i textboxene

        'Dim sqltype As New MySqlCommand("SELECT blood_type FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)
        'Dim sqlname As New MySqlCommand("SELECT firstname, lastname FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)

        'da2.SelectCommand = sqlname
        'da2.Fill(intern2)
        'da3.SelectCommand = sqltype
        'da3.Fill(intern3)

        'Dim sqlEditInfo As New MySqlCommand("SELECT e_mail, phone, address, password, firstname, lastname FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)
        'da4.SelectCommand = sqlEditInfo
        'da4.Fill(intern4)

        'For Each rad In interntabel.Rows
        'txtDrain.Text = (rad("last_Drain"))
        'txtHb.Text = (rad("hb"))
        'txtIronValue.Text = (rad("iron_Value"))
        'Next


        'For Each rad In intern3.Rows
        'txtBtype.Text = (rad("blood_type"))
        'Next

        'For Each rad In intern4.Rows
        'txtFirstName.Text = (rad("firstname"))
        'txtLastName.Text = (rad("lastname"))
        'txtMail.Text = (rad("e_mail"))
        'txtPhone.Text = (rad("phone"))
        'txtAddress.Text = (rad("address"))
        'txtPwd.Text = (rad("password"))
        'txtConPwd.Text = txtPwd.Text
        'Next

        'Catch ex As MySqlException
        'MsgBox(ex.Message)        'tilfelle det oppstår en feil
        'Finally
        'tilkobling.Dispose()      'lukke tilkoblingen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        'End Try
    End Sub


    Private Sub btnChangeData_Click(sender As Object, e As EventArgs) Handles btnChangeData.Click

        'Dim updateUser As New User
        'updateUser.update(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtZipcode.Text, txtPhone.Text, txtMail.Text, txtPwd.Text)

        updateData()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

        Me.Hide()
        LogIn.Show()

    End Sub

    Private Sub ChangeData_Click(sender As Object, e As EventArgs) Handles ChangeData.Click

    End Sub

    Private Sub MyPage_Click(sender As Object, e As EventArgs) Handles MyPage.Click

    End Sub

    Private Sub btnQuest_Click(sender As Object, e As EventArgs) Handles btnQuest.Click
        Me.Hide()
        QuestionForm.Show()

    End Sub
End Class