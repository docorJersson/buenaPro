Public Class Ciudadano
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSexo.Text = "Seleccione"
        cboTipoDoc.Text = "Seleccione"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tipoDoc As String
        Dim numDoc As String
        Dim apePaterno As String
        Dim apaMeterno As String
        Dim nombres As String
        Dim sexo As String
        Dim telefono As String
        Dim email As String

        tipoDoc = cboTipoDoc.SelectedItem.ToString.ToUpper
        numDoc = txtNumDoc.Text.ToString
        apePaterno = txtApePaterno.Text.ToString.ToUpper
        apaMeterno = txtApeMaterno.Text.ToString.ToUpper
        nombres = txtNombre.Text.ToString.ToUpper
        sexo = cboSexo.SelectedItem.ToString.ToUpper
        telefono = txtTelefono.Text.ToString
        email = txtEmail.Text.ToString
        Try
            CapaAccesoDatos.ciudadanoDA.insertCiudadano(tipoDoc, numDoc, apePaterno, apaMeterno, nombres, sexo, telefono, email)
            MessageBox.Show("Datos Registrados Exitosamente")
            cboTipoDoc.Text = ""
            txtNumDoc.Text = ""
            txtApePaterno.Text = ""
            txtApeMaterno.Text = ""
            txtNombre.Text = ""
            cboSexo.Text = ""
            txtTelefono.Text = ""
            txtEmail.Text = ""

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub cboTipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDoc.SelectedIndexChanged

    End Sub
End Class