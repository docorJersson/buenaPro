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
    Public Function insertConvocatoria(newConvocatoria As CapaEntidad.convocatoriaPublicaDE, autogeneado As Boolean) As Integer
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using insertConvo As New SqlCommand("insertConvoPublica", cBuenaPro)
                Try
                    insertConvo.CommandType = CommandType.StoredProcedure
                    insertConvo.Parameters.AddWithValue("@codigoFun", newConvocatoria.funcionarioOSCE.codFOSCE)
                    insertConvo.Parameters.AddWithValue("@nResoFun", newConvocatoria.funcionarioOSCE.numResolucion)
                    insertConvo.Parameters.Add("@cConvocatoria", SqlDbType.Int)
                    insertConvo.Parameters("@cConvocatoria").Direction = ParameterDirection.Output
                    insertConvo.ExecuteNonQuery()
                    Dim cConvocatoria As Integer = insertConvo.Parameters("@cConvocatoria").Value
                    newConvocatoria.codigoConvocatoria = cConvocatoria
                    Console.WriteLine(newConvocatoria.codigoConvocatoria.ToString)
                    insertCronograma(newConvocatoria, autogeneado)
                    Return cConvocatoria
                Catch ex As Exception
                    Debug.WriteLine(ex)
                End Try
            End Using
            cBuenaPro.Close()
        End Using
    End Function
    Private Sub insertCronograma(newConvocatorias As CapaEntidad.convocatoriaPublicaDE, autogenerado As Boolean)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Console.WriteLine("DKDK")
            Dim listCronogramas As List(Of CapaEntidad.cronogramaDE) = newConvocatorias.cronogramaConvoatoria
            If autogenerado = True Then
                Using insertCrono As New SqlCommand("creacionFecha", cBuenaPro)
                    Try
                        insertCrono.CommandType = CommandType.StoredProcedure
                        insertCrono.Parameters.AddWithValue("@numConvo", newConvocatorias.codigoConvocatoria)
                        insertCrono.Parameters.AddWithValue("@fInicio", DateTime.Now.Date)
                        insertCrono.ExecuteNonQuery()
                    Catch ex As Exception
                        Debug.WriteLine(ex)
                    End Try

                End Using
            Else
                For Each cronograma As CapaEntidad.cronogramaDE In listCronogramas
                    Using insertCrono As New SqlCommand("insertCronograma", cBuenaPro)
                        Try
                            insertCrono.CommandType = CommandType.StoredProcedure
                            insertCrono.Parameters.AddWithValue("@cConvocatoria", newConvocatorias.codigoConvocatoria)
                            insertCrono.Parameters.AddWithValue("@idProcedimiento", cronograma.codigoProcedimiento)
                            insertCrono.Parameters.AddWithValue("@fInicio", cronograma.fechaInicio)
                            insertCrono.Parameters.AddWithValue("@fFin", cronograma.fechaFin)
                            insertCrono.ExecuteNonQuery()
                        Catch ex As Exception
                            Debug.WriteLine(ex)
                        End Try
                    End Using
                Next
            End If
            insertDetalleConvo(newConvocatorias)
            cBuenaPro.Close()
        End Using
    End Sub
    Private Sub insertDetalleConvo(newConvocatoria As CapaEntidad.convocatoriaPublicaDE)
        Using cBuenaPro As New SqlConnection(My.Settings.ConexionBUENAPRO)
            cBuenaPro.Open()
            Using insertDetConvoca As New SqlCommand("insertDetConvocatoria", cBuenaPro)
                insertDetConvoca.CommandType = CommandType.StoredProcedure
                Try
                    insertDetConvoca.Parameters.AddWithValue("@cConvocatoria", newConvocatoria.codigoConvocatoria)

                    insertDetConvoca.Parameters.AddWithValue("@nConvocatoria", newConvocatoria.numeroConvocatoria)

                    insertDetConvoca.Parameters.AddWithValue("@tSeleccion", newConvocatoria.tipoSeleccion)

                    insertDetConvoca.Parameters.AddWithValue("@normativa", newConvocatoria.normaConvocatoria)

                    insertDetConvoca.Parameters.AddWithValue("@nomenclatura", newConvocatoria.nomenclaturaConvo)

                    insertDetConvoca.Parameters.AddWithValue("@idModo", newConvocatoria.modoConvocatoria)

                    insertDetConvoca.Parameters.AddWithValue("@desConvocatoria", newConvocatoria.descripcionConvocatoria)

                    insertDetConvoca.Parameters.AddWithValue("@cParticipacion", newConvocatoria.costoParticipacion)

                    insertDetConvoca.Parameters.AddWithValue("@moneda", Trim(newConvocatoria.tipoMoneda))

                    insertDetConvoca.Parameters.AddWithValue("@costoBases", newConvocatoria.costoBases)

                    insertDetConvoca.Parameters.AddWithValue("@fPublicacion", newConvocatoria.fechaPublicacion)

                    insertDetConvoca.Parameters.AddWithValue("@ubigeo", newConvocatoria.entidadConvocante.ubigeoEntidad)

                    insertDetConvoca.Parameters.AddWithValue("@ruc", newConvocatoria.entidadConvocante.rucEntidad)

                    insertDetConvoca.Parameters.AddWithValue("@idFinancieraPub", newConvocatoria.financieraPublica)

                    insertDetConvoca.ExecuteNonQuery()
                Catch ex As Exception
                    Debug.WriteLine(ex)
                End Try
            End Using
            cBuenaPro.Close()
        End Using
    End Sub
End Class
