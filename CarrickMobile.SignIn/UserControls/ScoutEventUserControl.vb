Imports Carrick.DataModel


Public Class ScoutEventUserControl

    Private _Event As ScoutingEvent

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        With EventNameTextBox
            AddHandler .KeyUp, AddressOf CheckEntryIsValid
            AddHandler .MouseUp, AddressOf CheckEntryIsValid
            AddHandler .LostFocus, Sub()
                                       _Event.EventName = EventNameTextBox.Text
                                   End Sub
        End With

        SetSaveEnabled(False)

    End Sub

    Event RemoveLinkedEntity(sender As Object, e As EventArgs)

    Public Sub LoadData(p As ScoutingEvent)
        Debug.WriteLine(p.ToString)
        _Event = p

        With _Event
            EventNameTextBox.Text = _Event.EventName
            If .StartDateTime.HasValue Then
                FromDateTimePicker.Value = _Event.StartDateTime.Value
            Else
                FromDateTimePicker.Visible = False
            End If

            If .FinishDateTime.HasValue Then
                ToDateTimePicker.Value = _Event.FinishDateTime.Value
            Else
                ToDateTimePicker.Visible = False
            End If

            If .ClosingDateTime.HasValue AndAlso _Event.ClosingDateTime.Value > Now Then
                ClosingDateTimePicker.Value = _Event.ClosingDateTime.Value
            ElseIf .ClosingDateTime.HasValue AndAlso _Event.ClosingDateTime.Value < Now Then
                ClosingDateTimePicker.Visible = False
                ClosesLabel.Visible = False
            ElseIf .StartDateTime.HasValue AndAlso _Event.StartDateTime.Value > Now Then
                ClosingDateTimePicker.Value = _Event.StartDateTime.Value
            Else
                ClosingDateTimePicker.Visible = False
                ClosesLabel.Visible = False
            End If

            If .FinishDateTime.HasValue And .StartDateTime.HasValue Then
                PossibleNightsTextBox.Text = DateDiff(DateInterval.Day, .StartDateTime.Value.Date, .FinishDateTime.Value.Date).ToString
            Else
                PossibleNightsTextBox.Text = "?"
            End If


        End With
    End Sub


    Private Sub RemoveButton_Click(sender As Object, e As EventArgs)
        RaiseEvent RemoveLinkedEntity(Me, New EventArgs)
    End Sub

    Private Sub CheckEntryIsValid(sender As Object, e As EventArgs)
        SetSaveEnabled(True)
        'If PreferredNameTextBox.Text.Length > 0 AndAlso _
        '        LastNameTextBox.Text.Length > 0 AndAlso _
        '        MobileTextBox.Text.Length > 0 AndAlso _
        '        EmailTextBox.Text.Length > 0 Then


        'Else
        '    SetSaveEnabled(False)
        'End If

        ' MumsPreferredNameTextBox.Text IsNot Nothing AndAlso _
        ' DadsPreferredNameTextBox.Text IsNot Nothing AndAlso _
    End Sub

    Private Sub SetSaveEnabled(Enabled As Boolean)
        If Enabled Then
            'SaveButton.Enabled = True
            'SaveButton.BackColor = Color.Blue
            'SaveButton.ForeColor = Color.White
        Else
            'SaveButton.Enabled = False
            'SaveButton.BackColor = Color.LightGray
            'SaveButton.ForeColor = Color.Black
        End If
    End Sub


    Private Sub BreakLinkButton_Click(sender As Object, e As EventArgs)
        'DataRepository.Singleton.BreakParentPersonLink(Person, _Person)
        'LoadData(New Parent)
        'ComboBox1.SelectedItem = Nothing

    End Sub


End Class
