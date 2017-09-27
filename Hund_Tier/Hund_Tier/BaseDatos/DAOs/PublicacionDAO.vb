Public Class PublicacionDAO
    Private Property str_sql = ""
    'AddAnimal servira para agregar perros o gatos, hay que poner un chequeo anterior.
    Friend Function addAnimal(ani As Animal, tipoAnimal As Integer) As Integer
        'Variable que me sirve para saber si el perro tiene color 2
        Dim tieneColor2 = (ani.idColor2 <> 0)
        'Variable que me sirve para saber si el perro esta castrado
        Dim estaCastrado = (ani.idCondicionCastrado <> 0)
        'Variable para saber si el perro tiene color de collar
        Dim tieneColorCollar = (ani.idColorCollar <> 0)

        'Si el animal es un perro (tipoAnimal =1) agregamos un perro a la BD
        If tipoAnimal = 1 Then
            str_sql = "INSERT INTO Perros (id_perro, nombre_perro, raza_perro, sexo_perro, tamano_perro, edad_perro, pelo_perro, color1"
            'Chequeamos los valores que pueden ser null en la BD para saber si agregarlos o no.
            If tieneColor2 Then
                str_sql += ", color2"
            End If

            If estaCastrado Then
                str_sql += ", condicion_castrado"
            End If

            If tieneColorCollar Then
                str_sql += ", color_collar"
            End If
            str_sql += ") VALUES("
            'Empezamos a agregar los valores que tendra cada campo en la BD
            str_sql += ani.idAnimal.ToString + ",'"
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
