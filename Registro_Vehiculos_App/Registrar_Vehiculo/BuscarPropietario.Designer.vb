<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarPropietario
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
        Me.DgvPropietario = New System.Windows.Forms.DataGridView()
        Me.NumeroIdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoIdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreJuridicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoElectronicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropietarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_VehiculoDataSet = New Registro_Vehiculos_App.Registro_VehiculoDataSet()
        Me.PropietarioTableAdapter = New Registro_Vehiculos_App.Registro_VehiculoDataSetTableAdapters.PropietarioTableAdapter()
        Me.TxtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropietarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_VehiculoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvPropietario
        '
        Me.DgvPropietario.AllowUserToAddRows = False
        Me.DgvPropietario.AllowUserToDeleteRows = False
        Me.DgvPropietario.AutoGenerateColumns = False
        Me.DgvPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPropietario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroIdentificacionDataGridViewTextBoxColumn, Me.TipoIdentificacionDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.NombreJuridicoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.CorreoElectronicoDataGridViewTextBoxColumn})
        Me.DgvPropietario.DataSource = Me.PropietarioBindingSource
        Me.DgvPropietario.Location = New System.Drawing.Point(11, 71)
        Me.DgvPropietario.MultiSelect = False
        Me.DgvPropietario.Name = "DgvPropietario"
        Me.DgvPropietario.ReadOnly = True
        Me.DgvPropietario.RowHeadersWidth = 51
        Me.DgvPropietario.RowTemplate.Height = 24
        Me.DgvPropietario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPropietario.Size = New System.Drawing.Size(906, 386)
        Me.DgvPropietario.TabIndex = 0
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
        'TipoIdentificacionDataGridViewTextBoxColumn
        '
        Me.TipoIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Identificacion"
        Me.TipoIdentificacionDataGridViewTextBoxColumn.HeaderText = "Tipo_Identificacion"
        Me.TipoIdentificacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TipoIdentificacionDataGridViewTextBoxColumn.Name = "TipoIdentificacionDataGridViewTextBoxColumn"
        Me.TipoIdentificacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoIdentificacionDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'NombreJuridicoDataGridViewTextBoxColumn
        '
        Me.NombreJuridicoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Juridico"
        Me.NombreJuridicoDataGridViewTextBoxColumn.HeaderText = "Nombre_Juridico"
        Me.NombreJuridicoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreJuridicoDataGridViewTextBoxColumn.Name = "NombreJuridicoDataGridViewTextBoxColumn"
        Me.NombreJuridicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreJuridicoDataGridViewTextBoxColumn.Width = 125
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Width = 125
        '
        'CorreoElectronicoDataGridViewTextBoxColumn
        '
        Me.CorreoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "Correo_Electronico"
        Me.CorreoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo_Electronico"
        Me.CorreoElectronicoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoElectronicoDataGridViewTextBoxColumn.Name = "CorreoElectronicoDataGridViewTextBoxColumn"
        Me.CorreoElectronicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoElectronicoDataGridViewTextBoxColumn.Width = 125
        '
        'PropietarioBindingSource
        '
        Me.PropietarioBindingSource.DataMember = "Propietario"
        Me.PropietarioBindingSource.DataSource = Me.Registro_VehiculoDataSet
        '
        'Registro_VehiculoDataSet
        '
        Me.Registro_VehiculoDataSet.DataSetName = "Registro_VehiculoDataSet"
        Me.Registro_VehiculoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PropietarioTableAdapter
        '
        Me.PropietarioTableAdapter.ClearBeforeFill = True
        '
        'TxtIdentificacion
        '
        Me.TxtIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdentificacion.Location = New System.Drawing.Point(12, 31)
        Me.TxtIdentificacion.Name = "TxtIdentificacion"
        Me.TxtIdentificacion.Size = New System.Drawing.Size(458, 27)
        Me.TxtIdentificacion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar por identificacion"
        '
        'BuscarPropietario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 466)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtIdentificacion)
        Me.Controls.Add(Me.DgvPropietario)
        Me.Name = "BuscarPropietario"
        Me.Text = "BuscarPropietario"
        CType(Me.DgvPropietario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropietarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_VehiculoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvPropietario As DataGridView
    Friend WithEvents Registro_VehiculoDataSet As Registro_VehiculoDataSet
    Friend WithEvents PropietarioBindingSource As BindingSource
    Friend WithEvents PropietarioTableAdapter As Registro_VehiculoDataSetTableAdapters.PropietarioTableAdapter
    Friend WithEvents NumeroIdentificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoIdentificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreJuridicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoElectronicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TxtIdentificacion As TextBox
    Friend WithEvents Label1 As Label
End Class
