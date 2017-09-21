Public Class Barrio
    Public Property ID_BARRIO As String
    Public Property nombre As String

    Public Overrides Function toString() As String
        Return nombre
    End Function

    Public Function getID() As String
        Return ID_BARRIO
    End Function

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Sub setID(id As String)
        ID_BARRIO = id
    End Sub

    Public Sub setNombre(unNombre As String)
        nombre = unNombre
    End Sub
End Class
