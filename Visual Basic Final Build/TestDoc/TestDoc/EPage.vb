Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class EPage
    Dim constring As String = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
    Dim connection As New MySqlConnection(constring)
    Dim cmd As MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim reader As MySqlDataReader
    Dim rad As DataRow
    Dim bSource As New BindingSource
    Dim command As MySqlCommand

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

    Private Sub EPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setter indeksen på comboboksene til 0
        cbPlateletsCount.SelectedIndex = 0
        cbCellsCount.SelectedIndex = 0
        cbPlasmaCount.SelectedIndex = 0

        'Setter størrelsen på tabcontrollen
        Userinformation.Size = New Size(1550, 750)

        Me.Size = SystemInformation.PrimaryMonitorSize

        'Sentrerer tavcontrollen
        Userinformation.Location = New Point((ClientSize.Width - Userinformation.Width) \ 2,
                             (ClientSize.Height - Userinformation.Height) \ 2)

        'Setter posisjonen til "logg ut"-knappen 
        btnSignOut.Location = New Point((Me.Width - btnSignOut.Width) \ 2 + 675,
                             (Me.Height - btnSignOut.Height) \ 2 - 350)
        ' Setter posisjonen til kalenderen
        gbCalendar.Location = New Point((TabPage3.Width - gbCalendar.Width) \ 2,
                             (TabPage3.Height - gbCalendar.Height) \ 2)


        'Kjører prosedyrer
        updateStock()
        showStock()
        load_dgwUser()

    End Sub

    'Loader datagridviewen
    Private Sub load_dgwUser()
        'Angir fonttype og fontstørrelse på teksten i tabellen
        dgwUsers.DefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Regular, GraphicsUnit.Point)
        dgwUsers.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 17.5, FontStyle.Bold, GraphicsUnit.Point)

        'Kjører en sql spørring som henter ut data til tabellen
        Try
            connection.Open()
            'Denne spørringen henter data fra både tabellen User og Blood_Data
            Dim query As String = "SELECT TableUser.ss_number as 'Personnummer',TableUser.lastname as 'Etternavn',TableUser.firstname as 'Fornavn', TableUser.quarantine as 'Karantene', TableBlood.Blood_type as 'Blodtype' FROM User TableUser INNER JOIN Blood_Data TableBlood on TableUser.ss_number=TableBlood.ss_number"
            cmd = New MySqlCommand(query, connection)
            adapter.SelectCommand = cmd
            adapter.Fill(dtable)
            bSource.DataSource = dtable
            dgwUsers.DataSource = bSource
            adapter.Update(dtable)

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    'Når man trykker på en person i tabellen, vil informasjonen til denne personen vises i textboxer
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwUsers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgwUsers.Rows(e.RowIndex)

            txtFirstname.Text = row.Cells("Fornavn").Value.ToString
            txtLastname.Text = row.Cells("Etternavn").Value.ToString
            txtSSN.Text = row.Cells("Personnummer").Value.ToString
        End If

        getUserInfo()
        getBloodData()
    End Sub


    'Henter ut bloddata basert på hvilken person som er valgt i tabellen
    Private Sub getBloodData()
        Try
            connection.Open()
            'Henter ut data basert på personnummeret i textSSN.text
            Dim query As String = "select blood_type, hb, iron_value, last_drain FROM Blood_Data where ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            Dim hb As String = ""
            Dim ironValue As String = ""
            Dim bloodType As String = ""
            Dim lastDrain As String = ""

            While reader.Read()
                hb &= reader("hb")
                ironValue = reader("iron_value")
                bloodType = reader("blood_type")
                lastDrain = reader("last_drain")
            End While

            'sjekker om lastDrain har en spesiell verdi
            If lastDrain = "01.01.1900" Then
                txtHB.Text = hb
                txtIron.Text = ironValue
                cbBloodType.Text = bloodType
                txtLastDrain.Text = "Ikke tappet"
            Else
                'Fyller textboxene med dataen som er hentet ut
                txtHB.Text = hb
                txtIron.Text = ironValue
                cbBloodType.Text = bloodType
                txtLastDrain.Text = lastDrain
            End If

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    'Henter ut data om personen som er valgt i tabellen
    Private Sub getUserInfo()
        Try
            connection.Open()
            Dim query As String = "select phone, e_mail, quarantine FROM User where ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            Dim email As String = ""
            Dim quarantine As String = ""
            Dim phone As String = ""

            While reader.Read()
                email &= reader("e_mail")
                quarantine &= reader("quarantine")
                phone &= reader("phone")
            End While
            'Legger dataen inn i textboksene
            txtMail.Text = email
            txtQuarantine.Text = quarantine
            txtPhone.Text = phone
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub


    'Kjører søkeprosedyre når man skriver i txtSearch.text
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim DV As New DataView(dtable)
        'Filtrerer blodtypene som begynner på bokstaven man trykker inn
        DV.RowFilter = String.Format("Blodtype Like '%{0}%'", txtSearch.Text)
        dgwUsers.DataSource = DV
    End Sub

    'Oppdaterer blodtataen til personen som er valgt
    Private Sub updateBloodData()

        Try
            connection.Open()
            'Endrer dataen til personen med personnummeret som står i txtSSN.text
            Dim query As String = "UPDATE Blood_Data SET blood_type = '" & cbBloodType.Text & "', hb = '" & txtHB.Text & "', iron_value = '" & txtIron.Text & "' WHERE ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            MsgBox("Bloddata oppdatert", MsgBoxStyle.Information, "Oppdatert")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub




    'Tømmer textboksene
    Private Sub clear()
        txtGetBloodType.Clear()
        txtGetBloodInfo.Clear()
        txtGetBloodCount.Clear()
        txtDepartment.Clear()
    End Sub

    'Knappen registrerer donasjonen og oppdaterer listboksen som viser lagerstatusen
    Private Sub btnRegDonation_Click(sender As Object, e As EventArgs) Handles btnRegDonation.Click
        regDonation()

        lbShowStock.Items.Clear()
        showStock()
    End Sub

    'Registrerer donasjonen
    Public Sub regDonation()

        'Definerer variabler som skal brukes
        Dim status As String = "Valid"
        Dim expiryDate As String
        Dim donationDate As Date = Today.ToString("dd/MM/yyyy")
        Dim count As Integer = Integer.Parse(cbPlateletsCount.Text)
        Dim count2 As Integer = Integer.Parse(cbCellsCount.Text)
        Dim count3 As Integer = Integer.Parse(cbPlasmaCount.Text)
        Dim sum = cbPlateletsCount.Text + +cbPlasmaCount.Text + +cbCellsCount.Text

        'Sjekker om summen av alle feltene tilsammen tilsvarer 5 (poser)
        If sum <> 5 Then
            MsgBox("Donasjonen må tilsammen tilsvare 5 poser!", MsgBoxStyle.Critical, "Feil")
            'Sjekker om en bruker er valgt
        ElseIf txtSSN.Text = "" Then
            MsgBox("Vær vennlig å velg donor", MsgBoxStyle.Critical, "Feil")
            'Sjekker om brukeren har fått en blodtype
        ElseIf txtGetBloodType.Text = "Ingen verdi" Then
            MsgBox("Personen har ingen gyldig blodtype", MsgBoxStyle.Critical, "Feil")
            'Sjekker om alle feltene har verdier over 0
        ElseIf count = 0 Or count2 = 0 Or count3 = 0 Then
            MsgBox("Du må fylle inn alle vediene!", MsgBoxStyle.Critical, "Feil")
            'Sjekker om brukeren har karantenen "Godkjent"
        ElseIf Not txtQuarantine.Text = "Godkjent" Then
            MsgBox("Denne brukeren er i karantene eller har ikke fullført spørreskjema!", MsgBoxStyle.Critical, "Feil")
        Else
            'Dersom alle disse betingelsene er oppfylt kjørers sql-spørringene
            Try
                connection.Open()
                'Spørringen kjørers like mange ganger som antallet poser
                For i = 1 To count
                    'Utløpsdatoen settes til 7 dager fram i tid fordi denne spørringen legger inn blodplater
                    expiryDate = Today.AddDays(7).Date
                    Dim query As String = "Insert INTO Donation_Stock (donation_date, blood_info, blood_type, ss_number, expiry_date, status) values('" & donationDate & "','Blodplater', '" & cbBloodType.Text & "','" & txtSSN.Text & "','" & expiryDate & "', '" & status & "')"
                    cmd = New MySqlCommand(query, connection)
                    reader = cmd.ExecuteReader
                    reader.Close()
                Next

                'Spørringen kjørers like mange ganger som antallet poser
                For i = 1 To count2
                    'Utløpsdatoen settes til 35 dager fram i tid fordi denne spørringen legger inn blodlegemer
                    expiryDate = Today.AddDays(35).Date
                    Dim query As String = "Insert INTO Donation_Stock (donation_date, blood_info, blood_type, ss_number, expiry_date, status) values('" & donationDate & "','Blodlegemer', '" & cbBloodType.Text & "','" & txtSSN.Text & "','" & expiryDate & "', '" & status & "')"
                    cmd = New MySqlCommand(query, connection)
                    reader = cmd.ExecuteReader
                    reader.Close()
                Next

                'Spørringen kjørers like mange ganger som antallet poser
                For i = 1 To count3
                    'Utløpsdatoen settes til "frozen" fordi denne spørringen legger inn blodplasma som fryses ned
                    expiryDate = "Frozen"
                    Dim query As String = "Insert INTO Donation_Stock (donation_date, blood_info, blood_type, ss_number, expiry_date, status) values('" & donationDate & "','Blodplasma', '" & cbBloodType.Text & "','" & txtSSN.Text & "','" & expiryDate & "', '" & status & "')"
                    cmd = New MySqlCommand(query, connection)
                    reader = cmd.ExecuteReader
                    reader.Close()
                Next

                MsgBox("Data lagret", MsgBoxStyle.Information, "Lagret")
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub

    'Knappen lukker vinduet og åpner login siden
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Close()
        LogIn.Show()
    End Sub


    'Knappen henter ut blod fra lageret
    Private Sub btnGetBlood_Click(sender As Object, e As EventArgs) Handles btnGetBlood.Click
        'Sjekker om det finnes bestillinger
        If txtGetBloodType.Text = "" Or txtGetBloodInfo.Text = "" Or txtGetBloodCount.Text = "" Then
            MsgBox("Ingen bestillinger funnet.", MsgBoxStyle.Critical, "Feil")
        Else
            getBlood()
            'Oppdaterer lagerstatusen
            lbShowStock.Items.Clear()
            showStock()
            btnGetOrder.Enabled = True
        End If
    End Sub

    'Opdaterer lageret og setter statusen til "Expired" hvis utløpsdatoen er mindre enn dagens dato
    Public Sub updateStock()
        Dim todaysDate = Today.Date
        Try
            connection.Open()
            Dim query As String = "UPDATE Donation_Stock SET status = 'Expired' where expiry_date < '" & todaysDate & "' "
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub


    'Henter ut blod fra lageret
    Private Sub getBlood()

        Dim int As Integer
        int = Integer.Parse(txtGetBloodCount.Text)
        Dim status = "Valid"

        'Henter data som tilsvarer textboksene
        Try
            Dim query As String = "select * FROM Donation_Stock where blood_info = '" & txtGetBloodInfo.Text & "' AND blood_type = '" & txtGetBloodType.Text & "' AND status = '" & status & "'"
            Dim dt As New DataTable

            'fyller en datatabell
            Using cnn As New MySqlConnection(constring)
                cnn.Open()
                Using ad As New MySqlDataAdapter(query, cnn)
                    ad.Fill(dt)
                End Using
                cnn.Close()
            End Using

            'Sjekker om datatabellen har like like mange eller mer rader enn de antallet vi prøver å hente ut
            connection.Open()
            'Dersom dette er tilfellet kjører vi følgende spørring:
            If dt IsNot Nothing AndAlso dt.Rows.Count >= int Then
                'Løkken går antall poser ganger
                For i = 1 To int
                    Dim query2 As String = "DELETE FROM Donation_Stock where blood_info = '" & txtGetBloodInfo.Text & "' AND blood_type = '" & txtGetBloodType.Text & "' AND status = '" & status & "' LIMIT 1"
                    cmd = New MySqlCommand(query2, connection)
                    reader = cmd.ExecuteReader
                    reader.Close()
                Next
                MsgBox("Hentet fra lager:" & vbCrLf & vbCrLf & "Blodinfo: " & txtGetBloodInfo.Text & vbCrLf & "Blodtype: " & txtGetBloodType.Text & vbCrLf & "Mengde: " & int & " pose(er)", MsgBoxStyle.Information, "Lager")

                clear()

            Else
                'Dersom det ikke er nok rader i tabell, vil en feilmelding komme opp
                MsgBox("Ikke nok på lager", MsgBoxStyle.Information, "Oops!")

            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    'Viser lagerstatusen i en listboks
    Private Sub showStock()


        'Definerer variabler
