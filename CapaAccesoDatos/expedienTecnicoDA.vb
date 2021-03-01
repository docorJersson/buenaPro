Imports CapaEntidad
Imports System.Data.SqlClient
Public Class expedienTecnicoDA
    Public Sub insertExpediente(newExpediente As expedienteTecnicoDE)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            Try
                cBuenaPro.Open()
                Using expeTecnico As New SqlCommand("insertExpedienTecnico", cBuenaPro)
                    expeTecnico.CommandType = CommandType.StoredProcedure

                    expeTecnico.Parameters.AddWithValue("@cConvocatoria", newExpediente.convocatoriaPublica.codigoConvocatoria)
                    expeTecnico.Parameters.AddWithValue("@cExpeTecnico", SqlDbType.Int)
                    expeTecnico.Parameters.AddWithValue("@presupuesto", newExpediente.presupuestObra)
                    expeTecnico.Parameters.AddWithValue("@fPresupuesto", newExpediente.fechaPresupuesto)
                    expeTecnico.Parameters.AddWithValue("@fRegistroPre", newExpediente.fRegistroPresupuesto)
                    expeTecnico.Parameters.AddWithValue("@docAnalisis", newExpediente.docAnalisis)
                    expeTecnico.Parameters.AddWithValue("@docFormulas", newExpediente.docFormulasPoli)
                    expeTecnico.Parameters.AddWithValue("@docGestion", newExpediente.docGestionRiesgos)
                    expeTecnico.Parameters.AddWithValue("@docOtros", newExpediente.docOtros)
                    expeTecnico.Parameters.AddWithValue("@fRegistro", newExpediente.fRegistroExpediente)
                    expeTecnico.Parameters.AddWithValue("@rucConsultora", newExpediente.consultoraObras.rucConsultoraObra)

                    expeTecnico.Parameters("@cExpeTecnico").Direction = ParameterDirection.Output
                    expeTecnico.ExecuteNonQuery()
                    Dim cExpediente As Integer = expeTecnico.Parameters("@cExpeTecnico").Value
                    newExpediente.codigoExpediente = cExpediente

                    insertTerrenoExpediente(newExpediente)
                    insertEstudioTec(newExpediente)
                End Using
                cBuenaPro.Close()
            Catch ex As Exception
                Debug.WriteLine(ex)
            End Try
        End Using
    End Sub
    Private Sub insertTerrenoExpediente(newExpediente As expedienteTecnicoDE)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            For Each terrenoExpe As terrenoExpedienteDE In newExpediente.terrenosExpediente
                Using insertTerreExpe As New SqlCommand("insertTerrenoExpediente", cBuenaPro)
                    Try
                        insertTerreExpe.CommandType = CommandType.StoredProcedure
                        insertTerreExpe.Parameters.AddWithValue("@codTereno", terrenoExpe.terrenoExpe.codTerreno)
                        insertTerreExpe.Parameters.AddWithValue("@cConvocatoria", newExpediente.convocatoriaPublica.codigoConvocatoria)
                        insertTerreExpe.Parameters.AddWithValue("@cExpeTecnico", newExpediente.codigoExpediente)
                        insertTerreExpe.Parameters.AddWithValue("@observacion", terrenoExpe.observacionTerreno)
                        insertTerreExpe.Parameters.AddWithValue("@fRegistro", terrenoExpe.fechaRegistro)
                        insertTerreExpe.ExecuteNonQuery()
                    Catch ex As Exception
                        Debug.WriteLine(ex)
                    End Try
                End Using
            Next
            cBuenaPro.Close()
        End Using
    End Sub
    Private Sub insertEstudioTec(newExpediente As expedienteTecnicoDE)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            For Each estudioTec As estudioTecnicoDE In newExpediente.estudioTecnico
                Using insertEstudio As New SqlCommand("insertEstudioTec", cBuenaPro)
                    Try
                        insertEstudio.CommandType = CommandType.StoredProcedure
                        insertEstudio.Parameters.AddWithValue("@cConvocatoria", newExpediente.convocatoriaPublica.codigoConvocatoria)
                        insertEstudio.Parameters.AddWithValue("@cExpeTecnico", newExpediente.codigoExpediente)
                        insertEstudio.Parameters.AddWithValue("@nombre", estudioTec.nombreEstudio)
                        insertEstudio.Parameters.AddWithValue("@documento", estudioTec.documentoEstudio)
                        insertEstudio.Parameters.AddWithValue("@fEstudio", estudioTec.fechaEstudio)
                        insertEstudio.Parameters.AddWithValue("@fRegistroTec", estudioTec.fechaRegistro)
                        insertEstudio.ExecuteNonQuery()
                    Catch ex As Exception
                        Debug.WriteLine(ex)
                    End Try
                End Using
            Next
            cBuenaPro.Close()
        End Using
    End Sub
    Public Sub insertAprobacion(newExpediente As expedienteTecnicoDE)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            Try
                cBuenaPro.Open()
                Using aprobacion As New SqlCommand("insertAprobacion", cBuenaPro)
                    aprobacion.CommandType = CommandType.StoredProcedure

                    aprobacion.Parameters.AddWithValue("@cConvocatoria", newExpediente.convocatoriaPublica.codigoConvocatoria)
                    aprobacion.Parameters.AddWithValue("@cExpeTecnico", newExpediente.codigoExpediente)
                    aprobacion.Parameters.AddWithValue("@cAprobacion", newExpediente.codigoExpediente.ToString & newExpediente.convocatoriaPublica.codigoConvocatoria.ToString)
                    Console.WriteLine(newExpediente.codigoExpediente.ToString & newExpediente.convocatoriaPublica.codigoConvocatoria.ToString & "Cambios")
                    aprobacion.Parameters.AddWithValue("@tDocumento", newExpediente.aprobacionPublica.tipoDocumento)
                    aprobacion.Parameters.AddWithValue("@fAprobacion", newExpediente.aprobacionPublica.fechaAprobacion)
                    aprobacion.Parameters.AddWithValue("@doc", newExpediente.aprobacionPublica.documentoAprobacion)
                    aprobacion.Parameters.AddWithValue("@area", newExpediente.aprobacionPublica.areaElaboracion)
                    aprobacion.Parameters.AddWithValue("@plazoObra", newExpediente.aprobacionPublica.plazoObra)
                    aprobacion.Parameters.AddWithValue("@codigoFun", newExpediente.aprobacionPublica.funcionariOSCE.codFOSCE)
                    aprobacion.Parameters.AddWithValue("@nResolucion", newExpediente.aprobacionPublica.funcionariOSCE.numResolucion)

                    aprobacion.ExecuteNonQuery()
                End Using
                cBuenaPro.Close()
            Catch ex As Exception
                Debug.WriteLine(ex)
            End Try
        End Using
    End Sub
End Class
