﻿Imports MySql.Data.MySqlClient
Public Class NewUser
    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        tilkobling.Open()


    End Sub

    Private tilkobling As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Fornavn = txtFirstname.Text
        Dim Etternavn = txtLastname.Text
        Dim Personnummer = txtPersonnr.Text
        Dim Adresse = txtAdress.Text
        Dim Postnummer = txtPostnr
        Dim Telefon = txtPostnr.Text
        Dim Epost = txtEmail.Text
        Dim Passord = txtPassword.Text


        Dim sqlSporring = "insert into Users (Etternavn, Fornavn, Personnummer, Adresse, Postnummer, Telefon, Epost, Passord) values (@Etternavn, @Fornavn, @Personnummer, @Adresse, @Postnummer, @Epost, @Telefon, @Passord)"
        Dim sql As New MySqlCommand(sqlSporring, tilkobling)

        sql.Parameters.AddWithValue("@Fornavn", Fornavn)
        sql.Parameters.AddWithValue("@Etternavn", Etternavn)
        sql.Parameters.AddWithValue("@Personnummer", Personnummer)
        sql.Parameters.AddWithValue("@Adresse", Adresse)
        sql.Parameters.AddWithValue("@Postnummer", Postnummer)
        sql.Parameters.AddWithValue("@Telefon", Telefon)
        sql.Parameters.AddWithValue("@Epost", Epost)
        sql.Parameters.AddWithValue("@Passord", Passord)

        sql.ExecuteNonQuery()

        MsgBox("Registrering vellykket")
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub


End Class