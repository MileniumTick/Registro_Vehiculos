<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.lblClave = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCorreoElec = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Registro_VehiculoDataSet = New Registro_Vehiculos_App.Registro_VehiculoDataSet()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New Registro_Vehiculos_App.Registro_VehiculoDataSetTableAdapters.UsuarioTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_VehiculoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.Location = New System.Drawing.Point(364, 142)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(62, 20)
        Me.lblClave.TabIndex = 28
        Me.lblClave.Text = "Clave:"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(416, 233)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(133, 43)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(263, 233)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(133, 43)
        Me.btnGuardar.TabIndex = 26
        Me.btnGuardar.Text = "Registrar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(263, 175)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(286, 22)
        Me.TxtClave.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 213)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'lblCorreoElec
        '
        Me.lblCorreoElec.AutoSize = True
        Me.lblCorreoElec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoElec.Location = New System.Drawing.Point(352, 25)
        Me.lblCorreoElec.Name = "lblCorreoElec"
        Me.lblCorreoElec.Size = New System.Drawing.Size(80, 20)
        Me.lblCorreoElec.TabIndex = 23
        Me.lblCorreoElec.Text = "Nombre:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(262, 53)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(286, 22)
        Me.TxtNombre.TabIndex = 22
        '
        'Registro_VehiculoDataSet
        '
        Me.Registro_VehiculoDataSet.DataSetName = "Registro_VehiculoDataSet"
        Me.Registro_VehiculoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataSource = Me.Registro_VehiculoDataSet
        Me.UsuarioBindingSource.Position = 0
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Correo electronico:"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(263, 115)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(286, 22)
        Me.TxtCorreo.TabIndex = 29
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 309)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCorreoElec)
        Me.Controls.Add(Me.TxtNombre)
        Me.Name = "frmRegistro"
        Me.Text = "Registro de usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_VehiculoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClave As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCorreoElec As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Registro_VehiculoDataSet As Registro_VehiculoDataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As Registro_VehiculoDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCorreo As TextBox
End Class
