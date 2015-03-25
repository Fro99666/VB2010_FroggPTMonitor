Public Class FroggPerformanceDetail

    Private exeName As String
    Private cName As String

    Private Sub TimerTick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTick.Tick
        refreshRows()
    End Sub

    Private Sub refreshRows()
        Dim CurrVal = 0
        'check process is running
        If Not FroggMonitor.processIsRunning() Then
            If categoryList.Items.Count = 5 Then removeProcessToList()
        Else
            If Not categoryList.Items.Count = 5 Then addProcessToList()
        End If
        'Refresh datas
        Dim k = DataGridView.Rows.Count
        For j = 0 To k - 1
            ALL.CounterName = DataGridView.Rows(j).Cells(0).Value
            DataGridView.Rows(j).Cells(1).Value = Format(ALL.NextValue(), "### ### ### ### ##0.##")
        Next
    End Sub

    Private Sub addProcessToList()
        If FroggMonitor.processIsRunning() Then
            exeName = FroggMonitor.nameRunning
            categoryList.Items.Add(exeName)
        End If
    End Sub

    Private Sub removeProcessToList()
        If categoryList.SelectedIndex = 4 Then categoryList.SelectedIndex = 0
        categoryList.Items.RemoveAt(4)
        setPerfType()
    End Sub

    Private Sub setPerfType()
        Dim iName As String
        'set selected datas
        Select Case categoryList.SelectedIndex
            Case 0
                cName = "Processor"
                iName = "_total"
            Case 1
                cName = "Memory"
                iName = ""
            Case 2
                cName = "PhysicalDisk"
                iName = "_total"
            Case 3
                cName = "Network Interface"
                iName = "0"
            Case 4
                cName = "Process"
                iName = exeName
            Case Else
                cName = "Processor"
                iName = "_all"
        End Select

        'set instance Categorie
        ALL.CategoryName = cName
        'set instance name
        ALL.InstanceName = iName
        'set form title
        Me.Text = "Monitoring " & cName
        'get datas
        getPerfData()
    End Sub

    Private Sub getPerfData()
        'init vars
        Dim instanceNames() As String
        Dim counters As New System.Collections.ArrayList()
        Dim counter As PerformanceCounter
        Dim mycat As New PerformanceCounterCategory(cName)

        ' Remove the current contents of the list. 
        DataGridView.Rows.Clear()
        ' Remove the current name list of the list. 
        instanceNameList.Items.Clear()

        'retrive the instances names
        instanceNames = mycat.GetInstanceNames()

        'if not process case
        If Not categoryList.SelectedIndex = 4 Then
            'add instance name list
            For Each instance In instanceNames
                instanceNameList.Items.Add(instance)
            Next
            instanceNameList.SelectedIndex = instanceNameList.Items.Count() - 1
            ALL.InstanceName = instanceNameList.SelectedItem
        End If

        ' Retrieve the counters. 
        Try
            'check for counters
            If (instanceNames.Length = 0) Then
                counters.AddRange(mycat.GetCounters())
            Else
                counters.AddRange(mycat.GetCounters(instanceNames(0)))
            End If

            ' Add the retrieved counters to the list. 
            For Each counter In counters
                ALL.CounterName = counter.CounterName
                DataGridView.Rows.Add({counter.CounterName, Format(ALL.NextValue(), "### ### ### ### ##0.##")})
            Next

        Catch ex As Exception
            MessageBox.Show("Unable to list the counters for this category:" & ControlChars.CrLf & ex.Message)
        End Try

    End Sub

    Private Sub FroggPerformanceDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'close perf form
        FroggPerformance.Close()


        'add timeTickList
        timeTickList.Items.Add("1 sec")
        timeTickList.Items.Add("2 sec")
        timeTickList.Items.Add("3 sec")
        timeTickList.Items.Add("4 sec")
        timeTickList.Items.Add("5 sec")
        timeTickList.SelectedIndex = 4

        'set columns
        DataGridView.ColumnCount = 2
        DataGridView.Columns(0).Name = "Type"
        DataGridView.Columns(1).Name = "Value"
        DataGridView.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'add cat to combolist
        categoryList.Items.Add("Processor")
        categoryList.Items.Add("Memory")
        categoryList.Items.Add("PhysicalDisk")
        categoryList.Items.Add("Network Interface")

        'add process to lis if is runnnig
        If FroggMonitor.processIsRunning() Then addProcessToList()
        If categoryList.Items.Count = 5 Then categoryList.SelectedIndex = 4

        'start timer
        TimerTick.Enabled = True
    End Sub

    Private Sub categoryList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles categoryList.SelectedIndexChanged
        setPerfType()
    End Sub

    Private Sub timeTickList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeTickList.SelectedIndexChanged
        TimerTick.Interval = (timeTickList.SelectedIndex + 1) * 1000
    End Sub

    Private Sub instanceNameList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles instanceNameList.SelectedIndexChanged
       ALL.InstanceName = instanceNameList.SelectedItem
    End Sub

    Private Sub dataGridView_SortCompare(ByVal sender As Object, ByVal e As DataGridViewSortCompareEventArgs) Handles DataGridView.SortCompare
        If e.Column.Index = 1 Then
            e.SortResult = Double.Parse(e.CellValue1.ToString()).CompareTo(Double.Parse(e.CellValue2.ToString()))
            e.Handled = True
        End If
    End Sub

End Class