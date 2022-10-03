Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Clientes
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        pnlAgregar.Visible = True
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlAgregar.Visible = False
    End Sub

    Private Sub btnGuardarC_Click(sender As Object, e As EventArgs) Handles btnGuardarC.Click
        Using connection As New SqlConnection("Data Source=DESKTOP-GQ798UG\SQLEXPRESS_INST;Initial Catalog=ProyectoTaller;Integrated Security=True")
            Dim consultaSql As String = "SELECT COUNT(*) FROM Clientes WHERE (dni=@dni)"
            Dim comando As New SqlCommand(consultaSql, connection)
            comando.Parameters.AddWithValue("@dni", txtDni.Text)
            connection.Open()
            Dim Existe As Boolean = Convert.ToInt32(comando.ExecuteScalar) > 0

            If (txtDni.Text = "") Or (txtNom.Text = "") Or (txtApe.Text = "") Or (txtEmail.Text = "") Or (txtDomic.Text = "") Or (txtTelef.Text = "") Then
                MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
            Else
                If Existe Then
                    MsgBox("El dni ingresado ya existe", vbCritical, "Error")
                Else
                    Dim result As MsgBoxResult
                    result = MsgBox("¿Desea terminar y registrar el nuevo cliente?", 4 + 256 + 32, "Confirmación")
                    If result = vbYes Then
                        Try
                            Dim cmd As New SqlCommand
                            abrir()
                            cmd = New SqlCommand("INSERTAR_CLIENTES", connection)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@dni", txtDni.Text)
                            cmd.Parameters.AddWithValue("@nombre", txtNom.Text)
                            cmd.Parameters.AddWithValue("@apellido", txtApe.Text)
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                            cmd.Parameters.AddWithValue("@domicilio", txtDomic.Text)
                            cmd.Parameters.AddWithValue("@telefono", txtTelef.Text)
                            cmd.ExecuteNonQuery()
                            MsgBox("Cliente registrado", MsgBoxStyle.OkOnly)
                            cerrar()
                            txtDni.Clear()
                            txtNom.Clear()
                            txtApe.Clear()
                            txtEmail.Clear()
                            txtDomic.Clear()
                            txtTelef.Clear()
                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try

                    End If
                End If
            End If
        End Using
    End Sub

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        abrir()
        da = New SqlDataAdapter("MOSTRAR_CLIENTES", connection)
        da.Fill(dt)
        dgvClientes.DataSource = dt
        cerrar()

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        abrir()
        Dim entrada As String = "SELECT * FROM Clientes WHERE dni LIKE '%" & txtBuscar.Text & "%'"
        Dim datos As New DataSet
        Dim adaptador As New SqlDataAdapter(entrada, connection)
        adaptador.Fill(datos)
        cerrar()
        Try
            dgvClientes.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try

    End Sub
End Class