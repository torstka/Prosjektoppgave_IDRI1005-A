﻿Imports MySql.Data.MySqlClient

Public Class Form1

    Private tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling.Open()
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs) Handles btbRegistrer.Click
        NewUser.Show()
        Me.Hide()
    End Sub

    Private Sub btbLogin_Click(sender As Object, e As EventArgs) Handles btbLogin.Click
        Dim personnr = txtPersonnr.Text
        Dim password = txtPassword.Text
        Dim sqlSporring = "select * from Users where Personnummer=@personnummer " &
                          "and Passord=@passord"

        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@personnummer", personnr)
        sql.Parameters.AddWithValue("@passord", password)

        Dim leser = sql.ExecuteReader()
        If leser.HasRows Then
            Logged_In.Show()
            Me.Hide()
            txtPersonnr.Clear()
            txtPassword.Clear()
        Else
            MsgBox("Innlogging misslykket")
        End If
        leser.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class
