<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentUserControl
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
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MemberNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MobileTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.BreakLinkButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PreferredNameTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(116, 69)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(202, 20)
        Me.LastNameTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LastName"
        '
        'MemberNumberTextBox
        '
        Me.MemberNumberTextBox.Location = New System.Drawing.Point(116, 95)
        Me.MemberNumberTextBox.Name = "MemberNumberTextBox"
        Me.MemberNumberTextBox.Size = New System.Drawing.Size(202, 20)
        Me.MemberNumberTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Membership"
        '
        'MobileTextBox
        '
        Me.MobileTextBox.Location = New System.Drawing.Point(116, 121)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(202, 20)
        Me.MobileTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mobile"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(116, 147)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(202, 20)
        Me.EmailTextBox.TabIndex = 8
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(10, 150)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(32, 13)
        Me.EmailLabel.TabIndex = 9
        Me.EmailLabel.Text = "Email"
        '
        'BreakLinkButton
        '
        Me.BreakLinkButton.Location = New System.Drawing.Point(239, 3)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Preferred Name"
        '
        'PreferredNameTextBox
        '
        Me.PreferredNameTextBox.Location = New System.Drawing.Point(116, 43)
        Me.PreferredNameTextBox.Name = "PreferredNameTextBox"
        Me.PreferredNameTextBox.Size = New System.Drawing.Size(202, 20)
        Me.PreferredNameTextBox.TabIndex = 14
        '
        'ParentUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PreferredNameTextBox)
        Me.Controls.Add(Me.BreakLinkButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MobileTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MemberNumberTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Name = "ParentUserControl"
        Me.Size = New System.Drawing.Size(326, 177)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MemberNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents BreakLinkButton As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PreferredNameTextBox As System.Windows.Forms.TextBox

End Class
