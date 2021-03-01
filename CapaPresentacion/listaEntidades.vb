Imports CapaLogicaNegocios
Public Class listaEntidades

    Dim entidadDL As New entidadPublica()
    Private ruc As String
    Private ubigeo As String
    Private nombre As String
    Private idDepa As Integer
    Private idProv As Integer
    Private idDist As Integer
    Public Property distrito() As Integer
        Get
            Return idDist
        End Get
        Set(ByVal value As Integer)
            idDist = value
        End Set
    End Property
    Public Property provincia() As Integer
        Get
            Return idProv
        End Get
        Set(ByVal value As Integer)
            idProv = value
        End Set
    End Property
    Public Property departamento() As Integer
        Get
            Return idDepa
        End Get
        Set(ByVal value As Integer)
            idDepa = value
        End Set
    End Property
    Public Property nombreEntidad() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property ubigeoEntidad() As String
        Get
            Return ubigeo
        End Get
        Set(ByVal value As String)
            ubigeo = value
        End Set
    End Property
    Public Property rucEntidad() As String
        Get
            Return ruc
        End Get
        Set(ByVal value As String)
            ruc = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ruc As String, ubigeo As String, nombre As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgEntidades.CellContentClick
        ubigeoEntidad = dtgEntidades.CurrentRow.Cells(0).Value.ToString
        rucEntidad = dtgEntidades.CurrentRow.Cells(1).Value.ToString
        nombreEntidad = dtgEntidades.CurrentRow.Cells(2).Value.ToString
        departamento = dtgEntidades.CurrentRow.Cells(7).Value.ToString
        provincia = dtgEntidades.CurrentRow.Cells(8).Value.ToString
        distrito = dtgEntidades.CurrentRow.Cells(9).Value.ToString

        Close()
    End Sub

    Private Sub listaEntidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgEntidades.DataSource = entidadDL.listEntidad()

    End Sub
End Class