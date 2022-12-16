<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoUsuario))
        Me.cmbTipo_usuario = New System.Windows.Forms.ComboBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblConsultar = New System.Windows.Forms.Label()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblTipo_Usuario = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.LblClave = New System.Windows.Forms.Label()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.Registro_VehiculoDataSet = New Registro_Vehiculos_App.Registro_VehiculoDataSet()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioTableAdapter = New Registro_Vehiculos_App.Registro_VehiculoDataSetTableAdapters.UsuarioTableAdapter()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbOpciones.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_VehiculoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTipo_usuario
        '
        Me.cmbTipo_usuario.FormattingEnabled = True
        Me.cmbTipo_usuario.Items.AddRange(New Object() {"Admin", "Clien"})
        Me.cmbTipo_usuario.Location = New System.Drawing.Point(201, 236)
        Me.cmbTipo_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipo_usuario.Name = "cmbTipo_usuario"
        Me.cmbTipo_usuario.Size = New System.Drawing.Size(160, 24)
        Me.cmbTipo_usuario.TabIndex = 44
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.Registro_VehiculoDataSet
        '
        'grbOpciones
        '
        Me.grbOpciones.Controls.Add(Me.btnLimpiar)
        Me.grbOpciones.Controls.Add(Me.btnModificar)
        Me.grbOpciones.Controls.Add(Me.btnBorrar)
        Me.grbOpciones.Location = New System.Drawing.Point(728, 63)
        Me.grbOpciones.Margin = New System.Windows.Forms.Padding(4)
        Me.grbOpciones.Name = "grbOpciones"
        Me.grbOpciones.Padding = New System.Windows.Forms.Padding(4)
        Me.grbOpciones.Size = New System.Drawing.Size(199, 164)
        Me.grbOpciones.TabIndex = 42
        Me.grbOpciones.TabStop = False
        Me.grbOpciones.Text = "Opciones"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(9, 114)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(175, 28)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar "
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(8, 23)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(176, 28)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar datos"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(8, 70)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(175, 28)
        Me.btnBorrar.TabIndex = 8
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblConsultar
        '
        Me.lblConsultar.AutoSize = True
        Me.lblConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultar.Location = New System.Drawing.Point(24, 410)
        Me.lblConsultar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsultar.Name = "lblConsultar"
        Me.lblConsultar.Size = New System.Drawing.Size(221, 52)
        Me.lblConsultar.TabIndex = 41
        Me.lblConsultar.Text = "Consultar "
        '
        'txtNombre1
        '
        Me.txtNombre1.Location = New System.Drawing.Point(33, 492)
        Me.txtNombre1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(175, 22)
        Me.txtNombre1.TabIndex = 40
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AutoGenerateColumns = False
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CorreoDataGridViewTextBoxColumn, Me.ClaveDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TipoUsuarioDataGridViewTextBoxColumn})
        Me.dgvDatos.DataSource = Me.UsuarioBindingSource
        Me.dgvDatos.Location = New System.Drawing.Point(265, 410)
        Me.dgvDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.RowHeadersWidth = 51
        Me.dgvDatos.Size = New System.Drawing.Size(661, 146)
        Me.dgvDatos.TabIndex = 39
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(33, 543)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(176, 28)
        Me.btnConsultar.TabIndex = 38
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(452, 63)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(141, 177)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(132, 22)
        Me.txtNombre.TabIndex = 37
        '
        'txtClave
        '
        Me.txtClave.Enabled = False
        Me.txtClave.Location = New System.Drawing.Point(141, 119)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(132, 22)
        Me.txtClave.TabIndex = 36
        '
        'txtCorreo
        '
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Location = New System.Drawing.Point(141, 63)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(132, 22)
        Me.txtCorreo.TabIndex = 35
        '
        'lblTipo_Usuario
        '
        Me.lblTipo_Usuario.AutoSize = True
        Me.lblTipo_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo_Usuario.Location = New System.Drawing.Point(40, 234)
        Me.lblTipo_Usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo_Usuario.Name = "lblTipo_Usuario"
        Me.lblTipo_Usuario.Size = New System.Drawing.Size(142, 25)
        Me.lblTipo_Usuario.TabIndex = 34
        Me.lblTipo_Usuario.Text = "Tipo Usuario:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(40, 177)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(94, 25)
        Me.lblNombre.TabIndex = 33
        Me.lblNombre.Text = "Nombre:"
        '
        'LblClave
        '
        Me.LblClave.AutoSize = True
        Me.LblClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClave.Location = New System.Drawing.Point(40, 119)
        Me.LblClave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblClave.Name = "LblClave"
        Me.LblClave.Size = New System.Drawing.Size(75, 25)
        Me.LblClave.TabIndex = 32
        Me.LblClave.Text = "Clave:"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCorreo.Location = New System.Drawing.Point(40, 63)
        Me.LblCorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(85, 25)
        Me.LblCorreo.TabIndex = 31
        Me.LblCorreo.Text = "Correo:"
        '
        'Registro_VehiculoDataSet
        '
        Me.Registro_VehiculoDataSet.DataSetName = "Registro_VehiculoDataSet"
        Me.Registro_VehiculoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        '
        'ClaveDataGridViewTextBoxColumn
        '
        Me.ClaveDataGridViewTextBoxColumn.DataPropertyName = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.HeaderText = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClaveDataGridViewTextBoxColumn.Name = "ClaveDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'TipoUsuarioDataGridViewTextBoxColumn
        '
        Me.TipoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Usuario"
        Me.TipoUsuarioDataGridViewTextBoxColumn.HeaderText = "Tipo_Usuario"
        Me.TipoUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TipoUsuarioDataGridViewTextBoxColumn.Name = "TipoUsuarioDataGridViewTextBoxColumn"
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'frmMantenimientoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 635)
        Me.Controls.Add(Me.cmbTipo_usuario)
        Me.Controls.Add(Me.grbOpciones)
        Me.Controls.Add(Me.lblConsultar)
        Me.Controls.Add(Me.txtNombre1)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblTipo_Usuario)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.LblClave)
        Me.Controls.Add(Me.LblCorreo)
        Me.Name = "frmMantenimientoUsuario"
        Me.Text = "Mantenimiento de usuarios"
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbOpciones.ResumeLayout(False)
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_VehiculoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTipo_usuario As ComboBox
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents grbOpciones As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblConsultar As Label
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnConsultar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblTipo_Usuario As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents LblClave As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents Registro_VehiculoDataSet As Registro_VehiculoDataSet
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioTableAdapter As Registro_VehiculoDataSetTableAdapters.UsuarioTableAdapter
End Class
