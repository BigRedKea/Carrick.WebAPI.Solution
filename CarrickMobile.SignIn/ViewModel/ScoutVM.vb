Imports Carrick.BusinessLogic.CompositeObjects
Imports Carrick.BusinessLogic.Interfaces

Public Class ScoutVM
    Private _Scout As PersonComposite

    Public ReadOnly Property OrganisationUnits As IEnumerable(Of IOrganisationUnit)
        Get
            Return _Scout.OrganisationUnits
        End Get
    End Property

    Public ReadOnly Property CurrentMember As Boolean
        Get
            Return Not _Scout.Person.DateLeftOrganisation.HasValue
        End Get
    End Property


    Public Sub New(s As PersonComposite)
        _Scout = s
    End Sub

    Friend ReadOnly Property IsBirthday As Boolean
        Get
            Return _Scout.IsBirthday
        End Get
    End Property

    Public ReadOnly Property Age As TimeSpan
        Get
            Return _Scout.Age
        End Get
    End Property

    Public ReadOnly Property LastSignedIn As Date
        Get
            'HACK
            Return Now()
        End Get
    End Property

    Public ReadOnly Property FullName As String
        Get
            Return _Scout.Person.FullName
        End Get
    End Property

    Public Property Gender As String
        Get
            Return _Scout.Person.Gender
        End Get
        Set(value As String)
            _Scout.Person.Gender = value
        End Set
    End Property

    Private _SignedIn As Boolean
    Public Property SignedIn As Boolean
        Get
            Return _SignedIn
        End Get
        Set(value As Boolean)
            _SignedIn = value
        End Set
    End Property

    Public ReadOnly Property FlagAsAbsent As Boolean
        Get
            Return DateDiff(DateInterval.Day, _Scout.LastSignedIn, Now) > 30
        End Get
    End Property

End Class
