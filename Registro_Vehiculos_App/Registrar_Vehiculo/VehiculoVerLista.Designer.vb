<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VehiculoVerLista
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DgvRegistroVehiculo = New System.Windows.Forms.DataGridView()
        Me.TipoIdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroIdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroPlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroChasisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroMotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstiloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnhoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CilindrajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CombustibleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorFiscalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoClaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Registro_VehiculoDataSet = New Registro_Vehiculos_App.Registro_VehiculoDataSet()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiculoTableAdapter = New Registro_Vehiculos_App.Registro_VehiculoDataSetTableAdapters.VehiculoTableAdapter()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNumeroPlaca = New System.Windows.Forms.TextBox()
        Me.TxtNumeroIdentificacion = New System.Windows.Forms.TextBox()
        Me.RegistroVehiculoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DgvRegistroVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_VehiculoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroVehiculoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvRegistroVehiculo
        '
        Me.DgvRegistroVehiculo.AllowUserToAddRows = False
        Me.DgvRegistroVehiculo.AllowUserToDeleteRows = False
        Me.DgvRegistroVehiculo.AutoGenerateColumns = False
        Me.DgvRegistroVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistroVehiculo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoIdentificacionDataGridViewTextBoxColumn, Me.NumeroIdentificacionDataGridViewTextBoxColumn, Me.ClaseDataGridViewTextBoxColumn, Me.NumeroPlacaDataGridViewTextBoxColumn, Me.NumeroChasisDataGridViewTextBoxColumn, Me.NumeroMotorDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.EstiloDataGridViewTextBoxColumn, Me.AnhoDataGridViewTextBoxColumn, Me.CilindrajeDataGridViewTextBoxColumn, Me.CapacidadDataGridViewTextBoxColumn, Me.CombustibleDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.ValorFiscalDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.CodigoClaseDataGridViewTextBoxColumn})
        Me.DgvRegistroVehiculo.DataMember = "Vehiculo"
        Me.DgvRegistroVehiculo.DataSource = Me.Registro_VehiculoDataSet
        Me.DgvRegistroVehiculo.Location = New System.Drawing.Point(12, 101)
        Me.DgvRegistroVehiculo.MultiSelect = False
        Me.DgvRegistroVehiculo.Name = "DgvRegistroVehiculo"
        Me.DgvRegistroVehiculo.ReadOnly = True
        Me.DgvRegistroVehiculo.RowHeadersWidth = 51
        Me.DgvRegistroVehiculo.RowTemplate.Height = 24
        Me.DgvRegistroVehiculo.Size = New System.Drawing.Size(1633, 617)
        Me.DgvRegistroVehiculo.TabIndex = 1
        '
        'TipoIdentificacionDataGridViewTextBoxColumn
        '
        Me.TipoIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Identificacion"
        Me.TipoIdentificacionDataGridViewTextBoxColumn.HeaderText = "Tipo_Identificacion"
        Me.TipoIdentificacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TipoIdentificacionDataGridViewTextBoxColumn.Name = "TipoIdentificacionDataGridViewTextBoxColumn"
        Me.TipoIdentificacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoIdentificacionDataGridViewTextBoxColumn.Width = 125
        '
        'NumeroIdentificacionDataGridViewTextBoxColumn
        '
        Me.NumeroIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Numero_Identificacion"
        Me.NumeroIdentificacionDataGridViewTextBoxColumn.HeaderText = "Numero_Identificacion"
        Me.NumeroIdentificacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroIdentificacionDataGridViewTextBoxColumn.Name = "NumeroIdentificacionDataGridViewTextBoxColumn"
        Me.NumeroIdentificacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroIdentificacionDataGridViewTextBoxColumn.Width = 125
        '
        'ClaseDataGridViewTextBoxColumn
        '
        Me.ClaseDataGridViewTextBoxColumn.DataPropertyName = "Clase"
        Me.ClaseDataGridViewTextBoxColumn.HeaderText = "Clase"
        Me.ClaseDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClaseDataGridViewTextBoxColumn.Name = "ClaseDataGridViewTextBoxColumn"
        Me.ClaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClaseDataGridViewTextBoxColumn.Width = 125
        '
        'NumeroPlacaDataGridViewTextBoxColumn
        '
        Me.NumeroPlacaDataGridViewTextBoxColumn.DataPropertyName = "Numero_Placa"
        Me.NumeroPlacaDataGridViewTextBoxColumn.HeaderText = "Numero_Placa"
        Me.NumeroPlacaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroPlacaDataGridViewTextBoxColumn.Name = "NumeroPlacaDataGridViewTextBoxColumn"
        Me.NumeroPlacaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroPlacaDataGridViewTextBoxColumn.Width = 125
        '
        'NumeroChasisDataGridViewTextBoxColumn
        '
        Me.NumeroChasisDataGridViewTextBoxColumn.DataPropertyName = "Numero_Chasis"
        Me.NumeroChasisDataGridViewTextBoxColumn.HeaderText = "Numero_Chasis"
        Me.NumeroChasisDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroChasisDataGridViewTextBoxColumn.Name = "NumeroChasisDataGridViewTextBoxColumn"
        Me.NumeroChasisDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroChasisDataGridViewTextBoxColumn.Width = 125
        '
        'NumeroMotorDataGridViewTextBoxColumn
        '
        Me.NumeroMotorDataGridViewTextBoxColumn.DataPropertyName = "Numero_Motor"
        Me.NumeroMotorDataGridViewTextBoxColumn.HeaderText = "Numero_Motor"
        Me.NumeroMotorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroMotorDataGridViewTextBoxColumn.Name = "NumeroMotorDataGridViewTextBoxColumn"
        Me.NumeroMotorDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroMotorDataGridViewTextBoxColumn.Width = 125
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ColorDataGridViewTextBoxColumn.Width = 125
        '
        'EstiloDataGridViewTextBoxColumn
        '
        Me.EstiloDataGridViewTextBoxColumn.DataPropertyName = "Estilo"
        Me.EstiloDataGridViewTextBoxColumn.HeaderText = "Estilo"
        Me.EstiloDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstiloDataGridViewTextBoxColumn.Name = "EstiloDataGridViewTextBoxColumn"
        Me.EstiloDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstiloDataGridViewTextBoxColumn.Width = 125
        '
        'AnhoDataGridViewTextBoxColumn
        '
        Me.AnhoDataGridViewTextBoxColumn.DataPropertyName = "Anho"
        Me.AnhoDataGridViewTextBoxColumn.HeaderText = "Anho"
        Me.AnhoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AnhoDataGridViewTextBoxColumn.Name = "AnhoDataGridViewTextBoxColumn"
        Me.AnhoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnhoDataGridViewTextBoxColumn.Width = 125
        '
        'CilindrajeDataGridViewTextBoxColumn
        '
        Me.CilindrajeDataGridViewTextBoxColumn.DataPropertyName = "Cilindraje"
        Me.CilindrajeDataGridViewTextBoxColumn.HeaderText = "Cilindraje"
        Me.CilindrajeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CilindrajeDataGridViewTextBoxColumn.Name = "CilindrajeDataGridViewTextBoxColumn"
        Me.CilindrajeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CilindrajeDataGridViewTextBoxColumn.Width = 125
        '
        'CapacidadDataGridViewTextBoxColumn
        '
        Me.CapacidadDataGridViewTextBoxColumn.DataPropertyName = "Capacidad"
        Me.CapacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad"
        Me.CapacidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CapacidadDataGridViewTextBoxColumn.Name = "CapacidadDataGridViewTextBoxColumn"
        Me.CapacidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CapacidadDataGridViewTextBoxColumn.Width = 125
        '
        'CombustibleDataGridViewTextBoxColumn
        '
        Me.CombustibleDataGridViewTextBoxColumn.DataPropertyName = "Combustible"
        Me.CombustibleDataGridViewTextBoxColumn.HeaderText = "Combustible"
        Me.CombustibleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CombustibleDataGridViewTextBoxColumn.Name = "CombustibleDataGridViewTextBoxColumn"
        Me.CombustibleDataGridViewTextBoxColumn.ReadOnly = True
        Me.CombustibleDataGridViewTextBoxColumn.Width = 125
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn.Width = 125
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoriaDataGridViewTextBoxColumn.Width = 125
        '
        'ValorFiscalDataGridViewTextBoxColumn
        '
        Me.ValorFiscalDataGridViewTextBoxColumn.DataPropertyName = "Valor_Fiscal"
        Me.ValorFiscalDataGridViewTextBoxColumn.HeaderText = "Valor_Fiscal"
        Me.ValorFiscalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ValorFiscalDataGridViewTextBoxColumn.Name = "ValorFiscalDataGridViewTextBoxColumn"
        Me.ValorFiscalDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorFiscalDataGridViewTextBoxColumn.Width = 125
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "Serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        Me.SerieDataGridViewTextBoxColumn.Width = 125
        '
        'CodigoClaseDataGridViewTextBoxColumn
        '
        Me.CodigoClaseDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Clase"
        Me.CodigoClaseDataGridViewTextBoxColumn.HeaderText = "Codigo_Clase"
        Me.CodigoClaseDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodigoClaseDataGridViewTextBoxColumn.Name = "CodigoClaseDataGridViewTextBoxColumn"
        Me.CodigoClaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoClaseDataGridViewTextBoxColumn.Width = 125
        '
        'Registro_VehiculoDataSet
        '
        Me.Registro_VehiculoDataSet.DataSetName = "Registro_VehiculoDataSet"
        Me.Registro_VehiculoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehiculoBindingSource
        '
        Me.VehiculoBindingSource.DataMember = "Vehiculo"
        Me.VehiculoBindingSource.DataSource = Me.Registro_VehiculoDataSet
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(1481, 42)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(164, 39)
        Me.BtnEditar.TabIndex = 15
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Location = New System.Drawing.Point(1295, 42)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(164, 39)
        Me.BtnBorrar.TabIndex = 16
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(293, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Numero de identificacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Numero de placa"
        '
        'TxtNumeroPlaca
        '
        Me.TxtNumeroPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumeroPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroPlaca.Location = New System.Drawing.Point(16, 59)
        Me.TxtNumeroPlaca.Name = "TxtNumeroPlaca"
        Me.TxtNumeroPlaca.Size = New System.Drawing.Size(260, 27)
        Me.TxtNumeroPlaca.TabIndex = 21
        '
        'TxtNumeroIdentificacion
        '
        Me.TxtNumeroIdentificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumeroIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroIdentificacion.Location = New System.Drawing.Point(297, 59)
        Me.TxtNumeroIdentificacion.Name = "TxtNumeroIdentificacion"
        Me.TxtNumeroIdentificacion.Size = New System.Drawing.Size(260, 27)
        Me.TxtNumeroIdentificacion.TabIndex = 22
        '
        'RegistroVehiculoDataSetBindingSource
        '
        Me.RegistroVehiculoDataSetBindingSource.DataSource = Me.Registro_VehiculoDataSet
        Me.RegistroVehiculoDataSetBindingSource.Position = 0
        '
        'VehiculoVerLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1657, 730)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNumeroPlaca)
        Me.Controls.Add(Me.TxtNumeroIdentificacion)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.DgvRegistroVehiculo)
        Me.Name = "VehiculoVerLista"
        Me.Text = "Lista de vehiculos registrados"
        CType(Me.DgvRegistroVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_VehiculoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroVehiculoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvRegistroVehiculo As DataGridView
    Friend WithEvents Registro_VehiculoDataSet As Registro_VehiculoDataSet
    Friend WithEvents VehiculoBindingSource As BindingSource
    Friend WithEvents VehiculoTableAdapter As Registro_VehiculoDataSetTableAdapters.VehiculoTableAdapter
    Friend WithEvents TipoIdentificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroIdentificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroPlacaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroChasisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroMotorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstiloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnhoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CilindrajeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapacidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CombustibleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorFiscalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoClaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNumeroPlaca As TextBox
    Friend WithEvents TxtNumeroIdentificacion As TextBox
    Friend WithEvents RegistroVehiculoDataSetBindingSource As BindingSource
End Class
