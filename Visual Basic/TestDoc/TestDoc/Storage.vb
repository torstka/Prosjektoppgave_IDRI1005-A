Imports MySql.Data.MySqlClient
Public Class Storage
    Private connection As MySqlConnection

    Private Sub Storage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        connection.Open()
    End Sub

    Private Sub Storage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        connection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        EmployeePage.Show()
    End Sub

    Private Sub btnSendOrders_Click(sender As Object, e As EventArgs) Handles btnSendOrders.Click
        Dim todaysdate As String
        todaysdate = Today
        Dim reader As MySqlDataReader

        Try
            Dim sqlString = "INSERT INTO Order_Request (date, department, info) VALUES ('" & todaysdate & "','" & txtDepartment.Text & "','" & txtOrderDetails.Text & "')"
            Dim command As New MySqlCommand(sqlString, connection)
            reader = command.ExecuteReader()

            MsgBox("Bestilling sendt", MsgBoxStyle.Information, "Vellykket")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnDiscardOrder_Click(sender As Object, e As EventArgs) Handles btnDiscardOrder.Click
        txtDepartment.Clear()
        txtOrderDetails.Clear()
    End Sub
End Class