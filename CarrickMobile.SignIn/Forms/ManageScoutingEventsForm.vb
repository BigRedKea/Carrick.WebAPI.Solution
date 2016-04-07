Imports Carrick.DataModel

Public Class ManageScoutingEventsForm

    Private _Event As ScoutingEvent
    Private _ScoutControls As New Dictionary(Of Integer, ScoutingEventNightsUserControl)

    Public Sub New()
        InitializeComponent()
        For Each org As OrganisationUnit In BL.Singleton.OrganisationUnitBL.GetAllItems
            For Each s As Person In BL.Singleton.PersonBL.GetPersonsInOrganisation(org)
                Dim chk As New ScoutingEventNightsUserControl
                'HACK chk.LoadData(s)
                chk.DisplayMode = ScoutingEventNightsUserControl.eDisplayMode.DisplayPersonName
                Me.FlowLayoutPanel1.Controls.Add(chk)
                _ScoutControls.Add(s.Id, chk)
            Next
        Next

        For Each se As ScoutingEvent In BL.Singleton.ScoutingEventBL.GetAllItems
            EventsComboBox.Items.Add(se)
        Next
    End Sub


    Private Sub EventsComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles EventsComboBox.SelectedValueChanged
        _Event = CType(EventsComboBox.SelectedItem, ScoutingEvent)
        'ScoutEventUserControl1.LoadData(_Event)

        Dim PersonScoutingEvent As Dictionary(Of Integer, PersonScoutingEvent) = BL.Singleton.PersonScoutingEventBL.GetItemsForEvent(_Event)

        ' HACK For Each itm In _ScoutControls.Values
        '    itm.LoadData(_Event)
        'Next

        'For Each itm In PersonScoutingEvent.Values
        '    If itm.PersonId IsNot Nothing Then
        '        _ScoutControls.Item(itm.PersonId).LoadData(itm)
        '    End If
        'Next
    End Sub

End Class