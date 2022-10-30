<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.PVentas = New System.Windows.Forms.Panel()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.DTdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LVentas = New System.Windows.Forms.Label()
        Me.dgvFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvID_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PVentas.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PVentas
        '
        Me.PVentas.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PVentas.Controls.Add(Me.LFecha)
        Me.PVentas.Controls.Add(Me.DTdesde)
        Me.PVentas.Controls.Add(Me.Label1)
        Me.PVentas.Controls.Add(Me.DataGridView1)
        Me.PVentas.Controls.Add(Me.LVentas)
        Me.PVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PVentas.Location = New System.Drawing.Point(0, 0)
        Me.PVentas.Name = "PVentas"
        Me.PVentas.Size = New System.Drawing.Size(800, 460)
        Me.PVentas.TabIndex = 0
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.Location = New System.Drawing.Point(503, 120)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(46, 13)
        Me.LFecha.TabIndex = 15
        Me.LFecha.Text = "Fecha:"
        '
        'DTdesde
        '
        Me.DTdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTdesde.Location = New System.Drawing.Point(558, 114)
        Me.DTdesde.Name = "DTdesde"
        Me.DTdesde.Size = New System.Drawing.Size(104, 20)
        Me.DTdesde.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(531, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvFecha, Me.dgvProducto, Me.dgvCantidad, Me.dgvNombre, Me.dgvApellido, Me.dgvID_Cliente, Me.dgvSubTotal})
        Me.DataGridView1.Location = New System.Drawing.Point(138, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(524, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'LVentas
        '
        Me.LVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVentas.AutoSize = True
        Me.LVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVentas.Location = New System.Drawing.Point(280, 22)
        Me.LVentas.Name = "LVentas"
        Me.LVentas.Size = New System.Drawing.Size(230, 37)
        Me.LVentas.TabIndex = 2
        Me.LVentas.Text = "Ventas Del Dia"
        '
        'dgvFecha
        '
        Me.dgvFecha.HeaderText = "Fecha"
        Me.dgvFecha.Name = "dgvFecha"
        '
        'dgvProducto
        '
        Me.dgvProducto.HeaderText = "Producto"
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.Width = 80
        '
        'dgvCantidad
        '
        Me.dgvCantidad.HeaderText = "Cantidad"
        Me.dgvCantidad.Name = "dgvCantidad"
        Me.dgvCantidad.Width = 80
        '
        'dgvNombre
        '
        Me.dgvNombre.HeaderText = "Nombre"
        Me.dgvNombre.Name = "dgvNombre"
        Me.dgvNombre.Width = 80
        '
        'dgvApellido
        '
        Me.dgvApellido.HeaderText = "Apellido"
        Me.dgvApellido.Name = "dgvApellido"
        Me.dgvApellido.Width = 80
        '
        'dgvID_Cliente
        '
        Me.dgvID_Cliente.HeaderText = "id_cliente"
        Me.dgvID_Cliente.Name = "dgvID_Cliente"
        Me.dgvID_Cliente.Width = 80
        '
        'dgvSubTotal
        '
        Me.dgvSubTotal.HeaderText = "Sub_Total"
        Me.dgvSubTotal.Name = "dgvSubTotal"
        Me.dgvSubTotal.Width = 80
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.PVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.PVentas.ResumeLayout(False)
        Me.PVentas.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PVentas As Panel
    Friend WithEvents LVentas As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents DTdesde As DateTimePicker
    Friend WithEvents dgvFecha As DataGridViewTextBoxColumn
    Friend WithEvents dgvProducto As DataGridViewTextBoxColumn
    Friend WithEvents dgvCantidad As DataGridViewTextBoxColumn
    Friend WithEvents dgvNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvApellido As DataGridViewTextBoxColumn
    Friend WithEvents dgvID_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents dgvSubTotal As DataGridViewTextBoxColumn
End Class
