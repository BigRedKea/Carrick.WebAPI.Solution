<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MailToForm
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PersonsCheckBox = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.IndividualEmailsButton = New System.Windows.Forms.Button()
        Me.UnSelectAllButton = New System.Windows.Forms.Button()
        Me.SelectAllPersonsButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UnselectPatrolsButton = New System.Windows.Forms.Button()
        Me.PatrolsComboBox = New System.Windows.Forms.ComboBox()
        Me.SelectPatrolsButton = New System.Windows.Forms.Button()
        Me.EventUnselectButton = New System.Windows.Forms.Button()
        Me.EventsComboBox = New System.Windows.Forms.ComboBox()
        Me.SelectPersonsAtEventButton = New System.Windows.Forms.Button()
        Me.CreateEmailButton = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.IndividualEmailsButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.UnSelectAllButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SelectAllPersonsButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.UnselectPatrolsButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PatrolsComboBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SelectPatrolsButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EventUnselectButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EventsComboBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SelectPersonsAtEventButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CreateEmailButton)
        Me.SplitContainer1.Size = New System.Drawing.Size(941, 484)
        Me.SplitContainer1.SplitterDistance = 470
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PersonsCheckBox)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(470, 484)
        Me.SplitContainer2.SplitterDistance = 51
        Me.SplitContainer2.TabIndex = 0
        '
        'PersonsCheckBox
        '
        Me.PersonsCheckBox.AutoSize = True
        Me.PersonsCheckBox.Location = New System.Drawing.Point(50, 12)
        Me.PersonsCheckBox.Name = "PersonsCheckBox"
        Me.PersonsCheckBox.Size = New System.Drawing.Size(123, 17)
        Me.PersonsCheckBox.TabIndex = 0
        Me.PersonsCheckBox.Text = "BCC Persons In Email"
        Me.PersonsCheckBox.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(470, 429)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'IndividualEmailsButton
        '
        Me.IndividualEmailsButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.IndividualEmailsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndividualEmailsButton.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.IndividualEmailsButton.Location = New System.Drawing.Point(242, 426)
        Me.IndividualEmailsButton.Name = "IndividualEmailsButton"
        Me.IndividualEmailsButton.Size = New System.Drawing.Size(205, 46)
        Me.IndividualEmailsButton.TabIndex = 11
        Me.IndividualEmailsButton.Text = "Create Individual Emails"
        Me.IndividualEmailsButton.UseVisualStyleBackColor = False
        '
        'UnSelectAllButton
        '
        Me.UnSelectAllButton.Location = New System.Drawing.Point(371, 33)
        Me.UnSelectAllButton.Name = "UnSelectAllButton"
        Me.UnSelectAllButton.Size = New System.Drawing.Size(75, 23)
        Me.UnSelectAllButton.TabIndex = 10
        Me.UnSelectAllButton.Text = "Unselect"
        Me.UnSelectAllButton.UseVisualStyleBackColor = True
        '
        'SelectAllPersonsButton
        '
        Me.SelectAllPersonsButton.Location = New System.Drawing.Point(285, 33)
        Me.SelectAllPersonsButton.Name = "SelectAllPersonsButton"
        Me.SelectAllPersonsButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectAllPersonsButton.TabIndex = 9
        Me.SelectAllPersonsButton.Text = "Select"
        Me.SelectAllPersonsButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Patrols"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Events"
        '
        'UnselectPatrolsButton
        '
        Me.UnselectPatrolsButton.Location = New System.Drawing.Point(372, 120)
        Me.UnselectPatrolsButton.Name = "UnselectPatrolsButton"
        Me.UnselectPatrolsButton.Size = New System.Drawing.Size(75, 23)
        Me.UnselectPatrolsButton.TabIndex = 6
        Me.UnselectPatrolsButton.Text = "Unselect"
        Me.UnselectPatrolsButton.UseVisualStyleBackColor = True
        '
        'PatrolsComboBox
        '
        Me.PatrolsComboBox.FormattingEnabled = True
        Me.PatrolsComboBox.Location = New System.Drawing.Point(34, 122)
        Me.PatrolsComboBox.Name = "PatrolsComboBox"
        Me.PatrolsComboBox.Size = New System.Drawing.Size(246, 21)
        Me.PatrolsComboBox.TabIndex = 5
        '
        'SelectPatrolsButton
        '
        Me.SelectPatrolsButton.Location = New System.Drawing.Point(286, 120)
        Me.SelectPatrolsButton.Name = "SelectPatrolsButton"
        Me.SelectPatrolsButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectPatrolsButton.TabIndex = 4
        Me.SelectPatrolsButton.Text = "Select"
        Me.SelectPatrolsButton.UseVisualStyleBackColor = True
        '
        'EventUnselectButton
        '
        Me.EventUnselectButton.Location = New System.Drawing.Point(372, 77)
        Me.EventUnselectButton.Name = "EventUnselectButton"
        Me.EventUnselectButton.Size = New System.Drawing.Size(75, 23)
        Me.EventUnselectButton.TabIndex = 3
        Me.EventUnselectButton.Text = "Unselect"
        Me.EventUnselectButton.UseVisualStyleBackColor = True
        '
        'EventsComboBox
        '
        Me.EventsComboBox.FormattingEnabled = True
        Me.EventsComboBox.Location = New System.Drawing.Point(34, 77)
        Me.EventsComboBox.Name = "EventsComboBox"
        Me.EventsComboBox.Size = New System.Drawing.Size(246, 21)
        Me.EventsComboBox.TabIndex = 2
        '
        'SelectPersonsAtEventButton
        '
        Me.SelectPersonsAtEventButton.Location = New System.Drawing.Point(286, 77)
        Me.SelectPersonsAtEventButton.Name = "SelectPersonsAtEventButton"
        Me.SelectPersonsAtEventButton.Size = New System.Drawing.Size(75, 23)
        Me.SelectPersonsAtEventButton.TabIndex = 1
        Me.SelectPersonsAtEventButton.Text = "Select"
        Me.SelectPersonsAtEventButton.UseVisualStyleBackColor = True
        '
        'CreateEmailButton
        '
        Me.CreateEmailButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.CreateEmailButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateEmailButton.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.CreateEmailButton.Location = New System.Drawing.Point(25, 426)
        Me.CreateEmailButton.Name = "CreateEmailButton"
        Me.CreateEmailButton.Size = New System.Drawing.Size(211, 46)
        Me.CreateEmailButton.TabIndex = 0
        Me.CreateEmailButton.Text = "Create Bulk Email"
        Me.CreateEmailButton.UseVisualStyleBackColor = False
        '
        'MailToForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 484)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MailToForm"
        Me.Text = "MailToForm"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PersonsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CreateEmailButton As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SelectPersonsAtEventButton As System.Windows.Forms.Button
    Friend WithEvents EventsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EventUnselectButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UnselectPatrolsButton As System.Windows.Forms.Button
    Friend WithEvents PatrolsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SelectPatrolsButton As System.Windows.Forms.Button
    Friend WithEvents UnSelectAllButton As System.Windows.Forms.Button
    Friend WithEvents SelectAllPersonsButton As System.Windows.Forms.Button
    Friend WithEvents IndividualEmailsButton As System.Windows.Forms.Button
End Class
