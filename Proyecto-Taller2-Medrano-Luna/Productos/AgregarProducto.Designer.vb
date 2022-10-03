<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardarP = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtPVent = New System.Windows.Forms.TextBox()
        Me.txtPCom = New System.Windows.Forms.TextBox()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.LNombrePro = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LPrecioVen = New System.Windows.Forms.Label()
        Me.LPrecCom = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LStock)
        Me.Panel1.Controls.Add(Me.LPrecCom)
        Me.Panel1.Controls.Add(Me.LPrecioVen)
        Me.Panel1.Controls.Add(Me.LCategoria)
        Me.Panel1.Controls.Add(Me.LNombrePro)
        Me.Panel1.Controls.Add(Me.txtStock)
        Me.Panel1.Controls.Add(Me.txtCat)
        Me.Panel1.Controls.Add(Me.txtProd)
        Me.Panel1.Controls.Add(Me.txtPCom)
        Me.Panel1.Controls.Add(Me.txtPVent)
        Me.Panel1.Controls.Add(Me.btnGuardarP)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 393)
        Me.Panel1.TabIndex = 0
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
        'txtPVent
        '
        Me.txtPVent.Location = New System.Drawing.Point(137, 171)
        Me.txtPVent.Name = "txtPVent"
        Me.txtPVent.Size = New System.Drawing.Size(100, 20)
        Me.txtPVent.TabIndex = 4
        '
        'txtPCom
        '
        Me.txtPCom.Location = New System.Drawing.Point(137, 208)
        Me.txtPCom.Name = "txtPCom"
        Me.txtPCom.Size = New System.Drawing.Size(100, 20)
        Me.txtPCom.TabIndex = 6
        '
        'txtProd
        '
        Me.txtProd.Location = New System.Drawing.Point(137, 96)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(100, 20)
        Me.txtProd.TabIndex = 7
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(137, 133)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(100, 20)
        Me.txtCat.TabIndex = 8
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(137, 252)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 9
        '
        'LNombrePro
        '
        Me.LNombrePro.AutoSize = True
        Me.LNombrePro.Location = New System.Drawing.Point(47, 99)
        Me.LNombrePro.Name = "LNombrePro"
        Me.LNombrePro.Size = New System.Drawing.Size(44, 13)
        Me.LNombrePro.TabIndex = 10
        Me.LNombrePro.Text = "Nombre"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(47, 136)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(54, 13)
        Me.LCategoria.TabIndex = 11
        Me.LCategoria.Text = "Categoría"
        '
        'LPrecioVen
        '
        Me.LPrecioVen.AutoSize = True
        Me.LPrecioVen.Location = New System.Drawing.Point(47, 174)
        Me.LPrecioVen.Name = "LPrecioVen"
        Me.LPrecioVen.Size = New System.Drawing.Size(68, 13)
        Me.LPrecioVen.TabIndex = 12
        Me.LPrecioVen.Text = "Precio Venta"
        '
        'LPrecCom
        '
        Me.LPrecCom.AutoSize = True
        Me.LPrecCom.Location = New System.Drawing.Point(47, 208)
        Me.LPrecCom.Name = "LPrecCom"
        Me.LPrecCom.Size = New System.Drawing.Size(76, 13)
        Me.LPrecCom.TabIndex = 13
        Me.LPrecCom.Text = "Precio Compra"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(47, 255)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(35, 13)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 393)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarProducto"
        Me.Text = "AgregarProducto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardarP As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents LStock As Label
    Friend WithEvents LPrecCom As Label
    Friend WithEvents LPrecioVen As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents LNombrePro As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtCat As TextBox
    Friend WithEvents txtProd As TextBox
    Friend WithEvents txtPCom As TextBox
    Friend WithEvents txtPVent As TextBox
End Class
