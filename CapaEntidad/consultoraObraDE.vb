Public Class consultoraObraDE
    Private rucConsultora As String
    Private nombre As String
    Private representante As String
    Private direccion As String
    Private idDepa As Integer
    Private telefono As String
    Private fax As String
    Private email As String
    Private objetoContra As String
    Private web As String
    Private fInicio As Date
    Private fFin As Date
    Private estado As Boolean
    Public Property estadoConsultora() As Boolean
        Get
            Return estado
        End Get
        Set(ByVal value As Boolean)
            estado = value
        End Set
    End Property
    Public Property fechaFin() As Date
        Get
            Return fFin
        End Get
        Set(ByVal value As Date)
            fFin = value
        End Set
    End Property
    Public Property fechaInicio() As Date
        Get
            Return fInicio
        End Get
        Set(ByVal value As Date)
            fInicio = value
        End Set
    End Property
    Public Property webCosultora() As String
        Get
            Return web
        End Get
        Set(ByVal value As String)
            web = value
        End Set
    End Property
    Public Property objetoContratacion() As String
        Get
            Return objetoContra
        End Get
        Set(ByVal value As String)
            objetoContra = value
        End Set
    End Property
    Public Property emailConsultora() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property
    Public Property faxConsultora() As String
        Get
            Return fax
        End Get
        Set(ByVal value As String)
            fax = value
        End Set
    End Property
    Public Property telefonoConsultora() As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
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
    Public Property direccionConsultora() As String
        Get
            Return direccion
        End Get
        Set(ByVal value As String)
            direccion = value
        End Set
    End Property
    Public Property representanteConsultoria() As String
        Get
            Return representante
        End Get
        Set(ByVal value As String)
            representante = value
        End Set
    End Property
    Public Property nombreConsultora() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property rucConsultoraObra() As String
        Get
            Return rucConsultora
        End Get
        Set(ByVal value As String)
            rucConsultora = value
        End Set
    End Property
End Class
