<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frptjuzgados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.juzgados2023DataSet = New Juzgados2023.juzgados2023DataSet()
        Me.datosjuzgadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datosjuzgadoTableAdapter = New Juzgados2023.juzgados2023DataSetTableAdapters.datosjuzgadoTableAdapter()
        CType(Me.juzgados2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datosjuzgadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.datosjuzgadoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Juzgados2023.rptjuz.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'juzgados2023DataSet
        '
        Me.juzgados2023DataSet.DataSetName = "juzgados2023DataSet"
        Me.juzgados2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'datosjuzgadoBindingSource
        '
        Me.datosjuzgadoBindingSource.DataMember = "datosjuzgado"
        Me.datosjuzgadoBindingSource.DataSource = Me.juzgados2023DataSet
        '
        'datosjuzgadoTableAdapter
        '
        Me.datosjuzgadoTableAdapter.ClearBeforeFill = True
        '
        'frtpjuzgados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frtpjuzgados"
        Me.Text = "frtpjuzgados"
        CType(Me.juzgados2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datosjuzgadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents datosjuzgadoBindingSource As BindingSource
    Friend WithEvents juzgados2023DataSet As juzgados2023DataSet
    Friend WithEvents datosjuzgadoTableAdapter As juzgados2023DataSetTableAdapters.datosjuzgadoTableAdapter
End Class
