Option Strict On
Option Explicit On

Imports Scout.BusinessLogic.CompositeObjects
Imports Scout.BusinessLogic.Interfaces
Imports ScoutDataModelPortable.Model

Public Class BadgeRequestDataGridViewRow : Inherits DataGridViewRow

    Private Shared bm As Image

    Private BadgeRequestPKCell As New DataGridViewTextBoxCell()
    Private BadgeNameCell As New DataGridViewTextBoxCell()
    Private ScoutNameCell As New DataGridViewTextBoxCell()
    Private BadgeImageCell As New DataGridViewImageCell()
    'Private OrderGuidCell As New DataGridViewTextBoxCell()
    Private LeaderAssignedCell As New DataGridViewComboBoxCell()
    Private AuthorisedByCell As New DataGridViewComboBoxCell()
    Private PresentedCell As New DataGridViewTextBoxCell()
    Private StockCell As New DataGridViewTextBoxCell()
    Private MarkCell As New DataGridViewCheckBoxCell()

    Public Sub New()
        With Me.Cells
            .Add(BadgeRequestPKCell)
            .Add(BadgeNameCell)
            .Add(ScoutNameCell)
            .Add(BadgeImageCell)
            '.Add(OrderGuidCell)
            .Add(LeaderAssignedCell)
            .Add(AuthorisedByCell)
            .Add(PresentedCell)
            .Add(StockCell)
            .Add(MarkCell)

            With BadgeRequestPKCell
                .ReadOnly = True
            End With

            With BadgeNameCell
                .ReadOnly = True
            End With

            With ScoutNameCell
                .ReadOnly = True
            End With

            With BadgeImageCell
                .ReadOnly = True
            End With

            'With OrderGuidCell
            '.ReadOnly = True
            'End With


            With AuthorisedByCell
                .ReadOnly = Not BL.Singleton.LeaderModeEnabled()
            End With

            With PresentedCell
                .ReadOnly = True
            End With

            With StockCell
                .ReadOnly = True
            End With

        End With


    End Sub

    Private _BadgeRequest As PersonBadgeComposite

    Property brc As PersonBadgeComposite
        Get
            Return _BadgeRequest
        End Get
        Set(value As PersonBadgeComposite)

            _BadgeRequest = value

            BadgeRequestPKCell.Value = _BadgeRequest.PersonBadge.Id

            If _BadgeRequest.Badge IsNot Nothing Then
                'Scout
                ScoutNameCell.Value = _BadgeRequest.Person.FullName

                'Badge Name
                BadgeNameCell.Value = _BadgeRequest.Badge.BadgeName

                If _BadgeRequest.Badge.BadgeImage IsNot Nothing Then
                    BadgeImageCell.Value = _BadgeRequest.Badge.BadgeImage
                Else

                End If

                If BadgeImageCell.Value Is Nothing Then
                    'Me.Height = bm.Height
                Else
                    Me.Height = CType(BadgeImageCell.Value, Image).Height
                End If

            End If


            LeaderAssignedCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            For Each leader As IPerson In BL.Singleton.PersonBL.GetItems
                LeaderAssignedCell.Items.Add(leader.ScoutName)
            Next
            LeaderAssignedCell.Value = BL.Singleton.PersonBL.GetItem(_BadgeRequest.PersonBadge.LeaderAssignedId.Value).ScoutName


            AuthorisedByCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            For Each leader As IPerson In BL.Singleton.PersonBL.GetItems
                AuthorisedByCell.Items.Add(leader.ScoutName)
            Next
            If _BadgeRequest.PersonBadge.AuthorisedById.HasValue Then
                AuthorisedByCell.Value = BL.Singleton.PersonBL.GetItem(_BadgeRequest.PersonBadge.AuthorisedById.Value).ScoutName
            End If

            If _BadgeRequest.PersonBadge.PresentedDateTime.HasValue Then
                PresentedCell.Value = _BadgeRequest.PersonBadge.PresentedDateTime.Value.ToString("d/MMM/yy")
            Else
                PresentedCell.Value = Nothing
            End If

            StockCell.Value = _BadgeRequest.Badge.Stock

            MarkCell.Value = CheckState.Unchecked
            MarkCell.ThreeState = False
        End Set
    End Property

    Property Checked As Boolean
        Get
            Return CBool(MarkCell.Value)
        End Get
        Set(value As Boolean)
            MarkCell.Value = value
        End Set
    End Property


    Sub PlaceOrder(guid As Guid)
        'If CBool(MarkCell.Value) And OrderGuidCell.Value.ToString.Length = 0 Then
        '    OrderGuidCell.Value = guid.ToString
        '    BadgeRequest.OrderGUID = guid
        'End If
    End Sub

    Sub Presented()
        If CBool(MarkCell.Value) And PresentedCell.Value Is Nothing Then
            PresentedCell.Value = Now.ToLongDateString
            BL.Singleton.BadgeRequestBL.SetBadgePresented(brc)

        End If
    End Sub

    Sub Delete()
        BL.Singleton.BadgeRequestBL.DeleteItem(_BadgeRequest)
    End Sub

    Sub SelectIfScoutPresent()
        For Each s As IPerson In BL.Singleton.PersonBL.GetItems

            'HACK If s.Id = brc.Person.Id And BL.Singleton.PersonSignInBL.GetItem(s.Id).SigninState = True Then
            '    MarkCell.Value = True
            '    Exit Sub
            'End If

            MarkCell.Value = False
        Next
    End Sub


    Public Shared Sub SetupDataGrid(grid As DataGridView)
        With grid
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False

        End With

        AddHandler grid.CellValueChanged, Sub(x As Object, e As DataGridViewCellEventArgs)

                                              If grid.IsCurrentCellDirty Then
                                                  CType(grid.CurrentRow, BadgeRequestDataGridViewRow).HandleCellChangedEvent(x, e)
                                              End If
                                          End Sub

        AddColumn(grid, "ID", New DataGridViewTextBoxCell)

        AddColumn(grid, "Scout", New DataGridViewTextBoxCell)

        AddColumn(grid, "Name", New DataGridViewTextBoxCell)

        bm = New Bitmap("ScoutIcon.jpg")
        With AddColumn(grid, "Picture", New DataGridViewImageCell)
            .Width = bm.Width
            .DefaultCellStyle.NullValue = bm
        End With

        'AddColumn(grid, "Ordered", New DataGridViewCheckBoxCell)

        AddColumn(grid, "Leader Assigned", New DataGridViewComboBoxCell)

        AddColumn(grid, "Authorised By", New DataGridViewComboBoxCell)

        AddColumn(grid, "Presented", New DataGridViewTextBoxCell)

        AddColumn(grid, "Stock", New DataGridViewTextBoxCell)

        AddColumn(grid, "Select", New DataGridViewCheckBoxCell)

    End Sub

    Private Shared Function AddColumn(grid As DataGridView, name As String, template As DataGridViewCell) As DataGridViewColumn
        Dim col1 As New DataGridViewColumn(template)
        With col1
            .HeaderText = name
            grid.Columns.Add(col1)
        End With
        Return col1
    End Function

    Private Sub HandleCellChangedEvent(x As Object, e As DataGridViewCellEventArgs)
        If LeaderAssignedCell.Value IsNot Nothing Then
            brc.PersonBadge.LeaderAssignedId = BL.Singleton.PersonBL.GetItem(CInt(LeaderAssignedCell.Value)).Id
        End If

        If AuthorisedByCell.Value IsNot Nothing Then
            brc.PersonBadge.AuthorisedById = BL.Singleton.PersonBL.GetItem(CInt(LeaderAssignedCell.Value)).Id
        End If
    End Sub

End Class
