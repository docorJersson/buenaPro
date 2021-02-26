Imports System.Data.SqlClient
Imports CapaEntidad

Public Class datProveedor
    Public Function getProveedor() As List(Of Proveedor)
        Dim connection = datConexion.Instance.GetConexion()
        Dim command As New SqlCommand
        Dim reader As SqlDataReader
        Dim _proveedores As New List(Of Proveedor)
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "select*from VW_listProveedor"
            reader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read
                    Dim _proveedor As New Proveedor
                    Dim contribuyent As New Contribuyente
                    _proveedor._rucProveedor = reader.Item("rucProveedor")
                    _proveedor._proveedor = reader.Item("proveedor")
                    _proveedor._consorcio = reader.Item("consorcio")
                    _proveedor._telefono = reader.Item("telefono")
                    _proveedor._cCEASE = reader.Item("cCEASE")
                    _proveedor._RNP = reader.Item("RNP")
                    _proveedor._estadoProveedor = reader.Item("estadoProveedor")
                    _proveedor._condicion = reader.Item("condicion")
                    contribuyent._contribuyente = reader.Item("contribuyente")
                    contribuyent._maxImpuesto = reader.Item("maxImpuesto")
                    contribuyent._minImpuesto = reader.Item("minImpuesto")
                    _proveedor._contribuyente = contribuyent
                    _proveedores.Add(_proveedor)
                End While
            End If
            reader.Close()
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            connection.Close()
        End Try
        Return _proveedores
    End Function

End Class
