﻿Imports CapaAccesoDatos
Public Class listBoxDL
    Private aD As New listCheckBox()
    Public Function listResolucion() As DataTable
        Return aD.listResolucion
    End Function
    Public Function listProcedimiento() As DataTable
        Return aD.listProcedimiento()
    End Function

End Class
