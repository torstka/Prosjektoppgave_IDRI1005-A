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
        Me.lblSSnumber = New System.Windows.Forms.Label()
        Me.btnQuest = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.regerror = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DonorPage.SuspendLayout()
        Me.MyPage.SuspendLayout()
        Me.gbBlood.SuspendLayout()
        Me.BookTime.SuspendLayout()
        Me.gbTime.SuspendLayout()
        Me.ChangeData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.InfoPage.SuspendLayout()
        CType(Me.regerror, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DonorPage
        '
        Me.DonorPage.Controls.Add(Me.MyPage)
        Me.DonorPage.Controls.Add(Me.BookTime)
        Me.DonorPage.Controls.Add(Me.ChangeData)
        Me.DonorPage.Controls.Add(Me.InfoPage)
        Me.DonorPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonorPage.Location = New System.Drawing.Point(170, 75)
        Me.DonorPage.Margin = New System.Windows.Forms.Padding(2)
        Me.DonorPage.Name = "DonorPage"
        Me.DonorPage.Padding = New System.Drawing.Point(39, 20)
        Me.DonorPage.SelectedIndex = 0
        Me.DonorPage.Size = New System.Drawing.Size(1196, 701)
        Me.DonorPage.TabIndex = 7
        '
        'MyPage
        '
        Me.MyPage.Controls.Add(Me.gbBlood)
        Me.MyPage.Controls.Add(Me.lblSSnumber)
        Me.MyPage.Controls.Add(Me.btnQuest)
        Me.MyPage.Controls.Add(Me.lblFullName)
        Me.MyPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyPage.Location = New System.Drawing.Point(4, 72)
        Me.MyPage.Margin = New System.Windows.Forms.Padding(2)
        Me.MyPage.Name = "MyPage"
        Me.MyPage.Padding = New System.Windows.Forms.Padding(2)
        Me.MyPage.Size = New System.Drawing.Size(1188, 625)
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
        Me.gbBlood.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBlood.Location = New System.Drawing.Point(84, 142)
        Me.gbBlood.Margin = New System.Windows.Forms.Padding(2)
        Me.gbBlood.Name = "gbBlood"
        Me.gbBlood.Padding = New System.Windows.Forms.Padding(2)
        Me.gbBlood.Size = New System.Drawing.Size(442, 331)
        Me.gbBlood.TabIndex = 13
        Me.gbBlood.TabStop = False
        Me.gbBlood.Text = "Din bloddata"
        '
        'txtBtype
        '
        Me.txtBtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBtype.Location = New System.Drawing.Point(202, 76)
        Me.txtBtype.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBtype.Name = "txtBtype"
        Me.txtBtype.Size = New System.Drawing.Size(176, 30)
        Me.txtBtype.TabIndex = 9
        '
        'ironValue
        '
        Me.ironValue.AutoSize = True
        Me.ironValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ironValue.Location = New System.Drawing.Point(20, 196)
        Me.ironValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ironValue.Name = "ironValue"
        Me.ironValue.Size = New System.Drawing.Size(100, 25)
        Me.ironValue.TabIndex = 8
        Me.ironValue.Text = "Jernlager:"
        '
        'txtIronValue
        '
        Me.txtIronValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIronValue.Location = New System.Drawing.Point(202, 191)
        Me.txtIronValue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIronValue.Name = "txtIronValue"
        Me.txtIronValue.Size = New System.Drawing.Size(176, 30)
        Me.txtIronValue.TabIndex = 12
        '
        'hb
        '
        Me.hb.AutoSize = True
        Me.hb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hb.Location = New System.Drawing.Point(20, 138)
        Me.hb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hb.Name = "hb"
        Me.hb.Size = New System.Drawing.Size(116, 25)
        Me.hb.TabIndex = 7
        Me.hb.Text = "Hemoglobin"
        '
        'txtDrain
        '
        Me.txtDrain.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrain.Location = New System.Drawing.Point(202, 252)
        Me.txtDrain.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDrain.Name = "txtDrain"
        Me.txtDrain.Size = New System.Drawing.Size(176, 30)
        Me.txtDrain.TabIndex = 10
        '
        'lastDrain
        '
        Me.lastDrain.AutoSize = True
        Me.lastDrain.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastDrain.Location = New System.Drawing.Point(20, 257)
        Me.lastDrain.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lastDrain.Name = "lastDrain"
        Me.lastDrain.Size = New System.Drawing.Size(131, 25)
        Me.lastDrain.TabIndex = 6
        Me.lastDrain.Text = "Siste tapping:"
        '
        'txtHb
        '
        Me.txtHb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHb.Location = New System.Drawing.Point(202, 133)
        Me.txtHb.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHb.Name = "txtHb"
        Me.txtHb.Size = New System.Drawing.Size(176, 30)
        Me.txtHb.TabIndex = 11
        '
        'bloodType
        '
        Me.bloodType.AutoSize = True
        Me.bloodType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bloodType.Location = New System.Drawing.Point(20, 81)
        Me.bloodType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bloodType.Name = "bloodType"
        Me.bloodType.Size = New System.Drawing.Size(148, 25)
        Me.bloodType.TabIndex = 5
        Me.bloodType.Text = "Din blodtype er:"
        '
        'lblSSnumber
        '
        Me.lblSSnumber.AutoSize = True
        Me.lblSSnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSnumber.Location = New System.Drawing.Point(82, 77)
        Me.lblSSnumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSSnumber.Name = "lblSSnumber"
        Me.lblSSnumber.Size = New System.Drawing.Size(203, 29)
        Me.lblSSnumber.TabIndex = 4
        Me.lblSSnumber.Text = "Navn kommer her"
        '
        'btnQuest
        '
        Me.btnQuest.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuest.Location = New System.Drawing.Point(596, 165)
        Me.btnQuest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuest.Name = "btnQuest"
        Me.btnQuest.Size = New System.Drawing.Size(484, 308)
        Me.btnQuest.TabIndex = 2
        Me.btnQuest.Text = "Spørreskjema"
        Me.btnQuest.UseVisualStyleBackColor = True
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(81, 23)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(210, 36)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Innlogget som:"
        '
        'BookTime
        '
        Me.BookTime.Controls.Add(Me.gbTime)
        Me.BookTime.Location = New System.Drawing.Point(4, 72)
        Me.BookTime.Margin = New System.Windows.Forms.Padding(2)
        Me.BookTime.Name = "BookTime"
        Me.BookTime.Padding = New System.Windows.Forms.Padding(2)
        Me.BookTime.Size = New System.Drawing.Size(1191, 625)
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
        Me.gbTime.Location = New System.Drawing.Point(47, 23)
        Me.gbTime.Margin = New System.Windows.Forms.Padding(2)
        Me.gbTime.Name = "gbTime"
        Me.gbTime.Padding = New System.Windows.Forms.Padding(2)
        Me.gbTime.Size = New System.Drawing.Size(700, 446)
        Me.gbTime.TabIndex = 1
        Me.gbTime.TabStop = False
        Me.gbTime.Text = "Bestill time"
        '
        'lblOTime
        '
        Me.lblOTime.AutoSize = True
        Me.lblOTime.Location = New System.Drawing.Point(250, 233)
        Me.lblOTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOTime.Name = "lblOTime"
        Me.lblOTime.Size = New System.Drawing.Size(20, 29)
        Me.lblOTime.TabIndex = 8
        Me.lblOTime.Text = " "
        '
        'lblODate
        '
        Me.lblODate.AutoSize = True
        Me.lblODate.Location = New System.Drawing.Point(197, 233)
        Me.lblODate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblODate.Name = "lblODate"
        Me.lblODate.Size = New System.Drawing.Size(20, 29)
        Me.lblODate.TabIndex = 7
        Me.lblODate.Text = " "
        '
        'newDonorOrder
        '
        Me.newDonorOrder.AutoSize = True
        Me.newDonorOrder.Location = New System.Drawing.Point(14, 233)
        Me.newDonorOrder.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.newDonorOrder.Name = "newDonorOrder"
        Me.newDonorOrder.Size = New System.Drawing.Size(186, 29)
        Me.newDonorOrder.TabIndex = 6
        Me.newDonorOrder.Text = "Du har ny time:"
        '
        'txtClearBox
        '
        Me.txtClearBox.Location = New System.Drawing.Point(526, 244)
        Me.txtClearBox.Margin = New System.Windows.Forms.Padding(2)
        Me.txtClearBox.Name = "txtClearBox"
        Me.txtClearBox.Size = New System.Drawing.Size(111, 52)
        Me.txtClearBox.TabIndex = 5
        Me.txtClearBox.Text = "Tøm"
        Me.txtClearBox.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(345, 244)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(120, 52)
        Me.btnOrder.TabIndex = 4
        Me.btnOrder.Text = "Bestill"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(336, 62)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(301, 163)
        Me.txtMessage.TabIndex = 3
        '
        'message
        '
        Me.message.AutoSize = True
        Me.message.Location = New System.Drawing.Point(397, 21)
        Me.message.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(175, 29)
        Me.message.TabIndex = 2
        Me.message.Text = "Gi en beskjed"
        '
        'dtpOrder
        '
        Me.dtpOrder.Location = New System.Drawing.Point(14, 80)
        Me.dtpOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpOrder.Name = "dtpOrder"
        Me.dtpOrder.Size = New System.Drawing.Size(291, 35)
        Me.dtpOrder.TabIndex = 1
        '
        'showDate
        '
        Me.showDate.AutoSize = True
        Me.showDate.Location = New System.Drawing.Point(17, 49)
        Me.showDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.showDate.Name = "showDate"
        Me.showDate.Size = New System.Drawing.Size(131, 29)
        Me.showDate.TabIndex = 0
        Me.showDate.Text = "Velg dato!"
        '
        'ChangeData
        '
        Me.ChangeData.Controls.Add(Me.GroupBox1)
        Me.ChangeData.Location = New System.Drawing.Point(4, 72)
        Me.ChangeData.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangeData.Name = "ChangeData"
        Me.ChangeData.Padding = New System.Windows.Forms.Padding(2)
        Me.ChangeData.Size = New System.Drawing.Size(1188, 625)
        Me.ChangeData.TabIndex = 2
        Me.ChangeData.Text = "TabPage3"
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
        'FName
        '
        Me.FName.AutoSize = True
        Me.FName.Location = New System.Drawing.Point(66, 56)
        Me.FName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(107, 29)
        Me.FName.TabIndex = 15
        Me.FName.Text = "Fornavn"
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
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(287, 50)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(213, 35)
        Me.txtFirstName.TabIndex = 16
        '
        'txtConPwd
        '
        Me.txtConPwd.Location = New System.Drawing.Point(284, 490)
        Me.txtConPwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConPwd.Name = "txtConPwd"
        Me.txtConPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPwd.Size = New System.Drawing.Size(216, 35)
        Me.txtConPwd.TabIndex = 14
        Me.txtConPwd.UseSystemPasswordChar = True
        '
        'txtZipcode
        '
        Me.txtZipcode.Location = New System.Drawing.Point(284, 238)
        Me.txtZipcode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(216, 35)
        Me.txtZipcode.TabIndex = 18
        '
        'confirmPwd
        '
        Me.confirmPwd.AutoSize = True
        Me.confirmPwd.Location = New System.Drawing.Point(66, 496)
        Me.confirmPwd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.confirmPwd.Name = "confirmPwd"
        Me.confirmPwd.Size = New System.Drawing.Size(199, 29)
        Me.confirmPwd.TabIndex = 13
        Me.confirmPwd.Text = "Bekreft Passord"
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
        'zipcode
        '
        Me.zipcode.AutoSize = True
        Me.zipcode.Location = New System.Drawing.Point(66, 244)
        Me.zipcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.zipcode.Name = "zipcode"
        Me.zipcode.Size = New System.Drawing.Size(123, 29)
        Me.zipcode.TabIndex = 17
        Me.zipcode.Text = "Postkode"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(284, 430)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(216, 35)
        Me.txtPwd.TabIndex = 11
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Location = New System.Drawing.Point(66, 180)
        Me.address.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(109, 29)
        Me.address.TabIndex = 2
        Me.address.Text = "Adresse"
        '
        'pwd
        '
        Me.pwd.AutoSize = True
        Me.pwd.Location = New System.Drawing.Point(66, 436)
        Me.pwd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(109, 29)
        Me.pwd.TabIndex = 5
        Me.pwd.Text = "Passord"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(284, 368)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(216, 35)
        Me.txtMail.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(284, 112)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(216, 35)
        Me.txtLastName.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(284, 305)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(216, 35)
        Me.txtPhone.TabIndex = 9
        '
        'mail
        '
        Me.mail.AutoSize = True
        Me.mail.Location = New System.Drawing.Point(66, 374)
        Me.mail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(89, 29)
        Me.mail.TabIndex = 4
        Me.mail.Text = "E-post"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(284, 174)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(216, 35)
        Me.txtAddress.TabIndex = 8
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(64, 311)
        Me.phone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(197, 29)
        Me.phone.TabIndex = 3
        Me.phone.Text = "Telefonnummer"
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
        Me.InfoPage.Location = New System.Drawing.Point(4, 72)
        Me.InfoPage.Margin = New System.Windows.Forms.Padding(2)
        Me.InfoPage.Name = "InfoPage"
        Me.InfoPage.Padding = New System.Windows.Forms.Padding(2)
        Me.InfoPage.Size = New System.Drawing.Size(1188, 625)
        Me.InfoPage.TabIndex = 3
        Me.InfoPage.Text = "TabPage4"
        Me.InfoPage.UseVisualStyleBackColor = True
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
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(1223, 29)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(140, 57)
        Me.btnLogOut.TabIndex = 8
        Me.btnLogOut.Text = "Logg Ut"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'regerror
        '
        Me.regerror.ContainerControl = Me
        '
        'UserPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.DonorPage)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UserPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.DonorPage.ResumeLayout(False)
        Me.MyPage.ResumeLayout(False)
        Me.MyPage.PerformLayout()
        Me.gbBlood.ResumeLayout(False)
        Me.gbBlood.PerformLayout()
        Me.BookTime.ResumeLayout(False)
        Me.gbTime.ResumeLayout(False)
        Me.gbTime.PerformLayout()
        Me.ChangeData.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.InfoPage.ResumeLayout(False)
        Me.InfoPage.PerformLayout()
        CType(Me.regerror, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblSSnumber As Label
    Friend WithEvents btnQuest As Button
    Friend WithEvents lblFullName As Label
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
    Friend WithEvents lastname As Label
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
    Friend WithEvents txtZipcode As TextBox
    Friend WithEvents zipcode As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents regerror As ErrorProvider
End Class
