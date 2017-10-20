<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_perfil_usuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_barrio = New System.Windows.Forms.TextBox()
        Me.lbl_depto = New System.Windows.Forms.Label()
        Me.txt_depto = New System.Windows.Forms.TextBox()
        Me.lbl_piso = New System.Windows.Forms.Label()
        Me.txt_piso = New System.Windows.Forms.TextBox()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.txt_numero_calle = New System.Windows.Forms.TextBox()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.lbl_barrio = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_num_telefono = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_modificar_pass = New System.Windows.Forms.Button()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.btn_modificar_info = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar_cambios = New System.Windows.Forms.Button()
        Me.lbl_eliminar_usuario = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_email)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(345, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos personales"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(8, 89)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(46, 17)
        Me.lbl_email.TabIndex = 5
        Me.lbl_email.Text = "Email:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(80, 85)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = True
        Me.txt_email.Size = New System.Drawing.Size(256, 22)
        Me.txt_email.TabIndex = 4
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(8, 57)
        Me.lbl_apellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(62, 17)
        Me.lbl_apellido.TabIndex = 3
        Me.lbl_apellido.Text = "Apellido:"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(80, 53)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.ReadOnly = True
        Me.txt_apellido.Size = New System.Drawing.Size(256, 22)
        Me.txt_apellido.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(80, 21)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(256, 22)
        Me.txt_nombre.TabIndex = 1
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(9, 25)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_barrio)
        Me.GroupBox2.Controls.Add(Me.lbl_depto)
        Me.GroupBox2.Controls.Add(Me.txt_depto)
        Me.GroupBox2.Controls.Add(Me.lbl_piso)
        Me.GroupBox2.Controls.Add(Me.txt_piso)
        Me.GroupBox2.Controls.Add(Me.lbl_numero)
        Me.GroupBox2.Controls.Add(Me.txt_numero_calle)
        Me.GroupBox2.Controls.Add(Me.cmb_barrio)
        Me.GroupBox2.Controls.Add(Me.lbl_calle)
        Me.GroupBox2.Controls.Add(Me.txt_calle)
        Me.GroupBox2.Controls.Add(Me.lbl_barrio)
        Me.GroupBox2.Controls.Add(Me.txt_telefono)
        Me.GroupBox2.Controls.Add(Me.lbl_num_telefono)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 143)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(345, 206)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de contacto: "
        '
        'txt_barrio
        '
        Me.txt_barrio.Location = New System.Drawing.Point(80, 57)
        Me.txt_barrio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_barrio.Name = "txt_barrio"
        Me.txt_barrio.ReadOnly = True
        Me.txt_barrio.Size = New System.Drawing.Size(256, 22)
        Me.txt_barrio.TabIndex = 13
        '
        'lbl_depto
        '
        Me.lbl_depto.AutoSize = True
        Me.lbl_depto.Location = New System.Drawing.Point(120, 153)
        Me.lbl_depto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_depto.Name = "lbl_depto"
        Me.lbl_depto.Size = New System.Drawing.Size(102, 17)
        Me.lbl_depto.TabIndex = 12
        Me.lbl_depto.Text = "Departamento:"
        '
        'txt_depto
        '
        Me.txt_depto.Location = New System.Drawing.Point(231, 149)
        Me.txt_depto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_depto.Name = "txt_depto"
        Me.txt_depto.ReadOnly = True
        Me.txt_depto.Size = New System.Drawing.Size(105, 22)
        Me.txt_depto.TabIndex = 11
        '
        'lbl_piso
        '
        Me.lbl_piso.AutoSize = True
        Me.lbl_piso.Location = New System.Drawing.Point(8, 153)
        Me.lbl_piso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_piso.Name = "lbl_piso"
        Me.lbl_piso.Size = New System.Drawing.Size(39, 17)
        Me.lbl_piso.TabIndex = 10
        Me.lbl_piso.Text = "Piso:"
        '
        'txt_piso
        '
        Me.txt_piso.Location = New System.Drawing.Point(56, 149)
        Me.txt_piso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_piso.Name = "txt_piso"
        Me.txt_piso.ReadOnly = True
        Me.txt_piso.Size = New System.Drawing.Size(53, 22)
        Me.txt_piso.TabIndex = 9
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(8, 121)
        Me.lbl_numero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(62, 17)
        Me.lbl_numero.TabIndex = 8
        Me.lbl_numero.Text = "Numero:"
        '
        'txt_numero_calle
        '
        Me.txt_numero_calle.Location = New System.Drawing.Point(80, 117)
        Me.txt_numero_calle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_numero_calle.Name = "txt_numero_calle"
        Me.txt_numero_calle.ReadOnly = True
        Me.txt_numero_calle.Size = New System.Drawing.Size(256, 22)
        Me.txt_numero_calle.TabIndex = 7
        '
        'cmb_barrio
        '
        Me.cmb_barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(80, 54)
        Me.cmb_barrio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(256, 24)
        Me.cmb_barrio.TabIndex = 6
        Me.cmb_barrio.Visible = False
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(8, 89)
        Me.lbl_calle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(43, 17)
        Me.lbl_calle.TabIndex = 5
        Me.lbl_calle.Text = "Calle:"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(80, 85)
        Me.txt_calle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.ReadOnly = True
        Me.txt_calle.Size = New System.Drawing.Size(256, 22)
        Me.txt_calle.TabIndex = 4
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Location = New System.Drawing.Point(8, 57)
        Me.lbl_barrio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(50, 17)
        Me.lbl_barrio.TabIndex = 3
        Me.lbl_barrio.Text = "Barrio:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(80, 21)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.ReadOnly = True
        Me.txt_telefono.Size = New System.Drawing.Size(256, 22)
        Me.txt_telefono.TabIndex = 1
        '
        'lbl_num_telefono
        '
        Me.lbl_num_telefono.AutoSize = True
        Me.lbl_num_telefono.Location = New System.Drawing.Point(9, 25)
        Me.lbl_num_telefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_num_telefono.Name = "lbl_num_telefono"
        Me.lbl_num_telefono.Size = New System.Drawing.Size(68, 17)
        Me.lbl_num_telefono.TabIndex = 0
        Me.lbl_num_telefono.Text = "Telefono:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_modificar_pass)
        Me.GroupBox3.Controls.Add(Me.lbl_username)
        Me.GroupBox3.Controls.Add(Me.txt_username)
        Me.GroupBox3.Controls.Add(Me.txt_password)
        Me.GroupBox3.Controls.Add(Me.lbl_password)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 356)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(345, 97)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de usuario"
        '
        'btn_modificar_pass
        '
        Me.btn_modificar_pass.Location = New System.Drawing.Point(231, 60)
        Me.btn_modificar_pass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_modificar_pass.Name = "btn_modificar_pass"
        Me.btn_modificar_pass.Size = New System.Drawing.Size(100, 28)
        Me.btn_modificar_pass.TabIndex = 11
        Me.btn_modificar_pass.Text = "Modificar"
        Me.btn_modificar_pass.UseVisualStyleBackColor = True
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(8, 33)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(133, 17)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Nombre de usuario:"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(148, 30)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.ReadOnly = True
        Me.txt_username.Size = New System.Drawing.Size(188, 22)
        Me.txt_username.TabIndex = 4
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(109, 64)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.ReadOnly = True
        Me.txt_password.Size = New System.Drawing.Size(112, 22)
        Me.txt_password.TabIndex = 1
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(16, 68)
        Me.lbl_password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(85, 17)
        Me.lbl_password.TabIndex = 0
        Me.lbl_password.Text = "Contraseña:"
        '
        'btn_modificar_info
        '
        Me.btn_modificar_info.Location = New System.Drawing.Point(73, 460)
        Me.btn_modificar_info.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_modificar_info.Name = "btn_modificar_info"
        Me.btn_modificar_info.Size = New System.Drawing.Size(188, 28)
        Me.btn_modificar_info.TabIndex = 6
        Me.btn_modificar_info.Text = "Modificar informacion"
        Me.btn_modificar_info.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(269, 460)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(100, 28)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(160, 459)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 28)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        Me.btn_cancelar.Visible = False
        '
        'btn_guardar_cambios
        '
        Me.btn_guardar_cambios.Location = New System.Drawing.Point(269, 459)
        Me.btn_guardar_cambios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_guardar_cambios.Name = "btn_guardar_cambios"
        Me.btn_guardar_cambios.Size = New System.Drawing.Size(100, 28)
        Me.btn_guardar_cambios.TabIndex = 10
        Me.btn_guardar_cambios.Text = "Guardar"
        Me.btn_guardar_cambios.UseVisualStyleBackColor = True
        Me.btn_guardar_cambios.Visible = False
        '
        'lbl_eliminar_usuario
        '
        Me.lbl_eliminar_usuario.AutoSize = True
        Me.lbl_eliminar_usuario.Location = New System.Drawing.Point(17, 494)
        Me.lbl_eliminar_usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_eliminar_usuario.Name = "lbl_eliminar_usuario"
        Me.lbl_eliminar_usuario.Size = New System.Drawing.Size(95, 17)
        Me.lbl_eliminar_usuario.TabIndex = 11
        Me.lbl_eliminar_usuario.Text = "Borrar cuenta"
        '
        'Frm_perfil_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 514)
        Me.Controls.Add(Me.lbl_eliminar_usuario)
        Me.Controls.Add(Me.btn_guardar_cambios)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_modificar_info)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Frm_perfil_usuario"
        Me.Text = "Mi usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_depto As Label
    Friend WithEvents txt_depto As TextBox
    Friend WithEvents lbl_piso As Label
    Friend WithEvents txt_piso As TextBox
    Friend WithEvents lbl_numero As Label
    Friend WithEvents txt_numero_calle As TextBox
    Friend WithEvents lbl_calle As Label
    Friend WithEvents txt_calle As TextBox
    Friend WithEvents lbl_barrio As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents lbl_num_telefono As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_modificar_info As Button
    Friend WithEvents lbl_username As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents btn_salir As Button
    Friend WithEvents txt_barrio As TextBox
    Friend WithEvents cmb_barrio As ComboBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar_cambios As Button
    Friend WithEvents btn_modificar_pass As Button
    Friend WithEvents lbl_eliminar_usuario As Label
End Class
