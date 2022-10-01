Public Class Form1
    Private Sub btnBkp_Click(sender As Object, e As EventArgs) Handles btnBkp.Click
        FormBkp.MdiParent = Me
        FormBkp.Show()

    End Sub

    Private Sub btnCerrPrinc_Click(sender As Object, e As EventArgs) Handles btnCerrPrinc.Click
        Me.Close()

    End Sub
End Class
