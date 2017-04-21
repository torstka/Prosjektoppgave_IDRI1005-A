<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MailForm
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
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtMail = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTime = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(156, 132)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(166, 20)
        Me.txtEmail.TabIndex = 0
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(156, 57)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(166, 20)
        Me.txtFirstname.TabIndex = 1
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(156, 96)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(166, 20)
        Me.txtLastname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Epost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fornavn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Etternavn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(156, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 38)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtMail
        '
        Me.dtMail.Location = New System.Drawing.Point(156, 173)
        Me.dtMail.Name = "dtMail"
        Me.dtMail.Size = New System.Drawing.Size(166, 20)
        Me.dtMail.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Dato"
        '
        'cbTime
        '
        Me.cbTime.FormattingEnabled = True
        Me.cbTime.Items.AddRange(New Object() {"07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30"})
        Me.cbTime.Location = New System.Drawing.Point(156, 213)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.Size = New System.Drawing.Size(56, 21)
        Me.cbTime.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Klokkeslett"
        '
        'MailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 349)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtMail)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtEmail)
        Me.Name = "MailForm"
        Me.Text = "MailForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dtMail As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTime As ComboBox
    Friend WithEvents Label5 As Label
End Class
