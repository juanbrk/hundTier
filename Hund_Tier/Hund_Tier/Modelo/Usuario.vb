Public Class Usuario
    Private Property idUsuario As Integer
    Private Property nombre As String
    Private Property apellido As String
    Private Property barrio_id As Integer
    Private Property username As String
    Private Property email As String
    Private Property contrasena As String
    Private Property num_telefono As String
    Private Property calle As String
    Private Property numero As String
    Private Property piso As Integer
    Private Property departamento As String
    Private Property habilitado As Integer
    Private Property barrioAsString As String






    Public Function getIdUsuario() As Integer
        Return idUsuario
    End Function

    Public Function getBarrio() As Integer
        Return barrio_id
    End Function

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Function getApellido() As String
        Return apellido
    End Function

    Public Function getUsername() As String
        Return username
    End Function

    Public Function getEmail() As String
        Return email
    End Function

    Public Function getPassword() As String
        Return contrasena
    End Function
    Public Function getCalle() As String
        Return calle
    End Function
    Public Function getNumTelefono() As String
        Return num_telefono
    End Function
    Public Function getNumeroCalle() As String
        Return numero
    End Function
    Public Function getPiso() As Integer
        Return piso
    End Function
    Public Function getDepartamento() As String
        Return departamento
    End Function
    Public Function getHabilitado() As Integer
        Return habilitado
    End Function



    Public Sub setNombre(ByVal nombreUsuario As String)
        nombre = nombreUsuario
    End Sub
    Public Sub setApellido(ByVal apellido_usuario As String)
        apellido = apellido_usuario
    End Sub

    Friend Sub setBarrioString(v As String)
        barrioAsString = v
    End Sub

    Public Sub setUsername(ByVal nombreUsuario As String)
        username = nombreUsuario
    End Sub

    Public Sub setEmail(ByVal emailUsuario As String)
        email = emailUsuario
    End Sub
    Public Sub setBarrio(ByVal nuevoBarrioId As Integer)
        barrio_id = nuevoBarrioId
    End Sub
    Public Sub setPassword(ByVal contra As String)
        contrasena = contra
    End Sub
    Public Sub setNumCalle(ByVal numeroCalle As String)
        numero = numeroCalle
    End Sub
    Public Sub setCalle(ByVal nombre_calle As String)
        calle = nombre_calle
    End Sub
    Public Sub set_numTelefono(ByVal numero_telefono_nuevo As String)
        num_telefono = numero_telefono_nuevo
    End Sub
    Public Sub setDepartamento(ByVal id_depto As String)
        departamento = id_depto
    End Sub
    Public Sub setPiso(ByVal piso_nuevo As Integer)
        piso = piso_nuevo
    End Sub
    Public Sub setHabilitado(ByVal valor As Integer)
        habilitado = valor
    End Sub

    Public Sub setId(ByVal id_user As Integer)
        idUsuario = id_user
    End Sub
    Friend Sub setNumeroTelefono(v As String)
        num_telefono = v
    End Sub

    Public Overrides Function toString() As String
        Return nombre
    End Function



End Class
