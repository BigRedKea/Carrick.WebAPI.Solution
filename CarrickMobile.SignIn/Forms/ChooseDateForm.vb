Public Class ChooseDateForm

    Property timestamp As Date
        Get
            Return DateTimePicker1.Value
        End Get
        Set(value As Date)
            DateTimePicker1.Value = value
        End Set
    End Property

End Class