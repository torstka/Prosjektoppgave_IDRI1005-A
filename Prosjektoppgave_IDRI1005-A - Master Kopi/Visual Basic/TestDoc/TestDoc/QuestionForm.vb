Imports MySql.Data.MySqlClient
Public Class QuestionForm
    Private oppkobling As New MySqlConnection
    Private connstring As String

    Private Sub QuestionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Sporring("CREATE TABLE Person(Id int, Fornavn char(25), Etternavn char(25), Epost varchar(25))")
        Sporring("INSERT INTO Person(Fornavn, Etternavn, Epost) VALUES('Svend', 'Horgen', 'svend@gmail.com')")
        'Sporring("INSERT INTO Person(Id, Fornavn, Etternavn, Epost) VALUES(2, 'Regine', 'Kvernelv', 'regine@gmail.com')")
        'Sporring("INSERT INTO Person(Id, Fornavn, Etternavn, Epost) VALUES(3, 'Emilie', 'Ytterli', 'emiliey@hotmail.com')")
        'Sporring("INSERT INTO Person(Id, Fornavn, Etternavn, Epost) VALUES(4, 'Nora', 'Lervik', 'nora@hotmail.com')")
        'Sporring("INSERT INTO Person(Id, Fornavn, Etternavn, Epost) VALUES(5, 'Emilie', 'Gjerde', 'emilieg@gmail.com')")
        'Sjekk med msgbox for å sjekke at spørringene blir riktig
        ' For ikke å endre på id: Skrive  på idm AUTO_INCREMENT
    End Sub
End Class