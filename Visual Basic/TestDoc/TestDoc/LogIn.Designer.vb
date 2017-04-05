<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPersonnr = New System.Windows.Forms.TextBox()
        Me.loginerror = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.loginerror, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 282)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 52)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Passord:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 197)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 52)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Brukernavn:"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLogin.Location = New System.Drawing.Point(554, 352)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(290, 94)
        Me.btnLogin.TabIndex = 42
        Me.btnLogin.Text = "Logg Inn"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(477, 282)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(421, 57)
        Me.txtPassword.TabIndex = 41
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtPersonnr
        '
        Me.txtPersonnr.Location = New System.Drawing.Point(477, 197)
        Me.txtPersonnr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPersonnr.Name = "txtPersonnr"
        Me.txtPersonnr.Size = New System.Drawing.Size(421, 57)
        Me.txtPersonnr.TabIndex = 40
        Me.txtPersonnr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'loginerror
        '
        Me.loginerror.ContainerControl = Me
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(576, 491)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(238, 33)
        Me.LinkLabel1.TabIndex = 47
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Registrer deg nå!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 33)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Lyst til å bli blodgiver?"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtPersonnr)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(111, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1136, 643)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Logg Inn"
        '
        'LogIn
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1282, 745)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LogIn"
        Me.Text = "Logg In"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.loginerror, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPersonnr As TextBox
    Friend WithEvents loginerror As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
End Class
