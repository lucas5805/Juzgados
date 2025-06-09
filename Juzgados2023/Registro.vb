Imports System.Data.SqlClient
Public Class Registro
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Juzgados2023DataSet.login' Puede moverla o quitarla según sea necesario.
        Me.LoginTableAdapter.Fill(Me.Juzgados2023DataSet.login)

    End Sub

    Private Sub refreshDatagrid()
        Conectar.conectar()
        Dim sql As SqlCommand = New SqlCommand("SELECT * FROM login", conexion)
        Dim ds As DataSet = New DataSet()
        Dim DataAdapter1 As SqlDataAdapter = New SqlDataAdapter()

        DataAdapter1.SelectCommand = sql
        DataAdapter1.Fill(ds, "login")
        dgvlog.DataSource = ds
        dgvlog.DataMember = "login"

    End Sub
    Private Sub llenarlogin()
        Dim sql As String = "SELECT usuario as usuario, contrasena as contrasena FROM login"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conectar.conexion)

        ds.Tables.Add("login")
        adp.Fill(ds.Tables("login"))
        Me.dgvlog.DataSource = ds.Tables("login")
    End Sub
    Public Sub Nuevousuario()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text

        Dim sql As String = "INSERT INTO login VALUES ('" & Me.u.Text & "','" & Me.c.Text & "')"
        cmd.CommandText = sql

        'validacion
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarlogin()
            Me.c.Clear()
            Me.u.Clear()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        flag_abm = 1 'ALTA
        Me.c.Enabled = True
        Me.u.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        flag_abm = 2 'UPDATE
        Dim wusuario As String
        wusuario = Me.dgvlog.CurrentRow.Cells("usuario").Value.ToString()

        Me.u.Text = wusuario
        Me.c.Text = Me.dgvlog.CurrentRow.Cells("contrasena").Value.ToString()

        Me.u.Enabled = True
        Me.c.Enabled = True
    End Sub

    Private Sub Updateusuarios()
        Dim wusuario As String
        wusuario = Me.dgvlog.CurrentRow.Cells("usuario").Value.ToString()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text
        Dim sql As String = "UPDATE login SET usuario = '" & Me.u.Text & "', contrasena = '" & Me.c.Text & "' WHERE usuario = '" & wusuario & "'"
        cmd.CommandText = sql
        'validacion

        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarlogin()
            Me.u.Clear()
            Me.c.Clear()
            Me.listo.Visible = True
        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        flag_abm = 3 'DELETE
        Dim wusuario As String
        wusuario = Me.dgvlog.CurrentRow.Cells("usuario").Value.ToString()
        Me.u.Text = wusuario
        Me.c.Text = Me.dgvlog.CurrentRow.Cells("contrasena").Value.ToString()
        Me.u.Enabled = False
        Me.c.Enabled = False
        Me.listo.Visible = True
    End Sub
    Private Sub deleteusuario()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text
        Dim wusuario As String
        wusuario = Me.dgvlog.CurrentRow.Cells("usuario").Value.ToString()
        Dim sql As String = "DELETE FROM login WHERE usuario = '" & wusuario & "'"
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarlogin()
            Me.u.Clear()
            Me.c.Clear()


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub listo_Click(sender As Object, e As EventArgs) Handles listo.Click
        Conectar.conectar()

        If flag_abm = 1 Then 'ALTA
            Nuevousuario()
        ElseIf flag_abm = 2 Then 'UPDATE
            Updateusuarios()
        ElseIf flag_abm = 3 Then 'DELETE
            deleteusuario()
        End If
        Try
            ' Code that may cause an exception goes here

        Catch ex As Exception
            ' Handle the exception here
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Me.refreshDatagrid()

    End Sub

    Private Sub dgvlog_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlog.CellContentClick

    End Sub


End Class