#Region "Counts Variabler"
        Dim count As Int16
        Dim count2 As Int16
        Dim count3 As Int16
        Dim count4 As Int16
        Dim count5 As Int16
        Dim count6 As Int16
        Dim count7 As Int16
        Dim count8 As Int16
        Dim count9 As Int16
        Dim count10 As Int16
        Dim count11 As Int16
        Dim count12 As Int16
        Dim count13 As Int16
        Dim count14 As Int16
        Dim count15 As Int16
        Dim count16 As Int16
        Dim count17 As Int16
        Dim count18 As Int16
        Dim count19 As Int16
        Dim count20 As Int16
        Dim count21 As Int16
        Dim count22 As Int16
        Dim count23 As Int16
        Dim count24 As Int16

#End Region

        'Teller og henter ut mengden av de ulike blodtypene og blodinfoen
#Region "Queries"
        Try
            connection.Open()
            Dim query As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplater' AND Blood_Type = 'A Rh+' AND Status = 'Valid'"
            cmd = New MySqlCommand(query, connection)
            count = cmd.ExecuteScalar

            Dim query2 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodlegemer' AND Blood_Type = 'A Rh+' AND Status = 'Valid'"
            Dim cmd2 = New MySqlCommand(query2, connection)
            count2 = cmd2.ExecuteScalar

            Dim query3 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplasma' AND Blood_Type = 'A Rh+' AND Status = 'Valid'"
            Dim cmd3 = New MySqlCommand(query3, connection)
            count3 = cmd3.ExecuteScalar

            '--------------------

            Dim query4 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplater' AND Blood_Type = 'A Rh-' AND Status = 'Valid'"
            Dim cmd4 = New MySqlCommand(query4, connection)
            count4 = cmd4.ExecuteScalar

            Dim query5 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodlegemer' AND Blood_Type = 'A Rh-' AND Status = 'Valid'"
            Dim cmd5 = New MySqlCommand(query5, connection)
            count5 = cmd5.ExecuteScalar

            Dim query6 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplasma' AND Blood_Type = 'A Rh-' AND Status = 'Valid'"
            Dim cmd6 = New MySqlCommand(query6, connection)
            count6 = cmd6.ExecuteScalar

            '----------------------------

            Dim query7 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplater' AND Blood_Type = 'B Rh+' AND Status = 'Valid'"
            Dim cmd7 = New MySqlCommand(query7, connection)
            count7 = cmd7.ExecuteScalar

            Dim query8 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodlegemer' AND Blood_Type = 'B Rh+' AND Status = 'Valid'"
            Dim cmd8 = New MySqlCommand(query8, connection)
            count8 = cmd8.ExecuteScalar

            Dim query9 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplasma' AND Blood_Type = 'B Rh+' AND Status = 'Valid'"
            Dim cmd9 = New MySqlCommand(query9, connection)
            count9 = cmd9.ExecuteScalar

            '---------------------------

            Dim query10 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplater' AND Blood_Type = 'B Rh-' AND Status = 'Valid'"
            Dim cmd10 = New MySqlCommand(query10, connection)
            count10 = cmd10.ExecuteScalar

            Dim query11 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodlegemer' AND Blood_Type = 'B Rh-' AND Status = 'Valid'"
            Dim cmd11 = New MySqlCommand(query11, connection)
            count11 = cmd11.ExecuteScalar

            Dim query12 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplasma' AND Blood_Type = 'B Rh-' AND Status = 'Valid'"
            Dim cmd12 = New MySqlCommand(query12, connection)
            count12 = cmd12.ExecuteScalar

            '----------------------------------

            Dim query13 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplater' AND Blood_Type = 'AB Rh+' AND Status = 'Valid'"
            Dim cmd13 = New MySqlCommand(query13, connection)
            count13 = cmd13.ExecuteScalar

            Dim query14 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodlegemer' AND Blood_Type = 'AB Rh+' AND Status = 'Valid'"
            Dim cmd14 = New MySqlCommand(query14, connection)
            count14 = cmd14.ExecuteScalar

            Dim query15 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplasma' AND Blood_Type = 'AB Rh+' AND Status = 'Valid'"
            Dim cmd15 = New MySqlCommand(query15, connection)
            count15 = cmd15.ExecuteScalar

            '---------------------------

            Dim query16 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplater' AND Blood_Type = 'AB Rh-' AND Status = 'Valid'"
            Dim cmd16 = New MySqlCommand(query16, connection)
            count16 = cmd16.ExecuteScalar

            Dim query17 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodlegemer' AND Blood_Type = 'AB Rh-' AND Status = 'Valid'"
            Dim cmd17 = New MySqlCommand(query17, connection)
            count17 = cmd17.ExecuteScalar

            Dim query18 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplasma' AND Blood_Type = 'AB Rh-' AND Status = 'Valid'"
            Dim cmd18 = New MySqlCommand(query18, connection)
            count18 = cmd18.ExecuteScalar

            '--------------------------

            Dim query19 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplater' AND Blood_Type = 'O Rh+' AND Status = 'Valid'"
            Dim cmd19 = New MySqlCommand(query19, connection)
            count19 = cmd19.ExecuteScalar

            Dim query20 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodlegemer' AND Blood_Type = 'O Rh+' AND Status = 'Valid'"
            Dim cmd20 = New MySqlCommand(query20, connection)
            count20 = cmd20.ExecuteScalar

            Dim query21 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplasma' AND Blood_Type = 'O Rh+' AND Status = 'Valid'"
            Dim cmd21 = New MySqlCommand(query21, connection)
            count21 = cmd21.ExecuteScalar

            '-------------------------------

            Dim query22 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplater' AND Blood_Type = 'O Rh-' AND Status = 'Valid'"
            Dim cmd22 = New MySqlCommand(query22, connection)
            count22 = cmd22.ExecuteScalar

            Dim query23 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodlegemer' AND Blood_Type = 'O Rh-' AND Status = 'Valid'"
            Dim cmd23 = New MySqlCommand(query23, connection)
            count23 = cmd23.ExecuteScalar

            Dim query24 As String = "select COUNT(blood_info) FROM Donation_Stock where Blood_Info = 'Blodplasma' AND Blood_Type = 'O Rh-' AND Status = 'Valid'"
            Dim cmd24 = New MySqlCommand(query24, connection)
            count24 = cmd24.ExecuteScalar




