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



End Class
