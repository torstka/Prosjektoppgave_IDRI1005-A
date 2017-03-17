Public Class MyPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        DataMyBlood.Show()
    End Sub

<<<<<<< HEAD
    Private Sub Button2_Click(sender As Object, e As EventArgs) 

=======
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        'Calender.show()
>>>>>>> master
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        BloodInformation.show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        'PersonInfo.Show() ' forma som legger inn personalia som er lik den ved førstegangs registrering
        'for det er vel kun de data man tenker at bruker skal kunne endre???
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        'QuestionForm1.show()
    End Sub
End Class