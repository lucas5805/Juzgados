Public Class frptexp
    Public Property CodExp As String
    Private Sub frtpexp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'juzgados2023DataSet.expedientes' Puede moverla o quitarla según sea necesario.
        Me.expedientesTableAdapter.FillBycodexp(Me.juzgados2023DataSet.expedientes, CodExp)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class