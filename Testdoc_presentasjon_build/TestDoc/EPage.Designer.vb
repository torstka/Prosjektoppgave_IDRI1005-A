<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EPage
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
        Me.Userinformation = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbPlasmaCount = New System.Windows.Forms.ComboBox()
        Me.cbCellsCount = New System.Windows.Forms.ComboBox()
        Me.cbPlateletsCount = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRegDonation = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSummons = New System.Windows.Forms.Button()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtQuarantine = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtLastDrain = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbBloodType = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtHB = New System.Windows.Forms.TextBox()
        Me.txtIron = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgwUsers = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtGetBloodInfo = New System.Windows.Forms.TextBox()
        Me.txtGetBloodType = New System.Windows.Forms.TextBox()
        Me.btnGetOrder = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbShowStock = New System.Windows.Forms.ListBox()
        Me.txtGetBloodCount = New System.Windows.Forms.TextBox()
        Me.btnGetBlood = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gbCalendar = New System.Windows.Forms.GroupBox()
        Me.lblQuarantine = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblVelgtime = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblLastDrain = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnVSSN = New System.Windows.Forms.Button()
        Me.txtbxSSNV = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnCApp = New System.Windows.Forms.Button()
        Me.lblnxtApp = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DTPOrder = New System.Windows.Forms.DateTimePicker()
        Me.txtbxTime = New System.Windows.Forms.ComboBox()
        Me.btnOrderApp = New System.Windows.Forms.Button()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Userinformation.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgwUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gbCalendar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Userinformation
        '
        Me.Userinformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Userinformation.Controls.Add(Me.TabPage1)
        Me.Userinformation.Controls.Add(Me.TabPage2)
        Me.Userinformation.Controls.Add(Me.TabPage3)
        Me.Userinformation.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userinformation.ItemSize = New System.Drawing.Size(205, 75)
        Me.Userinformation.Location = New System.Drawing.Point(77, 74)
        Me.Userinformation.Margin = New System.Windows.Forms.Padding(2)
        Me.Userinformation.Name = "Userinformation"
        Me.Userinformation.Padding = New System.Drawing.Point(48, 12)
        Me.Userinformation.SelectedIndex = 0
        Me.Userinformation.Size = New System.Drawing.Size(1550, 750)
        Me.Userinformation.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.Userinformation.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnStatistics)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 79)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1542, 667)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Brukerinformasjon"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.LightBlue
        Me.btnStatistics.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.Location = New System.Drawing.Point(591, 579)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(140, 59)
        Me.btnStatistics.TabIndex = 13
        Me.btnStatistics.Text = "Vis statistikk"
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbPlasmaCount)
        Me.GroupBox3.Controls.Add(Me.cbCellsCount)
        Me.GroupBox3.Controls.Add(Me.cbPlateletsCount)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnRegDonation)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(26, 421)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(528, 236)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registrer donasjon"
        '
        'cbPlasmaCount
        '
        Me.cbPlasmaCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlasmaCount.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlasmaCount.FormattingEnabled = True
        Me.cbPlasmaCount.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cbPlasmaCount.Location = New System.Drawing.Point(151, 168)
        Me.cbPlasmaCount.Name = "cbPlasmaCount"
        Me.cbPlasmaCount.Size = New System.Drawing.Size(121, 37)
        Me.cbPlasmaCount.TabIndex = 79
        '
        'cbCellsCount
        '
        Me.cbCellsCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCellsCount.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCellsCount.FormattingEnabled = True
        Me.cbCellsCount.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cbCellsCount.Location = New System.Drawing.Point(152, 121)
        Me.cbCellsCount.Name = "cbCellsCount"
        Me.cbCellsCount.Size = New System.Drawing.Size(121, 37)
        Me.cbCellsCount.TabIndex = 78
        '
        'cbPlateletsCount
        '
        Me.cbPlateletsCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlateletsCount.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlateletsCount.FormattingEnabled = True
        Me.cbPlateletsCount.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cbPlateletsCount.Location = New System.Drawing.Point(153, 74)
        Me.cbPlateletsCount.Name = "cbPlateletsCount"
        Me.cbPlateletsCount.Size = New System.Drawing.Size(121, 37)
        Me.cbPlateletsCount.TabIndex = 77
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(43, 174)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 26)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Plasma:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 26)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Legemer:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(148, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 26)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Pose (100ml)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 26)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Plater:"
        '
        'btnRegDonation
        '
        Me.btnRegDonation.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegDonation.Location = New System.Drawing.Point(315, 158)
        Me.btnRegDonation.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegDonation.Name = "btnRegDonation"
        Me.btnRegDonation.Size = New System.Drawing.Size(173, 47)
        Me.btnRegDonation.TabIndex = 60
        Me.btnRegDonation.Text = "Registrer donasjon"
        Me.btnRegDonation.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDeleteUser)
        Me.GroupBox2.Controls.Add(Me.txtMail)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.btnSummons)
        Me.GroupBox2.Controls.Add(Me.txtPhone)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtFirstname)
        Me.GroupBox2.Controls.Add(Me.txtLastname)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtSSN)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(350, 360)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Brukerinfo"
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.Location = New System.Drawing.Point(203, 298)
        Me.btnDeleteUser.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(130, 46)
        Me.btnDeleteUser.TabIndex = 66
        Me.btnDeleteUser.Text = "Slett bruker"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'txtMail
        '
        Me.txtMail.Enabled = False
        Me.txtMail.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(163, 226)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMail.Multiline = True
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(170, 33)
        Me.txtMail.TabIndex = 54
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 229)
        Me.Label18.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 26)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Epost:"
        '
        'btnSummons
        '
        Me.btnSummons.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummons.Location = New System.Drawing.Point(8, 298)
        Me.btnSummons.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSummons.Name = "btnSummons"
        Me.btnSummons.Size = New System.Drawing.Size(157, 46)
        Me.btnSummons.TabIndex = 65
        Me.btnSummons.Text = "Innkalling"
        Me.btnSummons.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.Enabled = False
        Me.txtPhone.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(163, 178)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(170, 33)
        Me.txtPhone.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 181)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 26)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Telefon:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 26)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Fornavn:"
        '
        'txtFirstname
        '
        Me.txtFirstname.Enabled = False
        Me.txtFirstname.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(163, 34)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(170, 33)
        Me.txtFirstname.TabIndex = 45
        '
        'txtLastname
        '
        Me.txtLastname.Enabled = False
        Me.txtLastname.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(163, 82)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(1)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(170, 33)
        Me.txtLastname.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 26)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Etternavn:"
        '
        'txtSSN
        '
        Me.txtSSN.Enabled = False
        Me.txtSSN.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSN.Location = New System.Drawing.Point(163, 130)
        Me.txtSSN.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(170, 33)
        Me.txtSSN.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 26)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Personnummer:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtQuarantine)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtLastDrain)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cbBloodType)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.txtHB)
        Me.GroupBox1.Controls.Add(Me.txtIron)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(396, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(350, 360)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bloddata"
        '
        'txtQuarantine
        '
        Me.txtQuarantine.Enabled = False
        Me.txtQuarantine.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuarantine.Location = New System.Drawing.Point(183, 232)
        Me.txtQuarantine.Margin = New System.Windows.Forms.Padding(1)
        Me.txtQuarantine.Name = "txtQuarantine"
        Me.txtQuarantine.Size = New System.Drawing.Size(150, 33)
        Me.txtQuarantine.TabIndex = 72
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(13, 184)
        Me.Label21.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(122, 26)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "Siste tapping"
        '
        'txtLastDrain
        '
        Me.txtLastDrain.Enabled = False
        Me.txtLastDrain.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastDrain.Location = New System.Drawing.Point(183, 181)
        Me.txtLastDrain.Margin = New System.Windows.Forms.Padding(1)
        Me.txtLastDrain.Name = "txtLastDrain"
        Me.txtLastDrain.Size = New System.Drawing.Size(150, 33)
        Me.txtLastDrain.TabIndex = 70
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(13, 232)
        Me.Label20.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 26)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Karantene:"
        '
        'cbBloodType
        '
        Me.cbBloodType.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBloodType.FormattingEnabled = True
        Me.cbBloodType.Items.AddRange(New Object() {"A Rh-", "A Rh+", "B Rh-", "B Rh+", "AB Rh-", "AB Rh+", "O Rh-", "O Rh+"})
        Me.cbBloodType.Location = New System.Drawing.Point(183, 37)
        Me.cbBloodType.Name = "cbBloodType"
        Me.cbBloodType.Size = New System.Drawing.Size(150, 34)
        Me.cbBloodType.TabIndex = 66
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(38, 298)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(264, 46)
        Me.btnUpdate.TabIndex = 67
        Me.btnUpdate.Text = "Oppdater bloddata"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtHB
        '
        Me.txtHB.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHB.Location = New System.Drawing.Point(183, 85)
        Me.txtHB.Margin = New System.Windows.Forms.Padding(1)
        Me.txtHB.Name = "txtHB"
        Me.txtHB.Size = New System.Drawing.Size(150, 33)
        Me.txtHB.TabIndex = 27
        '
        'txtIron
        '
        Me.txtIron.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIron.Location = New System.Drawing.Point(183, 133)
        Me.txtIron.Margin = New System.Windows.Forms.Padding(1)
        Me.txtIron.Name = "txtIron"
        Me.txtIron.Size = New System.Drawing.Size(150, 33)
        Me.txtIron.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 40)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 26)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Blodtype:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 88)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 26)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Hemoglobin:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 136)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 26)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Jernverdier:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txtSearch)
        Me.GroupBox5.Controls.Add(Me.dgwUsers)
        Me.GroupBox5.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(770, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(767, 650)
        Me.GroupBox5.TabIndex = 65
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Donorinformasjon"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(29, 35)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(249, 23)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "Trykk på en bruker for mer info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(363, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 29)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Filtrer etter blodtype"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(596, 20)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(166, 37)
        Me.txtSearch.TabIndex = 27
        '
        'dgwUsers
        '
        Me.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwUsers.Location = New System.Drawing.Point(15, 74)
        Me.dgwUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.dgwUsers.Name = "dgwUsers"
        Me.dgwUsers.RowTemplate.Height = 28
        Me.dgwUsers.Size = New System.Drawing.Size(747, 571)
        Me.dgwUsers.TabIndex = 21
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 79)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1542, 667)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lagerbeholdning"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtDepartment)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtGetBloodInfo)
        Me.GroupBox4.Controls.Add(Me.txtGetBloodType)
        Me.GroupBox4.Controls.Add(Me.btnGetOrder)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lbShowStock)
        Me.GroupBox4.Controls.Add(Me.txtGetBloodCount)
        Me.GroupBox4.Controls.Add(Me.btnGetBlood)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(248, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1125, 589)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'txtDepartment
        '
        Me.txtDepartment.Enabled = False
        Me.txtDepartment.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(268, 73)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(245, 33)
        Me.txtDepartment.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(122, 76)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 26)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Avdeling"
        '
        'txtGetBloodInfo
        '
        Me.txtGetBloodInfo.Enabled = False
        Me.txtGetBloodInfo.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGetBloodInfo.Location = New System.Drawing.Point(268, 180)
        Me.txtGetBloodInfo.Name = "txtGetBloodInfo"
        Me.txtGetBloodInfo.Size = New System.Drawing.Size(245, 33)
        Me.txtGetBloodInfo.TabIndex = 10
        '
        'txtGetBloodType
        '
        Me.txtGetBloodType.Enabled = False
        Me.txtGetBloodType.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGetBloodType.Location = New System.Drawing.Point(268, 127)
        Me.txtGetBloodType.Name = "txtGetBloodType"
        Me.txtGetBloodType.Size = New System.Drawing.Size(245, 33)
        Me.txtGetBloodType.TabIndex = 9
        '
        'btnGetOrder
        '
        Me.btnGetOrder.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetOrder.Location = New System.Drawing.Point(124, 302)
        Me.btnGetOrder.Name = "btnGetOrder"
        Me.btnGetOrder.Size = New System.Drawing.Size(157, 46)
        Me.btnGetOrder.TabIndex = 8
        Me.btnGetOrder.Text = "Hent bestilling"
        Me.btnGetOrder.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(619, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 29)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Lagerstatus"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(119, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 29)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Bestillinger"
        '
        'lbShowStock
        '
        Me.lbShowStock.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShowStock.FormattingEnabled = True
        Me.lbShowStock.ItemHeight = 24
        Me.lbShowStock.Location = New System.Drawing.Point(624, 65)
        Me.lbShowStock.Name = "lbShowStock"
        Me.lbShowStock.Size = New System.Drawing.Size(396, 508)
        Me.lbShowStock.TabIndex = 3
        '
        'txtGetBloodCount
        '
        Me.txtGetBloodCount.Enabled = False
        Me.txtGetBloodCount.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGetBloodCount.Location = New System.Drawing.Point(268, 235)
        Me.txtGetBloodCount.Name = "txtGetBloodCount"
        Me.txtGetBloodCount.Size = New System.Drawing.Size(245, 33)
        Me.txtGetBloodCount.TabIndex = 5
        '
        'btnGetBlood
        '
        Me.btnGetBlood.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetBlood.Location = New System.Drawing.Point(356, 303)
        Me.btnGetBlood.Name = "btnGetBlood"
        Me.btnGetBlood.Size = New System.Drawing.Size(157, 45)
        Me.btnGetBlood.TabIndex = 3
        Me.btnGetBlood.Text = "Hent fra lager"
        Me.btnGetBlood.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(122, 238)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 26)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Poser (100ml)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(122, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 26)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Blodtype"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(122, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 26)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Blodinfo"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gbCalendar)
        Me.TabPage3.Location = New System.Drawing.Point(4, 79)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1542, 667)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Kalender"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gbCalendar
        '
        Me.gbCalendar.Controls.Add(Me.lblQuarantine)
        Me.gbCalendar.Controls.Add(Me.Label27)
        Me.gbCalendar.Controls.Add(Me.lblVelgtime)
        Me.gbCalendar.Controls.Add(Me.Label22)
        Me.gbCalendar.Controls.Add(Me.Label23)
        Me.gbCalendar.Controls.Add(Me.lblLastDrain)
        Me.gbCalendar.Controls.Add(Me.lblName)
        Me.gbCalendar.Controls.Add(Me.btnVSSN)
        Me.gbCalendar.Controls.Add(Me.txtbxSSNV)
        Me.gbCalendar.Controls.Add(Me.Label24)
        Me.gbCalendar.Controls.Add(Me.btnCApp)
        Me.gbCalendar.Controls.Add(Me.lblnxtApp)
        Me.gbCalendar.Controls.Add(Me.Label25)
        Me.gbCalendar.Controls.Add(Me.DTPOrder)
        Me.gbCalendar.Controls.Add(Me.txtbxTime)
        Me.gbCalendar.Controls.Add(Me.btnOrderApp)
        Me.gbCalendar.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCalendar.Location = New System.Drawing.Point(413, 100)
        Me.gbCalendar.Name = "gbCalendar"
        Me.gbCalendar.Size = New System.Drawing.Size(567, 490)
        Me.gbCalendar.TabIndex = 98
        Me.gbCalendar.TabStop = False
        Me.gbCalendar.Text = "Kalender"
        '
        'lblQuarantine
        '
        Me.lblQuarantine.AutoSize = True
        Me.lblQuarantine.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarantine.Location = New System.Drawing.Point(212, 192)
        Me.lblQuarantine.Name = "lblQuarantine"
        Me.lblQuarantine.Size = New System.Drawing.Size(0, 26)
        Me.lblQuarantine.TabIndex = 103
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(50, 189)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(121, 29)
        Me.Label27.TabIndex = 102
        Me.Label27.Text = "Karantene:"
        '
        'lblVelgtime
        '
        Me.lblVelgtime.AutoSize = True
        Me.lblVelgtime.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelgtime.Location = New System.Drawing.Point(61, 302)
        Me.lblVelgtime.Name = "lblVelgtime"
        Me.lblVelgtime.Size = New System.Drawing.Size(115, 29)
        Me.lblVelgtime.TabIndex = 99
        Me.lblVelgtime.Text = "Velg time: "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(101, 139)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 29)
        Me.Label22.TabIndex = 101
        Me.Label22.Text = "Navn:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(38, 241)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(134, 29)
        Me.Label23.TabIndex = 100
        Me.Label23.Text = "Sist tapping:"
        '
        'lblLastDrain
        '
        Me.lblLastDrain.AutoSize = True
        Me.lblLastDrain.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastDrain.Location = New System.Drawing.Point(212, 244)
        Me.lblLastDrain.Name = "lblLastDrain"
        Me.lblLastDrain.Size = New System.Drawing.Size(18, 26)
        Me.lblLastDrain.TabIndex = 99
        Me.lblLastDrain.Text = "-"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(212, 142)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(18, 26)
        Me.lblName.TabIndex = 97
        Me.lblName.Text = "-"
        '
        'btnVSSN
        '
        Me.btnVSSN.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVSSN.Location = New System.Drawing.Point(428, 75)
        Me.btnVSSN.Name = "btnVSSN"
        Me.btnVSSN.Size = New System.Drawing.Size(110, 35)
        Me.btnVSSN.TabIndex = 96
        Me.btnVSSN.Text = "Se bruker"
        Me.btnVSSN.UseVisualStyleBackColor = True
        '
        'txtbxSSNV
        '
        Me.txtbxSSNV.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSSNV.Location = New System.Drawing.Point(213, 77)
        Me.txtbxSSNV.MaxLength = 11
        Me.txtbxSSNV.Name = "txtbxSSNV"
        Me.txtbxSSNV.Size = New System.Drawing.Size(209, 33)
        Me.txtbxSSNV.TabIndex = 95
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(47, 362)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(125, 29)
        Me.Label24.TabIndex = 94
        Me.Label24.Text = "Neste time:"
        '
        'btnCApp
        '
        Me.btnCApp.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCApp.Location = New System.Drawing.Point(331, 419)
        Me.btnCApp.Name = "btnCApp"
        Me.btnCApp.Size = New System.Drawing.Size(176, 52)
        Me.btnCApp.TabIndex = 73
        Me.btnCApp.Text = "Avbestill"
        Me.btnCApp.UseVisualStyleBackColor = True
        '
        'lblnxtApp
        '
        Me.lblnxtApp.AutoSize = True
        Me.lblnxtApp.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnxtApp.Location = New System.Drawing.Point(208, 365)
        Me.lblnxtApp.Name = "lblnxtApp"
        Me.lblnxtApp.Size = New System.Drawing.Size(120, 26)
        Me.lblnxtApp.TabIndex = 92
        Me.lblnxtApp.Text = "Ikke satt opp"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(2, 80)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(170, 29)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Personnummer:"
        '
        'DTPOrder
        '
        Me.DTPOrder.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPOrder.CustomFormat = "yyyy/MM/dd"
        Me.DTPOrder.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTPOrder.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPOrder.Location = New System.Drawing.Point(213, 298)
        Me.DTPOrder.MaxDate = New Date(3017, 12, 31, 0, 0, 0, 0)
        Me.DTPOrder.MinDate = New Date(2017, 3, 1, 0, 0, 0, 0)
        Me.DTPOrder.Name = "DTPOrder"
        Me.DTPOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPOrder.Size = New System.Drawing.Size(163, 33)
        Me.DTPOrder.TabIndex = 58
        Me.DTPOrder.Value = New Date(2017, 3, 24, 0, 0, 0, 0)
        '
        'txtbxTime
        '
        Me.txtbxTime.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTime.FormattingEnabled = True
        Me.txtbxTime.Items.AddRange(New Object() {"07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30"})
        Me.txtbxTime.Location = New System.Drawing.Point(401, 297)
        Me.txtbxTime.MaxDropDownItems = 12
        Me.txtbxTime.Name = "txtbxTime"
        Me.txtbxTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtbxTime.Size = New System.Drawing.Size(80, 34)
        Me.txtbxTime.TabIndex = 69
        Me.txtbxTime.Text = "08:00"
        '
        'btnOrderApp
        '
        Me.btnOrderApp.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderApp.Location = New System.Drawing.Point(43, 419)
        Me.btnOrderApp.Name = "btnOrderApp"
        Me.btnOrderApp.Size = New System.Drawing.Size(176, 52)
        Me.btnOrderApp.TabIndex = 62
        Me.btnOrderApp.Text = "Sett opp time"
        Me.btnOrderApp.UseVisualStyleBackColor = True
        '
        'btnSignOut
        '
        Me.btnSignOut.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(1168, 22)
        Me.btnSignOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(183, 59)
        Me.btnSignOut.TabIndex = 54
        Me.btnSignOut.Text = "Logg Ut"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tappern.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'EPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Userinformation)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tapper`n"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Userinformation.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgwUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.gbCalendar.ResumeLayout(False)
        Me.gbCalendar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Userinformation As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnSignOut As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtGetBloodCount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnGetBlood As Button
    Friend WithEvents lbShowStock As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnSummons As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegDonation As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSSN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbBloodType As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIron As TextBox
    Friend WithEvents dgwUsers As DataGridView
    Friend WithEvents cbPlasmaCount As ComboBox
    Friend WithEvents cbCellsCount As ComboBox
    Friend WithEvents cbPlateletsCount As ComboBox
    Friend WithEvents btnGetOrder As Button
    Friend WithEvents txtGetBloodInfo As TextBox
    Friend WithEvents txtGetBloodType As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtLastDrain As TextBox
    Friend WithEvents btnStatistics As Button
    Friend WithEvents gbCalendar As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblLastDrain As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnVSSN As Button
    Friend WithEvents txtbxSSNV As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btnCApp As Button
    Friend WithEvents lblnxtApp As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents DTPOrder As DateTimePicker
    Friend WithEvents txtbxTime As ComboBox
    Friend WithEvents btnOrderApp As Button
    Friend WithEvents lblVelgtime As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblQuarantine As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtQuarantine As TextBox
End Class
