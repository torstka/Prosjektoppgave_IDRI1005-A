Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class UserPage

    Public tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
    Public connection As MySqlConnection
    Public COMMAND As MySqlCommand


    Private Sub UserPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MyPage.Text = "Min side "
        Me.BookTime.Text = "Bestill time"
        Me.ChangeData.Text = "Endre personopplysninger"
        Me.InfoPage.Text = "Informasjon Blodgiving"



        Dim da As New MySqlDataAdapter
        Dim interntabel As New DataTable
        Dim da2 As New MySqlDataAdapter      'de 3 neste her er for å få med seg blodtypen, statisk verdi og skal linkes opp mot txtpersonnr fra form1
        Dim intern2 As New DataTable
        Dim rad As DataRow   'det vil være mange forskjellige variabler i hver rad i den interne tabellen
        Dim da3 As New MySqlDataAdapter
        Dim intern3 As New DataTable
        Dim da4 As New MySqlDataAdapter
        Dim intern4 As New DataTable

        Try
            tilkobling.Open()
            Dim sqlBloodInfo As New MySqlCommand("SELECT last_Drain, hb, iron_Value FROM Blood_Data WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)   'kommando med variabel til å ta imot fra DB, og tilkoblingen
            da.SelectCommand = sqlBloodInfo   'da(data_adapter) velger hvilken kommando som skal kjøres og "Kommanderer" de over til interntabellen med en sqlspørring hvor alt legges i variabelen fra linja over
            da.Fill(interntabel)          'når kommandolinje er valgt og utføres, legges data inn i den internetabellen, som igjen laster rad for rad inn i textboxene
            Dim sqltype As New MySqlCommand("SELECT blood_type FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)
            Dim sqlname As New MySqlCommand("SELECT firstname, lastname FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)
            da2.SelectCommand = sqlname
            da2.Fill(intern2)
            da3.SelectCommand = sqltype
            da3.Fill(intern3)

            Dim sqlEditInfo As New MySqlCommand("SELECT e_mail, phone, address, password, firstname, lastname FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", tilkobling)
            da4.SelectCommand = sqlEditInfo
            da4.Fill(intern4)

            For Each rad In interntabel.Rows
                txtDrain.Text = (rad("last_Drain"))
                txtHb.Text = (rad("hb"))
                txtIronValue.Text = (rad("iron_Value"))
            Next

            For Each rad In intern2.Rows
                Label1.Text = (rad("firstname") & " " & rad("lastname"))
            Next

            For Each rad In intern3.Rows
                txtBtype.Text = (rad("blood_type"))
            Next

            For Each rad In intern4.Rows
                txtFirstName.Text = (rad("firstname"))
                txtLastName.Text = (rad("lastname"))
                txtMail.Text = (rad("e_mail"))
                txtPhone.Text = (rad("phone"))
                txtAddress.Text = (rad("address"))
                txtPwd.Text = (rad("password"))
                txtConPwd.Text = txtPwd.Text
            Next

        Catch ex As MySqlException
            MsgBox(ex.Message)        'tilfelle det oppstår en feil
        Finally
            tilkobling.Dispose()      'lukke tilkoblingen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        End Try
    End Sub

    Public Sub variables()

        Dim firstname As String = txtFirstName.Text
        Dim lastname As String = txtLastName.Text
        Dim address As String = txtAddress.Text
        Dim phone As String = txtPhone.Text
        Dim email As String = txtMail.Text
        Dim password As String = txtPwd.Text
    End Sub


    Private Sub btnChangeData_Click(sender As Object, e As EventArgs) Handles btnChangeData.Click

        Dim updateUser As New User
        updateUser.update(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtZipcode.Text, txtPhone.Text, txtMail.Text, txtPwd.Text)

    End Sub
End Class