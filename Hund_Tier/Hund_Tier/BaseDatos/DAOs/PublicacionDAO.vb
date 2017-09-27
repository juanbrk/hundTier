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



End Class
