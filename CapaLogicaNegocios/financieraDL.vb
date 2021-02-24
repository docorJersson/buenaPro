Public Class financieraDL
    Dim finanDA As New CapaAccesoDatos.financierasDA
    Public Function listFinEntidad(ubigeo As String) As DataTable
        Return finanDA.listFinanEntidad(ubigeo)
    End Function
End Class
