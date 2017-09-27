Public Class PublicacionService
    Dim publiDao As New PublicacionDAO
    Public Sub New()
        publiDao = New PublicacionDAO()
    End Sub

    Public Function agregarAnimal(unAnimal As Animal, tipo_animal As Integer) As Integer
        Return publiDao.addAnimal(unAnimal, tipo_animal)
    End Function



End Class
