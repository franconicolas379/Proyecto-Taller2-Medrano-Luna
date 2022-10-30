Public Class Usuarios
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        pnlAgregarUs.Visible = True
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        pnlAgregarUs.Visible = False
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If (txtNom.Text = "") Or (txtApe.Text = "") Or (txtDni.Text = "") Or (txtUsua.Text = "") Or (txtContr.Text = "") Or (txtEmail.Text = "") Or (txtTel.Text = "") Then
            MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
        ElseIf IsNumeric(txtNom.Text) Or IsNumeric(txtApe.Text) Or IsNumeric(txtEmail.Text) Or IsNumeric(txtUsua.Text) Then
            MsgBox("Complete con valores alfabeticos en nombre, apellido, usuario y email por favor", MsgBoxStyle.Critical, "Error")

        ElseIf Not IsNumeric(txtDni.Text) Or Not IsNumeric(txtTel.Text) Then
            MsgBox("solo valores numéricos en dni y telefono por favor", MsgBoxStyle.Critical, "Error")
        Else
            dgvUsuarios.Rows.Add(
                txtNom.Text,
                txtApe.Text,
                txtDni.Text,
                txtUsua.Text,
                txtContr.Text,
                txtEmail.Text,
                txtTel.Text)
            txtNom.Clear()
            txtApe.Clear()
            txtDni.Clear()
            txtUsua.Clear()
            txtContr.Clear()
            txtEmail.Clear()
            txtTel.Clear()
        End If

    End Sub

    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        txtNom.Clear()
        txtApe.Clear()
        txtDni.Clear()
        txtUsua.Clear()
        txtContr.Clear()
        txtEmail.Clear()
        txtTel.Clear()
    End Sub

End Class