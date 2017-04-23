﻿Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class UserPage

    'Public connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
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
    Private Sub UserPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As New User
        DonorPage.Size = New Size(1550, 750)

        Me.Size = SystemInformation.PrimaryMonitorSize
        DonorPage.Location = New Point((Me.Width - DonorPage.Width) \ 2, (Me.Height - DonorPage.Height) \ 2)

        btnSignOut.Location = New Point((Me.Width - btnSignOut.Width) \ 2 + 680,
                             (Me.Height - btnSignOut.Height) \ 2 - 330)

        verifySSNumber()
        getAppointmentTime()
        txtConPwd.Hide()
        confirmPwd.Hide()
        showData()
        user.getUser()
        showBloodData()



    End Sub


    'forskjellige variabler som blir forklart her eller lengre ned i koden
    'dags dato som må være på riktig format
    Public TodayDForm As String = Date.Now.ToString("yyyy.MM.dd")
    Public todayP1 As String = Date.Now.AddDays(+1)
    'dot består av Date og Time, men disse er ikke satt enda.
    Public dot As String = " "
    'newApp er 
    Public newAPP As String
    Public txtbxSSN As String

    'brukes til å hente ut OrdreID som må være 0 eller over 0 for å 
    Public busy, cancel As Integer
    Public DTPFormat As String
    Public verifySSN As String


    'denne suben fjerner ding-lyden som normalt kommer når man manipulerer entertasten
    Const CARRIAGE_RETURN As Char = Chr(13)

    Private Sub NoReturnTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = CARRIAGE_RETURN Then
            e.Handled = True
            System.Windows.Forms.SendKeys.Send(vbTab)
        End If

    End Sub
    Public Sub showData()

        Try
            connection.Open()
            Dim query As String = "SELECT firstname, lastname, phone, e_mail, address, zip_code, password FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'"
            cmd = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(dtable)

            For Each rad In dtable.Rows
                txtFirstName.Text = (rad("firstname")).ToString()
                txtLastName.Text = (rad("lastname")).ToString()
                txtPhone.Text = (rad("phone")).ToString()
                txtMail.Text = (rad("e_mail")).ToString()
                txtAddress.Text = (rad("address")).ToString()
                txtZipcode.Text = (rad("zip_code")).ToString()
                txtPwd.Text = (rad("password")).ToString()
                txtConPwd.Text = txtPwd.Text
            Next
        Catch ex As MySqlException
            MsgBox(ex.Message)         'tilfelle det oppstår en feil
            connection.Close()
        Finally
            connection.Dispose()  'lukke connectionen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        End Try
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
            If txtDrain.Text = "01/01/1900" Then
                txtDrain.Text = "Ikke Tappet"
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)         'tilfelle det oppstår en feil
            connection.Close()

        Finally
            connection.Dispose()  'lukke connectionen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        End Try

    End Sub




    Private Sub btnChangeData_Click(sender As Object, e As EventArgs) Handles btnChangeData.Click
        updateData()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        LogIn.Show()
    End Sub

    Private Sub btnQuest_Click(sender As Object, e As EventArgs) Handles btnQuest.Click
        QuestForm.checkIfApproved()
    End Sub

    Private Sub txtPwd_TextChanged(sender As Object, e As EventArgs) Handles txtPwd.Click
        confirmPwd.Show()
        txtConPwd.Show()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Close()
        LogIn.Show()
    End Sub

    Private Sub verifyLastDrain()
        Dim sql As New MySqlCommand("Select last_drain From Blood_Data WHERE ss_number =" & ssNumber & " ", connection)
    End Sub
    Private Sub verifySSNumber()
        'setter verifySSN lik tekstboksen hvor de ansatte har tastet inn personnummeret
        verifySSN = ssNumber
        lblLastDrain.Text = " "

        Try
            connection.Open()
            'sql spørringen henter ut last_drain som er siste tapping koblet til et person nummer
            Dim query As String = "Select last_drain From Blood_Data Where ss_number = '" & ssNumber & "' "
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable
            cmd = New MySqlCommand(query, connection)
            da.SelectCommand = cmd
            da.Fill(interntabell)
            connection.Close()


            'last drain lagres som datetime
            Dim last_drain As DateTime
            Dim LastDrainP90 As DateTime
            For Each rad In interntabell.Rows
                last_drain = rad("last_drain")
                'Dersom last_drain viser "01.01.1900", vil minimunsverdien til datetimepicker være dagens dato (today)
                If last_drain = "01.01.1900" Then
                    Me.DTPOrder.MinDate = Today
                    'Labelen lastDrain vil vise "Ikke tappet"
                    lblLastDrain.Text = "Ikke tappet"
                Else
                    'vi plusser på 90 dager på last drain, og gjør minimumsverdien til DateTimePicker (DTPOrder) til denne variabelen
                    'slik ungår vi at det vil være mindre enn 3 måneder mellom tappinger.
                    LastDrainP90 = last_drain.AddDays(+90)
                    Me.DTPOrder.MinDate = LastDrainP90
                    lblLastDrain.Text = last_drain
                End If
            Next rad
        Catch feilmelding As MySqlException
            MsgBox("Feil ved uthenting av siste tapping     " &
             feilmelding.Message, MsgBoxStyle.Critical, "feil")
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub OrderApp()
        Dim newDTPValue As String
        Dim DTPValue As Date
        Dim nxtTapp As String
        'newAAP (new appointment) består av datoen valgt i DateTimePicker (DTPOrder) og 
        'legger sammen et mellomrom med comboboxen (txtbxTime) for å lage en ny time.
        newAPP = DTPOrder.Text + " " + txtbxTime.Text

        'testcheck1 og 2 er for å sjekke om labelen lblnextAPP er avbestilt eller ikke satt opp,
        'ettersom lblnxtApp vanligvis er "Ikke satt opp" og forandres til "avbestilt" ved avbestil knappen
        Dim testCheck1 As Boolean
        Dim testcheck2 As Boolean

        'nxtApp.text lablen kan være et dato, "avbestilt" eller "ingen time satt opp"
        testCheck1 = lblnxtApp.Text Like "Avbestilt"
        testcheck2 = lblnxtApp.Text Like "Ikke satt opp"

        'her hentes verdien til kalender DateTimePicker og omformes et annet format
        DTPValue = Me.DTPOrder.Value
        newDTPValue = DTPValue.ToString("yyyy.MM.dd")

        nxtTapp = TodayDForm

        'denne if setningen er omformet slik at de som jobber her kan sette opp time før det er godt tre måneder, i tilfellet at noen ringer inn for ny time.
        If dot = newAPP Then
            'her sjekkes det om man har trykket på bestillingsknappen 2 ganger og kort sagt forsøkt å sette opp samme time 2 ganger.
            MsgBox("Du har allerede denne timen satt opp", MsgBoxStyle.Information, "Kalender")
        ElseIf testCheck1 = False And testcheck2 = False Then
            'her sjekkes det om lblnxtApp IKKE er "Avbestilt" og "Ikke satt opp", om en av de er satt opp er det en time satt opp.
            MsgBox("Time er allerede satt opp", MsgBoxStyle.Information, "Kalender")
        ElseIf testCheck1 = True And testcheck2 = True Then
            'her sjekkes det om lblnxtApp ligner på både "avbestilt" OG "Ikke satt opp", dette skal i utgangspunktet ikke være mulig.
            MsgBox("Noe gikk galt med sjekk etter tidligere oppsatt time", MsgBoxStyle.Information, "Kalender")

        ElseIf nxtTapp < newDTPValue Then
            'her sjekkes det at den nye timen er større enn dags dato, som betyr at timen ikke har passert.
            'busy variabelen tilbakestilles til 0 før hver spørring
            busy = 0

            'sjekker om timen er opptatt
            Try
                connection.Open()
                'en SQL spørring som henter ut cal_id fra calenderen basert på dato og tid som er satt inn i DateTimePicker og Comboboxen
                Dim sql As New MySqlCommand("SELECT cal_id FROM Order_Appointment Where date= '" & DTPOrder.Text & "' And time= '" & txtbxTime.Text & "' ", connection)
                Dim da As New MySqlDataAdapter
                Dim interntabell As New DataTable

                da.SelectCommand = sql
                da.Fill(interntabell)
                connection.Close()

                Dim rad As DataRow
                For Each rad In interntabell.Rows
                    'her blir busy raden opptadert til cal_id som blir hentet ut, om det ikke er noen calender id og hente ut så forblir busy = 0
                    busy = rad("Cal_id")
                Next rad

            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                connection.Dispose()
            End Try
            'her sjekkes det om busy er over 0 og siden busy er en cal_id vil if setningen ikke sette opp timene som er tatt.
            If busy > 1 Then
                MsgBox("timen er opptatt", MsgBoxStyle.Information, "Kalender")
            ElseIf busy = 0 Then

                Try
                    connection.Open()
                    Dim sporring As String
                    'Insert spørring hvor cal_id er autoincrement og ikke trengs og settes inn, etterfulgt av SSN, dato og tid
                    sporring = "Insert Into Order_Appointment (date, time, ss_number) VALUES ('" & DTPOrder.Text & "', '" & txtbxTime.Text & "', '" & ssNumber & "')"

                    Dim insertsql As New MySqlCommand(sporring, connection)
                    Dim da As New MySqlDataAdapter
                    Dim interntabell As New DataTable

                    da.SelectCommand = insertsql
                    da.Fill(interntabell)
                    connection.Close()

                    lblnxtApp.Text = DTPOrder.Value.ToString("dd/MM/yyyy") + " " + txtbxTime.Text
                    MsgBox("Time bestilt for dato: " & DTPOrder.Value.ToString("dd/MM/yyyy") & vbNewLine & "Klokken: " & txtbxTime.Text, MsgBoxStyle.Information, "Timebestilling")
                Catch feilmelding As MySqlException
                    MsgBox("Feil ved connection til databasen: bestilling " & feilmelding.Message)
                Finally
                    connection.Dispose()
                End Try
            End If
        End If
    End Sub

    Private Sub getAppointmentTime()
        Try
            'her tilbakestilles lblnxtApp.text i tilfellet at ansatte skifter person nummer og at deres info ikke skal være igjen.
            lblnxtApp.Text = "Ikke satt opp"
            connection.Open()
            'sql spørringen henter ut cal_id, time, og dag fra calenderen basert på max(cal_id) til et personnummer
            Dim query As String = "Select cal_id, date, time From Order_Appointment Where ss_number =" & ssNumber & " And cal_id = (Select MAX(cal_id) From Order_Appointment Where ss_number = '" & ssNumber & "')"
            cmd = New MySqlCommand(query, connection)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            da.SelectCommand = cmd
            da.Fill(interntabell)
            connection.Close()

            Dim rad As DataRow
            Dim time, cal_id As String
            Dim appDate As Date
            For Each rad In interntabell.Rows
                cal_id = rad("cal_id")
                appDate = rad("date")
                time = rad("time")
                'opptaderer dot (Date og Time) slik at brukeren får feedback på neste time.
                dot = appDate.ToString("dd/MM/yyyy") + " " + time
                'lblnxtApp er labelen som viser neste time.
                lblnxtApp.Text = dot
                cancel = cal_id

            Next rad
        Catch feilmelding As MySqlException
            MsgBox("Feil ved connection til databasen fra form Cal_load:     " &
         feilmelding.Message)
            'dot nullstilles
            dot = " "
        Finally
            connection.Dispose()
        End Try
    End Sub


    Private Sub deleteApp()
        'cancel blir satt tilbakestilt før hver spørring
        'cancel er en variabel som blir opptadert til max(cal_id) til en person sitt person nummer
        'så lenge cancel > 0 så vil denne personens oppsatte time (eller ved en feil med flere timer) alle timene bli slettet
        cancel = 0

        '= txtpaoSSN.Text


        Try
                connection.Open()
                'select spørring som henter ut den max(cal_id) til et person nummer
                Dim sql As New MySqlCommand("Select Cal_id From Order_Appointment Where Cal_id = (Select MAX(Cal_id) From Order_Appointment Where ss_number =" & ssNumber & ") ", connection)
                Dim da As New MySqlDataAdapter
                Dim interntabell As New DataTable

                da.SelectCommand = sql
                da.Fill(interntabell)
                connection.Close()

                Dim rad As DataRow
                Dim Cal_id As String
                For Each rad In interntabell.Rows

                    Cal_id = rad("Cal_id")
                    'cancel blir opptader til cal_id som hentes ut, ellers forblir den 0
                    cancel = Cal_id

                Next rad
            Catch ex As MySqlException
                MsgBox("Mangler personnummer", MsgBoxStyle.Critical, "Feil")
                'ved feil i spørringen så stopper vi slettingen av spørringen
                cancel = 0
            Finally
                connection.Dispose()
            End Try
            'avbestilingen går bare igjennom sålenge personnummmeret har et
            If cancel > 0 Then

                Try
                    connection.Open()
                'spørringen sletter alle timebestillinger til et personnummer, men i praksis skal det bare være en bestilling pr. person nummer.
                Dim sql As New MySqlCommand("Delete From `Order_Appointment` Where `ss_number`=" & ssNumber & " ", connection)
                Dim da As New MySqlDataAdapter
                    Dim interntabell As New DataTable

                    da.SelectCommand = sql
                    da.Fill(interntabell)
                    connection.Close()

                    Dim rad As DataRow
                    Dim Cal_id As String
                    For Each rad In interntabell.Rows
                        Cal_id = rad("Cal_id")
                    Next rad
                    'lblnxtApp brukes som feedback til brukeren om at timen er avbestilt. 
                    'ved neste innlogging vil det stå "Ikke satt opp" om det ikke er noen time satt opp.
                    lblnxtApp.Text = "Avbestilt"
                    MsgBox("Time avbestilt", MsgBoxStyle.Information, "Avbestilt")
                Catch feilmelding As MySqlException
                    MsgBox(" kunne ikke slette time fra kalender: " &
                 feilmelding.Message)
                Finally
                    connection.Dispose()
                End Try
            Else
                MsgBox("Ingen time å avbestille", MsgBoxStyle.Information, "Feil")
            End If

    End Sub

    Private Sub BtnOrderApp_Click(sender As Object, e As EventArgs) Handles btnOrderApp.Click

        If txtQuarantine.Text = "Livstid" Then
            MsgBox("Du er i karantene og kan desverre ikke gi blod", MsgBoxStyle.Critical, "Oops!")
        ElseIf txtQuarantine.Text = "" Then
            OrderApp()
        ElseIf Not txtQuarantine.Text = "Godkjent" Then
            MsgBox("Du har karantene til " & txtQuarantine.Text & vbNewLine & "Vennligst vent til karantenen er utløpt før du bestiller time.", MsgBoxStyle.Information, "obs!")
        Else
            OrderApp()
        End If

    End Sub




    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Åpner link til nettside
        Dim url As String = “https://giblod.no/default.aspx“
        Process.Start(url)
    End Sub

    Private Sub btnCApp_Click(sender As Object, e As EventArgs) Handles btnCApp.Click
        deleteApp()
    End Sub


