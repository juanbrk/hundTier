Public Class frm_seleccion_tipo_aviso

    'Cuando se hace click sobre el boton para publicar un aviso sobre la adopcion de un perro se
    'muestra el form de avisos

    Private Sub btn_adopcion_perro_Click(sender As Object, e As EventArgs) Handles btn_adopcion_perro.Click

        Dim publicarAdopcionPerro_form As New frm_publicar_aviso

        ' Le cambiamos el titulo a la form por el que sea apropiado para cada caso
        publicarAdopcionPerro_form.setTitulo("Publicar perro en adopcion")
        ' Le seteamos el tipo de animal con el que trabajaremos
        publicarAdopcionPerro_form.setTipoAnimal(1)
        ' Le pasamos a la form el tipo de publicacion de que se trata, 1 = adopcion, 2= perdido, 3=encontrado
        publicarAdopcionPerro_form.setTipoPublicacion(1)
        publicarAdopcionPerro_form.ShowDialog()
        Me.Close()

    End Sub
End Class