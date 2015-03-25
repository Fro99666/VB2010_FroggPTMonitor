<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FroggPerformanceDetail
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FroggPerformanceDetail))
        Me.ALL = New System.Diagnostics.PerformanceCounter()
        Me.TimerTick = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.categoryList = New System.Windows.Forms.ComboBox()
        Me.timeTickList = New System.Windows.Forms.ComboBox()
        Me.instanceNameList = New System.Windows.Forms.ComboBox()
        CType(Me.ALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ALL
        '
        Me.ALL.CategoryName = "memory"
        Me.ALL.CounterName = "% Committed Bytes In Use"
        '
        'TimerTick
        '
        Me.TimerTick.Interval = 5000
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeColumns = False
        Me.DataGridView.AllowUserToResizeRows = False
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.ColumnHeadersHeight = 22
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView.Location = New System.Drawing.Point(0, 21)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.ShowCellErrors = False
        Me.DataGridView.ShowCellToolTips = False
        Me.DataGridView.ShowEditingIcon = False
        Me.DataGridView.ShowRowErrors = False
        Me.DataGridView.Size = New System.Drawing.Size(269, 355)
        Me.DataGridView.TabIndex = 1
        '
        'categoryList
        '
        Me.categoryList.Dock = System.Windows.Forms.DockStyle.Left
        Me.categoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categoryList.FormattingEnabled = True
        Me.categoryList.Location = New System.Drawing.Point(0, 0)
        Me.categoryList.Name = "categoryList"
        Me.categoryList.Size = New System.Drawing.Size(145, 21)
        Me.categoryList.TabIndex = 2
        '
        'timeTickList
        '
        Me.timeTickList.Dock = System.Windows.Forms.DockStyle.Right
        Me.timeTickList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.timeTickList.FormattingEnabled = True
        Me.timeTickList.Location = New System.Drawing.Point(236, 0)
        Me.timeTickList.Name = "timeTickList"
        Me.timeTickList.Size = New System.Drawing.Size(33, 21)
        Me.timeTickList.TabIndex = 3
        '
        'instanceNameList
        '
        Me.instanceNameList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.instanceNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.instanceNameList.FormattingEnabled = True
        Me.instanceNameList.Location = New System.Drawing.Point(145, 0)
        Me.instanceNameList.Name = "instanceNameList"
        Me.instanceNameList.Size = New System.Drawing.Size(91, 21)
        Me.instanceNameList.TabIndex = 4
        '
        'FroggPerformanceDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 376)
        Me.Controls.Add(Me.instanceNameList)
        Me.Controls.Add(Me.timeTickList)
        Me.Controls.Add(Me.categoryList)
        Me.Controls.Add(Me.DataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FroggPerformanceDetail"
        Me.Text = "Frogg Performance Detail"
        CType(Me.ALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ALL As System.Diagnostics.PerformanceCounter
    Friend WithEvents TimerTick As System.Windows.Forms.Timer
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents categoryList As System.Windows.Forms.ComboBox
    Friend WithEvents timeTickList As System.Windows.Forms.ComboBox
    Friend WithEvents instanceNameList As System.Windows.Forms.ComboBox
End Class
