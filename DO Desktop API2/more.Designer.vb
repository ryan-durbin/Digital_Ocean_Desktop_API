<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class more
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
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.nameInfoLabel = New System.Windows.Forms.Label()
        Me.backupLabel = New System.Windows.Forms.Label()
        Me.imageLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.regionLabel = New System.Windows.Forms.Label()
        Me.sizeLabel = New System.Windows.Forms.Label()
        Me.statusInfoLabel = New System.Windows.Forms.Label()
        Me.backupInfoLabel = New System.Windows.Forms.Label()
        Me.imageIDInfoLabel = New System.Windows.Forms.Label()
        Me.regionInfoLabel = New System.Windows.Forms.Label()
        Me.sizeInfoLabel = New System.Windows.Forms.Label()
        Me.Status2leabel = New System.Windows.Forms.Label()
        Me.Status2label = New System.Windows.Forms.Label()
        Me.rebootButton = New System.Windows.Forms.Button()
        Me.powerCycleButton = New System.Windows.Forms.Button()
        Me.enableBackupsButton = New System.Windows.Forms.Button()
        Me.disableBackupsButton = New System.Windows.Forms.Button()
        Me.powerOnButton = New System.Windows.Forms.Button()
        Me.powerOffButton = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.resetPasswordButton = New System.Windows.Forms.Button()
        Me.snapshotButton = New System.Windows.Forms.Button()
        Me.resizeButton = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Location = New System.Drawing.Point(14, 33)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(58, 13)
        Me.statusLabel.TabIndex = 0
        Me.statusLabel.Text = "IP Address"
        '
        'nameInfoLabel
        '
        Me.nameInfoLabel.AutoSize = True
        Me.nameInfoLabel.Location = New System.Drawing.Point(78, 9)
        Me.nameInfoLabel.Name = "nameInfoLabel"
        Me.nameInfoLabel.Size = New System.Drawing.Size(0, 13)
        Me.nameInfoLabel.TabIndex = 1
        '
        'backupLabel
        '
        Me.backupLabel.AutoSize = True
        Me.backupLabel.Location = New System.Drawing.Point(28, 82)
        Me.backupLabel.Name = "backupLabel"
        Me.backupLabel.Size = New System.Drawing.Size(44, 13)
        Me.backupLabel.TabIndex = 2
        Me.backupLabel.Text = "Backup"
        '
        'imageLabel
        '
        Me.imageLabel.AutoSize = True
        Me.imageLabel.Location = New System.Drawing.Point(28, 106)
        Me.imageLabel.Name = "imageLabel"
        Me.imageLabel.Size = New System.Drawing.Size(50, 13)
        Me.imageLabel.TabIndex = 4
        Me.imageLabel.Text = "Image ID"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(37, 9)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(35, 13)
        Me.nameLabel.TabIndex = 5
        Me.nameLabel.Text = "Name"
        '
        'regionLabel
        '
        Me.regionLabel.AutoSize = True
        Me.regionLabel.Location = New System.Drawing.Point(31, 131)
        Me.regionLabel.Name = "regionLabel"
        Me.regionLabel.Size = New System.Drawing.Size(41, 13)
        Me.regionLabel.TabIndex = 6
        Me.regionLabel.Text = "Region"
        '
        'sizeLabel
        '
        Me.sizeLabel.AutoSize = True
        Me.sizeLabel.Location = New System.Drawing.Point(45, 155)
        Me.sizeLabel.Name = "sizeLabel"
        Me.sizeLabel.Size = New System.Drawing.Size(27, 13)
        Me.sizeLabel.TabIndex = 7
        Me.sizeLabel.Text = "Size"
        '
        'statusInfoLabel
        '
        Me.statusInfoLabel.AutoSize = True
        Me.statusInfoLabel.Location = New System.Drawing.Point(78, 33)
        Me.statusInfoLabel.Name = "statusInfoLabel"
        Me.statusInfoLabel.Size = New System.Drawing.Size(0, 13)
        Me.statusInfoLabel.TabIndex = 8
        '
        'backupInfoLabel
        '
        Me.backupInfoLabel.AutoSize = True
        Me.backupInfoLabel.Location = New System.Drawing.Point(78, 82)
        Me.backupInfoLabel.Name = "backupInfoLabel"
        Me.backupInfoLabel.Size = New System.Drawing.Size(0, 13)
        Me.backupInfoLabel.TabIndex = 9
        '
        'imageIDInfoLabel
        '
        Me.imageIDInfoLabel.AutoSize = True
        Me.imageIDInfoLabel.Location = New System.Drawing.Point(78, 106)
        Me.imageIDInfoLabel.Name = "imageIDInfoLabel"
        Me.imageIDInfoLabel.Size = New System.Drawing.Size(0, 13)
        Me.imageIDInfoLabel.TabIndex = 11
        '
        'regionInfoLabel
        '
        Me.regionInfoLabel.AutoSize = True
        Me.regionInfoLabel.Location = New System.Drawing.Point(78, 131)
        Me.regionInfoLabel.Name = "regionInfoLabel"
        Me.regionInfoLabel.Size = New System.Drawing.Size(0, 13)
        Me.regionInfoLabel.TabIndex = 12
        '
        'sizeInfoLabel
        '
        Me.sizeInfoLabel.AutoSize = True
        Me.sizeInfoLabel.Location = New System.Drawing.Point(78, 155)
        Me.sizeInfoLabel.Name = "sizeInfoLabel"
        Me.sizeInfoLabel.Size = New System.Drawing.Size(0, 13)
        Me.sizeInfoLabel.TabIndex = 13
        '
        'Status2leabel
        '
        Me.Status2leabel.AutoSize = True
        Me.Status2leabel.Location = New System.Drawing.Point(78, 58)
        Me.Status2leabel.Name = "Status2leabel"
        Me.Status2leabel.Size = New System.Drawing.Size(0, 13)
        Me.Status2leabel.TabIndex = 15
        '
        'Status2label
        '
        Me.Status2label.AutoSize = True
        Me.Status2label.Location = New System.Drawing.Point(35, 58)
        Me.Status2label.Name = "Status2label"
        Me.Status2label.Size = New System.Drawing.Size(37, 13)
        Me.Status2label.TabIndex = 14
        Me.Status2label.Text = "Status"
        '
        'rebootButton
        '
        Me.rebootButton.Enabled = False
        Me.rebootButton.Location = New System.Drawing.Point(12, 180)
        Me.rebootButton.Name = "rebootButton"
        Me.rebootButton.Size = New System.Drawing.Size(75, 23)
        Me.rebootButton.TabIndex = 16
        Me.rebootButton.Text = "Reboot"
        Me.rebootButton.UseVisualStyleBackColor = True
        '
        'powerCycleButton
        '
        Me.powerCycleButton.Enabled = False
        Me.powerCycleButton.Location = New System.Drawing.Point(93, 180)
        Me.powerCycleButton.Name = "powerCycleButton"
        Me.powerCycleButton.Size = New System.Drawing.Size(75, 23)
        Me.powerCycleButton.TabIndex = 17
        Me.powerCycleButton.Text = "Power Cycle"
        Me.powerCycleButton.UseVisualStyleBackColor = True
        '
        'enableBackupsButton
        '
        Me.enableBackupsButton.Enabled = False
        Me.enableBackupsButton.Location = New System.Drawing.Point(175, 180)
        Me.enableBackupsButton.Name = "enableBackupsButton"
        Me.enableBackupsButton.Size = New System.Drawing.Size(97, 23)
        Me.enableBackupsButton.TabIndex = 18
        Me.enableBackupsButton.Text = "Enable Backups"
        Me.enableBackupsButton.UseVisualStyleBackColor = True
        '
        'disableBackupsButton
        '
        Me.disableBackupsButton.Enabled = False
        Me.disableBackupsButton.Location = New System.Drawing.Point(175, 209)
        Me.disableBackupsButton.Name = "disableBackupsButton"
        Me.disableBackupsButton.Size = New System.Drawing.Size(97, 23)
        Me.disableBackupsButton.TabIndex = 21
        Me.disableBackupsButton.Text = "Disable Backups"
        Me.disableBackupsButton.UseVisualStyleBackColor = True
        '
        'powerOnButton
        '
        Me.powerOnButton.Enabled = False
        Me.powerOnButton.Location = New System.Drawing.Point(93, 209)
        Me.powerOnButton.Name = "powerOnButton"
        Me.powerOnButton.Size = New System.Drawing.Size(75, 23)
        Me.powerOnButton.TabIndex = 20
        Me.powerOnButton.Text = "Power On"
        Me.powerOnButton.UseVisualStyleBackColor = True
        '
        'powerOffButton
        '
        Me.powerOffButton.Enabled = False
        Me.powerOffButton.Location = New System.Drawing.Point(12, 209)
        Me.powerOffButton.Name = "powerOffButton"
        Me.powerOffButton.Size = New System.Drawing.Size(75, 23)
        Me.powerOffButton.TabIndex = 19
        Me.powerOffButton.Text = "Power Off"
        Me.powerOffButton.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(13, 309)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(155, 23)
        Me.Button8.TabIndex = 23
        Me.Button8.Text = "Destroy Dropplet"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'resetPasswordButton
        '
        Me.resetPasswordButton.Enabled = False
        Me.resetPasswordButton.Location = New System.Drawing.Point(13, 238)
        Me.resetPasswordButton.Name = "resetPasswordButton"
        Me.resetPasswordButton.Size = New System.Drawing.Size(155, 23)
        Me.resetPasswordButton.TabIndex = 22
        Me.resetPasswordButton.Text = "Reset Password"
        Me.resetPasswordButton.UseVisualStyleBackColor = True
        '
        'snapshotButton
        '
        Me.snapshotButton.Enabled = False
        Me.snapshotButton.Location = New System.Drawing.Point(197, 267)
        Me.snapshotButton.Name = "snapshotButton"
        Me.snapshotButton.Size = New System.Drawing.Size(75, 23)
        Me.snapshotButton.TabIndex = 27
        Me.snapshotButton.Text = "Snapshot"
        Me.snapshotButton.UseVisualStyleBackColor = True
        '
        'resizeButton
        '
        Me.resizeButton.Enabled = False
        Me.resizeButton.Location = New System.Drawing.Point(197, 238)
        Me.resizeButton.Name = "resizeButton"
        Me.resizeButton.Size = New System.Drawing.Size(75, 23)
        Me.resizeButton.TabIndex = 26
        Me.resizeButton.Text = "Resize"
        Me.resizeButton.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Enabled = False
        Me.Button12.Location = New System.Drawing.Point(13, 267)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(155, 23)
        Me.Button12.TabIndex = 25
        Me.Button12.Text = "Rename Dropplet"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'more
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 346)
        Me.Controls.Add(Me.snapshotButton)
        Me.Controls.Add(Me.resizeButton)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.resetPasswordButton)
        Me.Controls.Add(Me.disableBackupsButton)
        Me.Controls.Add(Me.powerOnButton)
        Me.Controls.Add(Me.powerOffButton)
        Me.Controls.Add(Me.enableBackupsButton)
        Me.Controls.Add(Me.powerCycleButton)
        Me.Controls.Add(Me.rebootButton)
        Me.Controls.Add(Me.Status2leabel)
        Me.Controls.Add(Me.Status2label)
        Me.Controls.Add(Me.sizeInfoLabel)
        Me.Controls.Add(Me.regionInfoLabel)
        Me.Controls.Add(Me.imageIDInfoLabel)
        Me.Controls.Add(Me.backupInfoLabel)
        Me.Controls.Add(Me.statusInfoLabel)
        Me.Controls.Add(Me.sizeLabel)
        Me.Controls.Add(Me.regionLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.imageLabel)
        Me.Controls.Add(Me.backupLabel)
        Me.Controls.Add(Me.nameInfoLabel)
        Me.Controls.Add(Me.statusLabel)
        Me.Name = "more"
        Me.Text = "more"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents nameInfoLabel As System.Windows.Forms.Label
    Friend WithEvents backupLabel As System.Windows.Forms.Label
    Friend WithEvents imageLabel As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents regionLabel As System.Windows.Forms.Label
    Friend WithEvents sizeLabel As System.Windows.Forms.Label
    Friend WithEvents statusInfoLabel As System.Windows.Forms.Label
    Friend WithEvents backupInfoLabel As System.Windows.Forms.Label
    Friend WithEvents imageIDInfoLabel As System.Windows.Forms.Label
    Friend WithEvents regionInfoLabel As System.Windows.Forms.Label
    Friend WithEvents sizeInfoLabel As System.Windows.Forms.Label
    Friend WithEvents Status2leabel As System.Windows.Forms.Label
    Friend WithEvents Status2label As System.Windows.Forms.Label
    Friend WithEvents rebootButton As System.Windows.Forms.Button
    Friend WithEvents powerCycleButton As System.Windows.Forms.Button
    Friend WithEvents enableBackupsButton As System.Windows.Forms.Button
    Friend WithEvents disableBackupsButton As System.Windows.Forms.Button
    Friend WithEvents powerOnButton As System.Windows.Forms.Button
    Friend WithEvents powerOffButton As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents resetPasswordButton As System.Windows.Forms.Button
    Friend WithEvents snapshotButton As System.Windows.Forms.Button
    Friend WithEvents resizeButton As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
End Class
