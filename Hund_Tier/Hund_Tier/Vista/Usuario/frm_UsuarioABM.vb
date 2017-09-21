Public Class frm_UsuarioABM

    'Definimos unas variables error para poder usar a la hora de enviar mensajes de error
    Enum Err
        password_no_coinciden
        username_existente
        email_existente
    End Enum
    Dim usuario As Usuario
    Dim agregado As Integer

    Dim str_sql As String = ""

    'Definimos una variable _error con un valor por defecto
    Private _error As Err = Err.email_existente

    'Funcion que se ejecuta cuando se carga el formulario, es la primer funcion que se ejecuta
    'carga el combo barrio con los barrios de la BD
    Private Sub frm_UsuarioABM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo(cmb_barrio, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Barrios WHERE 1 = 1"), "nombre", "id_barrio")
    End Sub



    Private Sub btn_add_user_Click(sender As Object, e As EventArgs) Handles btn_add_user.Click
        Dim id_usuario = 0
        If validar_campos() Then

            If existe_mail() Then
                informar_error(Err.email_existente)
            ElseIf existe_username() Then
                informar_error(Err.username_existente)
            Else
                'El id del usuario a agregar en la BD se generará automaticamente mediante una funcion
                'de la clase bd helper que chequea cuantas filas hay en la tabla, segun ese resultado
                'le suma uno y ese es el nuevo id que tendra el usuario
                id_usuario = BDHelper.getDBHelper.generarId("Usuarios")
                usuario = New Usuario
                'Agregamos los valores a la string que ira a la BD como comando
                usuario.setId(id_usuario)
                usuario.setNombre(txt_nombre.Text)
                usuario.setApellido(txt_apellido.Text)
                usuario.setEmail(txt_email.Text)
                usuario.setBarrio(cmb_barrio.SelectedValue)
                usuario.setUsername(txt_username.Text)
                usuario.setPassword(txt_password.Text)
                'El 1 es el valor de la columna habilitado, que habilita al usuario.
                usuario.setHabilitado(1)

                'Usamos un service y un DAO para no hacer codigo en esta capa sino dejarlo todo a la capa de los
                'Dao
                Dim usrService As UsuariosService = New UsuariosService()

                Try
                    'Si se ejecuto bien la insercion a la BD, devolvera un int distinto de 0 y se muestra un
                    'mensaje que lo informa
                    If usrService.agregarUsuario(usuario) = 1 Then
                        MessageBox.Show("Se registro el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        frm_login.solicitar_iniciar_sesion()
                        Me.Close()
                    Else
                        MsgBox("Error al agregar el usuario")
                    End If
                Catch ex As Exception
                    MsgBox("Error al agregar barrio, probablemente el nombre ya exista", MsgBoxStyle.OkOnly, "Error")
                End Try



            End If
        End If


    End Sub

    'Funcion que permite determinar si el mail ingresado ya ha sido utilizado por otro usuario
    'No deberian estar estas funciones friend en algun otro lugar separado????????????????
    Friend Function existe_mail() As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from Usuarios where email = '" + txt_email.Text + "'").Rows.Count > 0
    End Function
    'Funcion que permite determinar si el nombre de usuario ingresado ya ha sido utilizado por otro usuario
    Private Function existe_username() As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from Usuarios where username = '" + txt_username.Text + "'").Rows.Count > 0
    End Function

    'Funcion que sirve para validar que se hayan rellenado todos los campos obligatorios, caso contrario
    'se informa con una ventana para que cada campo se complete
    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_nombre.Text = String.Empty Then
            txt_nombre.BackColor = Color.Red
            txt_nombre.Focus()
            informar_campo_faltante(lbl_nombre.Text)
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If

        If txt_apellido.Text = String.Empty Then
            txt_apellido.BackColor = Color.Red
            txt_apellido.Focus()
            informar_campo_faltante(lbl_apellido.Text)
            Return False
        Else
            txt_apellido.BackColor = Color.White
        End If

        If cmb_barrio.SelectedItem Is Nothing Then
            informar_campo_faltante(lbl_barrio.Text)
            Return False
        End If
        If txt_email.Text = String.Empty Then
            txt_email.BackColor = Color.Red
            txt_email.Focus()
            informar_campo_faltante(lbl_email.Text)
            Return False
        Else
            txt_email.BackColor = Color.White
        End If


        If txt_password.Text = String.Empty Then
            txt_password.BackColor = Color.Red
            txt_password.Focus()
            informar_campo_faltante(lbl_password.Text)
            Return False
        Else
            txt_password.BackColor = Color.White
        End If

        If txt_confirmarPass.Text = String.Empty Then
            txt_confirmarPass.BackColor = Color.Red
            txt_confirmarPass.Focus()
            informar_campo_faltante(lbl_confirmarPass.Text)
            Return False
        Else
            txt_confirmarPass.BackColor = Color.White
        End If

        If txt_confirmarPass.Text <> txt_password.Text Then
            informar_error(Err.password_no_coinciden)
            txt_confirmarPass.BackColor = Color.Red
            txt_password.BackColor = Color.Red
            txt_confirmarPass.Focus()

            Return False
        Else
            txt_confirmarPass.BackColor = Color.White
            txt_confirmarPass.BackColor = Color.White
        End If

        If txt_username.Text = String.Empty Then
            txt_username.BackColor = Color.Red
            txt_username.Focus()
            informar_campo_faltante(lbl_username.Text)
            Return False
        Else
            txt_username.BackColor = Color.White
        End If

        Return True
    End Function

    'Funcion que informa con una ventana de error el campo que falto rellenar.
    Friend Function informar_campo_faltante(ByVal campoFalta As String)
        MessageBox.Show("El campo " & campoFalta & " es obligatorio, por favor completelo",
                            "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Function

    'Funcion que, dependiendo del error que este sucediendo, lo informa. El tipo de error se pasa por
    'parametro como una variable del tipo Err definida arriba de todo en esta clase.
    Friend Function informar_error(ByVal identificador As Err)
        Select Case identificador
            Case Err.email_existente
                MessageBox.Show("La direccion de email ingresada ya tiene una cuenta asociada, por favor ingrese otra direccion",
                                "Email duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case Err.username_existente
                MessageBox.Show("El nombre de usuario ingresado no está disponible, por favor ingrese otro",
                                "Nombre de usuario no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case Err.password_no_coinciden
                MessageBox.Show("Las contraseñas ingresadas no coinciden",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

    End Function

    'Definimos un procedimiento Friend (Amigo) para poder utilizarlo desde otro formulario, que permita cargar un combo a partir de:
    'Componente combo
    'Source, una lista de objetos
    'Nombre de la property a mostrar en el displayMember del componente
    'Nombre de la property a almacenar en el valueMember del componente
    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

End Class