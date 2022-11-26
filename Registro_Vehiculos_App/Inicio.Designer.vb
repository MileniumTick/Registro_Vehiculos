<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnLista = New System.Windows.Forms.Button()
        Me.BtnVerPropietario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(27, 23)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(162, 38)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnLista
        '
        Me.BtnLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLista.Location = New System.Drawing.Point(27, 85)
        Me.BtnLista.Name = "BtnLista"
        Me.BtnLista.Size = New System.Drawing.Size(162, 38)
        Me.BtnLista.TabIndex = 2
        Me.BtnLista.Text = "Lista"
        Me.BtnLista.UseVisualStyleBackColor = True
        '
        'BtnVerPropietario
        '
        Me.BtnVerPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerPropietario.Location = New System.Drawing.Point(27, 148)
        Me.BtnVerPropietario.Name = "BtnVerPropietario"
        Me.BtnVerPropietario.Size = New System.Drawing.Size(162, 38)
        Me.BtnVerPropietario.TabIndex = 3
        Me.BtnVerPropietario.Text = "Propietarios"
        Me.BtnVerPropietario.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 238)
        Me.Controls.Add(Me.BtnVerPropietario)
        Me.Controls.Add(Me.BtnLista)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnLista As Button
    Friend WithEvents BtnVerPropietario As Button
End Class
