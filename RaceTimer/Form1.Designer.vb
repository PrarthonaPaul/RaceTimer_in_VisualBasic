<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRaceTimer
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnLap = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lstTimer = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(123, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(141, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Race Timer"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(123, 79)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(147, 32)
        Me.lblDisplay.TabIndex = 1
        Me.lblDisplay.Text = "00:00:00:00"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 130)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(110, 48)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnLap
        '
        Me.btnLap.Location = New System.Drawing.Point(154, 130)
        Me.btnLap.Name = "btnLap"
        Me.btnLap.Size = New System.Drawing.Size(110, 48)
        Me.btnLap.TabIndex = 3
        Me.btnLap.Text = "Lap"
        Me.btnLap.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(290, 130)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(110, 48)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lstTimer
        '
        Me.lstTimer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lstTimer.FormattingEnabled = True
        Me.lstTimer.ItemHeight = 20
        Me.lstTimer.Location = New System.Drawing.Point(60, 208)
        Me.lstTimer.Name = "lstTimer"
        Me.lstTimer.Size = New System.Drawing.Size(285, 84)
        Me.lstTimer.TabIndex = 5
        '
        'frmRaceTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 336)
        Me.Controls.Add(Me.lstTimer)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnLap)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "frmRaceTimer"
        Me.Text = "RaceTimer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnLap As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lstTimer As ListBox
End Class
