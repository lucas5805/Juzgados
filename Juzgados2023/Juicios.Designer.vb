<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juicios
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
        Me.dgvjuicios = New System.Windows.Forms.DataGridView()
        Me.cod_juicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_juicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JuiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Juzgados2023DataSet = New Juzgados2023.juzgados2023DataSet()
        Me.JuiciosTableAdapter1 = New Juzgados2023.juzgados2023DataSetTableAdapters.juiciosTableAdapter()
        Me.listo = New System.Windows.Forms.Button()
        Me.cjtxt = New System.Windows.Forms.TextBox()
        Me.dtxt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvjuicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvjuicios
        '
        Me.dgvjuicios.AllowUserToAddRows = False
        Me.dgvjuicios.AllowUserToDeleteRows = False
        Me.dgvjuicios.AutoGenerateColumns = False
        Me.dgvjuicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvjuicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_juicio, Me.desc_juicio})
        Me.dgvjuicios.DataSource = Me.JuiciosBindingSource
        Me.dgvjuicios.Location = New System.Drawing.Point(12, 12)
        Me.dgvjuicios.Name = "dgvjuicios"
        Me.dgvjuicios.ReadOnly = True
        Me.dgvjuicios.Size = New System.Drawing.Size(242, 150)
        Me.dgvjuicios.TabIndex = 0
        '
        'cod_juicio
        '
        Me.cod_juicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cod_juicio.DataPropertyName = "cod_juicio"
        Me.cod_juicio.HeaderText = "cod_juicio"
        Me.cod_juicio.Name = "cod_juicio"
        Me.cod_juicio.ReadOnly = True
        Me.cod_juicio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cod_juicio.Width = 80
        '
        'desc_juicio
        '
        Me.desc_juicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.desc_juicio.DataPropertyName = "desc_juicio"
        Me.desc_juicio.HeaderText = "desc_juicio"
        Me.desc_juicio.Name = "desc_juicio"
        Me.desc_juicio.ReadOnly = True
        Me.desc_juicio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.desc_juicio.Width = 85
        '
        'JuiciosBindingSource
        '
        Me.JuiciosBindingSource.DataMember = "juicios"
        Me.JuiciosBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'Juzgados2023DataSet
        '
        Me.Juzgados2023DataSet.DataSetName = "juzgados2023DataSet"
        Me.Juzgados2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JuiciosTableAdapter1
        '
        Me.JuiciosTableAdapter1.ClearBeforeFill = True
        '
        'listo
        '
        Me.listo.Location = New System.Drawing.Point(94, 206)
        Me.listo.Name = "listo"
        Me.listo.Size = New System.Drawing.Size(75, 23)
        Me.listo.TabIndex = 1
        Me.listo.Text = "Ingresar"
        Me.listo.UseVisualStyleBackColor = True
        '
        'cjtxt
        '
        Me.cjtxt.Location = New System.Drawing.Point(12, 180)
        Me.cjtxt.Name = "cjtxt"
        Me.cjtxt.Size = New System.Drawing.Size(100, 20)
        Me.cjtxt.TabIndex = 2
        '
        'dtxt
        '
        Me.dtxt.Location = New System.Drawing.Point(154, 180)
        Me.dtxt.Name = "dtxt"
        Me.dtxt.Size = New System.Drawing.Size(100, 20)
        Me.dtxt.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Juzgados2023.My.Resources.Resources.plus
        Me.PictureBox1.Location = New System.Drawing.Point(12, 235)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Juzgados2023.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.PictureBox2.Location = New System.Drawing.Point(107, 235)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Juzgados2023.My.Resources.Resources.rounded_remove_button
        Me.PictureBox3.Location = New System.Drawing.Point(203, 235)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripcion"
        '
        'Juicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 311)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtxt)
        Me.Controls.Add(Me.cjtxt)
        Me.Controls.Add(Me.listo)
        Me.Controls.Add(Me.dgvjuicios)
        Me.Name = "Juicios"
        Me.Text = "Juicios"
        CType(Me.dgvjuicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvjuicios As DataGridView
    Friend WithEvents JuiciosBindingSource As BindingSource
    Friend WithEvents Juzgados2023DataSet As juzgados2023DataSet
    Friend WithEvents JuiciosTableAdapter1 As juzgados2023DataSetTableAdapters.juiciosTableAdapter
    Friend WithEvents listo As Button
    Friend WithEvents cjtxt As TextBox
    Friend WithEvents dtxt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cod_juicio As DataGridViewTextBoxColumn
    Friend WithEvents desc_juicio As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
