Imports CapaLogicaNegocios
Imports CapaEntidad
Public Class terreno
    Dim terrenoDE As terrenoDE
    Dim listDL As New listBoxDL()
    Dim terrenoDL As New terrenoDL()
    Dim idDepa As Integer
    Dim idProv As Integer
    Dim idDist As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            terrenoDE = New terrenoDE()
            terrenoDE.codTerreno = idDepa.ToString & idProv.ToString
            terrenoDE.descripcionTerreno = txtDescripcion.Text.ToUpper
            terrenoDE.direccionTerreno = txtDireccion.Text.ToUpper
            terrenoDE.metroAncho = Double.Parse(txtAncho.Text)
            terrenoDE.metroLargo = Double.Parse(txtLargo.Text)
            terrenoDE.departamento = idDepa
            terrenoDE.provincia = idProv
            terrenoDE.distrito = idDist
            terrenoDE.fechaRegistro = DateTime.Now.Date
            terrenoDL.inserTerreno(terrenoDE)
            limpiar()
        Catch ex As Exception
            MsgBox("ERROR EN EL REGISTRO " & ex.ToString)
        End Try
    End Sub

    Private Sub terreno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As DataTable
        table = CapaAccesoDatos.listCheckBox.lisDep()
        cbDepartamento.DisplayMember = "departamento"
        cbDepartamento.ValueMember = "idDepa"
        cbDepartamento.DataSource = table
        cbDepartamento.Text = "Seleccione"
    End Sub

    Private Sub cbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvincia.SelectedIndexChanged
        idProv = cbProvincia.SelectedValue.ToString
        Dim table As DataTable

        table = CapaAccesoDatos.listCheckBox.listDist(idProv)
        cboDistrito.DisplayMember = "distrito"
        cboDistrito.ValueMember = "idDist"
        cboDistrito.DataSource = table
        cboDistrito.Text = "Seleccione"
    End Sub

    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        cbProvincia.Text = ""

        idDepa = cbDepartamento.SelectedValue.ToString
        Dim table As DataTable

        table = CapaAccesoDatos.listCheckBox.lisProv(idDepa)
        cbProvincia.DisplayMember = "provincia"
        cbProvincia.ValueMember = "idProv"
        cbProvincia.DataSource = table
        cbProvincia.Text = "Seleccione"
    End Sub

    Private Sub cboDistrito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDistrito.SelectedIndexChanged
        idDist = cboDistrito.SelectedValue.ToString

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub limpiar()
        txtAncho.Text = ""
        txtLargo.Text = ""
        txtDescripcion.Text = ""
        txtDireccion.Text = ""
        cbDepartamento.SelectedText = ""
        cboDistrito.SelectedText = ""
        cbProvincia.SelectedText = ""
        cbProvincia.DataSource = Nothing
        cboDistrito.DataSource = Nothing
        cbProvincia.Items.Clear()
        cboDistrito.Items.Clear()
    End Sub
End Class