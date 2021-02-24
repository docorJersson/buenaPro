Public Class session
    Private Shared _Session As session
    Private Shared ReadOnly _lock As Object = New Object()
    Public Shared ReadOnly _OK = "OK"
    Public Shared ReadOnly _ERROR = "ERROR"

    Private _login As String
    Private _tipo As String
    Private _Estado As String
    Private Sub New()
        _Estado = "ERROR"
    End Sub
    Public Function Estado() As String
        Return _Estado
    End Function
    Public Function IsAdministrador() As Boolean
        If _tipo = "Funcionario-OSCE" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub setSession(_user As CapaEntidad.entUser)
        If _user IsNot Nothing Then
            Me._login = _user._nameUser
            Me._tipo = _user._rol
            _Estado = "OK"
        Else
            _Estado = "ERROR"
        End If
    End Sub
    Public Shared Sub Close()
        _Session = Nothing
    End Sub
    Public Shared ReadOnly Property Instance() As session
        Get
            SyncLock _lock
                If (_Session Is Nothing) Then
                    _Session = New session()
                End If
            End SyncLock
            Return _Session
        End Get

    End Property
    Public Function getTipo() As String
        Return Me._tipo
    End Function
    Public Function getUser() As String
        Return _login
    End Function
End Class
