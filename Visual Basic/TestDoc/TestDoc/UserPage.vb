Imports System.Text.RegularExpressions
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

        verifySSNumber()




        DonorPage.Size = New Size(1550, 750)

        Me.Size = SystemInformation.PrimaryMonitorSize
        DonorPage.Location = New Point((Me.Width - DonorPage.Width) \ 2, (Me.Height - DonorPage.Height) \ 2)

        btnSignOut.Location = New Point((Me.Width - btnSignOut.Width) \ 2 + 800,
                             (Me.Height - btnSignOut.Height) \ 2 - 450)

        'Changeuserinfo.Location = New Point((ChangeData.Width - Changeuserinfo.Width) \ 2,
        '                     (ChangeData.Height - Changeuserinfo.Height) \ 2 + 50)

        txtConPwd.Hide()
        confirmPwd.Hide()



        'Label18.Text = ssNumber

        showData()
        Dim user As New User
        user.getUser()
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
        'connection.Open()
        'Dim sqlBloodInfo As New MySqlCommand("SELECT last_Drain, hb, iron_Value FROM Blood_Data WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", connection)   'kommando med variabel til å ta imot fra DB, og connectionen
        'da.SelectCommand = sqlBloodInfo   'da(data_adapter) velger hvilken kommando som skal kjøres og "Kommanderer" de over til interntabellen med en sqlspørring hvor alt legges i variabelen fra linja over
        'da.Fill(interntabel)          'når kommandolinje er valgt og utføres, legges data inn i den internetabellen, som igjen laster rad for rad inn i textboxene

        'Dim sqltype As New MySqlCommand("SELECT blood_type FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", connection)
        'Dim sqlname As New MySqlCommand("SELECT firstname, lastname FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", connection)

        'da2.SelectCommand = sqlname
        'da2.Fill(intern2)
        'da3.SelectCommand = sqltype
        'da3.Fill(intern3)

        'Dim sqlEditInfo As New MySqlCommand("SELECT e_mail, phone, address, password, firstname, lastname FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", connection)
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
        'connection.Dispose()      'lukke connectionen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        'End Try



    End Sub

#Region "pao public var"
    Public tilkobling As New MySqlConnection(
"Server=mysql.stud.iie.ntnu.no;" _
& "Database=g_oops_03;" _
& "Uid=g_oops_03;" _
& "Pwd=mczmmM3N;")
    'forskjellige variabler som blir forklart her eller lengre ned i koden
    'dags dato som må være på riktig format
    Public TodayDForm As String = Date.Now.ToString("yyyy.MM.dd")
    'dot består av Date og Time, men disse er ikke satt enda.
    Public dot As String = " "
    'newApp er 
    Public newAPP As String
    Public txtbxSSN As String

    'brukes til å hente ut OrdreID som må være 0 eller over 0 for å 
    Public busy, cancel As Integer
    Public DTPFormat As String
    Public verifySSN As String


