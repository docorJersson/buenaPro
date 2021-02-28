Public Class listFinancierta_Entidad
    Public ubigeo As String
    Private idFinan_Publica As Integer
    Public Property idFinancieraPublica() As Integer
        Get
            Return idFinan_Publica
        End Get
        Set(ByVal value As Integer)
            idFinan_Publica = value
        End Set
    End Property
    Private codFinanEntidad As String
    Private nombreFinanciera As String
    Private cuenta As String
    Public Property cuentaBancaria() As String
        Get
            Return cuenta
        End Get
        Set(ByVal value As String)
            cuenta = value
        End Set
    End Property
    Public Property nomFinanciera() As String
        Get
            Return nombreFinanciera
        End Get
        Set(ByVal value As String)
            nombreFinanciera = value
        End Set
    End Property

    Public Property codFinanciera() As String
        Get
            Return codFinanEntidad
        End Get
        Set(ByVal value As String)
            codFinanEntidad = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ubigeo As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.ubigeo = ubigeo

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private finanDL As New CapaLogicaNegocios.financieraDL()
    Private Sub listFinancierta_Entidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtLisFinanEnti.DataSource = finanDL.listFinEntidad(ubigeo)
    End Sub

    Private Sub dtLisFinanEnti_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtLisFinanEnti.CellContentClick
        idFinancieraPublica = dtLisFinanEnti.CurrentRow.Cells(0).Value.ToString
        codFinanciera = dtLisFinanEnti.CurrentRow.Cells(1).Value.ToString
        nomFinanciera = dtLisFinanEnti.CurrentRow.Cells(6).Value.ToString
        cuentaBancaria = dtLisFinanEnti.CurrentRow.Cells(3).Value.ToString
        Me.Close()

    End Sub
End Class