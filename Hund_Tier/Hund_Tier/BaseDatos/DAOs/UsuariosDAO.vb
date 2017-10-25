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

    'Funcion que sirve para chequera si el usuario y password ingresados en el login coinciden con algun usuario y pass
    'de la base de datos. Devuelve un boolean
    Friend Function existeUsuario(mailOUserName As String, pwd As String) As Boolean
        Dim strSql = "Select * From USUARIOS u Where  ((u.email = '" & mailOUserName & "' AND u.password = '" & pwd & "') AND u.habilitado=1) OR ((u.username = '" & mailOUserName & "' AND u.password = '" & pwd & "') AND u.habilitado=1)"
        Dim valorDevuelto = False
        Try
            If BDHelper.getDBHelper.ConsultaSQL(strSql).Rows.Count > 0 Then
                valorDevuelto = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return valorDevuelto

    End Function

    'Funcion que permite obtener un usuario a partir de su mail o nombre de usuario y su contraseña. Sirve para el 
    'login, primero se chequea que existe un usuario con esa pwd y mail y luego se lo recupera mediante este metodo
    Friend Function getUsuario(mailOUsername As String, pwd As String) As Usuario
        Dim strSql = "Select * From USUARIOS u Where  ((u.email = '" & mailOUsername & "' AND u.password = '" & pwd & "') AND u.habilitado=1) OR ((u.username = '" & mailOUsername & "' AND u.password = '" & pwd & "') AND u.habilitado=1)"

        Try
            Dim tabla = BDHelper.getDBHelper.ConsultaSQL(strSql)
            If tabla.Rows.Count > 0 Then
                Dim usuario As New Usuario
                usuario.setId(tabla.Rows(0).Item("id_usuario").ToString)
                usuario.setNombre(tabla.Rows(0).Item("nombre").ToString())
                usuario.setApellido(tabla.Rows(0).Item("apellido").ToString())
                usuario.setBarrio(tabla.Rows(0).Item("id_barrio").ToString())
                usuario.setUsername(tabla.Rows(0).Item("username").ToString())
                usuario.setEmail(tabla.Rows(0).Item("email").ToString())
                usuario.setPassword(tabla.Rows(0).Item("password").ToString)
                'Si el usuario tiene ingresado algun valor en la columna numero
                If Not IsDBNull(tabla.Rows(0).Item("num_telefono")) Then
                    usuario.setNumeroTelefono(tabla.Rows(0).Item("num_telefono").ToString())
                End If
                'Si hay una calle ingresada en la columna calle
                If Not IsDBNull(tabla.Rows(0).Item("calle")) Then
                    usuario.setCalle(tabla.Rows(0).Item("calle").ToString())
                    usuario.setNumCalle(tabla.Rows(0).Item("numero").ToString())
                    'Si el usuario vive en departamento (piso y depto)
                    If Not IsDBNull(tabla.Rows(0).Item("piso")) Then
                        usuario.setPiso(tabla.Rows(0).Item("piso"))
                        usuario.setDepartamento(tabla.Rows(0).Item("departamento"))
                    End If
                End If
                usuario.setPerfilId(tabla.Rows(0).Item("id_perfil"))

                Return usuario
                End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error tratando de obtener los datos de usuario", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        str_sql = "INSERT INTO Usuarios (id_usuario, nombre, apellido, email, id_barrio, username, password, habilitado,id_perfil, fecha_alta) VALUES("
        str_sql += usr.getIdUsuario.ToString + ",'"
        str_sql += usr.getNombre + "','"
        str_sql += usr.getApellido + "','"
        str_sql += usr.getEmail + "',"
        str_sql += usr.getBarrio.ToString + ", '"
        str_sql += usr.getUsername + "','"
        str_sql += usr.getPassword + "',"
        'El 1 es el valor de la columna habilitado, que habilita al usuario.
        str_sql += usr.getHabilitado.ToString + ","
        str_sql += usr.getPerfilId.ToString + ","
        str_sql += "GETDATE()" & ")"

        Try
            Return BDHelper.getDBHelper().EjecutarSQL(str_sql)
        Catch ex As Exception
            Throw ex
            Return 0
        End Try
    End Function

    Friend Function updateUsuario(usr As Usuario) As Integer

        Dim strSql = "Update Usuarios "
        strSql += "SET nombre ='" & usr.getNombre & "', apellido ='" & usr.getApellido & "', num_telefono='" & usr.getNumTelefono & "', email='" & usr.getEmail & "', id_barrio=" & usr.getBarrio & ", calle='" & usr.getCalle & "', numero='" & usr.getNumeroCalle & "',piso=" & usr.getPiso & ", departamento='" & usr.getDepartamento & "', password='" & usr.getPassword & "'"
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

    Friend Function getNombreBarrioUsuario(idBarrio As Integer) As String
        Dim valorDevuelto = ""
        Dim strSql = "Select B.nombre AS 'nombre barrio' From Barrios B Where B.id_barrio = " & idBarrio.ToString

        Try
            Dim tabla = BDHelper.getDBHelper.ConsultaSQL(strSql)
            If tabla.Rows.Count > 0 Then
                valorDevuelto = tabla.Rows(0).Item("nombre barrio")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error tratando de obtener los datos de usuario", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return valorDevuelto
    End Function

    Public Function getReportePendientesAltaUsuario(ByVal fechaDesde As String, ByVal fechaHasta As String) As DataTable
        Dim sql As String = "SELECT U.fecha_alta, U.username, U.nombre, U.apellido, U.email From usuarios U " &
        " WHERE U.fecha_alta>='" + fechaDesde + "' AND U.fecha_alta<='" + fechaHasta + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(sql)
    End Function


End Class
