Imports MySql.Data.MySqlClient
Public Class UserInformation

    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim table As New DataTable

    Private Sub UserInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        load_table()
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

            MessageBox.Show("Data oppdatert")
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
End Class