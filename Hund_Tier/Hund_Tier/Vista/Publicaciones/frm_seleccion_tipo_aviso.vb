Public Class frm_seleccion_tipo_aviso

    'Cuando se hace click sobre el boton para publicar un aviso sobre la adopcion de un perro se
    'muestra el form de avisos
    Public Enum mostrarSiguienteFormPara As Integer
        publicarAviso
        buscarAnimal
    End Enum

    'Esta variable determinará como se mostrara el siguiente form, si para publicar aviso o para
    'buscar animales. Es una bandera
    Dim elUsuarioVaA = mostrarSiguienteFormPara.publicarAviso

    'Cuando se hace click sobre el boton adopcion de perro pueden pasar dos cosas, que se este
    'tratando de hacer una nueva publicacion de un perro en adopcion o que se este buscando algun
    'perro que este en adopcion con las caracteristicas deseadas. 
    Private Sub btn_adopcion_perro_Click(sender As Object, e As EventArgs) Handles btn_adopcion_perro.Click

        Dim datosPublicacion_form As New frm_publicar_aviso
        ' Le seteamos el tipo de animal con el que trabajaremos
        datosPublicacion_form.setTipoAnimal(frm_publicar_aviso.TipoAnimal.perro)

        ' Chequeamos para ver como se mostrara la ventana de publicarAviso, puede mostrarse
        'para publicar un nuevo aviso o para hacer busqueda de animales que cumplan con ciertos
        'criterios

        If elUsuarioVaA = mostrarSiguienteFormPara.publicarAviso Then
            ' Le cambiamos el titulo a la form por el que sea apropiado para cada caso
            datosPublicacion_form.setTitulo("Publicar perro en adopcion")
            ' Le pasamos a la form el tipo de publicacion de que se trata, 1 = adopcion, 2= perdido, 3=encontrado
            datosPublicacion_form.setTipoPublicacion(frm_publicar_aviso.AccionUsuario.adopcion)

            'Si el usuario busca un animal, se hacen otras cosas.
        Else
            ' Le cambiamos el titulo a la form por el que sea apropiado para cada caso
            datosPublicacion_form.setTitulo("Buscar un animal")
            ' Le pasamos a la form el tipo de publicacion de que se trata, 1 = adopcion, 2= perdido, 3=encontrado
            datosPublicacion_form.setTipoPublicacion(frm_publicar_aviso.AccionUsuario.busqueda)
            'Le cambiamos el texto del boton para que en lugar de decir publicar diga buscar
            datosPublicacion_form.btn_publicar.Text = "Buscar"
        End If
        datosPublicacion_form.ShowDialog()
        Me.Close()

    End Sub

    Public Sub setEleccionUsuario(valor As mostrarSiguienteFormPara)
        elUsuarioVaA = valor
    End Sub
End Class