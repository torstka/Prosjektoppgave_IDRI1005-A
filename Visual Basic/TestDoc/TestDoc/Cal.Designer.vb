<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cal
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBApp = New System.Windows.Forms.ListBox()
        Me.can = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.day_p_time = New System.Windows.Forms.Label()
        Me.btnCApp = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.nxtApp = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTPOrder = New System.Windows.Forms.DateTimePicker()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbxTime = New System.Windows.Forms.ComboBox()
        Me.lblNxtApp = New System.Windows.Forms.Label()
        Me.lblODate = New System.Windows.Forms.Label()
        Me.BtnOrderApp = New System.Windows.Forms.Button()
        Me.lblOTime = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBApp)
        Me.GroupBox2.Location = New System.Drawing.Point(329, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 181)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Neste Tapping"
        '
        'LBApp
        '
        Me.LBApp.FormattingEnabled = True
        Me.LBApp.Location = New System.Drawing.Point(32, 19)
        Me.LBApp.Name = "LBApp"
        Me.LBApp.ScrollAlwaysVisible = True
        Me.LBApp.Size = New System.Drawing.Size(252, 43)
        Me.LBApp.TabIndex = 78
        '
        'can
        '
        Me.can.AutoSize = True
        Me.can.Location = New System.Drawing.Point(163, 257)
        Me.can.Name = "can"
        Me.can.Size = New System.Drawing.Size(59, 13)
        Me.can.TabIndex = 74
        Me.can.Text = "CanCancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Neste time:"
        '
        'day_p_time
        '
        Me.day_p_time.AutoSize = True
        Me.day_p_time.Location = New System.Drawing.Point(163, 236)
        Me.day_p_time.Name = "day_p_time"
        Me.day_p_time.Size = New System.Drawing.Size(142, 13)
        Me.day_p_time.TabIndex = 93
        Me.day_p_time.Text = "day + "" "" + time satt sammen"
        '
        'btnCApp
        '
        Me.btnCApp.Location = New System.Drawing.Point(14, 257)
        Me.btnCApp.Name = "btnCApp"
        Me.btnCApp.Size = New System.Drawing.Size(75, 23)
        Me.btnCApp.TabIndex = 73
        Me.btnCApp.Text = "Avbestill"
        Me.btnCApp.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.can)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.day_p_time)
        Me.GroupBox3.Controls.Add(Me.btnCApp)
        Me.GroupBox3.Controls.Add(Me.nxtApp)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DTPOrder)
        Me.GroupBox3.Controls.Add(Me.lblSSN)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtbxTime)
        Me.GroupBox3.Controls.Add(Me.lblNxtApp)
        Me.GroupBox3.Controls.Add(Me.lblODate)
        Me.GroupBox3.Controls.Add(Me.BtnOrderApp)
        Me.GroupBox3.Controls.Add(Me.lblOTime)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(311, 286)
        Me.GroupBox3.TabIndex = 93
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'nxtApp
        '
        Me.nxtApp.AutoSize = True
        Me.nxtApp.Location = New System.Drawing.Point(175, 196)
        Me.nxtApp.Name = "nxtApp"
        Me.nxtApp.Size = New System.Drawing.Size(69, 13)
        Me.nxtApp.TabIndex = 92
        Me.nxtApp.Text = "Ikke satt opp"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "person nummer"
        '
        'DTPOrder
        '
        Me.DTPOrder.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPOrder.CustomFormat = "yyyy/MM/dd"
        Me.DTPOrder.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTPOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPOrder.Location = New System.Drawing.Point(14, 78)
        Me.DTPOrder.MaxDate = New Date(3017, 12, 31, 0, 0, 0, 0)
        Me.DTPOrder.MinDate = New Date(2017, 3, 1, 0, 0, 0, 0)
        Me.DTPOrder.Name = "DTPOrder"
        Me.DTPOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPOrder.Size = New System.Drawing.Size(163, 31)
        Me.DTPOrder.TabIndex = 58
        Me.DTPOrder.Value = New Date(2017, 3, 24, 0, 0, 0, 0)
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(96, 20)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(73, 13)
        Me.lblSSN.TabIndex = 63
        Me.lblSSN.Text = "22119611122"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Time:"
        '
        'txtbxTime
        '
        Me.txtbxTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTime.FormattingEnabled = True
        Me.txtbxTime.Items.AddRange(New Object() {"07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30"})
        Me.txtbxTime.Location = New System.Drawing.Point(192, 78)
        Me.txtbxTime.MaxDropDownItems = 12
        Me.txtbxTime.Name = "txtbxTime"
        Me.txtbxTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtbxTime.Size = New System.Drawing.Size(71, 28)
        Me.txtbxTime.TabIndex = 69
        Me.txtbxTime.Text = "08:00"
        '
        'lblNxtApp
        '
        Me.lblNxtApp.AutoSize = True
        Me.lblNxtApp.Location = New System.Drawing.Point(106, 163)
        Me.lblNxtApp.Name = "lblNxtApp"
        Me.lblNxtApp.Size = New System.Drawing.Size(60, 13)
        Me.lblNxtApp.TabIndex = 70
        Me.lblNxtApp.Text = "Bestilt time:"
        Me.lblNxtApp.Visible = False
        '
        'lblODate
        '
        Me.lblODate.AutoSize = True
        Me.lblODate.Location = New System.Drawing.Point(177, 163)
        Me.lblODate.Name = "lblODate"
        Me.lblODate.Size = New System.Drawing.Size(0, 13)
        Me.lblODate.TabIndex = 71
        '
        'BtnOrderApp
        '
        Me.BtnOrderApp.Location = New System.Drawing.Point(14, 158)
        Me.BtnOrderApp.Name = "BtnOrderApp"
        Me.BtnOrderApp.Size = New System.Drawing.Size(75, 23)
        Me.BtnOrderApp.TabIndex = 62
        Me.BtnOrderApp.Text = "Bestill Time"
        Me.BtnOrderApp.UseVisualStyleBackColor = True
        '
        'lblOTime
        '
        Me.lblOTime.AutoSize = True
        Me.lblOTime.Location = New System.Drawing.Point(244, 163)
        Me.lblOTime.Name = "lblOTime"
        Me.lblOTime.Size = New System.Drawing.Size(0, 13)
        Me.lblOTime.TabIndex = 72
        '
        'Cal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 344)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Cal"
        Me.Text = "Cal"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LBApp As ListBox
    Friend WithEvents can As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents day_p_time As Label
    Friend WithEvents btnCApp As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents nxtApp As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DTPOrder As DateTimePicker
    Friend WithEvents lblSSN As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxTime As ComboBox
    Friend WithEvents lblNxtApp As Label
    Friend WithEvents lblODate As Label
    Friend WithEvents BtnOrderApp As Button
    Friend WithEvents lblOTime As Label
End Class
