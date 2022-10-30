<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlAgregarUs = New System.Windows.Forms.Panel()
        Me.CBPerfil = New System.Windows.Forms.ComboBox()
        Me.LPerfil = New System.Windows.Forms.Label()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LContr = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContr = New System.Windows.Forms.TextBox()
        Me.txtUsua = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.LTelef = New System.Windows.Forms.Label()
        Me.LEmail = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.LApe = New System.Windows.Forms.Label()
        Me.LNom = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvPerfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dvgEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dvgTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dvgDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.LUsua = New System.Windows.Forms.Label()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAgregarUs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuarios "
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(59, 397)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(138, 38)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar Usuario"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(477, 397)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(122, 38)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(620, 397)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(122, 38)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar "
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvPerfil, Me.dgvNombre, Me.dgvApellido, Me.dgvDNI, Me.dvgEmail, Me.dvgTel, Me.dvgDireccion, Me.Usuario})
        Me.dgvUsuarios.Location = New System.Drawing.Point(59, 122)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.Size = New System.Drawing.Size(683, 251)
        Me.dgvUsuarios.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.pnlAgregarUs)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.dgvUsuarios)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 460)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(102, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pnlAgregarUs
        '
        Me.pnlAgregarUs.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlAgregarUs.Controls.Add(Me.LUsua)
        Me.pnlAgregarUs.Controls.Add(Me.txtTel)
        Me.pnlAgregarUs.Controls.Add(Me.CBPerfil)
        Me.pnlAgregarUs.Controls.Add(Me.LPerfil)
        Me.pnlAgregarUs.Controls.Add(Me.BBorrar)
        Me.pnlAgregarUs.Controls.Add(Me.Panel3)
        Me.pnlAgregarUs.Controls.Add(Me.Panel2)
        Me.pnlAgregarUs.Controls.Add(Me.LContr)
        Me.pnlAgregarUs.Controls.Add(Me.txtEmail)
        Me.pnlAgregarUs.Controls.Add(Me.txtContr)
        Me.pnlAgregarUs.Controls.Add(Me.txtUsua)
        Me.pnlAgregarUs.Controls.Add(Me.txtDni)
        Me.pnlAgregarUs.Controls.Add(Me.txtApe)
        Me.pnlAgregarUs.Controls.Add(Me.txtNom)
        Me.pnlAgregarUs.Controls.Add(Me.LTelef)
        Me.pnlAgregarUs.Controls.Add(Me.LEmail)
        Me.pnlAgregarUs.Controls.Add(Me.LDNI)
        Me.pnlAgregarUs.Controls.Add(Me.LApe)
        Me.pnlAgregarUs.Controls.Add(Me.LNom)
        Me.pnlAgregarUs.Controls.Add(Me.Label2)
        Me.pnlAgregarUs.Controls.Add(Me.BCancelar)
        Me.pnlAgregarUs.Controls.Add(Me.BAgregar)
        Me.pnlAgregarUs.Location = New System.Drawing.Point(216, 26)
        Me.pnlAgregarUs.Name = "pnlAgregarUs"
        Me.pnlAgregarUs.Size = New System.Drawing.Size(299, 409)
        Me.pnlAgregarUs.TabIndex = 6
        Me.pnlAgregarUs.Visible = False
        '
        'CBPerfil
        '
        Me.CBPerfil.FormattingEnabled = True
        Me.CBPerfil.Items.AddRange(New Object() {"administrador", "gerente", "vendedor"})
        Me.CBPerfil.Location = New System.Drawing.Point(128, 66)
        Me.CBPerfil.Name = "CBPerfil"
        Me.CBPerfil.Size = New System.Drawing.Size(101, 21)
        Me.CBPerfil.TabIndex = 19
        '
        'LPerfil
        '
        Me.LPerfil.AutoSize = True
        Me.LPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPerfil.Location = New System.Drawing.Point(51, 69)
        Me.LPerfil.Name = "LPerfil"
        Me.LPerfil.Size = New System.Drawing.Size(36, 13)
        Me.LPerfil.TabIndex = 18
        Me.LPerfil.Text = "Perfil"
        '
        'BBorrar
        '
        Me.BBorrar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BBorrar.FlatAppearance.BorderSize = 0
        Me.BBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBorrar.Location = New System.Drawing.Point(110, 362)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BBorrar.TabIndex = 17
        Me.BBorrar.Text = "Borrar"
        Me.BBorrar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(294, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 404)
        Me.Panel3.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 404)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(299, 5)
        Me.Panel2.TabIndex = 15
        '
        'LContr
        '
        Me.LContr.AutoSize = True
        Me.LContr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContr.Location = New System.Drawing.Point(37, 245)
        Me.LContr.Name = "LContr"
        Me.LContr.Size = New System.Drawing.Size(71, 13)
        Me.LContr.TabIndex = 14
        Me.LContr.Text = "Contraseña"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(128, 277)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(101, 20)
        Me.txtEmail.TabIndex = 13
        '
        'txtContr
        '
        Me.txtContr.Location = New System.Drawing.Point(128, 242)
        Me.txtContr.Name = "txtContr"
        Me.txtContr.Size = New System.Drawing.Size(101, 20)
        Me.txtContr.TabIndex = 12
        '
        'txtUsua
        '
        Me.txtUsua.Location = New System.Drawing.Point(128, 207)
        Me.txtUsua.Name = "txtUsua"
        Me.txtUsua.Size = New System.Drawing.Size(100, 20)
        Me.txtUsua.TabIndex = 11
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(129, 171)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 10
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(128, 136)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(101, 20)
        Me.txtApe.TabIndex = 9
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(128, 101)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(101, 20)
        Me.txtNom.TabIndex = 8
        '
        'LTelef
        '
        Me.LTelef.AutoSize = True
        Me.LTelef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTelef.Location = New System.Drawing.Point(51, 315)
        Me.LTelef.Name = "LTelef"
        Me.LTelef.Size = New System.Drawing.Size(57, 13)
        Me.LTelef.TabIndex = 7
        Me.LTelef.Text = "Telefono"
        '
        'LEmail
        '
        Me.LEmail.AutoSize = True
        Me.LEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmail.Location = New System.Drawing.Point(51, 280)
        Me.LEmail.Name = "LEmail"
        Me.LEmail.Size = New System.Drawing.Size(37, 13)
        Me.LEmail.TabIndex = 6
        Me.LEmail.Text = "Email"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDNI.Location = New System.Drawing.Point(50, 174)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(29, 13)
        Me.LDNI.TabIndex = 5
        Me.LDNI.Text = "DNI"
        '
        'LApe
        '
        Me.LApe.AutoSize = True
        Me.LApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApe.Location = New System.Drawing.Point(50, 139)
        Me.LApe.Name = "LApe"
        Me.LApe.Size = New System.Drawing.Size(52, 13)
        Me.LApe.TabIndex = 4
        Me.LApe.Text = "Apellido"
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNom.Location = New System.Drawing.Point(50, 104)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(50, 13)
        Me.LNom.TabIndex = 3
        Me.LNom.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Agregar Usuario"
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BCancelar.FlatAppearance.BorderSize = 0
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.Location = New System.Drawing.Point(201, 362)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 1
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BAgregar.FlatAppearance.BorderSize = 0
        Me.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.Location = New System.Drawing.Point(19, 362)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BAgregar.TabIndex = 0
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(139, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(505, 23)
        Me.TextBox1.TabIndex = 5
        '
        'dgvPerfil
        '
        Me.dgvPerfil.HeaderText = "Perfil"
        Me.dgvPerfil.Name = "dgvPerfil"
        Me.dgvPerfil.Width = 80
        '
        'dgvNombre
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNombre.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvNombre.HeaderText = "Nombre"
        Me.dgvNombre.Name = "dgvNombre"
        Me.dgvNombre.Width = 80
        '
        'dgvApellido
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dgvApellido.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvApellido.HeaderText = "Apellido"
        Me.dgvApellido.Name = "dgvApellido"
        Me.dgvApellido.Width = 80
        '
        'dgvDNI
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvDNI.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDNI.HeaderText = "DNI"
        Me.dgvDNI.Name = "dgvDNI"
        Me.dgvDNI.Width = 80
        '
        'dvgEmail
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dvgEmail.DefaultCellStyle = DataGridViewCellStyle11
        Me.dvgEmail.HeaderText = "Email"
        Me.dvgEmail.Name = "dvgEmail"
        Me.dvgEmail.Width = 80
        '
        'dvgTel
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dvgTel.DefaultCellStyle = DataGridViewCellStyle12
        Me.dvgTel.HeaderText = "Telefono"
        Me.dvgTel.Name = "dvgTel"
        Me.dvgTel.Width = 80
        '
        'dvgDireccion
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dvgDireccion.DefaultCellStyle = DataGridViewCellStyle13
        Me.dvgDireccion.HeaderText = "Direccion"
        Me.dvgDireccion.Name = "dvgDireccion"
        Me.dvgDireccion.Width = 80
        '
        'Usuario
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Usuario.DefaultCellStyle = DataGridViewCellStyle14
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Width = 80
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(128, 312)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(101, 20)
        Me.txtTel.TabIndex = 21
        '
        'LUsua
        '
        Me.LUsua.AutoSize = True
        Me.LUsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsua.Location = New System.Drawing.Point(50, 210)
        Me.LUsua.Name = "LUsua"
        Me.LUsua.Size = New System.Drawing.Size(50, 13)
        Me.LUsua.TabIndex = 22
        Me.LUsua.Text = "Usuario"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAgregarUs.ResumeLayout(False)
        Me.pnlAgregarUs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlAgregarUs As Panel
    Friend WithEvents LContr As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContr As TextBox
    Friend WithEvents txtUsua As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtApe As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents LTelef As Label
    Friend WithEvents LEmail As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LApe As Label
    Friend WithEvents LNom As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BBorrar As Button
    Friend WithEvents CBPerfil As ComboBox
    Friend WithEvents LPerfil As Label
    Friend WithEvents dgvPerfil As DataGridViewTextBoxColumn
    Friend WithEvents dgvNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvApellido As DataGridViewTextBoxColumn
    Friend WithEvents dgvDNI As DataGridViewTextBoxColumn
    Friend WithEvents dvgEmail As DataGridViewTextBoxColumn
    Friend WithEvents dvgTel As DataGridViewTextBoxColumn
    Friend WithEvents dvgDireccion As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents LUsua As Label
    Friend WithEvents txtTel As TextBox
End Class
