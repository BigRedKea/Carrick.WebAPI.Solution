Imports Carrick.BusinessLogic.BusinessLogic
Imports Carrick.BusinessLogic.CompositeObjects
Imports Carrick.BusinessLogic.Interfaces
Imports Carrick.DataModel


Public Class OrganisationLoginUserControl
    Private _Patrol As OrganisationUnit

    Public Sub New(org As OrganisationUnit)

        ' This call is required by the designer.
        InitializeComponent()

        PatrolNameLabel.Text = org.Description
        _Patrol = org
        Me.TableLayoutPanel1.RowCount = 0

        'For Each Scout As Person In BL.Singleton.PersonBL.GetPersonsInOrganisation(org)
        '    AddPersonControl(Scout)
        'Next

        'PatrolColourPanel.BackColor = Color.FromName(org.PatrolColour)

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

    Private Sub AddPersonControl(Person As PersonComposite)

        Dim ctl As PersonLoginUserControl = New PersonLoginUserControl(Person)


        Me.TableLayoutPanel1.Controls.Add(ctl)

        For Each row As RowStyle In TableLayoutPanel1.RowStyles
            row.SizeType = SizeType.AutoSize
        Next

        Me.Height = Me.TableLayoutPanel1.Controls.Count * ctl.Height + 100
    End Sub

    Private Sub RemovePersonControl(Person As Person)
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
