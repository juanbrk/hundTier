<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_main
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
        Me.mnu_frm_main = New System.Windows.Forms.MenuStrip()
        Me.MiPerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_nombre_usuario = New System.Windows.Forms.Label()
        Me.lbl_img_user = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_agregar_publicacion = New System.Windows.Forms.Button()
        Me.lbl_verPublicaciones = New System.Windows.Forms.Button()
        Me.btn_busqueda = New System.Windows.Forms.Button()
        Me.MisPublicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_frm_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_frm_main
        '
        Me.mnu_frm_main.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnu_frm_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiPerfilToolStripMenuItem})
        Me.mnu_frm_main.Location = New System.Drawing.Point(0, 0)
        Me.mnu_frm_main.Name = "mnu_frm_main"
        Me.mnu_frm_main.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnu_frm_main.Size = New System.Drawing.Size(460, 28)
        Me.mnu_frm_main.TabIndex = 0
        Me.mnu_frm_main.Text = "MenuStrip1"
        '
        'MiPerfilToolStripMenuItem
        '
        Me.MiPerfilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.MisPublicacionesToolStripMenuItem})
        Me.MiPerfilToolStripMenuItem.Name = "MiPerfilToolStripMenuItem"
        Me.MiPerfilToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.MiPerfilToolStripMenuItem.Text = "Mi perfil"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'lbl_nombre_usuario
        '
        Me.lbl_nombre_usuario.AutoSize = True
        Me.lbl_nombre_usuario.Location = New System.Drawing.Point(311, 55)
        Me.lbl_nombre_usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre_usuario.Name = "lbl_nombre_usuario"
        Me.lbl_nombre_usuario.Size = New System.Drawing.Size(51, 17)
        Me.lbl_nombre_usuario.TabIndex = 1
        Me.lbl_nombre_usuario.Text = "Label1"
        Me.lbl_nombre_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_img_user
        '
        Me.lbl_img_user.AutoSize = True
        Me.lbl_img_user.Image = Global.Hund_Tier.My.Resources.Resources.user_log
        Me.lbl_img_user.Location = New System.Drawing.Point(167, 55)
        Me.lbl_img_user.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_img_user.MinimumSize = New System.Drawing.Size(40, 37)
        Me.lbl_img_user.Name = "lbl_img_user"
        Me.lbl_img_user.Size = New System.Drawing.Size(40, 37)
        Me.lbl_img_user.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_agregar_publicacion
        '
        Me.lbl_agregar_publicacion.Location = New System.Drawing.Point(17, 149)
        Me.lbl_agregar_publicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_agregar_publicacion.Name = "lbl_agregar_publicacion"
        Me.lbl_agregar_publicacion.Size = New System.Drawing.Size(132, 28)
        Me.lbl_agregar_publicacion.TabIndex = 4
        Me.lbl_agregar_publicacion.Text = "Publicar aviso"
        Me.lbl_agregar_publicacion.UseVisualStyleBackColor = True
        '
        'lbl_verPublicaciones
        '
        Me.lbl_verPublicaciones.Location = New System.Drawing.Point(159, 148)
        Me.lbl_verPublicaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_verPublicaciones.Name = "lbl_verPublicaciones"
        Me.lbl_verPublicaciones.Size = New System.Drawing.Size(143, 28)
        Me.lbl_verPublicaciones.TabIndex = 5
        Me.lbl_verPublicaciones.Text = "Ver publicaciones"
        Me.lbl_verPublicaciones.UseVisualStyleBackColor = True
        '
        'btn_busqueda
        '
        Me.btn_busqueda.Location = New System.Drawing.Point(309, 148)
        Me.btn_busqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_busqueda.Name = "btn_busqueda"
        Me.btn_busqueda.Size = New System.Drawing.Size(132, 28)
        Me.btn_busqueda.TabIndex = 6
        Me.btn_busqueda.Text = "Buscar animal"
        Me.btn_busqueda.UseVisualStyleBackColor = True
        '
        'MisPublicacionesToolStripMenuItem
        '
        Me.MisPublicacionesToolStripMenuItem.Name = "MisPublicacionesToolStripMenuItem"
        Me.MisPublicacionesToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.MisPublicacionesToolStripMenuItem.Text = "Mis publicaciones"
        '
        'Frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(460, 186)
        Me.Controls.Add(Me.btn_busqueda)
        Me.Controls.Add(Me.lbl_verPublicaciones)
        Me.Controls.Add(Me.lbl_agregar_publicacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_img_user)
        Me.Controls.Add(Me.lbl_nombre_usuario)
        Me.Controls.Add(Me.mnu_frm_main)
        Me.MainMenuStrip = Me.mnu_frm_main
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_main"
        Me.Text = "Hund Tier"
        Me.mnu_frm_main.ResumeLayout(False)
        Me.mnu_frm_main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu_frm_main As MenuStrip
    Friend WithEvents MiPerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_nombre_usuario As Label
    Friend WithEvents lbl_img_user As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_agregar_publicacion As Button
    Friend WithEvents lbl_verPublicaciones As Button
    Friend WithEvents btn_busqueda As Button
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MisPublicacionesToolStripMenuItem As ToolStripMenuItem
End Class
