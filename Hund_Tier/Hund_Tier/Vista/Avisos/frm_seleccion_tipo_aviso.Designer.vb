<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_seleccion_tipo_aviso
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
        Me.btn_adopcion_gato = New System.Windows.Forms.Button()
        Me.btn_adopcion_perro = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_perdido_gato = New System.Windows.Forms.Button()
        Me.btn_perdido_perro = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_encontrado_gato = New System.Windows.Forms.Button()
        Me.btn_encontrado_perro = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_adopcion_gato)
        Me.GroupBox1.Controls.Add(Me.btn_adopcion_perro)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adopcion"
        '
        'btn_adopcion_gato
        '
        Me.btn_adopcion_gato.Location = New System.Drawing.Point(100, 19)
        Me.btn_adopcion_gato.Name = "btn_adopcion_gato"
        Me.btn_adopcion_gato.Size = New System.Drawing.Size(75, 23)
        Me.btn_adopcion_gato.TabIndex = 1
        Me.btn_adopcion_gato.Text = "Gato"
        Me.btn_adopcion_gato.UseVisualStyleBackColor = True
        '
        'btn_adopcion_perro
        '
        Me.btn_adopcion_perro.Location = New System.Drawing.Point(19, 19)
        Me.btn_adopcion_perro.Name = "btn_adopcion_perro"
        Me.btn_adopcion_perro.Size = New System.Drawing.Size(75, 23)
        Me.btn_adopcion_perro.TabIndex = 0
        Me.btn_adopcion_perro.Text = "Perro"
        Me.btn_adopcion_perro.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_perdido_gato)
        Me.GroupBox2.Controls.Add(Me.btn_perdido_perro)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(191, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Perdido"
        '
        'btn_perdido_gato
        '
        Me.btn_perdido_gato.Location = New System.Drawing.Point(100, 19)
        Me.btn_perdido_gato.Name = "btn_perdido_gato"
        Me.btn_perdido_gato.Size = New System.Drawing.Size(75, 23)
        Me.btn_perdido_gato.TabIndex = 3
        Me.btn_perdido_gato.Text = "Gato"
        Me.btn_perdido_gato.UseVisualStyleBackColor = True
        '
        'btn_perdido_perro
        '
        Me.btn_perdido_perro.Location = New System.Drawing.Point(19, 19)
        Me.btn_perdido_perro.Name = "btn_perdido_perro"
        Me.btn_perdido_perro.Size = New System.Drawing.Size(75, 23)
        Me.btn_perdido_perro.TabIndex = 2
        Me.btn_perdido_perro.Text = "Perro"
        Me.btn_perdido_perro.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_encontrado_gato)
        Me.GroupBox3.Controls.Add(Me.btn_encontrado_perro)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 155)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 56)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Encontrado"
        '
        'btn_encontrado_gato
        '
        Me.btn_encontrado_gato.Location = New System.Drawing.Point(100, 19)
        Me.btn_encontrado_gato.Name = "btn_encontrado_gato"
        Me.btn_encontrado_gato.Size = New System.Drawing.Size(75, 23)
        Me.btn_encontrado_gato.TabIndex = 5
        Me.btn_encontrado_gato.Text = "Gato"
        Me.btn_encontrado_gato.UseVisualStyleBackColor = True
        '
        'btn_encontrado_perro
        '
        Me.btn_encontrado_perro.Location = New System.Drawing.Point(19, 19)
        Me.btn_encontrado_perro.Name = "btn_encontrado_perro"
        Me.btn_encontrado_perro.Size = New System.Drawing.Size(75, 23)
        Me.btn_encontrado_perro.TabIndex = 4
        Me.btn_encontrado_perro.Text = "Perro"
        Me.btn_encontrado_perro.UseVisualStyleBackColor = True
        '
        'frm_seleccion_tipo_aviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 223)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_seleccion_tipo_aviso"
        Me.Text = "Publicar un aviso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_adopcion_gato As Button
    Friend WithEvents btn_adopcion_perro As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_perdido_gato As Button
    Friend WithEvents btn_perdido_perro As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_encontrado_gato As Button
    Friend WithEvents btn_encontrado_perro As Button
End Class
