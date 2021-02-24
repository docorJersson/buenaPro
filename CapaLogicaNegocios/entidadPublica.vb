Public Class entidadPublica
    Dim entidadPublicaDA As New CapaAccesoDatos.entidadPublica
    Public Sub insertEntidad(newEntidad As CapaEntidad.entidadPublica)
        entidadPublicaDA.insertEntidad(newEntidad)
    End Sub
End Class
