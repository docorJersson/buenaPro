Public Class terrenoDE
    Private codigo As String
    Private descripcion As String
    Private direccion As String
    Private largo As Double
    Private ancho As Double
    Private fRegistro As Date
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
    Public Property fechaRegistro() As Date
        Get
            Return fRegistro
        End Get
        Set(ByVal value As Date)
            fRegistro = value
        End Set
    End Property
    Public Property metroAncho() As Double
        Get
            Return ancho
        End Get
        Set(ByVal value As Double)
            ancho = value
        End Set
    End Property
    Public Property metroLargo() As Double
        Get
            Return largo
        End Get
        Set(ByVal value As Double)
            largo = value
        End Set
    End Property
    Public Property direccionTerreno() As String
        Get
            Return direccion
        End Get
        Set(ByVal value As String)
            direccion = value
        End Set
    End Property

    Public Property descripcionTerreno() As String
        Get
            Return descripcion
        End Get
        Set(ByVal value As String)
            descripcion = value
        End Set
    End Property

    Public Property codTerreno() As String
        Get
            Return codigo
        End Get
        Set(ByVal value As String)
            codigo = value
        End Set
    End Property
End Class
