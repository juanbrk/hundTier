Public Class CombosService
    Private combDao As CombosDAO

    Public Sub New()
        combDao = New CombosDAO
    End Sub

    Public Function getBarrios() As DataTable
        Return combDao.cargarBarrios()
    End Function

End Class
