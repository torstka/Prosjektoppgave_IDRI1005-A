Imports MySql.Data.MySqlClient
Public Class Cal
    Public tilkobling As New MySqlConnection(
"Server=mysql.stud.iie.ntnu.no;" _
& "Database=g_oops_03;" _
& "Uid=g_oops_03;" _
& "Pwd=mczmmM3N;")
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

    Private Sub Cal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dt henter ut dagens dato + 91 dager
        'og DTPOrder (DayTimePicker) 
        Dim dt = DateTime.Now.AddDays(+91)
        Me.DTPOrder.Value = dt
        Me.DTPOrder.MinDate = dt

        Try
            tilkobling.Open()
            ' MsgBox("tilkobling 2 komplett")
            '"Select OrderID, day, time From Calendar Where ss_number =" & lblSSN.Text & " And OrderID = (Select MAX(OrderID) From Calendar)"
            'Select * From Calendar Where OrderID = (Select MAX(OrderID) From Calendar Where ss_number =22119611122) 
            'Select OrderID, day, time From Calendar Where ss_number =" & lblSSN.Text & " And OrderID = (Select MAX(OrderID) From Calendar Where ss_number =" & lblSSN.Text & ")
            Dim sql As New MySqlCommand("Select OrderID, day, time From Calendar Where ss_number =" & lblSSN.Text & " And OrderID = (Select MAX(OrderID) From Calendar Where ss_number =" & lblSSN.Text & ")", tilkobling)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            da.SelectCommand = sql
            da.Fill(interntabell)
            tilkobling.Close()

            Dim rad As DataRow
            Dim day, time, OrderID As String
            For Each rad In interntabell.Rows

                OrderID = rad("OrderID")
                day = rad("day")
                time = rad("time")
                LBApp.Items.Add(OrderID & vbTab & day & "- " & time)
                LBApp.Items.Add(Today)

                dot = day + " " + time
                nxtApp.Text = dot
                cancel = OrderID
                can.Text = cancel
                OIDtoSSN = OrderID
            Next rad
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen fra form Cal_load:     " &
     feilmelding.Message)

            dot = " "
        Finally
            tilkobling.Dispose()
        End Try
        Try
            tilkobling.Open()

            Dim sql As New MySqlCommand("Select OrderID, day, time From Calendar Where ss_number =" & lblSSN.Text & " And OrderID = (Select MAX(OrderID) From Calendar Where ss_number =" & lblSSN.Text & ")", tilkobling)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            da.SelectCommand = sql
            da.Fill(interntabell)
            tilkobling.Close()

            Dim rad As DataRow
            Dim day, time, OrderID As String
            For Each rad In interntabell.Rows

                OrderID = rad("OrderID")
                day = rad("day")
                time = rad("time")

                dot = day + " " + time
                nxtApp.Text = dot

                OIDtoSSN = OrderID
            Next rad
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen fra form Cal_load:     " &
     feilmelding.Message)

            dot = " "
        Finally
            tilkobling.Dispose()
        End Try
    End Sub
    Private Sub BtnOrderAppointment_Click(sender As Object, e As EventArgs) Handles BtnOrderApp.Click

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
                tilkobling.Open()
                Dim sql As New MySqlCommand("SELECT OrderID FROM Calendar Where Day= '" & DTPOrder.Text & "' And time= '" & txtbxTime.Text & "' ", tilkobling)
                Dim da As New MySqlDataAdapter
                Dim interntabell As New DataTable

                da.SelectCommand = sql
                da.Fill(interntabell)
                tilkobling.Close()

                Dim rad As DataRow
                For Each rad In interntabell.Rows
                    busy = rad("OrderID")

                Next rad
                'msgbox vises med 0
                MsgBox(busy & " b")
            Catch feilmelding As MySqlException
                MsgBox("Feil med variabel busy   " &
feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try

            If busy > 1 Then
                MsgBox("timen er opptatt")

            ElseIf busy = 0 Then
                MsgBox("Not busy")

                Try
                    tilkobling.Open()
                    Dim sporring As String
                    sporring = "Insert Into Calendar VALUES (' ', '" & lblSSN.Text & "', '" & DTPOrder.Text & "', '" & txtbxTime.Text & "')"

                    Dim insertsql As New MySqlCommand(sporring, tilkobling)
                    Dim da As New MySqlDataAdapter
                    Dim interntabell As New DataTable

                    da.SelectCommand = insertsql
                    da.Fill(interntabell)
                    tilkobling.Close()

                    lblODate.Text = DTPOrder.Text
                    lblOTime.Text = txtbxTime.Text
                    nxtApp.Text = DTPOrder.Text + " " + txtbxTime.Text
                Catch feilmelding As MySqlException
                    MsgBox("Feil ved tilkobling til databasen: bestilling " & feilmelding.Message)
                Finally
                    tilkobling.Dispose()
                End Try
            End If
        End If
    End Sub



    Private Sub btnCApp_Click(sender As Object, e As EventArgs) Handles btnCApp.Click
        cancel = 0

        '  Dim TCC1 As Boolean
        '  Dim TCC2 As Boolean

        'nxtApp.text lablen kan være et dato, "avbestilt" eller "ingen time satt opp"
        ' TCC1 = can.Text Like "CanCancel"
        '  testcheck2 = nxtApp.Text Like "Ingen satt opp"
        Try
            tilkobling.Open()
            ' MsgBox("tilkobling 2 komplett")
            '"Select OrderID, day, time From Calendar Where ss_number =" & lblSSN.Text & " And OrderID = (Select MAX(OrderID) From Calendar)"
            'Select * From Calendar Where OrderID = (Select MAX(OrderID) From Calendar Where ss_number =22119611122) 
            '"Select * From Calendar Where ss_number =" & lblSSN.Text & " And OrderID = (Select MAX(OrderID) From Calendar Where ss_number =" & lblSSN.Text & ")"
            Dim sql As New MySqlCommand("Select OrderId From Calendar Where OrderID = (Select MAX(OrderID) From Calendar Where ss_number =22119611122) ", tilkobling)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            da.SelectCommand = sql
            da.Fill(interntabell)
            tilkobling.Close()

            Dim rad As DataRow
            Dim OrderID As String
            For Each rad In interntabell.Rows

                OrderID = rad("OrderID")
                '  dot = day + " " + time
                cancel = OrderID

            Next rad
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen fra form Cal_load:     " &
     feilmelding.Message)
            cancel = 0

        Finally
            tilkobling.Dispose()
        End Try
        ' If busy > 0 Then
        ' MsgBox("Ingen time å avbestille")

        If cancel > 0 Then
            MsgBox("time avbestilles")
            Try
                tilkobling.Open()
                ' MsgBox("tilkobling 2 komplett")

                'UPDATE `Calendar` SET `OrderID`='183',`ss_number`=121221229,`day`='2017-10-01',`time`='08:30' WHERE `OrderID`='183'
                Dim sql As New MySqlCommand("UPDATE `Calendar` SET `OrderID`='" & OIDtoSSN & "', `ss_number`='" & lblSSN.Text & "', `day`='0000-00-00',`time`='00:00' Where OrderID ='" & OIDtoSSN & "' ", tilkobling)
                Dim da As New MySqlDataAdapter
                Dim interntabell As New DataTable

                da.SelectCommand = sql
                da.Fill(interntabell)
                tilkobling.Close()

                Dim rad As DataRow
                Dim day, time, OrderID As String
                For Each rad In interntabell.Rows
                    OrderID = rad("OrderID")
                    'day = rad("day")
                    'time = rad("time")

                    '   dot = day + " " + time

                    lblOTime.Text = "Avbestilt"
                    nxtApp.Text = "Avbestilt"
                Next rad

                MsgBox("avbestilt neste time.")
            Catch feilmelding As MySqlException
                MsgBox("Feil ved tilkobling til databasen fra form Cal_load:     " &
         feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try
        Else
            MsgBox("Ingen time å avbestille")
        End If
    End Sub
End Class