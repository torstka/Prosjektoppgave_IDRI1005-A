Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Statistics
    Public connection As New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_03;Uid=g_oops_03;Pwd=mczmmM3N")
    Dim command As MySqlCommand
    Dim bSource As New BindingSource
    Dim interntab As New DataTable
    Dim da As New MySqlDataAdapter
    Dim da2 As New MySqlDataAdapter
    Dim intern2 As New DataTable
    Dim bSoursce2 As New BindingSource
    Dim sql = New MySqlCommand("SELECT blood_type, COUNT(*) FROM Blood_Data WHERE blood_type <> 'Ikke verdi' GROUP BY blood_type HAVING COUNT(*)>0", connection)  'sql spørring som teller alle de forskjellige blodtypene som er lagret i DB
    Dim sql2 = New MySqlCommand("SELECT gender,COUNT(*) FROM User GROUP BY gender HAVING COUNT(*)>0 ", connection)   'sql spørring som teller antallet kvinner og menn som er donorer og lagret i DB

    'Har laget en kode som automatisk laster den visuelle statistikken som ledelsen får generert når de logger seg inn og blir navigert til forma statistic.vb. Det ligger i LogIn.vb validering på hvilket brukernavn som tastes inn, er det over
    ' 2000 vet programmet at det er noen fra ledelsen og de får direkte opplysning om statistikk.
    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = SystemInformation.PrimaryMonitorSize   'her følger 3 koder for å plassere groupboxene og tilbake samt logg ut knappen riktig i forma, når den står å kjører
        GroupBox1.Location = New Point((Me.Width - GroupBox1.Width) \ 2, (Me.Height - GroupBox1.Height) \ 2)

        btnSignOut.Location = New Point((Me.Width - btnSignOut.Width) \ 2 + 525,
                             (Me.Height - btnSignOut.Height) \ 2 - 415)

        btnBack.Location = New Point((ClientSize.Width - btnBack.Width) \ 2 + 532,
                           (ClientSize.Height - btnBack.Height) \ 2 - 400)

        'Så åpnes tilkoblingen VB skal ha oppmot DB. Tilkoblingen(connection) er satt til å være en public variabel slik at den kan brukes i alle formene og de forskjellige klassene som er laget. Her står brukernavn og passord samt tjenernavn
        'på den kontoen gruppe 3 har i phpMyAdmin knyttet til dette prosjektet.
        Try
            connection.Open()


            Dim dr2 As MySqlDataReader      'deklarer en variabel som tar med seg data fra DB. VB har en innebygd metode som leser(reader) av DB basert på den sql spørringen som er deklarert under klassen statistic
            dr2 = sql2.ExecuteReader()     'dataadapter er en dirigent som forteller VB hva og hvilke jobber den skal utføre, her sier den at VB skal lese av med spørring qsl2 oppmot DB

            While (dr2.Read())
                Me.CG.Series("KJØNNSFORDELING").Points.AddXY(dr2.GetString("gender"), dr2.GetInt64("COUNT(*)"))
                'så kodes en for-løkke som håndterer den data som dataadapteren får fra DB og la Stolpediagram(Chart) om kjønnsfordeling ta seg av den innleste data og plassere den i riktige x og y verdier, bassert på sql-spørring
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)  'en sikkerhet som fanger opp evt feil, som unngår at programmet krasjer og forklarer med en message hva som skjer
        Finally
            connection.Dispose()       'videre både lukkes og forkastes den data som har eksistert mellom DB og VB mens tilkoblingen har vært åpen
        End Try
        Try
            connection.Open()

            Dim dr As MySqlDataReader           'her følger helt samme prosedyre som utføringen av sql-spørring beskrevet over, bare at det spørres etter antallet forskjellige blodtyper
            dr = sql.ExecuteReader()

            While (dr.Read())
                Me.CBType.Series("BLODTYPER").Points.AddXY(dr.GetString("blood_type"), dr.GetInt64("COUNT(*)"))
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        CBlodtype.Series.Clear()   'her nullstilles diagrammet slik at det for hver gang viser den innhentede data fra DB
        CBlodtype.Titles.Clear()   'her nullstilles også den opplysende teksten som står i margen på kakediagrammet, som speiler tallene som sql-spørringen teller, hvor mange det er av blodtype A, av blodtype B osv.

        CBlodtype.Series.Add("Blodtyper")      'Så legges den rette data til i diagrammet

        CBlodtype.Series("Blodtyper").ChartType = SeriesChartType.Pie ' først er det satt et vanlig stolpediagram som her blir deklareret som kakediagram

        CBlodtype.Series(0).LabelFormat = "{#''}"      'For å få kakediagrammet til å vise antallet av de tellte blodtypene og ikke bare speile den teksten som står, måtte det kodes inn.
        CBlodtype.Series(0).IsValueShownAsLabel = True    'det hjalp ikke å endre properties for å få frem de eksakte tallene på kakediagrammet. på lik linje som med tittelen

        Try
            connection.Open()
            'gjør klar variabler for de ulike sql setningene og for beholdningen som skal leses av fra DB ang de detaljerte blodtypevariantene
            Dim Query As String
            Dim BloodcountA As Int16 = 0
            Dim BloodcountB As Int16 = 0
            Dim BloodcountAB As Int16 = 0
            Dim BloodcountO As Int16 = 0

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'A Rh+' OR blood_type = 'A Rh-'"  'sql for å telle alle blodtypene som er A Rh+ og A Rh-
            command = New MySqlCommand(Query, connection)                                                'en ny kommando utføres og den dirigerer både hvilken sql setning som skal kjøres og at tilkoblingen også brukes for å få tilgang til DB
            BloodcountA = Convert.ToInt16(command.ExecuteScalar)                                     'her gjøres den tellte teksten om til tall, og at det spørringen har funnet samt sikkret vil bli til tall, kan den data plasseres i variabelen BloodCountA

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'B Rh+' OR blood_type = 'B Rh-'"     'videre følger helt like spørringer
            command = New MySqlCommand(Query, connection)
            BloodcountB = Convert.ToInt16(command.ExecuteScalar)

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'AB Rh+' OR blood_type = 'AB Rh-'"
            command = New MySqlCommand(Query, connection)
            BloodcountAB = Convert.ToInt16(command.ExecuteScalar)

            Query = "SELECT COUNT(*) FROM Blood_Data WHERE blood_type = 'O Rh+' OR blood_type = 'O Rh-'"
            command = New MySqlCommand(Query, connection)
            BloodcountO = Convert.ToInt16(command.ExecuteScalar)

            CBlodtype.Series("Blodtyper").Points.AddXY("A", BloodcountA)        'her legges den data som variablene har inni stolpediagrammet, har mot formodning blodbanken ikke en spesifikkt blodtype, noe de bør ha
            CBlodtype.Series("Blodtyper").Points.AddXY("B", BloodcountB)        'har ikke det noe å si for selve programmet. Det krasjer ikke, det blir bare ikke opprettet en stolpe på den typen i diagrammet.
            CBlodtype.Series("Blodtyper").Points.AddXY("AB", BloodcountAB)
            CBlodtype.Series("Blodtyper").Points.AddXY("O", BloodcountO)

            connection.Close() ' Lukker tilkobling

        Catch ex As MySqlException ' Fanger opp feil fra MySql
        End Try
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Hide()      'her lukkes statistikk forma og man kommer tilbake til LogIn.vb, altså utgangspunktet for vårt produkt Tapper`n
        LogIn.Show()
    End Sub

    Private Sub btnSBType_Click(sender As Object, e As EventArgs) Handles btnSBType.Click
        CBlodtype.Hide()       'inne i forma statistikk vises først et kakediagram, som deler blodtypene inn i de 4 hovedtypene. En knapp kan trykkes for å vise stolpediagram for mer detaljert blodtypeinfo
        btnSBType.Hide()      'derfor gjemmes kakediagrammet på .Hide() , knappen hvor man kunne velge å gå til detaljer skal også gjemmes etter at stolpe med detaljer vises, for da skal man igjen ha mulighet til å gå tilbake
        lblCPie.Hide()        'En label for å vise bruker hva de ser på når de ser kakediagrammet måtte kodes inn kun på kake. Alle chart har titel func i properties men kun på kake at den tittelen ikke vises, har ikke funnet ut hvorfor det er slik
        CBType.Show()        'så viser VB frem stolpediagrammet
        btnBTPie.Show()      'og kanppen som går tilbake til kakediagram
    End Sub

    Private Sub btnBTPie_Click(sender As Object, e As EventArgs) Handles btnBTPie.Click
        CBType.Hide()             'her er samme kommentarer som over bare den andre veien.
        btnBTPie.Hide()
        btnSBType.Show()
        CBlodtype.Show()
        lblCPie.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()             'her lukkes forma statistikk og de ansatte kommer tilbake til sin ansatteside
        EPage.Show()
    End Sub
End Class