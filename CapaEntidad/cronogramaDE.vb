Public Class cronogramaDE
    Private cConvocatoria As Integer
    Private idProcedimiento As Integer
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
    Public Property codigoProcedimiento() As Integer
        Get
            Return idProcedimiento
        End Get
        Set(ByVal value As Integer)
            idProcedimiento = value
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
