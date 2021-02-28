Public Class terrenoExpedienteDE
    Private terreno As terrenoDE
    Private observacion As String
    Private fRegistro As Date
    Public Property fechaRegistro() As Date
        Get
            Return fRegistro
        End Get
        Set(ByVal value As Date)
            fRegistro = value
        End Set
    End Property
    Public Property observacionTerreno() As String
        Get
            Return observacion
        End Get
        Set(ByVal value As String)
            observacion = value
        End Set
    End Property
    Public Property terrenoExpe() As terrenoDE
        Get
            Return terreno
        End Get
        Set(ByVal value As terrenoDE)
            terreno = value
        End Set
    End Property
End Class
