Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.DataVisualization.Charting
Public Class EPage
    Dim constring As String = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
    Dim connection As New MySqlConnection(constring)
    Dim cmd As MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim reader As MySqlDataReader
    Dim rad As DataRow
    Dim bSource As New BindingSource

    Dim todaysDate As String = Today.ToString("dd/MM/yyyy")

    Dim command As MySqlCommand
    Dim interntab As New DataTable
    Dim da As New MySqlDataAdapter
    Dim da2 As New MySqlDataAdapter
    Dim intern2 As New DataTable
    Dim bSoursce2 As New BindingSource
    Dim sql = New MySqlCommand("SELECT blood_type, COUNT(*) FROM Blood_Data WHERE blood_type <> 'Ikke verdi' GROUP BY blood_type HAVING COUNT(*)>0", connection)
    Dim sql2 = New MySqlCommand("SELECT gender,COUNT(*) FROM User GROUP BY gender HAVING COUNT(*)>0 ", connection)
    Public Overrides Property AutoSize As Boolean


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
    Private Sub load_table()
        'Me.TabPage1.Text = "Brukerinformasjon"
        'Me.TabPage2.Text = "Lagerbeholdning"
        'Me.TabPage3.Text = "Statistikk"

    End Sub

    Private Sub load_dgwUser()
        dgwUsers.DefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Regular, GraphicsUnit.Point)
        dgwUsers.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 17.5, FontStyle.Bold, GraphicsUnit.Point)


        Try
            connection.Open()
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
    Private Sub EPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()

        Userinformation.Size = New Size(1550, 750)

        Me.Size = SystemInformation.PrimaryMonitorSize
        Userinformation.Location = New Point((ClientSize.Width - Userinformation.Width) \ 2,
                             (ClientSize.Height - Userinformation.Height) \ 2)

        btnSignOut.Location = New Point((ClientSize.Width - btnSignOut.Width) \ 2 + 800,
                             (ClientSize.Height - btnSignOut.Height) \ 2 - 450)

        dgwUsers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        updateStock()
        showStock()
    End Sub

    Private Sub TabPage3_Enter(sender As System.Object, e As System.EventArgs) Handles TabPage3.Enter


    End Sub
    Private Sub TabPage1_Enter(sender As System.Object, e As System.EventArgs) Handles TabPage1.Enter
        dtable.Clear()
        interntab.Clear()
        intern2.Clear()
        load_dgwUser()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwUsers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgwUsers.Rows(e.RowIndex)

            txtFirstname.Text = row.Cells("Fornavn").Value.ToString
            txtLastname.Text = row.Cells("Etternavn").Value.ToString
            txtSSN.Text = row.Cells("Personnummer").Value.ToString
        End If

        'Dim bloodData As New Employee
        'bloodData.showBloodData(txtHB.Text, txtIron.Text, cbBloodType.Text)

        getUserInfo()
        getBloodData()

    End Sub


    Private Sub getBloodData()
        Try
            connection.Open()
            Dim query As String = "select blood_type, hb, iron_value, last_drain FROM Blood_Data where ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            Dim hb As String = ""
            Dim ironValue As String = ""
            Dim bloodType As String = ""
            Dim lastDrain As String = ""

            While reader.Read()
                hb &= reader("hb") & " "
                ironValue = reader("iron_value") & " "
                bloodType = reader("blood_type") & " "
                lastDrain = reader("last_drain") & " "
            End While

            txtHB.Text = hb
            txtIron.Text = ironValue
            cbBloodType.Text = bloodType
            txtLastDrain.Text = lastDrain

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub getUserInfo()

        Try
            connection.Open()
            Dim query As String = "select phone, e_mail, quarantine FROM User where ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            Dim email As String = ""
            Dim quarantine As String = ""
            Dim phone As String = " "


            While reader.Read()
                email &= reader("e_mail") & " "
                quarantine &= reader("quarantine") & " "
                phone &= reader("phone") & " "
            End While

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


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim DV As New DataView(dtable)
        DV.RowFilter = String.Format("Blodtype Like '%{0}%'", txtSearch.Text)
        dgwUsers.DataSource = DV
    End Sub

    Private Sub updateBloodData()

        Try
            connection.Open()
            Dim query As String = "UPDATE Blood_Data SET blood_type = '" & cbBloodType.Text & "', hb = '" & txtHB.Text & "', iron_value = '" & txtIron.Text & "' WHERE ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader


            MessageBox.Show("Bloddata oppdatert")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub


    Private Sub txt_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtGetBloodCount.KeyPress, txtHB.KeyPress, txtIron.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub clear()

        txtGetBloodType.Clear()
        txtGetBloodInfo.Clear()
        txtGetBloodCount.Clear()
        txtDepartment.Clear()

    End Sub

    Private Sub btnRegDonation_Click(sender As Object, e As EventArgs) Handles btnRegDonation.Click

        regDonation()

        'Dim addDonation As New Stock
        'addDonation.addStock(cbBloodPart.SelectedItem, cbBloodType.Text, txtSSN.Text, expiryDate, status)
        lbShowStock.Items.Clear()
        showStock()

    End Sub

    Public Sub regDonation()

        Dim status As String = "Valid"
        Dim expiryDate As String

        'If cbBloodPart.Text = "Blodlegemer" Then
        '    expiryDate = Today.AddDays(35).Date
        'ElseIf cbBloodPart.Text = "Blodplater" Then
        '    expiryDate = Today.AddDays(7).Date
        'Else
        '    expiryDate = "Frozen"
        'End If

        Dim donationDate As Date = Today.ToString("dd/MM/yyyy")
        Dim count As Integer = Integer.Parse(cbPlateletsCount.Text)
        Dim count2 As Integer = Integer.Parse(cbCellsCount.Text)
        Dim count3 As Integer = Integer.Parse(cbPlasmaCount.Text)
        Dim sum = cbPlateletsCount.Text + +cbPlasmaCount.Text + +cbCellsCount.Text

        If sum <> 5 Then
            MsgBox("Donasjonen må tilsammen tilsvare 5 poser")

        ElseIf cbBloodType.Text = "" And txtSSN.Text = "" Then
            MsgBox("Vær vennlig å velg donor", MsgBoxStyle.Critical, "Velg donor")

        ElseIf count = 0 Or count2 = 0 Or count3 = 0 Then
            MsgBox("Du må fylle inn alle vediene!", MsgBoxStyle.Critical, "Verdier mangler!")
        Else

            Try
                connection.Open()

                For i = 1 To count
                    expiryDate = Today.AddDays(7).Date
                    Dim query As String = "Insert INTO Donation_Stock (donation_date, blood_info, blood_type, ss_number, expiry_date, status) values('" & donationDate & "','Blodplater', '" & cbBloodType.Text & "','" & txtSSN.Text & "','" & expiryDate & "', '" & status & "')"
                    cmd = New MySqlCommand(query, connection)
                    reader = cmd.ExecuteReader
                    reader.Close()
                Next


                For i = 1 To count2
                    expiryDate = Today.AddDays(35).Date
                    Dim query As String = "Insert INTO Donation_Stock (donation_date, blood_info, blood_type, ss_number, expiry_date, status) values('" & donationDate & "','Blodlegemer', '" & cbBloodType.Text & "','" & txtSSN.Text & "','" & expiryDate & "', '" & status & "')"
                    cmd = New MySqlCommand(query, connection)
                    reader = cmd.ExecuteReader
                    reader.Close()
                Next



                For i = 1 To count3
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

    'Private Sub btnGetBlood_Click(sender As Object, e As EventArgs) Handles btnGetBlood.Click
    '    Dim todaysDate = Today.ToString("dd/MM/yyyy")
    '    Dim int As Integer
    '    int = Integer.Parse(txtGetBloodCount.Text)
    '    Dim status = "Valid"


    '    Try
    '        connection.Open()




    '        Dim query2 As String = "SELECT * FROM Donation_Stock where blood_info = '" & cbGetBloodInfo.SelectedItem & "' AND blood_type = '" & cbGetBloodType.SelectedItem & "' AND status = '" & status & "'"
    '        cmd = New MySqlCommand(query2, connection)
    '        adapter = New MySqlDataAdapter
    '        adapter.SelectCommand = cmd
    '        adapter.Fill(dtable)

    '        For Each rad In dtable.Rows
    '            MsgBox(rad("blood_info") & " " & rad("blood_type") & " " & rad("status"))
    '            Console.WriteLine(rad("blood_info") & " " & rad("blood_type") & " " & rad("status"))
    '        Next



    '        'For i = 1 To int
    '        '    Dim query As String = "DELETE FROM Donation_Stock where blood_info = '" & cbGetBloodInfo.SelectedItem & "' AND blood_type = '" & cbGetBloodType.SelectedItem & "' AND status = '" & status & "' LIMIT 1"
    '        '    cmd = New MySqlCommand(query, connection)
    '        '    reader = cmd.ExecuteReader
    '        '    reader.Close()
    '        'Next

    '        'MsgBox("Blod hentet", MsgBoxStyle.Information, "Godkjent")
    '        'connection.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message & " Uttaket er ugyldig")
    '    Finally
    '        connection.Dispose()
    '    End Try
    'End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Close()
        LogIn.Show()
    End Sub

    Private Sub btnGetBlood_Click(sender As Object, e As EventArgs) Handles btnGetBlood.Click
        If txtGetBloodType.Text = "" Or txtGetBloodInfo.Text = "" Or txtGetBloodCount.Text = 0 Then
            MsgBox("Fyll inn alle verdier", MsgBoxStyle.Critical, "Feil")
        Else
            getBlood()
            lbShowStock.Items.Clear()
            showStock()
        End If


        'If dt.Rows.Count >= int Then
        '    For i = 1 To int
        '        Dim query2 As String = "DELETE FROM Donation_Stock where blood_info = '" & cbGetBloodInfo.SelectedItem & "' AND blood_type = '" & cbGetBloodType.SelectedItem & "' AND status = '" & status & "' LIMIT 1"
        '        cmd = New MySqlCommand(query2, connection)
        '        reader = cmd.ExecuteReader
        '        reader.Close()
        '    Next
        'End If



        'If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
        '    MsgBox("Fant " & dt.Rows.Count.ToString & " godkjente uttak")
        'Else
        '    MsgBox("Not found")
        'End If

    End Sub

    Public Sub updateStock()
        Dim todaysDate = Today.Date
        Try
            connection.Open()
            Dim query As String = "UPDATE Donation_Stock SET status = 'Expired' where expiry_date <= '" & todaysDate & "' "
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub


    Private Sub getBlood()

        Dim int As Integer
        int = Integer.Parse(txtGetBloodCount.Text)
        Dim status = "Valid"

        Try

            Dim query As String = "select * FROM Donation_Stock where blood_info = '" & txtGetBloodInfo.Text & "' AND blood_type = '" & txtGetBloodType.Text & "' AND status = '" & status & "'"
            Dim dt As New DataTable

            Using cnn As New MySqlConnection(constring)
                cnn.Open()
                Using ad As New MySqlDataAdapter(query, cnn)
                    ad.Fill(dt)
                End Using
                cnn.Close()
            End Using

            connection.Open()
            If dt IsNot Nothing AndAlso dt.Rows.Count >= int Then
                For i = 1 To int
                    Dim query2 As String = "DELETE FROM Donation_Stock where blood_info = '" & txtGetBloodInfo.Text & "' AND blood_type = '" & txtGetBloodType.Text & "' AND status = '" & status & "' LIMIT 1"
                    cmd = New MySqlCommand(query2, connection)
                    reader = cmd.ExecuteReader
                    reader.Close()
                Next
                MsgBox("Hentet fra lager:" & vbCrLf & vbCrLf & "Blodinfo: " & txtGetBloodInfo.Text & vbCrLf & "Blodtype: " & txtGetBloodType.Text & vbCrLf & "Mengde: " & int & " ml")
                btnGetBlood.Visible = False
                btnGetOrder.Visible = True
                clear()

            Else
                MsgBox("Ikke nok på lager")

            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    'Disse tre følgende kodene fjerner det som står inne i textboxene, de ansatte ska bruke for å legge inn blodverdier
    'på respektive donorer som kommer som svar fra lab. Gjør jobben hurtig når textbox klargjøres for inntasing både
    'med musklikk og med tab.


    Private Sub showStock()

        Try

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
            Dim count25 As Int16
            Dim count26 As Int16
            Dim count27 As Int16
            Dim count28 As Int16
            Dim count29 As Int16
            Dim count30 As Int16

