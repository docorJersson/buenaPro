Public Class estudioTecnicoDE
    Private cConvocatoria As Integer
    Private cExpeTecnico As Integer
    Private idEstudio As Integer
    Private nombre As String
    Private documento As String
    Private fEstudio As Date
    Private fRegistro As Date
    Public Property codExpeTecnico() As Integer
        Get
            Return cExpeTecnico
        End Get
        Set(ByVal value As Integer)
            cExpeTecnico = value
        End Set
    End Property
    Public Property convocatoria() As Integer
        Get
            Return cConvocatoria
        End Get
        Set(ByVal value As Integer)
            cConvocatoria = value
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
    Public Property fechaEstudio() As Date
        Get
            Return fEstudio
        End Get
        Set(ByVal value As Date)
            fEstudio = value
        End Set
    End Property
    Public Property documentoEstudio() As String
        Get
            Return documento
        End Get
        Set(ByVal value As String)
            documento = value
        End Set
    End Property
    Public Property nombreEstudio() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property idEstudioTecnic() As Integer
        Get
            Return idEstudio
        End Get
        Set(ByVal value As Integer)
            idEstudio = value
        End Set
    End Property
End Class
