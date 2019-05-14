<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleado))
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtApa = New System.Windows.Forms.TextBox()
        Me.txtAMa = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.Login = New System.Windows.Forms.Label()
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDCat = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtNac = New System.Windows.Forms.DateTimePicker()
        Me.txtIngreso = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregarLog = New System.Windows.Forms.Button()
        Me.btnAgregarCat = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSal = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCategoria
        '
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(384, 76)
        Me.cmbCategoria.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(197, 23)
        Me.cmbCategoria.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(933, 261)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(291, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "FOTO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(69, 389)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(149, 42)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(119, 17)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(132, 21)
        Me.txtId.TabIndex = 4
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(119, 48)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(132, 21)
        Me.txtNom.TabIndex = 5
        '
        'txtApa
        '
        Me.txtApa.Location = New System.Drawing.Point(119, 78)
        Me.txtApa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtApa.Name = "txtApa"
        Me.txtApa.Size = New System.Drawing.Size(132, 21)
        Me.txtApa.TabIndex = 6
        '
        'txtAMa
        '
        Me.txtAMa.Location = New System.Drawing.Point(119, 108)
        Me.txtAMa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAMa.Name = "txtAMa"
        Me.txtAMa.Size = New System.Drawing.Size(132, 21)
        Me.txtAMa.TabIndex = 7
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(119, 138)
        Me.txtDir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(132, 21)
        Me.txtDir.TabIndex = 8
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(119, 168)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(132, 21)
        Me.txtTel.TabIndex = 9
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(119, 198)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(132, 21)
        Me.txtMail.TabIndex = 10
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(119, 258)
        Me.txtRfc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(132, 21)
        Me.txtRfc.TabIndex = 12
        '
        'Login
        '
        Me.Login.AutoSize = True
        Me.Login.BackColor = System.Drawing.Color.Transparent
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(24, 332)
        Me.Login.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(42, 13)
        Me.Login.TabIndex = 14
        Me.Login.Text = "Login:"
        '
        'txtlogin
        '
        Me.txtlogin.Location = New System.Drawing.Point(119, 324)
        Me.txtlogin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(132, 21)
        Me.txtlogin.TabIndex = 15
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(119, 355)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(132, 21)
        Me.txtPass.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 359)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Password:"
        '
        'txtIDCat
        '
        Me.txtIDCat.Location = New System.Drawing.Point(381, 105)
        Me.txtIDCat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtIDCat.Name = "txtIDCat"
        Me.txtIDCat.Size = New System.Drawing.Size(161, 21)
        Me.txtIDCat.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(279, 17)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 27)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Id Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "A Paterno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 113)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "A Materno:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Direccion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 172)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Telefono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 202)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 237)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "F Nacimiento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 262)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "RFC:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 297)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "F INGRESO:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(252, 108)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "ID CATEGORIA:"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(383, 200)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 27)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "gafete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtNac
        '
        Me.txtNac.Location = New System.Drawing.Point(119, 230)
        Me.txtNac.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNac.Name = "txtNac"
        Me.txtNac.Size = New System.Drawing.Size(265, 21)
        Me.txtNac.TabIndex = 33
        '
        'txtIngreso
        '
        Me.txtIngreso.Location = New System.Drawing.Point(119, 290)
        Me.txtIngreso.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtIngreso.Name = "txtIngreso"
        Me.txtIngreso.Size = New System.Drawing.Size(265, 21)
        Me.txtIngreso.TabIndex = 34
        '
        'btnAgregarLog
        '
        Me.btnAgregarLog.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLog.Location = New System.Drawing.Point(227, 389)
        Me.btnAgregarLog.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgregarLog.Name = "btnAgregarLog"
        Me.btnAgregarLog.Size = New System.Drawing.Size(136, 42)
        Me.btnAgregarLog.TabIndex = 35
        Me.btnAgregarLog.Text = "Agregar Acceso"
        Me.btnAgregarLog.UseVisualStyleBackColor = False
        '
        'btnAgregarCat
        '
        Me.btnAgregarCat.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCat.Location = New System.Drawing.Point(384, 165)
        Me.btnAgregarCat.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgregarCat.Name = "btnAgregarCat"
        Me.btnAgregarCat.Size = New System.Drawing.Size(161, 27)
        Me.btnAgregarCat.TabIndex = 36
        Me.btnAgregarCat.Text = "Agregar Categoria"
        Me.btnAgregarCat.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(252, 80)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Categoria:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(252, 142)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Salario:"
        '
        'txtSal
        '
        Me.txtSal.Location = New System.Drawing.Point(384, 135)
        Me.txtSal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Size = New System.Drawing.Size(160, 21)
        Me.txtSal.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(933, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 239)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(633, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(239, 261)
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1240, 519)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtSal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnAgregarCat)
        Me.Controls.Add(Me.btnAgregarLog)
        Me.Controls.Add(Me.txtIngreso)
        Me.Controls.Add(Me.txtNac)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtIDCat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtlogin)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtAMa)
        Me.Controls.Add(Me.txtApa)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Empleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados:"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents verfoto As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtApa As TextBox
    Friend WithEvents txtAMa As TextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents Login As Label
    Friend WithEvents txtlogin As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDCat As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents txtNac As DateTimePicker
    Friend WithEvents txtIngreso As DateTimePicker
    Friend WithEvents btnAgregarLog As Button
    Friend WithEvents btnAgregarCat As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSal As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
