Public Class Financiera
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CapaAccesoDatos.listCheckBox.lisDep(comboDep)
    End Sub

    Private Sub comboDep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboDep.SelectedIndexChanged
        Dim departamento As String

        departamento = comboDep.SelectedItem.ToString
        Console.WriteLine(departamento)
        CapaAccesoDatos.listCheckBox.lisProv(comboProv, departamento)
    End Sub
End Class