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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ChangeData = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.phone = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.mail = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.zipcode = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.Label()
        Me.confirmPwd = New System.Windows.Forms.Label()
        Me.txtZipcode = New System.Windows.Forms.TextBox()
        Me.txtConPwd = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnChangeData = New System.Windows.Forms.Button()
        Me.FName = New System.Windows.Forms.Label()
        Me.MyPage = New System.Windows.Forms.TabPage()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnQuest = New System.Windows.Forms.Button()
        Me.lblSSnumber = New System.Windows.Forms.Label()
        Me.gbBlood = New System.Windows.Forms.GroupBox()
        Me.bloodType = New System.Windows.Forms.Label()
        Me.txtHb = New System.Windows.Forms.TextBox()
        Me.lastDrain = New System.Windows.Forms.Label()
        Me.txtDrain = New System.Windows.Forms.TextBox()
        Me.hb = New System.Windows.Forms.Label()
        Me.txtIronValue = New System.Windows.Forms.TextBox()
        Me.ironValue = New System.Windows.Forms.Label()
        Me.txtBtype = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblOTime = New System.Windows.Forms.Label()
        Me.BtnOrderApp = New System.Windows.Forms.Button()
        Me.lblODate = New System.Windows.Forms.Label()
        Me.lblNxtApp = New System.Windows.Forms.Label()
        Me.txtbxTime = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.DTPOrder = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nxtApp = New System.Windows.Forms.Label()
        Me.btnCApp = New System.Windows.Forms.Button()
        Me.day_p_time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.can = New System.Windows.Forms.Label()
        Me.DonorPage = New System.Windows.Forms.TabControl()
        CType(Me.regerror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoPage.SuspendLayout()
        Me.ChangeData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MyPage.SuspendLayout()
        Me.gbBlood.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.DonorPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(2026, 18)
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
        Me.InfoPage.Size = New System.Drawing.Size(1392, 717)
        Me.InfoPage.TabIndex = 3
        Me.InfoPage.Text = "Kriterier for blodgivning"
        Me.InfoPage.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(440, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(392, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "I dag kan ikke følgende personer gi blod:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(606, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "1.    Personer som ikke er friske. Avhengig av sykdom vurderes permanent utelukke" &
    "lse."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(138, 61)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(826, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "2.    Personer under 18 år. Øvre aldersgrense for nye givere varierer, noen blodb" &
    "anker praktiserer 60 år, de fleste 65 år."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(139, 87)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(259, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "3.    Personer som veier under 50 kg."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(798, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "4.    Personer som bruker medikamenter fast. Viktige unntak er p-piller, allergim" &
    "edisin og midler mot lavt stoffskifte. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Utover dette er det behov for in" &
    "dividuell vurdering av fagpersonell."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(138, 151)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(899, 32)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(137, 194)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(923, 32)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(136, 235)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(966, 64)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(135, 294)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(912, 64)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(135, 352)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(906, 32)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = resources.GetString("Label11.Text")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(125, 393)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(672, 32)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "10.    Personer som har oppholdt seg i Storbritannia i over 1 år til sammen i per" &
    "ioden 1980 – 1996 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         eller har fått blodoverføring der etter 1980."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(125, 435)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(941, 32)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = resources.GetString("Label13.Text")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(126, 477)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(573, 32)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "12.    Personer som har oppholdt seg i over 5 år til sammen i Afrika syd for Saha" &
    "ra " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         (dvs. gjelder ikke Egypt, Libya, Tunis, Algerie eller Marokko)."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(127, 520)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(850, 32)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = resources.GetString("Label15.Text")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(351, 565)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(402, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Vil du ha mer informasjon om blodgivning, kan du besøke"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(403, 582)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(475, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "eller ta kontakt med de ansatte ved blodbanken for øvrige spørsmål"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(747, 565)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(209, 16)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://giblod.no/default.aspx"
        '
        'ChangeData
        '
        Me.ChangeData.Controls.Add(Me.GroupBox1)
        Me.ChangeData.Location = New System.Drawing.Point(4, 79)
        Me.ChangeData.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangeData.Name = "ChangeData"
        Me.ChangeData.Padding = New System.Windows.Forms.Padding(2)
        Me.ChangeData.Size = New System.Drawing.Size(1392, 717)
        Me.ChangeData.TabIndex = 2
        Me.ChangeData.Text = "Endre personopplysninger"
        Me.ChangeData.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FName)
        Me.GroupBox1.Controls.Add(Me.btnChangeData)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtConPwd)
        Me.GroupBox1.Controls.Add(Me.txtZipcode)
        Me.GroupBox1.Controls.Add(Me.confirmPwd)
        Me.GroupBox1.Controls.Add(Me.lastname)
        Me.GroupBox1.Controls.Add(Me.zipcode)
        Me.GroupBox1.Controls.Add(Me.txtPwd)
        Me.GroupBox1.Controls.Add(Me.address)
        Me.GroupBox1.Controls.Add(Me.pwd)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.mail)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.phone)
        Me.GroupBox1.Location = New System.Drawing.Point(310, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 615)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Endre Personopplysninger"
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(64, 311)
        Me.phone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(174, 29)
        Me.phone.TabIndex = 3
        Me.phone.Text = "Telefonnummer"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(284, 177)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(213, 37)
        Me.txtAddress.TabIndex = 8
        '
        'mail
        '
        Me.mail.AutoSize = True
        Me.mail.Location = New System.Drawing.Point(66, 374)
        Me.mail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(76, 29)
        Me.mail.TabIndex = 4
        Me.mail.Text = "E-post"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(284, 305)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(213, 37)
        Me.txtPhone.TabIndex = 9
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(284, 114)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(213, 37)
        Me.txtLastName.TabIndex = 7
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(284, 368)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(216, 37)
        Me.txtMail.TabIndex = 10
        '
        'pwd
        '
        Me.pwd.AutoSize = True
        Me.pwd.Location = New System.Drawing.Point(66, 436)
        Me.pwd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(93, 29)
        Me.pwd.TabIndex = 5
        Me.pwd.Text = "Passord"
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Location = New System.Drawing.Point(66, 180)
        Me.address.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(94, 29)
        Me.address.TabIndex = 2
        Me.address.Text = "Adresse"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(284, 430)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(216, 37)
        Me.txtPwd.TabIndex = 11
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'zipcode
        '
        Me.zipcode.AutoSize = True
        Me.zipcode.Location = New System.Drawing.Point(66, 244)
        Me.zipcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.zipcode.Name = "zipcode"
        Me.zipcode.Size = New System.Drawing.Size(144, 29)
        Me.zipcode.TabIndex = 17
        Me.zipcode.Text = "Postnummer"
        '
        'lastname
        '
        Me.lastname.AutoSize = True
        Me.lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.Location = New System.Drawing.Point(66, 118)
        Me.lastname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(122, 29)
        Me.lastname.TabIndex = 1
        Me.lastname.Text = "Etternavn"
        '
        'confirmPwd
        '
        Me.confirmPwd.AutoSize = True
        Me.confirmPwd.Location = New System.Drawing.Point(66, 496)
        Me.confirmPwd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.confirmPwd.Name = "confirmPwd"
        Me.confirmPwd.Size = New System.Drawing.Size(171, 29)
        Me.confirmPwd.TabIndex = 13
        Me.confirmPwd.Text = "Bekreft Passord"
        '
        'txtZipcode
        '
        Me.txtZipcode.Location = New System.Drawing.Point(284, 241)
        Me.txtZipcode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(213, 37)
        Me.txtZipcode.TabIndex = 18
        '
        'txtConPwd
        '
        Me.txtConPwd.Location = New System.Drawing.Point(284, 490)
        Me.txtConPwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConPwd.Name = "txtConPwd"
        Me.txtConPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPwd.Size = New System.Drawing.Size(216, 37)
        Me.txtConPwd.TabIndex = 14
        Me.txtConPwd.UseSystemPasswordChar = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(284, 51)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(213, 37)
        Me.txtFirstName.TabIndex = 16
        '
        'btnChangeData
        '
        Me.btnChangeData.Location = New System.Drawing.Point(240, 535)
        Me.btnChangeData.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChangeData.Name = "btnChangeData"
        Me.btnChangeData.Size = New System.Drawing.Size(111, 52)
        Me.btnChangeData.TabIndex = 12
        Me.btnChangeData.Text = "Lagre"
        Me.btnChangeData.UseVisualStyleBackColor = True
        '
        'FName
        '
        Me.FName.AutoSize = True
        Me.FName.Location = New System.Drawing.Point(66, 56)
        Me.FName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(95, 29)
        Me.FName.TabIndex = 15
        Me.FName.Text = "Fornavn"
        '
        'MyPage
        '
        Me.MyPage.Controls.Add(Me.GroupBox3)
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
        Me.MyPage.Size = New System.Drawing.Size(1392, 717)
        Me.MyPage.TabIndex = 0
        Me.MyPage.Text = "Min side"
        Me.MyPage.UseVisualStyleBackColor = True
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
        'btnQuest
        '
        Me.btnQuest.AllowDrop = True
        Me.btnQuest.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuest.Location = New System.Drawing.Point(545, 295)
        Me.btnQuest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuest.Name = "btnQuest"
        Me.btnQuest.Size = New System.Drawing.Size(340, 171)
        Me.btnQuest.TabIndex = 2
        Me.btnQuest.Text = "Spørreskjema"
        Me.btnQuest.UseVisualStyleBackColor = True
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
        'gbBlood
        '
        Me.gbBlood.Controls.Add(Me.txtBtype)
        Me.gbBlood.Controls.Add(Me.ironValue)
        Me.gbBlood.Controls.Add(Me.txtIronValue)
        Me.gbBlood.Controls.Add(Me.hb)
        Me.gbBlood.Controls.Add(Me.txtDrain)
        Me.gbBlood.Controls.Add(Me.lastDrain)
        Me.gbBlood.Controls.Add(Me.txtHb)
        Me.gbBlood.Controls.Add(Me.bloodType)
        Me.gbBlood.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBlood.Location = New System.Drawing.Point(84, 142)
        Me.gbBlood.Margin = New System.Windows.Forms.Padding(2)
        Me.gbBlood.Name = "gbBlood"
        Me.gbBlood.Padding = New System.Windows.Forms.Padding(2)
        Me.gbBlood.Size = New System.Drawing.Size(442, 331)
        Me.gbBlood.TabIndex = 13
        Me.gbBlood.TabStop = False
        Me.gbBlood.Text = "Mine bloddata"
        '
        'bloodType
        '
        Me.bloodType.AutoSize = True
        Me.bloodType.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bloodType.Location = New System.Drawing.Point(20, 81)
        Me.bloodType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bloodType.Name = "bloodType"
        Me.bloodType.Size = New System.Drawing.Size(150, 26)
        Me.bloodType.TabIndex = 5
        Me.bloodType.Text = "Din blodtype er:"
        '
        'txtHb
        '
        Me.txtHb.Enabled = False
        Me.txtHb.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHb.Location = New System.Drawing.Point(202, 190)
        Me.txtHb.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHb.Name = "txtHb"
        Me.txtHb.Size = New System.Drawing.Size(176, 33)
        Me.txtHb.TabIndex = 11
        '
        'lastDrain
        '
        Me.lastDrain.AutoSize = True
        Me.lastDrain.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastDrain.Location = New System.Drawing.Point(20, 138)
        Me.lastDrain.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lastDrain.Name = "lastDrain"
        Me.lastDrain.Size = New System.Drawing.Size(128, 26)
        Me.lastDrain.TabIndex = 6
        Me.lastDrain.Text = "Siste tapping:"
        '
        'txtDrain
        '
        Me.txtDrain.Enabled = False
        Me.txtDrain.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrain.Location = New System.Drawing.Point(202, 133)
        Me.txtDrain.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDrain.Name = "txtDrain"
        Me.txtDrain.Size = New System.Drawing.Size(176, 33)
        Me.txtDrain.TabIndex = 10
        '
        'hb
        '
        Me.hb.AutoSize = True
        Me.hb.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hb.Location = New System.Drawing.Point(20, 195)
        Me.hb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hb.Name = "hb"
        Me.hb.Size = New System.Drawing.Size(116, 26)
        Me.hb.TabIndex = 7
        Me.hb.Text = "Hemoglobin"
        '
        'txtIronValue
        '
        Me.txtIronValue.Enabled = False
        Me.txtIronValue.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIronValue.Location = New System.Drawing.Point(202, 248)
        Me.txtIronValue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIronValue.Name = "txtIronValue"
        Me.txtIronValue.Size = New System.Drawing.Size(176, 33)
        Me.txtIronValue.TabIndex = 12
        '
        'ironValue
        '
        Me.ironValue.AutoSize = True
        Me.ironValue.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ironValue.Location = New System.Drawing.Point(20, 253)
        Me.ironValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ironValue.Name = "ironValue"
        Me.ironValue.Size = New System.Drawing.Size(95, 26)
        Me.ironValue.TabIndex = 8
        Me.ironValue.Text = "Jernlager:"
        '
        'txtBtype
        '
        Me.txtBtype.Enabled = False
        Me.txtBtype.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBtype.Location = New System.Drawing.Point(202, 76)
        Me.txtBtype.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBtype.Name = "txtBtype"
        Me.txtBtype.Size = New System.Drawing.Size(176, 33)
        Me.txtBtype.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.AllowDrop = True
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(545, 166)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(343, 109)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Fyll alltid ut spørreskjemaet før du gir blod." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Det må være tre måneder siden for" &
    "rige blodgivning. <("") "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.can)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.day_p_time)
        Me.GroupBox3.Controls.Add(Me.btnCApp)
        Me.GroupBox3.Controls.Add(Me.nxtApp)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.DTPOrder)
        Me.GroupBox3.Controls.Add(Me.lblSSN)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtbxTime)
        Me.GroupBox3.Controls.Add(Me.lblNxtApp)
        Me.GroupBox3.Controls.Add(Me.lblODate)
        Me.GroupBox3.Controls.Add(Me.BtnOrderApp)
        Me.GroupBox3.Controls.Add(Me.lblOTime)
        Me.GroupBox3.Location = New System.Drawing.Point(947, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(471, 512)
        Me.GroupBox3.TabIndex = 95
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'lblOTime
        '
        Me.lblOTime.AutoSize = True
        Me.lblOTime.Location = New System.Drawing.Point(255, 185)
        Me.lblOTime.Name = "lblOTime"
        Me.lblOTime.Size = New System.Drawing.Size(0, 13)
        Me.lblOTime.TabIndex = 72
        '
        'BtnOrderApp
        '
        Me.BtnOrderApp.Location = New System.Drawing.Point(14, 158)
        Me.BtnOrderApp.Name = "BtnOrderApp"
        Me.BtnOrderApp.Size = New System.Drawing.Size(118, 67)
        Me.BtnOrderApp.TabIndex = 62
        Me.BtnOrderApp.Text = "Bestill Time"
        Me.BtnOrderApp.UseVisualStyleBackColor = True
        '
        'lblODate
        '
        Me.lblODate.AutoSize = True
        Me.lblODate.Location = New System.Drawing.Point(495, 158)
        Me.lblODate.Name = "lblODate"
        Me.lblODate.Size = New System.Drawing.Size(0, 13)
        Me.lblODate.TabIndex = 71
        '
        'lblNxtApp
        '
        Me.lblNxtApp.AutoSize = True
        Me.lblNxtApp.Location = New System.Drawing.Point(183, 158)
        Me.lblNxtApp.Name = "lblNxtApp"
        Me.lblNxtApp.Size = New System.Drawing.Size(60, 13)
        Me.lblNxtApp.TabIndex = 70
        Me.lblNxtApp.Text = "Bestilt time:"
        Me.lblNxtApp.Visible = False
        '
        'txtbxTime
        '
        Me.txtbxTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTime.FormattingEnabled = True
        Me.txtbxTime.Items.AddRange(New Object() {"07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30"})
        Me.txtbxTime.Location = New System.Drawing.Point(231, 101)
        Me.txtbxTime.MaxDropDownItems = 12
        Me.txtbxTime.Name = "txtbxTime"
        Me.txtbxTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtbxTime.Size = New System.Drawing.Size(71, 28)
        Me.txtbxTime.TabIndex = 69
        Me.txtbxTime.Text = "08:00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(222, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "Time:"
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(210, 31)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(73, 13)
        Me.lblSSN.TabIndex = 63
        Me.lblSSN.Text = "22119611122"
        '
        'DTPOrder
        '
        Me.DTPOrder.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPOrder.CustomFormat = "yyyy/MM/dd"
        Me.DTPOrder.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTPOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPOrder.Location = New System.Drawing.Point(14, 101)
        Me.DTPOrder.MaxDate = New Date(3017, 12, 31, 0, 0, 0, 0)
        Me.DTPOrder.MinDate = New Date(2017, 3, 1, 0, 0, 0, 0)
        Me.DTPOrder.Name = "DTPOrder"
        Me.DTPOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPOrder.Size = New System.Drawing.Size(192, 31)
        Me.DTPOrder.TabIndex = 58
        Me.DTPOrder.Value = New Date(2017, 3, 24, 0, 0, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "person nummer"
        '
        'nxtApp
        '
        Me.nxtApp.AutoSize = True
        Me.nxtApp.Location = New System.Drawing.Point(249, 158)
        Me.nxtApp.Name = "nxtApp"
        Me.nxtApp.Size = New System.Drawing.Size(69, 13)
        Me.nxtApp.TabIndex = 92
        Me.nxtApp.Text = "Ikke satt opp"
        '
        'btnCApp
        '
        Me.btnCApp.Location = New System.Drawing.Point(14, 277)
        Me.btnCApp.Name = "btnCApp"
        Me.btnCApp.Size = New System.Drawing.Size(163, 50)
        Me.btnCApp.TabIndex = 73
        Me.btnCApp.Text = "Avbestill"
        Me.btnCApp.UseVisualStyleBackColor = True
        '
        'day_p_time
        '
        Me.day_p_time.AutoSize = True
        Me.day_p_time.Location = New System.Drawing.Point(25, 374)
        Me.day_p_time.Name = "day_p_time"
        Me.day_p_time.Size = New System.Drawing.Size(142, 13)
        Me.day_p_time.TabIndex = 93
        Me.day_p_time.Text = "day + "" "" + time satt sammen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Neste time:"
        '
        'can
        '
        Me.can.AutoSize = True
        Me.can.Location = New System.Drawing.Point(184, 212)
        Me.can.Name = "can"
        Me.can.Size = New System.Drawing.Size(59, 13)
        Me.can.TabIndex = 74
        Me.can.Text = "CanCancel"
        '
        'DonorPage
        '
        Me.DonorPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DonorPage.Controls.Add(Me.MyPage)
        Me.DonorPage.Controls.Add(Me.ChangeData)
        Me.DonorPage.Controls.Add(Me.InfoPage)
        Me.DonorPage.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonorPage.ItemSize = New System.Drawing.Size(205, 75)
        Me.DonorPage.Location = New System.Drawing.Point(12, 50)
        Me.DonorPage.Margin = New System.Windows.Forms.Padding(2)
        Me.DonorPage.Name = "DonorPage"
        Me.DonorPage.Padding = New System.Drawing.Point(48, 12)
        Me.DonorPage.SelectedIndex = 0
        Me.DonorPage.Size = New System.Drawing.Size(1400, 800)
        Me.DonorPage.TabIndex = 7
        '
        'UserPage
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1854, 761)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MyPage.ResumeLayout(False)
        Me.MyPage.PerformLayout()
        Me.gbBlood.ResumeLayout(False)
        Me.gbBlood.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.DonorPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents regerror As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DonorPage As TabControl
    Friend WithEvents MyPage As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents can As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents day_p_time As Label
    Friend WithEvents btnCApp As Button
    Friend WithEvents nxtApp As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DTPOrder As DateTimePicker
    Friend WithEvents lblSSN As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtbxTime As ComboBox
    Friend WithEvents lblNxtApp As Label
    Friend WithEvents lblODate As Label
    Friend WithEvents BtnOrderApp As Button
    Friend WithEvents lblOTime As Label
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
    Friend WithEvents GroupBox1 As GroupBox
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
End Class
