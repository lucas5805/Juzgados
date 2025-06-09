<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes_expedientes
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
        Me.dgvcliexp = New System.Windows.Forms.DataGridView()
        Me.Codcliente2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomapellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codexp2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomexpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteexpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Juzgados2023DataSet = New Juzgados2023.juzgados2023DataSet()
        Me.Cliente_expTableAdapter = New Juzgados2023.juzgados2023DataSetTableAdapters.cliente_expTableAdapter()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.expediente = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableAdapterManager1 = New Juzgados2023.juzgados2023DataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvcliexp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteexpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvcliexp
        '
        Me.dgvcliexp.AllowUserToAddRows = False
        Me.dgvcliexp.AllowUserToDeleteRows = False
        Me.dgvcliexp.AutoGenerateColumns = False
        Me.dgvcliexp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcliexp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codcliente2DataGridViewTextBoxColumn, Me.NomapellidoDataGridViewTextBoxColumn, Me.Codexp2DataGridViewTextBoxColumn, Me.NomexpDataGridViewTextBoxColumn})
        Me.dgvcliexp.DataSource = Me.ClienteexpBindingSource
        Me.dgvcliexp.Location = New System.Drawing.Point(12, 12)
        Me.dgvcliexp.Name = "dgvcliexp"
        Me.dgvcliexp.ReadOnly = True
        Me.dgvcliexp.Size = New System.Drawing.Size(444, 150)
        Me.dgvcliexp.TabIndex = 0
        '
        'Codcliente2DataGridViewTextBoxColumn
        '
        Me.Codcliente2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Codcliente2DataGridViewTextBoxColumn.DataPropertyName = "cod_cliente2"
        Me.Codcliente2DataGridViewTextBoxColumn.HeaderText = "cod_cliente2"
        Me.Codcliente2DataGridViewTextBoxColumn.Name = "Codcliente2DataGridViewTextBoxColumn"
        Me.Codcliente2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Codcliente2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Codcliente2DataGridViewTextBoxColumn.Width = 93
        '
        'NomapellidoDataGridViewTextBoxColumn
        '
        Me.NomapellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NomapellidoDataGridViewTextBoxColumn.DataPropertyName = "nom_apellido"
        Me.NomapellidoDataGridViewTextBoxColumn.HeaderText = "nom_apellido"
        Me.NomapellidoDataGridViewTextBoxColumn.Name = "NomapellidoDataGridViewTextBoxColumn"
        Me.NomapellidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomapellidoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NomapellidoDataGridViewTextBoxColumn.Width = 94
        '
        'Codexp2DataGridViewTextBoxColumn
        '
        Me.Codexp2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Codexp2DataGridViewTextBoxColumn.DataPropertyName = "cod_exp2"
        Me.Codexp2DataGridViewTextBoxColumn.HeaderText = "cod_exp2"
        Me.Codexp2DataGridViewTextBoxColumn.Name = "Codexp2DataGridViewTextBoxColumn"
        Me.Codexp2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Codexp2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Codexp2DataGridViewTextBoxColumn.Width = 79
        '
        'NomexpDataGridViewTextBoxColumn
        '
        Me.NomexpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NomexpDataGridViewTextBoxColumn.DataPropertyName = "nom_exp"
        Me.NomexpDataGridViewTextBoxColumn.HeaderText = "nom_exp"
        Me.NomexpDataGridViewTextBoxColumn.Name = "NomexpDataGridViewTextBoxColumn"
        Me.NomexpDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomexpDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NomexpDataGridViewTextBoxColumn.Width = 75
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
        'Cliente_expTableAdapter
        '
        Me.Cliente_expTableAdapter.ClearBeforeFill = True
        '
        'cliente
        '
        Me.cliente.FormattingEnabled = True
        Me.cliente.Location = New System.Drawing.Point(12, 205)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(121, 21)
        Me.cliente.TabIndex = 1
        '
        'expediente
        '
        Me.expediente.FormattingEnabled = True
        Me.expediente.Location = New System.Drawing.Point(196, 205)
        Me.expediente.Name = "expediente"
        Me.expediente.Size = New System.Drawing.Size(121, 21)
        Me.expediente.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(122, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "asociar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.cliente_expTableAdapter = Me.Cliente_expTableAdapter
        Me.TableAdapterManager1.clientesTableAdapter = Nothing
        Me.TableAdapterManager1.estadosTableAdapter = Nothing
        Me.TableAdapterManager1.expedientesTableAdapter = Nothing
        Me.TableAdapterManager1.juiciosTableAdapter = Nothing
        Me.TableAdapterManager1.juzgadosTableAdapter = Nothing
        Me.TableAdapterManager1.localidadesTableAdapter = Nothing
        Me.TableAdapterManager1.loginTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Juzgados2023.juzgados2023DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Expediente"
        '
        'Clientes_expedientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.expediente)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.dgvcliexp)
        Me.Name = "Clientes_expedientes"
        Me.Text = "Clientes_expedientes"
        CType(Me.dgvcliexp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteexpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvcliexp As DataGridView
    Friend WithEvents Juzgados2023DataSet As juzgados2023DataSet
    Friend WithEvents ClienteexpBindingSource As BindingSource
    Friend WithEvents Cliente_expTableAdapter As juzgados2023DataSetTableAdapters.cliente_expTableAdapter
    Friend WithEvents cod_cliente2 As DataGridViewTextBoxColumn
    Friend WithEvents nom_apellido As DataGridViewTextBoxColumn
    Friend WithEvents cod_exp2 As DataGridViewTextBoxColumn
    Friend WithEvents nom_exp As DataGridViewTextBoxColumn
    Friend WithEvents cliente As ComboBox
    Friend WithEvents expediente As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TableAdapterManager1 As juzgados2023DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Codcliente2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomapellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Codexp2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomexpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
