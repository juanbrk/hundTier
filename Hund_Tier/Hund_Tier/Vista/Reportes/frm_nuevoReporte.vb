Imports Microsoft.Reporting.WinForms

Public Class frm_nuevoReporte
    Private Sub mtxt_fechaDesde_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtxt_fechaDesde.MaskInputRejected

    End Sub

    Private Sub frm_nuevoReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rpt_animales.RefreshReport()
    End Sub

    Private Sub btn_generarReporte_Click(sender As Object, e As EventArgs) Handles btn_generarReporte.Click
        Dim oUsuariosService As New UsuariosService
        If IsDate(mtxt_fechaDesde.Text) And IsDate((mtxt_FechaHasta.Text)) Then
            rpt_animales.LocalReport.SetParameters({New ReportParameter("pDesde", mtxt_fechaDesde.Text), New ReportParameter("pHasta", mtxt_FechaHasta.Text)})
            rpt_animales.LocalReport.DataSources.Clear()
            rpt_animales.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", oUsuariosService.generarReporte(mtxt_fechaDesde.Text, mtxt_FechaHasta.Text)))
            rpt_animales.RefreshReport()
        Else
            MsgBox("Periodo incorrecto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub
End Class