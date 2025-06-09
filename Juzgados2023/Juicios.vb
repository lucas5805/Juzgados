Imports System.Data.SqlClient
Public Class Juicios
    Private Sub Juicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.JuiciosTableAdapter1.Fill(Me.Juzgados2023DataSet.juicios)
    End Sub
    Private Sub refreshDatagrid()
        Conectar.conectar()
        Dim sql As SqlCommand = New SqlCommand("SELECT * FROM juicios", conexion)
        Dim ds As DataSet = New DataSet()
        Dim DataAdapter1 As SqlDataAdapter = New SqlDataAdapter()

        DataAdapter1.SelectCommand = sql
        DataAdapter1.Fill(ds, "juicios")
        dgvjuicios.DataSource = ds
        dgvjuicios.DataMember = "juicios"

    End Sub
    Private Sub llenarjuicios()
        Dim sql As String = "SELECT cod_juicio as cod_cuicio, desc_juicio as desc_juicio FROM juicios"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conectar.conexion)

        ds.Tables.Add("juicios")
        adp.Fill(ds.Tables("juicios"))
        Me.dgvjuicios.DataSource = ds.Tables("juicios")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        flag_abm = 1 'ALTA
        Me.cjtxt.Enabled = True
        Me.dtxt.Enabled = True

        Me.dtxt.Focus()
    End Sub
    Private Sub nuevojuicios()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text

        Dim sql As String = "INSERT INTO juicios VALUES ('" & Me.cjtxt.Text & "','" & Me.dtxt.Text & "')"
        cmd.CommandText = sql

        'validacion
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarjuicios()
            Me.cjtxt.Clear()
            Me.dtxt.Clear()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try




    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        flag_abm = 2 'UPDATE
        Dim wcodigojuicio As String
        wcodigojuicio = Me.dgvjuicios.CurrentRow.Cells("cod_juicio").Value.ToString()

        Me.cjtxt.Text = wcodigojuicio
        Me.dtxt.Text = Me.dgvjuicios.CurrentRow.Cells("desc_juicio").Value.ToString()

        Me.cjtxt.Enabled = False ' Assuming the client code is not editable
        Me.dtxt.Enabled = True
    End Sub
    Private Sub updatejuicios()
        Dim desc As String = dgvjuicios.CurrentRow.Cells("desc_juicio").Value.ToString()

        ' Verifica si el juicio está asociado a un expediente
        Dim query As String = "SELECT COUNT(*) FROM expedientes WHERE juicio = @desc"
        Dim count As Integer

        Conectar.conectar()

        Using command As New SqlCommand(query, conexion)
            command.Parameters.AddWithValue("@desc", desc)

            count = Convert.ToInt32(command.ExecuteScalar())
        End Using


        'Si el juicio está asociado a un expediente, se muestra un mensaje y no se modifica
        If count > 0 Then
            MessageBox.Show("No es posible modificar este juicio porque está asociado a un expediente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim wcodigojuicio As String
            wcodigojuicio = Me.dgvjuicios.CurrentRow.Cells("cod_juicio").Value.ToString()
            Conectar.conectar()
            cmd.CommandType = CommandType.Text
            Dim sql As String = "UPDATE juicios SET cod_juicio = '" & Me.cjtxt.Text & "', desc_juicio = '" & Me.dtxt.Text & "' WHERE cod_juicio = '" & wcodigojuicio & "'"
            cmd.CommandText = sql
            'validacion

            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarjuicios()
                Me.dtxt.Clear()
                Me.cjtxt.Clear()
                Me.listo.Visible = True
            Catch ex As Exception

                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        flag_abm = 3 'DELETE
        Dim wcodigojuicio As String
        wcodigojuicio = Me.dgvjuicios.CurrentRow.Cells("cod_juicio").Value.ToString()
        Me.cjtxt.Text = wcodigojuicio
        Me.dtxt.Text = Me.dgvjuicios.CurrentRow.Cells("desc_juicio").Value.ToString()
        Me.cjtxt.Enabled = False ' Assuming the client code is not editable
        Me.dtxt.Enabled = True
        Me.listo.Visible = True
    End Sub
    Private Sub deletejuicios()
        Dim desc As String = dgvjuicios.CurrentRow.Cells("desc_juicio").Value.ToString()

        'Verifica si el juicio está asociado a un expediente
        Dim query As String = "SELECT COUNT(*) FROM expedientes WHERE juicio = @desc"
        Dim count As Integer

        Conectar.conectar()

        Using command As New SqlCommand(query, conexion)
            command.Parameters.AddWithValue("@desc", desc)

            count = Convert.ToInt32(command.ExecuteScalar())
        End Using


        'Si el juicio está asociado a un expediente, se muestra un mensaje y no se modifica
        If count > 0 Then
            MessageBox.Show("No es posible eliminar este juicio porque está asociado a un expediente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Conectar.conectar()
            cmd.CommandType = CommandType.Text
            Dim wcodigojuicio As String
            wcodigojuicio = Me.dgvjuicios.CurrentRow.Cells("cod_juicio").Value.ToString()
            Dim sql As String = "DELETE FROM juicios WHERE cod_juicio = '" & wcodigojuicio & "'"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarjuicios()
                Me.cjtxt.Clear()
                Me.dtxt.Clear()


            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles listo.Click
        Conectar.conectar()

        If flag_abm = 1 Then 'ALTA
            nuevojuicios()
        ElseIf flag_abm = 2 Then 'UPDATE
            updatejuicios()
        ElseIf flag_abm = 3 Then 'DELETE
            deletejuicios()
        End If
        Try
            ' Code that may cause an exception goes here

        Catch ex As Exception
            ' Handle the exception here
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Me.refreshDatagrid()
    End Sub

End Class