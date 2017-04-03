<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPersonnr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPostnr = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RegError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.RegError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(488, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Etternavn:"
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(586, 66)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(196, 26)
        Me.txtLastname.TabIndex = 2
        Me.txtLastname.Tag = "Fyll inn ditt etternavn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fornavn:"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(208, 66)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(188, 26)
        Me.txtFirstname.TabIndex = 1
        Me.txtFirstname.Tag = "Fyll inn ditt fornavn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 134)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Personnummer (11 siffer):"
        '
        'txtPersonnr
        '
        Me.txtPersonnr.Location = New System.Drawing.Point(208, 131)
        Me.txtPersonnr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPersonnr.Name = "txtPersonnr"
        Me.txtPersonnr.Size = New System.Drawing.Size(188, 26)
        Me.txtPersonnr.TabIndex = 3
        Me.txtPersonnr.Tag = "Fyll inn ditt personnummer (11)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 192)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Privatadresse:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 30
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(208, 188)
        Me.txtAdress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(188, 26)
        Me.txtAdress.TabIndex = 5
        Me.txtAdress.Tag = "Fyll inn din adresse"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(470, 134)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 20)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Postnummer:"
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(586, 129)
        Me.txtPostnr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(196, 26)
        Me.txtPostnr.TabIndex = 4
        Me.txtPostnr.Tag = "Fyll inn ditt postnummer"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(586, 252)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(196, 26)
        Me.txtConfirmPassword.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(446, 257)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 20)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Bekreft Passord:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(208, 252)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(188, 26)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.Tag = "Fyll inn ditt passord"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(586, 188)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(196, 26)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.Tag = "Fyll inn din epostadresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(462, 192)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 20)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Epostadresse:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 255)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Passord:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(208, 312)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhone.MaxLength = 8
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(188, 26)
        Me.txtPhone.TabIndex = 9
        Me.txtPhone.Tag = "Fyll inn dit telefonnummer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 315)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Telefon:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(430, 412)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 35)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Tilbake"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 412)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 35)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Registrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RegError
        '
        Me.RegError.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbFemale)
        Me.GroupBox1.Controls.Add(Me.rbMale)
        Me.GroupBox1.Location = New System.Drawing.Point(586, 312)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 42)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(6, 12)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(74, 24)
        Me.rbMale.TabIndex = 12
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Mann"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(82, 13)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(81, 24)
        Me.rbFemale.TabIndex = 13
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Kvinne"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(517, 328)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 20)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Kjønn:"
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 507)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPostnr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPersonnr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastname)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "NewUser"
        Me.Text = "NewUser"
        CType(Me.RegError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPersonnr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPostnr As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RegError As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents Label11 As Label
End Class
