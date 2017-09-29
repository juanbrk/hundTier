Public Class frm_modificar_contrasena
    Private Property usuario As Usuario
    Private Property bandera_modificado As Boolean
    Enum Err
        passwords_no_coinciden
        contrasena_actual_no_coincide
        email_existente
    End Enum

    'Es el constructor de la form, se le debe pasar un usuario como parametro
    'de ese usuario obtendremos la contraseña
    'Cuando se crea la form se establece la variable modificado a false
    'Se establecera a true si el usuario modifico su contraseña
    Public Sub New(ByVal usuario_pasado As Usuario)
        InitializeComponent()
        bandera_modificado = False
        usuario = usuario_pasado
    End Sub


    Public Function getModificado()
        Return bandera_modificado
    End Function

    Public Function getUsuario() As Usuario
        Return usuario
    End Function

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim str_sql = ""
        Dim usrService As New UsuariosService
        If validar_campos() Then

            'Si esta todo OK debo chequear que
            'la contraseña actual coincida con la del usuario
            If usrService.existeUsuario(usuario.getUsername, txt_pass_actual.Text) Then

                'Si la contraseña coincide, puedo actualizar la contraseña del usuario por
                'la ingresada. Primero le pregunto si esta seguro de querer cambiar la contra
                Dim d As DialogResult

                d = MessageBox.Show("¿Desea modificar sus datos?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                'Si el usuario esta de acuerdo con cambiar la contraseña, es decir, selecciona
                'el boton ok, lo actualizamos
                If (d = DialogResult.OK) Then

                    'Le asignamos al usuario en visual la nueva contraseña como atributo
                    'para poder pasarlo entre forms, ya actualizado. 
                    usuario.setPassword(txt_nueva_pass.Text)

                    Try

                        'Si la ejecucion de la actualizacion devuelve una fila entonces ya esta actualizado el usuario
                        If usrService.updateUsuario(usuario) = 1 Then

                            'Se le informa al usuario mediante msgbox
                            MessageBox.Show("Sus datos fueron actualizados!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            'Modificamos el valor de la bandera, para que otras forms puedan consultar
                            'si el usuario modifico su pass. 
                            bandera_modificado = True
                            Me.Close()
                        End If
                    Catch ex As Exception

                    End Try
                End If
            Else
                informar_error(Err.contrasena_actual_no_coincide)
            End If

        End If
    End Sub
    Private Function validar_campos() As Boolean

        'campos obligatorios
        If txt_pass_actual.Text = String.Empty Then
            txt_pass_actual.BackColor = Color.Red
            txt_pass_actual.Focus()
            frm_UsuarioABM.informar_campo_faltante(lbl_pass_actual.Text)
            Return False
        Else
            txt_pass_actual.BackColor = Color.White
        End If
        If txt_nueva_pass.Text = String.Empty Then
            txt_nueva_pass.BackColor = Color.Red
            txt_nueva_pass.Focus()
            frm_UsuarioABM.informar_campo_faltante(lbl_nueva_pass.Text)
            Return False
        Else
            txt_nueva_pass.BackColor = Color.White
        End If
        If txt_confirmar_pass.Text = String.Empty Then
            txt_confirmar_pass.BackColor = Color.Red
            txt_confirmar_pass.Focus()
            frm_UsuarioABM.informar_campo_faltante(lbl_confirmar_nueva_pass.Text)
            Return False
        Else
            txt_confirmar_pass.BackColor = Color.White
        End If
        If txt_nueva_pass.Text <> txt_confirmar_pass.Text Then

            'Deberia hacerlo con el metodo informar error de ABM pero no puedo porque el tipo de 
            'parametro que acepta es privado dentro de la clase ABM, por lo que no puedo accederla
            informar_error(Err.passwords_no_coinciden)
            txt_nueva_pass.BackColor = Color.Red
            txt_confirmar_pass.BackColor = Color.Red
            txt_nueva_pass.Focus()

            Return False
        Else
            txt_nueva_pass.BackColor = Color.White
            txt_confirmar_pass.BackColor = Color.White
        End If
        Return True
    End Function

    'Funcion que, dependiendo del error que este sucediendo, lo informa. El tipo de error se pasa por
    'parametro como una variable del tipo Err definida arriba de todo en esta clase.
    Friend Sub informar_error(ByVal identificador As Err)
        Select Case identificador
            Case Err.contrasena_actual_no_coincide
                MessageBox.Show("La contraseña ingresada es incorrecta",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case Err.passwords_no_coinciden
                MessageBox.Show("Las contraseñas ingresadas no coinciden",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
End Class
