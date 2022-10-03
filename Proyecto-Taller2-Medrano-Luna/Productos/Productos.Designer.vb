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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlAgregar = New System.Windows.Forms.Panel()
        Me.txtStockMin = New System.Windows.Forms.TextBox()
        Me.LStockMin = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPrecCos = New System.Windows.Forms.Label()
        Me.LPrecioVen = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LNombrePro = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.txtPCom = New System.Windows.Forms.TextBox()
        Me.txtPVent = New System.Windows.Forms.TextBox()
        Me.btnGuardarP = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.Panel1.SuspendLayout()
        Me.pnlAgregar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlAgregar)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.LProductos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 460)
        Me.Panel1.TabIndex = 0
        '
        'pnlAgregar
        '
        Me.pnlAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAgregar.Controls.Add(Me.txtStockMin)
        Me.pnlAgregar.Controls.Add(Me.LStockMin)
        Me.pnlAgregar.Controls.Add(Me.LStock)
        Me.pnlAgregar.Controls.Add(Me.LPrecCos)
        Me.pnlAgregar.Controls.Add(Me.LPrecioVen)
        Me.pnlAgregar.Controls.Add(Me.LCategoria)
        Me.pnlAgregar.Controls.Add(Me.LNombrePro)
        Me.pnlAgregar.Controls.Add(Me.txtStock)
        Me.pnlAgregar.Controls.Add(Me.txtCat)
        Me.pnlAgregar.Controls.Add(Me.txtProd)
        Me.pnlAgregar.Controls.Add(Me.txtPCom)
        Me.pnlAgregar.Controls.Add(Me.txtPVent)
        Me.pnlAgregar.Controls.Add(Me.btnGuardarP)
        Me.pnlAgregar.Controls.Add(Me.btnCancelar)
        Me.pnlAgregar.Controls.Add(Me.Label1)
        Me.pnlAgregar.Location = New System.Drawing.Point(237, 43)
        Me.pnlAgregar.Name = "pnlAgregar"
        Me.pnlAgregar.Size = New System.Drawing.Size(299, 393)
        Me.pnlAgregar.TabIndex = 6
        Me.pnlAgregar.Visible = False
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
        Me.LStockMin.Location = New System.Drawing.Point(46, 279)
        Me.LStockMin.Name = "LStockMin"
        Me.LStockMin.Size = New System.Drawing.Size(55, 13)
        Me.LStockMin.TabIndex = 15
        Me.LStockMin.Text = "Stock Min"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(46, 242)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(35, 13)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'LPrecCos
        '
        Me.LPrecCos.AutoSize = True
        Me.LPrecCos.Location = New System.Drawing.Point(46, 171)
        Me.LPrecCos.Name = "LPrecCos"
        Me.LPrecCos.Size = New System.Drawing.Size(67, 13)
        Me.LPrecCos.TabIndex = 13
        Me.LPrecCos.Text = "Precio Costo"
        '
        'LPrecioVen
        '
        Me.LPrecioVen.AutoSize = True
        Me.LPrecioVen.Location = New System.Drawing.Point(46, 206)
        Me.LPrecioVen.Name = "LPrecioVen"
        Me.LPrecioVen.Size = New System.Drawing.Size(68, 13)
        Me.LPrecioVen.TabIndex = 12
        Me.LPrecioVen.Text = "Precio Venta"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(46, 135)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(54, 13)
        Me.LCategoria.TabIndex = 11
        Me.LCategoria.Text = "Categoría"
        '
        'LNombrePro
        '
        Me.LNombrePro.AutoSize = True
        Me.LNombrePro.Location = New System.Drawing.Point(46, 99)
        Me.LNombrePro.Name = "LNombrePro"
        Me.LNombrePro.Size = New System.Drawing.Size(44, 13)
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
        'txtProd
        '
        Me.txtProd.Location = New System.Drawing.Point(137, 96)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(100, 20)
        Me.txtProd.TabIndex = 7
        '
        'txtPCom
        '
        Me.txtPCom.Location = New System.Drawing.Point(137, 203)
        Me.txtPCom.Name = "txtPCom"
        Me.txtPCom.Size = New System.Drawing.Size(100, 20)
        Me.txtPCom.TabIndex = 6
        '
        'txtPVent
        '
        Me.txtPVent.Location = New System.Drawing.Point(137, 168)
        Me.txtPVent.Name = "txtPVent"
        Me.txtPVent.Size = New System.Drawing.Size(100, 20)
        Me.txtPVent.TabIndex = 4
        '
        'btnGuardarP
        '
        Me.btnGuardarP.Location = New System.Drawing.Point(40, 347)
        Me.btnGuardarP.Name = "btnGuardarP"
        Me.btnGuardarP.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarP.TabIndex = 1
        Me.btnGuardarP.Text = "Guardar"
        Me.btnGuardarP.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(187, 347)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
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
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvIdProdu, Me.dgvNombre, Me.dgvCategoria, Me.dgvPrecioVenta, Me.dgvPrecioCompra, Me.dgvStock})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(524, 312)
        Me.DataGridView1.TabIndex = 5
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
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(626, 363)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(162, 34)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(626, 310)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(162, 34)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(626, 85)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(162, 34)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Producto"
        Me.btnAgregar.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlAgregar.ResumeLayout(False)
        Me.pnlAgregar.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LProductos As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents txtProd As TextBox
    Friend WithEvents txtPCom As TextBox
    Friend WithEvents txtPVent As TextBox
    Friend WithEvents btnGuardarP As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStockMin As TextBox
    Friend WithEvents LStockMin As Label
End Class
