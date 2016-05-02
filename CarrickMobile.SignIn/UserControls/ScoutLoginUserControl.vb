
Imports Carrick.BusinessLogic.CompositeObjects
Imports Carrick.BusinessLogic.Interfaces

Public Class PersonLoginUserControl

    Private _LogoutColour As Color = Color.LightGray
    Private _LoginColour As Color = Color.Green

    Public Property Person As ScoutVM

    Sub New(S As ScoutVM)
        InitializeComponent()

        _Person = S
        'HACK AddHandler _Person.PropertyChangedEvent, Sub(x As Object, e As EventArgs)
        '                                             RefreshData()
        '                                         End Sub

        AddHandler BL.Singleton.LeaderModeEnabledEvent, Sub(x As Object, e As EventArgs)
                                                            RefreshData()
                                                        End Sub

        RefreshData()
    End Sub

    Public Sub RefreshData()

        'Birthday cake
        CakePicture.Visible = Person.IsBirthday()

        If Person.FlagAsAbsent Then
            LoginButton.ForeColor = Color.Red
        End If

        If BL.Singleton.LeaderModeEnabled Then
            NameLabel.Text = Person.FullName & " [" & Person.Age.ToString("YY:MM") & "]"

            If _Person.Gender = "F" Then
                NameLabel.ForeColor = Color.DeepPink
            ElseIf _Person.Gender = "M" Then
                NameLabel.ForeColor = Color.Blue
            Else
                NameLabel.ForeColor = Color.Black
            End If
        Else
            NameLabel.Text = Person.FullName
            'HACK If Person.RankFK <= 2 Then NameLabel.Text = NameLabel.Text & " [Nights=" & Person.ScoutNights & "]"
            NameLabel.ForeColor = Color.Black
        End If


        LoginButton.BackColor = _LogoutColour

        SetLoginButton(Person.SignedIn)
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        'Don't ask for sign out
        'Don't ask questions of leaders
        If Not Person.SignedIn AndAlso Not BL.Singleton.LeaderModeEnabled Then

            'Dim frm2 As New UpcomingEventsForm
            'frm2.LoadData(_Person)
            'frm2.ShowDialog(Me)
        End If

        Person.SignedIn = Not Person.SignedIn
        SetLoginButton(Person.SignedIn)
    End Sub

    Private Sub SetLoginButton(SignedIn As Boolean)
        If SignedIn Then
            LoginButton.BackColor = _LoginColour
        Else
            LoginButton.BackColor = _LogoutColour
        End If
    End Sub


    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim frm As New EditScoutForm(_Person)
        frm.ShowDialog(Me)
    End Sub
End Class
