<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtVentaID = New System.Windows.Forms.TextBox()
        Me.btnVentaNueva = New System.Windows.Forms.Button()
        Me.gpbBuscaProducto = New System.Windows.Forms.GroupBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.gpbDetalles = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskTxtTotal = New System.Windows.Forms.MaskedTextBox()
        Me.dgvVentaDetalles = New System.Windows.Forms.DataGridView()
        Me.txtTipoProd = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNumProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btntel = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btnParaLlevar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.gpbBuscaProducto.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDetalles.SuspendLayout()
        CType(Me.dgvVentaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txtVentaID)
        Me.Panel1.Controls.Add(Me.btnVentaNueva)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 46)
        Me.Panel1.TabIndex = 0
        '
        'txtVentaID
        '
        Me.txtVentaID.Location = New System.Drawing.Point(135, 12)
        Me.txtVentaID.Name = "txtVentaID"
        Me.txtVentaID.Size = New System.Drawing.Size(100, 20)
        Me.txtVentaID.TabIndex = 1
        '
        'btnVentaNueva
        '
        Me.btnVentaNueva.Location = New System.Drawing.Point(12, 12)
        Me.btnVentaNueva.Name = "btnVentaNueva"
        Me.btnVentaNueva.Size = New System.Drawing.Size(93, 23)
        Me.btnVentaNueva.TabIndex = 0
        Me.btnVentaNueva.Text = "Nueva Venta"
        Me.btnVentaNueva.UseVisualStyleBackColor = True
        '
        'gpbBuscaProducto
        '
        Me.gpbBuscaProducto.AutoSize = True
        Me.gpbBuscaProducto.Controls.Add(Me.dgvProductos)
        Me.gpbBuscaProducto.Controls.Add(Me.txtProducto)
        Me.gpbBuscaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpbBuscaProducto.Location = New System.Drawing.Point(1, 54)
        Me.gpbBuscaProducto.Name = "gpbBuscaProducto"
        Me.gpbBuscaProducto.Size = New System.Drawing.Size(533, 215)
        Me.gpbBuscaProducto.TabIndex = 1
        Me.gpbBuscaProducto.TabStop = False
        Me.gpbBuscaProducto.Text = "PRODUCTO"
        '
        'dgvProductos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvProductos.Location = New System.Drawing.Point(7, 46)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(515, 150)
        Me.dgvProductos.TabIndex = 1
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(7, 20)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(416, 20)
        Me.txtProducto.TabIndex = 0
        '
        'gpbDetalles
        '
        Me.gpbDetalles.AutoSize = True
        Me.gpbDetalles.Controls.Add(Me.Label6)
        Me.gpbDetalles.Controls.Add(Me.Label4)
        Me.gpbDetalles.Controls.Add(Me.mskTxtTotal)
        Me.gpbDetalles.Controls.Add(Me.dgvVentaDetalles)
        Me.gpbDetalles.Controls.Add(Me.txtTipoProd)
        Me.gpbDetalles.Controls.Add(Me.txtCantidad)
        Me.gpbDetalles.Controls.Add(Me.txtPrecio)
        Me.gpbDetalles.Controls.Add(Me.txtNumProducto)
        Me.gpbDetalles.Controls.Add(Me.Label3)
        Me.gpbDetalles.Controls.Add(Me.Label2)
        Me.gpbDetalles.Controls.Add(Me.Label1)
        Me.gpbDetalles.Controls.Add(Me.txtNombreProducto)
        Me.gpbDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpbDetalles.Location = New System.Drawing.Point(1, 257)
        Me.gpbDetalles.Name = "gpbDetalles"
        Me.gpbDetalles.Size = New System.Drawing.Size(533, 294)
        Me.gpbDetalles.TabIndex = 2
        Me.gpbDetalles.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(366, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total: $"
        '
        'mskTxtTotal
        '
        Me.mskTxtTotal.Location = New System.Drawing.Point(366, 255)
        Me.mskTxtTotal.Name = "mskTxtTotal"
        Me.mskTxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.mskTxtTotal.TabIndex = 9
        '
        'dgvVentaDetalles
        '
        Me.dgvVentaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentaDetalles.Location = New System.Drawing.Point(7, 90)
        Me.dgvVentaDetalles.Name = "dgvVentaDetalles"
        Me.dgvVentaDetalles.Size = New System.Drawing.Size(515, 150)
        Me.dgvVentaDetalles.TabIndex = 8
        '
        'txtTipoProd
        '
        Me.txtTipoProd.Location = New System.Drawing.Point(366, 63)
        Me.txtTipoProd.Name = "txtTipoProd"
        Me.txtTipoProd.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoProd.TabIndex = 7
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(260, 63)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(138, 63)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'txtNumProducto
        '
        Me.txtNumProducto.Location = New System.Drawing.Point(6, 63)
        Me.txtNumProducto.Name = "txtNumProducto"
        Me.txtNumProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtNumProducto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CANTIDAD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PRECIO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NUM PRODUCTO:"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(7, 20)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(416, 20)
        Me.txtNombreProducto.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(557, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 40)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "  Seleccione " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tipo De Venta"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(609, 499)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(112, 33)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btntel
        '
        Me.btntel.BackColor = System.Drawing.Color.Transparent
        Me.btntel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntel.Image = Global.Pizzeria.My.Resources.Resources.phone_handset_icon_icons_com_48252
        Me.btntel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntel.Location = New System.Drawing.Point(540, 222)
        Me.btntel.Name = "btntel"
        Me.btntel.Size = New System.Drawing.Size(181, 57)
        Me.btntel.TabIndex = 8
        Me.btntel.Text = "Teléfono/Recoger en local"
        Me.btntel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntel.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Pizzeria.My.Resources.Resources._3615755_box_delivery_express_parcel_postman_scooter_service_107909
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(540, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(181, 57)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Entrega a Domicilio"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnLocal
        '
        Me.btnLocal.AutoSize = True
        Me.btnLocal.BackColor = System.Drawing.Color.Transparent
        Me.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocal.Image = Global.Pizzeria.My.Resources.Resources.shop_13338_1_
        Me.btnLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLocal.Location = New System.Drawing.Point(540, 133)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(181, 64)
        Me.btnLocal.TabIndex = 5
        Me.btnLocal.Text = "Consumo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "En Local"
        Me.btnLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLocal.UseVisualStyleBackColor = False
        '
        'btnParaLlevar
        '
        Me.btnParaLlevar.AutoSize = True
        Me.btnParaLlevar.BackColor = System.Drawing.Color.Transparent
        Me.btnParaLlevar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParaLlevar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParaLlevar.Image = Global.Pizzeria.My.Resources.Resources._1455739788_Kitchen_Bold_Line_Color_Mix_05_icon_icons_com_53393
        Me.btnParaLlevar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParaLlevar.Location = New System.Drawing.Point(540, 74)
        Me.btnParaLlevar.Name = "btnParaLlevar"
        Me.btnParaLlevar.Size = New System.Drawing.Size(181, 40)
        Me.btnParaLlevar.TabIndex = 4
        Me.btnParaLlevar.Text = "Para Llevar"
        Me.btnParaLlevar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnParaLlevar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnParaLlevar.UseVisualStyleBackColor = False
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pizzeria.My.Resources.Resources._88247
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(720, 544)
        Me.Controls.Add(Me.btntel)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnLocal)
        Me.Controls.Add(Me.btnParaLlevar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gpbDetalles)
        Me.Controls.Add(Me.gpbBuscaProducto)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTAS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gpbBuscaProducto.ResumeLayout(False)
        Me.gpbBuscaProducto.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDetalles.ResumeLayout(False)
        Me.gpbDetalles.PerformLayout()
        CType(Me.dgvVentaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtVentaID As TextBox
    Friend WithEvents btnVentaNueva As Button
    Friend WithEvents gpbBuscaProducto As GroupBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents gpbDetalles As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mskTxtTotal As MaskedTextBox
    Friend WithEvents dgvVentaDetalles As DataGridView
    Friend WithEvents txtTipoProd As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNumProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnParaLlevar As Button
    Friend WithEvents btnLocal As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btntel As Button
    Friend WithEvents Label6 As Label
End Class
