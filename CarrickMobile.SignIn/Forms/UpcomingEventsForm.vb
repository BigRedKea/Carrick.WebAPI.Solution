Imports Carrick.DataModel

Public Class UpcomingEventsForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private _EventControls As Dictionary(Of Integer, ScoutingEventNightsUserControl)

    Public Sub LoadData(s As Person)
        With FlowLayoutPanel1
            .Controls.Clear()
            .AutoScroll = True

            _EventControls = New Dictionary(Of Integer, ScoutingEventNightsUserControl)

            For Each itm In BL.Singleton.PersonScoutingEventBL.GetItemsForPerson(s)
                Dim _display As Boolean = False
                If itm.ScoutingEvent.ClosingDateTime IsNot Nothing Then
                    _display = CBool(itm.ScoutingEvent.ClosingDateTime > Now)
                ElseIf itm.ScoutingEvent IsNot Nothing Then
                    _display = CBool(itm.ScoutingEvent.StartDateTime > Now)
                End If

                If _display Then
                    Dim t As New ScoutingEventNightsUserControl
                    t.DisplayMode = ScoutingEventNightsUserControl.eDisplayMode.DisplayEventName
                    t.LoadData(itm)
                    _EventControls.Add(itm.PersonScoutingEvent.Id, t)
                    .Controls.Add(t)
                End If
            Next


            For Each itm In BL.Singleton.PersonScoutingEventBL.GetItemsForPerson(s)
                If _EventControls.ContainsKey(itm.PersonScoutingEvent.Id) Then
                    _EventControls.Item(itm.PersonScoutingEvent.Id).LoadData(itm)
                End If
            Next
        End With
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class