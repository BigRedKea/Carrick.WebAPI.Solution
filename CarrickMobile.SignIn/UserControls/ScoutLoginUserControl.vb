
Imports Carrick.BusinessLogic.CompositeObjects
Imports Carrick.BusinessLogic.Interfaces

Public Class PersonLoginUserControl

    Private _LogoutColour As Color = Color.LightGray
    Private _LoginColour As Color = Color.Green

    Public Property Person As PersonComposite

    Sub New(S As PersonComposite)
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

        If DateDiff(DateInterval.Day, _Person.LastSignedIn, Now) > 30 Then
            LoginButton.ForeColor = Color.Red
        End If

        If BL.Singleton.LeaderModeEnabled Then
            NameLabel.Text = Person.Person.FullName & " [" & Person.Age.ToString("YY:MM") & "]"

            If _Person.Person.Gender = "F" Then
                NameLabel.ForeColor = Color.DeepPink
            ElseIf _Person.Person.Gender = "M" Then
                NameLabel.ForeColor = Color.Blue
            Else
                NameLabel.ForeColor = Color.Black
            End If
        Else
            NameLabel.Text = Person.Person.FullName
            'HACK If Person.RankFK <= 2 Then NameLabel.Text = NameLabel.Text & " [Nights=" & Person.ScoutNights & "]"
            NameLabel.ForeColor = Color.Black
        End If


        LoginButton.BackColor = _LogoutColour

        SetLoginButton(BL.Singleton.PersonBL.IsSignedIn(Person.Person))
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        'Don't ask for sign out
        'Don't ask questions of leaders
        If Not BL.Singleton.PersonBL.IsSignedIn(Person.Person) AndAlso Not BL.Singleton.LeaderModeEnabled Then

            Dim frm2 As New UpcomingEventsForm
            frm2.LoadData(_Person.Person)
            frm2.ShowDialog(Me)
        End If

        BL.Singleton.PersonBL.SignedIn(Person.Person, Not BL.Singleton.PersonBL.IsSignedIn(Person.Person))
        SetLoginButton(BL.Singleton.PersonBL.IsSignedIn(Person.Person))
    End Sub

    Private Sub SetLoginButton(SignedIn As Boolean)
        If SignedIn Then
            LoginButton.BackColor = _LoginColour
        Else
            LoginButton.BackColor = _LogoutColour
        End If
    End Sub


    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim frm As New EditScoutForm(_Person.Person)
        frm.ShowDialog(Me)
    End Sub
End Class
