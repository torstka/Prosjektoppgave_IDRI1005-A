Imports MySql.Data.MySqlClient
Public Class Storage
    Private tilkobling As MySqlConnection

    Private Sub Storage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        tilkobling.Open()
    End Sub

    Private Sub Storage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        tilkobling.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        EmployeePage.Show()
    End Sub

    Private Sub btnSendOrders_Click(sender As Object, e As EventArgs) Handles btnSendOrders.Click
        Dim department As String = txtDepartment.Text
        Dim orderInfo As String = txtOrderDetails.Text
        Dim todaysdate As String
        todaysdate = Today

        Try
            Dim sqlString = "INSERT INTO Order_Request (department, date, info) VALUES (@Department, @OrderDate, @OrderInfo)"
            Dim sql As New MySqlCommand(sqlString, tilkobling)

            sql.Parameters.AddWithValue("@Department", department)
            sql.Parameters.AddWithValue("@OrderDate", todaysdate)
            sql.Parameters.AddWithValue("@OrderInfo", orderInfo)
            sql.ExecuteNonQuery()

            MsgBox("Bestilling sendt", MsgBoxStyle.Information, "Vellykket")
        Catch ex As Exception
            MsgBox("FEIL ved sending", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnDiscardOrder_Click(sender As Object, e As EventArgs) Handles btnDiscardOrder.Click
        txtDepartment.Clear()
        txtOrderDetails.Clear()
    End Sub
End Class