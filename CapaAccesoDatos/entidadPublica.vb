Imports System.Data.SqlClient
Imports CapaEntidad
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

    Public Sub insertEntidad(newEntidad As CapaEntidad.entidadPublica)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using insertEnti As New SqlCommand("insetEntidadPublica", cBuenaPro)
                Try
                    insertEnti.CommandType = CommandType.StoredProcedure
                    insertEnti.Parameters.AddWithValue("@ubigeo", Trim(newEntidad.ubigeoEntidad))
                    insertEnti.Parameters.AddWithValue("@ruc", Trim(newEntidad.rucEntidad))
                    insertEnti.Parameters.AddWithValue("@nombreEntidad", Trim(newEntidad.entidadaNombre))
                    insertEnti.Parameters.AddWithValue("@idDepa", Trim(newEntidad.departamento))
                    insertEnti.Parameters.AddWithValue("@idPro", Trim(newEntidad.provincia))
                    insertEnti.Parameters.AddWithValue("@idDist", Trim(newEntidad.distrito))
                    insertEnti.Parameters.AddWithValue("@direccion", Trim(newEntidad.direccionEntidad))
                    insertEnti.Parameters.AddWithValue("@web", Trim(newEntidad.paginaWeb))
                    insertEnti.Parameters.AddWithValue("@telefono", Trim(newEntidad.entidadTelefono))
                    insertEnti.Parameters.AddWithValue("@email", Trim(newEntidad.emailEntidad))
                    insertEnti.ExecuteNonQuery()

                    insertFunEntidad(newEntidad.entidadFuncionario)
                    insertFinanEntidad(newEntidad.fin_Entidad)
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            End Using
            cBuenaPro.Close()
        End Using
    End Sub
    Private Sub insertFunEntidad(listFun As List(Of CapaEntidad.funcionarioEntidad))
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            For Each funcionario As CapaEntidad.funcionarioEntidad In listFun
                Using insertFun As New SqlCommand("insertFuncEntidad", cBuenaPro)
                    Try
                        insertFun.CommandType = CommandType.StoredProcedure
                        insertFun.Parameters.AddWithValue("@codigo", Trim(funcionario.codigoFun))
                        insertFun.Parameters.AddWithValue("@nResolucion", Trim(funcionario.resoFun))
                        insertFun.Parameters.AddWithValue("@cargo", Trim(funcionario.cargoFun))
                        insertFun.Parameters.AddWithValue("@fResolucion", funcionario.fechaResolucion)
                        insertFun.Parameters.AddWithValue("@ubigeo", Trim(funcionario.ubigeoEntidad))
                        insertFun.Parameters.AddWithValue("@ruc", Trim(funcionario.rucEntidad))
                        insertFun.Parameters.AddWithValue("@nDIdentidad", Trim(funcionario.identidadCiudadano))
                        insertFun.Parameters.AddWithValue("@idTiResolucion", funcionario.idResolucion)
                        insertFun.ExecuteNonQuery()
                    Catch ex As Exception
                        Console.WriteLine(ex)
                    End Try
                End Using
            Next
            cBuenaPro.Close()
        End Using
    End Sub
    Private Sub insertFinanEntidad(listFinan As List(Of CapaEntidad.financieraEntidad))
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            For Each financiera As CapaEntidad.financieraEntidad In listFinan
                Using insertFinan As New SqlCommand("insertFinanPublica", cBuenaPro)
                    Try
                        insertFinan.CommandType = CommandType.StoredProcedure
                        insertFinan.Parameters.AddWithValue("@codFinanciera", Trim(financiera.codigoFinanciera))
                        insertFinan.Parameters.AddWithValue("@cuenta", Trim(financiera.cuentaBancaria))
                        insertFinan.Parameters.AddWithValue("@cuentaIBAN", Trim(financiera.cuentaInterbankaria))
                        insertFinan.Parameters.AddWithValue("@fApertura", financiera.fechApertura)
                        insertFinan.Parameters.AddWithValue("@seguroBanco", financiera.seguroBanco)
                        insertFinan.Parameters.AddWithValue("@saldo", financiera.saldoCuenta)
                        insertFinan.Parameters.AddWithValue("@ruc", Trim(financiera.rucEntidad))
                        insertFinan.Parameters.AddWithValue("@ubigeo", Trim(financiera.ubigeoEntidad))
                        insertFinan.ExecuteNonQuery()
                    Catch ex As Exception
                        Console.WriteLine(ex)
                    End Try
                End Using
            Next
            cBuenaPro.Close()
        End Using
    End Sub


End Class
