Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class UserPage

    'Public connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
    'Public connection As MySqlConnection
    'Public COMMAND As MySqlCommand

    Dim constring As String = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
    Dim connection As New MySqlConnection(constring)
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim reader As MySqlDataReader
    Dim rad As DataRow
    Public ssNumber = LogIn.txtPersonnr.Text

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFirstName.KeyDown
        If e.KeyCode = Keys.Enter Then     'her kan man flytte med bruk av ENTER mellom textboxer, av hensyn til nedsatt bevegelighet
            txtLastName.Focus()                 'gjelder for alle 8 følgende koder nedover
        End If
    End Sub
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLastName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAddress.Focus()
        End If
    End Sub
    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtZipcode.Focus()
        End If
    End Sub
    Private Sub TextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZipcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPhone.Focus()
        End If
    End Sub
    Private Sub TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMail.Focus()
        End If
    End Sub
    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPwd.Focus()
        End If
    End Sub
    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtConPwd.Focus()
            e.Handled = e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub TextBox8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConPwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangeData.Focus()
            e.Handled = e.SuppressKeyPress = True
        End If
    End Sub
    'denne suben fjerner ding-lyden som normalt kommer når man manipulerer entertasten
    Const CARRIAGE_RETURN As Char = Chr(13)

    Private Sub NoReturnTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = CARRIAGE_RETURN Then
            e.Handled = True
            System.Windows.Forms.SendKeys.Send(vbTab)
        End If

    End Sub
    Public Sub showData()

        Try
            connection.Open()
            Dim query As String = "SELECT firstname, lastname, phone, e_mail, address, zip_code, password FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'"
            cmd = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(dtable)

            For Each rad In dtable.Rows
                txtFirstName.Text = (rad("firstname")).ToString()
                txtLastName.Text = (rad("lastname")).ToString()
                txtPhone.Text = (rad("phone")).ToString()
                txtMail.Text = (rad("e_mail")).ToString()
                txtAddress.Text = (rad("address")).ToString()
                txtZipcode.Text = (rad("zip_code")).ToString()
                txtPwd.Text = (rad("password")).ToString()
                txtConPwd.Text = txtPwd.Text
            Next
        Catch ex As MySqlException
            MsgBox(ex.Message)         'tilfelle det oppstår en feil
            connection.Close()
        Finally
            connection.Dispose()  'lukke connectionen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        End Try
    End Sub

    Public Function ConfirmPass() As Boolean
        'Validerer at innholdet i "passord" og "bekreft passord" tekstboksene er identiske
        If Not txtPwd.Text.Equals(txtConPwd.Text) Then
            Me.regerror.SetError(txtConPwd, "Passordene må være like")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtConPwd, "")
            Return True
        End If
    End Function

    Private Function ValidPass() As Boolean
        'Validerer at tekstboksen inneholder mer enn et tegn
        Dim Pass = txtPwd.Text
        If Pass.Length = 0 Then
            Me.regerror.SetError(txtPwd, "Vennligst fyll ut et passord")
            Return False
            'Validerer at tekstboksen inneholder minst 8 tegn
        ElseIf Pass.Length < 8 Then
            Me.regerror.SetError(txtPwd, "Passord må bestå av minst 8 Tegn")
            Return False
        Else
            'Om betingelser er møtt, fjern "error" og return true (godkjent) verdi
            Me.regerror.SetError(txtPwd, "")
            Return True
        End If
    End Function

    Public Sub updateData()

        If Not ConfirmPass() Then
            MsgBox(Me.regerror.GetError(txtConPwd))
        ElseIf Not ValidPass() Then
            MsgBox(Me.regerror.GetError(txtPwd))
        Else

            Try
                connection.Open()
                Dim query As String = "UPDATE User SET firstname = @firstname,lastname = @lastname,phone = @phone, e_mail = @email, address = @address, zip_code = @zipcode, password = @password where ss_number = '" & ssNumber & "'"
                cmd = New MySqlCommand(query, connection)

                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text)
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@email", txtMail.Text)
                cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@zipcode", txtZipcode.Text)
                cmd.Parameters.AddWithValue("@password", txtPwd.Text)

                reader = cmd.ExecuteReader
                confirmPwd.Hide()
                txtConPwd.Hide()
                MessageBox.Show("Data oppdatert")
                reader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                connection.Close()
            Finally
                connection.Dispose()
            End Try
        End If

    End Sub


    Public Sub showBloodData()
        Try
            '  connection.Open()
            Dim query As String = "SELECT blood_type, hb, iron_value, last_drain FROM Blood_Data WHERE ss_number='" & LogIn.txtPersonnr.Text & "'"
            cmd = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(dtable)

            For Each rad In dtable.Rows
                txtBtype.Text = (rad("blood_type")).ToString()
                txtHb.Text = (rad("hb")).ToString()
                txtIronValue.Text = (rad("iron_value")).ToString()
                txtDrain.Text = (rad("last_drain")).ToString()
            Next

        Catch ex As MySqlException
            MsgBox(ex.Message)         'tilfelle det oppstår en feil
            connection.Close()

        Finally
            connection.Dispose()  'lukke connectionen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        End Try

    End Sub

    'Public Sub getUser()

    '    connection.Open()
    '    Dim query As String = "SELECT ss_number, firstname, lastname, quarantine FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'"
    '    cmd = New MySqlCommand(query, connection)
    '    adapter = New MySqlDataAdapter
    '    adapter.SelectCommand = cmd
    '    adapter.Fill(dtable)

    '    For Each rad In dtable.Rows
    '        lblFullName.Text = (rad("firstname") & " " & rad("lastname"))
    '        lblSSnumber.Text = (rad("ss_number")).ToString()
    '        TextBox1.Text = (rad("quarantine")).ToString()
    '    Next

    'End Sub

    Private Sub UserPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        getOrderDate()

        DonorPage.Size = New Size(1550, 750)

        Me.Size = SystemInformation.PrimaryMonitorSize
        DonorPage.Location = New Point((Me.Width - DonorPage.Width) \ 2, (Me.Height - DonorPage.Height) \ 2)

        btnSignOut.Location = New Point((ClientSize.Width - btnSignOut.Width) \ 2 + 800,
                             (ClientSize.Height - btnSignOut.Height) \ 2 - 450)

        txtConPwd.Hide()
        confirmPwd.Hide()



        'Label18.Text = ssNumber

        showData()
        Dim user As New User
        user.getUser()
        showBloodData()

        'Dim showUser As New User
        'showUser.showData(txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtMail.Text, txtAddress.Text, txtZipcode.Text, txtPwd.Text)


        'Dim da As New MySqlDataAdapter
        'Dim interntabel As New DataTable
        'Dim da2 As New MySqlDataAdapter      'de 3 neste her er for å få med seg blodtypen, statisk verdi og skal linkes opp mot txtpersonnr fra form1


        'Dim intern2 As New DataTable


        '        Dim rad As DataRow   'det vil være mange forskjellige variabler i hver rad i den interne tabellen


        'Dim da3 As New MySqlDataAdapter


        'Dim intern3 As New DataTable

        'Dim da4 As New MySqlDataAdapter

        'Dim intern4 As New DataTable

        'Try
        'connection.Open()
        'Dim sqlBloodInfo As New MySqlCommand("SELECT last_Drain, hb, iron_Value FROM Blood_Data WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", connection)   'kommando med variabel til å ta imot fra DB, og connectionen
        'da.SelectCommand = sqlBloodInfo   'da(data_adapter) velger hvilken kommando som skal kjøres og "Kommanderer" de over til interntabellen med en sqlspørring hvor alt legges i variabelen fra linja over
        'da.Fill(interntabel)          'når kommandolinje er valgt og utføres, legges data inn i den internetabellen, som igjen laster rad for rad inn i textboxene

        'Dim sqltype As New MySqlCommand("SELECT blood_type FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", connection)
        'Dim sqlname As New MySqlCommand("SELECT firstname, lastname FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", connection)

        'da2.SelectCommand = sqlname
        'da2.Fill(intern2)
        'da3.SelectCommand = sqltype
        'da3.Fill(intern3)

        'Dim sqlEditInfo As New MySqlCommand("SELECT e_mail, phone, address, password, firstname, lastname FROM User WHERE ss_number='" & LogIn.txtPersonnr.Text & "'", connection)
        'da4.SelectCommand = sqlEditInfo
        'da4.Fill(intern4)

        'For Each rad In interntabel.Rows
        'txtDrain.Text = (rad("last_Drain"))
        'txtHb.Text = (rad("hb"))
        'txtIronValue.Text = (rad("iron_Value"))
        'Next


        'For Each rad In intern3.Rows
        'txtBtype.Text = (rad("blood_type"))
        'Next

        'For Each rad In intern4.Rows
        'txtFirstName.Text = (rad("firstname"))
        'txtLastName.Text = (rad("lastname"))
        'txtMail.Text = (rad("e_mail"))
        'txtPhone.Text = (rad("phone"))
        'txtAddress.Text = (rad("address"))
        'txtPwd.Text = (rad("password"))
        'txtConPwd.Text = txtPwd.Text
        'Next

        'Catch ex As MySqlException
        'MsgBox(ex.Message)        'tilfelle det oppstår en feil
        'Finally
        'connection.Dispose()      'lukke connectionen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        'End Try
