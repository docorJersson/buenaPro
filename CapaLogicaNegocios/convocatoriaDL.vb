Imports CapaAccesoDatos
Public Class convocatoriaDL
    Dim convoDA As New CapaAccesoDatos.convocatoria()
    Public Function bocetoCronograma() As DataTable
        Return convoDA.bocetoCronograma()
    End Function
End Class
