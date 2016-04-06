﻿Imports Scout.BusinessLogic.Interfaces
Imports ScoutDataModelPortable.Model

Partial Public Class ScoutAtEventUserControl

    Private _Event As IScoutingEvent

    Public Property PersonScoutingEvent As IPersonScoutingEvent

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'With EventNameTextBox
        '    AddHandler .KeyUp, AddressOf CheckEntryIsValid
        '    AddHandler .MouseUp, AddressOf CheckEntryIsValid
        '    AddHandler .LostFocus, Sub()
        '                               _PersonScoutingEvent.GetScoutingEvent.EventName = EventNameTextBox.Text
        '                           End Sub
        'End With

        SetSaveEnabled(False)

        For Each itm As ScoutingEvent In BL.Singleton.ScoutingEventBL.GetItems()
            ComboBox1.Items.Add(itm)
        Next

    End Sub

    Event RemoveLinkedEntity(sender As Object, e As EventArgs)

    Public Sub LoadData(p As IPersonScoutingEvent)
        Debug.WriteLine(p.ToString)
        _PersonScoutingEvent = p

        _Event = BL.Singleton.ScoutingEventBL.GetScoutingEvent(p)
        Me.EventUserControl1.LoadData(_Event)

        With _PersonScoutingEvent

            If _PersonScoutingEvent.NightsUnderCanvas.HasValue Then
                NightsUnderCanvasTextBox.Text = _PersonScoutingEvent.NightsUnderCanvas.Value.ToString
            Else
                NightsUnderCanvasTextBox.BackColor = Color.Yellow
            End If

        End With
        ComboBox1.SelectedItem = p

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

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim p As ScoutingEvent = CType(ComboBox1.SelectedItem, ScoutingEvent)
            'If p Is Nothing Then
            '    'Do nothing

            'ElseIf _ScoutParent Is Nothing Then
            '    DataRepository.Singleton.InsertScoutParent(_Scout, p)

            'Else
            '    DataRepository.Singleton.UpdateScoutParent(_Scout, _ScoutParent.ParentKey.Value, p)
            'End If
            'LoadData(CType(ComboBox1.SelectedItem, Parent))
        End If
    End Sub


    Private Sub BreakLinkButton_Click(sender As Object, e As EventArgs) Handles BreakLinkButton.Click
        'DataRepository.Singleton.BreakParentScoutLink(Scout, _ScoutParent)
        'LoadData(New Parent)
        'ComboBox1.SelectedItem = Nothing

    End Sub




End Class