#Region "pao user_load"
        'dt henter ut dagens dato + 91 dager
        'og DTPOrder (DayTimePicker) 
        Dim dt = DateTime.Now.AddDays(+91)
        Me.DTPOrder.Value = dt
        Me.DTPOrder.MinDate = dt

        Try
            connection.Open()
            ' MsgBox("connection 2 komplett")
            'Select OrderID, day, time From Calendar Where ss_number =" & lblSSN.Text & " And OrderID = (Select MAX(OrderID) From Calendar Where ss_number =" & lblSSN.Text & ")

            Dim sql As New MySqlCommand("Select cal_id, day, time From Calendar Where ss_number =" & ssNumber & " And cal_id = (Select MAX(cal_id) From Calendar Where ss_number =" & lblSSN.Text & ")", connection)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            da.SelectCommand = sql
            ' da.Fill(interntabell)
            connection.Close()

            Dim rad As DataRow
            Dim day, time, OrderID As String
            For Each rad In interntabell.Rows

                OrderID = rad("cal_id")
                day = rad("day")
                time = rad("time")

                dot = day + " " + time
                nxtApp.Text = dot
                cancel = OrderID
                can.Text = cancel
                OIDtoSSN = OrderID
            Next rad
        Catch feilmelding As MySqlException
            MsgBox("Feil ved connection til databasen fra form Cal_load:     " &
     feilmelding.Message)

            dot = " "
        Finally
            connection.Dispose()
        End Try
        '   Try
        '       connection.Open()

        '       Dim sql As New MySqlCommand("Select OrderID, day, time From Calendar Where ss_number =" & lblSSN.Text & " And OrderID = (Select MAX(OrderID) From Calendar Where ss_number =" & lblSSN.Text & ")", connection)
        '       Dim da As New MySqlDataAdapter
        '       Dim interntabell As New DataTable

        '       da.SelectCommand = sql
        '       da.Fill(interntabell)
        '       connection.Close()

        '       Dim rad As DataRow
        '       Dim day, time, OrderID As String
        '       For Each rad In interntabell.Rows

        '           OrderID = rad("OrderID")
        '           day = rad("day")
        '           time = rad("time")

        '           dot = day + " " + time
        '           nxtApp.Text = dot

        '           OIDtoSSN = OrderID
        '       Next rad
        '   Catch feilmelding As MySqlException
        '       MsgBox("Feil ved connection til databasen fra form Cal_load:     " &
        'feilmelding.Message)

        '       dot = " "
        '   Finally
        '       connection.Dispose()
        '   End Try 
