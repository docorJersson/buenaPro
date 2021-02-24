Imports CapaAccesoDatos
Imports CapaEntidad
Public Class ciudadanoDL
    Public Function listCiudadano() As DataTable
        Return ciudadanoDA.listCiudadano
    End Function
End Class
