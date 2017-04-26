Imports System.Net.Mail
Public Class MailForm
    'Henter informasjonen fra Epage
    Dim firstname As String = EPage.txtFirstname.Text
    Dim lastname As String = EPage.txtLastname.Text
    Dim mail As String = EPage.txtMail.Text
    Public lastDrain As DateTime = EPage.txtLastDrain.Text
    Private Sub MailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Her henter programmet fornavet, etternavet og epostadressen fra de globale variablene som igjen henter infoen fra Epage
        txtFirstname.Text = firstname
        txtLastname.Text = lastname
        txtEmail.Text = mail
        Me.dtMail.MinDate = lastDrain.AddDays(90) 'Plusser på 90 dager i kalenderen fra sist tapping (lastDrain)
        cbTime.SelectedIndex = 0
    End Sub
    Private Sub sendEmail() 'Subben leter etter epostadressen som er skrevet inn i tekstfeltet, og sender så fra den oppgitte adressen ut til riktig person
        Try
            Dim mail As New MailMessage()
            Dim SmtpServer As New SmtpClient
            SmtpServer.Credentials = New Net.NetworkCredential("tappernas@gmail.com", "Pannekake123")
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.EnableSsl = True
            mail.To.Add(txtEmail.Text)
            mail.From = New MailAddress("tappernas@gmail.com")
            mail.Subject = "Innkalling til blodgivning"
            mail.Body = "Hei " & txtFirstname.Text & "!" & vbCrLf & vbCrLf & "Blodbanken har følgende time til deg: " & dtMail.Value & " klokken: " & cbTime.Text & vbCrLf & "Gi beskjed dersom timen ikke passer." & vbCrLf & vbCrLf & "Med vennlig hilsen" & vbCrLf & "Blodbanken ved St.Olavs Hospital"
            SmtpServer.Send(mail)
            mail.Body = ""
            MsgBox("Innkalling sendt!", MsgBoxStyle.Information, "Sendt")
        Catch error_mail As Exception
            MsgBox("Det skjedde dessverre en teknisk feil. Dobbelsjekk at du har fyllt inn riktig informasjon, og prøv på nytt." & error_mail.Message)
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        sendEmail() 'Kaller på subben og sender ut epost til aktuell person med epostadressen som står i tekstfeltet
    End Sub
End Class
