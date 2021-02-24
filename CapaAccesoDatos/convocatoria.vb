Imports System.Data.SqlClient
Public Class convocatoria
    Public Function bocetoCronograma() As DataTable
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Dim fecha As Date = DateTime.Now.Date
            Dim dateOnly As DateTime = fecha.Date

            'Console.WriteLine(dateOnly.ToString("d"))
            Using boceto As New SqlCommand("set datefirst 1;select p.procedimiento,f.fInicio,f.fFin from dbo.creacionFechaPrueba('" & dateOnly.ToString("d").ToString & "') as f inner join procedimiento p on p.idProcedimiento=f.idProce", cBuenaPro)
                Try
                    boceto.CommandType = CommandType.Text
                    Using adapList As New SqlDataAdapter(boceto)
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
