Imports MySql.Data.MySqlClient
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

    Private Sub load_table()
        Me.TabPage1.Text = "Brukerinformasjon"
        Me.TabPage2.Text = "Lagerbeholdning"
        Me.TabPage3.Text = "Statistikk"

    End Sub

    Private Sub dgwUser()
        dgwUsers.DefaultCellStyle.Font = New Font("Calibri", 14, FontStyle.Regular, GraphicsUnit.Point)
        dgwUsers.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold, GraphicsUnit.Point)


        Try
            connection.Open()
            Dim query As String = "SELECT TableUser.ss_number as 'Personnummer',TableUser.lastname as 'Etternavn',TableUser.firstname as 'Fornavn',TableUser.phone as 'Telefon', TableBlood.Blood_type as 'Blodtype' FROM User TableUser INNER JOIN Blood_Data TableBlood on TableUser.ss_number=TableBlood.ss_number"
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
        txtSSN.Enabled = False
        txtFirstname.Enabled = False
        txtLastname.Enabled = False
        txtPhone.Enabled = False

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
        Statistics()
    End Sub
    Private Sub TabPage1_Enter(sender As System.Object, e As System.EventArgs) Handles TabPage1.Enter
        dgwUser()
    End Sub
    Private Sub Statistics()
        CBType.Hide()

        Try
            connection.Open()

            da.SelectCommand = sql
            da.Fill(interntab)
            bSource.DataSource = interntab
            dgvBloodType.DataSource = bSource
            da.Update(interntab)

            da2.SelectCommand = sql2
            da2.Fill(intern2)
            bSoursce2.DataSource = intern2
            dgvGender.DataSource = bSoursce2
            da2.Update(intern2)

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
            interntab.Clear()
            intern2.Clear()
        End Try
        Try
            connection.Open()

            Dim dr2 As MySqlDataReader
            dr2 = sql2.ExecuteReader()

            While (dr2.Read())
                Me.CG.Series("KJØNNSFORDELING").Points.AddXY(dr2.GetString("gender"), dr2.GetInt64("COUNT(*)"))

            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        Try
            connection.Open()

            Dim dr As MySqlDataReader
            dr = sql.ExecuteReader()

            While (dr.Read())
                Me.CBType.Series("BLODTYPER").Points.AddXY(dr.GetString("blood_type"), dr.GetInt64("COUNT(*)"))
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        CBlodtype.Series.Clear()
        CBlodtype.Titles.Clear()

        CBlodtype.Series.Add("Blodtyper")

        CBlodtype.Series("Blodtyper").ChartType = SeriesChartType.Pie ' Blir deklareret som kakediagram

        CBlodtype.Series(0).LabelFormat = "{#''}"
        CBlodtype.Series(0).IsValueShownAsLabel = True

        Try
            connection.Open()
            Dim Query As String
            Dim BloodcountA As Int16 = 0
            Dim BloodcountB As Int16 = 0
            Dim BloodcountAB As Int16 = 0
            Dim BloodcountO As Int16 = 0

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'A Rh+' OR blood_type = 'A Rh-'"
            command = New MySqlCommand(Query, connection)
            BloodcountA = Convert.ToInt16(command.ExecuteScalar)

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'B Rh+' OR blood_type = 'B Rh-'"
            command = New MySqlCommand(Query, connection)
            BloodcountB = Convert.ToInt16(command.ExecuteScalar)

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'AB Rh+' OR blood_type = 'AB Rh-'"
            command = New MySqlCommand(Query, connection)
            BloodcountAB = Convert.ToInt16(command.ExecuteScalar)

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'O Rh+' OR blood_type = 'O Rh-'"
            command = New MySqlCommand(Query, connection)
            BloodcountO = Convert.ToInt16(command.ExecuteScalar)

            If BloodcountA > (0) Then ' Sjekker om data er relevant for grafen
                CBlodtype.Series("Blodtyper").Points.AddXY("A", BloodcountA)
            End If

            If BloodcountB > (0) Then
                CBlodtype.Series("Blodtyper").Points.AddXY("B", BloodcountB)
            End If


            If BloodcountAB > (0) Then
                CBlodtype.Series("Blodtyper").Points.AddXY("AB", BloodcountAB)
            End If

            If BloodcountO > (0) Then
                CBlodtype.Series("Blodtyper").Points.AddXY("O", BloodcountO)
            End If

            connection.Close() ' Lukker tilkobling

        Catch ex As MySqlException ' Fanger opp feil fra MySql
        End Try
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwUsers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgwUsers.Rows(e.RowIndex)

            txtFirstname.Text = row.Cells("Fornavn").Value.ToString
            txtLastname.Text = row.Cells("Etternavn").Value.ToString
            txtSSN.Text = row.Cells("Personnummer").Value.ToString
            txtPhone.Text = row.Cells("Telefon").Value.ToString
        End If

        'Dim bloodData As New Employee
        'bloodData.showBloodData(txtHB.Text, txtIron.Text, cbBloodType.Text)

        getUserInfo()
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

    Private Sub getUserInfo()

        Try
            connection.Open()
            Dim query As String = "select e_mail, quarantine FROM User where ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            Dim email As String = ""
            Dim quarantine As String = ""

            While reader.Read()
                email &= reader("e_mail") & " "
                quarantine &= reader("quarantine") & " "
            End While

            txtMail.Text = email
            txtQuarantine.Text = quarantine

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

    Private Sub btnSBType_Click(sender As Object, e As EventArgs) Handles btnSBType.Click
        CBlodtype.Hide()
        btnSBType.Hide()
        lblCPie.Hide()
        CBType.Show()
        btnBTPie.Show()
    End Sub

    Private Sub btnBTPie_Click(sender As Object, e As EventArgs) Handles btnBTPie.Click
        CBType.Hide()
        btnBTPie.Hide()
        btnSBType.Show()
        CBlodtype.Show()
        lblCPie.Show()
    End Sub

End Class