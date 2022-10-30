<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportes))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PReportes = New System.Windows.Forms.Panel()
        Me.LReportes = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.CGrafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DTdesde = New System.Windows.Forms.DateTimePicker()
        Me.DThasta = New System.Windows.Forms.DateTimePicker()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.PReportes.SuspendLayout()
        CType(Me.CGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PReportes
        '
        Me.PReportes.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PReportes.Controls.Add(Me.LHasta)
        Me.PReportes.Controls.Add(Me.LDesde)
        Me.PReportes.Controls.Add(Me.DThasta)
        Me.PReportes.Controls.Add(Me.DTdesde)
        Me.PReportes.Controls.Add(Me.LReportes)
        Me.PReportes.Controls.Add(Me.btnExportar)
        Me.PReportes.Controls.Add(Me.CGrafico)
        Me.PReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PReportes.Location = New System.Drawing.Point(0, 0)
        Me.PReportes.Name = "PReportes"
        Me.PReportes.Size = New System.Drawing.Size(800, 460)
        Me.PReportes.TabIndex = 0
        '
        'LReportes
        '
        Me.LReportes.AutoSize = True
        Me.LReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LReportes.Location = New System.Drawing.Point(338, 19)
        Me.LReportes.Name = "LReportes"
        Me.LReportes.Size = New System.Drawing.Size(125, 30)
        Me.LReportes.TabIndex = 4
        Me.LReportes.Text = "Reportes"
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(687, 395)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(101, 40)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'CGrafico
        '
        Me.CGrafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CGrafico.BorderlineColor = System.Drawing.SystemColors.WindowText
        Me.CGrafico.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea2.Name = "ChartArea1"
        Me.CGrafico.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.CGrafico.Legends.Add(Legend2)
        Me.CGrafico.Location = New System.Drawing.Point(12, 117)
        Me.CGrafico.Name = "CGrafico"
        Me.CGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.CGrafico.Series.Add(Series2)
        Me.CGrafico.Size = New System.Drawing.Size(465, 318)
        Me.CGrafico.TabIndex = 0
        Me.CGrafico.Text = "Chart1"
        '
        'DTdesde
        '
        Me.DTdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTdesde.Location = New System.Drawing.Point(604, 143)
        Me.DTdesde.Name = "DTdesde"
        Me.DTdesde.Size = New System.Drawing.Size(104, 20)
        Me.DTdesde.TabIndex = 5
        '
        'DThasta
        '
        Me.DThasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DThasta.Location = New System.Drawing.Point(604, 271)
        Me.DThasta.Name = "DThasta"
        Me.DThasta.Size = New System.Drawing.Size(104, 20)
        Me.DThasta.TabIndex = 6
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDesde.Location = New System.Drawing.Point(546, 149)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(47, 13)
        Me.LDesde.TabIndex = 11
        Me.LDesde.Text = "Desde:"
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHasta.Location = New System.Drawing.Point(549, 278)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(44, 13)
        Me.LHasta.TabIndex = 12
        Me.LHasta.Text = "Hasta:"
        '
        'FormReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.PReportes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormReportes"
        Me.Text = "FormReportes"
        Me.PReportes.ResumeLayout(False)
        Me.PReportes.PerformLayout()
        CType(Me.CGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PReportes As Panel
    Friend WithEvents btnExportar As Button
    Friend WithEvents CGrafico As DataVisualization.Charting.Chart
    Friend WithEvents LReportes As Label
    Friend WithEvents DThasta As DateTimePicker
    Friend WithEvents DTdesde As DateTimePicker
    Friend WithEvents LHasta As Label
    Friend WithEvents LDesde As Label
End Class
