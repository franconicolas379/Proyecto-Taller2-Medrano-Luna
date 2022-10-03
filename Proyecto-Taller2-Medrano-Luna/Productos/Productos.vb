Public Class Productos
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        pnlAgregar.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlAgregar.Visible = False
    End Sub

    ''Private Sub btnGuardarP_Click(sender As Object, e As EventArgs) Handles btnGuardarP.Click
    ''   Dim consulta As String = "INSERT INTO Productos VALUES(@DESCRIPCION, @CATEGORIA, )"
    ''End Sub

End Class