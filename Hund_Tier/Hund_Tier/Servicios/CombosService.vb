Public Class CombosService
    Private combDao As CombosDAO

    Public Sub New()
        combDao = New CombosDAO
    End Sub

    Public Function getBarrios() As DataTable
        Return combDao.cargarBarrios()
    End Function

    Public Function getRazasPerros() As DataTable
        Return combDao.cargarRazasPerros()
    End Function

    Public Function getColores() As DataTable
        Return combDao.cargarColores()
    End Function

    Public Function getSexos() As DataTable
        Return combDao.cargarSexos()
    End Function

    'Funcion que permite cargar cualquier combo, pasandoselo como parametro, junto al valor a mostrar y al valor que 
    'se seleccionara cuando se elija un valor del combo
    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

End Class
