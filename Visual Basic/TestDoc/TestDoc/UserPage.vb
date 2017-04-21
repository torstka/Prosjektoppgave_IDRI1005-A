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

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFirstName.KeyDown
        If e.KeyCode = Keys.Enter Then     'her kan man flytte med bruk av ENTER mellom textboxer, av hensyn til nedsatt bevegelighet
            txtLastName.Focus()                 'gjelder for alle 8 følgende koder nedover
        End If
    End Sub
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLastName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAddress.Focus()
        End If
    End Sub
    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtZipcode.Focus()
        End If
    End Sub
    Private Sub TextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZipcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPhone.Focus()
        End If
    End Sub
    Private Sub TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMail.Focus()
        End If
    End Sub
    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPwd.Focus()
        End If
    End Sub
    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtConPwd.Focus()
            e.Handled = e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub TextBox8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConPwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangeData.Focus()
            e.Handled = e.SuppressKeyPress = True
        End If
    End Sub
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
                confirmPwd.Hide()
                txtConPwd.Hide()
                MessageBox.Show("Data oppdatert")
                reader.Close()
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

    Private Sub UserPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        verifySSNumber()



        DonorPage.Size = New Size(1550, 750)

        Me.Size = SystemInformation.PrimaryMonitorSize
        DonorPage.Location = New Point((Me.Width - DonorPage.Width) \ 2, (Me.Height - DonorPage.Height) \ 2)

        btnSignOut.Location = New Point((UserInformation.Width - btnSignOut.Width) \ 2 + 800,
                             (UserInformation.Height - btnSignOut.Height) \ 2 - 450)

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
            MsgBox("du har allerede denne timen satt opp")
        ElseIf testCheck1 = False And testcheck2 = False Then
            'her sjekkes det om lblnxtApp IKKE er "Avbestilt" og "Ikke satt opp", om en av de er satt opp er det en time satt opp.
            MsgBox("time er allerede satt opp")
        ElseIf testCheck1 = True And testcheck2 = True Then
            'her sjekkes det om lblnxtApp ligner på både "avbestilt" OG "Ikke satt opp", dette skal i utgangspunktet ikke være mulig.
            MsgBox("noe gikk galt med sjekk etter tidligere oppsatt time")

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
                MsgBox("timen er opptatt")
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

                Catch feilmelding As MySqlException
                    MsgBox(" kunne ikke slette time fra kalender: " &
                 feilmelding.Message)
                Finally
                    tilkobling.Dispose()
                End Try
            Else
                MsgBox("Ingen time å avbestille")
            End If

        End If
    End Sub
    Private Sub btnCApp_Click(sender As Object, e As EventArgs) Handles btnCApp.Click
        deleteApp()
    End Sub
#End Region
End Class
