Imports CapaLogicaNegocios
Public Class lisTerreno
    Dim terrenoDL As New terrenoDL()
    Private codTerreno As String
    Private descripcion As String
    Private idDepa As Integer
    Private idProv As Integer
    Private idDist As Integer

    Public Property descripcionTerreno() As String
        Get
            Return descripcion
        End Get
        Set(ByVal value As String)
            descripcion = value
        End Set
    End Property
    Public Property codigoTerreno() As String
        Get
            Return codTerreno
        End Get
        Set(ByVal value As String)
            codTerreno = value
        End Set
    End Property
    Public Sub New(idDepa As Integer, idProv As Integer, idDist As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.idDepa = idDepa
        Me.idProv = idProv
        Me.idDist = idDist
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub lisTerreno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtTerreno.DataSource = terrenoDL.lisTerreno(idDepa, idProv, idDist)
    End Sub

    Private Sub dtTerreno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtTerreno.CellContentClick
        codigoTerreno = dtTerreno.CurrentRow.Cells(0).Value.ToString
        descripcionTerreno = dtTerreno.CurrentRow.Cells(1).Value.ToString
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim terreno As New terreno()
        terreno.ShowDialog()
        dtTerreno.DataSource = Nothing
        dtTerreno.Columns.Clear()
        dtTerreno.DataSource = terrenoDL.lisTerreno(idDepa, idProv, idDist)
    End Sub
End Class