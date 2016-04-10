Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Net

Imports Microsoft.Office.Interop.Outlook
Imports Carrick.DataModel
Imports Carrick.BusinessLogic.Interfaces

Public Class MailToForm
    Public Sub New()
        InitializeComponent()
        For Each org As OrganisationUnit In BL.Singleton.OrganisationUnitBL.GetAllItems
            For Each s As Person In BL.Singleton.PersonBL.GetPersonsInOrganisation(org)
                Dim chk As New ScoutCheckBox(s)
                Me.FlowLayoutPanel1.Controls.Add(chk)
            Next
            PatrolsComboBox.Items.Add(org)
        Next

        For Each se As ScoutingEvent In BL.Singleton.ScoutingEventBL.GetAllItems
            EventsComboBox.Items.Add(se)
        Next
    End Sub

    Private Sub IndividualEmailsButton_Click(sender As Object, e As EventArgs) Handles IndividualEmailsButton.Click

        For Each itm As Control In Me.FlowLayoutPanel1.Controls
            If TypeOf (itm) Is ScoutCheckBox AndAlso CType(itm, ScoutCheckBox).Checked Then
                Dim scout As Person = CType(itm, ScoutCheckBox).Scout
                Dim s As New SendMailClass
                s.recipient = ""

                Dim parents As String = ""

                For Each p As Person In BL.Singleton.PersonBL.GetParents(scout)
                    If parents.Length = 0 Then
                        parents = parents & p.PreferredName
                    Else
                        parents = parents & " and " & p.PreferredName
                    End If

                    If InStr(s.recipient, p.Email) > 0 Then
                        'Don't add more emails
                    ElseIf s.recipient.Length > 0 Then
                        s.recipient &= ";" & p.Email
                    Else
                        s.recipient = p.Email
                    End If
                Next

                If s.recipient.Length = 0 Then
                    MsgBox("Warning " & scout.FullName & " parents do not have an email address.")
                End If

                s.subject = "Wilston Scouts - Registered Activities and Records"
                's.files.Add((New ExportScoutingEventsToHTML).Execute(scout))
                s.files.Add((New ExportPersonToHTML).Execute(scout))
                s.body = "Dear " & parents & "," & vbCrLf
                s.body &= vbCrLf
                s.body &= "Please find attached an updated list of activites your scout has elected to Register or NOT Register an expression of interest in" & vbCrLf
                s.body &= vbCrLf
                s.body &= "This information is used to plan activities and communicate to those who have registered an expression of interest. So please have a chat with the Scout to make sure they have signed up to something they are available for." & vbCrLf
                s.body &= vbCrLf
                s.body &= "Changes can be made at signin." & vbCrLf
                s.body &= vbCrLf
                s.body &= vbCrLf
                s.body &= "Also attached is a copy of our records. Please make sure they are up to date, just in case the green book should go through the washing machine... or more importantly we need to contact you in an emergency." & vbCrLf
                s.body &= vbCrLf
                s.body &= "Regards Wilston Scouts"
                s.Execute()
            End If
        Next
    End Sub

    Private Sub CreateEmailButton_Click(sender As Object, e As EventArgs) Handles CreateEmailButton.Click
        OpenEmail("wilstonscouttroop@gmail.com", "From the Wilston Scout Troop", "Regards " & vbCrLf & " the Wilston Scout Leadership Team")
    End Sub

    Private Sub SelectAllScoutsButton_Click(sender As Object, e As EventArgs) Handles SelectAllPersonsButton.Click
        SelectAllScouts(True)
    End Sub

    Private Sub UnSelectAllScoutsButton_Click(sender As Object, e As EventArgs) Handles UnSelectAllButton.Click
        SelectAllScouts(False)
    End Sub

    Private Sub SelectScoutsAtEventButton_Click(sender As Object, e As EventArgs) Handles SelectPersonsAtEventButton.Click
        Dim scoutsToSelect As Dictionary(Of Integer, PersonScoutingEvent) = BL.Singleton.PersonBL.GetPersonsAtEvent(CType(EventsComboBox.SelectedItem, ScoutingEvent))

        Dim scouts As New List(Of Integer)

        For Each itm In scoutsToSelect
            If itm.Value.RegisteredForEvent Then
                scouts.Add(itm.Value.PersonId)
            End If
        Next

        SelectScouts(scouts, True)
    End Sub

    Private Sub UnSelectScoutsAtEventButton_Click(sender As Object, e As EventArgs) Handles EventUnselectButton.Click
        Dim scoutsToSelect As Dictionary(Of Integer, PersonScoutingEvent) = BL.Singleton.PersonBL.GetPersonsAtEvent(CType(EventsComboBox.SelectedItem, ScoutingEvent))

        Dim scouts As New List(Of Integer)

        For Each itm In scoutsToSelect
            If itm.Value.RegisteredForEvent Then
                scouts.Add(itm.Value.PersonId)
            End If
        Next

        SelectScouts(scouts, False)
    End Sub

    Private Sub SelectPatrolButton_Click(sender As Object, e As EventArgs) Handles SelectPatrolsButton.Click

        Dim scouts As New List(Of Integer)

        For Each itm As Person In BL.Singleton.PersonBL.GetPersonsInOrganisation(CType(PatrolsComboBox.SelectedItem, OrganisationUnit))
            scouts.Add(itm.Id)
        Next

        SelectScouts(scouts, True)
    End Sub

    Private Sub UnselectPatrols_Click(sender As Object, e As EventArgs) Handles UnselectPatrolsButton.Click

        Dim scouts As New List(Of Integer)

        For Each itm As Person In BL.Singleton.PersonBL.GetPersonsInOrganisation(CType(PatrolsComboBox.SelectedItem, OrganisationUnit))
            scouts.Add(itm.Id)
        Next

        SelectScouts(scouts, False)
    End Sub

    Sub SelectScouts(scouts As List(Of Integer), check As Boolean)
        For Each Sb As ScoutCheckBox In FlowLayoutPanel1.Controls
            If scouts.Contains(Sb.Scout.Id) Then
                Sb.Checked = check
            End If
        Next
    End Sub


    Sub SelectAllScouts(check As Boolean)
        For Each Sb As ScoutCheckBox In FlowLayoutPanel1.Controls
            Sb.Checked = check
        Next
    End Sub

    Public Function OpenEmail(ByVal EmailAddress As String,
        Optional ByVal Subject As String = "",
        Optional ByVal Body As String = "",
        Optional ByVal Attachment As String = Nothing) _
        As Boolean

        Dim bAns As Boolean = True
        Dim sParams As String
        sParams = EmailAddress
        If LCase(Strings.Left(sParams, 7)) <> "mailto:" Then _
            sParams = "mailto:" & sParams

        sParams &= "?bcc="

        For Each Sb As ScoutCheckBox In FlowLayoutPanel1.Controls
            If Sb.Checked Then
                Dim s As Person = Sb.Scout
                If BL.Singleton.PersonBL.GetParents(s).Count = 0 Then
                    MsgBox("Warning ... " & s.FullName & " has no parents defined")
                End If

                For Each p As Person In BL.Singleton.PersonBL.GetParents(s)
                    If p.Email <> "" Then
                        If InStr(sParams, p.Email) = 0 Then
                            sParams &= p.Email & ";"
                        End If
                    Else
                        MsgBox("Warning ... " & p.FullName & " has no email address defined")
                    End If
                Next

                If PersonsCheckBox.Checked Then
                    If InStr(sParams, s.Email) = 0 Then
                        sParams &= s.Email & ";"
                    End If
                End If
            End If
        Next

        If Subject <> "" Then sParams &= "&subject=" & Subject

        If Body <> "" Then
            'sParams = sParams & If(Subject = "", "?", "&")
            sParams = sParams & "&body=" & Body
        End If

        Try
            System.Diagnostics.Process.Start(sParams)
        Catch
            bAns = False
        End Try

        Return bAns

    End Function

    Private Class ScoutCheckBox
        Inherits CheckBox
        Public Property Scout As Person

        Public Sub New(s As Person)
            Text = s.FullName
            Width = 150
            _Scout = s
        End Sub
    End Class



End Class