<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nuevoReporte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxt_FechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.btn_generarReporte = New System.Windows.Forms.Button()
        Me.cmb_reportesPosibles = New System.Windows.Forms.ComboBox()
        Me.lbl_seleccionCombo = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS1 = New Hund_Tier.DS1()
        Me.ReporteUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mtxt_FechaHasta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.mtxt_fechaDesde)
        Me.GroupBox1.Controls.Add(Me.btn_generarReporte)
        Me.GroupBox1.Controls.Add(Me.cmb_reportesPosibles)
        Me.GroupBox1.Controls.Add(Me.lbl_seleccionCombo)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(381, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione tipo de reporte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Hasta:"
        '
        'mtxt_FechaHasta
        '
        Me.mtxt_FechaHasta.Location = New System.Drawing.Point(241, 42)
        Me.mtxt_FechaHasta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxt_FechaHasta.Mask = "00/00/0000"
        Me.mtxt_FechaHasta.Name = "mtxt_FechaHasta"
        Me.mtxt_FechaHasta.Size = New System.Drawing.Size(76, 20)
        Me.mtxt_FechaHasta.TabIndex = 5
        Me.mtxt_FechaHasta.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha desde:"
        '
        'mtxt_fechaDesde
        '
        Me.mtxt_fechaDesde.Location = New System.Drawing.Point(80, 42)
        Me.mtxt_fechaDesde.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxt_fechaDesde.Mask = "00/00/0000"
        Me.mtxt_fechaDesde.Name = "mtxt_fechaDesde"
        Me.mtxt_fechaDesde.Size = New System.Drawing.Size(76, 20)
        Me.mtxt_fechaDesde.TabIndex = 3
        Me.mtxt_fechaDesde.ValidatingType = GetType(Date)
        '
        'btn_generarReporte
        '
        Me.btn_generarReporte.Location = New System.Drawing.Point(296, 72)
        Me.btn_generarReporte.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_generarReporte.Name = "btn_generarReporte"
        Me.btn_generarReporte.Size = New System.Drawing.Size(80, 19)
        Me.btn_generarReporte.TabIndex = 2
        Me.btn_generarReporte.Text = "Generar"
        Me.btn_generarReporte.UseVisualStyleBackColor = True
        '
        'cmb_reportesPosibles
        '
        Me.cmb_reportesPosibles.FormattingEnabled = True
        Me.cmb_reportesPosibles.Location = New System.Drawing.Point(92, 18)
        Me.cmb_reportesPosibles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_reportesPosibles.Name = "cmb_reportesPosibles"
        Me.cmb_reportesPosibles.Size = New System.Drawing.Size(285, 21)
        Me.cmb_reportesPosibles.TabIndex = 1
        '
        'lbl_seleccionCombo
        '
        Me.lbl_seleccionCombo.AutoSize = True
        Me.lbl_seleccionCombo.Location = New System.Drawing.Point(5, 18)
        Me.lbl_seleccionCombo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_seleccionCombo.Name = "lbl_seleccionCombo"
        Me.lbl_seleccionCombo.Size = New System.Drawing.Size(82, 13)
        Me.lbl_seleccionCombo.TabIndex = 0
        Me.lbl_seleccionCombo.Text = "Tipo de reporte:"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "TablaUsuariosAlta"
        ReportDataSource1.Value = Me.ReporteUsuariosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Hund_Tier.ReporteUsuariosAlta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(10, 107)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(381, 116)
        Me.ReportViewer1.TabIndex = 1
        '
        'DS1
        '
        Me.DS1.DataSetName = "DS1"
        Me.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteUsuariosBindingSource
        '
        Me.ReporteUsuariosBindingSource.DataMember = "ReporteUsuarios"
        Me.ReporteUsuariosBindingSource.DataSource = Me.DS1
        '
        'frm_nuevoReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 235)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_nuevoReporte"
        Me.Text = "frm_nuevoReporte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mtxt_FechaHasta As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mtxt_fechaDesde As MaskedTextBox
    Friend WithEvents btn_generarReporte As Button
    Friend WithEvents cmb_reportesPosibles As ComboBox
    Friend WithEvents lbl_seleccionCombo As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteUsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS1 As Hund_Tier.DS1
End Class
