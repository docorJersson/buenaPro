Imports CapaEntidad
Imports System.Data.SqlClient
Public Class funcionarioOsceDA
    Public Function buscarFun(codigo As String) As funcionarioOSCEDE
        Dim connection = New SqlConnection(My.Settings.ConexionBUENAPRO)
        Dim command As New SqlCommand
        Dim reader As SqlDataReader
        Dim funcOSCE As funcionarioOSCEDE
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "obtenerFunOSCE"
            command.Parameters.AddWithValue("@codigo", codigo)
            command.CommandType = CommandType.StoredProcedure
            reader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                funcOSCE = New funcionarioOSCEDE()
                funcOSCE.desCargo = reader.Item("descripcionCargo")
                funcOSCE.codFOSCE = reader.Item("codigoFuncionario")
                funcOSCE.numResolucion = reader.Item("nResolucion")
                funcOSCE.correoOSCE = reader.Item("emailCoorporativo")
                funcOSCE.nIdentidad = reader.Item("nDIdentidad")
                funcOSCE.fechaRegistro = reader.Item("fRegistro")
                funcOSCE.estadoFun = reader.Item("estado")
                funcOSCE.tipoResolucion = reader.Item("idTiResolucion")
                reader.Close()
            End If

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            connection.Close()
        End Try
        Return funcOSCE
    End Function
End Class
