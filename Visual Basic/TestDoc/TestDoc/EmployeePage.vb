Public Class EmployeePage
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        EmployeeLogIn.Show()
    End Sub

    Private Sub EmployeePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Ansattnummer: " & EmployeeLogIn.ansattNr
    End Sub
End Class