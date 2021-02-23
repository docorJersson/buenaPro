Imports System.Data.SqlClient

Public Class entidadPublica
    Public Shared Function obtenerUbigeo(idDepa As Integer, idProv As Integer, idDist As Integer) As String
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using ubigeo As New SqlCommand("select dbo.muestraUbigeo(" & idDepa & "," & idProv & "," & idDist & ")", cBuenaPro)
                Try
                    ubigeo.CommandType = CommandType.Text
                    Dim textUbigeo As String
                    textUbigeo = ubigeo.ExecuteScalar()
                    Return textUbigeo
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            End Using
            cBuenaPro.Close()
        End Using
    End Function
End Class
