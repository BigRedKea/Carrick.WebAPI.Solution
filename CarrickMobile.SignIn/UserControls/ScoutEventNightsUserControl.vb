Imports Carrick.BusinessLogic.CompositeObjects
Imports Carrick.BusinessLogic.Interfaces

Public Class ScoutingEventNightsUserControl
    Private _sae As PersonScoutingEventComposite

    Public Enum eDisplayMode
        DisplayPersonName
        DisplayEventName
    End Enum

    Property DisplayMode As eDisplayMode = eDisplayMode.DisplayPersonName


    Public Sub New()
        InitializeComponent()
        AddHandler AttendingCheckBox.Click, Sub(sender As Object, e As EventArgs)
                                                If AttendingCheckBox.Checked Then
                                                    BL.Singleton.PersonScoutingEventBL.Link(_sae.ScoutingEvent, _sae.Person)
                                                Else
                                                    BL.Singleton.PersonScoutingEventBL.UnLink(_sae)
                                                End If
                                                RefreshData()
                                            End Sub
    End Sub

    Property Checked As Boolean
        Get
            Return AttendingCheckBox.Checked
        End Get
        Set(value As Boolean)
            AttendingCheckBox.Checked = value
            RefreshData()
        End Set
    End Property


    Private Sub RefreshData()
        Dim closingDate As Date = Now.AddDays(-1)
        If _sae.ScoutingEvent IsNot Nothing AndAlso _sae.ScoutingEvent.StartDateTime.HasValue Then
            closingDate = _sae.ScoutingEvent.StartDateTime.Value
        End If

        If _sae.ScoutingEvent IsNot Nothing AndAlso _sae.ScoutingEvent.ClosingDateTime.HasValue Then
            closingDate = _sae.ScoutingEvent.ClosingDateTime.Value
        End If

        Dim finishDate As Date = Now.AddDays(1)
        If _sae.ScoutingEvent IsNot Nothing AndAlso _sae.ScoutingEvent.FinishDateTime.HasValue Then
            finishDate = _sae.ScoutingEvent.FinishDateTime.Value
        End If

        NightsTextBox.Enabled = Checked _
                    And (BL.Singleton.LeaderModeEnabled Or closingDate > Now) _
                    And finishDate < Now

        If Checked = False Then
            _sae = Nothing
            NightsTextBox.Text = ""
        End If

        Select Case DisplayMode
            Case eDisplayMode.DisplayEventName
                'HACK If _sae.ScoutingEvent IsNot Nothing Then NameLabel.Text = _sae.ScoutingEvent.StartDateTime.ToStringWithDates
            Case eDisplayMode.DisplayPersonName
                If _sae.Person IsNot Nothing Then NameLabel.Text = _sae.Person.FullName
        End Select


        If _sae IsNot Nothing AndAlso _sae.PersonScoutingEvent.NightsUnderCanvas.HasValue Then
            NightsTextBox.Text = _sae.PersonScoutingEvent.NightsUnderCanvas.Value.ToString
        Else
            NightsTextBox.Text = ""
        End If
    End Sub

    Public Sub LoadData(sae As PersonScoutingEventComposite)
        _sae = sae

        If _sae.PersonScoutingEvent.RegisteredForEvent.HasValue Then
            Checked = _sae.PersonScoutingEvent.RegisteredForEvent.Value
        End If
        RefreshData()
    End Sub

    'Public Sub LoadData(s As Person)
    '    _Person = s
    '    Checked = False
    '    RefreshData()
    'End Sub

    'Public Sub LoadData(se As ScoutingEvent)
    '    _se = se

    '    Checked = False
    '    RefreshData()
    'End Sub

    Private Sub NightsTextBox_TextChanged(sender As Object, e As EventArgs) Handles NightsTextBox.TextChanged
        If IsNumeric(NightsTextBox.Text) Then
            _sae.PersonScoutingEvent.NightsUnderCanvas = CInt(NightsTextBox.Text)
        End If
    End Sub
End Class
