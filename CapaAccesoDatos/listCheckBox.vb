Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.DataRowView
Imports System.Windows.Forms
Imports CapaEntidad

Public Class listCheckBox
    Public Shared Function lisDep(ByVal comboDep As ComboBox)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Dim proDep As New SqlCommand
            proDep.Connection = cBuenaPro
            proDep.CommandText = "listDep"
            proDep.CommandType = CommandType.StoredProcedure
            Dim lector As SqlDataReader

            lector = proDep.ExecuteReader
            While (lector.Read())
                comboDep.Items.Add(lector.GetValue(1))
            End While
            cBuenaPro.Close()
        End Using
    End Function

    Public Shared Function lisProv(ByVal comboProv As ComboBox, departamento As String)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using proProv As New SqlCommand("listProv", cBuenaPro)
                proProv.CommandType = CommandType.StoredProcedure
                proProv.Parameters.Add("@departamento", SqlDbType.VarChar, 50).Value = departamento
                Dim lector As SqlDataReader
                lector = proProv.ExecuteReader
                While (lector.Read())
                    comboProv.Items.Add(lector.GetValue(1))
                End While
            End Using
            cBuenaPro.Close()
        End Using
    End Function
    Public Shared Function lisCatFinan(ByVal comboCatFin As ComboBox, sistema As String) As DataTable
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

End Class
