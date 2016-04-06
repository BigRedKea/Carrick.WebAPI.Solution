<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoutingEventNightsUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.AttendingCheckBox = New System.Windows.Forms.CheckBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NightsTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AttendingCheckBox
        '
        Me.AttendingCheckBox.AutoSize = True
        Me.AttendingCheckBox.Location = New System.Drawing.Point(4, 4)
        Me.AttendingCheckBox.Name = "AttendingCheckBox"
        Me.AttendingCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.AttendingCheckBox.TabIndex = 0
        Me.AttendingCheckBox.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(76, 6)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name"
        '
        'NightsTextBox
        '
        Me.NightsTextBox.Location = New System.Drawing.Point(25, 3)
        Me.NightsTextBox.Name = "NightsTextBox"
        Me.NightsTextBox.Size = New System.Drawing.Size(45, 20)
        Me.NightsTextBox.TabIndex = 2
        '
        'ScoutingEventNightsUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NightsTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.AttendingCheckBox)
        Me.Name = "ScoutingEventNightsUserControl"
        Me.Size = New System.Drawing.Size(368, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents AttendingCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents NameLabel As System.Windows.Forms.Label
    Private WithEvents NightsTextBox As System.Windows.Forms.TextBox

End Class
