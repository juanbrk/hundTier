Public Class frm_publicar_aviso
    Dim usuario As Usuario
    'Booleano que permite saber si las fechas ingresadas son validas.
    Dim flagFechas = False
    Enum TipoAnimal As Integer
        perro = 1
        gato = 2
    End Enum
    'Bandera que me permite saber si lo que se publicara es un gato(tipoAnimal = 2) o un perro (tipoAnimal = 1)
    'Por defecto es 1
    Dim tipo_animal = TipoAnimal.perro

    Enum AccionUsuario As Integer
        adopcion = 1
        perdido = 2
        encontrado = 3
        busqueda = 4
    End Enum

    Friend Enum idCastrado As Integer
        si = 1
        no = 2
        desconoce = 3
    End Enum
    'Bandera para saber que tipo de publicacion es, adopcion = 1, perdido = 2, encontrado = 3
    Dim accion_usuario = 1
    'Cuando carga la form hay que cargar los combos Barrio y los campos nombre y email con los datos del 
    'usuario

    'Instancia de PublicacionService para usar en los distintos metodos
    Dim publiServicio As New PublicacionService
    Private Sub frm_publicar_aviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCampos()
        usuario = Frm_main.getusuario()

    End Sub

    Public Sub setTitulo(titulo As String)
        Me.Text = titulo
    End Sub
    Public Sub setTipoAnimal(valor As Integer)
        tipo_animal = valor
    End Sub
    Public Sub setTipoPublicacion(valor As Integer)
        accion_usuario = valor
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
        If tipo_animal = TipoAnimal.perro Then
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

        'Carga de combos que son iguales tanto para perros como para gatos, de aca para abajo. 


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

        'Si el tipo de publicacion es cualquiera menos busqueda cargamos los nombres del usuario
        'Si es busqueda no necesitamos el nombre del usuario
        If accion_usuario <> AccionUsuario.busqueda Then

            'El nombre y email del usuario lo conseguimos desde el usuario de la frm_main
            usuario = Frm_main.getusuario()
            txt_nombre_responsable.Text = usuario.getNombre
            txt_mail_responsable.Text = usuario.getEmail
            txt_telefono_1.Text = usuario.getNumTelefono

            'Si el tipo de publicacion es busqueda anulamos los campos que no hacen falta para la 
            'busqueda. 
        Else

            txt_descripcion.ReadOnly = True
            txt_telefono_2.ReadOnly = True

        End If






    End Sub

    'Funcion que sirve para validar que se hayan rellenado todos los campos obligatorios, caso contrario
    'se informa con una ventana para que cada campo se complete
    Private Function validar_campos() As Boolean

        'Si el tipo de publicacion es cualquiera menos busqueda, validamos los campos obligatorios y demas

        If accion_usuario <> AccionUsuario.busqueda Then
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

            ' Si el tipo de publicacion es una busqueda Validamos que haya ingresado algo. 
        Else
            If txt_nombre_animal.Text = String.Empty Then
                If cmb_raza.SelectedItem Is Nothing Then
                    If cmb_color1.SelectedItem Is Nothing Then
                        If cmb_color2.SelectedItem Is Nothing Then
                            If cmb_sexo.SelectedItem Is Nothing Then
                                If cmb_edad.SelectedItem Is Nothing Then
                                    If cmb_pelo.SelectedItem Is Nothing Then
                                        If cmb_barrio.SelectedItem Is Nothing Then
                                            If cmb_tamano.SelectedItem Is Nothing Then
                                                MsgBox("Debe completar al menos un campo para continuar", MsgBoxStyle.OkOnly, "Error ")
                                                Return False
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If


        End If


        Return True
    End Function

    Private Sub btn_publicar_Click(sender As Object, e As EventArgs) Handles btn_publicar.Click
        If validar_campos() Then
            ' Animal  y publicacion que agregaremos a la BD o con los que buscaremos un animal
            Dim unAni As New Animal
            Dim publi As New Publicacion

            'Si el usuario esta haciendo una publicacion ´se crea una publiacion y se la carga con
            'los datos del animal, usuario y la publicacion.
            If accion_usuario <> AccionUsuario.busqueda Then

                'Chequeamos todo lo pertinente al animal de la publicacion.

                ' Creamos una variable del tipo booleana para saber que tipo de animal es, si es perro da verdadero
                ' Si es gato da falso
                Dim esPerro = (tipo_animal = TipoAnimal.perro)

                ' Si lo que se va a agregar es un perro. 
                If esPerro Then
                    unAni.tipoAnimal = TipoAnimal.perro
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

                    ' Si lo que agregamos es un gato
                Else

                End If

                ' Pasamos a la seccion de la informacion adicional y empezamos a completar los datos de
                ' la publicacion que se cargara a la BD
                publi.usuario = usuario
                publi.idBarrio = cmb_barrio.SelectedValue
                publi.nombreCiudad = txt_ciudad.Text
                publi.descripcionPublicacion = txt_descripcion.Text
                publi.animal = unAni
                publi.tipoPublicacion = accion_usuario

                If publi.usuario.getNumTelefono Is Nothing Then
                    usuario.setNumeroTelefono("")
                End If

                If txt_telefono_2.Text IsNot Nothing Then
                    publi.telefono2 = txt_telefono_2.Text
                End If

                ' Por ahora no mostramos confirmacion con los datos de la publicacion
                '  Solo un cartelito que diga estas seguro que deseas publicar. 

                Dim d As DialogResult
                d = MessageBox.Show("¿Desea continuar y realizar la publicacion?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If (d = DialogResult.OK) Then

                    ' Con todos los datos de la publicacion, la cargamos en la BD mediante la clase PublicacionService
                    ' Pasandole la publicacion como parametro.

                    ' Si la publicacion se cargo correctamente en la BD mostramos una ventana de confirmacion. 
                    If publiServicio.agregarPublicacionAdopcion(publi) = 1 Then
                        MessageBox.Show("La publicacion fue realizada con éxito", "Exito", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        Me.Close()
                    End If

                End If

                'Si el usuario esta realizando una busqueda accion_usuario = TipoUsuario.busqueda
                'Se busca entre todas las publicaciones con los datos del animal proporcionado
            Else
                'Definimos una lista de publicaciones que es la que le vamos a pasar a la siguiente
                ' Ventana

                Dim lstPubli As List(Of Publicacion)

                'Completamos los datos del animal que se quiere encontrar

                'Vamos a hacer la consulta en la BD con parametros. Es decir con una lista de filtros
                Dim filters As New List(Of Object)

                If txt_nombre_animal.Text <> "" Then
                    'Si el txt tiene un texto no vacìo entonces enviamos como filtro el nombre del animal a consultar
                    filters.Add(txt_nombre_animal.Text)
                Else
                    filters.Add(Nothing)
                End If 'Fin if de nombreANimal.text

                'Agregamos el tipo del animal que se busca
                filters.Add(tipo_animal)

                If Not cmb_raza.SelectedItem Is Nothing Then
                    'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro la raza  a consultar
                    filters.Add(cmb_raza.SelectedValue)
                Else
                    filters.Add(Nothing)
                End If ' If de cmbRaza.selectedVAlue

                If Not cmb_color1.SelectedItem Is Nothing Then
                    'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del color a consultar
                    filters.Add(cmb_color1.SelectedValue)
                Else
                    filters.Add(Nothing)
                End If

                If Not cmb_color2.SelectedItem Is Nothing Then
                    'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del color a consultar
                    filters.Add(cmb_color2.SelectedValue)
                Else
                    filters.Add(Nothing)
                End If

                If Not cmb_edad.SelectedItem Is Nothing Then
                    'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id de la edad a consultar
                    filters.Add(cmb_edad.SelectedValue)
                Else
                    filters.Add(Nothing)
                End If

                If Not cmb_sexo.SelectedItem Is Nothing Then
                    'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del sexo a consultar
                    filters.Add(cmb_sexo.SelectedValue)
                Else
                    filters.Add(Nothing)
                End If

                If Not cmb_tamano.SelectedItem Is Nothing Then
                    'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del tamaño a consultar
                    filters.Add(cmb_tamano.SelectedValue)
                Else
                    filters.Add(Nothing)
                End If

                If Not cmb_pelo.SelectedItem Is Nothing Then
                    'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del pelo a consultar
                    filters.Add(cmb_pelo.SelectedValue)
                Else
                    filters.Add(Nothing)
                End If

                If Not cmb_barrio.SelectedItem Is Nothing Then
                    'Si el cbo tiene un valor distinto de nulo entonces enviamos como filtro el id del barrio a consultar
                    filters.Add(cmb_barrio.SelectedValue)
                Else
                    filters.Add(Nothing)
                End If


                ' Agregamos el nombre de la ciudad
                filters.Add(txt_ciudad.Text)


                ' TODO arreglar el tema de las fechas. Tengo formato dd/mm/yy y no me lo permite

                'Mostramos las fechas para las cuales se va a realizar la busqueda y esperamos el resultado
                'Dim frm_seleccionFechas As New Frm_fechasBusqueda
                'frm_seleccionFechas.ShowDialog()

                'Si las fechas son validas (El usuario apreto OK y se validaron las fechas) las agregamos a los filtros

                'If frm_seleccionFechas.flagFechas Then
                '    filters.Add(frm_seleccionFechas.getFechaDesde)
                '    filters.Add(frm_seleccionFechas.getFechaHasta)
                'Else
                '    filters.Add(Nothing)
                '    filters.Add(Nothing)
                'End If

                'Chequeamos los radiobuttons a ver cual esta chequeado
                If rb_si.Checked Then
                    filters.Add(idCastrado.si)
                Else
                    If rbtn_no.Checked Then
                        filters.Add(idCastrado.no)
                    Else
                        If rbtn_NoSabe.Checked Then
                            filters.Add(idCastrado.desconoce)
                        Else
                            filters.Add(Nothing)
                        End If
                    End If
                End If

                'Con todos los filtros agregados vamos a buscar en la BD para mostrar en la grilla 
                ' De la siguiente ventana. 
                lstPubli = publiServicio.consultarPublicacionesConFiltro(filters.ToArray)

                ' Chequeamos la cantidad de objetos que contiene la lista devuelta para saber si se 
                ' encontraron coincidencias o no
                If lstPubli.Count <> 0 Then
                    'Si la lista no esta vacia se muestra el form donde se listan las publicaciones obtenidas
                    Dim listarPublicacionesFrm As New frm_listarPublicaciones
                    listarPublicacionesFrm.llenarGrid(lstPubli)
                    listarPublicacionesFrm.ShowDialog()

                Else
                    'Si la lista esta vacia se le avisa al usuario
                    MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados",
                   "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If 'If de TipoAccionUsuario <> TipoAccionUsuario.busqueda
        End If 'If de validarCampos()




    End Sub


End Class