Imports MySql.Data.MySqlClient
Public Class UserInformation

    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim table As New DataTable

    Private Sub UserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        load_table()
        Button2.Hide()
        Button3.Hide()
        Button6.Hide()

    End Sub

    Private Sub load_table()
        connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource

        Try
            connection.Open()
            Dim query As String = "SELECT ss_number as 'Personnummer',lastname as 'Etternavn',firstname as 'Fornavn',blood_type as'Blodtype' FROM User"
            command = New MySqlCommand(query, connection)
            SDA.SelectCommand = command
            SDA.Fill(table)
            bSource.DataSource = table
            DataGridView1.DataSource = bSource
            SDA.Update(table)

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub

    'Private Sub btnLoadTable_Click(sender As Object, e As EventArgs) Handles btnLoadTable.Click


    'connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
    'Dim SDA As New MySqlDataAdapter
    'Dim table As New DataTable
    '        'Dim bSource As New BindingSource

    'Try
    'connection.Open()
    'Dim query As String = "SELECT ss_number as 'Personnummer',lastname as 'Etternavn',firstname as 'Fornavn',blood_type as'Blodtype' FROM User"
    'command = New MySqlCommand(query, connection)
    'SDA.SelectCommand = command
    'SDA.Fill(table)
    'bSource.DataSource = table
    'DataGridView1.DataSource = bSource
    'SDA.Update(table)

    'connection.Close()
    'Catch ex As Exception
    'MessageBox.Show(ex.Message)
    'Finally
    'connection.Dispose()

    'End Try
    'End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            txtFirstname.Text = row.Cells("Fornavn").Value.ToString
            txtLastname.Text = row.Cells("Etternavn").Value.ToString
            txtSSN.Text = row.Cells("Personnummer").Value.ToString
            txtBloodType.Text = row.Cells("Blodtype").Value.ToString
        End If

        Dim reader As MySqlDataReader
        connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")

        Try
            connection.Open()
            Dim query As String = "select hb, iron_value FROM Blood_Data where ss_number = '" & txtSSN.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader

            Dim hb As String = ""
            Dim ironValue As String = ""

            While reader.Read()
                hb &= reader("hb") & " "
                ironValue = reader("iron_value") & " "

            End While


            txtHB.Text = hb
            txtIron.Text = ironValue

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim DV As New DataView(table)
        DV.RowFilter = String.Format("Blodtype Like '%{0}%'", txtSearch.Text)
        DataGridView1.DataSource = DV

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        Dim reader As MySqlDataReader 'deklarerer leseren


        'bruker try catch for å fange eventuelle feil ved spørringen
        Try
            connection.Open()
            Dim query As String = "UPDATE User SET blood_type = '" & txtBloodType.Text & "' WHERE ss_number = '" & txtSSN.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader


            MessageBox.Show("Blodtype registrert")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        table.Clear()
        load_table()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("En innkalling til " & txtFirstname.Text & " " & txtLastname.Text & " med fødselsnummer " & txtSSN.Text & " er nå sendt.", MsgBoxStyle.Information, "Innkalling Godkjent")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim reader As MySqlDataReader
        connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")

        Try
            connection.Open()
            Dim query As String = "Insert INTO Blood_Data VALUES (' ', (select ss_number from User where ss_number = '" & txtSSN.Text & "'), '" & txtHB.Text & "', '" & txtIron.Text & "', '" & txtLastDrain.Text & "')"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Data lagret")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim reader As MySqlDataReader
        connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")

        Try
            connection.Open()
            Dim query As String = "UPDATE Blood_Data SET hb= '" & txtHB.Text & "', iron_value='" & txtIron.Text & "' WHERE ss_number = '" & txtSSN.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Data lagret")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Show()
        Button5.Enabled = False
        Button2.Show()
        Button6.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox1.Show()
        Button4.Enabled = False
        Button3.Show()
        Button6.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox1.Hide()
        Button3.Hide()
        Button2.Hide()
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Hide()
    End Sub
End Class