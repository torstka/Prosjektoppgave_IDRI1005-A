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
        Me.Userinformation = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnRegDonation = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBloodCount = New System.Windows.Forms.TextBox()
        Me.cbBloodPart = New System.Windows.Forms.ComboBox()
        Me.btnUpdateData = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbBloodType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIron = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtGetBloodCount = New System.Windows.Forms.TextBox()
        Me.btnGetBlood = New System.Windows.Forms.Button()
        Me.cbGetBloodType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbGetBloodInfo = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.lbShowStock = New System.Windows.Forms.ListBox()
        Me.Userinformation.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Userinformation
        '
        Me.Userinformation.Controls.Add(Me.TabPage1)
        Me.Userinformation.Controls.Add(Me.TabPage2)
        Me.Userinformation.Controls.Add(Me.TabPage3)
        Me.Userinformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userinformation.Location = New System.Drawing.Point(90, 11)
        Me.Userinformation.Margin = New System.Windows.Forms.Padding(2)
        Me.Userinformation.Name = "Userinformation"
        Me.Userinformation.Padding = New System.Drawing.Point(39, 20)
        Me.Userinformation.SelectedIndex = 0
        Me.Userinformation.Size = New System.Drawing.Size(1200, 700)
        Me.Userinformation.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.btnUpdateData)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 74)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1192, 622)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.btnRegDonation)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtBloodCount)
        Me.GroupBox3.Controls.Add(Me.cbBloodPart)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(18, 306)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 296)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Donasjon"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(452, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 29)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "dl"
        '
        'btnRegDonation
        '
        Me.btnRegDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegDonation.Location = New System.Drawing.Point(258, 219)
        Me.btnRegDonation.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegDonation.Name = "btnRegDonation"
        Me.btnRegDonation.Size = New System.Drawing.Size(188, 55)
        Me.btnRegDonation.TabIndex = 60
        Me.btnRegDonation.Text = "Registrer donasjon"
        Me.btnRegDonation.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(90, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 29)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Mengde"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 29)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Blodinfo"
        '
        'txtBloodCount
        '
        Me.txtBloodCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBloodCount.Location = New System.Drawing.Point(258, 147)
        Me.txtBloodCount.Name = "txtBloodCount"
        Me.txtBloodCount.Size = New System.Drawing.Size(188, 32)
        Me.txtBloodCount.TabIndex = 62
        '
        'cbBloodPart
        '
        Me.cbBloodPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBloodPart.FormattingEnabled = True
        Me.cbBloodPart.Items.AddRange(New Object() {"Blodlegemer", "Blodplater", "Blodplasma"})
        Me.cbBloodPart.Location = New System.Drawing.Point(258, 78)
        Me.cbBloodPart.Name = "cbBloodPart"
        Me.cbBloodPart.Size = New System.Drawing.Size(188, 33)
        Me.cbBloodPart.TabIndex = 61
        '
        'btnUpdateData
        '
        Me.btnUpdateData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateData.Location = New System.Drawing.Point(323, 245)
        Me.btnUpdateData.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUpdateData.Name = "btnUpdateData"
        Me.btnUpdateData.Size = New System.Drawing.Size(237, 46)
        Me.btnUpdateData.TabIndex = 58
        Me.btnUpdateData.Text = "Oppdater bloddata"
        Me.btnUpdateData.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPhone)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtFirstname)
        Me.GroupBox2.Controls.Add(Me.txtLastname)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtSSN)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 30)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(270, 200)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Brukerinfo"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(152, 155)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(115, 26)
        Me.txtPhone.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 157)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 24)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Telefon:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Fornavn:"
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(152, 34)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(115, 26)
        Me.txtFirstname.TabIndex = 45
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(152, 75)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(1)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(115, 26)
        Me.txtLastname.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Etternavn:"
        '
        'txtSSN
        '
        Me.txtSSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSN.Location = New System.Drawing.Point(152, 115)
        Me.txtSSN.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(115, 26)
        Me.txtSSN.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 24)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Personnummer:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbBloodType)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtHB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtIron)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(307, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(270, 200)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bloddata"
        '
        'cbBloodType
        '
        Me.cbBloodType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBloodType.FormattingEnabled = True
        Me.cbBloodType.Items.AddRange(New Object() {"A Rh-", "A Rh+", "B Rh-", "B Rh+", "AB Rh-", "AB Rh+", "O Rh-", "O Rh+"})
        Me.cbBloodType.Location = New System.Drawing.Point(154, 32)
        Me.cbBloodType.Name = "cbBloodType"
        Me.cbBloodType.Size = New System.Drawing.Size(111, 28)
        Me.cbBloodType.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 81)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 24)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Hemoglobin:"
        '
        'txtHB
        '
        Me.txtHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHB.Location = New System.Drawing.Point(154, 79)
        Me.txtHB.Margin = New System.Windows.Forms.Padding(1)
        Me.txtHB.Name = "txtHB"
        Me.txtHB.Size = New System.Drawing.Size(113, 26)
        Me.txtHB.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 38)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Blodtype:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 129)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 24)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Jernverdier:"
        '
        'txtIron
        '
        Me.txtIron.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIron.Location = New System.Drawing.Point(154, 127)
        Me.txtIron.Margin = New System.Windows.Forms.Padding(1)
        Me.txtIron.Name = "txtIron"
        Me.txtIron.Size = New System.Drawing.Size(113, 26)
        Me.txtIron.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(769, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 29)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Filtrer etter blodtype"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1002, 4)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(186, 35)
        Me.txtSearch.TabIndex = 25
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(596, 48)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(590, 570)
        Me.DataGridView1.TabIndex = 21
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbShowStock)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 74)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1192, 622)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtGetBloodCount)
        Me.GroupBox4.Controls.Add(Me.btnGetBlood)
        Me.GroupBox4.Controls.Add(Me.cbGetBloodType)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.cbGetBloodInfo)
        Me.GroupBox4.Location = New System.Drawing.Point(126, 43)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(497, 563)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hent fra lager"
        '
        'txtGetBloodCount
        '
        Me.txtGetBloodCount.Location = New System.Drawing.Point(216, 283)
        Me.txtGetBloodCount.Name = "txtGetBloodCount"
        Me.txtGetBloodCount.Size = New System.Drawing.Size(245, 38)
        Me.txtGetBloodCount.TabIndex = 5
        '
        'btnGetBlood
        '
        Me.btnGetBlood.Location = New System.Drawing.Point(216, 352)
        Me.btnGetBlood.Name = "btnGetBlood"
        Me.btnGetBlood.Size = New System.Drawing.Size(245, 82)
        Me.btnGetBlood.TabIndex = 3
        Me.btnGetBlood.Text = "Hent blod fra lager"
        Me.btnGetBlood.UseVisualStyleBackColor = True
        '
        'cbGetBloodType
        '
        Me.cbGetBloodType.FormattingEnabled = True
        Me.cbGetBloodType.Items.AddRange(New Object() {"A Rh-", "A Rh+", "B Rh-", "B Rh+", "AB Rh-", "AB Rh+", "O Rh-", "O Rh+"})
        Me.cbGetBloodType.Location = New System.Drawing.Point(216, 181)
        Me.cbGetBloodType.Name = "cbGetBloodType"
        Me.cbGetBloodType.Size = New System.Drawing.Size(245, 39)
        Me.cbGetBloodType.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 290)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(157, 31)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Mengde (dl)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 189)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 31)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Blodtype"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 31)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Blodinfo"
        '
        'cbGetBloodInfo
        '
        Me.cbGetBloodInfo.FormattingEnabled = True
        Me.cbGetBloodInfo.Items.AddRange(New Object() {"Blodlegemer", "Blodplater", "Blodplasma"})
        Me.cbGetBloodInfo.Location = New System.Drawing.Point(216, 99)
        Me.cbGetBloodInfo.Name = "cbGetBloodInfo"
        Me.cbGetBloodInfo.Size = New System.Drawing.Size(245, 39)
        Me.cbGetBloodInfo.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 74)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1192, 622)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnSignOut
        '
        Me.btnSignOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(1168, 22)
        Me.btnSignOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(183, 59)
        Me.btnSignOut.TabIndex = 54
        Me.btnSignOut.Text = "Logg Ut"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'lbShowStock
        '
        Me.lbShowStock.FormattingEnabled = True
        Me.lbShowStock.ItemHeight = 31
        Me.lbShowStock.Location = New System.Drawing.Point(811, 43)
        Me.lbShowStock.Name = "lbShowStock"
        Me.lbShowStock.Size = New System.Drawing.Size(321, 500)
        Me.lbShowStock.TabIndex = 3
        '
        'EPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1447, 811)
        Me.Controls.Add(Me.Userinformation)
        Me.Controls.Add(Me.btnSignOut)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EPage"
        Me.Text = "EPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Userinformation.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Userinformation As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSignOut As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSSN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHB As TextBox
    Friend WithEvents txtIron As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnUpdateData As Button
    Friend WithEvents btnRegDonation As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBloodCount As TextBox
    Friend WithEvents cbBloodPart As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtGetBloodCount As TextBox
    Friend WithEvents cbGetBloodType As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbGetBloodInfo As ComboBox
    Friend WithEvents cbBloodType As ComboBox
    Friend WithEvents btnGetBlood As Button
    Friend WithEvents lbShowStock As ListBox
End Class