#Region "Endre Personinfo tekstbox validering"

    Private Sub txtFirstname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged, txtLastName.TextChanged, txtAddress.TextChanged
        'Gjør om første bokstav i relevante tekstbokser til Upper-Case
        If txtFirstName.Text <> "" Then
            Dim a As String = txtFirstName.Text
            txtFirstName.Text = (StrConv(a, VbStrConv.ProperCase))
            txtFirstName.Select(txtFirstName.Text.Length, 0)
        End If
        If txtLastName.Text <> "" Then
            Dim a As String = txtLastName.Text
            txtLastName.Text = (StrConv(a, VbStrConv.ProperCase))
            txtLastName.Select(txtLastName.Text.Length, 0)
        End If
        If txtAddress.Text <> "" Then
            Dim a As String = txtAddress.Text
            txtAddress.Text = (StrConv(a, VbStrConv.ProperCase))
            txtAddress.Select(txtAddress.Text.Length, 0)
        End If
    End Sub

    Public Function ValidFornavn() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Fornavn = txtFirstName.Text
        If Fornavn.Length = 0 Then
            Me.regerror.SetError(txtFirstName, "Vennligst fyll ut fornavn")
            Return False
            'Validerer at tekstboksen kun inneholder et bestemt sett av tegn (kun bokstaver)
        ElseIf Not Regex.IsMatch(Fornavn, "^[\p{L} ]+$") Then
            Me.regerror.SetError(txtFirstName, "Fornavn kan bare inneholde bokstaver")
            Return False
        Else
            'Om betingelser er møtt, gå videre
            Me.regerror.SetError(txtFirstName, "")
            Return True
        End If
    End Function
    Private Function ValidEtternavn() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Etternavn = txtLastName.Text
        If Etternavn.Length = 0 Then
            Me.regerror.SetError(txtLastName, "Vennligst fyll ut etternavn")
            Return False
            'Validerer at tekstboksen kun inneholder et bestemt sett av tegn (bokstaver)
        ElseIf Not Regex.IsMatch(Etternavn, "^[\p{L} ]+$") Then
            Me.regerror.SetError(txtLastName, "Etternavn kan bare inneholde bokstaver")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtLastName, "")
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
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtPhone, "")
            Return True
        End If
    End Function
    Private Function ValidPostnr() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Postnr = txtZipcode.Text
        If Postnr.Length = 0 Then
            Me.regerror.SetError(txtZipcode, "Vennligst fyll ut postnummer")
            Return False
            'Validerer at tekstboksen inneholder ett bestemt antall tegn (4 tegn)
        ElseIf Not Postnr.Length = 4 Then
            Me.regerror.SetError(txtZipcode, "Postnummer må bestå av 4 tall")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtZipcode, "")
            Return True
        End If
    End Function

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
    'Oppdatere karantene og siste tappe status
    Private Sub UpdateDrainandquarantine()
        connection.Open()
        Dim query As String = "SELECT TableUser.quarantine, TableBlood.last_drain FROM User TableUser INNER JOIN Blood_Data TableBlood on TableUser.ss_number=TableBlood.ss_number WHERE TableUser.ss_number='" & lblSSnumber.Text & "'"
        cmd = New MySqlCommand(query, connection)
        adapter = New MySqlDataAdapter
        adapter.SelectCommand = cmd
        adapter.Fill(dtable)

        For Each rad In dtable.Rows
            txtDrain.Text = (rad("last_drain")).ToString()
            txtQuarantine.Text = (rad("quarantine")).ToString()
        Next
        If txtDrain.Text = "01/01/1900" Then
            txtDrain.Text = "Ikke Tappet"
        End If
        connection.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdateQuarantine.Click
        UpdateDrainandquarantine()

    End Sub


#End Region

    Public Sub updateData()

        If Not ValidFornavn() Then
            MsgBox(Me.regerror.GetError(txtFirstName), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidEtternavn() Then
            MsgBox(Me.regerror.GetError(txtLastName), MsgBoxStyle.Critical, "Oops!")

        ElseIf Not ValidAdresse() Then
            MsgBox(Me.regerror.GetError(txtAddress), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidPostnr() Then
            MsgBox(Me.regerror.GetError(txtZipcode), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidEmail() Then
            MsgBox(Me.regerror.GetError(txtMail), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidTelefon() Then
            MsgBox(Me.regerror.GetError(txtPhone), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidPass() Then
            MsgBox(Me.regerror.GetError(txtPwd), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ConfirmPass() Then
            MsgBox(Me.regerror.GetError(txtConPwd), MsgBoxStyle.Critical, "Oops!")

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
                confirmPwd.Hide()
                txtConPwd.Hide()
                MsgBox("Data oppdatert!", MsgBoxStyle.Information, "Vellykket!")
                reader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                connection.Close()
            Finally
                connection.Dispose()
            End Try
        End If

    End Sub

End Class