#End Region

            'Fylles listboksen med verdiene som er hentet ut
#Region "ListBox"
            With lbShowStock.Items
                .Add("A Rh+")
                .Add("Blodplater:" & vbTab & count & " poser(100ml)")
                .Add("Blodlegemer:" & vbTab & count2 & " poser(100ml)")
                .Add("Blodplasma:" & vbTab & count3 & " poser(100ml)")
                .Add("")
                .Add("A Rh-")
                .Add("Blodplater:" & vbTab & count4 & " poser(100ml)")
                .Add("Blodlegemer:" & vbTab & count5 & " poser(100ml)")
                .Add("Blodplasma:" & vbTab & count6 & " poser(100ml)")
                .Add("")
                .Add("B Rh+")
                .Add("Blodplater" & vbTab & count7 & " poser(100ml)")
                .Add("Blodlegemer" & vbTab & count8 & " poser(100ml)")
                .Add("Blodplasma" & vbTab & count9 & " poser(100ml)")
                .Add("")
                .Add("B Rh-")
                .Add("Blodplater" & vbTab & count10 & " poser(100ml)")
                .Add("Blodlegemer" & vbTab & count11 & " poser(100ml)")
                .Add("Blodplasma" & vbTab & count12 & " poser(100ml)")
                .Add("")
                .Add("AB Rh+")
                .Add("Blodplater" & vbTab & count13 & " poser(100ml)")
                .Add("Blodlegemer" & vbTab & count14 & " poser(100ml)")
                .Add("Blodplasma" & vbTab & count15 & " poser(100ml)")
                .Add("")
                .Add("AB Rh-")
                .Add("Blodplater" & vbTab & count16 & " poser(100ml)")
                .Add("Blodlegemer" & vbTab & count17 & " poser(100ml)")
                .Add("Blodplasma" & vbTab & count18 & " poser(100ml)")
                .Add("")
                .Add("O Rh+")
                .Add("Blodplater" & vbTab & count19 & " poser(100ml)")
                .Add("Blodlegemer" & vbTab & count20 & " poser(100ml)")
                .Add("Blodplasma" & vbTab & count21 & " poser(100ml)")
                .Add("")
                .Add("O Rh-")
                .Add("Blodplater" & vbTab & count22 & " poser(100ml)")
                .Add("Blodlegemer" & vbTab & count23 & " poser(100ml)")
                .Add("Blodplasma" & vbTab & count24 & " poser(100ml)")
            End With
