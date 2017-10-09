Public Class frm_listarPublicaciones
    Private Sub frm_listarPublicaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub llenarGrid(ByRef source As List(Of Publicacion))
        dgv_publicaciones.Rows.Clear()
        For Each oPublicacion As Publicacion In source
            ' dgv_publicaciones.Rows.Add(New String() {oBug.id_bug.ToString, oBug.titulo, oBug.n_producto, oBug.fecha_alta.ToString("dd/MM/yyyy"), oBug.estado, oBug.asignado_a, oBug.n_criticidad, oBug.n_prioridad})
        Next
    End Sub
End Class