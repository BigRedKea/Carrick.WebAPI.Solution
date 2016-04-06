<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainBadgeRequestsForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SelectThosePresentButton = New System.Windows.Forms.Button()
        Me.PresentBadgeButton = New System.Windows.Forms.Button()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.PlaceOrderButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1084, 486)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1076, 460)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SelectThosePresentButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PresentBadgeButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SelectButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DeleteButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PlaceOrderButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1070, 454)
        Me.SplitContainer1.SplitterDistance = 36
        Me.SplitContainer1.TabIndex = 0
        '
        'SelectThosePresentButton
        '
        Me.SelectThosePresentButton.Location = New System.Drawing.Point(812, 3)
        Me.SelectThosePresentButton.Name = "SelectThosePresentButton"
        Me.SelectThosePresentButton.Size = New System.Drawing.Size(135, 27)
        Me.SelectThosePresentButton.TabIndex = 3
        Me.SelectThosePresentButton.Text = "Select those Present"
        Me.SelectThosePresentButton.UseVisualStyleBackColor = True
        '
        'PresentBadgeButton
        '
        Me.PresentBadgeButton.Location = New System.Drawing.Point(235, 3)
        Me.PresentBadgeButton.Name = "PresentBadgeButton"
        Me.PresentBadgeButton.Size = New System.Drawing.Size(135, 27)
        Me.PresentBadgeButton.TabIndex = 2
        Me.PresentBadgeButton.Text = "Record as Presented"
        Me.PresentBadgeButton.UseVisualStyleBackColor = True
        '
        'SelectButton
        '
        Me.SelectButton.Location = New System.Drawing.Point(671, 3)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(135, 27)
        Me.SelectButton.TabIndex = 2
        Me.SelectButton.Text = "Select All"
        Me.SelectButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(376, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(135, 27)
        Me.DeleteButton.TabIndex = 1
        Me.DeleteButton.Text = "Delete Selected"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'PlaceOrderButton
        '
        Me.PlaceOrderButton.Location = New System.Drawing.Point(77, 3)
        Me.PlaceOrderButton.Name = "PlaceOrderButton"
        Me.PlaceOrderButton.Size = New System.Drawing.Size(152, 27)
        Me.PlaceOrderButton.TabIndex = 0
        Me.PlaceOrderButton.Text = "Place Order"
        Me.PlaceOrderButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1070, 414)
        Me.DataGridView1.TabIndex = 0
        '
        'MaintainBadgeRequestsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 486)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MaintainBadgeRequestsForm"
        Me.Text = "Maintain Badge Requests"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PlaceOrderButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents SelectThosePresentButton As System.Windows.Forms.Button
    Friend WithEvents PresentBadgeButton As System.Windows.Forms.Button
    Friend WithEvents SelectButton As System.Windows.Forms.Button
End Class
