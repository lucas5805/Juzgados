<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expedientes
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
        Me.ExpedientesTableAdapter1 = New Juzgados2023.juzgados2023DataSetTableAdapters.expedientesTableAdapter()
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
        Me.listo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cetxt = New System.Windows.Forms.TextBox()
        Me.netxt = New System.Windows.Forms.TextBox()
        Me.fitxt = New System.Windows.Forms.TextBox()
        Me.ctxt = New System.Windows.Forms.TextBox()
        Me.estxt = New System.Windows.Forms.ComboBox()
        Me.EstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.jtxt = New System.Windows.Forms.ComboBox()
        Me.JuiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.juztxt = New System.Windows.Forms.ComboBox()
        Me.JuzgadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadosTableAdapter = New Juzgados2023.juzgados2023DataSetTableAdapters.estadosTableAdapter()
        Me.JuiciosTableAdapter = New Juzgados2023.juzgados2023DataSetTableAdapters.juiciosTableAdapter()
        Me.JuzgadosTableAdapter = New Juzgados2023.juzgados2023DataSetTableAdapters.juzgadosTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvexp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpedientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuzgadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExpedientesTableAdapter1
        '
        Me.ExpedientesTableAdapter1.ClearBeforeFill = True
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
        Me.cod_exp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cod_exp.DataPropertyName = "cod_exp"
        Me.cod_exp.HeaderText = "cod_exp"
        Me.cod_exp.Name = "cod_exp"
        Me.cod_exp.ReadOnly = True
        Me.cod_exp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cod_exp.Width = 73
        '
        'nombre_exp
        '
        Me.nombre_exp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.nombre_exp.DataPropertyName = "nombre_exp"
        Me.nombre_exp.HeaderText = "nombre_exp"
        Me.nombre_exp.Name = "nombre_exp"
        Me.nombre_exp.ReadOnly = True
        Me.nombre_exp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nombre_exp.Width = 90
        '
        'fecha_inicio
        '
        Me.fecha_inicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha_inicio.DataPropertyName = "fecha_inicio"
        Me.fecha_inicio.HeaderText = "fecha_inicio"
        Me.fecha_inicio.Name = "fecha_inicio"
        Me.fecha_inicio.ReadOnly = True
        Me.fecha_inicio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fecha_inicio.Width = 89
        '
        'caratula
        '
        Me.caratula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.caratula.DataPropertyName = "caratula"
        Me.caratula.HeaderText = "caratula"
        Me.caratula.Name = "caratula"
        Me.caratula.ReadOnly = True
        Me.caratula.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.caratula.Width = 70
        '
        'estado
        '
        Me.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.estado.Width = 64
        '
        'juicio
        '
        Me.juicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.juicio.DataPropertyName = "juicio"
        Me.juicio.HeaderText = "juicio"
        Me.juicio.Name = "juicio"
        Me.juicio.ReadOnly = True
        Me.juicio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.juicio.Width = 56
        '
        'juzgado
        '
        Me.juzgado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.juzgado.DataPropertyName = "juzgado"
        Me.juzgado.HeaderText = "juzgado"
        Me.juzgado.Name = "juzgado"
        Me.juzgado.ReadOnly = True
        Me.juzgado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.juzgado.Width = 69
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
        'listo
        '
        Me.listo.Location = New System.Drawing.Point(335, 336)
        Me.listo.Name = "listo"
        Me.listo.Size = New System.Drawing.Size(75, 23)
        Me.listo.TabIndex = 1
        Me.listo.Text = "Button1"
        Me.listo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Juzgados2023.My.Resources.Resources.plus
        Me.PictureBox1.Location = New System.Drawing.Point(274, 280)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Juzgados2023.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.PictureBox2.Location = New System.Drawing.Point(345, 280)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Juzgados2023.My.Resources.Resources.rounded_remove_button
        Me.PictureBox3.Location = New System.Drawing.Point(424, 280)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'cetxt
        '
        Me.cetxt.Location = New System.Drawing.Point(168, 205)
        Me.cetxt.Name = "cetxt"
        Me.cetxt.Size = New System.Drawing.Size(100, 20)
        Me.cetxt.TabIndex = 5
        '
        'netxt
        '
        Me.netxt.Location = New System.Drawing.Point(274, 205)
        Me.netxt.Name = "netxt"
        Me.netxt.Size = New System.Drawing.Size(100, 20)
        Me.netxt.TabIndex = 6
        '
        'fitxt
        '
        Me.fitxt.Location = New System.Drawing.Point(380, 205)
        Me.fitxt.Name = "fitxt"
        Me.fitxt.Size = New System.Drawing.Size(100, 20)
        Me.fitxt.TabIndex = 7
        '
        'ctxt
        '
        Me.ctxt.Location = New System.Drawing.Point(486, 205)
        Me.ctxt.Name = "ctxt"
        Me.ctxt.Size = New System.Drawing.Size(105, 20)
        Me.ctxt.TabIndex = 8
        '
        'estxt
        '
        Me.estxt.DataSource = Me.EstadosBindingSource
        Me.estxt.DisplayMember = "descripcion"
        Me.estxt.FormattingEnabled = True
        Me.estxt.Location = New System.Drawing.Point(219, 244)
        Me.estxt.Name = "estxt"
        Me.estxt.Size = New System.Drawing.Size(100, 21)
        Me.estxt.TabIndex = 12
        Me.estxt.ValueMember = "descripcion"
        '
        'EstadosBindingSource
        '
        Me.EstadosBindingSource.DataMember = "estados"
        Me.EstadosBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'jtxt
        '
        Me.jtxt.DataSource = Me.JuiciosBindingSource
        Me.jtxt.DisplayMember = "desc_juicio"
        Me.jtxt.FormattingEnabled = True
        Me.jtxt.Location = New System.Drawing.Point(325, 244)
        Me.jtxt.Name = "jtxt"
        Me.jtxt.Size = New System.Drawing.Size(100, 21)
        Me.jtxt.TabIndex = 13
        Me.jtxt.ValueMember = "desc_juicio"
        '
        'JuiciosBindingSource
        '
        Me.JuiciosBindingSource.DataMember = "juicios"
        Me.JuiciosBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'juztxt
        '
        Me.juztxt.DataSource = Me.JuzgadosBindingSource
        Me.juztxt.DisplayMember = "nombre_juzgado"
        Me.juztxt.FormattingEnabled = True
        Me.juztxt.Location = New System.Drawing.Point(431, 244)
        Me.juztxt.Name = "juztxt"
        Me.juztxt.Size = New System.Drawing.Size(100, 21)
        Me.juztxt.TabIndex = 14
        Me.juztxt.ValueMember = "nombre_juzgado"
        '
        'JuzgadosBindingSource
        '
        Me.JuzgadosBindingSource.DataMember = "juzgados"
        Me.JuzgadosBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'EstadosTableAdapter
        '
        Me.EstadosTableAdapter.ClearBeforeFill = True
        '
        'JuiciosTableAdapter
        '
        Me.JuiciosTableAdapter.ClearBeforeFill = True
        '
        'JuzgadosTableAdapter
        '
        Me.JuzgadosTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(684, 289)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(694, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Codigo Exp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(377, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Fecha inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(483, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Caratula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(322, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Juicio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(428, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Juzgado"
        '
        'Expedientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.juztxt)
        Me.Controls.Add(Me.jtxt)
        Me.Controls.Add(Me.estxt)
        Me.Controls.Add(Me.ctxt)
        Me.Controls.Add(Me.fitxt)
        Me.Controls.Add(Me.netxt)
        Me.Controls.Add(Me.cetxt)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.listo)
        Me.Controls.Add(Me.dgvexp)
        Me.Name = "Expedientes"
        Me.Text = "Expedientes"
        CType(Me.dgvexp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpedientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuzgadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExpedientesTableAdapter1 As juzgados2023DataSetTableAdapters.expedientesTableAdapter
    Friend WithEvents dgvexp As DataGridView
    Friend WithEvents ExpedientesBindingSource As BindingSource
    Friend WithEvents Juzgados2023DataSet As juzgados2023DataSet
    Friend WithEvents listo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cetxt As TextBox
    Friend WithEvents netxt As TextBox
    Friend WithEvents fitxt As TextBox
    Friend WithEvents ctxt As TextBox
    Friend WithEvents estxt As ComboBox
    Friend WithEvents jtxt As ComboBox
    Friend WithEvents juztxt As ComboBox
    Friend WithEvents EstadosBindingSource As BindingSource
    Friend WithEvents EstadosTableAdapter As juzgados2023DataSetTableAdapters.estadosTableAdapter
    Friend WithEvents JuiciosBindingSource As BindingSource
    Friend WithEvents JuiciosTableAdapter As juzgados2023DataSetTableAdapters.juiciosTableAdapter
    Friend WithEvents JuzgadosBindingSource As BindingSource
    Friend WithEvents JuzgadosTableAdapter As juzgados2023DataSetTableAdapters.juzgadosTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cod_exp As DataGridViewTextBoxColumn
    Friend WithEvents nombre_exp As DataGridViewTextBoxColumn
    Friend WithEvents fecha_inicio As DataGridViewTextBoxColumn
    Friend WithEvents caratula As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents juicio As DataGridViewTextBoxColumn
    Friend WithEvents juzgado As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
