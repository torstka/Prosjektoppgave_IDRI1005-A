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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserPage))
        Me.DonorPage = New System.Windows.Forms.TabControl()
        Me.MyPage = New System.Windows.Forms.TabPage()
        Me.gbBlood = New System.Windows.Forms.GroupBox()
        Me.txtBtype = New System.Windows.Forms.TextBox()
        Me.ironValue = New System.Windows.Forms.Label()
        Me.txtIronValue = New System.Windows.Forms.TextBox()
        Me.hb = New System.Windows.Forms.Label()
        Me.txtDrain = New System.Windows.Forms.TextBox()
        Me.lastDrain = New System.Windows.Forms.Label()
        Me.txtHb = New System.Windows.Forms.TextBox()
        Me.bloodType = New System.Windows.Forms.Label()
        Me.ShowLogedIn = New System.Windows.Forms.Label()
        Me.btnQuest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BookTime = New System.Windows.Forms.TabPage()
        Me.gbTime = New System.Windows.Forms.GroupBox()
        Me.lblOTime = New System.Windows.Forms.Label()
        Me.lblODate = New System.Windows.Forms.Label()
        Me.newDonorOrder = New System.Windows.Forms.Label()
        Me.txtClearBox = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.message = New System.Windows.Forms.Label()
        Me.dtpOrder = New System.Windows.Forms.DateTimePicker()
        Me.showDate = New System.Windows.Forms.Label()
        Me.ChangeData = New System.Windows.Forms.TabPage()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.FName = New System.Windows.Forms.Label()
        Me.txtConPwd = New System.Windows.Forms.TextBox()
        Me.confirmPwd = New System.Windows.Forms.Label()
        Me.btnChangeData = New System.Windows.Forms.Button()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.Label()
        Me.mail = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.name = New System.Windows.Forms.Label()
        Me.personInfo = New System.Windows.Forms.Label()
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
        Me.InfoBloodDonation = New System.Windows.Forms.Label()
        Me.txtZipcode = New System.Windows.Forms.TextBox()
        Me.zipcode = New System.Windows.Forms.Label()
        Me.DonorPage.SuspendLayout()
        Me.MyPage.SuspendLayout()
        Me.gbBlood.SuspendLayout()
        Me.BookTime.SuspendLayout()
        Me.gbTime.SuspendLayout()
        Me.ChangeData.SuspendLayout()
        Me.InfoPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'DonorPage
        '
        Me.DonorPage.Controls.Add(Me.MyPage)
        Me.DonorPage.Controls.Add(Me.BookTime)
        Me.DonorPage.Controls.Add(Me.ChangeData)
        Me.DonorPage.Controls.Add(Me.InfoPage)
        Me.DonorPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonorPage.Location = New System.Drawing.Point(111, 99)
        Me.DonorPage.Name = "DonorPage"
        Me.DonorPage.Padding = New System.Drawing.Point(39, 20)
        Me.DonorPage.SelectedIndex = 0
        Me.DonorPage.Size = New System.Drawing.Size(1060, 552)
        Me.DonorPage.TabIndex = 7
        '
        'MyPage
        '
        Me.MyPage.Controls.Add(Me.gbBlood)
        Me.MyPage.Controls.Add(Me.ShowLogedIn)
        Me.MyPage.Controls.Add(Me.btnQuest)
        Me.MyPage.Controls.Add(Me.Label1)
        Me.MyPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyPage.Location = New System.Drawing.Point(4, 63)
        Me.MyPage.Name = "MyPage"
        Me.MyPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MyPage.Size = New System.Drawing.Size(1052, 485)
        Me.MyPage.TabIndex = 0
        Me.MyPage.Text = "TabPage1"
        Me.MyPage.UseVisualStyleBackColor = True
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
        Me.gbBlood.Location = New System.Drawing.Point(79, 84)
        Me.gbBlood.Name = "gbBlood"
        Me.gbBlood.Size = New System.Drawing.Size(371, 284)
        Me.gbBlood.TabIndex = 13
        Me.gbBlood.TabStop = False
        Me.gbBlood.Text = "Din bloddata"
        '
        'txtBtype
        '
        Me.txtBtype.Location = New System.Drawing.Point(224, 43)
        Me.txtBtype.Name = "txtBtype"
        Me.txtBtype.Size = New System.Drawing.Size(100, 26)
        Me.txtBtype.TabIndex = 9
        '
        'ironValue
        '
        Me.ironValue.AutoSize = True
        Me.ironValue.Location = New System.Drawing.Point(50, 208)
        Me.ironValue.Name = "ironValue"
        Me.ironValue.Size = New System.Drawing.Size(79, 20)
        Me.ironValue.TabIndex = 8
        Me.ironValue.Text = "Jernlager:"
        '
        'txtIronValue
        '
        Me.txtIronValue.Location = New System.Drawing.Point(224, 193)
        Me.txtIronValue.Name = "txtIronValue"
        Me.txtIronValue.Size = New System.Drawing.Size(100, 26)
        Me.txtIronValue.TabIndex = 12
        '
        'hb
        '
        Me.hb.AutoSize = True
        Me.hb.Location = New System.Drawing.Point(50, 153)
        Me.hb.Name = "hb"
        Me.hb.Size = New System.Drawing.Size(94, 20)
        Me.hb.TabIndex = 7
        Me.hb.Text = "Hemoglobin"
        '
        'txtDrain
        '
        Me.txtDrain.Location = New System.Drawing.Point(224, 93)
        Me.txtDrain.Name = "txtDrain"
        Me.txtDrain.Size = New System.Drawing.Size(100, 26)
        Me.txtDrain.TabIndex = 10
        '
        'lastDrain
        '
        Me.lastDrain.AutoSize = True
        Me.lastDrain.Location = New System.Drawing.Point(50, 98)
        Me.lastDrain.Name = "lastDrain"
        Me.lastDrain.Size = New System.Drawing.Size(106, 20)
        Me.lastDrain.TabIndex = 6
        Me.lastDrain.Text = "Siste tapping:"
        '
        'txtHb
        '
        Me.txtHb.Location = New System.Drawing.Point(224, 143)
        Me.txtHb.Name = "txtHb"
        Me.txtHb.Size = New System.Drawing.Size(100, 26)
        Me.txtHb.TabIndex = 11
        '
        'bloodType
        '
        Me.bloodType.AutoSize = True
        Me.bloodType.Location = New System.Drawing.Point(50, 43)
        Me.bloodType.Name = "bloodType"
        Me.bloodType.Size = New System.Drawing.Size(119, 20)
        Me.bloodType.TabIndex = 5
        Me.bloodType.Text = "Din blodtype er:"
        '
        'ShowLogedIn
        '
        Me.ShowLogedIn.AutoSize = True
        Me.ShowLogedIn.Location = New System.Drawing.Point(13, 52)
        Me.ShowLogedIn.Name = "ShowLogedIn"
        Me.ShowLogedIn.Size = New System.Drawing.Size(133, 20)
        Me.ShowLogedIn.TabIndex = 4
        Me.ShowLogedIn.Text = "Navn kommer her"
        '
        'btnQuest
        '
        Me.btnQuest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuest.Location = New System.Drawing.Point(560, 136)
        Me.btnQuest.Name = "btnQuest"
        Me.btnQuest.Size = New System.Drawing.Size(302, 152)
        Me.btnQuest.TabIndex = 2
        Me.btnQuest.Text = "Spørreskjema"
        Me.btnQuest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Innlogget som:"
        '
        'BookTime
        '
        Me.BookTime.Controls.Add(Me.gbTime)
        Me.BookTime.Location = New System.Drawing.Point(4, 63)
        Me.BookTime.Name = "BookTime"
        Me.BookTime.Padding = New System.Windows.Forms.Padding(3)
        Me.BookTime.Size = New System.Drawing.Size(1052, 485)
        Me.BookTime.TabIndex = 1
        Me.BookTime.Text = "TabPage2"
        Me.BookTime.UseVisualStyleBackColor = True
        '
        'gbTime
        '
        Me.gbTime.Controls.Add(Me.lblOTime)
        Me.gbTime.Controls.Add(Me.lblODate)
        Me.gbTime.Controls.Add(Me.newDonorOrder)
        Me.gbTime.Controls.Add(Me.txtClearBox)
        Me.gbTime.Controls.Add(Me.btnOrder)
        Me.gbTime.Controls.Add(Me.txtMessage)
        Me.gbTime.Controls.Add(Me.message)
        Me.gbTime.Controls.Add(Me.dtpOrder)
        Me.gbTime.Controls.Add(Me.showDate)
        Me.gbTime.Location = New System.Drawing.Point(70, 36)
        Me.gbTime.Name = "gbTime"
        Me.gbTime.Size = New System.Drawing.Size(811, 227)
        Me.gbTime.TabIndex = 1
        Me.gbTime.TabStop = False
        Me.gbTime.Text = "Bestill time"
        '
        'lblOTime
        '
        Me.lblOTime.AutoSize = True
        Me.lblOTime.Location = New System.Drawing.Point(237, 167)
        Me.lblOTime.Name = "lblOTime"
        Me.lblOTime.Size = New System.Drawing.Size(14, 20)
        Me.lblOTime.TabIndex = 8
        Me.lblOTime.Text = " "
        '
        'lblODate
        '
        Me.lblODate.AutoSize = True
        Me.lblODate.Location = New System.Drawing.Point(158, 167)
        Me.lblODate.Name = "lblODate"
        Me.lblODate.Size = New System.Drawing.Size(14, 20)
        Me.lblODate.TabIndex = 7
        Me.lblODate.Text = " "
        '
        'newDonorOrder
        '
        Me.newDonorOrder.AutoSize = True
        Me.newDonorOrder.Location = New System.Drawing.Point(21, 167)
        Me.newDonorOrder.Name = "newDonorOrder"
        Me.newDonorOrder.Size = New System.Drawing.Size(130, 20)
        Me.newDonorOrder.TabIndex = 6
        Me.newDonorOrder.Text = "Du har ny time:"
        '
        'txtClearBox
        '
        Me.txtClearBox.Location = New System.Drawing.Point(637, 148)
        Me.txtClearBox.Name = "txtClearBox"
        Me.txtClearBox.Size = New System.Drawing.Size(101, 33)
        Me.txtClearBox.TabIndex = 5
        Me.txtClearBox.Text = "Tøm"
        Me.txtClearBox.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(488, 148)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(102, 33)
        Me.btnOrder.TabIndex = 4
        Me.btnOrder.Text = "Bestill"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(488, 35)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(250, 80)
        Me.txtMessage.TabIndex = 3
        '
        'message
        '
        Me.message.AutoSize = True
        Me.message.Location = New System.Drawing.Point(527, 13)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(119, 20)
        Me.message.TabIndex = 2
        Me.message.Text = "Gi en beskjed"
        '
        'dtpOrder
        '
        Me.dtpOrder.Location = New System.Drawing.Point(21, 123)
        Me.dtpOrder.Name = "dtpOrder"
        Me.dtpOrder.Size = New System.Drawing.Size(200, 26)
        Me.dtpOrder.TabIndex = 1
        '
        'showDate
        '
        Me.showDate.AutoSize = True
        Me.showDate.Location = New System.Drawing.Point(26, 76)
        Me.showDate.Name = "showDate"
        Me.showDate.Size = New System.Drawing.Size(91, 20)
        Me.showDate.TabIndex = 0
        Me.showDate.Text = "Velg dato!"
        '
        'ChangeData
        '
        Me.ChangeData.Controls.Add(Me.txtZipcode)
        Me.ChangeData.Controls.Add(Me.zipcode)
        Me.ChangeData.Controls.Add(Me.txtFirstName)
        Me.ChangeData.Controls.Add(Me.FName)
        Me.ChangeData.Controls.Add(Me.txtConPwd)
        Me.ChangeData.Controls.Add(Me.confirmPwd)
        Me.ChangeData.Controls.Add(Me.btnChangeData)
        Me.ChangeData.Controls.Add(Me.txtPwd)
        Me.ChangeData.Controls.Add(Me.txtMail)
        Me.ChangeData.Controls.Add(Me.txtPhone)
        Me.ChangeData.Controls.Add(Me.txtAddress)
        Me.ChangeData.Controls.Add(Me.txtLastName)
        Me.ChangeData.Controls.Add(Me.pwd)
        Me.ChangeData.Controls.Add(Me.mail)
        Me.ChangeData.Controls.Add(Me.phone)
        Me.ChangeData.Controls.Add(Me.address)
        Me.ChangeData.Controls.Add(Me.name)
        Me.ChangeData.Controls.Add(Me.personInfo)
        Me.ChangeData.Location = New System.Drawing.Point(4, 63)
        Me.ChangeData.Name = "ChangeData"
        Me.ChangeData.Padding = New System.Windows.Forms.Padding(3)
        Me.ChangeData.Size = New System.Drawing.Size(1052, 485)
        Me.ChangeData.TabIndex = 2
        Me.ChangeData.Text = "TabPage3"
        Me.ChangeData.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(552, 69)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(243, 26)
        Me.txtFirstName.TabIndex = 16
        '
        'FName
        '
        Me.FName.AutoSize = True
        Me.FName.Location = New System.Drawing.Point(256, 76)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(74, 20)
        Me.FName.TabIndex = 15
        Me.FName.Text = "Fornavn"
        '
        'txtConPwd
        '
        Me.txtConPwd.Location = New System.Drawing.Point(552, 355)
        Me.txtConPwd.Name = "txtConPwd"
        Me.txtConPwd.Size = New System.Drawing.Size(243, 26)
        Me.txtConPwd.TabIndex = 14
        '
        'confirmPwd
        '
        Me.confirmPwd.AutoSize = True
        Me.confirmPwd.Location = New System.Drawing.Point(256, 361)
        Me.confirmPwd.Name = "confirmPwd"
        Me.confirmPwd.Size = New System.Drawing.Size(138, 20)
        Me.confirmPwd.TabIndex = 13
        Me.confirmPwd.Text = "Bekreft Passord"
        '
        'btnChangeData
        '
        Me.btnChangeData.Location = New System.Drawing.Point(552, 406)
        Me.btnChangeData.Name = "btnChangeData"
        Me.btnChangeData.Size = New System.Drawing.Size(103, 30)
        Me.btnChangeData.TabIndex = 12
        Me.btnChangeData.Text = "Lagre"
        Me.btnChangeData.UseVisualStyleBackColor = True
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(552, 316)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(243, 26)
        Me.txtPwd.TabIndex = 11
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(552, 275)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(243, 26)
        Me.txtMail.TabIndex = 10
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(552, 234)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(243, 26)
        Me.txtPhone.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(552, 151)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(243, 26)
        Me.txtAddress.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(552, 110)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(243, 26)
        Me.txtLastName.TabIndex = 7
        '
        'pwd
        '
        Me.pwd.AutoSize = True
        Me.pwd.Location = New System.Drawing.Point(256, 322)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(74, 20)
        Me.pwd.TabIndex = 5
        Me.pwd.Text = "Passord"
        '
        'mail
        '
        Me.mail.AutoSize = True
        Me.mail.Location = New System.Drawing.Point(256, 281)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(62, 20)
        Me.mail.TabIndex = 4
        Me.mail.Text = "E-post"
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(256, 240)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(133, 20)
        Me.phone.TabIndex = 3
        Me.phone.Text = "Telefonnummer"
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Location = New System.Drawing.Point(256, 157)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(75, 20)
        Me.address.TabIndex = 2
        Me.address.Text = "Adresse"
        '
        'name
        '
        Me.name.AutoSize = True
        Me.name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name.Location = New System.Drawing.Point(256, 116)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(87, 20)
        Me.name.TabIndex = 1
        Me.name.Text = "Etternavn"
        '
        'personInfo
        '
        Me.personInfo.AutoSize = True
        Me.personInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personInfo.Location = New System.Drawing.Point(313, 18)
        Me.personInfo.Name = "personInfo"
        Me.personInfo.Size = New System.Drawing.Size(324, 29)
        Me.personInfo.TabIndex = 0
        Me.personInfo.Text = "Endre Personopplysninger"
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
        Me.InfoPage.Controls.Add(Me.InfoBloodDonation)
        Me.InfoPage.Location = New System.Drawing.Point(4, 63)
        Me.InfoPage.Name = "InfoPage"
        Me.InfoPage.Padding = New System.Windows.Forms.Padding(3)
        Me.InfoPage.Size = New System.Drawing.Size(1052, 393)
        Me.InfoPage.TabIndex = 3
        Me.InfoPage.Text = "TabPage4"
        Me.InfoPage.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(686, 581)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(241, 20)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://giblod.no/default.aspx"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(118, 604)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(547, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "eller ta kontakt med de ansatte ved blodbanken for øvrige spørsmål"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(118, 581)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(665, 40)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Vil du ha mer informasjon om blodgivning, kan du besøke Gi Blod sine             " &
    "       " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(-5, 532)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1005, 40)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = resources.GetString("Label15.Text")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(-5, 492)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(667, 40)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "12.    Personer som har oppholdt seg i over 5 år til sammen i Afrika syd for Saha" &
    "ra " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         (dvs. gjelder ikke Egypt, Libya, Tunis, Algerie eller Marokko)."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(-5, 452)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1095, 40)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = resources.GetString("Label13.Text")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(-5, 412)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(788, 40)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "10.    Personer som har oppholdt seg i Storbritannia i over 1 år til sammen i per" &
    "ioden 1980 – 1996 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         eller har fått blodoverføring der etter 1980."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 372)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1051, 40)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = resources.GetString("Label11.Text")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1054, 80)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1119, 80)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1088, 40)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1035, 40)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(930, 40)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "4.    Personer som bruker medikamenter fast. Viktige unntak er p-piller, allergim" &
    "edisin og midler mot lavt stoffskifte. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Utover dette er det behov for in" &
    "dividuell vurdering av fagpersonell."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(302, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "3.    Personer som veier under 50 kg."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(959, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "2.    Personer under 18 år. Øvre aldersgrense for nye givere varierer, noen blodb" &
    "anker praktiserer 60 år, de fleste 65 år."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(699, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "1.    Personer som ikke er friske. Avhengig av sykdom vurderes permanent utelukke" &
    "lse."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(335, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "I dag kan ikke følgende personer gi blod:"
        '
        'InfoBloodDonation
        '
        Me.InfoBloodDonation.AutoSize = True
        Me.InfoBloodDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoBloodDonation.Location = New System.Drawing.Point(354, 3)
        Me.InfoBloodDonation.Name = "InfoBloodDonation"
        Me.InfoBloodDonation.Size = New System.Drawing.Size(321, 29)
        Me.InfoBloodDonation.TabIndex = 0
        Me.InfoBloodDonation.Text = "Informasjon om blodgiving"
        '
        'txtZipcode
        '
        Me.txtZipcode.Location = New System.Drawing.Point(552, 193)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(243, 26)
        Me.txtZipcode.TabIndex = 18
        '
        'zipcode
        '
        Me.zipcode.AutoSize = True
        Me.zipcode.Location = New System.Drawing.Point(256, 199)
        Me.zipcode.Name = "zipcode"
        Me.zipcode.Size = New System.Drawing.Size(84, 20)
        Me.zipcode.TabIndex = 17
        Me.zipcode.Text = "Postkode"
        '
        'UserPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 758)
        Me.Controls.Add(Me.DonorPage)
        Me.name = "UserPage"
        Me.Text = "UserPage"
        Me.DonorPage.ResumeLayout(False)
        Me.MyPage.ResumeLayout(False)
        Me.MyPage.PerformLayout()
        Me.gbBlood.ResumeLayout(False)
        Me.gbBlood.PerformLayout()
        Me.BookTime.ResumeLayout(False)
        Me.gbTime.ResumeLayout(False)
        Me.gbTime.PerformLayout()
        Me.ChangeData.ResumeLayout(False)
        Me.ChangeData.PerformLayout()
        Me.InfoPage.ResumeLayout(False)
        Me.InfoPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DonorPage As TabControl
    Friend WithEvents MyPage As TabPage
    Friend WithEvents gbBlood As GroupBox
    Friend WithEvents txtBtype As TextBox
    Friend WithEvents ironValue As Label
    Friend WithEvents txtIronValue As TextBox
    Friend WithEvents hb As Label
    Friend WithEvents txtDrain As TextBox
    Friend WithEvents lastDrain As Label
    Friend WithEvents txtHb As TextBox
    Friend WithEvents bloodType As Label
    Friend WithEvents ShowLogedIn As Label
    Friend WithEvents btnQuest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BookTime As TabPage
    Friend WithEvents gbTime As GroupBox
    Friend WithEvents lblOTime As Label
    Friend WithEvents lblODate As Label
    Friend WithEvents newDonorOrder As Label
    Friend WithEvents txtClearBox As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents message As Label
    Friend WithEvents dtpOrder As DateTimePicker
    Friend WithEvents showDate As Label
    Friend WithEvents ChangeData As TabPage
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents FName As Label
    Friend WithEvents txtConPwd As TextBox
    Friend WithEvents confirmPwd As Label
    Friend WithEvents btnChangeData As Button
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents pwd As Label
    Friend WithEvents mail As Label
    Friend WithEvents phone As Label
    Friend WithEvents address As Label
    Friend WithEvents name As Label
    Friend WithEvents personInfo As Label
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
    Friend WithEvents InfoBloodDonation As Label
    Friend WithEvents txtZipcode As TextBox
    Friend WithEvents zipcode As Label
End Class
