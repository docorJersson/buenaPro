Public Class Postulantes
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles descConvocatoria.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim iPostulante As String
        Dim cConvocatoria As Integer
        Dim rucProveedor As String
        Dim fPresentacion As Date
        Dim observacion As String
        Dim justificacion As String
        Dim documentoOferta As String

        iPostulante = txtpostulante.Text.ToString
        cConvocatoria = txtnconvocatoria.Text.ToString
        rucProveedor = txtrucProv.Text.ToString
        fPresentacion = fpresent.Value.Date
        observacion = txtobser.Text.ToString
        justificacion = txtjust.Text.ToString
        documentoOferta = txtdoc.Text.ToString
        Try
            CapaAccesoDatos.datPostulante.insertPostulante(iPostulante, cConvocatoria, rucProveedor, fPresentacion, observacion, justificacion, documentoOferta)
            MessageBox.Show("Datos Registrados Exitosamente!!!")
            txtpostulante.Text = ""
            txtnconvocatoria.Text = ""
            txtrucProv.Text = ""
            fpresent.Text = ""
            txtobser.Text = ""
            txtjust.Text = ""
            txtdoc.Text = ""

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        listProveedor.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        listConvocatorias.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
    End Sub
End Class