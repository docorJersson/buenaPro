Imports System.Data.SqlClient
Imports CapaEntidad
Public Class datUser
    Public Function ValidarUser(nombreUsuario As String, contraseUsuario As String) As entUser
        Dim connection = New SqlConnection(My.Settings.ConexionBUENAPRO)
        Dim command As New SqlCommand
        Dim reader As SqlDataReader
        Dim _usuario As entUser
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "sp_Usuario"
            command.Parameters.Add("@userName", SqlDbType.NVarChar, 60).Value = nombreUsuario
            command.Parameters.Add("@userPassword", SqlDbType.NVarChar, 60).Value = contraseUsuario
            command.CommandType = CommandType.StoredProcedure
            reader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                _usuario = New entUser
                _usuario._idUser = reader.Item("idUser")
                _usuario._nameUser = reader.Item("nameUser")
                _usuario._rol = reader.Item("rol")
                reader.Close()
            End If

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            connection.Close()
        End Try
        Return _usuario
    End Function

    Public Function obtenerCodigo(user As String, rol As String) As String
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using codUser As New SqlCommand("select dbo.usuarioAccion('" & user & "','" & rol & "')", cBuenaPro)
                Try
                    codUser.CommandType = CommandType.Text
                    Dim codigo As String
                    codigo = codUser.ExecuteScalar()
                    Return codigo
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            End Using
            cBuenaPro.Close()
        End Using
    End Function




End Class
