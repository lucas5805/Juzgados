<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estados
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
        Me.EstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Juzgados2023DataSet = New Juzgados2023.juzgados2023DataSet()
        Me.EstadosTableAdapter1 = New Juzgados2023.juzgados2023DataSetTableAdapters.estadosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cetxt = New System.Windows.Forms.TextBox()
        Me.dtxt = New System.Windows.Forms.TextBox()
        Me.dgvest = New System.Windows.Forms.DataGridView()
        Me.cod_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EstadosBindingSource
        '
        Me.EstadosBindingSource.DataMember = "estados"
        Me.EstadosBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'Juzgados2023DataSet
        '
        Me.Juzgados2023DataSet.DataSetName = "juzgados2023DataSet"
        Me.Juzgados2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadosTableAdapter1
        '
        Me.EstadosTableAdapter1.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Juzgados2023.My.Resources.Resources.rounded_remove_button
        Me.PictureBox3.Location = New System.Drawing.Point(168, 228)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Juzgados2023.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.PictureBox2.Location = New System.Drawing.Point(101, 228)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Juzgados2023.My.Resources.Resources.plus
        Me.PictureBox1.Location = New System.Drawing.Point(34, 228)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cetxt
        '
        Me.cetxt.Location = New System.Drawing.Point(12, 185)
        Me.cetxt.Name = "cetxt"
        Me.cetxt.Size = New System.Drawing.Size(100, 20)
        Me.cetxt.TabIndex = 7
        '
        'dtxt
        '
        Me.dtxt.Location = New System.Drawing.Point(155, 185)
        Me.dtxt.Name = "dtxt"
        Me.dtxt.Size = New System.Drawing.Size(100, 20)
        Me.dtxt.TabIndex = 8
        '
        'dgvest
        '
        Me.dgvest.AllowUserToAddRows = False
        Me.dgvest.AllowUserToDeleteRows = False
        Me.dgvest.AutoGenerateColumns = False
        Me.dgvest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_estado, Me.descripcion})
        Me.dgvest.DataSource = Me.EstadosBindingSource
        Me.dgvest.Location = New System.Drawing.Point(12, 12)
        Me.dgvest.Name = "dgvest"
        Me.dgvest.ReadOnly = True
        Me.dgvest.Size = New System.Drawing.Size(240, 150)
        Me.dgvest.TabIndex = 9
        '
        'cod_estado
        '
        Me.cod_estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cod_estado.DataPropertyName = "cod_estado"
        Me.cod_estado.HeaderText = "cod_estado"
        Me.cod_estado.Name = "cod_estado"
        Me.cod_estado.ReadOnly = True
        Me.cod_estado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cod_estado.Width = 88
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.descripcion.Width = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Descripcion"
        '
        'Estados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 332)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvest)
        Me.Controls.Add(Me.dtxt)
        Me.Controls.Add(Me.cetxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Estados"
        Me.Text = "Estados"
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EstadosBindingSource As BindingSource
    Friend WithEvents Juzgados2023DataSet As juzgados2023DataSet
    Friend WithEvents EstadosTableAdapter1 As juzgados2023DataSetTableAdapters.estadosTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cetxt As TextBox
    Friend WithEvents dtxt As TextBox
    Friend WithEvents dgvest As DataGridView
    Friend WithEvents cod_estado As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
