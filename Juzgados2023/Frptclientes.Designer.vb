<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frptclientes
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
        Me.clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clientesTableAdapter = New Juzgados2023.juzgados2023DataSetTableAdapters.clientesTableAdapter()
        CType(Me.juzgados2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.clientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Juzgados2023.rptcliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(762, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'juzgados2023DataSet
        '
        Me.juzgados2023DataSet.DataSetName = "juzgados2023DataSet"
        Me.juzgados2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clientesBindingSource
        '
        Me.clientesBindingSource.DataMember = "clientes"
        Me.clientesBindingSource.DataSource = Me.juzgados2023DataSet
        '
        'clientesTableAdapter
        '
        Me.clientesTableAdapter.ClearBeforeFill = True
        '
        'Frptclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Frptclientes"
        Me.Text = "Frptclientes"
        CType(Me.juzgados2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clientesBindingSource As BindingSource
    Friend WithEvents juzgados2023DataSet As juzgados2023DataSet
    Friend WithEvents clientesTableAdapter As juzgados2023DataSetTableAdapters.clientesTableAdapter
End Class