#End Region
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub

    'Sletter brukeren som er valgt i tabellen
    Private Sub deleteUser()

        'sletter brukeren fra tabellen "Blood_Data"
        Try
            connection.Open()
            Dim query As String = "DELETE FROM Blood_Data where ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        'Sletter brukeren fra tabellen User
        Try
            connection.Open()
            Dim query As String = "DELETE FROM User where ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            MsgBox("Slettet bruker:" & vbCrLf & "Fornavn: " & txtFirstname.Text & vbCrLf & "Etternavn: " & txtLastname.Text & vbCrLf & "Personnummer: " & txtSSN.Text, MsgBoxStyle.Information, "Bruker slettet")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub

    'Knappen får opp innkallingsvinduet
    Private Sub btnSummons_Click(sender As Object, e As EventArgs) Handles btnSummons.Click
        'Hvis karantenen til personen er "Livstid", så kan ikke brukeren kalles inn
        If txtSSN.Text = "" Then
            MsgBox("Du har ikke valg en bruker.", MsgBoxStyle.Critical, "Feil")
        ElseIf txtQuarantine.Text = "Livstid" Then
            MsgBox("Denne brukeren har karantene.", MsgBoxStyle.Critical, "Feil")
            'Dersom man ikke har valgt en person, kan man heller ikke kalle inn
        ElseIf txtQuarantine.Text = "" Then
            MailForm.Show()
        ElseIf txtQuarantine.Text = "Godkjent" Then
            MailForm.Show()
        Else
            MsgBox("Brukeren du har vagt har en karantene, og kan ikke sendes innkalling til.", MsgBoxStyle.Critical, "Oops!")
        End If
    End Sub

    'Knappen oppdaterer bloddataen til brukeren som er valgt i tabellen
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Hvis man ikke har valgt en bruker, kan man ikke oppdatere
        If txtSSN.Text = "" Then
            MsgBox("Velg bruker som skal oppdateres", MsgBoxStyle.Critical, "Feil")
        ElseIf Not validhemoglobin Then
            MsgBox(Me.ErrorProvider1.GetError(txtHB), MsgBoxStyle.Critical, "Oops!")
        ElseIf Not ValidIronValue Then
            MsgBox(Me.ErrorProvider1.GetError(txtIron), MsgBoxStyle.Critical, "Oops!")
        Else
            'Kjører rosesyrene
            updateBloodData()
            UpdateQuarantine()
            dtable.Clear()
            load_dgwUser()
        End If
    End Sub
    Private Sub UpdateQuarantine()

        Try
            connection.Open()
            'Endrer dataen til personen med personnummeret som står i txtSSN.text
            Dim query As String = "UPDATE User SET quarantine = '" & txtQuarantine.Text & "' WHERE ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader


            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try


    End Sub
    'Sletter brukeren som er valgt i tabellen
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click

        If txtSSN.Text = "" Then
            MsgBox("Ingen bruker valgt", MsgBoxStyle.Critical, "Slett bruker")
        Else
            'MsgBox("Vil du virkelig slette denne brukeren?", MsgBoxStyle.OkCancel, "Slett bruker")
            deleteUser()
            dtable.Clear()
            load_dgwUser()
            ClearUserInfo()
            clearBloodData()

        End If
    End Sub
    'Klarere brukerinfo tekstbokser
    Private Sub ClearUserInfo()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtSSN.Clear()
        txtPhone.Clear()
        txtMail.Clear()
    End Sub

    'klarerer blodinfo tekstbokser
    Private Sub clearBloodData()
        cbBloodType.SelectedIndex = 0
        txtLastDrain.Clear()
        txtHB.Clear()
        txtLastDrain.Clear()
        txtIron.Clear()
        txtQuarantine.Clear()

    End Sub

    'Finner bestillinger som finnes i tabellen "Orders"
    Private Sub checkOrders()
        Try
            connection.Open()
            'Velger en random bestilling
            Dim query As String = "select * FROM Orders  ORDER BY rand() LIMIT 1"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            Dim bloodType As String = ""
            Dim bloodInfo As String = ""
            Dim amount As String = ""
            Dim department As String = ""

            While reader.Read()
                bloodType &= reader("bloodType")
                bloodInfo &= reader("bloodInfo")
                amount &= reader("amount") & " "
                department &= reader("depName")
            End While

            'Fyller tekstboksene med bestillingsinformasjonen
            txtGetBloodType.Text = bloodType
            txtGetBloodInfo.Text = bloodInfo
            txtGetBloodCount.Text = amount
            txtDepartment.Text = department

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub


    Private Sub btnGetOrder_Click(sender As Object, e As EventArgs) Handles btnGetOrder.Click
        'Kjører prosedyren
        checkOrders()
        'Gjør knappen usynelig 
        btnGetOrder.Enabled = False
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        'Skjuler formen
        Me.Hide()
        'Kjører prsedyrer
        Statistics.Show()
        Statistics.btnBack.Show()
        Statistics.btnSignOut.Hide()
    End Sub

    'Sjekker om personnummeret eksisterer i databasen
    Private Sub verifySSNumber()
        'setter verifySSN lik tekstboksen hvor de ansatte har tastet inn personnummeret
        verifySSN = txtbxSSNV.Text

        If Regex.IsMatch(verifySSN, "^[0-9 ]+$") And verifySSN.Length = 11 Then
            'om personnummeret består av tall og er 11 karakterer langt blir det godkjent
            txtbxSSN = verifySSN
            lblLastDrain.Text = " "

            Try
                connection.Open()
                'sql spørringen henter ut last_drain som er siste tapping koblet til et person nummer
                Dim query As String = "Select last_drain From Blood_Data Where ss_number = '" & txtbxSSNV.Text & "' "
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

            getAppointmentTime()
            getUserName()

        Else
            MsgBox("Ugyldig personnummer", MsgBoxStyle.Critical, "feil")
        End If
    End Sub

    'Henter ut timen som personen har
    Private Sub getAppointmentTime()
        Try
            'her tilbakestilles lblnxtApp.text i tilfellet at ansatte skifter person nummer og at deres info ikke skal være igjen.
            lblnxtApp.Text = "Ikke satt opp"
            connection.Open()
            'sql spørringen henter ut cal_id, time, og dag fra calenderen basert på max(cal_id) til et personnummer
            Dim query As String = "Select cal_id, date, time From Order_Appointment Where ss_number =" & txtbxSSNV.Text & " And cal_id = (Select MAX(cal_id) From Order_Appointment Where ss_number = '" & txtbxSSNV.Text & "')"
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

    'Henter ut brukerens navn
    Private Sub getUserName()
        Try
            'lblname blir tilbakestilt for å garantere at riktig navn vises eller ingen.
            lblName.Text = " "

            connection.Open()
            'first og last name hentes ut fra users basert på person nummer
            Dim query As String = "Select firstname, lastname, quarantine From User Where ss_number ='" & txtbxSSNV.Text & "' "
            cmd = New MySqlCommand(query, connection)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            da.SelectCommand = cmd
            da.Fill(interntabell)
            connection.Close()

            Dim rad As DataRow
            Dim fname, lname As String
            For Each rad In interntabell.Rows

                fname = rad("firstname")
                lname = rad("lastname")
                'navn
                lblName.Text = fname + " " + lname
                lblQuarantine.Text = rad("quarantine")
            Next rad

        Catch feilmelding As MySqlException
            MsgBox("Feil ved uthenting av siste tapping     " &
         feilmelding.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub btnVSSN_Click(sender As Object, e As EventArgs) Handles btnVSSN.Click
        'Kjører prosedyren
        verifySSNumber()
    End Sub

    'Setter opp ny time
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
            MsgBox("du har allerede denne timen satt opp", MsgBoxStyle.Information, "Kalender")
        ElseIf testCheck1 = False And testcheck2 = False Then
            'her sjekkes det om lblnxtApp IKKE er "Avbestilt" og "Ikke satt opp", om en av de er satt opp er det en time satt opp.
            MsgBox("time er allerede satt opp", MsgBoxStyle.Information, "Kalender")
        ElseIf testCheck1 = True And testcheck2 = True Then
            'her sjekkes det om lblnxtApp ligner på både "avbestilt" OG "Ikke satt opp", dette skal i utgangspunktet ikke være mulig.
            MsgBox("noe gikk galt med sjekk etter tidligere oppsatt time", MsgBoxStyle.Information, "Kalender")

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
                    sporring = "Insert Into Order_Appointment (date, time, ss_number) VALUES ('" & DTPOrder.Text & "', '" & txtbxTime.Text & "', '" & txtbxSSNV.Text & "')"

                    Dim insertsql As New MySqlCommand(sporring, connection)
                    Dim da As New MySqlDataAdapter
                    Dim interntabell As New DataTable

                    da.SelectCommand = insertsql
                    da.Fill(interntabell)
                    connection.Close()

                    lblnxtApp.Text = DTPOrder.Value.ToString("dd/MM/yyyy") + " " + txtbxTime.Text
                    MsgBox("Time bestilt for dato: " & DTPOrder.Value.ToString("dd/MM/yyyy") & vbNewLine & "Klokken: " & txtbxTime.Text, MsgBoxStyle.Information, "Timebestilling")
                Catch feilmelding As MySqlException
                    MsgBox("Personnummer ikke gyldig", MsgBoxStyle.Critical, "Feil")
                Finally
                    connection.Dispose()
                End Try
            End If
        End If
    End Sub

    Private Sub BtnOrderApp_Click(sender As Object, e As EventArgs) Handles btnOrderApp.Click
        If lblQuarantine.Text = "Livstid" Then
            MsgBox("Denne brukeren har karantene og kan ikke donere blod", MsgBoxStyle.Critical, "Oops!")
        Else 'Kjører prosedyren
            OrderApp()
        End If
    End Sub

    'Sletter oppsatt time
    Private Sub deleteApp()
        'cancel blir satt tilbakestilt før hver spørring
        'cancel er en variabel som blir opptadert til max(cal_id) til en person sitt person nummer
        'så lenge cancel > 0 så vil denne personens oppsatte time (eller ved en feil med flere timer) alle timene bli slettet
        cancel = 0

        '= txtpaoSSN.Text
        If verifySSN = txtbxSSNV.Text Then
            txtbxSSN = verifySSN

            Try
                connection.Open()
                'select spørring som henter ut den max(cal_id) til et person nummer
                Dim sql As New MySqlCommand("Select Cal_id From Order_Appointment Where Cal_id = (Select MAX(Cal_id) From Order_Appointment Where ss_number =" & txtbxSSNV.Text & ") ", connection)
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
                    Dim sql As New MySqlCommand("Delete From `Order_Appointment` Where `ss_number`=" & txtbxSSNV.Text & " ", connection)
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

        End If
    End Sub

    Private Sub btnCApp_Click(sender As Object, e As EventArgs) Handles btnCApp.Click
        'Kjører prosedyren
        deleteApp()
    End Sub
    'Validerer riktig utfylt verdier i hemoglobin tekstbox
    Private Function validhemoglobin() As Boolean
        Dim hemo = txtHB.Text

        If Not Regex.IsMatch(hemo, "^-?\d{1,3}(,\d{3})*(\.\d)?$|^\.\d\d$") Then
            Me.ErrorProvider1.SetError(txtHB, "Feil format. Eksempel på riktig format: '10.0'")
            Return False
        ElseIf hemo < 10 Then
            Me.ErrorProvider1.SetError(txtHB, "Hemoglobin verdi må være mellom 10 og 25")
            Return False
        ElseIf hemo > 25 Then
            Me.ErrorProvider1.SetError(txtHB, "Hemoglobin verdi må være mellom 10 og 25")
            Return False
        Else
            Me.ErrorProvider1.SetError(txtHB, "")
            Return True
        End If
    End Function
    'Validerer riktig utfylt verdier i jerntekstboksen
    Private Function ValidIronValue() As Boolean

        Dim Iron = txtIron.Text
        If Not Regex.IsMatch(Iron, "^-?\d{1,3}(,\d{3})*(\.\d)?$|^\.\d\d$") Then
            Me.ErrorProvider1.SetError(txtIron, "Feil format. Eksempel på riktig format: '35'")
            Return False
        ElseIf Iron < 10 Then
            Me.ErrorProvider1.SetError(txtIron, "Jernverdi kan ikke vere under 10")
            Return False
        ElseIf Iron > 100 Then
            Me.ErrorProvider1.SetError(txtIron, "Jernverdi kan ikke være over 100")
            Return False
        Else
            Me.ErrorProvider1.SetError(txtIron, "")
            Return True
        End If

    End Function
    'Klarerer kalender labels
    Private Sub txtbxSSNV_TextChanged(sender As Object, e As EventArgs) Handles txtbxSSNV.TextChanged
        lblLastDrain.Text = ""
        lblName.Text = ""
        lblQuarantine.Text = ""
        lblnxtApp.Text = "Ikke satt opp"
    End Sub

End Class

