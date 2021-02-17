Public Class Contribuyente
    Private idContribuyente
    Private contribuyente
    Private abreviatura
    Private maxImpuesto
    Private minImpuesto

    Public Property _idContribuyente As Integer
        Get
            Return idContribuyente
        End Get
        Set(value As Integer)
            idContribuyente = value
        End Set
    End Property

    Public Property _contribuyente As String
        Get
            Return contribuyente
        End Get
        Set(value As String)
            contribuyente = value
        End Set
    End Property

    Public Property _abreviatura As String
        Get
            Return abreviatura
        End Get
        Set(value As String)
            abreviatura = value
        End Set
    End Property

    Public Property _maxImpuesto As Decimal
        Get
            Return maxImpuesto
        End Get
        Set(value As Decimal)
            maxImpuesto = value
        End Set
    End Property

    Public Property _minImpuesto As Decimal
        Get
            Return minImpuesto
        End Get
        Set(value As Decimal)
            minImpuesto = value
        End Set
    End Property
End Class
