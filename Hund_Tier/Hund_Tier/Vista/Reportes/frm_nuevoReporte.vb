Imports System.Globalization
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
            Dim fechaDesde As DateTime = DateTime.ParseExact(mtxt_fechaDesde.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Dim reformatedDesde As String = fechaDesde.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
            Dim fechaHasta As DateTime = DateTime.ParseExact(mtxt_FechaHasta.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            Dim reformattedHasta As String = fechaDesde.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
            rpt_animales.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", oUsuariosService.generarReporteAltaUsuario(reformatedDesde, reformattedHasta)))
            rpt_animales.LocalReport.SetParameters({New ReportParameter("pFechaDesde", mtxt_fechaDesde.Text), New ReportParameter("pHasta", reformattedHasta)})
            rpt_animales.LocalReport.DataSources.Clear()
            rpt_animales.RefreshReport()
        Else
            MsgBox("Periodo incorrecto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub
End Class