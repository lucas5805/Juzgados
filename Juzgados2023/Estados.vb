Imports System.Data.SqlClient
Public Class Estados
    Private Sub Estados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EstadosTableAdapter1.Fill(Me.Juzgados2023DataSet.estados)
        refreshDatagrid()
    End Sub

    Private Sub refreshDatagrid()
        Conectar.conectar()
        Dim sql As SqlCommand = New SqlCommand("SELECT * FROM estados order by cod_estado", conexion)
        Dim ds As DataSet = New DataSet()
        Dim DataAdapter1 As SqlDataAdapter = New SqlDataAdapter()

        DataAdapter1.SelectCommand = sql
        DataAdapter1.Fill(ds, "estados")
        dgvest.DataSource = ds
        dgvest.DataMember = "estados"

    End Sub
    Private Sub llenarjuicios()
        Dim sql As String = "SELECT cod_estado as cod_estado, descripcion as descripcion FROM estados order by cod_estado"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conectar.conexion)

        ds.Tables.Add("estados")
        adp.Fill(ds.Tables("estados"))
        Me.dgvest.DataSource = ds.Tables("estados")
    End Sub
    Private Sub nuevojuicios()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text

        Dim sql As String = "INSERT INTO estados VALUES ('" & Me.cetxt.Text & "','" & Me.dtxt.Text & "')"
        cmd.CommandText = sql

        'validacion
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarjuicios()
            Me.cetxt.Clear()
            Me.dtxt.Clear()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        flag_abm = 1 'ALTA
        Me.cetxt.Enabled = True
        Me.dtxt.Enabled = True

        Me.dtxt.Focus()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        flag_abm = 2 'UPDATE
        Dim wcodigoest As String
        wcodigoest = Me.dgvest.CurrentRow.Cells("cod_estado").Value.ToString()

        Me.cetxt.Text = wcodigoest
        Me.dtxt.Text = Me.dgvest.CurrentRow.Cells("descripcion").Value.ToString()

        Me.cetxt.Enabled = False ' Assuming the client code is not editable
        Me.dtxt.Enabled = True
    End Sub
    Private Sub updatejuicios()
        Dim desc As String = dgvest.CurrentRow.Cells("descripcion").Value.ToString()

        ' Verifica si el estado está asociado a un expediente
        Dim query As String = "SELECT COUNT(*) FROM expedientes WHERE estado = @desc"
        Dim count As Integer

        Conectar.conectar()

        Using command As New SqlCommand(query, conexion)
            command.Parameters.AddWithValue("@desc", desc)

            count = Convert.ToInt32(command.ExecuteScalar())
        End Using


        ' Si el estado está asociado a un expediente, se muestra un mensaje y no se modifica
        If count > 0 Then
            MessageBox.Show("No es posible modificar este estado porque está asociado a un expediente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim wcodigoest As String
            wcodigoest = Me.dgvest.CurrentRow.Cells("cod_estado").Value.ToString()
            Conectar.conectar()
            cmd.CommandType = CommandType.Text
            Dim sql As String = "UPDATE estados SET cod_estado = '" & Me.cetxt.Text & "', descripcion = '" & Me.dtxt.Text & "' WHERE cod_estado = '" & wcodigoest & "'"
            cmd.CommandText = sql
            'validacion

            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarjuicios()
                Me.dtxt.Clear()
                Me.cetxt.Clear()
                Me.Button1.Visible = True
            Catch ex As Exception

                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        flag_abm = 3 'DELETE
        Dim wcodigoest As String
        wcodigoest = Me.dgvest.CurrentRow.Cells("cod_estado").Value.ToString()
        Me.cetxt.Text = wcodigoest
        Me.dtxt.Text = Me.dgvest.CurrentRow.Cells("descripcion").Value.ToString()
        Me.cetxt.Enabled = False
        Me.dtxt.Enabled = True


        Me.Button1.Visible = True
    End Sub
    Private Sub deletejuicios()
        Dim desc As String = dgvest.CurrentRow.Cells("descripcion").Value.ToString()

        ' Verifica si el estado está asociado a un expediente
        Dim query As String = "SELECT COUNT(*) FROM expedientes WHERE estado = @desc"
        Dim count As Integer

        Conectar.conectar()

        Using command As New SqlCommand(query, conexion)
            command.Parameters.AddWithValue("@desc", desc)

            count = Convert.ToInt32(command.ExecuteScalar())
        End Using


        ' Si el estado está asociado a un expediente, se muestra un mensaje y no se modifica
        If count > 0 Then
            MessageBox.Show("No es posible eliminar este estado porque está asociado a un expediente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Conectar.conectar()
            cmd.CommandType = CommandType.Text
            Dim wcodigoest As String
            wcodigoest = Me.dgvest.CurrentRow.Cells("cod_estado").Value.ToString()
            Dim sql As String = "DELETE FROM estados WHERE cod_estado = '" & wcodigoest & "'"
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarjuicios()
                Me.cetxt.Clear()
                Me.dtxt.Clear()


            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Conectar.conectar()

        If flag_abm = 1 Then 'ALTA
            nuevojuicios()
        ElseIf flag_abm = 2 Then 'UPDATE
            updatejuicios()
        ElseIf flag_abm = 3 Then 'DELETE
            deletejuicios()
        End If
        Try


        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Me.refreshDatagrid()
    End Sub


End Class