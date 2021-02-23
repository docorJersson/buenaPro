Public Class EntidadesPublicas
    Private codDepa As Integer
    Private codProv As Integer
    Private codDis As Integer

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged

    End Sub

    Private Sub EntidadesPublicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As DataTable
        table = CapaAccesoDatos.listCheckBox.lisDep()
        cboDepar.DisplayMember = "departamento"
        cboDepar.ValueMember = "idDepa"
        cboDepar.DataSource = table
        cboDepar.Text = "Seleccione"
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged

        cboDistrito.Text = ""

        codProv = cboProvincia.SelectedValue.ToString
        Dim table As DataTable

        table = CapaAccesoDatos.listCheckBox.listDist(codProv)
        cboDistrito.DisplayMember = "distrito"
        cboDistrito.ValueMember = "idDist"
        cboDistrito.DataSource = table
        cboDistrito.Text = "Seleccione"

    End Sub

    Private Sub cboDistrito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDistrito.SelectedIndexChanged
        codDis = cboDistrito.SelectedValue.ToString
    End Sub

    Private Sub cboDepar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepar.SelectedIndexChanged
        cboProvincia.Text = ""

        codDepa = cboDepar.SelectedValue.ToString
        Dim table As DataTable

        table = CapaAccesoDatos.listCheckBox.lisProv(codDepa)
        cboProvincia.DisplayMember = "provincia"
        cboProvincia.ValueMember = "idProv"
        cboProvincia.DataSource = table
        cboProvincia.Text = "Seleccione"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim lisFinancier As listaFinancieras
        listaFinancieras.Show()

    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim codFinan As String
        Dim cuenta As String
        Dim interbankario As String
        Dim saldo As Double
        Dim seguro As Boolean

        If ckSeguro.Checked = True Then
            seguro = True
        Else
            seguro = False
        End If

        codFinan = txtCodFinan.Text.ToString
        cuenta = txtCuenta.Text.ToString
        interbankario = txtInterbankario.Text.ToString
        saldo = txtSaldo.Text.ToString

        Dim entFina As ListViewItem
        entFina = New ListViewItem(codFinan)
        entFina.SubItems.Add(txtNomFinan.Text)
        entFina.SubItems.Add(cuenta)
        entFina.SubItems.Add(interbankario)
        entFina.SubItems.Add(seguro.ToString)
        listFinanciera.Items.Add(entFina)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class