<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuVendedor
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
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.lblPrincip = New System.Windows.Forms.Label()
        Me.btnCerrPrinc = New System.Windows.Forms.Button()
        Me.pnlVendedor = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pnlVendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblBienvenido)
        Me.Panel1.Controls.Add(Me.lblPrincip)
        Me.Panel1.Controls.Add(Me.btnCerrPrinc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 32)
        Me.Panel1.TabIndex = 2
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Location = New System.Drawing.Point(22, 9)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(63, 13)
        Me.lblBienvenido.TabIndex = 11
        Me.lblBienvenido.Text = "Bienvenido:"
        '
        'lblPrincip
        '
        Me.lblPrincip.AutoSize = True
        Me.lblPrincip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincip.Location = New System.Drawing.Point(488, 9)
        Me.lblPrincip.Name = "lblPrincip"
        Me.lblPrincip.Size = New System.Drawing.Size(46, 17)
        Me.lblPrincip.TabIndex = 4
        Me.lblPrincip.Text = "Inicio"
        '
        'btnCerrPrinc
        '
        Me.btnCerrPrinc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrPrinc.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrPrinc.FlatAppearance.BorderSize = 0
        Me.btnCerrPrinc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrPrinc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrPrinc.Location = New System.Drawing.Point(904, 3)
        Me.btnCerrPrinc.Name = "btnCerrPrinc"
        Me.btnCerrPrinc.Size = New System.Drawing.Size(33, 26)
        Me.btnCerrPrinc.TabIndex = 3
        Me.btnCerrPrinc.Text = "X"
        Me.btnCerrPrinc.UseVisualStyleBackColor = False
        '
        'pnlVendedor
        '
        Me.pnlVendedor.BackColor = System.Drawing.Color.White
        Me.pnlVendedor.Controls.Add(Me.btnSalir)
        Me.pnlVendedor.Controls.Add(Me.btnVentas)
        Me.pnlVendedor.Controls.Add(Me.btnClientes)
        Me.pnlVendedor.Controls.Add(Me.btnFacturas)
        Me.pnlVendedor.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlVendedor.Location = New System.Drawing.Point(0, 32)
        Me.pnlVendedor.Name = "pnlVendedor"
        Me.pnlVendedor.Size = New System.Drawing.Size(140, 460)
        Me.pnlVendedor.TabIndex = 13
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(5, 398)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 50)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVentas.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.Location = New System.Drawing.Point(5, 118)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(135, 50)
        Me.btnVentas.TabIndex = 13
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClientes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Location = New System.Drawing.Point(5, 62)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(135, 50)
        Me.btnClientes.TabIndex = 12
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnFacturas
        '
        Me.btnFacturas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFacturas.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnFacturas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFacturas.FlatAppearance.BorderSize = 0
        Me.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturas.Location = New System.Drawing.Point(5, 6)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(135, 50)
        Me.btnFacturas.TabIndex = 7
        Me.btnFacturas.Text = "Facturas"
        Me.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFacturas.UseVisualStyleBackColor = False
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(140, 32)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(800, 460)
        Me.pnlContenedor.TabIndex = 14
        '
        'MenuVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 492)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlVendedor)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuVendedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlVendedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents lblPrincip As Label
    Friend WithEvents btnCerrPrinc As Button
    Friend WithEvents pnlVendedor As Panel
    Friend WithEvents btnFacturas As Button
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnSalir As Button
End Class
