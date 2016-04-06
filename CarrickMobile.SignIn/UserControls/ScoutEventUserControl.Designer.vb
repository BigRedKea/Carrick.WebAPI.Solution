<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScoutEventUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.EventNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PossibleNightsTextBox = New System.Windows.Forms.TextBox()
        Me.ClosingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ClosesLabel = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'EventNameTextBox
        '
        Me.EventNameTextBox.Enabled = False
        Me.EventNameTextBox.Location = New System.Drawing.Point(3, 6)
        Me.EventNameTextBox.Name = "EventNameTextBox"
        Me.EventNameTextBox.Size = New System.Drawing.Size(243, 20)
        Me.EventNameTextBox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(512, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Possible Nights"
        '
        'PossibleNightsTextBox
        '
        Me.PossibleNightsTextBox.Enabled = False
        Me.PossibleNightsTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PossibleNightsTextBox.Location = New System.Drawing.Point(597, 30)
        Me.PossibleNightsTextBox.Name = "PossibleNightsTextBox"
        Me.PossibleNightsTextBox.Size = New System.Drawing.Size(54, 20)
        Me.PossibleNightsTextBox.TabIndex = 20
        '
        'ClosingDateTimePicker
        '
        Me.ClosingDateTimePicker.Location = New System.Drawing.Point(349, 3)
        Me.ClosingDateTimePicker.Name = "ClosingDateTimePicker"
        Me.ClosingDateTimePicker.Size = New System.Drawing.Size(182, 20)
        Me.ClosingDateTimePicker.TabIndex = 22
        '
        'ClosesLabel
        '
        Me.ClosesLabel.AutoSize = True
        Me.ClosesLabel.Location = New System.Drawing.Point(295, 6)
        Me.ClosesLabel.Name = "ClosesLabel"
        Me.ClosesLabel.Size = New System.Drawing.Size(38, 13)
        Me.ClosesLabel.TabIndex = 23
        Me.ClosesLabel.Text = "Closes"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Location = New System.Drawing.Point(314, 32)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(182, 20)
        Me.ToDateTimePicker.TabIndex = 24
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Location = New System.Drawing.Point(100, 31)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(182, 20)
        Me.FromDateTimePicker.TabIndex = 25
        '
        'ScoutAtEventUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.ClosesLabel)
        Me.Controls.Add(Me.ClosingDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PossibleNightsTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EventNameTextBox)
        Me.Name = "ScoutAtEventUserControl"
        Me.Size = New System.Drawing.Size(677, 63)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EventNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PossibleNightsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClosingDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ClosesLabel As System.Windows.Forms.Label
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
