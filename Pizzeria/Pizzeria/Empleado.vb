Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Empleado
    Dim foto As String
    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "Select Id_categoria,Nombre_Cat from Categoria Order by Nombre_Cat"
        Comm.CommandType = CommandType.Text
        Dim SqlAd As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblCategoria As New DataTable()
        SqlAd.Fill(tblCategoria)
        cmbCategoria.ValueMember = "Id_Categoria"
        cmbCategoria.DisplayMember = "Nombre_Cat"
        cmbCategoria.DataSource = tblCategoria
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.ToString().Trim() <> "" Then foto = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(foto)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim comm As New SqlCommand()
        comm.Connection = connsql
        comm.CommandText = "insert into Empleados(Id_Usuario,Nombre,A_Paterno,A_Materno,Direccion,Tel,E_mail,F_Nac,Rfc,F_Ingreso,Id_Categoria,Foto)" & "values(@Id_Usuario,@Nombre,@A_Paterno,@A_Materno,@Direccion,@Tel,@E_mail,@F_Nac,@Rfc,@F_Ingreso,@Id_Categoria,@Foto)"
        comm.CommandType = CommandType.Text
        comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = txtId.Text.ToString()
        comm.Parameters.Add("@Nombre", SqlDbType.NChar, 20).Value = txtNom.Text.ToString()
        comm.Parameters.Add("@A_Paterno", SqlDbType.NChar, 10).Value = txtApa.Text.ToString()
        comm.Parameters.Add("@A_Materno", SqlDbType.NChar, 10).Value = txtAMa.Text.ToString()
        comm.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = txtDir.Text.ToString()
        comm.Parameters.Add("@Tel", SqlDbType.Int).Value = txtTel.Text.ToString()
        comm.Parameters.Add("@E_mail", SqlDbType.VarChar, 50).Value = txtMail.Text.ToString()
        comm.Parameters.Add("@F_Nac", SqlDbType.Date).Value = txtNac.Text.ToString()
        comm.Parameters.Add("@Rfc", SqlDbType.NChar, 10).Value = txtRfc.Text.ToString()
        comm.Parameters.Add("@F_Ingreso", SqlDbType.Date).Value = txtIngreso.Text.ToString()
        comm.Parameters.Add("@Id_Categoria", SqlDbType.NChar, 10).Value = txtIDCat.Text.ToString()
        comm.Parameters.Add("@Foto", SqlDbType.NVarChar, 150).Value = PictureBox1.Text.ToString()
        comm.ExecuteNonQuery()
        comm.Parameters.Clear()

        btnAgregar.Enabled = False
        btnAgregarLog.Enabled = True
        txtNom.Text = ""
        txtApa.Text = ""
        txtAMa.Text = ""
        txtDir.Text = ""
        txtTel.Text = ""
        txtMail.Text = ""
        txtRfc.Text = ""
        txtIDCat.Text = ""
        PictureBox1.Image = Nothing
        txtId.ReadOnly = True
        txtIDCat.ReadOnly = False

    End Sub
    Private Sub printDocument_PrintPage(e)
        e.graphics.DrawRectangle(Pens.Black, New Rectangle(10, 10, 400, 600))
        e.graphics.DrawImage(PictureBox1.Image, 90, 30)
        Dim fuente As Font = New Font("arial", 14, FontStyle.Bold)
        e.graphics.drawstring("Nombre:  " & txtNom.Text.Trim() & " " & txtApa.Text.Trim(), fuente, Brushes.Black, New Point(25, 230))
        e.graphics.drawstring("Categoria: " & cmbCategoria.Text.Trim(), fuente, Brushes.Black, New Point(25, 230))
        e.graphics.drawstring("Empleado: ", fuente, Brushes.Black, New Point(25, 350))
        fuente = New Font("ABC c39 medium text", 16, FontStyle.Regular)
        e.graphics.drawstrin("*" & txtId.Text.Trim() & "*", fuente, Brushes.Black, New Point(150, 400))
        e.hasmorepages = False
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "Select Empleados. * , Acceso. * , Categoria. * from Empleados inner join Acceso " _
        & "on Empleados.Id_Usuario=Acceso.Id_Usuario inner join " _
        & "Categoria on Empleados.Id_Categoria = Categoria.Id_Categoria where Empleados.Id_Usuario=@Id_Usuario"
        Comm.CommandType = CommandType.Text
        Comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = txtId.Text.ToString()
        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If (DReader.HasRows) Then
            While DReader.Read()
                txtId.Text = DReader("Id_Usuario")
                cmbCategoria.SelectedValue = DReader("Id_Categoria")
                txtNom.Text = DReader("Nombre")
                txtApa.Text = DReader("A_Paterno")
                txtAMa.Text = DReader("A_Materno")
                txtDir.Text = DReader("Direccion")
                txtTel.Text = DReader("Tel")
                txtMail.Text = DReader("E_mail")
                txtNac.Value = DReader("F_Nac")
                txtRfc.Text = DReader("Rfc")
                txtIngreso.Value = DReader("F_Ingreso")
                txtIDCat.Text = DReader("Id_Categoria")
                txtSal.Text = DReader("Salario")
                txtlogin.Text = DReader("Login")
                txtPass.Text = DReader("Password")
                'If Not DReader.IsDBNull(DReader.GetOrdinal("Foto")) Then
                'PictureBox1.Image = Image.FromFile(DReader("Foto"))
                'Else
                'PictureBox1.Image = Nothing
                'End If
            End While
        Else
            MessageBox.Show("No se encontro registro", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        DReader.Close()

        'btnEliminarAcc.Enabled = True
        btnAgregarCat.Enabled = False
        'btnClear.Enabled = True
        'btnActualizarEmp.Enabled = True
        'btnActualizarCat.Enabled = True
        'btnActualizarLog.Enabled = True
        txtId.ReadOnly = True
        txtIDCat.ReadOnly = True
    End Sub

    Private Sub btnAgregarLog_Click(sender As Object, e As EventArgs) Handles btnAgregarLog.Click
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "Insert Into Acceso (Id_Usuario,Login,Password)" _
            & "values(@Id_Usuario,@Login,@Password)"
        Comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = txtId.Text.ToString()
        Comm.Parameters.Add("@Login", SqlDbType.NChar, 25).Value = txtlogin.Text.ToString()
        Comm.Parameters.Add("@Password", SqlDbType.NChar, 35).Value = txtPass.Text.ToString()

        Comm.ExecuteNonQuery()
        Comm.Parameters.Clear()

        btnAgregarCat.Enabled = True
        btnAgregarLog.Enabled = False
        txtlogin.Text = ""
        txtPass.Text = ""
        txtId.Text = ""
        txtId.ReadOnly = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAgregarCat.Click
        Dim Comm As New SqlCommand()
        Comm.Connection = connsql
        Comm.CommandText = "Insert Into Categoria (Id_Categoria,Nombre_Cat,Salario)" _
            & "values(@Id_Categoria,@Nombre_Cat,@Salario)"
        Comm.Parameters.Add("@Id_Categoria", SqlDbType.NChar, 10).Value = txtIDCat.Text.ToString()
        Comm.Parameters.Add("@Nombre_Cat", SqlDbType.NChar, 35).Value = cmbCategoria.Text.ToString()
        Comm.Parameters.Add("@Salario", SqlDbType.Money).Value = txtSal.Text.ToString()

        Comm.ExecuteNonQuery()
        Comm.Parameters.Clear()

        btnAgregar.Enabled = True
        txtIDCat.ReadOnly = True
        txtSal.Text = ""
        btnAgregarCat.Enabled = False
    End Sub

    Private Sub txtIDCat_TextChanged(sender As Object, e As EventArgs) Handles txtIDCat.TextChanged

    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged

    End Sub
End Class