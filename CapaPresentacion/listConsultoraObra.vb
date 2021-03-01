Imports CapaLogicaNegocios
Public Class listConsultoraObra
    Dim consultoraDL As New consultoraObraDL()
    Private ruc As String
    Private nombre As String
    Private representante As String
    Public Property representanteConsultora() As String
        Get
            Return representante
        End Get
        Set(ByVal value As String)
            representante = value
        End Set
    End Property
    Public Property nombreConsultora() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property rucConsultora() As String
        Get
            Return ruc
        End Get
        Set(ByVal value As String)
            ruc = value
        End Set
    End Property
    Private Sub listConsultoraObra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtConsultoraObra.DataSource = consultoraDL.listConsultora()
    End Sub

    Private Sub dtConsultoraObra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtConsultoraObra.CellContentClick
        rucConsultora = dtConsultoraObra.CurrentRow.Cells(0).Value.ToString
        nombreConsultora = dtConsultoraObra.CurrentRow.Cells(1).Value.ToString
        representanteConsultora = dtConsultoraObra.CurrentRow.Cells(2).Value.ToString
        Me.Close()
    End Sub
End Class