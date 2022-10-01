<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCerrPrinc = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProduc = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnBkp = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPrincip = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblPrincip)
        Me.Panel1.Controls.Add(Me.btnCerrPrinc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 32)
        Me.Panel1.TabIndex = 1
        '
        'btnCerrPrinc
        '
        Me.btnCerrPrinc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrPrinc.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrPrinc.FlatAppearance.BorderSize = 0
        Me.btnCerrPrinc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrPrinc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrPrinc.Location = New System.Drawing.Point(967, 3)
        Me.btnCerrPrinc.Name = "btnCerrPrinc"
        Me.btnCerrPrinc.Size = New System.Drawing.Size(33, 26)
        Me.btnCerrPrinc.TabIndex = 3
        Me.btnCerrPrinc.Text = "X"
        Me.btnCerrPrinc.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUsuarios.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.Location = New System.Drawing.Point(8, 38)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(135, 50)
        Me.btnUsuarios.TabIndex = 4
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClientes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Location = New System.Drawing.Point(8, 94)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(135, 50)
        Me.btnClientes.TabIndex = 5
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnProduc
        '
        Me.btnProduc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProduc.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnProduc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnProduc.FlatAppearance.BorderSize = 0
        Me.btnProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduc.Location = New System.Drawing.Point(8, 150)
        Me.btnProduc.Name = "btnProduc"
        Me.btnProduc.Size = New System.Drawing.Size(135, 50)
        Me.btnProduc.TabIndex = 6
        Me.btnProduc.Text = "Productos"
        Me.btnProduc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProduc.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVentas.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.Location = New System.Drawing.Point(8, 206)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(135, 50)
        Me.btnVentas.TabIndex = 7
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReport.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(8, 262)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(135, 50)
        Me.btnReport.TabIndex = 8
        Me.btnReport.Text = "Reportes"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnBkp
        '
        Me.btnBkp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBkp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBkp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBkp.FlatAppearance.BorderSize = 0
        Me.btnBkp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBkp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBkp.Location = New System.Drawing.Point(8, 318)
        Me.btnBkp.Name = "btnBkp"
        Me.btnBkp.Size = New System.Drawing.Size(135, 50)
        Me.btnBkp.TabIndex = 9
        Me.btnBkp.Text = "BackUP"
        Me.btnBkp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBkp.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(8, 486)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 50)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.btnUsuarios)
        Me.Panel2.Controls.Add(Me.btnClientes)
        Me.Panel2.Controls.Add(Me.btnProduc)
        Me.Panel2.Controls.Add(Me.btnVentas)
        Me.Panel2.Controls.Add(Me.btnReport)
        Me.Panel2.Controls.Add(Me.btnBkp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(143, 555)
        Me.Panel2.TabIndex = 11
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 587)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrPrinc As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProduc As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnBkp As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblPrincip As Label
End Class
