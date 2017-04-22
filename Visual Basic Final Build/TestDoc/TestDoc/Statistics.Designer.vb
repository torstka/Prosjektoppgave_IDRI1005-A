<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistics
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dgvBloodType = New System.Windows.Forms.DataGridView()
        Me.CBType = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CG = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvGender = New System.Windows.Forms.DataGridView()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.CBlodtype = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblStatistics = New System.Windows.Forms.Label()
        Me.lblCPie = New System.Windows.Forms.Label()
        Me.btnSBType = New System.Windows.Forms.Button()
        Me.btnBTPie = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvBloodType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBlodtype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBloodType
        '
        Me.dgvBloodType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBloodType.Location = New System.Drawing.Point(965, 442)
        Me.dgvBloodType.Name = "dgvBloodType"
        Me.dgvBloodType.RowTemplate.Height = 28
        Me.dgvBloodType.Size = New System.Drawing.Size(90, 87)
        Me.dgvBloodType.TabIndex = 12
        Me.dgvBloodType.Visible = False
        '
        'CBType
        '
        Me.CBType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBType.BackColor = System.Drawing.Color.Silver
        ChartArea4.Name = "ChartArea1"
        Me.CBType.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.CBType.Legends.Add(Legend4)
        Me.CBType.Location = New System.Drawing.Point(33, 66)
        Me.CBType.Name = "CBType"
        Me.CBType.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series4.ChartArea = "ChartArea1"
        Series4.Color = System.Drawing.Color.Crimson
        Series4.IsVisibleInLegend = False
        Series4.LabelAngle = 90
        Series4.Legend = "Legend1"
        Series4.Name = "BLODTYPER"
        Series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Me.CBType.Series.Add(Series4)
        Me.CBType.Size = New System.Drawing.Size(543, 637)
        Me.CBType.TabIndex = 13
        Me.CBType.Text = "Chart1"
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.Text = "Blodtypene spesifisert"
        Me.CBType.Titles.Add(Title3)
        '
        'CG
        '
        Me.CG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CG.BackColor = System.Drawing.Color.Silver
        ChartArea5.Name = "ChartArea1"
        Me.CG.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.CG.Legends.Add(Legend5)
        Me.CG.Location = New System.Drawing.Point(626, 66)
        Me.CG.Name = "CG"
        Series5.BorderColor = System.Drawing.Color.Yellow
        Series5.ChartArea = "ChartArea1"
        Series5.Color = System.Drawing.Color.DarkTurquoise
        Series5.IsVisibleInLegend = False
        Series5.Legend = "Legend1"
        Series5.Name = "KJØNNSFORDELING"
        Me.CG.Series.Add(Series5)
        Me.CG.Size = New System.Drawing.Size(560, 637)
        Me.CG.TabIndex = 14
        Me.CG.Text = "Chart1"
        Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "Title1"
        Title4.Text = "Fordelingen mellom Menn & Kvinner"
        Me.CG.Titles.Add(Title4)
        '
        'dgvGender
        '
        Me.dgvGender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGender.Location = New System.Drawing.Point(981, 485)
        Me.dgvGender.Name = "dgvGender"
        Me.dgvGender.RowTemplate.Height = 28
        Me.dgvGender.Size = New System.Drawing.Size(60, 44)
        Me.dgvGender.TabIndex = 15
        Me.dgvGender.Visible = False
        '
        'btnSignOut
        '
        Me.btnSignOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSignOut.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(1043, 29)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(183, 59)
        Me.btnSignOut.TabIndex = 17
        Me.btnSignOut.Text = "Logg Ut"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'CBlodtype
        '
        Me.CBlodtype.BackColor = System.Drawing.Color.Silver
        ChartArea6.Name = "ChartArea1"
        Me.CBlodtype.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.CBlodtype.Legends.Add(Legend6)
        Me.CBlodtype.Location = New System.Drawing.Point(33, 66)
        Me.CBlodtype.Name = "CBlodtype"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series6.Legend = "Legend1"
        Series6.Name = "Blodtyper"
        Me.CBlodtype.Series.Add(Series6)
        Me.CBlodtype.Size = New System.Drawing.Size(543, 637)
        Me.CBlodtype.TabIndex = 18
        Me.CBlodtype.Text = "Chart1"
        '
        'lblStatistics
        '
        Me.lblStatistics.AutoSize = True
        Me.lblStatistics.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatistics.Location = New System.Drawing.Point(364, 16)
        Me.lblStatistics.Name = "lblStatistics"
        Me.lblStatistics.Size = New System.Drawing.Size(486, 39)
        Me.lblStatistics.TabIndex = 19
        Me.lblStatistics.Text = "Ulik Statistikk hentet fra Databasen"
        '
        'lblCPie
        '
        Me.lblCPie.AutoSize = True
        Me.lblCPie.BackColor = System.Drawing.Color.White
        Me.lblCPie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPie.Location = New System.Drawing.Point(178, 86)
        Me.lblCPie.Name = "lblCPie"
        Me.lblCPie.Size = New System.Drawing.Size(226, 17)
        Me.lblCPie.TabIndex = 20
        Me.lblCPie.Text = "De fire forskjellige blodtypene"
        '
        'btnSBType
        '
        Me.btnSBType.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBType.Location = New System.Drawing.Point(116, 709)
        Me.btnSBType.Name = "btnSBType"
        Me.btnSBType.Size = New System.Drawing.Size(362, 47)
        Me.btnSBType.TabIndex = 21
        Me.btnSBType.Text = "Vis blodtyper i detalj"
        Me.btnSBType.UseVisualStyleBackColor = True
        '
        'btnBTPie
        '
        Me.btnBTPie.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBTPie.Location = New System.Drawing.Point(120, 709)
        Me.btnBTPie.Name = "btnBTPie"
        Me.btnBTPie.Size = New System.Drawing.Size(358, 47)
        Me.btnBTPie.TabIndex = 22
        Me.btnBTPie.Text = "Vis de fire blodtypene"
        Me.btnBTPie.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStatistics)
        Me.GroupBox1.Controls.Add(Me.lblCPie)
        Me.GroupBox1.Controls.Add(Me.CG)
        Me.GroupBox1.Controls.Add(Me.dgvBloodType)
        Me.GroupBox1.Controls.Add(Me.dgvGender)
        Me.GroupBox1.Controls.Add(Me.CBlodtype)
        Me.GroupBox1.Controls.Add(Me.CBType)
        Me.GroupBox1.Controls.Add(Me.btnSBType)
        Me.GroupBox1.Controls.Add(Me.btnBTPie)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1230, 776)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1237, 29)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(183, 59)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Tilbake"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TestDoc.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(38, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Statistics
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1353, 836)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Statistics"
        Me.Text = "Statistics"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvBloodType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBlodtype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBloodType As DataGridView
    Friend WithEvents CBType As DataVisualization.Charting.Chart
    Friend WithEvents CG As DataVisualization.Charting.Chart
    Friend WithEvents dgvGender As DataGridView
    Friend WithEvents btnSignOut As Button
    Friend WithEvents CBlodtype As DataVisualization.Charting.Chart
    Friend WithEvents lblStatistics As Label
    Friend WithEvents lblCPie As Label
    Friend WithEvents btnSBType As Button
    Friend WithEvents btnBTPie As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
