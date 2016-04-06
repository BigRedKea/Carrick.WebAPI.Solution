Imports System.Text

Public Class ExportVCF
    Public Property nameFirst As String = ""
    Public Property nameLast As String = ""
    Public Property nameMiddle As String = ""
    Public Property Title As String = ""
    Public Property email As String = ""
    Public Property uRL As String = ""
    Public Property telephone As String = ""
    Public Property fax As String = ""
    Public Property mobile As String = ""
    Public Property company As String = ""
    Public Property department As String = ""
    Public Property mtitle As String = ""
    Public Property profession As String = ""
    Public Property office As String = ""
    Public Property addressline1 As String = ""
    Public Property addressline2 As String = ""
    Public Property city As String = ""
    Public Property region As String = ""
    Public Property postCode As String = ""
    Public Property counTry As String = ""

    Public Property Note As String = ""


    Public Sub CreateVCard(exporttofile As String)

        Dim stringWrite As System.IO.StringWriter = New System.IO.StringWriter()

        Dim fileWrite As New IO.FileStream(exporttofile, IO.FileMode.Create)

        stringWrite.WriteLine("BEGIN:VCARD")

        stringWrite.WriteLine("VERSION:2.1")

        stringWrite.WriteLine("N:" + nameLast + ";" + nameFirst + ";" + nameMiddle + ";" + Title)

        stringWrite.WriteLine("FN:" + nameFirst + " " + nameMiddle + " " + nameLast)

        stringWrite.WriteLine("ORG:" + company + ";" + department)

        stringWrite.WriteLine("URL;HOME:" + uRL)

        stringWrite.WriteLine("TITLE:" + Title)

        stringWrite.WriteLine("ROLE:" + profession)

        stringWrite.WriteLine("TEL;HOME;VOICE:" + telephone)

        stringWrite.WriteLine("TEL;HOME;FAX:" + fax)

        stringWrite.WriteLine("TEL;CELL;VOICE:" + mobile)

        stringWrite.WriteLine("EMAIL;PREF;INTERNET:" + email)

        stringWrite.WriteLine("ADR;HOME;ENCODING=QUOTED-PRINTABLE:" + ";" + addressline1 + ";" + addressline2 + ";" + _
        city + ";" + region + ";" + postCode + ";" + _
        counTry)

        stringWrite.WriteLine("NOTE:" + Note)

        stringWrite.WriteLine("END:VCARD")


        Dim info As Byte() = New UTF8Encoding(True).GetBytes(stringWrite.ToString)
        fileWrite.Write(info, 0, info.Length)
        fileWrite.Flush()
        fileWrite.Close()
        fileWrite.Dispose()
    End Sub

    Shared Function NewLine() As String
        Return ";"
    End Function

End Class
