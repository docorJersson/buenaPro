Public Class convocatoriaPublicaDE
    Private cConvocatoria As Integer
    Private funOSCE As funcionarioOSCEDE
    Private nConvocatoria As Integer
    Private tSeleccion As String
    Private normativa As String
    Private nomenclatura As String
    Public Property nomenclaturaConvo() As String
        Get
            Return nomenclatura
        End Get
        Set(ByVal value As String)
            nomenclatura = value
        End Set
    End Property
    Private vSEACE As String
    Private idModo As Integer
    Private desConvocatoria As String
    Private ctParticipacion As Double
    Private moneda As String
    Private cBases As Double
    Private fPublicacion As Date
    Private entidadPublica As entidadPublica
    Private idFinanPublica As Integer
    Private cronograma As List(Of cronogramaDE)
    Public Property entidadConvocante() As entidadPublica
        Get
            Return entidadPublica
        End Get
        Set(ByVal value As entidadPublica)
            entidadPublica = value
        End Set
    End Property
    Public Property funcionarioOSCE() As funcionarioOSCEDE
        Get
            Return funOSCE
        End Get
        Set(ByVal value As funcionarioOSCEDE)
            funOSCE = value
        End Set
    End Property
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

    Public Property codigoConvocatoria() As Integer
        Get
            Return cConvocatoria
        End Get
        Set(ByVal value As Integer)
            cConvocatoria = value
        End Set
    End Property
End Class
