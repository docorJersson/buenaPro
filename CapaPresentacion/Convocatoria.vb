Imports CapaLogicaNegocios
Imports CapaEntidad
Public Class Convocatoria
    Dim finanFl As New financieraDL()
    Dim listboxDL As New listBoxDL()
    Dim convoDL As New convocatoriaDL()
    Dim user As New negLogin()
    Dim funOSCEDL As New funcionarioOSCEDL()
    Dim newConvocatoria As convocatoriaPublicaDE
    Dim funOSCEAccion As funcionarioOSCEDE
    Dim cronogramaConv As New List(Of cronogramaDE)
    Dim newCronograma As cronogramaDE
    Dim consultoraObraDE As consultoraObraDE
    Dim entidadConvocante As CapaEntidad.entidadPublica
    Dim expeTecnicoDE As expedienteTecnicoDE
    Dim aprobacionDE As aprobacionPublicaDE
    Dim terrenoExpeDE As terrenoExpedienteDE
    Dim listTerrenoExpe As New List(Of terrenoExpedienteDE)
    Dim estudioTecDE As estudioTecnicoDE
    Dim listEstudioTec As New List(Of estudioTecnicoDE)
    Dim expeTecnicoDL As New expedienTecnicoDL()
    Private idFinanciera_Entidad As Integer
    Private autogenerado As Boolean = True
    Private idDepa As Integer
    Private idProv As Integer
    Private idDist As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNConvocatoria.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Convocatoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles pnCronograma.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cboProce As Integer
        cboProce = cboProcedimiento.SelectedValue.ToString

        Dim fInicio As Date
        Dim fFin As Date
        Dim nombreProc As String
        fInicio = dtInicio.Value.Date
        fFin = dtFin.Value.Date

        newCronograma = New cronogramaDE()

        nombreProc = cboProcedimiento.SelectedItem.ToString.ToUpper

        Dim crono As ListViewItem
        crono = New ListViewItem(nombreProc)
        crono.SubItems.Add(fInicio.ToString("d"))
        crono.SubItems.Add(fFin.ToString("d"))
        lstCronograma.Items.Add(crono)

        newCronograma.fechaFin = fFin
        newCronograma.fechaInicio = fInicio
        newCronograma.codigoProcedimiento = cboProce

        cronogramaConv.Add(newCronograma)



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim table As DataTable
        table = listboxDL.listProcedimiento()

        cboProcedimiento.DisplayMember = "procedimiento"
        cboProcedimiento.ValueMember = "idProcedimiento"
        cboProcedimiento.DataSource = table
        cboProcedimiento.Text = "Seleccione"
        registroConvo(True)

    End Sub

    Private Sub cboGenerar_CheckedChanged(sender As Object, e As EventArgs) Handles ckGenerar.CheckedChanged
        If ckGenerar.Checked = True Then
            lstCronograma.Items.Clear()
            pnCronograma.Enabled = False
            Dim table As DataTable = convoDL.bocetoCronograma()
            Try
                For Each row As DataRow In table.Rows
                    Dim crono As ListViewItem
                    crono = New ListViewItem(Trim(row("procedimiento")))
                    crono.SubItems.Add((row("fInicio").ToString()))
                    crono.SubItems.Add((row("fFin").ToString()))
                    lstCronograma.Items.Add(crono)
                Next

            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
        Else
            pnCronograma.Enabled = True
            lstCronograma.Items.Clear()
        End If

    End Sub
    Private Sub registroConvo(estado As Boolean)
        tbDetallesConvo.Enabled = estado
        pnCronoConvocatoria.Enabled = estado
    End Sub


    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dispose()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim code As String
            funOSCEAccion = New funcionarioOSCEDE()
            code = user.accionUser(session.Instance.getUser(), session.Instance.getTipo())
            funOSCEAccion = funOSCEDL.buscarCodigo(code)
            newConvocatoria.funcionarioOSCE = funOSCEAccion
            If ckFunApro.Checked Then
                aprobacionDE.funcionariOSCE = funOSCEAccion
            End If

            Dim cConvocatoria As Integer
            cConvocatoria = convoDL.insertConvo(newConvocatoria, autogenerado)
            newConvocatoria.codigoConvocatoria = cConvocatoria

            expeTecnicoDE.convocatoriaPublica = newConvocatoria

            expeTecnicoDL.insertExpe(expeTecnicoDE)
            expeTecnicoDE.aprobacionPublica = aprobacionDE
            expeTecnicoDL.insertAprobacion(expeTecnicoDE)

            MsgBox("Convocatoria N°" & cConvocatoria.ToString)

        Catch ex As Exception
            Debug.WriteLine(ex)
        End Try
    End Sub

    Private Sub cboTiSeleccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTiSeleccion.SelectedIndexChanged

    End Sub

    Private Sub cboProcedimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProcedimiento.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim listForm As New listaEntidades()
        AddOwnedForm(listForm)
        listForm.ShowDialog()
        txtUbigeo.Text = listForm.ubigeoEntidad
        txtRuc.Text = listForm.rucEntidad
        txtNombreEntidad.Text = listForm.nombreEntidad
        entidadConvocante = New CapaEntidad.entidadPublica()
        entidadConvocante.ubigeoEntidad = listForm.ubigeoEntidad
        entidadConvocante.rucEntidad = listForm.rucEntidad
        idDepa = listForm.departamento
        idProv = listForm.provincia
        idDist = listForm.distrito

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim tableModo As DataTable
        tableModo = listboxDL.listModoDeber()

        cboModoDeber.DisplayMember = "modo"
        cboModoDeber.ValueMember = "idModo"
        cboModoDeber.DataSource = tableModo
        cboModoDeber.Text = "Seleccione"
        pnDetalleConvo.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim listFinanEntidad As New listFinancierta_Entidad(entidadConvocante.ubigeoEntidad)
        listFinanEntidad.ShowDialog()
        idFinanciera_Entidad = listFinanEntidad.idFinancieraPublica
        txtCodFinancera.Text = listFinanEntidad.codFinanciera
        txtNombreFinan.Text = listFinanEntidad.nomFinanciera
        txtCuenBan.Text = listFinanEntidad.cuentaBancaria
    End Sub

    Private Sub cboCostParticipacion_CheckedChanged(sender As Object, e As EventArgs) Handles cboCostParticipacion.CheckedChanged
        If cboCostParticipacion.Checked Then
            txtParticipacion.Enabled = False
        Else
            txtParticipacion.Enabled = True
        End If
        txtParticipacion.Text = ""
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles pnDetalleConvo.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles pnPresupuesto.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        newConvocatoria = New convocatoriaPublicaDE()
        Try
            newConvocatoria.numeroConvocatoria = txtNConvocatoria.Text
            newConvocatoria.tipoSeleccion = cboTiSeleccion.SelectedItem.ToString.ToUpper
            newConvocatoria.normaConvocatoria = txtNormativa.Text.ToUpper
            newConvocatoria.nomenclaturaConvo = txtNomenclatura.Text.ToUpper
            newConvocatoria.modoConvocatoria = cboModoDeber.SelectedValue.ToString
            newConvocatoria.descripcionConvocatoria = txtDesConvocatoria.Text.ToUpper
            If cboCostParticipacion.Checked = True Then
                newConvocatoria.costoParticipacion = 0
            Else
                newConvocatoria.costoParticipacion = txtParticipacion.Text
            End If
            newConvocatoria.tipoMoneda = cboMoneda.SelectedItem.ToString
            newConvocatoria.costoBases = txtBases.Text
            newConvocatoria.fechaPublicacion = dtFPublicacion.Value.Date
            newConvocatoria.entidadConvocante = Me.entidadConvocante
            newConvocatoria.financieraPublica = Me.idFinanciera_Entidad
            If ckGenerar.Checked = False Then
                autogenerado = False
                newConvocatoria.cronogramaConvoatoria = Me.cronogramaConv
            End If

            tbDetallesConvo.SelectedIndex = 1
            expeTecnico(True)
        Catch ex As Exception
            Debug.WriteLine(ex)
        End Try

    End Sub

    Private Sub expeTecnico(estado As Boolean)
        pnConsultora.Enabled = estado
        pnPresupuesto.Enabled = estado
        pnAnalisis.Enabled = estado
        pnPolinomicas.Enabled = estado
        pnRiesgos.Enabled = estado
        pnDocOpcional.Enabled = estado
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        expeTecnicoDE = New expedienteTecnicoDE()
        expeTecnicoDE.presupuestObra = txtPresupuesto.Text
        expeTecnicoDE.fechaPresupuesto = dtPresupuesto.Value.Date
        expeTecnicoDE.fRegistroPresupuesto = dtRegistroPresupuesto.Value.Date
        expeTecnicoDE.docAnalisis = txtAnalisis.Text
        expeTecnicoDE.docFormulasPoli = txtFormulas.Text
        expeTecnicoDE.docGestionRiesgos = txtRiesgos.Text
        expeTecnicoDE.docOtros = txtOtrosDoc.Text
        expeTecnicoDE.fRegistroExpediente = DateTime.Now.Date
        consultoraObraDE = New consultoraObraDE()
        consultoraObraDE.rucConsultoraObra = txtRUConsultora.Text
        expeTecnicoDE.consultoraObras = consultoraObraDE

        tbDetallesConvo.SelectedIndex = 2
        pnAprobacion.Enabled = True
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        aprobacionDE = New aprobacionPublicaDE()
        aprobacionDE.tipoDocumento = cboAproTipDoc.SelectedItem.ToString
        aprobacionDE.fechaAprobacion = dtFechaAprobacion.Value.Date
        aprobacionDE.documentoAprobacion = txtDocAprobacion.Text
        aprobacionDE.areaElaboracion = txtAreAprobacion.Text
        aprobacionDE.plazoObra = numAproPlazoObra.Value.ToString
        If ckFunApro.Checked = False Then
            funOSCEAccion = New funcionarioOSCEDE()
            funOSCEAccion.codFOSCE = txtAproCodFunOSCE.Text
            funOSCEAccion.numResolucion = txtAproResoFunOSCE.Text
            aprobacionDE.funcionariOSCE = funOSCEAccion
        End If
        pnTerreno.Enabled = True
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        expeTecnicoDE.terrenosExpediente = listTerrenoExpe
        pnEstudiosTec.Enabled = True
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        expeTecnicoDE.estudioTecnico = listEstudioTec
        btnGuardar.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckFunApro.CheckedChanged
        If ckFunApro.Checked Then
            funAprobacion(False)
        Else
            funAprobacion(True)
        End If
    End Sub
    Private Sub funAprobacion(estado As Boolean)
        txtAproFunNombre.Text = ""
        txtAproResoFunOSCE.Text = ""
        txtAproCodFunOSCE.Text = ""
        txtAproCodFunOSCE.Enabled = estado
        txtAproFunNombre.Enabled = estado
        txtAproResoFunOSCE.Enabled = estado
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsTerreno.SelectedIndexChanged

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim codTerreno As String = txTerrenoCod.Text
        Dim descripcion As String = txTerrenoDes.Text.ToUpper
        Dim observacion As String = txTerrenoObser.Text.ToUpper

        Dim terreno As ListViewItem
        terreno = New ListViewItem(codTerreno)
        terreno.SubItems.Add(descripcion)
        terreno.SubItems.Add(observacion)
        lsTerreno.Items.Add(terreno)

        terrenoExpeDE = New terrenoExpedienteDE()
        terrenoExpeDE.terrenoExpe.codTerreno = codTerreno
        terrenoExpeDE.fechaRegistro = DateTime.Now.Date
        listTerrenoExpe.Add(terrenoExpeDE)
        limpiaTerreno()


    End Sub

    Private Sub limpiaTerreno()
        txTerrenoCod.Text = ""
        txTerrenoDes.Text = ""
        txTerrenoObser.Text = ""
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim nombrEstudio As String = txtEstudioNombre.Text.ToUpper
        Dim docEstudio As String = txtEstudioDoc.Text
        Dim fEstudio As Date = dtEstudioFecha.Value.Date

        Dim estudio As ListViewItem
        estudio = New ListViewItem(nombrEstudio)
        estudio.SubItems.Add(docEstudio)
        estudio.SubItems.Add(fEstudio.ToString("d"))
        lstEstudio.Items.Add(estudio)

        estudioTecDE = New estudioTecnicoDE()
        estudioTecDE.nombreEstudio = nombrEstudio
        estudioTecDE.documentoEstudio = docEstudio
        estudioTecDE.fechaEstudio = fEstudio
        estudioTecDE.fechaRegistro = DateTime.Now.Date
        listEstudioTec.Add(estudioTecDE)
        limpiaEstudio()

    End Sub
    Private Sub limpiaEstudio()
        txtEstudioDoc.Text = ""
        txtEstudioNombre.Text = ""
        dtEstudioFecha.Value = DateTime.Now
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim nombreDoc As String = seleccionDocumento("analisisPrecio")
        txtAnalisis.Text = nombreDoc
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
    Private Function seleccionDocumento(docActividad As String) As String
        oDexploradorArchivos.Title = "Seleccione Documento"
        oDexploradorArchivos.Filter = "PDF|*.pdf"
        If oDexploradorArchivos.ShowDialog() = DialogResult.OK Then
            Dim extension As String = IO.Path.GetExtension(oDexploradorArchivos.FileName)
            If extension = ".pdf" Then
                Dim nombreOriginal = IO.Path.GetFileNameWithoutExtension(oDexploradorArchivos.FileName)
                Dim fecha As String = Date.Today()
                fecha = fecha.Replace("/", "-")
                Dim aleatorio As Integer = CInt(Int((999999 * Rnd()) + 1))
                Dim nombreFinal As String = aleatorio & "_" & fecha & "_" & nombreOriginal & "_" & docActividad & ".pdf"
                MsgBox("EL ARCHIVO HA SIDO SELECCIONADO CORRECTAMENTE")
                IO.File.Copy(oDexploradorArchivos.FileName, "./documentosBUENA_PRO/" & nombreFinal)
                Return nombreFinal
            Else
                MsgBox("EL FORMATO ES INCORRECTO")
            End If
        Else
            MsgBox("Error, Seleccion Vacía")
        End If
    End Function

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim nombreDoc As String = seleccionDocumento("formulasPolinomicas")
        txtFormulas.Text = nombreDoc
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim nombreDoc As String = seleccionDocumento("gestionRiesgos")
        txtRiesgos.Text = nombreDoc
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim nombreDoc As String = seleccionDocumento("otrosDocumentos")
        txtOtrosDoc.Text = nombreDoc
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim nombreDoc As String = seleccionDocumento("aprobaciónPública")
        txtDocAprobacion.Text = nombreDoc
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim listConObras As New listConsultoraObra()
        listConObras.ShowDialog()
        txtRUConsultora.Text = listConObras.rucConsultora
        txtNameConsultora.Text = listConObras.nombreConsultora
        txtRepresentanteConsultora.Text = listConObras.representanteConsultora


    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim listFun As New listFuncionariOSCE()
        listFun.ShowDialog()
        txtAproCodFunOSCE.Text = listFun.codigoFunOSCE
        txtAproResoFunOSCE.Text = listFun.resoFunOSCE
        txtAproFunNombre.Text = listFun.nombreFunOSCE
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim listTerreno As New lisTerreno()
        listTerreno.ShowDialog()
        txTerrenoCod.Text = listTerreno.codigoTerreno
        txTerrenoDes.Text = listTerreno.descripcionTerreno
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim nombreDoc As String = seleccionDocumento("estudioTecnico")
        txtEstudioDoc.Text = nombreDoc
    End Sub
End Class