<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromCombo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPromCombo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmProducto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecioNormal = New System.Windows.Forms.TextBox()
        Me.btnPasar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPrecioFinal = New System.Windows.Forms.TextBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvCombos = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstProductos = New System.Windows.Forms.ListBox()
        CType(Me.dgvCombos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(157, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Promociones y Combos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Producto"
        '
        'cmProducto
        '
        Me.cmProducto.FormattingEnabled = True
        Me.cmProducto.Location = New System.Drawing.Point(13, 62)
        Me.cmProducto.Name = "cmProducto"
        Me.cmProducto.Size = New System.Drawing.Size(393, 21)
        Me.cmProducto.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Precio Regular:"
        '
        'txtPrecioNormal
        '
        Me.txtPrecioNormal.Location = New System.Drawing.Point(13, 107)
        Me.txtPrecioNormal.Name = "txtPrecioNormal"
        Me.txtPrecioNormal.Size = New System.Drawing.Size(80, 20)
        Me.txtPrecioNormal.TabIndex = 4
        '
        'btnPasar
        '
        Me.btnPasar.Location = New System.Drawing.Point(331, 104)
        Me.btnPasar.Name = "btnPasar"
        Me.btnPasar.Size = New System.Drawing.Size(75, 23)
        Me.btnPasar.TabIndex = 5
        Me.btnPasar.Text = "---->"
        Me.btnPasar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre Oferta/Combo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tipo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Precio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Inicio:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(181, 134)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(225, 20)
        Me.txtNombre.TabIndex = 10
        '
        'txtPrecioFinal
        '
        Me.txtPrecioFinal.Location = New System.Drawing.Point(137, 185)
        Me.txtPrecioFinal.Name = "txtPrecioFinal"
        Me.txtPrecioFinal.Size = New System.Drawing.Size(75, 20)
        Me.txtPrecioFinal.TabIndex = 11
        '
        'CmbTipo
        '
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(137, 159)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CmbTipo.TabIndex = 12
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(58, 213)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInicio.TabIndex = 13
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(285, 212)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFin.TabIndex = 14
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(19, 244)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(136, 243)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 16
        Me.btnBorrar.Text = "Borrar Selecion"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(264, 242)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgvCombos
        '
        Me.dgvCombos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCombos.Location = New System.Drawing.Point(13, 274)
        Me.dgvCombos.Name = "dgvCombos"
        Me.dgvCombos.Size = New System.Drawing.Size(451, 150)
        Me.dgvCombos.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(261, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Fin:"
        '
        'lstProductos
        '
        Me.lstProductos.FormattingEnabled = True
        Me.lstProductos.Location = New System.Drawing.Point(412, 62)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(180, 147)
        Me.lstProductos.TabIndex = 20
        '
        'frmPromCombo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(606, 450)
        Me.Controls.Add(Me.lstProductos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvCombos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.txtPrecioFinal)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnPasar)
        Me.Controls.Add(Me.txtPrecioNormal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPromCombo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROMOCIONES Y COMBOS DE PIZZAS"
        CType(Me.dgvCombos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmProducto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecioNormal As TextBox
    Friend WithEvents btnPasar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecioFinal As TextBox
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgvCombos As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents lstProductos As ListBox
End Class
