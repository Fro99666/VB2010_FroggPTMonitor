Public Class FroggMonitorOption

#Region "Save Action"

    'Form Loading
    Private Sub FroggPTMonitorOption_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadValues()
    End Sub

    Private Sub loadValues()
        inptProc.Text = FroggMonitor.exeFile
        inptLog.Text = FroggMonitor.logFile
        inptTime.Text = FroggMonitor.refreshTime
        If FroggMonitor.saveLog = "1" Then
            inptSaveLog.Checked = True
            inptLog.Enabled = True
        Else
            inptSaveLog.Checked = False
            inptLog.Enabled = False
        End If
        'disable monotor exe editionif monitoring is running
        If FroggMonitor.isRunning > 0 Then inptProc.Enabled = False
        'add each process to list
        For Each p As String In FroggMonitor.processList
            If Not p = "" Then DataGridOptProcess.Rows.Add(p)
        Next
        'priority list
        inptPriority.SelectedIndex = FroggMonitor.exePrio
    End Sub

    Private Sub setValues()
        FroggMonitor.exeFile = inptProc.Text
        FroggMonitor.logFile = inptLog.Text
        FroggMonitor.refreshTime = inptTime.Text
        FroggMonitor.exePrio = inptPriority.SelectedIndex
        If inptSaveLog.Checked Then FroggMonitor.saveLog = "1" Else FroggMonitor.saveLog = "0"
        FroggMonitor.processList = {}
        For Each r As DataGridViewRow In DataGridOptProcess.Rows
            Array.Resize(FroggMonitor.processList, FroggMonitor.processList.Length + 1)
            FroggMonitor.processList(FroggMonitor.processList.Length - 1) = r.Cells(0).Value
        Next
    End Sub

    Private Function testValues()
        'nb error
        Dim err As Integer = 0, timeInt As Integer = 0
        'reset form
        inptProc.BackColor = Color.Black
        inptLog.BackColor = Color.Black
        inptTime.BackColor = Color.Black
        'check process file exist
        If Not My.Computer.FileSystem.FileExists(inptProc.Text) Then
            err = err + 1
            inptProc.BackColor = Color.Red
        End If
        'check log file end with .log
        If inptSaveLog.Checked Then
            If Not inptLog.Text.EndsWith(".log") And Not inptLog.Text.EndsWith(".txt") Then
                err = err + 1
                inptLog.BackColor = Color.Red
            End If
        End If
        'check if is integer
        If Not Integer.TryParse(inptTime.Text, timeInt) Then
            err = err + 1
            inptTime.BackColor = Color.Red
        End If
        'restore panel if is adv panel
        If err > 0 Then
            PanelAdvOpt.Visible = False
            PanelOpt.Visible = True
        End If
        'return nb err
        testValues = err
    End Function

    Public Sub doSave()
        If testValues() = 0 Then
            setValues()
            FroggMonitor.saveValues()
            Me.Hide()
        End If
    End Sub


#End Region


#Region "Button Action"

    '======[ SAVE BUTTON ]======
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        doSave()
    End Sub

    Private Sub BtnSave_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.MouseHover
        btnSave.Image = My.Resources.Resources.save_o
        txtSave.Visible = True
    End Sub

    Private Sub BtnSave_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.MouseDown
        btnSave.Image = My.Resources.Resources.save_a
    End Sub

    Private Sub BtnSave_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.MouseLeave
        btnSave.Image = My.Resources.Resources.save
        txtSave.Visible = False
    End Sub

    '======[ ADV OPTION  BUTTON ]======
    Private Sub BtnAdvOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvOpt.Click
        If PanelAdvOpt.Visible Then
            PanelAdvOpt.Visible = False
            PanelOpt.Visible = True
        Else
            PanelOpt.Visible = False
            PanelAdvOpt.Visible = True
        End If
    End Sub

    Private Sub BBtnAdvOpt_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvOpt.MouseHover
        btnAdvOpt.Image = My.Resources.Resources.option_o
        txtOption.Visible = True
    End Sub

    Private Sub BtnAdvOpt_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvOpt.MouseDown
        btnAdvOpt.Image = My.Resources.Resources.option_a
    End Sub

    Private Sub BtnAdvOpt_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvOpt.MouseLeave
        btnAdvOpt.Image = My.Resources.Resources.option_n
        txtOption.Visible = False
    End Sub

    '======[ CLOSE BUTTON ]======
    Private Sub btnCloseOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseOption.Click
        Me.Close()
    End Sub

    Private Sub BtnCloseOption_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseOption.MouseHover
        btnCloseOption.Image = My.Resources.Resources.close_o
        txtClose.Visible = True
    End Sub

    Private Sub BtnCloseOption_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseOption.MouseDown
        btnCloseOption.Image = My.Resources.Resources.close_a
    End Sub

    Private Sub BtnCloseOption_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseOption.MouseLeave
        btnCloseOption.Image = My.Resources.Resources.close
        txtClose.Visible = False
    End Sub

    '======[ ADD BUTTON ]======
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim userVal = FroggMonitor.displayMsg("", "Add a process to kill when process restart", 4)
        If userVal.EndsWith(".exe") OrElse userVal.EndsWith(".bat") Then
            Dim alreadyExist = False
            For Each r As DataGridViewRow In DataGridOptProcess.Rows
                If userVal = r.Cells(0).Value Then alreadyExist = True
            Next
            'check if already exist
            If Not alreadyExist Then
                DataGridOptProcess.Rows.Add(userVal)
                DataGridOptProcess.Rows(DataGridOptProcess.Rows.Count - 1).Selected = True
            Else
                FroggMonitor.displayMsg(userVal & " Already exist in process list", "", -1)
            End If
        Else
            FroggMonitor.displayMsg("Only .exe or .bat process can be added", "", -1)
        End If
    End Sub

    Private Sub btnAdd_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.MouseDown
        btnAdd.Image = My.Resources.Resources.btn_Add_a
    End Sub

    '======[ REMOVE BUTTON ]======
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        For Each r As DataGridViewRow In DataGridOptProcess.SelectedRows
            If (DataGridOptProcess.Rows.Count > 0) Then DataGridOptProcess.Rows.Remove(r)
        Next
    End Sub

    Private Sub btnDel_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.MouseDown
        btnDel.Image = My.Resources.Resources.btn_Del_a
    End Sub

    Private Sub DataGridOptProcess_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridOptProcess.CellClick
        If Not DataGridOptProcess.CurrentCell Is Nothing Then
            DataGridOptProcess.Rows(DataGridOptProcess.CurrentCell.RowIndex).Selected = True
        End If
    End Sub

    '======[ LOG CHECKBOX ]======
    Private Sub inptSaveLog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inptSaveLog.CheckedChanged
        If inptSaveLog.Checked Then inptLog.Enabled = True Else inptLog.Enabled = False
    End Sub

    '======[ PROCESS PATH INPUT ]======
    Private Sub inptProc_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inptProc.MouseDown
        If FroggMonitor.isRunning > 0 Then
            FroggMonitor.displayMsg("Cannot change process while monitoring is running", "", 2)
            inptProc.Enabled = False
        Else
            If FroggMonitor.getExeFile() Then inptProc.Text = FroggMonitor.exeFile
        End If
    End Sub

#End Region


#Region "Move Form"
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelOptBg.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelOptBg.MouseMove
        If MoveForm Then Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
    End Sub

    Public Sub MoveForm_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelOptBg.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class