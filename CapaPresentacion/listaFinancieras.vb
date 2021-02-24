Public Class listaFinancieras
    Dim codFinancieraNueva As String

    Private Sub listaFinancieras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daGriFinancieras.DataSource = CapaAccesoDatos.financierasDA.listFinancieras()
    End Sub

    Private Sub daGriFinancieras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles daGriFinancieras.CellContentClick
        codFinancieraNueva = daGriFinancieras.CurrentRow.Cells(0).Value.ToString

        EntidadesPublicas.txtCodFinan.Text = codFinancieraNueva
        EntidadesPublicas.txtNomFinan.Text = daGriFinancieras.CurrentRow.Cells(1).Value.ToString
        EntidadesPublicas.txtAbreviatura.Text = daGriFinancieras.CurrentRow.Cells(2).Value.ToString
        Close()
    End Sub
End Class