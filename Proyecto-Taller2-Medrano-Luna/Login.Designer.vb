<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.pnlLogTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtContr = New System.Windows.Forms.TextBox()
        Me.txtUsuar = New System.Windows.Forms.TextBox()
        Me.pnlContrLog = New System.Windows.Forms.Label()
        Me.pnlUsuarioLog = New System.Windows.Forms.Label()
        Me.pnlLogTop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLogTop
        '
        Me.pnlLogTop.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlLogTop.Controls.Add(Me.Label1)
        Me.pnlLogTop.Controls.Add(Me.Button1)
        Me.pnlLogTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogTop.Name = "pnlLogTop"
        Me.pnlLogTop.Size = New System.Drawing.Size(317, 36)
        Me.pnlLogTop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(122, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(282, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.btnIngresar)
        Me.Panel2.Controls.Add(Me.txtContr)
        Me.Panel2.Controls.Add(Me.txtUsuar)
        Me.Panel2.Controls.Add(Me.pnlContrLog)
        Me.Panel2.Controls.Add(Me.pnlUsuarioLog)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(317, 454)
        Me.Panel2.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(162, 403)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(68, 403)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(88, 23)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'txtContr
        '
        Me.txtContr.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtContr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContr.Location = New System.Drawing.Point(80, 257)
        Me.txtContr.Name = "txtContr"
        Me.txtContr.Size = New System.Drawing.Size(156, 26)
        Me.txtContr.TabIndex = 3
        '
        'txtUsuar
        '
        Me.txtUsuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUsuar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuar.Location = New System.Drawing.Point(80, 118)
        Me.txtUsuar.Name = "txtUsuar"
        Me.txtUsuar.Size = New System.Drawing.Size(156, 26)
        Me.txtUsuar.TabIndex = 2
        '
        'pnlContrLog
        '
        Me.pnlContrLog.AutoSize = True
        Me.pnlContrLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlContrLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlContrLog.Location = New System.Drawing.Point(123, 197)
        Me.pnlContrLog.Name = "pnlContrLog"
        Me.pnlContrLog.Size = New System.Drawing.Size(91, 17)
        Me.pnlContrLog.TabIndex = 1
        Me.pnlContrLog.Text = "Contraseña"
        '
        'pnlUsuarioLog
        '
        Me.pnlUsuarioLog.AutoSize = True
        Me.pnlUsuarioLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUsuarioLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlUsuarioLog.Location = New System.Drawing.Point(133, 88)
        Me.pnlUsuarioLog.Name = "pnlUsuarioLog"
        Me.pnlUsuarioLog.Size = New System.Drawing.Size(64, 17)
        Me.pnlUsuarioLog.TabIndex = 0
        Me.pnlUsuarioLog.Text = "Usuario"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 490)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlLogTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        Me.pnlLogTop.ResumeLayout(False)
        Me.pnlLogTop.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLogTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtContr As TextBox
    Friend WithEvents txtUsuar As TextBox
    Friend WithEvents pnlContrLog As Label
    Friend WithEvents pnlUsuarioLog As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnIngresar As Button
End Class
