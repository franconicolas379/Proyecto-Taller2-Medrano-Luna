<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBkp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBkp))
        Me.btnBkp = New System.Windows.Forms.Button()
        Me.lblBkp = New System.Windows.Forms.Label()
        Me.lblActual = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBkp
        '
        Me.btnBkp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBkp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBkp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBkp.Location = New System.Drawing.Point(340, 321)
        Me.btnBkp.Name = "btnBkp"
        Me.btnBkp.Size = New System.Drawing.Size(121, 41)
        Me.btnBkp.TabIndex = 0
        Me.btnBkp.Text = "BackUp"
        Me.btnBkp.UseVisualStyleBackColor = False
        '
        'lblBkp
        '
        Me.lblBkp.AutoSize = True
        Me.lblBkp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBkp.Location = New System.Drawing.Point(22, 55)
        Me.lblBkp.Name = "lblBkp"
        Me.lblBkp.Size = New System.Drawing.Size(757, 54)
        Me.lblBkp.TabIndex = 1
        Me.lblBkp.Text = resources.GetString("lblBkp.Text")
        '
        'lblActual
        '
        Me.lblActual.AutoSize = True
        Me.lblActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActual.Location = New System.Drawing.Point(174, 239)
        Me.lblActual.Name = "lblActual"
        Me.lblActual.Size = New System.Drawing.Size(166, 18)
        Me.lblActual.TabIndex = 2
        Me.lblActual.Text = "Última Actualización:"
        '
        'FormBkp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.lblActual)
        Me.Controls.Add(Me.lblBkp)
        Me.Controls.Add(Me.btnBkp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBkp"
        Me.Text = "FormBkp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBkp As Button
    Friend WithEvents lblBkp As Label
    Friend WithEvents lblActual As Label
End Class
