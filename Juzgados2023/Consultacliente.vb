Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Consultacliente
    Private WithEvents PrintDocument1 As New PrintDocument
    Public Class Cliente
        Public Property Cod_cliente As String
        Public Property nom_apellido As String
        ' Add more properties as needed
    End Class

    Private Sub refreshDatagrid()
        Conectar.conectar()
        Dim sql As SqlCommand = New SqlCommand("SELECT * FROM cliente_exp", conexion)
        Dim ds As DataSet = New DataSet()
        Dim DataAdapter1 As SqlDataAdapter = New SqlDataAdapter()

        DataAdapter1.SelectCommand = sql
        DataAdapter1.Fill(ds, "cliente_exp")
        dgv.DataSource = ds
        dgv.DataMember = "cliente_exp"
    End Sub
    Private Sub Consultacliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cliente_expTableAdapter1.Fill(Me.Juzgados2023DataSet.cliente_exp)

        Llenarcliente()

        Conectar.conectar()


        Dim query As String = "SELECT * FROM cliente_exp"


        Using adapter As New SqlDataAdapter(query, conexion)

            Dim dataTable As New DataTable()


            adapter.Fill(dataTable)


            dgv.DataSource = dataTable
        End Using
    End Sub
    Private Sub Llenarcliente()
        Try

            Conectar.conectar()


            Dim query As String = "SELECT cod_exp2 FROM cliente_exp "

            Dim adapter As New SqlDataAdapter(query, conexion)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ComboBox1.DataSource = dataTable
            ComboBox1.DisplayMember = "cod_exp2"
            ComboBox1.ValueMember = "cod_exp2"
        Catch ex As Exception
            MessageBox.Show("Error al cargar expedientes: " & ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim sql As SqlCommand = New SqlCommand("
            SELECT *
            FROM cliente_exp 
            INNER JOIN expedientes ON cliente_exp.cod_exp2 = expedientes.cod_exp
            WHERE cliente_exp.cod_exp2 = '" & Me.ComboBox1.SelectedValue & "'", conexion)

            Dim ds As DataSet = New DataSet()
            Dim DataAdapter1 As SqlDataAdapter = New SqlDataAdapter()

            DataAdapter1.SelectCommand = sql
            DataAdapter1.Fill(ds, "cliente_exp")

            dgv.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Muestra el cuadro de diálogo de impresión
        Dim printDialog As New PrintDialog()

        printDialog.Document = PrintDocument1
        If printDialog.ShowDialog() = DialogResult.OK Then
            ' Inicia el proceso de impresión
            PrintDocument1.Print()
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Configura las fuentes y los márgenes
        Dim font As New Font("Arial", 10)
        Dim margin As Integer = 40
        Dim y As Integer = margin

        ' Recorre las filas del DataGridView y dibuja el contenido
        For Each row As DataGridViewRow In dgv.Rows
            ' Si la fila no está visible, continúa con la siguiente
            If Not row.Visible Then
                Continue For
            End If

            ' Recorre las celdas de la fila y dibuja el contenido
            Dim x As Integer = margin
            For Each cell As DataGridViewCell In row.Cells
                ' Si la celda no está visible, continúa con la siguiente
                If Not cell.Visible Then
                    Continue For
                End If

                ' Dibuja el contenido de la celda
                e.Graphics.DrawString(cell.FormattedValue.ToString(), font, Brushes.Black, x, y)

                ' Incrementa la posición en X para la siguiente celda
                x += cell.Size.Width + 5 ' Añade un espacio entre celdas
            Next

            ' Incrementa la posición en Y para la siguiente fila
            y += row.Height
        Next
    End Sub

    Private Sub refrescar_Click(sender As Object, e As EventArgs) Handles refrescar.Click
        refreshDatagrid()
    End Sub
End Class