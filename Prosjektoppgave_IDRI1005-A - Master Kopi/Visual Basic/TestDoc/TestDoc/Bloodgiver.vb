Public Class Bloodgiver
    Private firstName As String      'private veraibler i klassen blodgiver, de brukes lokalt i klassen av public
    Private lastName As String   'sub addBloodGiver, som henter data og legger inn sine paramtre
    Private personalNumber As Integer
    Private adress As String
    Private emailAdress As String


    Public Sub addBloodGiver(ByRef firstname As String,
                             ByVal lastname As String,
                             ByVal persNumber As Integer,
                             ByVal adr As String,
                             ByVal mail As String)
        Me.firstName = firstname
        Me.lastName = lastname
        personalNumber = persNumber    'forskjellen på Me. og de som ikke har Me. er at variablene har IKKE samme
        Me.adress = adress           'navn, så man trenger ikke kode for å hjelpe VB med å vite hvilken variabel
        emailAdress = mail          'det er snakk om å bruke.
    End Sub

End Class
