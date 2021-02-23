Public Class Financiera
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CapaAccesoDatos.listCheckBox.lisDep(comboDep)
    End Sub

    Private Sub comboDep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboDep.SelectedIndexChanged
        comboProv.Text = ""
        comboProv.Items.Clear()
        Dim departamento As String

        departamento = comboDep.SelectedItem.ToString
        CapaAccesoDatos.listCheckBox.lisProv(comboProv, departamento)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSistema.SelectedIndexChanged
        comboCategoria.Text = ""
        comboCategoria.Items.Clear()

        Dim sistema As String
        sistema = comboSistema.SelectedItem.ToString
        Dim table As DataTable
        table = CapaAccesoDatos.listCheckBox.lisCatFinan(comboCategoria, sistema)
        comboCategoria.DisplayMember = "categoria"
        comboCategoria.ValueMember = "idCategoria"
        comboCategoria.DataSource = table

    End Sub

    Private Sub comboProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProv.SelectedIndexChanged

    End Sub

    Private Sub comboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCategoria.SelectedIndexChanged
        Console.WriteLine(comboCategoria.SelectedItem.ToString)
        Console.WriteLine(comboCategoria.SelectedValue.ToString)
        Console.WriteLine(comboCategoria.SelectedText.ToString)
    End Sub
End Class