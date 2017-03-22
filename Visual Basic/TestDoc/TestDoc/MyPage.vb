Imports MySql.Data.MySqlClient
Public Class MyPage
    Private tilkobling As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        DataMyBlood.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        'Calender.show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        BloodInformation.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        'PersonInfo.Show() ' forma som legger inn personalia som er lik den ved førstegangs registrering
        'for det er vel kun de data man tenker at bruker skal kunne endre???
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
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        tilkobling.Open()

        Dim sqlSporring = "SELECT * from User where ss_number = """ & ssn & """"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)



        Dim leser = sql.ExecuteReader()

        Dim fornavn = ""
        Dim etternavn = ""
        Dim telefon = ""
        Dim epost = ""
        Dim adresse = ""
        Dim postnummer = ""

        While leser.Read()
            fornavn &= leser("firstname") & " "
            etternavn &= leser("lastname") & " "
            telefon &= leser("phone") & " "
            epost &= leser("e_mail") & " "
            adresse &= leser("address") & " "
            postnummer &= leser("zip_code") & " "


        End While
        ListBox1.Items.Add("Fornavn:        " & fornavn)
        ListBox1.Items.Add("Etternavn:      " & etternavn)
        ListBox1.Items.Add("Personnummer:   " & ssn)
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Adresse:        " & adresse)
        ListBox1.Items.Add("Telefon:        " & telefon)
        ListBox1.Items.Add("Epost:          " & epost)
        ListBox1.Items.Add("----------Blodinfo----------")
        'hent ut informasjon om blodtype

        leser.Close()

    End Sub
End Class