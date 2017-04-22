<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Storage
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
        Me.btnDiscardOrder = New System.Windows.Forms.Button()
        Me.btnSendOrders = New System.Windows.Forms.Button()
        Me.btnAddDonation = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrderDetails = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDiscardOrder
        '
        Me.btnDiscardOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscardOrder.Location = New System.Drawing.Point(142, 366)
        Me.btnDiscardOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDiscardOrder.Name = "btnDiscardOrder"
        Me.btnDiscardOrder.Size = New System.Drawing.Size(94, 46)
        Me.btnDiscardOrder.TabIndex = 31
        Me.btnDiscardOrder.Text = "Tøm"
        Me.btnDiscardOrder.UseVisualStyleBackColor = True
        '
        'btnSendOrders
        '
        Me.btnSendOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendOrders.Location = New System.Drawing.Point(35, 366)
        Me.btnSendOrders.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSendOrders.Name = "btnSendOrders"
        Me.btnSendOrders.Size = New System.Drawing.Size(97, 46)
        Me.btnSendOrders.TabIndex = 32
        Me.btnSendOrders.Text = "Send"
        Me.btnSendOrders.UseVisualStyleBackColor = True
        '
        'btnAddDonation
        '
        Me.btnAddDonation.Location = New System.Drawing.Point(495, 356)
        Me.btnAddDonation.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddDonation.Name = "btnAddDonation"
        Me.btnAddDonation.Size = New System.Drawing.Size(164, 91)
        Me.btnAddDonation.TabIndex = 30
        Me.btnAddDonation.Text = "Registrer Donasjon"
        Me.btnAddDonation.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOrderDetails)
        Me.GroupBox1.Controls.Add(Me.txtDepartment)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 72)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(214, 289)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Send Bestilling"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 22)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Ordredetaljer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Avdeling"
        '
        'txtOrderDetails
        '
        Me.txtOrderDetails.AllowDrop = True
        Me.txtOrderDetails.Location = New System.Drawing.Point(5, 138)
        Me.txtOrderDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrderDetails.Multiline = True
        Me.txtOrderDetails.Name = "txtOrderDetails"
        Me.txtOrderDetails.Size = New System.Drawing.Size(202, 146)
        Me.txtOrderDetails.TabIndex = 22
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(5, 63)
        Me.txtDepartment.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(202, 35)
        Me.txtDepartment.TabIndex = 21
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(763, 72)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 39)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Tilbake"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Storage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 569)
        Me.Controls.Add(Me.btnDiscardOrder)
        Me.Controls.Add(Me.btnSendOrders)
        Me.Controls.Add(Me.btnAddDonation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Storage"
        Me.Text = "Storage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDiscardOrder As Button
    Friend WithEvents btnSendOrders As Button
    Friend WithEvents btnAddDonation As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOrderDetails As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Button3 As Button
End Class
