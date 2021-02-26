Imports System.Data.SqlClient
Public Class convocatoria
    Public Function bocetoCronograma() As DataTable
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Dim fecha As Date = DateTime.Now.Date

            Using boceto As New SqlCommand("set datefirst 1;select p.procedimiento,f.fInicio,f.fFin from dbo.creacionFechaPrueba('" & fecha.ToString("yyyy-MM-dd") & "') as f inner join procedimiento p on p.idProcedimiento=f.idProce", cBuenaPro)
                Try
                    boceto.CommandType = CommandType.Text
                    Using adapList As New SqlDataAdapter(boceto)
                        Using table As New DataTable
                            adapList.Fill(table)
                            Return table
                        End Using
                    End Using
                Catch ex As Exception
                    Console.WriteLine("ACCESOua")

                    Console.WriteLine(ex)
                End Try
            End Using
            cBuenaPro.Close()
        End Using
    End Function

    Public Function getConvocatorias() As DataTable
        Using conection As New SqlConnection(My.Settings.ConexionBUENAPRO)
            conection.Open()
            Using listConvocatorias As New SqlCommand("sp_convocatoriaP", conection)
                Try
                    listConvocatorias.CommandType = CommandType.StoredProcedure
                    Using adapList As New SqlDataAdapter(listConvocatorias)
                        Using table As New DataTable
                            adapList.Fill(table)
                            Return table
                        End Using
                    End Using
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            End Using
            conection.Close()
        End Using
    End Function
End Class
