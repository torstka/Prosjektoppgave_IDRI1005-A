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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        CType(Me.RegError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Etternavn:"
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(391, 43)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(132, 20)
        Me.txtLastname.TabIndex = 19
        Me.txtLastname.Tag = "Fyll inn ditt etternavn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "First name:"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(139, 43)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(127, 20)
        Me.txtFirstname.TabIndex = 21
        Me.txtFirstname.Tag = "Fyll inn ditt fornavn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Personnummer (11 siffer):"
        '
        'txtPersonnr
        '
        Me.txtPersonnr.Location = New System.Drawing.Point(139, 85)
        Me.txtPersonnr.Name = "txtPersonnr"
        Me.txtPersonnr.Size = New System.Drawing.Size(127, 20)
        Me.txtPersonnr.TabIndex = 25
        Me.txtPersonnr.Tag = "Fyll inn ditt personnummer (11)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Privatadresse:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 30
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(139, 122)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(127, 20)
        Me.txtAdress.TabIndex = 29
        Me.txtAdress.Tag = "Fyll inn din adresse"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(317, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Postnummer"
        '
        'txtPostnr
        '
        Me.txtPostnr.Location = New System.Drawing.Point(391, 84)
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(132, 20)
        Me.txtPostnr.TabIndex = 32
        Me.txtPostnr.Tag = "Fyll inn ditt postnummer"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(391, 164)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(132, 20)
        Me.txtConfirmPassword.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(302, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Bekreft Passord"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(139, 203)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(127, 20)
        Me.txtPassword.TabIndex = 40
        Me.txtPassword.Tag = "Fyll inn ditt passord"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(391, 122)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(132, 20)
        Me.txtEmail.TabIndex = 39
        Me.txtEmail.Tag = "Fyll inn din epostadresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(310, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Epostadresse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Passord:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(139, 162)
        Me.txtPhone.MaxLength = 8
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(127, 20)
        Me.txtPhone.TabIndex = 36
        Me.txtPhone.Tag = "Fyll inn dit telefonnummer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Telefon:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 23)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Tilbake"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(191, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 23)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Registrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RegError
        '
        Me.RegError.ContainerControl = Me
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(348, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Kjønn"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(396, 209)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton1.TabIndex = 46
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Mann"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(462, 210)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton2.TabIndex = 47
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Kvinne"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 336)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
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
        Me.Name = "NewUser"
        Me.Text = "NewUser"
        CType(Me.RegError, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label11 As Label
End Class
