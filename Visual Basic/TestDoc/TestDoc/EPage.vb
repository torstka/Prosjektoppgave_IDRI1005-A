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

        DataGridView1.DefaultCellStyle.Font = New Font("Calibri", 12, FontStyle.Regular, GraphicsUnit.Point)
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 14, FontStyle.Bold, GraphicsUnit.Point)

        Try
            connection.Open()
            Dim query As String = "SELECT a.ss_number as 'Personnummer',a.lastname as 'Etternavn',a.firstname as 'Fornavn',a.phone as 'Telefon', b.Blood_type as 'Blodtype' FROM User a INNER JOIN Blood_Data b on a.ss_number=b.ss_number"
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


        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)


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
            txtBloodType.Text = bloodType

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

    Private Sub btnUpdateData_Click(sender As Object, e As EventArgs) Handles btnUpdateData.Click
        Try
            connection.Open()
            Dim query As String = "UPDATE Blood_Data SET blood_type = '" & txtBloodType.Text & "', hb = '" & txtHB.Text & "', iron_value = '" & txtIron.Text & "', last_drain = '" & todaysDate & "' WHERE ss_number = '" & txtSSN.Text & "'"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader


            MessageBox.Show("Bloddata oppdatert")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        dtable.Clear()
        load_table()
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBloodCount.KeyPress, txtGetBloodCount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnRegDonation_Click(sender As Object, e As EventArgs) Handles btnRegDonation.Click



        Dim status As String = "Valid"

        Dim expiryDate As String

        If cbBloodPart.Text = "Blodlegemer" Then
            expiryDate = Today.AddDays(35).ToString("dd/MM/yyyy")
        ElseIf cbBloodPart.Text = "Blodplater" Then
            expiryDate = Today.AddDays(7).ToString("dd/MM/yyyy")
        Else
            expiryDate = "Frozen"
        End If

        Dim addDonation As New Stock

        addDonation.addStock(cbBloodPart.SelectedItem, txtBloodType.Text, txtSSN.Text, expiryDate, status)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        LogIn.Show()

    End Sub

    Private Sub btnGetBlood_Click(sender As Object, e As EventArgs) Handles btnGetBlood.Click
        Dim todaysDate = Today.ToString("dd/MM/yyyy")
        ' Dim int As Integer
        'int = Integer.Parse(txtGetBloodCount.Text)
        Dim status = "Valid"


        Try
            connection.Open()




            Dim query2 As String = "SELECT * FROM Donation_Stock where blood_info = '" & cbGetBloodInfo.SelectedItem & "' AND blood_type = '" & cbGetBloodType.SelectedItem & "' AND status = '" & status & "'"
            cmd = New MySqlCommand(query2, connection)
            adapter = New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(dtable)

            For Each rad In dtable.Rows
                MsgBox(rad("blood_info") & " " & rad("blood_type") & " " & rad("status"))
                Console.WriteLine(rad("blood_info") & " " & rad("blood_type") & " " & rad("status"))
            Next



            'For i = 1 To int
            '    Dim query As String = "DELETE FROM Donation_Stock where blood_info = '" & cbGetBloodInfo.SelectedItem & "' AND blood_type = '" & cbGetBloodType.SelectedItem & "' AND status = '" & status & "' LIMIT 1"
            '    cmd = New MySqlCommand(query, connection)
            '    reader = cmd.ExecuteReader
            '    reader.Close()
            'Next

            'MsgBox("Blod hentet", MsgBoxStyle.Information, "Godkjent")
            'connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " Uttaket er ugyldig")
        Finally
            connection.Dispose()
        End Try
    End Sub


End Class