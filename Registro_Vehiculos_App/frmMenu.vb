Public Class frmMenu
    Public Sub Execute(usuario As Registro_VehiculoDataSet.UsuarioRow)
        Dim Admin As Boolean = usuario.Tipo_Usuario = "Admin"

        MantenimientoToolStripMenuItem.Visible = Admin
        ReportesToolStripMenuItem.Visible = Admin

        Show()
    End Sub
    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click
        frmMantenimientoUsuario.ShowDialog()
    End Sub

    Private Sub BuscarPropietarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPropietarioToolStripMenuItem.Click
        frmPropietarioVehiculo.ShowDialog()
    End Sub

    Private Sub BuscarVehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarVehiculoToolStripMenuItem.Click
        frmVehiculoLista.ShowDialog()
    End Sub

    Private Sub NuevoRegistroDeVehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoRegistroDeVehiculoToolStripMenuItem.Click
        Dim frmVehiculoFormulario As New frmVehiculoFormulario
        frmVehiculoFormulario.Execute("Nuevo", New Vehiculo)
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub frmMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Refresh()
        frmLogin.Show()
    End Sub
End Class