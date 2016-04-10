Option Strict On
Option Explicit On

Imports Carrick.BusinessLogic.CompositeObjects
Imports Carrick.BusinessLogic.Interfaces
Imports Carrick.DataModel

Public Class MaintainBadgeRequestsForm
    Public Enum eBadgeFilter
        AllBadgesForActiveScouts
        BadgesToAuthorise
        BadgesToPresent
    End Enum

    Private bm As Image
    Public Property BadgeFilter As eBadgeFilter = eBadgeFilter.AllBadgesForActiveScouts


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        BadgeRequestDataGridViewRow.SetupDataGrid(DataGridView1)

    End Sub

    Public Sub Reload()
        DataGridView1.Rows.Clear()
        Dim brs As IEnumerable(Of PersonBadgeComposite)

        Select Case BadgeFilter
            Case eBadgeFilter.AllBadgesForActiveScouts
                brs = BL.Singleton.BadgeRequestBL.GetBadgeRequestsForActiveScouts
            Case eBadgeFilter.BadgesToAuthorise
                brs = BL.Singleton.BadgeRequestBL.GetBadgesToAuthorise
            Case eBadgeFilter.BadgesToPresent
                brs = BL.Singleton.BadgeRequestBL.GetBadgesToPresentToPersonsPresent
            Case Else
                Throw New NotImplementedException
        End Select

        For Each itm As PersonBadgeComposite In brs
            If itm.Badge.BadgeEnabled Then
                AddBadge(itm)
            End If
        Next
    End Sub


    Private Sub AddBadge(itm As PersonBadgeComposite)

        Dim r As New BadgeRequestDataGridViewRow
        r.brc = itm

        DataGridView1.Rows.Add(r)

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        For Each r As BadgeRequestDataGridViewRow In DataGridView1.Rows
            If r.Checked Then
                r.Delete()
            End If
        Next

        Reload()
    End Sub

    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        For Each r As BadgeRequestDataGridViewRow In DataGridView1.Rows
            r.Checked = True

        Next
    End Sub

    Private Sub SelectThosePresentButton_Click(sender As Object, e As EventArgs) Handles SelectThosePresentButton.Click
        For Each r As BadgeRequestDataGridViewRow In DataGridView1.Rows
            r.SelectIfScoutPresent()
        Next
    End Sub

    Private Sub PresentBadgeButton_Click(sender As Object, e As EventArgs) Handles PresentBadgeButton.Click
        For Each r As BadgeRequestDataGridViewRow In DataGridView1.Rows
            If r.Checked Then
                r.Presented()
            End If
        Next
    End Sub
End Class