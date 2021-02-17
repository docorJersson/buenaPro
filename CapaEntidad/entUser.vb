Public Class entUser
    Private idUser As Integer
    Private nameUser As String
    Private rol As String
    Public Property _rol As String
        Get
            Return rol
        End Get
        Set(ByVal value As String)
            rol = value
        End Set
    End Property
    Public Property _nameUser As String

        Get
            Return nameUser
        End Get
        Set(ByVal value As String
)
            nameUser = value
        End Set
    End Property
    Public Property _idUser As Integer
        Get
            Return idUser
        End Get
        Set(ByVal value As Integer)
            idUser = value
        End Set
    End Property
End Class
