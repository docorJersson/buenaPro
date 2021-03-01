Imports CapaAccesoDatos
Public Class terrenoDL
    Dim terrenoDA As New terrenoDA()
    Public Function lisTerreno(idDepa As Integer, idProv As Integer, idDist As Integer) As DataTable
        Return terrenoDA.listTerrenoEntidad(idDepa, idProv, idDist)
    End Function
End Class
