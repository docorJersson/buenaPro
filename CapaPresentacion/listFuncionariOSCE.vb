Imports CapaLogicaNegocios
Public Class listFuncionariOSCE
    Dim funcOSCEDL As New funcionarioOSCEDL()
    Private codigo As String
    Private resolucion As String
    Private nombre As String
    Public Property nombreFunOSCE() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property resoFunOSCE() As String
        Get
            Return resolucion
        End Get
        Set(ByVal value As String)
            resolucion = value
        End Set
    End Property
    Public Property codigoFunOSCE() As String
        Get
            Return codigo
        End Get
        Set(ByVal value As String)
            codigo = value
        End Set
    End Property
    Private Sub listFuncionariOSCE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFuncOsce.DataSource = funcOSCEDL.listFunOsce()
    End Sub

    Private Sub dtFuncOsce_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtFuncOsce.CellContentClick
        codigoFunOSCE = dtFuncOsce.CurrentRow.Cells(2).Value.ToString
        resoFunOSCE = dtFuncOsce.CurrentRow.Cells(3).Value.ToString
        nombreFunOSCE = dtFuncOsce.CurrentRow.Cells(0).Value.ToString.ToUpper
        Me.Close()
    End Sub
End Class