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
