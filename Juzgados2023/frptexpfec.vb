Public Class frptexpfec
    Public Property FechaDesde As Date
    Public Property FechaHasta As Date
    Private Sub frtpexpfec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'juzgados2023DataSet.expedientes' Puede moverla o quitarla según sea necesario.
        Me.ExpedientesTableAdapter.FillByfecha(Me.juzgados2023DataSet.expedientes, FechaDesde, FechaHasta)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class