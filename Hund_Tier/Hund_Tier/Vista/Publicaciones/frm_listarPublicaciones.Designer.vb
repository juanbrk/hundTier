<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listarPublicaciones
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
        Me.dgv_publicaciones = New System.Windows.Forms.DataGridView()
        Me.col_idPublicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombreAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_raza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipoAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_edadAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_peloAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sexoAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombreResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_publicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_publicaciones
        '
        Me.dgv_publicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_publicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idPublicacion, Me.col_nombreAnimal, Me.col_raza, Me.col_tipoAnimal, Me.col_edadAnimal, Me.col_peloAnimal, Me.col_sexoAnimal, Me.col_barrio, Me.col_ciudad, Me.col_nombreResponsable})
        Me.dgv_publicaciones.Location = New System.Drawing.Point(12, 12)
        Me.dgv_publicaciones.Name = "dgv_publicaciones"
        Me.dgv_publicaciones.Size = New System.Drawing.Size(936, 150)
        Me.dgv_publicaciones.TabIndex = 0
        '
        'col_idPublicacion
        '
        Me.col_idPublicacion.HeaderText = "# Publicacion"
        Me.col_idPublicacion.Name = "col_idPublicacion"
        '
        'col_nombreAnimal
        '
        Me.col_nombreAnimal.HeaderText = "Nombre"
        Me.col_nombreAnimal.Name = "col_nombreAnimal"
        '
        'col_raza
        '
        Me.col_raza.HeaderText = "Raza"
        Me.col_raza.Name = "col_raza"
        '
        'col_tipoAnimal
        '
        Me.col_tipoAnimal.HeaderText = "Perro/Gato"
        Me.col_tipoAnimal.Name = "col_tipoAnimal"
        '
        'col_edadAnimal
        '
        Me.col_edadAnimal.HeaderText = "Edad"
        Me.col_edadAnimal.Name = "col_edadAnimal"
        '
        'col_peloAnimal
        '
        Me.col_peloAnimal.HeaderText = "Pelo"
        Me.col_peloAnimal.Name = "col_peloAnimal"
        '
        'col_sexoAnimal
        '
        Me.col_sexoAnimal.HeaderText = "Sexo"
        Me.col_sexoAnimal.Name = "col_sexoAnimal"
        '
        'col_barrio
        '
        Me.col_barrio.HeaderText = "Barrio"
        Me.col_barrio.Name = "col_barrio"
        '
        'col_ciudad
        '
        Me.col_ciudad.HeaderText = "Ciudad"
        Me.col_ciudad.Name = "col_ciudad"
        '
        'col_nombreResponsable
        '
        Me.col_nombreResponsable.HeaderText = "Responsable"
        Me.col_nombreResponsable.Name = "col_nombreResponsable"
        '
        'frm_listarPublicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 261)
        Me.Controls.Add(Me.dgv_publicaciones)
        Me.Name = "frm_listarPublicaciones"
        Me.Text = "Resultado de consulta"
        CType(Me.dgv_publicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_publicaciones As DataGridView
    Friend WithEvents col_idPublicacion As DataGridViewTextBoxColumn
    Friend WithEvents col_nombreAnimal As DataGridViewTextBoxColumn
    Friend WithEvents col_raza As DataGridViewTextBoxColumn
    Friend WithEvents col_tipoAnimal As DataGridViewTextBoxColumn
    Friend WithEvents col_edadAnimal As DataGridViewTextBoxColumn
    Friend WithEvents col_peloAnimal As DataGridViewTextBoxColumn
    Friend WithEvents col_sexoAnimal As DataGridViewTextBoxColumn
    Friend WithEvents col_barrio As DataGridViewTextBoxColumn
    Friend WithEvents col_ciudad As DataGridViewTextBoxColumn
    Friend WithEvents col_nombreResponsable As DataGridViewTextBoxColumn
End Class
