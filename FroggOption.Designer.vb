<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FroggMonitorOption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FroggMonitorOption))
        Me.PanelOptBg = New System.Windows.Forms.Panel()
        Me.txtClose = New System.Windows.Forms.PictureBox()
        Me.txtSave = New System.Windows.Forms.PictureBox()
        Me.txtOption = New System.Windows.Forms.PictureBox()
        Me.btnCloseOption = New System.Windows.Forms.PictureBox()
        Me.btnAdvOpt = New System.Windows.Forms.PictureBox()
        Me.PanelOpt = New System.Windows.Forms.Panel()
        Me.inptPriority = New System.Windows.Forms.ComboBox()
        Me.txtPriority = New System.Windows.Forms.Label()
        Me.inptSaveLog = New System.Windows.Forms.CheckBox()
        Me.txtLog = New System.Windows.Forms.Label()
        Me.inptProc = New System.Windows.Forms.TextBox()
        Me.inptLog = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.Label()
        Me.inptTime = New System.Windows.Forms.TextBox()
        Me.txtProc = New System.Windows.Forms.Label()
        Me.FormTitle = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.PictureBox()
        Me.PanelAdvOpt = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.DataGridOptProcess = New System.Windows.Forms.DataGridView()
        Me.ProcessList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelOptBg.SuspendLayout()
        CType(Me.txtClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdvOpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOpt.SuspendLayout()
        CType(Me.FormTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdvOpt.SuspendLayout()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridOptProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelOptBg
        '
        Me.PanelOptBg.BackColor = System.Drawing.Color.Transparent
        Me.PanelOptBg.BackgroundImage = Global.FroggMonitor.My.Resources.Resources.bgopt
        Me.PanelOptBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelOptBg.Controls.Add(Me.txtClose)
        Me.PanelOptBg.Controls.Add(Me.txtSave)
        Me.PanelOptBg.Controls.Add(Me.txtOption)
        Me.PanelOptBg.Controls.Add(Me.btnCloseOption)
        Me.PanelOptBg.Controls.Add(Me.btnAdvOpt)
        Me.PanelOptBg.Controls.Add(Me.PanelOpt)
        Me.PanelOptBg.Controls.Add(Me.btnSave)
        Me.PanelOptBg.Controls.Add(Me.PanelAdvOpt)
        Me.PanelOptBg.Location = New System.Drawing.Point(0, 0)
        Me.PanelOptBg.Name = "PanelOptBg"
        Me.PanelOptBg.Size = New System.Drawing.Size(552, 122)
        Me.PanelOptBg.TabIndex = 13
        '
        'txtClose
        '
        Me.txtClose.Image = Global.FroggMonitor.My.Resources.Resources.txtClose
        Me.txtClose.Location = New System.Drawing.Point(475, 26)
        Me.txtClose.Name = "txtClose"
        Me.txtClose.Size = New System.Drawing.Size(74, 14)
        Me.txtClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.txtClose.TabIndex = 19
        Me.txtClose.TabStop = False
        Me.txtClose.Visible = False
        '
        'txtSave
        '
        Me.txtSave.Image = Global.FroggMonitor.My.Resources.Resources.savetxt
        Me.txtSave.Location = New System.Drawing.Point(475, 78)
        Me.txtSave.Name = "txtSave"
        Me.txtSave.Size = New System.Drawing.Size(74, 14)
        Me.txtSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.txtSave.TabIndex = 18
        Me.txtSave.TabStop = False
        Me.txtSave.Visible = False
        '
        'txtOption
        '
        Me.txtOption.Image = Global.FroggMonitor.My.Resources.Resources.optiontxt
        Me.txtOption.Location = New System.Drawing.Point(475, 52)
        Me.txtOption.Name = "txtOption"
        Me.txtOption.Size = New System.Drawing.Size(74, 14)
        Me.txtOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.txtOption.TabIndex = 17
        Me.txtOption.TabStop = False
        Me.txtOption.Visible = False
        '
        'btnCloseOption
        '
        Me.btnCloseOption.BackColor = System.Drawing.Color.Transparent
        Me.btnCloseOption.Image = Global.FroggMonitor.My.Resources.Resources.close
        Me.btnCloseOption.Location = New System.Drawing.Point(454, 21)
        Me.btnCloseOption.Name = "btnCloseOption"
        Me.btnCloseOption.Size = New System.Drawing.Size(24, 24)
        Me.btnCloseOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCloseOption.TabIndex = 5
        Me.btnCloseOption.TabStop = False
        '
        'btnAdvOpt
        '
        Me.btnAdvOpt.BackColor = System.Drawing.Color.Transparent
        Me.btnAdvOpt.Image = Global.FroggMonitor.My.Resources.Resources.option_n
        Me.btnAdvOpt.Location = New System.Drawing.Point(454, 47)
        Me.btnAdvOpt.Name = "btnAdvOpt"
        Me.btnAdvOpt.Size = New System.Drawing.Size(24, 24)
        Me.btnAdvOpt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnAdvOpt.TabIndex = 15
        Me.btnAdvOpt.TabStop = False
        '
        'PanelOpt
        '
        Me.PanelOpt.BackColor = System.Drawing.Color.Transparent
        Me.PanelOpt.Controls.Add(Me.inptPriority)
        Me.PanelOpt.Controls.Add(Me.txtPriority)
        Me.PanelOpt.Controls.Add(Me.inptSaveLog)
        Me.PanelOpt.Controls.Add(Me.txtLog)
        Me.PanelOpt.Controls.Add(Me.inptProc)
        Me.PanelOpt.Controls.Add(Me.inptLog)
        Me.PanelOpt.Controls.Add(Me.txtTime)
        Me.PanelOpt.Controls.Add(Me.inptTime)
        Me.PanelOpt.Controls.Add(Me.txtProc)
        Me.PanelOpt.Controls.Add(Me.FormTitle)
        Me.PanelOpt.Location = New System.Drawing.Point(7, 0)
        Me.PanelOpt.Name = "PanelOpt"
        Me.PanelOpt.Size = New System.Drawing.Size(340, 122)
        Me.PanelOpt.TabIndex = 12
        '
        'inptPriority
        '
        Me.inptPriority.BackColor = System.Drawing.Color.Black
        Me.inptPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inptPriority.ForeColor = System.Drawing.Color.White
        Me.inptPriority.IntegralHeight = False
        Me.inptPriority.ItemHeight = 13
        Me.inptPriority.Items.AddRange(New Object() {"Below Normal", "Normal", "Above Normal", "High", "Real Time"})
        Me.inptPriority.Location = New System.Drawing.Point(99, 71)
        Me.inptPriority.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.inptPriority.Name = "inptPriority"
        Me.inptPriority.Size = New System.Drawing.Size(121, 21)
        Me.inptPriority.TabIndex = 12
        '
        'txtPriority
        '
        Me.txtPriority.AutoSize = True
        Me.txtPriority.ForeColor = System.Drawing.Color.White
        Me.txtPriority.Location = New System.Drawing.Point(9, 73)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(78, 13)
        Me.txtPriority.TabIndex = 11
        Me.txtPriority.Text = "Process priority"
        '
        'inptSaveLog
        '
        Me.inptSaveLog.AutoSize = True
        Me.inptSaveLog.BackColor = System.Drawing.Color.Transparent
        Me.inptSaveLog.ForeColor = System.Drawing.Color.White
        Me.inptSaveLog.Location = New System.Drawing.Point(12, 97)
        Me.inptSaveLog.Name = "inptSaveLog"
        Me.inptSaveLog.Size = New System.Drawing.Size(73, 17)
        Me.inptSaveLog.TabIndex = 7
        Me.inptSaveLog.Text = "Save logs"
        Me.inptSaveLog.UseVisualStyleBackColor = False
        '
        'txtLog
        '
        Me.txtLog.AutoSize = True
        Me.txtLog.BackColor = System.Drawing.Color.Transparent
        Me.txtLog.ForeColor = System.Drawing.Color.White
        Me.txtLog.Location = New System.Drawing.Point(9, 52)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(63, 13)
        Me.txtLog.TabIndex = 5
        Me.txtLog.Text = "Path of logs"
        '
        'inptProc
        '
        Me.inptProc.BackColor = System.Drawing.Color.Black
        Me.inptProc.ForeColor = System.Drawing.Color.White
        Me.inptProc.Location = New System.Drawing.Point(99, 29)
        Me.inptProc.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.inptProc.Multiline = True
        Me.inptProc.Name = "inptProc"
        Me.inptProc.Size = New System.Drawing.Size(203, 18)
        Me.inptProc.TabIndex = 1
        '
        'inptLog
        '
        Me.inptLog.BackColor = System.Drawing.Color.Black
        Me.inptLog.ForeColor = System.Drawing.Color.White
        Me.inptLog.Location = New System.Drawing.Point(99, 50)
        Me.inptLog.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.inptLog.Multiline = True
        Me.inptLog.Name = "inptLog"
        Me.inptLog.Size = New System.Drawing.Size(165, 18)
        Me.inptLog.TabIndex = 2
        '
        'txtTime
        '
        Me.txtTime.AutoSize = True
        Me.txtTime.BackColor = System.Drawing.Color.Transparent
        Me.txtTime.ForeColor = System.Drawing.Color.White
        Me.txtTime.Location = New System.Drawing.Point(132, 98)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(134, 13)
        Me.txtTime.TabIndex = 9
        Me.txtTime.Text = "Procees refresh time ( in s )"
        '
        'inptTime
        '
        Me.inptTime.BackColor = System.Drawing.Color.Black
        Me.inptTime.ForeColor = System.Drawing.Color.White
        Me.inptTime.Location = New System.Drawing.Point(99, 95)
        Me.inptTime.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.inptTime.Multiline = True
        Me.inptTime.Name = "inptTime"
        Me.inptTime.Size = New System.Drawing.Size(33, 18)
        Me.inptTime.TabIndex = 8
        Me.inptTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProc
        '
        Me.txtProc.AutoSize = True
        Me.txtProc.BackColor = System.Drawing.Color.Transparent
        Me.txtProc.ForeColor = System.Drawing.Color.White
        Me.txtProc.Location = New System.Drawing.Point(9, 32)
        Me.txtProc.Name = "txtProc"
        Me.txtProc.Size = New System.Drawing.Size(84, 13)
        Me.txtProc.TabIndex = 4
        Me.txtProc.Text = "Path of process "
        '
        'FormTitle
        '
        Me.FormTitle.BackgroundImage = Global.FroggMonitor.My.Resources.Resources.optiontitle
        Me.FormTitle.Location = New System.Drawing.Point(-3, -64)
        Me.FormTitle.Name = "FormTitle"
        Me.FormTitle.Size = New System.Drawing.Size(191, 176)
        Me.FormTitle.TabIndex = 10
        Me.FormTitle.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Image = Global.FroggMonitor.My.Resources.Resources.save
        Me.btnSave.Location = New System.Drawing.Point(454, 73)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(24, 24)
        Me.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnSave.TabIndex = 10
        Me.btnSave.TabStop = False
        '
        'PanelAdvOpt
        '
        Me.PanelAdvOpt.Controls.Add(Me.btnDel)
        Me.PanelAdvOpt.Controls.Add(Me.btnAdd)
        Me.PanelAdvOpt.Controls.Add(Me.DataGridOptProcess)
        Me.PanelAdvOpt.Location = New System.Drawing.Point(7, 0)
        Me.PanelAdvOpt.Name = "PanelAdvOpt"
        Me.PanelAdvOpt.Size = New System.Drawing.Size(340, 119)
        Me.PanelAdvOpt.TabIndex = 16
        Me.PanelAdvOpt.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Image = Global.FroggMonitor.My.Resources.Resources.btnDel_o
        Me.btnDel.Location = New System.Drawing.Point(255, 37)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(39, 35)
        Me.btnDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnDel.TabIndex = 21
        Me.btnDel.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.FroggMonitor.My.Resources.Resources.btnAdd_o
        Me.btnAdd.Location = New System.Drawing.Point(255, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(39, 35)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.TabStop = False
        '
        'DataGridOptProcess
        '
        Me.DataGridOptProcess.AllowUserToAddRows = False
        Me.DataGridOptProcess.AllowUserToResizeColumns = False
        Me.DataGridOptProcess.AllowUserToResizeRows = False
        Me.DataGridOptProcess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridOptProcess.BackgroundColor = System.Drawing.Color.Black
        Me.DataGridOptProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOptProcess.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProcessList})
        Me.DataGridOptProcess.Location = New System.Drawing.Point(9, 3)
        Me.DataGridOptProcess.Name = "DataGridOptProcess"
        Me.DataGridOptProcess.RowHeadersVisible = False
        Me.DataGridOptProcess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridOptProcess.Size = New System.Drawing.Size(246, 113)
        Me.DataGridOptProcess.TabIndex = 19
        '
        'ProcessList
        '
        Me.ProcessList.Frozen = True
        Me.ProcessList.HeaderText = "Process List To Kill"
        Me.ProcessList.Name = "ProcessList"
        Me.ProcessList.ReadOnly = True
        Me.ProcessList.Width = 270
        '
        'FroggMonitorOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(553, 121)
        Me.Controls.Add(Me.PanelOptBg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FroggMonitorOption"
        Me.Text = "Frogg Monitor Option"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveCaption
        Me.PanelOptBg.ResumeLayout(False)
        Me.PanelOptBg.PerformLayout()
        CType(Me.txtClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdvOpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOpt.ResumeLayout(False)
        Me.PanelOpt.PerformLayout()
        CType(Me.FormTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdvOpt.ResumeLayout(False)
        Me.PanelAdvOpt.PerformLayout()
        CType(Me.btnDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridOptProcess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inptProc As System.Windows.Forms.TextBox
    Friend WithEvents inptLog As System.Windows.Forms.TextBox
    Friend WithEvents txtProc As System.Windows.Forms.Label
    Friend WithEvents txtLog As System.Windows.Forms.Label
    Friend WithEvents inptSaveLog As System.Windows.Forms.CheckBox
    Friend WithEvents txtTime As System.Windows.Forms.Label
    Friend WithEvents inptTime As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.PictureBox
    Friend WithEvents btnCloseOption As System.Windows.Forms.PictureBox
    Friend WithEvents PanelOpt As System.Windows.Forms.Panel
    Friend WithEvents PanelOptBg As System.Windows.Forms.Panel
    Friend WithEvents btnAdvOpt As System.Windows.Forms.PictureBox
    Friend WithEvents PanelAdvOpt As System.Windows.Forms.Panel
    Friend WithEvents DataGridOptProcess As System.Windows.Forms.DataGridView
    Friend WithEvents ProcessList As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtClose As System.Windows.Forms.PictureBox
    Friend WithEvents txtSave As System.Windows.Forms.PictureBox
    Friend WithEvents txtOption As System.Windows.Forms.PictureBox
    Friend WithEvents FormTitle As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdd As System.Windows.Forms.PictureBox
    Friend WithEvents btnDel As System.Windows.Forms.PictureBox
    Friend WithEvents txtPriority As System.Windows.Forms.Label
    Friend WithEvents inptPriority As System.Windows.Forms.ComboBox
End Class
