<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FroggPerformance
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FroggPerformance))
        Me.CPU = New System.Diagnostics.PerformanceCounter()
        Me.MEM = New System.Diagnostics.PerformanceCounter()
        Me.RefreshTick = New System.Windows.Forms.Timer(Me.components)
        Me.DISK = New System.Diagnostics.PerformanceCounter()
        Me.PanelPerf = New System.Windows.Forms.Panel()
        Me.txtDetail = New System.Windows.Forms.PictureBox()
        Me.txtDiskUsage = New System.Windows.Forms.Label()
        Me.timeList = New System.Windows.Forms.ComboBox()
        Me.ListType = New System.Windows.Forms.ComboBox()
        Me.txtClose = New System.Windows.Forms.PictureBox()
        Me.btnAdv = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.ProgressMEM = New System.Windows.Forms.ProgressBar()
        Me.txtDISK = New System.Windows.Forms.Label()
        Me.ProgressCPU = New System.Windows.Forms.ProgressBar()
        Me.txtMEM = New System.Windows.Forms.Label()
        Me.ProgressDISK = New System.Windows.Forms.ProgressBar()
        Me.txtCPU = New System.Windows.Forms.Label()
        CType(Me.CPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DISK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPerf.SuspendLayout()
        CType(Me.txtDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CPU
        '
        Me.CPU.CategoryName = "processor"
        Me.CPU.CounterName = "% Processor Time"
        Me.CPU.InstanceName = "_Total"
        '
        'MEM
        '
        Me.MEM.CategoryName = "memory"
        Me.MEM.CounterName = "% Committed Bytes In Use"
        '
        'RefreshTick
        '
        Me.RefreshTick.Interval = 1000
        '
        'DISK
        '
        Me.DISK.CategoryName = "PhysicalDisk"
        Me.DISK.CounterName = "% Disk Time"
        Me.DISK.InstanceName = "_Total"
        '
        'PanelPerf
        '
        Me.PanelPerf.BackgroundImage = Global.FroggMonitor.My.Resources.Resources.bgopt
        Me.PanelPerf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelPerf.Controls.Add(Me.txtDetail)
        Me.PanelPerf.Controls.Add(Me.txtDiskUsage)
        Me.PanelPerf.Controls.Add(Me.timeList)
        Me.PanelPerf.Controls.Add(Me.ListType)
        Me.PanelPerf.Controls.Add(Me.txtClose)
        Me.PanelPerf.Controls.Add(Me.btnAdv)
        Me.PanelPerf.Controls.Add(Me.btnClose)
        Me.PanelPerf.Controls.Add(Me.ProgressMEM)
        Me.PanelPerf.Controls.Add(Me.txtDISK)
        Me.PanelPerf.Controls.Add(Me.ProgressCPU)
        Me.PanelPerf.Controls.Add(Me.txtMEM)
        Me.PanelPerf.Controls.Add(Me.ProgressDISK)
        Me.PanelPerf.Controls.Add(Me.txtCPU)
        Me.PanelPerf.Location = New System.Drawing.Point(0, 0)
        Me.PanelPerf.Name = "PanelPerf"
        Me.PanelPerf.Size = New System.Drawing.Size(554, 123)
        Me.PanelPerf.TabIndex = 6
        '
        'txtDetail
        '
        Me.txtDetail.BackColor = System.Drawing.Color.Transparent
        Me.txtDetail.Image = Global.FroggMonitor.My.Resources.Resources.txtDetail
        Me.txtDetail.Location = New System.Drawing.Point(475, 52)
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.Size = New System.Drawing.Size(74, 14)
        Me.txtDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.txtDetail.TabIndex = 10
        Me.txtDetail.TabStop = False
        Me.txtDetail.Visible = False
        '
        'txtDiskUsage
        '
        Me.txtDiskUsage.BackColor = System.Drawing.Color.Transparent
        Me.txtDiskUsage.ForeColor = System.Drawing.Color.White
        Me.txtDiskUsage.Location = New System.Drawing.Point(194, 90)
        Me.txtDiskUsage.Name = "txtDiskUsage"
        Me.txtDiskUsage.Size = New System.Drawing.Size(80, 18)
        Me.txtDiskUsage.TabIndex = 13
        Me.txtDiskUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timeList
        '
        Me.timeList.BackColor = System.Drawing.Color.Black
        Me.timeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.timeList.ForeColor = System.Drawing.SystemColors.Window
        Me.timeList.FormattingEnabled = True
        Me.timeList.Items.AddRange(New Object() {"1 sec", "2 sec", "3 sec", "4 sec", "5 sec"})
        Me.timeList.Location = New System.Drawing.Point(276, 9)
        Me.timeList.Name = "timeList"
        Me.timeList.Size = New System.Drawing.Size(49, 21)
        Me.timeList.TabIndex = 12
        '
        'ListType
        '
        Me.ListType.BackColor = System.Drawing.Color.Black
        Me.ListType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListType.ForeColor = System.Drawing.Color.White
        Me.ListType.FormattingEnabled = True
        Me.ListType.Location = New System.Drawing.Point(60, 9)
        Me.ListType.Name = "ListType"
        Me.ListType.Size = New System.Drawing.Size(210, 21)
        Me.ListType.TabIndex = 11
        '
        'txtClose
        '
        Me.txtClose.BackColor = System.Drawing.Color.Transparent
        Me.txtClose.Image = Global.FroggMonitor.My.Resources.Resources.txtClose
        Me.txtClose.Location = New System.Drawing.Point(475, 26)
        Me.txtClose.Name = "txtClose"
        Me.txtClose.Size = New System.Drawing.Size(74, 14)
        Me.txtClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.txtClose.TabIndex = 8
        Me.txtClose.TabStop = False
        Me.txtClose.Visible = False
        '
        'btnAdv
        '
        Me.btnAdv.BackColor = System.Drawing.Color.Transparent
        Me.btnAdv.Image = Global.FroggMonitor.My.Resources.Resources.option_n
        Me.btnAdv.Location = New System.Drawing.Point(454, 47)
        Me.btnAdv.Name = "btnAdv"
        Me.btnAdv.Size = New System.Drawing.Size(24, 24)
        Me.btnAdv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnAdv.TabIndex = 7
        Me.btnAdv.TabStop = False
        Me.btnAdv.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Image = Global.FroggMonitor.My.Resources.Resources.close
        Me.btnClose.Location = New System.Drawing.Point(454, 21)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 24)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 6
        Me.btnClose.TabStop = False
        '
        'ProgressMEM
        '
        Me.ProgressMEM.BackColor = System.Drawing.Color.Black
        Me.ProgressMEM.ForeColor = System.Drawing.Color.Green
        Me.ProgressMEM.Location = New System.Drawing.Point(60, 63)
        Me.ProgressMEM.Name = "ProgressMEM"
        Me.ProgressMEM.Size = New System.Drawing.Size(233, 18)
        Me.ProgressMEM.TabIndex = 1
        '
        'txtDISK
        '
        Me.txtDISK.AutoSize = True
        Me.txtDISK.BackColor = System.Drawing.Color.Transparent
        Me.txtDISK.ForeColor = System.Drawing.Color.White
        Me.txtDISK.Location = New System.Drawing.Point(10, 95)
        Me.txtDISK.Name = "txtDISK"
        Me.txtDISK.Size = New System.Drawing.Size(32, 13)
        Me.txtDISK.TabIndex = 5
        Me.txtDISK.Text = "DISK"
        '
        'ProgressCPU
        '
        Me.ProgressCPU.BackColor = System.Drawing.Color.Black
        Me.ProgressCPU.ForeColor = System.Drawing.Color.Green
        Me.ProgressCPU.Location = New System.Drawing.Point(60, 37)
        Me.ProgressCPU.Name = "ProgressCPU"
        Me.ProgressCPU.Size = New System.Drawing.Size(251, 18)
        Me.ProgressCPU.TabIndex = 0
        '
        'txtMEM
        '
        Me.txtMEM.AutoSize = True
        Me.txtMEM.BackColor = System.Drawing.Color.Transparent
        Me.txtMEM.ForeColor = System.Drawing.Color.White
        Me.txtMEM.Location = New System.Drawing.Point(10, 68)
        Me.txtMEM.Name = "txtMEM"
        Me.txtMEM.Size = New System.Drawing.Size(32, 13)
        Me.txtMEM.TabIndex = 4
        Me.txtMEM.Text = "MEM"
        '
        'ProgressDISK
        '
        Me.ProgressDISK.BackColor = System.Drawing.Color.Black
        Me.ProgressDISK.ForeColor = System.Drawing.Color.Green
        Me.ProgressDISK.Location = New System.Drawing.Point(60, 90)
        Me.ProgressDISK.Name = "ProgressDISK"
        Me.ProgressDISK.Size = New System.Drawing.Size(214, 18)
        Me.ProgressDISK.TabIndex = 2
        '
        'txtCPU
        '
        Me.txtCPU.AutoSize = True
        Me.txtCPU.BackColor = System.Drawing.Color.Transparent
        Me.txtCPU.ForeColor = System.Drawing.Color.White
        Me.txtCPU.Location = New System.Drawing.Point(10, 42)
        Me.txtCPU.Name = "txtCPU"
        Me.txtCPU.Size = New System.Drawing.Size(29, 13)
        Me.txtCPU.TabIndex = 3
        Me.txtCPU.Text = "CPU"
        '
        'FroggPerformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(555, 121)
        Me.Controls.Add(Me.PanelPerf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FroggPerformance"
        Me.Text = "Frogg Performance"
        Me.TransparencyKey = System.Drawing.SystemColors.Desktop
        CType(Me.CPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DISK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPerf.ResumeLayout(False)
        Me.PanelPerf.PerformLayout()
        CType(Me.txtDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CPU As System.Diagnostics.PerformanceCounter
    Friend WithEvents MEM As System.Diagnostics.PerformanceCounter
    Friend WithEvents RefreshTick As System.Windows.Forms.Timer
    Friend WithEvents DISK As System.Diagnostics.PerformanceCounter
    Friend WithEvents ProgressCPU As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressMEM As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressDISK As System.Windows.Forms.ProgressBar
    Friend WithEvents txtCPU As System.Windows.Forms.Label
    Friend WithEvents txtMEM As System.Windows.Forms.Label
    Friend WithEvents txtDISK As System.Windows.Forms.Label
    Friend WithEvents PanelPerf As System.Windows.Forms.Panel
    Friend WithEvents btnAdv As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents txtClose As System.Windows.Forms.PictureBox
    Friend WithEvents txtDetail As System.Windows.Forms.PictureBox
    Friend WithEvents ListType As System.Windows.Forms.ComboBox
    Friend WithEvents timeList As System.Windows.Forms.ComboBox
    Friend WithEvents txtDiskUsage As System.Windows.Forms.Label
End Class
