Public Class Contribuyente
#Region "Atributos"
    Private idContribuyente As Integer
    Private contribuyente As String
    Private abreviatura As String
    Private maxImpuesto As Double
    Private minImpuesto As Double
#End Region

#Region "Propiedades"
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

    Public Property _maxImpuesto As Double
        Get
            Return maxImpuesto
        End Get
        Set(value As Double)
            maxImpuesto = value
        End Set
    End Property

    Public Property _minImpuesto As Double
        Get
            Return minImpuesto
        End Get
        Set(value As Double)
            minImpuesto = value
        End Set
    End Property
#End Region
End Class
