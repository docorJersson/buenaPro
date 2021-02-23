Imports CapaEntidad
Imports System.Data.SqlClient
Public Class financierasDA
    Public Shared Sub insertarFinancieras(idCategoria As Integer, codFinanciera As String, nombre As String, abreviatura As String, telefono As String, direccion As String, idDepa As Integer, idProv As Integer)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using insertFinan As New SqlCommand("insFinanciera", cBuenaPro)
                Try
                    insertFinan.CommandType = CommandType.StoredProcedure
                    insertFinan.Parameters.AddWithValue("@idCategoria", idCategoria)
                    insertFinan.Parameters.AddWithValue("@codFinanciera", codFinanciera)
                    insertFinan.Parameters.AddWithValue("@nombre", nombre)
                    insertFinan.Parameters.AddWithValue("@abreviatura", abreviatura)
                    insertFinan.Parameters.AddWithValue("@telefono", telefono)
                    insertFinan.Parameters.AddWithValue("@direccion", direccion)
                    insertFinan.Parameters.AddWithValue("@idDepa", idDepa)
                    insertFinan.Parameters.AddWithValue("@idProv", idProv)

                    insertFinan.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            End Using
            cBuenaPro.Close()
        End Using
    End Sub
End Class
