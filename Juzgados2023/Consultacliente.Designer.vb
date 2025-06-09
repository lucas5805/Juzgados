<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultacliente
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cod_cliente2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_exp2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteexpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Juzgados2023DataSet = New Juzgados2023.juzgados2023DataSet()
        Me.Cliente_expTableAdapter1 = New Juzgados2023.juzgados2023DataSetTableAdapters.cliente_expTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.refrescar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteexpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_cliente2, Me.nom_apellido, Me.cod_exp2, Me.nom_exp})
        Me.dgv.DataSource = Me.ClienteexpBindingSource
        Me.dgv.Location = New System.Drawing.Point(12, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(440, 150)
        Me.dgv.TabIndex = 0
        '
        'cod_cliente2
        '
        Me.cod_cliente2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cod_cliente2.DataPropertyName = "cod_cliente2"
        Me.cod_cliente2.HeaderText = "cod_cliente2"
        Me.cod_cliente2.Name = "cod_cliente2"
        Me.cod_cliente2.ReadOnly = True
        Me.cod_cliente2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cod_cliente2.Width = 93
        '
        'nom_apellido
        '
        Me.nom_apellido.DataPropertyName = "nom_apellido"
        Me.nom_apellido.HeaderText = "nom_apellido"
        Me.nom_apellido.Name = "nom_apellido"
        Me.nom_apellido.ReadOnly = True
        '
        'cod_exp2
        '
        Me.cod_exp2.DataPropertyName = "cod_exp2"
        Me.cod_exp2.HeaderText = "cod_exp2"
        Me.cod_exp2.Name = "cod_exp2"
        Me.cod_exp2.ReadOnly = True
        '
        'nom_exp
        '
        Me.nom_exp.DataPropertyName = "nom_exp"
        Me.nom_exp.HeaderText = "nom_exp"
        Me.nom_exp.Name = "nom_exp"
        Me.nom_exp.ReadOnly = True
        '
        'ClienteexpBindingSource
        '
        Me.ClienteexpBindingSource.DataMember = "cliente_exp"
        Me.ClienteexpBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'Juzgados2023DataSet
        '
        Me.Juzgados2023DataSet.DataSetName = "juzgados2023DataSet"
        Me.Juzgados2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cliente_expTableAdapter1
        '
        Me.Cliente_expTableAdapter1.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(43, 191)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(57, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'refrescar
        '
        Me.refrescar.Location = New System.Drawing.Point(269, 191)
        Me.refrescar.Name = "refrescar"
        Me.refrescar.Size = New System.Drawing.Size(75, 23)
        Me.refrescar.TabIndex = 4
        Me.refrescar.Text = "refrescar"
        Me.refrescar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cliente"
        '
        'Consultacliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.refrescar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Consultacliente"
        Me.Text = "Consultacliente"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteexpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents ClienteexpBindingSource As BindingSource
    Friend WithEvents Juzgados2023DataSet As juzgados2023DataSet
    Friend WithEvents Cliente_expTableAdapter1 As juzgados2023DataSetTableAdapters.cliente_expTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents refrescar As Button
    Friend WithEvents cod_cliente2 As DataGridViewTextBoxColumn
    Friend WithEvents nom_apellido As DataGridViewTextBoxColumn
    Friend WithEvents cod_exp2 As DataGridViewTextBoxColumn
    Friend WithEvents nom_exp As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
