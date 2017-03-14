<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeLogIn
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btbLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtAnsattnr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(442, 154)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "LOGG INN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 305)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Passord"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 231)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 25)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Ansattnummer"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(513, 370)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(138, 42)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btbLogin
        '
        Me.btbLogin.Location = New System.Drawing.Point(341, 370)
        Me.btbLogin.Margin = New System.Windows.Forms.Padding(6)
        Me.btbLogin.Name = "btbLogin"
        Me.btbLogin.Size = New System.Drawing.Size(138, 42)
        Me.btbLogin.TabIndex = 41
        Me.btbLogin.Text = "Login"
        Me.btbLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(488, 302)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(164, 29)
        Me.txtPassword.TabIndex = 40
        '
        'txtAnsattnr
        '
        Me.txtAnsattnr.Location = New System.Drawing.Point(488, 228)
        Me.txtAnsattnr.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAnsattnr.Name = "txtAnsattnr"
        Me.txtAnsattnr.Size = New System.Drawing.Size(164, 29)
        Me.txtAnsattnr.TabIndex = 39
        '
        'EmployeeLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 628)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btbLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtAnsattnr)
        Me.Name = "EmployeeLogIn"
        Me.Text = "EmployeeLogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btbLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtAnsattnr As TextBox
End Class
