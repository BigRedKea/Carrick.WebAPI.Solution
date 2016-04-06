<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PersonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParentsAndResidencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckPersonRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BadgesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BadgesToAuthoriseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BadgesToPresentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainBadgeRequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BadgeStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaceOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableLeaderModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadMembershipDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageEventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportDataToCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaderModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.CountPersons = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewPersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonsToolStripMenuItem, Me.BadgesToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LeaderModeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(766, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PersonsToolStripMenuItem
        '
        Me.PersonsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParentsAndResidencesToolStripMenuItem, Me.CheckPersonRecordsToolStripMenuItem, Me.NewPersonToolStripMenuItem})
        Me.PersonsToolStripMenuItem.Name = "PersonsToolStripMenuItem"
        Me.PersonsToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.PersonsToolStripMenuItem.Text = "Persons"
        '
        'ParentsAndResidencesToolStripMenuItem
        '
        Me.ParentsAndResidencesToolStripMenuItem.Name = "ParentsAndResidencesToolStripMenuItem"
        Me.ParentsAndResidencesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ParentsAndResidencesToolStripMenuItem.Text = "Parents and Residences"
        '
        'CheckPersonRecordsToolStripMenuItem
        '
        Me.CheckPersonRecordsToolStripMenuItem.Name = "CheckPersonRecordsToolStripMenuItem"
        Me.CheckPersonRecordsToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.CheckPersonRecordsToolStripMenuItem.Text = "Check Person Records"
        '
        'BadgesToolStripMenuItem
        '
        Me.BadgesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BadgesToAuthoriseToolStripMenuItem, Me.BadgesToPresentToolStripMenuItem, Me.MaintainBadgeRequestsToolStripMenuItem, Me.BadgeStockToolStripMenuItem, Me.PlaceOrderToolStripMenuItem})
        Me.BadgesToolStripMenuItem.Name = "BadgesToolStripMenuItem"
        Me.BadgesToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.BadgesToolStripMenuItem.Text = "Badges"
        '
        'BadgesToAuthoriseToolStripMenuItem
        '
        Me.BadgesToAuthoriseToolStripMenuItem.Name = "BadgesToAuthoriseToolStripMenuItem"
        Me.BadgesToAuthoriseToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.BadgesToAuthoriseToolStripMenuItem.Text = "Badges To Authorise"
        '
        'BadgesToPresentToolStripMenuItem
        '
        Me.BadgesToPresentToolStripMenuItem.Name = "BadgesToPresentToolStripMenuItem"
        Me.BadgesToPresentToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.BadgesToPresentToolStripMenuItem.Text = "Badges To Present"
        '
        'MaintainBadgeRequestsToolStripMenuItem
        '
        Me.MaintainBadgeRequestsToolStripMenuItem.Name = "MaintainBadgeRequestsToolStripMenuItem"
        Me.MaintainBadgeRequestsToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.MaintainBadgeRequestsToolStripMenuItem.Text = "Maintain Badge Requests"
        '
        'BadgeStockToolStripMenuItem
        '
        Me.BadgeStockToolStripMenuItem.Name = "BadgeStockToolStripMenuItem"
        Me.BadgeStockToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.BadgeStockToolStripMenuItem.Text = "Badge Stock"
        '
        'PlaceOrderToolStripMenuItem
        '
        Me.PlaceOrderToolStripMenuItem.Name = "PlaceOrderToolStripMenuItem"
        Me.PlaceOrderToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.PlaceOrderToolStripMenuItem.Text = "Place Order"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableLeaderModeToolStripMenuItem, Me.AddAQuestionToolStripMenuItem, Me.SendEmailToolStripMenuItem, Me.LoadMembershipDataToolStripMenuItem, Me.ManageEventsToolStripMenuItem, Me.EventsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'EnableLeaderModeToolStripMenuItem
        '
        Me.EnableLeaderModeToolStripMenuItem.Name = "EnableLeaderModeToolStripMenuItem"
        Me.EnableLeaderModeToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EnableLeaderModeToolStripMenuItem.Text = "Enable Leader Mode"
        '
        'AddAQuestionToolStripMenuItem
        '
        Me.AddAQuestionToolStripMenuItem.Name = "AddAQuestionToolStripMenuItem"
        Me.AddAQuestionToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AddAQuestionToolStripMenuItem.Text = "Add a Question"
        '
        'SendEmailToolStripMenuItem
        '
        Me.SendEmailToolStripMenuItem.Name = "SendEmailToolStripMenuItem"
        Me.SendEmailToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.SendEmailToolStripMenuItem.Text = "Send Email"
        '
        'LoadMembershipDataToolStripMenuItem
        '
        Me.LoadMembershipDataToolStripMenuItem.Name = "LoadMembershipDataToolStripMenuItem"
        Me.LoadMembershipDataToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.LoadMembershipDataToolStripMenuItem.Text = "Load Membership Data"
        '
        'ManageEventsToolStripMenuItem
        '
        Me.ManageEventsToolStripMenuItem.Name = "ManageEventsToolStripMenuItem"
        Me.ManageEventsToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ManageEventsToolStripMenuItem.Text = "Persons at Events"
        '
        'EventsToolStripMenuItem
        '
        Me.EventsToolStripMenuItem.Name = "EventsToolStripMenuItem"
        Me.EventsToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EventsToolStripMenuItem.Text = "Events"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportDataToCSVToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ExportDataToCSVToolStripMenuItem
        '
        Me.ExportDataToCSVToolStripMenuItem.Name = "ExportDataToCSVToolStripMenuItem"
        Me.ExportDataToCSVToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExportDataToCSVToolStripMenuItem.Text = "Export Data"
        '
        'LeaderModeToolStripMenuItem
        '
        Me.LeaderModeToolStripMenuItem.Name = "LeaderModeToolStripMenuItem"
        Me.LeaderModeToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.LeaderModeToolStripMenuItem.Text = "Leader Mode"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CountPersons})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 508)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(766, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'CountPersons
        '
        Me.CountPersons.Name = "CountPersons"
        Me.CountPersons.Size = New System.Drawing.Size(40, 17)
        Me.CountPersons.Text = "Count"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(766, 484)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'NewPersonToolStripMenuItem
        '
        Me.NewPersonToolStripMenuItem.Name = "NewPersonToolStripMenuItem"
        Me.NewPersonToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.NewPersonToolStripMenuItem.Text = "New Person"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 530)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MainForm"
        Me.Text = "Person Login"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PersonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportDataToCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableLeaderModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BadgesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintainBadgeRequestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddAQuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CountPersons As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ParentsAndResidencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckPersonRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BadgesToAuthoriseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BadgesToPresentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadMembershipDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageEventsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaderModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BadgeStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaceOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewPersonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
