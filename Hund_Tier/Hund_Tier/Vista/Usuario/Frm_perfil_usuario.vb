Public Class Frm_perfil_usuario
    Private Property usuario As Usuario
    'Bandera o flag, que sirve para saber si se esta en modo edicion o en modo visualizacion
    Private Property bandera_edicion = False
    'Atributo que nos permitira saber desde otra form si los datos fueron cambiados para actualizar
    'los datos que tiene el usuario guardado en la otra form
    Private Property bandera_datos_modificados = False
    'Bandera que nos permitira saber desde otra form si el usuario elimino su cuenta
    Private Property bandera_eliminado = False

    'La clasica strSql que contendra la string que se ejecutara en la BD
    Dim strSql As String = ""


    Enum Opcion
        insert
        update
        delete
    End Enum

    Private Sub Frm_perfil_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ni bien carga el formulario se llenan los campos con los datos del usuario que
        'fue pasado por parametro por frm_main
        llenar_campos()


    End Sub

    'Funcion que nos permite recibir el usuario pasado desde cualquier otra form para
    'cargar los campos con los datos de dicho usuario.
    'TODO agregar un segundo parametro para que verifique como entra a este formulario
    'si es update o que.
    Public Sub seleccionar_usuario(ByVal user As Usuario)
        usuario = user
        'Obtengo el nombre del usuario con el que voy a recuperar los datos
        'de la BD
        'Esto ya lo hago desde login, tengo que volver a hacerlo aca para garantizar que no haya
        'habido cambios en la bd o puedo trabajar con lo que ya obtuve, evitando el acceso a la 
        'BD nuevamente ????????????????????????????????????????????????
        Dim strSql = "Select U.*, B.nombre AS 'nombre_barrio'"
        strSql += " From usuarios  U Join barrios B on U.id_barrio = B.id_barrio"
        strSql += " WHERE U.username = '" & user.getUsername & "'"
        Dim tabla = BDHelper.getDBHelper.ConsultaSQL(strSql)
        If tabla.Rows.Count > 0 Then
            'guardamos las properties que si o si tienen valor 
            usuario.setNombre(tabla.Rows(0).Item("nombre").ToString())
            usuario.setEmail(tabla.Rows(0).Item("email").ToString())
            usuario.setUsername(tabla.Rows(0).Item("username").ToString())
            usuario.setPassword(tabla.Rows(0).Item("password").ToString)
            usuario.setApellido(tabla.Rows(0).Item("apellido").ToString())
            usuario.set_numTelefono(tabla.Rows(0).Item("num_telefono").ToString())
            usuario.setBarrio(tabla.Rows(0).Item("id_barrio"))
            usuario.setCalle(tabla.Rows(0).Item("calle").ToString())
            usuario.setNumCalle(tabla.Rows(0).Item("numero").ToString())
            usuario.setDepartamento(tabla.Rows(0).Item("departamento").ToString())
            usuario.setId(tabla.Rows(0).Item("id_usuario").ToString())
            'Las variables que pueden ser null las chequeamos
            If Not DBNull.Value.Equals(tabla.Rows(0).Item("piso")) Then
                usuario.setPiso(tabla.Rows(0).Item("piso"))
            End If

        End If
    End Sub

    Private Sub llenar_campos()

        Dim usrService As New UsuariosService

        Dim nombre_barrio = usrService.obtenerNombreBarrioUsuario(usuario.getBarrio)
        txt_nombre.Text = usuario.getNombre
        txt_apellido.Text = usuario.getApellido
        txt_email.Text = usuario.getEmail
        txt_username.Text = usuario.getUsername
        'Para completar el campo del barrio del usuario hay que obtener el nombre del barrio
        'de la tabla barrios de la BD haciendo un join 
        txt_barrio.Text = nombre_barrio
        txt_password.Text = usuario.getPassword
        txt_calle.Text = usuario.getCalle
        txt_numero_calle.Text = usuario.getNumeroCalle
        txt_depto.Text = usuario.getDepartamento
        txt_piso.Text = usuario.getPiso
        txt_telefono.Text = usuario.getNumTelefono
        'Cargamos el combo mediante la funcion publica del formulario frm_UsuarioABM que acepta
        'el combo que queremos cargar como parametro
        Dim cmbServicio As New CombosService
        Dim tablaDatos = cmbServicio.getBarrios
        cmbServicio.llenarCombo(cmb_barrio, tablaDatos, "nombre", "ID_BARRIO")
        cmb_barrio.Text = nombre_barrio

    End Sub

    Private Sub btn_modificar_info_Click(sender As Object, e As EventArgs) Handles btn_modificar_info.Click
        bandera_edicion = True
        permitir_edicion(bandera_edicion)
    End Sub

    Private Sub permitir_edicion(ByVal valor As Boolean)
        'Si valor es verdadero, quiere decir que hay que permitir la edicion de los campos, si es falso, hay que negar
        'la edicion de los campos. 
        'TODO poner visibilidad del campo correo electronico en visible en modo edicion y lo contrario
        'en modo visualizacion
        If valor Then
            txt_nombre.ReadOnly = False
            txt_apellido.ReadOnly = False
            txt_telefono.ReadOnly = False
            txt_calle.ReadOnly = False
            txt_numero_calle.ReadOnly = False
            txt_piso.ReadOnly = False
            txt_depto.ReadOnly = False
            txt_barrio.Visible = False
            cmb_barrio.Visible = True

            btn_modificar_info.Visible = False
            btn_salir.Visible = False
            btn_cancelar.Visible = True
            btn_guardar_cambios.Visible = True
        Else
            txt_nombre.ReadOnly = True
            txt_apellido.ReadOnly = True
            txt_telefono.ReadOnly = True
            txt_calle.ReadOnly = True
            txt_numero_calle.ReadOnly = True
            txt_piso.ReadOnly = True
            txt_depto.ReadOnly = True
            txt_barrio.Visible = True
            cmb_barrio.Visible = False

            btn_modificar_info.Visible = True
            btn_salir.Visible = True
            btn_cancelar.Visible = False
            btn_guardar_cambios.Visible = False
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        bandera_edicion = False
        permitir_edicion(bandera_edicion)
    End Sub

    Private Sub btn_guardar_cambios_Click(sender As Object, e As EventArgs) Handles btn_guardar_cambios.Click
        'Como hacemos para ejecutar la consulta del update pero con parametros, asi me aseguro que lo que pone
        'en los campos no me modifica la BD ?????????????????
        'TODO chequear que en los campos ingresados se ingresan los valores que deseamos, int o string.
        If validar_campos() Then
            'If frm_UsuarioABM.existe_mail() Then
            '
            'Else
            'End If
            Dim d As DialogResult
            d = MessageBox.Show("¿Desea modificar sus datos?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (d = DialogResult.OK) Then
                Dim usrService As New UsuariosService

                usuario.setNombre(txt_nombre.Text)
                usuario.setApellido(txt_apellido.Text)
                usuario.setEmail(txt_email.Text)
                usuario.setBarrio(cmb_barrio.SelectedValue.ToString)
                usuario.setCalle(txt_calle.Text)
                usuario.setNumCalle(txt_numero_calle.Text)
                usuario.setPiso(txt_piso.Text.ToString)
                usuario.setDepartamento(txt_depto.Text)
                usuario.set_numTelefono(txt_telefono.Text)

                Try
                    'Actualizamos al cliente mediante la clase UsuariosService,
                    '
                    If usrService.updateUsuario(usuario) = 1 Then
                        MessageBox.Show("Sus datos fueron actualizados!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        llenar_campos()
                        permitir_edicion(False)
                        Frm_main.setModificado(True)

                    End If
                Catch ex As Exception
                    MsgBox("Error al Actualizar el cliente", MsgBoxStyle.OkOnly, "Base de Datos")
                End Try

            End If
        End If


    End Sub

    'Funcion que sirve para validar que se hayan rellenado todos los campos obligatorios, caso contrario
    'se informa con una ventana para que cada campo se complete
    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_nombre.Text = String.Empty Then
            txt_nombre.BackColor = Color.Red
            txt_nombre.Focus()
            frm_UsuarioABM.informar_campo_faltante(lbl_nombre.Text)
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If

        If txt_apellido.Text = String.Empty Then
            txt_apellido.BackColor = Color.Red
            txt_apellido.Focus()
            frm_UsuarioABM.informar_campo_faltante(lbl_apellido.Text)
            Return False
        Else
            txt_apellido.BackColor = Color.White
        End If
        If txt_email.Text = String.Empty Then
            txt_email.BackColor = Color.Red
            txt_email.Focus()
            frm_UsuarioABM.informar_campo_faltante(lbl_email.Text)
            Return False
        Else
            txt_email.BackColor = Color.White
        End If
        If cmb_barrio.SelectedItem Is Nothing Then
            frm_UsuarioABM.informar_campo_faltante(lbl_barrio.Text)
            Return False
        End If

        Return True
    End Function

    Public Function modifico_datos() As Boolean
        Return bandera_datos_modificados
    End Function

    Public Function elimino_cuenta() As Boolean
        Return bandera_datos_modificados
    End Function

    Public Function getUsuario() As Usuario
        Return usuario
    End Function

    Private Sub btn_modificar_pass_Click(sender As Object, e As EventArgs) Handles btn_modificar_pass.Click
        'Al presionar el boton creamos una nueva form para modificar la contraseña
        ' y le pasamos el usuario como parametro, asi esta definido el creador de ese form
        Dim form_cambio_password As New frm_modificar_contrasena(usuario)
        'mostramos el form
        form_cambio_password.ShowDialog()
        'Si el usuario fue actualizado, esto se chequea con form_cambio_password.getModificado
        'le asignamos al atributo usuario de esta form el valor del usuario actualizado que es el
        'que esta en form_cambio_password
        If form_cambio_password.getModificado() Then
            usuario = form_cambio_password.getUsuario
            'llenamos los campos nuevamente, porque si se quiere volver a modificar la contra
            'tengo que tener en el campo contraseña el valor actualizado
            llenar_campos()
        End If
    End Sub

    Private Sub lbl_eliminar_usuario_Click(sender As Object, e As EventArgs) Handles lbl_eliminar_usuario.Click
        'Si hacen click en este label, se hara un borrado lógico del usuario para que ya no "exista"
        'Primero le mostramos una ventana preguntando si realmente quiere eliminar la cuenta
        Dim d As DialogResult
        d = MessageBox.Show("¿Desea eliminar su cuenta?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        'Si responde que si, lo borramos
        If (d = DialogResult.OK) Then
            Dim str_sql_borrado = ""
            Dim usrService As New UsuariosService
            ' el borrado es solo borrado logico, se cambia el valor del campo habilitado en la BD
            'se actualiza a 0. Lo que indica que no esta habilitado
            Try
                If usrService.darDeBajaUsuario(usuario) = 1 Then
                    MessageBox.Show("Lamentamos verte ir, ¡buen viaje!", "Cuenta eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Frm_main.setEliminado(True)
                    Me.Close()
                Else
                    MessageBox.Show("Ocurrio un error con la operacíon ", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_salir_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class