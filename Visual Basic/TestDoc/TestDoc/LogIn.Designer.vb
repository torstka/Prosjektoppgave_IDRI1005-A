<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btbRegistrer = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btbLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPersonnr = New System.Windows.Forms.TextBox()
        Me.loginerror = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.loginerror, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "LOGG INN"
        '
        'btbRegistrer
        '
        Me.btbRegistrer.Location = New System.Drawing.Point(158, 198)
        Me.btbRegistrer.Name = "btbRegistrer"
        Me.btbRegistrer.Size = New System.Drawing.Size(170, 23)
        Me.btbRegistrer.TabIndex = 46
        Me.btbRegistrer.Text = "Registrer deg"
        Me.btbRegistrer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Passord"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Personnummer"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(252, 169)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btbLogin
        '
        Me.btbLogin.Location = New System.Drawing.Point(158, 169)
        Me.btbLogin.Name = "btbLogin"
        Me.btbLogin.Size = New System.Drawing.Size(75, 23)
        Me.btbLogin.TabIndex = 42
        Me.btbLogin.Text = "Login"
        Me.btbLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(238, 132)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(91, 20)
        Me.txtPassword.TabIndex = 41
        Me.txtPassword.Text = "markus123"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtPersonnr
        '
        Me.txtPersonnr.Location = New System.Drawing.Point(238, 92)
        Me.txtPersonnr.Name = "txtPersonnr"
        Me.txtPersonnr.Size = New System.Drawing.Size(91, 20)
        Me.txtPersonnr.TabIndex = 40
        Me.txtPersonnr.Text = "11111111111"
        '
        'loginerror
        '
        Me.loginerror.ContainerControl = Me
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 295)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btbRegistrer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btbLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPersonnr)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LogIn"
        Me.Text = "LogIn"
        CType(Me.loginerror, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btbRegistrer As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btbLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPersonnr As TextBox
    Friend WithEvents loginerror As ErrorProvider
End Class
