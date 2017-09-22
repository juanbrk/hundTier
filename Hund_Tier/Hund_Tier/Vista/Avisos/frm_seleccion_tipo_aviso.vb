Public Class frm_seleccion_tipo_aviso
    'Cuando se hace click sobre el boton para publicar un aviso sobre la adopcion de un perro se
    'muestra el form de avisos
    Private Sub btn_adopcion_perro_Click(sender As Object, e As EventArgs) Handles btn_adopcion_perro.Click
        Dim publicarDdopcionPerro_form As New frm_publicar_aviso
        'Le cambiamos el titulo a la form por el que sea apropiado para cada caso
        publicarDdopcionPerro_form.setTitulo("Publicar perro en adopcion")
        publicarDdopcionPerro_form.ShowDialog()
    End Sub
End Class