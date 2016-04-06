Imports Microsoft.Office.Interop.Outlook

Public Class SendMailClass
    Property recipient As String
    Property subject As String
    Property body As String
    Property files As New List(Of String)

    Public Sub Execute()
        Dim appd As New Microsoft.Office.Interop.Outlook.Application
        Dim message As MailItem = CType(appd.CreateItem(OlItemType.olMailItem), MailItem)

        Dim recip As Recipient = CType(message.Recipients.Add(recipient), Recipient)
        recip.Resolve()

        With message
            .Body = body
            .Subject = subject
            For Each f As String In files
                .Attachments.Add(f, OlAttachmentType.olByValue, message.Body.Length + 1, "an attachment")
            Next
            .Save()
            .Display(False)
            'message.Send();
        End With

    End Sub
End Class
