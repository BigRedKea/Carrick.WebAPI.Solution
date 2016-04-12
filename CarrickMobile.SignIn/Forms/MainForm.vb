Imports System.Xml
Imports System.IO
Imports System.Xml.Serialization
Imports Carrick.DataModel
Imports Carrick.BusinessLogic.Interfaces

Public Class MainForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim OrganisationUnits As List(Of OrganisationUnit) = BL.Singleton.OrganisationUnitBL.GetOrganisationsSortedLargestToSmallest

        For Each p As OrganisationUnit In OrganisationUnits
            Dim ctl As New OrganisationLoginUserControl(p)
            Me.FlowLayoutPanel1.Controls.Add(ctl)
        Next

        AddHandler BL.Singleton.PersonBL.PersonSignedInEvent, Sub(x As Object, e As EventArgs)
                                                                  RefreshScreen()
                                                              End Sub

        AddHandler BL.Singleton.PersonBL.PersonSignedOutEvent, Sub(x As Object, e As EventArgs)
                                                                   RefreshScreen()
                                                               End Sub

        Me.WindowState = FormWindowState.Maximized
        RefreshScreen()
    End Sub

    Private Sub MaintainBadgeRequests_Click(sender As Object, e As EventArgs) Handles MaintainBadgeRequestsToolStripMenuItem.Click
        Dim frm As New MaintainBadgeRequestsForm
        frm.BadgeFilter = MaintainBadgeRequestsForm.eBadgeFilter.AllBadgesForActiveScouts
        frm.Reload()
        frm.ShowDialog(Me)
    End Sub

    Private Sub BadgesToAuthoriseBadgeRequests_Click(sender As Object, e As EventArgs) Handles BadgesToAuthoriseToolStripMenuItem.Click
        Dim frm As New MaintainBadgeRequestsForm
        frm.BadgeFilter = MaintainBadgeRequestsForm.eBadgeFilter.BadgesToAuthorise
        frm.Reload()
        frm.ShowDialog(Me)
    End Sub


    Private Sub BadgeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BadgeStockToolStripMenuItem.Click
        Dim frm As New BadgesForm
        frm.loaddata()
        frm.ShowDialog(Me)
    End Sub


    Private Sub BadgesToPresentBadgeRequests_Click(sender As Object, e As EventArgs) Handles BadgesToPresentToolStripMenuItem.Click
        Dim frm As New MaintainBadgeRequestsForm
        frm.BadgeFilter = MaintainBadgeRequestsForm.eBadgeFilter.BadgesToPresent
        frm.Reload()
        frm.ShowDialog(Me)
    End Sub

    'Private Sub ExportToCSVButton_Click(sender As Object, e As EventArgs) Handles ExportDataToCSVToolStripMenuItem.Click
    '    Dim frm As New ExportDataForm
    '    frm.ShowDialog(Me)
    'End Sub

    Private Sub LeaderMode_Click(sender As Object, e As EventArgs) Handles LeaderModeToolStripMenuItem.Click

        If Not BL.Singleton.LeaderModeEnabled Then
            Dim frm As New PasswordForm
            frm.ShowDialog()
            If frm.Password <> "*********" Then
                Exit Sub
            End If
        End If

        BL.Singleton.LeaderModeEnabled = Not BL.Singleton.LeaderModeEnabled

        RefreshScreen()
    End Sub

    Private Sub RefreshScreen()
        Me.CountPersons.Text = BL.Singleton.PersonBL.GetScoutsSignedIn() & " Scouts Logged In, out of " & BL.Singleton.PersonBL.GetActiveScouts().Count

        Me.ToolsToolStripMenuItem.Enabled = BL.Singleton.LeaderModeEnabled
        Me.BadgesToolStripMenuItem.Enabled = BL.Singleton.LeaderModeEnabled
        Me.ReportsToolStripMenuItem.Enabled = BL.Singleton.LeaderModeEnabled
        Me.PersonsToolStripMenuItem.Enabled = BL.Singleton.LeaderModeEnabled
        'Me.ParentsAndResidencesToolStripMenuItem.Enabled = DataRepository.Singleton.LeaderModeEnabled
        'Me.CheckScoutRecordsToolStripMenuItem.Enabled = DataRepository.Singleton.LeaderModeEnabled

        'Me.ExportDataToCSVToolStripMenuItem.Enabled = DataRepository.Singleton.LeaderModeEnabled
        'Me.BadgesToAuthoriseToolStripMenuItem.Enabled = DataRepository.Singleton.LeaderModeEnabled
        'Me.BadgesToPresentToolStripMenuItem.Enabled = DataRepository.Singleton.LeaderModeEnabled
        'Me.SendEmailToolStripMenuItem.Enabled = DataRepository.Singleton.LeaderModeEnabled

        If BL.Singleton.LeaderModeEnabled Then
            Me.LeaderModeToolStripMenuItem.Text = "Disable Leader Mode"
            Me.BackColor = Color.Aquamarine
        Else
            Me.LeaderModeToolStripMenuItem.Text = "Enable Leader Mode"
            Me.BackColor = Color.White
        End If
    End Sub

    'Private Sub ParentsAndResidencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParentsAndResidencesToolStripMenuItem.Click
    '    Cursor = Cursors.WaitCursor
    '    Dim psr As New ScoutParentResidenceForm
    '    psr.ShowDialog(Me)
    '    Cursor = Cursors.Default
    'End Sub

    'Private Sub CheckScoutRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckPersonRecordsToolStripMenuItem.Click
    '    Dim frm As New CheckPersonDownloadForm
    '    frm.ShowDialog(Me)
    'End Sub

    Private Sub SendEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendEmailToolStripMenuItem.Click
        Dim frm As New MailToForm
        frm.ShowDialog(Me)
    End Sub


    'Private Sub LoadMembershipDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadMembershipDataToolStripMenuItem.Click
    '    Dim f As FileInfo

    '    Dim a As New OpenFileDialog
    '    a.InitialDirectory = "C:\Users\WilstonScoutGroup\Dropbox\Wilston Scout Group Committee and Leaders"
    '    a.ShowDialog()
    '    f = New FileInfo(a.FileName)

    '    MembershipSystem.RefreshFromSpreadsheet(f)
    'End Sub


    Private Sub ManageEventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageEventsToolStripMenuItem.Click
        Dim frm As New ManageScoutingEventsForm
        frm.ShowDialog(Me)
    End Sub

    'Private Sub EventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventsToolStripMenuItem.Click
    '    Dim frm As New ManageEventsForm
    '    frm.LoadData()
    '    frm.ShowDialog(Me)
    'End Sub

    Private Sub PlaceOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaceOrderToolStripMenuItem.Click

        BL.Singleton.BadgeRequestBL.AddServiceBadges()
        MsgBox("Service Badges Added")

        Dim t As String = ""
        For Each itm In BL.Singleton.BadgeRequestBL.GetBadgesToOrder
            t &= vbTab & itm.Person.FullName.ToString & " " & itm.Badge.BadgeName & vbCrLf
        Next

        If MsgBox("Place Order for " & vbCrLf & t, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            BL.Singleton.BadgeRequestBL.CreateOrder()
            MsgBox("Order Placed")
        End If
    End Sub

    'Private Sub NewScoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPersonToolStripMenuItem.Click
    '    Dim frm As New newPerson
    '    frm.ShowDialog()
    'End Sub
End Class
