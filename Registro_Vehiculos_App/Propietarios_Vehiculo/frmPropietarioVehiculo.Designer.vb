<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropietarioVehiculo
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PropietarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblnombrej = New System.Windows.Forms.Label()
        Me.txtombrej = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.lblestadocivil = New System.Windows.Forms.Label()
        Me.cmbestadocivil = New System.Windows.Forms.ComboBox()
        Me.txtidentificacion = New System.Windows.Forms.TextBox()
        Me.cmbdistrito = New System.Windows.Forms.ComboBox()
        Me.lbldistrito = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.botlimpiar = New System.Windows.Forms.Button()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.cmbcanton = New System.Windows.Forms.ComboBox()
        Me.lblcanton = New System.Windows.Forms.Label()
        Me.botconsultar = New System.Windows.Forms.Button()
        Me.cmbprovincia = New System.Windows.Forms.ComboBox()
        Me.botmodificar = New System.Windows.Forms.Button()
        Me.lblprovincia = New System.Windows.Forms.Label()
        Me.botguardar = New System.Windows.Forms.Button()
        Me.lbltipoidenificacion = New System.Windows.Forms.Label()
        Me.cmbtipoid = New System.Windows.Forms.ComboBox()
        Me.lblidentificacion = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblapellido1 = New System.Windows.Forms.Label()
        Me.txtapellido2 = New System.Windows.Forms.TextBox()
        Me.lblapellido2 = New System.Windows.Forms.Label()
        Me.txtapellido1 = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Registro_VehiculoDataSet = New Registro_Vehiculos_App.Registro_VehiculoDataSet()
        Me.TipoIdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroIdentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreJuridicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistritoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCivilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoElectronicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropietarioTableAdapter = New Registro_Vehiculos_App.Registro_VehiculoDataSetTableAdapters.PropietarioTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropietarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_VehiculoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoIdentificacionDataGridViewTextBoxColumn, Me.NumeroIdentificacionDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PrimerApellidoDataGridViewTextBoxColumn, Me.SegundoApellidoDataGridViewTextBoxColumn, Me.NombreJuridicoDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.CantonDataGridViewTextBoxColumn, Me.DistritoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.EstadoCivilDataGridViewTextBoxColumn, Me.CorreoElectronicoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PropietarioBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(64, 457)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1548, 193)
        Me.DataGridView1.TabIndex = 112
        '
        'PropietarioBindingSource
        '
        Me.PropietarioBindingSource.DataMember = "Propietario"
        Me.PropietarioBindingSource.DataSource = Me.Registro_VehiculoDataSet
        '
        'lblnombrej
        '
        Me.lblnombrej.AutoSize = True
        Me.lblnombrej.Location = New System.Drawing.Point(103, 248)
        Me.lblnombrej.Name = "lblnombrej"
        Me.lblnombrej.Size = New System.Drawing.Size(131, 16)
        Me.lblnombrej.TabIndex = 110
        Me.lblnombrej.Text = "NOMBRE JURIDICO"
        '
        'txtombrej
        '
        Me.txtombrej.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtombrej.Location = New System.Drawing.Point(64, 285)
        Me.txtombrej.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtombrej.MaxLength = 30
        Me.txtombrej.Name = "txtombrej"
        Me.txtombrej.Size = New System.Drawing.Size(222, 22)
        Me.txtombrej.TabIndex = 111
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(64, 380)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcorreo.MaxLength = 60
        Me.txtcorreo.Multiline = True
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(512, 22)
        Me.txtcorreo.TabIndex = 109
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Location = New System.Drawing.Point(241, 339)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(163, 16)
        Me.lblcorreo.TabIndex = 108
        Me.lblcorreo.Text = "CORREO ELECTRONICO"
        '
        'lblestadocivil
        '
        Me.lblestadocivil.AutoSize = True
        Me.lblestadocivil.Location = New System.Drawing.Point(402, 249)
        Me.lblestadocivil.Name = "lblestadocivil"
        Me.lblestadocivil.Size = New System.Drawing.Size(97, 16)
        Me.lblestadocivil.TabIndex = 106
        Me.lblestadocivil.Text = "ESTADO CIVIL"
        '
        'cmbestadocivil
        '
        Me.cmbestadocivil.FormattingEnabled = True
        Me.cmbestadocivil.Items.AddRange(New Object() {"SOLTERO (A)", "CASADO (A)", "DIVORCIADO (A)", "VIUDO (A)"})
        Me.cmbestadocivil.Location = New System.Drawing.Point(339, 284)
        Me.cmbestadocivil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbestadocivil.Name = "cmbestadocivil"
        Me.cmbestadocivil.Size = New System.Drawing.Size(222, 24)
        Me.cmbestadocivil.TabIndex = 107
        '
        'txtidentificacion
        '
        Me.txtidentificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtidentificacion.Location = New System.Drawing.Point(339, 173)
        Me.txtidentificacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtidentificacion.MaxLength = 30
        Me.txtidentificacion.Name = "txtidentificacion"
        Me.txtidentificacion.Size = New System.Drawing.Size(222, 22)
        Me.txtidentificacion.TabIndex = 105
        '
        'cmbdistrito
        '
        Me.cmbdistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdistrito.FormattingEnabled = True
        Me.cmbdistrito.Location = New System.Drawing.Point(1113, 284)
        Me.cmbdistrito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbdistrito.Name = "cmbdistrito"
        Me.cmbdistrito.Size = New System.Drawing.Size(222, 24)
        Me.cmbdistrito.TabIndex = 104
        '
        'lbldistrito
        '
        Me.lbldistrito.AutoSize = True
        Me.lbldistrito.Location = New System.Drawing.Point(1179, 248)
        Me.lbldistrito.Name = "lbldistrito"
        Me.lbldistrito.Size = New System.Drawing.Size(70, 16)
        Me.lbldistrito.TabIndex = 103
        Me.lbldistrito.Text = "DISTRITO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(580, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 29)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "PROPIETARIOS"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(1377, 173)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdireccion.MaxLength = 60
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(234, 134)
        Me.txtdireccion.TabIndex = 93
        '
        'botlimpiar
        '
        Me.botlimpiar.Location = New System.Drawing.Point(1213, 363)
        Me.botlimpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.botlimpiar.Name = "botlimpiar"
        Me.botlimpiar.Size = New System.Drawing.Size(142, 38)
        Me.botlimpiar.TabIndex = 97
        Me.botlimpiar.Text = "LIMPIAR"
        Me.botlimpiar.UseVisualStyleBackColor = True
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(1449, 130)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(80, 16)
        Me.lbldireccion.TabIndex = 92
        Me.lbldireccion.Text = "DIRECCION"
        '
        'cmbcanton
        '
        Me.cmbcanton.FormattingEnabled = True
        Me.cmbcanton.Location = New System.Drawing.Point(858, 284)
        Me.cmbcanton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbcanton.Name = "cmbcanton"
        Me.cmbcanton.Size = New System.Drawing.Size(222, 24)
        Me.cmbcanton.TabIndex = 102
        '
        'lblcanton
        '
        Me.lblcanton.AutoSize = True
        Me.lblcanton.Location = New System.Drawing.Point(940, 248)
        Me.lblcanton.Name = "lblcanton"
        Me.lblcanton.Size = New System.Drawing.Size(64, 16)
        Me.lblcanton.TabIndex = 101
        Me.lblcanton.Text = "CANTON"
        '
        'botconsultar
        '
        Me.botconsultar.Location = New System.Drawing.Point(1075, 363)
        Me.botconsultar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.botconsultar.Name = "botconsultar"
        Me.botconsultar.Size = New System.Drawing.Size(130, 38)
        Me.botconsultar.TabIndex = 96
        Me.botconsultar.Text = "CONSULTAR"
        Me.botconsultar.UseVisualStyleBackColor = True
        '
        'cmbprovincia
        '
        Me.cmbprovincia.FormattingEnabled = True
        Me.cmbprovincia.Location = New System.Drawing.Point(593, 284)
        Me.cmbprovincia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbprovincia.Name = "cmbprovincia"
        Me.cmbprovincia.Size = New System.Drawing.Size(222, 24)
        Me.cmbprovincia.TabIndex = 100
        '
        'botmodificar
        '
        Me.botmodificar.Location = New System.Drawing.Point(940, 363)
        Me.botmodificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.botmodificar.Name = "botmodificar"
        Me.botmodificar.Size = New System.Drawing.Size(130, 38)
        Me.botmodificar.TabIndex = 95
        Me.botmodificar.Text = "MODIFICAR"
        Me.botmodificar.UseVisualStyleBackColor = True
        '
        'lblprovincia
        '
        Me.lblprovincia.AutoSize = True
        Me.lblprovincia.Location = New System.Drawing.Point(657, 248)
        Me.lblprovincia.Name = "lblprovincia"
        Me.lblprovincia.Size = New System.Drawing.Size(79, 16)
        Me.lblprovincia.TabIndex = 99
        Me.lblprovincia.Text = "PROVINCIA"
        '
        'botguardar
        '
        Me.botguardar.Location = New System.Drawing.Point(805, 363)
        Me.botguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.botguardar.Name = "botguardar"
        Me.botguardar.Size = New System.Drawing.Size(130, 38)
        Me.botguardar.TabIndex = 94
        Me.botguardar.Text = "GUARDAR"
        Me.botguardar.UseVisualStyleBackColor = True
        '
        'lbltipoidenificacion
        '
        Me.lbltipoidenificacion.AutoSize = True
        Me.lbltipoidenificacion.Location = New System.Drawing.Point(103, 130)
        Me.lbltipoidenificacion.Name = "lbltipoidenificacion"
        Me.lbltipoidenificacion.Size = New System.Drawing.Size(146, 16)
        Me.lbltipoidenificacion.TabIndex = 83
        Me.lbltipoidenificacion.Text = "TIPO IDENTIFICACION"
        '
        'cmbtipoid
        '
        Me.cmbtipoid.FormattingEnabled = True
        Me.cmbtipoid.Items.AddRange(New Object() {"FISICO ", "JURIDICO"})
        Me.cmbtipoid.Location = New System.Drawing.Point(64, 176)
        Me.cmbtipoid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbtipoid.Name = "cmbtipoid"
        Me.cmbtipoid.Size = New System.Drawing.Size(222, 24)
        Me.cmbtipoid.TabIndex = 91
        '
        'lblidentificacion
        '
        Me.lblidentificacion.AutoSize = True
        Me.lblidentificacion.Location = New System.Drawing.Point(390, 130)
        Me.lblidentificacion.Name = "lblidentificacion"
        Me.lblidentificacion.Size = New System.Drawing.Size(112, 16)
        Me.lblidentificacion.TabIndex = 84
        Me.lblidentificacion.Text = "IDENTIFICACION"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(675, 130)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(66, 16)
        Me.lblnombre.TabIndex = 85
        Me.lblnombre.Text = "NOMBRE"
        '
        'lblapellido1
        '
        Me.lblapellido1.AutoSize = True
        Me.lblapellido1.Location = New System.Drawing.Point(913, 130)
        Me.lblapellido1.Name = "lblapellido1"
        Me.lblapellido1.Size = New System.Drawing.Size(126, 16)
        Me.lblapellido1.TabIndex = 86
        Me.lblapellido1.Text = "PRIMER APELLIDO"
        '
        'txtapellido2
        '
        Me.txtapellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtapellido2.Location = New System.Drawing.Point(1113, 173)
        Me.txtapellido2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtapellido2.MaxLength = 30
        Me.txtapellido2.Name = "txtapellido2"
        Me.txtapellido2.Size = New System.Drawing.Size(222, 22)
        Me.txtapellido2.TabIndex = 90
        '
        'lblapellido2
        '
        Me.lblapellido2.AutoSize = True
        Me.lblapellido2.Location = New System.Drawing.Point(1149, 130)
        Me.lblapellido2.Name = "lblapellido2"
        Me.lblapellido2.Size = New System.Drawing.Size(142, 16)
        Me.lblapellido2.TabIndex = 87
        Me.lblapellido2.Text = "SEGUNDO APELLIDO"
        '
        'txtapellido1
        '
        Me.txtapellido1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtapellido1.Location = New System.Drawing.Point(868, 173)
        Me.txtapellido1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtapellido1.MaxLength = 30
        Me.txtapellido1.Name = "txtapellido1"
        Me.txtapellido1.Size = New System.Drawing.Size(222, 22)
        Me.txtapellido1.TabIndex = 89
        '
        'txtnombre
        '
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Location = New System.Drawing.Point(603, 171)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombre.MaxLength = 30
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(222, 22)
        Me.txtnombre.TabIndex = 88
        '
        'Registro_VehiculoDataSet
        '
        Me.Registro_VehiculoDataSet.DataSetName = "Registro_VehiculoDataSet"
        Me.Registro_VehiculoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoIdentificacionDataGridViewTextBoxColumn
        '
        Me.TipoIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Identificacion"
        Me.TipoIdentificacionDataGridViewTextBoxColumn.HeaderText = "Tipo_Identificacion"
        Me.TipoIdentificacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TipoIdentificacionDataGridViewTextBoxColumn.Name = "TipoIdentificacionDataGridViewTextBoxColumn"
        Me.TipoIdentificacionDataGridViewTextBoxColumn.Width = 125
        '
        'NumeroIdentificacionDataGridViewTextBoxColumn
        '
        Me.NumeroIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "Numero_Identificacion"
        Me.NumeroIdentificacionDataGridViewTextBoxColumn.HeaderText = "Numero_Identificacion"
        Me.NumeroIdentificacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroIdentificacionDataGridViewTextBoxColumn.Name = "NumeroIdentificacionDataGridViewTextBoxColumn"
        Me.NumeroIdentificacionDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'PrimerApellidoDataGridViewTextBoxColumn
        '
        Me.PrimerApellidoDataGridViewTextBoxColumn.DataPropertyName = "Primer_Apellido"
        Me.PrimerApellidoDataGridViewTextBoxColumn.HeaderText = "Primer_Apellido"
        Me.PrimerApellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrimerApellidoDataGridViewTextBoxColumn.Name = "PrimerApellidoDataGridViewTextBoxColumn"
        Me.PrimerApellidoDataGridViewTextBoxColumn.Width = 125
        '
        'SegundoApellidoDataGridViewTextBoxColumn
        '
        Me.SegundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "Segundo_Apellido"
        Me.SegundoApellidoDataGridViewTextBoxColumn.HeaderText = "Segundo_Apellido"
        Me.SegundoApellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SegundoApellidoDataGridViewTextBoxColumn.Name = "SegundoApellidoDataGridViewTextBoxColumn"
        Me.SegundoApellidoDataGridViewTextBoxColumn.Width = 125
        '
        'NombreJuridicoDataGridViewTextBoxColumn
        '
        Me.NombreJuridicoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Juridico"
        Me.NombreJuridicoDataGridViewTextBoxColumn.HeaderText = "Nombre_Juridico"
        Me.NombreJuridicoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreJuridicoDataGridViewTextBoxColumn.Name = "NombreJuridicoDataGridViewTextBoxColumn"
        Me.NombreJuridicoDataGridViewTextBoxColumn.Width = 125
        '
        'ProvinciaDataGridViewTextBoxColumn
        '
        Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
        Me.ProvinciaDataGridViewTextBoxColumn.Width = 125
        '
        'CantonDataGridViewTextBoxColumn
        '
        Me.CantonDataGridViewTextBoxColumn.DataPropertyName = "Canton"
        Me.CantonDataGridViewTextBoxColumn.HeaderText = "Canton"
        Me.CantonDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantonDataGridViewTextBoxColumn.Name = "CantonDataGridViewTextBoxColumn"
        Me.CantonDataGridViewTextBoxColumn.Width = 125
        '
        'DistritoDataGridViewTextBoxColumn
        '
        Me.DistritoDataGridViewTextBoxColumn.DataPropertyName = "Distrito"
        Me.DistritoDataGridViewTextBoxColumn.HeaderText = "Distrito"
        Me.DistritoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DistritoDataGridViewTextBoxColumn.Name = "DistritoDataGridViewTextBoxColumn"
        Me.DistritoDataGridViewTextBoxColumn.Width = 125
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoCivilDataGridViewTextBoxColumn
        '
        Me.EstadoCivilDataGridViewTextBoxColumn.DataPropertyName = "Estado_Civil"
        Me.EstadoCivilDataGridViewTextBoxColumn.HeaderText = "Estado_Civil"
        Me.EstadoCivilDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoCivilDataGridViewTextBoxColumn.Name = "EstadoCivilDataGridViewTextBoxColumn"
        Me.EstadoCivilDataGridViewTextBoxColumn.Width = 125
        '
        'CorreoElectronicoDataGridViewTextBoxColumn
        '
        Me.CorreoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "Correo_Electronico"
        Me.CorreoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo_Electronico"
        Me.CorreoElectronicoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoElectronicoDataGridViewTextBoxColumn.Name = "CorreoElectronicoDataGridViewTextBoxColumn"
        Me.CorreoElectronicoDataGridViewTextBoxColumn.Width = 125
        '
        'PropietarioTableAdapter
        '
        Me.PropietarioTableAdapter.ClearBeforeFill = True
        '
        'frmPropietarioVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1676, 703)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblnombrej)
        Me.Controls.Add(Me.txtombrej)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.lblcorreo)
        Me.Controls.Add(Me.lblestadocivil)
        Me.Controls.Add(Me.cmbestadocivil)
        Me.Controls.Add(Me.txtidentificacion)
        Me.Controls.Add(Me.cmbdistrito)
        Me.Controls.Add(Me.lbldistrito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.botlimpiar)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.cmbcanton)
        Me.Controls.Add(Me.lblcanton)
        Me.Controls.Add(Me.botconsultar)
        Me.Controls.Add(Me.cmbprovincia)
        Me.Controls.Add(Me.botmodificar)
        Me.Controls.Add(Me.lblprovincia)
        Me.Controls.Add(Me.botguardar)
        Me.Controls.Add(Me.lbltipoidenificacion)
        Me.Controls.Add(Me.cmbtipoid)
        Me.Controls.Add(Me.lblidentificacion)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblapellido1)
        Me.Controls.Add(Me.txtapellido2)
        Me.Controls.Add(Me.lblapellido2)
        Me.Controls.Add(Me.txtapellido1)
        Me.Controls.Add(Me.txtnombre)
        Me.Name = "frmPropietarioVehiculo"
        Me.Text = "Propietarios de vehiculos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropietarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_VehiculoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PropietarioBindingSource As BindingSource
    Friend WithEvents lblnombrej As Label
    Friend WithEvents txtombrej As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents lblcorreo As Label
    Friend WithEvents lblestadocivil As Label
    Friend WithEvents cmbestadocivil As ComboBox
    Friend WithEvents txtidentificacion As TextBox
    Friend WithEvents cmbdistrito As ComboBox
    Friend WithEvents lbldistrito As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents botlimpiar As Button
    Friend WithEvents lbldireccion As Label
    Friend WithEvents cmbcanton As ComboBox
    Friend WithEvents lblcanton As Label
    Friend WithEvents botconsultar As Button
    Friend WithEvents cmbprovincia As ComboBox
    Friend WithEvents botmodificar As Button
    Friend WithEvents lblprovincia As Label
    Friend WithEvents botguardar As Button
    Friend WithEvents lbltipoidenificacion As Label
    Friend WithEvents cmbtipoid As ComboBox
    Friend WithEvents lblidentificacion As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblapellido1 As Label
    Friend WithEvents txtapellido2 As TextBox
    Friend WithEvents lblapellido2 As Label
    Friend WithEvents txtapellido1 As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents TipoIdentificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroIdentificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundoApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreJuridicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DistritoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCivilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoElectronicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Registro_VehiculoDataSet As Registro_VehiculoDataSet
    Friend WithEvents PropietarioTableAdapter As Registro_VehiculoDataSetTableAdapters.PropietarioTableAdapter
End Class
