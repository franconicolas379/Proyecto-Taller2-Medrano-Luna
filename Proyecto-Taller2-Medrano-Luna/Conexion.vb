Imports System.Data.Sql
Imports System.Data.SqlClient

Module Conexion
    Public connection As New SqlConnection("Data Source=DESKTOP-GQ798UG\SQLEXPRESS_INST;Initial Catalog=ProyectoTaller;Integrated Security=True")
    Public comando As New SqlCommand


    Sub abrir()
        If connection.State = 0 Then
            connection.Open()
        End If
    End Sub

    Sub cerrar()
        If connection.State = 1 Then
            connection.Close()
        End If
    End Sub
End Module
