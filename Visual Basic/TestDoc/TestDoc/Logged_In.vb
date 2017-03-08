Public Class Logged_In


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide() 'her lukkes forma "innlogget" og tar bruker til forma "spørreskjemaet(questionForm)" 
        'QuestionForm.Show()
    End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide() 'samme skjer her at "innlogget" lukkes og forma "MyPage" åpnes
        MyPage.Show()


        End Sub
    End Class

