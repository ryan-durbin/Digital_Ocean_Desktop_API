<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.clientIdLabel = New System.Windows.Forms.Label()
        Me.clientIdTextBox = New System.Windows.Forms.TextBox()
        Me.apiTextBox = New System.Windows.Forms.TextBox()
        Me.apiLabel = New System.Windows.Forms.Label()
        Me.retrieveButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.updateLabel1 = New System.Windows.Forms.Label()
        Me.updateLabelDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.fasterCheckBox = New System.Windows.Forms.CheckBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.moreButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'clientIdLabel
        '
        Me.clientIdLabel.AutoSize = True
        Me.clientIdLabel.Location = New System.Drawing.Point(12, 26)
        Me.clientIdLabel.Name = "clientIdLabel"
        Me.clientIdLabel.Size = New System.Drawing.Size(50, 13)
        Me.clientIdLabel.TabIndex = 0
        Me.clientIdLabel.Text = "Client ID:"
        '
        'clientIdTextBox
        '
        Me.clientIdTextBox.Location = New System.Drawing.Point(68, 23)
        Me.clientIdTextBox.Name = "clientIdTextBox"
        Me.clientIdTextBox.Size = New System.Drawing.Size(224, 20)
        Me.clientIdTextBox.TabIndex = 1
        '
        'apiTextBox
        '
        Me.apiTextBox.Location = New System.Drawing.Point(68, 49)
        Me.apiTextBox.Name = "apiTextBox"
        Me.apiTextBox.Size = New System.Drawing.Size(224, 20)
        Me.apiTextBox.TabIndex = 3
        '
        'apiLabel
        '
        Me.apiLabel.AutoSize = True
        Me.apiLabel.Location = New System.Drawing.Point(12, 52)
        Me.apiLabel.Name = "apiLabel"
        Me.apiLabel.Size = New System.Drawing.Size(27, 13)
        Me.apiLabel.TabIndex = 2
        Me.apiLabel.Text = "API:"
        '
        'retrieveButton
        '
        Me.retrieveButton.Location = New System.Drawing.Point(298, 21)
        Me.retrieveButton.Name = "retrieveButton"
        Me.retrieveButton.Size = New System.Drawing.Size(75, 23)
        Me.retrieveButton.TabIndex = 5
        Me.retrieveButton.Text = "Start"
        Me.retrieveButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(298, 47)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 6
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Location = New System.Drawing.Point(35, 83)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(43, 13)
        Me.statusLabel.TabIndex = 8
        Me.statusLabel.Text = "______"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 112)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(280, 303)
        Me.ListBox1.TabIndex = 9
        '
        'updateLabel1
        '
        Me.updateLabel1.AutoSize = True
        Me.updateLabel1.Location = New System.Drawing.Point(118, 83)
        Me.updateLabel1.Name = "updateLabel1"
        Me.updateLabel1.Size = New System.Drawing.Size(68, 13)
        Me.updateLabel1.TabIndex = 11
        Me.updateLabel1.Text = "Last Update:"
        '
        'updateLabelDate
        '
        Me.updateLabelDate.AutoSize = True
        Me.updateLabelDate.Location = New System.Drawing.Point(192, 83)
        Me.updateLabelDate.Name = "updateLabelDate"
        Me.updateLabelDate.Size = New System.Drawing.Size(0, 13)
        Me.updateLabelDate.TabIndex = 12
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'fasterCheckBox
        '
        Me.fasterCheckBox.AutoSize = True
        Me.fasterCheckBox.Location = New System.Drawing.Point(308, 82)
        Me.fasterCheckBox.Name = "fasterCheckBox"
        Me.fasterCheckBox.Size = New System.Drawing.Size(55, 17)
        Me.fasterCheckBox.TabIndex = 13
        Me.fasterCheckBox.Text = "Faster"
        Me.fasterCheckBox.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(298, 112)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(65, 264)
        Me.ListBox2.TabIndex = 15
        '
        'moreButton
        '
        Me.moreButton.Enabled = False
        Me.moreButton.Location = New System.Drawing.Point(298, 382)
        Me.moreButton.Name = "moreButton"
        Me.moreButton.Size = New System.Drawing.Size(65, 33)
        Me.moreButton.TabIndex = 16
        Me.moreButton.Text = "More"
        Me.moreButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 429)
        Me.Controls.Add(Me.moreButton)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.fasterCheckBox)
        Me.Controls.Add(Me.updateLabelDate)
        Me.Controls.Add(Me.updateLabel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.retrieveButton)
        Me.Controls.Add(Me.apiTextBox)
        Me.Controls.Add(Me.apiLabel)
        Me.Controls.Add(Me.clientIdTextBox)
        Me.Controls.Add(Me.clientIdLabel)
        Me.Name = "Main"
        Me.Text = "DO Managment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clientIdLabel As System.Windows.Forms.Label
    Friend WithEvents clientIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents apiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents apiLabel As System.Windows.Forms.Label
    Friend WithEvents retrieveButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents updateLabel1 As System.Windows.Forms.Label
    Friend WithEvents updateLabelDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents fasterCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents moreButton As System.Windows.Forms.Button
End Class
