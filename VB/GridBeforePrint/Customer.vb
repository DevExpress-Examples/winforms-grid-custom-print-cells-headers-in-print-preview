Namespace GridBeforePrint

    Friend Class Customer

        Private firstNameField As String

        Private lastNameField As String

        Private idField As Integer

        Public Property Id As Integer
            Get
                Return idField
            End Get

            Set(ByVal value As Integer)
                idField = value
            End Set
        End Property

        Public Property LastName As String
            Get
                Return lastNameField
            End Get

            Set(ByVal value As String)
                lastNameField = value
            End Set
        End Property

        Public Property FirstName As String
            Get
                Return firstNameField
            End Get

            Set(ByVal value As String)
                firstNameField = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal id As Integer)
            Me.FirstName = firstName
            Me.LastName = lastName
            Me.Id = id
        End Sub
    End Class
End Namespace
