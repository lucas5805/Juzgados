<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expedientesxfecha
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
        Me.dgvexp = New System.Windows.Forms.DataGridView()
        Me.cod_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.caratula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.juicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.juzgado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpedientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Juzgados2023DataSet = New Juzgados2023.juzgados2023DataSet()
        Me.ExpedientesTableAdapter = New Juzgados2023.juzgados2023DataSetTableAdapters.expedientesTableAdapter()
        Me.desde = New System.Windows.Forms.TextBox()
        Me.hasta = New System.Windows.Forms.TextBox()
        Me.buscar = New System.Windows.Forms.Button()
        Me.rpt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvexp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpedientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvexp
        '
        Me.dgvexp.AllowUserToAddRows = False
        Me.dgvexp.AllowUserToDeleteRows = False
        Me.dgvexp.AutoGenerateColumns = False
        Me.dgvexp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvexp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_exp, Me.nombre_exp, Me.fecha_inicio, Me.caratula, Me.estado, Me.juicio, Me.juzgado})
        Me.dgvexp.DataSource = Me.ExpedientesBindingSource
        Me.dgvexp.Location = New System.Drawing.Point(12, 12)
        Me.dgvexp.Name = "dgvexp"
        Me.dgvexp.ReadOnly = True
        Me.dgvexp.Size = New System.Drawing.Size(776, 150)
        Me.dgvexp.TabIndex = 0
        '
        'cod_exp
        '
        Me.cod_exp.DataPropertyName = "cod_exp"
        Me.cod_exp.HeaderText = "cod_exp"
        Me.cod_exp.Name = "cod_exp"
        Me.cod_exp.ReadOnly = True
        '
        'nombre_exp
        '
        Me.nombre_exp.DataPropertyName = "nombre_exp"
        Me.nombre_exp.HeaderText = "nombre_exp"
        Me.nombre_exp.Name = "nombre_exp"
        Me.nombre_exp.ReadOnly = True
        '
        'fecha_inicio
        '
        Me.fecha_inicio.DataPropertyName = "fecha_inicio"
        Me.fecha_inicio.HeaderText = "fecha_inicio"
        Me.fecha_inicio.Name = "fecha_inicio"
        Me.fecha_inicio.ReadOnly = True
        '
        'caratula
        '
        Me.caratula.DataPropertyName = "caratula"
        Me.caratula.HeaderText = "caratula"
        Me.caratula.Name = "caratula"
        Me.caratula.ReadOnly = True
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'juicio
        '
        Me.juicio.DataPropertyName = "juicio"
        Me.juicio.HeaderText = "juicio"
        Me.juicio.Name = "juicio"
        Me.juicio.ReadOnly = True
        '
        'juzgado
        '
        Me.juzgado.DataPropertyName = "juzgado"
        Me.juzgado.HeaderText = "juzgado"
        Me.juzgado.Name = "juzgado"
        Me.juzgado.ReadOnly = True
        '
        'ExpedientesBindingSource
        '
        Me.ExpedientesBindingSource.DataMember = "expedientes"
        Me.ExpedientesBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'Juzgados2023DataSet
        '
        Me.Juzgados2023DataSet.DataSetName = "juzgados2023DataSet"
        Me.Juzgados2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExpedientesTableAdapter
        '
        Me.ExpedientesTableAdapter.ClearBeforeFill = True
        '
        'desde
        '
        Me.desde.Location = New System.Drawing.Point(12, 200)
        Me.desde.Name = "desde"
        Me.desde.Size = New System.Drawing.Size(100, 20)
        Me.desde.TabIndex = 1
        '
        'hasta
        '
        Me.hasta.Location = New System.Drawing.Point(153, 200)
        Me.hasta.Name = "hasta"
        Me.hasta.Size = New System.Drawing.Size(100, 20)
        Me.hasta.TabIndex = 2
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(280, 200)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(75, 23)
        Me.buscar.TabIndex = 3
        Me.buscar.Text = "buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'rpt
        '
        Me.rpt.Location = New System.Drawing.Point(280, 249)
        Me.rpt.Name = "rpt"
        Me.rpt.Size = New System.Drawing.Size(75, 23)
        Me.rpt.TabIndex = 4
        Me.rpt.Text = "reporte"
        Me.rpt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha Hasta"
        '
        'Expedientesxfecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rpt)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.hasta)
        Me.Controls.Add(Me.desde)
        Me.Controls.Add(Me.dgvexp)
        Me.Name = "Expedientesxfecha"
        Me.Text = "Expedientesxfecha"
        CType(Me.dgvexp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpedientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvexp As DataGridView
    Friend WithEvents Juzgados2023DataSet As juzgados2023DataSet
    Friend WithEvents ExpedientesBindingSource As BindingSource
    Friend WithEvents ExpedientesTableAdapter As juzgados2023DataSetTableAdapters.expedientesTableAdapter
    Friend WithEvents cod_exp As DataGridViewTextBoxColumn
    Friend WithEvents nombre_exp As DataGridViewTextBoxColumn
    Friend WithEvents fecha_inicio As DataGridViewTextBoxColumn
    Friend WithEvents caratula As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents juicio As DataGridViewTextBoxColumn
    Friend WithEvents juzgado As DataGridViewTextBoxColumn
    Friend WithEvents desde As TextBox
    Friend WithEvents hasta As TextBox
    Friend WithEvents buscar As Button
    Friend WithEvents rpt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
