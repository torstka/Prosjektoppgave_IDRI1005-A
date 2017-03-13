<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logged_In
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Imprint MT Shadow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(136, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(315, 170)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Spørre Skjema"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Imprint MT Shadow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(562, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(329, 170)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Min Side"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Velkommen inn!"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(848, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 46)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Logg ut"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Logged_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 531)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Logged_In"
        Me.Text = "Logged_In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
