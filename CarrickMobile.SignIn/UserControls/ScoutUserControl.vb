
Imports Carrick.BusinessLogic.Interfaces


Public Class PersonUserControl
    Private _Person As IPerson

    Public ReadOnly Property Person As IPerson
        Get
            Return _Person
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With PreferredNameTextBox
            AddHandler .KeyUp, AddressOf CheckEntryIsValid
            AddHandler .MouseUp, AddressOf CheckEntryIsValid
            AddHandler .LostFocus, Sub()
                                       _Person.PreferredName = PreferredNameTextBox.Text
                                   End Sub
        End With

        With LastNameTextBox
            AddHandler .MouseUp, AddressOf CheckEntryIsValid
            AddHandler .KeyUp, AddressOf CheckEntryIsValid
            AddHandler .LostFocus, Sub()
                                       _Person.Surname = LastNameTextBox.Text
                                   End Sub
        End With

        With MemberNumberTextBox
            AddHandler .MouseUp, AddressOf CheckEntryIsValid
            AddHandler .KeyUp, AddressOf CheckEntryIsValid
            AddHandler .LostFocus, Sub()
                                       _Person.MembershipId = MemberNumberTextBox.Text
                                   End Sub
        End With

        With MobileTextBox
            AddHandler .MouseUp, AddressOf CheckEntryIsValid
            AddHandler .KeyUp, AddressOf CheckEntryIsValid
            AddHandler .LostFocus, Sub()
                                       _Person.Mobile = MobileTextBox.Text
                                   End Sub
        End With

        With EmailTextBox
            AddHandler .MouseUp, AddressOf CheckEntryIsValid
            AddHandler .KeyUp, AddressOf CheckEntryIsValid
            AddHandler .LostFocus, Sub()
                                       _Person.Email = EmailTextBox.Text
                                   End Sub
        End With


        SetSaveEnabled(False)

    End Sub

    Event RemoveLinkedEntity(sender As Object, e As EventArgs)

    Public Sub LoadData(r As IPerson)
        _Person = r
        With _Person
            PreferredNameTextBox.Text = .PreferredName
            LastNameTextBox.Text = .Surname
            MemberNumberTextBox.Text = .MembershipId
            MobileTextBox.Text = .Mobile
            'EmailTextBox.Text = .Email
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



End Class
