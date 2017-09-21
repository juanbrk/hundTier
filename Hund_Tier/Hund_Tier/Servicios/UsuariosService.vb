Public Class UsuariosService
    Private usrDao As UsuariosDAO
    Public Sub New()
        usrDao = New UsuariosDAO()
    End Sub

    Public Function listarUsuarios() As List(Of Usuario)
        Return usrDao.getAll()
    End Function
    Public Function getCountUsuarios() As Integer
        Return BDHelper.getDBHelper.generarId("usuarios") - 1
    End Function

    Public Function darDeBajaUsuario(id As Integer) As Integer
        Return usrDao.darDeBaja(id)
    End Function

    Public Function agregarUsuario(unUsuario As Usuario) As Integer
        Return usrDao.addUsuario(unUsuario)
    End Function

    Public Function updateUsuario(unUsuario As Usuario) As Integer
        Return usrDao.updateUsuario(unUsuario)
    End Function



End Class
