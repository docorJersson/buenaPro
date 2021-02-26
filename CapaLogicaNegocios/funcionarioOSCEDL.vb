Imports CapaAccesoDatos
Imports CapaEntidad
Public Class funcionarioOSCEDL
    Dim funcOSDA As New funcionarioOsceDA()
    Public Function buscarCodigo(codigo As String) As funcionarioOSCEDE
        Return funcOSDA.buscarFun(codigo)
    End Function

End Class
