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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_seleccionCombo = New System.Windows.Forms.Label()
        Me.cmb_reportesPosibles = New System.Windows.Forms.ComboBox()
        Me.btn_generarReporte = New System.Windows.Forms.Button()
        Me.mtxt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxt_FechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione tipo de reporte"
        '
        'lbl_seleccionCombo
        '
        Me.lbl_seleccionCombo.AutoSize = True
        Me.lbl_seleccionCombo.Location = New System.Drawing.Point(7, 22)
        Me.lbl_seleccionCombo.Name = "lbl_seleccionCombo"
        Me.lbl_seleccionCombo.Size = New System.Drawing.Size(110, 17)
        Me.lbl_seleccionCombo.TabIndex = 0
        Me.lbl_seleccionCombo.Text = "Tipo de reporte:"
        '
        'cmb_reportesPosibles
        '
        Me.cmb_reportesPosibles.FormattingEnabled = True
        Me.cmb_reportesPosibles.Location = New System.Drawing.Point(123, 22)
        Me.cmb_reportesPosibles.Name = "cmb_reportesPosibles"
        Me.cmb_reportesPosibles.Size = New System.Drawing.Size(379, 24)
        Me.cmb_reportesPosibles.TabIndex = 1
        '
        'btn_generarReporte
        '
        Me.btn_generarReporte.Location = New System.Drawing.Point(395, 88)
        Me.btn_generarReporte.Name = "btn_generarReporte"
        Me.btn_generarReporte.Size = New System.Drawing.Size(107, 23)
        Me.btn_generarReporte.TabIndex = 2
        Me.btn_generarReporte.Text = "Generar"
        Me.btn_generarReporte.UseVisualStyleBackColor = True
        '
        'mtxt_fechaDesde
        '
        Me.mtxt_fechaDesde.Location = New System.Drawing.Point(106, 52)
        Me.mtxt_fechaDesde.Mask = "00/00/0000"
        Me.mtxt_fechaDesde.Name = "mtxt_fechaDesde"
        Me.mtxt_fechaDesde.Size = New System.Drawing.Size(100, 22)
        Me.mtxt_fechaDesde.TabIndex = 3
        Me.mtxt_fechaDesde.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Hasta:"
        '
        'mtxt_FechaHasta
        '
        Me.mtxt_FechaHasta.Location = New System.Drawing.Point(321, 52)
        Me.mtxt_FechaHasta.Mask = "00/00/0000"
        Me.mtxt_FechaHasta.Name = "mtxt_FechaHasta"
        Me.mtxt_FechaHasta.Size = New System.Drawing.Size(100, 22)
        Me.mtxt_FechaHasta.TabIndex = 5
        Me.mtxt_FechaHasta.ValidatingType = GetType(Date)
        '
        'frm_nuevoReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 264)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_nuevoReporte"
        Me.Text = "frm_nuevoReporte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
End Class
