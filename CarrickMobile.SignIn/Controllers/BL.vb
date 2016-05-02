
Imports Carrick.BusinessLogic
Imports Carrick.BusinessLogic.Interfaces
Imports Carrick.ClientData.DataProviders

Imports System

Public Class BL : Inherits BusinessLogic

    Private mc As ModelDataProvider
    Public Event LeaderModeEnabledEvent(x As Object, e As EventArgs)

    Public Sub New(baseurl As String, username As String, password As String)
        MyBase.New()
        mc = New ModelDataProvider(New SQLite.Net.Platform.Generic.SQLitePlatformGeneric(), baseurl, username, password)
        MyBase.DataProviders = mc

    End Sub

    Private _Scouts As ScoutsVM

    Public ReadOnly Property Scouts As ScoutsVM
        Get
            If _Scouts Is Nothing Then
                _Scouts = New ScoutsVM
                Dim q As IEnumerable = BL.Singleton.PersonBL.GetActiveScouts()

                For Each scout In BL.Singleton.PersonBL.GetCompositeItems(q)
                    Dim s As New ScoutVM(scout)
                    _Scouts.Add(s)
                Next

            End If
            Return _Scouts
        End Get
    End Property

    Public Sub New()
        MyClass.New("https://localhost:44300", "chris@noonanfamily.org", "Test123!")
        Execute()
    End Sub

    Friend Shared Property Singleton As New BL

    Friend Property LeaderModeEnabled As Boolean = False

    Public Sub Execute()
        mc.CreateModel()
        mc.LoadLocalData()
        mc.Sync()
    End Sub
End Class
