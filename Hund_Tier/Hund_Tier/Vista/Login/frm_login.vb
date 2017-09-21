Public Class frm_login

    'La property usuario es una variable del tipo Usuario de Visual studio donde se 
    'guardaran los datos del usuario traido desde la BD. De esta manera será mas facil para pasar
    'los datos del usuario de una form a otra sin tener que volver a entrar a la BD
    Private Property usuario As Usuario
    'La variable validado estará en false hasta que un usuario se loguee correctamente
    'ahi pasara a true. Se pedira desde frm_main para saber si se logueo algun usuario
    Private Property validado = False


    'TODO permitir iniciar sesion con username ademas de mail. 

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim strSQL As String
        Dim tabla As DataTable
        'Validamos que las cajas no esten vacías
        'If String.IsNullOrEmpty(txt_password.Text) Or String.IsNullOrEmpty(txt_usuario.Text) Then
        If txt_password.Text = String.Empty Or txt_email.Text = String.Empty Then
            MessageBox.Show("Olvidó ingresar email y/o password", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' El usuario puede loguearse con email o username
            strSQL = "Select * From USUARIOS u Where  ((u.email = '" & txt_email.Text & "' AND u.password = '" & txt_password.Text & "') AND u.habilitado=1) OR ((u.username = '" & txt_email.Text & "' AND u.password = '" & txt_password.Text & "') AND u.habilitado=1)"
            '"Select u.id_usuario,u.email AS 'email_usuario' , u.nombre AS 'nombre_usuario', username From Usuarios u Where (u.email = '" & txt_email.Text & "' OR u.username = '" & txt_email.Text & "') AND u.password = '" & txt_password.Text & "'"
            '
            tabla = BDHelper.getDBHelper().ConsultaSQL(strSQL)
            If tabla.Rows.Count > 0 Then
                'Si la tabla devuelve una fila con un usuario, creamos un objeto usuario de Visual
                ' y le asignamos las variables nombre, username y email a las del usuario
                'que devolvio la tabla desde la BD. 
                usuario = New Usuario
                usuario.setNombre(tabla.Rows(0).Item("nombre").ToString())
                usuario.setEmail(tabla.Rows(0).Item("email").ToString())
                usuario.setBarrio(tabla.Rows(0).Item("id_barrio").ToString())
                usuario.setUsername(tabla.Rows(0).Item("username").ToString())
                usuario.setPassword(tabla.Rows(0).Item("password").ToString)
                'Seteamos validado a true, entonces desde frm_main podremos saber si
                'fue efectivo el login, para saber si actualizar el lbl de nombre de usuario
                'o si se cancela el inicio de sesion para que la frm_main no se muestre
                validado = True
                Me.Close()
            Else
                MessageBox.Show("Usuario y/o password incorrectos", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Limpiamos las cajas de texto y dejamos el cursor sobre el control: txt_usuario.
                txt_password.Text = String.Empty
                txt_email.Text = String.Empty
                txt_email.Focus()
            End If
        End If
    End Sub

    Private Sub lbl_registrate_Click(sender As Object, e As EventArgs) Handles lbl_registrate.Click
        frm_UsuarioABM.ShowDialog()
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        solicitar_iniciar_sesion()
    End Sub

    'Funcion que solo muestra una ventana informando sobre la necesidad de ingresar usuario y contraseña
    Friend Sub solicitar_iniciar_sesion()
        MessageBox.Show("Por favor ingrese su email y contraseña", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        'End termina la ejecucion de la app
        End
    End Sub
    Public Function getUsuario() As Usuario
        Return usuario
    End Function

    Public Function getValidado() As Boolean
        Return validado
    End Function

    Private Sub lbl_info_username_Click(sender As Object, e As EventArgs) Handles lbl_info_username.Click
        MessageBox.Show("Si no recuerda su nombre de usuario puede intentar con su email", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Funcion que elimina los valores de los campos de texto de la form
    Public Sub limpiarCampos()
        txt_email.Text = ""
        txt_password.Text = ""
    End Sub
End Class