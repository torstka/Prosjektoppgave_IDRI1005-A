<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserPage))
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.regerror = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InfoPage = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChangeData = New System.Windows.Forms.TabPage()
        Me.Changeuserinfo = New System.Windows.Forms.GroupBox()
        Me.FName = New System.Windows.Forms.Label()
        Me.btnChangeData = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtConPwd = New System.Windows.Forms.TextBox()
        Me.txtZipcode = New System.Windows.Forms.TextBox()
        Me.confirmPwd = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.Label()
        Me.zipcode = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.Label()
        Me.pwd = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.mail = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.Label()
        Me.MyPage = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblVelgTime = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblLastDrain = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnCApp = New System.Windows.Forms.Button()
        Me.lblnxtApp = New System.Windows.Forms.Label()
        Me.DTPOrder = New System.Windows.Forms.DateTimePicker()
        Me.txtbxTime = New System.Windows.Forms.ComboBox()
        Me.btnOrderApp = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gbBlood = New System.Windows.Forms.GroupBox()
        Me.btnUpdateQuarantine = New System.Windows.Forms.Button()
        Me.lblquarantine = New System.Windows.Forms.Label()
        Me.txtQuarantine = New System.Windows.Forms.TextBox()
        Me.txtBtype = New System.Windows.Forms.TextBox()
        Me.ironValue = New System.Windows.Forms.Label()
        Me.txtIronValue = New System.Windows.Forms.TextBox()
        Me.hb = New System.Windows.Forms.Label()
        Me.txtDrain = New System.Windows.Forms.TextBox()
        Me.lastDrain = New System.Windows.Forms.Label()
        Me.txtHb = New System.Windows.Forms.TextBox()
        Me.bloodType = New System.Windows.Forms.Label()
        Me.lblSSnumber = New System.Windows.Forms.Label()
        Me.btnQuest = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.DonorPage = New System.Windows.Forms.TabControl()
        Me.btnSignOut = New System.Windows.Forms.Button()
        CType(Me.regerror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoPage.SuspendLayout()
        Me.ChangeData.SuspendLayout()
        Me.Changeuserinfo.SuspendLayout()
        Me.MyPage.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gbBlood.SuspendLayout()
        Me.DonorPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(2343, 18)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(133, 38)
        Me.btnLogOut.TabIndex = 8
        Me.btnLogOut.Text = "Logg Ut"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'regerror
        '
        Me.regerror.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TestDoc.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'InfoPage
        '
        Me.InfoPage.AutoScroll = True
        Me.InfoPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InfoPage.Controls.Add(Me.LinkLabel1)
        Me.InfoPage.Controls.Add(Me.Label17)
        Me.InfoPage.Controls.Add(Me.Label16)
        Me.InfoPage.Controls.Add(Me.Label15)
        Me.InfoPage.Controls.Add(Me.Label14)
        Me.InfoPage.Controls.Add(Me.Label13)
        Me.InfoPage.Controls.Add(Me.Label12)
        Me.InfoPage.Controls.Add(Me.Label11)
        Me.InfoPage.Controls.Add(Me.Label10)
        Me.InfoPage.Controls.Add(Me.Label9)
        Me.InfoPage.Controls.Add(Me.Label8)
        Me.InfoPage.Controls.Add(Me.Label7)
        Me.InfoPage.Controls.Add(Me.Label6)
        Me.InfoPage.Controls.Add(Me.Label5)
        Me.InfoPage.Controls.Add(Me.Label4)
        Me.InfoPage.Controls.Add(Me.Label3)
        Me.InfoPage.Controls.Add(Me.Label2)
        Me.InfoPage.Location = New System.Drawing.Point(4, 79)
        Me.InfoPage.Margin = New System.Windows.Forms.Padding(2)
        Me.InfoPage.Name = "InfoPage"
        Me.InfoPage.Padding = New System.Windows.Forms.Padding(2)
        Me.InfoPage.Size = New System.Drawing.Size(1542, 715)
        Me.InfoPage.TabIndex = 3
        Me.InfoPage.Text = "Kriterier for blodgivning"
        Me.InfoPage.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(952, 614)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(221, 21)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://giblod.no/default.aspx"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(616, 633)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(479, 21)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "eller ta kontakt med de ansatte ved blodbanken for øvrige spørsmål"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(549, 614)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(410, 21)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Vil du ha mer informasjon om blodgivning, kan du besøke"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Gainsboro
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(323, 556)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(852, 42)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = resources.GetString("Label15.Text")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(323, 515)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(555, 42)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "• Personer som har oppholdt seg i over 5 år til sammen i Afrika syd for Sahara " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "         (dvs. gjelder ikke Egypt, Libya, Tunis, Algerie eller Marokko)."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Gainsboro
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(323, 470)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(924, 42)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = resources.GetString("Label13.Text")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(323, 428)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(669, 42)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "• Personer som har oppholdt seg i Storbritannia i over 1 år til sammen i perioden" &
    " 1980 – 1996 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         eller har fått blodoverføring der etter 1980."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Gainsboro
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(323, 382)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(900, 42)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = resources.GetString("Label11.Text")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(323, 319)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(906, 63)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(323, 256)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(963, 63)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(323, 214)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(937, 42)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "• Menn som har eller har hatt sex med menn. Kvinner som har eller har hatt seksue" &
    "ll kontakt med menn som har hatt sex med menn, " & Global.Microsoft.VisualBasic.ChrW(10) & "       får minimum 6 måneders ka" &
    "rantene etter siste seksuelle kontakt."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(323, 169)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(884, 42)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(323, 127)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(800, 42)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "• Personer som bruker medikamenter fast. Viktige unntak er p-piller, allergimedis" &
    "in og midler mot lavt stoffskifte. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Utover dette er det behov for indivi" &
    "duell vurdering av fagpersonell."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(323, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "• Personer som veier under 50 kg."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(323, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(808, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "• Personer under 18 år. Øvre aldersgrense for nye givere varierer, noen blodbanke" &
    "r praktiserer 60 år, de fleste 65 år."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(591, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "• Personer som ikke er friske. Avhengig av sykdom vurderes permanent utelukkelse." &
    ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(574, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Følgende personer kan ikke gi blod"
        '
        'ChangeData
        '
        Me.ChangeData.Controls.Add(Me.Changeuserinfo)
        Me.ChangeData.Location = New System.Drawing.Point(4, 79)
        Me.ChangeData.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangeData.Name = "ChangeData"
        Me.ChangeData.Padding = New System.Windows.Forms.Padding(2)
        Me.ChangeData.Size = New System.Drawing.Size(1542, 715)
        Me.ChangeData.TabIndex = 2
        Me.ChangeData.Text = "Endre personopplysninger"
        Me.ChangeData.UseVisualStyleBackColor = True
        '
        'Changeuserinfo
        '
        Me.Changeuserinfo.Controls.Add(Me.FName)
        Me.Changeuserinfo.Controls.Add(Me.btnChangeData)
        Me.Changeuserinfo.Controls.Add(Me.txtFirstName)
        Me.Changeuserinfo.Controls.Add(Me.txtConPwd)
        Me.Changeuserinfo.Controls.Add(Me.txtZipcode)
        Me.Changeuserinfo.Controls.Add(Me.confirmPwd)
        Me.Changeuserinfo.Controls.Add(Me.lastname)
        Me.Changeuserinfo.Controls.Add(Me.zipcode)
        Me.Changeuserinfo.Controls.Add(Me.txtPwd)
        Me.Changeuserinfo.Controls.Add(Me.address)
        Me.Changeuserinfo.Controls.Add(Me.pwd)
        Me.Changeuserinfo.Controls.Add(Me.txtMail)
        Me.Changeuserinfo.Controls.Add(Me.txtLastName)
        Me.Changeuserinfo.Controls.Add(Me.txtPhone)
        Me.Changeuserinfo.Controls.Add(Me.mail)
        Me.Changeuserinfo.Controls.Add(Me.txtAddress)
        Me.Changeuserinfo.Controls.Add(Me.phone)
        Me.Changeuserinfo.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Changeuserinfo.Location = New System.Drawing.Point(444, 23)
        Me.Changeuserinfo.Name = "Changeuserinfo"
        Me.Changeuserinfo.Size = New System.Drawing.Size(754, 615)
        Me.Changeuserinfo.TabIndex = 20
        Me.Changeuserinfo.TabStop = False
        Me.Changeuserinfo.Text = "Endre Personopplysninger"
        '
        'FName
        '
        Me.FName.AutoSize = True
        Me.FName.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName.Location = New System.Drawing.Point(66, 56)
        Me.FName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(103, 33)
        Me.FName.TabIndex = 15
        Me.FName.Text = "Fornavn"
        '
        'btnChangeData
        '
        Me.btnChangeData.Location = New System.Drawing.Point(339, 545)
        Me.btnChangeData.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChangeData.Name = "btnChangeData"
        Me.btnChangeData.Size = New System.Drawing.Size(111, 52)
        Me.btnChangeData.TabIndex = 9
        Me.btnChangeData.Text = "Lagre"
        Me.btnChangeData.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(284, 51)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(378, 40)
        Me.txtFirstName.TabIndex = 1
        '
        'txtConPwd
        '
        Me.txtConPwd.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConPwd.Location = New System.Drawing.Point(284, 490)
        Me.txtConPwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConPwd.Name = "txtConPwd"
        Me.txtConPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPwd.Size = New System.Drawing.Size(381, 40)
        Me.txtConPwd.TabIndex = 8
        Me.txtConPwd.UseSystemPasswordChar = True
        '
        'txtZipcode
        '
        Me.txtZipcode.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipcode.Location = New System.Drawing.Point(284, 241)
        Me.txtZipcode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(378, 40)
        Me.txtZipcode.TabIndex = 4
        '
        'confirmPwd
        '
        Me.confirmPwd.AutoSize = True
        Me.confirmPwd.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPwd.Location = New System.Drawing.Point(66, 496)
        Me.confirmPwd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.confirmPwd.Name = "confirmPwd"
        Me.confirmPwd.Size = New System.Drawing.Size(185, 33)
        Me.confirmPwd.TabIndex = 13
        Me.confirmPwd.Text = "Bekreft Passord"
        '
        'lastname
        '
        Me.lastname.AutoSize = True
        Me.lastname.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.Location = New System.Drawing.Point(66, 118)
        Me.lastname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(120, 33)
        Me.lastname.TabIndex = 1
        Me.lastname.Text = "Etternavn"
        '
        'zipcode
        '
        Me.zipcode.AutoSize = True
        Me.zipcode.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zipcode.Location = New System.Drawing.Point(66, 244)
        Me.zipcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.zipcode.Name = "zipcode"
        Me.zipcode.Size = New System.Drawing.Size(156, 33)
        Me.zipcode.TabIndex = 17
        Me.zipcode.Text = "Postnummer"
        '
        'txtPwd
        '
        Me.txtPwd.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.Location = New System.Drawing.Point(284, 430)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(381, 40)
        Me.txtPwd.TabIndex = 7
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(66, 180)
        Me.address.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(102, 33)
        Me.address.TabIndex = 2
        Me.address.Text = "Adresse"
        '
        'pwd
        '
        Me.pwd.AutoSize = True
        Me.pwd.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd.Location = New System.Drawing.Point(66, 436)
        Me.pwd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(100, 33)
        Me.pwd.TabIndex = 5
        Me.pwd.Text = "Passord"
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(284, 368)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(381, 40)
        Me.txtMail.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(284, 114)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(378, 40)
        Me.txtLastName.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(284, 305)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(378, 40)
        Me.txtPhone.TabIndex = 5
        '
        'mail
        '
        Me.mail.AutoSize = True
        Me.mail.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail.Location = New System.Drawing.Point(66, 374)
        Me.mail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(84, 33)
        Me.mail.TabIndex = 4
        Me.mail.Text = "E-post"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(284, 177)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(378, 40)
        Me.txtAddress.TabIndex = 3
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone.Location = New System.Drawing.Point(64, 311)
        Me.phone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(187, 33)
        Me.phone.TabIndex = 3
        Me.phone.Text = "Telefonnummer"
        '
        'MyPage
        '
        Me.MyPage.Controls.Add(Me.GroupBox6)
        Me.MyPage.Controls.Add(Me.Label20)
        Me.MyPage.Controls.Add(Me.gbBlood)
        Me.MyPage.Controls.Add(Me.lblSSnumber)
        Me.MyPage.Controls.Add(Me.btnQuest)
        Me.MyPage.Controls.Add(Me.lblFullName)
        Me.MyPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyPage.Location = New System.Drawing.Point(4, 79)
        Me.MyPage.Margin = New System.Windows.Forms.Padding(2)
        Me.MyPage.Name = "MyPage"
        Me.MyPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MyPage.Size = New System.Drawing.Size(1542, 715)
        Me.MyPage.TabIndex = 0
        Me.MyPage.Text = "Min side"
        Me.MyPage.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblVelgTime)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.lblLastDrain)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.btnCApp)
        Me.GroupBox6.Controls.Add(Me.lblnxtApp)
        Me.GroupBox6.Controls.Add(Me.DTPOrder)
        Me.GroupBox6.Controls.Add(Me.txtbxTime)
        Me.GroupBox6.Controls.Add(Me.btnOrderApp)
        Me.GroupBox6.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(989, 146)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(443, 374)
        Me.GroupBox6.TabIndex = 99
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Timebestilling"
        '
        'lblVelgTime
        '
        Me.lblVelgTime.AutoSize = True
        Me.lblVelgTime.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelgTime.Location = New System.Drawing.Point(33, 142)
        Me.lblVelgTime.Name = "lblVelgTime"
        Me.lblVelgTime.Size = New System.Drawing.Size(103, 26)
        Me.lblVelgTime.TabIndex = 101
        Me.lblVelgTime.Text = "Velg time: "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(33, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(118, 26)
        Me.Label23.TabIndex = 100
        Me.Label23.Text = "Sist tapping:"
        '
        'lblLastDrain
        '
        Me.lblLastDrain.AutoSize = True
        Me.lblLastDrain.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastDrain.Location = New System.Drawing.Point(168, 74)
        Me.lblLastDrain.Name = "lblLastDrain"
        Me.lblLastDrain.Size = New System.Drawing.Size(18, 26)
        Me.lblLastDrain.TabIndex = 99
        Me.lblLastDrain.Text = "-"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(33, 226)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(111, 26)
        Me.Label24.TabIndex = 94
        Me.Label24.Text = "Neste time:"
        '
        'btnCApp
        '
        Me.btnCApp.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCApp.Location = New System.Drawing.Point(251, 289)
        Me.btnCApp.Name = "btnCApp"
        Me.btnCApp.Size = New System.Drawing.Size(129, 52)
        Me.btnCApp.TabIndex = 73
        Me.btnCApp.Text = "Avbestill"
        Me.btnCApp.UseVisualStyleBackColor = True
        '
        'lblnxtApp
        '
        Me.lblnxtApp.AutoSize = True
        Me.lblnxtApp.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnxtApp.Location = New System.Drawing.Point(168, 226)
        Me.lblnxtApp.Name = "lblnxtApp"
        Me.lblnxtApp.Size = New System.Drawing.Size(120, 26)
        Me.lblnxtApp.TabIndex = 92
        Me.lblnxtApp.Text = "Ikke satt opp"
        '
        'DTPOrder
        '
        Me.DTPOrder.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPOrder.CustomFormat = "yyyy/MM/dd"
        Me.DTPOrder.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTPOrder.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPOrder.Location = New System.Drawing.Point(173, 137)
        Me.DTPOrder.MaxDate = New Date(3017, 12, 31, 0, 0, 0, 0)
        Me.DTPOrder.MinDate = New Date(2017, 3, 1, 0, 0, 0, 0)
        Me.DTPOrder.Name = "DTPOrder"
        Me.DTPOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPOrder.Size = New System.Drawing.Size(149, 33)
        Me.DTPOrder.TabIndex = 58
        Me.DTPOrder.Value = New Date(2017, 3, 24, 0, 0, 0, 0)
        '
        'txtbxTime
        '
        Me.txtbxTime.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTime.FormattingEnabled = True
        Me.txtbxTime.Items.AddRange(New Object() {"07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30"})
        Me.txtbxTime.Location = New System.Drawing.Point(328, 137)
        Me.txtbxTime.MaxDropDownItems = 12
        Me.txtbxTime.Name = "txtbxTime"
        Me.txtbxTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtbxTime.Size = New System.Drawing.Size(87, 34)
        Me.txtbxTime.TabIndex = 69
        Me.txtbxTime.Text = "08:00"
        '
        'btnOrderApp
        '
        Me.btnOrderApp.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderApp.Location = New System.Drawing.Point(63, 289)
        Me.btnOrderApp.Name = "btnOrderApp"
        Me.btnOrderApp.Size = New System.Drawing.Size(138, 52)
        Me.btnOrderApp.TabIndex = 62
        Me.btnOrderApp.Text = "Bestill Time"
        Me.btnOrderApp.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AllowDrop = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(590, 159)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(340, 109)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Fyll alltid ut spørreskjemaet før du gir blod. Det må være tre måneder siden forr" &
    "ige blodgivning."
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbBlood
        '
        Me.gbBlood.Controls.Add(Me.btnUpdateQuarantine)
        Me.gbBlood.Controls.Add(Me.lblquarantine)
        Me.gbBlood.Controls.Add(Me.txtQuarantine)
        Me.gbBlood.Controls.Add(Me.txtBtype)
        Me.gbBlood.Controls.Add(Me.ironValue)
        Me.gbBlood.Controls.Add(Me.txtIronValue)
        Me.gbBlood.Controls.Add(Me.hb)
        Me.gbBlood.Controls.Add(Me.txtDrain)
        Me.gbBlood.Controls.Add(Me.lastDrain)
        Me.gbBlood.Controls.Add(Me.txtHb)
        Me.gbBlood.Controls.Add(Me.bloodType)
        Me.gbBlood.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBlood.Location = New System.Drawing.Point(85, 142)
        Me.gbBlood.Margin = New System.Windows.Forms.Padding(2)
        Me.gbBlood.Name = "gbBlood"
        Me.gbBlood.Padding = New System.Windows.Forms.Padding(2)
        Me.gbBlood.Size = New System.Drawing.Size(442, 378)
        Me.gbBlood.TabIndex = 13
        Me.gbBlood.TabStop = False
        Me.gbBlood.Text = "Mine bloddata"
        '
        'btnUpdateQuarantine
        '
        Me.btnUpdateQuarantine.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateQuarantine.Location = New System.Drawing.Point(151, 333)
        Me.btnUpdateQuarantine.Name = "btnUpdateQuarantine"
        Me.btnUpdateQuarantine.Size = New System.Drawing.Size(126, 40)
        Me.btnUpdateQuarantine.TabIndex = 15
        Me.btnUpdateQuarantine.Text = "Oppdater"
        Me.btnUpdateQuarantine.UseVisualStyleBackColor = True
        '
        'lblquarantine
        '
        Me.lblquarantine.AutoSize = True
        Me.lblquarantine.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquarantine.Location = New System.Drawing.Point(39, 278)
        Me.lblquarantine.Name = "lblquarantine"
        Me.lblquarantine.Size = New System.Drawing.Size(101, 24)
        Me.lblquarantine.TabIndex = 14
        Me.lblquarantine.Text = "Karantene:"
        '
        'txtQuarantine
        '
        Me.txtQuarantine.Enabled = False
        Me.txtQuarantine.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuarantine.Location = New System.Drawing.Point(220, 268)
        Me.txtQuarantine.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQuarantine.Name = "txtQuarantine"
        Me.txtQuarantine.Size = New System.Drawing.Size(176, 32)
        Me.txtQuarantine.TabIndex = 13
        '
        'txtBtype
        '
        Me.txtBtype.Enabled = False
        Me.txtBtype.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBtype.Location = New System.Drawing.Point(220, 45)
        Me.txtBtype.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBtype.Name = "txtBtype"
        Me.txtBtype.Size = New System.Drawing.Size(176, 33)
        Me.txtBtype.TabIndex = 9
        '
        'ironValue
        '
        Me.ironValue.AutoSize = True
        Me.ironValue.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ironValue.Location = New System.Drawing.Point(38, 222)
        Me.ironValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ironValue.Name = "ironValue"
        Me.ironValue.Size = New System.Drawing.Size(95, 26)
        Me.ironValue.TabIndex = 8
        Me.ironValue.Text = "Jernlager:"
        '
        'txtIronValue
        '
        Me.txtIronValue.Enabled = False
        Me.txtIronValue.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIronValue.Location = New System.Drawing.Point(220, 217)
        Me.txtIronValue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIronValue.Name = "txtIronValue"
        Me.txtIronValue.Size = New System.Drawing.Size(176, 33)
        Me.txtIronValue.TabIndex = 12
        '
        'hb
        '
        Me.hb.AutoSize = True
        Me.hb.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hb.Location = New System.Drawing.Point(38, 164)
        Me.hb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hb.Name = "hb"
        Me.hb.Size = New System.Drawing.Size(122, 26)
        Me.hb.TabIndex = 7
        Me.hb.Text = "Hemoglobin:"
        '
        'txtDrain
        '
        Me.txtDrain.Enabled = False
        Me.txtDrain.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrain.Location = New System.Drawing.Point(220, 102)
        Me.txtDrain.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDrain.Name = "txtDrain"
        Me.txtDrain.Size = New System.Drawing.Size(176, 33)
        Me.txtDrain.TabIndex = 10
        '
        'lastDrain
        '
        Me.lastDrain.AutoSize = True
        Me.lastDrain.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastDrain.Location = New System.Drawing.Point(38, 107)
        Me.lastDrain.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lastDrain.Name = "lastDrain"
        Me.lastDrain.Size = New System.Drawing.Size(128, 26)
        Me.lastDrain.TabIndex = 6
        Me.lastDrain.Text = "Siste tapping:"
        '
        'txtHb
        '
        Me.txtHb.Enabled = False
        Me.txtHb.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHb.Location = New System.Drawing.Point(220, 159)
        Me.txtHb.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHb.Name = "txtHb"
        Me.txtHb.Size = New System.Drawing.Size(176, 33)
        Me.txtHb.TabIndex = 11
        '
        'bloodType
        '
        Me.bloodType.AutoSize = True
        Me.bloodType.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bloodType.Location = New System.Drawing.Point(38, 50)
        Me.bloodType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bloodType.Name = "bloodType"
        Me.bloodType.Size = New System.Drawing.Size(150, 26)
        Me.bloodType.TabIndex = 5
        Me.bloodType.Text = "Din blodtype er:"
        '
        'lblSSnumber
        '
        Me.lblSSnumber.AutoSize = True
        Me.lblSSnumber.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSnumber.Location = New System.Drawing.Point(80, 75)
        Me.lblSSnumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSSnumber.Name = "lblSSnumber"
        Me.lblSSnumber.Size = New System.Drawing.Size(0, 29)
        Me.lblSSnumber.TabIndex = 4
        '
        'btnQuest
        '
        Me.btnQuest.AllowDrop = True
        Me.btnQuest.BackColor = System.Drawing.Color.LightBlue
        Me.btnQuest.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuest.Location = New System.Drawing.Point(590, 349)
        Me.btnQuest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuest.Name = "btnQuest"
        Me.btnQuest.Size = New System.Drawing.Size(340, 171)
        Me.btnQuest.TabIndex = 2
        Me.btnQuest.Text = "Spørreskjema"
        Me.btnQuest.UseVisualStyleBackColor = False
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(79, 21)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(190, 36)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Innlogget som:"
        '
        'DonorPage
        '
        Me.DonorPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DonorPage.Controls.Add(Me.MyPage)
        Me.DonorPage.Controls.Add(Me.ChangeData)
        Me.DonorPage.Controls.Add(Me.InfoPage)
        Me.DonorPage.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonorPage.ItemSize = New System.Drawing.Size(205, 75)
        Me.DonorPage.Location = New System.Drawing.Point(12, 160)
        Me.DonorPage.Margin = New System.Windows.Forms.Padding(2)
        Me.DonorPage.Name = "DonorPage"
        Me.DonorPage.Padding = New System.Drawing.Point(48, 12)
        Me.DonorPage.SelectedIndex = 0
        Me.DonorPage.Size = New System.Drawing.Size(1550, 798)
        Me.DonorPage.TabIndex = 7
        '
        'btnSignOut
        '
        Me.btnSignOut.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(939, 39)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(183, 59)
        Me.btnSignOut.TabIndex = 10
        Me.btnSignOut.Text = "Logg ut"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'UserPage
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.DonorPage)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UserPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tapper`n"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.regerror, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoPage.ResumeLayout(False)
        Me.InfoPage.PerformLayout()
        Me.ChangeData.ResumeLayout(False)
        Me.Changeuserinfo.ResumeLayout(False)
        Me.Changeuserinfo.PerformLayout()
        Me.MyPage.ResumeLayout(False)
        Me.MyPage.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.gbBlood.ResumeLayout(False)
        Me.gbBlood.PerformLayout()
        Me.DonorPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents regerror As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DonorPage As TabControl
    Friend WithEvents MyPage As TabPage
    Friend WithEvents Label20 As Label
    Friend WithEvents gbBlood As GroupBox
    Friend WithEvents txtBtype As TextBox
    Friend WithEvents ironValue As Label
    Friend WithEvents txtIronValue As TextBox
    Friend WithEvents hb As Label
    Friend WithEvents txtDrain As TextBox
    Friend WithEvents lastDrain As Label
    Friend WithEvents txtHb As TextBox
    Friend WithEvents bloodType As Label
    Friend WithEvents lblSSnumber As Label
    Friend WithEvents btnQuest As Button
    Friend WithEvents lblFullName As Label
    Friend WithEvents ChangeData As TabPage
    Friend WithEvents Changeuserinfo As GroupBox
    Friend WithEvents FName As Label
    Friend WithEvents btnChangeData As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtConPwd As TextBox
    Friend WithEvents txtZipcode As TextBox
    Friend WithEvents confirmPwd As Label
    Friend WithEvents lastname As Label
    Friend WithEvents zipcode As Label
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents address As Label
    Friend WithEvents pwd As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents mail As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents phone As Label
    Friend WithEvents InfoPage As TabPage
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuarantine As TextBox
    Friend WithEvents lblquarantine As Label
    Friend WithEvents btnSignOut As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents lblLastDrain As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnCApp As Button
    Friend WithEvents lblnxtApp As Label
    Friend WithEvents DTPOrder As DateTimePicker
    Friend WithEvents txtbxTime As ComboBox
    Friend WithEvents btnOrderApp As Button
    Friend WithEvents lblVelgTime As Label
    Friend WithEvents btnUpdateQuarantine As Button
End Class
