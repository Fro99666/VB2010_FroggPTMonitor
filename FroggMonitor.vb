Public Class FroggMonitor

    ' ### TODO ###
    ' - Process Check :
    '    * manage process to kill list


#Region "Default value"
    'default values
    Public exeFile As String = ""
    Public logFile As String = "monitor.log"
    Public iniFile As String = "monitor.ini" 'not modifiable
    Public saveLog As String = "1"
    Public exePrio As Integer = 3
    Public refreshTime As Integer = 5 'in sec
    Public processList As String() = {}
    'script vars
    Public isRunning As Integer = 0
    Public procRunning As Process
    Private exeRunning As String = ""
    Public nameRunning As String = ""
    Private msgTitle As String = "FroggPT monitor"
    Private StateObj As New StateObjClass
    'thread safe
    Delegate Sub SetTextCallback(ByVal [text] As String)
    'txt to display
    Private txtRun = "RESTARTING"
    Private txtOff = "INACTIVE"
    Private txtOn = "RUNNING"
#End Region


#Region "Log Func"
    Private Function getTime()
        getTime = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")
    End Function

    Private Sub addTolog(ByVal msg As String)
        If saveLog = 1 Then
            If Not My.Computer.FileSystem.FileExists(logFile) Then
                Dim lines As New ArrayList
                lines.Add("#### [ " & getTime() & " ] LogFile created ####")
                writeFile(logFile, lines)
            End If
            'append to file
            My.Computer.FileSystem.WriteAllText(logFile, "[" & getTime() & "] " & msg & vbCrLf, True)
        End If
    End Sub
#End Region


