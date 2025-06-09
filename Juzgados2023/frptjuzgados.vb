Public Class frptjuzgados
    Private Sub frtpjuzgados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'juzgados2023DataSet.datosjuzgado' Puede moverla o quitarla según sea necesario.
        Me.datosjuzgadoTableAdapter.Fill(Me.juzgados2023DataSet.datosjuzgado)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class