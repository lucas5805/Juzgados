Imports System.Data.SqlClient
Public Class Juzgados
    Private Sub Juzgados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Juzgados2023DataSet.localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.Fill(Me.Juzgados2023DataSet.localidades)
        'TODO: esta línea de código carga datos en la tabla 'Juzgados2023DataSet.juzgados' Puede moverla o quitarla según sea necesario.
        Me.JuzgadosTableAdapter.Fill(Me.Juzgados2023DataSet.juzgados)
        Me.ltxt.Text = ""
    End Sub

    Private Sub refreshDatagrid()
        Conectar.conectar()
        Dim sql As SqlCommand = New SqlCommand("SELECT * FROM Juzgados", conexion)
        Dim ds As DataSet = New DataSet()
        Dim DataAdapter1 As SqlDataAdapter = New SqlDataAdapter()

        DataAdapter1.SelectCommand = sql
        DataAdapter1.Fill(ds, "Juzgados")
        dgvjuz.DataSource = ds
        dgvjuz.DataMember = "Juzgados"

    End Sub
    Private Sub llenarjuicios()
        Dim sql As String = "SELECT cod_juzgado as cod_juzgado, nombre_juzgado as nombre_juzgado, nombre_juez as nombre_juez, secretario as secretario, fecha_alta as fecha_alta, telefono as telefono, localidad as localidad FROM Juzgados"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conectar.conexion)

        ds.Tables.Add("Juzgados")
        adp.Fill(ds.Tables("Juzgados"))
        Me.dgvjuz.DataSource = ds.Tables("Juzgados")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        flag_abm = 1 'ALTA
        Me.cjtxt.Enabled = True
        Me.njtxt.Enabled = True
        Me.njutxt.Enabled = True
        Me.stxt.Enabled = True
        Me.fatxt.Enabled = True
        Me.ttxt.Enabled = True
        Me.ltxt.Enabled = True
        Me.cjtxt.Focus()
    End Sub

    Private Sub nuevoJuzgados()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text

        Dim sql As String = "INSERT INTO Juzgados VALUES ('" & Me.cjtxt.Text & "','" & Me.njtxt.Text & "','" & Me.njutxt.Text & "','" & Me.stxt.Text & "','" & Me.ttxt.Text & "','" & Me.fatxt.Text & "','" & Me.ltxt.Text & "')"
        cmd.CommandText = sql

        'validacion
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarjuicios()
            Me.cjtxt.Clear()
            Me.njtxt.Clear()
            Me.njutxt.Clear()
            Me.stxt.Clear()
            Me.fatxt.Clear()
            Me.ttxt.Clear()
            Me.ltxt.Text = ""
        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        flag_abm = 2 'UPDATE
        Dim wcodigojuz As String
        wcodigojuz = Me.dgvjuz.CurrentRow.Cells("cod_juzgado").Value.ToString()
        Me.cjtxt.Text = wcodigojuz
        Me.njtxt.Text = Me.dgvjuz.CurrentRow.Cells("nombre_juzgado").Value.ToString()
        Me.njutxt.Text = Me.dgvjuz.CurrentRow.Cells("nombre_juez").Value.ToString()
        Me.stxt.Text = Me.dgvjuz.CurrentRow.Cells("secretario").Value.ToString()
        Me.fatxt.Text = Convert.ToDateTime(Me.dgvjuz.CurrentRow.Cells("fecha_alta").Value)
        Me.ttxt.Text = Me.dgvjuz.CurrentRow.Cells("telefono").Value.ToString()
        Me.ltxt.Text = Me.dgvjuz.CurrentRow.Cells("localidad").Value.ToString()

        Me.cjtxt.Enabled = False
        Me.njtxt.Enabled = True
        Me.njutxt.Enabled = True
        Me.stxt.Enabled = True
        Me.fatxt.Enabled = True
        Me.ttxt.Enabled = True
        Me.ltxt.Enabled = True
    End Sub
    Private Sub updateJuzgados()
        Dim desc As String = dgvjuz.CurrentRow.Cells("nombre_juzgado").Value.ToString()

        ' Verifica si el juzgado está asociado a un expediente
        Dim query As String = "SELECT COUNT(*) FROM expedientes WHERE juzgado = @desc"
        Dim count As Integer

        Conectar.conectar()

        Using command As New SqlCommand(query, conexion)
            command.Parameters.AddWithValue("@desc", desc)

            count = Convert.ToInt32(command.ExecuteScalar())
        End Using


        'Si el juzgado está asociado a un expediente, se muestra un mensaje y no se modifica
        If count > 0 Then
            MessageBox.Show("No es posible modificar este juzgado porque está asociado a un expediente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim wcodigojuz As String
            wcodigojuz = Me.dgvjuz.CurrentRow.Cells("cod_juzgado").Value.ToString()
            cmd.Connection = Conectar.conexion
            cmd.CommandType = CommandType.Text
            Dim sql As String = "UPDATE Juzgados SET nombre_juzgado = ' " & Me.njtxt.Text & "', nombre_juez = '" & Me.njutxt.Text & "', secretario = '" & Me.stxt.Text & "', fecha_alta = '" & Me.fatxt.Text & "', telefono = '" & Me.ttxt.Text & "', localidad = '" & Me.ltxt.Text & "' WHERE cod_juzgado = '" & wcodigojuz & "'"
            cmd.CommandText = sql
            'validacion

            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarjuicios()
                Me.cjtxt.Clear()
                Me.njtxt.Clear()
                Me.njutxt.Clear()
                Me.stxt.Clear()
                Me.fatxt.Clear()
                Me.ttxt.Clear()
                Me.ltxt.Text = ""
            Catch ex As Exception

                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        flag_abm = 3 'DELETE
        Dim wcodigojuz As String
        wcodigojuz = Me.dgvjuz.CurrentRow.Cells("cod_juzgado").Value.ToString()
        Me.cjtxt.Text = wcodigojuz
        Me.njtxt.Text = Me.dgvjuz.CurrentRow.Cells("nombre_juzgado").Value.ToString()
        Me.njutxt.Text = Me.dgvjuz.CurrentRow.Cells("nombre_juez").Value.ToString()
        Me.stxt.Text = Me.dgvjuz.CurrentRow.Cells("secretario").Value.ToString()
        Me.fatxt.Text = Convert.ToDateTime(Me.dgvjuz.CurrentRow.Cells("fecha_alta").Value)
        Me.ttxt.Text = Me.dgvjuz.CurrentRow.Cells("telefono").Value.ToString()
        Me.ltxt.Text = Me.dgvjuz.CurrentRow.Cells("localidad").Value.ToString()

        Me.cjtxt.Enabled = True
        Me.njtxt.Enabled = True
        Me.njutxt.Enabled = True
        Me.stxt.Enabled = True
        Me.fatxt.Enabled = True
        Me.ttxt.Enabled = True
        Me.ltxt.Enabled = True


        Me.Listo.Visible = True
    End Sub
    Private Sub deleteJuzgados()
        Dim desc As String = dgvjuz.CurrentRow.Cells("nombre_juzgado").Value.ToString()

        ' Verifica si el juzgado está asociado a un expediente
        Dim query As String = "SELECT COUNT(*) FROM expedientes WHERE juzgado = @desc"
        Dim count As Integer

        Conectar.conectar()

        Using command As New SqlCommand(query, conexion)
            command.Parameters.AddWithValue("@desc", desc)

            count = Convert.ToInt32(command.ExecuteScalar())
        End Using


        'Si el juzgado está asociado a un expediente, se muestra un mensaje y no se modifica
        If count > 0 Then
            MessageBox.Show("No es posible eliminar este juzgado porque está asociado a un expediente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Conectar.conectar()
            cmd.CommandType = CommandType.Text
            Dim wcodigojuz As String
            wcodigojuz = Me.dgvjuz.CurrentRow.Cells("cod_juzgado").Value.ToString()
            Dim sql As String = "DELETE FROM Juzgados WHERE cod_juzgado = '" & wcodigojuz & "'"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarjuicios()
                Me.cjtxt.Clear()
                Me.njtxt.Clear()
                Me.njutxt.Clear()
                Me.stxt.Clear()
                Me.fatxt.Clear()
                Me.ttxt.Clear()
                Me.ltxt.Text = ""

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Listo_Click(sender As Object, e As EventArgs) Handles Listo.Click
        Conectar.conectar()

        If flag_abm = 1 Then 'ALTA
            nuevoJuzgados()
        ElseIf flag_abm = 2 Then 'UPDATE
            updateJuzgados()
        ElseIf flag_abm = 3 Then 'DELETE
            deleteJuzgados()
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
        frptjuzgados.Show()
    End Sub

End Class