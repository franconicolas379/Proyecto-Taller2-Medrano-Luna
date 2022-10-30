<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.PClientes = New System.Windows.Forms.Panel()
        Me.pnlAgregar = New System.Windows.Forms.Panel()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelef = New System.Windows.Forms.TextBox()
        Me.txtDomic = New System.Windows.Forms.TextBox()
        Me.LStockMin = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPrecCos = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.btnGuardarC = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.LAgreClien = New System.Windows.Forms.Label()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.LClientes = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.PClientes.SuspendLayout()
        Me.pnlAgregar.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PClientes
        '
        Me.PClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PClientes.Controls.Add(Me.pnlAgregar)
        Me.PClientes.Controls.Add(Me.LBuscar)
        Me.PClientes.Controls.Add(Me.txtBuscar)
        Me.PClientes.Controls.Add(Me.btnModificar)
        Me.PClientes.Controls.Add(Me.btnEliminar)
        Me.PClientes.Controls.Add(Me.btnAgregar)
        Me.PClientes.Controls.Add(Me.LClientes)
        Me.PClientes.Controls.Add(Me.dgvClientes)
        Me.PClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PClientes.Location = New System.Drawing.Point(0, 0)
        Me.PClientes.Name = "PClientes"
        Me.PClientes.Size = New System.Drawing.Size(800, 460)
        Me.PClientes.TabIndex = 0
        '
        'pnlAgregar
        '
        Me.pnlAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAgregar.Controls.Add(Me.BBorrar)
        Me.pnlAgregar.Controls.Add(Me.Label1)
        Me.pnlAgregar.Controls.Add(Me.txtTelef)
        Me.pnlAgregar.Controls.Add(Me.txtDomic)
        Me.pnlAgregar.Controls.Add(Me.LStockMin)
        Me.pnlAgregar.Controls.Add(Me.LStock)
        Me.pnlAgregar.Controls.Add(Me.LPrecCos)
        Me.pnlAgregar.Controls.Add(Me.LCategoria)
        Me.pnlAgregar.Controls.Add(Me.LDni)
        Me.pnlAgregar.Controls.Add(Me.txtEmail)
        Me.pnlAgregar.Controls.Add(Me.txtNom)
        Me.pnlAgregar.Controls.Add(Me.txtDni)
        Me.pnlAgregar.Controls.Add(Me.txtApe)
        Me.pnlAgregar.Controls.Add(Me.btnGuardarC)
        Me.pnlAgregar.Controls.Add(Me.btnCancelar)
        Me.pnlAgregar.Controls.Add(Me.LAgreClien)
        Me.pnlAgregar.Location = New System.Drawing.Point(255, 21)
        Me.pnlAgregar.Name = "pnlAgregar"
        Me.pnlAgregar.Size = New System.Drawing.Size(299, 413)
        Me.pnlAgregar.TabIndex = 8
        Me.pnlAgregar.Visible = False
        '
        'BBorrar
        '
        Me.BBorrar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BBorrar.FlatAppearance.BorderSize = 0
        Me.BBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBorrar.Location = New System.Drawing.Point(110, 366)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BBorrar.TabIndex = 18
        Me.BBorrar.Text = "Borrar"
        Me.BBorrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Telefono"
        '
        'txtTelef
        '
        Me.txtTelef.Location = New System.Drawing.Point(137, 293)
        Me.txtTelef.Name = "txtTelef"
        Me.txtTelef.Size = New System.Drawing.Size(100, 20)
        Me.txtTelef.TabIndex = 17
        '
        'txtDomic
        '
        Me.txtDomic.Location = New System.Drawing.Point(137, 257)
        Me.txtDomic.Name = "txtDomic"
        Me.txtDomic.Size = New System.Drawing.Size(100, 20)
        Me.txtDomic.TabIndex = 16
        '
        'LStockMin
        '
        Me.LStockMin.AutoSize = True
        Me.LStockMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStockMin.Location = New System.Drawing.Point(46, 260)
        Me.LStockMin.Name = "LStockMin"
        Me.LStockMin.Size = New System.Drawing.Size(58, 13)
        Me.LStockMin.TabIndex = 15
        Me.LStockMin.Text = "Domicilio"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.Location = New System.Drawing.Point(46, 223)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(37, 13)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Email"
        '
        'LPrecCos
        '
        Me.LPrecCos.AutoSize = True
        Me.LPrecCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecCos.Location = New System.Drawing.Point(46, 187)
        Me.LPrecCos.Name = "LPrecCos"
        Me.LPrecCos.Size = New System.Drawing.Size(52, 13)
        Me.LPrecCos.TabIndex = 13
        Me.LPrecCos.Text = "Apellido"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.Location = New System.Drawing.Point(46, 152)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(50, 13)
        Me.LCategoria.TabIndex = 11
        Me.LCategoria.Text = "Nombre"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.Location = New System.Drawing.Point(46, 116)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(29, 13)
        Me.LDni.TabIndex = 10
        Me.LDni.Text = "DNI"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(137, 220)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(137, 149)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 8
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(137, 113)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 7
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(137, 184)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(100, 20)
        Me.txtApe.TabIndex = 4
        '
        'btnGuardarC
        '
        Me.btnGuardarC.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardarC.FlatAppearance.BorderSize = 0
        Me.btnGuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarC.Location = New System.Drawing.Point(21, 366)
        Me.btnGuardarC.Name = "btnGuardarC"
        Me.btnGuardarC.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarC.TabIndex = 1
        Me.btnGuardarC.Text = "Guardar"
        Me.btnGuardarC.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(203, 366)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'LAgreClien
        '
        Me.LAgreClien.AutoSize = True
        Me.LAgreClien.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAgreClien.Location = New System.Drawing.Point(78, 23)
        Me.LAgreClien.Name = "LAgreClien"
        Me.LAgreClien.Size = New System.Drawing.Size(141, 24)
        Me.LAgreClien.TabIndex = 3
        Me.LAgreClien.Text = "Agregar Cliente"
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscar.Location = New System.Drawing.Point(94, 75)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(103, 16)
        Me.LBuscar.TabIndex = 7
        Me.LBuscar.Text = "Buscar Por DNI:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(203, 72)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(351, 22)
        Me.txtBuscar.TabIndex = 6
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(623, 148)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(152, 34)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(623, 228)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(152, 34)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(623, 112)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(152, 30)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Cliente"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'LClientes
        '
        Me.LClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LClientes.AutoSize = True
        Me.LClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LClientes.Location = New System.Drawing.Point(345, 21)
        Me.LClientes.Name = "LClientes"
        Me.LClientes.Size = New System.Drawing.Size(131, 37)
        Me.LClientes.TabIndex = 1
        Me.LClientes.Text = "Clientes"
        '
        'dgvClientes
        '
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(63, 112)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(524, 299)
        Me.dgvClientes.TabIndex = 5
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.PClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.PClientes.ResumeLayout(False)
        Me.PClientes.PerformLayout()
        Me.pnlAgregar.ResumeLayout(False)
        Me.pnlAgregar.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PClientes As Panel
    Friend WithEvents pnlAgregar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTelef As TextBox
    Friend WithEvents txtDomic As TextBox
    Friend WithEvents LStockMin As Label
    Friend WithEvents LStock As Label
    Friend WithEvents LPrecCos As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents LDni As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtApe As TextBox
    Friend WithEvents btnGuardarC As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents LAgreClien As Label
    Friend WithEvents LBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents LClientes As Label
    Friend WithEvents BBorrar As Button
End Class
