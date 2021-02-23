Imports CapaEntidad
Public Class Financiera
    Private codDepa As Integer
    Private codProv As Integer
    Private codCategoria As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As DataTable
        table = CapaAccesoDatos.listCheckBox.lisDep()
        comboDep.DisplayMember = "departamento"
        comboDep.ValueMember = "idDepa"
        comboDep.DataSource = table
        comboDep.Text = ""

    End Sub

    Private Sub comboDep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboDep.SelectedIndexChanged
        comboProv.Text = ""

        codDepa = comboDep.SelectedValue.ToString
        Dim table As DataTable

        table = CapaAccesoDatos.listCheckBox.lisProv(codDepa)
        comboProv.DisplayMember = "provincia"
        comboProv.ValueMember = "idProv"
        comboProv.DataSource = table
        comboProv.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSistema.SelectedIndexChanged
        comboCategoria.Text = ""
        Dim sistema As String
        sistema = comboSistema.SelectedItem.ToString
        Dim table As DataTable
        table = CapaAccesoDatos.listCheckBox.lisCatFinan(sistema)
        comboCategoria.DisplayMember = "categoria"
        comboCategoria.ValueMember = "idCategoria"
        comboCategoria.DataSource = table
        comboCategoria.Text = ""


    End Sub

    Private Sub comboProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProv.SelectedIndexChanged
        codProv = comboProv.SelectedValue.ToString()
    End Sub

    Private Sub comboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCategoria.SelectedIndexChanged
        codCategoria = comboCategoria.SelectedValue.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim codFinanciera As String
        Dim nombre As String
        Dim abreviatura As String
        Dim telefono As String
        Dim direccion As String
        codFinanciera = txtCodFinanciera.Text.ToString
        nombre = txtNombreFinan.Text.ToString.ToUpper
        abreviatura = txtAbreviatura.Text.ToString.ToUpper
        telefono = txtTelefono.Text.ToString
        direccion = txtDireccion.Text.ToString.ToUpper

        CapaAccesoDatos.financierasDA.insertarFinancieras(codCategoria, codFinanciera, nombre, abreviatura, telefono, direccion, codDepa, codProv)
        MsgBox("Financiera Registrada con éxito")

        txtCodFinanciera.Text = ""
        txtNombreFinan.Text = ""
        txtAbreviatura.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        codCategoria = Nothing
        codDepa = Nothing
        codProv = Nothing
        comboCategoria.Text = ""
        comboSistema.Text = ""
        comboDep.Text = ""
        comboProv.Text = ""




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub
End Class