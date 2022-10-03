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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LClientes = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.pnlAgregar = New System.Windows.Forms.Panel()
        Me.LAgreClien = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardarC = New System.Windows.Forms.Button()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LPrecCos = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LStockMin = New System.Windows.Forms.Label()
        Me.txtDomic = New System.Windows.Forms.TextBox()
        Me.txtTelef = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAgregar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pnlAgregar)
        Me.Panel2.Controls.Add(Me.LBuscar)
        Me.Panel2.Controls.Add(Me.txtBuscar)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.LClientes)
        Me.Panel2.Controls.Add(Me.dgvClientes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 460)
        Me.Panel2.TabIndex = 0
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
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(623, 112)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(152, 30)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Cliente"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(623, 228)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(152, 34)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(623, 148)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(152, 34)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(63, 112)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(524, 299)
        Me.dgvClientes.TabIndex = 5
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(236, 61)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(351, 22)
        Me.txtBuscar.TabIndex = 6
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscar.Location = New System.Drawing.Point(130, 64)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(103, 16)
        Me.LBuscar.TabIndex = 7
        Me.LBuscar.Text = "Buscar Por DNI:"
        '
        'pnlAgregar
        '
        Me.pnlAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(182, 366)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardarC
        '
        Me.btnGuardarC.Location = New System.Drawing.Point(40, 366)
        Me.btnGuardarC.Name = "btnGuardarC"
        Me.btnGuardarC.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarC.TabIndex = 1
        Me.btnGuardarC.Text = "Guardar"
        Me.btnGuardarC.UseVisualStyleBackColor = True
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(137, 184)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(100, 20)
        Me.txtApe.TabIndex = 4
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(137, 113)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 7
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(137, 149)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(137, 220)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 9
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(46, 116)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(26, 13)
        Me.LDni.TabIndex = 10
        Me.LDni.Text = "DNI"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(46, 152)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(44, 13)
        Me.LCategoria.TabIndex = 11
        Me.LCategoria.Text = "Nombre"
        '
        'LPrecCos
        '
        Me.LPrecCos.AutoSize = True
        Me.LPrecCos.Location = New System.Drawing.Point(46, 187)
        Me.LPrecCos.Name = "LPrecCos"
        Me.LPrecCos.Size = New System.Drawing.Size(44, 13)
        Me.LPrecCos.TabIndex = 13
        Me.LPrecCos.Text = "Apellido"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(46, 223)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(32, 13)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Email"
        '
        'LStockMin
        '
        Me.LStockMin.AutoSize = True
        Me.LStockMin.Location = New System.Drawing.Point(46, 260)
        Me.LStockMin.Name = "LStockMin"
        Me.LStockMin.Size = New System.Drawing.Size(49, 13)
        Me.LStockMin.TabIndex = 15
        Me.LStockMin.Text = "Domicilio"
        '
        'txtDomic
        '
        Me.txtDomic.Location = New System.Drawing.Point(137, 257)
        Me.txtDomic.Name = "txtDomic"
        Me.txtDomic.Size = New System.Drawing.Size(100, 20)
        Me.txtDomic.TabIndex = 16
        '
        'txtTelef
        '
        Me.txtTelef.Location = New System.Drawing.Point(137, 293)
        Me.txtTelef.Name = "txtTelef"
        Me.txtTelef.Size = New System.Drawing.Size(100, 20)
        Me.txtTelef.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Telefono"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAgregar.ResumeLayout(False)
        Me.pnlAgregar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
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
End Class
