Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CapaEntidad

Public Class listCheckBox
    Public Shared Function lisDep() As DataTable
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using proDep As New SqlCommand("listDep", cBuenaPro)
                proDep.CommandType = CommandType.StoredProcedure
                Using dataDepa As New SqlDataAdapter(proDep)
                    Using table As New DataTable
                        dataDepa.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
            cBuenaPro.Close()
        End Using
    End Function

    Public Shared Function lisProv(idDepa As Integer) As DataTable
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using proProv As New SqlCommand("listProv", cBuenaPro)
                proProv.CommandType = CommandType.StoredProcedure
                proProv.Parameters.AddWithValue("@idDepa", idDepa)

                Using daPro As New SqlDataAdapter(proProv)
                    Using table As New DataTable
                        daPro.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
            cBuenaPro.Close()
        End Using
    End Function

    Public Shared Function lisCatFinan(sistema As String) As DataTable
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using proListCatFin As New SqlCommand("lisCateFinan", cBuenaPro)
                proListCatFin.CommandType = CommandType.StoredProcedure
                proListCatFin.Parameters.AddWithValue("@sistema", sistema)

                Using daPro As New SqlDataAdapter(proListCatFin)
                    Using table As New DataTable
                        daPro.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
            cBuenaPro.Close()
        End Using
    End Function

    Public Shared Function listDist(idProv As Integer) As DataTable
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using proDis As New SqlCommand("listDistrito", cBuenaPro)
                proDis.CommandType = CommandType.StoredProcedure
                proDis.Parameters.AddWithValue("@idProv", idProv)

                Using daPro As New SqlDataAdapter(proDis)
                    Using table As New DataTable
                        daPro.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
            cBuenaPro.Close()
        End Using
    End Function

    Public Function listResolucion() As DataTable
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using listReso As New SqlCommand("listResolucion", cBuenaPro)
                listReso.CommandType = CommandType.StoredProcedure

                Using daRes As New SqlDataAdapter(listReso)
                    Using table As New DataTable
                        daRes.Fill(table)
                        Return table
                    End Using
                End Using
            End Using
            cBuenaPro.Close()
        End Using
    End Function
End Class


