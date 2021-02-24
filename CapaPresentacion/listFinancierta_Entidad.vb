Public Class listFinancierta_Entidad
    Public ubigeo As String
    Public codFinanEntidad As Integer
    Private finanDL As New CapaLogicaNegocios.financieraDL()
    Private Sub listFinancierta_Entidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtLisFinanEnti.DataSource = finanDL.listFinEntidad(ubigeo)
    End Sub

    Private Sub dtLisFinanEnti_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtLisFinanEnti.CellContentClick
        codFinanEntidad = dtLisFinanEnti.CurrentRow.Cells(0).Value.ToString

    End Sub
End Class