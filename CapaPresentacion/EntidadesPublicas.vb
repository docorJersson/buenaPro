Imports CapaEntidad
Imports CapaLogicaNegocios
Public Class EntidadesPublicas
    Private listBoxDL As New listBoxDL()
    Private codDepa As Integer
    Private codProv As Integer
    Private codDis As Integer
    Private ruc As String
    Private ubigeo As String
    Private entidadDL As New CapaLogicaNegocios.entidadPublica
    Public enti_Financiera As New List(Of financieraEntidad)
    Public funcionarioEntidad As New List(Of funcionarioEntidad)
    Private newEntidad As CapaEntidad.entidadPublica

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnEntidad.Paint

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged

    End Sub

    Private Sub EntidadesPublicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As DataTable
        table = CapaAccesoDatos.listCheckBox.lisDep()
        cboDepar.DisplayMember = "departamento"
        cboDepar.ValueMember = "idDepa"
        cboDepar.DataSource = table
        cboDepar.Text = "Seleccione"
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged

        cboDistrito.Text = ""

        codProv = cboProvincia.SelectedValue.ToString
        Dim table As DataTable

        table = CapaAccesoDatos.listCheckBox.listDist(codProv)
        cboDistrito.DisplayMember = "distrito"
        cboDistrito.ValueMember = "idDist"
        cboDistrito.DataSource = table
        cboDistrito.Text = "Seleccione"

    End Sub

    Private Sub cboDistrito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDistrito.SelectedIndexChanged
        codDis = cboDistrito.SelectedValue.ToString
    End Sub

    Private Sub cboDepar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepar.SelectedIndexChanged
        cboProvincia.Text = ""

        codDepa = cboDepar.SelectedValue.ToString
        Dim table As DataTable

        table = CapaAccesoDatos.listCheckBox.lisProv(codDepa)
        cboProvincia.DisplayMember = "provincia"
        cboProvincia.ValueMember = "idProv"
        cboProvincia.DataSource = table
        cboProvincia.Text = "Seleccione"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        listaFinancieras.Show()

    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim codFinan As String
        Dim cuenta As String
        Dim interbankario As String
        Dim saldo As Double
        Dim seguro As Boolean
        Dim fApertura As Date
        If ckSeguro.Checked = True Then
            seguro = True
        Else
            seguro = False
        End If

        codFinan = txtCodFinan.Text.ToString
        cuenta = txtCuenta.Text.ToString
        interbankario = txtInterbankario.Text.ToString
        saldo = txtSaldo.Text.ToString
        fApertura = dtApertura.Value.Date
        Try
            Dim entidad_Finaicera As New financieraEntidad()
            entidad_Finaicera.cuentaBancaria = cuenta
            entidad_Finaicera.cuentaInterbankaria = interbankario
            entidad_Finaicera.fechApertura = fApertura
            entidad_Finaicera.seguroBanco = seguro
            entidad_Finaicera.saldoCuenta = Convert.ToDouble(saldo)
            entidad_Finaicera.rucEntidad = ruc
            entidad_Finaicera.ubigeoEntidad = ubigeo
            entidad_Finaicera.codigoFinanciera = codFinan
            enti_Financiera.Add(entidad_Finaicera)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        Dim entFina As ListViewItem
        entFina = New ListViewItem(codFinan)
        entFina.SubItems.Add(txtNomFinan.Text)
        entFina.SubItems.Add(cuenta)
        entFina.SubItems.Add(interbankario)
        entFina.SubItems.Add(seguro.ToString)
        entFina.SubItems.Add(fApertura.ToString)
        entFina.SubItems.Add(saldo)
        listFinanciera.Items.Add(entFina)

        limpiarFinanciera()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            newEntidad = New CapaEntidad.entidadPublica()
            newEntidad.rucEntidad = ruc
            newEntidad.ubigeoEntidad = ubigeo
            newEntidad.entidadaNombre = txtNombre.Text
            newEntidad.departamento = codDepa
            newEntidad.provincia = codProv
            newEntidad.distrito = codDis
            newEntidad.direccionEntidad = txtDirecion.Text
            newEntidad.paginaWeb = txtWeb.Text
            newEntidad.entidadTelefono = txtTeléfono.Text
            newEntidad.emailEntidad = txtCorreo.Text
            newEntidad.fin_Entidad = enti_Financiera
            newEntidad.entidadFuncionario = funcionarioEntidad

            entidadDL.insertEntidad(newEntidad)
            MsgBox("REGISTRO GUARDADO")
            listFinanciera.Items.Clear()
            lisFuncionario.Items.Clear()
            limpiaEntidad(False)
            limpiarFinanciera()
            limpiarFuncionario()
            enti_Financiera.Clear()
            funcionarioEntidad.Clear()

        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles panelFinancieras.Paint

    End Sub

    Private Sub listFinanciera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listFinanciera.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ubigeo = CapaAccesoDatos.entidadPublica.obtenerUbigeo(codDepa, codProv, codDis)
        Console.WriteLine(ubigeo)
        If ubigeo = "EXISTE" Then
            MsgBox("LA ENTIDAD DESEA REGISTRAR YA EXISTE")
            ubigeo = Nothing
            limpiaEntidad(False)
        Else
            ruc = txtRuc.Text.ToString
            txtUbigeo.Text = ubigeo
            tbDetalles.Enabled = True
            panelFinancieras.Enabled = True
            pnEntidad.Enabled = False
            Button5.Enabled = False
            MsgBox("CONTINÚE REGISTRANDO LOS DATOS ")

            cboResolucion.Text = ""
            Dim table As DataTable

            table = listBoxDL.listResolucion()
            cboResolucion.DisplayMember = "tipoResolucion"
            cboResolucion.ValueMember = "idTiResolucion"
            cboResolucion.DataSource = table
            cboResolucion.Text = "Seleccione"
        End If

    End Sub

    Private Sub limpiaEntidad(estado As Boolean)
        cboDepar.Text = ""
        cboDistrito.Text = ""
        cboProvincia.Text = ""
        codDepa = Nothing
        codDis = Nothing
        codProv = Nothing
        txtNombre.Text = ""
        txtRuc.Text = ""
        txtUbigeo.Text = ""
        txtDirecion.Text = ""
        txtWeb.Text = ""
        txtTeléfono.Text = ""
        txtCorreo.Text = ""
        tbDetalles.Enabled = estado
        pnEntidad.Enabled = Not estado
        panelFinancieras.Enabled = estado
        Button5.Enabled = Not estado
    End Sub

    Private Sub limpiarFinanciera()
        txtCodFinan.Text = ""
        txtNomFinan.Text = ""
        txtAbreviatura.Text = ""
        txtCuenta.Text = ""
        txtInterbankario.Text = ""
        txtSaldo.Text = ""
        ckSeguro.CheckState = False
    End Sub
    Private Sub limpiarFuncionario()
        txtIdentidad.Text = ""
        txtNomCiudadano.Text = ""
        txtCargo.Text = ""
        dtFResolucion.Text = ""
        cboResolucion.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiarFinanciera()
        limpiaEntidad(False)
        listFinanciera.Items.Clear()
        lisFuncionario.Items.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        listaCiudadano.Show()
    End Sub

    Private Sub cboResolucion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboResolucion.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim nIdentidad As String
        Dim cargo As String
        Dim fResolucion As Date
        Dim idTiResolucion As Integer

        nIdentidad = txtIdentidad.Text
        cargo = txtCargo.Text
        fResolucion = dtFResolucion.Value.Date
        idTiResolucion = cboResolucion.SelectedValue.ToString

        Dim funcionario As New funcionarioEntidad()
        funcionario.codigoFun = nIdentidad
        funcionario.resoFun = nIdentidad
        funcionario.cargoFun = cargo
        funcionario.fechaResolucion = fResolucion
        funcionario.ubigeoEntidad = ubigeo
        funcionario.rucEntidad = ruc
        funcionario.idResolucion = idTiResolucion
        funcionario.identidadCiudadano = nIdentidad
        funcionarioEntidad.Add(funcionario)


        Dim funEntidad As ListViewItem
        funEntidad = New ListViewItem(nIdentidad)
        funEntidad.SubItems.Add(txtNomCiudadano.Text)
        funEntidad.SubItems.Add(txtCargo.Text)
        funEntidad.SubItems.Add(fResolucion.ToString)
        lisFuncionario.Items.Add(funEntidad)

        limpiarFuncionario()

    End Sub
End Class