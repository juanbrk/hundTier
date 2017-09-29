Public Class Frm_perfil_usuario
    'Private Property usuario As Usuario
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

    Private Sub llenar_campos()
        Dim usr = Frm_main.getusuario
        Dim usrService As New UsuariosService

        Dim nombre_barrio = usrService.obtenerNombreBarrioUsuario(usr.getBarrio)
        txt_nombre.Text = usr.getNombre
        txt_apellido.Text = usr.getApellido
        txt_email.Text = usr.getEmail
        txt_username.Text = usr.getUsername

        txt_barrio.Text = nombre_barrio
        txt_password.Text = usr.getPassword
        txt_calle.Text = usr.getCalle
        txt_numero_calle.Text = usr.getNumeroCalle
        txt_depto.Text = usr.getDepartamento
        txt_piso.Text = usr.getPiso
        txt_telefono.Text = usr.getNumTelefono
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

        'TODO chequear que en los campos ingresados se ingresan los valores que deseamos, int o string.
        If validar_campos() Then

            Dim d As DialogResult
            d = MessageBox.Show("¿Desea modificar sus datos?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (d = DialogResult.OK) Then
                Dim usrService As New UsuariosService

                Try
                    'Actualizamos primero la instancia cliente de main para luego actualizar a partir de esa
                    'los datos del usuario en la BD usando la clase UsuariosService,
                    '
                    actualizarUsuario()

                    If usrService.updateUsuario(Frm_main.getusuario) = 1 Then
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

    'Public Function getUsuario() As Usuario
    '    Return usuario
    'End Function

    Private Sub btn_modificar_pass_Click(sender As Object, e As EventArgs) Handles btn_modificar_pass.Click
        'Al presionar el boton creamos una nueva form para modificar la contraseña
        ' y le pasamos el usuario como parametro, asi esta definido el creador de ese form
        Dim form_cambio_password As New frm_modificar_contrasena()
        'mostramos el form
        form_cambio_password.ShowDialog()
        'Si el usuario fue actualizado, esto se chequea con form_cambio_password.getModificado
        'le asignamos al atributo usuario de esta form el valor del usuario actualizado que es el
        'que esta en form_cambio_password
        If form_cambio_password.getModificado() Then
            'usuario = form_cambio_password.getUsuario
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
                If usrService.darDeBajaUsuario(Frm_main.getusuario) = 1 Then
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

    Private Sub actualizarUsuario()
        Frm_main.getusuario().setNombre(txt_nombre.Text)
        Frm_main.getusuario().setApellido(txt_apellido.Text)
        Frm_main.getusuario().setEmail(txt_email.Text)
        Frm_main.getusuario().setBarrio(cmb_barrio.SelectedValue.ToString)
        Frm_main.getusuario().setCalle(txt_calle.Text)
        Frm_main.getusuario().setNumCalle(txt_numero_calle.Text)
        Frm_main.getusuario().setPiso(txt_piso.Text.ToString)
        Frm_main.getusuario().setDepartamento(txt_depto.Text)
        Frm_main.getusuario().set_numTelefono(txt_telefono.Text)
    End Sub
End Class