#End Region

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

        Catch ex As MySqlException
            MsgBox(ex.Message)         'tilfelle det oppstår en feil
            connection.Close()

        Finally
            connection.Dispose()  'lukke connectionen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        End Try

    End Sub

    'Public Sub getUser()

    '    connection.Open()
    '    Dim query As String = "SELECT ss_number, firstname, lastname, quarantine FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'"
    '    cmd = New MySqlCommand(query, connection)
    '    adapter = New MySqlDataAdapter
    '    adapter.SelectCommand = cmd
    '    adapter.Fill(dtable)

    '    For Each rad In dtable.Rows
    '        lblFullName.Text = (rad("firstname") & " " & rad("lastname"))
    '        lblSSnumber.Text = (rad("ss_number")).ToString()
    '        TextBox1.Text = (rad("quarantine")).ToString()
    '    Next

    'End Sub


    Private Sub btnChangeData_Click(sender As Object, e As EventArgs) Handles btnChangeData.Click

        'Dim updateUser As New User
        'updateUser.update(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtZipcode.Text, txtPhone.Text, txtMail.Text, txtPwd.Text)

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

    '#End Region

    Private Sub verifySSNumber()
        'setter verifySSN lik tekstboksen hvor de ansatte har tastet inn personnummeret
        verifySSN = ssNumber
        lblLastDrain.Text = " "

        Try
            tilkobling.Open()
            'sql spørringen henter ut last_drain som er siste tapping koblet til et person nummer
            Dim sql As New MySqlCommand("Select last_drain From Blood_Data Where ss_number =" & ssNumber & " ", tilkobling)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable
            da.SelectCommand = sql
            da.Fill(interntabell)
            tilkobling.Close()

            Dim rad As DataRow
            'last drain lagres som datetime
            Dim last_drain As DateTime
            Dim LastDrainP90 As DateTime
            For Each rad In interntabell.Rows

                last_drain = rad("last_drain")
                'vi plusser på 91 dager på last drain, og gjør minimumsverdien til DateTimePicker (DTPOrder) til denne variabelen
                'slik ungår vi at det vil være mindre enn 3 måneder mellom tappinger.
                LastDrainP90 = last_drain.AddDays(+91)
                Me.DTPOrder.MinDate = LastDrainP90
                lblLastDrain.Text = last_drain
            Next rad
        Catch feilmelding As MySqlException
            MsgBox("Feil ved uthenting av siste tapping     " &
             feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try

        Try
            'her tilbakestilles lblnxtApp.text i tilfellet at ansatte skifter person nummer og at deres info ikke skal være igjen.
            lblnxtApp.Text = "Ikke satt opp"
            tilkobling.Open()
            'sql spørringen henter ut cal_id, time, og dag fra calenderen basert på max(cal_id) til et personnummer
            Dim sql As New MySqlCommand("Select cal_id, day, time From Calendar Where ss_number =" & ssNumber & " And cal_id = (Select MAX(cal_id) From Calendar Where ss_number =" & ssNumber & ")", tilkobling)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            da.SelectCommand = sql
            da.Fill(interntabell)
            tilkobling.Close()

            Dim rad As DataRow
            Dim day, time, cal_id As String
            For Each rad In interntabell.Rows

                cal_id = rad("cal_id")
                day = rad("day")
                time = rad("time")
                'opptaderer dot (Date og Time) slik at brukeren får feedback på neste time.
                dot = day + " " + time
                'lblnxtApp er labelen som viser neste time.
                lblnxtApp.Text = dot
                cancel = cal_id

            Next rad
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen fra form Cal_load:     " &
             feilmelding.Message)
            'dot nullstilles
            dot = " "
        Finally
            tilkobling.Dispose()
        End Try

    End Sub
#Region "pao Verify Social Security Number"

#End Region
    'innlogging:   g_oops_03
    'lbl = short for Label
    'bx = short for Box
    'Passord.... : mczmmM3N
    'txt = short for Text
    'LB = short for ListBox
    'App = short for appointment in regards of naming, buttons, labels in the Cal.vb
    'hist = short for history
    'Nxt = short for next

