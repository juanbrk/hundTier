Public Class Frm_main
    'Idem fmr_loguin
    Dim usuario As Usuario
    Dim bandera_eliminado = False
    Dim bandera_modificado = True
    Dim form_logueo As New frm_login

    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar el formulario principal cargamos y mostramos el formulario: Frm_login en forma MODAL.
        form_logueo.ShowDialog()
        If form_logueo.getValidado Then
            usuario = form_logueo.getUsuario()
            actualizarUsuarioLogueado(usuario.getUsername)
        Else
            Me.Close()
        End If
    End Sub

    Public Sub actualizarUsuarioLogueado(ByVal userLogin As String)
        lbl_nombre_usuario.Text = userLogin
        mnu_frm_main.Visible = True
    End Sub

    Private Sub MiPerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiPerfilToolStripMenuItem.Click
        'Creamos un objeto form_ajuste_perfil del tipo Frm_perfil_usuario asi le podemos
        'asignar un usuario como atributo de ese form, para que cuando mostremos el form
        'podamos cargar los campos con los datos del usuario pasado.
        Dim form_ajuste_perfil As New Frm_perfil_usuario
        form_ajuste_perfil.seleccionar_usuario(usuario)
        form_ajuste_perfil.ShowDialog()
        If bandera_eliminado Then
            form_logueo.limpiarCampos()
            form_logueo.ShowDialog()
            Me.Hide()

        End If

        'Si el usuario en lugar de modificar sus datos elimino la cuenta, entonces le cerramos
        'sesion y mostramos el login
        'ElseIf form_ajuste_perfil.elimino_cuenta() Then
        'usuario = Nothing
        'Me.Close()
        'COMO VOLVER A INICIAR EL PROCESO UNA VEZ QUE EL USUARIO ELIMINO SU CUENTA
        'PARA QUE DESDE MAIN ME LLEVE A LOGIN NUEVAMENTE
        '????????????????????????????????????????????????????????????????
        'End If
    End Sub

    Public Sub setUsuario(ByVal user As Usuario)
        usuario = user
    End Sub
    Public Sub setEliminado(valor As Boolean)
        bandera_eliminado = valor
    End Sub
End Class