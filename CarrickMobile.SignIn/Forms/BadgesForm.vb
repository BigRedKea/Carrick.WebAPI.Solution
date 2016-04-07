

Imports Carrick.DataModel

Public Class BadgesForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Public Sub loaddata()
        FlowLayoutPanel1.Controls.Clear()
        ' Add any initialization after the InitializeComponent() call.
        For Each b As Badge In BL.Singleton.BadgeBL.GetAllItems
            Dim buc As New BadgeUserControl
            buc.LoadData(b)
            FlowLayoutPanel1.Controls.Add(buc)
        Next
    End Sub
End Class