#End Region
    End Sub
    Private Sub btnChangeData_Click(sender As Object, e As EventArgs) Handles btnChangeData.Click

        'Dim updateUser As New User
        'updateUser.update(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtZipcode.Text, txtPhone.Text, txtMail.Text, txtPwd.Text)

        updateData()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

        Me.Hide()
        LogIn.Show()

    End Sub

    Private Sub btnQuest_Click(sender As Object, e As EventArgs) Handles btnQuest.Click

        QuestForm.checkIfApproved()

    End Sub
#Region "pao public var"
    Public today_p90 As DateTime = DateTime.Now.AddDays(+90)
    Public Today As String = Date.Now.ToString("yyyy.MM.dd")
    Public dot As String = " "
    Public newAPP As String

    'brukes til å hente ut OrdreID som må være 0 eller over 0 for å 
    Public busy, cancel As Integer

    Public DTPFormat As String
    Public OIDtoSSN As String

    'innlogging:   g_oops_03
    'lbl = short for Label
    'bx = short for Box
    'Passord.... : mczmmM3N
    'txt = short for Text
    'LB = short for ListBox
    'App = short for appointment in regards of naming, buttons, labels in the Cal.vb
    'hist = short for history
    'Nxt = short for next
#End Region
#Region "pao Order button and sql"

    Private Sub BtnOrderApp_Click(sender As Object, e As EventArgs) Handles BtnOrderApp.Click

        Dim newDTPValue As String
        Dim DTPValue As Date
        Dim nxtTapp As String

        newAPP = DTPOrder.Text + " " + txtbxTime.Text

        ' OldAppCheck = nxtApp.Text
        Dim testCheck1 As Boolean
        Dim testcheck2 As Boolean

        'nxtApp.text lablen kan være et dato, "avbestilt" eller "ingen time satt opp"
        testCheck1 = nxtApp.Text Like "Avbestilt"
        testcheck2 = nxtApp.Text Like "Ikke satt opp"

        DTPValue = Me.DTPOrder.Value
        newDTPValue = DTPValue.ToString("yyyy.MM.dd")
        nxtTapp = today_p90.ToString("yyyy.MM.dd")

        '  Dim LastApp As String
        ' MsgBox(newDTPValue & " /" & nxtTapp)
        If nxtTapp < Today And dot <> newAPP Then
            'siste bestiling er passert 
            MsgBox("ikke gyldig time, må settes opp med over 3 måneders ventetid")
        ElseIf dot = newAPP Then
            MsgBox("du har allerede denne timen satt opp")
        ElseIf testCheck1 = False And testcheck2 = False Then
            MsgBox("time er allerede satt opp")
        ElseIf testCheck1 = True And testcheck2 = True Then
            MsgBox("noe gikk galt med sjekk etter tidligere oppsatt time")
        ElseIf nxtTapp < newDTPValue Then
            busy = 0

            Try
                '"SELECT OrderID From Calendar Where Day = '2017.10.01' And time = '08:00'"
                '"SELECT OrderID FROM Calendar Where Day= '" & DTPOrder.Text & "' And time= '" & txtbxTime.Text & "' "
                connection.Open()
                Dim sql As New MySqlCommand("SELECT cal_id FROM Calendar Where Day= '" & DTPOrder.Text & "' And time= '" & txtbxTime.Text & "' ", connection)
                Dim da As New MySqlDataAdapter
                Dim interntabell As New DataTable

                da.SelectCommand = sql
                da.Fill(interntabell)
                connection.Close()

                Dim rad As DataRow
                For Each rad In interntabell.Rows
                    busy = rad("cal_id")

                Next rad
                'msgbox vises med 0
                MsgBox(busy & " b")
            Catch feilmelding As MySqlException
                MsgBox("Feil med variabel busy   " &
feilmelding.Message)
            Finally
                connection.Dispose()
            End Try

            If busy > 1 Then
                MsgBox("timen er opptatt")

            ElseIf busy = 0 Then
                MsgBox("Not busy")

                Try
                    connection.Open()
                    Dim sporring As String
                    sporring = "Insert Into Calendar (ss_number, day, time) VALUES ('" & ssNumber & "','" & DTPOrder.Text & "', '" & txtbxTime.Text & "')"

                    Dim insertsql As New MySqlCommand(sporring, connection)
                    Dim da As New MySqlDataAdapter
                    Dim interntabell As New DataTable

                    da.SelectCommand = insertsql
                    da.Fill(interntabell)
                    connection.Close()

                    lblODate.Text = DTPOrder.Text
                    lblOTime.Text = txtbxTime.Text
                    nxtApp.Text = DTPOrder.Text + " " + txtbxTime.Text
                Catch feilmelding As MySqlException
                    MsgBox("Feil ved connection til databasen: bestilling " & feilmelding.Message)
                Finally
                    connection.Dispose()
                End Try
            End If
        End If

    End Sub

