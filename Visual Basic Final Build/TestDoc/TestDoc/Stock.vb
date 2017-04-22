Imports MySql.Data.MySqlClient
Public Class Stock

    Dim constring As String = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
    Dim con As New MySqlConnection(constring)
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim reader As MySqlDataReader



    'Public Sub addStock(ByVal bloodPart As String, ByVal bloodType As String, ssn As String, ByVal expiryDate As String, ByVal status As String)


    '    Dim donationDate As Date = Today.ToString("dd/MM/yyyy")
    '    Dim test As Integer
    '    test = Integer.Parse(EPage.txtBloodCount.Text)
    '    Try
    '        con.Open()

    '        For i = 1 To test
    '            Dim query As String = "Insert INTO Donation_Stock (donation_date, blood_info, blood_type, ss_number, expiry_date, status) values('" & donationDate & "','" & bloodPart & "', '" & bloodType & "','" & ssn & "','" & expiryDate & "', '" & status & "')"
    '            cmd = New MySqlCommand(query, con)
    '            reader = cmd.ExecuteReader
    '            reader.Close()
    '        Next

    '        MsgBox("Data lagret", MsgBoxStyle.Information, "Lagret")
    '        con.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        con.Dispose()
    '    End Try
    'End Sub



End Class
