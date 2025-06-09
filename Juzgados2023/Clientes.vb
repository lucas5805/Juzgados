'trae las librerias de sql para usar la base de datos
Imports System.Data.SqlClient
Public Class Clientes
    'esto hace que cada vez que cargue el form se realize determinada accion
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llena las tablas
        Me.LocalidadesTableAdapter.Fill(Me.Juzgados2023DataSet.localidades)
        Me.ClientesTableAdapter1.Fill(Me.Juzgados2023DataSet.clientes)
        'limpia el combobox
        Me.ltxt.Text = ""
    End Sub
    Private Sub refreshDatagrid()
        Conectar.conectar()
        Dim sql As SqlCommand = New SqlCommand("SELECT * FROM clientes", conexion)
        Dim ds As DataSet = New DataSet()
        Dim DataAdapter1 As SqlDataAdapter = New SqlDataAdapter()

        DataAdapter1.SelectCommand = sql
        DataAdapter1.Fill(ds, "clientes")
        dgvcli.DataSource = ds
        dgvcli.DataMember = "clientes"

    End Sub
    Private Sub llenarclientes()
        Dim sql As String = "SELECT cod_cliente as CODIGO_CLIENTE, nom_apellido as NOMBRE_APELLIDO, tel_cel as tel_cel, tipo_nro_doc as tipo_nro_doc, domicilio as DOMICILIO, fecha_nac as FECHA_NAC FROM clientes"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conectar.conexion)

        ds.Tables.Add("clientes")
        adp.Fill(ds.Tables("clientes"))
        Me.dgvcli.DataSource = ds.Tables("clientes")
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        flag_abm = 1 'ALTA
        Me.cctxt.Enabled = True
        Me.natxt.Enabled = True
        Me.tctxt.Enabled = True
        Me.doctxt.Enabled = True
        Me.dtxt.Enabled = True
        Me.fntxt.Enabled = True
        Me.ltxt.Enabled = True
        Me.cctxt.Focus()
    End Sub
    Private Sub nuevocliente()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text

        Dim sql As String = "INSERT INTO clientes VALUES ('" & Me.cctxt.Text & "','" & Me.doctxt.Text & "','" & Me.natxt.Text & "','" & Me.dtxt.Text & "','" & Me.tctxt.Text & "','" & Me.fntxt.Text & "','" & Me.ltxt.Text & "')"
        cmd.CommandText = sql

        'validacion
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarclientes()
            Me.cctxt.Clear()
            Me.doctxt.Clear()
            Me.dtxt.Clear()
            Me.natxt.Clear()
            Me.fntxt.Clear()
            Me.ltxt.Text = ""
            Me.listo.Visible = True
        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        flag_abm = 8 'UPDATE
        Dim wcodigocliente As String
        wcodigocliente = Me.dgvcli.CurrentRow.Cells("cod_cliente").Value.ToString()

        Me.cctxt.Text = wcodigocliente
        Me.natxt.Text = Me.dgvcli.CurrentRow.Cells("nom_apellido").Value.ToString()
        Me.tctxt.Text = Me.dgvcli.CurrentRow.Cells("tel_cel").Value.ToString()
        Me.doctxt.Text = Me.dgvcli.CurrentRow.Cells("tipo_nro_doc").Value.ToString()
        Me.dtxt.Text = Me.dgvcli.CurrentRow.Cells("DOMICILIO").Value.ToString()
        Me.ltxt.Text = Me.dgvcli.CurrentRow.Cells("localidad").Value.ToString()
        Me.fntxt.Text = (Me.dgvcli.CurrentRow.Cells("FECHA_NAC").Value)
        Me.cctxt.Enabled = False ' Assuming the client code is not editable
        Me.natxt.Enabled = True
        Me.tctxt.Enabled = True
        Me.doctxt.Enabled = True
        Me.dtxt.Enabled = True
        Me.fntxt.Enabled = True
        Me.ltxt.Enabled = True
        Me.listo.Visible = True
    End Sub
    Private Sub updatecliente()
        Dim nombreApellido As String = dgvcli.CurrentRow.Cells("nom_apellido").Value.ToString()

        ' Verifica si el cliente está asociado a un expediente
        Dim query As String = "SELECT COUNT(*) FROM cliente_exp WHERE nom_apellido = @nombreApellido"
        Dim count As Integer

        Conectar.conectar()

        Using command As New SqlCommand(query, conexion)
            command.Parameters.AddWithValue("@nombreApellido", nombreApellido)

            count = Convert.ToInt32(command.ExecuteScalar())
        End Using


        ' Si el cliente está asociado a un expediente, se muestra un mensaje y no se modifica
        If count > 0 Then
            MessageBox.Show("No es posible modificar este cliente porque está asociado a un expediente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim wcodigocliente As String
            wcodigocliente = Me.dgvcli.CurrentRow.Cells("COD_CLIENTE").Value.ToString()
            Conectar.conectar()
            cmd.CommandType = CommandType.Text
            Dim sql As String = "UPDATE clientes SET nom_apellido = '" & Me.natxt.Text & "', tel_cel = '" & Me.tctxt.Text & "', tipo_nro_doc = '" & Me.doctxt.Text & "', domicilio = '" & Me.dtxt.Text & "', fecha_nac = '" & Me.fntxt.Text & "', localidad = '" & Me.ltxt.Text & "' WHERE cod_cliente = '" & wcodigocliente & "'"
            cmd.CommandText = sql
            'validacion
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarclientes()
                Me.cctxt.Clear()
                Me.doctxt.Clear()
                Me.dtxt.Clear()
                Me.natxt.Clear()
                Me.fntxt.Clear()
                Me.ltxt.Text = ""
                Me.tctxt.Clear()
                Me.listo.Visible = True
            Catch ex As Exception

                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        flag_abm = 3 'DELETE
        Dim wcodigocliente As String
        wcodigocliente = Me.dgvcli.CurrentRow.Cells("COD_CLIENTe").Value.ToString()
        Me.cctxt.Text = wcodigocliente
        Me.natxt.Text = Me.dgvcli.CurrentRow.Cells("NOM_APELLIDO").Value.ToString()
        Me.tctxt.Text = Me.dgvcli.CurrentRow.Cells("TEL_cel").Value.ToString()
        Me.doctxt.Text = Me.dgvcli.CurrentRow.Cells("tipo_nro_doc").Value.ToString()
        Me.dtxt.Text = Me.dgvcli.CurrentRow.Cells("DOMICILIO").Value.ToString()
        Me.ltxt.Text = Me.dgvcli.CurrentRow.Cells("localidad").Value.ToString()
        Me.fntxt.Text = (Me.dgvcli.CurrentRow.Cells("FECHA_NAC").Value)
        Me.cctxt.Enabled = False ' Assuming the client code is not editable
        Me.natxt.Enabled = False
        Me.tctxt.Enabled = False
        Me.doctxt.Enabled = False
        Me.dtxt.Enabled = False
        Me.fntxt.Enabled = False
        Me.ltxt.Enabled = False
        Me.listo.Visible = True
    End Sub
    Private Sub deleteCliente()
        Dim nombreApellido As String = dgvcli.CurrentRow.Cells("nom_apellido").Value.ToString()

        ' Verifica si el cliente está asociado a un expediente
        Dim query As String = "SELECT COUNT(*) FROM cliente_exp WHERE nom_apellido = @nombreApellido"
        Dim count As Integer

        Conectar.conectar()

        Using command As New SqlCommand(query, conexion)
            command.Parameters.AddWithValue("@nombreApellido", nombreApellido)

            count = Convert.ToInt32(command.ExecuteScalar())
        End Using


        ' Si el cliente está asociado a un expediente, se muestra un mensaje y no lo va a borrar
        If count > 0 Then
            MessageBox.Show("No es posible borrar este cliente porque está asociado a un expediente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Conectar.conectar()
            cmd.CommandType = CommandType.Text
            Dim wcodigocliente As String
            wcodigocliente = Me.dgvcli.CurrentRow.Cells("COD_CLIENTE").Value.ToString()
            Dim sql As String = "DELETE FROM clientes WHERE cod_cliente = '" & wcodigocliente & "'"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarclientes()
                Me.cctxt.Clear()
                Me.natxt.Clear()
                Me.tctxt.Clear()
                Me.doctxt.Clear()
                Me.ltxt.Text = ""
                Me.dtxt.Clear()
                Me.fntxt.Clear()
                Me.listo.Visible = True
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub listo_Click(sender As Object, e As EventArgs) Handles listo.Click
        Conectar.conectar()

        If flag_abm = 1 Then 'ALTA
            nuevocliente()
        ElseIf flag_abm = 8 Then 'UPDATE
            updatecliente()
        ElseIf flag_abm = 3 Then 'DELETE
            deleteCliente()
        End If
        Try
            ' Code that may cause an exception goes here

        Catch ex As Exception
            ' Handle the exception here
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Me.refreshDatagrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frptclientes.Show()
    End Sub
End Class