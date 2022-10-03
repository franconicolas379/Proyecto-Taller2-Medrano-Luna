Public Class MenuGerente

    Private currentForm As Form = Nothing
    Private Sub AbrirFormHijo(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        pnlContenedor.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.BringToFront()
        childForm.Show()

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub btnCerrPrinc_Click(sender As Object, e As EventArgs) Handles btnCerrPrinc.Click
        End

    End Sub
    Private Sub btnBkp_Click(sender As Object, e As EventArgs) Handles btnBkp.Click
        AbrirFormHijo(New FormBkp())
        lblPrincip.Text = "Back Up"

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormHijo(New Clientes())
        lblPrincip.Text = "Clientes"
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormHijo(New Ventas())
        lblPrincip.Text = "Ventas"
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        AbrirFormHijo(New FormReportes())
        lblPrincip.Text = "Reportes"
    End Sub

    Private Sub btnProduc_Click(sender As Object, e As EventArgs) Handles btnProduc.Click
        AbrirFormHijo(New Productos())
        lblPrincip.Text = "Productos"
    End Sub
End Class