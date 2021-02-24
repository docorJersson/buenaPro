Public Class entidadPublica
    Private ruc As String
    Private ubigeo As String
    Private nombreEntidad As String
    Private idDepa As Integer
    Private idProv As Integer
    Private idDist As Integer
    Private direccion As String
    Private pagina As String
    Private telefono As String
    Private email As String
    Private financieraPublica As List(Of financieraEntidad)
    Private funcionarios As List(Of funcionarioEntidad)
    Public Property entidadFuncionario() As List(Of funcionarioEntidad)
        Get
            Return funcionarios
        End Get
        Set(ByVal value As List(Of funcionarioEntidad))
            funcionarios = value
        End Set
    End Property
    Public Property fin_Entidad() As List(Of financieraEntidad)
        Get
            Return financieraPublica
        End Get
        Set(ByVal value As List(Of financieraEntidad))
            financieraPublica = value
        End Set
    End Property
    Public Property emailEntidad() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property
    Public Property entidadTelefono() As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
        End Set
    End Property
    Public Property paginaWeb() As String
        Get
            Return pagina
        End Get
        Set(ByVal value As String)
            pagina = value
        End Set
    End Property
    Public Property direccionEntidad() As String
        Get
            Return direccion
        End Get
        Set(ByVal value As String)
            direccion = value
        End Set
    End Property
    Public Property distrito() As Integer
        Get
            Return idDist
        End Get
        Set(ByVal value As Integer)
            idDist = value
        End Set
    End Property
    Public Property provincia() As Integer
        Get
            Return idProv
        End Get
        Set(ByVal value As Integer)
            idProv = value
        End Set
    End Property
    Public Property departamento() As Integer
        Get
            Return idDepa
        End Get
        Set(ByVal value As Integer)
            idDepa = value
        End Set
    End Property
    Public Property entidadaNombre() As String
        Get
            Return nombreEntidad
        End Get
        Set(ByVal value As String)
            nombreEntidad = value
        End Set
    End Property
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
End Class
