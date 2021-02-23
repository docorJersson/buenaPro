Imports CapaLogicaNegocios
Imports CapaEntidad
Public Class listaCiudadano
    Private ciudadanoDL As New ciudadanoDL

    Private Sub dtCiudadano_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCiudadano.CellContentClick

    End Sub

    Private Sub listaCiudadano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtCiudadano.DataSource = ciudadanoDL.listCiudadano()
    End Sub
End Class