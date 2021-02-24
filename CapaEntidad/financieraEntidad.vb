Public Class financieraEntidad
    Private cuenta As String
    Private cuentaInter As String
    Private fApertura As Date
    Private seguro As Boolean
    Private saldo As Double
    Private codFinanciera As String
    Private ruc As String
    Private ubigeo As String
    Public Property ubigeoEntidad() As String
        Get
            Return ubigeo
        End Get
        Set(ByVal value As String)
            ubigeo = value
        End Set
    End Property
    Public Property rucEntidad() As String
        Get
            Return ruc
        End Get
        Set(ByVal value As String)
            ruc = value
        End Set
    End Property
    Public Property codigoFinanciera() As String
        Get
            Return codFinanciera
        End Get
        Set(ByVal value As String)
            codFinanciera = value
        End Set
    End Property
    Public Property saldoCuenta() As Double
        Get
            Return saldo
        End Get
        Set(ByVal value As Double)
            saldo = value
        End Set
    End Property
    Public Property seguroBanco() As Boolean
        Get
            Return seguro
        End Get
        Set(ByVal value As Boolean)
            seguro = value
        End Set
    End Property
    Public Property fechApertura() As Date
        Get
            Return fApertura
        End Get
        Set(ByVal value As Date)
            fApertura = value
        End Set
    End Property
    Public Property cuentaInterbankaria() As String
        Get
            Return cuentaInter
        End Get
        Set(ByVal value As String)
            cuentaInter = value
        End Set
    End Property
    Public Property cuentaBancaria() As String
        Get
            Return cuenta
        End Get
        Set(ByVal value As String)
            cuenta = value
        End Set
    End Property
End Class