#End Region

#Region "Queries"
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

            'Dim query25 As String = "select COUNT(blood_type) FROM Donation_Stock where Blood_Type = 'A Rh+' AND Status = 'Valid'"
            'Dim cmd25 = New MySqlCommand(query25, connection)
            'count25 = cmd25.ExecuteScalar

            'Dim query26 As String = "select COUNT(blood_type) FROM Donation_Stock where Blood_Type = 'A Rh-' AND Status = 'Valid'"
            'Dim cmd26 = New MySqlCommand(query26, connection)
            'count26 = cmd26.ExecuteScalar

            'Dim query27 As String = "select COUNT(blood_type) FROM Donation_Stock where Blood_Type = 'B Rh+' AND Status = 'Valid'"
            'Dim cmd27 = New MySqlCommand(query27, connection)
            'count27 = cmd27.ExecuteScalar

            'Dim query28 As String = "select COUNT(blood_type) FROM Donation_Stock where Blood_Type = 'B Rh-' AND Status = 'Valid'"
            'Dim cmd28 = New MySqlCommand(query28, connection)
            'count28 = cmd28.ExecuteScalar

            'Dim query29 As String = "select COUNT(blood_type) FROM Donation_Stock where Blood_Type = 'AB Rh+' AND Status = 'Valid'"
            'Dim cmd29 = New MySqlCommand(query29, connection)
            'count29 = cmd29.ExecuteScalar

            'Dim query30 As String = "select COUNT(blood_type) FROM Donation_Stock where Blood_Type = 'AB Rh-' AND Status = 'Valid'"
            'Dim cmd30 = New MySqlCommand(query30, connection)
            'count30 = cmd30.ExecuteScalar


