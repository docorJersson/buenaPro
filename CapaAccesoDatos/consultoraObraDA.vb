Imports System.Data.SqlClient

Public Class consultoraObraDA
    Public Function listFunction() As DataTable
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using consultora As New SqlCommand("select * from  listConsultoraObra", cBuenaPro)
                Try
                    consultora.CommandType = CommandType.Text
                    Using adapter As New SqlDataAdapter(consultora)
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
