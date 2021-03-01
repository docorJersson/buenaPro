Imports CapaAccesoDatos
Imports CapaEntidad
Public Class terrenoDL
    Dim terrenoDA As New terrenoDA()
    Public Function lisTerreno(idDepa As Integer, idProv As Integer, idDist As Integer) As DataTable
        Return terrenoDA.listTerrenoEntidad(idDepa, idProv, idDist)
    End Function
    Public Sub inserTerreno(newTerreno As terrenoDE)
        terrenoDA.insertTerreno(newTerreno)
    End Sub
End Class
