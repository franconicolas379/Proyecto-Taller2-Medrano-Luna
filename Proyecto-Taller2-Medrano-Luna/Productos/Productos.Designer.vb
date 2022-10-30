<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.PProductos = New System.Windows.Forms.Panel()
        Me.pnlAgregar = New System.Windows.Forms.Panel()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.txtStockMin = New System.Windows.Forms.TextBox()
        Me.LStockMin = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPrecCos = New System.Windows.Forms.Label()
        Me.LPrecioVen = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LNombrePro = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPVent = New System.Windows.Forms.TextBox()
        Me.txtPCos = New System.Windows.Forms.TextBox()
        Me.btnGuardarP = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.dgvIdProdu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.LProductos = New System.Windows.Forms.Label()
        Me.PProductos.SuspendLayout()
        Me.pnlAgregar.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PProductos
        '
        Me.PProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PProductos.Controls.Add(Me.pnlAgregar)
        Me.PProductos.Controls.Add(Me.dgvProductos)
        Me.PProductos.Controls.Add(Me.btnEliminar)
        Me.PProductos.Controls.Add(Me.btnModificar)
        Me.PProductos.Controls.Add(Me.btnAgregar)
        Me.PProductos.Controls.Add(Me.LProductos)
        Me.PProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PProductos.Location = New System.Drawing.Point(0, 0)
        Me.PProductos.Name = "PProductos"
        Me.PProductos.Size = New System.Drawing.Size(800, 460)
        Me.PProductos.TabIndex = 0
        '
        'pnlAgregar
        '
        Me.pnlAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAgregar.Controls.Add(Me.BBorrar)
        Me.pnlAgregar.Controls.Add(Me.txtStockMin)
        Me.pnlAgregar.Controls.Add(Me.LStockMin)
        Me.pnlAgregar.Controls.Add(Me.LStock)
        Me.pnlAgregar.Controls.Add(Me.LPrecCos)
        Me.pnlAgregar.Controls.Add(Me.LPrecioVen)
        Me.pnlAgregar.Controls.Add(Me.LCategoria)
        Me.pnlAgregar.Controls.Add(Me.LNombrePro)
        Me.pnlAgregar.Controls.Add(Me.txtStock)
        Me.pnlAgregar.Controls.Add(Me.txtCat)
        Me.pnlAgregar.Controls.Add(Me.txtNom)
        Me.pnlAgregar.Controls.Add(Me.txtPVent)
        Me.pnlAgregar.Controls.Add(Me.txtPCos)
        Me.pnlAgregar.Controls.Add(Me.btnGuardarP)
        Me.pnlAgregar.Controls.Add(Me.btnCancelar)
        Me.pnlAgregar.Controls.Add(Me.Label1)
        Me.pnlAgregar.Location = New System.Drawing.Point(252, 34)
        Me.pnlAgregar.Name = "pnlAgregar"
        Me.pnlAgregar.Size = New System.Drawing.Size(299, 393)
        Me.pnlAgregar.TabIndex = 6
        Me.pnlAgregar.Visible = False
        '
        'BBorrar
        '
        Me.BBorrar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BBorrar.FlatAppearance.BorderSize = 0
        Me.BBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBorrar.Location = New System.Drawing.Point(112, 347)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BBorrar.TabIndex = 17
        Me.BBorrar.Text = "Borrar"
        Me.BBorrar.UseVisualStyleBackColor = False
        '
        'txtStockMin
        '
        Me.txtStockMin.Location = New System.Drawing.Point(137, 276)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Size = New System.Drawing.Size(100, 20)
        Me.txtStockMin.TabIndex = 16
        '
        'LStockMin
        '
        Me.LStockMin.AutoSize = True
        Me.LStockMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStockMin.Location = New System.Drawing.Point(46, 279)
        Me.LStockMin.Name = "LStockMin"
        Me.LStockMin.Size = New System.Drawing.Size(64, 13)
        Me.LStockMin.TabIndex = 15
        Me.LStockMin.Text = "Stock Min"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.Location = New System.Drawing.Point(46, 242)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(40, 13)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'LPrecCos
        '
        Me.LPrecCos.AutoSize = True
        Me.LPrecCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecCos.Location = New System.Drawing.Point(46, 171)
        Me.LPrecCos.Name = "LPrecCos"
        Me.LPrecCos.Size = New System.Drawing.Size(79, 13)
        Me.LPrecCos.TabIndex = 13
        Me.LPrecCos.Text = "Precio Costo"
        '
        'LPrecioVen
        '
        Me.LPrecioVen.AutoSize = True
        Me.LPrecioVen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecioVen.Location = New System.Drawing.Point(46, 206)
        Me.LPrecioVen.Name = "LPrecioVen"
        Me.LPrecioVen.Size = New System.Drawing.Size(80, 13)
        Me.LPrecioVen.TabIndex = 12
        Me.LPrecioVen.Text = "Precio Venta"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.Location = New System.Drawing.Point(46, 135)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(63, 13)
        Me.LCategoria.TabIndex = 11
        Me.LCategoria.Text = "Categoría"
        '
        'LNombrePro
        '
        Me.LNombrePro.AutoSize = True
        Me.LNombrePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombrePro.Location = New System.Drawing.Point(46, 99)
        Me.LNombrePro.Name = "LNombrePro"
        Me.LNombrePro.Size = New System.Drawing.Size(50, 13)
        Me.LNombrePro.TabIndex = 10
        Me.LNombrePro.Text = "Nombre"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(137, 239)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 9
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(137, 132)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(100, 20)
        Me.txtCat.TabIndex = 8
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(137, 96)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 7
        '
        'txtPVent
        '
        Me.txtPVent.Location = New System.Drawing.Point(137, 203)
        Me.txtPVent.Name = "txtPVent"
        Me.txtPVent.Size = New System.Drawing.Size(100, 20)
        Me.txtPVent.TabIndex = 6
        '
        'txtPCos
        '
        Me.txtPCos.Location = New System.Drawing.Point(137, 168)
        Me.txtPCos.Name = "txtPCos"
        Me.txtPCos.Size = New System.Drawing.Size(100, 20)
        Me.txtPCos.TabIndex = 4
        '
        'btnGuardarP
        '
        Me.btnGuardarP.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardarP.FlatAppearance.BorderSize = 0
        Me.btnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarP.Location = New System.Drawing.Point(21, 347)
        Me.btnGuardarP.Name = "btnGuardarP"
        Me.btnGuardarP.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarP.TabIndex = 1
        Me.btnGuardarP.Text = "Guardar"
        Me.btnGuardarP.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(203, 347)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Agregar Producto"
        '
        'dgvProductos
        '
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvIdProdu, Me.dgvNombre, Me.dgvCategoria, Me.dgvPrecioVenta, Me.dgvPrecioCompra, Me.dgvStock})
        Me.dgvProductos.Location = New System.Drawing.Point(59, 82)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(524, 329)
        Me.dgvProductos.TabIndex = 5
        '
        'dgvIdProdu
        '
        Me.dgvIdProdu.HeaderText = "id_producto"
        Me.dgvIdProdu.Name = "dgvIdProdu"
        Me.dgvIdProdu.Width = 80
        '
        'dgvNombre
        '
        Me.dgvNombre.HeaderText = "Nombre"
        Me.dgvNombre.Name = "dgvNombre"
        Me.dgvNombre.Width = 80
        '
        'dgvCategoria
        '
        Me.dgvCategoria.HeaderText = "Categoria"
        Me.dgvCategoria.Name = "dgvCategoria"
        Me.dgvCategoria.Width = 80
        '
        'dgvPrecioVenta
        '
        Me.dgvPrecioVenta.HeaderText = "Precio_Venta"
        Me.dgvPrecioVenta.Name = "dgvPrecioVenta"
        Me.dgvPrecioVenta.Width = 80
        '
        'dgvPrecioCompra
        '
        Me.dgvPrecioCompra.HeaderText = "Precio_Compra"
        Me.dgvPrecioCompra.Name = "dgvPrecioCompra"
        Me.dgvPrecioCompra.Width = 80
        '
        'dgvStock
        '
        Me.dgvStock.HeaderText = "Stock"
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.Width = 80
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(626, 363)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(162, 34)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(626, 310)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(162, 34)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(626, 119)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(162, 34)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Producto"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'LProductos
        '
        Me.LProductos.AutoSize = True
        Me.LProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProductos.Location = New System.Drawing.Point(316, 18)
        Me.LProductos.Name = "LProductos"
        Me.LProductos.Size = New System.Drawing.Size(137, 31)
        Me.LProductos.TabIndex = 0
        Me.LProductos.Text = "Productos"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.PProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.PProductos.ResumeLayout(False)
        Me.PProductos.PerformLayout()
        Me.pnlAgregar.ResumeLayout(False)
        Me.pnlAgregar.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PProductos As Panel
    Friend WithEvents LProductos As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents dgvIdProdu As DataGridViewTextBoxColumn
    Friend WithEvents dgvNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvCategoria As DataGridViewTextBoxColumn
    Friend WithEvents dgvPrecioVenta As DataGridViewTextBoxColumn
    Friend WithEvents dgvPrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents dgvStock As DataGridViewTextBoxColumn
    Friend WithEvents pnlAgregar As Panel
    Friend WithEvents LStock As Label
    Friend WithEvents LPrecCos As Label
    Friend WithEvents LPrecioVen As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents LNombrePro As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtCat As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPVent As TextBox
    Friend WithEvents txtPCos As TextBox
    Friend WithEvents btnGuardarP As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStockMin As TextBox
    Friend WithEvents LStockMin As Label
    Friend WithEvents BBorrar As Button
End Class
