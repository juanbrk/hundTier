Public Class PublicacionService
    Dim publiDao As New PublicacionDAO
    Public Sub New()
        publiDao = New PublicacionDAO()
    End Sub

    Public Function agregarAnimal(unAnimal As Animal) As Integer
        Return publiDao.addAnimal(unAnimal)
    End Function

    'Funcion que agrega publicacion de adopcion. Puede que sea solo agregarPublicacion y que haga el chequeo del 
    'tipo de publicacion en el DAO
    Public Function agregarPublicacionAdopcion(unaPublicacion As Publicacion) As Integer
        Return publiDao.addPublicacionAdopcion(unaPublicacion)
    End Function



End Class
