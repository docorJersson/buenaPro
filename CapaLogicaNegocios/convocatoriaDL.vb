Imports CapaAccesoDatos
Imports CapaEntidad
Public Class convocatoriaDL
    Dim convoDA As New CapaAccesoDatos.convocatoria()
    Public Function bocetoCronograma() As DataTable
        Return convoDA.bocetoCronograma()
    End Function
    Public Function listConvocatorias() As DataTable
        Return convoDA.getConvocatorias()
    End Function
    Public Function insertConvo(newConvocatoria As convocatoriaPublicaDE, autogenerado As Boolean) As Integer
        Return convoDA.insertConvocatoria(newConvocatoria, autogenerado)
    End Function
End Class
