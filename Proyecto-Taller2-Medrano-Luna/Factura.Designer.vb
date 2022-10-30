<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Factura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PFactura = New System.Windows.Forms.Panel()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.LCliente = New System.Windows.Forms.Label()
        Me.dgvFact = New System.Windows.Forms.DataGridView()
        Me.prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.elim = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PCliente = New System.Windows.Forms.Panel()
        Me.LSelCllien = New System.Windows.Forms.Label()
        Me.btnCanCli = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LTel = New System.Windows.Forms.Label()
        Me.LNom = New System.Windows.Forms.Label()
        Me.LApe = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.PProducto = New System.Windows.Forms.Panel()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.LAgregarProd = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.Lcant = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.LBusProd = New System.Windows.Forms.Label()
        Me.btnGuardarPro = New System.Windows.Forms.Button()
        Me.btnCanProd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LFactura = New System.Windows.Forms.Label()
        Me.BBuscarCli = New System.Windows.Forms.Button()
        Me.PFactura.SuspendLayout()
        CType(Me.dgvFact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCliente.SuspendLayout()
        Me.PProducto.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PFactura
        '
        Me.PFactura.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PFactura.Controls.Add(Me.LTotal)
        Me.PFactura.Controls.Add(Me.LCliente)
        Me.PFactura.Controls.Add(Me.dgvFact)
        Me.PFactura.Controls.Add(Me.Button3)
        Me.PFactura.Controls.Add(Me.PCliente)
        Me.PFactura.Controls.Add(Me.PProducto)
        Me.PFactura.Controls.Add(Me.Panel2)
        Me.PFactura.Controls.Add(Me.LFactura)
        Me.PFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PFactura.Location = New System.Drawing.Point(0, 0)
        Me.PFactura.Name = "PFactura"
        Me.PFactura.Size = New System.Drawing.Size(755, 467)
        Me.PFactura.TabIndex = 0
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.Location = New System.Drawing.Point(626, 361)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(40, 13)
        Me.LTotal.TabIndex = 22
        Me.LTotal.Text = "Total:"
        '
        'LCliente
        '
        Me.LCliente.AutoSize = True
        Me.LCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCliente.Location = New System.Drawing.Point(316, 361)
        Me.LCliente.Name = "LCliente"
        Me.LCliente.Size = New System.Drawing.Size(50, 13)
        Me.LCliente.TabIndex = 21
        Me.LCliente.Text = "Cliente:"
        '
        'dgvFact
        '
        Me.dgvFact.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.dgvFact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFact.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFact.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod, Me.cant, Me.prec, Me.elim})
        Me.dgvFact.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvFact.Location = New System.Drawing.Point(304, 56)
        Me.dgvFact.MultiSelect = False
        Me.dgvFact.Name = "dgvFact"
        Me.dgvFact.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvFact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFact.Size = New System.Drawing.Size(440, 280)
        Me.dgvFact.TabIndex = 11
        '
        'prod
        '
        Me.prod.HeaderText = "Producto"
        Me.prod.Name = "prod"
        '
        'cant
        '
        Me.cant.HeaderText = "Cantidad"
        Me.cant.Name = "cant"
        '
        'prec
        '
        Me.prec.HeaderText = "Precio"
        Me.prec.Name = "prec"
        '
        'elim
        '
        Me.elim.HeaderText = ""
        Me.elim.Name = "elim"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(653, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Confirmar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PCliente
        '
        Me.PCliente.Controls.Add(Me.BBuscarCli)
        Me.PCliente.Controls.Add(Me.LSelCllien)
        Me.PCliente.Controls.Add(Me.btnCanCli)
        Me.PCliente.Controls.Add(Me.Button4)
        Me.PCliente.Controls.Add(Me.LTel)
        Me.PCliente.Controls.Add(Me.LNom)
        Me.PCliente.Controls.Add(Me.LApe)
        Me.PCliente.Controls.Add(Me.LDNI)
        Me.PCliente.Controls.Add(Me.txtApe)
        Me.PCliente.Controls.Add(Me.txtDNI)
        Me.PCliente.Controls.Add(Me.txtTel)
        Me.PCliente.Controls.Add(Me.txtNombre)
        Me.PCliente.Location = New System.Drawing.Point(12, 56)
        Me.PCliente.Name = "PCliente"
        Me.PCliente.Size = New System.Drawing.Size(286, 205)
        Me.PCliente.TabIndex = 6
        '
        'LSelCllien
        '
        Me.LSelCllien.AutoSize = True
        Me.LSelCllien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSelCllien.Location = New System.Drawing.Point(65, 14)
        Me.LSelCllien.Name = "LSelCllien"
        Me.LSelCllien.Size = New System.Drawing.Size(46, 13)
        Me.LSelCllien.TabIndex = 23
        Me.LSelCllien.Text = "Cliente"
        '
        'btnCanCli
        '
        Me.btnCanCli.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCanCli.FlatAppearance.BorderSize = 0
        Me.btnCanCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCanCli.Location = New System.Drawing.Point(161, 164)
        Me.btnCanCli.Name = "btnCanCli"
        Me.btnCanCli.Size = New System.Drawing.Size(75, 23)
        Me.btnCanCli.TabIndex = 22
        Me.btnCanCli.Text = "Cancelar"
        Me.btnCanCli.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(36, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Agregar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'LTel
        '
        Me.LTel.AutoSize = True
        Me.LTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTel.Location = New System.Drawing.Point(24, 128)
        Me.LTel.Name = "LTel"
        Me.LTel.Size = New System.Drawing.Size(57, 13)
        Me.LTel.TabIndex = 20
        Me.LTel.Text = "Teléfono"
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNom.Location = New System.Drawing.Point(24, 43)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(50, 13)
        Me.LNom.TabIndex = 19
        Me.LNom.Text = "Nombre"
        '
        'LApe
        '
        Me.LApe.AutoSize = True
        Me.LApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApe.Location = New System.Drawing.Point(24, 69)
        Me.LApe.Name = "LApe"
        Me.LApe.Size = New System.Drawing.Size(52, 13)
        Me.LApe.TabIndex = 18
        Me.LApe.Text = "Apellido"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDNI.Location = New System.Drawing.Point(24, 98)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(29, 13)
        Me.LDNI.TabIndex = 17
        Me.LDNI.Text = "DNI"
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(139, 69)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(100, 20)
        Me.txtApe.TabIndex = 16
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(139, 95)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 15
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(139, 121)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(100, 20)
        Me.txtTel.TabIndex = 14
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(139, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 13
        '
        'PProducto
        '
        Me.PProducto.Controls.Add(Me.LPrecio)
        Me.PProducto.Controls.Add(Me.txtPrecio)
        Me.PProducto.Controls.Add(Me.LAgregarProd)
        Me.PProducto.Controls.Add(Me.LStock)
        Me.PProducto.Controls.Add(Me.Lcant)
        Me.PProducto.Controls.Add(Me.txtStock)
        Me.PProducto.Controls.Add(Me.txtCant)
        Me.PProducto.Controls.Add(Me.txtProd)
        Me.PProducto.Controls.Add(Me.LBusProd)
        Me.PProducto.Controls.Add(Me.btnGuardarPro)
        Me.PProducto.Controls.Add(Me.btnCanProd)
        Me.PProducto.Location = New System.Drawing.Point(12, 283)
        Me.PProducto.Name = "PProducto"
        Me.PProducto.Size = New System.Drawing.Size(286, 172)
        Me.PProducto.TabIndex = 5
        '
        'LPrecio
        '
        Me.LPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecio.Location = New System.Drawing.Point(127, 110)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(43, 13)
        Me.LPrecio.TabIndex = 26
        Me.LPrecio.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPrecio.Location = New System.Drawing.Point(199, 107)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(75, 20)
        Me.txtPrecio.TabIndex = 25
        '
        'LAgregarProd
        '
        Me.LAgregarProd.AutoSize = True
        Me.LAgregarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAgregarProd.Location = New System.Drawing.Point(114, 9)
        Me.LAgregarProd.Name = "LAgregarProd"
        Me.LAgregarProd.Size = New System.Drawing.Size(58, 13)
        Me.LAgregarProd.TabIndex = 24
        Me.LAgregarProd.Text = "Producto"
        '
        'LStock
        '
        Me.LStock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.Location = New System.Drawing.Point(3, 78)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(40, 13)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'Lcant
        '
        Me.Lcant.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lcant.AutoSize = True
        Me.Lcant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcant.Location = New System.Drawing.Point(127, 78)
        Me.Lcant.Name = "Lcant"
        Me.Lcant.Size = New System.Drawing.Size(57, 13)
        Me.Lcant.TabIndex = 13
        Me.Lcant.Text = "Cantidad"
        '
        'txtStock
        '
        Me.txtStock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStock.Location = New System.Drawing.Point(59, 75)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(59, 20)
        Me.txtStock.TabIndex = 12
        '
        'txtCant
        '
        Me.txtCant.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCant.Location = New System.Drawing.Point(199, 75)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(75, 20)
        Me.txtCant.TabIndex = 11
        '
        'txtProd
        '
        Me.txtProd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProd.Location = New System.Drawing.Point(113, 40)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(100, 20)
        Me.txtProd.TabIndex = 10
        '
        'LBusProd
        '
        Me.LBusProd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LBusProd.AutoSize = True
        Me.LBusProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBusProd.Location = New System.Drawing.Point(23, 43)
        Me.LBusProd.Name = "LBusProd"
        Me.LBusProd.Size = New System.Drawing.Size(58, 13)
        Me.LBusProd.TabIndex = 9
        Me.LBusProd.Text = "Producto"
        '
        'btnGuardarPro
        '
        Me.btnGuardarPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarPro.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardarPro.FlatAppearance.BorderSize = 0
        Me.btnGuardarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarPro.Location = New System.Drawing.Point(36, 142)
        Me.btnGuardarPro.Name = "btnGuardarPro"
        Me.btnGuardarPro.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarPro.TabIndex = 7
        Me.btnGuardarPro.Text = "Agregar"
        Me.btnGuardarPro.UseVisualStyleBackColor = False
        '
        'btnCanProd
        '
        Me.btnCanProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCanProd.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCanProd.FlatAppearance.BorderSize = 0
        Me.btnCanProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCanProd.Location = New System.Drawing.Point(161, 142)
        Me.btnCanProd.Name = "btnCanProd"
        Me.btnCanProd.Size = New System.Drawing.Size(75, 23)
        Me.btnCanProd.TabIndex = 8
        Me.btnCanProd.Text = "Cancelar"
        Me.btnCanProd.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LVendedor)
        Me.Panel2.Controls.Add(Me.LFecha)
        Me.Panel2.Location = New System.Drawing.Point(255, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(359, 35)
        Me.Panel2.TabIndex = 4
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendedor.Location = New System.Drawing.Point(159, 9)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(65, 13)
        Me.LVendedor.TabIndex = 1
        Me.LVendedor.Text = "Vendedor:"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.Location = New System.Drawing.Point(3, 9)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(46, 13)
        Me.LFecha.TabIndex = 0
        Me.LFecha.Text = "Fecha:"
        '
        'LFactura
        '
        Me.LFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LFactura.AutoSize = True
        Me.LFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFactura.Location = New System.Drawing.Point(76, 9)
        Me.LFactura.Name = "LFactura"
        Me.LFactura.Size = New System.Drawing.Size(107, 31)
        Me.LFactura.TabIndex = 3
        Me.LFactura.Text = "Factura"
        '
        'BBuscarCli
        '
        Me.BBuscarCli.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BBuscarCli.FlatAppearance.BorderSize = 0
        Me.BBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarCli.Location = New System.Drawing.Point(152, 9)
        Me.BBuscarCli.Name = "BBuscarCli"
        Me.BBuscarCli.Size = New System.Drawing.Size(98, 23)
        Me.BBuscarCli.TabIndex = 24
        Me.BBuscarCli.Text = "Buscar Cliente"
        Me.BBuscarCli.UseVisualStyleBackColor = False
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 467)
        Me.Controls.Add(Me.PFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.PFactura.ResumeLayout(False)
        Me.PFactura.PerformLayout()
        CType(Me.dgvFact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCliente.ResumeLayout(False)
        Me.PCliente.PerformLayout()
        Me.PProducto.ResumeLayout(False)
        Me.PProducto.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PFactura As Panel
    Friend WithEvents LFactura As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LVendedor As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents prod As DataGridViewTextBoxColumn
    Friend WithEvents cant As DataGridViewTextBoxColumn
    Friend WithEvents prec As DataGridViewTextBoxColumn
    Friend WithEvents elim As DataGridViewImageColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents PCliente As Panel
    Friend WithEvents PProducto As Panel
    Friend WithEvents LBusProd As Label
    Friend WithEvents btnGuardarPro As Button
    Friend WithEvents btnCanProd As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtCant As TextBox
    Friend WithEvents txtProd As TextBox
    Friend WithEvents LTel As Label
    Friend WithEvents LNom As Label
    Friend WithEvents LApe As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents txtApe As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents LCliente As Label
    Friend WithEvents btnCanCli As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents LStock As Label
    Friend WithEvents Lcant As Label
    Friend WithEvents LTotal As Label
    Friend WithEvents dgvFact As DataGridView
    Friend WithEvents LSelCllien As Label
    Friend WithEvents LAgregarProd As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents BBuscarCli As Button
End Class
