Imports System.Data.SqlClient
Public Class Expedientesxfecha
    Private Sub Expedientesxfecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Juzgados2023DataSet.expedientes' Puede moverla o quitarla según sea necesario.
        Me.ExpedientesTableAdapter.Fill(Me.Juzgados2023DataSet.expedientes)

    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim fechaDesde As Date = desde.Text
        Dim fechaHasta As Date = hasta.Text

        ' Construir la consulta SQL para buscar entre las fechas
        Dim consulta As String = "SELECT * FROM expedientes WHERE fecha_inicio BETWEEN @FechaDesde AND @FechaHasta"

        ' Establecer la conexión a la base de datos
        Conectar.conectar()
        'comprueba que las fechas sean coherentes
        If fechaDesde > fechaHasta Then
            MessageBox.Show("La fecha inicial no puede ser posterior a la fecha final.")
            Return
        End If

        ' Crear un adaptador de datos y un conjunto de datos
        Using adapter As New SqlDataAdapter(consulta, conexion)
            ' Agregar parámetros para las fechas
            adapter.SelectCommand.Parameters.AddWithValue("@FechaDesde", fechaDesde)
            adapter.SelectCommand.Parameters.AddWithValue("@FechaHasta", fechaHasta)

            ' Crear un conjunto de datos para almacenar los resultados
            Dim dataSet As New DataSet()

            ' Llenar el conjunto de datos con los resultados de la consulta
            adapter.Fill(dataSet, "expedientes")

            ' Verificar si hay resultados
            If dataSet.Tables("expedientes").Rows.Count > 0 Then
                ' Mostrar los resultados en el DataGridView
                dgvexp.DataSource = dataSet.Tables("expedientes")
            Else
                ' Mostrar un mensaje de error si no se encuentran resultados
                MessageBox.Show("No se encontraron resultados para la búsqueda especificada.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub rpt_Click(sender As Object, e As EventArgs) Handles rpt.Click
        Try
            ' Obtener las fechas desde los TextBox
            Dim fechaDesde As Date = desde.Text
            Dim fechaHasta As Date = hasta.Text
            ' Validar que las fechas sean coherentes
            If fechaDesde > fechaHasta Then
                MessageBox.Show("La fecha inicial no puede ser posterior a la fecha final.")
                Return
            End If


            ' Pasar las fechas como parámetros al formulario de informes
            frptexpfec.FechaDesde = fechaDesde
            frptexpfec.FechaHasta = fechaHasta


            frptexpfec.Show()
        Catch ex As Exception
            MsgBox("Los campos no pueden estar vacios" & ex.Message, MsgBoxStyle.Critical, "Error")


        End Try
    End Sub
End Class