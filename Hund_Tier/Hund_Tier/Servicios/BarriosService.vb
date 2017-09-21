Public Class BarriosService
    Private barrdao As BarriosDao

    Public Sub New()
        barrdao = New BarriosDao
    End Sub

    Public Function listarBarrios() As List(Of Barrio)
        Return barrdao.getAll()
    End Function
    Public Function getNombreBarrio(idBarrio As Integer) As String
        Return barrdao.getNombreDeBarrio(idBarrio)
    End Function

End Class
