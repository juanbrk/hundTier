Public Class UsuariosDAO
    Friend Function getAll() As List(Of Usuario)
        Dim data As DataTable = BDHelper.getDBHelper.ConsultaSQL("SELECT U.*, B.nombre as nombre_barrio FROM Usuarios U JOIN  Barrios B on  U.id_barrio = B.id_barrio")

        Dim usr As Usuario
        Dim listaUsuarios As New List(Of Usuario)
        For Each fila As DataRow In data.Rows
            usr = New Usuario()
            With usr
                .setId(fila.Item("id_usuario"))
                .setNombre(fila.Item("nombre").ToString)
                .setApellido(fila.Item("apellido").ToString)
                .setNumeroTelefono(fila.Item("num_telefono").ToString())
                .setEmail(fila.Item("email").ToString)
                .setBarrio(fila.Item("barrio_id"))
                .setCalle(fila.Item("calle").ToString())
                .setNumCalle(fila.Item("numero").ToString())
                .setPiso(fila.Item("piso"))
                .setDepartamento(fila.Item("departamento").ToString())
                .setUsername(fila.Item("username").ToString())
                .setPassword(fila.Item("password").ToString())
                .setHabilitado(fila.Item("habilitado").ToString())
                .setBarrioString(fila.Item("nombre_barrio").ToString())
            End With
            listaUsuarios.Add(usr)
        Next
        Return listaUsuarios
    End Function


    Friend Function darDeBaja(usuario As Usuario) As Integer
        Dim str_sql_borrado = "Update Usuarios "
        str_sql_borrado += "SET habilitado= 0"
        str_sql_borrado += " WHERE id_usuario=" & usuario.getIdUsuario
        Try
            Return BDHelper.getDBHelper.EjecutarSQL(str_sql_borrado)
        Catch e As Exception
            Return 0
        End Try

    End Function

    Friend Function addUsuario(usr As Usuario) As Integer
        Dim str_sql As String
        str_sql = "INSERT INTO Usuarios (id_usuario, nombre, apellido, email, id_barrio, username, password, habilitado) VALUES("
        str_sql += usr.getIdUsuario.ToString + ",'"
        str_sql += usr.getNombre + "','"
        str_sql += usr.getApellido + "','"
        str_sql += usr.getEmail + "',"
        str_sql += usr.getBarrio.ToString + ", '"
        str_sql += usr.getUsername + "','"
        str_sql += usr.getPassword + "',"
        'El 1 es el valor de la columna habilitado, que habilita al usuario.
        str_sql += usr.getHabilitado.ToString & ")"

        Try
            Return BDHelper.getDBHelper().EjecutarSQL(str_sql)
        Catch ex As Exception
            Throw ex
            Return 0
        End Try
    End Function

    Friend Function updateUsuario(usr As Usuario) As Integer

        Dim strSql = "Update Usuarios "
        strSql += "SET nombre ='" & usr.getNombre & "', apellido ='" & usr.getApellido & "', num_telefono='" & usr.getNumTelefono & "', email='" & usr.getEmail & "', id_barrio=" & usr.getBarrio & ", calle='" & usr.getCalle & "', numero='" & usr.getNumeroCalle & "',piso=" & usr.getPiso & ", departamento='" & usr.getDepartamento & "'"
        strSql += "WHERE id_usuario = " & usr.getIdUsuario

        Try
            Return BDHelper.getDBHelper.EjecutarSQL(strSql)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Funcion que permite determinar si el mail ingresado ya ha sido utilizado por otro usuario
    Friend Function existeMail(mailIngresado As String) As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from Usuarios where email = '" + mailIngresado + "'").Rows.Count > 0
    End Function

    'Funcion que permite determinar si el nombre de usuario ingresado ya ha sido utilizado por otro usuario
    Friend Function existeUsername(usernameIngresado As String) As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from Usuarios where username = '" + usernameIngresado + "'").Rows.Count > 0
    End Function


End Class
