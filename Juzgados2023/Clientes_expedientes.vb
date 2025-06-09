Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Public Class Clientes_expedientes
    Private Sub Clientes_expedientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'Juzgados2023DataSet.cliente_exp' Puede moverla o quitarla según sea necesario.
        Me.Cliente_expTableAdapter.Fill(Me.Juzgados2023DataSet.cliente_exp)
        Me.cliente.Text = ""
        Me.expediente.Text = ""
    End Sub

    Private Sub LlenarClientesSinExpedientes()
        Try
            ' Abrir la conexión
            Conectar.conectar()

            ' Consulta para obtener clientes que no tienen expedientes asociados
            Dim query As String = "SELECT cod_cliente, nom_apellido FROM Clientes order by cod_cliente "
            Dim adapter As New SqlDataAdapter(query, conexion)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Asignar el origen de datos al ComboBox de clientes
            cliente.DataSource = dataTable
            cliente.DisplayMember = "nom_apellido"
            cliente.ValueMember = "cod_cliente"
        Catch ex As Exception
            MessageBox.Show("Error al cargar: " & ex.Message)

        End Try
    End Sub
    ' Llenar los ComboBox al cargar el formulario
    Private Sub cli_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Llenar solo clientes sin expedientes asociados
        LlenarClientesSinExpedientes()

        ' Llenar ComboBox de expedientes
        LlenarExpedientes()
    End Sub
    Private Sub LlenarExpedientes()
        Try
            ' Abrir la conexión
            Conectar.conectar()

            ' Consulta para obtener expedientes desde la base de datos

            Dim query As String = "SELECT nom_exp, cod_exp2 FROM cliente_exp " &
                              "WHERE cod_cliente2 IS NULL"
            Dim adapter As New SqlDataAdapter(query, conexion)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            ' Asignar el origen de datos al ComboBox de expedientes
            expediente.DataSource = dataTable
            expediente.DisplayMember = "cod_exp2"
            expediente.ValueMember = "cod_exp2"
        Catch ex As Exception
            MessageBox.Show("Error al cargar expedientes: " & ex.Message)
        Finally
            ' Cerrar la conexión

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Conectar.conectar()
            cmd.CommandType = CommandType.Text

            ' obtiene tanto el nombre como el codigo de cliente elegido
            Dim codCliente As Integer = Convert.ToInt32(Me.cliente.SelectedValue)
            Dim nomApellido As String = Me.cliente.Text

            ' actualiza ambas columnas
            Dim sql As String = "UPDATE cliente_exp SET cod_cliente2 = @CodCliente, nom_apellido = @NomApellido WHERE cod_exp2 = @CodExp"
            cmd.CommandText = sql

            ' añade parametros para el codigo y nombre de cliente, y para el codigo de expediente(el nombre no hace falta porque no se utiliza para la funcionalidad)
            cmd.Parameters.AddWithValue("@CodCliente", codCliente)
            cmd.Parameters.AddWithValue("@NomApellido", nomApellido)
            cmd.Parameters.AddWithValue("@CodExp", Me.expediente.Text)

            ' ejecuta el comando en sql
            cmd.ExecuteNonQuery()
            MsgBox("Update successful!", MsgBoxStyle.Information, "Success")
            ' recarga el datagrid
            Me.refreshDatagrid()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub refreshDatagrid()
        Conectar.conectar()
        Dim sql As SqlCommand = New SqlCommand("SELECT cod_cliente2, nom_apellido, nom_exp, cod_exp2 FROM cliente_exp", conexion)
        Dim ds As DataSet = New DataSet()
        Dim DataAdapter1 As SqlDataAdapter = New SqlDataAdapter()

        DataAdapter1.SelectCommand = sql
        DataAdapter1.Fill(ds, "cliente_exp")
        dgvcliexp.DataSource = ds
        dgvcliexp.DataMember = "cliente_exp"
    End Sub

End Class