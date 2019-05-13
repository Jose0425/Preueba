<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COMPRA
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvCompra = New System.Windows.Forms.DataGridView()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.dvgListaMostrar = New System.Windows.Forms.DataGridView()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.mskTxtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskNormal = New System.Windows.Forms.TextBox()
        Me.mskIva = New System.Windows.Forms.TextBox()
        Me.txtCompraID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.Fecha_Hora = New System.Windows.Forms.Timer(Me.components)
        Me.txtHora = New System.Windows.Forms.Label()
        CType(Me.dgvCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgListaMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCompra
        '
        Me.dgvCompra.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.dgvCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompra.Location = New System.Drawing.Point(35, 248)
        Me.dgvCompra.Name = "dgvCompra"
        Me.dgvCompra.Size = New System.Drawing.Size(510, 190)
        Me.dgvCompra.TabIndex = 0
        '
        'btnVenta
        '
        Me.btnVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.Location = New System.Drawing.Point(570, 168)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(218, 52)
        Me.btnVenta.TabIndex = 1
        Me.btnVenta.Text = "Compra"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'dvgListaMostrar
        '
        Me.dvgListaMostrar.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.dvgListaMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgListaMostrar.Location = New System.Drawing.Point(35, 70)
        Me.dvgListaMostrar.Name = "dvgListaMostrar"
        Me.dvgListaMostrar.Size = New System.Drawing.Size(510, 150)
        Me.dvgListaMostrar.TabIndex = 2
        '
        'txtCompra
        '
        Me.txtCompra.Location = New System.Drawing.Point(35, 34)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(245, 20)
        Me.txtCompra.TabIndex = 3
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(305, 34)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 8
        '
        'mskTxtTotal
        '
        Me.mskTxtTotal.CausesValidation = False
        Me.mskTxtTotal.Enabled = False
        Me.mskTxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTxtTotal.Location = New System.Drawing.Point(570, 377)
        Me.mskTxtTotal.Multiline = True
        Me.mskTxtTotal.Name = "mskTxtTotal"
        Me.mskTxtTotal.Size = New System.Drawing.Size(218, 61)
        Me.mskTxtTotal.TabIndex = 9
        Me.mskTxtTotal.TabStop = False
        Me.mskTxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre Del Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Venta"
        '
        'mskNormal
        '
        Me.mskNormal.Location = New System.Drawing.Point(570, 243)
        Me.mskNormal.Multiline = True
        Me.mskNormal.Name = "mskNormal"
        Me.mskNormal.Size = New System.Drawing.Size(218, 61)
        Me.mskNormal.TabIndex = 15
        '
        'mskIva
        '
        Me.mskIva.Location = New System.Drawing.Point(570, 310)
        Me.mskIva.Multiline = True
        Me.mskIva.Name = "mskIva"
        Me.mskIva.Size = New System.Drawing.Size(218, 61)
        Me.mskIva.TabIndex = 16
        '
        'txtCompraID
        '
        Me.txtCompraID.Location = New System.Drawing.Point(423, 33)
        Me.txtCompraID.Name = "txtCompraID"
        Me.txtCompraID.Size = New System.Drawing.Size(122, 20)
        Me.txtCompraID.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(423, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Orden"
        '
        'txtFecha
        '
        Me.txtFecha.AutoSize = True
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(545, 9)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(0, 18)
        Me.txtFecha.TabIndex = 19
        '
        'Fecha_Hora
        '
        Me.Fecha_Hora.Enabled = True
        '
        'txtHora
        '
        Me.txtHora.AutoSize = True
        Me.txtHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora.Location = New System.Drawing.Point(714, 40)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(0, 18)
        Me.txtHora.TabIndex = 20
        '
        'COMPRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pizzeria.My.Resources.Resources._88247
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCompraID)
        Me.Controls.Add(Me.mskIva)
        Me.Controls.Add(Me.mskNormal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mskTxtTotal)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtCompra)
        Me.Controls.Add(Me.dvgListaMostrar)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.dgvCompra)
        Me.Name = "COMPRA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPRA"
        CType(Me.dgvCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgListaMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCompra As DataGridView
    Friend WithEvents btnVenta As Button
    Friend WithEvents dvgListaMostrar As DataGridView
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents mskTxtTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mskNormal As TextBox
    Friend WithEvents mskIva As TextBox
    Friend WithEvents txtCompraID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFecha As Label
    Friend WithEvents Fecha_Hora As Timer
    Friend WithEvents txtHora As Label
End Class
