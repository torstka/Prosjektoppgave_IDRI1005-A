Imports MySql.Data.MySqlClient
Public Class EmployeePage
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        EmployeeLogIn.Show()
    End Sub
    Private conn As MySqlConnection
    Private connectionOK As Boolean = False

    Private Sub EmployeePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        conn = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")

        'Tester oppkoblingen
        Try
            conn.Open()
            connectionOK = True 'Forbindelsen godkjennes
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to database" &
                myerror.Message)
            connectionOK = False 'Forbindelsen godkjennes ikke
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Function Query(ByVal sql As String) As DataTable

        Dim myData As New DataTable

        Try
            conn.Open()

            Dim myCommand As New MySqlCommand
            Dim myAdapter As New MySqlDataAdapter


            myCommand.Connection = conn
            myCommand.CommandText = sql

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to database" &
                myerror.Message)
        Finally
            conn.Dispose()
        End Try

        Return myData
    End Function


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If connectionOK Then
            Query("DELETE FROM Order_Request")
            MsgBox("Bestillinger slettet", MsgBoxStyle.Information, "Slettet")
        Else
            MessageBox.Show("Tilkobling misslykket")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Storage.Show()
    End Sub

    Private Sub btnShowOrders_Click(sender As Object, e As EventArgs) Handles btnShowOrders.Click

        If connectionOK Then

            Dim myData As New DataTable
            myData = Query("SELECT * from Order_Request")

            'En tabell består av mange rader, og DataRow kan inneholde en rad
            Dim temprad As DataRow
            Dim department As String
            Dim orderDate As String
            Dim orderInfo As String 'hjelpevariabler


            'Fyller listeboksen med formatert informasjon
            ListBox1.Items.Clear() 'fjerner evt. gammel tekst i listeboks

            For Each temprad In myData.Rows
                'Hver rad har felter, som vi kan hente ut vha navnet og hermetegn
                department = temprad("department")
                orderDate = temprad("date")
                orderInfo = temprad("info")
                ListBox1.Items.Add("Avdeling: " & department & "    Dato: " & orderDate & "    Info: " & orderInfo) 'utskriften
            Next temprad
        Else
            MessageBox.Show("Tilkobling misslykket")
        End If

        If ListBox1.Items.Count < 1 Then
            MsgBox("Det finnes ingen tilgjengelige bestillinger", MsgBoxStyle.Information, "STATUS")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        UserInformation.Show()
    End Sub

End Class