#Region "pao Order button and sql"
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
            MsgBox("Du har allerede denne timen satt opp!", MsgBoxStyle.Information, "Timebestilling")
        ElseIf testCheck1 = False And testcheck2 = False Then
            'her sjekkes det om lblnxtApp IKKE er "Avbestilt" og "Ikke satt opp", om en av de er satt opp er det en time satt opp.
            MsgBox("Time er allerede satt opp!", MsgBoxStyle.Information, "Timebestilling")
        ElseIf testCheck1 = True And testcheck2 = True Then
            'her sjekkes det om lblnxtApp ligner på både "avbestilt" OG "Ikke satt opp", dette skal i utgangspunktet ikke være mulig.
            MsgBox("Noe gikk galt med sjekk etter tidligere oppsatt time", MsgBoxStyle.Information, "Timebestilling")

        ElseIf nxtTapp < newDTPValue Then
            'her sjekkes det at den nye timen er større enn dags dato, som betyr at timen ikke har passert.
            'busy variabelen tilbakestilles til 0 før hver spørring
            busy = 0

            Try

                tilkobling.Open()
                'en SQL spørring som henter ut cal_id fra calenderen basert på dato og tid som er satt inn i DateTimePicker og Comboboxen
                Dim sql As New MySqlCommand("SELECT Cal_id FROM Calendar Where Day= '" & DTPOrder.Text & "' And time= '" & txtbxTime.Text & "' ", tilkobling)
                Dim da As New MySqlDataAdapter
                Dim interntabell As New DataTable

                da.SelectCommand = sql
                da.Fill(interntabell)
                tilkobling.Close()

                Dim rad As DataRow
                For Each rad In interntabell.Rows
                    'her blir busy raden opptadert til cal_id som blir hentet ut, om det ikke er noen calender id og hente ut så forblir busy = 0
                    busy = rad("Cal_id")

                Next rad
            Catch feilmelding As MySqlException
                MsgBox("Feil med variabel busy   " &
feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try
            'her sjekkes det om busy er over 0 og siden busy er en cal_id vil if setningen ikke sette opp timene som er tatt.
            If busy > 1 Then
                MsgBox("Timen er opptatt! Velg en annen dato eller klokkeslett.", MsgBoxStyle.Information, "Timebestilling")
            ElseIf busy = 0 Then
                Try
                    tilkobling.Open()
                    Dim sporring As String
                    'Insert spørring hvor cal_id er autoincrement og ikke trengs og settes inn, etterfulgt av SSN, dato og tid
                    sporring = "Insert Into Calendar VALUES (' ', '" & ssNumber & "', '" & DTPOrder.Text & "', '" & txtbxTime.Text & "')"

                    Dim insertsql As New MySqlCommand(sporring, tilkobling)
                    Dim da As New MySqlDataAdapter
                    Dim interntabell As New DataTable

                    da.SelectCommand = insertsql
                    da.Fill(interntabell)
                    tilkobling.Close()

                    'lblOdate og lblOtime
                    ' lblODate.Text = DTPOrder.Text
                    ' lblOTime.Text = txtbxTime.Text
                    lblnxtApp.Text = DTPOrder.Text + " " + txtbxTime.Text
                    MsgBox("Time bestilt for dato: " & DTPOrder.Text & vbNewLine & "Klokken: " & txtbxTime.Text & "!", MsgBoxStyle.Information, "Timebestilling")
                Catch feilmelding As MySqlException
                    MsgBox("Feil ved tilkobling til databasen: bestilling " & feilmelding.Message)
                Finally
                    tilkobling.Dispose()
                End Try
            End If
        End If
    End Sub
    Private Sub BtnOrderApp_Click(sender As Object, e As EventArgs) Handles btnOrderApp.Click
        OrderApp()
    End Sub
#End Region

#Region "pao Delete Order button and sql"
    Private Sub deleteApp()
        'cancel blir satt tilbakestilt før hver spørring
        'cancel er en variabel som blir opptadert til max(cal_id) til en person sitt person nummer
        'så lenge cancel > 0 så vil denne personens oppsatte time (eller ved en feil med flere timer) alle timene bli slettet
        cancel = 0

        '= txtpaoSSN.Text
        If verifySSN = ssNumber Then
            txtbxSSN = verifySSN

            Try
                tilkobling.Open()
                'select spørring som henter ut den max(cal_id) til et person nummer
                Dim sql As New MySqlCommand("Select Cal_id From Calendar Where Cal_id = (Select MAX(Cal_id) From Calendar Where ss_number =" & ssNumber & ") ", tilkobling)
                Dim da As New MySqlDataAdapter
                Dim interntabell As New DataTable

                da.SelectCommand = sql
                da.Fill(interntabell)
                tilkobling.Close()

                Dim rad As DataRow
                Dim Cal_id As String
                For Each rad In interntabell.Rows

                    Cal_id = rad("Cal_id")
                    'cancel blir opptader til cal_id som hentes ut, ellers forblir den 0
                    cancel = Cal_id

                Next rad
            Catch feilmelding As MySqlException
                MsgBox("Feil ved spørring, avbestilling kanseleres: " &
         feilmelding.Message)
                'ved feil i spørringen så stopper vi slettingen av spørringen
                cancel = 0
            Finally
                tilkobling.Dispose()
            End Try
            'avbestilingen går bare igjennom sålenge personnummmeret har et
            If cancel > 0 Then

                Try
                    tilkobling.Open()

                    'spørringen sletter alle timebestillinger til et personnummer, men i praksis skal det bare være en bestilling pr. person nummer.
                    Dim sql As New MySqlCommand("Delete From `Calendar` Where `ss_number`=" & ssNumber & " ", tilkobling)
                    Dim da As New MySqlDataAdapter
                    Dim interntabell As New DataTable

                    da.SelectCommand = sql
                    da.Fill(interntabell)
                    tilkobling.Close()

                    Dim rad As DataRow
                    Dim Cal_id As String
                    For Each rad In interntabell.Rows
                        Cal_id = rad("Cal_id")
                    Next rad
                    'lblnxtApp brukes som feedback til brukeren om at timen er avbestilt. 
                    'ved neste innlogging vil det stå "Ikke satt opp" om det ikke er noen time satt opp.
                    lblnxtApp.Text = "Avbestilt"
                    MsgBox("Timen er avbestilt!", MsgBoxStyle.Information, "Timebestilling")
                Catch feilmelding As MySqlException
                    MsgBox(" kunne ikke slette time fra kalender: " &
                 feilmelding.Message, MsgBoxStyle.Information, "Timebestilling")
                Finally
                    tilkobling.Dispose()
                End Try
            Else
                MsgBox("Ingen time å avbestille", MsgBoxStyle.Information, "Timebestilling")
            End If

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = “https://giblod.no/default.aspx“

        Process.Start(url)
    End Sub

    Private Sub btnCApp_Click(sender As Object, e As EventArgs) Handles btnCApp.Click
        deleteApp()
    End Sub
#End Region

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
