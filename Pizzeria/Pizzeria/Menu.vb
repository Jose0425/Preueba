Public Class VENTA
    Private Sub EmpleadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadaToolStripMenuItem.Click
        Empleado.Show()
    End Sub

    Private Sub VENTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ConfigPizzeria.Iniciarconexion()

    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click
        frmArticulos.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmProductosVenta.Show()
    End Sub

    Private Sub ListaDeMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeMaterialesToolStripMenuItem.Click
        ListaDeMateriales.Show()
    End Sub


    Private Sub PromocionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromocionesToolStripMenuItem.Click
        frmPromCombo.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        frmVentas.Show()

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub COMPRAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMPRAToolStripMenuItem.Click
        COMPRA.Show()
    End Sub
End Class
