﻿Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class NewUser
    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
        tilkobling.Open()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub
    Private Function ValidFornavn() As Boolean
        Dim Fornavn = txtFirstname.Text
        If Fornavn.Length = 0 Then
            Me.ErrorProvider1.SetError(txtFirstname, "Please enter your name")
            Return False
        ElseIf Not Regex.IsMatch(Fornavn, "^[\p{L} ]+$") Then
            Me.ErrorProvider1.SetError(txtFirstname, "First name can only contain letters")
            Return False
        Else
            Me.ErrorProvider1.SetError(txtFirstname, "")
            Return True
        End If
    End Function
    Private Function ValidEtternavn() As Boolean
        Dim Etternavn = txtLastname.Text
        If Etternavn.Length = 0 Then
            Me.ErrorProvider1.SetError(txtLastname, "Please enter your last name")
            Return False
        ElseIf Not Regex.IsMatch(Etternavn, "^[\p{L} ]+$") Then
            Me.ErrorProvider1.SetError(txtLastname, "Last name can only contain digits")
            Return False
        Else
            Me.ErrorProvider1.SetError(txtLastname, "")
            Return True
        End If
    End Function
    Private Function ValidPersnr() As Boolean
        Dim persnr = txtPersonnr.Text
        If persnr.Length = 0 Then
            Me.ErrorProvider1.SetError(txtPersonnr, "Please enter birthnumber")
            Return False
        ElseIf Not persnr.Length = 11 Then
            Me.ErrorProvider1.SetError(txtPersonnr, "Birth number must be 11 characters long")
            Return False
        ElseIf Not Regex.IsMatch(persnr, "^[0-9]+$") Then
            Me.ErrorProvider1.SetError(txtPersonnr, "Birth number can only contain digits")
            Return False
        Else
            Me.ErrorProvider1.SetError(txtPersonnr, "")
            Return True
        End If
    End Function
    Private Function ValidAdresse() As Boolean
        Dim Adresse = txtAdress.Text
        If Adresse.Length = 0 Then
            Me.ErrorProvider1.SetError(txtAdress, "Please enter your address")
            Return False
        Else
            Me.ErrorProvider1.SetError(txtAdress, "")
            Return True
        End If
    End Function
    Private Function ValidTelefon() As Boolean
        Dim telefonnr = txtPhone.Text
        If telefonnr.Length = 0 Then
            Me.ErrorProvider1.SetError(txtPhone, "Please enter phone number")
            Return False
        ElseIf Not telefonnr.Length = 8 Then
            Me.ErrorProvider1.SetError(txtPhone, "Phone number must be 8 characters long")
            Return False
        ElseIf Not Regex.IsMatch(telefonnr, "^[0-9]+$") Then
            Me.ErrorProvider1.SetError(txtPhone, "Phone number can only contain digits")
            Return False
        Else
            Me.ErrorProvider1.SetError(txtPhone, "")
            Return True
        End If
    End Function
    Private Function ValidPostnr() As Boolean
        Dim Postnr = txtPostnr.Text
        If Postnr.Length = 0 Then
            Me.ErrorProvider1.SetError(txtPostnr, "Please enter post number")
            Return False
        ElseIf Not Postnr.Length = 4 Then
            Me.ErrorProvider1.SetError(txtPostnr, "Post number must be 4 characters long")
            Return False
        ElseIf Not Regex.IsMatch(Postnr, "^[0-9]+$") Then
            Me.ErrorProvider1.SetError(txtPostnr, "Post number can only contain digits")
            Return False
        Else
            Me.ErrorProvider1.SetError(txtPostnr, "")
            Return True
        End If
    End Function

    Private Function ValidEmail() As Boolean
        Dim epost = txtEmail.Text
        If epost.Length = 0 Then
            Me.ErrorProvider1.SetError(txtEmail, "Please enter email address")
            Return False
        End If
        Dim errorMessage = "E-mail address must be valid e-mail address format." + ControlChars.Cr +
            "For example 'someone@example.com' "
        Me.ErrorProvider1.SetError(txtEmail, errorMessage)
        Dim indexAt1 = epost.IndexOf("@")
        Dim indexAt2 = epost.LastIndexOf("@")
        If indexAt1 < 1 Or Not indexAt1 = indexAt2 Then
            Return False
        End If
        Dim indexDot1 = epost.IndexOf(".", indexAt1)
        Dim indexDot2 = epost.LastIndexOf(".")
        If indexDot1 <= indexAt1 + 1 Or Not indexDot2 = indexDot1 Or indexDot1 = epost.Length - 1 Then
            Return False
        End If
        Me.ErrorProvider1.SetError(txtEmail, "")
        Return True
    End Function
    Private Function ConfirmPass() As Boolean
        If Not txtPassword.Text.Equals(txtConfirmPassword.Text) Then
            Me.ErrorProvider1.SetError(txtConfirmPassword, "Passwords do not match")
            Return False
        Else
            Me.ErrorProvider1.SetError(txtConfirmPassword, "")
            Return True
        End If
    End Function
    Private Function ValidPass() As Boolean
        Dim Pass = txtPassword.Text
        If Pass.Length = 0 Then
            Me.ErrorProvider1.SetError(txtPassword, "Please enter a password")
            Return False
        ElseIf Pass.Length < 8 Then
            Me.ErrorProvider1.SetError(txtPassword, "Password must be atleast 8 characters long")
            Return False
        Else
            Me.ErrorProvider1.SetError(txtPassword, "")
            Return True
        End If
    End Function

    Private tilkobling As MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Fornavn = txtFirstname.Text
        Dim Etternavn = txtLastname.Text
        Dim Personnummer = txtPersonnr.Text
        Dim Adresse = txtAdress.Text
        Dim Postnummer = txtPostnr.Text
        Dim Telefon = txtPhone.Text
        Dim Epost = txtEmail.Text
        Dim Passord = txtPassword.Text

        If Not ValidFornavn() Then
            MsgBox(Me.ErrorProvider1.GetError(txtFirstname))
        ElseIf Not ValidEtternavn() Then
            MsgBox(Me.ErrorProvider1.GetError(txtLastname))
        ElseIf Not ValidPersnr() Then
            MsgBox(Me.ErrorProvider1.GetError(txtPersonnr))
        ElseIf Not ValidAdresse() Then
            MsgBox(Me.ErrorProvider1.GetError(txtAdress))
        ElseIf Not ValidTelefon() Then
            MsgBox(Me.ErrorProvider1.GetError(txtPhone))
        ElseIf Not ValidPostnr() Then
            MsgBox(Me.ErrorProvider1.GetError(txtPostnr))
        ElseIf Not ValidEmail() Then
            MsgBox(Me.ErrorProvider1.GetError(txtEmail))
        ElseIf Not ValidPass() Then
            MsgBox(Me.ErrorProvider1.GetError(txtPassword))
        ElseIf Not ConfirmPass() Then
            MsgBox(Me.ErrorProvider1.GetError(txtConfirmPassword))
        Else

            Dim sqlSporring = "insert into Users (Etternavn, Fornavn, Personnummer, Adresse, Postnummer, Epost, Telefon, Passord) values (@Etternavn, @Fornavn, @Personnummer, @Adresse, @Postnummer, @Epost, @Telefon, @Passord)"
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

        End If

    End Sub

End Class