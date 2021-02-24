Public Class cronogramaDE
    Private cConvocatoria As Integer
    Private idFinaPu As Integer
    Private fInicio As Date
    Private fFin As Date
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
    Public Property financieraEntidad() As Integer
        Get
            Return idFinaPu
        End Get
        Set(ByVal value As Integer)
            idFinaPu = value
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
