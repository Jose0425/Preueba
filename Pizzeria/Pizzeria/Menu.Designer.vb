<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTA
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VENTA))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuCatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeMaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromocionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPRAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCatalogoToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuCatalogoToolStripMenuItem
        '
        Me.MenuCatalogoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.MenuCatalogoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuCatalogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadaToolStripMenuItem, Me.ArticulosToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ListaDeMaterialesToolStripMenuItem, Me.VentasToolStripMenuItem, Me.PromocionesToolStripMenuItem, Me.COMPRAToolStripMenuItem})
        Me.MenuCatalogoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuCatalogoToolStripMenuItem.ForeColor = System.Drawing.Color.LawnGreen
        Me.MenuCatalogoToolStripMenuItem.Name = "MenuCatalogoToolStripMenuItem"
        Me.MenuCatalogoToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.MenuCatalogoToolStripMenuItem.Text = "Menu Catalogo"
        '
        'EmpleadaToolStripMenuItem
        '
        Me.EmpleadaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpleadaToolStripMenuItem.Name = "EmpleadaToolStripMenuItem"
        Me.EmpleadaToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.EmpleadaToolStripMenuItem.Text = "Empleados"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.ProductosToolStripMenuItem.Text = "Catalogo De Productos"
        '
        'ListaDeMaterialesToolStripMenuItem
        '
        Me.ListaDeMaterialesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaDeMaterialesToolStripMenuItem.Name = "ListaDeMaterialesToolStripMenuItem"
        Me.ListaDeMaterialesToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.ListaDeMaterialesToolStripMenuItem.Text = "Lista De Materiales"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.VentasToolStripMenuItem.Text = "Venta"
        '
        'PromocionesToolStripMenuItem
        '
        Me.PromocionesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromocionesToolStripMenuItem.Name = "PromocionesToolStripMenuItem"
        Me.PromocionesToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.PromocionesToolStripMenuItem.Text = "Promociones"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarToolStripMenuItem.ForeColor = System.Drawing.Color.LawnGreen
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'COMPRAToolStripMenuItem
        '
        Me.COMPRAToolStripMenuItem.Name = "COMPRAToolStripMenuItem"
        Me.COMPRAToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.COMPRAToolStripMenuItem.Text = "COMPRA"
        '
        'VENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Pizzeria.My.Resources.Resources._2394
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VENTA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PIZZERIA"
        Me.TransparencyKey = System.Drawing.SystemColors.MenuHighlight
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuCatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeMaterialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromocionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMPRAToolStripMenuItem As ToolStripMenuItem
End Class
