Public Class Proveedor
    Private rucProveedor As String
    Private proveedor As String
    Private consorcio As Boolean
    Private telefono As String
    Private email As String
    Private cCEASE As String
    Private RNP As Boolean
    Private estadoProveedor As Boolean
    Private condicion As String
    Public objEntidadContri As Contribuyente

    Public Property _rucProveedor As Char
        Get
            Return rucProveedor
        End Get
        Set(value As Char)
            rucProveedor = value
        End Set
    End Property

    Public Property _proveedor As String
        Get
            Return proveedor
        End Get
        Set(value As String)
            proveedor = value
        End Set
    End Property

    Public Property _consorcio As Boolean
        Get
            Return consorcio
        End Get
        Set(value As Boolean)
            consorcio = value
        End Set
    End Property

    Public Property _telefono As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property _email As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property _cCEASE As Char
        Get
            Return cCEASE
        End Get
        Set(value As Char)
            cCEASE = value
        End Set
    End Property

    Public Property _RNP As Boolean
        Get
            Return RNP
        End Get
        Set(value As Boolean)
            RNP = value
        End Set
    End Property

    Public Property _estadoProveedor As Boolean
        Get
            Return estadoProveedor
        End Get
        Set(value As Boolean)
            estadoProveedor = value
        End Set
    End Property

    Public Property _condicion As String
        Get
            Return condicion
        End Get
        Set(value As String)
            condicion = value
        End Set
    End Property

    Public Sub New()
        objEntidadContri = New Contribuyente
    End Sub
End Class
