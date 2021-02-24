Public Class convocatoriaPublicaDE
    Private cConvocatoria As Integer
    Private nIdentidad As String
    Private nResoOSCE As String
    Private nConvocatoria As Integer
    Private tSeleccion As String
    Private normativa As String
    Private vSEACE As String
    Private idModo As Integer
    Private desConvocatoria As String
    Private ctParticipacion As Double
    Private moneda As String
    Private cBases As Double
    Private fPublicacion As Date
    Private ubigeo As String
    Private ruc As String
    Private idFinanPublica As Integer
    Private cronograma As List(Of cronogramaDE)
    Public Property cronogramaConvoatoria() As List(Of cronogramaDE)
        Get
            Return cronograma
        End Get
        Set(ByVal value As List(Of cronogramaDE))
            cronograma = value
        End Set
    End Property
    Public Property financieraPublica() As Integer
        Get
            Return idFinanPublica
        End Get
        Set(ByVal value As Integer)
            idFinanPublica = value
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
    Public Property fechaPublicacion() As Date
        Get
            Return fPublicacion
        End Get
        Set(ByVal value As Date)
            fPublicacion = value
        End Set
    End Property
    Public Property costoBases() As Double
        Get
            Return cBases
        End Get
        Set(ByVal value As Double)
            cBases = value
        End Set
    End Property
    Public Property tipoMoneda() As String
        Get
            Return moneda
        End Get
        Set(ByVal value As String)
            moneda = value
        End Set
    End Property
    Public Property costoParticipacion() As Double
        Get
            Return ctParticipacion
        End Get
        Set(ByVal value As Double)
            ctParticipacion = value
        End Set
    End Property
    Public Property descripcionConvocatoria() As String
        Get
            Return desConvocatoria
        End Get
        Set(ByVal value As String)
            desConvocatoria = value
        End Set
    End Property
    Public Property modoConvocatoria() As Integer
        Get
            Return idModo
        End Get
        Set(ByVal value As Integer)
            idModo = value
        End Set
    End Property
    Public Property versionSEACE() As String
        Get
            Return vSEACE
        End Get
        Set(ByVal value As String)
            vSEACE = value
        End Set
    End Property
    Public Property normaConvocatoria() As String
        Get
            Return normativa
        End Get
        Set(ByVal value As String)
            normativa = value
        End Set
    End Property
    Public Property tipoSeleccion() As String
        Get
            Return tSeleccion
        End Get
        Set(ByVal value As String)
            tSeleccion = value
        End Set
    End Property
    Public Property numeroConvocatoria() As Integer
        Get
            Return nConvocatoria
        End Get
        Set(ByVal value As Integer)
            nConvocatoria = value
        End Set
    End Property
    Public Property resoFunciOSCE() As String
        Get
            Return nResoOSCE
        End Get
        Set(ByVal value As String)
            nResoOSCE = value
        End Set
    End Property
    Public Property funOSCE() As String
        Get
            Return nIdentidad
        End Get
        Set(ByVal value As String)
            nIdentidad = value
        End Set
    End Property
    Public Property codigoConvocatoria() As Integer
        Get
            Return cConvocatoria
        End Get
        Set(ByVal value As Integer)
            cConvocatoria = value
        End Set
    End Property
End Class
