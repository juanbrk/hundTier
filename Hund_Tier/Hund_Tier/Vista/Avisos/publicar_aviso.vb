Public Class frm_publicar_aviso

    'Cuando carga la form hay que cargar los combos Barrio y los campos nombre y email con los datos del 
    'usuario
    Private Sub frm_publicar_aviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmbServicio As New CombosService

    End Sub

    Public Sub setTitulo(titulo As String)
        Me.Text = titulo
    End Sub
End Class