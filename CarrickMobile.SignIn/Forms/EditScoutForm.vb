Imports Carrick.BusinessLogic.CompositeObjects
Imports Carrick.BusinessLogic.Interfaces
Imports Carrick.DataModel

Public Class EditScoutForm

    Private _Scout As Person
    Private bm As Image

    Public Sub New(s As Person)

        ' This call is required by the designer.
        InitializeComponent()

        _Scout = s
        IDLabel.Text = s.Id.ToString
        Me.Text = "Edit " & s.FullName & " Details"

        'Patrol
        With PatrolComboBox
            For Each p As OrganisationUnit In BL.Singleton.OrganisationUnitBL.GetAllItems
                .Items.Add(p)
            Next

            .DropDownStyle = ComboBoxStyle.DropDown
            'HACK .SelectedItem = s.OrganisationUnit
            AddHandler .SelectionChangeCommitted, Sub(sender As Object, e As EventArgs)
                                                      BL.Singleton.PersonOrganisationUnitBL.ChangeOrganisation(_Scout, CType(PatrolComboBox.SelectedItem, OrganisationUnit))
                                                  End Sub
            .Enabled = BL.Singleton.LeaderModeEnabled
        End With


        'Scout Leader
        With Me.ScoutLeaderComboBox
            For Each itm As Person In BL.Singleton.PersonBL.GetAllItems
                .Items.Add(itm)
            Next
            .DropDownStyle = ComboBoxStyle.DropDownList
            AddHandler .SelectionChangeCommitted, Sub(sender As Object, e As EventArgs)
                                                      RefreshScreen()
                                                  End Sub
        End With

        'Rank
        'With RankComboBox
        '    For Each p As Rank In BL.Singleton.Ranks.Values
        '        .Items.Add(p)
        '    Next

        '    .DropDownStyle = ComboBoxStyle.DropDown
        '    .SelectedItem = s.Rank
        '    AddHandler .SelectionChangeCommitted, Sub(sender As Object, e As EventArgs)
        '                                              Dim frm As New ChooseDateForm
        '                                              frm.timestamp = Now
        '                                              frm.ShowDialog(Me)

        '                                              _Scout.SetRank(CType(RankComboBox.SelectedItem, Rank), frm.timestamp)
        '                                          End Sub
        '    .Enabled = BL.Singleton.LeaderModeEnabled
        'End With

        'Membership
        With MembershipTextBox
            .Text = s.MembershipId
            AddHandler .LostFocus, Sub(sender As Object, e As EventArgs)
                                       _Scout.MembershipId = MembershipTextBox.Text
                                   End Sub
            .Enabled = BL.Singleton.LeaderModeEnabled
        End With

        'PreferredName
        With PreferredNameTextBox
            .Text = s.PreferredName
            AddHandler .LostFocus, Sub(sender As Object, e As EventArgs)
                                       _Scout.PreferredName = PreferredNameTextBox.Text
                                   End Sub
            .Enabled = BL.Singleton.LeaderModeEnabled
        End With

        'Medicare
        With MedicareTextBox
            .Text = s.MedicareNumber
            AddHandler .LostFocus, Sub(sender As Object, e As EventArgs)
                                       _Scout.MedicareNumber = MedicareTextBox.Text
                                   End Sub
            .Visible = BL.Singleton.LeaderModeEnabled
        End With

        'Gender
        With GenderComboBox

            .Items.Add("M")
            .Items.Add("F")

            .DropDownStyle = ComboBoxStyle.DropDown
            .SelectedItem = s.Gender
            AddHandler .SelectionChangeCommitted, Sub(sender As Object, e As EventArgs)
                                                      _Scout.Gender = CStr(GenderComboBox.SelectedItem)
                                                  End Sub
            .Enabled = BL.Singleton.LeaderModeEnabled
        End With

        'LastName
        With LastNameTextBox
            .Text = s.Surname
            AddHandler .LostFocus, Sub(sender As Object, e As EventArgs)
                                       _Scout.Surname = LastNameTextBox.Text
                                   End Sub
            .Enabled = BL.Singleton.LeaderModeEnabled
        End With

        'Date Left
        'With ActiveCheckBox
        '    .Checked = Not (s.DateLeftOrganisation.HasValue)
        '    AddHandler .CheckedChanged, Sub(sender As Object, e As EventArgs)
        '                                    If ActiveCheckBox.CheckState = CheckState.Unchecked Then
        '                                        Dim reason As String = InputBox("Reason for leaving?", , _Scout.NotesForMembership)
        '                                        _Scout.SetScoutInActive(reason)
        '                                    Else
        '                                        _Scout.SetScoutActive()
        '                                    End If
        '                                End Sub
        '    .Enabled = BL.Singleton.LeaderModeEnabled
        'End With

        'Request Badge
        With RequestBadgeComboBox
            For Each p As Badge In BL.Singleton.BadgeBL.GetAllItems
                If p.BadgeEnabled Then
                    .Items.Add(p)
                End If
            Next

            .DropDownStyle = ComboBoxStyle.DropDownList
            '.SelectedItem = s.Rank
            AddHandler .SelectionChangeCommitted, Sub(sender As Object, e As EventArgs)
                                                      RefreshScreen()
                                                      PictureBox1.Image = (New ImageHelper).Convert(CType(RequestBadgeComboBox.SelectedItem, Badge).BadgeImage)

                                                  End Sub
            '.Enabled = DataRepository.Singleton.LeaderModeEnabled
        End With


        With RequestBadgeButton
            .Enabled = False
            AddHandler .Click, Sub(sender As Object, e As EventArgs)
                                   Dim br As PersonBadgeComposite = BL.Singleton.BadgeRequestBL.RequestBadge(_Scout, CType(RequestBadgeComboBox.SelectedItem, Badge))
                                   br.PersonBadge.LeaderAssignedId = CType(ScoutLeaderComboBox.SelectedItem, Person).Id
                                   AddBadge(br)
                                   ScoutLeaderComboBox.SelectedItem = Nothing
                                   RequestBadgeComboBox.SelectedItem = Nothing
                                   RefreshScreen()
                               End Sub
        End With

        BadgeRequestDataGridViewRow.SetupDataGrid(DataGridView1)

        For Each itm As PersonBadgeComposite In BL.Singleton.BadgeRequestBL.GetBadgeRequestsforPerson(_Scout)
            AddBadge(itm)
        Next


        With AddParentButton
            .Visible = BL.Singleton.LeaderModeEnabled
        End With

        With ParentTableLayoutPanel
            .RowStyles.Clear()
            .Controls.Clear()
            .AutoScroll = True
            For Each itm As Person In BL.Singleton.PersonBL.GetParents(_Scout)
                Dim t As New ParentUserControl
                t.LoadData(itm)
                t.Scout = _Scout
                .Controls.Add(t)
            Next
            .Visible = BL.Singleton.LeaderModeEnabled
        End With

        Dim evnts As New Dictionary(Of Integer, ScoutingEventNightsUserControl)

        With ScoutingEventsLayoutPanel1
            .Controls.Clear()
            .AutoScroll = True
            For Each itm As PersonScoutingEventComposite In BL.Singleton.ScoutingEventBL.GetScoutingEvents(_Scout)
                Dim t As New ScoutingEventNightsUserControl
                t.DisplayMode = ScoutingEventNightsUserControl.eDisplayMode.DisplayEventName
                t.LoadData(itm)
                .Controls.Add(t)
                evnts.Add(itm.PersonScoutingEvent.Id, t)
            Next

            For Each itm As PersonScoutingEventComposite In BL.Singleton.ScoutingEventBL.GetScoutingEvents(_Scout)
                If itm.ScoutingEvent.StartDateTime > Now And Not evnts.ContainsKey(itm.ScoutingEvent.Id) Then
                    Dim t As New ScoutingEventNightsUserControl
                    t.DisplayMode = ScoutingEventNightsUserControl.eDisplayMode.DisplayEventName
                    t.LoadData(itm)
                    't.LoadData(_Scout)
                    .Controls.Add(t)
                    evnts.Add(itm.ScoutingEvent.Id, t)
                End If
            Next
        End With



    End Sub

    Public Sub RefreshScreen()

        If ScoutLeaderComboBox.SelectedItem Is Nothing Then
            RequestBadgeButton.Enabled = False
        ElseIf RequestBadgeComboBox.SelectedItem Is Nothing Then
            RequestBadgeButton.Enabled = False
        Else
            'HACK  RequestBadgeButton.Enabled = CBool(CType(ScoutLeaderComboBox.SelectedItem, Person).Id <> BL.Singleton.NoLeaderAssignedPK)
        End If

    End Sub

    Private Sub AddBadge(itm As PersonBadgeComposite)
        Dim br As New BadgeRequestDataGridViewRow
        br.brc = itm

        DataGridView1.Rows.Add(br)

    End Sub


    Private Sub AddParentButton_Click(sender As Object, e As EventArgs) Handles AddParentButton.Click
        Dim pc As New ParentUserControl
        pc.Scout = _Scout
        ParentTableLayoutPanel.Controls.Add(pc)
    End Sub



End Class