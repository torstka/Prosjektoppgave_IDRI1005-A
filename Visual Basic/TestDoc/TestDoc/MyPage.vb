Imports MySql.Data.MySqlClient
Public Class MyPage
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim command2 As MySqlCommand



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        'Calender.show()
    End Sub





    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        LogIn.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        'QuestionForm1.show()
    End Sub

    Private Sub MyPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ssn = LogIn.ssn
        connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        connection.Open()

        Dim reader As MySqlDataReader
        Dim query = "SELECT * from User where ss_number = """ & ssn & """"
        command = New MySqlCommand(query, connection)

        Dim reader2 As MySqlDataReader
        Dim query2 = "SELECT * from Blood_Data where ss_number = """ & ssn & """"
        command2 = New MySqlCommand(query2, connection)

        reader = command.ExecuteReader()

        Dim fornavn = ""
        Dim etternavn = ""
        Dim telefon = ""
        Dim epost = ""
        Dim adresse = ""
        Dim postnummer = ""
        Dim blodtype = ""

        While reader.Read()
            fornavn &= reader("firstname") & " "
            etternavn &= reader("lastname") & " "
            telefon &= reader("phone") & " "
            epost &= reader("e_mail") & " "
            adresse &= reader("address") & " "
            postnummer &= reader("zip_code") & " "
            blodtype &= reader("blood_type") & " "
        End While

        'reader2 = command2.ExecuteReader
        'Dim hb As Double = ""
        'Dim ironValue As Integer = ""
        'Dim lastDrain As String = ""

        'While reader2.Read()
        '    hb &= reader2("hb") & " "
        '    ironValue &= reader2("iron_value") & " "
        '    lastDrain &= reader2("last_drain") & " "
        'End While

        'ListBox1.Items.Add("Fornavn:        " & fornavn)
        'ListBox1.Items.Add("Etternavn:      " & etternavn)
        'ListBox1.Items.Add("Personnummer:   " & ssn)
        'ListBox1.Items.Add("")
        'ListBox1.Items.Add("Adresse:        " & adresse)
        'ListBox1.Items.Add("Telefon:        " & telefon)
        'ListBox1.Items.Add("Epost:          " & epost)
        'ListBox1.Items.Add("")
        'ListBox1.Items.Add("----------Blodinfo----------")
        'ListBox1.Items.Add("Blodtype:       " & blodtype)
        'ListBox1.Items.Add("Hemoglobin (hb):        " & hb)
        'ListBox1.Items.Add("Jernverdier:            " & ironValue)
        'ListBox1.Items.Add("")
        'ListBox1.Items.Add("Siste tapping:          " & lastDrain)

        'hent ut informasjon om blodtype

        reader.Close()

    End Sub
End Class