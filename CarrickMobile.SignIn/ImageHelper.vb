Public Class ImageHelper

    Public Function Convert(mybytearray As Byte()) As Image
        Dim myimage As Image
        Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(mybytearray)
        myimage = System.Drawing.Image.FromStream(ms)
        ms.Close()
        ms.Dispose()

        Return myimage
    End Function

End Class
