Public Class Frptclientes
    Private Sub Frptclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'juzgados2023DataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.clientesTableAdapter.FillBycli(Me.juzgados2023DataSet.clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class