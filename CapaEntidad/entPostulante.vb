Imports CapaEntidad

Public Class entPostulante
#Region "Atributos"
    Private iPostulante As Char
    Private cConvocatoria As convocatoriaPublicaDE
    Private rucProveedor As Proveedor
    Private fRegistro As Date
    Private fPresentacion As Date
    Private estadoRegistro As Boolean
    Private estadoPropuesta As Boolean
    Private observacion As String
    Private justificacion As String
    Private documentoOferta As String
#End Region

#Region "Propiedades"
    Public Property _iPostulante As Char
        Get
            Return iPostulante
        End Get
        Set(value As Char)
            iPostulante = value
        End Set
    End Property

    Public Property _CConvocatoria As convocatoriaPublicaDE
        Get
            Return cConvocatoria
        End Get
        Set(value As convocatoriaPublicaDE)
            cConvocatoria = value
        End Set
    End Property

    Public Property _RucProveedor As Proveedor
        Get
            Return rucProveedor
        End Get
        Set(value As Proveedor)
            rucProveedor = value
        End Set
    End Property

    Public Property _FRegistro As Date
        Get
            Return fRegistro
        End Get
        Set(value As Date)
            fRegistro = value
        End Set
    End Property

    Public Property _FPresentacion_ As Date
        Get
            Return fPresentacion
        End Get
        Set(value As Date)
            fPresentacion = value
        End Set
    End Property

    Public Property _EstadoRegistro1 As Boolean
        Get
            Return estadoRegistro
        End Get
        Set(value As Boolean)
            estadoRegistro = value
        End Set
    End Property

    Public Property _EstadoPropuesta As Boolean
        Get
            Return estadoPropuesta
        End Get
        Set(value As Boolean)
            estadoPropuesta = value
        End Set
    End Property

    Public Property _Observacion As String
        Get
            Return observacion
        End Get
        Set(value As String)
            observacion = value
        End Set
    End Property

    Public Property _Justificacion As String
        Get
            Return justificacion
        End Get
        Set(value As String)
            justificacion = value
        End Set
    End Property

    Public Property _DocumentoOferta As String
        Get
            Return documentoOferta
        End Get
        Set(value As String)
            documentoOferta = value
        End Set
    End Property
End Class
#End Region
