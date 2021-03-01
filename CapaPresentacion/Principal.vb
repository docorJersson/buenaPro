Public Class frmPrincipal
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Postulantes.Show()
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        Convocatoria.Show()
    End Sub


    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rol As String
        rol = session.Instance.getTipo()
        Select Case rol
            Case "Funcionario-OSCE"

            Case "Funcionario-Entidad"
                AdicionalesToolStripMenuItem.Visible = False
                menConsultoras.Visible = False
                menContratista.Visible = False
                menContratos.Visible = False
                menConvocatorias.Visible = False
                menOSCE.Visible = False
                menProcedimiento.Visible = False
            Case "Proveedor"
        End Select

    End Sub

    Private Sub AgregarMunicipalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarMunicipalidadToolStripMenuItem.Click
        EntidadesPublicas.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
        Login.Show()
        Login.BringToFront()

    End Sub
End Class