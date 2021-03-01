Imports CapaAccesoDatos
Imports CapaEntidad
Public Class expedienTecnicoDL
    Dim expeTec As New expedienTecnicoDA()
    Public Sub insertExpe(newExpe As expedienteTecnicoDE)
        expeTec.insertExpediente(newExpe)
    End Sub
    Public Sub insertAprobacion(newExpe As expedienteTecnicoDE)
        expeTec.insertAprobacion(newExpe)
    End Sub
End Class
