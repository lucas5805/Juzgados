Imports System.Data.SqlClient
Public Class Expedientes
    Private Sub Expedientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Juzgados2023DataSet.juzgados' Puede moverla o quitarla según sea necesario.
        Me.JuzgadosTableAdapter.Fill(Me.Juzgados2023DataSet.juzgados)
        'TODO: esta línea de código carga datos en la tabla 'Juzgados2023DataSet.juicios' Puede moverla o quitarla según sea necesario.
        Me.JuiciosTableAdapter.Fill(Me.Juzgados2023DataSet.juicios)
        'TODO: esta línea de código carga datos en la tabla 'Juzgados2023DataSet.estados' Puede moverla o quitarla según sea necesario.
        Me.EstadosTableAdapter.Fill(Me.Juzgados2023DataSet.estados)
        Me.ExpedientesTableAdapter1.Fill(Me.Juzgados2023DataSet.expedientes)
        Me.estxt.Text = ""
        Me.jtxt.Text = ""
        Me.juztxt.Text = ""
    End Sub
    Private Sub refreshDatagrid()
        Conectar.conectar()
        Dim sql As SqlCommand = New SqlCommand("SELECT * FROM expedientes", conexion)
        Dim ds As DataSet = New DataSet()
        Dim DataAdapter1 As SqlDataAdapter = New SqlDataAdapter()

        DataAdapter1.SelectCommand = sql
        DataAdapter1.Fill(ds, "expedientes")
        dgvexp.DataSource = ds
        dgvexp.DataMember = "expedientes"

    End Sub
    Private Sub llenarexpedientes()
        Dim sql As String = "SELECT cod_exp as cod_exp, fecha_inicio as fecha_inicio, caratula as caratula, estado as estado, juicio as juicio, juzgado as juzgado FROM expedientes"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, Conectar.conexion)

        ds.Tables.Add("expedientes")
        adp.Fill(ds.Tables("expedientes"))
        Me.dgvexp.DataSource = ds.Tables("expedientes")
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        flag_abm = 1 'ALTA
        Me.cetxt.Enabled = True
        Me.netxt.Enabled = True
        Me.fitxt.Enabled = True
        Me.ctxt.Enabled = True
        Me.estxt.Enabled = True
        Me.jtxt.Enabled = True
        Me.juztxt.Enabled = True
        Me.cetxt.Focus()
    End Sub
    Private Sub nuevoexpediente()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text

        Dim sql As String = " INSERT INTO expedientes VALUES ('" & Me.cetxt.Text & "','" & Me.netxt.Text & "','" & Me.fitxt.Text & "','" & Me.ctxt.Text & "','" & Me.estxt.Text & "','" & Me.jtxt.Text & "','" & Me.juztxt.Text & "');
        INSERT INTO cliente_exp(cod_exp2, nom_exp) VALUES ('" & Me.cetxt.Text & "','" & Me.netxt.Text & "')"
        cmd.CommandText = sql

        'validacion
        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarexpedientes()
            Me.cetxt.Clear()
            Me.netxt.Clear()
            Me.fitxt.Clear()
            Me.ctxt.Clear()
            Me.estxt.Text = ""
            Me.jtxt.Text = ""
            Me.juztxt.Text = ""


        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        flag_abm = 2 'UPDATE
        Dim wcodigoexp As String
        wcodigoexp = Me.dgvexp.CurrentRow.Cells("cod_exp").Value.ToString()

        Me.cetxt.Text = wcodigoexp
        Me.netxt.Text = Me.dgvexp.CurrentRow.Cells("nombre_exp").Value.ToString()
        Me.fitxt.Text = (Me.dgvexp.CurrentRow.Cells("fecha_inicio").Value)
        Me.ctxt.Text = Me.dgvexp.CurrentRow.Cells("caratula").Value.ToString()
        Me.estxt.Text = Me.dgvexp.CurrentRow.Cells("estado").Value.ToString()
        Me.jtxt.Text = Me.dgvexp.CurrentRow.Cells("juicio").Value.ToString()
        Me.juztxt.Text = (Me.dgvexp.CurrentRow.Cells("juzgado").Value.ToString())
        Me.cetxt.Enabled = False 'el codigo no se edita
        Me.netxt.Enabled = True
        Me.fitxt.Enabled = True
        Me.ctxt.Enabled = True
        Me.estxt.Enabled = True
        Me.jtxt.Enabled = True
        Me.juztxt.Enabled = True
    End Sub
    Private Sub updateexpediente()
        Dim wcodigoexp As String
        wcodigoexp = Me.dgvexp.CurrentRow.Cells("cod_exp").Value.ToString()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text
        Dim sql As String = "UPDATE expedientes SET cod_exp = '" & Me.cetxt.Text & "', nombre_exp = '" & Me.netxt.Text & "', fecha_inicio = '" & Me.fitxt.Text & "', caratula = '" & Me.ctxt.Text & "', estado = '" & Me.estxt.Text & "', juicio = '" & Me.jtxt.Text & "', juzgado = '" & Me.juztxt.Text & "' WHERE cod_exp = '" & wcodigoexp & "'"
        cmd.CommandText = sql


        Dim sqlQuery As String

        sqlQuery = "UPDATE expedientes SET juicio = '" & Me.jtxt.Text & "' WHERE juicio = '" & Me.jtxt.Text & "';"
        Dim cmdUpdateExp As New SqlCommand(sqlQuery, conexion)
        cmdUpdateExp.ExecuteNonQuery()




        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarexpedientes()
            Me.cetxt.Clear()
            Me.netxt.Clear()
            Me.fitxt.Clear()
            Me.ctxt.Clear()
            Me.estxt.Text = ""
            Me.jtxt.Text = ""
            Me.juztxt.Text = ""
        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        flag_abm = 3 'DELETE
        Dim wcodigoexp As String
        wcodigoexp = Me.dgvexp.CurrentRow.Cells("cod_exp").Value.ToString()
        Me.cetxt.Text = wcodigoexp
        Me.netxt.Text = Me.dgvexp.CurrentRow.Cells("nombre_exp").Value.ToString()
        Me.fitxt.Text = (Me.dgvexp.CurrentRow.Cells("fecha_inicio").Value)
        Me.ctxt.Text = Me.dgvexp.CurrentRow.Cells("caratula").Value.ToString()
        Me.estxt.Text = Me.dgvexp.CurrentRow.Cells("estado").Value.ToString()
        Me.jtxt.Text = Me.dgvexp.CurrentRow.Cells("juicio").Value.ToString()
        Me.juztxt.Text = Me.dgvexp.CurrentRow.Cells("juzgado").Value.ToString()
        Me.cetxt.Enabled = False
        Me.netxt.Enabled = True
        Me.fitxt.Enabled = True
        Me.ctxt.Enabled = True
        Me.estxt.Enabled = True
        Me.jtxt.Enabled = True
        Me.juztxt.Enabled = True
        Me.Listo.Visible = True
    End Sub
    Private Sub deleteexpediente()
        Conectar.conectar()
        cmd.CommandType = CommandType.Text
        Dim wcodigoexp As String
        wcodigoexp = Me.dgvexp.CurrentRow.Cells("cod_exp").Value.ToString()
        Dim sql As String = "ALTER TABLE cliente_exp NOCHECK CONSTRAINT FK__cliente_e__cod_e__2B3F6F97; DELETE FROM expedientes WHERE cod_exp = '" & wcodigoexp & "';
        DELETE FROM cliente_exp WHERE cod_exp2 = '" & wcodigoexp & "'; ALTER TABLE cliente_exp WITH CHECK CHECK CONSTRAINT FK__cliente_e__cod_e__2B3F6F97;"
        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarexpedientes()
            Me.cetxt.Clear()
            Me.netxt.Clear()
            Me.ctxt.Clear()
            Me.fitxt.Clear()
            Me.estxt.Text = ""
            Me.jtxt.Text = ""
            Me.juztxt.Text = ""


        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")


            '             MsgBox(ex.ToString())
            '            Dim errortxt As String = "C:\errores\error.txt"
            '           Using writer As New System.IO.StreamWriter(errortxt, True)
            '          writer.WriteLine("Date/Time: " & Date.Now.ToString())
            '         writer.WriteLine("Error: " & ex.ToString())
            '        writer.WriteLine("=============================================")
            ' End Using
        End Try
    End Sub

    Private Sub listo_Click(sender As Object, e As EventArgs) Handles listo.Click
        Conectar.conectar()

        If flag_abm = 1 Then 'ALTA
            nuevoexpediente()
        ElseIf flag_abm = 2 Then 'UPDATE
            updateexpediente()

        ElseIf flag_abm = 3 Then 'DELETE
            deleteexpediente()
        End If
        Try

        Catch ex As Exception
            ' Handle the exception here
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        fitxt.Clear()
        Me.refreshDatagrid()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            frptexp.CodExp = TextBox1.Text
            frptexp.Show()
        Catch ex As Exception
            MsgBox("Los campos no pueden estar vacios" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class