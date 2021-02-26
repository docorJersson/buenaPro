Imports CapaAccesoDatos
Public Class convocatoriaDL
    Dim convoDA As New CapaAccesoDatos.convocatoria()
    Public Function bocetoCronograma() As DataTable
        Return convoDA.bocetoCronograma()
    End Function
    Public Function listConvocatorias() As DataTable
        Return convoDA.getConvocatorias()
    End Function

End Class
