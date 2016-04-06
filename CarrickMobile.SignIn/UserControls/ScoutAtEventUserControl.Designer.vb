<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScoutAtEventUserControl
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
        Me.BreakLinkButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NightsUnderCanvasTextBox = New System.Windows.Forms.TextBox()
        Me.EventUserControl1 = New ScoutAtEventUserControl()
        Me.SuspendLayout()
        '
        'BreakLinkButton
        '
        Me.BreakLinkButton.Location = New System.Drawing.Point(738, 6)
        Me.BreakLinkButton.Name = "BreakLinkButton"
        Me.BreakLinkButton.Size = New System.Drawing.Size(30, 18)
        Me.BreakLinkButton.TabIndex = 13
        Me.BreakLinkButton.Text = "X"
        Me.BreakLinkButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(8, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nights"
        '
        'NightsUnderCanvasTextBox
        '
        Me.NightsUnderCanvasTextBox.Location = New System.Drawing.Point(78, 96)
        Me.NightsUnderCanvasTextBox.Name = "NightsUnderCanvasTextBox"
        Me.NightsUnderCanvasTextBox.Size = New System.Drawing.Size(54, 20)
        Me.NightsUnderCanvasTextBox.TabIndex = 18
        '
        'EventUserControl1
        '
        Me.EventUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EventUserControl1.Enabled = False
        Me.EventUserControl1.Location = New System.Drawing.Point(3, 30)
        Me.EventUserControl1.Name = "EventUserControl1"
        Me.EventUserControl1.Size = New System.Drawing.Size(765, 60)
        Me.EventUserControl1.TabIndex = 20
        '
        'PersonScoutAtEventUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.EventUserControl1)
        Me.Controls.Add(Me.NightsUnderCanvasTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BreakLinkButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "PersonScoutAtEventUserControl"
        Me.Size = New System.Drawing.Size(772, 122)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BreakLinkButton As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NightsUnderCanvasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EventUserControl1 As ScoutAtEventUserControl

End Class
