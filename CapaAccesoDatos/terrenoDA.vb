Imports System.Data.SqlClient
Imports CapaEntidad
Public Class terrenoDA
    Public Function listTerrenoEntidad(idDepa As Integer, idProv As Integer, idDist As Integer) As DataTable
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using terreno As New SqlCommand("listTerreno", cBuenaPro)
                Try
                    terreno.CommandType = CommandType.StoredProcedure
                    terreno.Parameters.AddWithValue("@idDepa", idDepa)
                    terreno.Parameters.AddWithValue("@idProv", idProv)
                    terreno.Parameters.AddWithValue("@idDist", idDist)
                    Using adapter As New SqlDataAdapter(terreno)
                        Dim table As New DataTable
                        adapter.Fill(table)
                        Return table
                    End Using

                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            End Using
            cBuenaPro.Close()
        End Using
    End Function

    Public Sub insertTerreno(newTerreno As terrenoDE)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using terreno As New SqlCommand("sp_InsertTerreno", cBuenaPro)
                Try
                    terreno.CommandType = CommandType.StoredProcedure
                    terreno.Parameters.AddWithValue("@codeTerreno", newTerreno.codTerreno)
                    terreno.Parameters.AddWithValue("@descripcion", newTerreno.descripcionTerreno)
                    terreno.Parameters.AddWithValue("@direccion", newTerreno.direccionTerreno)
                    terreno.Parameters.AddWithValue("@metroLargo", newTerreno.metroLargo)
                    terreno.Parameters.AddWithValue("@metroAncho", newTerreno.metroAncho)
                    terreno.Parameters.AddWithValue("@fRegistro", newTerreno.fechaRegistro)
                    terreno.Parameters.AddWithValue("@idDepa", newTerreno.departamento)
                    terreno.Parameters.AddWithValue("@idProv", newTerreno.provincia)
                    terreno.Parameters.AddWithValue("@idDist", newTerreno.distrito)

                    terreno.ExecuteNonQuery()
                Catch ex As Exception
                    Debug.WriteLine(ex)
                End Try
            End Using
            cBuenaPro.Close()
        End Using
    End Sub
End Class
