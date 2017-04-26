Imports MySql.Data.MySqlClient

Public Class Questions
    Private Sub Questions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
    Private answer As String
    Private comm As MySqlCommand
    Dim arrayListQuery As New ArrayList


    Private Function Sporring(ByVal sql As String) As DataTable
        Dim tabel As New DataTable
        Try
            Dim kommando As New MySqlCommand(sql, connection)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = kommando
            da.Fill(tabel)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show("En feil har oppstått: " & ex.Message)
        End Try
        Return tabel
    End Function



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'HENTE UT PERSONNUMMER OG TA BORT TABPAGE 6/7 ETTERSOM HVILKET KJØNN DET ER.
        Me.TabPage1.Text = "Runde 1"
        Me.TabPage2.Text = "Runde 2"
        Me.TabPage3.Text = "Runde 3"
        Me.TabPage4.Text = "Runde 4"
        Me.TabPage5.Text = "Runde 5"
        Me.TabPage6.Text = "Kvinner"
        Me.TabPage7.Text = "Menn"
        Me.TabPage8.Text = "Runde 8"

        connection.Open()
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
        qu45.Text = tabell.Rows(44)(0).ToString() & " " & tabell.Rows(44)(1).ToString()
        qu46.Text = tabell.Rows(45)(0).ToString() & " " & tabell.Rows(45)(1).ToString()
        qu47.Text = tabell.Rows(46)(0).ToString() & " " & tabell.Rows(46)(1).ToString()
        qu48.Text = tabell.Rows(47)(0).ToString() & " " & tabell.Rows(47)(1).ToString()
        qu49.Text = tabell.Rows(48)(0).ToString() & " " & tabell.Rows(48)(1).ToString()
        qu50.Text = tabell.Rows(49)(0).ToString() & " " & tabell.Rows(49)(1).ToString()
        qu51.Text = tabell.Rows(50)(0).ToString() & " " & tabell.Rows(50)(1).ToString()
        qu52.Text = tabell.Rows(51)(0).ToString() & " " & tabell.Rows(51)(1).ToString()
        qu53.Text = tabell.Rows(52)(0).ToString() & " " & tabell.Rows(52)(1).ToString()
        qu54.Text = tabell.Rows(53)(0).ToString() & " " & tabell.Rows(53)(1).ToString()
        qu55.Text = tabell.Rows(54)(0).ToString() & " " & tabell.Rows(54)(1).ToString()
        qu56.Text = tabell.Rows(55)(0).ToString() & " " & tabell.Rows(55)(1).ToString()
        qu57.Text = tabell.Rows(56)(0).ToString() & " " & tabell.Rows(56)(1).ToString()
        qu58.Text = tabell.Rows(57)(0).ToString() & " " & tabell.Rows(57)(1).ToString()
        qu59.Text = tabell.Rows(58)(0).ToString() & " " & tabell.Rows(58)(1).ToString()
