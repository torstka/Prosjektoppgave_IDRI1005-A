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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        CType(Me.dgvBloodType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBlodtype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBloodType
        '
        Me.dgvBloodType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBloodType.Location = New System.Drawing.Point(998, 602)
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
        ChartArea1.Name = "ChartArea1"
        Me.CBType.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.CBType.Legends.Add(Legend1)
        Me.CBType.Location = New System.Drawing.Point(26, 84)
        Me.CBType.Name = "CBType"
        Me.CBType.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.Crimson
        Series1.LabelAngle = 90
        Series1.Legend = "Legend1"
        Series1.Name = "BLODTYPER"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Me.CBType.Series.Add(Series1)
        Me.CBType.Size = New System.Drawing.Size(528, 512)
        Me.CBType.TabIndex = 13
        Me.CBType.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Blodtypene spesifisert"
        Me.CBType.Titles.Add(Title1)
        '
        'CG
        '
        Me.CG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CG.BackColor = System.Drawing.Color.Silver
        ChartArea2.Name = "ChartArea1"
        Me.CG.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.CG.Legends.Add(Legend2)
        Me.CG.Location = New System.Drawing.Point(583, 84)
        Me.CG.Name = "CG"
        Series2.BorderColor = System.Drawing.Color.Yellow
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.DarkTurquoise
        Series2.Legend = "Legend1"
        Series2.Name = "KJØNNSFORDELING"
        Me.CG.Series.Add(Series2)
        Me.CG.Size = New System.Drawing.Size(560, 512)
        Me.CG.TabIndex = 14
        Me.CG.Text = "Chart1"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "Fordelingen mellom Menn & Kvinner"
        Me.CG.Titles.Add(Title2)
        '
        'dgvGender
        '
        Me.dgvGender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGender.Location = New System.Drawing.Point(1110, 645)
        Me.dgvGender.Name = "dgvGender"
        Me.dgvGender.RowTemplate.Height = 28
        Me.dgvGender.Size = New System.Drawing.Size(60, 44)
        Me.dgvGender.TabIndex = 15
        Me.dgvGender.Visible = False
        '
        'btnSignOut
        '
        Me.btnSignOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSignOut.Location = New System.Drawing.Point(1022, 13)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(148, 42)
        Me.btnSignOut.TabIndex = 17
        Me.btnSignOut.Text = "Logg Ut"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'CBlodtype
        '
        Me.CBlodtype.BackColor = System.Drawing.Color.LightGray
        ChartArea3.Name = "ChartArea1"
        Me.CBlodtype.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.CBlodtype.Legends.Add(Legend3)
        Me.CBlodtype.Location = New System.Drawing.Point(26, 84)
        Me.CBlodtype.Name = "CBlodtype"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Legend = "Legend1"
        Series3.Name = "Blodtyper"
        Me.CBlodtype.Series.Add(Series3)
        Me.CBlodtype.Size = New System.Drawing.Size(528, 512)
        Me.CBlodtype.TabIndex = 18
        Me.CBlodtype.Text = "Chart1"
        '
        'lblStatistics
        '
        Me.lblStatistics.AutoSize = True
        Me.lblStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatistics.Location = New System.Drawing.Point(420, 13)
        Me.lblStatistics.Name = "lblStatistics"
        Me.lblStatistics.Size = New System.Drawing.Size(551, 37)
        Me.lblStatistics.TabIndex = 19
        Me.lblStatistics.Text = "Ulik Statistikk hentet fra Databasen"
        '
        'lblCPie
        '
        Me.lblCPie.AutoSize = True
        Me.lblCPie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPie.Location = New System.Drawing.Point(159, 84)
        Me.lblCPie.Name = "lblCPie"
        Me.lblCPie.Size = New System.Drawing.Size(278, 25)
        Me.lblCPie.TabIndex = 20
        Me.lblCPie.Text = "De 4 forskjellige blodtypene"
        '
        'btnSBType
        '
        Me.btnSBType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSBType.Location = New System.Drawing.Point(92, 602)
        Me.btnSBType.Name = "btnSBType"
        Me.btnSBType.Size = New System.Drawing.Size(358, 47)
        Me.btnSBType.TabIndex = 21
        Me.btnSBType.Text = "Vis blodtyper mer spesifikt"
        Me.btnSBType.UseVisualStyleBackColor = True
        '
        'btnBTPie
        '
        Me.btnBTPie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBTPie.Location = New System.Drawing.Point(92, 602)
        Me.btnBTPie.Name = "btnBTPie"
        Me.btnBTPie.Size = New System.Drawing.Size(358, 47)
        Me.btnBTPie.TabIndex = 22
        Me.btnBTPie.Text = "Tilbake til Kakediagram"
        Me.btnBTPie.UseVisualStyleBackColor = True
        '
        'Statistics
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1182, 701)
        Me.Controls.Add(Me.lblCPie)
        Me.Controls.Add(Me.lblStatistics)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.dgvGender)
        Me.Controls.Add(Me.CG)
        Me.Controls.Add(Me.dgvBloodType)
        Me.Controls.Add(Me.CBType)
        Me.Controls.Add(Me.btnSBType)
        Me.Controls.Add(Me.btnBTPie)
        Me.Controls.Add(Me.CBlodtype)
        Me.Name = "Statistics"
        Me.Text = "Statistics"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvBloodType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBlodtype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
