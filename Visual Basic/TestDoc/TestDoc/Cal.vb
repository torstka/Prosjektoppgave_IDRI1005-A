Imports MySql.Data.MySqlClient
Public Class Cal
    Public sum As String
    Public today_p90d As DateTime = DateTime.Now.AddMonths(+3)
    Public Today As String = Date.Now.ToString("yyyy.MM.dd")
    ' Public td As DateTime = DateTime.Now.AddYears(-18)
    '   Public tod As DateTime = DateTime.Now.AddYears(+47)
    Public oldDateOrder As String
    Public Dot As String

    '    Public nxtApp As Integer
    Private Sub Cal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dt henter ut dagens dato + 3 måneder
        'og DTPOrder (DayTimePicker) 
        Dim dt = DateTime.Now.AddMonths(+3)
        Me.DTPOrder.Value = dt
        Me.DTPOrder.MinDate = dt

        Dim tilkobling As New MySqlConnection(
        "Server=mysql.stud.iie.ntnu.no;" _
        & "Database=g_oops_03;" _
        & "Uid=g_oops_03;" _
        & "Pwd=mczmmM3N;")

        Try
            tilkobling.Open()

            Dim sql As New MySqlCommand(" Select day, Month(day) As Month, Year(day) As Year, time FROM Calender Where p_nr ='" & lblSSN.Text & "' ", tilkobling)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            da.SelectCommand = sql
            da.Fill(interntabell)
            tilkobling.Close()

            Dim rad As DataRow
            Dim day As String 'hjelpevariabler
            Dim month As Integer
            Dim year As Integer
            For Each rad In interntabell.Rows
                day = rad("day")
                month = rad("month")
                year = rad("Year")
            Next rad

        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen fra form Cal_load:     " &
     feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try

        Try
            tilkobling.Open()
            Dim sql As New MySqlCommand("Select OrderID, day, time From Calender Where p_nr =" & lblSSN.Text & " And OrderID = (Select MAX(OrderID) From Calender)", tilkobling)
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
                LBHist.Items.Add(OrderID & vbTab & day & "- " & time)
                LBHist.Items.Add(Today)

                Dot = day + " " + time
                Label1.Text = Dot
            Next rad
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen fra form Cal_load:     " &
     feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try



        '        'innlogging:   g_oops_03
        '        'lbl = short for Label
        '        'bx = short for Box
        '        'Passord.... : mczmmM3N
        '        'txt = short for Text
        '        'LB = short for ListBox
        '        'App = short for appointment in regards of naming, buttons, labels in the Cal.vb
        '        'hist = short for history
        '        'Nxt = short for next

    End Sub

    Private Sub BtnOrderAppointment_Click(sender As Object, e As EventArgs) Handles BtnOrderApp.Click
        Dim tilkobling As New MySqlConnection(
"Server=mysql.stud.iie.ntnu.no;" _
& "Database=g_oops_03;" _
& "Uid=g_oops_03;" _
& "Pwd=mczmmM3N;")

        Dim newDTPValue As String
        Dim DTPValue As Date

        DTPValue = Me.DTPOrder.Value
        newDTPValue = DTPValue.ToString("yyyy.MM.dd")

        Dim nxtTapp As String = today_p90d.ToString("yyyy.MM.dd")

        '  Dim LastApp As String
        MsgBox(newDTPValue & " /" & nxtTapp)
        If nxtTapp < Today Then
            ' MsgBox(nxtTapp & " > " & Today)

        ElseIf nxtTapp < newDTPValue Then
            Try
                tilkobling.Open()
                'MsgBox("Alt gikk greit med å koble til databasen")
                'SELECT Count(OrderID) AS Orders From Calender Where day ='2017-08-01' And time ='08:00'
                Dim sql As New MySqlCommand("SELECT Count(OrderID) As Orders FROM Calender Where day='" & DTPOrder.Value & "' And  time ='" & txtbxTime.Text & "' ", tilkobling)
                Dim da As New MySqlDataAdapter
                Dim interntabell As New DataTable
                da.SelectCommand = sql
                da.Fill(interntabell)
                tilkobling.Close()
                Dim rad As DataRow
                Dim Orders As String
                '  MsgBox("ant. ordre")
                For Each rad In interntabell.Rows
                    Orders = rad("Orders")
                    'day = rad("day")
                    'time = rad("time")

                Next rad
                sum = Orders
                Label3.Text = sum
                MsgBox(Orders)

            Catch feilmelding As MySqlException
                MsgBox("Feil med sum   " &
feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try

            If sum >= 3 Then
                MsgBox("dato og time tatt")
            ElseIf sum <= 2 Then
                Try
                    tilkobling.Open()
                    Dim sporring As String
                    sporring = "Insert INTO Calender VALUES (' ', '" & lblSSN.Text & "', '" & DTPOrder.Text & "', '" & txtbxTime.Text & "')"

                    Dim insertsql As New MySqlCommand(sporring, tilkobling)
                    Dim da As New MySqlDataAdapter
                    Dim interntabell As New DataTable
                    da.SelectCommand = insertsql
                    da.Fill(interntabell)
                    tilkobling.Close()


                Catch feilmelding As MySqlException
                    MsgBox("Feil ved tilkobling til databasen: bestilling " & feilmelding.Message)
                Finally
                    tilkobling.Dispose()
                End Try
            End If

        End If
    End Sub

End Class