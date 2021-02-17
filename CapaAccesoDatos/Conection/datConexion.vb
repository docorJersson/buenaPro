Imports System.Data.SqlClient

Public Class datConexion
    Private Shared conection As datConexion
    Private Shared ReadOnly _lock As Object = New Object()
    Private myconection As SqlConnection

    Private Sub New()
        Me.myconection = New SqlConnection("Data Source=LAPTOP-87F930TD;Initial Catalog=BD_BUENAPRO;Integrated Security=True")
    End Sub

    Friend Function ObtenerConexion() As IDisposable
        Throw New NotImplementedException()
    End Function

    Public Shared ReadOnly Property Instance() As datConexion
        Get
            SyncLock _lock
                If (conection Is Nothing) Then
                    conection = New datConexion()
                End If
            End SyncLock

            Return conection
        End Get

    End Property

    Public Function GetConexion() As SqlConnection
        Return Me.myconection
    End Function

End Class