#End Region
#Region "pao Cancel Order button and sql"
    Private Sub btnCApp_Click(sender As Object, e As EventArgs) Handles btnCApp.Click
        cancel = 0

        Dim TCC1 As Boolean
        '  Dim TCC2 As Boolean

        'nxtApp.text lablen kan være et dato, "avbestilt" eller "ingen time satt opp"
        TCC1 = can.Text Like "CanCancel"
        '  testcheck2 = nxtApp.Text Like "Ingen satt opp"
        If TCC1 = False Then
            MsgBox("Ingen time satt opp")
        Else
            Try
                connection.Open()
                ' MsgBox("connection 2 komplett")
                '"Select OrderID, day, time From Calendar Where ss_number =" & lblSSN.Text & " And OrderID = (Select MAX(OrderID) From Calendar)"
                'Select * From Calendar Where OrderID = (Select MAX(OrderID) From Calendar Where ss_number =22119611122) 
                '"Select * From Calendar Where ss_number =" & lblSSN.Text & " And OrderID = (Select MAX(OrderID) From Calendar Where ss_number =" & lblSSN.Text & ")"
                Dim sql As New MySqlCommand("Select cal_id From Calendar Where cal_id = (Select MAX(cal_id) From Calendar Where ss_number =" & ssNumber & ") ", connection)
                Dim da As New MySqlDataAdapter
                Dim interntabell As New DataTable

                da.SelectCommand = sql
                da.Fill(interntabell)
                connection.Close()

                Dim rad As DataRow
                Dim calID As String
                For Each rad In interntabell.Rows

                    calID = rad("cal_id")
                    '  dot = day + " " + time
                    cancel = calID

                Next rad
            Catch feilmelding As MySqlException
                MsgBox("Feil ved connection til databasen fra form Cal_load:     " &
     feilmelding.Message)
                cancel = 0

            Finally
                connection.Dispose()
            End Try
            If cancel > 0 Then
                MsgBox("time avbestilles")
                Try
                    connection.Open()
                    ' MsgBox("connection 2 komplett")

                    'UPDATE `Calendar` SET `OrderID`='183',`ss_number`=121221229,`day`='2017-10-01',`time`='08:30' WHERE `OrderID`='183'
                    Dim sql As New MySqlCommand("UPDATE `Calendar` SET `cal_ID`='" & OIDtoSSN & "', `ss_number`='" & ssNumber & "', `day`='0000-00-00',`time`='00:00' Where cal_id ='" & OIDtoSSN & "' ", connection)
                    Dim da As New MySqlDataAdapter
                    Dim interntabell As New DataTable

                    da.SelectCommand = sql
                    da.Fill(interntabell)
                    connection.Close()

                    Dim rad As DataRow
                    Dim OrderID As String
                    For Each rad In interntabell.Rows
                        OrderID = rad("cal_id")
                        'day = rad("day")
                        'time = rad("time")
                        '   dot = day + " " + time
                        lblOTime.Text = "Avbestilt"
                        nxtApp.Text = "Avbestilt"
                    Next rad

                    MsgBox("avbestilt neste time.")
                Catch feilmelding As MySqlException
                    MsgBox("Feil ved connection til databasen fra form Cal_load:     " &
             feilmelding.Message)
                Finally
                    connection.Dispose()
                End Try
            Else
                MsgBox("Ingen time å avbestille")
            End If
        End If
    End Sub

    Private Sub txtPwd_TextChanged(sender As Object, e As EventArgs) Handles txtPwd.Click
        confirmPwd.Show()
        txtConPwd.Show()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Close()
        LogIn.Show()
    End Sub


#End Region
    Private Sub getOrderDate()

        Try
            '  connection.Open()
            Dim query As String = "SELECT day, time From Calendar Where cal_id = (Select MAX(cal_id)From Calendar Where ss_number = '" & ssNumber & "')"
            cmd = New MySqlCommand(query, connection)
            adapter = New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(dtable)

            For Each rad In dtable.Rows
                nxtApp.Text = (rad("day"))
                lblOTime.Text = (rad("time"))
            Next

        Catch ex As MySqlException
            MsgBox(ex.Message)         'tilfelle det oppstår en feil
            connection.Close()

        Finally
            connection.Dispose()  'lukke connectionen og forkaster den internedata som er blitt brukt under kjøringen av denne forma
        End Try
    End Sub
End Class
