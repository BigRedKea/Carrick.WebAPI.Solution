<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditScoutForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MedicareTextBox = New System.Windows.Forms.TextBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PreferredNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MembershipTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RankComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PatrolComboBox = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Badge = New System.Windows.Forms.Label()
        Me.PersonLeaderLabel = New System.Windows.Forms.Label()
        Me.ScoutLeaderComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RequestBadgeComboBox = New System.Windows.Forms.ComboBox()
        Me.RequestBadgeButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.AddParentButton = New System.Windows.Forms.Button()
        Me.ParentTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.ScoutingEventsLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GenderComboBox)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ActiveCheckBox)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.MedicareTextBox)
        Me.TabPage1.Controls.Add(Me.IDLabel)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.LastNameTextBox)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.PreferredNameTextBox)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.MembershipTextBox)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.RankComboBox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.PatrolComboBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(822, 372)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Location = New System.Drawing.Point(91, 248)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(56, 17)
        Me.ActiveCheckBox.TabIndex = 15
        Me.ActiveCheckBox.Text = "Active"
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Medicare"
        '
        'MedicareTextBox
        '
        Me.MedicareTextBox.Location = New System.Drawing.Point(103, 161)
        Me.MedicareTextBox.Name = "MedicareTextBox"
        Me.MedicareTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MedicareTextBox.TabIndex = 11
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(8, 354)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(18, 13)
        Me.IDLabel.TabIndex = 10
        Me.IDLabel.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Last Name"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(103, 81)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Preferred Name"
        '
        'PreferredNameTextBox
        '
        Me.PreferredNameTextBox.Location = New System.Drawing.Point(103, 55)
        Me.PreferredNameTextBox.Name = "PreferredNameTextBox"
        Me.PreferredNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PreferredNameTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Membership #"
        '
        'MembershipTextBox
        '
        Me.MembershipTextBox.Location = New System.Drawing.Point(103, 29)
        Me.MembershipTextBox.Name = "MembershipTextBox"
        Me.MembershipTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MembershipTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rank"
        '
        'RankComboBox
        '
        Me.RankComboBox.FormattingEnabled = True
        Me.RankComboBox.Location = New System.Drawing.Point(103, 134)
        Me.RankComboBox.Name = "RankComboBox"
        Me.RankComboBox.Size = New System.Drawing.Size(200, 21)
        Me.RankComboBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patrol"
        '
        'PatrolComboBox
        '
        Me.PatrolComboBox.FormattingEnabled = True
        Me.PatrolComboBox.Location = New System.Drawing.Point(103, 107)
        Me.PatrolComboBox.Name = "PatrolComboBox"
        Me.PatrolComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PatrolComboBox.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(830, 398)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(822, 372)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Badges"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Badge)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PersonLeaderLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ScoutLeaderComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RequestBadgeComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RequestBadgeButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(816, 366)
        Me.SplitContainer1.SplitterDistance = 137
        Me.SplitContainer1.TabIndex = 0
        '
        'Badge
        '
        Me.Badge.AutoSize = True
        Me.Badge.Location = New System.Drawing.Point(43, 17)
        Me.Badge.Name = "Badge"
        Me.Badge.Size = New System.Drawing.Size(38, 13)
        Me.Badge.TabIndex = 5
        Me.Badge.Text = "Badge"
        '
        'PersonLeaderLabel
        '
        Me.PersonLeaderLabel.AutoSize = True
        Me.PersonLeaderLabel.Location = New System.Drawing.Point(42, 47)
        Me.PersonLeaderLabel.Name = "PersonLeaderLabel"
        Me.PersonLeaderLabel.Size = New System.Drawing.Size(163, 13)
        Me.PersonLeaderLabel.TabIndex = 4
        Me.PersonLeaderLabel.Text = "Person Leader Asked To Approve"
        '
        'PersonLeaderComboBox
        '
        Me.ScoutLeaderComboBox.FormattingEnabled = True
        Me.ScoutLeaderComboBox.Location = New System.Drawing.Point(211, 44)
        Me.ScoutLeaderComboBox.Name = "PersonLeaderComboBox"
        Me.ScoutLeaderComboBox.Size = New System.Drawing.Size(255, 21)
        Me.ScoutLeaderComboBox.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(481, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'RequestBadgeComboBox
        '
        Me.RequestBadgeComboBox.FormattingEnabled = True
        Me.RequestBadgeComboBox.Location = New System.Drawing.Point(211, 17)
        Me.RequestBadgeComboBox.Name = "RequestBadgeComboBox"
        Me.RequestBadgeComboBox.Size = New System.Drawing.Size(255, 21)
        Me.RequestBadgeComboBox.TabIndex = 1
        '
        'RequestBadgeButton
        '
        Me.RequestBadgeButton.Location = New System.Drawing.Point(278, 89)
        Me.RequestBadgeButton.Name = "RequestBadgeButton"
        Me.RequestBadgeButton.Size = New System.Drawing.Size(129, 35)
        Me.RequestBadgeButton.TabIndex = 0
        Me.RequestBadgeButton.Text = "Request"
        Me.RequestBadgeButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(816, 225)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SplitContainer2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(822, 372)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Family"
        Me.TabPage4.UseVisualStyleBackColor = True
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.AddParentButton)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ParentTableLayoutPanel)
        Me.SplitContainer2.Size = New System.Drawing.Size(822, 372)
        Me.SplitContainer2.SplitterDistance = 36
        Me.SplitContainer2.TabIndex = 0
        '
        'AddParentButton
        '
        Me.AddParentButton.Location = New System.Drawing.Point(31, 10)
        Me.AddParentButton.Name = "AddParentButton"
        Me.AddParentButton.Size = New System.Drawing.Size(75, 23)
        Me.AddParentButton.TabIndex = 0
        Me.AddParentButton.Text = "Add"
        Me.AddParentButton.UseVisualStyleBackColor = True
        '
        'ParentTableLayoutPanel
        '
        Me.ParentTableLayoutPanel.ColumnCount = 1
        Me.ParentTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ParentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParentTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ParentTableLayoutPanel.Name = "ParentTableLayoutPanel"
        Me.ParentTableLayoutPanel.RowCount = 1
        Me.ParentTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ParentTableLayoutPanel.Size = New System.Drawing.Size(822, 332)
        Me.ParentTableLayoutPanel.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SplitContainer3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(822, 372)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Events"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.ScoutingEventsLayoutPanel1)
        Me.SplitContainer3.Size = New System.Drawing.Size(816, 366)
        Me.SplitContainer3.SplitterDistance = 40
        Me.SplitContainer3.TabIndex = 0
        '
        'ScoutingEventsLayoutPanel1
        '
        Me.ScoutingEventsLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScoutingEventsLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ScoutingEventsLayoutPanel1.Name = "ScoutingEventsLayoutPanel1"
        Me.ScoutingEventsLayoutPanel1.Size = New System.Drawing.Size(816, 322)
        Me.ScoutingEventsLayoutPanel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Gender"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(103, 187)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(200, 21)
        Me.GenderComboBox.TabIndex = 18
        '
        'EditPersonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 398)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "EditPersonForm"
        Me.Text = "EditPerson"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PatrolComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RankComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents RequestBadgeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RequestBadgeButton As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MembershipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PreferredNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Badge As System.Windows.Forms.Label
    Friend WithEvents PersonLeaderLabel As System.Windows.Forms.Label
    Friend WithEvents ScoutLeaderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IDLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MedicareTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ParentTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AddParentButton As System.Windows.Forms.Button
    Friend WithEvents ActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ScoutingEventsLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
