Public Class financieras
    Private m_idCategoria As Integer
    Private m_codeFinanciera As String
    Private m_nombreFinan As String
    Private m_abreviatura As String
    Private m_telefono As String
    Private m_direccion As String
    Private m_idDepa As Integer
    Private m_idProv As Integer
    Public Property provincia() As Integer
        Get
            Return m_idProv
        End Get
        Set(ByVal value As Integer)
            m_idProv = value
        End Set
    End Property
    Public Property departamento() As Integer
        Get
            Return m_idDepa
        End Get
        Set(ByVal value As Integer)
            m_idDepa = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return m_direccion
        End Get
        Set(ByVal value As String)
            m_direccion = value
        End Set
    End Property
    Public Property telefono() As String
        Get
            Return m_telefono
        End Get
        Set(ByVal value As String)
            m_telefono = value
        End Set
    End Property

    Public Property abreviatura() As String
        Get
            Return m_abreviatura
        End Get
        Set(ByVal value As String)
            m_abreviatura = value
        End Set
    End Property
    Public Property nombreFinan() As String
        Get
            Return m_nombreFinan
        End Get
        Set(ByVal value As String)
            m_nombreFinan = value
        End Set
    End Property
    Public Property codeFinanciera() As String
        Get
            Return m_codeFinanciera
        End Get
        Set(ByVal value As String)
            m_codeFinanciera = value
        End Set
    End Property
    Public Property idCategoria() As Integer
        Get
            Return m_idCategoria
        End Get
        Set(ByVal value As Integer)
            m_idCategoria = value
        End Set
    End Property
End Class
