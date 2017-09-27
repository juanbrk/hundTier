Public Class PublicacionService
    Dim publiDao As New PublicacionDAO
    Public Sub New()
        publiDao = New PublicacionDAO()
    End Sub

    Public Function agregarAnimal(unAnimal As Animal) As Integer
        Return publiDao.addAnimal(unAnimal)
    End Function



End Class
