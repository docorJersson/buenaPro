Imports CapaLogicaNegocios
Imports CapaEntidad
Public Class listaCiudadano
    Private ciudadanoDL As New ciudadanoDL

    Private Sub dtCiudadano_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCiudadano.CellContentClick
        EntidadesPublicas.txtIdentidad.Text = dtCiudadano.CurrentRow.Cells(1).Value.ToString.ToUpper
        EntidadesPublicas.txtNomCiudadano.Text = dtCiudadano.CurrentRow.Cells(4).Value.ToString.ToUpper & " " & dtCiudadano.CurrentRow.Cells(3).Value.ToString.ToUpper & " " & dtCiudadano.CurrentRow.Cells(2).Value.ToString.ToUpper
        Close()
        ' EntidadesPublicas.txtNomFinan.Text = daGriFinancieras.CurrentRow.Cells(1).Value.ToString

    End Sub

    Private Sub listaCiudadano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtCiudadano.DataSource = ciudadanoDL.listCiudadano()
    End Sub
End Class