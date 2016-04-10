Imports Carrick.BusinessLogic.Interfaces
Imports Carrick.DataModel


Public Class ParentUserControl

    Public Property ScoutParent As Person
    Public Property Scout As Person

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        With PreferredNameTextBox
            AddHandler .LostFocus, Sub()
                                       _ScoutParent.PreferredName = PreferredNameTextBox.Text
                                   End Sub
        End With

        With LastNameTextBox
            AddHandler .LostFocus, Sub()
                                       _ScoutParent.Surname = LastNameTextBox.Text
                                   End Sub
        End With

        With MemberNumberTextBox
            AddHandler .LostFocus, Sub()
                                       _ScoutParent.MembershipId = MemberNumberTextBox.Text
                                   End Sub
        End With

        With MobileTextBox
            AddHandler .LostFocus, Sub()
                                       _ScoutParent.Mobile = MobileTextBox.Text
                                   End Sub
        End With

        With EmailTextBox
            AddHandler .LostFocus, Sub()
                                       _ScoutParent.Email = EmailTextBox.Text
                                   End Sub
        End With

        For Each itm As Person In BL.Singleton.PersonBL.GetAllItems
            ComboBox1.Items.Add(itm)
        Next

    End Sub

    Event RemoveLinkedEntity(sender As Object, e As EventArgs)

    Public Sub LoadData(p As Person)
        Debug.WriteLine(p.ToString)
        _ScoutParent = p
        With _ScoutParent
            LastNameTextBox.Text = .Surname
            PreferredNameTextBox.Text = .PreferredName
            MemberNumberTextBox.Text = .MembershipId
            MobileTextBox.Text = .Mobile
            EmailTextBox.Text = .Email
        End With
        ComboBox1.SelectedItem = p
    End Sub


    Private Sub RemoveButton_Click(sender As Object, e As EventArgs)
        RaiseEvent RemoveLinkedEntity(Me, New EventArgs)
    End Sub


    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim p As Person = CType(ComboBox1.SelectedItem, Person)
            If p Is Nothing Then
                'Do nothing
            Else
                BL.Singleton.PersonPersonBL.LinkScoutParent(_Scout, _ScoutParent)
            End If

            LoadData(CType(ComboBox1.SelectedItem, Person))
        End If
    End Sub


    Private Sub BreakLinkButton_Click(sender As Object, e As EventArgs) Handles BreakLinkButton.Click
        BL.Singleton.PersonPersonBL.BreakParentScoutLink(Scout, _ScoutParent)
        LoadData(BL.Singleton.PersonBL.CreateItem)
        ComboBox1.SelectedItem = Nothing
    End Sub




End Class
