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
        Me.Regbox = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtyob = New System.Windows.Forms.TextBox()
        Me.TxtDoB = New System.Windows.Forms.TextBox()
        Me.Txtmob = New System.Windows.Forms.TextBox()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.RegError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Regbox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(736, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 29)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Etternavn:"
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(857, 201)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(236, 37)
        Me.txtLastname.TabIndex = 2
        Me.txtLastname.Tag = "Fyll inn ditt etternavn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 29)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fornavn:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(385, 201)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(248, 37)
        Me.txtFirstname.TabIndex = 1
        Me.txtFirstname.Tag = "Fyll inn ditt fornavn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(102, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(266, 29)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Personnummer (11 siffer):"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPersonnr
        '
        Me.txtPersonnr.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonnr.Location = New System.Drawing.Point(385, 243)
        Me.txtPersonnr.MaxLength = 11
        Me.txtPersonnr.Name = "txtPersonnr"
        Me.txtPersonnr.Size = New System.Drawing.Size(248, 37)
        Me.txtPersonnr.TabIndex = 3
        Me.txtPersonnr.Tag = "Fyll inn ditt personnummer (11)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(272, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 29)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Adresse:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(416, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 30
        '
        'txtAdress
        '
        Me.txtAdress.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdress.Location = New System.Drawing.Point(385, 285)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(248, 37)
        Me.txtAdress.TabIndex = 5
        Me.txtAdress.Tag = "Fyll inn din adresse"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(760, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 29)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Postnr.:"
        '
        'txtPostnr
        '
        Me.txtPostnr.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostnr.Location = New System.Drawing.Point(857, 285)
        Me.txtPostnr.MaxLength = 4
        Me.txtPostnr.Name = "txtPostnr"
        Me.txtPostnr.Size = New System.Drawing.Size(236, 37)
        Me.txtPostnr.TabIndex = 4
        Me.txtPostnr.Tag = "Fyll inn ditt postnummer"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(857, 369)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(236, 37)
        Me.txtConfirmPassword.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(679, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 29)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Bekreft passord:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(385, 369)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(248, 37)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.Tag = "Fyll inn ditt passord"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(385, 327)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(248, 37)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.Tag = "Fyll inn din epostadresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(219, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 29)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Epostadresse:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(274, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 29)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Passord:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(857, 327)
        Me.txtPhone.MaxLength = 8
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(236, 37)
        Me.txtPhone.TabIndex = 9
        Me.txtPhone.Tag = "Fyll inn dit telefonnummer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(760, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 29)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Telefon:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(494, 539)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 42)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Tilbake"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(648, 539)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 42)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Registrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RegError
        '
        Me.RegError.ContainerControl = Me
        '
        'Regbox
        '
        Me.Regbox.Controls.Add(Me.PictureBox1)
        Me.Regbox.Controls.Add(Me.Label14)
        Me.Regbox.Controls.Add(Me.txtyob)
        Me.Regbox.Controls.Add(Me.TxtDoB)
        Me.Regbox.Controls.Add(Me.Txtmob)
        Me.Regbox.Controls.Add(Me.rbFemale)
        Me.Regbox.Controls.Add(Me.rbMale)
        Me.Regbox.Controls.Add(Me.Label11)
        Me.Regbox.Controls.Add(Me.txtLastname)
        Me.Regbox.Controls.Add(Me.Label1)
        Me.Regbox.Controls.Add(Me.Button2)
        Me.Regbox.Controls.Add(Me.txtFirstname)
        Me.Regbox.Controls.Add(Me.Button1)
        Me.Regbox.Controls.Add(Me.Label2)
        Me.Regbox.Controls.Add(Me.txtConfirmPassword)
        Me.Regbox.Controls.Add(Me.txtPersonnr)
        Me.Regbox.Controls.Add(Me.Label10)
        Me.Regbox.Controls.Add(Me.Label5)
        Me.Regbox.Controls.Add(Me.txtPassword)
        Me.Regbox.Controls.Add(Me.txtAdress)
        Me.Regbox.Controls.Add(Me.txtEmail)
        Me.Regbox.Controls.Add(Me.Label7)
        Me.Regbox.Controls.Add(Me.Label9)
        Me.Regbox.Controls.Add(Me.txtPostnr)
        Me.Regbox.Controls.Add(Me.Label6)
        Me.Regbox.Controls.Add(Me.Label8)
        Me.Regbox.Controls.Add(Me.txtPhone)
        Me.Regbox.Controls.Add(Me.Label4)
        Me.Regbox.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regbox.Location = New System.Drawing.Point(12, 9)
        Me.Regbox.Name = "Regbox"
        Me.Regbox.Size = New System.Drawing.Size(1300, 750)
        Me.Regbox.TabIndex = 47
        Me.Regbox.TabStop = False
        Me.Regbox.Text = "Registreringsskjema"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(713, 246)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 29)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Fødselsdato:"
        '
        'txtyob
        '
        Me.txtyob.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyob.Location = New System.Drawing.Point(993, 243)
        Me.txtyob.MaxLength = 4
        Me.txtyob.Name = "txtyob"
        Me.txtyob.Size = New System.Drawing.Size(100, 37)
        Me.txtyob.TabIndex = 57
        Me.txtyob.Text = "ÅÅÅÅ"
        Me.txtyob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDoB
        '
        Me.TxtDoB.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoB.Location = New System.Drawing.Point(857, 243)
        Me.TxtDoB.MaxLength = 2
        Me.TxtDoB.Name = "TxtDoB"
        Me.TxtDoB.Size = New System.Drawing.Size(67, 37)
        Me.TxtDoB.TabIndex = 56
        Me.TxtDoB.Text = "DD"
        Me.TxtDoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtmob
        '
        Me.Txtmob.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmob.Location = New System.Drawing.Point(930, 243)
        Me.Txtmob.MaxLength = 2
        Me.Txtmob.Name = "Txtmob"
        Me.Txtmob.Size = New System.Drawing.Size(57, 37)
        Me.Txtmob.TabIndex = 55
        Me.Txtmob.Text = "MM"
        Me.Txtmob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFemale.Location = New System.Drawing.Point(470, 445)
        Me.rbFemale.Margin = New System.Windows.Forms.Padding(2)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(97, 33)
        Me.rbFemale.TabIndex = 13
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Kvinne"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMale.Location = New System.Drawing.Point(376, 445)
        Me.rbMale.Margin = New System.Windows.Forms.Padding(2)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(90, 33)
        Me.rbMale.TabIndex = 12
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Mann"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(283, 445)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 29)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Kjønn:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Label12"
        Me.Label12.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TestDoc.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(955, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 750)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Regbox)
        Me.Controls.Add(Me.Label3)
        Me.Name = "NewUser"
        Me.Text = "NewUser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RegError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Regbox.ResumeLayout(False)
        Me.Regbox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Regbox As GroupBox
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtyob As TextBox
    Friend WithEvents TxtDoB As TextBox
    Friend WithEvents Txtmob As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
