Public Class frm_publicar_aviso
    Dim usuario As Usuario
    'Bandera que me permite saber si lo que se publicara es un gato(tipoAnimal = 2) o un perro (tipoAnimal = 1)
    'Por defecto es 1
    Dim tipo_animal = 1


    'Bandera para saber que tipo de publicacion es, adopcion = 1, perdido = 2, encontrado = 3
    Dim tipo_publicacion = 1
    'Cuando carga la form hay que cargar los combos Barrio y los campos nombre y email con los datos del 
    'usuario
    Private Sub frm_publicar_aviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCampos()
        usuario = Frm_main.getUsuario()

    End Sub

    Public Sub setTitulo(titulo As String)
        Me.Text = titulo
    End Sub
    Public Sub setTipoAnimal(valor As Integer)
        tipo_animal = valor
    End Sub
    Public Sub setTipoPublicacion(valor As Integer)
        tipo_publicacion = valor
    End Sub

    Private Sub llenarCampos()
        'Cargamos los combos a partir de ComboService 
        Dim cmbServicio As New CombosService
        'Obtenemos la tabla con todos los barrios
        Dim TablaDatos = cmbServicio.getBarrios
        'Cargamos el combo mediante el metodo llenarCombo de CombosService
        'Es todo lo mismo, lo unico que cambia es el combo a rellenar y 
        ' los ultimos dos parametros
        cmbServicio.llenarCombo(cmb_barrio, TablaDatos, "nombre", "ID_BARRIO")
        'Reutilizamos la tabla, pero ahora le cargamos las razas

        'Si el tipo de animal es un perro, cargamos los combos con lo que le corresponde a perros. 
        If tipo_animal = 1 Then
            TablaDatos = cmbServicio.getRazasPerros
            cmbServicio.llenarCombo(cmb_raza, TablaDatos, "nombre_raza", "cod_raza")
            'Reutilizamos la tabla para cargar los combos color1 y color2
            TablaDatos = cmbServicio.getColores
            cmbServicio.llenarCombo(cmb_color1, TablaDatos, "nombre", "id_color")
            'Volvemos a cargar con los colores
            TablaDatos = cmbServicio.getColores
            cmbServicio.llenarCombo(cmb_color2, TablaDatos, "nombre", "id_color")

            'Si el animal es un gato llenamos los combos con lo relativo a gatos. 
        Else

        End If

        'Cargamos combo sexos
        TablaDatos = cmbServicio.getSexos
        cmbServicio.llenarCombo(cmb_sexo, TablaDatos, "nombre_sexo", "codigo_sexo")
        'Cargamos combo edades
        TablaDatos = cmbServicio.getEdadesAnimal
        cmbServicio.llenarCombo(cmb_edad, TablaDatos, "nombre_edad", "codigo_edad")
        'Cargamos el combo tamaño
        TablaDatos = cmbServicio.getTamanosAnimal
        cmbServicio.llenarCombo(cmb_tamano, TablaDatos, "nombre_tamano", "codigo_tamano")
        'Cargamos el combo pelo
        TablaDatos = cmbServicio.getPelosAnimal
        cmbServicio.llenarCombo(cmb_pelo, TablaDatos, "nombre_pelo", "codigo_pelo")



        'El nombre y email del usuario lo conseguimos desde el usuario de la frm_main
        usuario = Frm_main.getUsuario()
        txt_nombre_responsable.Text = usuario.getNombre
        txt_mail_responsable.Text = usuario.getEmail
        txt_telefono_1.Text = usuario.getNumTelefono





    End Sub

    'Funcion que sirve para validar que se hayan rellenado todos los campos obligatorios, caso contrario
    'se informa con una ventana para que cada campo se complete
    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_nombre_animal.Text = String.Empty Then
            txt_nombre_animal.BackColor = Color.Red
            txt_nombre_animal.Focus()
            frm_UsuarioABM.informar_campo_faltante(lbl_nombre_animal.Text)
            Return False
        Else
            txt_nombre_animal.BackColor = Color.White
        End If

        If cmb_raza.SelectedItem Is Nothing Then
            frm_UsuarioABM.informar_campo_faltante(lbl_raza.Text)
            Return False
        End If
        If cmb_color1.SelectedItem Is Nothing Then
            frm_UsuarioABM.informar_campo_faltante(lbl_color_1.Text)
            Return False
        End If
        If cmb_sexo.SelectedItem Is Nothing Then
            frm_UsuarioABM.informar_campo_faltante(lbl_sexo_animal.Text)
            Return False
        End If
        If cmb_edad.SelectedItem Is Nothing Then
            frm_UsuarioABM.informar_campo_faltante(lbl_edad.Text)
            Return False
        End If
        If cmb_tamano.SelectedItem Is Nothing Then
            frm_UsuarioABM.informar_campo_faltante(lbl_tamano.Text)
            Return False
        End If
        If cmb_pelo.SelectedItem Is Nothing Then
            frm_UsuarioABM.informar_campo_faltante(lbl_pelo.Text)
            Return False
        End If

        'Si el usuario no agrego un telefono cuando se dio de alta, vamos a necesitar que agregue al menos uno.
        If txt_telefono_1.Text = "" Then
            If txt_telefono_2.Text = "" Then
                MsgBox("Debe agregar al menos un telefono", MsgBoxStyle.OkOnly, "Error con telefono")
                txt_telefono_2.BackColor = Color.Red
                txt_telefono_2.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub btn_publicar_Click(sender As Object, e As EventArgs) Handles btn_publicar.Click
        If validar_campos() Then
            'Animal  y publicacion que agregaremos a la BD
            Dim unAni As New Animal
            Dim publi As New Publicacion

            'Chequeamos todo lo pertinente al animal de la publicacion.

            'Creamos una variable del tipo booleana para saber que tipo de animal es, si es perro da verdadero
            'Si es gato da falso
            Dim esPerro = (tipo_animal = 1)

            'Si lo que se va a agregar es un perro. 
            If esPerro Then
                unAni.tipoAnimal = 1
                unAni.idAnimal = BDHelper.getDBHelper.generarIdAnimal(tipo_animal)
                unAni.nombre = txt_nombre_animal.Text
                unAni.tamano = cmb_tamano.SelectedValue
                unAni.idTipoPelo = cmb_pelo.SelectedValue
                unAni.idRaza = cmb_raza.SelectedValue
                unAni.idEdad = cmb_edad.SelectedValue
                unAni.idSexo = cmb_sexo.SelectedValue
                unAni.idColor1 = cmb_color1.SelectedValue
                If cmb_color2.SelectedValue IsNot Nothing Then
                    unAni.idColor2 = cmb_color2.SelectedValue
                End If

                If rb_si.Checked Then
                    unAni.idCondicionCastrado = 1
                End If

                If rbtn_no.Checked Then
                    unAni.idCondicionCastrado = 2
                End If

                If rbtn_NoSabe.Checked Then
                    unAni.idCondicionCastrado = 3
                End If

            'Si lo que agregamos es un gato
            Else

            End If


            'Pasamos a la seccion de la informacion adicional y empezamos a completar los datos de
            'la publicacion que se cargara a la BD
            publi.usuario = usuario
            publi.idBarrio = cmb_barrio.SelectedValue
            publi.nombreCiudad = txt_ciudad.Text
            publi.descripcionPublicacion = txt_descripcion.Text
            publi.animal = unAni
            publi.tipoPublicacion = tipo_publicacion

            If publi.usuario.getNumTelefono Is Nothing Then
                usuario.setNumeroTelefono("")
            End If

            If txt_telefono_2.Text IsNot Nothing Then
                publi.telefono2 = txt_telefono_2.Text
            End If



            Dim publiServicio As New PublicacionService
            'Agregamos el animal, pasando como parametro el animal  que queremos
            'Que se agregue a la BD. Segun el tipo de animal, se le dira a la base dedatos a que 
            ' tabla agregar el animal si a perros o a gatos.
            'Esto deberia estar dentro de otra funcion agregarPublicacion()
            'publiServicio.agregarAnimal(unAni)

            publiServicio.agregarPublicacionAdopcion(publi)


        End If


    End Sub
End Class