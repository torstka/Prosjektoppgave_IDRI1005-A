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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTPOrder = New System.Windows.Forms.DateTimePicker()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbxTime = New System.Windows.Forms.ComboBox()
        Me.lblNxtApp = New System.Windows.Forms.Label()
        Me.lblODate = New System.Windows.Forms.Label()
        Me.BtnOrderApp = New System.Windows.Forms.Button()
        Me.lblOTime = New System.Windows.Forms.Label()
        Me.LBHist = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DTPOrder.CustomFormat = "yyyy-MM-dd"
        Me.DTPOrder.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTPOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPOrder.Location = New System.Drawing.Point(14, 78)
        Me.DTPOrder.MaxDate = New Date(3017, 12, 31, 0, 0, 0, 0)
        Me.DTPOrder.MinDate = New Date(2017, 3, 1, 0, 0, 0, 0)
        Me.DTPOrder.Name = "DTPOrder"
        Me.DTPOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTPOrder.Size = New System.Drawing.Size(250, 31)
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
        Me.Label6.Location = New System.Drawing.Point(11, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Time:"
        '
        'txtbxTime
        '
        Me.txtbxTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxTime.FormattingEnabled = True
        Me.txtbxTime.Items.AddRange(New Object() {"08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "24.00", "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00"})
        Me.txtbxTime.Location = New System.Drawing.Point(143, 115)
        Me.txtbxTime.Name = "txtbxTime"
        Me.txtbxTime.Size = New System.Drawing.Size(121, 28)
        Me.txtbxTime.TabIndex = 69
        Me.txtbxTime.Text = "08:00"
        '
        'lblNxtApp
        '
        Me.lblNxtApp.AutoSize = True
        Me.lblNxtApp.Location = New System.Drawing.Point(104, 250)
        Me.lblNxtApp.Name = "lblNxtApp"
        Me.lblNxtApp.Size = New System.Drawing.Size(60, 13)
        Me.lblNxtApp.TabIndex = 70
        Me.lblNxtApp.Text = "Bestilt time:"
        '
        'lblODate
        '
        Me.lblODate.AutoSize = True
        Me.lblODate.Location = New System.Drawing.Point(177, 250)
        Me.lblODate.Name = "lblODate"
        Me.lblODate.Size = New System.Drawing.Size(0, 13)
        Me.lblODate.TabIndex = 71
        '
        'BtnOrderApp
        '
        Me.BtnOrderApp.Location = New System.Drawing.Point(14, 245)
        Me.BtnOrderApp.Name = "BtnOrderApp"
        Me.BtnOrderApp.Size = New System.Drawing.Size(75, 23)
        Me.BtnOrderApp.TabIndex = 62
        Me.BtnOrderApp.Text = "Bestill Time"
        Me.BtnOrderApp.UseVisualStyleBackColor = True
        '
        'lblOTime
        '
        Me.lblOTime.AutoSize = True
        Me.lblOTime.Location = New System.Drawing.Point(234, 250)
        Me.lblOTime.Name = "lblOTime"
        Me.lblOTime.Size = New System.Drawing.Size(0, 13)
        Me.lblOTime.TabIndex = 72
        '
        'LBHist
        '
        Me.LBHist.FormattingEnabled = True
        Me.LBHist.Location = New System.Drawing.Point(32, 19)
        Me.LBHist.Name = "LBHist"
        Me.LBHist.ScrollAlwaysVisible = True
        Me.LBHist.Size = New System.Drawing.Size(445, 43)
        Me.LBHist.TabIndex = 78
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DTPOrder)
        Me.GroupBox3.Controls.Add(Me.lblSSN)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtbxTime)
        Me.GroupBox3.Controls.Add(Me.lblNxtApp)
        Me.GroupBox3.Controls.Add(Me.lblODate)
        Me.GroupBox3.Controls.Add(Me.BtnOrderApp)
        Me.GroupBox3.Controls.Add(Me.lblOTime)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(311, 286)
        Me.GroupBox3.TabIndex = 91
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBHist)
        Me.GroupBox2.Location = New System.Drawing.Point(328, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 105)
        Me.GroupBox2.TabIndex = 90
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Neste Tapping"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "day + "" "" + time satt sammen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Label1"
        '
        'Cal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 510)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cal"
        Me.Text = "Cal"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents DTPOrder As DateTimePicker
    Friend WithEvents lblSSN As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxTime As ComboBox
    Friend WithEvents lblNxtApp As Label
    Friend WithEvents lblODate As Label
    Friend WithEvents BtnOrderApp As Button
    Friend WithEvents lblOTime As Label
    Friend WithEvents LBHist As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
