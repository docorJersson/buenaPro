Imports CapaAccesoDatos
Imports CapaEntidad

Public Class negLogin
    Private datUser As New datUser
    Public Function Login(user As String, pass As String) As entUser
        Return datUser.ValidarUser(user, pass)
    End Function

    Public Function accionUser(user As String, rol As String) As String
        Return datUser.obtenerCodigo(user, rol)
    End Function
End Class
