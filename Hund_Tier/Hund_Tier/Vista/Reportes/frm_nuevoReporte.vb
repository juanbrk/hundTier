Public Class frm_nuevoReporte
    Private Sub mtxt_fechaDesde_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtxt_fechaDesde.MaskInputRejected

    End Sub

    Private Sub frm_nuevoReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class