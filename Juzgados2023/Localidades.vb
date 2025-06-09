Imports System.Data.SqlClient
Public Class Localidades
    Private Sub Localidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LocalidadesTableAdapter1.Fill(Me.juzgados2023dataset.localidades)
    End Sub
    Private Sub refreshDatagrid()
        Conectar.conectar()
        Dim sql As SqlCommand = New SqlCommand("SELECT * FROM Localidades", conexion)
        Dim ds As DataSet = New DataSet()
        Dim DataAdapter1 As SqlDataAdapter = New SqlDataAdapter()

        DataAdapter1.SelectCommand = sql
        DataAdapter1.Fill(ds, "Localidades")
        dgvloc.DataSource = ds
        dgvloc.DataMember = "Localidades"

    End Sub
    Private Sub llenarLocalidades()
        Dim sql As String = "select cp as CP ,localidades as LOCALIDADES from localidades"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conectar.conexion)

        ds.Tables.Add("localidades")
        adp.Fill(ds.Tables("localidades"))
        Me.dgvloc.DataSource = ds.Tables("localidades")
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        flag_abm = 1 'ALTA
        Me.cptxt.Enabled = True
        Me.localtxt.Enabled = True
        Me.localtxt.Focus()
    End Sub
    Private Sub nuevaLocalidad()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text
        Dim sql As String = "insert into localidades values (" & Me.cptxt.Text & ",'" & Me.localtxt.Text & "')"
        cmd.CommandText = sql

        'validacion
        If Me.cptxt.Text <> "" Then
            If Me.localtxt.Text <> "" Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarLocalidades()
                    Me.cptxt.Clear()
                    Me.localtxt.Clear()
                    Me.listo.Visible = True
                Catch ex As Exception

                End Try
            Else
                MsgBox("El campo LOCALIDAD no puede estar vacio.", "Error")
                Me.localtxt.Focus()
            End If
        Else
            MsgBox("El campo CP no puede estar vacio.", "Error")
            Me.cptxt.Focus()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        flag_abm = 2 'UPDATE
        wcp = Me.dgvloc.CurrentRow.Cells(0).Value
        Me.cptxt.Text = wcp
        Me.localtxt.Text = Me.dgvloc.CurrentRow.Cells(1).Value.ToString
        Me.localtxt.Enabled = True
        Me.localtxt.Focus()
    End Sub
    Private Sub updateLocalidades()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text
        Dim sql As String = "update localidades set localidades = '" & Me.localtxt.Text & "' where cp = " & wcp & ""
        cmd.CommandText = sql
        'validacion
        If Me.localtxt.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarLocalidades()
                Me.cptxt.Clear()
                Me.localtxt.Clear()
                Me.listo.Visible = True
            Catch ex As Exception

            End Try
        Else
            MsgBox("El campo LOCALIDADES no puede estar vacio.", "Error")
            Me.localtxt.Focus()
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        flag_abm = 3 'DELETE
        wcp = Me.dgvloc.CurrentRow.Cells(0).Value
        Me.cptxt.Text = wcp
        Me.localtxt.Text = Me.dgvloc.CurrentRow.Cells(1).Value.ToString
        Me.localtxt.Enabled = True
    End Sub
    Private Sub deleteLocalidades()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text
        Dim sql As String = "delete localidades where cp = " & wcp & ""
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarLocalidades()
            Me.localtxt.Clear()
            Me.listo.Visible = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles listo.Click
        Conectar.conectar()

        If flag_abm = 1 Then 'ALTA
            nuevaLocalidad()
        ElseIf flag_abm = 2 Then 'UPDATE
            updateLocalidades()
        ElseIf flag_abm = 3 Then 'DELETE
            deleteLocalidades()
            Try
                ' Code that may cause an exception goes here

            Catch ex As Exception
                ' Handle the exception here
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
        Me.cptxt.Enabled = False
        Me.localtxt.Enabled = False
        Me.refreshDatagrid()
    End Sub

    Private Sub buscarcp_Click(sender As Object, e As EventArgs) Handles buscarcp.Click
        Try
            Dim valorBuscado As String = TextBox1.Text
            valorBuscado = valorBuscado.ToLower()
            For Each fila As DataGridViewRow In dgvloc.Rows
                If Not fila.IsNewRow AndAlso fila.Cells("cp").Value IsNot Nothing Then
                    Dim valorCelda As String = fila.Cells("cp").Value.ToString().ToLower()
                    If valorCelda.Contains(valorBuscado) Then
                        fila.Selected = True
                        dgvloc.FirstDisplayedScrollingRowIndex = fila.Index
                    End If
                End If
            Next
            TextBox1.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub buscarlocal_Click(sender As Object, e As EventArgs) Handles buscarlocal.Click
        Try
            Dim valorBuscado As String = TextBox2.Text
            valorBuscado = valorBuscado.ToLower()
            For Each fila As DataGridViewRow In dgvloc.Rows
                If Not fila.IsNewRow AndAlso fila.Cells("localidad").Value IsNot Nothing Then
                    Dim valorCelda As String = fila.Cells("localidad").Value.ToString().ToLower()
                    If valorCelda.Contains(valorBuscado) Then
                        fila.Selected = True
                        dgvloc.FirstDisplayedScrollingRowIndex = fila.Index
                    End If
                End If
            Next
            TextBox2.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class