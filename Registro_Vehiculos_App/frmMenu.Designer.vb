<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPropietarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarVehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoRegistroDeVehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.CapturaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento Usuario"
        '
        'CapturaToolStripMenuItem
        '
        Me.CapturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPropietarioToolStripMenuItem, Me.BuscarVehiculoToolStripMenuItem, Me.NuevoRegistroDeVehiculoToolStripMenuItem})
        Me.CapturaToolStripMenuItem.Name = "CapturaToolStripMenuItem"
        Me.CapturaToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.CapturaToolStripMenuItem.Text = "Captura y Búsqueda"
        '
        'BuscarPropietarioToolStripMenuItem
        '
        Me.BuscarPropietarioToolStripMenuItem.Name = "BuscarPropietarioToolStripMenuItem"
        Me.BuscarPropietarioToolStripMenuItem.Size = New System.Drawing.Size(293, 26)
        Me.BuscarPropietarioToolStripMenuItem.Text = "Mantenimiento de propietario"
        '
        'BuscarVehiculoToolStripMenuItem
        '
        Me.BuscarVehiculoToolStripMenuItem.Name = "BuscarVehiculoToolStripMenuItem"
        Me.BuscarVehiculoToolStripMenuItem.Size = New System.Drawing.Size(293, 26)
        Me.BuscarVehiculoToolStripMenuItem.Text = "Buscar vehiculo"
        '
        'NuevoRegistroDeVehiculoToolStripMenuItem
        '
        Me.NuevoRegistroDeVehiculoToolStripMenuItem.Name = "NuevoRegistroDeVehiculoToolStripMenuItem"
        Me.NuevoRegistroDeVehiculoToolStripMenuItem.Size = New System.Drawing.Size(293, 26)
        Me.NuevoRegistroDeVehiculoToolStripMenuItem.Text = "Nuevo registro de vehiculo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(174, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(457, 320)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CapturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarPropietarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarVehiculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoRegistroDeVehiculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
End Class
