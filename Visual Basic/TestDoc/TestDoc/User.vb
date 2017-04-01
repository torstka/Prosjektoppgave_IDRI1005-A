Imports MySql.Data.MySqlClient
Public Class User


    Dim constring As String = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
    Dim connection As New MySqlConnection(constring)
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim reader As MySqlDataReader
    Dim rad As DataRow

    Public ssNumber = LogIn.txtPersonnr.Text


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

    Public Sub update(ByVal firstname As String, ByVal lastname As String, ByVal phone As String, ByVal email As String, ByVal address As String, ByVal zipcode As String, ByVal password As String)

        Try
            connection.Open()
            Dim query As String = "UPDATE User SET firstname = @firstname,lastname = @lastname,phone = @phone, e_mail = @email, address = @address, zip_code = @zipcode, password = @password where ss_number = '" & ssNumber & "'"
            cmd = New MySqlCommand(query, connection)

            cmd.Parameters.AddWithValue("@firstname", firstname)
            cmd.Parameters.AddWithValue("@lastname", lastname)
            cmd.Parameters.AddWithValue("@phone", phone)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@zipcode", zipcode)
            cmd.Parameters.AddWithValue("@password", password)
            reader = cmd.ExecuteReader

            MessageBox.Show("Data oppdatert")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        Finally
            connection.Dispose()
        End Try
    End Sub

    Public Sub showData(ByVal firstname As String, ByVal lastname As String, ByVal phone As String, ByVal mail As String, ByVal address As String, ByVal zipCode As String, ByVal password As String)

        Try
            connection.Open()
            Dim query As String = "SELECT firstname, lastname, phone, e_mail, address, zip_code, password FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'"
            cmd = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(dtable)

            For Each rad In dtable.Rows
                firstname = (rad("firstname"))
                lastname = (rad("lastname"))
                phone = (rad("phone"))
                mail = (rad("e_mail"))
                address = (rad("address"))
                zipCode = (rad("zip_code"))
                password = (rad("password"))
            Next

        Catch ex As MySqlException
            MsgBox(ex.Message)         'tilfelle det oppstår en feil
            connection.Close()

        Finally
            connection.Dispose()  'lukke tilkoblingen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
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
