Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Form1

    'Kan være lurt å lagre server, database, brukernavn og passord som globale variabler
    'Dette gjør at vi kan gjenbruke denne informasjonen så lenge programmet kjører
    Private server As String
    Private database As String
    Private username As String
    Private password As String
    Private connstring As String

    'Forbindelsen settes til OK først dersom server, database, brukernavn og passord er riktig
    Private connectionOK As Boolean = False
    Private conn As New MySqlConnection

    'Dette kjøres når login vinduet kommer opp
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox3.PasswordChar = "*"
    End Sub


    'Login knapp lagrer server, database, brukernavn og passord til globale variabler
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        server = TextBox1.Text
        database = TextBox2.Text
        username = TextBox2.Text
        password = TextBox3.Text

        connstring = "Server=" & TextBox1.Text & ";" _
            & "Database=" & TextBox2.Text & ";" _
            & "Uid=" & TextBox2.Text & ";" _
            & "Pwd=" & TextBox3.Text & ";"

        'Database er her samme som brukernavn

        conn.ConnectionString = connstring

        'Tester oppkoblingen
        Try
            conn.Open()
            MessageBox.Show("Connection opened successfully")
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

    'Cancel knapp avslutter programmet
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    ' ------------------------------
    'Legger inn data i databasen
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If connectionOK Then
            Query("INSERT INTO Person (Person_Id, Person_Fornavn, Person_Etternavn) VALUES (500,'Ole','Jensen')")
        Else
            MessageBox.Show("Connection is not OK - Login properly")
        End If
    End Sub

    'Kjører en spørring mot Person tabellen ved å bruke funksjonen Query
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If connectionOK Then

            Dim myData As New DataTable
            myData = Query("SELECT * from Person")

            'En tabell består av mange rader, og DataRow kan inneholde en rad
            Dim temprad As DataRow
            Dim pid, fornavn, etternavn As String  'hjelpevariabler

            'Fyller listeboksen med formatert informasjon
            ListBox1.Items.Clear() 'fjerner evt. gammel tekst i listeboks

            For Each temprad In myData.Rows
                'Hver rad har felter, som vi kan hente ut vha navnet og hermetegn
                pid = temprad("Person_Id")
                fornavn = temprad("Person_Fornavn")
                etternavn = temprad("Person_Etternavn")
                ListBox1.Items.Add(pid & " " & fornavn & " " & etternavn) 'utskriften
            Next temprad
        Else
            MessageBox.Show("Connection is not OK - Login properly")
        End If
    End Sub

    'Sletter data i databasen
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If connectionOK Then
            Query("DELETE FROM Person WHERE Person_Id = 500")
        Else
            MessageBox.Show("Connection is not OK - Login properly")
        End If
    End Sub

    Private Function Query(ByVal sql As String) As DataTable

        Dim myData As New DataTable

        Try
            conn.Open()

            Dim myCommand As New MySqlCommand
            Dim myAdapter As New MySqlDataAdapter


            Dim kommando As New MySqlCommand(sql, conn)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = kommando
            da.Fill(myData)

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to database" &
                myerror.Message)
        Finally
            conn.Dispose()
        End Try

        Return myData
    End Function

    'Oppretter tabellen Person og legger inn eksempeldata
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If connectionOK Then
            Query("CREATE TABLE Person (Person_Id int, Person_Fornavn char(25), Person_Etternavn char(25))")
            Query("INSERT INTO Person (Person_Id, Person_Fornavn, Person_Etternavn) VALUES (1,'Svend','Horgen')")
            Query("INSERT INTO Person (Person_Id, Person_Fornavn, Person_Etternavn) VALUES (2,'Kari','Jensen')")
            Query("INSERT INTO Person (Person_Id, Person_Fornavn, Person_Etternavn) VALUES (3,'Rune','Olsen')")
            Query("INSERT INTO Person (Person_Id, Person_Fornavn, Person_Etternavn) VALUES (4,'Birger','Svendsen')")
            Query("INSERT INTO Person (Person_Id, Person_Fornavn, Person_Etternavn) VALUES (5,'Lars','Hansen')")
        Else
            MessageBox.Show("Connection is not OK - Login properly")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If connectionOK Then
            Query("DROP TABLE Person")
        Else
            MessageBox.Show("Connection is not OK - Login properly")
        End If
    End Sub

End Class
