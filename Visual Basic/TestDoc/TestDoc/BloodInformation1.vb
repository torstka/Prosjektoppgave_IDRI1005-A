Public Class BloodInformation1
    Private Sub BloodInformation1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Dim webAddress As String = "https://www.giblod.no/Home.aspx"
        Process.Start(webAddress)
    End Sub
End Class