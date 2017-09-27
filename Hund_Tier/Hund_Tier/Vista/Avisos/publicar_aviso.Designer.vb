<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_publicar_aviso
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
        Me.rbtn_NoSabe = New System.Windows.Forms.RadioButton()
        Me.cmb_color2 = New System.Windows.Forms.ComboBox()
        Me.cmb_color1 = New System.Windows.Forms.ComboBox()
        Me.Imagen = New System.Windows.Forms.Label()
        Me.rbtn_no = New System.Windows.Forms.RadioButton()
        Me.rb_si = New System.Windows.Forms.RadioButton()
        Me.lbl_castrado = New System.Windows.Forms.Label()
        Me.lbl_color_2 = New System.Windows.Forms.Label()
        Me.lbl_color_1 = New System.Windows.Forms.Label()
        Me.cmb_pelo = New System.Windows.Forms.ComboBox()
        Me.lbl_pelo = New System.Windows.Forms.Label()
        Me.cmb_edad = New System.Windows.Forms.ComboBox()
        Me.lbl_edad = New System.Windows.Forms.Label()
        Me.cmb_tamano = New System.Windows.Forms.ComboBox()
        Me.lbl_tamano = New System.Windows.Forms.Label()
        Me.cmb_sexo = New System.Windows.Forms.ComboBox()
        Me.lbl_sexo_animal = New System.Windows.Forms.Label()
        Me.cmb_raza = New System.Windows.Forms.ComboBox()
        Me.lbl_raza = New System.Windows.Forms.Label()
        Me.txt_nombre_animal = New System.Windows.Forms.TextBox()
        Me.lbl_nombre_animal = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.txt_ciudad = New System.Windows.Forms.TextBox()
        Me.lbl_ciudad = New System.Windows.Forms.Label()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.lbl_barrio = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_telefono_2 = New System.Windows.Forms.TextBox()
        Me.lbl_telefono_2 = New System.Windows.Forms.Label()
        Me.txt_telefono_1 = New System.Windows.Forms.TextBox()
        Me.lbl_telefono_1 = New System.Windows.Forms.Label()
        Me.txt_mail_responsable = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_nombre_responsable = New System.Windows.Forms.TextBox()
        Me.lbl_nombre_responsable = New System.Windows.Forms.Label()
        Me.btn_publicar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtn_NoSabe)
        Me.GroupBox1.Controls.Add(Me.cmb_color2)
        Me.GroupBox1.Controls.Add(Me.cmb_color1)
        Me.GroupBox1.Controls.Add(Me.Imagen)
        Me.GroupBox1.Controls.Add(Me.rbtn_no)
        Me.GroupBox1.Controls.Add(Me.rb_si)
        Me.GroupBox1.Controls.Add(Me.lbl_castrado)
        Me.GroupBox1.Controls.Add(Me.lbl_color_2)
        Me.GroupBox1.Controls.Add(Me.lbl_color_1)
        Me.GroupBox1.Controls.Add(Me.cmb_pelo)
        Me.GroupBox1.Controls.Add(Me.lbl_pelo)
        Me.GroupBox1.Controls.Add(Me.cmb_edad)
        Me.GroupBox1.Controls.Add(Me.lbl_edad)
        Me.GroupBox1.Controls.Add(Me.cmb_tamano)
        Me.GroupBox1.Controls.Add(Me.lbl_tamano)
        Me.GroupBox1.Controls.Add(Me.cmb_sexo)
        Me.GroupBox1.Controls.Add(Me.lbl_sexo_animal)
        Me.GroupBox1.Controls.Add(Me.cmb_raza)
        Me.GroupBox1.Controls.Add(Me.lbl_raza)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_animal)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre_animal)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del animal"
        '
        'rbtn_NoSabe
        '
        Me.rbtn_NoSabe.AutoSize = True
        Me.rbtn_NoSabe.Location = New System.Drawing.Point(396, 112)
        Me.rbtn_NoSabe.Name = "rbtn_NoSabe"
        Me.rbtn_NoSabe.Size = New System.Drawing.Size(85, 17)
        Me.rbtn_NoSabe.TabIndex = 22
        Me.rbtn_NoSabe.TabStop = True
        Me.rbtn_NoSabe.Text = "Desconozco"
        Me.rbtn_NoSabe.UseVisualStyleBackColor = True
        '
        'cmb_color2
        '
        Me.cmb_color2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_color2.FormattingEnabled = True
        Me.cmb_color2.Location = New System.Drawing.Point(75, 96)
        Me.cmb_color2.Name = "cmb_color2"
        Me.cmb_color2.Size = New System.Drawing.Size(166, 21)
        Me.cmb_color2.TabIndex = 21
        '
        'cmb_color1
        '
        Me.cmb_color1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_color1.FormattingEnabled = True
        Me.cmb_color1.Location = New System.Drawing.Point(75, 70)
        Me.cmb_color1.Name = "cmb_color1"
        Me.cmb_color1.Size = New System.Drawing.Size(166, 21)
        Me.cmb_color1.TabIndex = 20
        '
        'Imagen
        '
        Me.Imagen.AutoSize = True
        Me.Imagen.Location = New System.Drawing.Point(465, 10)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(42, 13)
        Me.Imagen.TabIndex = 19
        Me.Imagen.Text = "Imagen"
        '
        'rbtn_no
        '
        Me.rbtn_no.AutoSize = True
        Me.rbtn_no.Location = New System.Drawing.Point(351, 112)
        Me.rbtn_no.Name = "rbtn_no"
        Me.rbtn_no.Size = New System.Drawing.Size(39, 17)
        Me.rbtn_no.TabIndex = 18
        Me.rbtn_no.TabStop = True
        Me.rbtn_no.Text = "No"
        Me.rbtn_no.UseVisualStyleBackColor = True
        '
        'rb_si
        '
        Me.rb_si.AutoSize = True
        Me.rb_si.Location = New System.Drawing.Point(297, 112)
        Me.rb_si.Name = "rb_si"
        Me.rb_si.Size = New System.Drawing.Size(34, 17)
        Me.rb_si.TabIndex = 17
        Me.rb_si.TabStop = True
        Me.rb_si.Text = "Si"
        Me.rb_si.UseVisualStyleBackColor = True
        '
        'lbl_castrado
        '
        Me.lbl_castrado.AutoSize = True
        Me.lbl_castrado.Location = New System.Drawing.Point(258, 96)
        Me.lbl_castrado.Name = "lbl_castrado"
        Me.lbl_castrado.Size = New System.Drawing.Size(52, 13)
        Me.lbl_castrado.TabIndex = 16
        Me.lbl_castrado.Text = "Castrado:"
        '
        'lbl_color_2
        '
        Me.lbl_color_2.AutoSize = True
        Me.lbl_color_2.Location = New System.Drawing.Point(25, 99)
        Me.lbl_color_2.Name = "lbl_color_2"
        Me.lbl_color_2.Size = New System.Drawing.Size(43, 13)
        Me.lbl_color_2.TabIndex = 14
        Me.lbl_color_2.Text = "Color 2:"
        '
        'lbl_color_1
        '
        Me.lbl_color_1.AutoSize = True
        Me.lbl_color_1.Location = New System.Drawing.Point(25, 73)
        Me.lbl_color_1.Name = "lbl_color_1"
        Me.lbl_color_1.Size = New System.Drawing.Size(43, 13)
        Me.lbl_color_1.TabIndex = 12
        Me.lbl_color_1.Text = "Color 1:"
        '
        'cmb_pelo
        '
        Me.cmb_pelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pelo.FormattingEnabled = True
        Me.cmb_pelo.Location = New System.Drawing.Point(351, 65)
        Me.cmb_pelo.Name = "cmb_pelo"
        Me.cmb_pelo.Size = New System.Drawing.Size(84, 21)
        Me.cmb_pelo.TabIndex = 11
        '
        'lbl_pelo
        '
        Me.lbl_pelo.AutoSize = True
        Me.lbl_pelo.Location = New System.Drawing.Point(348, 49)
        Me.lbl_pelo.Name = "lbl_pelo"
        Me.lbl_pelo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_pelo.TabIndex = 10
        Me.lbl_pelo.Text = "Pelo"
        '
        'cmb_edad
        '
        Me.cmb_edad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_edad.FormattingEnabled = True
        Me.cmb_edad.Location = New System.Drawing.Point(261, 65)
        Me.cmb_edad.Name = "cmb_edad"
        Me.cmb_edad.Size = New System.Drawing.Size(84, 21)
        Me.cmb_edad.TabIndex = 9
        '
        'lbl_edad
        '
        Me.lbl_edad.AutoSize = True
        Me.lbl_edad.Location = New System.Drawing.Point(258, 49)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(32, 13)
        Me.lbl_edad.TabIndex = 8
        Me.lbl_edad.Text = "Edad"
        '
        'cmb_tamano
        '
        Me.cmb_tamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tamano.FormattingEnabled = True
        Me.cmb_tamano.Location = New System.Drawing.Point(351, 26)
        Me.cmb_tamano.Name = "cmb_tamano"
        Me.cmb_tamano.Size = New System.Drawing.Size(84, 21)
        Me.cmb_tamano.TabIndex = 7
        '
        'lbl_tamano
        '
        Me.lbl_tamano.AutoSize = True
        Me.lbl_tamano.Location = New System.Drawing.Point(348, 10)
        Me.lbl_tamano.Name = "lbl_tamano"
        Me.lbl_tamano.Size = New System.Drawing.Size(46, 13)
        Me.lbl_tamano.TabIndex = 6
        Me.lbl_tamano.Text = "Tamaño"
        '
        'cmb_sexo
        '
        Me.cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sexo.FormattingEnabled = True
        Me.cmb_sexo.Location = New System.Drawing.Point(261, 26)
        Me.cmb_sexo.Name = "cmb_sexo"
        Me.cmb_sexo.Size = New System.Drawing.Size(84, 21)
        Me.cmb_sexo.TabIndex = 5
        '
        'lbl_sexo_animal
        '
        Me.lbl_sexo_animal.AutoSize = True
        Me.lbl_sexo_animal.Location = New System.Drawing.Point(258, 10)
        Me.lbl_sexo_animal.Name = "lbl_sexo_animal"
        Me.lbl_sexo_animal.Size = New System.Drawing.Size(31, 13)
        Me.lbl_sexo_animal.TabIndex = 4
        Me.lbl_sexo_animal.Text = "Sexo"
        '
        'cmb_raza
        '
        Me.cmb_raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_raza.FormattingEnabled = True
        Me.cmb_raza.Location = New System.Drawing.Point(75, 43)
        Me.cmb_raza.Name = "cmb_raza"
        Me.cmb_raza.Size = New System.Drawing.Size(166, 21)
        Me.cmb_raza.TabIndex = 3
        '
        'lbl_raza
        '
        Me.lbl_raza.AutoSize = True
        Me.lbl_raza.Location = New System.Drawing.Point(34, 46)
        Me.lbl_raza.Name = "lbl_raza"
        Me.lbl_raza.Size = New System.Drawing.Size(35, 13)
        Me.lbl_raza.TabIndex = 2
        Me.lbl_raza.Text = "Raza:"
        '
        'txt_nombre_animal
        '
        Me.txt_nombre_animal.Location = New System.Drawing.Point(75, 17)
        Me.txt_nombre_animal.MaxLength = 50
        Me.txt_nombre_animal.Name = "txt_nombre_animal"
        Me.txt_nombre_animal.Size = New System.Drawing.Size(166, 20)
        Me.txt_nombre_animal.TabIndex = 1
        '
        'lbl_nombre_animal
        '
        Me.lbl_nombre_animal.AutoSize = True
        Me.lbl_nombre_animal.Location = New System.Drawing.Point(25, 20)
        Me.lbl_nombre_animal.Name = "lbl_nombre_animal"
        Me.lbl_nombre_animal.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre_animal.TabIndex = 0
        Me.lbl_nombre_animal.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_descripcion)
        Me.GroupBox2.Controls.Add(Me.lbl_descripcion)
        Me.GroupBox2.Controls.Add(Me.txt_ciudad)
        Me.GroupBox2.Controls.Add(Me.lbl_ciudad)
        Me.GroupBox2.Controls.Add(Me.cmb_barrio)
        Me.GroupBox2.Controls.Add(Me.lbl_barrio)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(525, 136)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion adicional"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(10, 61)
        Me.txt_descripcion.MaxLength = 1000
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(497, 69)
        Me.txt_descripcion.TabIndex = 23
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(7, 44)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(271, 13)
        Me.lbl_descripcion.TabIndex = 22
        Me.lbl_descripcion.Text = "Descripcion de la publicacion (Maximo 1000 caracteres)"
        '
        'txt_ciudad
        '
        Me.txt_ciudad.Location = New System.Drawing.Point(307, 17)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.ReadOnly = True
        Me.txt_ciudad.Size = New System.Drawing.Size(166, 20)
        Me.txt_ciudad.TabIndex = 20
        Me.txt_ciudad.Text = "Cordoba"
        Me.txt_ciudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.Location = New System.Drawing.Point(261, 20)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(40, 13)
        Me.lbl_ciudad.TabIndex = 21
        Me.lbl_ciudad.Text = "Ciudad"
        '
        'cmb_barrio
        '
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(47, 17)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(194, 21)
        Me.cmb_barrio.TabIndex = 20
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Location = New System.Drawing.Point(7, 20)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(34, 13)
        Me.lbl_barrio.TabIndex = 0
        Me.lbl_barrio.Text = "Barrio"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_telefono_2)
        Me.GroupBox3.Controls.Add(Me.lbl_telefono_2)
        Me.GroupBox3.Controls.Add(Me.txt_telefono_1)
        Me.GroupBox3.Controls.Add(Me.lbl_telefono_1)
        Me.GroupBox3.Controls.Add(Me.txt_mail_responsable)
        Me.GroupBox3.Controls.Add(Me.lbl_email)
        Me.GroupBox3.Controls.Add(Me.txt_nombre_responsable)
        Me.GroupBox3.Controls.Add(Me.lbl_nombre_responsable)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 298)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(525, 104)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del responsable"
        '
        'txt_telefono_2
        '
        Me.txt_telefono_2.Location = New System.Drawing.Point(254, 74)
        Me.txt_telefono_2.Name = "txt_telefono_2"
        Me.txt_telefono_2.Size = New System.Drawing.Size(253, 20)
        Me.txt_telefono_2.TabIndex = 25
        '
        'lbl_telefono_2
        '
        Me.lbl_telefono_2.AutoSize = True
        Me.lbl_telefono_2.Location = New System.Drawing.Point(251, 58)
        Me.lbl_telefono_2.Name = "lbl_telefono_2"
        Me.lbl_telefono_2.Size = New System.Drawing.Size(61, 13)
        Me.lbl_telefono_2.TabIndex = 26
        Me.lbl_telefono_2.Text = "Telefono 2:"
        '
        'txt_telefono_1
        '
        Me.txt_telefono_1.Location = New System.Drawing.Point(254, 36)
        Me.txt_telefono_1.Name = "txt_telefono_1"
        Me.txt_telefono_1.ReadOnly = True
        Me.txt_telefono_1.Size = New System.Drawing.Size(253, 20)
        Me.txt_telefono_1.TabIndex = 20
        '
        'lbl_telefono_1
        '
        Me.lbl_telefono_1.AutoSize = True
        Me.lbl_telefono_1.Location = New System.Drawing.Point(251, 20)
        Me.lbl_telefono_1.Name = "lbl_telefono_1"
        Me.lbl_telefono_1.Size = New System.Drawing.Size(61, 13)
        Me.lbl_telefono_1.TabIndex = 24
        Me.lbl_telefono_1.Text = "Telefono 1:"
        '
        'txt_mail_responsable
        '
        Me.txt_mail_responsable.Location = New System.Drawing.Point(19, 74)
        Me.txt_mail_responsable.Name = "txt_mail_responsable"
        Me.txt_mail_responsable.ReadOnly = True
        Me.txt_mail_responsable.Size = New System.Drawing.Size(222, 20)
        Me.txt_mail_responsable.TabIndex = 23
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(16, 58)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(35, 13)
        Me.lbl_email.TabIndex = 22
        Me.lbl_email.Text = "Email:"
        '
        'txt_nombre_responsable
        '
        Me.txt_nombre_responsable.Location = New System.Drawing.Point(19, 35)
        Me.txt_nombre_responsable.Name = "txt_nombre_responsable"
        Me.txt_nombre_responsable.ReadOnly = True
        Me.txt_nombre_responsable.Size = New System.Drawing.Size(222, 20)
        Me.txt_nombre_responsable.TabIndex = 21
        '
        'lbl_nombre_responsable
        '
        Me.lbl_nombre_responsable.AutoSize = True
        Me.lbl_nombre_responsable.Location = New System.Drawing.Point(16, 20)
        Me.lbl_nombre_responsable.Name = "lbl_nombre_responsable"
        Me.lbl_nombre_responsable.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre_responsable.TabIndex = 20
        Me.lbl_nombre_responsable.Text = "Nombre:"
        '
        'btn_publicar
        '
        Me.btn_publicar.Location = New System.Drawing.Point(463, 408)
        Me.btn_publicar.Name = "btn_publicar"
        Me.btn_publicar.Size = New System.Drawing.Size(75, 23)
        Me.btn_publicar.TabIndex = 3
        Me.btn_publicar.Text = "Publicar"
        Me.btn_publicar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(382, 408)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_publicar_aviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 440)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_publicar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_publicar_aviso"
        Me.Text = "publicar_aviso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_color_2 As Label
    Friend WithEvents lbl_color_1 As Label
    Friend WithEvents cmb_pelo As ComboBox
    Friend WithEvents lbl_pelo As Label
    Friend WithEvents cmb_edad As ComboBox
    Friend WithEvents lbl_edad As Label
    Friend WithEvents cmb_tamano As ComboBox
    Friend WithEvents lbl_tamano As Label
    Friend WithEvents cmb_sexo As ComboBox
    Friend WithEvents lbl_sexo_animal As Label
    Friend WithEvents cmb_raza As ComboBox
    Friend WithEvents lbl_raza As Label
    Friend WithEvents txt_nombre_animal As TextBox
    Friend WithEvents lbl_nombre_animal As Label
    Friend WithEvents Imagen As Label
    Friend WithEvents rbtn_no As RadioButton
    Friend WithEvents rb_si As RadioButton
    Friend WithEvents lbl_castrado As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_ciudad As Label
    Friend WithEvents cmb_barrio As ComboBox
    Friend WithEvents lbl_barrio As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents txt_ciudad As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_telefono_2 As TextBox
    Friend WithEvents lbl_telefono_2 As Label
    Friend WithEvents txt_telefono_1 As TextBox
    Friend WithEvents lbl_telefono_1 As Label
    Friend WithEvents txt_mail_responsable As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_nombre_responsable As TextBox
    Friend WithEvents lbl_nombre_responsable As Label
    Friend WithEvents btn_publicar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents cmb_color2 As ComboBox
    Friend WithEvents cmb_color1 As ComboBox
    Friend WithEvents rbtn_NoSabe As RadioButton
End Class
