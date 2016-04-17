Imports System.IO
Imports System.Web.UI
Imports System.Text
Imports Carrick.BusinessLogic.Interfaces

Public Class ExportPersonToHTML


    Public Function Execute(Person As IPerson) As String

        Dim filepath As String = Nothing
        Try

            Dim Personname As String = Person.PreferredName & " " & Person.Surname
            filepath = My.Settings.ExportPath & "PersonRecords\" & Personname & ".htm"
            Dim fileWrite As New IO.FileStream(filepath, IO.FileMode.Create)

            Using sw As StringWriter = New StringWriter
                Using ht As New HtmlTextWriter(sw)
                    With ht
                        ' Create the div.
                        .AddAttribute(HtmlTextWriterAttribute.Class, "c")
                        .RenderBeginTag(HtmlTextWriterTag.Div)

                        ' Person Name
                        .RenderBeginTag(HtmlTextWriterTag.H1)
                        .Write(Person.FullName)
                        .RenderEndTag()

                        ' Person Name
                        .AddAttribute(HtmlTextWriterAttribute.Border, "1")
                        .AddStyleAttribute(HtmlTextWriterStyle.BorderStyle, "dotted")
                        .RenderBeginTag(HtmlTextWriterTag.Table)
                        WriteTableRow(ht, New String() {"ID", Person.Id.ToString})
                        'HACK WriteTableRow(ht, New String() {"Patrol", Person.Patrol.Name.ToString})
                        WriteTableRow(ht, New String() {"Member", Person.MembershipId})

                        If Person.DateOfInvestiture.HasValue Then
                            WriteTableRow(ht, New String() {"Date Of Investiture", Person.DateOfInvestiture.Value.ToString("dd/MMM/yyyy")})
                        Else
                            WriteTableRow(ht, New String() {"Date Of Investiture", ""})
                        End If

                        WriteTableRow(ht, New String() {"Medicare", Person.MedicareNumber})

                        WriteTableRow(ht, New String() {"Email (with parent permission)", Person.Email})

                        WriteTableRow(ht, New String() {"Mobile (for senior Persons with parent permission)", Person.Mobile})

                        If Person.DateOfBirth.HasValue Then
                            WriteTableRow(ht, New String() {"Date Of Birth", Person.DateOfBirth.Value.ToString("dd/MMM/yyyy")})
                            Dim age As Double = (DateDiff(DateInterval.Month, Person.DateOfBirth.Value, Now()) / 12)
                            WriteTableRow(ht, New String() {"Age", Fix(age).ToString & " Years " & Fix((age - Fix(age)) * 12) & " Months"})
                        Else
                            WriteTableRow(ht, New String() {"Date Of Birth", ""})
                        End If

                        If Person.LastTetanus.HasValue Then
                            WriteTableRow(ht, New String() {"Last Tetanus", Person.LastTetanus.Value.ToString("dd/MMM/yyyy")})
                        Else
                            WriteTableRow(ht, New String() {"Last Tetanus", ""})
                        End If

                        WriteTableRow(ht, New String() {"Other Relevant Medical Information (e.g. Allergies)", ""})

                        WriteTableRow(ht, New String() {"Family Code", Person.FamilyCode})
                        'WriteTableRow(ht, New String() {"Invoice", Person.Invoice.ToString})

                        ' WriteTableRow(ht, New String() {"Comments For Treasurer", Person.CommentsForTreasurer.ToString})
                        'WriteTableRow(ht, New String() {"Comments For Membership", Person.CommentsForMembership.ToString})

                        If Person.DateLeftOrganisation.HasValue Then
                            WriteTableRow(ht, New String() {"Date Left", Person.DateLeftOrganisation.ToString})
                        End If


                        .RenderEndTag() ' Table
                        .RenderEndTag() 'Div


                        For Each p As IPerson In BL.Singleton.PersonBL.GetParents(Person)

                            .RenderBeginTag(HtmlTextWriterTag.Div)

                            .RenderBeginTag(HtmlTextWriterTag.H2)
                            .Write(p.FullName)
                            .RenderEndTag()

                            .AddAttribute(HtmlTextWriterAttribute.Border, "1")
                            .AddStyleAttribute(HtmlTextWriterStyle.BorderStyle, "dotted")
                            .RenderBeginTag(HtmlTextWriterTag.Table)
                            WriteTableRow(ht, New String() {"Member", p.MembershipId})
                            WriteTableRow(ht, New String() {"Email", p.Email})
                            WriteTableRow(ht, New String() {"Mobile", p.Mobile})
                            WriteTableRow(ht, New String() {"Family Code", p.FamilyCode})
                            'If Not publishprivateInformation Then
                            For Each r As IResidence In BL.Singleton.ResidenceBL.GetResidences(Person)
                                WriteTableRow(ht, New String() {"Phone", r.ResidencePhone})
                                WriteTableRow(ht, New String() {"Residence Line 1", r.ResidenceAddressLine1})
                                WriteTableRow(ht, New String() {"Residence Line 2", r.ResidenceAddressLine2})
                                WriteTableRow(ht, New String() {"Area", r.Area})
                                WriteTableRow(ht, New String() {"PostCode", r.PostCode})
                            Next
                            'End If

                            'End Table
                            .RenderEndTag()
                            'End Div
                            .RenderEndTag()
                        Next

                        Dim badges As Dictionary(Of Integer, IPersonBadge) = BL.Singleton.PersonBadgeBL.GetBadgeRequestsforPerson(Person)
                        .RenderBeginTag(HtmlTextWriterTag.Div)

                        .RenderBeginTag(HtmlTextWriterTag.H2)
                        .Write("Badge Records")
                        .RenderEndTag()

                        .AddAttribute(HtmlTextWriterAttribute.Border, "1")
                        .AddStyleAttribute(HtmlTextWriterStyle.BorderStyle, "dotted")
                        .RenderBeginTag(HtmlTextWriterTag.Table)

                        .AddStyleAttribute(HtmlTextWriterStyle.FontWeight, "bold")
                        .AddStyleAttribute(HtmlTextWriterStyle.FontFamily, "verdana")
                        .AddStyleAttribute(HtmlTextWriterStyle.FontSize, "12pt")
                        .RenderBeginTag(HtmlTextWriterTag.Tr)

                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("ID")
                        .RenderEndTag()

                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("Badge")
                        .RenderEndTag()

                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("Presented")
                        .RenderEndTag()

                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("Leader Assigned")
                        .RenderEndTag()

                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("Leader Authorised")
                        .RenderEndTag()
                        .RenderEndTag()

                        For Each itm As IPersonBadge In badges.Values
                            Dim s As New List(Of String)
                            s.Add(itm.Id.ToString)
                            s.Add(BL.Singleton.BadgeBL.GetItem(itm).BadgeName)
                            If itm.PresentedTimeStamp.HasValue Then
                                s.Add(itm.PresentedTimeStamp.Value.ToString("dd/MMM/yyyy"))
                            Else
                                s.Add("Not Presented")
                            End If

                            If itm.LeaderAssignedId IsNot Nothing Then
                                s.Add(itm.LeaderAssignedId)
                            Else
                                s.Add("No Leader Assigned")
                            End If

                            If itm.AuthorisedById IsNot Nothing Then
                                s.Add(itm.AuthorisedById)
                            Else
                                s.Add("No Leader Approved")
                            End If

                            WriteTableRow(ht, s.ToArray)

                        Next

                        'End Table
                        .RenderEndTag()
                        'End Div
                        .RenderEndTag()

                        Dim GetPersonScoutingEvents As IEnumerable(Of IPersonScoutingEvent) = BL.Singleton.ScoutingEventBL.GetAllItems


                        .RenderBeginTag(HtmlTextWriterTag.Div)

                        .RenderBeginTag(HtmlTextWriterTag.H2)
                        .Write("Events")
                        .RenderEndTag()

                        .AddAttribute(HtmlTextWriterAttribute.Border, "1")
                        .AddStyleAttribute(HtmlTextWriterStyle.BorderStyle, "dotted")
                        .RenderBeginTag(HtmlTextWriterTag.Table)

                        .AddStyleAttribute(HtmlTextWriterStyle.FontWeight, "bold")
                        .AddStyleAttribute(HtmlTextWriterStyle.FontFamily, "verdana")
                        .AddStyleAttribute(HtmlTextWriterStyle.FontSize, "12pt")
                        .RenderBeginTag(HtmlTextWriterTag.Tr)
                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("ID")
                        .RenderEndTag()

                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("Event")
                        .RenderEndTag()

                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("Start")
                        .RenderEndTag()

                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("Finish")
                        .RenderEndTag()

                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("Nights")
                        .RenderEndTag()

                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("Nights Under Canvas")
                        .RenderEndTag()

                        .RenderBeginTag(HtmlTextWriterTag.Th)
                        .Write("Kilometers Travelled")
                        .RenderEndTag()

                        .RenderEndTag()

                        Dim totalnights As Integer = 0

                        Dim totalKilometersTravelled As Integer = 0

                        For Each itm In BL.Singleton.PersonScoutingEventBL.GetItemsForPerson(Person)
                            Dim e As IScoutingEvent = itm.ScoutingEvent
                            Dim s As New List(Of String)


                            s.Add(itm.PersonScoutingEvent.Id.ToString)

                            s.Add(e.EventName)
                            If e.StartDateTime.HasValue Then
                                s.Add(e.StartDateTime.Value.ToString("d/MMM/yyyy"))
                            Else
                                s.Add("-")
                            End If


                            If e.FinishDateTime.HasValue Then
                                s.Add(e.FinishDateTime.Value.ToString("d/MMM/yyyy"))
                            Else
                                s.Add("-")
                            End If

                            If e.StartDateTime.HasValue And e.FinishDateTime.HasValue Then
                                s.Add((e.FinishDateTime.Value.DayOfYear - e.StartDateTime.Value.DayOfYear).ToString())
                            Else
                                s.Add("-")
                            End If

                            If itm.PersonScoutingEvent.NightsUnderCanvas.HasValue Then
                                s.Add(itm.PersonScoutingEvent.NightsUnderCanvas.ToString)
                                totalnights = totalnights + itm.PersonScoutingEvent.NightsUnderCanvas.Value
                            Else
                                s.Add("-")
                            End If

                            If itm.PersonScoutingEvent.KilometersTravelled.HasValue Then
                                s.Add(itm.PersonScoutingEvent.KilometersTravelled.ToString)
                                totalKilometersTravelled = totalKilometersTravelled + itm.PersonScoutingEvent.KilometersTravelled.Value
                            Else
                                s.Add("-")
                            End If

                            WriteTableRow(ht, s.ToArray)

                        Next

                        'End Table
                        .RenderEndTag()

                        'Total nights
                        .RenderBeginTag(HtmlTextWriterTag.H4)
                        .Write("Total of " & totalnights.ToString & " Nights Under Canvas with other Persons.")
                        .RenderEndTag()

                        'Total kilometers Travelled
                        .RenderBeginTag(HtmlTextWriterTag.H4)
                        .Write("Total of " & totalKilometersTravelled.ToString & " (nominal) Kilometers Travelled.")
                        .RenderEndTag()

                        'End Div
                        .RenderEndTag()

                    End With
                End Using

                Dim info As Byte() = New UTF8Encoding(True).GetBytes(sw.ToString)
                fileWrite.Write(info, 0, info.Length)
                fileWrite.Flush()
                fileWrite.Close()
                fileWrite.Dispose()
            End Using


        Catch ex As Exception
            Throw
        End Try

        Return filepath
    End Function

    Public Sub WriteTableRow(ht As HtmlTextWriter, sdata() As String)
        With ht
            .RenderBeginTag(HtmlTextWriterTag.Tr)
            For Each s As String In sdata
                .RenderBeginTag(HtmlTextWriterTag.Td)
                .Write(s)
                .RenderEndTag()
            Next
            .RenderEndTag() ' Tr
            .WriteLine()
        End With
    End Sub


End Class
