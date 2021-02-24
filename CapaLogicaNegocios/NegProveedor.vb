Imports System.Data.SqlClient
Imports CapaAccesoDatos
Imports CapaEntidad

Public Class NegProveedor
    Private _proveedor As New datProveedor
    Dim objtProveedor As New datProveedor
    Public Function Proveedores() As List(Of Proveedor)
        Dim _proveedores As List(Of Proveedor)
        _proveedores = _proveedor.getProveedor()
        Return _proveedores
    End Function
End Class