#End Region

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
    Private Sub deleteUser()

        Try
            connection.Open()
            Dim query As String = "DELETE FROM Blood_Data where ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            MsgBox("Slettet bruker:" & vbCrLf & "Fornavn: " & txtFirstname.Text & vbCrLf & "Etternavn: " & txtLastname.Text & vbCrLf & "Personnummer: " & txtSSN.Text)
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub btnSummons_Click(sender As Object, e As EventArgs) Handles btnSummons.Click



        If txtQuarantine.Text = "Livstid " Then
            MsgBox("Denne brukeren har en karantene på 'Livstid'")


        ElseIf txtSSN.Text = "" Then
            MsgBox("Du har ikke valg en bruker.", MsgBoxStyle.Critical, "Feil")


        Else
            MailForm.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtSSN.Text = "" Then
            MsgBox("Velg bruker som skal oppdateres", MsgBoxStyle.Critical, "Feil")
        Else
            updateBloodData()
            dtable.Clear()
            load_table()
        End If

    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click

        If txtSSN.Text = "" Then
            MsgBox("Velg bruker som skal slettes", MsgBoxStyle.Critical, "Feil")
        Else
            deleteUser()
            dtable.Clear()
            load_table()
        End If

    End Sub


    Private Sub checkDonationAmount()


    End Sub

    Private Sub checkOrders()
        Try
            connection.Open()
            Dim query As String = "select * FROM Orders  ORDER BY rand() LIMIT 1"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            Dim bloodType As String = ""
            Dim bloodInfo As String = ""
            Dim amount As String = ""
            Dim department As String = ""

            While reader.Read()
                bloodType &= reader("bloodType") & " "
                bloodInfo &= reader("bloodInfo") & " "
                amount &= reader("amount") & " "
                department &= reader("depName") & " "

            End While

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
        checkOrders()
        btnGetOrder.Visible = False
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Me.Hide()
        Statistics.Show()
        Statistics.btnBack.Show()
        Statistics.btnSignOut.Hide()

    End Sub

    Private Sub verifySSNumber()
        'setter verifySSN lik tekstboksen hvor de ansatte har tastet inn personnummeret
        verifySSN = txtbxSSNV.Text

        If Regex.IsMatch(verifySSN, "^[0-9 ]+$") And verifySSN.Length = 11 Then
            'om personnummeret består av tall og er 11 karakterer langt blir det godkjent
            txtbxSSN = verifySSN
            lblLastDrain.Text = " "

            Try
                tilkobling.Open()
                'sql spørringen henter ut last_drain som er siste tapping koblet til et person nummer
                Dim sql As New MySqlCommand("Select last_drain From Blood_Data Where ss_number =" & txtbxSSNV.Text & " ", tilkobling)
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
                Dim sql As New MySqlCommand("Select cal_id, day, time From Calendar Where ss_number =" & txtbxSSNV.Text & " And cal_id = (Select MAX(cal_id) From Calendar Where ss_number =" & txtbxSSNV.Text & ")", tilkobling)
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

            Try
                'lblname blir tilbakestilt for å garantere at riktig navn vises eller ingen.
                lblName.Text = " "

                tilkobling.Open()
                'first og last name hentes ut fra users basert på person nummer
                Dim sql As New MySqlCommand("Select firstname, lastname From User Where ss_number ='" & txtbxSSNV.Text & "' ", tilkobling)
                Dim da As New MySqlDataAdapter
                Dim interntabell As New DataTable

                da.SelectCommand = sql
                da.Fill(interntabell)
                tilkobling.Close()

                Dim rad As DataRow
                Dim fname, lname As String
                For Each rad In interntabell.Rows

                    fname = rad("firstname")
                    lname = rad("lastname")
                    'navn
                    lblName.Text = fname + " " + lname
                Next rad

            Catch feilmelding As MySqlException
                MsgBox("Feil ved uthenting av siste tapping     " &
             feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try

        Else
            MsgBox("Ugyldig personnummer")
        End If
    End Sub
#Region "pao Verify Social Security Number"
    Private Sub btnVSSN_Click(sender As Object, e As EventArgs) Handles btnVSSN.Click
        'knapp for å verifiere at person nummeret er 11 siffer og inneholder tall. 
        'kort sagt mye av det samme som fra load spørringene som userpage har til bruk i kalenderen.
        verifySSNumber()
    End Sub
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
                    sporring = "Insert Into Calendar VALUES (' ', '" & txtbxSSNV.Text & "', '" & DTPOrder.Text & "', '" & txtbxTime.Text & "')"

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
    Private Sub BtnOrderApp_Click(sender As Object, e As EventArgs) Handles BtnOrderApp.Click
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
        If verifySSN = txtbxSSNV.Text Then
            txtbxSSN = verifySSN

            Try
                tilkobling.Open()
                'select spørring som henter ut den max(cal_id) til et person nummer
                Dim sql As New MySqlCommand("Select Cal_id From Calendar Where Cal_id = (Select MAX(Cal_id) From Calendar Where ss_number =" & txtbxSSNV.Text & ") ", tilkobling)
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
                    Dim sql As New MySqlCommand("Delete From `Calendar` Where `ss_number`=" & txtbxSSNV.Text & " ", tilkobling)
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