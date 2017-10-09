Public Class PublicacionDAO
    Private Property str_sql = ""

    'AddAnimal servira para agregar perros o gatos, hay que poner un chequeo anterior.
    Friend Function addAnimal(ani As Animal) As Integer
        'Variable booleana que nos permite saber que animal agregar segun la property tipoAnimal del animal
        'Pasado por parametro .Si es perro el resultado es verdadero Si es un gato, el resultado es falso. 
        Dim esPerro = (ani.tipoAnimal = 1)
        'Variable que me sirve para saber si el animal tiene color 2
        Dim tieneColor2 = (ani.idColor2 <> 0)
        'Variable que me sirve para saber si el animal esta castrado
        Dim estaCastrado = (ani.idCondicionCastrado <> 0)
        'Variable para saber si el animal tiene color de collar
        Dim tieneColorCollar = (ani.idColorCollar <> 0)

        'Si el animal es un perro (tipoAnimal =1) agregamos un perro a la BD
        If esPerro Then
            str_sql = "INSERT INTO Animal (id_animal, cod_tipo_animal, nombre, cod_raza, cod_sexo, cod_tamano, cod_edad, cod_pelo, color1"
            'Chequeamos los valores que pueden ser null en la BD para saber si agregarlos o no.
            If tieneColor2 Then
                str_sql += ", color2"
            End If

            If estaCastrado Then
                str_sql += ", cod_castrado"
            End If

            If tieneColorCollar Then
                str_sql += ", cod_color_collar"
            End If
            str_sql += ") VALUES("
            'Empezamos a agregar los valores que tendra cada campo en la BD
            str_sql += ani.idAnimal.ToString + ","
            str_sql += ani.tipoAnimal.ToString + ",'"
            str_sql += ani.nombre + "',"
            str_sql += ani.idRaza.ToString + ","
            str_sql += ani.idSexo.ToString + ","
            str_sql += ani.tamano.ToString + ", "
            str_sql += ani.idEdad.ToString + ","
            str_sql += ani.idTipoPelo.ToString + ","
            str_sql += ani.idColor1.ToString
            'Chequeamos los valores que pueden ser null en la BD para saber si agregarlos o no.
            If tieneColor2 Then
                str_sql += "," & ani.idColor2.ToString & ""
            End If

            If estaCastrado Then
                str_sql += "," & ani.idCondicionCastrado.ToString & ""
            End If

            If tieneColorCollar Then
                str_sql += "," & ani.idColorCollar & ""
            End If

            str_sql += ")"
            Try
                Return BDHelper.getDBHelper().EjecutarSQL(str_sql)
            Catch ex As Exception
                Throw ex
                Return 0
            End Try
            'Si el animal es un gato(tipoAnimal = 2) agregamos un gato a la BD
        Else

        End If




    End Function

    Friend Function addPublicacionAdopcion(unaPublicacion As Publicacion) As Integer
        'Variable que almacena el valor que se retornara. se actualiza en cada try catch. 
        Dim valorRetorno As New Integer

        Try
            ' Agregamos el animal, pasando como parametro el animal  que queremos
            ' Que se agregue a la BD. Segun el tipo de animal, se le dira a la base dedatos a que 
            ' tabla agregar el animal si a perros o a gatos.
            If addAnimal(unaPublicacion.animal) = 1 Then
                'Generamos los datos que faltan para subir la publicacion a la BD. Codigo de publicacion y estadoPublicacion
                'La fecha de publicacion la agregara el motor de la BD
                unaPublicacion.codigoPublicacion = BDHelper.getDBHelper.generarId("Publicacion")
                unaPublicacion.estadoPublicacion = 1

                'Creamos un booleano para verificar si la publicacion tiene telefono2
                Dim tieneTelefono = (unaPublicacion.telefono2 IsNot Nothing)

                str_sql = "Insert into Publicacion(cod_publicacion, tipo_animal, id_animal, tipo_publicacion, fecha_publicacion, barrio, descripcion, usuario_responsable"
                'si ingresaron un telefono2 en la publicacion, lo agregamos. si no no.
                If tieneTelefono Then
                    str_sql += ", telefono2"
                End If
                str_sql += ", estado_publicacion, ciudad) VALUES ("

                '(1,1,2,1,GETDATE(),4,'asdasda',3,'156546',1,'Cordoba')
                str_sql += unaPublicacion.codigoPublicacion.ToString & "," & unaPublicacion.animal.tipoAnimal.ToString & "," & unaPublicacion.animal.idAnimal.ToString & "," & unaPublicacion.tipoPublicacion.ToString & ","
                str_sql += " GETDATE()," & unaPublicacion.idBarrio.ToString & ",'" & unaPublicacion.descripcionPublicacion & "'," & unaPublicacion.usuario.getIdUsuario.ToString & ","
                'Si la publi tiene telefono, la agregamos
                If tieneTelefono Then
                    str_sql += "'" & unaPublicacion.telefono2 & "',"
                End If
                str_sql += unaPublicacion.estadoPublicacion.ToString & ",'" & unaPublicacion.nombreCiudad & "')"

                Try
                    valorRetorno = BDHelper.getDBHelper().EjecutarSQL(str_sql)
                Catch ex As Exception
                    MsgBox("Error al agregar La publicacion", MsgBoxStyle.OkOnly, "Base de Datos")
                    valorRetorno = 0
                End Try
            End If

        Catch ex As Exception
            MsgBox("Error al agregar el animal", MsgBoxStyle.OkOnly, "Base de Datos")
            valorRetorno = 0
        End Try

        Return valorRetorno

    End Function

    'TODO hacer funcionar esta funcion para buscar animales segun los datos pasados por param
    ' y el barrio o ciudad de la publicacion
    Friend Function buscarAnimal(unAni As Animal, publi As Publicacion) As List(Of Usuario)
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

    Public Function getPublicacionConFiltros(ByVal params As Object()) As IList(Of Publicacion)
        Dim lst As New List(Of Publicacion)

        'String que se le pasara a la consulta en la BD con parametros, es larga porque tiene muchas uniones con
        'diferentes tablas para poder armar el formato que aparece en dgv_publicaciones en el form frm_listarPublicaciones
        Dim sql_str As String = "Select P.cod_publicacion AS 'Codigo publicacion'," &
        "A.nombre As 'nombre animal'," &
        "R.nombre_raza AS 'raza'," &
        "TA.nombre_tipo AS 'tipo animal'," &
        " E.nombre_edad As 'edad', PA.nombre_pelo AS 'pelo'," &
        " S.nombre_sexo AS 'sexo', B.nombre As 'Barrio'," &
        " P.ciudad As 'ciudad', U.nombre As 'responsable'" &
        "From ((((((((Publicacion P " &
        "Join Animal A  ON (P.id_animal = A.id_animal AND P.tipo_animal = A.cod_tipo_animal))" &
        "Join Razas R On (A.cod_raza = R.cod_raza AND A.cod_tipo_animal = R.cod_tipo_animal))" &
        "Join Tipo_Animal TA ON A.cod_tipo_animal = TA.codigo_animal)" &
        "Join Edad_Animal E ON A.cod_edad = E.codigo_edad)" &
        "Join Pelo_Animal PA ON A.cod_pelo = PA.codigo_pelo)" &
        "Join Sexo_Animal S ON A.cod_sexo = S.codigo_sexo)" &
        "Join Barrios B On P.barrio = B.id_barrio)" &
        "Join Usuarios U ON P.usuario_responsable = U.id_usuario)" &
        "Where "

        Dim andString As String = " AND "
        'Booleano que permite saber si ya se agrego algun parametro, para saber si agregar la palabra
        'And a sql_str
        Dim yaPasoParametro As Boolean = False
        'Validamos filtro nombre animal
        If Not IsNothing(params(0)) Then
            'Si ya hubo algun parametro pasado, le agregamos la palabra AND, si no no se la 
            'agregamos pero actualizamos la flag
            If yaPasoParametro Then
                sql_str += andString & " "
                sql_str += "A.nombre = @param1 "
            Else
                sql_str += " A.nombre = @param1 "
                yaPasoParametro = True
            End If

        End If

        'Agregamos el tipo de animal como filtro
        If yaPasoParametro Then
            sql_str += andString & " "
            sql_str += " A.cod_tipo_animal = @param2"
        Else
            sql_str += " A.cod_tipo_animal = @param2"
            yaPasoParametro = True
        End If
        'Validamos filtro raza
        If Not IsNothing(params(2)) Then
            If yaPasoParametro Then
                sql_str += andString & " "
                sql_str += " A.cod_raza = @param3 "
            Else
                sql_str += " A.cod_raza = @param3 "
                yaPasoParametro = True
            End If
        End If
        'Validamos filtro color1
        If Not IsNothing(params(3)) Then
            If yaPasoParametro Then
                sql_str += andString & " "
                sql_str += " A.color1 = @param4 "
            Else
                sql_str += " A.color1 = @param4 "
                yaPasoParametro = True
            End If

        End If
        'Validamos filtro color2
        If Not IsNothing(params(4)) Then
            If yaPasoParametro Then
                sql_str += andString & " "
                sql_str += " A.color2 = @param5 "
            Else
                sql_str += " A.color2 = @param5 "
                yaPasoParametro = True
            End If

        End If
        'Validamos filtro edad
        If Not IsNothing(params(5)) Then
            If yaPasoParametro Then
                sql_str += andString & " "
                sql_str += " A.cod_edad = @param6 "
            Else
                sql_str += " A.cod_edad = @param6 "
                yaPasoParametro = True
            End If

        End If
        'Validamos filtro sexo
        If Not IsNothing(params(6)) Then
            If yaPasoParametro Then
                sql_str += andString & " "
                sql_str += " A.cod_sexo = @param7 "
            Else
                sql_str += " A.cod_sexo = @param7 "
                yaPasoParametro = True
            End If

        End If
        'Validamos filtro tamaño
        If Not IsNothing(params(7)) Then
            If yaPasoParametro Then
                sql_str += andString & " "
                sql_str += " A.cod_tamano = @param8 "
            Else
                sql_str += " A.cod_tamano = @param8 "
                yaPasoParametro = True
            End If

        End If
        'Validamos filtro pelo
        If Not IsNothing(params(8)) Then
            If yaPasoParametro Then
                sql_str += andString & " "
                sql_str += "  A.cod_pelo = @param9 "
            Else
                sql_str += "  A.cod_pelo = @param9  "
                yaPasoParametro = True
            End If
        End If
        'Validamos filtro barrio
        If Not IsNothing(params(9)) Then
            If yaPasoParametro Then
                sql_str += andString & " "
                sql_str += "  P.barrio = @param10 "
            Else
                sql_str += "  P.barrio = @param10  "
                yaPasoParametro = True
            End If
        End If
        'Validamos el filtro ciudad
        If Not IsNothing(params(10)) Then
            If yaPasoParametro Then
                sql_str += andString & " "
                sql_str += " P.ciudad = @param11 "
            Else
                sql_str += "  P.ciudad = @param11  "
                yaPasoParametro = True
            End If
        End If
        'Validamos filtro de fechas
        'If Not IsNothing(params(11)) And Not IsNothing(params(12)) Then
        '    If yaPasoParametro Then
        '        sql_str += andString & " "
        '        sql_str += " (P.fecha_publicacion>=@param12 AND P.fecha_publicacion<=@param13) "
        '    Else
        '        sql_str += "  (P.fecha_publicacion>=@param12 AND P.fecha_publicacion<=@param13)  "
        '        yaPasoParametro = True
        '    End If
        'End If
        'Validamos filtro de estado castrado
        If Not IsNothing(params(11)) Then
            If yaPasoParametro Then
                sql_str += andString & " "
                sql_str += "A.cod_castrado=@param12 "
            Else
                sql_str += "  A.cod_castrado=@param12  "
                yaPasoParametro = True
            End If
        End If

        sql_str += " And P.estado_publicacion = 1"

        '' TODO
        ' Por cada fila devuelta en la consutla a la BD con parametros a traves de BDHelper
        ' Mapeamos el resultado de la fila a una publicacion y lo agregamos a la lista que nos servira
        ' como source para la dgv
        For Each row As DataRow In BDHelper.getDBHelper.ConsultarSQLConParametros(sql_str, params).Rows
            lst.Add(mapPublicacionChica(row))
        Next

        Return lst
    End Function

    ' Funcion que convierte el resultado de una consulta a una BD con filtros a una publicacion resumida
    Private Function mapPublicacionChica(ByVal row As DataRow) As Publicacion
        Dim oPubli As New Publicacion

        oPubli.codigoPublicacion = Convert.ToInt32(row.Item("Codigo publicacion").ToString)
        oPubli.animal = New Animal
        oPubli.animal.nombre = row.Item("nombre animal").ToString
        oPubli.animal.razaString = row.Item("raza").ToString
        oPubli.animal.tipoAnimalString = row.Item("tipo animal").ToString
        oPubli.animal.edadString = row.Item("edad").ToString
        oPubli.animal.peloString = row.Item("pelo").ToString
        oPubli.animal.sexoString = row.Item("sexo").ToString
        oPubli.barrioString = row.Item("Barrio").ToString
        oPubli.nombreCiudad = row.Item("ciudad").ToString
        oPubli.nombreUsuario = row.Item("responsable").ToString


        Return oPubli
    End Function


End Class
