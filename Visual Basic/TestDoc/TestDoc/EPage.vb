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

        Try
            connection.Open()
            Dim query As String = "SELECT ss_number as 'Personnummer',lastname as 'Etternavn',firstname as 'Fornavn', phone as 'Telefon' FROM User"
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

    Private Sub btnAddData_Click(sender As Object, e As EventArgs) Handles btnAddData.Click

        Try
            connection.Open()
            Dim query As String = "Insert INTO Blood_Data (blood_type, hb, iron_value, last_drain, ss_number) values( '" & txtBloodType.Text & "','" & txtHB.Text & "', '" & txtIron.Text & "', '" & todaysDate & "','" & txtSSN.Text & "')"
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader
            MsgBox("Data lagret", MsgBoxStyle.Information, "Lagret")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub

    Private Sub btnRegDonation_Click(sender As Object, e As EventArgs) Handles btnRegDonation.Click

        Dim addDonation As New Stock

        addDonation.add(txtBloodType.Text, txtSSN.Text)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        LogIn.Show()

    End Sub
End Class