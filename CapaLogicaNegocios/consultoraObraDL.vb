Imports CapaAccesoDatos
Public Class consultoraObraDL
    Dim consultoraDA As New consultoraObraDA()
    Public Function listConsultora() As DataTable
        Return consultoraDA.listFunction()
    End Function
End Class
