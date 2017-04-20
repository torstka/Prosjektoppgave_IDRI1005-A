Imports MySql.Data.MySqlClient
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

    Private Sub load_table()

        DataGridView1.DefaultCellStyle.Font = New Font("Calibri", 14, FontStyle.Regular, GraphicsUnit.Point)
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold, GraphicsUnit.Point)

        Me.TabPage1.Text = "Brukerinformasjon"
        Me.TabPage2.Text = "Lagerbeholdning"
        Me.TabPage3.Text = "Statistikk"


        Try
            connection.Open()
            Dim query As String = "SELECT TableUser.ss_number as 'Personnummer',TableUser.lastname as 'Etternavn',TableUser.firstname as 'Fornavn',TableUser.phone as 'Telefon', TableUser.quarantine as 'Karantene', TableBlood.Blood_type as 'Blodtype' FROM User TableUser INNER JOIN Blood_Data TableBlood on TableUser.ss_number=TableBlood.ss_number"
            cmd = New MySqlCommand(query, connection)
            adapter.SelectCommand = cmd
            adapter.Fill(dtable)
            bSource.DataSource = dtable
            DataGridView1.DataSource = bSource
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
        txtSSN.Enabled = False
        txtFirstname.Enabled = False
        txtLastname.Enabled = False
        txtPhone.Enabled = False

        Me.Size = SystemInformation.PrimaryMonitorSize
        Userinformation.Location = New Point((ClientSize.Width - Userinformation.Width) \ 2,
                             (ClientSize.Height - Userinformation.Height) \ 2)

        btnSignOut.Location = New Point((ClientSize.Width - btnSignOut.Width) \ 2 + 800,
                             (ClientSize.Height - btnSignOut.Height) \ 2 - 450)

        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        updateStock()
        showStock()



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            txtFirstname.Text = row.Cells("Fornavn").Value.ToString
            txtLastname.Text = row.Cells("Etternavn").Value.ToString
            txtSSN.Text = row.Cells("Personnummer").Value.ToString
            txtPhone.Text = row.Cells("Telefon").Value.ToString
        End If

        'Dim bloodData As New Employee
        'bloodData.showBloodData(txtHB.Text, txtIron.Text, cbBloodType.Text)

        getMail()
        getBloodData()


    End Sub


    Private Sub getBloodData()
        Try
            connection.Open()
            Dim query As String = "select blood_type, hb, iron_value FROM Blood_Data where ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            Dim hb As String = ""
            Dim ironValue As String = ""
            Dim bloodType As String = ""

            While reader.Read()
                hb &= reader("hb") & " "
                ironValue = reader("iron_value") & " "
                bloodType = reader("blood_type") & " "

            End While

            txtHB.Text = hb
            txtIron.Text = ironValue
            cbBloodType.Text = bloodType


            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub getMail()

        Try
            connection.Open()
            Dim query As String = "select e_mail FROM User where ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            Dim email As String = ""

            While reader.Read()
                email &= reader("e_mail") & " "
            End While

            txtMail.Text = email

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
        DataGridView1.DataSource = DV
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

        txtPlateletsCount.Clear()
        txtCellsCount.Clear()
        txtPlasmaCount.Clear()

    End Sub

    Private Sub btnRegDonation_Click(sender As Object, e As EventArgs) Handles btnRegDonation.Click

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
        Dim count As Integer = Integer.Parse(txtPlateletsCount.Text)
        Dim count2 As Integer = Integer.Parse(txtCellsCount.Text)
        Dim count3 As Integer = Integer.Parse(txtPlasmaCount.Text)
        Dim sum = txtPlateletsCount.Text + +txtPlasmaCount.Text + +txtCellsCount.Text

        If sum <> 500 Then
            MsgBox("Den totale verdien må tilsammen være 500 ml")

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

        'Dim addDonation As New Stock

        'addDonation.addStock(cbBloodPart.SelectedItem, cbBloodType.Text, txtSSN.Text, expiryDate, status)

        lbShowStock.Items.Clear()
        showStock()

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
        If cbGetBloodType.Text = "" Or cbGetBloodInfo.Text = "" Or txtGetBloodCount.Text = 0 Then
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

            Dim query As String = "select * FROM Donation_Stock where blood_info = '" & cbGetBloodInfo.SelectedItem & "' AND blood_type = '" & cbGetBloodType.SelectedItem & "' AND status = '" & status & "'"
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
                    Dim query2 As String = "DELETE FROM Donation_Stock where blood_info = '" & cbGetBloodInfo.SelectedItem & "' AND blood_type = '" & cbGetBloodType.SelectedItem & "' AND status = '" & status & "' LIMIT 1"
                    cmd = New MySqlCommand(query2, connection)
                    reader = cmd.ExecuteReader
                    reader.Close()
                Next
                MsgBox("Hentet fra lager:" & vbCrLf & vbCrLf & "Blodinfo: " & cbGetBloodInfo.Text & vbCrLf & "Blodtype: " & cbGetBloodType.Text & vbCrLf & "Mengde: " & int & " ml")
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
    Private Sub txtPlateletsCount_Click(sender As Object, e As EventArgs) Handles txtPlateletsCount.Click
        txtPlateletsCount.Text = ""
    End Sub
    Private Sub txtPlasmaCount_Click(sender As Object, e As EventArgs) Handles txtPlasmaCount.Click
        txtPlasmaCount.Text = ""
    End Sub
    Private Sub txtCellsCount_Click(sender As Object, e As EventArgs) Handles txtCellsCount.Click
        txtCellsCount.Text = ""
    End Sub

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
                .Add("Blodplater:" & vbTab & count)
                .Add("Blodlegemer:" & vbTab & count2)
                .Add("Blodplasma:" & vbTab & count3)
                .Add("")
                .Add("A Rh-")
                .Add("Blodplater:" & vbTab & count4)
                .Add("Blodlegemer:" & vbTab & count5)
                .Add("Blodplasma:" & vbTab & count6)
                .Add("")
                .Add("B Rh+")
                .Add("Blodplater" & vbTab & count7)
                .Add("Blodlegemer" & vbTab & count8)
                .Add("Blodplasma" & vbTab & count9)
                .Add("")
                .Add("B Rh-")
                .Add("Blodplater" & vbTab & count10)
                .Add("Blodlegemer" & vbTab & count11)
                .Add("Blodplasma" & vbTab & count12)
                .Add("")
                .Add("AB Rh+")
                .Add("Blodplater" & vbTab & count13)
                .Add("Blodlegemer" & vbTab & count14)
                .Add("Blodplasma" & vbTab & count15)
                .Add("")
                .Add("AB Rh-")
                .Add("Blodplater" & vbTab & count16)
                .Add("Blodlegemer" & vbTab & count17)
                .Add("Blodplasma" & vbTab & count18)
                .Add("")
                .Add("O Rh+")
                .Add("Blodplater" & vbTab & count19)
                .Add("Blodlegemer" & vbTab & count20)
                .Add("Blodplasma" & vbTab & count21)
                .Add("")
                .Add("O Rh-")
                .Add("Blodplater" & vbTab & count22)
                .Add("Blodlegemer" & vbTab & count23)
                .Add("Blodplasma" & vbTab & count24)
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

        If txtSSN.Text = "" Then
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
End Class