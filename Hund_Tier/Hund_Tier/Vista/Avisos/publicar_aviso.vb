Public Class frm_publicar_aviso
    Dim usuario As Usuario

    'Cuando carga la form hay que cargar los combos Barrio y los campos nombre y email con los datos del 
    'usuario
    Private Sub frm_publicar_aviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCampos()

    End Sub

    Public Sub setTitulo(titulo As String)
        Me.Text = titulo
    End Sub

    Private Sub llenarCampos()
        'Cargamos los combos a partir de ComboService 
        Dim cmbServicio As New CombosService
        'Obtenemos la tabla con todos los barrios
        Dim TablaDatos = cmbServicio.getBarrios
        'Cargamos el combo mediante el metodo llenarCombo de CombosService
        cmbServicio.llenarCombo(cmb_barrio, TablaDatos, "nombre", "ID_BARRIO")
        'Reutilizamos la tabla, pero ahora le cargamos las razas
        TablaDatos = cmbServicio.getRazasPerros
        cmbServicio.llenarCombo(cmb_raza, TablaDatos, "nombre_raza", "id_raza")
        'Reutilizamos la tabla para cargar los combos color1 y color2
        TablaDatos = cmbServicio.getColores
        cmbServicio.llenarCombo(cmb_color1, TablaDatos, "nombre", "id_color")
        cmbServicio.llenarCombo(cmb_color2, TablaDatos, "nombre", "id_color")
        'Cargamos combo sexos
        TablaDatos = cmbServicio.getSexos
        cmbServicio.llenarCombo(cmb_sexo, TablaDatos, "nombre_sexo", "codigo_sexo")



        'El nombre y email del usuario lo conseguimos desde el usuario de la frm_main
        usuario = Frm_main.getUsuario()
        txt_nombre_responsable.Text = usuario.getNombre
        txt_mail_responsable.Text = usuario.getEmail
        txt_telefono_1.Text = usuario.getNumTelefono





    End Sub
End Class