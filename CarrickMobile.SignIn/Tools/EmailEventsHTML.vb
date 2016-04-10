Imports System.IO
Imports System.Web.UI
Imports System.Text
Imports Carrick.DataModel
Imports Carrick.BusinessLogic.Interfaces
Imports Carrick.BusinessLogic.CompositeObjects

Public Class EmailEventsHTML

    Public Sub Execute()
        For Each itm As PersonScoutingEventComposite In BL.Singleton.PersonScoutingEventBL.GetActiveCompositeItems
            Dim scoutsgoing As New List(Of Integer)
            'For Each sae As PersonScoutingEvent In BL.Singleton.PersonBL.GetPersonsAtEvent(itm)

            '    If Not (scoutsgoing.Contains(sae.PersonId)) Then
            '        scoutsgoing.Add(sae.PersonId)
            '    End If
            'Next

            If itm.ScoutingEvent.StartDateTime > Now() Then
                Dim evtname As String = itm.ScoutingEvent.EventName
                evtname = Replace(evtname, "\", "_")
                evtname = Replace(evtname, "/", "_")

                Dim filepath As String = My.Settings.ExportPath & "EmailScouts" & evtname & ".htm"
                Dim fileWrite As New IO.FileStream(filepath, IO.FileMode.Create)

                Using sw As StringWriter = New StringWriter
                    sw.WriteLine("<HTML>")
                    '   
                    sw.WriteLine("<HEAD>")
                    sw.WriteLine("<TITLE>Create Scout Emails for Scouts Who Have Registered interest in " & itm.ScoutingEvent.EventName & "</TITLE>")

                    sw.WriteLine("<SCRIPT>")

                    sw.WriteLine("function selectscout(form, filter,  select) {")
                    sw.WriteLine("    switch(filter)")
                    sw.WriteLine("        {")
                    sw.WriteLine("            case '':")
                    For Each org As OrganisationUnit In BL.Singleton.OrganisationUnitBL.GetAllItems
                        For Each sct As Person In BL.Singleton.PersonBL.GetPersonsInOrganisation(org)
                            sw.WriteLine("                form.Checkbox" & sct.Id & ".checked = select;")
                        Next
                    Next
                    sw.WriteLine("                break")

                    For Each org As OrganisationUnit In BL.Singleton.OrganisationUnitBL.GetAllItems
                        sw.WriteLine("            case '" & org.Description & "':")
                        For Each sct As Person In BL.Singleton.PersonBL.GetPersonsInOrganisation(org)
                            sw.WriteLine("                form.Checkbox" & sct.Id & ".checked = select;")
                        Next
                        sw.WriteLine("                break")
                    Next

                    sw.WriteLine("        }")
                    sw.WriteLine("    }")

                    sw.WriteLine("function valid(form) {")
                    sw.WriteLine("    var addresses ='' ;")
                    sw.WriteLine("    var Count = 0;")
                    sw.WriteLine("    var bodytext = '';")
                    sw.WriteLine("    var newline = '%0D%0A';")

                    For Each org As OrganisationUnit In BL.Singleton.OrganisationUnitBL.GetAllItems
                        For Each sct As Person In BL.Singleton.PersonBL.GetPersonsInOrganisation(org)
                            Dim email As String = ""
                            For Each p As Person In BL.Singleton.PersonBL.GetParents(sct)
                                email = email & Trim(p.Email) & ";"
                            Next

                            If email.Length > 0 Then
                                email = Left(email, email.Length - 1)
                                email = Replace(email, vbCr, "")
                                email = Replace(email, vbLf, "")

                                sw.WriteLine("    if (form.Checkbox" & sct.Id & ".checked && addresses.indexOf(""" & email & """)<=0) addresses = addresses + '" & email & "' + ';'")
                            End If
                        Next
                    Next

                    sw.WriteLine("    if (form.BccScoutsCheckBox.checked)")
                    sw.WriteLine("    {")
                    For Each org As OrganisationUnit In BL.Singleton.OrganisationUnitBL.GetAllItems
                        For Each sct As Person In BL.Singleton.PersonBL.GetPersonsInOrganisation(org)
                            Dim email As String = Trim(sct.Email)

                            If email.Length > 0 Then
                                sw.WriteLine("    if (form.Checkbox" & sct.Id & ".checked && addresses.indexOf(""" & email & """)<=0) addresses = addresses + '" & email & "' + ';'")
                            End If
                        Next
                    Next


                    sw.WriteLine("        bodytext = 'Dear Parents and Scouts' + newline + newline + form.bodydata.value")

                    sw.WriteLine("    }")
                    sw.WriteLine("            else")
                    sw.WriteLine("    {")
                    sw.WriteLine("            bodytext = ""Dear Parents of Scouts"" + newline + newline + form.bodydata.value")
                    sw.WriteLine("    }")
                    sw.WriteLine("            var linkstr = ""mailto:"" + ""wilstonscouttroop@gmail.com""")
                    sw.WriteLine("            if (addresses.length > 0)")
                    sw.WriteLine("    {")
                    sw.WriteLine("        linkstr = linkstr + '?bcc=' + addresses")
                    sw.WriteLine("    }")
                    sw.WriteLine("    window.open( linkstr + ' &subject=' + form.subjectdata.value + '&body=' + bodytext);")
                    sw.WriteLine(" }")
                    sw.WriteLine("</SCRIPT>")
                    sw.WriteLine("</HEAD>")

                    sw.WriteLine("<BODY>")
                    sw.WriteLine(" <H3> Email Scouts going to " & evtname & " </H3>")

                    sw.WriteLine(" <FORM>")
                    sw.WriteLine("     <table width=""200"" style=""border:1px solid black;width:200pt"">")

                    sw.WriteLine("         <tr >")
                    sw.WriteLine("             <td>Subject</td>")
                    sw.WriteLine("             <td><input type=""text"" name=""subjectdata"" value=""From Wilston Scouts"" style=""width:200pt""></td>")
                    sw.WriteLine("         </tr>")
                    sw.WriteLine("         <tr>")
                    sw.WriteLine("             <td>Body</td>")
                    sw.WriteLine("             <td><input type=""text"" name=""bodydata"" value=""Regards Wilston Scout Troop Leaders"" style=""width:200pt""></td>")
                    sw.WriteLine("         </tr>")
                    sw.WriteLine("     </table>")

                    sw.WriteLine("     <br />")
                    sw.WriteLine("     <br />")
                    sw.WriteLine("     Bcc Scouts in the email")
                    sw.WriteLine("     <input type=""checkbox"" name=""BccScoutsCheckBox"" /> ")
                    sw.WriteLine("     <br />")
                    sw.WriteLine("     <INPUT TYPE=""button"" VALUE=""Create Email"" onClick=""valid(this.form)"" style=""background-color:blue;font-size:22px;color:white"">")

                    sw.WriteLine("     <br />")
                    sw.WriteLine("     <br />")

                    sw.WriteLine("     <table width=""200"" style=""border:1px solid black;width:200pt"">")

                    sw.WriteLine("         <tr>")
                    sw.WriteLine("             <td>All Scouts</td>")
                    sw.WriteLine("             <td><input type=""button"" value=""Select All"" onclick=""selectscout(this.form,'',true)""></td>")
                    sw.WriteLine("             <td><input type=""button"" value=""Unselect All"" onclick=""selectscout(this.form, '', false)""></td>")
                    sw.WriteLine("         </tr>")

                    sw.WriteLine("     </table>")
                    sw.WriteLine("     <br />")

                    For Each ptl As OrganisationUnit In BL.Singleton.OrganisationUnitBL.GetAllItems
                        sw.WriteLine("     <h4> " & ptl.Description & " </h4>")
                        sw.WriteLine("     <input type=""button"" value=""Select"" onclick=""selectscout(this.form, '" & ptl.Description & "', true)"">")
                        sw.WriteLine("     <input type=""button"" value=""Unselect"" onclick=""selectscout(this.form, '" & ptl.Description & "', false)"">")
                        sw.WriteLine("     <table width=""200"" style=""border:1px solid black;width:200pt"">")
                        For Each sct As Person In BL.Singleton.PersonBL.GetPersonsInOrganisation(ptl)
                            sw.WriteLine("         <tr>")

                            Dim ckd As String = ""
                            If scoutsgoing.Contains(sct.Id) Then
                                ckd = "checked = ""checked"""
                            End If

                            sw.WriteLine("             <td><input type=""checkbox"" " & ckd & "name=""Checkbox" & sct.Id & """></td>")
                            sw.WriteLine("             <td>" & sct.FullName & "</td>")
                            sw.WriteLine("         </tr>")
                        Next
                        sw.WriteLine("     </table>")

                    Next ptl

                    sw.WriteLine("</FORM>")
                    sw.WriteLine("</BODY>")
                    sw.WriteLine("</HTML>")


                    Dim info As Byte() = New UTF8Encoding(True).GetBytes(sw.ToString)
                    fileWrite.Write(info, 0, info.Length)
                    fileWrite.Flush()
                    fileWrite.Close()
                    fileWrite.Dispose()
                End Using
            End If
        Next
    End Sub

End Class
