﻿Public Class frmPrincipal
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Postulantes.Show()
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        Convocatoria.Show()
    End Sub

<<<<<<< HEAD
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        listProveedor.Show()
=======
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rol As String
        rol = session.Instance.getTipo()
        Select Case rol
            Case "Funcionario-OSCE"

            Case "Funcionario-Entidad"
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
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
>>>>>>> 4869a9f283d7d43acb9646fc531d9cb9c3c654b4
    End Sub
End Class