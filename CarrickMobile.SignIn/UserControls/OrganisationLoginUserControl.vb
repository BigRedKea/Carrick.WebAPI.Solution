imports Carrick.BusinessLogic
Imports Carrick.BusinessLogic.CompositeObjects
Imports Carrick.BusinessLogic.Interfaces



Public Class OrganisationLoginUserControl
    Private _Patrol As IOrganisationUnit

    Public Sub New(org As IOrganisationUnit)

        ' This call is required by the designer.
        InitializeComponent()

        PatrolNameLabel.Text = org.Description
        _Patrol = org
        Me.TableLayoutPanel1.RowCount = 0


        If String.IsNullOrEmpty(org.PatrolColour) Then
            PatrolColourPanel.BackColor = Color.White
        Else
            PatrolColourPanel.BackColor = Color.FromName(org.PatrolColour)
        End If

        AddHandler BL.Singleton.OrganisationUnitBL.PersonAddedEvent, Sub(sender As Object, e As PersonAddedEventArgs)
                                                                         If e.OrganisationUnit.Equals(_Patrol) Then
                                                                             ' AddPersonControl(e.Person)
                                                                         End If
                                                                     End Sub

        AddHandler BL.Singleton.OrganisationUnitBL.PersonRemovedEvent, Sub(sender As Object, e As PersonRemovedEventArgs)
                                                                           If e.OrganisationUnit.Equals(_Patrol) Then
                                                                               RemovePersonControl(e.Person)
                                                                           End If
                                                                       End Sub

        'Duty Patrol
        'HACK PictureBox1.Visible = _Patrol.IsPatrolOnDuty(Now)
    End Sub

    Public Sub AddScout(s As ScoutVM)

        Dim ctl As PersonLoginUserControl = New PersonLoginUserControl(s)

        Me.TableLayoutPanel1.Controls.Add(ctl)

        For Each row As RowStyle In TableLayoutPanel1.RowStyles
            row.SizeType = SizeType.AutoSize
        Next

        Me.Height = Me.TableLayoutPanel1.Controls.Count * ctl.Height + 100
    End Sub

    Private Sub RemovePersonControl(Person As IPerson)
        Dim itmToRemove As Control = Nothing
        For Each ctl As PersonLoginUserControl In TableLayoutPanel1.Controls
            If ctl.Person Is Person Then
                itmToRemove = ctl
            End If
        Next

        If itmToRemove IsNot Nothing Then
            Me.TableLayoutPanel1.Controls.Remove(itmToRemove)
        End If

    End Sub


End Class
