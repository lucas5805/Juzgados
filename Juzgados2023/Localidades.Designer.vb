<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Localidades
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
        Me.dgvloc = New System.Windows.Forms.DataGridView()
        Me.cp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Juzgados2023DataSet = New Juzgados2023.juzgados2023DataSet()
        Me.listo = New System.Windows.Forms.Button()
        Me.cptxt = New System.Windows.Forms.TextBox()
        Me.localtxt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LocalidadesTableAdapter1 = New Juzgados2023.juzgados2023DataSetTableAdapters.localidadesTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.buscarcp = New System.Windows.Forms.Button()
        Me.buscarlocal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvloc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvloc
        '
        Me.dgvloc.AllowUserToAddRows = False
        Me.dgvloc.AllowUserToDeleteRows = False
        Me.dgvloc.AutoGenerateColumns = False
        Me.dgvloc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvloc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cp, Me.localidad})
        Me.dgvloc.DataSource = Me.LocalidadesBindingSource
        Me.dgvloc.Location = New System.Drawing.Point(12, 30)
        Me.dgvloc.Name = "dgvloc"
        Me.dgvloc.ReadOnly = True
        Me.dgvloc.Size = New System.Drawing.Size(240, 150)
        Me.dgvloc.TabIndex = 0
        '
        'cp
        '
        Me.cp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cp.DataPropertyName = "cp"
        Me.cp.HeaderText = "cp"
        Me.cp.Name = "cp"
        Me.cp.ReadOnly = True
        Me.cp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cp.Width = 44
        '
        'localidad
        '
        Me.localidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.localidad.DataPropertyName = "localidades"
        Me.localidad.HeaderText = "localidades"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        Me.localidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.localidad.Width = 85
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "localidades"
        Me.LocalidadesBindingSource.DataSource = Me.Juzgados2023DataSet
        '
        'Juzgados2023DataSet
        '
        Me.Juzgados2023DataSet.DataSetName = "juzgados2023DataSet"
        Me.Juzgados2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'listo
        '
        Me.listo.Location = New System.Drawing.Point(88, 315)
        Me.listo.Name = "listo"
        Me.listo.Size = New System.Drawing.Size(75, 23)
        Me.listo.TabIndex = 1
        Me.listo.Text = "Ingresar"
        Me.listo.UseVisualStyleBackColor = True
        '
        'cptxt
        '
        Me.cptxt.Location = New System.Drawing.Point(12, 203)
        Me.cptxt.Name = "cptxt"
        Me.cptxt.Size = New System.Drawing.Size(100, 20)
        Me.cptxt.TabIndex = 2
        '
        'localtxt
        '
        Me.localtxt.Location = New System.Drawing.Point(152, 203)
        Me.localtxt.Name = "localtxt"
        Me.localtxt.Size = New System.Drawing.Size(100, 20)
        Me.localtxt.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Juzgados2023.My.Resources.Resources.plus
        Me.PictureBox1.Location = New System.Drawing.Point(23, 245)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Juzgados2023.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.PictureBox2.Location = New System.Drawing.Point(99, 245)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Juzgados2023.My.Resources.Resources.rounded_remove_button
        Me.PictureBox3.Location = New System.Drawing.Point(180, 245)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'LocalidadesTableAdapter1
        '
        Me.LocalidadesTableAdapter1.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(443, 135)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(443, 175)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'buscarcp
        '
        Me.buscarcp.Location = New System.Drawing.Point(549, 133)
        Me.buscarcp.Name = "buscarcp"
        Me.buscarcp.Size = New System.Drawing.Size(75, 23)
        Me.buscarcp.TabIndex = 9
        Me.buscarcp.Text = "Buscar"
        Me.buscarcp.UseVisualStyleBackColor = True
        '
        'buscarlocal
        '
        Me.buscarlocal.Location = New System.Drawing.Point(549, 176)
        Me.buscarlocal.Name = "buscarlocal"
        Me.buscarlocal.Size = New System.Drawing.Size(75, 23)
        Me.buscarlocal.TabIndex = 10
        Me.buscarlocal.Text = "Buscar"
        Me.buscarlocal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Codigo postal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Localidades"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Codigo postal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(440, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Localidad"
        '
        'Localidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buscarlocal)
        Me.Controls.Add(Me.buscarcp)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.localtxt)
        Me.Controls.Add(Me.cptxt)
        Me.Controls.Add(Me.listo)
        Me.Controls.Add(Me.dgvloc)
        Me.Name = "Localidades"
        Me.Text = "Localidades"
        CType(Me.dgvloc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Juzgados2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvloc As DataGridView
    Friend WithEvents listo As Button
    Friend WithEvents cptxt As TextBox
    Friend WithEvents localtxt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LocalidadesTableAdapter1 As juzgados2023DataSetTableAdapters.localidadesTableAdapter
    Friend WithEvents LocalidadesBindingSource As BindingSource
    Friend WithEvents Juzgados2023DataSet As juzgados2023DataSet
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents buscarcp As Button
    Friend WithEvents buscarlocal As Button
    Friend WithEvents cp As DataGridViewTextBoxColumn
    Friend WithEvents localidad As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
