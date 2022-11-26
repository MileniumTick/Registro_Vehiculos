Public Class Inicio
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim frmVehiculoFormulario As New VehiculoFormulario
        frmVehiculoFormulario.Execute("Nuevo", New Vehiculo)
    End Sub

    Private Sub BtnLista_Click(sender As Object, e As EventArgs) Handles BtnLista.Click
        Dim frmVehiculoLista As New VehiculoVerLista
        frmVehiculoLista.ShowDialog()
    End Sub

    Private Sub BtnVerPropietario_Click(sender As Object, e As EventArgs) 
        Dim frmVehiculoLista As New BuscarPropietario
        frmVehiculoLista.ShowDialog()
    End Sub
End Class