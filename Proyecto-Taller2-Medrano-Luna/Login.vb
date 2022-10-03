Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim usuario As String
        Dim contraseña As String

        usuario = txtUsuar.Text
        contraseña = txtContr.Text

        If usuario = "santiago" And contraseña = "1234" Then
            Me.Hide()
            Dim nuevoForm As New MenuGerente
            nuevoForm.Show()
        ElseIf usuario = "nicolas" And contraseña = "1234" Then
            Me.Hide()
            Dim nuevoForm As New MenuVendedor
            nuevoForm.Show()
        ElseIf usuario = "otro" And contraseña = "1234" Then
            Me.Hide()
            Dim nuevoForm As New Form1
            nuevoForm.Show()
        End If
    End Sub
End Class