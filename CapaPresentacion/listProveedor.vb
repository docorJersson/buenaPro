Imports CapaLogicaNegocios

Public Class listProveedor

    Private proveedor As New NegProveedor

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtproveed.CellContentClick
        Postulantes.txtrucProv.Text = dtproveed.CurrentRow.Cells(0).Value.ToString.ToUpper
        Postulantes.txtnomProvee.Text = dtproveed.CurrentRow.Cells(1).Value.ToString.ToUpper
        Postulantes.checkConsorcio.Checked = dtproveed.CurrentRow.Cells(2).Value.ToString.ToUpper
        Postulantes.txtContribuyente.Text = dtproveed.CurrentRow.Cells(3).Value.ToString.ToUpper
        Postulantes.txtcease.Text = dtproveed.CurrentRow.Cells(4).Value.ToString.ToUpper
        Postulantes.txtnintegrante.Text = dtproveed.CurrentRow.Cells(5).Value.ToString.ToUpper
        Postulantes.txtdepa.Text = dtproveed.CurrentRow.Cells(6).Value.ToString.ToUpper
        Dispose()

    End Sub

    Private Sub listProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtproveed.DataSource = proveedor.listProveedores
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub
End Class