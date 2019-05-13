Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Printing

Module ConfigPizzeria
    Public connsql As SqlConnection
    Public Sub Iniciarconexion()
        connsql = New SqlConnection("Data Source=DESKTOP-7PS7I8B\SQLEXPRESS;Initial Catalog=PIZZERIA;Integrated Security=True")
        connsql.Open()

    End Sub
End Module
