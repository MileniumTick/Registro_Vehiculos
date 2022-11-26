<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehiculoFormulario
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
        Me.TxtNumeroIdentificacion = New System.Windows.Forms.TextBox()
        Me.TxtNumeroPlaca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarIdentificacion = New System.Windows.Forms.Button()
        Me.BtnGenerarPlaca = New System.Windows.Forms.Button()
        Me.CbxTipoIdentificacion = New System.Windows.Forms.ComboBox()
        Me.CbxClase = New System.Windows.Forms.ComboBox()
        Me.TxtNumeroChasis = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNumeroMotor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpAnno = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbxColor = New System.Windows.Forms.ComboBox()
        Me.CbxEstilo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbxCapacidad = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbxCombustible = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtCilindraje = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtValorFiscal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.ValidaCamposTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LblFechaActual = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNumeroIdentificacion
        '
        Me.TxtNumeroIdentificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumeroIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroIdentificacion.Location = New System.Drawing.Point(26, 132)
        Me.TxtNumeroIdentificacion.Name = "TxtNumeroIdentificacion"
        Me.TxtNumeroIdentificacion.Size = New System.Drawing.Size(260, 27)
        Me.TxtNumeroIdentificacion.TabIndex = 1
        '
        'TxtNumeroPlaca
        '
        Me.TxtNumeroPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumeroPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroPlaca.Location = New System.Drawing.Point(26, 59)
        Me.TxtNumeroPlaca.Name = "TxtNumeroPlaca"
        Me.TxtNumeroPlaca.ReadOnly = True
        Me.TxtNumeroPlaca.Size = New System.Drawing.Size(260, 27)
        Me.TxtNumeroPlaca.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Clase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Numero de placa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Numero de identificacion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnBuscarIdentificacion)
        Me.GroupBox1.Controls.Add(Me.BtnGenerarPlaca)
        Me.GroupBox1.Controls.Add(Me.CbxTipoIdentificacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CbxClase)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNumeroPlaca)
        Me.GroupBox1.Controls.Add(Me.TxtNumeroIdentificacion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 186)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos basicos necesarios"
        '
        'BtnBuscarIdentificacion
        '
        Me.BtnBuscarIdentificacion.Enabled = False
        Me.BtnBuscarIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarIdentificacion.Location = New System.Drawing.Point(616, 131)
        Me.BtnBuscarIdentificacion.Name = "BtnBuscarIdentificacion"
        Me.BtnBuscarIdentificacion.Size = New System.Drawing.Size(164, 28)
        Me.BtnBuscarIdentificacion.TabIndex = 48
        Me.BtnBuscarIdentificacion.Text = "Buscar"
        Me.BtnBuscarIdentificacion.UseVisualStyleBackColor = True
        '
        'BtnGenerarPlaca
        '
        Me.BtnGenerarPlaca.Enabled = False
        Me.BtnGenerarPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerarPlaca.Location = New System.Drawing.Point(616, 59)
        Me.BtnGenerarPlaca.Name = "BtnGenerarPlaca"
        Me.BtnGenerarPlaca.Size = New System.Drawing.Size(164, 28)
        Me.BtnGenerarPlaca.TabIndex = 45
        Me.BtnGenerarPlaca.Text = "Generar Placa"
        Me.BtnGenerarPlaca.UseVisualStyleBackColor = True
        '
        'CbxTipoIdentificacion
        '
        Me.CbxTipoIdentificacion.Enabled = False
        Me.CbxTipoIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxTipoIdentificacion.FormattingEnabled = True
        Me.CbxTipoIdentificacion.Items.AddRange(New Object() {"Fisica", "Juridica"})
        Me.CbxTipoIdentificacion.Location = New System.Drawing.Point(335, 132)
        Me.CbxTipoIdentificacion.Name = "CbxTipoIdentificacion"
        Me.CbxTipoIdentificacion.Size = New System.Drawing.Size(260, 28)
        Me.CbxTipoIdentificacion.TabIndex = 47
        '
        'CbxClase
        '
        Me.CbxClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxClase.FormattingEnabled = True
        Me.CbxClase.Items.AddRange(New Object() {"A1", "A2", "A3", "B1", "B2", "B3"})
        Me.CbxClase.Location = New System.Drawing.Point(335, 59)
        Me.CbxClase.Name = "CbxClase"
        Me.CbxClase.Size = New System.Drawing.Size(260, 28)
        Me.CbxClase.TabIndex = 46
        '
        'TxtNumeroChasis
        '
        Me.TxtNumeroChasis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroChasis.Location = New System.Drawing.Point(38, 241)
        Me.TxtNumeroChasis.Name = "TxtNumeroChasis"
        Me.TxtNumeroChasis.Size = New System.Drawing.Size(260, 27)
        Me.TxtNumeroChasis.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Numero de chasis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(343, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Numero de motor"
        '
        'TxtNumeroMotor
        '
        Me.TxtNumeroMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroMotor.Location = New System.Drawing.Point(347, 241)
        Me.TxtNumeroMotor.Name = "TxtNumeroMotor"
        Me.TxtNumeroMotor.Size = New System.Drawing.Size(260, 27)
        Me.TxtNumeroMotor.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(959, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Año"
        '
        'DtpAnno
        '
        Me.DtpAnno.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAnno.CustomFormat = ""
        Me.DtpAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpAnno.Location = New System.Drawing.Point(963, 387)
        Me.DtpAnno.Name = "DtpAnno"
        Me.DtpAnno.Size = New System.Drawing.Size(260, 27)
        Me.DtpAnno.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(653, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Serie"
        '
        'TxtSerie
        '
        Me.TxtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSerie.Location = New System.Drawing.Point(657, 241)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(260, 27)
        Me.TxtSerie.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Color"
        '
        'CbxColor
        '
        Me.CbxColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxColor.FormattingEnabled = True
        Me.CbxColor.Items.AddRange(New Object() {"Azul", "Rojo", "Blanco", "Negro", "Amarillo", "Gris"})
        Me.CbxColor.Location = New System.Drawing.Point(38, 388)
        Me.CbxColor.Name = "CbxColor"
        Me.CbxColor.Size = New System.Drawing.Size(260, 28)
        Me.CbxColor.TabIndex = 10
        '
        'CbxEstilo
        '
        Me.CbxEstilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxEstilo.FormattingEnabled = True
        Me.CbxEstilo.Items.AddRange(New Object() {"Sedan", "SUV", "4x4", "Deportivo"})
        Me.CbxEstilo.Location = New System.Drawing.Point(38, 315)
        Me.CbxEstilo.Name = "CbxEstilo"
        Me.CbxEstilo.Size = New System.Drawing.Size(260, 28)
        Me.CbxEstilo.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 20)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Estilo"
        '
        'CbxCapacidad
        '
        Me.CbxCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCapacidad.FormattingEnabled = True
        Me.CbxCapacidad.Location = New System.Drawing.Point(351, 388)
        Me.CbxCapacidad.Name = "CbxCapacidad"
        Me.CbxCapacidad.Size = New System.Drawing.Size(260, 28)
        Me.CbxCapacidad.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(347, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 20)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Capacidad"
        '
        'CbxCombustible
        '
        Me.CbxCombustible.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCombustible.FormattingEnabled = True
        Me.CbxCombustible.Items.AddRange(New Object() {"Gasolina", "Diesel", "Electrico"})
        Me.CbxCombustible.Location = New System.Drawing.Point(657, 388)
        Me.CbxCombustible.Name = "CbxCombustible"
        Me.CbxCombustible.Size = New System.Drawing.Size(260, 28)
        Me.CbxCombustible.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(653, 360)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 20)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Combustible"
        '
        'CbxCategoria
        '
        Me.CbxCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCategoria.FormattingEnabled = True
        Me.CbxCategoria.Items.AddRange(New Object() {"Doble traccion", "Traccion delantera", "Traccion trasera"})
        Me.CbxCategoria.Location = New System.Drawing.Point(347, 313)
        Me.CbxCategoria.Name = "CbxCategoria"
        Me.CbxCategoria.Size = New System.Drawing.Size(260, 28)
        Me.CbxCategoria.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(343, 287)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 20)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Categoria"
        '
        'TxtMarca
        '
        Me.TxtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarca.Location = New System.Drawing.Point(657, 314)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(260, 27)
        Me.TxtMarca.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(653, 287)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 20)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Marca"
        '
        'TxtCilindraje
        '
        Me.TxtCilindraje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCilindraje.Location = New System.Drawing.Point(963, 314)
        Me.TxtCilindraje.Name = "TxtCilindraje"
        Me.TxtCilindraje.Size = New System.Drawing.Size(260, 27)
        Me.TxtCilindraje.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(959, 287)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 20)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Cilindraje"
        '
        'TxtValorFiscal
        '
        Me.TxtValorFiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValorFiscal.Location = New System.Drawing.Point(963, 241)
        Me.TxtValorFiscal.Name = "TxtValorFiscal"
        Me.TxtValorFiscal.Size = New System.Drawing.Size(260, 27)
        Me.TxtValorFiscal.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(959, 214)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 20)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Valor fiscal"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(1059, 465)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(164, 39)
        Me.BtnGuardar.TabIndex = 14
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(874, 465)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(164, 39)
        Me.BtnCancelar.TabIndex = 15
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'ValidaCamposTimer
        '
        Me.ValidaCamposTimer.Enabled = True
        Me.ValidaCamposTimer.Interval = 1000
        '
        'LblFechaActual
        '
        Me.LblFechaActual.AutoSize = True
        Me.LblFechaActual.Location = New System.Drawing.Point(1074, 20)
        Me.LblFechaActual.Name = "LblFechaActual"
        Me.LblFechaActual.Size = New System.Drawing.Size(52, 16)
        Me.LblFechaActual.TabIndex = 45
        Me.LblFechaActual.Text = "FECHA"
        '
        'VehiculoFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 538)
        Me.Controls.Add(Me.LblFechaActual)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtValorFiscal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtCilindraje)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CbxCategoria)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CbxCombustible)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CbxCapacidad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CbxEstilo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbxColor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtSerie)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DtpAnno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNumeroMotor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNumeroChasis)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VehiculoFormulario"
        Me.Text = "Registrar vehiculos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNumeroIdentificacion As TextBox
    Friend WithEvents TxtNumeroPlaca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNumeroChasis As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNumeroMotor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DtpAnno As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CbxColor As ComboBox
    Friend WithEvents CbxEstilo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CbxCapacidad As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CbxCombustible As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CbxCategoria As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtCilindraje As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtValorFiscal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents CbxClase As ComboBox
    Friend WithEvents BtnGenerarPlaca As Button
    Friend WithEvents CbxTipoIdentificacion As ComboBox
    Friend WithEvents BtnBuscarIdentificacion As Button
    Friend WithEvents ValidaCamposTimer As Timer
    Friend WithEvents LblFechaActual As Label
End Class
