
Public Class funcionarioOSCEDE
    Private cargo As String
    Private codigoFunOSCE As String
    Private nReso As String
    Private nCiudadano As String
    Private emailOSCE As String
    Private fRegistro As Date
    Private fSalida As Date
    Private estado As String
    Private idTiReso As Integer
    Public Property tipoResolucion() As Integer
        Get
            Return idTiReso
        End Get
        Set(ByVal value As Integer)
            idTiReso = value
        End Set
    End Property
    Public Property estadoFun() As String
        Get
            Return estado
        End Get
        Set(ByVal value As String)
            estado = value
        End Set
    End Property
    Public Property fechaSalida() As Date
        Get
            Return fSalida
        End Get
        Set(ByVal value As Date)
            fSalida = value
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


    Public Property correoOSCE() As String
        Get
            Return emailOSCE
        End Get
        Set(ByVal value As String)
            emailOSCE = value
        End Set
    End Property
    Public Property nIdentidad() As String
        Get
            Return nCiudadano
        End Get
        Set(ByVal value As String)
            nCiudadano = value
        End Set
    End Property
    Public Property numResolucion() As String
        Get
            Return nReso
        End Get
        Set(ByVal value As String)
            nReso = value
        End Set
    End Property

    Public Property codFOSCE() As String
        Get
            Return codigoFunOSCE
        End Get
        Set(ByVal value As String)
            codigoFunOSCE = value
        End Set
    End Property
    Public Property desCargo() As String
        Get
            Return cargo
        End Get
        Set(ByVal value As String)
            cargo = value
        End Set
    End Property
End Class
