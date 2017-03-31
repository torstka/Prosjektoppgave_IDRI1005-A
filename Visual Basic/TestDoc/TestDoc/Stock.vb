Imports MySql.Data.MySqlClient
Public Class Stock

    Dim constring As String = "Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N"
    Dim con As New MySqlConnection(constring)
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter



    Public Sub add()
        Dim donationDate As String = Today.ToString("dd/MM/yyyy")
        Dim bloodType As String = InputBox("Legg til blodtype", "Blodtype")
        Dim bloodCells As Double = InputBox("Legg til blodceller", "Blodceller")
        Dim cellsDate = Today.AddDays(35).ToString("dd/MM/yyyy")
        Dim plasma As Double = InputBox("Legg til plasma", "Plasma")
        Dim platelets As Integer = InputBox("Legg til blodplater", "Blodplater")
        Dim plateletsDate = Today.AddDays(7).ToString("dd/MM/yyyy")
        Dim ssNumber As String = "11111111111"

        Try
            con.Open()
            Dim sql As String = "INSERT INTO Donation_Stock(donation_date, blood_type, blood_cells, cells_date, plasma, platelets, platelets_date, ss_number) VALUES(@DonationDate, @BloodType, @BloodCells, @CellsDate, @Plasma, @Platelets, @PlateletsDate,@SsNumber)"

            cmd = New MySqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@DonationDate", donationDate)
            cmd.Parameters.AddWithValue("@BloodType", bloodType)
            cmd.Parameters.AddWithValue("@BloodCells", bloodCells)
            cmd.Parameters.AddWithValue("@CellsDate", cellsDate)
            cmd.Parameters.AddWithValue("@Plasma", plasma)
            cmd.Parameters.AddWithValue("@Platelets", platelets)
            cmd.Parameters.AddWithValue("@PlateletsDate", plateletsDate)
            cmd.Parameters.AddWithValue("@SsNumber", ssNumber)
            cmd.ExecuteNonQuery()

            MsgBox("Registrering vellykket", MsgBoxStyle.Information, "SUKSESS")
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        Finally
            con.Dispose()
        End Try
    End Sub



End Class
