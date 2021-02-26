Public Class frmPrincipal
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Postulantes.Show()
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        Convocatoria.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        listProveedor.Show()
    End Sub
End Class