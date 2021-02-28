Public Class aprobacionPublicaDE
    Private cConvocatoria As Integer
    Private cExpediente As Integer
    Private cAprobacion As String
    Private tDocumento As String
    Private fAprobacion As Date
    Private documento As String
    Private area As String
    Private plazObra As Integer
    Private funOSCE As funcionarioOSCEDE
    Public Property funcionariOSCE() As funcionarioOSCEDE
        Get
            Return funOSCE
        End Get
        Set(ByVal value As funcionarioOSCEDE)
            funOSCE = value
        End Set
    End Property
    Public Property plazoObra() As Integer
        Get
            Return plazObra
        End Get
        Set(ByVal value As Integer)
            plazObra = value
        End Set
    End Property
    Public Property areaElaboracion() As String
        Get
            Return area
        End Get
        Set(ByVal value As String)
            area = value
        End Set
    End Property
    Public Property documentoAprobacion() As String
        Get
            Return documento
        End Get
        Set(ByVal value As String)
            documento = value
        End Set
    End Property
    Public Property fechaAprobacion() As Date
        Get
            Return fAprobacion
        End Get
        Set(ByVal value As Date)
            fAprobacion = value
        End Set
    End Property
    Public Property tipoDocumento() As String
        Get
            Return tDocumento
        End Get
        Set(ByVal value As String)
            tDocumento = value
        End Set
    End Property
    Public Property codigoAprobacion() As String
        Get
            Return cAprobacion
        End Get
        Set(ByVal value As String)
            cAprobacion = value
        End Set
    End Property
    Public Property expedienTecnico() As Integer
        Get
            Return cExpediente
        End Get
        Set(ByVal value As Integer)
            cExpediente = value
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
End Class
