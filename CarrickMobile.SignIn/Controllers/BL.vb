
Imports Carrick.BusinessLogic
Imports Carrick.BusinessLogic.Interfaces
Imports Carrick.ClientData.DataProviders

Imports System

Public Class BL : Inherits BusinessLogic

    Private mc As ModelDataProvider
    Public Event LeaderModeEnabledEvent(x As Object, e As EventArgs)

    Public Sub New(baseurl As String, username As String, password As String)
        MyBase.New()
        mc = New ModelDataProvider(baseurl, username, password)
        MyBase.DataProviders = mc

    End Sub

    Public Sub New()
        MyClass.New("https://localhost:44300", "chris@noonanfamily.org", "Test123!")
        Execute()
    End Sub

    Friend Shared Property Singleton As New BL

    Friend Property LeaderModeEnabled As Boolean = False

    Public Sub Execute()
        mc.CreateModel(New SQLite.Net.Platform.Generic.SQLitePlatformGeneric())
        mc.LoadLocalData()

        mc.Sync()

    End Sub
End Class
