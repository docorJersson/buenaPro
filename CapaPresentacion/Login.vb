Imports CapaEntidad
Imports CapaLogicaNegocios

Public Class Login
    Private usuario As New negLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsuario.Text <> "" And txtPassword.Text <> "" Then
            Dim user As entUser
            user = usuario.Login(txtUsuario.Text, txtPassword.Text)
            session.Instance.setSession(user)
            If session.Instance.Estado = session._OK Then
                Me.Hide()
                Dim frmprincipal As New frmPrincipal()
                frmprincipal.Show()
                MessageBox.Show("Bienvenido al Sistema!!")
            Else
                MessageBox.Show("Los datos ingresados son incorrectos")
                txtUsuario.Text = ""
                txtPassword.Text = ""
            End If
            session.Instance.getTipo()
        Else
            MessageBox.Show("Datos no ingresados")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
