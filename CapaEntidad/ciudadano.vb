Public Class ciudadano
    Private m_tipoIdentidad As String
    Private m_numIdentidad As String
    Private m_aPaterno As String
    Private m_aMaterno As String
    Private m_nombres As String
    Private m_sexo As String
    Private m_telefono As String
    Private m_email As String
    Public Property nombresy() As String
        Get
            Return m_nombres
        End Get
        Set(ByVal value As String)
            m_nombres = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return m_email
        End Get
        Set(ByVal value As String)
            m_email = value
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
    Public Property sexo() As String
        Get
            Return m_sexo
        End Get
        Set(ByVal value As String)
            m_sexo = value
        End Set
    End Property
    Public Property aMaterno() As String
        Get
            Return m_aMaterno
        End Get
        Set(ByVal value As String)
            m_aMaterno = value
        End Set
    End Property
    Public Property aPaterno() As String
        Get
            Return m_aPaterno
        End Get
        Set(ByVal value As String)
            m_aPaterno = value
        End Set
    End Property
    Public Property numIdentidad() As String
        Get
            Return m_numIdentidad
        End Get
        Set(ByVal value As String)
            m_numIdentidad = value
        End Set
    End Property
    Public Property tipoEntidad() As String
        Get
            Return m_tipoIdentidad
        End Get
        Set(ByVal value As String)
            m_tipoIdentidad = value
        End Set
    End Property
End Class
