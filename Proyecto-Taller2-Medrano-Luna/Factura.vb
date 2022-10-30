Public Class Factura
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtNombre.Text <> " " And txtApe.Text <> " " And txtDNI.Text <> " " And txtTel.Text <> " " Then
            LCliente.Text = "Clientes: " & txtNombre.Text
            txtNombre.Clear()
            txtApe.Clear()
            txtDNI.Clear()
            txtTel.Clear()
        Else
            MsgBox("Debe completar todos los campos", vbOK + vbCritical, "Error")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardarPro.Click
        If txtProd.Text <> " " And txtCant.Text <> " " And txtPrecio.Text <> " " Then
            dgvFact.Rows.Add(
                txtProd.Text,
                txtCant.Text,
                txtPrecio.Text)
            txtProd.Clear()
            txtCant.Clear()
            txtPrecio.Clear()
        Else
            MsgBox("Debe completar todos los campos", vbOK + vbCritical, "Error")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCanCli.Click
        txtNombre.Clear()
        txtApe.Clear()
        txtDNI.Clear()
        txtTel.Clear()
    End Sub

    Private Sub btnCanProd_Click(sender As Object, e As EventArgs) Handles btnCanProd.Click
        txtProd.Clear()
        txtCant.Clear()
        txtPrecio.Clear()
    End Sub
End Class