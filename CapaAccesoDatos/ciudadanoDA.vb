Imports System.Data.SqlClient
Public Class ciudadanoDA
    Public Shared Sub insertCiudadano(tipoDoc As String, numDoc As String, apePaterno As String, apeMaterno As String, nombre As String, sexo As String, telefono As String, email As String)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using insertCiud As New SqlCommand("insertCiudadano", cBuenaPro)
                Try
                    insertCiud.CommandType = CommandType.StoredProcedure
                    insertCiud.Parameters.AddWithValue("@tipDoc", tipoDoc)
                    insertCiud.Parameters.AddWithValue("@nDoc", numDoc)
                    insertCiud.Parameters.AddWithValue("@aPaterno", apePaterno)
                    insertCiud.Parameters.AddWithValue("@aMaterno", apeMaterno)
                    insertCiud.Parameters.AddWithValue("@nombre", nombre)
                    insertCiud.Parameters.AddWithValue("@sexo", sexo)
                    insertCiud.Parameters.AddWithValue("@telefono", telefono)
                    insertCiud.Parameters.AddWithValue("@email", email)

                    insertCiud.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            End Using
            cBuenaPro.Close()
        End Using
    End Sub
    Public Shared Function listCiudadano() As DataTable
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using listCiud As New SqlCommand("listCiudadano", cBuenaPro)
                Try
                    listCiud.CommandType = CommandType.StoredProcedure
                    Using adapList As New SqlDataAdapter(listCiud)
                        Using table As New DataTable
                            adapList.Fill(table)
                            Return table
                        End Using
                    End Using
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            End Using
            cBuenaPro.Close()
        End Using
    End Function
End Class
