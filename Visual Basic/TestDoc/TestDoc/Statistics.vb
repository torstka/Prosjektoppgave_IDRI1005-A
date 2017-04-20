Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Statistics
    Public tilkobling As New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
    Dim command As MySqlCommand
    Dim bSource As New BindingSource
    Dim interntab As New DataTable
    Dim da As New MySqlDataAdapter
    Dim da2 As New MySqlDataAdapter
    Dim intern2 As New DataTable
    Dim bSoursce2 As New BindingSource
    Dim sql = New MySqlCommand("SELECT blood_type, COUNT(*) FROM Blood_Data WHERE blood_type <> 'Ikke verdi' GROUP BY blood_type HAVING COUNT(*)>0", tilkobling)
    Dim sql2 = New MySqlCommand("SELECT gender,COUNT(*) FROM User GROUP BY gender HAVING COUNT(*)>0 ", tilkobling)
    Public Overrides Property AutoSize As Boolean

    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBType.Hide()

        Try
            tilkobling.Open()

            da.SelectCommand = sql
            da.Fill(interntab)
            bSource.DataSource = interntab
            dgvBloodType.DataSource = bSource
            da.Update(interntab)


            da2.SelectCommand = sql2
            da2.Fill(intern2)
            bSoursce2.DataSource = intern2
            dgvGender.DataSource = bSoursce2
            da2.Update(intern2)

            tilkobling.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            tilkobling.Dispose()
            interntab.Clear()
            intern2.Clear()
        End Try
        Try
            tilkobling.Open()

            Dim dr2 As MySqlDataReader
            dr2 = sql2.ExecuteReader()

            While (dr2.Read())
                Me.CG.Series("KJØNNSFORDELING").Points.AddXY(dr2.GetString("gender"), dr2.GetInt64("COUNT(*)"))

            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            tilkobling.Dispose()
        End Try
        Try
            tilkobling.Open()

            Dim dr As MySqlDataReader
            dr = sql.ExecuteReader()

            While (dr.Read())
                Me.CBType.Series("BLODTYPER").Points.AddXY(dr.GetString("blood_type"), dr.GetInt64("COUNT(*)"))
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            tilkobling.Dispose()
        End Try
        CBlodtype.Series.Clear()
        CBlodtype.Titles.Clear()

        CBlodtype.Series.Add("Blodtyper")

        CBlodtype.Series("Blodtyper").ChartType = SeriesChartType.Pie ' Blir deklareret som kakediagram

        CBlodtype.Series(0).LabelFormat = "{#''}"
        CBlodtype.Series(0).IsValueShownAsLabel = True

        Try
            tilkobling.Open()
            Dim Query As String
            Dim BloodcountA As Int16 = 0
            Dim BloodcountB As Int16 = 0
            Dim BloodcountAB As Int16 = 0
            Dim BloodcountO As Int16 = 0

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'A Rh+' OR blood_type = 'A Rh-'"
            command = New MySqlCommand(Query, tilkobling)
            BloodcountA = Convert.ToInt16(command.ExecuteScalar)

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'B Rh+' OR blood_type = 'B Rh-'"
            command = New MySqlCommand(Query, tilkobling)
            BloodcountB = Convert.ToInt16(command.ExecuteScalar)

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'AB Rh+' OR blood_type = 'AB Rh-'"
            command = New MySqlCommand(Query, tilkobling)
            BloodcountAB = Convert.ToInt16(command.ExecuteScalar)

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'O Rh+' OR blood_type = 'O Rh-'"
            command = New MySqlCommand(Query, tilkobling)
            BloodcountO = Convert.ToInt16(command.ExecuteScalar)

            If BloodcountA > (0) Then ' Sjekker om data er relevant for grafen
                CBlodtype.Series("Blodtyper").Points.AddXY("A", BloodcountA)
            End If

            If BloodcountB > (0) Then
                CBlodtype.Series("Blodtyper").Points.AddXY("B", BloodcountB)
            End If


            If BloodcountAB > (0) Then
                CBlodtype.Series("Blodtyper").Points.AddXY("AB", BloodcountAB)
            End If

            If BloodcountO > (0) Then
                CBlodtype.Series("Blodtyper").Points.AddXY("O", BloodcountO)
            End If

            tilkobling.Close() ' Lukker tilkobling

        Catch ex As MySqlException ' Fanger opp feil fra MySql
        End Try
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Hide()
        LogIn.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSBType.Click
        CBlodtype.Hide()
        btnSBType.Hide()
        lblCPie.Hide()
        CBType.Show()
        btnBTPie.Show()
    End Sub

    Private Sub btnBTPie_Click(sender As Object, e As EventArgs) Handles btnBTPie.Click
        CBType.Hide()
        btnBTPie.Hide()
        btnSBType.Show()
        CBlodtype.Show()
        lblCPie.Show()
    End Sub
End Class