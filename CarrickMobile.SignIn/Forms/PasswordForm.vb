Public Class PasswordForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public ReadOnly Property Password As String
        Get
            Return TextBox1.Text
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PasswordForm_Load(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Focus()
        TextBox1.Focus()
    End Sub

End Class