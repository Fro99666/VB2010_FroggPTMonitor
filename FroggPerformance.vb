Public Class FroggPerformance

#Region "Main var"
    Private cVal As Single
    Private mval As Single
    Private dVal As Single
    Private TotalMem = My.Computer.Info.TotalPhysicalMemory
    Private exeName As String
#End Region


#Region "Load Form Function"

    Private Sub FroggPerf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set perf
        ListType.Items.Add("All process")
        addProcessToList()
        ListType.SelectedIndex = ListType.Items.Count() - 1
        setPerfType()
        'set tick
        timeList.SelectedIndex = 0
        setTimeTick()
        'start tick
        RefreshTick.Enabled = True
    End Sub

    Private Sub addProcessToList()
        If FroggMonitor.processIsRunning() Then
            btnAdv.Visible = True
            exeName = FroggMonitor.nameRunning
            ListType.Items.Add(exeName)
        End If
    End Sub

    Private Sub removeProcessToList()
        btnAdv.Visible = False
        ListType.Items.RemoveAt(1)
        ListType.SelectedIndex = 0
        setPerfType()
    End Sub

    Private Sub setTimeTick()
        RefreshTick.Interval = (timeList.SelectedIndex + 1) * 1000
    End Sub

#End Region


#Region "Button Action"

    '======[ ADVANCED BUTTON ]======
    Private Sub btnAdv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdv.Click
        FroggPerformanceDetail.Show()
    End Sub

    Private Sub btnAdv_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdv.MouseHover
        btnAdv.Image = My.Resources.Resources.option_o
        txtDetail.Visible = True
    End Sub

    Private Sub btnAdv_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdv.MouseDown
        btnAdv.Image = My.Resources.Resources.option_a
    End Sub

    Private Sub btnAdv_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdv.MouseLeave
        btnAdv.Image = My.Resources.Resources.option_n
        txtDetail.Visible = False
    End Sub

    '======[ CLOSE BUTTON ]======
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseHover
        btnClose.Image = My.Resources.Resources.close_o
        txtClose.Visible = True
    End Sub

    Private Sub BtnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseDown
        btnClose.Image = My.Resources.Resources.close_a
    End Sub

    Private Sub BtnClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        btnClose.Image = My.Resources.Resources.close
        txtClose.Visible = False
    End Sub

    '======[ TIMETICK CHANGE ]======
    Private Sub timeList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeList.SelectedIndexChanged
        setTimeTick()
    End Sub

    '======[ PERFTYPE CHANGE ]======
    Private Sub ListType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListType.SelectedIndexChanged
        setPerfType()
    End Sub

#End Region


#Region "Perf function"

    Private Sub setProgressBarColor(ByVal val As Integer, ByVal P As ProgressBar)
        If (val * 100 / P.Maximum) > 80 Then P.ForeColor = Color.Red Else P.ForeColor = Color.Green
    End Sub

    'set display each sec
    Private Sub Refresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshTick.Tick
        Dim selectedInf = ListType.SelectedIndex
        'if process has stoped
        If selectedInf Then
            If Not FroggMonitor.processIsRunning Then removeProcessToList()
        End If
        'set values
        If selectedInf Then
            'Process Case
            cVal = CPU.NextValue
            mval = FroggMonitor.procRunning.WorkingSet64 * 100 / TotalMem
            Dim diskUsage = DISK.NextValue
            dVal = (diskUsage * 100 / 1000) / ProgressDISK.Maximum 'max in k/s
            txtDiskUsage.Text = Format(diskUsage / 1000, "#,##0.00") & "k/s"
        Else
            'All Case
            cVal = CPU.NextValue
            mval = MEM.NextValue
            dVal = DISK.NextValue
        End If
        'send values to progress bar
        If cVal <= ProgressCPU.Maximum Then
            ProgressCPU.Value = cVal
            'set bar color
            setProgressBarColor(cVal, ProgressCPU)
        End If
        If mval <= ProgressMEM.Maximum Then
            ProgressMEM.Value = mval
            'set bar color
            setProgressBarColor(mval, ProgressMEM)
        End If
        If dVal <= ProgressDISK.Maximum Then
            ProgressDISK.Value = dVal
            'set bar color
            setProgressBarColor(dVal, ProgressDISK)
        End If
        'check if process is running
        If ListType.Items.Count() = 1 Then
            If Not FroggMonitor.procRunning Is Nothing Then addProcessToList()
        End If
    End Sub

    'set the changed perf
    Private Sub setPerfType()
        Select Case ListType.SelectedIndex
            Case 0
                'set CPU perf
                CPU.CategoryName = "Processor"
                CPU.CounterName = "% Processor Time"
                CPU.InstanceName = "_Total"
                ProgressCPU.Maximum = 100
                'set MEM perf
                MEM.CategoryName = "Memory"
                MEM.CounterName = "% Committed Bytes In Use"
                MEM.InstanceName = ""
                ProgressMEM.Maximum = 100
                'set DISK perf
                DISK.CategoryName = "PhysicalDisk"
                DISK.CounterName = "% Disk Time"
                DISK.InstanceName = "_Total"
                ProgressDISK.Maximum = 100
                txtDiskUsage.Visible = False
            Case 1
                'set CPU perf
                CPU.CategoryName = "Process"
                CPU.CounterName = "% Processor Time"
                CPU.InstanceName = exeName
                ProgressCPU.Maximum = 100
                'set MEM perf
                MEM.CategoryName = "Process"
                MEM.CounterName = "Working Set - Private"
                MEM.InstanceName = exeName
                ProgressMEM.Maximum = 100
                'set DISK perf
                DISK.CategoryName = "Process"
                DISK.CounterName = "IO Data Bytes/sec"
                DISK.InstanceName = exeName
                ProgressDISK.Maximum = 150000 'in k/s = max 150mb/sec
                txtDiskUsage.Visible = True
        End Select
        'reset progress bar
        ProgressCPU.Value = 0
        ProgressMEM.Value = 0
        ProgressDISK.Value = 0
        txtDiskUsage.Text = ""
    End Sub

#End Region


#Region "Move Form"

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelPerf.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelPerf.MouseMove
        If MoveForm Then Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
    End Sub

    Public Sub MoveForm_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelPerf.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class