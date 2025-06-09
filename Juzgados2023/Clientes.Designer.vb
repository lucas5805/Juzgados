<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.ClientesTableAdapter1 = New Juzgados2023.juzgados2023DataSetTableAdapters.clientesTableAdapter()
        Me.dgvcli = New System.Windows.Forms.DataGridView()
        Me.cod_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_nro_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel_cel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Juzgados2023DataSet = New Juzgados2023.juzgados2023DataSet()
        Me.cctxt = New System.Windows.Forms.TextBox()
        Me.doctxt = New System.Windows.Forms.TextBox()
        Me.natxt = New System.Windows.Forms.TextBox()
        Me.fntxt = New System.Windows.Forms.TextBox()
        Me.dtxt = New System.Windows.Forms.TextBox()
        Me.tctxt = New System.Windows.Forms.TextBox()
        Me.ltxt = New System.Windows.Forms.ComboBox()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.listo = New System.Windows.Forms.Button()
        Me.LocalidadesTableAdapter = New Juzgados2023.juzgados2023DataSetTableAdapters.localidadesTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvcli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'dgvcli
        '
        Me.dgvcli.AllowUserToAddRows = False
        Me.dgvcli.AllowUserToDeleteRows = False
        Me.dgvcli.AutoGenerateColumns = False
        Me.dgvcli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_cliente, Me.tipo_nro_doc, Me.nom_apellido, Me.domicilio, Me.tel_cel, Me.fecha_nac, Me.localidad})
        Me.dgvcli.DataSource = Me.ClientesBindingSource
        Me.dgvcli.Location = New System.Drawing.Point(12, 26)
        Me.dgvcli.Name = "dgvcli"
        Me.dgvcli.ReadOnly = True
        Me.dgvcli.Size = New System.Drawing.Size(745, 150)
        Me.dgvcli.TabIndex = 0
        '
        'cod_cliente
        '
        Me.cod_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cod_cliente.DataPropertyName = "cod_cliente"
        Me.cod_cliente.HeaderText = "cod_cliente"
        Me.cod_cliente.Name = "cod_cliente"
        Me.cod_cliente.ReadOnly = True
        Me.cod_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cod_cliente.Width = 87
        '
        'tipo_nro_doc
        '
        Me.tipo_nro_doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tipo_nro_doc.DataPropertyName = "tipo_nro_doc"
        Me.tipo_nro_doc.HeaderText = "tipo_nro_doc"
        Me.tipo_nro_doc.Name = "tipo_nro_doc"
        Me.tipo_nro_doc.ReadOnly = True
        Me.tipo_nro_doc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tipo_nro_doc.Width = 94
        '
        'nom_apellido
        '
        Me.nom_apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.nom_apellido.DataPropertyName = "nom_apellido"
        Me.nom_apellido.HeaderText = "nom_apellido"
        Me.nom_apellido.Name = "nom_apellido"
        Me.nom_apellido.ReadOnly = True
        Me.nom_apellido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nom_apellido.Width = 94
        '
        'domicilio
        '
        Me.domicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.domicilio.DataPropertyName = "domicilio"
        Me.domicilio.HeaderText = "domicilio"
        Me.domicilio.Name = "domicilio"
        Me.domicilio.ReadOnly = True
        Me.domicilio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.domicilio.Width = 72
        '
        'tel_cel
        '
        Me.tel_cel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tel_cel.DataPropertyName = "tel_cel"
        Me.tel_cel.HeaderText = "tel_cel"
        Me.tel_cel.Name = "tel_cel"
        Me.tel_cel.ReadOnly = True
        Me.tel_cel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tel_cel.Width = 63
        '
        'fecha_nac
        '
        Me.fecha_nac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha_nac.DataPropertyName = "fecha_nac"
        Me.fecha_nac.HeaderText = "fecha_nac"
        Me.fecha_nac.Name = "fecha_nac"
        Me.fecha_nac.ReadOnly = True
        Me.fecha_nac.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fecha_nac.Width = 83
        '
        'localidad
        '
        Me.localidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.localidad.DataPropertyName = "localidad"
        Me.localidad.HeaderText = "localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        Me.localidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.localidad.Width = 74
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'Juzgados2023DataSet
        '
        Me.Juzgados2023DataSet.DataSetName = "juzgados2023DataSet"
        Me.Juzgados2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cctxt
        '
        Me.cctxt.Location = New System.Drawing.Point(164, 207)
        Me.cctxt.Name = "cctxt"
        Me.cctxt.Size = New System.Drawing.Size(100, 20)
        Me.cctxt.TabIndex = 1
        '
        'doctxt
        '
        Me.doctxt.Location = New System.Drawing.Point(270, 207)
        Me.doctxt.Name = "doctxt"
        Me.doctxt.Size = New System.Drawing.Size(100, 20)
        Me.doctxt.TabIndex = 2
        '
        'natxt
        '
        Me.natxt.Location = New System.Drawing.Point(376, 207)
        Me.natxt.Name = "natxt"
        Me.natxt.Size = New System.Drawing.Size(100, 20)
        Me.natxt.TabIndex = 3
        '
        'fntxt
        '
        Me.fntxt.Location = New System.Drawing.Point(341, 244)
        Me.fntxt.Name = "fntxt"
        Me.fntxt.Size = New System.Drawing.Size(100, 20)
        Me.fntxt.TabIndex = 4
        '
        'dtxt
        '
        Me.dtxt.Location = New System.Drawing.Point(482, 207)
        Me.dtxt.Name = "dtxt"
        Me.dtxt.Size = New System.Drawing.Size(100, 20)
        Me.dtxt.TabIndex = 5
        '
        'tctxt
        '
        Me.tctxt.Location = New System.Drawing.Point(235, 245)
        Me.tctxt.Name = "tctxt"
        Me.tctxt.Size = New System.Drawing.Size(100, 20)
        Me.tctxt.TabIndex = 6
        '
        'ltxt
        '
        Me.ltxt.DataSource = Me.LocalidadesBindingSource
        Me.ltxt.DisplayMember = "localidades"
        Me.ltxt.FormattingEnabled = True
        Me.ltxt.Location = New System.Drawing.Point(447, 244)
        Me.ltxt.Name = "ltxt"
        Me.ltxt.Size = New System.Drawing.Size(100, 21)
        Me.ltxt.TabIndex = 7
        Me.ltxt.ValueMember = "localidades"
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "localidades"
        Me.LocalidadesBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Juzgados2023.My.Resources.Resources.plus
        Me.PictureBox1.Location = New System.Drawing.Point(254, 271)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Juzgados2023.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.PictureBox2.Location = New System.Drawing.Point(363, 271)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Juzgados2023.My.Resources.Resources.rounded_remove_button
        Me.PictureBox3.Location = New System.Drawing.Point(474, 271)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(57, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'listo
        '
        Me.listo.Location = New System.Drawing.Point(288, 327)
        Me.listo.Name = "listo"
        Me.listo.Size = New System.Drawing.Size(100, 23)
        Me.listo.TabIndex = 11
        Me.listo.Text = "Ingresar"
        Me.listo.UseVisualStyleBackColor = True
        '
        'LocalidadesTableAdapter
        '
        Me.LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(394, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Cod. Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(376, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre y Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(508, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Domicilio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(262, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(338, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Fecha de nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(471, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Localidad"
        '
        'Clientes
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
        Me.Controls.Add(Me.listo)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ltxt)
        Me.Controls.Add(Me.tctxt)
        Me.Controls.Add(Me.dtxt)
        Me.Controls.Add(Me.fntxt)
        Me.Controls.Add(Me.natxt)
        Me.Controls.Add(Me.doctxt)
        Me.Controls.Add(Me.cctxt)
        Me.Controls.Add(Me.dgvcli)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.dgvcli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientesTableAdapter1 As juzgados2023DataSetTableAdapters.clientesTableAdapter
    Friend WithEvents dgvcli As DataGridView
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents Juzgados2023DataSet As juzgados2023DataSet
    Friend WithEvents cctxt As TextBox
    Friend WithEvents doctxt As TextBox
    Friend WithEvents natxt As TextBox
    Friend WithEvents fntxt As TextBox
    Friend WithEvents dtxt As TextBox
    Friend WithEvents tctxt As TextBox
    Friend WithEvents ltxt As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents listo As Button
    Friend WithEvents LocalidadesBindingSource As BindingSource
    Friend WithEvents LocalidadesTableAdapter As juzgados2023DataSetTableAdapters.localidadesTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents cod_cliente As DataGridViewTextBoxColumn
    Friend WithEvents tipo_nro_doc As DataGridViewTextBoxColumn
    Friend WithEvents nom_apellido As DataGridViewTextBoxColumn
    Friend WithEvents domicilio As DataGridViewTextBoxColumn
    Friend WithEvents tel_cel As DataGridViewTextBoxColumn
    Friend WithEvents fecha_nac As DataGridViewTextBoxColumn
    Friend WithEvents localidad As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
