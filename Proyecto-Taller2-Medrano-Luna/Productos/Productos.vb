Public Class Productos
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        pnlAgregar.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlAgregar.Visible = False
    End Sub

    Private Sub btnGuardarP_Click(sender As Object, e As EventArgs) Handles btnGuardarP.Click
        If (txtNom.Text = "") Or (txtCat.Text = "") Or (txtPCos.Text = "") Or (txtPVent.Text = "") Or (txtStock.Text = "") Or (txtStockMin.Text = "") Then
            MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
        ElseIf IsNumeric(txtNom.Text) Or IsNumeric(txtCat.Text) Then
            MsgBox("Complete con valores alfabeticos en nombre y categoria por favor", MsgBoxStyle.Critical, "Error")

        ElseIf Not IsNumeric(txtPCos.Text) Or Not IsNumeric(txtPVent.Text) Or IsNumeric(txtStock) Or IsNumeric(txtStockMin) Then
            MsgBox("solo valores numéricos en Precio Costo, Precio Venta, Stock y Stock Min por favor", MsgBoxStyle.Critical, "Error")
        Else
            dgvProductos.Rows.Add(
                txtNom.Text,
                txtCat.Text,
                txtPCos.Text,
                txtPVent.Text,
                txtStock.Text,
                txtStockMin.Text)
            txtNom.Clear()
            txtCat.Clear()
            txtPCos.Clear()
            txtPVent.Clear()
            txtStock.Clear()
            txtStockMin.Clear()
        End If
    End Sub

    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        txtNom.Clear()
        txtCat.Clear()
        txtPCos.Clear()
        txtPVent.Clear()
        txtStock.Clear()
        txtStockMin.Clear()
    End Sub

End Class