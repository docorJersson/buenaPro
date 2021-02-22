Imports System.Data.Sql
Imports System.Data.SqlClient
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
                Console.WriteLine(departamento)
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

End Class
