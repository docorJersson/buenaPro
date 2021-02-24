Public Class funcionarioEntidad
    Private codigo As String
    Private nResolucion As String
    Private cargo As String
    Private email As String
    Private fResolucion As Date
    Private ubigeo As String
    Private ruc As String
    Private estado As Boolean
    Private idReso As Integer
    Private nIdentidad As String
    Public Property identidadCiudadano() As String
        Get
            Return nIdentidad
        End Get
        Set(ByVal value As String)
            nIdentidad = value
        End Set
    End Property
    Public Property idResolucion() As Integer
        Get
            Return idReso
        End Get
        Set(ByVal value As Integer)
            idReso = value
        End Set
    End Property

    Public Property estadoFun() As Boolean
        Get
            Return estado
        End Get
        Set(ByVal value As Boolean)
            estado = value
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
    Public Property ubigeoEntidad() As String
        Get
            Return ubigeo
        End Get
        Set(ByVal value As String)
            ubigeo = value
        End Set
    End Property
    Public Property fechaResolucion() As Date
        Get
            Return fResolucion
        End Get
        Set(ByVal value As Date)
            fResolucion = value
        End Set
    End Property
    Public Property emailEnt() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property
    Public Property cargoFun() As String
        Get
            Return cargo
        End Get
        Set(ByVal value As String)
            cargo = value
        End Set
    End Property
    Public Property resoFun() As String
        Get
            Return nResolucion
        End Get
        Set(ByVal value As String)
            nResolucion = value
        End Set
    End Property
    Public Property codigoFun() As String
        Get
            Return codigo
        End Get
        Set(ByVal value As String)
            codigo = value
        End Set
    End Property
End Class