#End Region

        connection.close()
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

    Private Sub quarantine()
        Dim todayDate As String = Today.ToString("yyyy/MM/dd")
        Dim quarantine = Today.ToString("yyyy/MM/dd") + 90 * todayDate
        Dim teller As Integer = 0
        If RadioButton2.Checked Or RadioButton4.Checked Or RadioButton6.Checked Or RadioButton8.Checked Then
            quarantine = True
            '  ElseIf RadioButton Then
        End If
        'Select Case quarantine
        '    Case RadioButton2.Checked, RadioButton4.Checked, RadioButton6.Checked, RadioButton8.Checked
        '        teller += 0
        '    Case 

        'End Select
        Dim query As String = "SELECT DataMyBlood.lastDrain, DataMyBlood.personnummer"

        '        Select Case tblLoanAccount.Date, tblLoanAccount.Payment, tblLoanAccount.Interest,
        '    tblLoanAccount.Total, tblLoanAccount.Auto, tblLoanAccount.Installment,
        '    If(Installment = 0, 'Interest', concat('Installment : ', Installment)) as Description
        'From tblLoanAccount
        'Join tblloanRegistry On tblloanRegistry.LoanID = tblLoanAccount.LoanID
        'Where tblloanRegistry.EMPNumber = 1111 
        '    And tblLoanAccount.LoanID = 1 
        '    And tblLoanAccount.Total <> 0 
        'ORDER BY tblLoanAccount.ID

        connection.Open()
        Dim reader As MySqlDataReader
        Dim query2 As String = "SELECT User.ss_number FROM User Join Answer On Answer.id_answer = User.ss_number"
        comm = New MySqlCommand(query2, connection)
        reader = comm.ExecuteReader
        MsgBox(query2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        'Henter alle tag'ene/svarene fra CheckAllAnswers fra tabControl. 
        CheckAllAnswers(QuestionRound)

        Dim todayDate As String = Today.ToString("yyyy/MM/dd") 'Setter datoen for spørreskjemaet til dagens dato.
        Dim reader As MySqlDataReader

        Try
            connection.Open()
            'Henter svarene fra ArraylistQuery og fyller databasen med disse svarene. 1=Ja, 0=Nei. Vi bruker tall for å bruke mindre plass i databasen.
            Dim query As String = "INSERT INTO Answer(date, qu1, qu2, qu3, qu4, qu5, qu6, qu7, qu8, qu9, qu10, qu11, qu12, qu13, qu14, qu15, qu16, qu17, qu18, qu19, qu20, qu21, qu22, qu23, qu24, qu25, qu26, qu27, qu28, qu29, qu30, qu31, qu32, qu33, qu34, qu35, qu36, qu37, qu38, qu39, qu40, qu41, qu42, qu43, qu44, qu45, qu46, qu47, qu48, qu49, qu50, qu51, qu52, qu53, qu54, qu55, qu56, qu57, qu58, qu59 ) VALUES ('" & todayDate & "','" & arrayListQuery(0) & "','" & arrayListQuery(1) & "','" & arrayListQuery(2) & "','" & arrayListQuery(3) & "','" & arrayListQuery(4) & "','" & arrayListQuery(5) & "','" & arrayListQuery(6) & "','" & arrayListQuery(7) & "','" & arrayListQuery(8) & "','" & arrayListQuery(9) & "','" & arrayListQuery(10) & "','" & arrayListQuery(11) & "','" & arrayListQuery(12) & "','" & arrayListQuery(13) & "','" & arrayListQuery(14) & "','" & arrayListQuery(15) & "','" & arrayListQuery(16) & "','" & arrayListQuery(17) & "','" & arrayListQuery(18) & "','" & arrayListQuery(19) & "','" & arrayListQuery(20) & "','" & arrayListQuery(21) & "','" & arrayListQuery(22) & "','" & arrayListQuery(23) & "','" & arrayListQuery(24) & "','" & arrayListQuery(25) & "','" & arrayListQuery(26) & "','" & arrayListQuery(27) & "','" & arrayListQuery(28) & "','" & arrayListQuery(29) & "','" & arrayListQuery(30) & "','" & arrayListQuery(31) & "','" & arrayListQuery(32) & "','" & arrayListQuery(33) & "','" & arrayListQuery(34) & "','" & arrayListQuery(35) & "','" & arrayListQuery(36) & "','" & arrayListQuery(37) & "','" & arrayListQuery(38) & "','" & arrayListQuery(39) & "','" & arrayListQuery(40) & "','" & arrayListQuery(41) & "','" & arrayListQuery(42) & "','" & arrayListQuery(43) & "','" & arrayListQuery(44) & "','" & arrayListQuery(45) & "','" & arrayListQuery(46) & "','" & arrayListQuery(47) & "','" & arrayListQuery(48) & "','" & arrayListQuery(49) & "','" & arrayListQuery(50) & "','" & arrayListQuery(51) & "','" & arrayListQuery(52) & "','" & arrayListQuery(53) & "','" & arrayListQuery(54) & "','" & arrayListQuery(55) & "','" & arrayListQuery(56) & "','" & arrayListQuery(57) & "','" & arrayListQuery(58) & "')"
            comm = New MySqlCommand(query, connection)
            reader = comm.ExecuteReader
            MsgBox("Svarene er lagret")
            connection.close()
        Catch ex As Exception
            MsgBox("Vennligst sjekk at du har besvart alle spørsmål.", MsgBoxStyle.Information) 'Err.Description)
        Finally
            connection.dispose()

        End Try
    End Sub

    ' query = "INSERT INTO Answers(date, qu" & i&") VALUES('arrTilSporring(i-1)')"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        QuestionRound.SelectTab(1)

    End Sub
    Private Sub btnNeste2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
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
End Class
