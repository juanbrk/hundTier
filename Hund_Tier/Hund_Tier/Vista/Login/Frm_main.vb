Public Class Frm_main
    'TODO aplicar el patron singleton para la variable usuario. Para que pueda ser accedida global
    'mente desde todas las forms

    'RESOLVER el tema de cuando un usuario elimina la cuenta y como hacer para que se vuelva a 
    'Iniciar el proceso de login. 

    Dim bandera_eliminado = False
    Dim bandera_modificado = False
    'Definimos una unica instancia de frm_login patron singleton
    Private Shared instancia_form_logueo As frm_login

    'Patron singleton para usuario
    Private Shared instanciaUsuario As Usuario


    'Bandera que sirve para saber si esta form esta escondida para poder mostrarla despues del logueo
    Dim bandera_escondida = False

    'Bandera que sirve para saber que selecciona el usuario para cuando se muestre la form
    'de seleccion de tipo de aviso, puede ser para buscar animales o para publicar una nueva
    'publicacion
    Enum SeleccionUsuario As Integer
        publicarAviso
        buscarAnimales
    End Enum

    Public Shared Function getInstanciaLogin() As frm_login
        If IsNothing(instancia_form_logueo) Then
            instancia_form_logueo = New frm_login()
        End If
        Return instancia_form_logueo
    End Function

    Public Shared Function getusuario() As Usuario
        If IsNothing(instanciaUsuario) Then
            instanciaUsuario = New Usuario()
        End If
        Return instanciaUsuario
    End Function

    Public Shared Sub inicializarUsuario(usr As Usuario)

    End Sub


    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bandera_escondida = True

        'Al cargar el formulario principal cargamos y mostramos el formulario: Frm_login en forma MODAL.
        mostrarLoginForm()

        ' instancia_form_logueo.ShowDialog()

        If instancia_form_logueo.getValidado Then
            'Si esta ventana estaba escondida , mostramos la ventana. 
            mostrarMain()

            actualizarUsuario(instanciaUsuario.getUsername)
        Else
            Me.Close()
        End If
    End Sub

    'Funcion para mostrar la ventana de login
    Private Sub mostrarLoginForm()
        getInstanciaLogin().ShowDialog()
        getInstanciaLogin.setEscondido(True)

    End Sub

    Private Sub mostrarMain()
        'Si esta ventana estaba escondida, es decir si se estaba mostrando la ventana
        'de login, entonces mostramos la ventana. 
        If bandera_escondida Then
            bandera_escondida = False
            Me.Show()
        End If
    End Sub

    Public Sub actualizarUsuario(ByVal userLogin As String)
        Dim user As Usuario
        lbl_nombre_usuario.Text = userLogin
        mnu_frm_main.Visible = True
    End Sub

    Private Sub MiPerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiPerfilToolStripMenuItem.Click
        'Creamos un objeto form_ajuste_perfil del tipo Frm_perfil_usuario asi le podemos
        'asignar un usuario como atributo de ese form, para que cuando mostremos el form
        'podamos cargar los campos con los datos del usuario pasado.
        Dim form_ajuste_perfil As New Frm_perfil_usuario
        'form_ajuste_perfil.seleccionar_usuario(instanciaUsuario)
        form_ajuste_perfil.ShowDialog()
        'Si el usuario elimino su cuenta tenemos que cerrar este formulario, borrar los datos del usuario y mandarlo
        'al form login de vuelta. 
        If bandera_eliminado Then
            Me.Hide()
            bandera_escondida = True
            'Si el usuario lo unico que hizo fueron modificar sus datos, cuando se cierre la ventana en la que estaba haciendo cambios
            'hay que actualizar el usuario de este form por el modificado. 
        ElseIf bandera_modificado Then
            Dim usrService As New UsuariosService
            instanciaUsuario = usrService.obtenerUsuario(instanciaUsuario.getUsername, instanciaUsuario.getPassword)


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
        instanciaUsuario = user
    End Sub
    Public Sub setEliminado(valor As Boolean)
        bandera_eliminado = valor
    End Sub
    Public Sub setModificado(valor As Boolean)
        bandera_modificado = True
    End Sub

    Private Sub lbl_agregar_publicacion_Click(sender As Object, e As EventArgs) Handles lbl_agregar_publicacion.Click
        mostrarFormSeleccionTipoAvisoPara(SeleccionUsuario.publicarAviso)
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click

    End Sub

    Private Sub btn_busqueda_Click(sender As Object, e As EventArgs) Handles btn_busqueda.Click
        'se muestra el form seleccion Tipo aviso, se le pasa por parametro un entero que dice si vamos a agregar
        'Un nuevo aviso o si vamos a consultar la BD para ver los animales. 
        mostrarFormSeleccionTipoAvisoPara(SeleccionUsuario.buscarAnimales)
    End Sub

    'Funcion que permite pasar un parametro para que las siguientes forms sepan cual es la 
    'eleccion del usuario. Si es hacer una nueva publicacion de un animal encontrado, perdido
    'o en adopcion; o si es para buscar un animal. No cambia en nada como se presentan los siguientes
    'forms sino que sirve a la hora de ver el form frm_publicar_aviso. que va a cambiar su 
    'logica si es para buscar animales. 
    Private Shared Sub mostrarFormSeleccionTipoAvisoPara(tipoMuestraForm As SeleccionUsuario)
        Dim seleccionar_tipo_aviso As New frm_seleccion_tipo_aviso
        seleccionar_tipo_aviso.setEleccionUsuario(tipoMuestraForm)
        seleccionar_tipo_aviso.ShowDialog()
    End Sub

    Private Sub lbl_verPublicaciones_Click(sender As Object, e As EventArgs) Handles lbl_verPublicaciones.Click

    End Sub
End Class