#Region "Form Func"

    'Form Loading
    Private Sub FroggPTMonitor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadValues()
    End Sub

    Private Sub exitMain()
        addTolog("Monitoring " & nameRunning & " exited by user")
        System.Environment.Exit(-1)
        System.Windows.Forms.Application.Exit()
        Close()
    End Sub

    Private Sub loadValues()
        Dim config As String, configLine As String(), lineVals As String()
        If My.Computer.FileSystem.FileExists(iniFile) Then
            config = My.Computer.FileSystem.ReadAllText(iniFile)
            'get each line
            configLine = config.Split(vbCrLf)
            'for each lines
            For Each line In configLine
                'If Contains char "
                If line.Contains("""") Then
                    'spit char "
                    lineVals = line.Split("""")
                    'if array has at least 3 elements then set values
                    If lineVals.Length > 3 Then
                        Select Case lineVals(1)
                            Case "exeFile"
                                exeFile = lineVals(3)
                            Case "logFile"
                                logFile = lineVals(3)
                            Case "refreshTime"
                                refreshTime = lineVals(3)
                            Case "saveLog"
                                saveLog = lineVals(3)
                            Case "processList"
                                processList = lineVals(3).Split(" ")
                            Case "exePrio"
                                exePrio = Val(lineVals(3))
                        End Select
                    End If
                End If
            Next
        End If
    End Sub

    Public Sub saveValues()
        Dim lines As New ArrayList
        'create line array
        lines.Add("# /!\ Do Not Change This File By Yourself /!\")
        lines.Add("")
        lines.Add("#Options")
        'set values
        lines.Add("""exeFile"" = """ & exeFile & """")
        lines.Add("""exePrio"" = """ & exePrio & """")
        lines.Add("""logFile"" = """ & logFile & """")
        lines.Add("""saveLog"" = """ & saveLog & """")
        lines.Add("""refreshTime"" = """ & refreshTime & """")
        lines.Add("""processList"" = """ & Join(processList, " ") & """")
        writeFile(iniFile, lines)
    End Sub

#End Region


#Region "Process Function"

    Public Function getExeFile()
        Dim askFileName As New OpenFileDialog()
        askFileName.Filter = "exefiles (*.exe)|*.exe"
        askFileName.FilterIndex = 1
        askFileName.RestoreDirectory = True
        askFileName.FileName = exeFile
        If askFileName.ShowDialog() = DialogResult.OK Then
            exeFile = askFileName.FileName
            getExeFile = True
        Else
            getExeFile = False
        End If
    End Function

    'if process has stoped
    Public Function processIsRunning()
        Dim pStatus = True
        If procRunning Is Nothing Then
            pStatus = False
        Else
            If procRunning.HasExited Then pStatus = False
        End If
        processIsRunning = pStatus
    End Function

    Private Sub checkProcess()
        If exeFile = "" Then
            If Not getExeFile() Then Exit Sub
        End If
        'log start monitoring
        addTolog("Monitoring Started by user")
        'set filename to search
        exeRunning = Replace(IO.Path.GetFileName(exeFile), ".exe", "")
        'check if process is already running
        If isRunning > 0 Then
            stopProcess()
        Else
            CheckIfRunning()
        End If
    End Sub

    '===>START
    Private Sub startProcess()
        procRunning = Process.Start(exeFile)
        nameRunning = procRunning.ProcessName
        isRunning = 1
        setStartDisplay()
        setPriority()
    End Sub

    Private Sub setStartDisplay()
        If BtnState.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf setStartDisplay)
            Me.Invoke(d, New Object() {[Text]})
        Else
            BtnState.Image = My.Resources.Resources.power_load
            BtnPower.Image = My.Resources.Resources.powerbtn_on
            txtInfo.Text = txtRun
        End If
    End Sub

    '===>STOP
    Private Sub stopProcess()
        StateObj.TimerCanceled = True
        If Not procRunning.HasExited Then
            If displayMsg("Monitoring has been sucessfully stoped." & vbCrLf & vbCrLf & "Do you wish to Stop " & exeFile & " ?", "", 3) Then
                procRunning.Kill()
                addTolog("Monitoring & Process " & nameRunning & " Stopped by user")
            Else
                addTolog("Monitoring " & nameRunning & " Stopped by user")
            End If
        End If
        isRunning = 0
        setStopDisplay()
    End Sub

    Private Sub setStopDisplay()
        If BtnState.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf setStopDisplay)
            Me.Invoke(d, New Object() {[Text]})
        Else
            BtnState.Image = My.Resources.Resources.power_off
            BtnPower.Image = My.Resources.Resources.powerbtn
            txtInfo.Text = txtOff
        End If
    End Sub

    '===>Priotiry
    Private Sub setPriority()
        If Not procRunning.HasExited Then
            Select Case exePrio
                Case 0
                    procRunning.PriorityClass = System.Diagnostics.ProcessPriorityClass.BelowNormal
                Case 1
                    procRunning.PriorityClass = System.Diagnostics.ProcessPriorityClass.Normal
                Case 2
                    procRunning.PriorityClass = System.Diagnostics.ProcessPriorityClass.AboveNormal
                Case 3
                    procRunning.PriorityClass = System.Diagnostics.ProcessPriorityClass.High
                Case 4
                    procRunning.PriorityClass = System.Diagnostics.ProcessPriorityClass.RealTime
                Case Else
                    procRunning.PriorityClass = System.Diagnostics.ProcessPriorityClass.Normal
            End Select
        End If
    End Sub

    '===>RUNNING
    Private Sub runProcess()
        isRunning = 2
        setRunDisplay()
    End Sub

    Private Sub setRunDisplay()
        If BtnState.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf setRunDisplay)
            Me.Invoke(d, New Object() {[Text]})
        Else
            BtnState.Image = My.Resources.Resources.power_on
            BtnPower.Image = My.Resources.Resources.powerbtn_on
            txtInfo.Text = txtOn
        End If
    End Sub

    '==>TEST
    Private Sub doTest()
        If procRunning Is Nothing Then
            startProcess()
            addTolog("Process " & nameRunning & " starting")
        Else
            If procRunning.HasExited Then
                startProcess()
                addTolog("AUTORESTARTING /!\ Process " & nameRunning & "has crashed /!\ ")
            Else
                If Not isRunning = 2 Then
                    runProcess()
                    addTolog("Process " & nameRunning & " is running")
                End If
            End If
        End If
    End Sub

    Private Sub testProcess_timer()
        Dim State As StateObjClass = CType(StateObj, StateObjClass)
        If State.TimerCanceled Then
            State.TimerReference.Dispose()
        Else
            doTest()
        End If
    End Sub

    Private Sub CheckIfRunning()
        'check if process already exist
        For Each currProcess As Process In Process.GetProcesses()
            If currProcess.ProcessName = exeRunning Then
                procRunning = currProcess
                nameRunning = procRunning.ProcessName
                Exit For
            End If
        Next
        'start display
        doTest()
        'set process priority
        setPriority()
        'start timer thread
        Dim TimerDelegate As New System.Threading.TimerCallback(AddressOf Me.testProcess_timer)
        Dim TimerItem As New System.Threading.Timer(TimerDelegate, StateObj, refreshTime * 1000, refreshTime * 1000)
        StateObj.TimerReference = TimerItem
    End Sub

#End Region


#Region "Button Action"
    '======[ SAVE BUTTON ]======
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If FroggMonitorOption.Visible Then
            FroggMonitorOption.doSave()
        Else
            If displayMsg("Do you wish to Save monitoring settings ?", "", 3) Then saveValues()
        End If
    End Sub

    Private Sub BtnSave_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.MouseHover
        BtnSave.Image = My.Resources.Resources.save_o
        btnSaveTxt.Visible = True
    End Sub

    Private Sub BtnSave_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.MouseDown
        BtnSave.Image = My.Resources.Resources.save_a
    End Sub

    Private Sub BtnSave_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.MouseLeave
        BtnSave.Image = My.Resources.Resources.save
        btnSaveTxt.Visible = False
    End Sub

    '======[ OPTION BUTTON ]======
    Private Sub BtnOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOption.Click
        FroggMonitorOption.Show()
    End Sub

    Private Sub BtnOption_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOption.MouseHover
        BtnOption.Image = My.Resources.Resources.option_o
        btnOptionTxt.Visible = True
    End Sub

    Private Sub BtnOption_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOption.MouseDown
        BtnOption.Image = My.Resources.Resources.option_a
    End Sub

    Private Sub BtnOption_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOption.MouseLeave
        BtnOption.Image = My.Resources.Resources.option_n
        btnOptionTxt.Visible = False
    End Sub

    '======[ POWER BUTTON ]======
    Private Sub BtnPower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPower.Click
        checkProcess()
    End Sub

    Private Sub BtnPower_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPower.MouseHover
        If isRunning > 0 Then
            BtnPower.Image = My.Resources.Resources.powerbtn_off
        Else
            BtnPower.Image = My.Resources.Resources.powerbtn_o
        End If
    End Sub

    Private Sub BtnPower_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPower.MouseLeave
        If isRunning > 0 Then
            BtnPower.Image = My.Resources.Resources.powerbtn_on
        Else
            BtnPower.Image = My.Resources.Resources.powerbtn
        End If
    End Sub

    '======[ COPYRIGHT BUTTON ]======
    Private Sub BtnFrogg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFrogg.Click
        FroggLogo.Show()
    End Sub

    Private Sub BtnFrogg_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFrogg.MouseHover
        BtnFrogg.Image = My.Resources.Resources.froggpt_o
    End Sub

    Private Sub BtnFrogg_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFrogg.MouseDown
        BtnFrogg.Image = My.Resources.Resources.froggpt_a
    End Sub

    Private Sub BtnFrogg_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFrogg.MouseLeave
        BtnFrogg.Image = My.Resources.Resources.froggpt
    End Sub

    '======[ PERF BUTTON ]======
    Private Sub btnPerf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerf.Click
        FroggPerformance.Show()
    End Sub

    Private Sub btnPerf_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerf.MouseHover
        btnPerf.Image = My.Resources.Resources.btnPerf_o
        txtPerf.Visible = True
    End Sub

    Private Sub btnPerf_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerf.MouseDown
        btnPerf.Image = My.Resources.Resources.btnPerf_a
    End Sub

    Private Sub btnPerf_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerf.MouseLeave
        btnPerf.Image = My.Resources.Resources.btnPerf
        txtPerf.Visible = False
    End Sub

    '======[ EXIT BUTTON ]======
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        If displayMsg("Do you wish to Exit process monitor ?", "", 3) Then exitMain()
    End Sub

    Private Sub PanelBtnClose_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.MouseHover
        BtnExit.Image = My.Resources.Resources.close_o
        btnCloseTxt.Visible = True
    End Sub

    Private Sub PanelBtnClose_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.MouseDown
        BtnExit.Image = My.Resources.Resources.close_a
    End Sub

    Private Sub PanelBtnClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.MouseLeave
        BtnExit.Image = My.Resources.Resources.close
        btnCloseTxt.Visible = False
    End Sub

#End Region


#Region "Functions"
    'Create a file
    Public Sub writeFile(ByVal fileName As String, ByVal lines As ArrayList)
        'create stream file
        Dim streamFile As New System.IO.StreamWriter(fileName, False)
        'add each line
        For Each line In lines
            streamFile.WriteLine(line)
        Next
        'end file stream
        streamFile.Close()
    End Sub

    'Display msg
    Public Function displayMsg(ByVal msg As String, ByVal defaultVal As String, ByVal lvl As Integer)
        'lvl -1 = error
        'lvl  0 = ok
        'lvl  1 = info
        'lvl  2 = waring
        'lvl  3 = confirm
        'lvl  4 = user input

        'define msg box title depending in lvl value
        Select Case lvl
            Case -1
                MsgBox(msg, Nothing, msgTitle & " - Error occured")
                displayMsg = True
            Case 1
                displayMsg = True
            Case 2
                MsgBox(msg, Nothing, msgTitle & " - Warning occured")
                displayMsg = True
            Case 3
                Dim answer As DialogResult
                answer = MsgBox(msg, MessageBoxButtons.YesNo, msgTitle)
                If answer = vbYes Then displayMsg = True Else displayMsg = False
            Case 4
                displayMsg = InputBox(msg, msgTitle, defaultVal)
            Case Else
                displayMsg = "NOT DEFINED"
        End Select
    End Function
#End Region


#Region "Move Form"
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelContainAll.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelContainAll.MouseMove
        If MoveForm Then Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
    End Sub

    Public Sub MoveForm_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelContainAll.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region


End Class

'process thread state class
Public Class StateObjClass
    Public TimerReference As System.Threading.Timer
    Public TimerCanceled As Boolean = False
End Class