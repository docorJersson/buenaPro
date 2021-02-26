Public Class listConvocatorias
    Private datconvocatoria As New CapaAccesoDatos.convocatoria
    Private Sub CANCELAR_Click(sender As Object, e As EventArgs) Handles CANCELAR.Click
        Dispose()
    End Sub

    Private Sub listConvocatorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtconvocatoria.DataSource = datconvocatoria.getConvocatorias
    End Sub

    Private Sub dtconvocatoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtconvocatoria.CellContentClick
        Postulantes.txtnconvocatoria.Text = dtconvocatoria.CurrentRow.Cells(0).Value.ToString.ToUpper
        Postulantes.descConvocatoria.Text = dtconvocatoria.CurrentRow.Cells(1).Value.ToString.ToUpper
        Postulantes.txtpresupuesto.Text = dtconvocatoria.CurrentRow.Cells(2).Value.ToString.ToUpper
        Postulantes.txtpart.Text = dtconvocatoria.CurrentRow.Cells(3).Value.ToString.ToUpper
        Postulantes.txtbase.Text = dtconvocatoria.CurrentRow.Cells(4).Value.ToString.ToUpper
        Postulantes.txtentiConvocante.Text = dtconvocatoria.CurrentRow.Cells(5).Value.ToString.ToUpper
        Postulantes.txtConvoDepa.Text = dtconvocatoria.CurrentRow.Cells(6).Value.ToString.ToUpper
        Dispose()
    End Sub
End Class