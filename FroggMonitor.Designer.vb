<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FroggMonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FroggMonitor))
        Me.txtPerf = New System.Windows.Forms.PictureBox()
        Me.btnCloseTxt = New System.Windows.Forms.PictureBox()
        Me.btnSaveTxt = New System.Windows.Forms.PictureBox()
        Me.btnOptionTxt = New System.Windows.Forms.PictureBox()
        Me.PanelContainAll = New System.Windows.Forms.Panel()
        Me.btnPerf = New System.Windows.Forms.PictureBox()
        Me.BtnExit = New System.Windows.Forms.PictureBox()
        Me.BtnFrogg = New System.Windows.Forms.PictureBox()
        Me.BtnPower = New System.Windows.Forms.PictureBox()
        Me.txtInfo = New System.Windows.Forms.Label()
        Me.BtnState = New System.Windows.Forms.PictureBox()
        Me.BtnSave = New System.Windows.Forms.PictureBox()
        Me.BtnOption = New System.Windows.Forms.PictureBox()
        CType(Me.txtPerf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCloseTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOptionTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContainAll.SuspendLayout()
        CType(Me.btnPerf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFrogg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPerf
        '
        Me.txtPerf.BackColor = System.Drawing.Color.Transparent
        Me.txtPerf.Image = Global.FroggMonitor.My.Resources.Resources.txtPerf
        Me.txtPerf.Location = New System.Drawing.Point(208, 127)
        Me.txtPerf.Name = "txtPerf"
        Me.txtPerf.Size = New System.Drawing.Size(74, 14)
        Me.txtPerf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.txtPerf.TabIndex = 11
        Me.txtPerf.TabStop = False
        Me.txtPerf.Visible = False
        '
        'btnCloseTxt
        '
        Me.btnCloseTxt.Image = Global.FroggMonitor.My.Resources.Resources.closetxt
        Me.btnCloseTxt.Location = New System.Drawing.Point(7, 15)
        Me.btnCloseTxt.Name = "btnCloseTxt"
        Me.btnCloseTxt.Size = New System.Drawing.Size(74, 14)
        Me.btnCloseTxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCloseTxt.TabIndex = 9
        Me.btnCloseTxt.TabStop = False
        Me.btnCloseTxt.Visible = False
        '
        'btnSaveTxt
        '
        Me.btnSaveTxt.Image = Global.FroggMonitor.My.Resources.Resources.savetxt
        Me.btnSaveTxt.Location = New System.Drawing.Point(210, 35)
        Me.btnSaveTxt.Name = "btnSaveTxt"
        Me.btnSaveTxt.Size = New System.Drawing.Size(74, 14)
        Me.btnSaveTxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnSaveTxt.TabIndex = 8
        Me.btnSaveTxt.TabStop = False
        Me.btnSaveTxt.Visible = False
        '
        'btnOptionTxt
        '
        Me.btnOptionTxt.Image = Global.FroggMonitor.My.Resources.Resources.optiontxt
        Me.btnOptionTxt.Location = New System.Drawing.Point(187, 8)
        Me.btnOptionTxt.Name = "btnOptionTxt"
        Me.btnOptionTxt.Size = New System.Drawing.Size(74, 14)
        Me.btnOptionTxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnOptionTxt.TabIndex = 7
        Me.btnOptionTxt.TabStop = False
        Me.btnOptionTxt.Visible = False
        '
        'PanelContainAll
        '
        Me.PanelContainAll.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainAll.BackgroundImage = Global.FroggMonitor.My.Resources.Resources.bg
        Me.PanelContainAll.Controls.Add(Me.btnPerf)
        Me.PanelContainAll.Controls.Add(Me.BtnExit)
        Me.PanelContainAll.Controls.Add(Me.BtnFrogg)
        Me.PanelContainAll.Controls.Add(Me.BtnPower)
        Me.PanelContainAll.Controls.Add(Me.txtInfo)
        Me.PanelContainAll.Controls.Add(Me.BtnState)
        Me.PanelContainAll.Controls.Add(Me.BtnSave)
        Me.PanelContainAll.Controls.Add(Me.BtnOption)
        Me.PanelContainAll.ForeColor = System.Drawing.Color.Transparent
        Me.PanelContainAll.Location = New System.Drawing.Point(60, 0)
        Me.PanelContainAll.Name = "PanelContainAll"
        Me.PanelContainAll.Size = New System.Drawing.Size(159, 157)
        Me.PanelContainAll.TabIndex = 6
        '
        'btnPerf
        '
        Me.btnPerf.BackColor = System.Drawing.Color.Transparent
        Me.btnPerf.Image = Global.FroggMonitor.My.Resources.Resources.btnPerf
        Me.btnPerf.Location = New System.Drawing.Point(127, 121)
        Me.btnPerf.Name = "btnPerf"
        Me.btnPerf.Size = New System.Drawing.Size(24, 24)
        Me.btnPerf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnPerf.TabIndex = 11
        Me.btnPerf.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.Image = Global.FroggMonitor.My.Resources.Resources.close
        Me.BtnExit.Location = New System.Drawing.Point(14, 10)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(24, 24)
        Me.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.TabStop = False
        '
        'BtnFrogg
        '
        Me.BtnFrogg.BackColor = System.Drawing.Color.Transparent
        Me.BtnFrogg.Image = Global.FroggMonitor.My.Resources.Resources.froggpt
        Me.BtnFrogg.Location = New System.Drawing.Point(0, 125)
        Me.BtnFrogg.Name = "BtnFrogg"
        Me.BtnFrogg.Size = New System.Drawing.Size(32, 32)
        Me.BtnFrogg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnFrogg.TabIndex = 8
        Me.BtnFrogg.TabStop = False
        '
        'BtnPower
        '
        Me.BtnPower.BackColor = System.Drawing.Color.Transparent
        Me.BtnPower.Image = Global.FroggMonitor.My.Resources.Resources.powerbtn
        Me.BtnPower.Location = New System.Drawing.Point(65, 88)
        Me.BtnPower.Name = "BtnPower"
        Me.BtnPower.Size = New System.Drawing.Size(30, 30)
        Me.BtnPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnPower.TabIndex = 7
        Me.BtnPower.TabStop = False
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.Color.Transparent
        Me.txtInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.ForeColor = System.Drawing.Color.White
        Me.txtInfo.Location = New System.Drawing.Point(29, 65)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(100, 23)
        Me.txtInfo.TabIndex = 6
        Me.txtInfo.Text = "INACTIVE"
        Me.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnState
        '
        Me.BtnState.BackColor = System.Drawing.Color.Transparent
        Me.BtnState.Image = Global.FroggMonitor.My.Resources.Resources.power_off
        Me.BtnState.Location = New System.Drawing.Point(66, 48)
        Me.BtnState.Name = "BtnState"
        Me.BtnState.Size = New System.Drawing.Size(27, 13)
        Me.BtnState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnState.TabIndex = 2
        Me.BtnState.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BackgroundImage = Global.FroggMonitor.My.Resources.Resources.save
        Me.BtnSave.Location = New System.Drawing.Point(134, 30)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(24, 24)
        Me.BtnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.TabStop = False
        '
        'BtnOption
        '
        Me.BtnOption.BackColor = System.Drawing.Color.Transparent
        Me.BtnOption.BackgroundImage = Global.FroggMonitor.My.Resources.Resources.option_n
        Me.BtnOption.Location = New System.Drawing.Point(111, 3)
        Me.BtnOption.Name = "BtnOption"
        Me.BtnOption.Size = New System.Drawing.Size(24, 24)
        Me.BtnOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnOption.TabIndex = 5
        Me.BtnOption.TabStop = False
        '
        'FroggMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(300, 157)
        Me.Controls.Add(Me.txtPerf)
        Me.Controls.Add(Me.btnCloseTxt)
        Me.Controls.Add(Me.btnSaveTxt)
        Me.Controls.Add(Me.btnOptionTxt)
        Me.Controls.Add(Me.PanelContainAll)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FroggMonitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frogg Monitor"
        Me.TransparencyKey = System.Drawing.Color.MidnightBlue
        CType(Me.txtPerf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCloseTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOptionTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContainAll.ResumeLayout(False)
        Me.PanelContainAll.PerformLayout()
        CType(Me.btnPerf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFrogg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnState As System.Windows.Forms.PictureBox
    Friend WithEvents BtnExit As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSave As System.Windows.Forms.PictureBox
    Friend WithEvents BtnOption As System.Windows.Forms.PictureBox
    Friend WithEvents PanelContainAll As System.Windows.Forms.Panel
    Friend WithEvents txtInfo As System.Windows.Forms.Label
    Friend WithEvents BtnPower As System.Windows.Forms.PictureBox
    Friend WithEvents BtnFrogg As System.Windows.Forms.PictureBox
    Friend WithEvents btnOptionTxt As System.Windows.Forms.PictureBox
    Friend WithEvents btnSaveTxt As System.Windows.Forms.PictureBox
    Friend WithEvents btnCloseTxt As System.Windows.Forms.PictureBox
    Friend WithEvents btnPerf As System.Windows.Forms.PictureBox
    Friend WithEvents txtPerf As System.Windows.Forms.PictureBox

End Class
