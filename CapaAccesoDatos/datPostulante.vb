Imports System.Data.SqlClient

Public Class datPostulante
    Public Shared Sub insertPostulante(iPostulante As String, cConvocatoria As Integer, rucProveedor As String, fPresentacion As Date, observacion As String, justificacion As String, documentoOferta As String)
        Using conection As New SqlConnection(My.Settings.ConexionBUENAPRO)
            conection.Open()
            Using insertPost As New SqlCommand("sp_insertPostulante", conection)
                Try
                    insertPost.CommandType = CommandType.StoredProcedure
                    insertPost.Parameters.AddWithValue("@iPostulante", iPostulante)
                    insertPost.Parameters.AddWithValue("@cConvocatoria", cConvocatoria)
                    insertPost.Parameters.AddWithValue("@rucProveedor", rucProveedor)
                    insertPost.Parameters.AddWithValue("@fPresentacion", fPresentacion)
                    insertPost.Parameters.AddWithValue("@observacion", observacion)
                    insertPost.Parameters.AddWithValue("@justificacion", justificacion)
                    insertPost.Parameters.AddWithValue("@documentoOferta", documentoOferta)
                    insertPost.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            End Using
            conection.Close()
        End Using
    End Sub
End Class
