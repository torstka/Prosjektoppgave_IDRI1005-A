Imports MySql.Data.MySqlClient
Public Class User


    Dim constring As String = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
    Dim connection As New MySqlConnection(constring)
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim reader As MySqlDataReader


    Public Sub add(ByVal ssNumber As String, ByVal firstname As String, ByVal lastname As String, ByVal address As String, ByVal zipcode As Integer, ByVal phone As String, ByVal email As String, ByVal password As String, ByVal male As String, ByVal female As String)
        Dim Mbox = NewUser.Mbox.Checked
        Dim Fbox = NewUser.Mbox.Checked

        Try
            connection.Open()
            Dim query = "insert into User (ss_number, firstname, lastname, phone, e_mail, address, zip_code, password, gender) values (@ssnumber, @firstname, @lastname, @phone, @email, @address, @zipcode, @password, @gender)"
            cmd = New MySqlCommand(query, connection)

            cmd.Parameters.AddWithValue("@ssnumber", ssNumber)
            cmd.Parameters.AddWithValue("@firstname", firstname)
            cmd.Parameters.AddWithValue("@lastname", lastname)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@zipcode", zipcode)
            cmd.Parameters.AddWithValue("@phone", phone)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@password", password)
            If Mbox Then
                cmd.Parameters.AddWithValue("@gender", male)
            ElseIf Fbox Then
                cmd.Parameters.AddWithValue("@gender", female)
            End If

            cmd.ExecuteNonQuery()
            MsgBox("Registrering vellykket!")
        Catch ex As Exception
            MsgBox(ex.Message)
            connection.Close()
        Finally
            connection.Dispose()
        End Try

    End Sub

    Public Sub update(ByVal fornavn As String, ByVal etternavn As String, ByVal telefon As String)

        Try
            connection.Open()
            Dim query As String = "UPDATE bruker SET fornavn = @firstname , etteranvn = @lastname, telefon = @telefon where fornavn = '" & fornavn & "'"
            cmd = New MySqlCommand(query, connection)

            cmd.Parameters.AddWithValue("@firstname", fornavn)
            cmd.Parameters.AddWithValue("@lastname", etternavn)
            cmd.Parameters.AddWithValue("@phone", telefon)
            reader = cmd.ExecuteReader

            MessageBox.Show("Data oppdatert")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        Finally
            connection.Dispose()
        End Try
    End Sub


    '  Public Sub load_table()
    '    connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
    'Dim SDA As New MySqlDataAdapter

    'Dim bSource As New BindingSource

    'Try
    '       connection.Open()
    'Dim query As String = "SELECT ss_number as 'Personnummer',lastname as 'Etternavn',firstname as 'Fornavn',blood_type as'Blodtype' FROM User"
    '        cmd = New MySqlCommand(query, connection)
    '        SDA.SelectCommand = cmd()
    '       SDA.Fill(dtable)
    '      bSource.DataSource = dtable
    '     DataGridView1.DataSource = bSource
    '    SDA.Update(dtable)

    '   connection.Close()
    'Catch ex As Exception
    '       MessageBox.Show(ex.Message)
    'Finally
    '       connection.Dispose()

    'End Try
    'End Sub


End Class
