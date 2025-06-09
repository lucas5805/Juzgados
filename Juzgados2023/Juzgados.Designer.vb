<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juzgados
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
        Me.dgvjuz = New System.Windows.Forms.DataGridView()
        Me.cod_juzgado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_juzgado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_juez = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.secretario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_alta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JuzgadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Juzgados2023DataSet = New Juzgados2023.juzgados2023DataSet()
        Me.JuzgadosTableAdapter = New Juzgados2023.juzgados2023DataSetTableAdapters.juzgadosTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cjtxt = New System.Windows.Forms.TextBox()
        Me.njtxt = New System.Windows.Forms.TextBox()
        Me.njutxt = New System.Windows.Forms.TextBox()
        Me.stxt = New System.Windows.Forms.TextBox()
        Me.ttxt = New System.Windows.Forms.TextBox()
        Me.fatxt = New System.Windows.Forms.TextBox()
        Me.Listo = New System.Windows.Forms.Button()
        Me.ltxt = New System.Windows.Forms.ComboBox()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadesTableAdapter = New Juzgados2023.juzgados2023DataSetTableAdapters.localidadesTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvjuz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuzgadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvjuz
        '
        Me.dgvjuz.AllowUserToAddRows = False
        Me.dgvjuz.AllowUserToDeleteRows = False
        Me.dgvjuz.AutoGenerateColumns = False
        Me.dgvjuz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvjuz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_juzgado, Me.nombre_juzgado, Me.Nombre_juez, Me.secretario, Me.telefono, Me.fecha_alta, Me.Localidad})
        Me.dgvjuz.DataSource = Me.JuzgadosBindingSource
        Me.dgvjuz.Location = New System.Drawing.Point(12, 12)
        Me.dgvjuz.Name = "dgvjuz"
        Me.dgvjuz.ReadOnly = True
        Me.dgvjuz.Size = New System.Drawing.Size(794, 150)
        Me.dgvjuz.TabIndex = 0
        '
        'cod_juzgado
        '
        Me.cod_juzgado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cod_juzgado.DataPropertyName = "cod_juzgado"
        Me.cod_juzgado.HeaderText = "cod_juzgado"
        Me.cod_juzgado.Name = "cod_juzgado"
        Me.cod_juzgado.ReadOnly = True
        Me.cod_juzgado.Width = 93
        '
        'nombre_juzgado
        '
        Me.nombre_juzgado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.nombre_juzgado.DataPropertyName = "nombre_juzgado"
        Me.nombre_juzgado.HeaderText = "nombre_juzgado"
        Me.nombre_juzgado.Name = "nombre_juzgado"
        Me.nombre_juzgado.ReadOnly = True
        Me.nombre_juzgado.Width = 110
        '
        'Nombre_juez
        '
        Me.Nombre_juez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nombre_juez.DataPropertyName = "nombre_juez"
        Me.Nombre_juez.HeaderText = "nombre_juez"
        Me.Nombre_juez.Name = "Nombre_juez"
        Me.Nombre_juez.ReadOnly = True
        Me.Nombre_juez.Width = 92
        '
        'secretario
        '
        Me.secretario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.secretario.DataPropertyName = "secretario"
        Me.secretario.HeaderText = "secretario"
        Me.secretario.Name = "secretario"
        Me.secretario.ReadOnly = True
        Me.secretario.Width = 78
        '
        'telefono
        '
        Me.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 70
        '
        'fecha_alta
        '
        Me.fecha_alta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha_alta.DataPropertyName = "fecha_alta"
        Me.fecha_alta.HeaderText = "fecha_alta"
        Me.fecha_alta.Name = "fecha_alta"
        Me.fecha_alta.ReadOnly = True
        Me.fecha_alta.Width = 82
        '
        'Localidad
        '
        Me.Localidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Localidad.DataPropertyName = "Localidad"
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        Me.Localidad.Width = 78
        '
        'JuzgadosBindingSource
        '
        Me.JuzgadosBindingSource.DataMember = "juzgados"
        Me.JuzgadosBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'Juzgados2023DataSet
        '
        Me.Juzgados2023DataSet.DataSetName = "juzgados2023DataSet"
        Me.Juzgados2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JuzgadosTableAdapter
        '
        Me.JuzgadosTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Juzgados2023.My.Resources.Resources.plus
        Me.PictureBox1.Location = New System.Drawing.Point(282, 279)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Juzgados2023.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.PictureBox2.Location = New System.Drawing.Point(365, 279)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Juzgados2023.My.Resources.Resources.rounded_remove_button
        Me.PictureBox3.Location = New System.Drawing.Point(447, 279)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'cjtxt
        '
        Me.cjtxt.Location = New System.Drawing.Point(158, 217)
        Me.cjtxt.Name = "cjtxt"
        Me.cjtxt.Size = New System.Drawing.Size(100, 20)
        Me.cjtxt.TabIndex = 4
        '
        'njtxt
        '
        Me.njtxt.Location = New System.Drawing.Point(276, 217)
        Me.njtxt.Name = "njtxt"
        Me.njtxt.Size = New System.Drawing.Size(100, 20)
        Me.njtxt.TabIndex = 5
        '
        'njutxt
        '
        Me.njutxt.Location = New System.Drawing.Point(399, 217)
        Me.njutxt.Name = "njutxt"
        Me.njutxt.Size = New System.Drawing.Size(100, 20)
        Me.njutxt.TabIndex = 6
        '
        'stxt
        '
        Me.stxt.Location = New System.Drawing.Point(517, 217)
        Me.stxt.Name = "stxt"
        Me.stxt.Size = New System.Drawing.Size(100, 20)
        Me.stxt.TabIndex = 7
        '
        'ttxt
        '
        Me.ttxt.Location = New System.Drawing.Point(224, 253)
        Me.ttxt.Name = "ttxt"
        Me.ttxt.Size = New System.Drawing.Size(100, 20)
        Me.ttxt.TabIndex = 8
        '
        'fatxt
        '
        Me.fatxt.Location = New System.Drawing.Point(340, 253)
        Me.fatxt.Name = "fatxt"
        Me.fatxt.Size = New System.Drawing.Size(100, 20)
        Me.fatxt.TabIndex = 9
        '
        'Listo
        '
        Me.Listo.Location = New System.Drawing.Point(311, 346)
        Me.Listo.Name = "Listo"
        Me.Listo.Size = New System.Drawing.Size(75, 23)
        Me.Listo.TabIndex = 11
        Me.Listo.Text = "Ingresar"
        Me.Listo.UseVisualStyleBackColor = True
        '
        'ltxt
        '
        Me.ltxt.DataSource = Me.LocalidadesBindingSource
        Me.ltxt.DisplayMember = "localidades"
        Me.ltxt.FormattingEnabled = True
        Me.ltxt.Location = New System.Drawing.Point(456, 253)
        Me.ltxt.Name = "ltxt"
        Me.ltxt.Size = New System.Drawing.Size(100, 21)
        Me.ltxt.TabIndex = 12
        Me.ltxt.ValueMember = "localidades"
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "localidades"
        Me.LocalidadesBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'LocalidadesTableAdapter
        '
        Me.LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(399, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Juez"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(517, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Secretario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Telefono Juzgado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(337, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha de alta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(453, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Localidad"
        '
        'Juzgados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ltxt)
        Me.Controls.Add(Me.Listo)
        Me.Controls.Add(Me.fatxt)
        Me.Controls.Add(Me.ttxt)
        Me.Controls.Add(Me.stxt)
        Me.Controls.Add(Me.njutxt)
        Me.Controls.Add(Me.njtxt)
        Me.Controls.Add(Me.cjtxt)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvjuz)
        Me.Name = "Juzgados"
        Me.Text = "Juzgados"
        CType(Me.dgvjuz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuzgadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvjuz As DataGridView
    Friend WithEvents Juzgados2023DataSet As juzgados2023DataSet
    Friend WithEvents JuzgadosBindingSource As BindingSource
    Friend WithEvents JuzgadosTableAdapter As juzgados2023DataSetTableAdapters.juzgadosTableAdapter
    Friend WithEvents cod_juzgado As DataGridViewTextBoxColumn
    Friend WithEvents nombre_juzgado As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_juez As DataGridViewTextBoxColumn
    Friend WithEvents secretario As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents fecha_alta As DataGridViewTextBoxColumn
    Friend WithEvents Localidad As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cjtxt As TextBox
    Friend WithEvents njtxt As TextBox
    Friend WithEvents njutxt As TextBox
    Friend WithEvents stxt As TextBox
    Friend WithEvents ttxt As TextBox
    Friend WithEvents fatxt As TextBox
    Friend WithEvents Listo As Button
    Friend WithEvents ltxt As ComboBox
    Friend WithEvents LocalidadesBindingSource As BindingSource
    Friend WithEvents LocalidadesTableAdapter As juzgados2023DataSetTableAdapters.localidadesTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
