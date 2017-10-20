<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UsuarioABM
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
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.lbl_barrio = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txt_confirmarPass = New System.Windows.Forms.TextBox()
        Me.lbl_confirmarPass = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.btn_add_user = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(8, 27)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(77, 23)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(229, 22)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(77, 55)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(229, 22)
        Me.txt_apellido.TabIndex = 3
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(8, 59)
        Me.lbl_apellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(62, 17)
        Me.lbl_apellido.TabIndex = 2
        Me.lbl_apellido.Text = "Apellido:"
        '
        'cmb_barrio
        '
        Me.cmb_barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(77, 87)
        Me.cmb_barrio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(229, 24)
        Me.cmb_barrio.TabIndex = 4
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Location = New System.Drawing.Point(7, 92)
        Me.lbl_barrio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(50, 17)
        Me.lbl_barrio.TabIndex = 5
        Me.lbl_barrio.Text = "Barrio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_barrio)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Controls.Add(Me.cmb_barrio)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(345, 137)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos personales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_username)
        Me.GroupBox2.Controls.Add(Me.lbl_username)
        Me.GroupBox2.Controls.Add(Me.txt_confirmarPass)
        Me.GroupBox2.Controls.Add(Me.lbl_confirmarPass)
        Me.GroupBox2.Controls.Add(Me.txt_password)
        Me.GroupBox2.Controls.Add(Me.lbl_password)
        Me.GroupBox2.Controls.Add(Me.txt_email)
        Me.GroupBox2.Controls.Add(Me.lbl_email)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 161)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(345, 174)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Crear un usuario"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(151, 119)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(156, 22)
        Me.txt_username.TabIndex = 13
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(8, 123)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(133, 17)
        Me.lbl_username.TabIndex = 12
        Me.lbl_username.Text = "Nombre de usuario:"
        '
        'txt_confirmarPass
        '
        Me.txt_confirmarPass.Location = New System.Drawing.Point(151, 87)
        Me.txt_confirmarPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_confirmarPass.Name = "txt_confirmarPass"
        Me.txt_confirmarPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmarPass.Size = New System.Drawing.Size(156, 22)
        Me.txt_confirmarPass.TabIndex = 11
        '
        'lbl_confirmarPass
        '
        Me.lbl_confirmarPass.AutoSize = True
        Me.lbl_confirmarPass.Location = New System.Drawing.Point(8, 91)
        Me.lbl_confirmarPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_confirmarPass.Name = "lbl_confirmarPass"
        Me.lbl_confirmarPass.Size = New System.Drawing.Size(148, 17)
        Me.lbl_confirmarPass.TabIndex = 10
        Me.lbl_confirmarPass.Text = "Confirmar contraseña:"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(151, 55)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(156, 22)
        Me.txt_password.TabIndex = 9
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(8, 59)
        Me.lbl_password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(85, 17)
        Me.lbl_password.TabIndex = 8
        Me.lbl_password.Text = "Contraseña:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(77, 23)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(229, 22)
        Me.txt_email.TabIndex = 7
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(8, 27)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(46, 17)
        Me.lbl_email.TabIndex = 6
        Me.lbl_email.Text = "Email:"
        '
        'btn_add_user
        '
        Me.btn_add_user.Location = New System.Drawing.Point(261, 338)
        Me.btn_add_user.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_add_user.Name = "btn_add_user"
        Me.btn_add_user.Size = New System.Drawing.Size(100, 28)
        Me.btn_add_user.TabIndex = 8
        Me.btn_add_user.Text = "Registrarme"
        Me.btn_add_user.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(153, 338)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 28)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_UsuarioABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 382)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_add_user)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_UsuarioABM"
        Me.Text = "Nuevo usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents cmb_barrio As ComboBox
    Friend WithEvents lbl_barrio As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents lbl_username As Label
    Friend WithEvents txt_confirmarPass As TextBox
    Friend WithEvents lbl_confirmarPass As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents btn_add_user As Button
    Friend WithEvents btn_cancelar As Button
End Class
