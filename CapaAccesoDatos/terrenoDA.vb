Imports System.Data.SqlClient
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
End Class
