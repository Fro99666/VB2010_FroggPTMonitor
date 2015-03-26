<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FroggLogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FroggLogo))
        Me.FroggLogoImg = New System.Windows.Forms.PictureBox()
        CType(Me.FroggLogoImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FroggLogoImg
        '
        Me.FroggLogoImg.Image = Global.FroggMonitor.My.Resources.Resources.frogglogo
        Me.FroggLogoImg.Location = New System.Drawing.Point(0, 0)
        Me.FroggLogoImg.Name = "FroggLogoImg"
        Me.FroggLogoImg.Size = New System.Drawing.Size(479, 152)
        Me.FroggLogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.FroggLogoImg.TabIndex = 0
        Me.FroggLogoImg.TabStop = False
        '
        'FroggLogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(484, 155)
        Me.Controls.Add(Me.FroggLogoImg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FroggLogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frogg Logo"
        Me.TransparencyKey = System.Drawing.Color.MidnightBlue
        CType(Me.FroggLogoImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FroggLogoImg As System.Windows.Forms.PictureBox
End Class
