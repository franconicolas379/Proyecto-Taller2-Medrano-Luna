Public Class MenuVendedor

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

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        AbrirFormHijo(New Factura())
        lblPrincip.Text = "Generar Facturas"
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormHijo(New Clientes())
        lblPrincip.Text = "Clientes"
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormHijo(New Ventas())
        lblPrincip.Text = "Ventas"
    End Sub
End Class