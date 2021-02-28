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
    Dim entidadConvocante As CapaEntidad.entidadPublica
    Private idFinanciera_Entidad As Integer
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
        newConvocatoria = New convocatoriaPublicaDE()
        Try
            Dim code As String
            Dim autogenerado As Boolean = True
            code = user.accionUser(session.Instance.getUser(), session.Instance.getTipo())
            funOSCEAccion = funOSCEDL.buscarCodigo(code)
            newConvocatoria.funcionarioOSCE = funOSCEAccion
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
            Dim cConvocatoria As Integer
            cConvocatoria = convoDL.insertConvo(newConvocatoria, autogenerado)
            MsgBox("Convocatoria N°" + cConvocatoria.ToString)

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
        tbDetallesConvo.SelectedIndex = 1
        expeTecnico(True)
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
        tbDetallesConvo.SelectedIndex = 2
        pnAprobacion.Enabled = True
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        pnTerreno.Enabled = True
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        pnEstudiosTec.Enabled = True
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        btnGuardar.Enabled = True
    End Sub
End Class