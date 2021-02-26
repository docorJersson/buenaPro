Imports CapaLogicaNegocios
Public Class listaEntidades

    Dim entidadDL As New entidadPublica()
    Private ruc As String
    Private ubigeo As String
    Private nombre As String
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
        Dim listen As New Convocatoria()
        listen.ubigeo = dtgEntidades.CurrentRow.Cells(0).Value.ToString
        listen.r = dtgEntidades.CurrentRow.Cells(1).Value.ToString
        nombreEntidad = dtgEntidades.CurrentRow.Cells(2).Value.ToString
        Console.WriteLine("LIST" + ubigeoEntidad + rucEntidad + nombreEntidad)
        Close()
        Console.WriteLine("LISTdfg")

    End Sub

    Private Sub listaEntidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgEntidades.DataSource = entidadDL.listEntidad()

    End Sub
End Class