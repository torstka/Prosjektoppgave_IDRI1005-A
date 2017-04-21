Imports MySql.Data.MySqlClient
Public Class QuestForm
    Private connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
    Private answer As String
    Private comm As MySqlCommand
    Dim arrayListQuery As New ArrayList
    Dim totalQT As String
    Dim adapter As New MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim ssn As String = UserPage.lblSSnumber.Text
    Private Sub QuestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = SystemInformation.PrimaryMonitorSize
        QuestionRound.Location = New Point((ClientSize.Width - QuestionRound.Width) \ 2,
                             (ClientSize.Height - QuestionRound.Height) \ 2)

        Me.TabPage1.Text = "Side 1"
        Me.TabPage2.Text = "Side 2"
        Me.TabPage3.Text = "Side 3"
        Me.TabPage4.Text = "Side 4"
        Me.TabPage5.Text = "Side 5"
        Me.TabPage6.Text = "Side 6"
        Me.TabPage7.Text = "Side 7"
        Me.TabPage8.Text = "Side 8 - Kvinner"
        Me.TabPage9.Text = "Side 9 - Menn"
        Me.TabPage10.Text = "Side 10"

        checkIfApproved()
        checkGender() 'Henter ut hvilken kjønn-side som skal være aktiv/inaktiv.
        'connection.Open()
        Dim command As New MySqlCommand("SELECT * FROM QuestForm ", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim tabell As New DataTable()
        adapter.Fill(tabell)

#Region "Alle spm"
        qu1.Text = tabell.Rows(0)(0).ToString() & " " & tabell.Rows(0)(1).ToString()
        qu2.Text = tabell.Rows(1)(0).ToString() & " " & tabell.Rows(1)(1).ToString()
        qu3.Text = tabell.Rows(2)(0).ToString() & " " & tabell.Rows(2)(1).ToString()
        qu4.Text = tabell.Rows(3)(0).ToString() & " " & tabell.Rows(3)(1).ToString()
        qu5.Text = tabell.Rows(4)(0).ToString() & " " & tabell.Rows(4)(1).ToString()
        qu6.Text = tabell.Rows(5)(0).ToString() & " " & tabell.Rows(5)(1).ToString()
        qu7.Text = tabell.Rows(6)(0).ToString() & " " & tabell.Rows(6)(1).ToString()
        qu8.Text = tabell.Rows(7)(0).ToString() & " " & tabell.Rows(7)(1).ToString()
        qu9.Text = tabell.Rows(8)(0).ToString() & " " & tabell.Rows(8)(1).ToString()
        qu10.Text = tabell.Rows(9)(0).ToString() & " " & tabell.Rows(9)(1).ToString()
        qu11.Text = tabell.Rows(10)(0).ToString() & " " & tabell.Rows(10)(1).ToString()
        qu12.Text = tabell.Rows(11)(0).ToString() & " " & tabell.Rows(11)(1).ToString()
        qu13.Text = tabell.Rows(12)(0).ToString() & " " & tabell.Rows(12)(1).ToString()
        qu14.Text = tabell.Rows(13)(0).ToString() & " " & tabell.Rows(13)(1).ToString()
        qu15.Text = tabell.Rows(14)(0).ToString() & " " & tabell.Rows(14)(1).ToString()
        qu16.Text = tabell.Rows(15)(0).ToString() & " " & tabell.Rows(15)(1).ToString()
        qu17.Text = tabell.Rows(16)(0).ToString() & " " & tabell.Rows(16)(1).ToString()
        qu18.Text = tabell.Rows(17)(0).ToString() & " " & tabell.Rows(17)(1).ToString()
        qu19.Text = tabell.Rows(18)(0).ToString() & " " & tabell.Rows(18)(1).ToString()
        qu20.Text = tabell.Rows(19)(0).ToString() & " " & tabell.Rows(19)(1).ToString()
        qu21.Text = tabell.Rows(20)(0).ToString() & " " & tabell.Rows(20)(1).ToString()
        qu22.Text = tabell.Rows(21)(0).ToString() & " " & tabell.Rows(21)(1).ToString()
        qu23.Text = tabell.Rows(22)(0).ToString() & " " & tabell.Rows(22)(1).ToString()
        qu24.Text = tabell.Rows(23)(0).ToString() & " " & tabell.Rows(23)(1).ToString()
        qu25.Text = tabell.Rows(24)(0).ToString() & " " & tabell.Rows(24)(1).ToString()
        qu26.Text = tabell.Rows(25)(0).ToString() & " " & tabell.Rows(25)(1).ToString()
        qu27.Text = tabell.Rows(26)(0).ToString() & " " & tabell.Rows(26)(1).ToString()
        qu28.Text = tabell.Rows(27)(0).ToString() & " " & tabell.Rows(27)(1).ToString()
        qu29.Text = tabell.Rows(28)(0).ToString() & " " & tabell.Rows(28)(1).ToString()
        qu30.Text = tabell.Rows(29)(0).ToString() & " " & tabell.Rows(29)(1).ToString()
        qu31.Text = tabell.Rows(30)(0).ToString() & " " & tabell.Rows(30)(1).ToString()
        qu32.Text = tabell.Rows(31)(0).ToString() & " " & tabell.Rows(31)(1).ToString()
        qu33.Text = tabell.Rows(32)(0).ToString() & " " & tabell.Rows(32)(1).ToString()
        qu34.Text = tabell.Rows(33)(0).ToString() & " " & tabell.Rows(33)(1).ToString()
        qu35.Text = tabell.Rows(34)(0).ToString() & " " & tabell.Rows(34)(1).ToString()
        qu36.Text = tabell.Rows(35)(0).ToString() & " " & tabell.Rows(35)(1).ToString()
        qu37.Text = tabell.Rows(36)(0).ToString() & " " & tabell.Rows(36)(1).ToString()
        qu38.Text = tabell.Rows(37)(0).ToString() & " " & tabell.Rows(37)(1).ToString()
        qu39.Text = tabell.Rows(38)(0).ToString() & " " & tabell.Rows(38)(1).ToString()
        qu40.Text = tabell.Rows(39)(0).ToString() & " " & tabell.Rows(39)(1).ToString()
        qu41.Text = tabell.Rows(40)(0).ToString() & " " & tabell.Rows(40)(1).ToString()
        qu42.Text = tabell.Rows(41)(0).ToString() & " " & tabell.Rows(41)(1).ToString()
        qu43.Text = tabell.Rows(42)(0).ToString() & " " & tabell.Rows(42)(1).ToString()
        qu44.Text = tabell.Rows(43)(0).ToString() & " " & tabell.Rows(43)(1).ToString()
        'qu45.Text = tabell.Rows(44)(0).ToString() & " " & tabell.Rows(44)(1).ToString()
        'qu46.Text = tabell.Rows(45)(0).ToString() & " " & tabell.Rows(45)(1).ToString()
        'qu47.Text = tabell.Rows(46)(0).ToString() & " " & tabell.Rows(46)(1).ToString()
        'qu48.Text = tabell.Rows(47)(0).ToString() & " " & tabell.Rows(47)(1).ToString()
        'qu49.Text = tabell.Rows(48)(0).ToString() & " " & tabell.Rows(48)(1).ToString()
        'qu50.Text = tabell.Rows(49)(0).ToString() & " " & tabell.Rows(49)(1).ToString()
        'qu51.Text = tabell.Rows(50)(0).ToString() & " " & tabell.Rows(50)(1).ToString()
        'qu52.Text = tabell.Rows(51)(0).ToString() & " " & tabell.Rows(51)(1).ToString()
        'qu53.Text = tabell.Rows(52)(0).ToString() & " " & tabell.Rows(52)(1).ToString()
        'qu54.Text = tabell.Rows(53)(0).ToString() & " " & tabell.Rows(53)(1).ToString()
        'qu55.Text = tabell.Rows(54)(0).ToString() & " " & tabell.Rows(54)(1).ToString()
        'qu56.Text = tabell.Rows(55)(0).ToString() & " " & tabell.Rows(55)(1).ToString()
        'qu57.Text = tabell.Rows(56)(0).ToString() & " " & tabell.Rows(56)(1).ToString()
        'qu58.Text = tabell.Rows(57)(0).ToString() & " " & tabell.Rows(57)(1).ToString()
        'qu59.Text = tabell.Rows(58)(0).ToString() & " " & tabell.Rows(58)(1).ToString()
#End Region
        connection.close()
    End Sub


    Private Sub checkGender()
        Dim command As New MySqlCommand("SELECT * FROM QuestForm ", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim tabell As New DataTable()
        adapter.Fill(tabell)
        Try
            connection.Open()
            Dim table As New DataTable
            Dim female As String = "Female"
            Dim query As String = "SELECT gender FROM User WHERE ss_number = '" & ssn & "'AND gender = '" & female & "'"
            comm = New MySqlCommand(query, connection)
            reader = comm.ExecuteReader
#Region "Sjekker Mann/Kvinne"
            If reader.HasRows Then
                rbNei49.Checked = True
                rbNei49.Enabled = False
                rbJa49.Enabled = False
                lbM1.Visible = False
                lbM2.Visible = False
                lbM3.Visible = False
                lbM4.Visible = False
                lbM5.Visible = False
                lbM6.Visible = False
                lbM7.Visible = False
                lbM9.Visible = False
                lbM10.Visible = False
                lbFShow.Visible = False
                qu49.Enabled = False
                qu45.Text = tabell.Rows(44)(0).ToString() & " " & tabell.Rows(44)(1).ToString()
                qu46.Text = tabell.Rows(45)(0).ToString() & " " & tabell.Rows(45)(1).ToString()
                qu47.Text = tabell.Rows(46)(0).ToString() & " " & tabell.Rows(46)(1).ToString()
                qu48.Text = tabell.Rows(47)(0).ToString() & " " & tabell.Rows(47)(1).ToString()
                qu49.Text = "" & " " & tabell.Rows(48)(1).ToString()
                qu50.Text = "49" & " " & tabell.Rows(49)(1).ToString()
                qu51.Text = "50" & " " & tabell.Rows(50)(1).ToString()
                qu52.Text = "51" & " " & tabell.Rows(51)(1).ToString()
                qu53.Text = "52" & " " & tabell.Rows(52)(1).ToString()
                qu54.Text = "53" & " " & tabell.Rows(53)(1).ToString()
                qu55.Text = "54" & " " & tabell.Rows(54)(1).ToString()
                qu56.Text = "55" & " " & tabell.Rows(55)(1).ToString()
                qu57.Text = "56" & " " & tabell.Rows(56)(1).ToString()
                qu58.Text = "57" & " " & tabell.Rows(57)(1).ToString()
                qu59.Text = "58" & " " & tabell.Rows(58)(1).ToString()
            Else
                rbNei45.Checked = True
                rbNei46.Checked = True
                rbNei47.Checked = True
                rbNei48.Checked = True
                rbJa45.Enabled = False
                rbJa46.Enabled = False
                rbJa47.Enabled = False
                rbJa48.Enabled = False
                rbNei46.Enabled = False
                rbNei45.Enabled = False
                rbNei47.Enabled = False
                rbNei48.Enabled = False
                lbF1.Visible = False
                lbF2.Visible = False
                lbF3.Visible = False
                lbF4.Visible = False
                lbF5.Visible = False
                lbF6.Visible = False
                lbF7.Visible = False
                lbF8.Visible = False
                lbF10.Visible = False
                lbMShow.Visible = False
                qu45.Enabled = False
                qu46.Enabled = False
                qu47.Enabled = False
                qu48.Enabled = False
                qu45.Text = "" & " " & tabell.Rows(44)(1).ToString()
                qu46.Text = "" & " " & tabell.Rows(45)(1).ToString()
                qu47.Text = "" & " " & tabell.Rows(46)(1).ToString()
                qu48.Text = "" & " " & tabell.Rows(47)(1).ToString()
                qu49.Text = "45" & " " & tabell.Rows(48)(1).ToString()
                qu50.Text = "46" & " " & tabell.Rows(49)(1).ToString()
                qu51.Text = "47" & " " & tabell.Rows(50)(1).ToString()
                qu52.Text = "48" & " " & tabell.Rows(51)(1).ToString()
                qu53.Text = "49" & " " & tabell.Rows(52)(1).ToString()
                qu54.Text = "50" & " " & tabell.Rows(53)(1).ToString()
                qu55.Text = "51" & " " & tabell.Rows(54)(1).ToString()
                qu56.Text = "52" & " " & tabell.Rows(55)(1).ToString()
                qu57.Text = "53" & " " & tabell.Rows(56)(1).ToString()
                qu58.Text = "54" & " " & tabell.Rows(57)(1).ToString()
                qu59.Text = "55" & " " & tabell.Rows(58)(1).ToString()
            End If
#End Region

            reader.Close()
            connection.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub checkIfApproved()
        connection.close()
        Dim todaysDate90 As String = Today.AddDays(-90).ToString("dd/MM/yyyy")
        Dim threeMounthAgo = Today.AddDays(-90).ToString("dd/MM/yyyy")
        Dim today2 = Today.ToString("dd/MM/yyyy")

        Try
            connection.open()
            Dim query As String = "SELECT last_drain FROM Blood_Data WHERE ss_number='" & ssn & "'"
            Dim comm As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            reader = comm.ExecuteReader

            Dim lastDrain As String = ""
            While reader.Read()
                lastDrain &= reader("last_drain") & " "
            End While

            If lastDrain >= threeMounthAgo Then
                MsgBox("Det er kortere enn tre måneder siden sist tapping, og du må derfor vente.")
            ElseIf lastDrain = today2 Then
                MsgBox("Du har allerede svart på spørreskjema i dag. Vennligst vent til du blir kalt inn.")

            ElseIf UserPage.TextBox1.Text = "Livstid" Then
                MsgBox("Du har karantene på Livstid og kan ikke gi blod")
                Else
                UserPage.Hide()
                Me.Show()
            End If
            connection.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.dispose()
        End Try

    End Sub
    Private Sub CheckAllAnswers(ByVal tabControl As TabControl)

        Dim rbtn As RadioButton
        Dim rbtnTag As String = String.Empty
        'På dette punktet vil Subben begynne å lete etter alle de forskjellige TabPageX i TabControl
        For Each tabPage In QuestionRound.Controls
            'På dette punktet vil den lete etter alle de forskjellige panelene i TabPageX. I et panel har jeg lagt en label + 2 radiobuttons, disse har hver sin .Tag verdi.
            '.Tag er en verdi som vi som kodere kan angi til en radiobutton, og i vårt tilfelle er det gunstig at vi legger inn 0 og 1 på de respektive radiobuttonene. 
            For Each panel In tabPage.Controls 'Her tester den hvert panel i TabPageX.Controls, og finner de to radiobuttonene (If TypeOf ctl Is RadioButton). 
                Try
                    Dim ctl As Control
                    For Each ctl In panel.Controls
                        If TypeOf ctl Is RadioButton Then
                            rbtn = DirectCast(ctl, RadioButton)
                            If rbtn.Checked Then
                                rbtnTag = rbtn.Tag 'Midlertidig tag som nå inneholder verdien i radiobuttonX sin .Tag
                                arrayListQuery.Add(rbtnTag) 'Sender .Tag inn i ArrayList
                                Exit For
                            End If
                        End If
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        Next
    End Sub
    Private Sub quarantine() 'As Boolean
        'Setter de forskjellige mulige karantenene med riktig dato fra dagens dato. 
        Dim todayDate As System.DateTime
        'Setter de forskjellige typene karantener  
        Dim qt24t As String ' = Today.ToString("dd/MM/yyyy")
        Dim qt14d As String ' = Today.ToString("dd/MM/yyyy")
        Dim qt31d As String '  = Today.ToString("dd/MM/yyyy")
        Dim qt90d As String '= Today.ToString("dd/MM/yyyy")
        Dim qt120d As String '= Today.ToString("dd/MM/yyyy")
        Dim qt365d As String '= Today.ToString("dd/MM/yyyy")
        Dim lifeTimequarantine As String = "Livstid"
        Dim listQuarantine As New List(Of Object)()

        'Fyller karantenene fra dagens dato til karantene-datoen
        todayDate = Today.ToString("dd/MM/yyyy")
        qt24t = todayDate.AddDays(1)
        qt14d = todayDate.AddDays(14)
        qt31d = todayDate.AddDays(31)
        qt90d = todayDate.AddDays(90)
        qt120d = todayDate.AddDays(120)
        qt365d = todayDate.AddDays(365)
        'Sjekker hvert spmørsmål for hvilken karantene som tilhører hva
        If rbJa32.Checked Or rbJa42.Checked Or rbJa43.Checked Or rbJa44.Checked Or rbJa34.Checked Or rbJa35.Checked Or rbJa36.Checked Or rbJa49.Checked Or rbJa51.Checked Or rbJa52.Checked Or rbJa54.Checked Or rbJa55.Checked Then
            totalQT = lifeTimequarantine
        ElseIf rbJa15.Checked Or rbJa16.Checked Or rbJa17.Checked Or rbJa18.Checked Or rbJa19.Checked Or rbJa26.Checked Or rbJa27.Checked Or rbJa28.Checked Then
            totalQT = qt120d
        ElseIf rbJa6.Checked Or rbJa23.Checked Then
            totalQT = qt31d
        ElseIf rbJa5.Checked Or rbJa8.Checked Or rbJa9.Checked Or rbJa10.Checked Or rbJa20.Checked Then
            totalQT = qt14d
        ElseIf rbJa11.Checked Then
            totalQT = qt24t
        ElseIf rbNei2.Checked Or rbNei3.Checked Or rbNei4.Checked Or rbJa7.Checked Or rbJa12.Checked Or rbJa13.Checked Or rbJa14.Checked Or rbJa21.Checked Or rbJa22.Checked Or rbJa24.Checked Or rbJa25.Checked Or rbJa33.Checked Or rbJa37.Checked Or rbJa38.Checked Or rbJa39.Checked Or rbJa40.Checked Or rbJa41.Checked Or rbJa47.Checked Or rbJa48.Checked Or rbJa50.Checked Or rbJa53.Checked Or rbJa56.Checked Then
            totalQT = "Helsesjekk"
        Else
            totalQT = "Godkjent"
        End If
        updateQuarantine()
    End Sub
    Private Sub updateQuarantine()
        Try
            connection.open()
            Dim query As String = "UPDATE User SET quarantine='" & totalQT & "' WHERE ss_number='" & ssn & "'"
            Dim comm = New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader
            reader = comm.ExecuteReader
            MsgBox("Karantenen er oppdatert TAS BORT ")
            connection.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub updateLastDrain()

        Dim todaysDate = Today.Date
        Try
            connection.Open()
            Dim query As String = "UPDATE Blood_Data SET last_drain = '" & todaysDate & "' WHERE ss_number = '" & ssn & "'"
            comm = New MySqlCommand(query, connection)
            reader = comm.ExecuteReader
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub
    Private Sub SaveAnswers()
        CheckAllAnswers(QuestionRound)  'Henter alle tag'ene/svarene fra CheckAllAnswers fra tabControl. 
        quarantine()

        Dim todayDate As String = Today.ToString("yyyy/MM/dd") 'Setter datoen for spørreskjemaet til dagens dato.
        Dim approved As String = "Approved"
        Dim notApproved As String = "Not approved"

        Try
            connection.Open()
            If totalQT = "Godkjent" Then
                'Henter svarene fra ArraylistQuery og fyller databasen med disse svarene. 1=Ja, 0=Nei. Vi bruker tall for å bruke mindre plass i databasen.
                Dim query As String = "INSERT INTO Answer(date, status, ss_number, qu1, qu2, qu3, qu4, qu5, qu6, qu7, qu8, qu9, qu10, qu11, qu12, qu13, qu14, qu15, qu16, qu17, qu18, qu19, qu20, qu21, qu22, qu23, qu24, qu25, qu26, qu27, qu28, qu29, qu30, qu31, qu32, qu33, qu34, qu35, qu36, qu37, qu38, qu39, qu40, qu41, qu42, qu43, qu44, qu45, qu46, qu47, qu48, qu49, qu50, qu51, qu52, qu53, qu54, qu55, qu56, qu57, qu58, qu59) VALUES ('" & todayDate & "','" & approved & "','" & ssn & "','" & arrayListQuery(0) & "','" & arrayListQuery(1) & "','" & arrayListQuery(2) & "','" & arrayListQuery(3) & "','" & arrayListQuery(4) & "','" & arrayListQuery(5) & "','" & arrayListQuery(6) & "','" & arrayListQuery(7) & "','" & arrayListQuery(8) & "','" & arrayListQuery(9) & "','" & arrayListQuery(10) & "','" & arrayListQuery(11) & "','" & arrayListQuery(12) & "','" & arrayListQuery(13) & "','" & arrayListQuery(14) & "','" & arrayListQuery(15) & "','" & arrayListQuery(16) & "','" & arrayListQuery(17) & "','" & arrayListQuery(18) & "','" & arrayListQuery(19) & "','" & arrayListQuery(20) & "','" & arrayListQuery(21) & "','" & arrayListQuery(22) & "','" & arrayListQuery(23) & "','" & arrayListQuery(24) & "','" & arrayListQuery(25) & "','" & arrayListQuery(26) & "','" & arrayListQuery(27) & "','" & arrayListQuery(28) & "','" & arrayListQuery(29) & "','" & arrayListQuery(30) & "','" & arrayListQuery(31) & "','" & arrayListQuery(32) & "','" & arrayListQuery(33) & "','" & arrayListQuery(34) & "','" & arrayListQuery(35) & "','" & arrayListQuery(36) & "','" & arrayListQuery(37) & "','" & arrayListQuery(38) & "','" & arrayListQuery(39) & "','" & arrayListQuery(40) & "','" & arrayListQuery(41) & "','" & arrayListQuery(42) & "','" & arrayListQuery(43) & "','" & arrayListQuery(44) & "','" & arrayListQuery(45) & "','" & arrayListQuery(46) & "','" & arrayListQuery(47) & "','" & arrayListQuery(48) & "','" & arrayListQuery(49) & "','" & arrayListQuery(50) & "','" & arrayListQuery(51) & "','" & arrayListQuery(52) & "','" & arrayListQuery(53) & "','" & arrayListQuery(54) & "','" & arrayListQuery(55) & "','" & arrayListQuery(56) & "','" & arrayListQuery(57) & "','" & arrayListQuery(58) & "')"
                comm = New MySqlCommand(query, connection)
                reader = comm.ExecuteReader
                ' updateQuarantine()
                MsgBox("Svarene dine vil nå bli behandlet, og du kan gå til helsesjekken.")
            Else
                'Henter svarene fra ArraylistQuery og fyller databasen med disse svarene. 1=Ja, 0=Nei. Vi bruker tall for å bruke mindre plass i databasen.
                Dim query As String = "INSERT INTO Answer(date, status, ss_number, qu1, qu2, qu3, qu4, qu5, qu6, qu7, qu8, qu9, qu10, qu11, qu12, qu13, qu14, qu15, qu16, qu17, qu18, qu19, qu20, qu21, qu22, qu23, qu24, qu25, qu26, qu27, qu28, qu29, qu30, qu31, qu32, qu33, qu34, qu35, qu36, qu37, qu38, qu39, qu40, qu41, qu42, qu43, qu44, qu45, qu46, qu47, qu48, qu49, qu50, qu51, qu52, qu53, qu54, qu55, qu56, qu57, qu58, qu59) VALUES ('" & todayDate & "','" & notApproved & "','" & ssn & "','" & arrayListQuery(0) & "','" & arrayListQuery(1) & "','" & arrayListQuery(2) & "','" & arrayListQuery(3) & "','" & arrayListQuery(4) & "','" & arrayListQuery(5) & "','" & arrayListQuery(6) & "','" & arrayListQuery(7) & "','" & arrayListQuery(8) & "','" & arrayListQuery(9) & "','" & arrayListQuery(10) & "','" & arrayListQuery(11) & "','" & arrayListQuery(12) & "','" & arrayListQuery(13) & "','" & arrayListQuery(14) & "','" & arrayListQuery(15) & "','" & arrayListQuery(16) & "','" & arrayListQuery(17) & "','" & arrayListQuery(18) & "','" & arrayListQuery(19) & "','" & arrayListQuery(20) & "','" & arrayListQuery(21) & "','" & arrayListQuery(22) & "','" & arrayListQuery(23) & "','" & arrayListQuery(24) & "','" & arrayListQuery(25) & "','" & arrayListQuery(26) & "','" & arrayListQuery(27) & "','" & arrayListQuery(28) & "','" & arrayListQuery(29) & "','" & arrayListQuery(30) & "','" & arrayListQuery(31) & "','" & arrayListQuery(32) & "','" & arrayListQuery(33) & "','" & arrayListQuery(34) & "','" & arrayListQuery(35) & "','" & arrayListQuery(36) & "','" & arrayListQuery(37) & "','" & arrayListQuery(38) & "','" & arrayListQuery(39) & "','" & arrayListQuery(40) & "','" & arrayListQuery(41) & "','" & arrayListQuery(42) & "','" & arrayListQuery(43) & "','" & arrayListQuery(44) & "','" & arrayListQuery(45) & "','" & arrayListQuery(46) & "','" & arrayListQuery(47) & "','" & arrayListQuery(48) & "','" & arrayListQuery(49) & "','" & arrayListQuery(50) & "','" & arrayListQuery(51) & "','" & arrayListQuery(52) & "','" & arrayListQuery(53) & "','" & arrayListQuery(54) & "','" & arrayListQuery(55) & "','" & arrayListQuery(56) & "','" & arrayListQuery(57) & "','" & arrayListQuery(58) & "')"
                comm = New MySqlCommand(query, connection)
                reader = comm.ExecuteReader
                'updateQuarantine()
                MsgBox("Svarene er lagret")
            End If
            UserPage.Show()

            Me.Close()
            reader.Close()
            connection.close()

        Catch ex As Exception
            MsgBox("Vennligst sjekk at du har besvart alle spørsmål.", MsgBoxStyle.Information, "Advarsel")
        Finally
            connection.dispose()
        End Try
    End Sub
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Dim user As New User
        user.getUser()
        SaveAnswers()
        'UserPage.Show()
        updateLastDrain()


    End Sub
#Region "Alle neste- og forrige-knapper"

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        quarantine()
    End Sub
    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        QuestionRound.SelectTab(1)
    End Sub
    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        QuestionRound.SelectTab(2)
    End Sub
    Private Sub btnNext3_Click(sender As Object, e As EventArgs) Handles btnNext3.Click
        QuestionRound.SelectTab(3)
    End Sub
    Private Sub btnNext4_Click(sender As Object, e As EventArgs) Handles btnNext4.Click
        QuestionRound.SelectTab(4)
    End Sub
    Private Sub btnNext5_Click(sender As Object, e As EventArgs) Handles btnNext5.Click
        QuestionRound.SelectTab(5)
    End Sub

    Private Sub btnNext6_Click(sender As Object, e As EventArgs) Handles btnNext6.Click
        QuestionRound.SelectTab(6)
    End Sub
    Private Sub btnNext7_Click(sender As Object, e As EventArgs) Handles btnNext7.Click
        QuestionRound.SelectTab(7)
    End Sub

    Private Sub btnNext8_Click(sender As Object, e As EventArgs) Handles btnNext8.Click
        QuestionRound.SelectTab(8)
    End Sub

    Private Sub btnNext9_Click(sender As Object, e As EventArgs) Handles btnNext9.Click
        QuestionRound.SelectTab(9)
    End Sub

    '--------------------------------------
    Private Sub btnPrev2_Click(sender As Object, e As EventArgs) Handles btnPrev2.Click
        QuestionRound.SelectTab(0)
    End Sub
    Private Sub btnPrev3_Click(sender As Object, e As EventArgs) Handles btnPrev3.Click
        QuestionRound.SelectTab(1)
    End Sub

    Private Sub btnPrev4_Click(sender As Object, e As EventArgs) Handles btnPrev4.Click
        QuestionRound.SelectTab(2)
    End Sub

    Private Sub btnPrev5_Click(sender As Object, e As EventArgs) Handles btnPrev5.Click
        QuestionRound.SelectTab(3)
    End Sub
    Private Sub btnPrev6_Click(sender As Object, e As EventArgs) Handles btnPrev6.Click
        QuestionRound.SelectTab(4)
    End Sub

    Private Sub btnPrev7_Click(sender As Object, e As EventArgs) Handles btnPrev7.Click
        QuestionRound.SelectTab(5)
    End Sub
    Private Sub btnPrev8_Click(sender As Object, e As EventArgs) Handles btnPrev8.Click
        QuestionRound.SelectTab(6)
    End Sub

    Private Sub btnPrev9_Click(sender As Object, e As EventArgs) Handles btnPrev9.Click
        QuestionRound.SelectTab(7)
    End Sub

    Private Sub btnPrev10_Click(sender As Object, e As EventArgs) Handles btnPrev10.Click
        QuestionRound.SelectTab(8)
    End Sub

#End Region



End Class