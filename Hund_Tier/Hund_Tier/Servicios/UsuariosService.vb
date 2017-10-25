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

    Public Function darDeBajaUsuario(usr As Usuario) As Integer
        Return usrDao.darDeBaja(usr)
    End Function

    Public Function agregarUsuario(unUsuario As Usuario) As Integer
        Return usrDao.addUsuario(unUsuario)
    End Function

    Public Function updateUsuario(unUsuario As Usuario) As Integer
        Return usrDao.updateUsuario(unUsuario)
    End Function

    Public Function existeMail(mailIngresado As String) As Boolean
        Return usrDao.existeMail(mailIngresado)
    End Function

    Public Function existeUsername(usernameIngresado As String) As Boolean
        Return usrDao.existeUsername(usernameIngresado)
    End Function

    Public Function existeUsuario(mailOUsername As String, pwd As String) As Boolean
        Return usrDao.existeUsuario(mailOUsername, pwd)
    End Function

    Public Function obtenerUsuario(mailOUsername As String, pwd As String) As Usuario
        Return usrDao.getUsuario(mailOUsername, pwd)
    End Function

    Public Function obtenerNombreBarrioUsuario(idBarrio As Integer) As String
        Return usrDao.getNombreBarrioUsuario(idBarrio)
    End Function

    Public Function generarReporteAltaUsuario(ByVal fecDesde As String, ByVal fecHasta As String) As DataTable
        Return usrDao.getReportePendientesAltaUsuario(fecDesde, fecHasta)
    End Function





End Class
