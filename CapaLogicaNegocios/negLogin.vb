Imports CapaAccesoDatos
Imports CapaEntidad

Public Class negLogin
    Private datUser As New datUser
    Public Function Login(user As String, pass As String) As entUser
        Return datUser.ValidarUser(user, pass)
    End Function
End Class
