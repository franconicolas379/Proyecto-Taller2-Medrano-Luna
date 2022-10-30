<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuGerente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.lblPrincip = New System.Windows.Forms.Label()
        Me.btnCerrPrinc = New System.Windows.Forms.Button()
        Me.pnlGerente = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBkp = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnProduc = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pnlGerente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightCyan
        Me.Panel1.Controls.Add(Me.lblBienvenido)
        Me.Panel1.Controls.Add(Me.lblPrincip)
        Me.Panel1.Controls.Add(Me.btnCerrPrinc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(140, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 32)
        Me.Panel1.TabIndex = 2
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Location = New System.Drawing.Point(22, 8)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(63, 13)
        Me.lblBienvenido.TabIndex = 11
        Me.lblBienvenido.Text = "Bienvenido:"
        '
        'lblPrincip
        '
        Me.lblPrincip.AutoSize = True
        Me.lblPrincip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincip.Location = New System.Drawing.Point(377, 8)
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
        Me.btnCerrPrinc.Location = New System.Drawing.Point(764, 3)
        Me.btnCerrPrinc.Name = "btnCerrPrinc"
        Me.btnCerrPrinc.Size = New System.Drawing.Size(33, 26)
        Me.btnCerrPrinc.TabIndex = 3
        Me.btnCerrPrinc.Text = "X"
        Me.btnCerrPrinc.UseVisualStyleBackColor = False
        '
        'pnlGerente
        '
        Me.pnlGerente.BackColor = System.Drawing.Color.LightCyan
        Me.pnlGerente.Controls.Add(Me.btnSalir)
        Me.pnlGerente.Controls.Add(Me.btnBkp)
        Me.pnlGerente.Controls.Add(Me.btnReport)
        Me.pnlGerente.Controls.Add(Me.btnVentas)
        Me.pnlGerente.Controls.Add(Me.btnProduc)
        Me.pnlGerente.Controls.Add(Me.btnClientes)
        Me.pnlGerente.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlGerente.Location = New System.Drawing.Point(0, 0)
        Me.pnlGerente.Name = "pnlGerente"
        Me.pnlGerente.Size = New System.Drawing.Size(140, 492)
        Me.pnlGerente.TabIndex = 14
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(5, 430)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 50)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnBkp
        '
        Me.btnBkp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBkp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBkp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBkp.FlatAppearance.BorderSize = 0
        Me.btnBkp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBkp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBkp.Image = CType(resources.GetObject("btnBkp.Image"), System.Drawing.Image)
        Me.btnBkp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBkp.Location = New System.Drawing.Point(5, 294)
        Me.btnBkp.Name = "btnBkp"
        Me.btnBkp.Size = New System.Drawing.Size(135, 50)
        Me.btnBkp.TabIndex = 15
        Me.btnBkp.Text = "BackUP"
        Me.btnBkp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBkp.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReport.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(5, 238)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(135, 50)
        Me.btnReport.TabIndex = 14
        Me.btnReport.Text = "Reportes"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVentas.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(5, 182)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(135, 50)
        Me.btnVentas.TabIndex = 13
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnProduc
        '
        Me.btnProduc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProduc.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnProduc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnProduc.FlatAppearance.BorderSize = 0
        Me.btnProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduc.Image = CType(resources.GetObject("btnProduc.Image"), System.Drawing.Image)
        Me.btnProduc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduc.Location = New System.Drawing.Point(5, 126)
        Me.btnProduc.Name = "btnProduc"
        Me.btnProduc.Size = New System.Drawing.Size(135, 50)
        Me.btnProduc.TabIndex = 12
        Me.btnProduc.Text = "Productos"
        Me.btnProduc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProduc.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClientes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(5, 70)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(135, 50)
        Me.btnClientes.TabIndex = 11
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(140, 32)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(800, 460)
        Me.pnlContenedor.TabIndex = 15
        '
        'MenuGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 492)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlGerente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuGerente"
        Me.Text = "MenuGerente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlGerente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents lblPrincip As Label
    Friend WithEvents btnCerrPrinc As Button
    Friend WithEvents pnlGerente As Panel
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProduc As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnBkp As Button
    Friend WithEvents btnSalir As Button
End Class
