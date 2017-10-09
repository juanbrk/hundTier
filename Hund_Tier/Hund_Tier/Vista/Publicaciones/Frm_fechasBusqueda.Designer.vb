<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_fechasBusqueda
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
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_fechaDesde = New System.Windows.Forms.Label()
        Me.lbl_fechaHasta = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_fechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(13, 13)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(136, 13)
        Me.lbl_descripcion.TabIndex = 0
        Me.lbl_descripcion.Text = "Ingrese el rango de fechas:"
        '
        'lbl_fechaDesde
        '
        Me.lbl_fechaDesde.AutoSize = True
        Me.lbl_fechaDesde.Location = New System.Drawing.Point(13, 44)
        Me.lbl_fechaDesde.Name = "lbl_fechaDesde"
        Me.lbl_fechaDesde.Size = New System.Drawing.Size(41, 13)
        Me.lbl_fechaDesde.TabIndex = 1
        Me.lbl_fechaDesde.Text = "Desde:"
        '
        'lbl_fechaHasta
        '
        Me.lbl_fechaHasta.AutoSize = True
        Me.lbl_fechaHasta.Location = New System.Drawing.Point(13, 70)
        Me.lbl_fechaHasta.Name = "lbl_fechaHasta"
        Me.lbl_fechaHasta.Size = New System.Drawing.Size(38, 13)
        Me.lbl_fechaHasta.TabIndex = 3
        Me.lbl_fechaHasta.Text = "Hasta:"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(127, 99)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 5
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(46, 99)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_fechaDesde
        '
        Me.txt_fechaDesde.Location = New System.Drawing.Point(60, 41)
        Me.txt_fechaDesde.Mask = "00/00/0000"
        Me.txt_fechaDesde.Name = "txt_fechaDesde"
        Me.txt_fechaDesde.Size = New System.Drawing.Size(131, 20)
        Me.txt_fechaDesde.TabIndex = 7
        '
        'txt_fechaHasta
        '
        Me.txt_fechaHasta.Location = New System.Drawing.Point(60, 67)
        Me.txt_fechaHasta.Mask = "00/00/0000"
        Me.txt_fechaHasta.Name = "txt_fechaHasta"
        Me.txt_fechaHasta.Size = New System.Drawing.Size(131, 20)
        Me.txt_fechaHasta.TabIndex = 8
        '
        'Frm_fechasBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 134)
        Me.Controls.Add(Me.txt_fechaHasta)
        Me.Controls.Add(Me.txt_fechaDesde)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lbl_fechaHasta)
        Me.Controls.Add(Me.lbl_fechaDesde)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Name = "Frm_fechasBusqueda"
        Me.Text = "Ingrese fechas de busqueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents lbl_fechaDesde As Label
    Friend WithEvents lbl_fechaHasta As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents txt_fechaDesde As MaskedTextBox
    Friend WithEvents txt_fechaHasta As MaskedTextBox
End Class
