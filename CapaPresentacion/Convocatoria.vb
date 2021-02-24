Imports CapaLogicaNegocios
Imports CapaEntidad
Public Class Convocatoria
    Dim finanFl As New financieraDL()
    Dim listboxDL As New listBoxDL()
    Dim convoDL As New convocatoriaDL()
    Dim user As New negLogin()
    Dim funOSCEDL As New funcionarioOSCEDL()
    Dim newConvocatoria As convocatoriaPublicaDE
    Dim funOSCEAccion As funcionarioOSCEDE
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnConvocatoria.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Convocatoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles pnCronograma.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        newConvocatoria = New convocatoriaPublicaDE()
        Dim code As String
        code = user.accionUser(session.Instance.getUser(), session.Instance.getTipo())
        funOSCEAccion = funOSCEDL.buscarCodigo(code)
        newConvocatoria.funOSCE = funOSCEAccion.codFOSCE.ToString
        newConvocatoria.resoFunciOSCE = funOSCEAccion.numResolucion.ToString


        Dim table As DataTable
        table = listboxDL.listResolucion()
        cboProcedimiento.DisplayMember = "procedimiento"
        cboProcedimiento.ValueMember = "idProcedimiento"
        cboProcedimiento.DataSource = table
        cboProcedimiento.Text = "Seleccione"
    End Sub

    Private Sub cboGenerar_CheckedChanged(sender As Object, e As EventArgs) Handles ckGenerar.CheckedChanged
        If ckGenerar.Checked = True Then
            pnCronograma.Enabled = False
            Dim table As DataTable = convoDL.bocetoCronograma()
            Try
                For Each row As DataRow In table.Rows
                    Dim crono As ListViewItem
                    crono = New ListViewItem(Trim(row("procedimiento")))
                    crono.SubItems.Add((row("fInicio").ToString()))
                    crono.SubItems.Add((row("fFin").ToString()))
                    lstCronograma.Items.Add(crono)
                Next

            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
        Else
            pnCronograma.Enabled = True
            lstCronograma.Items.Clear()
        End If

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class