Imports System.Data.SqlClient
Imports System.Data
Public Class loginform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Acceso.Show()
        Me.Hide()
    End Sub

    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigPizzeria.Iniciarconexion()
    End Sub

    Private Sub txtIdUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Select()
        End If

    End Sub

    Private Sub txtIdUsuario_Validated(sender As Object, e As EventArgs) Handles txtIdUsuario.Validated
        If txtIdUsuario.Text.Trim() = "" Then
            Exit Sub
        End If
        Dim acc As String = ""
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "AccesoUsuario"
        Comm.CommandType = CommandType.StoredProcedure
        Comm.Parameters.Add("@Id", SqlDbType.NChar, 10).Value = txtIdUsuario.Text.ToString()

        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If DReader.HasRows Then
            While DReader.Read()
                acc = DReader("Nombre_Cat")
            End While
        Else
            MessageBox.Show("Usuario no encontrado", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        DReader.Close()

        Select Case acc.Trim()
            Case "Administrador"
                VENTA.Show()
            Case "Producto"
                frmVentas.Show()
            Case ""
                Exit Sub
        End Select
        Me.Hide()


    End Sub

    Private Sub txtIdUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtIdUsuario.TextChanged

    End Sub
End Class