Imports System.Data.SqlClient

Public Class BDHelper
    ' La clase BDHelper permite quitar del código del formulario todo lo relacionado con el acceso a bd.
    ' Permite ejecutar comandos sql y retornar resultados a la capa de datos.
    ' Implementa el patrón SINGLETON, que garantiza tener solo una instancia de esta clase.

    Private string_conexion As String
    Private Shared instance As BDHelper 'Unica instancia de la clase

    Private Sub New()
        string_conexion = "Data Source=DESKTOP-HK05I7G\SQLEXPRESS;Initial Catalog=Hund_Tier;User ID=sa;Password=thyssenkrupps"
    End Sub

    Public Shared Function getDBHelper() As BDHelper
        If IsNothing(instance) Then
            instance = New BDHelper()
        End If
        Return instance
    End Function

    Public Function EjecutarSQL(ByVal strSql As String) As Integer
        ' Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand

        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            ' Establece que conexión usar
            conexion.ConnectionString = string_conexion
            ' Abre la conexión
            conexion.Open()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            ' Establece la instrucción a ejecutar
            cmd.CommandText = strSql
            ' Retorna el resultado de ejecutar el comando
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            ' Cierra la conexión
            If conexion.State = ConnectionState.Open Then conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    'Funcion que hace el alta de una publicacion con una transaccion, es decir, primero se carga en la BD
    'el animal de la publicacion en la tabla Animal y luego la publicacion en la tabla Publicacion.
    'Durante el tiempo que esta en ejecucion la transaccion, no se puede acceder a la BD ni cambiarle valores
    'esto garantiza que la BD quede en un estado coherente. 
    Public Function ejecutarSQLTransaction(unaPublicacion As Publicacion) As Integer
        Dim cnnx As New SqlConnection
        'Comando para agregar la publicacion
        Dim cmdPublicacion As New SqlCommand
        'Comando para agregar el animal
        Dim cmdAnimal As New SqlCommand
        Dim miTransaccion As SqlTransaction
        Dim tieneTelefono = (unaPublicacion.telefono2 IsNot Nothing)

        Dim valorDevolucion As Integer = 1
        cnnx.ConnectionString = string_conexion

        cnnx.Open()
        miTransaccion = cnnx.BeginTransaction

        Try
            'Primero agregamos al animal
            'Variable que me sirve para saber si el animal tiene color 2
            Dim tieneColor2 = (unaPublicacion.animal.idColor2 <> 0)
            'Variable que me sirve para saber si el animal esta castrado
            Dim estaCastrado = (unaPublicacion.animal.idCondicionCastrado <> 0)
            'Variable para saber si el animal tiene color de collar
            Dim tieneColorCollar = (unaPublicacion.animal.idColorCollar <> 0)

            Dim str_sql_animal = "INSERT INTO Animal (id_animal, cod_tipo_animal, nombre, cod_raza, cod_sexo, cod_tamano, cod_edad, cod_pelo, color1"
            If tieneColor2 Then
                str_sql_animal += ", color2"
            End If

            If estaCastrado Then
                str_sql_animal += ", cod_castrado"
            End If

            If tieneColorCollar Then
                str_sql_animal += ", cod_color_collar"
            End If
            str_sql_animal += ") VALUES(@idAnimal, @tipoAnimal, @nombre, @idRaza, @idSexo, @tamano, @edad, @idPelo, @idColor1"
            If tieneColor2 Then
                str_sql_animal += ",@idColor2"
            End If

            If estaCastrado Then
                str_sql_animal += ",@condicionCastrado"
            End If

            If tieneColorCollar Then
                str_sql_animal += ",@colorCollar"
            End If
            str_sql_animal += ")"
            cmdAnimal = New SqlCommand(str_sql_animal, cnnx, miTransaccion)
            cmdAnimal.Connection = cnnx
            cmdAnimal.Parameters.Add("@idAnimal", SqlDbType.Int).Value = unaPublicacion.animal.idAnimal
            cmdAnimal.Parameters.Add("@tipoAnimal", SqlDbType.Int).Value = unaPublicacion.animal.tipoAnimal
            cmdAnimal.Parameters.Add("@nombre", SqlDbType.VarChar).Value = unaPublicacion.animal.nombre
            cmdAnimal.Parameters.Add("@idRaza", SqlDbType.Int).Value = unaPublicacion.animal.idRaza
            cmdAnimal.Parameters.Add("@idSexo", SqlDbType.Int).Value = unaPublicacion.animal.idSexo
            cmdAnimal.Parameters.Add("@tamano", SqlDbType.Int).Value = unaPublicacion.animal.tamano
            cmdAnimal.Parameters.Add("@edad", SqlDbType.Int).Value = unaPublicacion.animal.idEdad
            cmdAnimal.Parameters.Add("@idPelo", SqlDbType.Int).Value = unaPublicacion.animal.idTipoPelo
            cmdAnimal.Parameters.Add("@idColor1", SqlDbType.Int).Value = unaPublicacion.animal.idColor1
            If tieneColor2 Then
                cmdAnimal.Parameters.Add("@idColor2", SqlDbType.Int).Value = unaPublicacion.animal.idColor2
            End If

            If estaCastrado Then
                cmdAnimal.Parameters.Add("@condicionCastrado", SqlDbType.Int).Value = unaPublicacion.animal.idCondicionCastrado
            End If

            If tieneColorCollar Then
                cmdAnimal.Parameters.Add("@colorCollar", SqlDbType.Int).Value = unaPublicacion.animal.idColorCollar
            End If
            cmdAnimal.ExecuteNonQuery()
            MsgBox("INSERT DE ANIMAL")

            'EN EL CONSTRUCTOR DEL COMMAND LE PASAMOS LA TRANSACCION 

            Dim str_sql_publicacion = "Insert into Publicacion(cod_publicacion, tipo_animal, id_animal, tipo_publicacion, fecha_publicacion, barrio, descripcion, usuario_responsable"
            If tieneTelefono Then
                str_sql_publicacion += ", telefono2"
            End If
            str_sql_publicacion += ", estado_publicacion, ciudad) VALUES (@codigoPublicacion,@tipoAnimal,@idAnimal,@tipoPublicacion, @fecha, @barrio, @descripcion,@idResponsable, "
            If tieneTelefono Then
                str_sql_publicacion += "@telefono,"
            End If
            str_sql_publicacion += "@estadoPublicacion,@ciudad)"

            cmdPublicacion = New SqlCommand(str_sql_publicacion, cnnx, miTransaccion)
            cmdPublicacion.Connection = cnnx
            cmdPublicacion.Parameters.Add("@codigoPublicacion", SqlDbType.Int).Value = unaPublicacion.codigoPublicacion
            cmdPublicacion.Parameters.Add("@tipoAnimal", SqlDbType.Int).Value = unaPublicacion.animal.tipoAnimal
            cmdPublicacion.Parameters.Add("@idAnimal", SqlDbType.Int).Value = unaPublicacion.animal.idAnimal
            cmdPublicacion.Parameters.Add("@tipoPublicacion", SqlDbType.Int).Value = unaPublicacion.tipoPublicacion
            cmdPublicacion.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Date.Now
            cmdPublicacion.Parameters.Add("@barrio", SqlDbType.Int).Value = unaPublicacion.idBarrio
            cmdPublicacion.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = unaPublicacion.descripcionPublicacion
            cmdPublicacion.Parameters.Add("@idResponsable", SqlDbType.Int).Value = unaPublicacion.usuario.getIdUsuario
            If tieneTelefono Then
                cmdPublicacion.Parameters.Add("@telefono", SqlDbType.VarChar).Value = unaPublicacion.telefono2
            End If
            cmdPublicacion.Parameters.Add("@estadoPublicacion", SqlDbType.Int).Value = unaPublicacion.estadoPublicacion
            cmdPublicacion.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = unaPublicacion.nombreCiudad

            cmdPublicacion.ExecuteNonQuery()

            miTransaccion.Commit()

        Catch ex As Exception
            miTransaccion.Rollback()
            MessageBox.Show("Ocurrio un error al intentar publicar su aviso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            valorDevolucion = 0
        Finally
            cnnx.Close()
            cnnx.Dispose()
        End Try
        Return valorDevolucion
    End Function

    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        ' Se utiliza para sentencias SQL del tipo “Select”
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            'Dispose() libera los recursos asociados a la conexón
            conexion.Dispose()
        End Try
    End Function

    'Funcion que genera automaticamente un id para agregar en la tabla que se desee, segun el string
    'pasado por parametro
    Public Function generarId(ByVal nombreTablaAAgregar As String) As Integer
        ' Se utiliza para sentencias SQL del tipo “Select”
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim strSql = "Select * From " & nombreTablaAAgregar
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Dim nuevo_id = 0
        Dim filas_tabla = 0
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' 'segun la cantidad de filas que retorne la tabla, creamos un id que sea un numero mayor al numero devuelto
            filas_tabla = tabla.Rows.Count
            If filas_tabla > 0 Then
                nuevo_id = filas_tabla + 1
            Else
                nuevo_id = 1
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            'Dispose() libera los recursos asociados a la conexón
            conexion.Dispose()
        End Try
        Return nuevo_id
    End Function

    'Funcion que permite generar un id al animal, segun sea perro o gato. Se busca en la tabla animal
    'los animales con el mismo tipo de animal ingresado por parametro y se cuentan las filas que hay de
    'ese tipo de animal. El nuevo id es el numero de filas + 1
    Public Function generarIdAnimal(tipoAnimal As Integer) As Integer
        Dim strSql = "Select * From Animal  Where cod_tipo_animal =" & tipoAnimal
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Dim nuevo_id = 0
        Dim filas_tabla = 0
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' 'segun la cantidad de filas que retorne la tabla, creamos un id que sea un numero mayor al numero devuelto
            filas_tabla = tabla.Rows.Count
            If filas_tabla > 0 Then
                nuevo_id = filas_tabla + 1
            Else
                nuevo_id = 1
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            'Dispose() libera los recursos asociados a la conexón
            conexion.Dispose()
        End Try
        Return nuevo_id
    End Function

    Public Function ConsultarSQLConParametros(ByVal sqlStr As String, ByVal params As Object()) As Data.DataTable
        ' Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        ' La función recibe por valor una sentencia sql como string y un arreglo de parámetros, devuelve un objeto de tipo DataTable

        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Dim n_param As String
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sqlStr

            'Agregamos a la colección de parámetros del comando los filtros recibidos
            'IMPORTANTE: cada parametro deberá llamarse: param1, param2,.., paramN
            For i = 0 To params.Length - 1
                If Not IsNothing(params(i)) Then
                    n_param = "param" + Convert.ToString(i + 1)
                    cmd.Parameters.AddWithValue(n_param, params(i))
                End If
            Next

            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            'Dispose() libera los recursos asociados a la conexón
            conexion.Dispose()
        End Try
    End Function
End Class
