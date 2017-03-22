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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
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
        Me.btnDiscardOrder.Location = New System.Drawing.Point(174, 439)
        Me.btnDiscardOrder.Name = "btnDiscardOrder"
        Me.btnDiscardOrder.Size = New System.Drawing.Size(115, 55)
        Me.btnDiscardOrder.TabIndex = 31
        Me.btnDiscardOrder.Text = "Tøm"
        Me.btnDiscardOrder.UseVisualStyleBackColor = True
        '
        'btnSendOrders
        '
        Me.btnSendOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendOrders.Location = New System.Drawing.Point(43, 439)
        Me.btnSendOrders.Name = "btnSendOrders"
        Me.btnSendOrders.Size = New System.Drawing.Size(119, 55)
        Me.btnSendOrders.TabIndex = 32
        Me.btnSendOrders.Text = "Send"
        Me.btnSendOrders.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 49)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Location = New System.Drawing.Point(865, 396)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(190, 268)
        Me.ListBox1.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOrderDetails)
        Me.GroupBox1.Controls.Add(Me.txtDepartment)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 347)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Send Bestilling"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Ordredetaljer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Avdeling"
        '
        'txtOrderDetails
        '
        Me.txtOrderDetails.AllowDrop = True
        Me.txtOrderDetails.Location = New System.Drawing.Point(6, 166)
        Me.txtOrderDetails.Multiline = True
        Me.txtOrderDetails.Name = "txtOrderDetails"
        Me.txtOrderDetails.Size = New System.Drawing.Size(246, 174)
        Me.txtOrderDetails.TabIndex = 22
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(6, 76)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(246, 39)
        Me.txtDepartment.TabIndex = 21
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(932, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 47)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Tilbake"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Storage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 683)
        Me.Controls.Add(Me.btnDiscardOrder)
        Me.Controls.Add(Me.btnSendOrders)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "Storage"
        Me.Text = "Storage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDiscardOrder As Button
    Friend WithEvents btnSendOrders As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOrderDetails As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Button3 As Button
End Class
