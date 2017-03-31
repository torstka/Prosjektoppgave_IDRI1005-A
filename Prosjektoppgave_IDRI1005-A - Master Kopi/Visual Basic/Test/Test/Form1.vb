Imports MySql.Data.MySqlClient
Public Class Form1
    Private connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
    Private answer As String
    Private comm As MySqlCommand

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        connection.Close()
        connection.Dispose()
    End Sub
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

    Private Function GetCheckedItem()
        Dim selected As String = ""
        If rbJa.Checked = True Then
            selected = "Ja"
        Else rbNei.Checked = True
            selected = "Nei"
        End If
        Return selected
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabPage1.Text = "Runde 1"
        Me.TabPage2.Text = "Runde 2"
        Me.TabPage3.Text = "Runde 3"
        Me.TabPage4.Text = "Runde 4"
        Me.TabPage5.Text = "Runde 5"
        Me.TabPage6.Text = "Runde 6"
        Me.TabPage7.Text = "Runde 7"
        Me.TabPage8.Text = "Runde 8"

        connection.Open()
        Dim command As New MySqlCommand("SELECT * FROM QuestForm ", connection)

        command.Parameters.Add("@id", MySqlDbType.Text).Value = qu1.Text
        Dim adapter As New MySqlDataAdapter(command)
        Dim tabell As New DataTable()
        adapter.Fill(tabell)

        If tabell.Rows.Count() > 0 Then
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

        End If

        '----------
        'For Each row As DataRow In tabell.Rows
        '    row.Item(tabell.Rows(0)(0).ToString() & " " & tabell.Rows(0)(1).ToString())
        '    'For Each letter As datarow In tabell.Rows
        '    '    qu1.Text = tabell.Rows(Index)(0).ToString() & " " & tabell.Rows(Index)(1).ToString()
        '    '    Debug.Write(Index.ToString & letter & " ")
        '    'Next
        'Next row



        ' Sporring("INSERT INTO Person(Fornavn, Etternavn, Epost) VALUES('" & qu1.Text & "'.'" & qu2.Text & "')")

        connection.close()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbJa.CheckedChanged
        answer = "ja"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbNei.CheckedChanged
        answer = "nei"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNeste1.Click
        TabControl1.SelectTab(1)
        connection.connectionString = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"

        ' newConn = New MySqlConnection
        Dim command As New MySqlCommand("Select * FROM Answers ", connection)
        Dim reader As MySqlDataReader

        Try
            connection.Open()
            Dim query As String
            query = "INSERT INTO Answers(id, answer) VALUE (id, '" & answer & "')"
            comm = New MySqlCommand(query, connection)
            reader = comm.ExecuteReader

            MsgBox("Svarene er lagret")
            connection.close()
        Catch ex As Exception
            MsgBox("FEIL")

        End Try

    End Sub

End Class

'HUSK Å ENDRE NAVN PÅ KNAPPER OG ALT

